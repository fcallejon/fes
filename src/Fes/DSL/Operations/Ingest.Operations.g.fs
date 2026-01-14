// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module IngestOperations =

    type IngestGetGeoipDatabaseRequest = {
        Id: Ids
    } with
        static member ToRequest(request: IngestGetGeoipDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/geoip/database/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module IngestGetGeoipDatabaseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestGetGeoipDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestGetGeoipDatabaseRequest.ToRequest request

    type IngestGetGeoipDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestGetGeoipDatabaseRequest =
            {
                IngestGetGeoipDatabaseRequest.Id = Unchecked.defaultof<Ids>
            } : IngestGetGeoipDatabaseRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestGetGeoipDatabaseRequest, value: Ids) =
            { state with IngestGetGeoipDatabaseRequest.Id = value } : IngestGetGeoipDatabaseRequest

    let ingestGetGeoipDatabaseRequest = IngestGetGeoipDatabaseRequestBuilder()

    type IngestPutGeoipDatabaseRequest = {
        Id: Id
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("maxmind")>]
        Maxmind: TypesMaxmind
    } with
        static member ToRequest(request: IngestPutGeoipDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/geoip/database/{request.Id}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``name`` = request.Name; ``maxmind`` = request.Maxmind |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IngestPutGeoipDatabaseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestPutGeoipDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestPutGeoipDatabaseRequest.ToRequest request

    type IngestPutGeoipDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestPutGeoipDatabaseRequest =
            {
                IngestPutGeoipDatabaseRequest.Id = Unchecked.defaultof<Id>
                IngestPutGeoipDatabaseRequest.MasterTimeout = Option.None
                IngestPutGeoipDatabaseRequest.Timeout = Option.None
                IngestPutGeoipDatabaseRequest.Name = Unchecked.defaultof<Name>
                IngestPutGeoipDatabaseRequest.Maxmind = Unchecked.defaultof<TypesMaxmind>
            } : IngestPutGeoipDatabaseRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestPutGeoipDatabaseRequest, value: Id) =
            { state with IngestPutGeoipDatabaseRequest.Id = value } : IngestPutGeoipDatabaseRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestPutGeoipDatabaseRequest, value: Duration) =
            { state with IngestPutGeoipDatabaseRequest.MasterTimeout = Option.Some value } : IngestPutGeoipDatabaseRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestPutGeoipDatabaseRequest, value: Duration) =
            { state with IngestPutGeoipDatabaseRequest.Timeout = Option.Some value } : IngestPutGeoipDatabaseRequest

        [<CustomOperation("name")>]
        member _.Name(state: IngestPutGeoipDatabaseRequest, value: Name) =
            { state with IngestPutGeoipDatabaseRequest.Name = value } : IngestPutGeoipDatabaseRequest

        [<CustomOperation("maxmind")>]
        member _.Maxmind(state: IngestPutGeoipDatabaseRequest, value: TypesMaxmind) =
            { state with IngestPutGeoipDatabaseRequest.Maxmind = value } : IngestPutGeoipDatabaseRequest

    let ingestPutGeoipDatabaseRequest = IngestPutGeoipDatabaseRequestBuilder()

    type IngestPutGeoipDatabaseResponse = AcknowledgedResponseBase

    type IngestDeleteGeoipDatabaseRequest = {
        Id: Ids
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IngestDeleteGeoipDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/geoip/database/{request.Id}"
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

    module IngestDeleteGeoipDatabaseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestDeleteGeoipDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestDeleteGeoipDatabaseRequest.ToRequest request

    type IngestDeleteGeoipDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestDeleteGeoipDatabaseRequest =
            {
                IngestDeleteGeoipDatabaseRequest.Id = Unchecked.defaultof<Ids>
                IngestDeleteGeoipDatabaseRequest.MasterTimeout = Option.None
                IngestDeleteGeoipDatabaseRequest.Timeout = Option.None
            } : IngestDeleteGeoipDatabaseRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestDeleteGeoipDatabaseRequest, value: Ids) =
            { state with IngestDeleteGeoipDatabaseRequest.Id = value } : IngestDeleteGeoipDatabaseRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestDeleteGeoipDatabaseRequest, value: Duration) =
            { state with IngestDeleteGeoipDatabaseRequest.MasterTimeout = Option.Some value } : IngestDeleteGeoipDatabaseRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestDeleteGeoipDatabaseRequest, value: Duration) =
            { state with IngestDeleteGeoipDatabaseRequest.Timeout = Option.Some value } : IngestDeleteGeoipDatabaseRequest

    let ingestDeleteGeoipDatabaseRequest = IngestDeleteGeoipDatabaseRequestBuilder()

    type IngestDeleteGeoipDatabaseResponse = AcknowledgedResponseBase

    type IngestGetIpLocationDatabaseRequest = {
        Id: Ids
    } with
        static member ToRequest(request: IngestGetIpLocationDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/ip_location/database/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module IngestGetIpLocationDatabaseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestGetIpLocationDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestGetIpLocationDatabaseRequest.ToRequest request

    type IngestGetIpLocationDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestGetIpLocationDatabaseRequest =
            {
                IngestGetIpLocationDatabaseRequest.Id = Unchecked.defaultof<Ids>
            } : IngestGetIpLocationDatabaseRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestGetIpLocationDatabaseRequest, value: Ids) =
            { state with IngestGetIpLocationDatabaseRequest.Id = value } : IngestGetIpLocationDatabaseRequest

    let ingestGetIpLocationDatabaseRequest = IngestGetIpLocationDatabaseRequestBuilder()

    type IngestPutIpLocationDatabaseRequest = {
        Id: Id
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("body")>]
        Body: TypesDatabaseConfiguration
    } with
        static member ToRequest(request: IngestPutIpLocationDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/ip_location/database/{request.Id}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module IngestPutIpLocationDatabaseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestPutIpLocationDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestPutIpLocationDatabaseRequest.ToRequest request

    type IngestPutIpLocationDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestPutIpLocationDatabaseRequest =
            {
                IngestPutIpLocationDatabaseRequest.Id = Unchecked.defaultof<Id>
                IngestPutIpLocationDatabaseRequest.MasterTimeout = Option.None
                IngestPutIpLocationDatabaseRequest.Timeout = Option.None
                IngestPutIpLocationDatabaseRequest.Body = Unchecked.defaultof<TypesDatabaseConfiguration>
            } : IngestPutIpLocationDatabaseRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestPutIpLocationDatabaseRequest, value: Id) =
            { state with IngestPutIpLocationDatabaseRequest.Id = value } : IngestPutIpLocationDatabaseRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestPutIpLocationDatabaseRequest, value: Duration) =
            { state with IngestPutIpLocationDatabaseRequest.MasterTimeout = Option.Some value } : IngestPutIpLocationDatabaseRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestPutIpLocationDatabaseRequest, value: Duration) =
            { state with IngestPutIpLocationDatabaseRequest.Timeout = Option.Some value } : IngestPutIpLocationDatabaseRequest

        [<CustomOperation("body")>]
        member _.Body(state: IngestPutIpLocationDatabaseRequest, value: TypesDatabaseConfiguration) =
            { state with IngestPutIpLocationDatabaseRequest.Body = value } : IngestPutIpLocationDatabaseRequest

    let ingestPutIpLocationDatabaseRequest = IngestPutIpLocationDatabaseRequestBuilder()

    type IngestPutIpLocationDatabaseResponse = AcknowledgedResponseBase

    type IngestDeleteIpLocationDatabaseRequest = {
        Id: Ids
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IngestDeleteIpLocationDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/ip_location/database/{request.Id}"
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

    module IngestDeleteIpLocationDatabaseRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestDeleteIpLocationDatabaseRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestDeleteIpLocationDatabaseRequest.ToRequest request

    type IngestDeleteIpLocationDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestDeleteIpLocationDatabaseRequest =
            {
                IngestDeleteIpLocationDatabaseRequest.Id = Unchecked.defaultof<Ids>
                IngestDeleteIpLocationDatabaseRequest.MasterTimeout = Option.None
                IngestDeleteIpLocationDatabaseRequest.Timeout = Option.None
            } : IngestDeleteIpLocationDatabaseRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestDeleteIpLocationDatabaseRequest, value: Ids) =
            { state with IngestDeleteIpLocationDatabaseRequest.Id = value } : IngestDeleteIpLocationDatabaseRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestDeleteIpLocationDatabaseRequest, value: Duration) =
            { state with IngestDeleteIpLocationDatabaseRequest.MasterTimeout = Option.Some value } : IngestDeleteIpLocationDatabaseRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestDeleteIpLocationDatabaseRequest, value: Duration) =
            { state with IngestDeleteIpLocationDatabaseRequest.Timeout = Option.Some value } : IngestDeleteIpLocationDatabaseRequest

    let ingestDeleteIpLocationDatabaseRequest = IngestDeleteIpLocationDatabaseRequestBuilder()

    type IngestDeleteIpLocationDatabaseResponse = AcknowledgedResponseBase

    type IngestGetPipelineRequest = {
        Id: Id
        MasterTimeout: Duration option
        Summary: bool option
    } with
        static member ToRequest(request: IngestGetPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/pipeline/{request.Id}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Summary |> Option.map (fun v -> "summary", Fes.Http.toQueryValue v)
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

    module IngestGetPipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestGetPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestGetPipelineRequest.ToRequest request

    type IngestGetPipelineRequestBuilder() =
        member _.Yield(_: unit) : IngestGetPipelineRequest =
            {
                IngestGetPipelineRequest.Id = Unchecked.defaultof<Id>
                IngestGetPipelineRequest.MasterTimeout = Option.None
                IngestGetPipelineRequest.Summary = Option.None
            } : IngestGetPipelineRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestGetPipelineRequest, value: Id) =
            { state with IngestGetPipelineRequest.Id = value } : IngestGetPipelineRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestGetPipelineRequest, value: Duration) =
            { state with IngestGetPipelineRequest.MasterTimeout = Option.Some value } : IngestGetPipelineRequest

        [<CustomOperation("summary")>]
        member _.Summary(state: IngestGetPipelineRequest, value: bool) =
            { state with IngestGetPipelineRequest.Summary = Option.Some value } : IngestGetPipelineRequest

    let ingestGetPipelineRequest = IngestGetPipelineRequestBuilder()

    type IngestPutPipelineRequest = {
        Id: Id
        MasterTimeout: Duration option
        Timeout: Duration option
        IfVersion: float option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("on_failure")>]
        OnFailure: TypesProcessorContainer array option
        [<JsonPropertyName("processors")>]
        Processors: TypesProcessorContainer array option
        [<JsonPropertyName("version")>]
        Version: VersionNumber option
        [<JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<JsonPropertyName("field_access_pattern")>]
        FieldAccessPattern: TypesFieldAccessPattern option
    } with
        static member ToRequest(request: IngestPutPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/pipeline/{request.Id}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.IfVersion |> Option.map (fun v -> "if_version", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``_meta`` = request.Meta; ``description`` = request.Description; ``on_failure`` = request.OnFailure; ``processors`` = request.Processors; ``version`` = request.Version; ``deprecated`` = request.Deprecated; ``field_access_pattern`` = request.FieldAccessPattern |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IngestPutPipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestPutPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestPutPipelineRequest.ToRequest request

    type IngestPutPipelineRequestBuilder() =
        member _.Yield(_: unit) : IngestPutPipelineRequest =
            {
                IngestPutPipelineRequest.Id = Unchecked.defaultof<Id>
                IngestPutPipelineRequest.MasterTimeout = Option.None
                IngestPutPipelineRequest.Timeout = Option.None
                IngestPutPipelineRequest.IfVersion = Option.None
                IngestPutPipelineRequest.Meta = Option.None
                IngestPutPipelineRequest.Description = Option.None
                IngestPutPipelineRequest.OnFailure = Option.None
                IngestPutPipelineRequest.Processors = Option.None
                IngestPutPipelineRequest.Version = Option.None
                IngestPutPipelineRequest.Deprecated = Option.None
                IngestPutPipelineRequest.FieldAccessPattern = Option.None
            } : IngestPutPipelineRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestPutPipelineRequest, value: Id) =
            { state with IngestPutPipelineRequest.Id = value } : IngestPutPipelineRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestPutPipelineRequest, value: Duration) =
            { state with IngestPutPipelineRequest.MasterTimeout = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestPutPipelineRequest, value: Duration) =
            { state with IngestPutPipelineRequest.Timeout = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("if_version")>]
        member _.IfVersion(state: IngestPutPipelineRequest, value: float) =
            { state with IngestPutPipelineRequest.IfVersion = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: IngestPutPipelineRequest, value: Metadata) =
            { state with IngestPutPipelineRequest.Meta = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("description")>]
        member _.Description(state: IngestPutPipelineRequest, value: string) =
            { state with IngestPutPipelineRequest.Description = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("on_failure")>]
        member _.OnFailure(state: IngestPutPipelineRequest, value: TypesProcessorContainer array) =
            { state with IngestPutPipelineRequest.OnFailure = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("processors")>]
        member _.Processors(state: IngestPutPipelineRequest, value: TypesProcessorContainer array) =
            { state with IngestPutPipelineRequest.Processors = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("version")>]
        member _.Version(state: IngestPutPipelineRequest, value: VersionNumber) =
            { state with IngestPutPipelineRequest.Version = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IngestPutPipelineRequest, value: bool) =
            { state with IngestPutPipelineRequest.Deprecated = Option.Some value } : IngestPutPipelineRequest

        [<CustomOperation("field_access_pattern")>]
        member _.FieldAccessPattern(state: IngestPutPipelineRequest, value: TypesFieldAccessPattern) =
            { state with IngestPutPipelineRequest.FieldAccessPattern = Option.Some value } : IngestPutPipelineRequest

    let ingestPutPipelineRequest = IngestPutPipelineRequestBuilder()

    type IngestPutPipelineResponse = AcknowledgedResponseBase

    type IngestDeletePipelineRequest = {
        Id: Id
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IngestDeletePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/pipeline/{request.Id}"
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

    module IngestDeletePipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestDeletePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestDeletePipelineRequest.ToRequest request

    type IngestDeletePipelineRequestBuilder() =
        member _.Yield(_: unit) : IngestDeletePipelineRequest =
            {
                IngestDeletePipelineRequest.Id = Unchecked.defaultof<Id>
                IngestDeletePipelineRequest.MasterTimeout = Option.None
                IngestDeletePipelineRequest.Timeout = Option.None
            } : IngestDeletePipelineRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestDeletePipelineRequest, value: Id) =
            { state with IngestDeletePipelineRequest.Id = value } : IngestDeletePipelineRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IngestDeletePipelineRequest, value: Duration) =
            { state with IngestDeletePipelineRequest.MasterTimeout = Option.Some value } : IngestDeletePipelineRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestDeletePipelineRequest, value: Duration) =
            { state with IngestDeletePipelineRequest.Timeout = Option.Some value } : IngestDeletePipelineRequest

    let ingestDeletePipelineRequest = IngestDeletePipelineRequestBuilder()

    type IngestDeletePipelineResponse = AcknowledgedResponseBase

    type IngestGeoIpStatsRequest = unit

    let ingestGeoIpStatsRequest = ()

    type IngestGeoIpStatsResponse = {
        [<JsonPropertyName("stats")>]
        Stats: GeoIpStatsGeoIpDownloadStatistics
        [<JsonPropertyName("nodes")>]
        Nodes: Map<string, GeoIpStatsGeoIpNodeDatabases>
    }

    type IngestProcessorGrokRequest = unit

    let ingestProcessorGrokRequest = ()

    type IngestProcessorGrokResponse = {
        [<JsonPropertyName("patterns")>]
        Patterns: Map<string, string>
    }

    type IngestSimulateRequest = {
        Id: Id
        Verbose: bool option
        [<JsonPropertyName("docs")>]
        Docs: TypesDocument array
        [<JsonPropertyName("pipeline")>]
        Pipeline: TypesPipeline option
    } with
        static member ToRequest(request: IngestSimulateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/pipeline/{request.Id}/_simulate"
                let queryParams =
                    [
                        request.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``docs`` = request.Docs; ``pipeline`` = request.Pipeline |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IngestSimulateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IngestSimulateRequest) : Result<Fes.Http.RequestMsg, exn> =
            IngestSimulateRequest.ToRequest request

    type IngestSimulateRequestBuilder() =
        member _.Yield(_: unit) : IngestSimulateRequest =
            {
                IngestSimulateRequest.Id = Unchecked.defaultof<Id>
                IngestSimulateRequest.Verbose = Option.None
                IngestSimulateRequest.Docs = [||]
                IngestSimulateRequest.Pipeline = Option.None
            } : IngestSimulateRequest

        [<CustomOperation("id")>]
        member _.Id(state: IngestSimulateRequest, value: Id) =
            { state with IngestSimulateRequest.Id = value } : IngestSimulateRequest

        [<CustomOperation("verbose")>]
        member _.Verbose(state: IngestSimulateRequest, value: bool) =
            { state with IngestSimulateRequest.Verbose = Option.Some value } : IngestSimulateRequest

        [<CustomOperation("docs")>]
        member _.Docs(state: IngestSimulateRequest, value: TypesDocument array) =
            { state with IngestSimulateRequest.Docs = value } : IngestSimulateRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: IngestSimulateRequest, value: TypesPipeline) =
            { state with IngestSimulateRequest.Pipeline = Option.Some value } : IngestSimulateRequest

    let ingestSimulateRequest = IngestSimulateRequestBuilder()

    type SimulateIngestRequest = {
        Index: IndexName
        Pipeline: PipelineName option
        MergeType: IngestMergeType option
        [<JsonPropertyName("docs")>]
        Docs: TypesDocument array
        [<JsonPropertyName("component_template_substitutions")>]
        ComponentTemplateSubstitutions: Map<string, TypesComponentTemplateNode> option
        [<JsonPropertyName("index_template_substitutions")>]
        IndexTemplateSubstitutions: Map<string, TypesIndexTemplate> option
        [<JsonPropertyName("mapping_addition")>]
        MappingAddition: MappingTypeMapping option
        [<JsonPropertyName("pipeline_substitutions")>]
        PipelineSubstitutions: Map<string, TypesPipeline> option
    } with
        static member ToRequest(request: SimulateIngestRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/{request.Index}/_simulate"
                let queryParams =
                    [
                        request.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                        request.MergeType |> Option.map (fun v -> "merge_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``docs`` = request.Docs; ``component_template_substitutions`` = request.ComponentTemplateSubstitutions; ``index_template_substitutions`` = request.IndexTemplateSubstitutions; ``mapping_addition`` = request.MappingAddition; ``pipeline_substitutions`` = request.PipelineSubstitutions |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SimulateIngestRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SimulateIngestRequest) : Result<Fes.Http.RequestMsg, exn> =
            SimulateIngestRequest.ToRequest request

    type SimulateIngestRequestBuilder() =
        member _.Yield(_: unit) : SimulateIngestRequest =
            {
                SimulateIngestRequest.Index = Unchecked.defaultof<IndexName>
                SimulateIngestRequest.Pipeline = Option.None
                SimulateIngestRequest.MergeType = Option.None
                SimulateIngestRequest.Docs = [||]
                SimulateIngestRequest.ComponentTemplateSubstitutions = Option.None
                SimulateIngestRequest.IndexTemplateSubstitutions = Option.None
                SimulateIngestRequest.MappingAddition = Option.None
                SimulateIngestRequest.PipelineSubstitutions = Option.None
            } : SimulateIngestRequest

        [<CustomOperation("index")>]
        member _.Index(state: SimulateIngestRequest, value: IndexName) =
            { state with SimulateIngestRequest.Index = value } : SimulateIngestRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: SimulateIngestRequest, value: PipelineName) =
            { state with SimulateIngestRequest.Pipeline = Option.Some value } : SimulateIngestRequest

        [<CustomOperation("merge_type")>]
        member _.MergeType(state: SimulateIngestRequest, value: IngestMergeType) =
            { state with SimulateIngestRequest.MergeType = Option.Some value } : SimulateIngestRequest

        [<CustomOperation("docs")>]
        member _.Docs(state: SimulateIngestRequest, value: TypesDocument array) =
            { state with SimulateIngestRequest.Docs = value } : SimulateIngestRequest

        [<CustomOperation("component_template_substitutions")>]
        member _.ComponentTemplateSubstitutions(state: SimulateIngestRequest, value: Map<string, TypesComponentTemplateNode>) =
            { state with SimulateIngestRequest.ComponentTemplateSubstitutions = Option.Some value } : SimulateIngestRequest

        [<CustomOperation("index_template_substitutions")>]
        member _.IndexTemplateSubstitutions(state: SimulateIngestRequest, value: Map<string, TypesIndexTemplate>) =
            { state with SimulateIngestRequest.IndexTemplateSubstitutions = Option.Some value } : SimulateIngestRequest

        [<CustomOperation("mapping_addition")>]
        member _.MappingAddition(state: SimulateIngestRequest, value: MappingTypeMapping) =
            { state with SimulateIngestRequest.MappingAddition = Option.Some value } : SimulateIngestRequest

        [<CustomOperation("pipeline_substitutions")>]
        member _.PipelineSubstitutions(state: SimulateIngestRequest, value: Map<string, TypesPipeline>) =
            { state with SimulateIngestRequest.PipelineSubstitutions = Option.Some value } : SimulateIngestRequest

    let simulateIngestRequest = SimulateIngestRequestBuilder()

