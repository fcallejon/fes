// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityQueryApiKeysBuilders =

    module ApiKeyAggregation =

        let cardinality (value: CoreTypes.CardinalityAggregation) =
            ApiKeyAggregationContainer.Cardinality value

        let composite (value: CoreTypes.CompositeAggregation) =
            ApiKeyAggregationContainer.Composite value

        let dateRange (value: CoreTypes.DateRangeAggregation) =
            ApiKeyAggregationContainer.DateRange value

        let filter (value: SecurityQueryApiKeys.ApiKeyQueryContainer) =
            ApiKeyAggregationContainer.Filter value

        let filters (value: SecurityQueryApiKeys.ApiKeyFiltersAggregation) =
            ApiKeyAggregationContainer.Filters value

        let missing (value: CoreTypes.MissingAggregation) =
            ApiKeyAggregationContainer.Missing value

        let range (value: CoreTypes.RangeAggregation) =
            ApiKeyAggregationContainer.Range value

        let terms (value: CoreTypes.TermsAggregation) =
            ApiKeyAggregationContainer.Terms value

        let valueCount (value: CoreTypes.ValueCountAggregation) =
            ApiKeyAggregationContainer.ValueCount value

    type ApiKeyFiltersAggregationBuilder() =
        member _.Yield(_: unit) : ApiKeyFiltersAggregation =
            {
                Filters = None
                OtherBucket = None
                OtherBucketKey = None
                Keyed = None
            }

        [<CustomOperation("filters")>]
        member _.Filters(state: ApiKeyFiltersAggregation, value: CoreTypes.Buckets<SecurityQueryApiKeys.ApiKeyQueryContainer>) =
            { state with Filters = Some value }

        [<CustomOperation("otherBucket")>]
        member _.OtherBucket(state: ApiKeyFiltersAggregation, value: bool) =
            { state with OtherBucket = Some value }

        [<CustomOperation("otherBucketKey")>]
        member _.OtherBucketKey(state: ApiKeyFiltersAggregation, value: string) =
            { state with OtherBucketKey = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: ApiKeyFiltersAggregation, value: bool) =
            { state with Keyed = Some value }

    let apiKeyFiltersAggregation = ApiKeyFiltersAggregationBuilder()

    module ApiKeyQuery =

        let bool (value: CoreTypes.BoolQuery) =
            ApiKeyQueryContainer.Bool value

        let exists (value: CoreTypes.ExistsQuery) =
            ApiKeyQueryContainer.Exists value

        let ids (value: CoreTypes.IdsQuery) =
            ApiKeyQueryContainer.Ids value

        let match' (field: string) (value: CoreTypes.MatchQuery) =
            ApiKeyQueryContainer.Match (field, value)

        let matchAll (value: CoreTypes.MatchAllQuery) =
            ApiKeyQueryContainer.MatchAll value

        let prefix (field: string) (value: CoreTypes.PrefixQuery) =
            ApiKeyQueryContainer.Prefix (field, value)

        let range (field: string) (value: CoreTypes.RangeQuery) =
            ApiKeyQueryContainer.Range (field, value)

        let simpleQueryString (value: CoreTypes.SimpleQueryStringQuery) =
            ApiKeyQueryContainer.SimpleQueryString value

        let term (field: string) (value: CoreTypes.TermQuery) =
            ApiKeyQueryContainer.Term (field, value)

        let terms (value: CoreTypes.TermsQuery) =
            ApiKeyQueryContainer.Terms value

        let wildcard (field: string) (value: CoreTypes.WildcardQuery) =
            ApiKeyQueryContainer.Wildcard (field, value)

