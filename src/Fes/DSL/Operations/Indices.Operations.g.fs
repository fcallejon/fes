// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module IndicesOperations =

    type ClusterGetComponentTemplateRequest = {
        Name: Name
        FlatSettings: bool option
        SettingsFilter: System.Text.Json.JsonElement option
        IncludeDefaults: bool option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: ClusterGetComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{request.Name}"
                let queryParams =
                    [
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.SettingsFilter |> Option.map (fun v -> "settings_filter", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
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

    module ClusterGetComponentTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterGetComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterGetComponentTemplateRequest.ToRequest request

    type ClusterGetComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterGetComponentTemplateRequest =
            {
                ClusterGetComponentTemplateRequest.Name = Unchecked.defaultof<Name>
                ClusterGetComponentTemplateRequest.FlatSettings = Option.None
                ClusterGetComponentTemplateRequest.SettingsFilter = Option.None
                ClusterGetComponentTemplateRequest.IncludeDefaults = Option.None
                ClusterGetComponentTemplateRequest.Local = Option.None
                ClusterGetComponentTemplateRequest.MasterTimeout = Option.None
            } : ClusterGetComponentTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: ClusterGetComponentTemplateRequest, value: Name) =
            { state with ClusterGetComponentTemplateRequest.Name = value } : ClusterGetComponentTemplateRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: ClusterGetComponentTemplateRequest, value: bool) =
            { state with ClusterGetComponentTemplateRequest.FlatSettings = Option.Some value } : ClusterGetComponentTemplateRequest

        [<CustomOperation("settings_filter")>]
        member _.SettingsFilter(state: ClusterGetComponentTemplateRequest, value: System.Text.Json.JsonElement) =
            { state with ClusterGetComponentTemplateRequest.SettingsFilter = Option.Some value } : ClusterGetComponentTemplateRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: ClusterGetComponentTemplateRequest, value: bool) =
            { state with ClusterGetComponentTemplateRequest.IncludeDefaults = Option.Some value } : ClusterGetComponentTemplateRequest

        [<CustomOperation("local")>]
        member _.Local(state: ClusterGetComponentTemplateRequest, value: bool) =
            { state with ClusterGetComponentTemplateRequest.Local = Option.Some value } : ClusterGetComponentTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterGetComponentTemplateRequest, value: Duration) =
            { state with ClusterGetComponentTemplateRequest.MasterTimeout = Option.Some value } : ClusterGetComponentTemplateRequest

    let clusterGetComponentTemplateRequest = ClusterGetComponentTemplateRequestBuilder()

    type ClusterPutComponentTemplateRequest = {
        Name: Name
        Create: bool option
        Cause: string option
        MasterTimeout: Duration option
        [<JsonPropertyName("template")>]
        Template: PutIndexTemplateIndexTemplateMapping
        [<JsonPropertyName("version")>]
        Version: VersionNumber option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("deprecated")>]
        Deprecated: bool option
    } with
        static member ToRequest(request: ClusterPutComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{request.Name}"
                let queryParams =
                    [
                        request.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        request.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``template`` = request.Template; ``version`` = request.Version; ``_meta`` = request.Meta; ``deprecated`` = request.Deprecated |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ClusterPutComponentTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterPutComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterPutComponentTemplateRequest.ToRequest request

    type ClusterPutComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterPutComponentTemplateRequest =
            {
                ClusterPutComponentTemplateRequest.Name = Unchecked.defaultof<Name>
                ClusterPutComponentTemplateRequest.Create = Option.None
                ClusterPutComponentTemplateRequest.Cause = Option.None
                ClusterPutComponentTemplateRequest.MasterTimeout = Option.None
                ClusterPutComponentTemplateRequest.Template = Unchecked.defaultof<PutIndexTemplateIndexTemplateMapping>
                ClusterPutComponentTemplateRequest.Version = Option.None
                ClusterPutComponentTemplateRequest.Meta = Option.None
                ClusterPutComponentTemplateRequest.Deprecated = Option.None
            } : ClusterPutComponentTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: ClusterPutComponentTemplateRequest, value: Name) =
            { state with ClusterPutComponentTemplateRequest.Name = value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("create")>]
        member _.Create(state: ClusterPutComponentTemplateRequest, value: bool) =
            { state with ClusterPutComponentTemplateRequest.Create = Option.Some value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("cause")>]
        member _.Cause(state: ClusterPutComponentTemplateRequest, value: string) =
            { state with ClusterPutComponentTemplateRequest.Cause = Option.Some value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterPutComponentTemplateRequest, value: Duration) =
            { state with ClusterPutComponentTemplateRequest.MasterTimeout = Option.Some value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("template")>]
        member _.Template(state: ClusterPutComponentTemplateRequest, value: PutIndexTemplateIndexTemplateMapping) =
            { state with ClusterPutComponentTemplateRequest.Template = value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("version")>]
        member _.Version(state: ClusterPutComponentTemplateRequest, value: VersionNumber) =
            { state with ClusterPutComponentTemplateRequest.Version = Option.Some value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: ClusterPutComponentTemplateRequest, value: Metadata) =
            { state with ClusterPutComponentTemplateRequest.Meta = Option.Some value } : ClusterPutComponentTemplateRequest

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: ClusterPutComponentTemplateRequest, value: bool) =
            { state with ClusterPutComponentTemplateRequest.Deprecated = Option.Some value } : ClusterPutComponentTemplateRequest

    let clusterPutComponentTemplateRequest = ClusterPutComponentTemplateRequestBuilder()

    type ClusterDeleteComponentTemplateRequest = {
        Name: Names
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: ClusterDeleteComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{request.Name}"
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

    module ClusterDeleteComponentTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterDeleteComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterDeleteComponentTemplateRequest.ToRequest request

    type ClusterDeleteComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterDeleteComponentTemplateRequest =
            {
                ClusterDeleteComponentTemplateRequest.Name = Unchecked.defaultof<Names>
                ClusterDeleteComponentTemplateRequest.MasterTimeout = Option.None
                ClusterDeleteComponentTemplateRequest.Timeout = Option.None
            } : ClusterDeleteComponentTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: ClusterDeleteComponentTemplateRequest, value: Names) =
            { state with ClusterDeleteComponentTemplateRequest.Name = value } : ClusterDeleteComponentTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterDeleteComponentTemplateRequest, value: Duration) =
            { state with ClusterDeleteComponentTemplateRequest.MasterTimeout = Option.Some value } : ClusterDeleteComponentTemplateRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterDeleteComponentTemplateRequest, value: Duration) =
            { state with ClusterDeleteComponentTemplateRequest.Timeout = Option.Some value } : ClusterDeleteComponentTemplateRequest

    let clusterDeleteComponentTemplateRequest = ClusterDeleteComponentTemplateRequestBuilder()

    type ClusterDeleteComponentTemplateResponse = AcknowledgedResponseBase

    type ClusterExistsComponentTemplateRequest = {
        Name: Names
        MasterTimeout: Duration option
        Local: bool option
    } with
        static member ToRequest(request: ClusterExistsComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
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

    module ClusterExistsComponentTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterExistsComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterExistsComponentTemplateRequest.ToRequest request

    type ClusterExistsComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterExistsComponentTemplateRequest =
            {
                ClusterExistsComponentTemplateRequest.Name = Unchecked.defaultof<Names>
                ClusterExistsComponentTemplateRequest.MasterTimeout = Option.None
                ClusterExistsComponentTemplateRequest.Local = Option.None
            } : ClusterExistsComponentTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: ClusterExistsComponentTemplateRequest, value: Names) =
            { state with ClusterExistsComponentTemplateRequest.Name = value } : ClusterExistsComponentTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterExistsComponentTemplateRequest, value: Duration) =
            { state with ClusterExistsComponentTemplateRequest.MasterTimeout = Option.Some value } : ClusterExistsComponentTemplateRequest

        [<CustomOperation("local")>]
        member _.Local(state: ClusterExistsComponentTemplateRequest, value: bool) =
            { state with ClusterExistsComponentTemplateRequest.Local = Option.Some value } : ClusterExistsComponentTemplateRequest

    let clusterExistsComponentTemplateRequest = ClusterExistsComponentTemplateRequestBuilder()

    type DanglingIndicesImportDanglingIndexRequest = {
        IndexUuid: Uuid
        AcceptDataLoss: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: DanglingIndicesImportDanglingIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_dangling/{request.IndexUuid}"
                let queryParams =
                    [
                        request.AcceptDataLoss |> Option.map (fun v -> "accept_data_loss", Fes.Http.toQueryValue v)
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

    module DanglingIndicesImportDanglingIndexRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: DanglingIndicesImportDanglingIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            DanglingIndicesImportDanglingIndexRequest.ToRequest request

    type DanglingIndicesImportDanglingIndexRequestBuilder() =
        member _.Yield(_: unit) : DanglingIndicesImportDanglingIndexRequest =
            {
                DanglingIndicesImportDanglingIndexRequest.IndexUuid = Unchecked.defaultof<Uuid>
                DanglingIndicesImportDanglingIndexRequest.AcceptDataLoss = Option.None
                DanglingIndicesImportDanglingIndexRequest.MasterTimeout = Option.None
                DanglingIndicesImportDanglingIndexRequest.Timeout = Option.None
            } : DanglingIndicesImportDanglingIndexRequest

        [<CustomOperation("index_uuid")>]
        member _.IndexUuid(state: DanglingIndicesImportDanglingIndexRequest, value: Uuid) =
            { state with DanglingIndicesImportDanglingIndexRequest.IndexUuid = value } : DanglingIndicesImportDanglingIndexRequest

        [<CustomOperation("accept_data_loss")>]
        member _.AcceptDataLoss(state: DanglingIndicesImportDanglingIndexRequest, value: bool) =
            { state with DanglingIndicesImportDanglingIndexRequest.AcceptDataLoss = Option.Some value } : DanglingIndicesImportDanglingIndexRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: DanglingIndicesImportDanglingIndexRequest, value: Duration) =
            { state with DanglingIndicesImportDanglingIndexRequest.MasterTimeout = Option.Some value } : DanglingIndicesImportDanglingIndexRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DanglingIndicesImportDanglingIndexRequest, value: Duration) =
            { state with DanglingIndicesImportDanglingIndexRequest.Timeout = Option.Some value } : DanglingIndicesImportDanglingIndexRequest

    let danglingIndicesImportDanglingIndexRequest = DanglingIndicesImportDanglingIndexRequestBuilder()

    type DanglingIndicesImportDanglingIndexResponse = AcknowledgedResponseBase

    type DanglingIndicesDeleteDanglingIndexRequest = {
        IndexUuid: Uuid
        AcceptDataLoss: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: DanglingIndicesDeleteDanglingIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_dangling/{request.IndexUuid}"
                let queryParams =
                    [
                        request.AcceptDataLoss |> Option.map (fun v -> "accept_data_loss", Fes.Http.toQueryValue v)
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

    module DanglingIndicesDeleteDanglingIndexRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: DanglingIndicesDeleteDanglingIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            DanglingIndicesDeleteDanglingIndexRequest.ToRequest request

    type DanglingIndicesDeleteDanglingIndexRequestBuilder() =
        member _.Yield(_: unit) : DanglingIndicesDeleteDanglingIndexRequest =
            {
                DanglingIndicesDeleteDanglingIndexRequest.IndexUuid = Unchecked.defaultof<Uuid>
                DanglingIndicesDeleteDanglingIndexRequest.AcceptDataLoss = Option.None
                DanglingIndicesDeleteDanglingIndexRequest.MasterTimeout = Option.None
                DanglingIndicesDeleteDanglingIndexRequest.Timeout = Option.None
            } : DanglingIndicesDeleteDanglingIndexRequest

        [<CustomOperation("index_uuid")>]
        member _.IndexUuid(state: DanglingIndicesDeleteDanglingIndexRequest, value: Uuid) =
            { state with DanglingIndicesDeleteDanglingIndexRequest.IndexUuid = value } : DanglingIndicesDeleteDanglingIndexRequest

        [<CustomOperation("accept_data_loss")>]
        member _.AcceptDataLoss(state: DanglingIndicesDeleteDanglingIndexRequest, value: bool) =
            { state with DanglingIndicesDeleteDanglingIndexRequest.AcceptDataLoss = Option.Some value } : DanglingIndicesDeleteDanglingIndexRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: DanglingIndicesDeleteDanglingIndexRequest, value: Duration) =
            { state with DanglingIndicesDeleteDanglingIndexRequest.MasterTimeout = Option.Some value } : DanglingIndicesDeleteDanglingIndexRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DanglingIndicesDeleteDanglingIndexRequest, value: Duration) =
            { state with DanglingIndicesDeleteDanglingIndexRequest.Timeout = Option.Some value } : DanglingIndicesDeleteDanglingIndexRequest

    let danglingIndicesDeleteDanglingIndexRequest = DanglingIndicesDeleteDanglingIndexRequestBuilder()

    type DanglingIndicesDeleteDanglingIndexResponse = AcknowledgedResponseBase

    type DanglingIndicesListDanglingIndicesRequest = unit

    let danglingIndicesListDanglingIndicesRequest = ()

    type DanglingIndicesListDanglingIndicesResponse = {
        [<JsonPropertyName("dangling_indices")>]
        DanglingIndices: ListDanglingIndicesDanglingIndex array
    }

    type IndicesAddBlockRequest = {
        Index: Indices
        Block: TypesIndicesBlockOptions
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesAddBlockRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_block/{request.Block}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module IndicesAddBlockRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesAddBlockRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesAddBlockRequest.ToRequest request

    type IndicesAddBlockRequestBuilder() =
        member _.Yield(_: unit) : IndicesAddBlockRequest =
            {
                IndicesAddBlockRequest.Index = Unchecked.defaultof<Indices>
                IndicesAddBlockRequest.Block = Unchecked.defaultof<TypesIndicesBlockOptions>
                IndicesAddBlockRequest.AllowNoIndices = Option.None
                IndicesAddBlockRequest.ExpandWildcards = Option.None
                IndicesAddBlockRequest.IgnoreUnavailable = Option.None
                IndicesAddBlockRequest.MasterTimeout = Option.None
                IndicesAddBlockRequest.Timeout = Option.None
            } : IndicesAddBlockRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesAddBlockRequest, value: Indices) =
            { state with IndicesAddBlockRequest.Index = value } : IndicesAddBlockRequest

        [<CustomOperation("block")>]
        member _.Block(state: IndicesAddBlockRequest, value: TypesIndicesBlockOptions) =
            { state with IndicesAddBlockRequest.Block = value } : IndicesAddBlockRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesAddBlockRequest, value: bool) =
            { state with IndicesAddBlockRequest.AllowNoIndices = Option.Some value } : IndicesAddBlockRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesAddBlockRequest, value: ExpandWildcards) =
            { state with IndicesAddBlockRequest.ExpandWildcards = Option.Some value } : IndicesAddBlockRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesAddBlockRequest, value: bool) =
            { state with IndicesAddBlockRequest.IgnoreUnavailable = Option.Some value } : IndicesAddBlockRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesAddBlockRequest, value: Duration) =
            { state with IndicesAddBlockRequest.MasterTimeout = Option.Some value } : IndicesAddBlockRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesAddBlockRequest, value: Duration) =
            { state with IndicesAddBlockRequest.Timeout = Option.Some value } : IndicesAddBlockRequest

    let indicesAddBlockRequest = IndicesAddBlockRequestBuilder()

    type IndicesAddBlockResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("shards_acknowledged")>]
        ShardsAcknowledged: bool
        [<JsonPropertyName("indices")>]
        Indices: AddBlockAddIndicesBlockStatus array
    }

    type IndicesRemoveBlockRequest = {
        Index: Indices
        Block: TypesIndicesBlockOptions
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesRemoveBlockRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_block/{request.Block}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module IndicesRemoveBlockRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesRemoveBlockRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesRemoveBlockRequest.ToRequest request

    type IndicesRemoveBlockRequestBuilder() =
        member _.Yield(_: unit) : IndicesRemoveBlockRequest =
            {
                IndicesRemoveBlockRequest.Index = Unchecked.defaultof<Indices>
                IndicesRemoveBlockRequest.Block = Unchecked.defaultof<TypesIndicesBlockOptions>
                IndicesRemoveBlockRequest.AllowNoIndices = Option.None
                IndicesRemoveBlockRequest.ExpandWildcards = Option.None
                IndicesRemoveBlockRequest.IgnoreUnavailable = Option.None
                IndicesRemoveBlockRequest.MasterTimeout = Option.None
                IndicesRemoveBlockRequest.Timeout = Option.None
            } : IndicesRemoveBlockRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRemoveBlockRequest, value: Indices) =
            { state with IndicesRemoveBlockRequest.Index = value } : IndicesRemoveBlockRequest

        [<CustomOperation("block")>]
        member _.Block(state: IndicesRemoveBlockRequest, value: TypesIndicesBlockOptions) =
            { state with IndicesRemoveBlockRequest.Block = value } : IndicesRemoveBlockRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesRemoveBlockRequest, value: bool) =
            { state with IndicesRemoveBlockRequest.AllowNoIndices = Option.Some value } : IndicesRemoveBlockRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesRemoveBlockRequest, value: ExpandWildcards) =
            { state with IndicesRemoveBlockRequest.ExpandWildcards = Option.Some value } : IndicesRemoveBlockRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesRemoveBlockRequest, value: bool) =
            { state with IndicesRemoveBlockRequest.IgnoreUnavailable = Option.Some value } : IndicesRemoveBlockRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesRemoveBlockRequest, value: Duration) =
            { state with IndicesRemoveBlockRequest.MasterTimeout = Option.Some value } : IndicesRemoveBlockRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesRemoveBlockRequest, value: Duration) =
            { state with IndicesRemoveBlockRequest.Timeout = Option.Some value } : IndicesRemoveBlockRequest

    let indicesRemoveBlockRequest = IndicesRemoveBlockRequestBuilder()

    type IndicesRemoveBlockResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("indices")>]
        Indices: RemoveBlockRemoveIndicesBlockStatus array
    }

    type IndicesAnalyzeRequest = {
        Index: IndexName
        QueryIndex: IndexName option
        [<JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<JsonPropertyName("attributes")>]
        Attributes: string array option
        [<JsonPropertyName("char_filter")>]
        CharFilter: AnalysisCharFilter array option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("field")>]
        Field: Field option
        [<JsonPropertyName("filter")>]
        Filter: AnalysisTokenFilter array option
        [<JsonPropertyName("normalizer")>]
        Normalizer: string option
        [<JsonPropertyName("text")>]
        Text: AnalyzeTextToAnalyze option
        [<JsonPropertyName("tokenizer")>]
        Tokenizer: AnalysisTokenizer option
    } with
        static member ToRequest(request: IndicesAnalyzeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_analyze"
                let queryParams =
                    [
                        request.QueryIndex |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``analyzer`` = request.Analyzer; ``attributes`` = request.Attributes; ``char_filter`` = request.CharFilter; ``explain`` = request.Explain; ``field`` = request.Field; ``filter`` = request.Filter; ``normalizer`` = request.Normalizer; ``text`` = request.Text; ``tokenizer`` = request.Tokenizer |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesAnalyzeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesAnalyzeRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesAnalyzeRequest.ToRequest request

    type IndicesAnalyzeRequestBuilder() =
        member _.Yield(_: unit) : IndicesAnalyzeRequest =
            {
                IndicesAnalyzeRequest.Index = Unchecked.defaultof<IndexName>
                IndicesAnalyzeRequest.QueryIndex = Option.None
                IndicesAnalyzeRequest.Analyzer = Option.None
                IndicesAnalyzeRequest.Attributes = Option.None
                IndicesAnalyzeRequest.CharFilter = Option.None
                IndicesAnalyzeRequest.Explain = Option.None
                IndicesAnalyzeRequest.Field = Option.None
                IndicesAnalyzeRequest.Filter = Option.None
                IndicesAnalyzeRequest.Normalizer = Option.None
                IndicesAnalyzeRequest.Text = Option.None
                IndicesAnalyzeRequest.Tokenizer = Option.None
            } : IndicesAnalyzeRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesAnalyzeRequest, value: IndexName) =
            { state with IndicesAnalyzeRequest.Index = value } : IndicesAnalyzeRequest

        [<CustomOperation("query_index")>]
        member _.QueryIndex(state: IndicesAnalyzeRequest, value: IndexName) =
            { state with IndicesAnalyzeRequest.QueryIndex = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IndicesAnalyzeRequest, value: string) =
            { state with IndicesAnalyzeRequest.Analyzer = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("attributes")>]
        member _.Attributes(state: IndicesAnalyzeRequest, value: string array) =
            { state with IndicesAnalyzeRequest.Attributes = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("char_filter")>]
        member _.CharFilter(state: IndicesAnalyzeRequest, value: AnalysisCharFilter array) =
            { state with IndicesAnalyzeRequest.CharFilter = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: IndicesAnalyzeRequest, value: bool) =
            { state with IndicesAnalyzeRequest.Explain = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("field")>]
        member _.Field(state: IndicesAnalyzeRequest, value: Field) =
            { state with IndicesAnalyzeRequest.Field = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: IndicesAnalyzeRequest, value: AnalysisTokenFilter array) =
            { state with IndicesAnalyzeRequest.Filter = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: IndicesAnalyzeRequest, value: string) =
            { state with IndicesAnalyzeRequest.Normalizer = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("text")>]
        member _.Text(state: IndicesAnalyzeRequest, value: AnalyzeTextToAnalyze) =
            { state with IndicesAnalyzeRequest.Text = Option.Some value } : IndicesAnalyzeRequest

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: IndicesAnalyzeRequest, value: AnalysisTokenizer) =
            { state with IndicesAnalyzeRequest.Tokenizer = Option.Some value } : IndicesAnalyzeRequest

    let indicesAnalyzeRequest = IndicesAnalyzeRequestBuilder()

    type IndicesClearCacheRequest = {
        Index: Indices
        QueryIndex: Indices option
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        Fielddata: bool option
        Fields: Fields option
        IgnoreUnavailable: bool option
        Query: bool option
        Request: bool option
    } with
        static member ToRequest(request: IndicesClearCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_cache/clear"
                let queryParams =
                    [
                        request.QueryIndex |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.Fielddata |> Option.map (fun v -> "fielddata", Fes.Http.toQueryValue v)
                        request.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Query |> Option.map (fun v -> "query", Fes.Http.toQueryValue v)
                        request.Request |> Option.map (fun v -> "request", Fes.Http.toQueryValue v)
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

    module IndicesClearCacheRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesClearCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesClearCacheRequest.ToRequest request

    type IndicesClearCacheRequestBuilder() =
        member _.Yield(_: unit) : IndicesClearCacheRequest =
            {
                IndicesClearCacheRequest.Index = Unchecked.defaultof<Indices>
                IndicesClearCacheRequest.QueryIndex = Option.None
                IndicesClearCacheRequest.AllowNoIndices = Option.None
                IndicesClearCacheRequest.ExpandWildcards = Option.None
                IndicesClearCacheRequest.Fielddata = Option.None
                IndicesClearCacheRequest.Fields = Option.None
                IndicesClearCacheRequest.IgnoreUnavailable = Option.None
                IndicesClearCacheRequest.Query = Option.None
                IndicesClearCacheRequest.Request = Option.None
            } : IndicesClearCacheRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesClearCacheRequest, value: Indices) =
            { state with IndicesClearCacheRequest.Index = value } : IndicesClearCacheRequest

        [<CustomOperation("query_index")>]
        member _.QueryIndex(state: IndicesClearCacheRequest, value: Indices) =
            { state with IndicesClearCacheRequest.QueryIndex = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesClearCacheRequest, value: bool) =
            { state with IndicesClearCacheRequest.AllowNoIndices = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesClearCacheRequest, value: ExpandWildcards) =
            { state with IndicesClearCacheRequest.ExpandWildcards = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: IndicesClearCacheRequest, value: bool) =
            { state with IndicesClearCacheRequest.Fielddata = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesClearCacheRequest, value: Fields) =
            { state with IndicesClearCacheRequest.Fields = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesClearCacheRequest, value: bool) =
            { state with IndicesClearCacheRequest.IgnoreUnavailable = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("query")>]
        member _.Query(state: IndicesClearCacheRequest, value: bool) =
            { state with IndicesClearCacheRequest.Query = Option.Some value } : IndicesClearCacheRequest

        [<CustomOperation("request")>]
        member _.Request(state: IndicesClearCacheRequest, value: bool) =
            { state with IndicesClearCacheRequest.Request = Option.Some value } : IndicesClearCacheRequest

    let indicesClearCacheRequest = IndicesClearCacheRequestBuilder()

    type IndicesCloneRequest = {
        Index: IndexName
        Target: Name
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        [<JsonPropertyName("aliases")>]
        Aliases: Map<string, TypesAlias> option
        [<JsonPropertyName("settings")>]
        Settings: Map<string, obj> option
    } with
        static member ToRequest(request: IndicesCloneRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_clone/{request.Target}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aliases`` = request.Aliases; ``settings`` = request.Settings |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesCloneRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesCloneRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesCloneRequest.ToRequest request

    type IndicesCloneRequestBuilder() =
        member _.Yield(_: unit) : IndicesCloneRequest =
            {
                IndicesCloneRequest.Index = Unchecked.defaultof<IndexName>
                IndicesCloneRequest.Target = Unchecked.defaultof<Name>
                IndicesCloneRequest.MasterTimeout = Option.None
                IndicesCloneRequest.Timeout = Option.None
                IndicesCloneRequest.WaitForActiveShards = Option.None
                IndicesCloneRequest.Aliases = Option.None
                IndicesCloneRequest.Settings = Option.None
            } : IndicesCloneRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCloneRequest, value: IndexName) =
            { state with IndicesCloneRequest.Index = value } : IndicesCloneRequest

        [<CustomOperation("target")>]
        member _.Target(state: IndicesCloneRequest, value: Name) =
            { state with IndicesCloneRequest.Target = value } : IndicesCloneRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesCloneRequest, value: Duration) =
            { state with IndicesCloneRequest.MasterTimeout = Option.Some value } : IndicesCloneRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCloneRequest, value: Duration) =
            { state with IndicesCloneRequest.Timeout = Option.Some value } : IndicesCloneRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesCloneRequest, value: WaitForActiveShards) =
            { state with IndicesCloneRequest.WaitForActiveShards = Option.Some value } : IndicesCloneRequest

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesCloneRequest, value: Map<string, TypesAlias>) =
            { state with IndicesCloneRequest.Aliases = Option.Some value } : IndicesCloneRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesCloneRequest, value: Map<string, obj>) =
            { state with IndicesCloneRequest.Settings = Option.Some value } : IndicesCloneRequest

    let indicesCloneRequest = IndicesCloneRequestBuilder()

    type IndicesCloseRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
    } with
        static member ToRequest(request: IndicesCloseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_close"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module IndicesCloseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesCloseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesCloseRequest.ToRequest request

    type IndicesCloseRequestBuilder() =
        member _.Yield(_: unit) : IndicesCloseRequest =
            {
                IndicesCloseRequest.Index = Unchecked.defaultof<Indices>
                IndicesCloseRequest.AllowNoIndices = Option.None
                IndicesCloseRequest.ExpandWildcards = Option.None
                IndicesCloseRequest.IgnoreUnavailable = Option.None
                IndicesCloseRequest.MasterTimeout = Option.None
                IndicesCloseRequest.Timeout = Option.None
                IndicesCloseRequest.WaitForActiveShards = Option.None
            } : IndicesCloseRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCloseRequest, value: Indices) =
            { state with IndicesCloseRequest.Index = value } : IndicesCloseRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesCloseRequest, value: bool) =
            { state with IndicesCloseRequest.AllowNoIndices = Option.Some value } : IndicesCloseRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesCloseRequest, value: ExpandWildcards) =
            { state with IndicesCloseRequest.ExpandWildcards = Option.Some value } : IndicesCloseRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesCloseRequest, value: bool) =
            { state with IndicesCloseRequest.IgnoreUnavailable = Option.Some value } : IndicesCloseRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesCloseRequest, value: Duration) =
            { state with IndicesCloseRequest.MasterTimeout = Option.Some value } : IndicesCloseRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCloseRequest, value: Duration) =
            { state with IndicesCloseRequest.Timeout = Option.Some value } : IndicesCloseRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesCloseRequest, value: WaitForActiveShards) =
            { state with IndicesCloseRequest.WaitForActiveShards = Option.Some value } : IndicesCloseRequest

    let indicesCloseRequest = IndicesCloseRequestBuilder()

    type IndicesCloseResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("indices")>]
        Indices: Map<string, CloseCloseIndexResult>
        [<JsonPropertyName("shards_acknowledged")>]
        ShardsAcknowledged: bool
    }

    type IndicesGetRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
        Local: bool option
        MasterTimeout: Duration option
        Features: GetFeatures option
    } with
        static member ToRequest(request: IndicesGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Features |> Option.map (fun v -> "features", Fes.Http.toQueryValue v)
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

    module IndicesGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetRequest.ToRequest request

    type IndicesGetRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetRequest =
            {
                IndicesGetRequest.Index = Unchecked.defaultof<Indices>
                IndicesGetRequest.AllowNoIndices = Option.None
                IndicesGetRequest.ExpandWildcards = Option.None
                IndicesGetRequest.FlatSettings = Option.None
                IndicesGetRequest.IgnoreUnavailable = Option.None
                IndicesGetRequest.IncludeDefaults = Option.None
                IndicesGetRequest.Local = Option.None
                IndicesGetRequest.MasterTimeout = Option.None
                IndicesGetRequest.Features = Option.None
            } : IndicesGetRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetRequest, value: Indices) =
            { state with IndicesGetRequest.Index = value } : IndicesGetRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesGetRequest, value: bool) =
            { state with IndicesGetRequest.AllowNoIndices = Option.Some value } : IndicesGetRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetRequest, value: ExpandWildcards) =
            { state with IndicesGetRequest.ExpandWildcards = Option.Some value } : IndicesGetRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesGetRequest, value: bool) =
            { state with IndicesGetRequest.FlatSettings = Option.Some value } : IndicesGetRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetRequest, value: bool) =
            { state with IndicesGetRequest.IgnoreUnavailable = Option.Some value } : IndicesGetRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesGetRequest, value: bool) =
            { state with IndicesGetRequest.IncludeDefaults = Option.Some value } : IndicesGetRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetRequest, value: bool) =
            { state with IndicesGetRequest.Local = Option.Some value } : IndicesGetRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetRequest, value: Duration) =
            { state with IndicesGetRequest.MasterTimeout = Option.Some value } : IndicesGetRequest

        [<CustomOperation("features")>]
        member _.Features(state: IndicesGetRequest, value: GetFeatures) =
            { state with IndicesGetRequest.Features = Option.Some value } : IndicesGetRequest

    let indicesGetRequest = IndicesGetRequestBuilder()

    type IndicesCreateRequest = {
        Index: IndexName
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        [<JsonPropertyName("aliases")>]
        Aliases: Map<string, TypesAlias> option
        [<JsonPropertyName("mappings")>]
        Mappings: MappingTypeMapping option
        [<JsonPropertyName("settings")>]
        Settings: TypesIndexSettings option
    } with
        static member ToRequest(request: IndicesCreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``aliases`` = request.Aliases; ``mappings`` = request.Mappings; ``settings`` = request.Settings |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesCreateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesCreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesCreateRequest.ToRequest request

    type IndicesCreateRequestBuilder() =
        member _.Yield(_: unit) : IndicesCreateRequest =
            {
                IndicesCreateRequest.Index = Unchecked.defaultof<IndexName>
                IndicesCreateRequest.MasterTimeout = Option.None
                IndicesCreateRequest.Timeout = Option.None
                IndicesCreateRequest.WaitForActiveShards = Option.None
                IndicesCreateRequest.Aliases = Option.None
                IndicesCreateRequest.Mappings = Option.None
                IndicesCreateRequest.Settings = Option.None
            } : IndicesCreateRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCreateRequest, value: IndexName) =
            { state with IndicesCreateRequest.Index = value } : IndicesCreateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesCreateRequest, value: Duration) =
            { state with IndicesCreateRequest.MasterTimeout = Option.Some value } : IndicesCreateRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCreateRequest, value: Duration) =
            { state with IndicesCreateRequest.Timeout = Option.Some value } : IndicesCreateRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesCreateRequest, value: WaitForActiveShards) =
            { state with IndicesCreateRequest.WaitForActiveShards = Option.Some value } : IndicesCreateRequest

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesCreateRequest, value: Map<string, TypesAlias>) =
            { state with IndicesCreateRequest.Aliases = Option.Some value } : IndicesCreateRequest

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndicesCreateRequest, value: MappingTypeMapping) =
            { state with IndicesCreateRequest.Mappings = Option.Some value } : IndicesCreateRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesCreateRequest, value: TypesIndexSettings) =
            { state with IndicesCreateRequest.Settings = Option.Some value } : IndicesCreateRequest

    let indicesCreateRequest = IndicesCreateRequestBuilder()

    type IndicesCreateResponse = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("shards_acknowledged")>]
        ShardsAcknowledged: bool
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
    }

    type IndicesDeleteRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module IndicesDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteRequest.ToRequest request

    type IndicesDeleteRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteRequest =
            {
                IndicesDeleteRequest.Index = Unchecked.defaultof<Indices>
                IndicesDeleteRequest.AllowNoIndices = Option.None
                IndicesDeleteRequest.ExpandWildcards = Option.None
                IndicesDeleteRequest.IgnoreUnavailable = Option.None
                IndicesDeleteRequest.MasterTimeout = Option.None
                IndicesDeleteRequest.Timeout = Option.None
            } : IndicesDeleteRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDeleteRequest, value: Indices) =
            { state with IndicesDeleteRequest.Index = value } : IndicesDeleteRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesDeleteRequest, value: bool) =
            { state with IndicesDeleteRequest.AllowNoIndices = Option.Some value } : IndicesDeleteRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteRequest, value: ExpandWildcards) =
            { state with IndicesDeleteRequest.ExpandWildcards = Option.Some value } : IndicesDeleteRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesDeleteRequest, value: bool) =
            { state with IndicesDeleteRequest.IgnoreUnavailable = Option.Some value } : IndicesDeleteRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteRequest, value: Duration) =
            { state with IndicesDeleteRequest.MasterTimeout = Option.Some value } : IndicesDeleteRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteRequest, value: Duration) =
            { state with IndicesDeleteRequest.Timeout = Option.Some value } : IndicesDeleteRequest

    let indicesDeleteRequest = IndicesDeleteRequestBuilder()

    type IndicesDeleteResponse = IndicesResponseBase

    type IndicesExistsRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
        Local: bool option
    } with
        static member ToRequest(request: IndicesExistsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
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

    module IndicesExistsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesExistsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesExistsRequest.ToRequest request

    type IndicesExistsRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsRequest =
            {
                IndicesExistsRequest.Index = Unchecked.defaultof<Indices>
                IndicesExistsRequest.AllowNoIndices = Option.None
                IndicesExistsRequest.ExpandWildcards = Option.None
                IndicesExistsRequest.FlatSettings = Option.None
                IndicesExistsRequest.IgnoreUnavailable = Option.None
                IndicesExistsRequest.IncludeDefaults = Option.None
                IndicesExistsRequest.Local = Option.None
            } : IndicesExistsRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesExistsRequest, value: Indices) =
            { state with IndicesExistsRequest.Index = value } : IndicesExistsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesExistsRequest, value: bool) =
            { state with IndicesExistsRequest.AllowNoIndices = Option.Some value } : IndicesExistsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesExistsRequest, value: ExpandWildcards) =
            { state with IndicesExistsRequest.ExpandWildcards = Option.Some value } : IndicesExistsRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesExistsRequest, value: bool) =
            { state with IndicesExistsRequest.FlatSettings = Option.Some value } : IndicesExistsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesExistsRequest, value: bool) =
            { state with IndicesExistsRequest.IgnoreUnavailable = Option.Some value } : IndicesExistsRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesExistsRequest, value: bool) =
            { state with IndicesExistsRequest.IncludeDefaults = Option.Some value } : IndicesExistsRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesExistsRequest, value: bool) =
            { state with IndicesExistsRequest.Local = Option.Some value } : IndicesExistsRequest

    let indicesExistsRequest = IndicesExistsRequestBuilder()

    type IndicesPutAliasRequest = {
        Index: Indices
        Name: Name
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("filter")>]
        Filter: QueryDslQueryContainer option
        [<JsonPropertyName("index_routing")>]
        IndexRouting: Routing option
        [<JsonPropertyName("is_write_index")>]
        IsWriteIndex: bool option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("search_routing")>]
        SearchRouting: Routing option
    } with
        static member ToRequest(request: IndicesPutAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_aliases/{request.Name}"
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
                |> Fes.Http.Request.withJsonBody {| ``filter`` = request.Filter; ``index_routing`` = request.IndexRouting; ``is_write_index`` = request.IsWriteIndex; ``routing`` = request.Routing; ``search_routing`` = request.SearchRouting |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutAliasRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutAliasRequest.ToRequest request

    type IndicesPutAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutAliasRequest =
            {
                IndicesPutAliasRequest.Index = Unchecked.defaultof<Indices>
                IndicesPutAliasRequest.Name = Unchecked.defaultof<Name>
                IndicesPutAliasRequest.MasterTimeout = Option.None
                IndicesPutAliasRequest.Timeout = Option.None
                IndicesPutAliasRequest.Filter = Option.None
                IndicesPutAliasRequest.IndexRouting = Option.None
                IndicesPutAliasRequest.IsWriteIndex = Option.None
                IndicesPutAliasRequest.Routing = Option.None
                IndicesPutAliasRequest.SearchRouting = Option.None
            } : IndicesPutAliasRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesPutAliasRequest, value: Indices) =
            { state with IndicesPutAliasRequest.Index = value } : IndicesPutAliasRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutAliasRequest, value: Name) =
            { state with IndicesPutAliasRequest.Name = value } : IndicesPutAliasRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutAliasRequest, value: Duration) =
            { state with IndicesPutAliasRequest.MasterTimeout = Option.Some value } : IndicesPutAliasRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutAliasRequest, value: Duration) =
            { state with IndicesPutAliasRequest.Timeout = Option.Some value } : IndicesPutAliasRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: IndicesPutAliasRequest, value: QueryDslQueryContainer) =
            { state with IndicesPutAliasRequest.Filter = Option.Some value } : IndicesPutAliasRequest

        [<CustomOperation("index_routing")>]
        member _.IndexRouting(state: IndicesPutAliasRequest, value: Routing) =
            { state with IndicesPutAliasRequest.IndexRouting = Option.Some value } : IndicesPutAliasRequest

        [<CustomOperation("is_write_index")>]
        member _.IsWriteIndex(state: IndicesPutAliasRequest, value: bool) =
            { state with IndicesPutAliasRequest.IsWriteIndex = Option.Some value } : IndicesPutAliasRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: IndicesPutAliasRequest, value: Routing) =
            { state with IndicesPutAliasRequest.Routing = Option.Some value } : IndicesPutAliasRequest

        [<CustomOperation("search_routing")>]
        member _.SearchRouting(state: IndicesPutAliasRequest, value: Routing) =
            { state with IndicesPutAliasRequest.SearchRouting = Option.Some value } : IndicesPutAliasRequest

    let indicesPutAliasRequest = IndicesPutAliasRequestBuilder()

    type IndicesDeleteAliasRequest = {
        Index: Indices
        Name: Names
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesDeleteAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_aliases/{request.Name}"
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

    module IndicesDeleteAliasRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteAliasRequest.ToRequest request

    type IndicesDeleteAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteAliasRequest =
            {
                IndicesDeleteAliasRequest.Index = Unchecked.defaultof<Indices>
                IndicesDeleteAliasRequest.Name = Unchecked.defaultof<Names>
                IndicesDeleteAliasRequest.MasterTimeout = Option.None
                IndicesDeleteAliasRequest.Timeout = Option.None
            } : IndicesDeleteAliasRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDeleteAliasRequest, value: Indices) =
            { state with IndicesDeleteAliasRequest.Index = value } : IndicesDeleteAliasRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteAliasRequest, value: Names) =
            { state with IndicesDeleteAliasRequest.Name = value } : IndicesDeleteAliasRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteAliasRequest, value: Duration) =
            { state with IndicesDeleteAliasRequest.MasterTimeout = Option.Some value } : IndicesDeleteAliasRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteAliasRequest, value: Duration) =
            { state with IndicesDeleteAliasRequest.Timeout = Option.Some value } : IndicesDeleteAliasRequest

    let indicesDeleteAliasRequest = IndicesDeleteAliasRequestBuilder()

    type IndicesDeleteDataLifecycleRequest = {
        Name: DataStreamNames
        ExpandWildcards: ExpandWildcards option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesDeleteDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_lifecycle"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
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

    module IndicesDeleteDataLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteDataLifecycleRequest.ToRequest request

    type IndicesDeleteDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteDataLifecycleRequest =
            {
                IndicesDeleteDataLifecycleRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesDeleteDataLifecycleRequest.ExpandWildcards = Option.None
                IndicesDeleteDataLifecycleRequest.MasterTimeout = Option.None
                IndicesDeleteDataLifecycleRequest.Timeout = Option.None
            } : IndicesDeleteDataLifecycleRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteDataLifecycleRequest, value: DataStreamNames) =
            { state with IndicesDeleteDataLifecycleRequest.Name = value } : IndicesDeleteDataLifecycleRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteDataLifecycleRequest, value: ExpandWildcards) =
            { state with IndicesDeleteDataLifecycleRequest.ExpandWildcards = Option.Some value } : IndicesDeleteDataLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteDataLifecycleRequest, value: Duration) =
            { state with IndicesDeleteDataLifecycleRequest.MasterTimeout = Option.Some value } : IndicesDeleteDataLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteDataLifecycleRequest, value: Duration) =
            { state with IndicesDeleteDataLifecycleRequest.Timeout = Option.Some value } : IndicesDeleteDataLifecycleRequest

    let indicesDeleteDataLifecycleRequest = IndicesDeleteDataLifecycleRequestBuilder()

    type IndicesDeleteDataLifecycleResponse = AcknowledgedResponseBase

    type IndicesGetIndexTemplateRequest = {
        Name: Name
        Local: bool option
        FlatSettings: bool option
        MasterTimeout: Duration option
        IncludeDefaults: bool option
    } with
        static member ToRequest(request: IndicesGetIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{request.Name}"
                let queryParams =
                    [
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
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

    module IndicesGetIndexTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetIndexTemplateRequest.ToRequest request

    type IndicesGetIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetIndexTemplateRequest =
            {
                IndicesGetIndexTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesGetIndexTemplateRequest.Local = Option.None
                IndicesGetIndexTemplateRequest.FlatSettings = Option.None
                IndicesGetIndexTemplateRequest.MasterTimeout = Option.None
                IndicesGetIndexTemplateRequest.IncludeDefaults = Option.None
            } : IndicesGetIndexTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetIndexTemplateRequest, value: Name) =
            { state with IndicesGetIndexTemplateRequest.Name = value } : IndicesGetIndexTemplateRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetIndexTemplateRequest, value: bool) =
            { state with IndicesGetIndexTemplateRequest.Local = Option.Some value } : IndicesGetIndexTemplateRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesGetIndexTemplateRequest, value: bool) =
            { state with IndicesGetIndexTemplateRequest.FlatSettings = Option.Some value } : IndicesGetIndexTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetIndexTemplateRequest, value: Duration) =
            { state with IndicesGetIndexTemplateRequest.MasterTimeout = Option.Some value } : IndicesGetIndexTemplateRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesGetIndexTemplateRequest, value: bool) =
            { state with IndicesGetIndexTemplateRequest.IncludeDefaults = Option.Some value } : IndicesGetIndexTemplateRequest

    let indicesGetIndexTemplateRequest = IndicesGetIndexTemplateRequestBuilder()

    type IndicesPutIndexTemplateRequest = {
        Name: Name
        Create: bool option
        MasterTimeout: Duration option
        Cause: string option
        [<JsonPropertyName("index_patterns")>]
        IndexPatterns: Indices option
        [<JsonPropertyName("composed_of")>]
        ComposedOf: Name array option
        [<JsonPropertyName("template")>]
        Template: PutIndexTemplateIndexTemplateMapping option
        [<JsonPropertyName("data_stream")>]
        DataStream: TypesDataStreamVisibility option
        [<JsonPropertyName("priority")>]
        Priority: float option
        [<JsonPropertyName("version")>]
        Version: VersionNumber option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("allow_auto_create")>]
        AllowAutoCreate: bool option
        [<JsonPropertyName("ignore_missing_component_templates")>]
        IgnoreMissingComponentTemplates: string array option
        [<JsonPropertyName("deprecated")>]
        Deprecated: bool option
    } with
        static member ToRequest(request: IndicesPutIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{request.Name}"
                let queryParams =
                    [
                        request.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``index_patterns`` = request.IndexPatterns; ``composed_of`` = request.ComposedOf; ``template`` = request.Template; ``data_stream`` = request.DataStream; ``priority`` = request.Priority; ``version`` = request.Version; ``_meta`` = request.Meta; ``allow_auto_create`` = request.AllowAutoCreate; ``ignore_missing_component_templates`` = request.IgnoreMissingComponentTemplates; ``deprecated`` = request.Deprecated |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutIndexTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutIndexTemplateRequest.ToRequest request

    type IndicesPutIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutIndexTemplateRequest =
            {
                IndicesPutIndexTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesPutIndexTemplateRequest.Create = Option.None
                IndicesPutIndexTemplateRequest.MasterTimeout = Option.None
                IndicesPutIndexTemplateRequest.Cause = Option.None
                IndicesPutIndexTemplateRequest.IndexPatterns = Option.None
                IndicesPutIndexTemplateRequest.ComposedOf = Option.None
                IndicesPutIndexTemplateRequest.Template = Option.None
                IndicesPutIndexTemplateRequest.DataStream = Option.None
                IndicesPutIndexTemplateRequest.Priority = Option.None
                IndicesPutIndexTemplateRequest.Version = Option.None
                IndicesPutIndexTemplateRequest.Meta = Option.None
                IndicesPutIndexTemplateRequest.AllowAutoCreate = Option.None
                IndicesPutIndexTemplateRequest.IgnoreMissingComponentTemplates = Option.None
                IndicesPutIndexTemplateRequest.Deprecated = Option.None
            } : IndicesPutIndexTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutIndexTemplateRequest, value: Name) =
            { state with IndicesPutIndexTemplateRequest.Name = value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("create")>]
        member _.Create(state: IndicesPutIndexTemplateRequest, value: bool) =
            { state with IndicesPutIndexTemplateRequest.Create = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutIndexTemplateRequest, value: Duration) =
            { state with IndicesPutIndexTemplateRequest.MasterTimeout = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesPutIndexTemplateRequest, value: string) =
            { state with IndicesPutIndexTemplateRequest.Cause = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("index_patterns")>]
        member _.IndexPatterns(state: IndicesPutIndexTemplateRequest, value: Indices) =
            { state with IndicesPutIndexTemplateRequest.IndexPatterns = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("composed_of")>]
        member _.ComposedOf(state: IndicesPutIndexTemplateRequest, value: Name array) =
            { state with IndicesPutIndexTemplateRequest.ComposedOf = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("template")>]
        member _.Template(state: IndicesPutIndexTemplateRequest, value: PutIndexTemplateIndexTemplateMapping) =
            { state with IndicesPutIndexTemplateRequest.Template = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("data_stream")>]
        member _.DataStream(state: IndicesPutIndexTemplateRequest, value: TypesDataStreamVisibility) =
            { state with IndicesPutIndexTemplateRequest.DataStream = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("priority")>]
        member _.Priority(state: IndicesPutIndexTemplateRequest, value: float) =
            { state with IndicesPutIndexTemplateRequest.Priority = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("version")>]
        member _.Version(state: IndicesPutIndexTemplateRequest, value: VersionNumber) =
            { state with IndicesPutIndexTemplateRequest.Version = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: IndicesPutIndexTemplateRequest, value: Metadata) =
            { state with IndicesPutIndexTemplateRequest.Meta = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("allow_auto_create")>]
        member _.AllowAutoCreate(state: IndicesPutIndexTemplateRequest, value: bool) =
            { state with IndicesPutIndexTemplateRequest.AllowAutoCreate = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("ignore_missing_component_templates")>]
        member _.IgnoreMissingComponentTemplates(state: IndicesPutIndexTemplateRequest, value: string array) =
            { state with IndicesPutIndexTemplateRequest.IgnoreMissingComponentTemplates = Option.Some value } : IndicesPutIndexTemplateRequest

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IndicesPutIndexTemplateRequest, value: bool) =
            { state with IndicesPutIndexTemplateRequest.Deprecated = Option.Some value } : IndicesPutIndexTemplateRequest

    let indicesPutIndexTemplateRequest = IndicesPutIndexTemplateRequestBuilder()

    type IndicesDeleteIndexTemplateRequest = {
        Name: Names
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesDeleteIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{request.Name}"
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

    module IndicesDeleteIndexTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteIndexTemplateRequest.ToRequest request

    type IndicesDeleteIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteIndexTemplateRequest =
            {
                IndicesDeleteIndexTemplateRequest.Name = Unchecked.defaultof<Names>
                IndicesDeleteIndexTemplateRequest.MasterTimeout = Option.None
                IndicesDeleteIndexTemplateRequest.Timeout = Option.None
            } : IndicesDeleteIndexTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteIndexTemplateRequest, value: Names) =
            { state with IndicesDeleteIndexTemplateRequest.Name = value } : IndicesDeleteIndexTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteIndexTemplateRequest, value: Duration) =
            { state with IndicesDeleteIndexTemplateRequest.MasterTimeout = Option.Some value } : IndicesDeleteIndexTemplateRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteIndexTemplateRequest, value: Duration) =
            { state with IndicesDeleteIndexTemplateRequest.Timeout = Option.Some value } : IndicesDeleteIndexTemplateRequest

    let indicesDeleteIndexTemplateRequest = IndicesDeleteIndexTemplateRequestBuilder()

    type IndicesDeleteIndexTemplateResponse = AcknowledgedResponseBase

    type IndicesExistsIndexTemplateRequest = {
        Name: Name
        Local: bool option
        FlatSettings: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesExistsIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{request.Name}"
                let queryParams =
                    [
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module IndicesExistsIndexTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesExistsIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesExistsIndexTemplateRequest.ToRequest request

    type IndicesExistsIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsIndexTemplateRequest =
            {
                IndicesExistsIndexTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesExistsIndexTemplateRequest.Local = Option.None
                IndicesExistsIndexTemplateRequest.FlatSettings = Option.None
                IndicesExistsIndexTemplateRequest.MasterTimeout = Option.None
            } : IndicesExistsIndexTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesExistsIndexTemplateRequest, value: Name) =
            { state with IndicesExistsIndexTemplateRequest.Name = value } : IndicesExistsIndexTemplateRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesExistsIndexTemplateRequest, value: bool) =
            { state with IndicesExistsIndexTemplateRequest.Local = Option.Some value } : IndicesExistsIndexTemplateRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesExistsIndexTemplateRequest, value: bool) =
            { state with IndicesExistsIndexTemplateRequest.FlatSettings = Option.Some value } : IndicesExistsIndexTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesExistsIndexTemplateRequest, value: Duration) =
            { state with IndicesExistsIndexTemplateRequest.MasterTimeout = Option.Some value } : IndicesExistsIndexTemplateRequest

    let indicesExistsIndexTemplateRequest = IndicesExistsIndexTemplateRequestBuilder()

    type IndicesGetTemplateRequest = {
        Name: Names
        FlatSettings: bool option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{request.Name}"
                let queryParams =
                    [
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
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

    module IndicesGetTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetTemplateRequest.ToRequest request

    type IndicesGetTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetTemplateRequest =
            {
                IndicesGetTemplateRequest.Name = Unchecked.defaultof<Names>
                IndicesGetTemplateRequest.FlatSettings = Option.None
                IndicesGetTemplateRequest.Local = Option.None
                IndicesGetTemplateRequest.MasterTimeout = Option.None
            } : IndicesGetTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetTemplateRequest, value: Names) =
            { state with IndicesGetTemplateRequest.Name = value } : IndicesGetTemplateRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesGetTemplateRequest, value: bool) =
            { state with IndicesGetTemplateRequest.FlatSettings = Option.Some value } : IndicesGetTemplateRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetTemplateRequest, value: bool) =
            { state with IndicesGetTemplateRequest.Local = Option.Some value } : IndicesGetTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetTemplateRequest, value: Duration) =
            { state with IndicesGetTemplateRequest.MasterTimeout = Option.Some value } : IndicesGetTemplateRequest

    let indicesGetTemplateRequest = IndicesGetTemplateRequestBuilder()

    type IndicesPutTemplateRequest = {
        Name: Name
        Create: bool option
        MasterTimeout: Duration option
        Order: float option
        Cause: string option
        [<JsonPropertyName("aliases")>]
        Aliases: Map<string, TypesAlias> option
        [<JsonPropertyName("index_patterns")>]
        IndexPatterns: System.Text.Json.JsonElement option
        [<JsonPropertyName("mappings")>]
        Mappings: MappingTypeMapping option
        [<JsonPropertyName("order")>]
        BodyOrder: float option
        [<JsonPropertyName("settings")>]
        Settings: TypesIndexSettings option
        [<JsonPropertyName("version")>]
        Version: VersionNumber option
    } with
        static member ToRequest(request: IndicesPutTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{request.Name}"
                let queryParams =
                    [
                        request.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Order |> Option.map (fun v -> "order", Fes.Http.toQueryValue v)
                        request.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aliases`` = request.Aliases; ``index_patterns`` = request.IndexPatterns; ``mappings`` = request.Mappings; ``order`` = request.BodyOrder; ``settings`` = request.Settings; ``version`` = request.Version |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutTemplateRequest.ToRequest request

    type IndicesPutTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutTemplateRequest =
            {
                IndicesPutTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesPutTemplateRequest.Create = Option.None
                IndicesPutTemplateRequest.MasterTimeout = Option.None
                IndicesPutTemplateRequest.Order = Option.None
                IndicesPutTemplateRequest.Cause = Option.None
                IndicesPutTemplateRequest.Aliases = Option.None
                IndicesPutTemplateRequest.IndexPatterns = Option.None
                IndicesPutTemplateRequest.Mappings = Option.None
                IndicesPutTemplateRequest.BodyOrder = Option.None
                IndicesPutTemplateRequest.Settings = Option.None
                IndicesPutTemplateRequest.Version = Option.None
            } : IndicesPutTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutTemplateRequest, value: Name) =
            { state with IndicesPutTemplateRequest.Name = value } : IndicesPutTemplateRequest

        [<CustomOperation("create")>]
        member _.Create(state: IndicesPutTemplateRequest, value: bool) =
            { state with IndicesPutTemplateRequest.Create = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutTemplateRequest, value: Duration) =
            { state with IndicesPutTemplateRequest.MasterTimeout = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("order")>]
        member _.Order(state: IndicesPutTemplateRequest, value: float) =
            { state with IndicesPutTemplateRequest.Order = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesPutTemplateRequest, value: string) =
            { state with IndicesPutTemplateRequest.Cause = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesPutTemplateRequest, value: Map<string, TypesAlias>) =
            { state with IndicesPutTemplateRequest.Aliases = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("index_patterns")>]
        member _.IndexPatterns(state: IndicesPutTemplateRequest, value: System.Text.Json.JsonElement) =
            { state with IndicesPutTemplateRequest.IndexPatterns = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndicesPutTemplateRequest, value: MappingTypeMapping) =
            { state with IndicesPutTemplateRequest.Mappings = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("body_order")>]
        member _.BodyOrder(state: IndicesPutTemplateRequest, value: float) =
            { state with IndicesPutTemplateRequest.BodyOrder = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesPutTemplateRequest, value: TypesIndexSettings) =
            { state with IndicesPutTemplateRequest.Settings = Option.Some value } : IndicesPutTemplateRequest

        [<CustomOperation("version")>]
        member _.Version(state: IndicesPutTemplateRequest, value: VersionNumber) =
            { state with IndicesPutTemplateRequest.Version = Option.Some value } : IndicesPutTemplateRequest

    let indicesPutTemplateRequest = IndicesPutTemplateRequestBuilder()

    type IndicesDeleteTemplateRequest = {
        Name: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesDeleteTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{request.Name}"
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

    module IndicesDeleteTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteTemplateRequest.ToRequest request

    type IndicesDeleteTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteTemplateRequest =
            {
                IndicesDeleteTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesDeleteTemplateRequest.MasterTimeout = Option.None
                IndicesDeleteTemplateRequest.Timeout = Option.None
            } : IndicesDeleteTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteTemplateRequest, value: Name) =
            { state with IndicesDeleteTemplateRequest.Name = value } : IndicesDeleteTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteTemplateRequest, value: Duration) =
            { state with IndicesDeleteTemplateRequest.MasterTimeout = Option.Some value } : IndicesDeleteTemplateRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteTemplateRequest, value: Duration) =
            { state with IndicesDeleteTemplateRequest.Timeout = Option.Some value } : IndicesDeleteTemplateRequest

    let indicesDeleteTemplateRequest = IndicesDeleteTemplateRequestBuilder()

    type IndicesDeleteTemplateResponse = AcknowledgedResponseBase

    type IndicesExistsTemplateRequest = {
        Name: Names
        FlatSettings: bool option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesExistsTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{request.Name}"
                let queryParams =
                    [
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module IndicesExistsTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesExistsTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesExistsTemplateRequest.ToRequest request

    type IndicesExistsTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsTemplateRequest =
            {
                IndicesExistsTemplateRequest.Name = Unchecked.defaultof<Names>
                IndicesExistsTemplateRequest.FlatSettings = Option.None
                IndicesExistsTemplateRequest.Local = Option.None
                IndicesExistsTemplateRequest.MasterTimeout = Option.None
            } : IndicesExistsTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesExistsTemplateRequest, value: Names) =
            { state with IndicesExistsTemplateRequest.Name = value } : IndicesExistsTemplateRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesExistsTemplateRequest, value: bool) =
            { state with IndicesExistsTemplateRequest.FlatSettings = Option.Some value } : IndicesExistsTemplateRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesExistsTemplateRequest, value: bool) =
            { state with IndicesExistsTemplateRequest.Local = Option.Some value } : IndicesExistsTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesExistsTemplateRequest, value: Duration) =
            { state with IndicesExistsTemplateRequest.MasterTimeout = Option.Some value } : IndicesExistsTemplateRequest

    let indicesExistsTemplateRequest = IndicesExistsTemplateRequestBuilder()

    type IndicesDiskUsageRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        Flush: bool option
        IgnoreUnavailable: bool option
        RunExpensiveTasks: bool option
    } with
        static member ToRequest(request: IndicesDiskUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_disk_usage"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.Flush |> Option.map (fun v -> "flush", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.RunExpensiveTasks |> Option.map (fun v -> "run_expensive_tasks", Fes.Http.toQueryValue v)
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

    module IndicesDiskUsageRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDiskUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDiskUsageRequest.ToRequest request

    type IndicesDiskUsageRequestBuilder() =
        member _.Yield(_: unit) : IndicesDiskUsageRequest =
            {
                IndicesDiskUsageRequest.Index = Unchecked.defaultof<Indices>
                IndicesDiskUsageRequest.AllowNoIndices = Option.None
                IndicesDiskUsageRequest.ExpandWildcards = Option.None
                IndicesDiskUsageRequest.Flush = Option.None
                IndicesDiskUsageRequest.IgnoreUnavailable = Option.None
                IndicesDiskUsageRequest.RunExpensiveTasks = Option.None
            } : IndicesDiskUsageRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDiskUsageRequest, value: Indices) =
            { state with IndicesDiskUsageRequest.Index = value } : IndicesDiskUsageRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesDiskUsageRequest, value: bool) =
            { state with IndicesDiskUsageRequest.AllowNoIndices = Option.Some value } : IndicesDiskUsageRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesDiskUsageRequest, value: ExpandWildcards) =
            { state with IndicesDiskUsageRequest.ExpandWildcards = Option.Some value } : IndicesDiskUsageRequest

        [<CustomOperation("flush")>]
        member _.Flush(state: IndicesDiskUsageRequest, value: bool) =
            { state with IndicesDiskUsageRequest.Flush = Option.Some value } : IndicesDiskUsageRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesDiskUsageRequest, value: bool) =
            { state with IndicesDiskUsageRequest.IgnoreUnavailable = Option.Some value } : IndicesDiskUsageRequest

        [<CustomOperation("run_expensive_tasks")>]
        member _.RunExpensiveTasks(state: IndicesDiskUsageRequest, value: bool) =
            { state with IndicesDiskUsageRequest.RunExpensiveTasks = Option.Some value } : IndicesDiskUsageRequest

    let indicesDiskUsageRequest = IndicesDiskUsageRequestBuilder()

    type IndicesGetAliasRequest = {
        Index: Indices
        Name: Names
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_alias/{request.Name}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
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

    module IndicesGetAliasRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetAliasRequest.ToRequest request

    type IndicesGetAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetAliasRequest =
            {
                IndicesGetAliasRequest.Index = Unchecked.defaultof<Indices>
                IndicesGetAliasRequest.Name = Unchecked.defaultof<Names>
                IndicesGetAliasRequest.AllowNoIndices = Option.None
                IndicesGetAliasRequest.ExpandWildcards = Option.None
                IndicesGetAliasRequest.IgnoreUnavailable = Option.None
                IndicesGetAliasRequest.MasterTimeout = Option.None
            } : IndicesGetAliasRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetAliasRequest, value: Indices) =
            { state with IndicesGetAliasRequest.Index = value } : IndicesGetAliasRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetAliasRequest, value: Names) =
            { state with IndicesGetAliasRequest.Name = value } : IndicesGetAliasRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesGetAliasRequest, value: bool) =
            { state with IndicesGetAliasRequest.AllowNoIndices = Option.Some value } : IndicesGetAliasRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetAliasRequest, value: ExpandWildcards) =
            { state with IndicesGetAliasRequest.ExpandWildcards = Option.Some value } : IndicesGetAliasRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetAliasRequest, value: bool) =
            { state with IndicesGetAliasRequest.IgnoreUnavailable = Option.Some value } : IndicesGetAliasRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetAliasRequest, value: Duration) =
            { state with IndicesGetAliasRequest.MasterTimeout = Option.Some value } : IndicesGetAliasRequest

    let indicesGetAliasRequest = IndicesGetAliasRequestBuilder()

    type IndicesExistsAliasRequest = {
        Index: Indices
        Name: Names
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesExistsAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_alias/{request.Name}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module IndicesExistsAliasRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesExistsAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesExistsAliasRequest.ToRequest request

    type IndicesExistsAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsAliasRequest =
            {
                IndicesExistsAliasRequest.Index = Unchecked.defaultof<Indices>
                IndicesExistsAliasRequest.Name = Unchecked.defaultof<Names>
                IndicesExistsAliasRequest.AllowNoIndices = Option.None
                IndicesExistsAliasRequest.ExpandWildcards = Option.None
                IndicesExistsAliasRequest.IgnoreUnavailable = Option.None
                IndicesExistsAliasRequest.MasterTimeout = Option.None
            } : IndicesExistsAliasRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesExistsAliasRequest, value: Indices) =
            { state with IndicesExistsAliasRequest.Index = value } : IndicesExistsAliasRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesExistsAliasRequest, value: Names) =
            { state with IndicesExistsAliasRequest.Name = value } : IndicesExistsAliasRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesExistsAliasRequest, value: bool) =
            { state with IndicesExistsAliasRequest.AllowNoIndices = Option.Some value } : IndicesExistsAliasRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesExistsAliasRequest, value: ExpandWildcards) =
            { state with IndicesExistsAliasRequest.ExpandWildcards = Option.Some value } : IndicesExistsAliasRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesExistsAliasRequest, value: bool) =
            { state with IndicesExistsAliasRequest.IgnoreUnavailable = Option.Some value } : IndicesExistsAliasRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesExistsAliasRequest, value: Duration) =
            { state with IndicesExistsAliasRequest.MasterTimeout = Option.Some value } : IndicesExistsAliasRequest

    let indicesExistsAliasRequest = IndicesExistsAliasRequestBuilder()

    type IndicesFieldUsageStatsRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        Fields: Fields option
    } with
        static member ToRequest(request: IndicesFieldUsageStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_field_usage_stats"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
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

    module IndicesFieldUsageStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesFieldUsageStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesFieldUsageStatsRequest.ToRequest request

    type IndicesFieldUsageStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesFieldUsageStatsRequest =
            {
                IndicesFieldUsageStatsRequest.Index = Unchecked.defaultof<Indices>
                IndicesFieldUsageStatsRequest.AllowNoIndices = Option.None
                IndicesFieldUsageStatsRequest.ExpandWildcards = Option.None
                IndicesFieldUsageStatsRequest.IgnoreUnavailable = Option.None
                IndicesFieldUsageStatsRequest.Fields = Option.None
            } : IndicesFieldUsageStatsRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesFieldUsageStatsRequest, value: Indices) =
            { state with IndicesFieldUsageStatsRequest.Index = value } : IndicesFieldUsageStatsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesFieldUsageStatsRequest, value: bool) =
            { state with IndicesFieldUsageStatsRequest.AllowNoIndices = Option.Some value } : IndicesFieldUsageStatsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesFieldUsageStatsRequest, value: ExpandWildcards) =
            { state with IndicesFieldUsageStatsRequest.ExpandWildcards = Option.Some value } : IndicesFieldUsageStatsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesFieldUsageStatsRequest, value: bool) =
            { state with IndicesFieldUsageStatsRequest.IgnoreUnavailable = Option.Some value } : IndicesFieldUsageStatsRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesFieldUsageStatsRequest, value: Fields) =
            { state with IndicesFieldUsageStatsRequest.Fields = Option.Some value } : IndicesFieldUsageStatsRequest

    let indicesFieldUsageStatsRequest = IndicesFieldUsageStatsRequestBuilder()

    type IndicesFieldUsageStatsResponse = FieldUsageStatsFieldsUsageBody

    type IndicesFlushRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        Force: bool option
        IgnoreUnavailable: bool option
        WaitIfOngoing: bool option
    } with
        static member ToRequest(request: IndicesFlushRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_flush"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.WaitIfOngoing |> Option.map (fun v -> "wait_if_ongoing", Fes.Http.toQueryValue v)
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

    module IndicesFlushRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesFlushRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesFlushRequest.ToRequest request

    type IndicesFlushRequestBuilder() =
        member _.Yield(_: unit) : IndicesFlushRequest =
            {
                IndicesFlushRequest.Index = Unchecked.defaultof<Indices>
                IndicesFlushRequest.AllowNoIndices = Option.None
                IndicesFlushRequest.ExpandWildcards = Option.None
                IndicesFlushRequest.Force = Option.None
                IndicesFlushRequest.IgnoreUnavailable = Option.None
                IndicesFlushRequest.WaitIfOngoing = Option.None
            } : IndicesFlushRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesFlushRequest, value: Indices) =
            { state with IndicesFlushRequest.Index = value } : IndicesFlushRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesFlushRequest, value: bool) =
            { state with IndicesFlushRequest.AllowNoIndices = Option.Some value } : IndicesFlushRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesFlushRequest, value: ExpandWildcards) =
            { state with IndicesFlushRequest.ExpandWildcards = Option.Some value } : IndicesFlushRequest

        [<CustomOperation("force")>]
        member _.Force(state: IndicesFlushRequest, value: bool) =
            { state with IndicesFlushRequest.Force = Option.Some value } : IndicesFlushRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesFlushRequest, value: bool) =
            { state with IndicesFlushRequest.IgnoreUnavailable = Option.Some value } : IndicesFlushRequest

        [<CustomOperation("wait_if_ongoing")>]
        member _.WaitIfOngoing(state: IndicesFlushRequest, value: bool) =
            { state with IndicesFlushRequest.WaitIfOngoing = Option.Some value } : IndicesFlushRequest

    let indicesFlushRequest = IndicesFlushRequestBuilder()

    type IndicesForcemergeRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        Flush: bool option
        IgnoreUnavailable: bool option
        MaxNumSegments: float option
        OnlyExpungeDeletes: bool option
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: IndicesForcemergeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_forcemerge"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.Flush |> Option.map (fun v -> "flush", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MaxNumSegments |> Option.map (fun v -> "max_num_segments", Fes.Http.toQueryValue v)
                        request.OnlyExpungeDeletes |> Option.map (fun v -> "only_expunge_deletes", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    module IndicesForcemergeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesForcemergeRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesForcemergeRequest.ToRequest request

    type IndicesForcemergeRequestBuilder() =
        member _.Yield(_: unit) : IndicesForcemergeRequest =
            {
                IndicesForcemergeRequest.Index = Unchecked.defaultof<Indices>
                IndicesForcemergeRequest.AllowNoIndices = Option.None
                IndicesForcemergeRequest.ExpandWildcards = Option.None
                IndicesForcemergeRequest.Flush = Option.None
                IndicesForcemergeRequest.IgnoreUnavailable = Option.None
                IndicesForcemergeRequest.MaxNumSegments = Option.None
                IndicesForcemergeRequest.OnlyExpungeDeletes = Option.None
                IndicesForcemergeRequest.WaitForCompletion = Option.None
            } : IndicesForcemergeRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesForcemergeRequest, value: Indices) =
            { state with IndicesForcemergeRequest.Index = value } : IndicesForcemergeRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesForcemergeRequest, value: bool) =
            { state with IndicesForcemergeRequest.AllowNoIndices = Option.Some value } : IndicesForcemergeRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesForcemergeRequest, value: ExpandWildcards) =
            { state with IndicesForcemergeRequest.ExpandWildcards = Option.Some value } : IndicesForcemergeRequest

        [<CustomOperation("flush")>]
        member _.Flush(state: IndicesForcemergeRequest, value: bool) =
            { state with IndicesForcemergeRequest.Flush = Option.Some value } : IndicesForcemergeRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesForcemergeRequest, value: bool) =
            { state with IndicesForcemergeRequest.IgnoreUnavailable = Option.Some value } : IndicesForcemergeRequest

        [<CustomOperation("max_num_segments")>]
        member _.MaxNumSegments(state: IndicesForcemergeRequest, value: float) =
            { state with IndicesForcemergeRequest.MaxNumSegments = Option.Some value } : IndicesForcemergeRequest

        [<CustomOperation("only_expunge_deletes")>]
        member _.OnlyExpungeDeletes(state: IndicesForcemergeRequest, value: bool) =
            { state with IndicesForcemergeRequest.OnlyExpungeDeletes = Option.Some value } : IndicesForcemergeRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: IndicesForcemergeRequest, value: bool) =
            { state with IndicesForcemergeRequest.WaitForCompletion = Option.Some value } : IndicesForcemergeRequest

    let indicesForcemergeRequest = IndicesForcemergeRequestBuilder()

    type IndicesGetFieldMappingRequest = {
        Index: Indices
        Fields: Fields
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
    } with
        static member ToRequest(request: IndicesGetFieldMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_mapping/field/{request.Fields}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
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

    module IndicesGetFieldMappingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetFieldMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetFieldMappingRequest.ToRequest request

    type IndicesGetFieldMappingRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetFieldMappingRequest =
            {
                IndicesGetFieldMappingRequest.Index = Unchecked.defaultof<Indices>
                IndicesGetFieldMappingRequest.Fields = Unchecked.defaultof<Fields>
                IndicesGetFieldMappingRequest.AllowNoIndices = Option.None
                IndicesGetFieldMappingRequest.ExpandWildcards = Option.None
                IndicesGetFieldMappingRequest.IgnoreUnavailable = Option.None
                IndicesGetFieldMappingRequest.IncludeDefaults = Option.None
            } : IndicesGetFieldMappingRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetFieldMappingRequest, value: Indices) =
            { state with IndicesGetFieldMappingRequest.Index = value } : IndicesGetFieldMappingRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesGetFieldMappingRequest, value: Fields) =
            { state with IndicesGetFieldMappingRequest.Fields = value } : IndicesGetFieldMappingRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesGetFieldMappingRequest, value: bool) =
            { state with IndicesGetFieldMappingRequest.AllowNoIndices = Option.Some value } : IndicesGetFieldMappingRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetFieldMappingRequest, value: ExpandWildcards) =
            { state with IndicesGetFieldMappingRequest.ExpandWildcards = Option.Some value } : IndicesGetFieldMappingRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetFieldMappingRequest, value: bool) =
            { state with IndicesGetFieldMappingRequest.IgnoreUnavailable = Option.Some value } : IndicesGetFieldMappingRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesGetFieldMappingRequest, value: bool) =
            { state with IndicesGetFieldMappingRequest.IncludeDefaults = Option.Some value } : IndicesGetFieldMappingRequest

    let indicesGetFieldMappingRequest = IndicesGetFieldMappingRequestBuilder()

    type IndicesGetMappingRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_mapping"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module IndicesGetMappingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetMappingRequest.ToRequest request

    type IndicesGetMappingRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetMappingRequest =
            {
                IndicesGetMappingRequest.Index = Unchecked.defaultof<Indices>
                IndicesGetMappingRequest.AllowNoIndices = Option.None
                IndicesGetMappingRequest.ExpandWildcards = Option.None
                IndicesGetMappingRequest.IgnoreUnavailable = Option.None
                IndicesGetMappingRequest.Local = Option.None
                IndicesGetMappingRequest.MasterTimeout = Option.None
            } : IndicesGetMappingRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetMappingRequest, value: Indices) =
            { state with IndicesGetMappingRequest.Index = value } : IndicesGetMappingRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesGetMappingRequest, value: bool) =
            { state with IndicesGetMappingRequest.AllowNoIndices = Option.Some value } : IndicesGetMappingRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetMappingRequest, value: ExpandWildcards) =
            { state with IndicesGetMappingRequest.ExpandWildcards = Option.Some value } : IndicesGetMappingRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetMappingRequest, value: bool) =
            { state with IndicesGetMappingRequest.IgnoreUnavailable = Option.Some value } : IndicesGetMappingRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetMappingRequest, value: bool) =
            { state with IndicesGetMappingRequest.Local = Option.Some value } : IndicesGetMappingRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetMappingRequest, value: Duration) =
            { state with IndicesGetMappingRequest.MasterTimeout = Option.Some value } : IndicesGetMappingRequest

    let indicesGetMappingRequest = IndicesGetMappingRequestBuilder()

    type IndicesPutMappingRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
        WriteIndexOnly: bool option
        [<JsonPropertyName("date_detection")>]
        DateDetection: bool option
        [<JsonPropertyName("dynamic")>]
        Dynamic: MappingDynamicMapping option
        [<JsonPropertyName("dynamic_date_formats")>]
        DynamicDateFormats: string array option
        [<JsonPropertyName("dynamic_templates")>]
        DynamicTemplates: Map<string, MappingDynamicTemplate> array option
        [<JsonPropertyName("_field_names")>]
        FieldNames: MappingFieldNamesField option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("numeric_detection")>]
        NumericDetection: bool option
        [<JsonPropertyName("properties")>]
        Properties: Map<string, MappingProperty> option
        [<JsonPropertyName("_routing")>]
        Routing: MappingRoutingField option
        [<JsonPropertyName("_source")>]
        Source: MappingSourceField option
        [<JsonPropertyName("runtime")>]
        Runtime: MappingRuntimeFields option
    } with
        static member ToRequest(request: IndicesPutMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_mapping"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WriteIndexOnly |> Option.map (fun v -> "write_index_only", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``date_detection`` = request.DateDetection; ``dynamic`` = request.Dynamic; ``dynamic_date_formats`` = request.DynamicDateFormats; ``dynamic_templates`` = request.DynamicTemplates; ``_field_names`` = request.FieldNames; ``_meta`` = request.Meta; ``numeric_detection`` = request.NumericDetection; ``properties`` = request.Properties; ``_routing`` = request.Routing; ``_source`` = request.Source; ``runtime`` = request.Runtime |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutMappingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutMappingRequest.ToRequest request

    type IndicesPutMappingRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutMappingRequest =
            {
                IndicesPutMappingRequest.Index = Unchecked.defaultof<Indices>
                IndicesPutMappingRequest.AllowNoIndices = Option.None
                IndicesPutMappingRequest.ExpandWildcards = Option.None
                IndicesPutMappingRequest.IgnoreUnavailable = Option.None
                IndicesPutMappingRequest.MasterTimeout = Option.None
                IndicesPutMappingRequest.Timeout = Option.None
                IndicesPutMappingRequest.WriteIndexOnly = Option.None
                IndicesPutMappingRequest.DateDetection = Option.None
                IndicesPutMappingRequest.Dynamic = Option.None
                IndicesPutMappingRequest.DynamicDateFormats = Option.None
                IndicesPutMappingRequest.DynamicTemplates = Option.None
                IndicesPutMappingRequest.FieldNames = Option.None
                IndicesPutMappingRequest.Meta = Option.None
                IndicesPutMappingRequest.NumericDetection = Option.None
                IndicesPutMappingRequest.Properties = Option.None
                IndicesPutMappingRequest.Routing = Option.None
                IndicesPutMappingRequest.Source = Option.None
                IndicesPutMappingRequest.Runtime = Option.None
            } : IndicesPutMappingRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesPutMappingRequest, value: Indices) =
            { state with IndicesPutMappingRequest.Index = value } : IndicesPutMappingRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesPutMappingRequest, value: bool) =
            { state with IndicesPutMappingRequest.AllowNoIndices = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesPutMappingRequest, value: ExpandWildcards) =
            { state with IndicesPutMappingRequest.ExpandWildcards = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesPutMappingRequest, value: bool) =
            { state with IndicesPutMappingRequest.IgnoreUnavailable = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutMappingRequest, value: Duration) =
            { state with IndicesPutMappingRequest.MasterTimeout = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutMappingRequest, value: Duration) =
            { state with IndicesPutMappingRequest.Timeout = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("write_index_only")>]
        member _.WriteIndexOnly(state: IndicesPutMappingRequest, value: bool) =
            { state with IndicesPutMappingRequest.WriteIndexOnly = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("date_detection")>]
        member _.DateDetection(state: IndicesPutMappingRequest, value: bool) =
            { state with IndicesPutMappingRequest.DateDetection = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: IndicesPutMappingRequest, value: MappingDynamicMapping) =
            { state with IndicesPutMappingRequest.Dynamic = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("dynamic_date_formats")>]
        member _.DynamicDateFormats(state: IndicesPutMappingRequest, value: string array) =
            { state with IndicesPutMappingRequest.DynamicDateFormats = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("dynamic_templates")>]
        member _.DynamicTemplates(state: IndicesPutMappingRequest, value: Map<string, MappingDynamicTemplate> array) =
            { state with IndicesPutMappingRequest.DynamicTemplates = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("_field_names")>]
        member _.FieldNames(state: IndicesPutMappingRequest, value: MappingFieldNamesField) =
            { state with IndicesPutMappingRequest.FieldNames = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: IndicesPutMappingRequest, value: Metadata) =
            { state with IndicesPutMappingRequest.Meta = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("numeric_detection")>]
        member _.NumericDetection(state: IndicesPutMappingRequest, value: bool) =
            { state with IndicesPutMappingRequest.NumericDetection = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("properties")>]
        member _.Properties(state: IndicesPutMappingRequest, value: Map<string, MappingProperty>) =
            { state with IndicesPutMappingRequest.Properties = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("_routing")>]
        member _.Routing(state: IndicesPutMappingRequest, value: MappingRoutingField) =
            { state with IndicesPutMappingRequest.Routing = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("_source")>]
        member _.Source(state: IndicesPutMappingRequest, value: MappingSourceField) =
            { state with IndicesPutMappingRequest.Source = Option.Some value } : IndicesPutMappingRequest

        [<CustomOperation("runtime")>]
        member _.Runtime(state: IndicesPutMappingRequest, value: MappingRuntimeFields) =
            { state with IndicesPutMappingRequest.Runtime = Option.Some value } : IndicesPutMappingRequest

    let indicesPutMappingRequest = IndicesPutMappingRequestBuilder()

    type IndicesGetSettingsRequest = {
        Index: Indices
        Name: Names
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_settings/{request.Name}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
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

    module IndicesGetSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetSettingsRequest.ToRequest request

    type IndicesGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetSettingsRequest =
            {
                IndicesGetSettingsRequest.Index = Unchecked.defaultof<Indices>
                IndicesGetSettingsRequest.Name = Unchecked.defaultof<Names>
                IndicesGetSettingsRequest.AllowNoIndices = Option.None
                IndicesGetSettingsRequest.ExpandWildcards = Option.None
                IndicesGetSettingsRequest.FlatSettings = Option.None
                IndicesGetSettingsRequest.IgnoreUnavailable = Option.None
                IndicesGetSettingsRequest.IncludeDefaults = Option.None
                IndicesGetSettingsRequest.Local = Option.None
                IndicesGetSettingsRequest.MasterTimeout = Option.None
            } : IndicesGetSettingsRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetSettingsRequest, value: Indices) =
            { state with IndicesGetSettingsRequest.Index = value } : IndicesGetSettingsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetSettingsRequest, value: Names) =
            { state with IndicesGetSettingsRequest.Name = value } : IndicesGetSettingsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesGetSettingsRequest, value: bool) =
            { state with IndicesGetSettingsRequest.AllowNoIndices = Option.Some value } : IndicesGetSettingsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetSettingsRequest, value: ExpandWildcards) =
            { state with IndicesGetSettingsRequest.ExpandWildcards = Option.Some value } : IndicesGetSettingsRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesGetSettingsRequest, value: bool) =
            { state with IndicesGetSettingsRequest.FlatSettings = Option.Some value } : IndicesGetSettingsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetSettingsRequest, value: bool) =
            { state with IndicesGetSettingsRequest.IgnoreUnavailable = Option.Some value } : IndicesGetSettingsRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesGetSettingsRequest, value: bool) =
            { state with IndicesGetSettingsRequest.IncludeDefaults = Option.Some value } : IndicesGetSettingsRequest

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetSettingsRequest, value: bool) =
            { state with IndicesGetSettingsRequest.Local = Option.Some value } : IndicesGetSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetSettingsRequest, value: Duration) =
            { state with IndicesGetSettingsRequest.MasterTimeout = Option.Some value } : IndicesGetSettingsRequest

    let indicesGetSettingsRequest = IndicesGetSettingsRequestBuilder()

    type IndicesOpenRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
    } with
        static member ToRequest(request: IndicesOpenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_open"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module IndicesOpenRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesOpenRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesOpenRequest.ToRequest request

    type IndicesOpenRequestBuilder() =
        member _.Yield(_: unit) : IndicesOpenRequest =
            {
                IndicesOpenRequest.Index = Unchecked.defaultof<Indices>
                IndicesOpenRequest.AllowNoIndices = Option.None
                IndicesOpenRequest.ExpandWildcards = Option.None
                IndicesOpenRequest.IgnoreUnavailable = Option.None
                IndicesOpenRequest.MasterTimeout = Option.None
                IndicesOpenRequest.Timeout = Option.None
                IndicesOpenRequest.WaitForActiveShards = Option.None
            } : IndicesOpenRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesOpenRequest, value: Indices) =
            { state with IndicesOpenRequest.Index = value } : IndicesOpenRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesOpenRequest, value: bool) =
            { state with IndicesOpenRequest.AllowNoIndices = Option.Some value } : IndicesOpenRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesOpenRequest, value: ExpandWildcards) =
            { state with IndicesOpenRequest.ExpandWildcards = Option.Some value } : IndicesOpenRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesOpenRequest, value: bool) =
            { state with IndicesOpenRequest.IgnoreUnavailable = Option.Some value } : IndicesOpenRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesOpenRequest, value: Duration) =
            { state with IndicesOpenRequest.MasterTimeout = Option.Some value } : IndicesOpenRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesOpenRequest, value: Duration) =
            { state with IndicesOpenRequest.Timeout = Option.Some value } : IndicesOpenRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesOpenRequest, value: WaitForActiveShards) =
            { state with IndicesOpenRequest.WaitForActiveShards = Option.Some value } : IndicesOpenRequest

    let indicesOpenRequest = IndicesOpenRequestBuilder()

    type IndicesOpenResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("shards_acknowledged")>]
        ShardsAcknowledged: bool
    }

    type IndicesPutSettingsRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        MasterTimeout: Duration option
        PreserveExisting: bool option
        Reopen: bool option
        Timeout: Duration option
        [<JsonPropertyName("body")>]
        Body: TypesIndexSettings
    } with
        static member ToRequest(request: IndicesPutSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_settings"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.PreserveExisting |> Option.map (fun v -> "preserve_existing", Fes.Http.toQueryValue v)
                        request.Reopen |> Option.map (fun v -> "reopen", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutSettingsRequest.ToRequest request

    type IndicesPutSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutSettingsRequest =
            {
                IndicesPutSettingsRequest.Index = Unchecked.defaultof<Indices>
                IndicesPutSettingsRequest.AllowNoIndices = Option.None
                IndicesPutSettingsRequest.ExpandWildcards = Option.None
                IndicesPutSettingsRequest.FlatSettings = Option.None
                IndicesPutSettingsRequest.IgnoreUnavailable = Option.None
                IndicesPutSettingsRequest.MasterTimeout = Option.None
                IndicesPutSettingsRequest.PreserveExisting = Option.None
                IndicesPutSettingsRequest.Reopen = Option.None
                IndicesPutSettingsRequest.Timeout = Option.None
                IndicesPutSettingsRequest.Body = Unchecked.defaultof<TypesIndexSettings>
            } : IndicesPutSettingsRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesPutSettingsRequest, value: Indices) =
            { state with IndicesPutSettingsRequest.Index = value } : IndicesPutSettingsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesPutSettingsRequest, value: bool) =
            { state with IndicesPutSettingsRequest.AllowNoIndices = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesPutSettingsRequest, value: ExpandWildcards) =
            { state with IndicesPutSettingsRequest.ExpandWildcards = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: IndicesPutSettingsRequest, value: bool) =
            { state with IndicesPutSettingsRequest.FlatSettings = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesPutSettingsRequest, value: bool) =
            { state with IndicesPutSettingsRequest.IgnoreUnavailable = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutSettingsRequest, value: Duration) =
            { state with IndicesPutSettingsRequest.MasterTimeout = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("preserve_existing")>]
        member _.PreserveExisting(state: IndicesPutSettingsRequest, value: bool) =
            { state with IndicesPutSettingsRequest.PreserveExisting = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("reopen")>]
        member _.Reopen(state: IndicesPutSettingsRequest, value: bool) =
            { state with IndicesPutSettingsRequest.Reopen = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutSettingsRequest, value: Duration) =
            { state with IndicesPutSettingsRequest.Timeout = Option.Some value } : IndicesPutSettingsRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesPutSettingsRequest, value: TypesIndexSettings) =
            { state with IndicesPutSettingsRequest.Body = value } : IndicesPutSettingsRequest

    let indicesPutSettingsRequest = IndicesPutSettingsRequestBuilder()

    type IndicesRecoveryRequest = {
        Index: Indices
        ActiveOnly: bool option
        Detailed: bool option
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
    } with
        static member ToRequest(request: IndicesRecoveryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_recovery"
                let queryParams =
                    [
                        request.ActiveOnly |> Option.map (fun v -> "active_only", Fes.Http.toQueryValue v)
                        request.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module IndicesRecoveryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesRecoveryRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesRecoveryRequest.ToRequest request

    type IndicesRecoveryRequestBuilder() =
        member _.Yield(_: unit) : IndicesRecoveryRequest =
            {
                IndicesRecoveryRequest.Index = Unchecked.defaultof<Indices>
                IndicesRecoveryRequest.ActiveOnly = Option.None
                IndicesRecoveryRequest.Detailed = Option.None
                IndicesRecoveryRequest.AllowNoIndices = Option.None
                IndicesRecoveryRequest.ExpandWildcards = Option.None
                IndicesRecoveryRequest.IgnoreUnavailable = Option.None
            } : IndicesRecoveryRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRecoveryRequest, value: Indices) =
            { state with IndicesRecoveryRequest.Index = value } : IndicesRecoveryRequest

        [<CustomOperation("active_only")>]
        member _.ActiveOnly(state: IndicesRecoveryRequest, value: bool) =
            { state with IndicesRecoveryRequest.ActiveOnly = Option.Some value } : IndicesRecoveryRequest

        [<CustomOperation("detailed")>]
        member _.Detailed(state: IndicesRecoveryRequest, value: bool) =
            { state with IndicesRecoveryRequest.Detailed = Option.Some value } : IndicesRecoveryRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesRecoveryRequest, value: bool) =
            { state with IndicesRecoveryRequest.AllowNoIndices = Option.Some value } : IndicesRecoveryRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesRecoveryRequest, value: ExpandWildcards) =
            { state with IndicesRecoveryRequest.ExpandWildcards = Option.Some value } : IndicesRecoveryRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesRecoveryRequest, value: bool) =
            { state with IndicesRecoveryRequest.IgnoreUnavailable = Option.Some value } : IndicesRecoveryRequest

    let indicesRecoveryRequest = IndicesRecoveryRequestBuilder()

    type IndicesRefreshRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
    } with
        static member ToRequest(request: IndicesRefreshRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_refresh"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module IndicesRefreshRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesRefreshRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesRefreshRequest.ToRequest request

    type IndicesRefreshRequestBuilder() =
        member _.Yield(_: unit) : IndicesRefreshRequest =
            {
                IndicesRefreshRequest.Index = Unchecked.defaultof<Indices>
                IndicesRefreshRequest.AllowNoIndices = Option.None
                IndicesRefreshRequest.ExpandWildcards = Option.None
                IndicesRefreshRequest.IgnoreUnavailable = Option.None
            } : IndicesRefreshRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRefreshRequest, value: Indices) =
            { state with IndicesRefreshRequest.Index = value } : IndicesRefreshRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesRefreshRequest, value: bool) =
            { state with IndicesRefreshRequest.AllowNoIndices = Option.Some value } : IndicesRefreshRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesRefreshRequest, value: ExpandWildcards) =
            { state with IndicesRefreshRequest.ExpandWildcards = Option.Some value } : IndicesRefreshRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesRefreshRequest, value: bool) =
            { state with IndicesRefreshRequest.IgnoreUnavailable = Option.Some value } : IndicesRefreshRequest

    let indicesRefreshRequest = IndicesRefreshRequestBuilder()

    type IndicesReloadSearchAnalyzersRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        Resource: string option
    } with
        static member ToRequest(request: IndicesReloadSearchAnalyzersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_reload_search_analyzers"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Resource |> Option.map (fun v -> "resource", Fes.Http.toQueryValue v)
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

    module IndicesReloadSearchAnalyzersRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesReloadSearchAnalyzersRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesReloadSearchAnalyzersRequest.ToRequest request

    type IndicesReloadSearchAnalyzersRequestBuilder() =
        member _.Yield(_: unit) : IndicesReloadSearchAnalyzersRequest =
            {
                IndicesReloadSearchAnalyzersRequest.Index = Unchecked.defaultof<Indices>
                IndicesReloadSearchAnalyzersRequest.AllowNoIndices = Option.None
                IndicesReloadSearchAnalyzersRequest.ExpandWildcards = Option.None
                IndicesReloadSearchAnalyzersRequest.IgnoreUnavailable = Option.None
                IndicesReloadSearchAnalyzersRequest.Resource = Option.None
            } : IndicesReloadSearchAnalyzersRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesReloadSearchAnalyzersRequest, value: Indices) =
            { state with IndicesReloadSearchAnalyzersRequest.Index = value } : IndicesReloadSearchAnalyzersRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesReloadSearchAnalyzersRequest, value: bool) =
            { state with IndicesReloadSearchAnalyzersRequest.AllowNoIndices = Option.Some value } : IndicesReloadSearchAnalyzersRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesReloadSearchAnalyzersRequest, value: ExpandWildcards) =
            { state with IndicesReloadSearchAnalyzersRequest.ExpandWildcards = Option.Some value } : IndicesReloadSearchAnalyzersRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesReloadSearchAnalyzersRequest, value: bool) =
            { state with IndicesReloadSearchAnalyzersRequest.IgnoreUnavailable = Option.Some value } : IndicesReloadSearchAnalyzersRequest

        [<CustomOperation("resource")>]
        member _.Resource(state: IndicesReloadSearchAnalyzersRequest, value: string) =
            { state with IndicesReloadSearchAnalyzersRequest.Resource = Option.Some value } : IndicesReloadSearchAnalyzersRequest

    let indicesReloadSearchAnalyzersRequest = IndicesReloadSearchAnalyzersRequestBuilder()

    type IndicesResolveClusterRequest = {
        Name: Names
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesResolveClusterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_resolve/cluster/{request.Name}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module IndicesResolveClusterRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesResolveClusterRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesResolveClusterRequest.ToRequest request

    type IndicesResolveClusterRequestBuilder() =
        member _.Yield(_: unit) : IndicesResolveClusterRequest =
            {
                IndicesResolveClusterRequest.Name = Unchecked.defaultof<Names>
                IndicesResolveClusterRequest.AllowNoIndices = Option.None
                IndicesResolveClusterRequest.ExpandWildcards = Option.None
                IndicesResolveClusterRequest.IgnoreThrottled = Option.None
                IndicesResolveClusterRequest.IgnoreUnavailable = Option.None
                IndicesResolveClusterRequest.Timeout = Option.None
            } : IndicesResolveClusterRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesResolveClusterRequest, value: Names) =
            { state with IndicesResolveClusterRequest.Name = value } : IndicesResolveClusterRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesResolveClusterRequest, value: bool) =
            { state with IndicesResolveClusterRequest.AllowNoIndices = Option.Some value } : IndicesResolveClusterRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesResolveClusterRequest, value: ExpandWildcards) =
            { state with IndicesResolveClusterRequest.ExpandWildcards = Option.Some value } : IndicesResolveClusterRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: IndicesResolveClusterRequest, value: bool) =
            { state with IndicesResolveClusterRequest.IgnoreThrottled = Option.Some value } : IndicesResolveClusterRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesResolveClusterRequest, value: bool) =
            { state with IndicesResolveClusterRequest.IgnoreUnavailable = Option.Some value } : IndicesResolveClusterRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesResolveClusterRequest, value: Duration) =
            { state with IndicesResolveClusterRequest.Timeout = Option.Some value } : IndicesResolveClusterRequest

    let indicesResolveClusterRequest = IndicesResolveClusterRequestBuilder()

    type IndicesResolveIndexRequest = {
        Name: Names
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        AllowNoIndices: bool option
        Mode: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: IndicesResolveIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_resolve/index/{request.Name}"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.Mode |> Option.map (fun v -> "mode", Fes.Http.toQueryValue v)
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

    module IndicesResolveIndexRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesResolveIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesResolveIndexRequest.ToRequest request

    type IndicesResolveIndexRequestBuilder() =
        member _.Yield(_: unit) : IndicesResolveIndexRequest =
            {
                IndicesResolveIndexRequest.Name = Unchecked.defaultof<Names>
                IndicesResolveIndexRequest.ExpandWildcards = Option.None
                IndicesResolveIndexRequest.IgnoreUnavailable = Option.None
                IndicesResolveIndexRequest.AllowNoIndices = Option.None
                IndicesResolveIndexRequest.Mode = Option.None
            } : IndicesResolveIndexRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesResolveIndexRequest, value: Names) =
            { state with IndicesResolveIndexRequest.Name = value } : IndicesResolveIndexRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesResolveIndexRequest, value: ExpandWildcards) =
            { state with IndicesResolveIndexRequest.ExpandWildcards = Option.Some value } : IndicesResolveIndexRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesResolveIndexRequest, value: bool) =
            { state with IndicesResolveIndexRequest.IgnoreUnavailable = Option.Some value } : IndicesResolveIndexRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesResolveIndexRequest, value: bool) =
            { state with IndicesResolveIndexRequest.AllowNoIndices = Option.Some value } : IndicesResolveIndexRequest

        [<CustomOperation("mode")>]
        member _.Mode(state: IndicesResolveIndexRequest, value: System.Text.Json.JsonElement) =
            { state with IndicesResolveIndexRequest.Mode = Option.Some value } : IndicesResolveIndexRequest

    let indicesResolveIndexRequest = IndicesResolveIndexRequestBuilder()

    type IndicesRolloverRequest = {
        Alias: IndexAlias
        NewIndex: IndexName
        DryRun: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        Lazy: bool option
        [<JsonPropertyName("aliases")>]
        Aliases: Map<string, TypesAlias> option
        [<JsonPropertyName("conditions")>]
        Conditions: RolloverRolloverConditions option
        [<JsonPropertyName("mappings")>]
        Mappings: MappingTypeMapping option
        [<JsonPropertyName("settings")>]
        Settings: Map<string, obj> option
    } with
        static member ToRequest(request: IndicesRolloverRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Alias}/_rollover/{request.NewIndex}"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        request.Lazy |> Option.map (fun v -> "lazy", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aliases`` = request.Aliases; ``conditions`` = request.Conditions; ``mappings`` = request.Mappings; ``settings`` = request.Settings |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesRolloverRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesRolloverRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesRolloverRequest.ToRequest request

    type IndicesRolloverRequestBuilder() =
        member _.Yield(_: unit) : IndicesRolloverRequest =
            {
                IndicesRolloverRequest.Alias = Unchecked.defaultof<IndexAlias>
                IndicesRolloverRequest.NewIndex = Unchecked.defaultof<IndexName>
                IndicesRolloverRequest.DryRun = Option.None
                IndicesRolloverRequest.MasterTimeout = Option.None
                IndicesRolloverRequest.Timeout = Option.None
                IndicesRolloverRequest.WaitForActiveShards = Option.None
                IndicesRolloverRequest.Lazy = Option.None
                IndicesRolloverRequest.Aliases = Option.None
                IndicesRolloverRequest.Conditions = Option.None
                IndicesRolloverRequest.Mappings = Option.None
                IndicesRolloverRequest.Settings = Option.None
            } : IndicesRolloverRequest

        [<CustomOperation("alias")>]
        member _.Alias(state: IndicesRolloverRequest, value: IndexAlias) =
            { state with IndicesRolloverRequest.Alias = value } : IndicesRolloverRequest

        [<CustomOperation("new_index")>]
        member _.NewIndex(state: IndicesRolloverRequest, value: IndexName) =
            { state with IndicesRolloverRequest.NewIndex = value } : IndicesRolloverRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: IndicesRolloverRequest, value: bool) =
            { state with IndicesRolloverRequest.DryRun = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesRolloverRequest, value: Duration) =
            { state with IndicesRolloverRequest.MasterTimeout = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesRolloverRequest, value: Duration) =
            { state with IndicesRolloverRequest.Timeout = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesRolloverRequest, value: WaitForActiveShards) =
            { state with IndicesRolloverRequest.WaitForActiveShards = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("lazy")>]
        member _.Lazy(state: IndicesRolloverRequest, value: bool) =
            { state with IndicesRolloverRequest.Lazy = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesRolloverRequest, value: Map<string, TypesAlias>) =
            { state with IndicesRolloverRequest.Aliases = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("conditions")>]
        member _.Conditions(state: IndicesRolloverRequest, value: RolloverRolloverConditions) =
            { state with IndicesRolloverRequest.Conditions = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndicesRolloverRequest, value: MappingTypeMapping) =
            { state with IndicesRolloverRequest.Mappings = Option.Some value } : IndicesRolloverRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesRolloverRequest, value: Map<string, obj>) =
            { state with IndicesRolloverRequest.Settings = Option.Some value } : IndicesRolloverRequest

    let indicesRolloverRequest = IndicesRolloverRequestBuilder()

    type IndicesSegmentsRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
    } with
        static member ToRequest(request: IndicesSegmentsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_segments"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module IndicesSegmentsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesSegmentsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesSegmentsRequest.ToRequest request

    type IndicesSegmentsRequestBuilder() =
        member _.Yield(_: unit) : IndicesSegmentsRequest =
            {
                IndicesSegmentsRequest.Index = Unchecked.defaultof<Indices>
                IndicesSegmentsRequest.AllowNoIndices = Option.None
                IndicesSegmentsRequest.ExpandWildcards = Option.None
                IndicesSegmentsRequest.IgnoreUnavailable = Option.None
            } : IndicesSegmentsRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesSegmentsRequest, value: Indices) =
            { state with IndicesSegmentsRequest.Index = value } : IndicesSegmentsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesSegmentsRequest, value: bool) =
            { state with IndicesSegmentsRequest.AllowNoIndices = Option.Some value } : IndicesSegmentsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesSegmentsRequest, value: ExpandWildcards) =
            { state with IndicesSegmentsRequest.ExpandWildcards = Option.Some value } : IndicesSegmentsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesSegmentsRequest, value: bool) =
            { state with IndicesSegmentsRequest.IgnoreUnavailable = Option.Some value } : IndicesSegmentsRequest

    let indicesSegmentsRequest = IndicesSegmentsRequestBuilder()

    type IndicesShardStoresRequest = {
        Index: Indices
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreUnavailable: bool option
        Status: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: IndicesShardStoresRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_shard_stores"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Status |> Option.map (fun v -> "status", Fes.Http.toQueryValue v)
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

    module IndicesShardStoresRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesShardStoresRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesShardStoresRequest.ToRequest request

    type IndicesShardStoresRequestBuilder() =
        member _.Yield(_: unit) : IndicesShardStoresRequest =
            {
                IndicesShardStoresRequest.Index = Unchecked.defaultof<Indices>
                IndicesShardStoresRequest.AllowNoIndices = Option.None
                IndicesShardStoresRequest.ExpandWildcards = Option.None
                IndicesShardStoresRequest.IgnoreUnavailable = Option.None
                IndicesShardStoresRequest.Status = Option.None
            } : IndicesShardStoresRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesShardStoresRequest, value: Indices) =
            { state with IndicesShardStoresRequest.Index = value } : IndicesShardStoresRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesShardStoresRequest, value: bool) =
            { state with IndicesShardStoresRequest.AllowNoIndices = Option.Some value } : IndicesShardStoresRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesShardStoresRequest, value: ExpandWildcards) =
            { state with IndicesShardStoresRequest.ExpandWildcards = Option.Some value } : IndicesShardStoresRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesShardStoresRequest, value: bool) =
            { state with IndicesShardStoresRequest.IgnoreUnavailable = Option.Some value } : IndicesShardStoresRequest

        [<CustomOperation("status")>]
        member _.Status(state: IndicesShardStoresRequest, value: System.Text.Json.JsonElement) =
            { state with IndicesShardStoresRequest.Status = Option.Some value } : IndicesShardStoresRequest

    let indicesShardStoresRequest = IndicesShardStoresRequestBuilder()

    type IndicesShrinkRequest = {
        Index: IndexName
        Target: IndexName
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        [<JsonPropertyName("aliases")>]
        Aliases: Map<string, TypesAlias> option
        [<JsonPropertyName("settings")>]
        Settings: Map<string, obj> option
    } with
        static member ToRequest(request: IndicesShrinkRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_shrink/{request.Target}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aliases`` = request.Aliases; ``settings`` = request.Settings |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesShrinkRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesShrinkRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesShrinkRequest.ToRequest request

    type IndicesShrinkRequestBuilder() =
        member _.Yield(_: unit) : IndicesShrinkRequest =
            {
                IndicesShrinkRequest.Index = Unchecked.defaultof<IndexName>
                IndicesShrinkRequest.Target = Unchecked.defaultof<IndexName>
                IndicesShrinkRequest.MasterTimeout = Option.None
                IndicesShrinkRequest.Timeout = Option.None
                IndicesShrinkRequest.WaitForActiveShards = Option.None
                IndicesShrinkRequest.Aliases = Option.None
                IndicesShrinkRequest.Settings = Option.None
            } : IndicesShrinkRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesShrinkRequest, value: IndexName) =
            { state with IndicesShrinkRequest.Index = value } : IndicesShrinkRequest

        [<CustomOperation("target")>]
        member _.Target(state: IndicesShrinkRequest, value: IndexName) =
            { state with IndicesShrinkRequest.Target = value } : IndicesShrinkRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesShrinkRequest, value: Duration) =
            { state with IndicesShrinkRequest.MasterTimeout = Option.Some value } : IndicesShrinkRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesShrinkRequest, value: Duration) =
            { state with IndicesShrinkRequest.Timeout = Option.Some value } : IndicesShrinkRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesShrinkRequest, value: WaitForActiveShards) =
            { state with IndicesShrinkRequest.WaitForActiveShards = Option.Some value } : IndicesShrinkRequest

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesShrinkRequest, value: Map<string, TypesAlias>) =
            { state with IndicesShrinkRequest.Aliases = Option.Some value } : IndicesShrinkRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesShrinkRequest, value: Map<string, obj>) =
            { state with IndicesShrinkRequest.Settings = Option.Some value } : IndicesShrinkRequest

    let indicesShrinkRequest = IndicesShrinkRequestBuilder()

    type IndicesSimulateIndexTemplateRequest = {
        Name: Name
        Create: bool option
        Cause: string option
        MasterTimeout: Duration option
        IncludeDefaults: bool option
        [<JsonPropertyName("body")>]
        Body: TypesIndexTemplate
    } with
        static member ToRequest(request: IndicesSimulateIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/_simulate_index/{request.Name}"
                let queryParams =
                    [
                        request.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        request.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
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

    module IndicesSimulateIndexTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesSimulateIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesSimulateIndexTemplateRequest.ToRequest request

    type IndicesSimulateIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesSimulateIndexTemplateRequest =
            {
                IndicesSimulateIndexTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesSimulateIndexTemplateRequest.Create = Option.None
                IndicesSimulateIndexTemplateRequest.Cause = Option.None
                IndicesSimulateIndexTemplateRequest.MasterTimeout = Option.None
                IndicesSimulateIndexTemplateRequest.IncludeDefaults = Option.None
                IndicesSimulateIndexTemplateRequest.Body = Unchecked.defaultof<TypesIndexTemplate>
            } : IndicesSimulateIndexTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesSimulateIndexTemplateRequest, value: Name) =
            { state with IndicesSimulateIndexTemplateRequest.Name = value } : IndicesSimulateIndexTemplateRequest

        [<CustomOperation("create")>]
        member _.Create(state: IndicesSimulateIndexTemplateRequest, value: bool) =
            { state with IndicesSimulateIndexTemplateRequest.Create = Option.Some value } : IndicesSimulateIndexTemplateRequest

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesSimulateIndexTemplateRequest, value: string) =
            { state with IndicesSimulateIndexTemplateRequest.Cause = Option.Some value } : IndicesSimulateIndexTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesSimulateIndexTemplateRequest, value: Duration) =
            { state with IndicesSimulateIndexTemplateRequest.MasterTimeout = Option.Some value } : IndicesSimulateIndexTemplateRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesSimulateIndexTemplateRequest, value: bool) =
            { state with IndicesSimulateIndexTemplateRequest.IncludeDefaults = Option.Some value } : IndicesSimulateIndexTemplateRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesSimulateIndexTemplateRequest, value: TypesIndexTemplate) =
            { state with IndicesSimulateIndexTemplateRequest.Body = value } : IndicesSimulateIndexTemplateRequest

    let indicesSimulateIndexTemplateRequest = IndicesSimulateIndexTemplateRequestBuilder()

    type IndicesSimulateIndexTemplateResponse = {
        [<JsonPropertyName("overlapping")>]
        Overlapping: SimulateTemplateOverlapping array option
        [<JsonPropertyName("template")>]
        Template: SimulateTemplateTemplate
    }

    type IndicesSimulateTemplateRequest = {
        Name: Name
        Create: bool option
        Cause: string option
        MasterTimeout: Duration option
        IncludeDefaults: bool option
        [<JsonPropertyName("allow_auto_create")>]
        AllowAutoCreate: bool option
        [<JsonPropertyName("index_patterns")>]
        IndexPatterns: Indices option
        [<JsonPropertyName("composed_of")>]
        ComposedOf: Name array option
        [<JsonPropertyName("template")>]
        Template: PutIndexTemplateIndexTemplateMapping option
        [<JsonPropertyName("data_stream")>]
        DataStream: TypesDataStreamVisibility option
        [<JsonPropertyName("priority")>]
        Priority: float option
        [<JsonPropertyName("version")>]
        Version: VersionNumber option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("ignore_missing_component_templates")>]
        IgnoreMissingComponentTemplates: string array option
        [<JsonPropertyName("deprecated")>]
        Deprecated: bool option
    } with
        static member ToRequest(request: IndicesSimulateTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/_simulate/{request.Name}"
                let queryParams =
                    [
                        request.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        request.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``allow_auto_create`` = request.AllowAutoCreate; ``index_patterns`` = request.IndexPatterns; ``composed_of`` = request.ComposedOf; ``template`` = request.Template; ``data_stream`` = request.DataStream; ``priority`` = request.Priority; ``version`` = request.Version; ``_meta`` = request.Meta; ``ignore_missing_component_templates`` = request.IgnoreMissingComponentTemplates; ``deprecated`` = request.Deprecated |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesSimulateTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesSimulateTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesSimulateTemplateRequest.ToRequest request

    type IndicesSimulateTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesSimulateTemplateRequest =
            {
                IndicesSimulateTemplateRequest.Name = Unchecked.defaultof<Name>
                IndicesSimulateTemplateRequest.Create = Option.None
                IndicesSimulateTemplateRequest.Cause = Option.None
                IndicesSimulateTemplateRequest.MasterTimeout = Option.None
                IndicesSimulateTemplateRequest.IncludeDefaults = Option.None
                IndicesSimulateTemplateRequest.AllowAutoCreate = Option.None
                IndicesSimulateTemplateRequest.IndexPatterns = Option.None
                IndicesSimulateTemplateRequest.ComposedOf = Option.None
                IndicesSimulateTemplateRequest.Template = Option.None
                IndicesSimulateTemplateRequest.DataStream = Option.None
                IndicesSimulateTemplateRequest.Priority = Option.None
                IndicesSimulateTemplateRequest.Version = Option.None
                IndicesSimulateTemplateRequest.Meta = Option.None
                IndicesSimulateTemplateRequest.IgnoreMissingComponentTemplates = Option.None
                IndicesSimulateTemplateRequest.Deprecated = Option.None
            } : IndicesSimulateTemplateRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesSimulateTemplateRequest, value: Name) =
            { state with IndicesSimulateTemplateRequest.Name = value } : IndicesSimulateTemplateRequest

        [<CustomOperation("create")>]
        member _.Create(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with IndicesSimulateTemplateRequest.Create = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesSimulateTemplateRequest, value: string) =
            { state with IndicesSimulateTemplateRequest.Cause = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesSimulateTemplateRequest, value: Duration) =
            { state with IndicesSimulateTemplateRequest.MasterTimeout = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with IndicesSimulateTemplateRequest.IncludeDefaults = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("allow_auto_create")>]
        member _.AllowAutoCreate(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with IndicesSimulateTemplateRequest.AllowAutoCreate = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("index_patterns")>]
        member _.IndexPatterns(state: IndicesSimulateTemplateRequest, value: Indices) =
            { state with IndicesSimulateTemplateRequest.IndexPatterns = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("composed_of")>]
        member _.ComposedOf(state: IndicesSimulateTemplateRequest, value: Name array) =
            { state with IndicesSimulateTemplateRequest.ComposedOf = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("template")>]
        member _.Template(state: IndicesSimulateTemplateRequest, value: PutIndexTemplateIndexTemplateMapping) =
            { state with IndicesSimulateTemplateRequest.Template = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("data_stream")>]
        member _.DataStream(state: IndicesSimulateTemplateRequest, value: TypesDataStreamVisibility) =
            { state with IndicesSimulateTemplateRequest.DataStream = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("priority")>]
        member _.Priority(state: IndicesSimulateTemplateRequest, value: float) =
            { state with IndicesSimulateTemplateRequest.Priority = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("version")>]
        member _.Version(state: IndicesSimulateTemplateRequest, value: VersionNumber) =
            { state with IndicesSimulateTemplateRequest.Version = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: IndicesSimulateTemplateRequest, value: Metadata) =
            { state with IndicesSimulateTemplateRequest.Meta = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("ignore_missing_component_templates")>]
        member _.IgnoreMissingComponentTemplates(state: IndicesSimulateTemplateRequest, value: string array) =
            { state with IndicesSimulateTemplateRequest.IgnoreMissingComponentTemplates = Option.Some value } : IndicesSimulateTemplateRequest

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with IndicesSimulateTemplateRequest.Deprecated = Option.Some value } : IndicesSimulateTemplateRequest

    let indicesSimulateTemplateRequest = IndicesSimulateTemplateRequestBuilder()

    type IndicesSplitRequest = {
        Index: IndexName
        Target: IndexName
        MasterTimeout: Duration option
        Timeout: Duration option
        WaitForActiveShards: WaitForActiveShards option
        [<JsonPropertyName("aliases")>]
        Aliases: Map<string, TypesAlias> option
        [<JsonPropertyName("settings")>]
        Settings: Map<string, obj> option
    } with
        static member ToRequest(request: IndicesSplitRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_split/{request.Target}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aliases`` = request.Aliases; ``settings`` = request.Settings |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesSplitRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesSplitRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesSplitRequest.ToRequest request

    type IndicesSplitRequestBuilder() =
        member _.Yield(_: unit) : IndicesSplitRequest =
            {
                IndicesSplitRequest.Index = Unchecked.defaultof<IndexName>
                IndicesSplitRequest.Target = Unchecked.defaultof<IndexName>
                IndicesSplitRequest.MasterTimeout = Option.None
                IndicesSplitRequest.Timeout = Option.None
                IndicesSplitRequest.WaitForActiveShards = Option.None
                IndicesSplitRequest.Aliases = Option.None
                IndicesSplitRequest.Settings = Option.None
            } : IndicesSplitRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesSplitRequest, value: IndexName) =
            { state with IndicesSplitRequest.Index = value } : IndicesSplitRequest

        [<CustomOperation("target")>]
        member _.Target(state: IndicesSplitRequest, value: IndexName) =
            { state with IndicesSplitRequest.Target = value } : IndicesSplitRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesSplitRequest, value: Duration) =
            { state with IndicesSplitRequest.MasterTimeout = Option.Some value } : IndicesSplitRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesSplitRequest, value: Duration) =
            { state with IndicesSplitRequest.Timeout = Option.Some value } : IndicesSplitRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: IndicesSplitRequest, value: WaitForActiveShards) =
            { state with IndicesSplitRequest.WaitForActiveShards = Option.Some value } : IndicesSplitRequest

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesSplitRequest, value: Map<string, TypesAlias>) =
            { state with IndicesSplitRequest.Aliases = Option.Some value } : IndicesSplitRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesSplitRequest, value: Map<string, obj>) =
            { state with IndicesSplitRequest.Settings = Option.Some value } : IndicesSplitRequest

    let indicesSplitRequest = IndicesSplitRequestBuilder()

    type IndicesStatsRequest = {
        Index: Indices
        Metric: CommonStatsFlags
        CompletionFields: Fields option
        ExpandWildcards: ExpandWildcards option
        FielddataFields: Fields option
        Fields: Fields option
        ForbidClosedIndices: bool option
        Groups: System.Text.Json.JsonElement option
        IncludeSegmentFileSizes: bool option
        IncludeUnloadedSegments: bool option
        Level: Level option
    } with
        static member ToRequest(request: IndicesStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_stats/{request.Metric}"
                let queryParams =
                    [
                        request.CompletionFields |> Option.map (fun v -> "completion_fields", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.FielddataFields |> Option.map (fun v -> "fielddata_fields", Fes.Http.toQueryValue v)
                        request.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        request.ForbidClosedIndices |> Option.map (fun v -> "forbid_closed_indices", Fes.Http.toQueryValue v)
                        request.Groups |> Option.map (fun v -> "groups", Fes.Http.toQueryValue v)
                        request.IncludeSegmentFileSizes |> Option.map (fun v -> "include_segment_file_sizes", Fes.Http.toQueryValue v)
                        request.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", Fes.Http.toQueryValue v)
                        request.Level |> Option.map (fun v -> "level", Fes.Http.toQueryValue v)
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

    module IndicesStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesStatsRequest.ToRequest request

    type IndicesStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesStatsRequest =
            {
                IndicesStatsRequest.Index = Unchecked.defaultof<Indices>
                IndicesStatsRequest.Metric = Unchecked.defaultof<CommonStatsFlags>
                IndicesStatsRequest.CompletionFields = Option.None
                IndicesStatsRequest.ExpandWildcards = Option.None
                IndicesStatsRequest.FielddataFields = Option.None
                IndicesStatsRequest.Fields = Option.None
                IndicesStatsRequest.ForbidClosedIndices = Option.None
                IndicesStatsRequest.Groups = Option.None
                IndicesStatsRequest.IncludeSegmentFileSizes = Option.None
                IndicesStatsRequest.IncludeUnloadedSegments = Option.None
                IndicesStatsRequest.Level = Option.None
            } : IndicesStatsRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesStatsRequest, value: Indices) =
            { state with IndicesStatsRequest.Index = value } : IndicesStatsRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: IndicesStatsRequest, value: CommonStatsFlags) =
            { state with IndicesStatsRequest.Metric = value } : IndicesStatsRequest

        [<CustomOperation("completion_fields")>]
        member _.CompletionFields(state: IndicesStatsRequest, value: Fields) =
            { state with IndicesStatsRequest.CompletionFields = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesStatsRequest, value: ExpandWildcards) =
            { state with IndicesStatsRequest.ExpandWildcards = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("fielddata_fields")>]
        member _.FielddataFields(state: IndicesStatsRequest, value: Fields) =
            { state with IndicesStatsRequest.FielddataFields = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesStatsRequest, value: Fields) =
            { state with IndicesStatsRequest.Fields = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("forbid_closed_indices")>]
        member _.ForbidClosedIndices(state: IndicesStatsRequest, value: bool) =
            { state with IndicesStatsRequest.ForbidClosedIndices = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("groups")>]
        member _.Groups(state: IndicesStatsRequest, value: System.Text.Json.JsonElement) =
            { state with IndicesStatsRequest.Groups = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("include_segment_file_sizes")>]
        member _.IncludeSegmentFileSizes(state: IndicesStatsRequest, value: bool) =
            { state with IndicesStatsRequest.IncludeSegmentFileSizes = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("include_unloaded_segments")>]
        member _.IncludeUnloadedSegments(state: IndicesStatsRequest, value: bool) =
            { state with IndicesStatsRequest.IncludeUnloadedSegments = Option.Some value } : IndicesStatsRequest

        [<CustomOperation("level")>]
        member _.Level(state: IndicesStatsRequest, value: Level) =
            { state with IndicesStatsRequest.Level = Option.Some value } : IndicesStatsRequest

    let indicesStatsRequest = IndicesStatsRequestBuilder()

    type IndicesUpdateAliasesRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("actions")>]
        Actions: UpdateAliasesAction array option
    } with
        static member ToRequest(request: IndicesUpdateAliasesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_aliases"
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
                |> Fes.Http.Request.withJsonBody {| ``actions`` = request.Actions |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesUpdateAliasesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesUpdateAliasesRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesUpdateAliasesRequest.ToRequest request

    type IndicesUpdateAliasesRequestBuilder() =
        member _.Yield(_: unit) : IndicesUpdateAliasesRequest =
            {
                IndicesUpdateAliasesRequest.MasterTimeout = Option.None
                IndicesUpdateAliasesRequest.Timeout = Option.None
                IndicesUpdateAliasesRequest.Actions = Option.None
            } : IndicesUpdateAliasesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesUpdateAliasesRequest, value: Duration) =
            { state with IndicesUpdateAliasesRequest.MasterTimeout = Option.Some value } : IndicesUpdateAliasesRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesUpdateAliasesRequest, value: Duration) =
            { state with IndicesUpdateAliasesRequest.Timeout = Option.Some value } : IndicesUpdateAliasesRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: IndicesUpdateAliasesRequest, value: UpdateAliasesAction array) =
            { state with IndicesUpdateAliasesRequest.Actions = Option.Some value } : IndicesUpdateAliasesRequest

    let indicesUpdateAliasesRequest = IndicesUpdateAliasesRequestBuilder()

    type IndicesUpdateAliasesResponse = AcknowledgedResponseBase

    type IndicesValidateQueryRequest = {
        Index: Indices
        AllowNoIndices: bool option
        AllShards: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        DefaultOperator: QueryDslOperator option
        Df: string option
        ExpandWildcards: ExpandWildcards option
        Explain: bool option
        IgnoreUnavailable: bool option
        Lenient: bool option
        Rewrite: bool option
        Q: string option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
    } with
        static member ToRequest(request: IndicesValidateQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_validate/query"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.AllShards |> Option.map (fun v -> "all_shards", Fes.Http.toQueryValue v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                        request.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                        request.Rewrite |> Option.map (fun v -> "rewrite", Fes.Http.toQueryValue v)
                        request.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``query`` = request.Query |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesValidateQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesValidateQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesValidateQueryRequest.ToRequest request

    type IndicesValidateQueryRequestBuilder() =
        member _.Yield(_: unit) : IndicesValidateQueryRequest =
            {
                IndicesValidateQueryRequest.Index = Unchecked.defaultof<Indices>
                IndicesValidateQueryRequest.AllowNoIndices = Option.None
                IndicesValidateQueryRequest.AllShards = Option.None
                IndicesValidateQueryRequest.Analyzer = Option.None
                IndicesValidateQueryRequest.AnalyzeWildcard = Option.None
                IndicesValidateQueryRequest.DefaultOperator = Option.None
                IndicesValidateQueryRequest.Df = Option.None
                IndicesValidateQueryRequest.ExpandWildcards = Option.None
                IndicesValidateQueryRequest.Explain = Option.None
                IndicesValidateQueryRequest.IgnoreUnavailable = Option.None
                IndicesValidateQueryRequest.Lenient = Option.None
                IndicesValidateQueryRequest.Rewrite = Option.None
                IndicesValidateQueryRequest.Q = Option.None
                IndicesValidateQueryRequest.Query = Option.None
            } : IndicesValidateQueryRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesValidateQueryRequest, value: Indices) =
            { state with IndicesValidateQueryRequest.Index = value } : IndicesValidateQueryRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.AllowNoIndices = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("all_shards")>]
        member _.AllShards(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.AllShards = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IndicesValidateQueryRequest, value: string) =
            { state with IndicesValidateQueryRequest.Analyzer = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.AnalyzeWildcard = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: IndicesValidateQueryRequest, value: QueryDslOperator) =
            { state with IndicesValidateQueryRequest.DefaultOperator = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("df")>]
        member _.Df(state: IndicesValidateQueryRequest, value: string) =
            { state with IndicesValidateQueryRequest.Df = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesValidateQueryRequest, value: ExpandWildcards) =
            { state with IndicesValidateQueryRequest.ExpandWildcards = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.Explain = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.IgnoreUnavailable = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.Lenient = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: IndicesValidateQueryRequest, value: bool) =
            { state with IndicesValidateQueryRequest.Rewrite = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("q")>]
        member _.Q(state: IndicesValidateQueryRequest, value: string) =
            { state with IndicesValidateQueryRequest.Q = Option.Some value } : IndicesValidateQueryRequest

        [<CustomOperation("query")>]
        member _.Query(state: IndicesValidateQueryRequest, value: QueryDslQueryContainer) =
            { state with IndicesValidateQueryRequest.Query = Option.Some value } : IndicesValidateQueryRequest

    let indicesValidateQueryRequest = IndicesValidateQueryRequestBuilder()

