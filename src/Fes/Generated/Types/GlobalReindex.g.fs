// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalReindex =

    type Destination = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("op_type")>]
        OpType: Types.OpType option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: Types.VersionType option
    }

    type RemoteSource = {
        [<System.Text.Json.Serialization.JsonPropertyName("connect_timeout")>]
        ConnectTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: Types.Username option
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: Types.Password option
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("socket_timeout")>]
        SocketTimeout: Types.Duration option
    }

    type Source = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("remote")>]
        Remote: GlobalReindex.RemoteSource option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: Types.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: TypesMapping.RuntimeFields option
    }

