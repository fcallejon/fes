namespace Fes

open System
open System.Net

module Exceptions =
    open FSharpPlus
    open Fleece.SystemTextJson
    open Fleece.SystemTextJson.Operators

    type FailedShards =
        { Shard: int
          Index: string
          Node: string
          Reason: ElasticsearchCausedBy }
        static member OfJson json =
            match json with
            | JObject o ->
                monad {
                    let! shard = o .@ "shard"
                    let! index = o .@ "index"
                    let! node = o .@ "node"
                    let! reason = o .@ "reason"

                    return
                        { FailedShards.Shard = shard
                          Index = index
                          Node = node
                          Reason = reason }
                }
            | x -> Decode.Fail.objExpected x

    and ElasticsearchExceptions =
        | ResourceAlreadyExistsException
        | IllegalArgumentException
        | SearchPhaseExecutionException
        | ContentParseException
        | ParsingException
        | ClassCastException
        | IndexNotFoundException
        | MapperParsingException
        | ParseException
        static member OfJson value =
            match value with
            | JString "resource_already_exists_exception" -> Decode.Success ResourceAlreadyExistsException
            | JString "illegal_argument_exception" -> Decode.Success IllegalArgumentException
            | JString "search_phase_execution_exception" -> Decode.Success SearchPhaseExecutionException
            | JString "x_content_parse_exception" -> Decode.Success ContentParseException
            | JString "parsing_exception" -> Decode.Success ParsingException
            | JString "class_cast_exception" -> Decode.Success ClassCastException
            | JString "index_not_found_exception" -> Decode.Success IndexNotFoundException
            | JString "mapper_parsing_exception" -> Decode.Success MapperParsingException
            | JString "parse_exception" -> Decode.Success ParseException
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong ElasticsearchException value: %s{x}"
            | x -> Decode.Fail.strExpected x

    and ElasticsearchCauseByType =
        | NumberFormat
        | ContentParse
        | Parsing
        | Parse
        static member OfJson value =
            match value with
            | JString "number_format_exception" -> Decode.Success NumberFormat
            | JString "x_content_parse_exception" -> Decode.Success ContentParse
            | JString "parsing_exception" -> Decode.Success Parsing
            | JString "parse_exception" -> Decode.Success Parse
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong ElasticsearchCauseByType value: %s{x}"
            | x -> Decode.Fail.strExpected x

    and ElasticsearchRootCauseInfo =
        { Type: ElasticsearchExceptions
          Reason: string }
        static member OfJson value =
            match value with
            | JObject o ->
                monad {
                    let! esType = o .@ "type"
                    let! reason = o .@ "reason"

                    return
                        { ElasticsearchRootCauseInfo.Type = esType
                          Reason = reason }
                }
            | x -> Decode.Fail.objExpected x

    and ElasticsearchCausedBy =
        { Type: ElasticsearchCauseByType
          Reason: string
          Stack: option<string>
          CausedBy: option<ElasticsearchCausedBy> }
        static member OfJson value =
            match value with
            | JObject o ->
                monad {
                    let! esType = o .@ "type"
                    let! reason = o .@ "reason"
                    let! stack = o .@? "stack_trace"
                    let! causedBy = o .@? "caused_by"

                    return
                        { ElasticsearchCausedBy.Type = esType
                          Reason = reason
                          Stack = stack
                          CausedBy = causedBy }
                }
            | x -> Decode.Fail.objExpected x

    and ElasticsearchException =
        inherit Exception
        val raw: JsonValue
        val esType: ElasticsearchExceptions
        val status: HttpStatusCode
        val reason: string
        val cause: option<ElasticsearchCausedBy>
        val stack: option<string>
        val index: option<string>
        val root: ElasticsearchRootCauseInfo []
        val phase: option<string>
        val grouped: option<bool>
        val failedShards: option<FailedShards>

        private new(raw',
                    index',
                    esType',
                    status',
                    reason',
                    root': ElasticsearchRootCauseInfo [],
                    cause',
                    stack',
                    phase',
                    grouped',
                    failedShards') =
            { inherit Exception(reason')
              raw = raw'
              esType = esType'
              status = status'
              reason = reason'
              root = root'
              cause = cause'
              stack = stack'
              index = index'
              phase = phase'
              grouped = grouped'
              failedShards = failedShards' }

        static member OfJson json =
            match json with
            | JObject o ->
                match o.TryGetValue "error" with
                | true, JObject error ->
                    monad {
                        let! esType = error .@ "type"

                        let! status =
                            o .@ "status"
                            |> Result.bind JsonEnum.fromInt<HttpStatusCode>

                        let! reason = error .@ "reason"
                        let! index = error .@? "index"
                        let! cause = error .@? "cause"
                        let! stack = error .@? "stack_trace"

                        let! root =
                            error .@ "root_cause"
                            |> Result.bind (
                                Array.map ElasticsearchRootCauseInfo.OfJson
                                >> sequence
                            )

                        let! phase = o .@? "phase"
                        let! grouped = o .@? "grouped"
                        let! failedShards = o .@? "failed_shards"

                        return!
                            Decode.Success
                            <| ElasticsearchException(
                                json,
                                index,
                                esType,
                                status,
                                reason,
                                root,
                                cause,
                                stack,
                                phase,
                                grouped,
                                failedShards
                            )
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

    let withDefaultException de =
        function
        | Result.Ok esException -> esException :> exn |> Result.Error
        | Result.Error _ -> Result.Error de
