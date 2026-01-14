// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module DocumentOperations =

    type BulkRequest = {
        Index: IndexName
        IncludeSourceOnError: bool option
        ListExecutedPipelines: bool option
        Pipeline: string option
        Refresh: Refresh option
        Routing: Routing option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        RequireAlias: bool option
        RequireDataStream: bool option
    } with
        static member ToRequest(request: BulkRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_bulk"
                let queryParams =
                    [
                        request.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                        request.ListExecutedPipelines |> Option.map (fun v -> "list_executed_pipelines", Fes.Http.toQueryValue v)
                        request.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                        request.RequireDataStream |> Option.map (fun v -> "require_data_stream", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module BulkRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: BulkRequest) : Result<Fes.Http.RequestMsg, exn> =
            BulkRequest.ToRequest request

    type BulkRequestBuilder() =
        member _.Yield(_: unit) : BulkRequest =
            {
                BulkRequest.Index = Unchecked.defaultof<IndexName>
                BulkRequest.IncludeSourceOnError = Option.None
                BulkRequest.ListExecutedPipelines = Option.None
                BulkRequest.Pipeline = Option.None
                BulkRequest.Refresh = Option.None
                BulkRequest.Routing = Option.None
                BulkRequest.Source = Option.None
                BulkRequest.SourceExcludes = Option.None
                BulkRequest.SourceIncludes = Option.None
                BulkRequest.Timeout = Option.None
                BulkRequest.WaitForActiveShards = Option.None
                BulkRequest.RequireAlias = Option.None
                BulkRequest.RequireDataStream = Option.None
            } : BulkRequest

        [<CustomOperation("index")>]
        member _.Index(state: BulkRequest, value: IndexName) =
            { state with BulkRequest.Index = value } : BulkRequest

        [<CustomOperation("include_source_on_error")>]
        member _.IncludeSourceOnError(state: BulkRequest, value: bool) =
            { state with BulkRequest.IncludeSourceOnError = Option.Some value } : BulkRequest

        [<CustomOperation("list_executed_pipelines")>]
        member _.ListExecutedPipelines(state: BulkRequest, value: bool) =
            { state with BulkRequest.ListExecutedPipelines = Option.Some value } : BulkRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: BulkRequest, value: string) =
            { state with BulkRequest.Pipeline = Option.Some value } : BulkRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: BulkRequest, value: Refresh) =
            { state with BulkRequest.Refresh = Option.Some value } : BulkRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: BulkRequest, value: Routing) =
            { state with BulkRequest.Routing = Option.Some value } : BulkRequest

        [<CustomOperation("_source")>]
        member _.Source(state: BulkRequest, value: SearchTypesSourceConfigParam) =
            { state with BulkRequest.Source = Option.Some value } : BulkRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: BulkRequest, value: Fields) =
            { state with BulkRequest.SourceExcludes = Option.Some value } : BulkRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: BulkRequest, value: Fields) =
            { state with BulkRequest.SourceIncludes = Option.Some value } : BulkRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: BulkRequest, value: Duration) =
            { state with BulkRequest.Timeout = Option.Some value } : BulkRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: BulkRequest, value: WaitForActiveShards) =
            { state with BulkRequest.WaitForActiveShards = Option.Some value } : BulkRequest

        [<CustomOperation("require_alias")>]
        member _.RequireAlias(state: BulkRequest, value: bool) =
            { state with BulkRequest.RequireAlias = Option.Some value } : BulkRequest

        [<CustomOperation("require_data_stream")>]
        member _.RequireDataStream(state: BulkRequest, value: bool) =
            { state with BulkRequest.RequireDataStream = Option.Some value } : BulkRequest

    let bulkRequest = BulkRequestBuilder()

    type CreateRequest = {
        Index: IndexName
        Id: Id
        IncludeSourceOnError: bool option
        Pipeline: string option
        Refresh: Refresh option
        RequireAlias: bool option
        RequireDataStream: bool option
        Routing: Routing option
        Timeout: Duration option
        Version: VersionNumber option
        VersionType: VersionType option
        WaitForActiveShards: WaitForActiveShards option
    } with
        static member ToRequest(request: CreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_create/{request.Id}"
                let queryParams =
                    [
                        request.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                        request.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                        request.RequireDataStream |> Option.map (fun v -> "require_data_stream", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module CreateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            CreateRequest.ToRequest request

    type CreateRequestBuilder() =
        member _.Yield(_: unit) : CreateRequest =
            {
                CreateRequest.Index = Unchecked.defaultof<IndexName>
                CreateRequest.Id = Unchecked.defaultof<Id>
                CreateRequest.IncludeSourceOnError = Option.None
                CreateRequest.Pipeline = Option.None
                CreateRequest.Refresh = Option.None
                CreateRequest.RequireAlias = Option.None
                CreateRequest.RequireDataStream = Option.None
                CreateRequest.Routing = Option.None
                CreateRequest.Timeout = Option.None
                CreateRequest.Version = Option.None
                CreateRequest.VersionType = Option.None
                CreateRequest.WaitForActiveShards = Option.None
            } : CreateRequest

        [<CustomOperation("index")>]
        member _.Index(state: CreateRequest, value: IndexName) =
            { state with CreateRequest.Index = value } : CreateRequest

        [<CustomOperation("id")>]
        member _.Id(state: CreateRequest, value: Id) =
            { state with CreateRequest.Id = value } : CreateRequest

        [<CustomOperation("include_source_on_error")>]
        member _.IncludeSourceOnError(state: CreateRequest, value: bool) =
            { state with CreateRequest.IncludeSourceOnError = Option.Some value } : CreateRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: CreateRequest, value: string) =
            { state with CreateRequest.Pipeline = Option.Some value } : CreateRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: CreateRequest, value: Refresh) =
            { state with CreateRequest.Refresh = Option.Some value } : CreateRequest

        [<CustomOperation("require_alias")>]
        member _.RequireAlias(state: CreateRequest, value: bool) =
            { state with CreateRequest.RequireAlias = Option.Some value } : CreateRequest

        [<CustomOperation("require_data_stream")>]
        member _.RequireDataStream(state: CreateRequest, value: bool) =
            { state with CreateRequest.RequireDataStream = Option.Some value } : CreateRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: CreateRequest, value: Routing) =
            { state with CreateRequest.Routing = Option.Some value } : CreateRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CreateRequest, value: Duration) =
            { state with CreateRequest.Timeout = Option.Some value } : CreateRequest

        [<CustomOperation("version")>]
        member _.Version(state: CreateRequest, value: VersionNumber) =
            { state with CreateRequest.Version = Option.Some value } : CreateRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: CreateRequest, value: VersionType) =
            { state with CreateRequest.VersionType = Option.Some value } : CreateRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: CreateRequest, value: WaitForActiveShards) =
            { state with CreateRequest.WaitForActiveShards = Option.Some value } : CreateRequest

    let createRequest = CreateRequestBuilder()

    type GetRequest = {
        Index: IndexName
        Id: Id
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Routing option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceExcludeVectors: bool option
        SourceIncludes: Fields option
        StoredFields: Fields option
        Version: VersionNumber option
        VersionType: VersionType option
    } with
        static member ToRequest(request: GetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_doc/{request.Id}"
                let queryParams =
                    [
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceExcludeVectors |> Option.map (fun v -> "_source_exclude_vectors", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module GetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: GetRequest) : Result<Fes.Http.RequestMsg, exn> =
            GetRequest.ToRequest request

    type GetRequestBuilder() =
        member _.Yield(_: unit) : GetRequest =
            {
                GetRequest.Index = Unchecked.defaultof<IndexName>
                GetRequest.Id = Unchecked.defaultof<Id>
                GetRequest.Preference = Option.None
                GetRequest.Realtime = Option.None
                GetRequest.Refresh = Option.None
                GetRequest.Routing = Option.None
                GetRequest.Source = Option.None
                GetRequest.SourceExcludes = Option.None
                GetRequest.SourceExcludeVectors = Option.None
                GetRequest.SourceIncludes = Option.None
                GetRequest.StoredFields = Option.None
                GetRequest.Version = Option.None
                GetRequest.VersionType = Option.None
            } : GetRequest

        [<CustomOperation("index")>]
        member _.Index(state: GetRequest, value: IndexName) =
            { state with GetRequest.Index = value } : GetRequest

        [<CustomOperation("id")>]
        member _.Id(state: GetRequest, value: Id) =
            { state with GetRequest.Id = value } : GetRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: GetRequest, value: string) =
            { state with GetRequest.Preference = Option.Some value } : GetRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: GetRequest, value: bool) =
            { state with GetRequest.Realtime = Option.Some value } : GetRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: GetRequest, value: bool) =
            { state with GetRequest.Refresh = Option.Some value } : GetRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: GetRequest, value: Routing) =
            { state with GetRequest.Routing = Option.Some value } : GetRequest

        [<CustomOperation("_source")>]
        member _.Source(state: GetRequest, value: SearchTypesSourceConfigParam) =
            { state with GetRequest.Source = Option.Some value } : GetRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: GetRequest, value: Fields) =
            { state with GetRequest.SourceExcludes = Option.Some value } : GetRequest

        [<CustomOperation("_source_exclude_vectors")>]
        member _.SourceExcludeVectors(state: GetRequest, value: bool) =
            { state with GetRequest.SourceExcludeVectors = Option.Some value } : GetRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: GetRequest, value: Fields) =
            { state with GetRequest.SourceIncludes = Option.Some value } : GetRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: GetRequest, value: Fields) =
            { state with GetRequest.StoredFields = Option.Some value } : GetRequest

        [<CustomOperation("version")>]
        member _.Version(state: GetRequest, value: VersionNumber) =
            { state with GetRequest.Version = Option.Some value } : GetRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: GetRequest, value: VersionType) =
            { state with GetRequest.VersionType = Option.Some value } : GetRequest

    let getRequest = GetRequestBuilder()

    type GetResponse = GetGetResult

    type IndexRequest = {
        Index: IndexName
        Id: Id
        IfPrimaryTerm: float option
        IfSeqNo: SequenceNumber option
        IncludeSourceOnError: bool option
        OpType: OpType option
        Pipeline: string option
        Refresh: Refresh option
        Routing: Routing option
        Timeout: Duration option
        Version: VersionNumber option
        VersionType: VersionType option
        WaitForActiveShards: WaitForActiveShards option
        RequireAlias: bool option
        RequireDataStream: bool option
    } with
        static member ToRequest(request: IndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_doc/{request.Id}"
                let queryParams =
                    [
                        request.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        request.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        request.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                        request.OpType |> Option.map (fun v -> "op_type", Fes.Http.toQueryValue v)
                        request.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                        request.RequireDataStream |> Option.map (fun v -> "require_data_stream", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IndexRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndexRequest.ToRequest request

    type IndexRequestBuilder() =
        member _.Yield(_: unit) : IndexRequest =
            {
                IndexRequest.Index = Unchecked.defaultof<IndexName>
                IndexRequest.Id = Unchecked.defaultof<Id>
                IndexRequest.IfPrimaryTerm = Option.None
                IndexRequest.IfSeqNo = Option.None
                IndexRequest.IncludeSourceOnError = Option.None
                IndexRequest.OpType = Option.None
                IndexRequest.Pipeline = Option.None
                IndexRequest.Refresh = Option.None
                IndexRequest.Routing = Option.None
                IndexRequest.Timeout = Option.None
                IndexRequest.Version = Option.None
                IndexRequest.VersionType = Option.None
                IndexRequest.WaitForActiveShards = Option.None
                IndexRequest.RequireAlias = Option.None
                IndexRequest.RequireDataStream = Option.None
            } : IndexRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndexRequest, value: IndexName) =
            { state with IndexRequest.Index = value } : IndexRequest

        [<CustomOperation("id")>]
        member _.Id(state: IndexRequest, value: Id) =
            { state with IndexRequest.Id = value } : IndexRequest

        [<CustomOperation("if_primary_term")>]
        member _.IfPrimaryTerm(state: IndexRequest, value: float) =
            { state with IndexRequest.IfPrimaryTerm = Option.Some value } : IndexRequest

        [<CustomOperation("if_seq_no")>]
        member _.IfSeqNo(state: IndexRequest, value: SequenceNumber) =
            { state with IndexRequest.IfSeqNo = Option.Some value } : IndexRequest

        [<CustomOperation("include_source_on_error")>]
        member _.IncludeSourceOnError(state: IndexRequest, value: bool) =
            { state with IndexRequest.IncludeSourceOnError = Option.Some value } : IndexRequest

        [<CustomOperation("op_type")>]
        member _.OpType(state: IndexRequest, value: OpType) =
            { state with IndexRequest.OpType = Option.Some value } : IndexRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: IndexRequest, value: string) =
            { state with IndexRequest.Pipeline = Option.Some value } : IndexRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: IndexRequest, value: Refresh) =
            { state with IndexRequest.Refresh = Option.Some value } : IndexRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: IndexRequest, value: Routing) =
            { state with IndexRequest.Routing = Option.Some value } : IndexRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndexRequest, value: Duration) =
            { state with IndexRequest.Timeout = Option.Some value } : IndexRequest

        [<CustomOperation("version")>]
        member _.Version(state: IndexRequest, value: VersionNumber) =
            { state with IndexRequest.Version = Option.Some value } : IndexRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: IndexRequest, value: VersionType) =
            { state with IndexRequest.VersionType = Option.Some value } : IndexRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndexRequest, value: WaitForActiveShards) =
            { state with IndexRequest.WaitForActiveShards = Option.Some value } : IndexRequest

        [<CustomOperation("require_alias")>]
        member _.RequireAlias(state: IndexRequest, value: bool) =
            { state with IndexRequest.RequireAlias = Option.Some value } : IndexRequest

        [<CustomOperation("require_data_stream")>]
        member _.RequireDataStream(state: IndexRequest, value: bool) =
            { state with IndexRequest.RequireDataStream = Option.Some value } : IndexRequest

    let indexRequest = IndexRequestBuilder()

    type DeleteRequest = {
        Index: IndexName
        Id: Id
        IfPrimaryTerm: float option
        IfSeqNo: SequenceNumber option
        Refresh: Refresh option
        Routing: Routing option
        Timeout: Duration option
        Version: VersionNumber option
        VersionType: VersionType option
        WaitForActiveShards: WaitForActiveShards option
    } with
        static member ToRequest(request: DeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_doc/{request.Id}"
                let queryParams =
                    [
                        request.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        request.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module DeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: DeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            DeleteRequest.ToRequest request

    type DeleteRequestBuilder() =
        member _.Yield(_: unit) : DeleteRequest =
            {
                DeleteRequest.Index = Unchecked.defaultof<IndexName>
                DeleteRequest.Id = Unchecked.defaultof<Id>
                DeleteRequest.IfPrimaryTerm = Option.None
                DeleteRequest.IfSeqNo = Option.None
                DeleteRequest.Refresh = Option.None
                DeleteRequest.Routing = Option.None
                DeleteRequest.Timeout = Option.None
                DeleteRequest.Version = Option.None
                DeleteRequest.VersionType = Option.None
                DeleteRequest.WaitForActiveShards = Option.None
            } : DeleteRequest

        [<CustomOperation("index")>]
        member _.Index(state: DeleteRequest, value: IndexName) =
            { state with DeleteRequest.Index = value } : DeleteRequest

        [<CustomOperation("id")>]
        member _.Id(state: DeleteRequest, value: Id) =
            { state with DeleteRequest.Id = value } : DeleteRequest

        [<CustomOperation("if_primary_term")>]
        member _.IfPrimaryTerm(state: DeleteRequest, value: float) =
            { state with DeleteRequest.IfPrimaryTerm = Option.Some value } : DeleteRequest

        [<CustomOperation("if_seq_no")>]
        member _.IfSeqNo(state: DeleteRequest, value: SequenceNumber) =
            { state with DeleteRequest.IfSeqNo = Option.Some value } : DeleteRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: DeleteRequest, value: Refresh) =
            { state with DeleteRequest.Refresh = Option.Some value } : DeleteRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: DeleteRequest, value: Routing) =
            { state with DeleteRequest.Routing = Option.Some value } : DeleteRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteRequest, value: Duration) =
            { state with DeleteRequest.Timeout = Option.Some value } : DeleteRequest

        [<CustomOperation("version")>]
        member _.Version(state: DeleteRequest, value: VersionNumber) =
            { state with DeleteRequest.Version = Option.Some value } : DeleteRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: DeleteRequest, value: VersionType) =
            { state with DeleteRequest.VersionType = Option.Some value } : DeleteRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: DeleteRequest, value: WaitForActiveShards) =
            { state with DeleteRequest.WaitForActiveShards = Option.Some value } : DeleteRequest

    let deleteRequest = DeleteRequestBuilder()

    type DeleteResponse = WriteResponseBase

    type ExistsRequest = {
        Index: IndexName
        Id: Id
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Routing option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        StoredFields: Fields option
        Version: VersionNumber option
        VersionType: VersionType option
    } with
        static member ToRequest(request: ExistsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_doc/{request.Id}"
                let queryParams =
                    [
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    module ExistsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ExistsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ExistsRequest.ToRequest request

    type ExistsRequestBuilder() =
        member _.Yield(_: unit) : ExistsRequest =
            {
                ExistsRequest.Index = Unchecked.defaultof<IndexName>
                ExistsRequest.Id = Unchecked.defaultof<Id>
                ExistsRequest.Preference = Option.None
                ExistsRequest.Realtime = Option.None
                ExistsRequest.Refresh = Option.None
                ExistsRequest.Routing = Option.None
                ExistsRequest.Source = Option.None
                ExistsRequest.SourceExcludes = Option.None
                ExistsRequest.SourceIncludes = Option.None
                ExistsRequest.StoredFields = Option.None
                ExistsRequest.Version = Option.None
                ExistsRequest.VersionType = Option.None
            } : ExistsRequest

        [<CustomOperation("index")>]
        member _.Index(state: ExistsRequest, value: IndexName) =
            { state with ExistsRequest.Index = value } : ExistsRequest

        [<CustomOperation("id")>]
        member _.Id(state: ExistsRequest, value: Id) =
            { state with ExistsRequest.Id = value } : ExistsRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: ExistsRequest, value: string) =
            { state with ExistsRequest.Preference = Option.Some value } : ExistsRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: ExistsRequest, value: bool) =
            { state with ExistsRequest.Realtime = Option.Some value } : ExistsRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ExistsRequest, value: bool) =
            { state with ExistsRequest.Refresh = Option.Some value } : ExistsRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: ExistsRequest, value: Routing) =
            { state with ExistsRequest.Routing = Option.Some value } : ExistsRequest

        [<CustomOperation("_source")>]
        member _.Source(state: ExistsRequest, value: SearchTypesSourceConfigParam) =
            { state with ExistsRequest.Source = Option.Some value } : ExistsRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: ExistsRequest, value: Fields) =
            { state with ExistsRequest.SourceExcludes = Option.Some value } : ExistsRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: ExistsRequest, value: Fields) =
            { state with ExistsRequest.SourceIncludes = Option.Some value } : ExistsRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: ExistsRequest, value: Fields) =
            { state with ExistsRequest.StoredFields = Option.Some value } : ExistsRequest

        [<CustomOperation("version")>]
        member _.Version(state: ExistsRequest, value: VersionNumber) =
            { state with ExistsRequest.Version = Option.Some value } : ExistsRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: ExistsRequest, value: VersionType) =
            { state with ExistsRequest.VersionType = Option.Some value } : ExistsRequest

    let existsRequest = ExistsRequestBuilder()

    type DeleteByQueryRequest = {
        Index: Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        Conflicts: Conflicts option
        DefaultOperator: QueryDslOperator option
        Df: string option
        ExpandWildcards: ExpandWildcards option
        From: float option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxDocs: float option
        Preference: string option
        Refresh: bool option
        RequestCache: bool option
        RequestsPerSecond: float option
        Routing: Routing option
        Q: string option
        Scroll: Duration option
        ScrollSize: float option
        SearchTimeout: Duration option
        SearchType: SearchType option
        Slices: Slices option
        Sort: string array option
        Stats: string array option
        TerminateAfter: float option
        Timeout: Duration option
        Version: bool option
        WaitForActiveShards: WaitForActiveShards option
        WaitForCompletion: bool option
        [<JsonPropertyName("max_docs")>]
        MaxDocs2: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("slice")>]
        Slice: SlicedScroll option
        [<JsonPropertyName("sort")>]
        Sort2: Sort option
    } with
        static member ToRequest(request: DeleteByQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_delete_by_query"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                        request.Conflicts |> Option.map (fun v -> "conflicts", Fes.Http.toQueryValue v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                        request.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                        request.MaxDocs |> Option.map (fun v -> "max_docs", Fes.Http.toQueryValue v)
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                        request.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                        request.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                        request.ScrollSize |> Option.map (fun v -> "scroll_size", Fes.Http.toQueryValue v)
                        request.SearchTimeout |> Option.map (fun v -> "search_timeout", Fes.Http.toQueryValue v)
                        request.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                        request.Slices |> Option.map (fun v -> "slices", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.Stats |> Option.map (fun v -> "stats", Fes.Http.toQueryValue v)
                        request.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``max_docs`` = request.MaxDocs2; ``query`` = request.Query; ``slice`` = request.Slice; ``sort`` = request.Sort2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module DeleteByQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: DeleteByQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            DeleteByQueryRequest.ToRequest request

    type DeleteByQueryRequestBuilder() =
        member _.Yield(_: unit) : DeleteByQueryRequest =
            {
                DeleteByQueryRequest.Index = Unchecked.defaultof<Indices>
                DeleteByQueryRequest.AllowNoIndices = Option.None
                DeleteByQueryRequest.Analyzer = Option.None
                DeleteByQueryRequest.AnalyzeWildcard = Option.None
                DeleteByQueryRequest.Conflicts = Option.None
                DeleteByQueryRequest.DefaultOperator = Option.None
                DeleteByQueryRequest.Df = Option.None
                DeleteByQueryRequest.ExpandWildcards = Option.None
                DeleteByQueryRequest.From = Option.None
                DeleteByQueryRequest.IgnoreUnavailable = Option.None
                DeleteByQueryRequest.Lenient = Option.None
                DeleteByQueryRequest.MaxDocs = Option.None
                DeleteByQueryRequest.Preference = Option.None
                DeleteByQueryRequest.Refresh = Option.None
                DeleteByQueryRequest.RequestCache = Option.None
                DeleteByQueryRequest.RequestsPerSecond = Option.None
                DeleteByQueryRequest.Routing = Option.None
                DeleteByQueryRequest.Q = Option.None
                DeleteByQueryRequest.Scroll = Option.None
                DeleteByQueryRequest.ScrollSize = Option.None
                DeleteByQueryRequest.SearchTimeout = Option.None
                DeleteByQueryRequest.SearchType = Option.None
                DeleteByQueryRequest.Slices = Option.None
                DeleteByQueryRequest.Sort = Option.None
                DeleteByQueryRequest.Stats = Option.None
                DeleteByQueryRequest.TerminateAfter = Option.None
                DeleteByQueryRequest.Timeout = Option.None
                DeleteByQueryRequest.Version = Option.None
                DeleteByQueryRequest.WaitForActiveShards = Option.None
                DeleteByQueryRequest.WaitForCompletion = Option.None
                DeleteByQueryRequest.MaxDocs2 = Option.None
                DeleteByQueryRequest.Query = Option.None
                DeleteByQueryRequest.Slice = Option.None
                DeleteByQueryRequest.Sort2 = Option.None
            } : DeleteByQueryRequest

        [<CustomOperation("index")>]
        member _.Index(state: DeleteByQueryRequest, value: Indices) =
            { state with DeleteByQueryRequest.Index = value } : DeleteByQueryRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.AllowNoIndices = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: DeleteByQueryRequest, value: string) =
            { state with DeleteByQueryRequest.Analyzer = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.AnalyzeWildcard = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: DeleteByQueryRequest, value: Conflicts) =
            { state with DeleteByQueryRequest.Conflicts = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: DeleteByQueryRequest, value: QueryDslOperator) =
            { state with DeleteByQueryRequest.DefaultOperator = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("df")>]
        member _.Df(state: DeleteByQueryRequest, value: string) =
            { state with DeleteByQueryRequest.Df = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: DeleteByQueryRequest, value: ExpandWildcards) =
            { state with DeleteByQueryRequest.ExpandWildcards = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("from")>]
        member _.From(state: DeleteByQueryRequest, value: float) =
            { state with DeleteByQueryRequest.From = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.IgnoreUnavailable = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.Lenient = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("max_docs")>]
        member _.MaxDocs(state: DeleteByQueryRequest, value: float) =
            { state with DeleteByQueryRequest.MaxDocs = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: DeleteByQueryRequest, value: string) =
            { state with DeleteByQueryRequest.Preference = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.Refresh = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("request_cache")>]
        member _.RequestCache(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.RequestCache = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: DeleteByQueryRequest, value: float) =
            { state with DeleteByQueryRequest.RequestsPerSecond = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: DeleteByQueryRequest, value: Routing) =
            { state with DeleteByQueryRequest.Routing = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("q")>]
        member _.Q(state: DeleteByQueryRequest, value: string) =
            { state with DeleteByQueryRequest.Q = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: DeleteByQueryRequest, value: Duration) =
            { state with DeleteByQueryRequest.Scroll = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("scroll_size")>]
        member _.ScrollSize(state: DeleteByQueryRequest, value: float) =
            { state with DeleteByQueryRequest.ScrollSize = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("search_timeout")>]
        member _.SearchTimeout(state: DeleteByQueryRequest, value: Duration) =
            { state with DeleteByQueryRequest.SearchTimeout = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: DeleteByQueryRequest, value: SearchType) =
            { state with DeleteByQueryRequest.SearchType = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("slices")>]
        member _.Slices(state: DeleteByQueryRequest, value: Slices) =
            { state with DeleteByQueryRequest.Slices = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: DeleteByQueryRequest, value: string array) =
            { state with DeleteByQueryRequest.Sort = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("stats")>]
        member _.Stats(state: DeleteByQueryRequest, value: string array) =
            { state with DeleteByQueryRequest.Stats = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("terminate_after")>]
        member _.TerminateAfter(state: DeleteByQueryRequest, value: float) =
            { state with DeleteByQueryRequest.TerminateAfter = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteByQueryRequest, value: Duration) =
            { state with DeleteByQueryRequest.Timeout = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("version")>]
        member _.Version(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.Version = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: DeleteByQueryRequest, value: WaitForActiveShards) =
            { state with DeleteByQueryRequest.WaitForActiveShards = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: DeleteByQueryRequest, value: bool) =
            { state with DeleteByQueryRequest.WaitForCompletion = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("max_docs2")>]
        member _.MaxDocs2(state: DeleteByQueryRequest, value: float) =
            { state with DeleteByQueryRequest.MaxDocs2 = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("query")>]
        member _.Query(state: DeleteByQueryRequest, value: QueryDslQueryContainer) =
            { state with DeleteByQueryRequest.Query = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("slice")>]
        member _.Slice(state: DeleteByQueryRequest, value: SlicedScroll) =
            { state with DeleteByQueryRequest.Slice = Option.Some value } : DeleteByQueryRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: DeleteByQueryRequest, value: Sort) =
            { state with DeleteByQueryRequest.Sort2 = Option.Some value } : DeleteByQueryRequest

    let deleteByQueryRequest = DeleteByQueryRequestBuilder()

    type DeleteByQueryResponse = {
        [<JsonPropertyName("batches")>]
        Batches: float option
        [<JsonPropertyName("deleted")>]
        Deleted: float option
        [<JsonPropertyName("failures")>]
        Failures: BulkIndexByScrollFailure array option
        [<JsonPropertyName("noops")>]
        Noops: float option
        [<JsonPropertyName("requests_per_second")>]
        RequestsPerSecond: float option
        [<JsonPropertyName("retries")>]
        Retries: Retries option
        [<JsonPropertyName("slice_id")>]
        SliceId: float option
        [<JsonPropertyName("task")>]
        Task: TaskId option
        [<JsonPropertyName("throttled")>]
        Throttled: Duration option
        [<JsonPropertyName("throttled_millis")>]
        ThrottledMillis: DurationValueUnitMillis option
        [<JsonPropertyName("throttled_until")>]
        ThrottledUntil: Duration option
        [<JsonPropertyName("throttled_until_millis")>]
        ThrottledUntilMillis: DurationValueUnitMillis option
        [<JsonPropertyName("timed_out")>]
        TimedOut: bool option
        [<JsonPropertyName("took")>]
        Took: DurationValueUnitMillis option
        [<JsonPropertyName("total")>]
        Total: float option
        [<JsonPropertyName("version_conflicts")>]
        VersionConflicts: float option
    }

    type DeleteByQueryRethrottleRequest = {
        TaskId: TaskId
        RequestsPerSecond: float
    } with
        static member ToRequest(request: DeleteByQueryRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_delete_by_query/{request.TaskId}/_rethrottle"
                let queryParams =
                    [
                        Some ("requests_per_second", Fes.Http.toQueryValue request.RequestsPerSecond)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module DeleteByQueryRethrottleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: DeleteByQueryRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            DeleteByQueryRethrottleRequest.ToRequest request

    type DeleteByQueryRethrottleRequestBuilder() =
        member _.Yield(_: unit) : DeleteByQueryRethrottleRequest =
            {
                DeleteByQueryRethrottleRequest.TaskId = Unchecked.defaultof<TaskId>
                DeleteByQueryRethrottleRequest.RequestsPerSecond = 0.0
            } : DeleteByQueryRethrottleRequest

        [<CustomOperation("task_id")>]
        member _.TaskId(state: DeleteByQueryRethrottleRequest, value: TaskId) =
            { state with DeleteByQueryRethrottleRequest.TaskId = value } : DeleteByQueryRethrottleRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: DeleteByQueryRethrottleRequest, value: float) =
            { state with DeleteByQueryRethrottleRequest.RequestsPerSecond = value } : DeleteByQueryRethrottleRequest

    let deleteByQueryRethrottleRequest = DeleteByQueryRethrottleRequestBuilder()

    type DeleteByQueryRethrottleResponse = TypesTaskListResponseBase

    type GetSourceRequest = {
        Index: IndexName
        Id: Id
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Routing option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        Version: VersionNumber option
        VersionType: VersionType option
    } with
        static member ToRequest(request: GetSourceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_source/{request.Id}"
                let queryParams =
                    [
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module GetSourceRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: GetSourceRequest) : Result<Fes.Http.RequestMsg, exn> =
            GetSourceRequest.ToRequest request

    type GetSourceRequestBuilder() =
        member _.Yield(_: unit) : GetSourceRequest =
            {
                GetSourceRequest.Index = Unchecked.defaultof<IndexName>
                GetSourceRequest.Id = Unchecked.defaultof<Id>
                GetSourceRequest.Preference = Option.None
                GetSourceRequest.Realtime = Option.None
                GetSourceRequest.Refresh = Option.None
                GetSourceRequest.Routing = Option.None
                GetSourceRequest.Source = Option.None
                GetSourceRequest.SourceExcludes = Option.None
                GetSourceRequest.SourceIncludes = Option.None
                GetSourceRequest.Version = Option.None
                GetSourceRequest.VersionType = Option.None
            } : GetSourceRequest

        [<CustomOperation("index")>]
        member _.Index(state: GetSourceRequest, value: IndexName) =
            { state with GetSourceRequest.Index = value } : GetSourceRequest

        [<CustomOperation("id")>]
        member _.Id(state: GetSourceRequest, value: Id) =
            { state with GetSourceRequest.Id = value } : GetSourceRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: GetSourceRequest, value: string) =
            { state with GetSourceRequest.Preference = Option.Some value } : GetSourceRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: GetSourceRequest, value: bool) =
            { state with GetSourceRequest.Realtime = Option.Some value } : GetSourceRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: GetSourceRequest, value: bool) =
            { state with GetSourceRequest.Refresh = Option.Some value } : GetSourceRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: GetSourceRequest, value: Routing) =
            { state with GetSourceRequest.Routing = Option.Some value } : GetSourceRequest

        [<CustomOperation("_source")>]
        member _.Source(state: GetSourceRequest, value: SearchTypesSourceConfigParam) =
            { state with GetSourceRequest.Source = Option.Some value } : GetSourceRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: GetSourceRequest, value: Fields) =
            { state with GetSourceRequest.SourceExcludes = Option.Some value } : GetSourceRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: GetSourceRequest, value: Fields) =
            { state with GetSourceRequest.SourceIncludes = Option.Some value } : GetSourceRequest

        [<CustomOperation("version")>]
        member _.Version(state: GetSourceRequest, value: VersionNumber) =
            { state with GetSourceRequest.Version = Option.Some value } : GetSourceRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: GetSourceRequest, value: VersionType) =
            { state with GetSourceRequest.VersionType = Option.Some value } : GetSourceRequest

    let getSourceRequest = GetSourceRequestBuilder()

    type ExistsSourceRequest = {
        Index: IndexName
        Id: Id
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Routing option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        Version: VersionNumber option
        VersionType: VersionType option
    } with
        static member ToRequest(request: ExistsSourceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_source/{request.Id}"
                let queryParams =
                    [
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    module ExistsSourceRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ExistsSourceRequest) : Result<Fes.Http.RequestMsg, exn> =
            ExistsSourceRequest.ToRequest request

    type ExistsSourceRequestBuilder() =
        member _.Yield(_: unit) : ExistsSourceRequest =
            {
                ExistsSourceRequest.Index = Unchecked.defaultof<IndexName>
                ExistsSourceRequest.Id = Unchecked.defaultof<Id>
                ExistsSourceRequest.Preference = Option.None
                ExistsSourceRequest.Realtime = Option.None
                ExistsSourceRequest.Refresh = Option.None
                ExistsSourceRequest.Routing = Option.None
                ExistsSourceRequest.Source = Option.None
                ExistsSourceRequest.SourceExcludes = Option.None
                ExistsSourceRequest.SourceIncludes = Option.None
                ExistsSourceRequest.Version = Option.None
                ExistsSourceRequest.VersionType = Option.None
            } : ExistsSourceRequest

        [<CustomOperation("index")>]
        member _.Index(state: ExistsSourceRequest, value: IndexName) =
            { state with ExistsSourceRequest.Index = value } : ExistsSourceRequest

        [<CustomOperation("id")>]
        member _.Id(state: ExistsSourceRequest, value: Id) =
            { state with ExistsSourceRequest.Id = value } : ExistsSourceRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: ExistsSourceRequest, value: string) =
            { state with ExistsSourceRequest.Preference = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: ExistsSourceRequest, value: bool) =
            { state with ExistsSourceRequest.Realtime = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ExistsSourceRequest, value: bool) =
            { state with ExistsSourceRequest.Refresh = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: ExistsSourceRequest, value: Routing) =
            { state with ExistsSourceRequest.Routing = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("_source")>]
        member _.Source(state: ExistsSourceRequest, value: SearchTypesSourceConfigParam) =
            { state with ExistsSourceRequest.Source = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: ExistsSourceRequest, value: Fields) =
            { state with ExistsSourceRequest.SourceExcludes = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: ExistsSourceRequest, value: Fields) =
            { state with ExistsSourceRequest.SourceIncludes = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("version")>]
        member _.Version(state: ExistsSourceRequest, value: VersionNumber) =
            { state with ExistsSourceRequest.Version = Option.Some value } : ExistsSourceRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: ExistsSourceRequest, value: VersionType) =
            { state with ExistsSourceRequest.VersionType = Option.Some value } : ExistsSourceRequest

    let existsSourceRequest = ExistsSourceRequestBuilder()

    type MgetRequest = {
        Index: IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Routing option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        StoredFields: Fields option
        [<JsonPropertyName("docs")>]
        Docs: MgetOperation array option
        [<JsonPropertyName("ids")>]
        Ids: Ids option
    } with
        static member ToRequest(request: MgetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_mget"
                let queryParams =
                    [
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``docs`` = request.Docs; ``ids`` = request.Ids |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MgetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MgetRequest) : Result<Fes.Http.RequestMsg, exn> =
            MgetRequest.ToRequest request

    type MgetRequestBuilder() =
        member _.Yield(_: unit) : MgetRequest =
            {
                MgetRequest.Index = Unchecked.defaultof<IndexName>
                MgetRequest.Preference = Option.None
                MgetRequest.Realtime = Option.None
                MgetRequest.Refresh = Option.None
                MgetRequest.Routing = Option.None
                MgetRequest.Source = Option.None
                MgetRequest.SourceExcludes = Option.None
                MgetRequest.SourceIncludes = Option.None
                MgetRequest.StoredFields = Option.None
                MgetRequest.Docs = Option.None
                MgetRequest.Ids = Option.None
            } : MgetRequest

        [<CustomOperation("index")>]
        member _.Index(state: MgetRequest, value: IndexName) =
            { state with MgetRequest.Index = value } : MgetRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: MgetRequest, value: string) =
            { state with MgetRequest.Preference = Option.Some value } : MgetRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: MgetRequest, value: bool) =
            { state with MgetRequest.Realtime = Option.Some value } : MgetRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: MgetRequest, value: bool) =
            { state with MgetRequest.Refresh = Option.Some value } : MgetRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: MgetRequest, value: Routing) =
            { state with MgetRequest.Routing = Option.Some value } : MgetRequest

        [<CustomOperation("_source")>]
        member _.Source(state: MgetRequest, value: SearchTypesSourceConfigParam) =
            { state with MgetRequest.Source = Option.Some value } : MgetRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: MgetRequest, value: Fields) =
            { state with MgetRequest.SourceExcludes = Option.Some value } : MgetRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: MgetRequest, value: Fields) =
            { state with MgetRequest.SourceIncludes = Option.Some value } : MgetRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: MgetRequest, value: Fields) =
            { state with MgetRequest.StoredFields = Option.Some value } : MgetRequest

        [<CustomOperation("docs")>]
        member _.Docs(state: MgetRequest, value: MgetOperation array) =
            { state with MgetRequest.Docs = Option.Some value } : MgetRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: MgetRequest, value: Ids) =
            { state with MgetRequest.Ids = Option.Some value } : MgetRequest

    let mgetRequest = MgetRequestBuilder()

    type MtermvectorsRequest = {
        Index: IndexName
        Ids: Id array option
        Fields: Fields option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        Preference: string option
        Realtime: bool option
        Routing: Routing option
        TermStatistics: bool option
        Version: VersionNumber option
        VersionType: VersionType option
        [<JsonPropertyName("docs")>]
        Docs: MtermvectorsOperation array option
        [<JsonPropertyName("ids")>]
        Ids2: Id array option
    } with
        static member ToRequest(request: MtermvectorsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_mtermvectors"
                let queryParams =
                    [
                        request.Ids |> Option.map (fun v -> "ids", Fes.Http.toQueryValue v)
                        request.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        request.FieldStatistics |> Option.map (fun v -> "field_statistics", Fes.Http.toQueryValue v)
                        request.Offsets |> Option.map (fun v -> "offsets", Fes.Http.toQueryValue v)
                        request.Payloads |> Option.map (fun v -> "payloads", Fes.Http.toQueryValue v)
                        request.Positions |> Option.map (fun v -> "positions", Fes.Http.toQueryValue v)
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.TermStatistics |> Option.map (fun v -> "term_statistics", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``docs`` = request.Docs; ``ids`` = request.Ids2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MtermvectorsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MtermvectorsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MtermvectorsRequest.ToRequest request

    type MtermvectorsRequestBuilder() =
        member _.Yield(_: unit) : MtermvectorsRequest =
            {
                MtermvectorsRequest.Index = Unchecked.defaultof<IndexName>
                MtermvectorsRequest.Ids = Option.None
                MtermvectorsRequest.Fields = Option.None
                MtermvectorsRequest.FieldStatistics = Option.None
                MtermvectorsRequest.Offsets = Option.None
                MtermvectorsRequest.Payloads = Option.None
                MtermvectorsRequest.Positions = Option.None
                MtermvectorsRequest.Preference = Option.None
                MtermvectorsRequest.Realtime = Option.None
                MtermvectorsRequest.Routing = Option.None
                MtermvectorsRequest.TermStatistics = Option.None
                MtermvectorsRequest.Version = Option.None
                MtermvectorsRequest.VersionType = Option.None
                MtermvectorsRequest.Docs = Option.None
                MtermvectorsRequest.Ids2 = Option.None
            } : MtermvectorsRequest

        [<CustomOperation("index")>]
        member _.Index(state: MtermvectorsRequest, value: IndexName) =
            { state with MtermvectorsRequest.Index = value } : MtermvectorsRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: MtermvectorsRequest, value: Id array) =
            { state with MtermvectorsRequest.Ids = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: MtermvectorsRequest, value: Fields) =
            { state with MtermvectorsRequest.Fields = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("field_statistics")>]
        member _.FieldStatistics(state: MtermvectorsRequest, value: bool) =
            { state with MtermvectorsRequest.FieldStatistics = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("offsets")>]
        member _.Offsets(state: MtermvectorsRequest, value: bool) =
            { state with MtermvectorsRequest.Offsets = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("payloads")>]
        member _.Payloads(state: MtermvectorsRequest, value: bool) =
            { state with MtermvectorsRequest.Payloads = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("positions")>]
        member _.Positions(state: MtermvectorsRequest, value: bool) =
            { state with MtermvectorsRequest.Positions = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: MtermvectorsRequest, value: string) =
            { state with MtermvectorsRequest.Preference = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: MtermvectorsRequest, value: bool) =
            { state with MtermvectorsRequest.Realtime = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: MtermvectorsRequest, value: Routing) =
            { state with MtermvectorsRequest.Routing = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("term_statistics")>]
        member _.TermStatistics(state: MtermvectorsRequest, value: bool) =
            { state with MtermvectorsRequest.TermStatistics = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("version")>]
        member _.Version(state: MtermvectorsRequest, value: VersionNumber) =
            { state with MtermvectorsRequest.Version = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: MtermvectorsRequest, value: VersionType) =
            { state with MtermvectorsRequest.VersionType = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("docs")>]
        member _.Docs(state: MtermvectorsRequest, value: MtermvectorsOperation array) =
            { state with MtermvectorsRequest.Docs = Option.Some value } : MtermvectorsRequest

        [<CustomOperation("ids2")>]
        member _.Ids2(state: MtermvectorsRequest, value: Id array) =
            { state with MtermvectorsRequest.Ids2 = Option.Some value } : MtermvectorsRequest

    let mtermvectorsRequest = MtermvectorsRequestBuilder()

    type ReindexRequest = {
        Refresh: bool option
        RequestsPerSecond: float option
        Scroll: Duration option
        Slices: Slices option
        MaxDocs: float option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        WaitForCompletion: bool option
        RequireAlias: bool option
        [<JsonPropertyName("conflicts")>]
        Conflicts: Conflicts option
        [<JsonPropertyName("dest")>]
        Dest: ReindexDestination
        [<JsonPropertyName("max_docs")>]
        MaxDocs2: float option
        [<JsonPropertyName("script")>]
        Script: Script option
        [<JsonPropertyName("source")>]
        Source: ReindexSource
    } with
        static member ToRequest(request: ReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_reindex"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                        request.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                        request.Slices |> Option.map (fun v -> "slices", Fes.Http.toQueryValue v)
                        request.MaxDocs |> Option.map (fun v -> "max_docs", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                        request.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``conflicts`` = request.Conflicts; ``dest`` = request.Dest; ``max_docs`` = request.MaxDocs2; ``script`` = request.Script; ``source`` = request.Source |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ReindexRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            ReindexRequest.ToRequest request

    type ReindexRequestBuilder() =
        member _.Yield(_: unit) : ReindexRequest =
            {
                ReindexRequest.Refresh = Option.None
                ReindexRequest.RequestsPerSecond = Option.None
                ReindexRequest.Scroll = Option.None
                ReindexRequest.Slices = Option.None
                ReindexRequest.MaxDocs = Option.None
                ReindexRequest.Timeout = Option.None
                ReindexRequest.WaitForActiveShards = Option.None
                ReindexRequest.WaitForCompletion = Option.None
                ReindexRequest.RequireAlias = Option.None
                ReindexRequest.Conflicts = Option.None
                ReindexRequest.Dest = Unchecked.defaultof<ReindexDestination>
                ReindexRequest.MaxDocs2 = Option.None
                ReindexRequest.Script = Option.None
                ReindexRequest.Source = Unchecked.defaultof<ReindexSource>
            } : ReindexRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ReindexRequest, value: bool) =
            { state with ReindexRequest.Refresh = Option.Some value } : ReindexRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: ReindexRequest, value: float) =
            { state with ReindexRequest.RequestsPerSecond = Option.Some value } : ReindexRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ReindexRequest, value: Duration) =
            { state with ReindexRequest.Scroll = Option.Some value } : ReindexRequest

        [<CustomOperation("slices")>]
        member _.Slices(state: ReindexRequest, value: Slices) =
            { state with ReindexRequest.Slices = Option.Some value } : ReindexRequest

        [<CustomOperation("max_docs")>]
        member _.MaxDocs(state: ReindexRequest, value: float) =
            { state with ReindexRequest.MaxDocs = Option.Some value } : ReindexRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ReindexRequest, value: Duration) =
            { state with ReindexRequest.Timeout = Option.Some value } : ReindexRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: ReindexRequest, value: WaitForActiveShards) =
            { state with ReindexRequest.WaitForActiveShards = Option.Some value } : ReindexRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: ReindexRequest, value: bool) =
            { state with ReindexRequest.WaitForCompletion = Option.Some value } : ReindexRequest

        [<CustomOperation("require_alias")>]
        member _.RequireAlias(state: ReindexRequest, value: bool) =
            { state with ReindexRequest.RequireAlias = Option.Some value } : ReindexRequest

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: ReindexRequest, value: Conflicts) =
            { state with ReindexRequest.Conflicts = Option.Some value } : ReindexRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: ReindexRequest, value: ReindexDestination) =
            { state with ReindexRequest.Dest = value } : ReindexRequest

        [<CustomOperation("max_docs2")>]
        member _.MaxDocs2(state: ReindexRequest, value: float) =
            { state with ReindexRequest.MaxDocs2 = Option.Some value } : ReindexRequest

        [<CustomOperation("script")>]
        member _.Script(state: ReindexRequest, value: Script) =
            { state with ReindexRequest.Script = Option.Some value } : ReindexRequest

        [<CustomOperation("source")>]
        member _.Source(state: ReindexRequest, value: ReindexSource) =
            { state with ReindexRequest.Source = value } : ReindexRequest

    let reindexRequest = ReindexRequestBuilder()

    type ReindexResponse = {
        [<JsonPropertyName("batches")>]
        Batches: float option
        [<JsonPropertyName("created")>]
        Created: float option
        [<JsonPropertyName("deleted")>]
        Deleted: float option
        [<JsonPropertyName("failures")>]
        Failures: BulkIndexByScrollFailure array option
        [<JsonPropertyName("noops")>]
        Noops: float option
        [<JsonPropertyName("retries")>]
        Retries: Retries option
        [<JsonPropertyName("requests_per_second")>]
        RequestsPerSecond: float option
        [<JsonPropertyName("slice_id")>]
        SliceId: float option
        [<JsonPropertyName("task")>]
        Task: TaskId option
        [<JsonPropertyName("throttled_millis")>]
        ThrottledMillis: EpochTimeUnitMillis option
        [<JsonPropertyName("throttled_until_millis")>]
        ThrottledUntilMillis: EpochTimeUnitMillis option
        [<JsonPropertyName("timed_out")>]
        TimedOut: bool option
        [<JsonPropertyName("took")>]
        Took: DurationValueUnitMillis option
        [<JsonPropertyName("total")>]
        Total: float option
        [<JsonPropertyName("updated")>]
        Updated: float option
        [<JsonPropertyName("version_conflicts")>]
        VersionConflicts: float option
    }

    type ReindexRethrottleRequest = {
        TaskId: Id
        RequestsPerSecond: float
    } with
        static member ToRequest(request: ReindexRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_reindex/{request.TaskId}/_rethrottle"
                let queryParams =
                    [
                        Some ("requests_per_second", Fes.Http.toQueryValue request.RequestsPerSecond)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module ReindexRethrottleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ReindexRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            ReindexRethrottleRequest.ToRequest request

    type ReindexRethrottleRequestBuilder() =
        member _.Yield(_: unit) : ReindexRethrottleRequest =
            {
                ReindexRethrottleRequest.TaskId = Unchecked.defaultof<Id>
                ReindexRethrottleRequest.RequestsPerSecond = 0.0
            } : ReindexRethrottleRequest

        [<CustomOperation("task_id")>]
        member _.TaskId(state: ReindexRethrottleRequest, value: Id) =
            { state with ReindexRethrottleRequest.TaskId = value } : ReindexRethrottleRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: ReindexRethrottleRequest, value: float) =
            { state with ReindexRethrottleRequest.RequestsPerSecond = value } : ReindexRethrottleRequest

    let reindexRethrottleRequest = ReindexRethrottleRequestBuilder()

    type ReindexRethrottleResponse = {
        [<JsonPropertyName("nodes")>]
        Nodes: Map<string, ReindexRethrottleReindexNode>
    }

    type TermvectorsRequest = {
        Index: IndexName
        Id: Id
        Fields: Fields option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        Preference: string option
        Realtime: bool option
        Routing: Routing option
        TermStatistics: bool option
        Version: VersionNumber option
        VersionType: VersionType option
        [<JsonPropertyName("doc")>]
        Doc: obj option
        [<JsonPropertyName("filter")>]
        Filter: TermvectorsFilter option
        [<JsonPropertyName("per_field_analyzer")>]
        PerFieldAnalyzer: Map<string, string> option
        [<JsonPropertyName("fields")>]
        Fields2: Field array option
        [<JsonPropertyName("field_statistics")>]
        FieldStatistics2: bool option
        [<JsonPropertyName("offsets")>]
        Offsets2: bool option
        [<JsonPropertyName("payloads")>]
        Payloads2: bool option
        [<JsonPropertyName("positions")>]
        Positions2: bool option
        [<JsonPropertyName("term_statistics")>]
        TermStatistics2: bool option
        [<JsonPropertyName("routing")>]
        Routing2: Routing option
        [<JsonPropertyName("version")>]
        Version2: VersionNumber option
        [<JsonPropertyName("version_type")>]
        VersionType2: VersionType option
    } with
        static member ToRequest(request: TermvectorsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_termvectors/{request.Id}"
                let queryParams =
                    [
                        request.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        request.FieldStatistics |> Option.map (fun v -> "field_statistics", Fes.Http.toQueryValue v)
                        request.Offsets |> Option.map (fun v -> "offsets", Fes.Http.toQueryValue v)
                        request.Payloads |> Option.map (fun v -> "payloads", Fes.Http.toQueryValue v)
                        request.Positions |> Option.map (fun v -> "positions", Fes.Http.toQueryValue v)
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.TermStatistics |> Option.map (fun v -> "term_statistics", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``doc`` = request.Doc; ``filter`` = request.Filter; ``per_field_analyzer`` = request.PerFieldAnalyzer; ``fields`` = request.Fields2; ``field_statistics`` = request.FieldStatistics2; ``offsets`` = request.Offsets2; ``payloads`` = request.Payloads2; ``positions`` = request.Positions2; ``term_statistics`` = request.TermStatistics2; ``routing`` = request.Routing2; ``version`` = request.Version2; ``version_type`` = request.VersionType2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module TermvectorsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TermvectorsRequest) : Result<Fes.Http.RequestMsg, exn> =
            TermvectorsRequest.ToRequest request

    type TermvectorsRequestBuilder() =
        member _.Yield(_: unit) : TermvectorsRequest =
            {
                TermvectorsRequest.Index = Unchecked.defaultof<IndexName>
                TermvectorsRequest.Id = Unchecked.defaultof<Id>
                TermvectorsRequest.Fields = Option.None
                TermvectorsRequest.FieldStatistics = Option.None
                TermvectorsRequest.Offsets = Option.None
                TermvectorsRequest.Payloads = Option.None
                TermvectorsRequest.Positions = Option.None
                TermvectorsRequest.Preference = Option.None
                TermvectorsRequest.Realtime = Option.None
                TermvectorsRequest.Routing = Option.None
                TermvectorsRequest.TermStatistics = Option.None
                TermvectorsRequest.Version = Option.None
                TermvectorsRequest.VersionType = Option.None
                TermvectorsRequest.Doc = Option.None
                TermvectorsRequest.Filter = Option.None
                TermvectorsRequest.PerFieldAnalyzer = Option.None
                TermvectorsRequest.Fields2 = Option.None
                TermvectorsRequest.FieldStatistics2 = Option.None
                TermvectorsRequest.Offsets2 = Option.None
                TermvectorsRequest.Payloads2 = Option.None
                TermvectorsRequest.Positions2 = Option.None
                TermvectorsRequest.TermStatistics2 = Option.None
                TermvectorsRequest.Routing2 = Option.None
                TermvectorsRequest.Version2 = Option.None
                TermvectorsRequest.VersionType2 = Option.None
            } : TermvectorsRequest

        [<CustomOperation("index")>]
        member _.Index(state: TermvectorsRequest, value: IndexName) =
            { state with TermvectorsRequest.Index = value } : TermvectorsRequest

        [<CustomOperation("id")>]
        member _.Id(state: TermvectorsRequest, value: Id) =
            { state with TermvectorsRequest.Id = value } : TermvectorsRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: TermvectorsRequest, value: Fields) =
            { state with TermvectorsRequest.Fields = Option.Some value } : TermvectorsRequest

        [<CustomOperation("field_statistics")>]
        member _.FieldStatistics(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.FieldStatistics = Option.Some value } : TermvectorsRequest

        [<CustomOperation("offsets")>]
        member _.Offsets(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Offsets = Option.Some value } : TermvectorsRequest

        [<CustomOperation("payloads")>]
        member _.Payloads(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Payloads = Option.Some value } : TermvectorsRequest

        [<CustomOperation("positions")>]
        member _.Positions(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Positions = Option.Some value } : TermvectorsRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: TermvectorsRequest, value: string) =
            { state with TermvectorsRequest.Preference = Option.Some value } : TermvectorsRequest

        [<CustomOperation("realtime")>]
        member _.Realtime(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Realtime = Option.Some value } : TermvectorsRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: TermvectorsRequest, value: Routing) =
            { state with TermvectorsRequest.Routing = Option.Some value } : TermvectorsRequest

        [<CustomOperation("term_statistics")>]
        member _.TermStatistics(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.TermStatistics = Option.Some value } : TermvectorsRequest

        [<CustomOperation("version")>]
        member _.Version(state: TermvectorsRequest, value: VersionNumber) =
            { state with TermvectorsRequest.Version = Option.Some value } : TermvectorsRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: TermvectorsRequest, value: VersionType) =
            { state with TermvectorsRequest.VersionType = Option.Some value } : TermvectorsRequest

        [<CustomOperation("doc")>]
        member _.Doc(state: TermvectorsRequest, value: obj) =
            { state with TermvectorsRequest.Doc = Option.Some value } : TermvectorsRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: TermvectorsRequest, value: TermvectorsFilter) =
            { state with TermvectorsRequest.Filter = Option.Some value } : TermvectorsRequest

        [<CustomOperation("per_field_analyzer")>]
        member _.PerFieldAnalyzer(state: TermvectorsRequest, value: Map<string, string>) =
            { state with TermvectorsRequest.PerFieldAnalyzer = Option.Some value } : TermvectorsRequest

        [<CustomOperation("fields2")>]
        member _.Fields2(state: TermvectorsRequest, value: Field array) =
            { state with TermvectorsRequest.Fields2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("field_statistics2")>]
        member _.FieldStatistics2(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.FieldStatistics2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("offsets2")>]
        member _.Offsets2(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Offsets2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("payloads2")>]
        member _.Payloads2(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Payloads2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("positions2")>]
        member _.Positions2(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.Positions2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("term_statistics2")>]
        member _.TermStatistics2(state: TermvectorsRequest, value: bool) =
            { state with TermvectorsRequest.TermStatistics2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("routing2")>]
        member _.Routing2(state: TermvectorsRequest, value: Routing) =
            { state with TermvectorsRequest.Routing2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("version2")>]
        member _.Version2(state: TermvectorsRequest, value: VersionNumber) =
            { state with TermvectorsRequest.Version2 = Option.Some value } : TermvectorsRequest

        [<CustomOperation("version_type2")>]
        member _.VersionType2(state: TermvectorsRequest, value: VersionType) =
            { state with TermvectorsRequest.VersionType2 = Option.Some value } : TermvectorsRequest

    let termvectorsRequest = TermvectorsRequestBuilder()

    type UpdateRequest = {
        Index: IndexName
        Id: Id
        IfPrimaryTerm: float option
        IfSeqNo: SequenceNumber option
        IncludeSourceOnError: bool option
        Lang: string option
        Refresh: Refresh option
        RequireAlias: bool option
        RetryOnConflict: float option
        Routing: Routing option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        [<JsonPropertyName("detect_noop")>]
        DetectNoop: bool option
        [<JsonPropertyName("doc")>]
        Doc: obj option
        [<JsonPropertyName("doc_as_upsert")>]
        DocAsUpsert: bool option
        [<JsonPropertyName("script")>]
        Script: Script option
        [<JsonPropertyName("scripted_upsert")>]
        ScriptedUpsert: bool option
        [<JsonPropertyName("_source")>]
        Source2: SearchTypesSourceConfig option
        [<JsonPropertyName("upsert")>]
        Upsert: obj option
    } with
        static member ToRequest(request: UpdateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_update/{request.Id}"
                let queryParams =
                    [
                        request.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        request.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        request.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                        request.Lang |> Option.map (fun v -> "lang", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                        request.RetryOnConflict |> Option.map (fun v -> "retry_on_conflict", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``detect_noop`` = request.DetectNoop; ``doc`` = request.Doc; ``doc_as_upsert`` = request.DocAsUpsert; ``script`` = request.Script; ``scripted_upsert`` = request.ScriptedUpsert; ``_source`` = request.Source2; ``upsert`` = request.Upsert |}
                |> Result.Ok
            with ex -> Result.Error ex

    module UpdateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: UpdateRequest) : Result<Fes.Http.RequestMsg, exn> =
            UpdateRequest.ToRequest request

    type UpdateRequestBuilder() =
        member _.Yield(_: unit) : UpdateRequest =
            {
                UpdateRequest.Index = Unchecked.defaultof<IndexName>
                UpdateRequest.Id = Unchecked.defaultof<Id>
                UpdateRequest.IfPrimaryTerm = Option.None
                UpdateRequest.IfSeqNo = Option.None
                UpdateRequest.IncludeSourceOnError = Option.None
                UpdateRequest.Lang = Option.None
                UpdateRequest.Refresh = Option.None
                UpdateRequest.RequireAlias = Option.None
                UpdateRequest.RetryOnConflict = Option.None
                UpdateRequest.Routing = Option.None
                UpdateRequest.Timeout = Option.None
                UpdateRequest.WaitForActiveShards = Option.None
                UpdateRequest.Source = Option.None
                UpdateRequest.SourceExcludes = Option.None
                UpdateRequest.SourceIncludes = Option.None
                UpdateRequest.DetectNoop = Option.None
                UpdateRequest.Doc = Option.None
                UpdateRequest.DocAsUpsert = Option.None
                UpdateRequest.Script = Option.None
                UpdateRequest.ScriptedUpsert = Option.None
                UpdateRequest.Source2 = Option.None
                UpdateRequest.Upsert = Option.None
            } : UpdateRequest

        [<CustomOperation("index")>]
        member _.Index(state: UpdateRequest, value: IndexName) =
            { state with UpdateRequest.Index = value } : UpdateRequest

        [<CustomOperation("id")>]
        member _.Id(state: UpdateRequest, value: Id) =
            { state with UpdateRequest.Id = value } : UpdateRequest

        [<CustomOperation("if_primary_term")>]
        member _.IfPrimaryTerm(state: UpdateRequest, value: float) =
            { state with UpdateRequest.IfPrimaryTerm = Option.Some value } : UpdateRequest

        [<CustomOperation("if_seq_no")>]
        member _.IfSeqNo(state: UpdateRequest, value: SequenceNumber) =
            { state with UpdateRequest.IfSeqNo = Option.Some value } : UpdateRequest

        [<CustomOperation("include_source_on_error")>]
        member _.IncludeSourceOnError(state: UpdateRequest, value: bool) =
            { state with UpdateRequest.IncludeSourceOnError = Option.Some value } : UpdateRequest

        [<CustomOperation("lang")>]
        member _.Lang(state: UpdateRequest, value: string) =
            { state with UpdateRequest.Lang = Option.Some value } : UpdateRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: UpdateRequest, value: Refresh) =
            { state with UpdateRequest.Refresh = Option.Some value } : UpdateRequest

        [<CustomOperation("require_alias")>]
        member _.RequireAlias(state: UpdateRequest, value: bool) =
            { state with UpdateRequest.RequireAlias = Option.Some value } : UpdateRequest

        [<CustomOperation("retry_on_conflict")>]
        member _.RetryOnConflict(state: UpdateRequest, value: float) =
            { state with UpdateRequest.RetryOnConflict = Option.Some value } : UpdateRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: UpdateRequest, value: Routing) =
            { state with UpdateRequest.Routing = Option.Some value } : UpdateRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: UpdateRequest, value: Duration) =
            { state with UpdateRequest.Timeout = Option.Some value } : UpdateRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: UpdateRequest, value: WaitForActiveShards) =
            { state with UpdateRequest.WaitForActiveShards = Option.Some value } : UpdateRequest

        [<CustomOperation("_source")>]
        member _.Source(state: UpdateRequest, value: SearchTypesSourceConfigParam) =
            { state with UpdateRequest.Source = Option.Some value } : UpdateRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: UpdateRequest, value: Fields) =
            { state with UpdateRequest.SourceExcludes = Option.Some value } : UpdateRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: UpdateRequest, value: Fields) =
            { state with UpdateRequest.SourceIncludes = Option.Some value } : UpdateRequest

        [<CustomOperation("detect_noop")>]
        member _.DetectNoop(state: UpdateRequest, value: bool) =
            { state with UpdateRequest.DetectNoop = Option.Some value } : UpdateRequest

        [<CustomOperation("doc")>]
        member _.Doc(state: UpdateRequest, value: obj) =
            { state with UpdateRequest.Doc = Option.Some value } : UpdateRequest

        [<CustomOperation("doc_as_upsert")>]
        member _.DocAsUpsert(state: UpdateRequest, value: bool) =
            { state with UpdateRequest.DocAsUpsert = Option.Some value } : UpdateRequest

        [<CustomOperation("script")>]
        member _.Script(state: UpdateRequest, value: Script) =
            { state with UpdateRequest.Script = Option.Some value } : UpdateRequest

        [<CustomOperation("scripted_upsert")>]
        member _.ScriptedUpsert(state: UpdateRequest, value: bool) =
            { state with UpdateRequest.ScriptedUpsert = Option.Some value } : UpdateRequest

        [<CustomOperation("_source2")>]
        member _.Source2(state: UpdateRequest, value: SearchTypesSourceConfig) =
            { state with UpdateRequest.Source2 = Option.Some value } : UpdateRequest

        [<CustomOperation("upsert")>]
        member _.Upsert(state: UpdateRequest, value: obj) =
            { state with UpdateRequest.Upsert = Option.Some value } : UpdateRequest

    let updateRequest = UpdateRequestBuilder()

    type UpdateResponse = UpdateUpdateWriteResponseBase

    type UpdateByQueryRequest = {
        Index: Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        Conflicts: Conflicts option
        DefaultOperator: QueryDslOperator option
        Df: string option
        ExpandWildcards: ExpandWildcards option
        From: float option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxDocs: float option
        Pipeline: string option
        Preference: string option
        Q: string option
        Refresh: bool option
        RequestCache: bool option
        RequestsPerSecond: float option
        Routing: Routing option
        Scroll: Duration option
        ScrollSize: float option
        SearchTimeout: Duration option
        SearchType: SearchType option
        Slices: Slices option
        Sort: string array option
        Stats: string array option
        TerminateAfter: float option
        Timeout: Duration option
        Version: bool option
        VersionType: bool option
        WaitForActiveShards: WaitForActiveShards option
        WaitForCompletion: bool option
        [<JsonPropertyName("max_docs")>]
        MaxDocs2: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("script")>]
        Script: Script option
        [<JsonPropertyName("slice")>]
        Slice: SlicedScroll option
        [<JsonPropertyName("conflicts")>]
        Conflicts2: Conflicts option
    } with
        static member ToRequest(request: UpdateByQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_update_by_query"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                        request.Conflicts |> Option.map (fun v -> "conflicts", Fes.Http.toQueryValue v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                        request.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                        request.MaxDocs |> Option.map (fun v -> "max_docs", Fes.Http.toQueryValue v)
                        request.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                        request.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                        request.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                        request.ScrollSize |> Option.map (fun v -> "scroll_size", Fes.Http.toQueryValue v)
                        request.SearchTimeout |> Option.map (fun v -> "search_timeout", Fes.Http.toQueryValue v)
                        request.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                        request.Slices |> Option.map (fun v -> "slices", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.Stats |> Option.map (fun v -> "stats", Fes.Http.toQueryValue v)
                        request.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``max_docs`` = request.MaxDocs2; ``query`` = request.Query; ``script`` = request.Script; ``slice`` = request.Slice; ``conflicts`` = request.Conflicts2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module UpdateByQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: UpdateByQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            UpdateByQueryRequest.ToRequest request

    type UpdateByQueryRequestBuilder() =
        member _.Yield(_: unit) : UpdateByQueryRequest =
            {
                UpdateByQueryRequest.Index = Unchecked.defaultof<Indices>
                UpdateByQueryRequest.AllowNoIndices = Option.None
                UpdateByQueryRequest.Analyzer = Option.None
                UpdateByQueryRequest.AnalyzeWildcard = Option.None
                UpdateByQueryRequest.Conflicts = Option.None
                UpdateByQueryRequest.DefaultOperator = Option.None
                UpdateByQueryRequest.Df = Option.None
                UpdateByQueryRequest.ExpandWildcards = Option.None
                UpdateByQueryRequest.From = Option.None
                UpdateByQueryRequest.IgnoreUnavailable = Option.None
                UpdateByQueryRequest.Lenient = Option.None
                UpdateByQueryRequest.MaxDocs = Option.None
                UpdateByQueryRequest.Pipeline = Option.None
                UpdateByQueryRequest.Preference = Option.None
                UpdateByQueryRequest.Q = Option.None
                UpdateByQueryRequest.Refresh = Option.None
                UpdateByQueryRequest.RequestCache = Option.None
                UpdateByQueryRequest.RequestsPerSecond = Option.None
                UpdateByQueryRequest.Routing = Option.None
                UpdateByQueryRequest.Scroll = Option.None
                UpdateByQueryRequest.ScrollSize = Option.None
                UpdateByQueryRequest.SearchTimeout = Option.None
                UpdateByQueryRequest.SearchType = Option.None
                UpdateByQueryRequest.Slices = Option.None
                UpdateByQueryRequest.Sort = Option.None
                UpdateByQueryRequest.Stats = Option.None
                UpdateByQueryRequest.TerminateAfter = Option.None
                UpdateByQueryRequest.Timeout = Option.None
                UpdateByQueryRequest.Version = Option.None
                UpdateByQueryRequest.VersionType = Option.None
                UpdateByQueryRequest.WaitForActiveShards = Option.None
                UpdateByQueryRequest.WaitForCompletion = Option.None
                UpdateByQueryRequest.MaxDocs2 = Option.None
                UpdateByQueryRequest.Query = Option.None
                UpdateByQueryRequest.Script = Option.None
                UpdateByQueryRequest.Slice = Option.None
                UpdateByQueryRequest.Conflicts2 = Option.None
            } : UpdateByQueryRequest

        [<CustomOperation("index")>]
        member _.Index(state: UpdateByQueryRequest, value: Indices) =
            { state with UpdateByQueryRequest.Index = value } : UpdateByQueryRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.AllowNoIndices = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: UpdateByQueryRequest, value: string) =
            { state with UpdateByQueryRequest.Analyzer = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.AnalyzeWildcard = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: UpdateByQueryRequest, value: Conflicts) =
            { state with UpdateByQueryRequest.Conflicts = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: UpdateByQueryRequest, value: QueryDslOperator) =
            { state with UpdateByQueryRequest.DefaultOperator = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("df")>]
        member _.Df(state: UpdateByQueryRequest, value: string) =
            { state with UpdateByQueryRequest.Df = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: UpdateByQueryRequest, value: ExpandWildcards) =
            { state with UpdateByQueryRequest.ExpandWildcards = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("from")>]
        member _.From(state: UpdateByQueryRequest, value: float) =
            { state with UpdateByQueryRequest.From = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.IgnoreUnavailable = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.Lenient = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("max_docs")>]
        member _.MaxDocs(state: UpdateByQueryRequest, value: float) =
            { state with UpdateByQueryRequest.MaxDocs = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: UpdateByQueryRequest, value: string) =
            { state with UpdateByQueryRequest.Pipeline = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: UpdateByQueryRequest, value: string) =
            { state with UpdateByQueryRequest.Preference = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("q")>]
        member _.Q(state: UpdateByQueryRequest, value: string) =
            { state with UpdateByQueryRequest.Q = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.Refresh = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("request_cache")>]
        member _.RequestCache(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.RequestCache = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: UpdateByQueryRequest, value: float) =
            { state with UpdateByQueryRequest.RequestsPerSecond = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: UpdateByQueryRequest, value: Routing) =
            { state with UpdateByQueryRequest.Routing = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: UpdateByQueryRequest, value: Duration) =
            { state with UpdateByQueryRequest.Scroll = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("scroll_size")>]
        member _.ScrollSize(state: UpdateByQueryRequest, value: float) =
            { state with UpdateByQueryRequest.ScrollSize = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("search_timeout")>]
        member _.SearchTimeout(state: UpdateByQueryRequest, value: Duration) =
            { state with UpdateByQueryRequest.SearchTimeout = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: UpdateByQueryRequest, value: SearchType) =
            { state with UpdateByQueryRequest.SearchType = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("slices")>]
        member _.Slices(state: UpdateByQueryRequest, value: Slices) =
            { state with UpdateByQueryRequest.Slices = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: UpdateByQueryRequest, value: string array) =
            { state with UpdateByQueryRequest.Sort = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("stats")>]
        member _.Stats(state: UpdateByQueryRequest, value: string array) =
            { state with UpdateByQueryRequest.Stats = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("terminate_after")>]
        member _.TerminateAfter(state: UpdateByQueryRequest, value: float) =
            { state with UpdateByQueryRequest.TerminateAfter = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: UpdateByQueryRequest, value: Duration) =
            { state with UpdateByQueryRequest.Timeout = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("version")>]
        member _.Version(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.Version = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("version_type")>]
        member _.VersionType(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.VersionType = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: UpdateByQueryRequest, value: WaitForActiveShards) =
            { state with UpdateByQueryRequest.WaitForActiveShards = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: UpdateByQueryRequest, value: bool) =
            { state with UpdateByQueryRequest.WaitForCompletion = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("max_docs2")>]
        member _.MaxDocs2(state: UpdateByQueryRequest, value: float) =
            { state with UpdateByQueryRequest.MaxDocs2 = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("query")>]
        member _.Query(state: UpdateByQueryRequest, value: QueryDslQueryContainer) =
            { state with UpdateByQueryRequest.Query = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("script")>]
        member _.Script(state: UpdateByQueryRequest, value: Script) =
            { state with UpdateByQueryRequest.Script = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("slice")>]
        member _.Slice(state: UpdateByQueryRequest, value: SlicedScroll) =
            { state with UpdateByQueryRequest.Slice = Option.Some value } : UpdateByQueryRequest

        [<CustomOperation("conflicts2")>]
        member _.Conflicts2(state: UpdateByQueryRequest, value: Conflicts) =
            { state with UpdateByQueryRequest.Conflicts2 = Option.Some value } : UpdateByQueryRequest

    let updateByQueryRequest = UpdateByQueryRequestBuilder()

    type UpdateByQueryResponse = {
        [<JsonPropertyName("batches")>]
        Batches: float option
        [<JsonPropertyName("failures")>]
        Failures: BulkIndexByScrollFailure array option
        [<JsonPropertyName("noops")>]
        Noops: float option
        [<JsonPropertyName("deleted")>]
        Deleted: float option
        [<JsonPropertyName("requests_per_second")>]
        RequestsPerSecond: float option
        [<JsonPropertyName("retries")>]
        Retries: Retries option
        [<JsonPropertyName("task")>]
        Task: TaskId option
        [<JsonPropertyName("timed_out")>]
        TimedOut: bool option
        [<JsonPropertyName("took")>]
        Took: DurationValueUnitMillis option
        [<JsonPropertyName("total")>]
        Total: float option
        [<JsonPropertyName("updated")>]
        Updated: float option
        [<JsonPropertyName("version_conflicts")>]
        VersionConflicts: float option
        [<JsonPropertyName("throttled")>]
        Throttled: Duration option
        [<JsonPropertyName("throttled_millis")>]
        ThrottledMillis: DurationValueUnitMillis option
        [<JsonPropertyName("throttled_until")>]
        ThrottledUntil: Duration option
        [<JsonPropertyName("throttled_until_millis")>]
        ThrottledUntilMillis: DurationValueUnitMillis option
    }

    type UpdateByQueryRethrottleRequest = {
        TaskId: Id
        RequestsPerSecond: float
    } with
        static member ToRequest(request: UpdateByQueryRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_update_by_query/{request.TaskId}/_rethrottle"
                let queryParams =
                    [
                        Some ("requests_per_second", Fes.Http.toQueryValue request.RequestsPerSecond)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module UpdateByQueryRethrottleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: UpdateByQueryRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            UpdateByQueryRethrottleRequest.ToRequest request

    type UpdateByQueryRethrottleRequestBuilder() =
        member _.Yield(_: unit) : UpdateByQueryRethrottleRequest =
            {
                UpdateByQueryRethrottleRequest.TaskId = Unchecked.defaultof<Id>
                UpdateByQueryRethrottleRequest.RequestsPerSecond = 0.0
            } : UpdateByQueryRethrottleRequest

        [<CustomOperation("task_id")>]
        member _.TaskId(state: UpdateByQueryRethrottleRequest, value: Id) =
            { state with UpdateByQueryRethrottleRequest.TaskId = value } : UpdateByQueryRethrottleRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: UpdateByQueryRethrottleRequest, value: float) =
            { state with UpdateByQueryRethrottleRequest.RequestsPerSecond = value } : UpdateByQueryRethrottleRequest

    let updateByQueryRethrottleRequest = UpdateByQueryRethrottleRequestBuilder()

    type UpdateByQueryRethrottleResponse = {
        [<JsonPropertyName("nodes")>]
        Nodes: Map<string, UpdateByQueryRethrottleUpdateByQueryRethrottleNode>
    }

