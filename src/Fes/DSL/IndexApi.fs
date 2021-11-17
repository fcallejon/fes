namespace Fes.Contracts.Api

open FSharpPlus
open System
open Fes
open Fes.DSL.Units
open Fes.QueryParams.Builder
open Fes.QueryParams.Builder.Operators
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

type IndexDocumentOpType =
    | Index
    | Create
    override x.ToString() =
        match x with
        | Index -> "index"
        | Create -> "create"

type IndexDocumentRefresh =
    | True
    | False
    | WaitFor
    override x.ToString() =
        match x with
        | True -> "true"
        | False -> "false"
        | WaitFor -> "wait_for"

type IndexDocumentVersionType =
    | External
    | ExternalGreaterThanOrEqual
    override x.ToString() =
        match x with
        | External -> "external"
        | ExternalGreaterThanOrEqual -> "external_gte"

type IndexDocumentWaitForActiveShards =
    | All
    | Custom of int
    override x.ToString() =
        match x with
        | All -> "all"
        | Custom value -> $"%i{value}"

type IndexDocumentQueryParameters =
    { IfSeqNo: option<int>
      IfPrimaryTerm: option<int>
      OpType: option<IndexDocumentOpType>
      Pipeline: option<string>
      Refresh: option<IndexDocumentRefresh>
      Routing: option<string>
      Version: option<int>
      VersionType: option<IndexDocumentVersionType>
      WaitForActiveShards: option<IndexDocumentWaitForActiveShards>
      Timeout: option<TimeoutUnit>
      RequireAlias: option<bool> }
    static member ToQueryParams queryParams =
        qparams [ "if_seq_no" &=? queryParams.IfSeqNo
                  "if_primary_term" &=? queryParams.IfPrimaryTerm
                  "op_type" &=? queryParams.OpType
                  "pipeline" &=? queryParams.Pipeline
                  "refresh" &=? queryParams.Refresh
                  "routing" &=? queryParams.Routing
                  "timeout" &=? queryParams.Timeout
                  "version" &=? queryParams.Version
                  "version_type" &=? queryParams.VersionType
                  "wait_for_active_shards"
                  &=? queryParams.WaitForActiveShards
                  "require_alias" &=? queryParams.RequireAlias ]

type IndexDocumentGetBody = unit -> JsonValue

type IndexDocument<'TDocument> =
    { Document: 'TDocument
      Target: string
      Id: option<string>
      Parameters: option<IndexDocumentQueryParameters> }

    static member inline ToRequest request =
        let query =
            request.Parameters
            |> Option.map toQueryParams
            |> Option.defaultValue (Result.Ok String.Empty)

        let id = request.Id |> Option.defaultValue String.Empty
        let mk query =
            let jsonDoc = toJson request.Document
            $"%s{request.Target}/_doc/%s{id}%s{query}"
            |> Http.Request.fromPath
            |> Http.Request.withMethod Http.Put
            |> (jsonDoc |> string |> Http.Request.withJson)

        mk <!> query

type IndexDocumentResponseResult =
| Created
| Updated
with
    static member OfJson json =
        match json with
        | JString "created" -> Decode.Success Created
        | JString "updated" -> Decode.Success Updated
        | JString x as v -> Decode.Fail.invalidValue v $"Wrong Text Type: %s{x}"
        | x -> Decode.Fail.strExpected x

type IndexDocumentShardsInfoResponse =
    { Total: int
      Successful: int
      Failed: int }
with
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! total = o .@ "total"
                let! successful = o .@ "successful"
                let! failed = o .@ "failed"

                return
                    { IndexDocumentShardsInfoResponse.Total = total
                      Successful = successful 
                      Failed = failed }
            }
        | x -> Decode.Fail.objExpected x

type IndexDocumentResponse =
    { Result: IndexDocumentResponseResult
      Index: string
      Type: string
      Id: string
      Version: int
      SeqNo: int
      PrimaryTerm: int
      ShardsInfo: IndexDocumentShardsInfoResponse }
with
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! result = o .@ "result"
                let! id = o .@ "_id"
                let! index = o .@ "_index"
                let! docType = o .@ "_type"
                let! version = o .@ "_version"
                let! seqNo = o .@ "_seq_no"
                let! primaryTerm = o .@ "_primary_term"
                let! shards = o .@ "_shards"

                return
                    { IndexDocumentResponse.Result = result
                      Id = id 
                      Index = index
                      Type = docType
                      Version = version
                      SeqNo = seqNo
                      PrimaryTerm = primaryTerm
                      ShardsInfo = shards }
            }
        | x -> Decode.Fail.objExpected x