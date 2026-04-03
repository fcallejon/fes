// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module EqlOperations =

    type EqlDeleteRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: EqlDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_eql/search/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type EqlDeleteResponse = Types.AcknowledgedResponseBase

    type EqlDeleteRequestBuilder() =
        member _.Yield(_: unit) : EqlDeleteRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: EqlDeleteRequest, value: Types.Id) =
            { state with Id = value }

    let eqlDeleteRequest = EqlDeleteRequestBuilder()

    type EqlGetRequest = {
        Id: Types.Id
        KeepAlive: Types.Duration option
        WaitForCompletionTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: EqlGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_eql/search/{req.Id}"
                let queryParams =
                    [
                        req.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        req.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type EqlGetResponse<'tEvent> = Types.EqlSearchResponseBase<'tEvent>

    type EqlGetRequestBuilder() =
        member _.Yield(_: unit) : EqlGetRequest =
            {
                Id = Unchecked.defaultof<_>
                KeepAlive = None
                WaitForCompletionTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: EqlGetRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EqlGetRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EqlGetRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

    let eqlGetRequest = EqlGetRequestBuilder()

    module Get =
        let withKeepAlive (value: Types.Duration) (req: EqlGetRequest) =
            { req with KeepAlive = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: EqlGetRequest) =
            { req with WaitForCompletionTimeout = Some value }

    type EqlGetStatusRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: EqlGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_eql/search/status/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type EqlGetStatusResponse = System.Text.Json.JsonElement

    type EqlGetStatusRequestBuilder() =
        member _.Yield(_: unit) : EqlGetStatusRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: EqlGetStatusRequest, value: Types.Id) =
            { state with Id = value }

    let eqlGetStatusRequest = EqlGetStatusRequestBuilder()

    type EqlSearchRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        AllowPartialSearchResults: bool option
        AllowPartialSequenceResults: bool option
        ExpandWildcards: Types.ExpandWildcards option
        CcsMinimizeRoundtrips: bool option
        IgnoreUnavailable: bool option
        KeepAlive: Types.Duration option
        KeepOnCompletion: bool option
        WaitForCompletionTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("case_sensitive")>]
        CaseSensitive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("event_category_field")>]
        EventCategoryField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("tiebreaker_field")>]
        TiebreakerField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_field")>]
        TimestampField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_size")>]
        FetchSize: Types.Uint option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        bodyKeepAlive: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_on_completion")>]
        bodyKeepOnCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("wait_for_completion_timeout")>]
        bodyWaitForCompletionTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_partial_search_results")>]
        bodyAllowPartialSearchResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_partial_sequence_results")>]
        bodyAllowPartialSequenceResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Uint option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("result_position")>]
        ResultPosition: Types.ResultPosition option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("max_samples_per_key")>]
        MaxSamplesPerKey: Types.Integer option
    }

        with
        static member ToRequest(req: EqlSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_eql/search"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                        req.AllowPartialSequenceResults |> Option.map (fun v -> "allow_partial_sequence_results", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        req.KeepOnCompletion |> Option.map (fun v -> "keep_on_completion", Fes.Http.toQueryValue v)
                        req.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type EqlSearchResponse<'tEvent> = Types.EqlSearchResponseBase<'tEvent>

    type EqlSearchRequestBuilder() =
        member _.Yield(_: unit) : EqlSearchRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                AllowPartialSearchResults = None
                AllowPartialSequenceResults = None
                ExpandWildcards = None
                CcsMinimizeRoundtrips = None
                IgnoreUnavailable = None
                KeepAlive = None
                KeepOnCompletion = None
                WaitForCompletionTimeout = None
                ProjectRouting = None
                Query = Unchecked.defaultof<_>
                CaseSensitive = None
                EventCategoryField = None
                TiebreakerField = None
                TimestampField = None
                FetchSize = None
                Filter = None
                bodyKeepAlive = None
                bodyKeepOnCompletion = None
                bodyWaitForCompletionTimeout = None
                bodyAllowPartialSearchResults = None
                bodyAllowPartialSequenceResults = None
                Size = None
                Fields = None
                ResultPosition = None
                RuntimeMappings = None
                MaxSamplesPerKey = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: EqlSearchRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: EqlSearchRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: EqlSearchRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("allowPartialSequenceResults")>]
        member _.AllowPartialSequenceResults(state: EqlSearchRequest, value: bool) =
            { state with AllowPartialSequenceResults = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: EqlSearchRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: EqlSearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: EqlSearchRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EqlSearchRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("keepOnCompletion")>]
        member _.KeepOnCompletion(state: EqlSearchRequest, value: bool) =
            { state with KeepOnCompletion = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EqlSearchRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: EqlSearchRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: EqlSearchRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("caseSensitive")>]
        member _.CaseSensitive(state: EqlSearchRequest, value: bool) =
            { state with CaseSensitive = Some value }

        [<CustomOperation("eventCategoryField")>]
        member _.EventCategoryField(state: EqlSearchRequest, value: Types.Field) =
            { state with EventCategoryField = Some value }

        [<CustomOperation("tiebreakerField")>]
        member _.TiebreakerField(state: EqlSearchRequest, value: Types.Field) =
            { state with TiebreakerField = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: EqlSearchRequest, value: Types.Field) =
            { state with TimestampField = Some value }

        [<CustomOperation("fetchSize")>]
        member _.FetchSize(state: EqlSearchRequest, value: Types.Uint) =
            { state with FetchSize = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: EqlSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("bodyKeepAlive")>]
        member _.BodyKeepAlive(state: EqlSearchRequest, value: Types.Duration) =
            { state with bodyKeepAlive = Some value }

        [<CustomOperation("bodyKeepOnCompletion")>]
        member _.BodyKeepOnCompletion(state: EqlSearchRequest, value: bool) =
            { state with bodyKeepOnCompletion = Some value }

        [<CustomOperation("bodyWaitForCompletionTimeout")>]
        member _.BodyWaitForCompletionTimeout(state: EqlSearchRequest, value: Types.Duration) =
            { state with bodyWaitForCompletionTimeout = Some value }

        [<CustomOperation("bodyAllowPartialSearchResults")>]
        member _.BodyAllowPartialSearchResults(state: EqlSearchRequest, value: bool) =
            { state with bodyAllowPartialSearchResults = Some value }

        [<CustomOperation("bodyAllowPartialSequenceResults")>]
        member _.BodyAllowPartialSequenceResults(state: EqlSearchRequest, value: bool) =
            { state with bodyAllowPartialSequenceResults = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: EqlSearchRequest, value: Types.Uint) =
            { state with Size = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: EqlSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Fields = Some value }

        [<CustomOperation("resultPosition")>]
        member _.ResultPosition(state: EqlSearchRequest, value: Types.ResultPosition) =
            { state with ResultPosition = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: EqlSearchRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("maxSamplesPerKey")>]
        member _.MaxSamplesPerKey(state: EqlSearchRequest, value: Types.Integer) =
            { state with MaxSamplesPerKey = Some value }

    let eqlSearchRequest = EqlSearchRequestBuilder()

    module Search =
        let withAllowNoIndices (value: bool) (req: EqlSearchRequest) =
            { req with AllowNoIndices = Some value }
        let withAllowPartialSearchResults (value: bool) (req: EqlSearchRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withAllowPartialSequenceResults (value: bool) (req: EqlSearchRequest) =
            { req with AllowPartialSequenceResults = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: EqlSearchRequest) =
            { req with ExpandWildcards = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: EqlSearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withIgnoreUnavailable (value: bool) (req: EqlSearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withKeepAlive (value: Types.Duration) (req: EqlSearchRequest) =
            { req with KeepAlive = Some value }
        let withKeepOnCompletion (value: bool) (req: EqlSearchRequest) =
            { req with KeepOnCompletion = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: EqlSearchRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: EqlSearchRequest) =
            { req with ProjectRouting = Some value }
        let withQuery (value: string) (req: EqlSearchRequest) =
            { req with Query = value }
        let withCaseSensitive (value: bool) (req: EqlSearchRequest) =
            { req with CaseSensitive = Some value }
        let withEventCategoryField (value: Types.Field) (req: EqlSearchRequest) =
            { req with EventCategoryField = Some value }
        let withTiebreakerField (value: Types.Field) (req: EqlSearchRequest) =
            { req with TiebreakerField = Some value }
        let withTimestampField (value: Types.Field) (req: EqlSearchRequest) =
            { req with TimestampField = Some value }
        let withFetchSize (value: Types.Uint) (req: EqlSearchRequest) =
            { req with FetchSize = Some value }
        let withFilter (value: System.Text.Json.JsonElement) (req: EqlSearchRequest) =
            { req with Filter = Some value }
        let withBodyKeepAlive (value: Types.Duration) (req: EqlSearchRequest) =
            { req with bodyKeepAlive = Some value }
        let withBodyKeepOnCompletion (value: bool) (req: EqlSearchRequest) =
            { req with bodyKeepOnCompletion = Some value }
        let withBodyWaitForCompletionTimeout (value: Types.Duration) (req: EqlSearchRequest) =
            { req with bodyWaitForCompletionTimeout = Some value }
        let withBodyAllowPartialSearchResults (value: bool) (req: EqlSearchRequest) =
            { req with bodyAllowPartialSearchResults = Some value }
        let withBodyAllowPartialSequenceResults (value: bool) (req: EqlSearchRequest) =
            { req with bodyAllowPartialSequenceResults = Some value }
        let withSize (value: Types.Uint) (req: EqlSearchRequest) =
            { req with Size = Some value }
        let withFields (value: System.Text.Json.JsonElement) (req: EqlSearchRequest) =
            { req with Fields = Some value }
        let withResultPosition (value: Types.ResultPosition) (req: EqlSearchRequest) =
            { req with ResultPosition = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: EqlSearchRequest) =
            { req with RuntimeMappings = Some value }
        let withMaxSamplesPerKey (value: Types.Integer) (req: EqlSearchRequest) =
            { req with MaxSamplesPerKey = Some value }

