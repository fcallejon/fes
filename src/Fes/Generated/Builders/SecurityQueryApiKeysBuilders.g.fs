// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityQueryApiKeysBuilders =

    module ApiKeyAggregation =

        let cardinality (value: TypesAggregations.CardinalityAggregation) =
            ApiKeyAggregationContainer.Cardinality value

        let composite (value: TypesAggregations.CompositeAggregation) =
            ApiKeyAggregationContainer.Composite value

        let dateRange (value: TypesAggregations.DateRangeAggregation) =
            ApiKeyAggregationContainer.DateRange value

        let filter (value: SecurityQueryApiKeys.ApiKeyQueryContainer) =
            ApiKeyAggregationContainer.Filter value

        let filters (value: SecurityQueryApiKeys.ApiKeyFiltersAggregation) =
            ApiKeyAggregationContainer.Filters value

        let missing (value: TypesAggregations.MissingAggregation) =
            ApiKeyAggregationContainer.Missing value

        let range (value: TypesAggregations.RangeAggregation) =
            ApiKeyAggregationContainer.Range value

        let terms (value: TypesAggregations.TermsAggregation) =
            ApiKeyAggregationContainer.Terms value

        let valueCount (value: TypesAggregations.ValueCountAggregation) =
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
        member _.Filters(state: ApiKeyFiltersAggregation, value: TypesAggregations.Buckets<SecurityQueryApiKeys.ApiKeyQueryContainer>) =
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

        let bool (value: TypesQueryDsl.BoolQuery) =
            ApiKeyQueryContainer.Bool value

        let exists (value: TypesQueryDsl.ExistsQuery) =
            ApiKeyQueryContainer.Exists value

        let ids (value: TypesQueryDsl.IdsQuery) =
            ApiKeyQueryContainer.Ids value

        let match' (field: string) (value: TypesQueryDsl.MatchQuery) =
            ApiKeyQueryContainer.Match (field, value)

        let matchAll (value: TypesQueryDsl.MatchAllQuery) =
            ApiKeyQueryContainer.MatchAll value

        let prefix (field: string) (value: TypesQueryDsl.PrefixQuery) =
            ApiKeyQueryContainer.Prefix (field, value)

        let range (field: string) (value: TypesQueryDsl.RangeQuery) =
            ApiKeyQueryContainer.Range (field, value)

        let simpleQueryString (value: TypesQueryDsl.SimpleQueryStringQuery) =
            ApiKeyQueryContainer.SimpleQueryString value

        let term (field: string) (value: TypesQueryDsl.TermQuery) =
            ApiKeyQueryContainer.Term (field, value)

        let terms (value: TypesQueryDsl.TermsQuery) =
            ApiKeyQueryContainer.Terms value

        let wildcard (field: string) (value: TypesQueryDsl.WildcardQuery) =
            ApiKeyQueryContainer.Wildcard (field, value)

