// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module SnapshotOperations =

    type SnapshotCleanupRepositoryRequest = {
        Repository: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SnapshotCleanupRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/_cleanup"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotCleanupRepositoryResponse = System.Text.Json.JsonElement

    type SnapshotCleanupRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCleanupRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCleanupRepositoryRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCleanupRepositoryRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotCleanupRepositoryRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let snapshotCleanupRepositoryRequest = SnapshotCleanupRepositoryRequestBuilder()

    module CleanupRepository =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotCleanupRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SnapshotCleanupRepositoryRequest) =
            { req with Timeout = Some value }

    type SnapshotCloneRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Name
        TargetSnapshot: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Indices: string
    }

        with
        static member ToRequest(req: SnapshotCloneRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}/_clone/{req.TargetSnapshot}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotCloneResponse = CoreTypes.AcknowledgedResponseBase

    type SnapshotCloneRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCloneRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                TargetSnapshot = Unchecked.defaultof<_>
                MasterTimeout = None
                Indices = Unchecked.defaultof<_>
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCloneRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotCloneRequest, value: CoreTypes.Name) =
            { state with Snapshot = value }

        [<CustomOperation("targetSnapshot")>]
        member _.TargetSnapshot(state: SnapshotCloneRequest, value: CoreTypes.Name) =
            { state with TargetSnapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCloneRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotCloneRequest, value: string) =
            { state with Indices = value }

    let snapshotCloneRequest = SnapshotCloneRequestBuilder()

    module Clone =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotCloneRequest) =
            { req with MasterTimeout = Some value }
        let withIndices (value: string) (req: SnapshotCloneRequest) =
            { req with Indices = value }

    type SnapshotCreateRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        WaitForCompletion: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        FeatureStates: string list option
        IgnoreUnavailable: bool option
        IncludeGlobalState: bool option
        Indices: CoreTypes.Indices option
        Metadata: CoreTypes.Metadata option
        Partial: bool option
    }

        with
        static member ToRequest(req: SnapshotCreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    type SnapshotCreateResponse = System.Text.Json.JsonElement

    type SnapshotCreateRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCreateRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
                ExpandWildcards = None
                FeatureStates = None
                IgnoreUnavailable = None
                IncludeGlobalState = None
                Indices = None
                Metadata = None
                Partial = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCreateRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotCreateRequest, value: CoreTypes.Name) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCreateRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: SnapshotCreateRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SnapshotCreateRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: SnapshotCreateRequest, value: string list) =
            { state with FeatureStates = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SnapshotCreateRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeGlobalState")>]
        member _.IncludeGlobalState(state: SnapshotCreateRequest, value: bool) =
            { state with IncludeGlobalState = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotCreateRequest, value: CoreTypes.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SnapshotCreateRequest, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("partial")>]
        member _.Partial(state: SnapshotCreateRequest, value: bool) =
            { state with Partial = Some value }

    let snapshotCreateRequest = SnapshotCreateRequestBuilder()

    module Create =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotCreateRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: SnapshotCreateRequest) =
            { req with WaitForCompletion = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: SnapshotCreateRequest) =
            { req with ExpandWildcards = Some value }
        let withFeatureStates (value: string list) (req: SnapshotCreateRequest) =
            { req with FeatureStates = Some value }
        let withIgnoreUnavailable (value: bool) (req: SnapshotCreateRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeGlobalState (value: bool) (req: SnapshotCreateRequest) =
            { req with IncludeGlobalState = Some value }
        let withIndices (value: CoreTypes.Indices) (req: SnapshotCreateRequest) =
            { req with Indices = Some value }
        let withMetadata (value: CoreTypes.Metadata) (req: SnapshotCreateRequest) =
            { req with Metadata = Some value }
        let withPartial (value: bool) (req: SnapshotCreateRequest) =
            { req with Partial = Some value }

    type SnapshotCreateRepositoryRequest = {
        Repository: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
        Verify: bool option
        Document: obj
    }

        with
        static member ToRequest(req: SnapshotCreateRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.Verify |> Option.map (fun v -> "verify", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotCreateRepositoryResponse = CoreTypes.AcknowledgedResponseBase

    type SnapshotCreateRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCreateRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Verify = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCreateRepositoryRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCreateRepositoryRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotCreateRepositoryRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("verify")>]
        member _.Verify(state: SnapshotCreateRepositoryRequest, value: bool) =
            { state with Verify = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: SnapshotCreateRepositoryRequest, value) =
            { state with Document = value }

    let snapshotCreateRepositoryRequest = SnapshotCreateRepositoryRequestBuilder()

    module CreateRepository =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotCreateRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SnapshotCreateRepositoryRequest) =
            { req with Timeout = Some value }
        let withVerify (value: bool) (req: SnapshotCreateRepositoryRequest) =
            { req with Verify = Some value }

    type SnapshotDeleteRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Names
        MasterTimeout: CoreTypes.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: SnapshotDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotDeleteResponse = CoreTypes.AcknowledgedResponseBase

    type SnapshotDeleteRequestBuilder() =
        member _.Yield(_: unit) : SnapshotDeleteRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotDeleteRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotDeleteRequest, value: CoreTypes.Names) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotDeleteRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: SnapshotDeleteRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let snapshotDeleteRequest = SnapshotDeleteRequestBuilder()

    module Delete =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotDeleteRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: SnapshotDeleteRequest) =
            { req with WaitForCompletion = Some value }

    type SnapshotDeleteRepositoryRequest = {
        Repository: CoreTypes.Names
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SnapshotDeleteRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotDeleteRepositoryResponse = CoreTypes.AcknowledgedResponseBase

    type SnapshotDeleteRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotDeleteRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotDeleteRepositoryRequest, value: CoreTypes.Names) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotDeleteRepositoryRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotDeleteRepositoryRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let snapshotDeleteRepositoryRequest = SnapshotDeleteRepositoryRequestBuilder()

    module DeleteRepository =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotDeleteRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SnapshotDeleteRepositoryRequest) =
            { req with Timeout = Some value }

    type SnapshotGetRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Names
        After: string option
        FromSortValue: string option
        IgnoreUnavailable: bool option
        IndexDetails: bool option
        IndexNames: bool option
        IncludeRepository: bool option
        MasterTimeout: CoreTypes.Duration option
        Order: CoreTypes.SortOrder option
        Offset: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        SlmPolicyFilter: CoreTypes.Name option
        Sort: SnapshotTypes.SnapshotSort option
        State: System.Text.Json.JsonElement option
        Verbose: bool option
    }

        with
        static member ToRequest(req: SnapshotGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}"
                let queryParams =
                    [
                        req.After |> Option.map (fun v -> "after", Fes.Http.toQueryValue v)
                        req.FromSortValue |> Option.map (fun v -> "from_sort_value", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.IndexDetails |> Option.map (fun v -> "index_details", Fes.Http.toQueryValue v)
                        req.IndexNames |> Option.map (fun v -> "index_names", Fes.Http.toQueryValue v)
                        req.IncludeRepository |> Option.map (fun v -> "include_repository", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Order |> Option.map (fun v -> "order", Fes.Http.toQueryValue v)
                        req.Offset |> Option.map (fun v -> "offset", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.SlmPolicyFilter |> Option.map (fun v -> "slm_policy_filter", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        req.State |> Option.map (fun v -> "state", Fes.Http.toQueryValue v)
                        req.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
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

    type SnapshotGetResponse = System.Text.Json.JsonElement

    type SnapshotGetRequestBuilder() =
        member _.Yield(_: unit) : SnapshotGetRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                After = None
                FromSortValue = None
                IgnoreUnavailable = None
                IndexDetails = None
                IndexNames = None
                IncludeRepository = None
                MasterTimeout = None
                Order = None
                Offset = None
                Size = None
                SlmPolicyFilter = None
                Sort = None
                State = None
                Verbose = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotGetRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotGetRequest, value: CoreTypes.Names) =
            { state with Snapshot = value }

        [<CustomOperation("after")>]
        member _.After(state: SnapshotGetRequest, value: string) =
            { state with After = Some value }

        [<CustomOperation("fromSortValue")>]
        member _.FromSortValue(state: SnapshotGetRequest, value: string) =
            { state with FromSortValue = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SnapshotGetRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("indexDetails")>]
        member _.IndexDetails(state: SnapshotGetRequest, value: bool) =
            { state with IndexDetails = Some value }

        [<CustomOperation("indexNames")>]
        member _.IndexNames(state: SnapshotGetRequest, value: bool) =
            { state with IndexNames = Some value }

        [<CustomOperation("includeRepository")>]
        member _.IncludeRepository(state: SnapshotGetRequest, value: bool) =
            { state with IncludeRepository = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotGetRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: SnapshotGetRequest, value: CoreTypes.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: SnapshotGetRequest, value: CoreTypes.Integer) =
            { state with Offset = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SnapshotGetRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slmPolicyFilter")>]
        member _.SlmPolicyFilter(state: SnapshotGetRequest, value: CoreTypes.Name) =
            { state with SlmPolicyFilter = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SnapshotGetRequest, value: SnapshotTypes.SnapshotSort) =
            { state with Sort = Some value }

        [<CustomOperation("state")>]
        member _.State(state: SnapshotGetRequest, value: System.Text.Json.JsonElement) =
            { state with State = Some value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: SnapshotGetRequest, value: bool) =
            { state with Verbose = Some value }

    let snapshotGetRequest = SnapshotGetRequestBuilder()

    module Get =
        let withAfter (value: string) (req: SnapshotGetRequest) =
            { req with After = Some value }
        let withFromSortValue (value: string) (req: SnapshotGetRequest) =
            { req with FromSortValue = Some value }
        let withIgnoreUnavailable (value: bool) (req: SnapshotGetRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIndexDetails (value: bool) (req: SnapshotGetRequest) =
            { req with IndexDetails = Some value }
        let withIndexNames (value: bool) (req: SnapshotGetRequest) =
            { req with IndexNames = Some value }
        let withIncludeRepository (value: bool) (req: SnapshotGetRequest) =
            { req with IncludeRepository = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotGetRequest) =
            { req with MasterTimeout = Some value }
        let withOrder (value: CoreTypes.SortOrder) (req: SnapshotGetRequest) =
            { req with Order = Some value }
        let withOffset (value: CoreTypes.Integer) (req: SnapshotGetRequest) =
            { req with Offset = Some value }
        let withSize (value: CoreTypes.Integer) (req: SnapshotGetRequest) =
            { req with Size = Some value }
        let withSlmPolicyFilter (value: CoreTypes.Name) (req: SnapshotGetRequest) =
            { req with SlmPolicyFilter = Some value }
        let withSort (value: SnapshotTypes.SnapshotSort) (req: SnapshotGetRequest) =
            { req with Sort = Some value }
        let withState (value: System.Text.Json.JsonElement) (req: SnapshotGetRequest) =
            { req with State = Some value }
        let withVerbose (value: bool) (req: SnapshotGetRequest) =
            { req with Verbose = Some value }

    type SnapshotGetRepositoryRequest = {
        Repository: CoreTypes.Names
        Local: bool option
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SnapshotGetRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}"
                let queryParams =
                    [
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    type SnapshotGetRepositoryResponse = Map<string, SnapshotTypes.Repository>

    type SnapshotGetRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotGetRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotGetRepositoryRequest, value: CoreTypes.Names) =
            { state with Repository = value }

        [<CustomOperation("local")>]
        member _.Local(state: SnapshotGetRepositoryRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotGetRepositoryRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let snapshotGetRepositoryRequest = SnapshotGetRepositoryRequestBuilder()

    module GetRepository =
        let withLocal (value: bool) (req: SnapshotGetRepositoryRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotGetRepositoryRequest) =
            { req with MasterTimeout = Some value }

    type SnapshotRepositoryAnalyzeRequest = {
        Repository: CoreTypes.Name
        BlobCount: CoreTypes.Integer option
        Concurrency: CoreTypes.Integer option
        Detailed: bool option
        EarlyReadNodeCount: CoreTypes.Integer option
        MaxBlobSize: CoreTypes.ByteSize option
        MaxTotalDataSize: CoreTypes.ByteSize option
        RareActionProbability: CoreTypes.Double option
        RarelyAbortWrites: bool option
        ReadNodeCount: CoreTypes.Integer option
        RegisterOperationCount: CoreTypes.Integer option
        Seed: CoreTypes.Integer option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SnapshotRepositoryAnalyzeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/_analyze"
                let queryParams =
                    [
                        req.BlobCount |> Option.map (fun v -> "blob_count", Fes.Http.toQueryValue v)
                        req.Concurrency |> Option.map (fun v -> "concurrency", Fes.Http.toQueryValue v)
                        req.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                        req.EarlyReadNodeCount |> Option.map (fun v -> "early_read_node_count", Fes.Http.toQueryValue v)
                        req.MaxBlobSize |> Option.map (fun v -> "max_blob_size", Fes.Http.toQueryValue v)
                        req.MaxTotalDataSize |> Option.map (fun v -> "max_total_data_size", Fes.Http.toQueryValue v)
                        req.RareActionProbability |> Option.map (fun v -> "rare_action_probability", Fes.Http.toQueryValue v)
                        req.RarelyAbortWrites |> Option.map (fun v -> "rarely_abort_writes", Fes.Http.toQueryValue v)
                        req.ReadNodeCount |> Option.map (fun v -> "read_node_count", Fes.Http.toQueryValue v)
                        req.RegisterOperationCount |> Option.map (fun v -> "register_operation_count", Fes.Http.toQueryValue v)
                        req.Seed |> Option.map (fun v -> "seed", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotRepositoryAnalyzeResponse = System.Text.Json.JsonElement

    type SnapshotRepositoryAnalyzeRequestBuilder() =
        member _.Yield(_: unit) : SnapshotRepositoryAnalyzeRequest =
            {
                Repository = Unchecked.defaultof<_>
                BlobCount = None
                Concurrency = None
                Detailed = None
                EarlyReadNodeCount = None
                MaxBlobSize = None
                MaxTotalDataSize = None
                RareActionProbability = None
                RarelyAbortWrites = None
                ReadNodeCount = None
                RegisterOperationCount = None
                Seed = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("blobCount")>]
        member _.BlobCount(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Integer) =
            { state with BlobCount = Some value }

        [<CustomOperation("concurrency")>]
        member _.Concurrency(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Integer) =
            { state with Concurrency = Some value }

        [<CustomOperation("detailed")>]
        member _.Detailed(state: SnapshotRepositoryAnalyzeRequest, value: bool) =
            { state with Detailed = Some value }

        [<CustomOperation("earlyReadNodeCount")>]
        member _.EarlyReadNodeCount(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Integer) =
            { state with EarlyReadNodeCount = Some value }

        [<CustomOperation("maxBlobSize")>]
        member _.MaxBlobSize(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.ByteSize) =
            { state with MaxBlobSize = Some value }

        [<CustomOperation("maxTotalDataSize")>]
        member _.MaxTotalDataSize(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.ByteSize) =
            { state with MaxTotalDataSize = Some value }

        [<CustomOperation("rareActionProbability")>]
        member _.RareActionProbability(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Double) =
            { state with RareActionProbability = Some value }

        [<CustomOperation("rarelyAbortWrites")>]
        member _.RarelyAbortWrites(state: SnapshotRepositoryAnalyzeRequest, value: bool) =
            { state with RarelyAbortWrites = Some value }

        [<CustomOperation("readNodeCount")>]
        member _.ReadNodeCount(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Integer) =
            { state with ReadNodeCount = Some value }

        [<CustomOperation("registerOperationCount")>]
        member _.RegisterOperationCount(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Integer) =
            { state with RegisterOperationCount = Some value }

        [<CustomOperation("seed")>]
        member _.Seed(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Integer) =
            { state with Seed = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotRepositoryAnalyzeRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let snapshotRepositoryAnalyzeRequest = SnapshotRepositoryAnalyzeRequestBuilder()

    module RepositoryAnalyze =
        let withBlobCount (value: CoreTypes.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with BlobCount = Some value }
        let withConcurrency (value: CoreTypes.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Concurrency = Some value }
        let withDetailed (value: bool) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Detailed = Some value }
        let withEarlyReadNodeCount (value: CoreTypes.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with EarlyReadNodeCount = Some value }
        let withMaxBlobSize (value: CoreTypes.ByteSize) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with MaxBlobSize = Some value }
        let withMaxTotalDataSize (value: CoreTypes.ByteSize) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with MaxTotalDataSize = Some value }
        let withRareActionProbability (value: CoreTypes.Double) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with RareActionProbability = Some value }
        let withRarelyAbortWrites (value: bool) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with RarelyAbortWrites = Some value }
        let withReadNodeCount (value: CoreTypes.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with ReadNodeCount = Some value }
        let withRegisterOperationCount (value: CoreTypes.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with RegisterOperationCount = Some value }
        let withSeed (value: CoreTypes.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Seed = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Timeout = Some value }

    type SnapshotRepositoryVerifyIntegrityRequest = {
        Repository: CoreTypes.Names
        BlobThreadPoolConcurrency: CoreTypes.Integer option
        IndexSnapshotVerificationConcurrency: CoreTypes.Integer option
        IndexVerificationConcurrency: CoreTypes.Integer option
        MaxBytesPerSec: string option
        MaxFailedShardSnapshots: CoreTypes.Integer option
        MetaThreadPoolConcurrency: CoreTypes.Integer option
        SnapshotVerificationConcurrency: CoreTypes.Integer option
        VerifyBlobContents: bool option
    }

        with
        static member ToRequest(req: SnapshotRepositoryVerifyIntegrityRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/_verify_integrity"
                let queryParams =
                    [
                        req.BlobThreadPoolConcurrency |> Option.map (fun v -> "blob_thread_pool_concurrency", Fes.Http.toQueryValue v)
                        req.IndexSnapshotVerificationConcurrency |> Option.map (fun v -> "index_snapshot_verification_concurrency", Fes.Http.toQueryValue v)
                        req.IndexVerificationConcurrency |> Option.map (fun v -> "index_verification_concurrency", Fes.Http.toQueryValue v)
                        req.MaxBytesPerSec |> Option.map (fun v -> "max_bytes_per_sec", Fes.Http.toQueryValue v)
                        req.MaxFailedShardSnapshots |> Option.map (fun v -> "max_failed_shard_snapshots", Fes.Http.toQueryValue v)
                        req.MetaThreadPoolConcurrency |> Option.map (fun v -> "meta_thread_pool_concurrency", Fes.Http.toQueryValue v)
                        req.SnapshotVerificationConcurrency |> Option.map (fun v -> "snapshot_verification_concurrency", Fes.Http.toQueryValue v)
                        req.VerifyBlobContents |> Option.map (fun v -> "verify_blob_contents", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotRepositoryVerifyIntegrityResponse = System.Text.Json.JsonElement

    type SnapshotRepositoryVerifyIntegrityRequestBuilder() =
        member _.Yield(_: unit) : SnapshotRepositoryVerifyIntegrityRequest =
            {
                Repository = Unchecked.defaultof<_>
                BlobThreadPoolConcurrency = None
                IndexSnapshotVerificationConcurrency = None
                IndexVerificationConcurrency = None
                MaxBytesPerSec = None
                MaxFailedShardSnapshots = None
                MetaThreadPoolConcurrency = None
                SnapshotVerificationConcurrency = None
                VerifyBlobContents = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Names) =
            { state with Repository = value }

        [<CustomOperation("blobThreadPoolConcurrency")>]
        member _.BlobThreadPoolConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Integer) =
            { state with BlobThreadPoolConcurrency = Some value }

        [<CustomOperation("indexSnapshotVerificationConcurrency")>]
        member _.IndexSnapshotVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Integer) =
            { state with IndexSnapshotVerificationConcurrency = Some value }

        [<CustomOperation("indexVerificationConcurrency")>]
        member _.IndexVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Integer) =
            { state with IndexVerificationConcurrency = Some value }

        [<CustomOperation("maxBytesPerSec")>]
        member _.MaxBytesPerSec(state: SnapshotRepositoryVerifyIntegrityRequest, value: string) =
            { state with MaxBytesPerSec = Some value }

        [<CustomOperation("maxFailedShardSnapshots")>]
        member _.MaxFailedShardSnapshots(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Integer) =
            { state with MaxFailedShardSnapshots = Some value }

        [<CustomOperation("metaThreadPoolConcurrency")>]
        member _.MetaThreadPoolConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Integer) =
            { state with MetaThreadPoolConcurrency = Some value }

        [<CustomOperation("snapshotVerificationConcurrency")>]
        member _.SnapshotVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: CoreTypes.Integer) =
            { state with SnapshotVerificationConcurrency = Some value }

        [<CustomOperation("verifyBlobContents")>]
        member _.VerifyBlobContents(state: SnapshotRepositoryVerifyIntegrityRequest, value: bool) =
            { state with VerifyBlobContents = Some value }

    let snapshotRepositoryVerifyIntegrityRequest = SnapshotRepositoryVerifyIntegrityRequestBuilder()

    module RepositoryVerifyIntegrity =
        let withBlobThreadPoolConcurrency (value: CoreTypes.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with BlobThreadPoolConcurrency = Some value }
        let withIndexSnapshotVerificationConcurrency (value: CoreTypes.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with IndexSnapshotVerificationConcurrency = Some value }
        let withIndexVerificationConcurrency (value: CoreTypes.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with IndexVerificationConcurrency = Some value }
        let withMaxBytesPerSec (value: string) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with MaxBytesPerSec = Some value }
        let withMaxFailedShardSnapshots (value: CoreTypes.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with MaxFailedShardSnapshots = Some value }
        let withMetaThreadPoolConcurrency (value: CoreTypes.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with MetaThreadPoolConcurrency = Some value }
        let withSnapshotVerificationConcurrency (value: CoreTypes.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with SnapshotVerificationConcurrency = Some value }
        let withVerifyBlobContents (value: bool) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with VerifyBlobContents = Some value }

    type SnapshotRestoreRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        WaitForCompletion: bool option
        FeatureStates: string list option
        IgnoreIndexSettings: string list option
        IgnoreUnavailable: bool option
        IncludeAliases: bool option
        IncludeGlobalState: bool option
        IndexSettings: IndicesTypes.IndexSettings option
        Indices: CoreTypes.Indices option
        Partial: bool option
        RenamePattern: string option
        RenameReplacement: string option
    }

        with
        static member ToRequest(req: SnapshotRestoreRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}/_restore"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    type SnapshotRestoreResponse = System.Text.Json.JsonElement

    type SnapshotRestoreRequestBuilder() =
        member _.Yield(_: unit) : SnapshotRestoreRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
                FeatureStates = None
                IgnoreIndexSettings = None
                IgnoreUnavailable = None
                IncludeAliases = None
                IncludeGlobalState = None
                IndexSettings = None
                Indices = None
                Partial = None
                RenamePattern = None
                RenameReplacement = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotRestoreRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotRestoreRequest, value: CoreTypes.Name) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotRestoreRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: SnapshotRestoreRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: SnapshotRestoreRequest, value: string list) =
            { state with FeatureStates = Some value }

        [<CustomOperation("ignoreIndexSettings")>]
        member _.IgnoreIndexSettings(state: SnapshotRestoreRequest, value: string list) =
            { state with IgnoreIndexSettings = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SnapshotRestoreRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeAliases")>]
        member _.IncludeAliases(state: SnapshotRestoreRequest, value: bool) =
            { state with IncludeAliases = Some value }

        [<CustomOperation("includeGlobalState")>]
        member _.IncludeGlobalState(state: SnapshotRestoreRequest, value: bool) =
            { state with IncludeGlobalState = Some value }

        [<CustomOperation("indexSettings")>]
        member _.IndexSettings(state: SnapshotRestoreRequest, value: IndicesTypes.IndexSettings) =
            { state with IndexSettings = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotRestoreRequest, value: CoreTypes.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("partial")>]
        member _.Partial(state: SnapshotRestoreRequest, value: bool) =
            { state with Partial = Some value }

        [<CustomOperation("renamePattern")>]
        member _.RenamePattern(state: SnapshotRestoreRequest, value: string) =
            { state with RenamePattern = Some value }

        [<CustomOperation("renameReplacement")>]
        member _.RenameReplacement(state: SnapshotRestoreRequest, value: string) =
            { state with RenameReplacement = Some value }

    let snapshotRestoreRequest = SnapshotRestoreRequestBuilder()

    module Restore =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotRestoreRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: SnapshotRestoreRequest) =
            { req with WaitForCompletion = Some value }
        let withFeatureStates (value: string list) (req: SnapshotRestoreRequest) =
            { req with FeatureStates = Some value }
        let withIgnoreIndexSettings (value: string list) (req: SnapshotRestoreRequest) =
            { req with IgnoreIndexSettings = Some value }
        let withIgnoreUnavailable (value: bool) (req: SnapshotRestoreRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeAliases (value: bool) (req: SnapshotRestoreRequest) =
            { req with IncludeAliases = Some value }
        let withIncludeGlobalState (value: bool) (req: SnapshotRestoreRequest) =
            { req with IncludeGlobalState = Some value }
        let withIndexSettings (value: IndicesTypes.IndexSettings) (req: SnapshotRestoreRequest) =
            { req with IndexSettings = Some value }
        let withIndices (value: CoreTypes.Indices) (req: SnapshotRestoreRequest) =
            { req with Indices = Some value }
        let withPartial (value: bool) (req: SnapshotRestoreRequest) =
            { req with Partial = Some value }
        let withRenamePattern (value: string) (req: SnapshotRestoreRequest) =
            { req with RenamePattern = Some value }
        let withRenameReplacement (value: string) (req: SnapshotRestoreRequest) =
            { req with RenameReplacement = Some value }

    type SnapshotStatusRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Names
        IgnoreUnavailable: bool option
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SnapshotStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}/_status"
                let queryParams =
                    [
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    type SnapshotStatusResponse = System.Text.Json.JsonElement

    type SnapshotStatusRequestBuilder() =
        member _.Yield(_: unit) : SnapshotStatusRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                IgnoreUnavailable = None
                MasterTimeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotStatusRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotStatusRequest, value: CoreTypes.Names) =
            { state with Snapshot = value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SnapshotStatusRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotStatusRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let snapshotStatusRequest = SnapshotStatusRequestBuilder()

    module Status =
        let withIgnoreUnavailable (value: bool) (req: SnapshotStatusRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotStatusRequest) =
            { req with MasterTimeout = Some value }

    type SnapshotVerifyRepositoryRequest = {
        Repository: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SnapshotVerifyRepositoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/_verify"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SnapshotVerifyRepositoryResponse = System.Text.Json.JsonElement

    type SnapshotVerifyRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotVerifyRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotVerifyRepositoryRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotVerifyRepositoryRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotVerifyRepositoryRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let snapshotVerifyRepositoryRequest = SnapshotVerifyRepositoryRequestBuilder()

    module VerifyRepository =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SnapshotVerifyRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SnapshotVerifyRepositoryRequest) =
            { req with Timeout = Some value }

