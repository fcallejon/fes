// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EnrichTypes =

    type Policy = {
        [<System.Text.Json.Serialization.JsonPropertyName("enrich_fields")>]
        EnrichFields: Types.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("match_field")>]
        MatchField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
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
        Config: Map<EnrichTypes.PolicyType, EnrichTypes.Policy>
    }

