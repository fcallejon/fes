// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module EqlOperations =

    type EqlGetRequest = {
        Id: Id
        KeepAlive: Duration option
        WaitForCompletionTimeout: Duration option
    } with
        static member ToRequest(request: EqlGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_eql/search/{request.Id}"
                let queryParams =
                    [
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        request.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
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

    module EqlGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EqlGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            EqlGetRequest.ToRequest request

    type EqlGetRequestBuilder() =
        member _.Yield(_: unit) : EqlGetRequest =
            {
                EqlGetRequest.Id = Unchecked.defaultof<Id>
                EqlGetRequest.KeepAlive = Option.None
                EqlGetRequest.WaitForCompletionTimeout = Option.None
            } : EqlGetRequest

        [<CustomOperation("id")>]
        member _.Id(state: EqlGetRequest, value: Id) =
            { state with EqlGetRequest.Id = value } : EqlGetRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: EqlGetRequest, value: Duration) =
            { state with EqlGetRequest.KeepAlive = Option.Some value } : EqlGetRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: EqlGetRequest, value: Duration) =
            { state with EqlGetRequest.WaitForCompletionTimeout = Option.Some value } : EqlGetRequest

    let eqlGetRequest = EqlGetRequestBuilder()

    type EqlGetResponse = TypesEqlSearchResponseBase

    type EqlDeleteRequest = {
        Id: Id
    } with
        static member ToRequest(request: EqlDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_eql/search/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module EqlDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EqlDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            EqlDeleteRequest.ToRequest request

    type EqlDeleteRequestBuilder() =
        member _.Yield(_: unit) : EqlDeleteRequest =
            {
                EqlDeleteRequest.Id = Unchecked.defaultof<Id>
            } : EqlDeleteRequest

        [<CustomOperation("id")>]
        member _.Id(state: EqlDeleteRequest, value: Id) =
            { state with EqlDeleteRequest.Id = value } : EqlDeleteRequest

    let eqlDeleteRequest = EqlDeleteRequestBuilder()

    type EqlDeleteResponse = AcknowledgedResponseBase

    type EqlGetStatusRequest = {
        Id: Id
    } with
        static member ToRequest(request: EqlGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_eql/search/status/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module EqlGetStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EqlGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            EqlGetStatusRequest.ToRequest request

    type EqlGetStatusRequestBuilder() =
        member _.Yield(_: unit) : EqlGetStatusRequest =
            {
                EqlGetStatusRequest.Id = Unchecked.defaultof<Id>
            } : EqlGetStatusRequest

        [<CustomOperation("id")>]
        member _.Id(state: EqlGetStatusRequest, value: Id) =
            { state with EqlGetStatusRequest.Id = value } : EqlGetStatusRequest

    let eqlGetStatusRequest = EqlGetStatusRequestBuilder()

    type EqlGetStatusResponse = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<JsonPropertyName("is_running")>]
        IsRunning: bool
        [<JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: EpochTimeUnitMillis option
        [<JsonPropertyName("expiration_time_in_millis")>]
        ExpirationTimeInMillis: EpochTimeUnitMillis option
        [<JsonPropertyName("completion_status")>]
        CompletionStatus: float option
    }

    type EqlSearchRequest = {
        Index: Indices
        AllowNoIndices: bool option
        AllowPartialSearchResults: bool option
        AllowPartialSequenceResults: bool option
        ExpandWildcards: ExpandWildcards option
        CcsMinimizeRoundtrips: bool option
        IgnoreUnavailable: bool option
        KeepAlive: Duration option
        KeepOnCompletion: bool option
        WaitForCompletionTimeout: Duration option
        [<JsonPropertyName("query")>]
        Query: string
        [<JsonPropertyName("case_sensitive")>]
        CaseSensitive: bool option
        [<JsonPropertyName("event_category_field")>]
        EventCategoryField: Field option
        [<JsonPropertyName("tiebreaker_field")>]
        TiebreakerField: Field option
        [<JsonPropertyName("timestamp_field")>]
        TimestampField: Field option
        [<JsonPropertyName("fetch_size")>]
        FetchSize: Uint option
        [<JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<JsonPropertyName("keep_alive")>]
        KeepAlive2: Duration option
        [<JsonPropertyName("keep_on_completion")>]
        KeepOnCompletion2: bool option
        [<JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout2: Duration option
        [<JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults2: bool option
        [<JsonPropertyName("allow_partial_sequence_results")>]
        AllowPartialSequenceResults2: bool option
        [<JsonPropertyName("size")>]
        Size: Uint option
        [<JsonPropertyName("fields")>]
        Fields: System.Text.Json.JsonElement option
        [<JsonPropertyName("result_position")>]
        ResultPosition: SearchResultPosition option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("max_samples_per_key")>]
        MaxSamplesPerKey: float option
    } with
        static member ToRequest(request: EqlSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_eql/search"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                        request.AllowPartialSequenceResults |> Option.map (fun v -> "allow_partial_sequence_results", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        request.KeepOnCompletion |> Option.map (fun v -> "keep_on_completion", Fes.Http.toQueryValue v)
                        request.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``query`` = request.Query; ``case_sensitive`` = request.CaseSensitive; ``event_category_field`` = request.EventCategoryField; ``tiebreaker_field`` = request.TiebreakerField; ``timestamp_field`` = request.TimestampField; ``fetch_size`` = request.FetchSize; ``filter`` = request.Filter; ``keep_alive`` = request.KeepAlive2; ``keep_on_completion`` = request.KeepOnCompletion2; ``wait_for_completion_timeout`` = request.WaitForCompletionTimeout2; ``allow_partial_search_results`` = request.AllowPartialSearchResults2; ``allow_partial_sequence_results`` = request.AllowPartialSequenceResults2; ``size`` = request.Size; ``fields`` = request.Fields; ``result_position`` = request.ResultPosition; ``runtime_mappings`` = request.RuntimeMappings; ``max_samples_per_key`` = request.MaxSamplesPerKey |}
                |> Result.Ok
            with ex -> Result.Error ex

    module EqlSearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EqlSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            EqlSearchRequest.ToRequest request

    type EqlSearchRequestBuilder() =
        member _.Yield(_: unit) : EqlSearchRequest =
            {
                EqlSearchRequest.Index = Unchecked.defaultof<Indices>
                EqlSearchRequest.AllowNoIndices = Option.None
                EqlSearchRequest.AllowPartialSearchResults = Option.None
                EqlSearchRequest.AllowPartialSequenceResults = Option.None
                EqlSearchRequest.ExpandWildcards = Option.None
                EqlSearchRequest.CcsMinimizeRoundtrips = Option.None
                EqlSearchRequest.IgnoreUnavailable = Option.None
                EqlSearchRequest.KeepAlive = Option.None
                EqlSearchRequest.KeepOnCompletion = Option.None
                EqlSearchRequest.WaitForCompletionTimeout = Option.None
                EqlSearchRequest.Query = String.Empty
                EqlSearchRequest.CaseSensitive = Option.None
                EqlSearchRequest.EventCategoryField = Option.None
                EqlSearchRequest.TiebreakerField = Option.None
                EqlSearchRequest.TimestampField = Option.None
                EqlSearchRequest.FetchSize = Option.None
                EqlSearchRequest.Filter = Option.None
                EqlSearchRequest.KeepAlive2 = Option.None
                EqlSearchRequest.KeepOnCompletion2 = Option.None
                EqlSearchRequest.WaitForCompletionTimeout2 = Option.None
                EqlSearchRequest.AllowPartialSearchResults2 = Option.None
                EqlSearchRequest.AllowPartialSequenceResults2 = Option.None
                EqlSearchRequest.Size = Option.None
                EqlSearchRequest.Fields = Option.None
                EqlSearchRequest.ResultPosition = Option.None
                EqlSearchRequest.RuntimeMappings = Option.None
                EqlSearchRequest.MaxSamplesPerKey = Option.None
            } : EqlSearchRequest

        [<CustomOperation("index")>]
        member _.Index(state: EqlSearchRequest, value: Indices) =
            { state with EqlSearchRequest.Index = value } : EqlSearchRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.AllowNoIndices = Option.Some value } : EqlSearchRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.AllowPartialSearchResults = Option.Some value } : EqlSearchRequest

        [<CustomOperation("allow_partial_sequence_results")>]
        member _.AllowPartialSequenceResults(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.AllowPartialSequenceResults = Option.Some value } : EqlSearchRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: EqlSearchRequest, value: ExpandWildcards) =
            { state with EqlSearchRequest.ExpandWildcards = Option.Some value } : EqlSearchRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.CcsMinimizeRoundtrips = Option.Some value } : EqlSearchRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.IgnoreUnavailable = Option.Some value } : EqlSearchRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: EqlSearchRequest, value: Duration) =
            { state with EqlSearchRequest.KeepAlive = Option.Some value } : EqlSearchRequest

        [<CustomOperation("keep_on_completion")>]
        member _.KeepOnCompletion(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.KeepOnCompletion = Option.Some value } : EqlSearchRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: EqlSearchRequest, value: Duration) =
            { state with EqlSearchRequest.WaitForCompletionTimeout = Option.Some value } : EqlSearchRequest

        [<CustomOperation("query")>]
        member _.Query(state: EqlSearchRequest, value: string) =
            { state with EqlSearchRequest.Query = value } : EqlSearchRequest

        [<CustomOperation("case_sensitive")>]
        member _.CaseSensitive(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.CaseSensitive = Option.Some value } : EqlSearchRequest

        [<CustomOperation("event_category_field")>]
        member _.EventCategoryField(state: EqlSearchRequest, value: Field) =
            { state with EqlSearchRequest.EventCategoryField = Option.Some value } : EqlSearchRequest

        [<CustomOperation("tiebreaker_field")>]
        member _.TiebreakerField(state: EqlSearchRequest, value: Field) =
            { state with EqlSearchRequest.TiebreakerField = Option.Some value } : EqlSearchRequest

        [<CustomOperation("timestamp_field")>]
        member _.TimestampField(state: EqlSearchRequest, value: Field) =
            { state with EqlSearchRequest.TimestampField = Option.Some value } : EqlSearchRequest

        [<CustomOperation("fetch_size")>]
        member _.FetchSize(state: EqlSearchRequest, value: Uint) =
            { state with EqlSearchRequest.FetchSize = Option.Some value } : EqlSearchRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: EqlSearchRequest, value: System.Text.Json.JsonElement) =
            { state with EqlSearchRequest.Filter = Option.Some value } : EqlSearchRequest

        [<CustomOperation("keep_alive2")>]
        member _.KeepAlive2(state: EqlSearchRequest, value: Duration) =
            { state with EqlSearchRequest.KeepAlive2 = Option.Some value } : EqlSearchRequest

        [<CustomOperation("keep_on_completion2")>]
        member _.KeepOnCompletion2(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.KeepOnCompletion2 = Option.Some value } : EqlSearchRequest

        [<CustomOperation("wait_for_completion_timeout2")>]
        member _.WaitForCompletionTimeout2(state: EqlSearchRequest, value: Duration) =
            { state with EqlSearchRequest.WaitForCompletionTimeout2 = Option.Some value } : EqlSearchRequest

        [<CustomOperation("allow_partial_search_results2")>]
        member _.AllowPartialSearchResults2(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.AllowPartialSearchResults2 = Option.Some value } : EqlSearchRequest

        [<CustomOperation("allow_partial_sequence_results2")>]
        member _.AllowPartialSequenceResults2(state: EqlSearchRequest, value: bool) =
            { state with EqlSearchRequest.AllowPartialSequenceResults2 = Option.Some value } : EqlSearchRequest

        [<CustomOperation("size")>]
        member _.Size(state: EqlSearchRequest, value: Uint) =
            { state with EqlSearchRequest.Size = Option.Some value } : EqlSearchRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: EqlSearchRequest, value: System.Text.Json.JsonElement) =
            { state with EqlSearchRequest.Fields = Option.Some value } : EqlSearchRequest

        [<CustomOperation("result_position")>]
        member _.ResultPosition(state: EqlSearchRequest, value: SearchResultPosition) =
            { state with EqlSearchRequest.ResultPosition = Option.Some value } : EqlSearchRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: EqlSearchRequest, value: MappingRuntimeFields) =
            { state with EqlSearchRequest.RuntimeMappings = Option.Some value } : EqlSearchRequest

        [<CustomOperation("max_samples_per_key")>]
        member _.MaxSamplesPerKey(state: EqlSearchRequest, value: float) =
            { state with EqlSearchRequest.MaxSamplesPerKey = Option.Some value } : EqlSearchRequest

    let eqlSearchRequest = EqlSearchRequestBuilder()

