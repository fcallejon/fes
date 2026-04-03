// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityQueryApiKeys =

    [<RequireQualifiedAccess>]
    type ApiKeyAggregate =
        | CardinalityAggregate of CoreTypes.CardinalityAggregate
        | ValueCountAggregate of CoreTypes.ValueCountAggregate
        | StringTermsAggregate of CoreTypes.StringTermsAggregate
        | LongTermsAggregate of CoreTypes.LongTermsAggregate
        | DoubleTermsAggregate of CoreTypes.DoubleTermsAggregate
        | UnmappedTermsAggregate of CoreTypes.UnmappedTermsAggregate
        | MultiTermsAggregate of CoreTypes.MultiTermsAggregate
        | MissingAggregate of CoreTypes.MissingAggregate
        | FilterAggregate of CoreTypes.FilterAggregate
        | FiltersAggregate of CoreTypes.FiltersAggregate
        | RangeAggregate of CoreTypes.RangeAggregate
        | DateRangeAggregate of CoreTypes.DateRangeAggregate
        | CompositeAggregate of CoreTypes.CompositeAggregate

    [<RequireQualifiedAccess>]
    type ApiKeyQueryContainer =
        | Bool of CoreTypes.BoolQuery
        | Exists of CoreTypes.ExistsQuery
        | Ids of CoreTypes.IdsQuery
        | Match of field: string * CoreTypes.MatchQuery
        | MatchAll of CoreTypes.MatchAllQuery
        | Prefix of field: string * CoreTypes.PrefixQuery
        | Range of field: string * CoreTypes.RangeQuery
        | SimpleQueryString of CoreTypes.SimpleQueryStringQuery
        | Term of field: string * CoreTypes.TermQuery
        | Terms of CoreTypes.TermsQuery
        | Wildcard of field: string * CoreTypes.WildcardQuery
        | Unknown of name: string * System.Text.Json.JsonElement

    type ApiKeyFiltersAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: CoreTypes.Buckets<ApiKeyQueryContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("other_bucket")>]
        OtherBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("other_bucket_key")>]
        OtherBucketKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    [<RequireQualifiedAccess>]
    type ApiKeyAggregationContainer =
        | Cardinality of CoreTypes.CardinalityAggregation
        | Composite of CoreTypes.CompositeAggregation
        | DateRange of CoreTypes.DateRangeAggregation
        | Filter of ApiKeyQueryContainer
        | Filters of ApiKeyFiltersAggregation
        | Missing of CoreTypes.MissingAggregation
        | Range of CoreTypes.RangeAggregation
        | Terms of CoreTypes.TermsAggregation
        | ValueCount of CoreTypes.ValueCountAggregation
        | Unknown of name: string * System.Text.Json.JsonElement

    and ApiKeyAggregationContainerMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, ApiKeyAggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: CoreTypes.Metadata option
    }

