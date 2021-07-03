namespace Fes

module Exceptions =
    open System
    open System.Net
    open FSharpPlus
    open Fleece.SystemTextJson
    open Fleece.SystemTextJson.Operators
    
    type ElasticsearchExceptions =
    | ResourceAlreadyExistsException
    
    with
        static member OfJson value =
            match value with
            | JString "resource_already_exists_exception" -> Decode.Success ResourceAlreadyExistsException
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong ElasticsearchException value: %s{x}"
            | x -> Decode.Fail.strExpected x
            
    type ElasticsearchRootCauseInfo =
        { Type: ElasticsearchExceptions
          Reason: string }
    with
        static member OfJson value =
            match value with
            | JObject o ->
                monad {
                    let! esType = o .@ "type" 
                    let! reason = o .@ "reason"
                    
                    return { ElasticsearchRootCauseInfo.Type = esType
                             Reason = reason }
                }
            | x -> Decode.Fail.objExpected x
    
    type ElasticsearchException =
        inherit Exception
        val raw: JsonValue
        val esType: ElasticsearchExceptions
        val status: HttpStatusCode
        val reason: string
        val index: string
        val root: ElasticsearchRootCauseInfo[]
        
        private new (raw', index', esType', status', reason', root': ElasticsearchRootCauseInfo[]) = {
            inherit Exception(reason')
            raw = raw'
            esType = esType'
            status = status'
            reason = reason'
            root = root'
            index = index'}

        static member OfJson json =            
            match json with
            | JObject o ->
                match o.TryGetValue "error" with
                | true, JObject error ->
                    monad {
                        let! esType =  error .@ "type" 
                        let! status = o .@ "status" |> Result.bind JsonEnum.fromInt<HttpStatusCode>
                        let! reason = error .@ "reason"
                        let! index = error .@ "index"
                        let! root = error .@ "root_cause" |> Result.bind (Array.map ElasticsearchRootCauseInfo.OfJson >> sequence)
                        
                        return! Decode.Success <| ElasticsearchException(json, index, esType, status, reason, root)
                    }
                | _, _ -> Decode.Fail.parseError (exn <| string json) "Invalid error response."
            | x -> Decode.Fail.objExpected x
            
[<RequireQualifiedAccess>]
module ElasticsearchException =
    open Fleece.SystemTextJson
    
    let ofString s =
        JsonValue.Parse s
        |> Exceptions.ElasticsearchException.OfJson
        |> Result.mapError (sprintf "%O" >> exn)
        
    let withDefaultException de = function
        | Result.Ok esException -> esException :> exn |> Result.Error
        | Result.Error _ -> Result.Error de