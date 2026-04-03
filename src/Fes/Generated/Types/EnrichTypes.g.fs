// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EnrichTypes =

    type Policy = {
        [<System.Text.Json.Serialization.JsonPropertyName("enrich_fields")>]
        EnrichFields: CoreTypes.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("match_field")>]
        MatchField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("elasticsearch_version")>]
        ElasticsearchVersion: string option
    }

    [<RequireQualifiedAccess>]
    type PolicyType =
        | GeoMatch
        | Match
        | Range

    type Summary = {
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: Map<PolicyType, Policy>
    }

