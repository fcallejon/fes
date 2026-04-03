// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module IngestOperations =

    type IngestDeleteGeoipDatabaseRequest = {
        Id: Types.Ids
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: IngestDeleteGeoipDatabaseRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/geoip/database/{Fes.Http.toPathSegment req.Id}"
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

    type IngestDeleteGeoipDatabaseResponse = Types.AcknowledgedResponseBase

    type IngestDeleteGeoipDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestDeleteGeoipDatabaseRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestDeleteGeoipDatabaseRequest, value: Types.Ids) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestDeleteGeoipDatabaseRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestDeleteGeoipDatabaseRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ingestDeleteGeoipDatabaseRequest = IngestDeleteGeoipDatabaseRequestBuilder()

    module DeleteGeoipDatabase =
        let withMasterTimeout (value: Types.Duration) (req: IngestDeleteGeoipDatabaseRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IngestDeleteGeoipDatabaseRequest) =
            { req with Timeout = Some value }

    type IngestDeleteIpLocationDatabaseRequest = {
        Id: Types.Ids
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: IngestDeleteIpLocationDatabaseRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/ip_location/database/{Fes.Http.toPathSegment req.Id}"
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

    type IngestDeleteIpLocationDatabaseResponse = Types.AcknowledgedResponseBase

    type IngestDeleteIpLocationDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestDeleteIpLocationDatabaseRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestDeleteIpLocationDatabaseRequest, value: Types.Ids) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestDeleteIpLocationDatabaseRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestDeleteIpLocationDatabaseRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ingestDeleteIpLocationDatabaseRequest = IngestDeleteIpLocationDatabaseRequestBuilder()

    module DeleteIpLocationDatabase =
        let withMasterTimeout (value: Types.Duration) (req: IngestDeleteIpLocationDatabaseRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IngestDeleteIpLocationDatabaseRequest) =
            { req with Timeout = Some value }

    type IngestDeletePipelineRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: IngestDeletePipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/pipeline/{Fes.Http.toPathSegment req.Id}"
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

    type IngestDeletePipelineResponse = Types.AcknowledgedResponseBase

    type IngestDeletePipelineRequestBuilder() =
        member _.Yield(_: unit) : IngestDeletePipelineRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestDeletePipelineRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestDeletePipelineRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestDeletePipelineRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ingestDeletePipelineRequest = IngestDeletePipelineRequestBuilder()

    module DeletePipeline =
        let withMasterTimeout (value: Types.Duration) (req: IngestDeletePipelineRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IngestDeletePipelineRequest) =
            { req with Timeout = Some value }

    type IngestGeoIpStatsRequest = | IngestGeoIpStatsRequest

        with
        static member ToEndpoint(req: IngestGeoIpStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/geoip/stats"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type IngestGeoIpStatsResponse = System.Text.Json.JsonElement

    type IngestGetGeoipDatabaseRequest = {
        Id: Types.Ids
    }

        with
        static member ToEndpoint(req: IngestGetGeoipDatabaseRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/geoip/database/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type IngestGetGeoipDatabaseResponse = System.Text.Json.JsonElement

    type IngestGetGeoipDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestGetGeoipDatabaseRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestGetGeoipDatabaseRequest, value: Types.Ids) =
            { state with Id = value }

    let ingestGetGeoipDatabaseRequest = IngestGetGeoipDatabaseRequestBuilder()

    type IngestGetIpLocationDatabaseRequest = {
        Id: Types.Ids
    }

        with
        static member ToEndpoint(req: IngestGetIpLocationDatabaseRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/ip_location/database/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type IngestGetIpLocationDatabaseResponse = System.Text.Json.JsonElement

    type IngestGetIpLocationDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestGetIpLocationDatabaseRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestGetIpLocationDatabaseRequest, value: Types.Ids) =
            { state with Id = value }

    let ingestGetIpLocationDatabaseRequest = IngestGetIpLocationDatabaseRequestBuilder()

    type IngestGetPipelineRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
        Summary: bool option
    }

        with
        static member ToEndpoint(req: IngestGetPipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/pipeline/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Summary |> Option.map (fun v -> "summary", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type IngestGetPipelineResponse = Map<string, Types.IngestTypesPipeline>

    type IngestGetPipelineRequestBuilder() =
        member _.Yield(_: unit) : IngestGetPipelineRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Summary = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestGetPipelineRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestGetPipelineRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("summary")>]
        member _.Summary(state: IngestGetPipelineRequest, value: bool) =
            { state with Summary = Some value }

    let ingestGetPipelineRequest = IngestGetPipelineRequestBuilder()

    module GetPipeline =
        let withMasterTimeout (value: Types.Duration) (req: IngestGetPipelineRequest) =
            { req with MasterTimeout = Some value }
        let withSummary (value: bool) (req: IngestGetPipelineRequest) =
            { req with Summary = Some value }

    type IngestProcessorGrokRequest = | IngestProcessorGrokRequest

        with
        static member ToEndpoint(req: IngestProcessorGrokRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/processor/grok"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type IngestProcessorGrokResponse = System.Text.Json.JsonElement

    type IngestPutGeoipDatabaseRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("maxmind")>]
        Maxmind: Types.Maxmind
    }

        with
        static member ToEndpoint(req: IngestPutGeoipDatabaseRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/geoip/database/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type IngestPutGeoipDatabaseResponse = Types.AcknowledgedResponseBase

    type IngestPutGeoipDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestPutGeoipDatabaseRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Name = Unchecked.defaultof<_>
                Maxmind = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestPutGeoipDatabaseRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestPutGeoipDatabaseRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestPutGeoipDatabaseRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: IngestPutGeoipDatabaseRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("maxmind")>]
        member _.Maxmind(state: IngestPutGeoipDatabaseRequest, value: Types.Maxmind) =
            { state with Maxmind = value }

    let ingestPutGeoipDatabaseRequest = IngestPutGeoipDatabaseRequestBuilder()

    module PutGeoipDatabase =
        let withMasterTimeout (value: Types.Duration) (req: IngestPutGeoipDatabaseRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IngestPutGeoipDatabaseRequest) =
            { req with Timeout = Some value }
        let withName (value: Types.Name) (req: IngestPutGeoipDatabaseRequest) =
            { req with Name = value }
        let withMaxmind (value: Types.Maxmind) (req: IngestPutGeoipDatabaseRequest) =
            { req with Maxmind = value }

    type IngestPutIpLocationDatabaseRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToEndpoint(req: IngestPutIpLocationDatabaseRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/ip_location/database/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type IngestPutIpLocationDatabaseResponse = Types.AcknowledgedResponseBase

    type IngestPutIpLocationDatabaseRequestBuilder() =
        member _.Yield(_: unit) : IngestPutIpLocationDatabaseRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestPutIpLocationDatabaseRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestPutIpLocationDatabaseRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestPutIpLocationDatabaseRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IngestPutIpLocationDatabaseRequest, value) =
            { state with Document = value }

    let ingestPutIpLocationDatabaseRequest = IngestPutIpLocationDatabaseRequestBuilder()

    module PutIpLocationDatabase =
        let withMasterTimeout (value: Types.Duration) (req: IngestPutIpLocationDatabaseRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IngestPutIpLocationDatabaseRequest) =
            { req with Timeout = Some value }

    type IngestPutPipelineRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        IfVersion: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("on_failure")>]
        OnFailure: Types.ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: Types.ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("field_access_pattern")>]
        FieldAccessPattern: Types.FieldAccessPattern option
    }

        with
        static member ToEndpoint(req: IngestPutPipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/pipeline/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.IfVersion |> Option.map (fun v -> "if_version", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type IngestPutPipelineResponse = Types.AcknowledgedResponseBase

    type IngestPutPipelineRequestBuilder() =
        member _.Yield(_: unit) : IngestPutPipelineRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                IfVersion = None
                Meta = None
                Description = None
                OnFailure = None
                Processors = None
                Version = None
                Deprecated = None
                FieldAccessPattern = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestPutPipelineRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IngestPutPipelineRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IngestPutPipelineRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("ifVersion")>]
        member _.IfVersion(state: IngestPutPipelineRequest, value: Types.Integer) =
            { state with IfVersion = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: IngestPutPipelineRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: IngestPutPipelineRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: IngestPutPipelineRequest, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("processors")>]
        member _.Processors(state: IngestPutPipelineRequest, value: Types.ProcessorContainer list) =
            { state with Processors = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IngestPutPipelineRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IngestPutPipelineRequest, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("fieldAccessPattern")>]
        member _.FieldAccessPattern(state: IngestPutPipelineRequest, value: Types.FieldAccessPattern) =
            { state with FieldAccessPattern = Some value }

    let ingestPutPipelineRequest = IngestPutPipelineRequestBuilder()

    module PutPipeline =
        let withMasterTimeout (value: Types.Duration) (req: IngestPutPipelineRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IngestPutPipelineRequest) =
            { req with Timeout = Some value }
        let withIfVersion (value: Types.Integer) (req: IngestPutPipelineRequest) =
            { req with IfVersion = Some value }
        let withMeta (value: Types.Metadata) (req: IngestPutPipelineRequest) =
            { req with Meta = Some value }
        let withDescription (value: string) (req: IngestPutPipelineRequest) =
            { req with Description = Some value }
        let withOnFailure (value: Types.ProcessorContainer list) (req: IngestPutPipelineRequest) =
            { req with OnFailure = Some value }
        let withProcessors (value: Types.ProcessorContainer list) (req: IngestPutPipelineRequest) =
            { req with Processors = Some value }
        let withVersion (value: Types.VersionNumber) (req: IngestPutPipelineRequest) =
            { req with Version = Some value }
        let withDeprecated (value: bool) (req: IngestPutPipelineRequest) =
            { req with Deprecated = Some value }
        let withFieldAccessPattern (value: Types.FieldAccessPattern) (req: IngestPutPipelineRequest) =
            { req with FieldAccessPattern = Some value }

    type IngestSimulateRequest = {
        Id: Types.Id
        Verbose: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.Document list
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: Types.IngestTypesPipeline option
    }

        with
        static member ToEndpoint(req: IngestSimulateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ingest/pipeline/{Fes.Http.toPathSegment req.Id}/_simulate"
            let queryParams =
                [
                    req.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type IngestSimulateResponse = System.Text.Json.JsonElement

    type IngestSimulateRequestBuilder() =
        member _.Yield(_: unit) : IngestSimulateRequest =
            {
                Id = Unchecked.defaultof<_>
                Verbose = None
                Docs = Unchecked.defaultof<_>
                Pipeline = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: IngestSimulateRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: IngestSimulateRequest, value: bool) =
            { state with Verbose = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: IngestSimulateRequest, value: Types.Document list) =
            { state with Docs = value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: IngestSimulateRequest, value: Types.IngestTypesPipeline) =
            { state with Pipeline = Some value }

    let ingestSimulateRequest = IngestSimulateRequestBuilder()

    module Simulate =
        let withVerbose (value: bool) (req: IngestSimulateRequest) =
            { req with Verbose = Some value }
        let withDocs (value: Types.Document list) (req: IngestSimulateRequest) =
            { req with Docs = value }
        let withPipeline (value: Types.IngestTypesPipeline) (req: IngestSimulateRequest) =
            { req with Pipeline = Some value }

