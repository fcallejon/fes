// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TextStructureTypes =

    [<RequireQualifiedAccess>]
    type EcsCompatibilityType =
        | Disabled
        | V1

    type TopHit = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement
    }

    type FieldStat = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("cardinality")>]
        Cardinality: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("top_hits")>]
        TopHits: TextStructureTypes.TopHit list
        [<System.Text.Json.Serialization.JsonPropertyName("mean_value")>]
        MeanValue: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("median_value")>]
        MedianValue: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_value")>]
        MaxValue: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_value")>]
        MinValue: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("earliest")>]
        Earliest: string option
        [<System.Text.Json.Serialization.JsonPropertyName("latest")>]
        Latest: string option
    }

    [<RequireQualifiedAccess>]
    type FormatType =
        | Delimited
        | Ndjson
        | SemiStructuredText
        | Xml

