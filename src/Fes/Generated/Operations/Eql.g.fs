// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module EqlOperations =

    type EqlDeleteRequest = {
        Id: CoreTypes.Id
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

    type EqlDeleteResponse = CoreTypes.AcknowledgedResponseBase

    type EqlDeleteRequestBuilder() =
        member _.Yield(_: unit) : EqlDeleteRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: EqlDeleteRequest, value: CoreTypes.Id) =
            { state with Id = value }

    let eqlDeleteRequest = EqlDeleteRequestBuilder()

    type EqlGetRequest = {
        Id: CoreTypes.Id
        KeepAlive: CoreTypes.Duration option
        WaitForCompletionTimeout: CoreTypes.Duration option
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

    type EqlGetResponse = EqlTypes.EqlSearchResponseBase<EqlGetResponse.TEvent>

    type EqlGetRequestBuilder() =
        member _.Yield(_: unit) : EqlGetRequest =
            {
                Id = Unchecked.defaultof<_>
                KeepAlive = None
                WaitForCompletionTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: EqlGetRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EqlGetRequest, value: CoreTypes.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EqlGetRequest, value: CoreTypes.Duration) =
            { state with WaitForCompletionTimeout = Some value }

    let eqlGetRequest = EqlGetRequestBuilder()

    module Get =
        let withKeepAlive (value: CoreTypes.Duration) (req: EqlGetRequest) =
            { req with KeepAlive = Some value }
        let withWaitForCompletionTimeout (value: CoreTypes.Duration) (req: EqlGetRequest) =
            { req with WaitForCompletionTimeout = Some value }

    type EqlGetStatusRequest = {
        Id: CoreTypes.Id
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
        member _.Id(state: EqlGetStatusRequest, value: CoreTypes.Id) =
            { state with Id = value }

    let eqlGetStatusRequest = EqlGetStatusRequestBuilder()

    type EqlSearchRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        AllowPartialSearchResults: bool option
        AllowPartialSequenceResults: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        CcsMinimizeRoundtrips: bool option
        IgnoreUnavailable: bool option
        KeepAlive: CoreTypes.Duration option
        KeepOnCompletion: bool option
        WaitForCompletionTimeout: CoreTypes.Duration option
        ProjectRouting: CoreTypes.ProjectRouting option
        Query: string
        CaseSensitive: bool option
        EventCategoryField: CoreTypes.Field option
        TiebreakerField: CoreTypes.Field option
        TimestampField: CoreTypes.Field option
        FetchSize: CoreTypes.Uint option
        Filter: System.Text.Json.JsonElement option
        KeepAlive: CoreTypes.Duration option
        KeepOnCompletion: bool option
        WaitForCompletionTimeout: CoreTypes.Duration option
        AllowPartialSearchResults: bool option
        AllowPartialSequenceResults: bool option
        Size: CoreTypes.Uint option
        Fields: System.Text.Json.JsonElement option
        ResultPosition: EqlSearch.ResultPosition option
        RuntimeMappings: CoreTypes.RuntimeFields option
        MaxSamplesPerKey: CoreTypes.Integer option
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

    type EqlSearchResponse = EqlTypes.EqlSearchResponseBase<EqlSearchResponse.TEvent>

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
                KeepAlive = None
                KeepOnCompletion = None
                WaitForCompletionTimeout = None
                AllowPartialSearchResults = None
                AllowPartialSequenceResults = None
                Size = None
                Fields = None
                ResultPosition = None
                RuntimeMappings = None
                MaxSamplesPerKey = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: EqlSearchRequest, value: CoreTypes.Indices) =
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
        member _.ExpandWildcards(state: EqlSearchRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: EqlSearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: EqlSearchRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EqlSearchRequest, value: CoreTypes.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("keepOnCompletion")>]
        member _.KeepOnCompletion(state: EqlSearchRequest, value: bool) =
            { state with KeepOnCompletion = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EqlSearchRequest, value: CoreTypes.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: EqlSearchRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: EqlSearchRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("caseSensitive")>]
        member _.CaseSensitive(state: EqlSearchRequest, value: bool) =
            { state with CaseSensitive = Some value }

        [<CustomOperation("eventCategoryField")>]
        member _.EventCategoryField(state: EqlSearchRequest, value: CoreTypes.Field) =
            { state with EventCategoryField = Some value }

        [<CustomOperation("tiebreakerField")>]
        member _.TiebreakerField(state: EqlSearchRequest, value: CoreTypes.Field) =
            { state with TiebreakerField = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: EqlSearchRequest, value: CoreTypes.Field) =
            { state with TimestampField = Some value }

        [<CustomOperation("fetchSize")>]
        member _.FetchSize(state: EqlSearchRequest, value: CoreTypes.Uint) =
            { state with FetchSize = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: EqlSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EqlSearchRequest, value: CoreTypes.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("keepOnCompletion")>]
        member _.KeepOnCompletion(state: EqlSearchRequest, value: bool) =
            { state with KeepOnCompletion = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EqlSearchRequest, value: CoreTypes.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: EqlSearchRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("allowPartialSequenceResults")>]
        member _.AllowPartialSequenceResults(state: EqlSearchRequest, value: bool) =
            { state with AllowPartialSequenceResults = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: EqlSearchRequest, value: CoreTypes.Uint) =
            { state with Size = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: EqlSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Fields = Some value }

        [<CustomOperation("resultPosition")>]
        member _.ResultPosition(state: EqlSearchRequest, value: EqlSearch.ResultPosition) =
            { state with ResultPosition = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: EqlSearchRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("maxSamplesPerKey")>]
        member _.MaxSamplesPerKey(state: EqlSearchRequest, value: CoreTypes.Integer) =
            { state with MaxSamplesPerKey = Some value }

    let eqlSearchRequest = EqlSearchRequestBuilder()

    module Search =
        let withAllowNoIndices (value: bool) (req: EqlSearchRequest) =
            { req with AllowNoIndices = Some value }
        let withAllowPartialSearchResults (value: bool) (req: EqlSearchRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withAllowPartialSequenceResults (value: bool) (req: EqlSearchRequest) =
            { req with AllowPartialSequenceResults = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: EqlSearchRequest) =
            { req with ExpandWildcards = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: EqlSearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withIgnoreUnavailable (value: bool) (req: EqlSearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withKeepAlive (value: CoreTypes.Duration) (req: EqlSearchRequest) =
            { req with KeepAlive = Some value }
        let withKeepOnCompletion (value: bool) (req: EqlSearchRequest) =
            { req with KeepOnCompletion = Some value }
        let withWaitForCompletionTimeout (value: CoreTypes.Duration) (req: EqlSearchRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: EqlSearchRequest) =
            { req with ProjectRouting = Some value }
        let withQuery (value: string) (req: EqlSearchRequest) =
            { req with Query = value }
        let withCaseSensitive (value: bool) (req: EqlSearchRequest) =
            { req with CaseSensitive = Some value }
        let withEventCategoryField (value: CoreTypes.Field) (req: EqlSearchRequest) =
            { req with EventCategoryField = Some value }
        let withTiebreakerField (value: CoreTypes.Field) (req: EqlSearchRequest) =
            { req with TiebreakerField = Some value }
        let withTimestampField (value: CoreTypes.Field) (req: EqlSearchRequest) =
            { req with TimestampField = Some value }
        let withFetchSize (value: CoreTypes.Uint) (req: EqlSearchRequest) =
            { req with FetchSize = Some value }
        let withFilter (value: System.Text.Json.JsonElement) (req: EqlSearchRequest) =
            { req with Filter = Some value }
        let withKeepAlive (value: CoreTypes.Duration) (req: EqlSearchRequest) =
            { req with KeepAlive = Some value }
        let withKeepOnCompletion (value: bool) (req: EqlSearchRequest) =
            { req with KeepOnCompletion = Some value }
        let withWaitForCompletionTimeout (value: CoreTypes.Duration) (req: EqlSearchRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withAllowPartialSearchResults (value: bool) (req: EqlSearchRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withAllowPartialSequenceResults (value: bool) (req: EqlSearchRequest) =
            { req with AllowPartialSequenceResults = Some value }
        let withSize (value: CoreTypes.Uint) (req: EqlSearchRequest) =
            { req with Size = Some value }
        let withFields (value: System.Text.Json.JsonElement) (req: EqlSearchRequest) =
            { req with Fields = Some value }
        let withResultPosition (value: EqlSearch.ResultPosition) (req: EqlSearchRequest) =
            { req with ResultPosition = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: EqlSearchRequest) =
            { req with RuntimeMappings = Some value }
        let withMaxSamplesPerKey (value: CoreTypes.Integer) (req: EqlSearchRequest) =
            { req with MaxSamplesPerKey = Some value }

