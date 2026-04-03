// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalReindex =

    type Destination = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("op_type")>]
        OpType: CoreTypes.OpType option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: CoreTypes.VersionType option
    }

    type RemoteSource = {
        [<System.Text.Json.Serialization.JsonPropertyName("connect_timeout")>]
        ConnectTimeout: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: CoreTypes.Username option
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: CoreTypes.Password option
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("socket_timeout")>]
        SocketTimeout: CoreTypes.Duration option
    }

    type Source = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("remote")>]
        Remote: RemoteSource option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: CoreTypes.ProjectRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: CoreTypes.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: CoreTypes.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: CoreTypes.RuntimeFields option
    }

