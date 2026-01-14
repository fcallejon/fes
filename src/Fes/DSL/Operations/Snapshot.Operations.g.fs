// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SnapshotOperations =

    type SnapshotCleanupRepositoryRequest = {
        Repository: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SnapshotCleanupRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/_cleanup"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module SnapshotCleanupRepositoryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotCleanupRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotCleanupRepositoryRequest.ToRequest request

    type SnapshotCleanupRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCleanupRepositoryRequest =
            {
                SnapshotCleanupRepositoryRequest.Repository = Unchecked.defaultof<Name>
                SnapshotCleanupRepositoryRequest.MasterTimeout = Option.None
                SnapshotCleanupRepositoryRequest.Timeout = Option.None
            } : SnapshotCleanupRepositoryRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCleanupRepositoryRequest, value: Name) =
            { state with SnapshotCleanupRepositoryRequest.Repository = value } : SnapshotCleanupRepositoryRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotCleanupRepositoryRequest, value: Duration) =
            { state with SnapshotCleanupRepositoryRequest.MasterTimeout = Option.Some value } : SnapshotCleanupRepositoryRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotCleanupRepositoryRequest, value: Duration) =
            { state with SnapshotCleanupRepositoryRequest.Timeout = Option.Some value } : SnapshotCleanupRepositoryRequest

    let snapshotCleanupRepositoryRequest = SnapshotCleanupRepositoryRequestBuilder()

    type SnapshotCleanupRepositoryResponse = {
        [<JsonPropertyName("results")>]
        Results: CleanupRepositoryCleanupRepositoryResults
    }

    type SnapshotCloneRequest = {
        Repository: Name
        Snapshot: Name
        TargetSnapshot: Name
        MasterTimeout: Duration option
        [<JsonPropertyName("indices")>]
        Indices: string
    } with
        static member ToRequest(request: SnapshotCloneRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}/_clone/{request.TargetSnapshot}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``indices`` = request.Indices |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SnapshotCloneRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotCloneRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotCloneRequest.ToRequest request

    type SnapshotCloneRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCloneRequest =
            {
                SnapshotCloneRequest.Repository = Unchecked.defaultof<Name>
                SnapshotCloneRequest.Snapshot = Unchecked.defaultof<Name>
                SnapshotCloneRequest.TargetSnapshot = Unchecked.defaultof<Name>
                SnapshotCloneRequest.MasterTimeout = Option.None
                SnapshotCloneRequest.Indices = String.Empty
            } : SnapshotCloneRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCloneRequest, value: Name) =
            { state with SnapshotCloneRequest.Repository = value } : SnapshotCloneRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotCloneRequest, value: Name) =
            { state with SnapshotCloneRequest.Snapshot = value } : SnapshotCloneRequest

        [<CustomOperation("target_snapshot")>]
        member _.TargetSnapshot(state: SnapshotCloneRequest, value: Name) =
            { state with SnapshotCloneRequest.TargetSnapshot = value } : SnapshotCloneRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotCloneRequest, value: Duration) =
            { state with SnapshotCloneRequest.MasterTimeout = Option.Some value } : SnapshotCloneRequest

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotCloneRequest, value: string) =
            { state with SnapshotCloneRequest.Indices = value } : SnapshotCloneRequest

    let snapshotCloneRequest = SnapshotCloneRequestBuilder()

    type SnapshotCloneResponse = AcknowledgedResponseBase

    type SnapshotGetRequest = {
        Repository: Name
        Snapshot: Names
        After: string option
        FromSortValue: string option
        IgnoreUnavailable: bool option
        IndexDetails: bool option
        IndexNames: bool option
        IncludeRepository: bool option
        MasterTimeout: Duration option
        Order: SortOrder option
        Offset: float option
        Size: float option
        SlmPolicyFilter: Name option
        Sort: TypesSnapshotSort option
        State: System.Text.Json.JsonElement option
        Verbose: bool option
    } with
        static member ToRequest(request: SnapshotGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}"
                let queryParams =
                    [
                        request.After |> Option.map (fun v -> "after", Fes.Http.toQueryValue v)
                        request.FromSortValue |> Option.map (fun v -> "from_sort_value", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.IndexDetails |> Option.map (fun v -> "index_details", Fes.Http.toQueryValue v)
                        request.IndexNames |> Option.map (fun v -> "index_names", Fes.Http.toQueryValue v)
                        request.IncludeRepository |> Option.map (fun v -> "include_repository", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Order |> Option.map (fun v -> "order", Fes.Http.toQueryValue v)
                        request.Offset |> Option.map (fun v -> "offset", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.SlmPolicyFilter |> Option.map (fun v -> "slm_policy_filter", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.State |> Option.map (fun v -> "state", Fes.Http.toQueryValue v)
                        request.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
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

    module SnapshotGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotGetRequest.ToRequest request

    type SnapshotGetRequestBuilder() =
        member _.Yield(_: unit) : SnapshotGetRequest =
            {
                SnapshotGetRequest.Repository = Unchecked.defaultof<Name>
                SnapshotGetRequest.Snapshot = Unchecked.defaultof<Names>
                SnapshotGetRequest.After = Option.None
                SnapshotGetRequest.FromSortValue = Option.None
                SnapshotGetRequest.IgnoreUnavailable = Option.None
                SnapshotGetRequest.IndexDetails = Option.None
                SnapshotGetRequest.IndexNames = Option.None
                SnapshotGetRequest.IncludeRepository = Option.None
                SnapshotGetRequest.MasterTimeout = Option.None
                SnapshotGetRequest.Order = Option.None
                SnapshotGetRequest.Offset = Option.None
                SnapshotGetRequest.Size = Option.None
                SnapshotGetRequest.SlmPolicyFilter = Option.None
                SnapshotGetRequest.Sort = Option.None
                SnapshotGetRequest.State = Option.None
                SnapshotGetRequest.Verbose = Option.None
            } : SnapshotGetRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotGetRequest, value: Name) =
            { state with SnapshotGetRequest.Repository = value } : SnapshotGetRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotGetRequest, value: Names) =
            { state with SnapshotGetRequest.Snapshot = value } : SnapshotGetRequest

        [<CustomOperation("after")>]
        member _.After(state: SnapshotGetRequest, value: string) =
            { state with SnapshotGetRequest.After = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("from_sort_value")>]
        member _.FromSortValue(state: SnapshotGetRequest, value: string) =
            { state with SnapshotGetRequest.FromSortValue = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SnapshotGetRequest, value: bool) =
            { state with SnapshotGetRequest.IgnoreUnavailable = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("index_details")>]
        member _.IndexDetails(state: SnapshotGetRequest, value: bool) =
            { state with SnapshotGetRequest.IndexDetails = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("index_names")>]
        member _.IndexNames(state: SnapshotGetRequest, value: bool) =
            { state with SnapshotGetRequest.IndexNames = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("include_repository")>]
        member _.IncludeRepository(state: SnapshotGetRequest, value: bool) =
            { state with SnapshotGetRequest.IncludeRepository = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotGetRequest, value: Duration) =
            { state with SnapshotGetRequest.MasterTimeout = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("order")>]
        member _.Order(state: SnapshotGetRequest, value: SortOrder) =
            { state with SnapshotGetRequest.Order = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("offset")>]
        member _.Offset(state: SnapshotGetRequest, value: float) =
            { state with SnapshotGetRequest.Offset = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("size")>]
        member _.Size(state: SnapshotGetRequest, value: float) =
            { state with SnapshotGetRequest.Size = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("slm_policy_filter")>]
        member _.SlmPolicyFilter(state: SnapshotGetRequest, value: Name) =
            { state with SnapshotGetRequest.SlmPolicyFilter = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: SnapshotGetRequest, value: TypesSnapshotSort) =
            { state with SnapshotGetRequest.Sort = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("state")>]
        member _.State(state: SnapshotGetRequest, value: System.Text.Json.JsonElement) =
            { state with SnapshotGetRequest.State = Option.Some value } : SnapshotGetRequest

        [<CustomOperation("verbose")>]
        member _.Verbose(state: SnapshotGetRequest, value: bool) =
            { state with SnapshotGetRequest.Verbose = Option.Some value } : SnapshotGetRequest

    let snapshotGetRequest = SnapshotGetRequestBuilder()

    type SnapshotGetResponse = {
        [<JsonPropertyName("remaining")>]
        Remaining: float
        [<JsonPropertyName("total")>]
        Total: float
        [<JsonPropertyName("next")>]
        Next: string option
        [<JsonPropertyName("responses")>]
        Responses: GetSnapshotResponseItem array option
        [<JsonPropertyName("snapshots")>]
        Snapshots: TypesSnapshotInfo array option
    }

    type SnapshotCreateRequest = {
        Repository: Name
        Snapshot: Name
        MasterTimeout: Duration option
        WaitForCompletion: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("feature_states")>]
        FeatureStates: string array option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<JsonPropertyName("indices")>]
        Indices: Indices option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("partial")>]
        Partial: bool option
    } with
        static member ToRequest(request: SnapshotCreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``expand_wildcards`` = request.ExpandWildcards; ``feature_states`` = request.FeatureStates; ``ignore_unavailable`` = request.IgnoreUnavailable; ``include_global_state`` = request.IncludeGlobalState; ``indices`` = request.Indices; ``metadata`` = request.Metadata; ``partial`` = request.Partial |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SnapshotCreateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotCreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotCreateRequest.ToRequest request

    type SnapshotCreateRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCreateRequest =
            {
                SnapshotCreateRequest.Repository = Unchecked.defaultof<Name>
                SnapshotCreateRequest.Snapshot = Unchecked.defaultof<Name>
                SnapshotCreateRequest.MasterTimeout = Option.None
                SnapshotCreateRequest.WaitForCompletion = Option.None
                SnapshotCreateRequest.ExpandWildcards = Option.None
                SnapshotCreateRequest.FeatureStates = Option.None
                SnapshotCreateRequest.IgnoreUnavailable = Option.None
                SnapshotCreateRequest.IncludeGlobalState = Option.None
                SnapshotCreateRequest.Indices = Option.None
                SnapshotCreateRequest.Metadata = Option.None
                SnapshotCreateRequest.Partial = Option.None
            } : SnapshotCreateRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCreateRequest, value: Name) =
            { state with SnapshotCreateRequest.Repository = value } : SnapshotCreateRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotCreateRequest, value: Name) =
            { state with SnapshotCreateRequest.Snapshot = value } : SnapshotCreateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotCreateRequest, value: Duration) =
            { state with SnapshotCreateRequest.MasterTimeout = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: SnapshotCreateRequest, value: bool) =
            { state with SnapshotCreateRequest.WaitForCompletion = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: SnapshotCreateRequest, value: ExpandWildcards) =
            { state with SnapshotCreateRequest.ExpandWildcards = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("feature_states")>]
        member _.FeatureStates(state: SnapshotCreateRequest, value: string array) =
            { state with SnapshotCreateRequest.FeatureStates = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SnapshotCreateRequest, value: bool) =
            { state with SnapshotCreateRequest.IgnoreUnavailable = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("include_global_state")>]
        member _.IncludeGlobalState(state: SnapshotCreateRequest, value: bool) =
            { state with SnapshotCreateRequest.IncludeGlobalState = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotCreateRequest, value: Indices) =
            { state with SnapshotCreateRequest.Indices = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SnapshotCreateRequest, value: Metadata) =
            { state with SnapshotCreateRequest.Metadata = Option.Some value } : SnapshotCreateRequest

        [<CustomOperation("partial")>]
        member _.Partial(state: SnapshotCreateRequest, value: bool) =
            { state with SnapshotCreateRequest.Partial = Option.Some value } : SnapshotCreateRequest

    let snapshotCreateRequest = SnapshotCreateRequestBuilder()

    type SnapshotDeleteRequest = {
        Repository: Name
        Snapshot: Names
        MasterTimeout: Duration option
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: SnapshotDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    module SnapshotDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotDeleteRequest.ToRequest request

    type SnapshotDeleteRequestBuilder() =
        member _.Yield(_: unit) : SnapshotDeleteRequest =
            {
                SnapshotDeleteRequest.Repository = Unchecked.defaultof<Name>
                SnapshotDeleteRequest.Snapshot = Unchecked.defaultof<Names>
                SnapshotDeleteRequest.MasterTimeout = Option.None
                SnapshotDeleteRequest.WaitForCompletion = Option.None
            } : SnapshotDeleteRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotDeleteRequest, value: Name) =
            { state with SnapshotDeleteRequest.Repository = value } : SnapshotDeleteRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotDeleteRequest, value: Names) =
            { state with SnapshotDeleteRequest.Snapshot = value } : SnapshotDeleteRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotDeleteRequest, value: Duration) =
            { state with SnapshotDeleteRequest.MasterTimeout = Option.Some value } : SnapshotDeleteRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: SnapshotDeleteRequest, value: bool) =
            { state with SnapshotDeleteRequest.WaitForCompletion = Option.Some value } : SnapshotDeleteRequest

    let snapshotDeleteRequest = SnapshotDeleteRequestBuilder()

    type SnapshotDeleteResponse = AcknowledgedResponseBase

    type SnapshotGetRepositoryRequest = {
        Repository: Names
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: SnapshotGetRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}"
                let queryParams =
                    [
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module SnapshotGetRepositoryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotGetRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotGetRepositoryRequest.ToRequest request

    type SnapshotGetRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotGetRepositoryRequest =
            {
                SnapshotGetRepositoryRequest.Repository = Unchecked.defaultof<Names>
                SnapshotGetRepositoryRequest.Local = Option.None
                SnapshotGetRepositoryRequest.MasterTimeout = Option.None
            } : SnapshotGetRepositoryRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotGetRepositoryRequest, value: Names) =
            { state with SnapshotGetRepositoryRequest.Repository = value } : SnapshotGetRepositoryRequest

        [<CustomOperation("local")>]
        member _.Local(state: SnapshotGetRepositoryRequest, value: bool) =
            { state with SnapshotGetRepositoryRequest.Local = Option.Some value } : SnapshotGetRepositoryRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotGetRepositoryRequest, value: Duration) =
            { state with SnapshotGetRepositoryRequest.MasterTimeout = Option.Some value } : SnapshotGetRepositoryRequest

    let snapshotGetRepositoryRequest = SnapshotGetRepositoryRequestBuilder()

    type SnapshotCreateRepositoryRequest = {
        Repository: Name
        MasterTimeout: Duration option
        Timeout: Duration option
        Verify: bool option
        [<JsonPropertyName("body")>]
        Body: TypesRepository
    } with
        static member ToRequest(request: SnapshotCreateRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Verify |> Option.map (fun v -> "verify", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module SnapshotCreateRepositoryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotCreateRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotCreateRepositoryRequest.ToRequest request

    type SnapshotCreateRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCreateRepositoryRequest =
            {
                SnapshotCreateRepositoryRequest.Repository = Unchecked.defaultof<Name>
                SnapshotCreateRepositoryRequest.MasterTimeout = Option.None
                SnapshotCreateRepositoryRequest.Timeout = Option.None
                SnapshotCreateRepositoryRequest.Verify = Option.None
                SnapshotCreateRepositoryRequest.Body = Unchecked.defaultof<TypesRepository>
            } : SnapshotCreateRepositoryRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCreateRepositoryRequest, value: Name) =
            { state with SnapshotCreateRepositoryRequest.Repository = value } : SnapshotCreateRepositoryRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotCreateRepositoryRequest, value: Duration) =
            { state with SnapshotCreateRepositoryRequest.MasterTimeout = Option.Some value } : SnapshotCreateRepositoryRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotCreateRepositoryRequest, value: Duration) =
            { state with SnapshotCreateRepositoryRequest.Timeout = Option.Some value } : SnapshotCreateRepositoryRequest

        [<CustomOperation("verify")>]
        member _.Verify(state: SnapshotCreateRepositoryRequest, value: bool) =
            { state with SnapshotCreateRepositoryRequest.Verify = Option.Some value } : SnapshotCreateRepositoryRequest

        [<CustomOperation("body")>]
        member _.Body(state: SnapshotCreateRepositoryRequest, value: TypesRepository) =
            { state with SnapshotCreateRepositoryRequest.Body = value } : SnapshotCreateRepositoryRequest

    let snapshotCreateRepositoryRequest = SnapshotCreateRepositoryRequestBuilder()

    type SnapshotDeleteRepositoryRequest = {
        Repository: Names
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SnapshotDeleteRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module SnapshotDeleteRepositoryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotDeleteRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotDeleteRepositoryRequest.ToRequest request

    type SnapshotDeleteRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotDeleteRepositoryRequest =
            {
                SnapshotDeleteRepositoryRequest.Repository = Unchecked.defaultof<Names>
                SnapshotDeleteRepositoryRequest.MasterTimeout = Option.None
                SnapshotDeleteRepositoryRequest.Timeout = Option.None
            } : SnapshotDeleteRepositoryRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotDeleteRepositoryRequest, value: Names) =
            { state with SnapshotDeleteRepositoryRequest.Repository = value } : SnapshotDeleteRepositoryRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotDeleteRepositoryRequest, value: Duration) =
            { state with SnapshotDeleteRepositoryRequest.MasterTimeout = Option.Some value } : SnapshotDeleteRepositoryRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotDeleteRepositoryRequest, value: Duration) =
            { state with SnapshotDeleteRepositoryRequest.Timeout = Option.Some value } : SnapshotDeleteRepositoryRequest

    let snapshotDeleteRepositoryRequest = SnapshotDeleteRepositoryRequestBuilder()

    type SnapshotDeleteRepositoryResponse = AcknowledgedResponseBase

    type SnapshotRepositoryAnalyzeRequest = {
        Repository: Name
        BlobCount: float option
        Concurrency: float option
        Detailed: bool option
        EarlyReadNodeCount: float option
        MaxBlobSize: ByteSize option
        MaxTotalDataSize: ByteSize option
        RareActionProbability: float option
        RarelyAbortWrites: bool option
        ReadNodeCount: float option
        RegisterOperationCount: float option
        Seed: float option
        Timeout: Duration option
    } with
        static member ToRequest(request: SnapshotRepositoryAnalyzeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/_analyze"
                let queryParams =
                    [
                        request.BlobCount |> Option.map (fun v -> "blob_count", Fes.Http.toQueryValue v)
                        request.Concurrency |> Option.map (fun v -> "concurrency", Fes.Http.toQueryValue v)
                        request.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                        request.EarlyReadNodeCount |> Option.map (fun v -> "early_read_node_count", Fes.Http.toQueryValue v)
                        request.MaxBlobSize |> Option.map (fun v -> "max_blob_size", Fes.Http.toQueryValue v)
                        request.MaxTotalDataSize |> Option.map (fun v -> "max_total_data_size", Fes.Http.toQueryValue v)
                        request.RareActionProbability |> Option.map (fun v -> "rare_action_probability", Fes.Http.toQueryValue v)
                        request.RarelyAbortWrites |> Option.map (fun v -> "rarely_abort_writes", Fes.Http.toQueryValue v)
                        request.ReadNodeCount |> Option.map (fun v -> "read_node_count", Fes.Http.toQueryValue v)
                        request.RegisterOperationCount |> Option.map (fun v -> "register_operation_count", Fes.Http.toQueryValue v)
                        request.Seed |> Option.map (fun v -> "seed", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module SnapshotRepositoryAnalyzeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotRepositoryAnalyzeRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotRepositoryAnalyzeRequest.ToRequest request

    type SnapshotRepositoryAnalyzeRequestBuilder() =
        member _.Yield(_: unit) : SnapshotRepositoryAnalyzeRequest =
            {
                SnapshotRepositoryAnalyzeRequest.Repository = Unchecked.defaultof<Name>
                SnapshotRepositoryAnalyzeRequest.BlobCount = Option.None
                SnapshotRepositoryAnalyzeRequest.Concurrency = Option.None
                SnapshotRepositoryAnalyzeRequest.Detailed = Option.None
                SnapshotRepositoryAnalyzeRequest.EarlyReadNodeCount = Option.None
                SnapshotRepositoryAnalyzeRequest.MaxBlobSize = Option.None
                SnapshotRepositoryAnalyzeRequest.MaxTotalDataSize = Option.None
                SnapshotRepositoryAnalyzeRequest.RareActionProbability = Option.None
                SnapshotRepositoryAnalyzeRequest.RarelyAbortWrites = Option.None
                SnapshotRepositoryAnalyzeRequest.ReadNodeCount = Option.None
                SnapshotRepositoryAnalyzeRequest.RegisterOperationCount = Option.None
                SnapshotRepositoryAnalyzeRequest.Seed = Option.None
                SnapshotRepositoryAnalyzeRequest.Timeout = Option.None
            } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotRepositoryAnalyzeRequest, value: Name) =
            { state with SnapshotRepositoryAnalyzeRequest.Repository = value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("blob_count")>]
        member _.BlobCount(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.BlobCount = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("concurrency")>]
        member _.Concurrency(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.Concurrency = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("detailed")>]
        member _.Detailed(state: SnapshotRepositoryAnalyzeRequest, value: bool) =
            { state with SnapshotRepositoryAnalyzeRequest.Detailed = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("early_read_node_count")>]
        member _.EarlyReadNodeCount(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.EarlyReadNodeCount = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("max_blob_size")>]
        member _.MaxBlobSize(state: SnapshotRepositoryAnalyzeRequest, value: ByteSize) =
            { state with SnapshotRepositoryAnalyzeRequest.MaxBlobSize = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("max_total_data_size")>]
        member _.MaxTotalDataSize(state: SnapshotRepositoryAnalyzeRequest, value: ByteSize) =
            { state with SnapshotRepositoryAnalyzeRequest.MaxTotalDataSize = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("rare_action_probability")>]
        member _.RareActionProbability(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.RareActionProbability = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("rarely_abort_writes")>]
        member _.RarelyAbortWrites(state: SnapshotRepositoryAnalyzeRequest, value: bool) =
            { state with SnapshotRepositoryAnalyzeRequest.RarelyAbortWrites = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("read_node_count")>]
        member _.ReadNodeCount(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.ReadNodeCount = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("register_operation_count")>]
        member _.RegisterOperationCount(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.RegisterOperationCount = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("seed")>]
        member _.Seed(state: SnapshotRepositoryAnalyzeRequest, value: float) =
            { state with SnapshotRepositoryAnalyzeRequest.Seed = Option.Some value } : SnapshotRepositoryAnalyzeRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotRepositoryAnalyzeRequest, value: Duration) =
            { state with SnapshotRepositoryAnalyzeRequest.Timeout = Option.Some value } : SnapshotRepositoryAnalyzeRequest

    let snapshotRepositoryAnalyzeRequest = SnapshotRepositoryAnalyzeRequestBuilder()

    type SnapshotRepositoryAnalyzeResponse = {
        [<JsonPropertyName("blob_count")>]
        BlobCount: float
        [<JsonPropertyName("blob_path")>]
        BlobPath: string
        [<JsonPropertyName("concurrency")>]
        Concurrency: float
        [<JsonPropertyName("coordinating_node")>]
        CoordinatingNode: RepositoryAnalyzeSnapshotNodeInfo
        [<JsonPropertyName("delete_elapsed")>]
        DeleteElapsed: Duration
        [<JsonPropertyName("delete_elapsed_nanos")>]
        DeleteElapsedNanos: DurationValueUnitNanos
        [<JsonPropertyName("details")>]
        Details: RepositoryAnalyzeDetailsInfo
        [<JsonPropertyName("early_read_node_count")>]
        EarlyReadNodeCount: float
        [<JsonPropertyName("issues_detected")>]
        IssuesDetected: string array
        [<JsonPropertyName("listing_elapsed")>]
        ListingElapsed: Duration
        [<JsonPropertyName("listing_elapsed_nanos")>]
        ListingElapsedNanos: DurationValueUnitNanos
        [<JsonPropertyName("max_blob_size")>]
        MaxBlobSize: ByteSize
        [<JsonPropertyName("max_blob_size_bytes")>]
        MaxBlobSizeBytes: float
        [<JsonPropertyName("max_total_data_size")>]
        MaxTotalDataSize: ByteSize
        [<JsonPropertyName("max_total_data_size_bytes")>]
        MaxTotalDataSizeBytes: float
        [<JsonPropertyName("rare_action_probability")>]
        RareActionProbability: float
        [<JsonPropertyName("read_node_count")>]
        ReadNodeCount: float
        [<JsonPropertyName("repository")>]
        Repository: string
        [<JsonPropertyName("seed")>]
        Seed: float
        [<JsonPropertyName("summary")>]
        Summary: RepositoryAnalyzeSummaryInfo
    }

    type SnapshotRepositoryVerifyIntegrityRequest = {
        Repository: Names
        BlobThreadPoolConcurrency: float option
        IndexSnapshotVerificationConcurrency: float option
        IndexVerificationConcurrency: float option
        MaxBytesPerSec: string option
        MaxFailedShardSnapshots: float option
        MetaThreadPoolConcurrency: float option
        SnapshotVerificationConcurrency: float option
        VerifyBlobContents: bool option
    } with
        static member ToRequest(request: SnapshotRepositoryVerifyIntegrityRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/_verify_integrity"
                let queryParams =
                    [
                        request.BlobThreadPoolConcurrency |> Option.map (fun v -> "blob_thread_pool_concurrency", Fes.Http.toQueryValue v)
                        request.IndexSnapshotVerificationConcurrency |> Option.map (fun v -> "index_snapshot_verification_concurrency", Fes.Http.toQueryValue v)
                        request.IndexVerificationConcurrency |> Option.map (fun v -> "index_verification_concurrency", Fes.Http.toQueryValue v)
                        request.MaxBytesPerSec |> Option.map (fun v -> "max_bytes_per_sec", Fes.Http.toQueryValue v)
                        request.MaxFailedShardSnapshots |> Option.map (fun v -> "max_failed_shard_snapshots", Fes.Http.toQueryValue v)
                        request.MetaThreadPoolConcurrency |> Option.map (fun v -> "meta_thread_pool_concurrency", Fes.Http.toQueryValue v)
                        request.SnapshotVerificationConcurrency |> Option.map (fun v -> "snapshot_verification_concurrency", Fes.Http.toQueryValue v)
                        request.VerifyBlobContents |> Option.map (fun v -> "verify_blob_contents", Fes.Http.toQueryValue v)
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

    module SnapshotRepositoryVerifyIntegrityRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotRepositoryVerifyIntegrityRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotRepositoryVerifyIntegrityRequest.ToRequest request

    type SnapshotRepositoryVerifyIntegrityRequestBuilder() =
        member _.Yield(_: unit) : SnapshotRepositoryVerifyIntegrityRequest =
            {
                SnapshotRepositoryVerifyIntegrityRequest.Repository = Unchecked.defaultof<Names>
                SnapshotRepositoryVerifyIntegrityRequest.BlobThreadPoolConcurrency = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.IndexSnapshotVerificationConcurrency = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.IndexVerificationConcurrency = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.MaxBytesPerSec = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.MaxFailedShardSnapshots = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.MetaThreadPoolConcurrency = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.SnapshotVerificationConcurrency = Option.None
                SnapshotRepositoryVerifyIntegrityRequest.VerifyBlobContents = Option.None
            } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotRepositoryVerifyIntegrityRequest, value: Names) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.Repository = value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("blob_thread_pool_concurrency")>]
        member _.BlobThreadPoolConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: float) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.BlobThreadPoolConcurrency = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("index_snapshot_verification_concurrency")>]
        member _.IndexSnapshotVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: float) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.IndexSnapshotVerificationConcurrency = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("index_verification_concurrency")>]
        member _.IndexVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: float) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.IndexVerificationConcurrency = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("max_bytes_per_sec")>]
        member _.MaxBytesPerSec(state: SnapshotRepositoryVerifyIntegrityRequest, value: string) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.MaxBytesPerSec = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("max_failed_shard_snapshots")>]
        member _.MaxFailedShardSnapshots(state: SnapshotRepositoryVerifyIntegrityRequest, value: float) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.MaxFailedShardSnapshots = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("meta_thread_pool_concurrency")>]
        member _.MetaThreadPoolConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: float) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.MetaThreadPoolConcurrency = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("snapshot_verification_concurrency")>]
        member _.SnapshotVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: float) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.SnapshotVerificationConcurrency = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

        [<CustomOperation("verify_blob_contents")>]
        member _.VerifyBlobContents(state: SnapshotRepositoryVerifyIntegrityRequest, value: bool) =
            { state with SnapshotRepositoryVerifyIntegrityRequest.VerifyBlobContents = Option.Some value } : SnapshotRepositoryVerifyIntegrityRequest

    let snapshotRepositoryVerifyIntegrityRequest = SnapshotRepositoryVerifyIntegrityRequestBuilder()

    type SnapshotRestoreRequest = {
        Repository: Name
        Snapshot: Name
        MasterTimeout: Duration option
        WaitForCompletion: bool option
        [<JsonPropertyName("feature_states")>]
        FeatureStates: string array option
        [<JsonPropertyName("ignore_index_settings")>]
        IgnoreIndexSettings: string array option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("include_aliases")>]
        IncludeAliases: bool option
        [<JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<JsonPropertyName("index_settings")>]
        IndexSettings: TypesIndexSettings option
        [<JsonPropertyName("indices")>]
        Indices: Indices option
        [<JsonPropertyName("partial")>]
        Partial: bool option
        [<JsonPropertyName("rename_pattern")>]
        RenamePattern: string option
        [<JsonPropertyName("rename_replacement")>]
        RenameReplacement: string option
    } with
        static member ToRequest(request: SnapshotRestoreRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}/_restore"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``feature_states`` = request.FeatureStates; ``ignore_index_settings`` = request.IgnoreIndexSettings; ``ignore_unavailable`` = request.IgnoreUnavailable; ``include_aliases`` = request.IncludeAliases; ``include_global_state`` = request.IncludeGlobalState; ``index_settings`` = request.IndexSettings; ``indices`` = request.Indices; ``partial`` = request.Partial; ``rename_pattern`` = request.RenamePattern; ``rename_replacement`` = request.RenameReplacement |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SnapshotRestoreRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotRestoreRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotRestoreRequest.ToRequest request

    type SnapshotRestoreRequestBuilder() =
        member _.Yield(_: unit) : SnapshotRestoreRequest =
            {
                SnapshotRestoreRequest.Repository = Unchecked.defaultof<Name>
                SnapshotRestoreRequest.Snapshot = Unchecked.defaultof<Name>
                SnapshotRestoreRequest.MasterTimeout = Option.None
                SnapshotRestoreRequest.WaitForCompletion = Option.None
                SnapshotRestoreRequest.FeatureStates = Option.None
                SnapshotRestoreRequest.IgnoreIndexSettings = Option.None
                SnapshotRestoreRequest.IgnoreUnavailable = Option.None
                SnapshotRestoreRequest.IncludeAliases = Option.None
                SnapshotRestoreRequest.IncludeGlobalState = Option.None
                SnapshotRestoreRequest.IndexSettings = Option.None
                SnapshotRestoreRequest.Indices = Option.None
                SnapshotRestoreRequest.Partial = Option.None
                SnapshotRestoreRequest.RenamePattern = Option.None
                SnapshotRestoreRequest.RenameReplacement = Option.None
            } : SnapshotRestoreRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotRestoreRequest, value: Name) =
            { state with SnapshotRestoreRequest.Repository = value } : SnapshotRestoreRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotRestoreRequest, value: Name) =
            { state with SnapshotRestoreRequest.Snapshot = value } : SnapshotRestoreRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotRestoreRequest, value: Duration) =
            { state with SnapshotRestoreRequest.MasterTimeout = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: SnapshotRestoreRequest, value: bool) =
            { state with SnapshotRestoreRequest.WaitForCompletion = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("feature_states")>]
        member _.FeatureStates(state: SnapshotRestoreRequest, value: string array) =
            { state with SnapshotRestoreRequest.FeatureStates = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("ignore_index_settings")>]
        member _.IgnoreIndexSettings(state: SnapshotRestoreRequest, value: string array) =
            { state with SnapshotRestoreRequest.IgnoreIndexSettings = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SnapshotRestoreRequest, value: bool) =
            { state with SnapshotRestoreRequest.IgnoreUnavailable = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("include_aliases")>]
        member _.IncludeAliases(state: SnapshotRestoreRequest, value: bool) =
            { state with SnapshotRestoreRequest.IncludeAliases = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("include_global_state")>]
        member _.IncludeGlobalState(state: SnapshotRestoreRequest, value: bool) =
            { state with SnapshotRestoreRequest.IncludeGlobalState = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("index_settings")>]
        member _.IndexSettings(state: SnapshotRestoreRequest, value: TypesIndexSettings) =
            { state with SnapshotRestoreRequest.IndexSettings = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotRestoreRequest, value: Indices) =
            { state with SnapshotRestoreRequest.Indices = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("partial")>]
        member _.Partial(state: SnapshotRestoreRequest, value: bool) =
            { state with SnapshotRestoreRequest.Partial = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("rename_pattern")>]
        member _.RenamePattern(state: SnapshotRestoreRequest, value: string) =
            { state with SnapshotRestoreRequest.RenamePattern = Option.Some value } : SnapshotRestoreRequest

        [<CustomOperation("rename_replacement")>]
        member _.RenameReplacement(state: SnapshotRestoreRequest, value: string) =
            { state with SnapshotRestoreRequest.RenameReplacement = Option.Some value } : SnapshotRestoreRequest

    let snapshotRestoreRequest = SnapshotRestoreRequestBuilder()

    type SnapshotRestoreResponse = {
        [<JsonPropertyName("accepted")>]
        Accepted: bool option
        [<JsonPropertyName("snapshot")>]
        Snapshot: RestoreSnapshotRestore option
    }

    type SnapshotStatusRequest = {
        Repository: Name
        Snapshot: Names
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: SnapshotStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}/_status"
                let queryParams =
                    [
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module SnapshotStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotStatusRequest.ToRequest request

    type SnapshotStatusRequestBuilder() =
        member _.Yield(_: unit) : SnapshotStatusRequest =
            {
                SnapshotStatusRequest.Repository = Unchecked.defaultof<Name>
                SnapshotStatusRequest.Snapshot = Unchecked.defaultof<Names>
                SnapshotStatusRequest.IgnoreUnavailable = Option.None
                SnapshotStatusRequest.MasterTimeout = Option.None
            } : SnapshotStatusRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotStatusRequest, value: Name) =
            { state with SnapshotStatusRequest.Repository = value } : SnapshotStatusRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotStatusRequest, value: Names) =
            { state with SnapshotStatusRequest.Snapshot = value } : SnapshotStatusRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SnapshotStatusRequest, value: bool) =
            { state with SnapshotStatusRequest.IgnoreUnavailable = Option.Some value } : SnapshotStatusRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotStatusRequest, value: Duration) =
            { state with SnapshotStatusRequest.MasterTimeout = Option.Some value } : SnapshotStatusRequest

    let snapshotStatusRequest = SnapshotStatusRequestBuilder()

    type SnapshotVerifyRepositoryRequest = {
        Repository: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SnapshotVerifyRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/_verify"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module SnapshotVerifyRepositoryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SnapshotVerifyRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SnapshotVerifyRepositoryRequest.ToRequest request

    type SnapshotVerifyRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotVerifyRepositoryRequest =
            {
                SnapshotVerifyRepositoryRequest.Repository = Unchecked.defaultof<Name>
                SnapshotVerifyRepositoryRequest.MasterTimeout = Option.None
                SnapshotVerifyRepositoryRequest.Timeout = Option.None
            } : SnapshotVerifyRepositoryRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotVerifyRepositoryRequest, value: Name) =
            { state with SnapshotVerifyRepositoryRequest.Repository = value } : SnapshotVerifyRepositoryRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SnapshotVerifyRepositoryRequest, value: Duration) =
            { state with SnapshotVerifyRepositoryRequest.MasterTimeout = Option.Some value } : SnapshotVerifyRepositoryRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotVerifyRepositoryRequest, value: Duration) =
            { state with SnapshotVerifyRepositoryRequest.Timeout = Option.Some value } : SnapshotVerifyRepositoryRequest

    let snapshotVerifyRepositoryRequest = SnapshotVerifyRepositoryRequestBuilder()

    type SnapshotVerifyRepositoryResponse = {
        [<JsonPropertyName("nodes")>]
        Nodes: Map<string, VerifyRepositoryCompactNodeInfo>
    }

