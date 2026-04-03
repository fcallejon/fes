// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityQueryApiKeysBuilders =

    module ApiKeyAggregation =

        let cardinality (value: Types.CardinalityAggregation) =
            Types.ApiKeyAggregationContainer.Cardinality value

        let composite (value: Types.CompositeAggregation) =
            Types.ApiKeyAggregationContainer.Composite value

        let dateRange (value: Types.DateRangeAggregation) =
            Types.ApiKeyAggregationContainer.DateRange value

        let filter (value: Types.ApiKeyQueryContainer) =
            Types.ApiKeyAggregationContainer.Filter value

        let filters (value: Types.ApiKeyFiltersAggregation) =
            Types.ApiKeyAggregationContainer.Filters value

        let missing (value: Types.MissingAggregation) =
            Types.ApiKeyAggregationContainer.Missing value

        let range (value: Types.RangeAggregation) =
            Types.ApiKeyAggregationContainer.Range value

        let terms (value: Types.TermsAggregation) =
            Types.ApiKeyAggregationContainer.Terms value

        let valueCount (value: Types.ValueCountAggregation) =
            Types.ApiKeyAggregationContainer.ValueCount value

    type ApiKeyFiltersAggregationBuilder() =
        member _.Yield(_: unit) : Types.ApiKeyFiltersAggregation =
            {
                Filters = None
                OtherBucket = None
                OtherBucketKey = None
                Keyed = None
            }

        [<CustomOperation("filters")>]
        member _.Filters(state: Types.ApiKeyFiltersAggregation, value: Types.Buckets<Types.ApiKeyQueryContainer>) =
            { state with Filters = Some value }

        [<CustomOperation("otherBucket")>]
        member _.OtherBucket(state: Types.ApiKeyFiltersAggregation, value: bool) =
            { state with OtherBucket = Some value }

        [<CustomOperation("otherBucketKey")>]
        member _.OtherBucketKey(state: Types.ApiKeyFiltersAggregation, value: string) =
            { state with OtherBucketKey = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.ApiKeyFiltersAggregation, value: bool) =
            { state with Keyed = Some value }

    let apiKeyFiltersAggregation = ApiKeyFiltersAggregationBuilder()

    module ApiKeyQuery =

        let bool (value: Types.BoolQuery) =
            Types.ApiKeyQueryContainer.Bool value

        let exists (value: Types.ExistsQuery) =
            Types.ApiKeyQueryContainer.Exists value

        let ids (value: Types.IdsQuery) =
            Types.ApiKeyQueryContainer.Ids value

        let match' (field: string) (value: Types.MatchQuery) =
            Types.ApiKeyQueryContainer.Match (field, value)

        let matchAll (value: Types.MatchAllQuery) =
            Types.ApiKeyQueryContainer.MatchAll value

        let prefix (field: string) (value: Types.PrefixQuery) =
            Types.ApiKeyQueryContainer.Prefix (field, value)

        let range (field: string) (value: Types.RangeQuery) =
            Types.ApiKeyQueryContainer.Range (field, value)

        let simpleQueryString (value: Types.SimpleQueryStringQuery) =
            Types.ApiKeyQueryContainer.SimpleQueryString value

        let term (field: string) (value: Types.TermQuery) =
            Types.ApiKeyQueryContainer.Term (field, value)

        let terms (value: Types.TermsQuery) =
            Types.ApiKeyQueryContainer.Terms value

        let wildcard (field: string) (value: Types.WildcardQuery) =
            Types.ApiKeyQueryContainer.Wildcard (field, value)

