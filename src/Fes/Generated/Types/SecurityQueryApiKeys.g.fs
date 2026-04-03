// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityQueryApiKeys =

    [<RequireQualifiedAccess>]
    type ApiKeyAggregate =
        | CardinalityAggregate of TypesAggregations.CardinalityAggregate
        | ValueCountAggregate of TypesAggregations.ValueCountAggregate
        | StringTermsAggregate of TypesAggregations.StringTermsAggregate
        | LongTermsAggregate of TypesAggregations.LongTermsAggregate
        | DoubleTermsAggregate of TypesAggregations.DoubleTermsAggregate
        | UnmappedTermsAggregate of TypesAggregations.UnmappedTermsAggregate
        | MultiTermsAggregate of TypesAggregations.MultiTermsAggregate
        | MissingAggregate of TypesAggregations.MissingAggregate
        | FilterAggregate of TypesAggregations.FilterAggregate
        | FiltersAggregate of TypesAggregations.FiltersAggregate
        | RangeAggregate of TypesAggregations.RangeAggregate
        | DateRangeAggregate of TypesAggregations.DateRangeAggregate
        | CompositeAggregate of TypesAggregations.CompositeAggregate

    [<RequireQualifiedAccess>]
    type ApiKeyQueryContainer =
        | Bool of TypesQueryDsl.BoolQuery
        | Exists of TypesQueryDsl.ExistsQuery
        | Ids of TypesQueryDsl.IdsQuery
        | Match of field: string * TypesQueryDsl.MatchQuery
        | MatchAll of TypesQueryDsl.MatchAllQuery
        | Prefix of field: string * TypesQueryDsl.PrefixQuery
        | Range of field: string * TypesQueryDsl.RangeQuery
        | SimpleQueryString of TypesQueryDsl.SimpleQueryStringQuery
        | Term of field: string * TypesQueryDsl.TermQuery
        | Terms of TypesQueryDsl.TermsQuery
        | Wildcard of field: string * TypesQueryDsl.WildcardQuery
        | Unknown of name: string * System.Text.Json.JsonElement

    type ApiKeyFiltersAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: TypesAggregations.Buckets<SecurityQueryApiKeys.ApiKeyQueryContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("other_bucket")>]
        OtherBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("other_bucket_key")>]
        OtherBucketKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    [<RequireQualifiedAccess>]
    type ApiKeyAggregationContainer =
        | Cardinality of TypesAggregations.CardinalityAggregation
        | Composite of TypesAggregations.CompositeAggregation
        | DateRange of TypesAggregations.DateRangeAggregation
        | Filter of SecurityQueryApiKeys.ApiKeyQueryContainer
        | Filters of SecurityQueryApiKeys.ApiKeyFiltersAggregation
        | Missing of TypesAggregations.MissingAggregation
        | Range of TypesAggregations.RangeAggregation
        | Terms of TypesAggregations.TermsAggregation
        | ValueCount of TypesAggregations.ValueCountAggregation
        | Unknown of name: string * System.Text.Json.JsonElement

    and ApiKeyAggregationContainerMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, SecurityQueryApiKeys.ApiKeyAggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Types.Metadata option
    }

