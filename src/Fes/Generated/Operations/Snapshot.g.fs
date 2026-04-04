// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module SnapshotOperations =

    type SnapshotCleanupRepositoryRequest = {
        Repository: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SnapshotCleanupRepositoryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/_cleanup"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type SnapshotCleanupRepositoryResponse = System.Text.Json.JsonElement

    type SnapshotCleanupRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotCleanupRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotCleanupRepositoryRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCleanupRepositoryRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotCleanupRepositoryRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let snapshotCleanupRepositoryRequest = SnapshotCleanupRepositoryRequestBuilder()

    module CleanupRepository =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotCleanupRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SnapshotCleanupRepositoryRequest) =
            { req with Timeout = Some value }

    type SnapshotCloneRequest = {
        Repository: Types.Name
        Snapshot: Types.Name
        TargetSnapshot: Types.Name
        MasterTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string
    }

        with
        static member ToEndpoint(req: SnapshotCloneRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/{Fes.Http.toPathSegment req.Snapshot}/_clone/{Fes.Http.toPathSegment req.TargetSnapshot}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SnapshotCloneResponse = Types.AcknowledgedResponseBase

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
        member _.Repository(state: SnapshotCloneRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotCloneRequest, value: Types.Name) =
            { state with Snapshot = value }

        [<CustomOperation("targetSnapshot")>]
        member _.TargetSnapshot(state: SnapshotCloneRequest, value: Types.Name) =
            { state with TargetSnapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCloneRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotCloneRequest, value: string) =
            { state with Indices = value }

    let snapshotCloneRequest = SnapshotCloneRequestBuilder()

    module Clone =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotCloneRequest) =
            { req with MasterTimeout = Some value }
        let withIndices (value: string) (req: SnapshotCloneRequest) =
            { req with Indices = value }

    type SnapshotCreateRequest = {
        Repository: Types.Name
        Snapshot: Types.Name
        MasterTimeout: Types.Duration option
        WaitForCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: Types.ExpandWildcards option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: bool option
    }

        with
        static member ToEndpoint(req: SnapshotCreateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/{Fes.Http.toPathSegment req.Snapshot}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Repository(state: SnapshotCreateRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotCreateRequest, value: Types.Name) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCreateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: SnapshotCreateRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SnapshotCreateRequest, value: Types.ExpandWildcards) =
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
        member _.Indices(state: SnapshotCreateRequest, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SnapshotCreateRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("partial")>]
        member _.Partial(state: SnapshotCreateRequest, value: bool) =
            { state with Partial = Some value }

    let snapshotCreateRequest = SnapshotCreateRequestBuilder()

    module Create =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotCreateRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: SnapshotCreateRequest) =
            { req with WaitForCompletion = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: SnapshotCreateRequest) =
            { req with ExpandWildcards = Some value }
        let withFeatureStates (value: string list) (req: SnapshotCreateRequest) =
            { req with FeatureStates = Some value }
        let withIgnoreUnavailable (value: bool) (req: SnapshotCreateRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeGlobalState (value: bool) (req: SnapshotCreateRequest) =
            { req with IncludeGlobalState = Some value }
        let withIndices (value: Types.Indices) (req: SnapshotCreateRequest) =
            { req with Indices = Some value }
        let withMetadata (value: Types.Metadata) (req: SnapshotCreateRequest) =
            { req with Metadata = Some value }
        let withPartial (value: bool) (req: SnapshotCreateRequest) =
            { req with Partial = Some value }

    type SnapshotCreateRepositoryRequest = {
        Repository: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Verify: bool option
        Document: Types.Repository
    }

        with
        static member ToEndpoint(req: SnapshotCreateRepositoryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type SnapshotCreateRepositoryResponse = Types.AcknowledgedResponseBase

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
        member _.Repository(state: SnapshotCreateRepositoryRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotCreateRepositoryRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotCreateRepositoryRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("verify")>]
        member _.Verify(state: SnapshotCreateRepositoryRequest, value: bool) =
            { state with Verify = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: SnapshotCreateRepositoryRequest, value) =
            { state with Document = value }

    let snapshotCreateRepositoryRequest = SnapshotCreateRepositoryRequestBuilder()

    module CreateRepository =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotCreateRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SnapshotCreateRepositoryRequest) =
            { req with Timeout = Some value }
        let withVerify (value: bool) (req: SnapshotCreateRepositoryRequest) =
            { req with Verify = Some value }

    type SnapshotDeleteRequest = {
        Repository: Types.Name
        Snapshot: Types.Names
        MasterTimeout: Types.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToEndpoint(req: SnapshotDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/{Fes.Http.toPathSegment req.Snapshot}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type SnapshotDeleteResponse = Types.AcknowledgedResponseBase

    type SnapshotDeleteRequestBuilder() =
        member _.Yield(_: unit) : SnapshotDeleteRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotDeleteRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotDeleteRequest, value: Types.Names) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotDeleteRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: SnapshotDeleteRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let snapshotDeleteRequest = SnapshotDeleteRequestBuilder()

    module Delete =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotDeleteRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: SnapshotDeleteRequest) =
            { req with WaitForCompletion = Some value }

    type SnapshotDeleteRepositoryRequest = {
        Repository: Types.Names
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SnapshotDeleteRepositoryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type SnapshotDeleteRepositoryResponse = Types.AcknowledgedResponseBase

    type SnapshotDeleteRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotDeleteRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotDeleteRepositoryRequest, value: Types.Names) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotDeleteRepositoryRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotDeleteRepositoryRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let snapshotDeleteRepositoryRequest = SnapshotDeleteRepositoryRequestBuilder()

    module DeleteRepository =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotDeleteRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SnapshotDeleteRepositoryRequest) =
            { req with Timeout = Some value }

    type SnapshotGetRequest = {
        Repository: Types.Name
        Snapshot: Types.Names
        After: string option
        FromSortValue: string option
        IgnoreUnavailable: bool option
        IndexDetails: bool option
        IndexNames: bool option
        IncludeRepository: bool option
        MasterTimeout: Types.Duration option
        Order: Types.SortOrder option
        Offset: Types.Integer option
        Size: Types.Integer option
        SlmPolicyFilter: Types.Name option
        Sort: Types.SnapshotSort option
        State: Types.SnapshotState list option
        Verbose: bool option
    }

        with
        static member ToEndpoint(req: SnapshotGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/{Fes.Http.toPathSegment req.Snapshot}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.Repository(state: SnapshotGetRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotGetRequest, value: Types.Names) =
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
        member _.MasterTimeout(state: SnapshotGetRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: SnapshotGetRequest, value: Types.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: SnapshotGetRequest, value: Types.Integer) =
            { state with Offset = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SnapshotGetRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slmPolicyFilter")>]
        member _.SlmPolicyFilter(state: SnapshotGetRequest, value: Types.Name) =
            { state with SlmPolicyFilter = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SnapshotGetRequest, value: Types.SnapshotSort) =
            { state with Sort = Some value }

        [<CustomOperation("state")>]
        member _.State(state: SnapshotGetRequest, value: Types.SnapshotState list) =
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
        let withMasterTimeout (value: Types.Duration) (req: SnapshotGetRequest) =
            { req with MasterTimeout = Some value }
        let withOrder (value: Types.SortOrder) (req: SnapshotGetRequest) =
            { req with Order = Some value }
        let withOffset (value: Types.Integer) (req: SnapshotGetRequest) =
            { req with Offset = Some value }
        let withSize (value: Types.Integer) (req: SnapshotGetRequest) =
            { req with Size = Some value }
        let withSlmPolicyFilter (value: Types.Name) (req: SnapshotGetRequest) =
            { req with SlmPolicyFilter = Some value }
        let withSort (value: Types.SnapshotSort) (req: SnapshotGetRequest) =
            { req with Sort = Some value }
        let withState (value: Types.SnapshotState list) (req: SnapshotGetRequest) =
            { req with State = Some value }
        let withVerbose (value: bool) (req: SnapshotGetRequest) =
            { req with Verbose = Some value }

    type SnapshotGetRepositoryRequest = {
        Repository: Types.Names
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SnapshotGetRepositoryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}"
            let queryParams =
                [
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SnapshotGetRepositoryResponse = Map<string, Types.Repository>

    type SnapshotGetRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotGetRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotGetRepositoryRequest, value: Types.Names) =
            { state with Repository = value }

        [<CustomOperation("local")>]
        member _.Local(state: SnapshotGetRepositoryRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotGetRepositoryRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let snapshotGetRepositoryRequest = SnapshotGetRepositoryRequestBuilder()

    module GetRepository =
        let withLocal (value: bool) (req: SnapshotGetRepositoryRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: SnapshotGetRepositoryRequest) =
            { req with MasterTimeout = Some value }

    type SnapshotRepositoryAnalyzeRequest = {
        Repository: Types.Name
        BlobCount: Types.Integer option
        Concurrency: Types.Integer option
        Detailed: bool option
        EarlyReadNodeCount: Types.Integer option
        MaxBlobSize: Types.ByteSize option
        MaxTotalDataSize: Types.ByteSize option
        RareActionProbability: Types.Double option
        RarelyAbortWrites: bool option
        ReadNodeCount: Types.Integer option
        RegisterOperationCount: Types.Integer option
        Seed: Types.Integer option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SnapshotRepositoryAnalyzeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/_analyze"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

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
        member _.Repository(state: SnapshotRepositoryAnalyzeRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("blobCount")>]
        member _.BlobCount(state: SnapshotRepositoryAnalyzeRequest, value: Types.Integer) =
            { state with BlobCount = Some value }

        [<CustomOperation("concurrency")>]
        member _.Concurrency(state: SnapshotRepositoryAnalyzeRequest, value: Types.Integer) =
            { state with Concurrency = Some value }

        [<CustomOperation("detailed")>]
        member _.Detailed(state: SnapshotRepositoryAnalyzeRequest, value: bool) =
            { state with Detailed = Some value }

        [<CustomOperation("earlyReadNodeCount")>]
        member _.EarlyReadNodeCount(state: SnapshotRepositoryAnalyzeRequest, value: Types.Integer) =
            { state with EarlyReadNodeCount = Some value }

        [<CustomOperation("maxBlobSize")>]
        member _.MaxBlobSize(state: SnapshotRepositoryAnalyzeRequest, value: Types.ByteSize) =
            { state with MaxBlobSize = Some value }

        [<CustomOperation("maxTotalDataSize")>]
        member _.MaxTotalDataSize(state: SnapshotRepositoryAnalyzeRequest, value: Types.ByteSize) =
            { state with MaxTotalDataSize = Some value }

        [<CustomOperation("rareActionProbability")>]
        member _.RareActionProbability(state: SnapshotRepositoryAnalyzeRequest, value: Types.Double) =
            { state with RareActionProbability = Some value }

        [<CustomOperation("rarelyAbortWrites")>]
        member _.RarelyAbortWrites(state: SnapshotRepositoryAnalyzeRequest, value: bool) =
            { state with RarelyAbortWrites = Some value }

        [<CustomOperation("readNodeCount")>]
        member _.ReadNodeCount(state: SnapshotRepositoryAnalyzeRequest, value: Types.Integer) =
            { state with ReadNodeCount = Some value }

        [<CustomOperation("registerOperationCount")>]
        member _.RegisterOperationCount(state: SnapshotRepositoryAnalyzeRequest, value: Types.Integer) =
            { state with RegisterOperationCount = Some value }

        [<CustomOperation("seed")>]
        member _.Seed(state: SnapshotRepositoryAnalyzeRequest, value: Types.Integer) =
            { state with Seed = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotRepositoryAnalyzeRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let snapshotRepositoryAnalyzeRequest = SnapshotRepositoryAnalyzeRequestBuilder()

    module RepositoryAnalyze =
        let withBlobCount (value: Types.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with BlobCount = Some value }
        let withConcurrency (value: Types.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Concurrency = Some value }
        let withDetailed (value: bool) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Detailed = Some value }
        let withEarlyReadNodeCount (value: Types.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with EarlyReadNodeCount = Some value }
        let withMaxBlobSize (value: Types.ByteSize) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with MaxBlobSize = Some value }
        let withMaxTotalDataSize (value: Types.ByteSize) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with MaxTotalDataSize = Some value }
        let withRareActionProbability (value: Types.Double) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with RareActionProbability = Some value }
        let withRarelyAbortWrites (value: bool) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with RarelyAbortWrites = Some value }
        let withReadNodeCount (value: Types.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with ReadNodeCount = Some value }
        let withRegisterOperationCount (value: Types.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with RegisterOperationCount = Some value }
        let withSeed (value: Types.Integer) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Seed = Some value }
        let withTimeout (value: Types.Duration) (req: SnapshotRepositoryAnalyzeRequest) =
            { req with Timeout = Some value }

    type SnapshotRepositoryVerifyIntegrityRequest = {
        Repository: Types.Names
        BlobThreadPoolConcurrency: Types.Integer option
        IndexSnapshotVerificationConcurrency: Types.Integer option
        IndexVerificationConcurrency: Types.Integer option
        MaxBytesPerSec: string option
        MaxFailedShardSnapshots: Types.Integer option
        MetaThreadPoolConcurrency: Types.Integer option
        SnapshotVerificationConcurrency: Types.Integer option
        VerifyBlobContents: bool option
    }

        with
        static member ToEndpoint(req: SnapshotRepositoryVerifyIntegrityRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/_verify_integrity"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

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
        member _.Repository(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Names) =
            { state with Repository = value }

        [<CustomOperation("blobThreadPoolConcurrency")>]
        member _.BlobThreadPoolConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Integer) =
            { state with BlobThreadPoolConcurrency = Some value }

        [<CustomOperation("indexSnapshotVerificationConcurrency")>]
        member _.IndexSnapshotVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Integer) =
            { state with IndexSnapshotVerificationConcurrency = Some value }

        [<CustomOperation("indexVerificationConcurrency")>]
        member _.IndexVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Integer) =
            { state with IndexVerificationConcurrency = Some value }

        [<CustomOperation("maxBytesPerSec")>]
        member _.MaxBytesPerSec(state: SnapshotRepositoryVerifyIntegrityRequest, value: string) =
            { state with MaxBytesPerSec = Some value }

        [<CustomOperation("maxFailedShardSnapshots")>]
        member _.MaxFailedShardSnapshots(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Integer) =
            { state with MaxFailedShardSnapshots = Some value }

        [<CustomOperation("metaThreadPoolConcurrency")>]
        member _.MetaThreadPoolConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Integer) =
            { state with MetaThreadPoolConcurrency = Some value }

        [<CustomOperation("snapshotVerificationConcurrency")>]
        member _.SnapshotVerificationConcurrency(state: SnapshotRepositoryVerifyIntegrityRequest, value: Types.Integer) =
            { state with SnapshotVerificationConcurrency = Some value }

        [<CustomOperation("verifyBlobContents")>]
        member _.VerifyBlobContents(state: SnapshotRepositoryVerifyIntegrityRequest, value: bool) =
            { state with VerifyBlobContents = Some value }

    let snapshotRepositoryVerifyIntegrityRequest = SnapshotRepositoryVerifyIntegrityRequestBuilder()

    module RepositoryVerifyIntegrity =
        let withBlobThreadPoolConcurrency (value: Types.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with BlobThreadPoolConcurrency = Some value }
        let withIndexSnapshotVerificationConcurrency (value: Types.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with IndexSnapshotVerificationConcurrency = Some value }
        let withIndexVerificationConcurrency (value: Types.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with IndexVerificationConcurrency = Some value }
        let withMaxBytesPerSec (value: string) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with MaxBytesPerSec = Some value }
        let withMaxFailedShardSnapshots (value: Types.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with MaxFailedShardSnapshots = Some value }
        let withMetaThreadPoolConcurrency (value: Types.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with MetaThreadPoolConcurrency = Some value }
        let withSnapshotVerificationConcurrency (value: Types.Integer) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with SnapshotVerificationConcurrency = Some value }
        let withVerifyBlobContents (value: bool) (req: SnapshotRepositoryVerifyIntegrityRequest) =
            { req with VerifyBlobContents = Some value }

    type SnapshotRestoreRequest = {
        Repository: Types.Name
        Snapshot: Types.Name
        MasterTimeout: Types.Duration option
        WaitForCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_index_settings")>]
        IgnoreIndexSettings: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_aliases")>]
        IncludeAliases: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_settings")>]
        IndexSettings: Types.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rename_pattern")>]
        RenamePattern: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rename_replacement")>]
        RenameReplacement: string option
    }

        with
        static member ToEndpoint(req: SnapshotRestoreRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/{Fes.Http.toPathSegment req.Snapshot}/_restore"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Repository(state: SnapshotRestoreRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotRestoreRequest, value: Types.Name) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotRestoreRequest, value: Types.Duration) =
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
        member _.IndexSettings(state: SnapshotRestoreRequest, value: Types.IndexSettings) =
            { state with IndexSettings = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotRestoreRequest, value: Types.Indices) =
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
        let withMasterTimeout (value: Types.Duration) (req: SnapshotRestoreRequest) =
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
        let withIndexSettings (value: Types.IndexSettings) (req: SnapshotRestoreRequest) =
            { req with IndexSettings = Some value }
        let withIndices (value: Types.Indices) (req: SnapshotRestoreRequest) =
            { req with Indices = Some value }
        let withPartial (value: bool) (req: SnapshotRestoreRequest) =
            { req with Partial = Some value }
        let withRenamePattern (value: string) (req: SnapshotRestoreRequest) =
            { req with RenamePattern = Some value }
        let withRenameReplacement (value: string) (req: SnapshotRestoreRequest) =
            { req with RenameReplacement = Some value }

    type SnapshotStatusRequest = {
        Repository: Types.Name
        Snapshot: Types.Names
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SnapshotStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/{Fes.Http.toPathSegment req.Snapshot}/_status"
            let queryParams =
                [
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.Repository(state: SnapshotStatusRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotStatusRequest, value: Types.Names) =
            { state with Snapshot = value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SnapshotStatusRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotStatusRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let snapshotStatusRequest = SnapshotStatusRequestBuilder()

    module Status =
        let withIgnoreUnavailable (value: bool) (req: SnapshotStatusRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: SnapshotStatusRequest) =
            { req with MasterTimeout = Some value }

    type SnapshotVerifyRepositoryRequest = {
        Repository: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SnapshotVerifyRepositoryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_snapshot/{Fes.Http.toPathSegment req.Repository}/_verify"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type SnapshotVerifyRepositoryResponse = System.Text.Json.JsonElement

    type SnapshotVerifyRepositoryRequestBuilder() =
        member _.Yield(_: unit) : SnapshotVerifyRepositoryRequest =
            {
                Repository = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotVerifyRepositoryRequest, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SnapshotVerifyRepositoryRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SnapshotVerifyRepositoryRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let snapshotVerifyRepositoryRequest = SnapshotVerifyRepositoryRequestBuilder()

    module VerifyRepository =
        let withMasterTimeout (value: Types.Duration) (req: SnapshotVerifyRepositoryRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SnapshotVerifyRepositoryRequest) =
            { req with Timeout = Some value }

