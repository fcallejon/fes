// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EsqlListQueries =

    type Body = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_millis")>]
        StartTimeMillis: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_nanos")>]
        RunningTimeNanos: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

