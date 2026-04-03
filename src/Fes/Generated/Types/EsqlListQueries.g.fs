// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EsqlListQueries =

    type Body = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_millis")>]
        StartTimeMillis: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_nanos")>]
        RunningTimeNanos: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

