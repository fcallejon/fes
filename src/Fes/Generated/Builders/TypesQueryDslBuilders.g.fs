// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TypesQueryDslBuilders =

    type BoolQueryBuilder() =
        member _.Yield(_: unit) : Types.BoolQuery =
            {
                Filter = None
                MinimumShouldMatch = None
                Must = None
                MustNot = None
                Should = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.BoolQuery, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.BoolQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("must")>]
        member _.Must(state: Types.BoolQuery, value: System.Text.Json.JsonElement) =
            { state with Must = Some value }

        [<CustomOperation("mustNot")>]
        member _.MustNot(state: Types.BoolQuery, value: System.Text.Json.JsonElement) =
            { state with MustNot = Some value }

        [<CustomOperation("should")>]
        member _.Should(state: Types.BoolQuery, value: System.Text.Json.JsonElement) =
            { state with Should = Some value }

    let boolQuery = BoolQueryBuilder()

    type CombinedFieldsQueryBuilder() =
        member _.Yield(_: unit) : Types.CombinedFieldsQuery =
            {
                Fields = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
                AutoGenerateSynonymsPhraseQuery = None
                Operator = None
                MinimumShouldMatch = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.CombinedFieldsQuery, value: Types.Field list) =
            { state with Fields = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.CombinedFieldsQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: Types.CombinedFieldsQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: Types.CombinedFieldsQuery, value: Types.CombinedFieldsOperator) =
            { state with Operator = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.CombinedFieldsQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: Types.CombinedFieldsQuery, value: Types.CombinedFieldsZeroTerms) =
            { state with ZeroTermsQuery = Some value }

    let combinedFieldsQuery = CombinedFieldsQueryBuilder()

    type CommonTermsQueryBuilder() =
        member _.Yield(_: unit) : Types.CommonTermsQuery =
            {
                Analyzer = None
                CutoffFrequency = None
                HighFreqOperator = None
                LowFreqOperator = None
                MinimumShouldMatch = None
                Query = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.CommonTermsQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("cutoffFrequency")>]
        member _.CutoffFrequency(state: Types.CommonTermsQuery, value: Types.Double) =
            { state with CutoffFrequency = Some value }

        [<CustomOperation("highFreqOperator")>]
        member _.HighFreqOperator(state: Types.CommonTermsQuery, value: Types.Operator) =
            { state with HighFreqOperator = Some value }

        [<CustomOperation("lowFreqOperator")>]
        member _.LowFreqOperator(state: Types.CommonTermsQuery, value: Types.Operator) =
            { state with LowFreqOperator = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.CommonTermsQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.CommonTermsQuery, value: string) =
            { state with Query = value }

    let commonTermsQuery = CommonTermsQueryBuilder()

    let ofQuery (value: string) : Types.CommonTermsQuery =
        {
            Analyzer = None
            CutoffFrequency = None
            HighFreqOperator = None
            LowFreqOperator = None
            MinimumShouldMatch = None
            Query = value
        }

    type DateRangeQueryBuilder() =
        member _.Yield(_: unit) : Types.DateRangeQuery =
            {
                Format = None
                TimeZone = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateRangeQuery, value: Types.DateFormat) =
            { state with Format = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.DateRangeQuery, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let dateRangeQuery = DateRangeQueryBuilder()

    type FieldAndFormatBuilder() =
        member _.Yield(_: unit) : Types.FieldAndFormat =
            {
                Field = Unchecked.defaultof<_>
                Format = None
                IncludeUnmapped = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.FieldAndFormat, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.FieldAndFormat, value: string) =
            { state with Format = Some value }

        [<CustomOperation("includeUnmapped")>]
        member _.IncludeUnmapped(state: Types.FieldAndFormat, value: bool) =
            { state with IncludeUnmapped = Some value }

    let fieldAndFormat = FieldAndFormatBuilder()

    let ofField (value: Types.Field) : Types.FieldAndFormat =
        {
            Field = value
            Format = None
            IncludeUnmapped = None
        }

    type FieldLookupBuilder() =
        member _.Yield(_: unit) : Types.FieldLookup =
            {
                Id = Unchecked.defaultof<_>
                Index = None
                Path = None
                Routing = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.FieldLookup, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.FieldLookup, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.FieldLookup, value: Types.Field) =
            { state with Path = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.FieldLookup, value: string) =
            { state with Routing = Some value }

    let fieldLookup = FieldLookupBuilder()

    type FieldValueFactorScoreFunctionBuilder() =
        member _.Yield(_: unit) : Types.FieldValueFactorScoreFunction =
            {
                Field = Unchecked.defaultof<_>
                Factor = None
                Missing = None
                Modifier = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.FieldValueFactorScoreFunction, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("factor")>]
        member _.Factor(state: Types.FieldValueFactorScoreFunction, value: Types.Double) =
            { state with Factor = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.FieldValueFactorScoreFunction, value: Types.Double) =
            { state with Missing = Some value }

        [<CustomOperation("modifier")>]
        member _.Modifier(state: Types.FieldValueFactorScoreFunction, value: Types.FieldValueFactorModifier) =
            { state with Modifier = Some value }

    let fieldValueFactorScoreFunction = FieldValueFactorScoreFunctionBuilder()

    module FunctionScore =

        let exp (value: Types.DecayFunction) =
            Types.FunctionScoreContainer.Exp value

        let gauss (value: Types.DecayFunction) =
            Types.FunctionScoreContainer.Gauss value

        let linear (value: Types.DecayFunction) =
            Types.FunctionScoreContainer.Linear value

        let fieldValueFactor (value: Types.FieldValueFactorScoreFunction) =
            Types.FunctionScoreContainer.FieldValueFactor value

        let randomScore (value: Types.RandomScoreFunction) =
            Types.FunctionScoreContainer.RandomScore value

        let scriptScore (value: Types.ScriptScoreFunction) =
            Types.FunctionScoreContainer.ScriptScore value

    type FunctionScoreQueryBuilder() =
        member _.Yield(_: unit) : Types.FunctionScoreQuery =
            {
                BoostMode = None
                Functions = None
                MaxBoost = None
                MinScore = None
                Query = None
                ScoreMode = None
            }

        [<CustomOperation("boostMode")>]
        member _.BoostMode(state: Types.FunctionScoreQuery, value: Types.FunctionBoostMode) =
            { state with BoostMode = Some value }

        [<CustomOperation("functions")>]
        member _.Functions(state: Types.FunctionScoreQuery, value: Types.FunctionScoreContainer list) =
            { state with Functions = Some value }

        [<CustomOperation("maxBoost")>]
        member _.MaxBoost(state: Types.FunctionScoreQuery, value: Types.Double) =
            { state with MaxBoost = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: Types.FunctionScoreQuery, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.FunctionScoreQuery, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: Types.FunctionScoreQuery, value: Types.FunctionScoreMode) =
            { state with ScoreMode = Some value }

    let functionScoreQuery = FunctionScoreQueryBuilder()

    let ofFunctions (value: Types.FunctionScoreContainer list) : Types.FunctionScoreQuery =
        {
            BoostMode = None
            Functions = value
            MaxBoost = None
            MinScore = None
            Query = None
            ScoreMode = None
        }

    type FuzzyQueryBuilder() =
        member _.Yield(_: unit) : Types.FuzzyQuery =
            {
                MaxExpansions = None
                PrefixLength = None
                Rewrite = None
                Transpositions = None
                Fuzziness = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: Types.FuzzyQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.FuzzyQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: Types.FuzzyQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("transpositions")>]
        member _.Transpositions(state: Types.FuzzyQuery, value: bool) =
            { state with Transpositions = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.FuzzyQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.FuzzyQuery, value: System.Text.Json.JsonElement) =
            { state with Value = value }

    let fuzzyQuery = FuzzyQueryBuilder()

    let ofValue (value: System.Text.Json.JsonElement) : Types.FuzzyQuery =
        {
            MaxExpansions = None
            PrefixLength = None
            Rewrite = None
            Transpositions = None
            Fuzziness = None
            Value = value
        }

    type GeoBoundingBoxQueryBuilder() =
        member _.Yield(_: unit) : Types.GeoBoundingBoxQuery =
            {
                Type = None
                ValidationMethod = None
                IgnoreUnmapped = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.GeoBoundingBoxQuery, value: Types.GeoExecution) =
            { state with Type = Some value }

        [<CustomOperation("validationMethod")>]
        member _.ValidationMethod(state: Types.GeoBoundingBoxQuery, value: Types.GeoValidationMethod) =
            { state with ValidationMethod = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.GeoBoundingBoxQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

    let geoBoundingBoxQuery = GeoBoundingBoxQueryBuilder()

    type GeoDistanceQueryBuilder() =
        member _.Yield(_: unit) : Types.GeoDistanceQuery =
            {
                Distance = Unchecked.defaultof<_>
                DistanceType = None
                ValidationMethod = None
                IgnoreUnmapped = None
            }

        [<CustomOperation("distance")>]
        member _.Distance(state: Types.GeoDistanceQuery, value: Types.Distance) =
            { state with Distance = value }

        [<CustomOperation("distanceType")>]
        member _.DistanceType(state: Types.GeoDistanceQuery, value: Types.GeoDistanceType) =
            { state with DistanceType = Some value }

        [<CustomOperation("validationMethod")>]
        member _.ValidationMethod(state: Types.GeoDistanceQuery, value: Types.GeoValidationMethod) =
            { state with ValidationMethod = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.GeoDistanceQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

    let geoDistanceQuery = GeoDistanceQueryBuilder()

    module GeoGridQuery =

        let geotile (value: Types.GeoTile) =
            Types.GeoGridQuery.Geotile value

        let geohash (value: Types.GeoHash) =
            Types.GeoGridQuery.Geohash value

        let geohex (value: Types.GeoHexCell) =
            Types.GeoGridQuery.Geohex value

    type GeoPolygonQueryBuilder() =
        member _.Yield(_: unit) : Types.GeoPolygonQuery =
            {
                ValidationMethod = None
                IgnoreUnmapped = None
            }

        [<CustomOperation("validationMethod")>]
        member _.ValidationMethod(state: Types.GeoPolygonQuery, value: Types.GeoValidationMethod) =
            { state with ValidationMethod = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.GeoPolygonQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

    let geoPolygonQuery = GeoPolygonQueryBuilder()

    type GeoShapeFieldQueryBuilder() =
        member _.Yield(_: unit) : Types.GeoShapeFieldQuery =
            {
                Shape = None
                IndexedShape = None
                Relation = None
            }

        [<CustomOperation("shape")>]
        member _.Shape(state: Types.GeoShapeFieldQuery, value: Types.GeoShape) =
            { state with Shape = Some value }

        [<CustomOperation("indexedShape")>]
        member _.IndexedShape(state: Types.GeoShapeFieldQuery, value: Types.FieldLookup) =
            { state with IndexedShape = Some value }

        [<CustomOperation("relation")>]
        member _.Relation(state: Types.GeoShapeFieldQuery, value: Types.GeoShapeRelation) =
            { state with Relation = Some value }

    let geoShapeFieldQuery = GeoShapeFieldQueryBuilder()

    type HasChildQueryBuilder() =
        member _.Yield(_: unit) : Types.HasChildQuery =
            {
                IgnoreUnmapped = None
                InnerHits = None
                MaxChildren = None
                MinChildren = None
                Query = Unchecked.defaultof<_>
                ScoreMode = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.HasChildQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: Types.HasChildQuery, value: Types.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("maxChildren")>]
        member _.MaxChildren(state: Types.HasChildQuery, value: Types.Integer) =
            { state with MaxChildren = Some value }

        [<CustomOperation("minChildren")>]
        member _.MinChildren(state: Types.HasChildQuery, value: Types.Integer) =
            { state with MinChildren = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.HasChildQuery, value: Types.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: Types.HasChildQuery, value: Types.ChildScoreMode) =
            { state with ScoreMode = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HasChildQuery, value: Types.RelationName) =
            { state with Type = value }

    let hasChildQuery = HasChildQueryBuilder()

    type HasParentQueryBuilder() =
        member _.Yield(_: unit) : Types.HasParentQuery =
            {
                IgnoreUnmapped = None
                InnerHits = None
                ParentType = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
                Score = None
            }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.HasParentQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: Types.HasParentQuery, value: Types.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("parentType")>]
        member _.ParentType(state: Types.HasParentQuery, value: Types.RelationName) =
            { state with ParentType = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.HasParentQuery, value: Types.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("score")>]
        member _.Score(state: Types.HasParentQuery, value: bool) =
            { state with Score = Some value }

    let hasParentQuery = HasParentQueryBuilder()

    type IntervalsAllOfBuilder() =
        member _.Yield(_: unit) : Types.IntervalsAllOf =
            {
                Intervals = Unchecked.defaultof<_>
                MaxGaps = None
                Ordered = None
                Filter = None
            }

        [<CustomOperation("intervals")>]
        member _.Intervals(state: Types.IntervalsAllOf, value: Types.IntervalsContainer list) =
            { state with Intervals = value }

        [<CustomOperation("maxGaps")>]
        member _.MaxGaps(state: Types.IntervalsAllOf, value: Types.Integer) =
            { state with MaxGaps = Some value }

        [<CustomOperation("ordered")>]
        member _.Ordered(state: Types.IntervalsAllOf, value: bool) =
            { state with Ordered = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.IntervalsAllOf, value: Types.IntervalsFilter) =
            { state with Filter = Some value }

    let intervalsAllOf = IntervalsAllOfBuilder()

    module Intervals =

        let allOf (value: Types.IntervalsAllOf) =
            Types.IntervalsContainer.AllOf value

        let anyOf (value: Types.IntervalsAnyOf) =
            Types.IntervalsContainer.AnyOf value

        let fuzzy (value: Types.IntervalsFuzzy) =
            Types.IntervalsContainer.Fuzzy value

        let match' (value: Types.IntervalsMatch) =
            Types.IntervalsContainer.Match value

        let prefix (value: Types.IntervalsPrefix) =
            Types.IntervalsContainer.Prefix value

        let range (value: Types.IntervalsRange) =
            Types.IntervalsContainer.Range value

        let regexp (value: Types.IntervalsRegexp) =
            Types.IntervalsContainer.Regexp value

        let wildcard (value: Types.IntervalsWildcard) =
            Types.IntervalsContainer.Wildcard value

    module IntervalsFilter =

        let after (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.After value

        let before (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.Before value

        let containedBy (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.ContainedBy value

        let containing (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.Containing value

        let notContainedBy (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.NotContainedBy value

        let notContaining (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.NotContaining value

        let notOverlapping (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.NotOverlapping value

        let overlapping (value: Types.IntervalsContainer) =
            Types.IntervalsFilter.Overlapping value

        let script (value: Types.Script) =
            Types.IntervalsFilter.Script value

    type IntervalsFuzzyBuilder() =
        member _.Yield(_: unit) : Types.IntervalsFuzzy =
            {
                Analyzer = None
                Fuzziness = None
                PrefixLength = None
                Term = Unchecked.defaultof<_>
                Transpositions = None
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IntervalsFuzzy, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.IntervalsFuzzy, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.IntervalsFuzzy, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("term")>]
        member _.Term(state: Types.IntervalsFuzzy, value: string) =
            { state with Term = value }

        [<CustomOperation("transpositions")>]
        member _.Transpositions(state: Types.IntervalsFuzzy, value: bool) =
            { state with Transpositions = Some value }

        [<CustomOperation("useField")>]
        member _.UseField(state: Types.IntervalsFuzzy, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsFuzzy = IntervalsFuzzyBuilder()

    type IntervalsMatchBuilder() =
        member _.Yield(_: unit) : Types.IntervalsMatch =
            {
                Analyzer = None
                MaxGaps = None
                Ordered = None
                Query = Unchecked.defaultof<_>
                UseField = None
                Filter = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IntervalsMatch, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("maxGaps")>]
        member _.MaxGaps(state: Types.IntervalsMatch, value: Types.Integer) =
            { state with MaxGaps = Some value }

        [<CustomOperation("ordered")>]
        member _.Ordered(state: Types.IntervalsMatch, value: bool) =
            { state with Ordered = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.IntervalsMatch, value: string) =
            { state with Query = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: Types.IntervalsMatch, value: Types.Field) =
            { state with UseField = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.IntervalsMatch, value: Types.IntervalsFilter) =
            { state with Filter = Some value }

    let intervalsMatch = IntervalsMatchBuilder()

    type IntervalsPrefixBuilder() =
        member _.Yield(_: unit) : Types.IntervalsPrefix =
            {
                Analyzer = None
                Prefix = Unchecked.defaultof<_>
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IntervalsPrefix, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: Types.IntervalsPrefix, value: string) =
            { state with Prefix = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: Types.IntervalsPrefix, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsPrefix = IntervalsPrefixBuilder()

    module IntervalsQuery =

        let allOf (value: Types.IntervalsAllOf) =
            Types.IntervalsQuery.AllOf value

        let anyOf (value: Types.IntervalsAnyOf) =
            Types.IntervalsQuery.AnyOf value

        let fuzzy (value: Types.IntervalsFuzzy) =
            Types.IntervalsQuery.Fuzzy value

        let match' (value: Types.IntervalsMatch) =
            Types.IntervalsQuery.Match value

        let prefix (value: Types.IntervalsPrefix) =
            Types.IntervalsQuery.Prefix value

        let range (value: Types.IntervalsRange) =
            Types.IntervalsQuery.Range value

        let regexp (value: Types.IntervalsRegexp) =
            Types.IntervalsQuery.Regexp value

        let wildcard (value: Types.IntervalsWildcard) =
            Types.IntervalsQuery.Wildcard value

    type IntervalsRangeBuilder() =
        member _.Yield(_: unit) : Types.IntervalsRange =
            {
                Analyzer = None
                Gte = None
                Gt = None
                Lte = None
                Lt = None
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IntervalsRange, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("gte")>]
        member _.Gte(state: Types.IntervalsRange, value: string) =
            { state with Gte = Some value }

        [<CustomOperation("gt")>]
        member _.Gt(state: Types.IntervalsRange, value: string) =
            { state with Gt = Some value }

        [<CustomOperation("lte")>]
        member _.Lte(state: Types.IntervalsRange, value: string) =
            { state with Lte = Some value }

        [<CustomOperation("lt")>]
        member _.Lt(state: Types.IntervalsRange, value: string) =
            { state with Lt = Some value }

        [<CustomOperation("useField")>]
        member _.UseField(state: Types.IntervalsRange, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsRange = IntervalsRangeBuilder()

    type IntervalsRegexpBuilder() =
        member _.Yield(_: unit) : Types.IntervalsRegexp =
            {
                Analyzer = None
                Pattern = Unchecked.defaultof<_>
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IntervalsRegexp, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.IntervalsRegexp, value: string) =
            { state with Pattern = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: Types.IntervalsRegexp, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsRegexp = IntervalsRegexpBuilder()

    type IntervalsWildcardBuilder() =
        member _.Yield(_: unit) : Types.IntervalsWildcard =
            {
                Analyzer = None
                Pattern = Unchecked.defaultof<_>
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IntervalsWildcard, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.IntervalsWildcard, value: string) =
            { state with Pattern = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: Types.IntervalsWildcard, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsWildcard = IntervalsWildcardBuilder()

    type LikeDocumentBuilder() =
        member _.Yield(_: unit) : Types.LikeDocument =
            {
                Doc = None
                Fields = None
                Id = None
                Index = None
                PerFieldAnalyzer = None
                Routing = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("doc")>]
        member _.Doc(state: Types.LikeDocument, value: System.Text.Json.JsonElement) =
            { state with Doc = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.LikeDocument, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.LikeDocument, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.LikeDocument, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("perFieldAnalyzer")>]
        member _.PerFieldAnalyzer(state: Types.LikeDocument, value: Map<Types.Field, string>) =
            { state with PerFieldAnalyzer = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.LikeDocument, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.LikeDocument, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.LikeDocument, value: Types.VersionType) =
            { state with VersionType = Some value }

    let likeDocument = LikeDocumentBuilder()

    type MatchBoolPrefixQueryBuilder() =
        member _.Yield(_: unit) : Types.MatchBoolPrefixQuery =
            {
                Analyzer = None
                Fuzziness = None
                FuzzyRewrite = None
                FuzzyTranspositions = None
                MaxExpansions = None
                MinimumShouldMatch = None
                Operator = None
                PrefixLength = None
                Query = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.MatchBoolPrefixQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.MatchBoolPrefixQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: Types.MatchBoolPrefixQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: Types.MatchBoolPrefixQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: Types.MatchBoolPrefixQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.MatchBoolPrefixQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: Types.MatchBoolPrefixQuery, value: Types.Operator) =
            { state with Operator = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.MatchBoolPrefixQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.MatchBoolPrefixQuery, value: string) =
            { state with Query = value }

    let matchBoolPrefixQuery = MatchBoolPrefixQueryBuilder()

    let ofQuery (value: string) : Types.MatchBoolPrefixQuery =
        {
            Analyzer = None
            Fuzziness = None
            FuzzyRewrite = None
            FuzzyTranspositions = None
            MaxExpansions = None
            MinimumShouldMatch = None
            Operator = None
            PrefixLength = None
            Query = value
        }

    type MatchPhrasePrefixQueryBuilder() =
        member _.Yield(_: unit) : Types.MatchPhrasePrefixQuery =
            {
                Analyzer = None
                MaxExpansions = None
                Query = Unchecked.defaultof<_>
                Slop = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.MatchPhrasePrefixQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: Types.MatchPhrasePrefixQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.MatchPhrasePrefixQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("slop")>]
        member _.Slop(state: Types.MatchPhrasePrefixQuery, value: Types.Integer) =
            { state with Slop = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: Types.MatchPhrasePrefixQuery, value: Types.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let matchPhrasePrefixQuery = MatchPhrasePrefixQueryBuilder()

    let ofQuery (value: string) : Types.MatchPhrasePrefixQuery =
        {
            Analyzer = None
            MaxExpansions = None
            Query = value
            Slop = None
            ZeroTermsQuery = None
        }

    type MatchPhraseQueryBuilder() =
        member _.Yield(_: unit) : Types.MatchPhraseQuery =
            {
                Analyzer = None
                Query = Unchecked.defaultof<_>
                Slop = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.MatchPhraseQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.MatchPhraseQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("slop")>]
        member _.Slop(state: Types.MatchPhraseQuery, value: Types.Integer) =
            { state with Slop = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: Types.MatchPhraseQuery, value: Types.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let matchPhraseQuery = MatchPhraseQueryBuilder()

    let ofQuery (value: string) : Types.MatchPhraseQuery =
        {
            Analyzer = None
            Query = value
            Slop = None
            ZeroTermsQuery = None
        }

    type MatchQueryBuilder() =
        member _.Yield(_: unit) : Types.MatchQuery =
            {
                Analyzer = None
                AutoGenerateSynonymsPhraseQuery = None
                CutoffFrequency = None
                Fuzziness = None
                FuzzyRewrite = None
                FuzzyTranspositions = None
                Lenient = None
                MaxExpansions = None
                MinimumShouldMatch = None
                Operator = None
                PrefixLength = None
                Query = Unchecked.defaultof<_>
                ZeroTermsQuery = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.MatchQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: Types.MatchQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("cutoffFrequency")>]
        member _.CutoffFrequency(state: Types.MatchQuery, value: Types.Double) =
            { state with CutoffFrequency = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.MatchQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: Types.MatchQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: Types.MatchQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: Types.MatchQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: Types.MatchQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.MatchQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: Types.MatchQuery, value: Types.Operator) =
            { state with Operator = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.MatchQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.MatchQuery, value: System.Text.Json.JsonElement) =
            { state with Query = value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: Types.MatchQuery, value: Types.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let matchQuery = MatchQueryBuilder()

    let ofQuery (value: System.Text.Json.JsonElement) : Types.MatchQuery =
        {
            Analyzer = None
            AutoGenerateSynonymsPhraseQuery = None
            CutoffFrequency = None
            Fuzziness = None
            FuzzyRewrite = None
            FuzzyTranspositions = None
            Lenient = None
            MaxExpansions = None
            MinimumShouldMatch = None
            Operator = None
            PrefixLength = None
            Query = value
            ZeroTermsQuery = None
        }

    type MoreLikeThisQueryBuilder() =
        member _.Yield(_: unit) : Types.MoreLikeThisQuery =
            {
                Analyzer = None
                BoostTerms = None
                FailOnUnsupportedField = None
                Fields = None
                Include = None
                Like = Unchecked.defaultof<_>
                MaxDocFreq = None
                MaxQueryTerms = None
                MaxWordLength = None
                MinDocFreq = None
                MinimumShouldMatch = None
                MinTermFreq = None
                MinWordLength = None
                Routing = None
                StopWords = None
                Unlike = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.MoreLikeThisQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("boostTerms")>]
        member _.BoostTerms(state: Types.MoreLikeThisQuery, value: Types.Double) =
            { state with BoostTerms = Some value }

        [<CustomOperation("failOnUnsupportedField")>]
        member _.FailOnUnsupportedField(state: Types.MoreLikeThisQuery, value: bool) =
            { state with FailOnUnsupportedField = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.MoreLikeThisQuery, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.MoreLikeThisQuery, value: bool) =
            { state with Include = Some value }

        [<CustomOperation("like")>]
        member _.Like(state: Types.MoreLikeThisQuery, value: System.Text.Json.JsonElement) =
            { state with Like = value }

        [<CustomOperation("maxDocFreq")>]
        member _.MaxDocFreq(state: Types.MoreLikeThisQuery, value: Types.Integer) =
            { state with MaxDocFreq = Some value }

        [<CustomOperation("maxQueryTerms")>]
        member _.MaxQueryTerms(state: Types.MoreLikeThisQuery, value: Types.Integer) =
            { state with MaxQueryTerms = Some value }

        [<CustomOperation("maxWordLength")>]
        member _.MaxWordLength(state: Types.MoreLikeThisQuery, value: Types.Integer) =
            { state with MaxWordLength = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: Types.MoreLikeThisQuery, value: Types.Integer) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.MoreLikeThisQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("minTermFreq")>]
        member _.MinTermFreq(state: Types.MoreLikeThisQuery, value: Types.Integer) =
            { state with MinTermFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: Types.MoreLikeThisQuery, value: Types.Integer) =
            { state with MinWordLength = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.MoreLikeThisQuery, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("stopWords")>]
        member _.StopWords(state: Types.MoreLikeThisQuery, value: Types.StopWords) =
            { state with StopWords = Some value }

        [<CustomOperation("unlike")>]
        member _.Unlike(state: Types.MoreLikeThisQuery, value: System.Text.Json.JsonElement) =
            { state with Unlike = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.MoreLikeThisQuery, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.MoreLikeThisQuery, value: Types.VersionType) =
            { state with VersionType = Some value }

    let moreLikeThisQuery = MoreLikeThisQueryBuilder()

    type MultiMatchQueryBuilder() =
        member _.Yield(_: unit) : Types.MultiMatchQuery =
            {
                Analyzer = None
                AutoGenerateSynonymsPhraseQuery = None
                CutoffFrequency = None
                Fields = None
                Fuzziness = None
                FuzzyRewrite = None
                FuzzyTranspositions = None
                Lenient = None
                MaxExpansions = None
                MinimumShouldMatch = None
                Operator = None
                PrefixLength = None
                Query = Unchecked.defaultof<_>
                Slop = None
                TieBreaker = None
                Type = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.MultiMatchQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: Types.MultiMatchQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("cutoffFrequency")>]
        member _.CutoffFrequency(state: Types.MultiMatchQuery, value: Types.Double) =
            { state with CutoffFrequency = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.MultiMatchQuery, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.MultiMatchQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: Types.MultiMatchQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: Types.MultiMatchQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: Types.MultiMatchQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: Types.MultiMatchQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.MultiMatchQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: Types.MultiMatchQuery, value: Types.Operator) =
            { state with Operator = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.MultiMatchQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.MultiMatchQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("slop")>]
        member _.Slop(state: Types.MultiMatchQuery, value: Types.Integer) =
            { state with Slop = Some value }

        [<CustomOperation("tieBreaker")>]
        member _.TieBreaker(state: Types.MultiMatchQuery, value: Types.Double) =
            { state with TieBreaker = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.MultiMatchQuery, value: Types.TextQueryType) =
            { state with Type = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: Types.MultiMatchQuery, value: Types.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let multiMatchQuery = MultiMatchQueryBuilder()

    type NestedQueryBuilder() =
        member _.Yield(_: unit) : Types.NestedQuery =
            {
                IgnoreUnmapped = None
                InnerHits = None
                Path = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
                ScoreMode = None
            }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.NestedQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: Types.NestedQuery, value: Types.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.NestedQuery, value: Types.Field) =
            { state with Path = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.NestedQuery, value: Types.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: Types.NestedQuery, value: Types.ChildScoreMode) =
            { state with ScoreMode = Some value }

    let nestedQuery = NestedQueryBuilder()

    type ParentIdQueryBuilder() =
        member _.Yield(_: unit) : Types.ParentIdQuery =
            {
                Id = None
                IgnoreUnmapped = None
                Type = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ParentIdQuery, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.ParentIdQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ParentIdQuery, value: Types.RelationName) =
            { state with Type = Some value }

    let parentIdQuery = ParentIdQueryBuilder()

    type PercolateQueryBuilder() =
        member _.Yield(_: unit) : Types.PercolateQuery =
            {
                Document = None
                Documents = None
                Field = Unchecked.defaultof<_>
                Id = None
                Index = None
                Name = None
                Preference = None
                Routing = None
                Version = None
            }

        [<CustomOperation("document")>]
        member _.Document(state: Types.PercolateQuery, value: System.Text.Json.JsonElement) =
            { state with Document = Some value }

        [<CustomOperation("documents")>]
        member _.Documents(state: Types.PercolateQuery, value: System.Text.Json.JsonElement list) =
            { state with Documents = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.PercolateQuery, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.PercolateQuery, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.PercolateQuery, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.PercolateQuery, value: string) =
            { state with Name = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: Types.PercolateQuery, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.PercolateQuery, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.PercolateQuery, value: Types.VersionNumber) =
            { state with Version = Some value }

    let percolateQuery = PercolateQueryBuilder()

    module PinnedQuery =

        let ids (value: Types.Id list) =
            Types.PinnedQuery.Ids value

        let docs (value: Types.PinnedDoc list) =
            Types.PinnedQuery.Docs value

    type PrefixQueryBuilder() =
        member _.Yield(_: unit) : Types.PrefixQuery =
            {
                Rewrite = None
                Value = Unchecked.defaultof<_>
                CaseInsensitive = None
            }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: Types.PrefixQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.PrefixQuery, value: string) =
            { state with Value = value }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: Types.PrefixQuery, value: bool) =
            { state with CaseInsensitive = Some value }

    let prefixQuery = PrefixQueryBuilder()

    let ofValue (value: string) : Types.PrefixQuery =
        {
            Rewrite = None
            Value = value
            CaseInsensitive = None
        }

    type QueryBaseBuilder() =
        member _.Yield(_: unit) : Types.QueryBase =
            {
                Boost = None
                Name = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.QueryBase, value: Types.Float) =
            { state with Boost = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.QueryBase, value: string) =
            { state with Name = Some value }

    let queryBase = QueryBaseBuilder()

    module Query =

        let bool (value: Types.BoolQuery) =
            Types.QueryContainer.Bool value

        let boosting (value: Types.BoostingQuery) =
            Types.QueryContainer.Boosting value

        let common (field: string) (value: Types.CommonTermsQuery) =
            Types.QueryContainer.Common (field, value)

        let combinedFields (value: Types.CombinedFieldsQuery) =
            Types.QueryContainer.CombinedFields value

        let constantScore (value: Types.ConstantScoreQuery) =
            Types.QueryContainer.ConstantScore value

        let disMax (value: Types.DisMaxQuery) =
            Types.QueryContainer.DisMax value

        let distanceFeature (value: Types.DistanceFeatureQuery) =
            Types.QueryContainer.DistanceFeature value

        let exists (value: Types.ExistsQuery) =
            Types.QueryContainer.Exists value

        let functionScore (value: Types.FunctionScoreQuery) =
            Types.QueryContainer.FunctionScore value

        let fuzzy (field: string) (value: Types.FuzzyQuery) =
            Types.QueryContainer.Fuzzy (field, value)

        let geoBoundingBox (value: Types.GeoBoundingBoxQuery) =
            Types.QueryContainer.GeoBoundingBox value

        let geoDistance (value: Types.GeoDistanceQuery) =
            Types.QueryContainer.GeoDistance value

        let geoGrid (field: string) (value: Types.GeoGridQuery) =
            Types.QueryContainer.GeoGrid (field, value)

        let geoPolygon (value: Types.GeoPolygonQuery) =
            Types.QueryContainer.GeoPolygon value

        let geoShape (value: Types.GeoShapeQuery) =
            Types.QueryContainer.GeoShape value

        let hasChild (value: Types.HasChildQuery) =
            Types.QueryContainer.HasChild value

        let hasParent (value: Types.HasParentQuery) =
            Types.QueryContainer.HasParent value

        let ids (value: Types.IdsQuery) =
            Types.QueryContainer.Ids value

        let intervals (field: string) (value: Types.IntervalsQuery) =
            Types.QueryContainer.Intervals (field, value)

        let knn (value: Types.KnnQuery) =
            Types.QueryContainer.Knn value

        let match' (field: string) (value: Types.MatchQuery) =
            Types.QueryContainer.Match (field, value)

        let matchAll (value: Types.MatchAllQuery) =
            Types.QueryContainer.MatchAll value

        let matchBoolPrefix (field: string) (value: Types.MatchBoolPrefixQuery) =
            Types.QueryContainer.MatchBoolPrefix (field, value)

        let matchNone (value: Types.MatchNoneQuery) =
            Types.QueryContainer.MatchNone value

        let matchPhrase (field: string) (value: Types.MatchPhraseQuery) =
            Types.QueryContainer.MatchPhrase (field, value)

        let matchPhrasePrefix (field: string) (value: Types.MatchPhrasePrefixQuery) =
            Types.QueryContainer.MatchPhrasePrefix (field, value)

        let moreLikeThis (value: Types.MoreLikeThisQuery) =
            Types.QueryContainer.MoreLikeThis value

        let multiMatch (value: Types.MultiMatchQuery) =
            Types.QueryContainer.MultiMatch value

        let nested (value: Types.NestedQuery) =
            Types.QueryContainer.Nested value

        let parentId (value: Types.ParentIdQuery) =
            Types.QueryContainer.ParentId value

        let percolate (value: Types.PercolateQuery) =
            Types.QueryContainer.Percolate value

        let pinned (value: Types.PinnedQuery) =
            Types.QueryContainer.Pinned value

        let prefix (field: string) (value: Types.PrefixQuery) =
            Types.QueryContainer.Prefix (field, value)

        let queryString (value: Types.QueryStringQuery) =
            Types.QueryContainer.QueryString value

        let range (field: string) (value: Types.RangeQuery) =
            Types.QueryContainer.Range (field, value)

        let rankFeature (value: Types.RankFeatureQuery) =
            Types.QueryContainer.RankFeature value

        let regexp (field: string) (value: Types.RegexpQuery) =
            Types.QueryContainer.Regexp (field, value)

        let rule (value: Types.RuleQuery) =
            Types.QueryContainer.Rule value

        let script (value: Types.ScriptQuery) =
            Types.QueryContainer.Script value

        let scriptScore (value: Types.ScriptScoreQuery) =
            Types.QueryContainer.ScriptScore value

        let semantic (value: Types.SemanticQuery) =
            Types.QueryContainer.Semantic value

        let shape (value: Types.ShapeQuery) =
            Types.QueryContainer.Shape value

        let simpleQueryString (value: Types.SimpleQueryStringQuery) =
            Types.QueryContainer.SimpleQueryString value

        let spanContaining (value: Types.SpanContainingQuery) =
            Types.QueryContainer.SpanContaining value

        let spanFieldMasking (value: Types.SpanFieldMaskingQuery) =
            Types.QueryContainer.SpanFieldMasking value

        let spanFirst (value: Types.SpanFirstQuery) =
            Types.QueryContainer.SpanFirst value

        let spanMulti (value: Types.SpanMultiTermQuery) =
            Types.QueryContainer.SpanMulti value

        let spanNear (value: Types.SpanNearQuery) =
            Types.QueryContainer.SpanNear value

        let spanNot (value: Types.SpanNotQuery) =
            Types.QueryContainer.SpanNot value

        let spanOr (value: Types.SpanOrQuery) =
            Types.QueryContainer.SpanOr value

        let spanTerm (field: string) (value: Types.SpanTermQuery) =
            Types.QueryContainer.SpanTerm (field, value)

        let spanWithin (value: Types.SpanWithinQuery) =
            Types.QueryContainer.SpanWithin value

        let sparseVector (value: Types.SparseVectorQuery) =
            Types.QueryContainer.SparseVector value

        let term (field: string) (value: Types.TermQuery) =
            Types.QueryContainer.Term (field, value)

        let terms (value: Types.TermsQuery) =
            Types.QueryContainer.Terms value

        let termsSet (field: string) (value: Types.TermsSetQuery) =
            Types.QueryContainer.TermsSet (field, value)

        let textExpansion (field: string) (value: Types.TextExpansionQuery) =
            Types.QueryContainer.TextExpansion (field, value)

        let weightedTokens (field: string) (value: Types.WeightedTokensQuery) =
            Types.QueryContainer.WeightedTokens (field, value)

        let wildcard (field: string) (value: Types.WildcardQuery) =
            Types.QueryContainer.Wildcard (field, value)

        let wrapper (value: Types.WrapperQuery) =
            Types.QueryContainer.Wrapper value

        let type' (value: Types.TypeQuery) =
            Types.QueryContainer.Type value

    type QueryStringQueryBuilder() =
        member _.Yield(_: unit) : Types.QueryStringQuery =
            {
                AllowLeadingWildcard = None
                Analyzer = None
                AnalyzeWildcard = None
                AutoGenerateSynonymsPhraseQuery = None
                DefaultField = None
                DefaultOperator = None
                EnablePositionIncrements = None
                Escape = None
                Fields = None
                Fuzziness = None
                FuzzyMaxExpansions = None
                FuzzyPrefixLength = None
                FuzzyRewrite = None
                FuzzyTranspositions = None
                Lenient = None
                MaxDeterminizedStates = None
                MinimumShouldMatch = None
                PhraseSlop = None
                Query = Unchecked.defaultof<_>
                QuoteAnalyzer = None
                QuoteFieldSuffix = None
                Rewrite = None
                TieBreaker = None
                TimeZone = None
                Type = None
            }

        [<CustomOperation("allowLeadingWildcard")>]
        member _.AllowLeadingWildcard(state: Types.QueryStringQuery, value: bool) =
            { state with AllowLeadingWildcard = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.QueryStringQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: Types.QueryStringQuery, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: Types.QueryStringQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("defaultField")>]
        member _.DefaultField(state: Types.QueryStringQuery, value: Types.Field) =
            { state with DefaultField = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: Types.QueryStringQuery, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("enablePositionIncrements")>]
        member _.EnablePositionIncrements(state: Types.QueryStringQuery, value: bool) =
            { state with EnablePositionIncrements = Some value }

        [<CustomOperation("escape")>]
        member _.Escape(state: Types.QueryStringQuery, value: bool) =
            { state with Escape = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.QueryStringQuery, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.QueryStringQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyMaxExpansions")>]
        member _.FuzzyMaxExpansions(state: Types.QueryStringQuery, value: Types.Integer) =
            { state with FuzzyMaxExpansions = Some value }

        [<CustomOperation("fuzzyPrefixLength")>]
        member _.FuzzyPrefixLength(state: Types.QueryStringQuery, value: Types.Integer) =
            { state with FuzzyPrefixLength = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: Types.QueryStringQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: Types.QueryStringQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: Types.QueryStringQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxDeterminizedStates")>]
        member _.MaxDeterminizedStates(state: Types.QueryStringQuery, value: Types.Integer) =
            { state with MaxDeterminizedStates = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.QueryStringQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("phraseSlop")>]
        member _.PhraseSlop(state: Types.QueryStringQuery, value: Types.Double) =
            { state with PhraseSlop = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.QueryStringQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("quoteAnalyzer")>]
        member _.QuoteAnalyzer(state: Types.QueryStringQuery, value: string) =
            { state with QuoteAnalyzer = Some value }

        [<CustomOperation("quoteFieldSuffix")>]
        member _.QuoteFieldSuffix(state: Types.QueryStringQuery, value: string) =
            { state with QuoteFieldSuffix = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: Types.QueryStringQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("tieBreaker")>]
        member _.TieBreaker(state: Types.QueryStringQuery, value: Types.Double) =
            { state with TieBreaker = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.QueryStringQuery, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.QueryStringQuery, value: Types.TextQueryType) =
            { state with Type = Some value }

    let queryStringQuery = QueryStringQueryBuilder()

    type RandomScoreFunctionBuilder() =
        member _.Yield(_: unit) : Types.RandomScoreFunction =
            {
                Field = None
                Seed = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RandomScoreFunction, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("seed")>]
        member _.Seed(state: Types.RandomScoreFunction, value: System.Text.Json.JsonElement) =
            { state with Seed = Some value }

    let randomScoreFunction = RandomScoreFunctionBuilder()

    type RankFeatureQueryBuilder() =
        member _.Yield(_: unit) : Types.RankFeatureQuery =
            {
                Field = Unchecked.defaultof<_>
                Saturation = None
                Log = None
                Linear = None
                Sigmoid = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RankFeatureQuery, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("saturation")>]
        member _.Saturation(state: Types.RankFeatureQuery, value: Types.RankFeatureFunctionSaturation) =
            { state with Saturation = Some value }

        [<CustomOperation("log")>]
        member _.Log(state: Types.RankFeatureQuery, value: Types.RankFeatureFunctionLogarithm) =
            { state with Log = Some value }

        [<CustomOperation("linear")>]
        member _.Linear(state: Types.RankFeatureQuery, value: Types.RankFeatureFunctionLinear) =
            { state with Linear = Some value }

        [<CustomOperation("sigmoid")>]
        member _.Sigmoid(state: Types.RankFeatureQuery, value: Types.RankFeatureFunctionSigmoid) =
            { state with Sigmoid = Some value }

    let rankFeatureQuery = RankFeatureQueryBuilder()

    type RegexpQueryBuilder() =
        member _.Yield(_: unit) : Types.RegexpQuery =
            {
                CaseInsensitive = None
                Flags = None
                MaxDeterminizedStates = None
                Rewrite = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: Types.RegexpQuery, value: bool) =
            { state with CaseInsensitive = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.RegexpQuery, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("maxDeterminizedStates")>]
        member _.MaxDeterminizedStates(state: Types.RegexpQuery, value: Types.Integer) =
            { state with MaxDeterminizedStates = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: Types.RegexpQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.RegexpQuery, value: string) =
            { state with Value = value }

    let regexpQuery = RegexpQueryBuilder()

    let ofValue (value: string) : Types.RegexpQuery =
        {
            CaseInsensitive = None
            Flags = None
            MaxDeterminizedStates = None
            Rewrite = None
            Value = value
        }

    type RuleQueryBuilder() =
        member _.Yield(_: unit) : Types.RuleQuery =
            {
                Organic = Unchecked.defaultof<_>
                RulesetIds = None
                RulesetId = None
                MatchCriteria = Unchecked.defaultof<_>
            }

        [<CustomOperation("organic")>]
        member _.Organic(state: Types.RuleQuery, value: Types.QueryContainer) =
            { state with Organic = value }

        [<CustomOperation("rulesetIds")>]
        member _.RulesetIds(state: Types.RuleQuery, value: System.Text.Json.JsonElement) =
            { state with RulesetIds = Some value }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: Types.RuleQuery, value: string) =
            { state with RulesetId = Some value }

        [<CustomOperation("matchCriteria")>]
        member _.MatchCriteria(state: Types.RuleQuery, value: System.Text.Json.JsonElement) =
            { state with MatchCriteria = value }

    let ruleQuery = RuleQueryBuilder()

    type ShapeFieldQueryBuilder() =
        member _.Yield(_: unit) : Types.ShapeFieldQuery =
            {
                IndexedShape = None
                Relation = None
                Shape = None
            }

        [<CustomOperation("indexedShape")>]
        member _.IndexedShape(state: Types.ShapeFieldQuery, value: Types.FieldLookup) =
            { state with IndexedShape = Some value }

        [<CustomOperation("relation")>]
        member _.Relation(state: Types.ShapeFieldQuery, value: Types.GeoShapeRelation) =
            { state with Relation = Some value }

        [<CustomOperation("shape")>]
        member _.Shape(state: Types.ShapeFieldQuery, value: Types.GeoShape) =
            { state with Shape = Some value }

    let shapeFieldQuery = ShapeFieldQueryBuilder()

    type SimpleQueryStringQueryBuilder() =
        member _.Yield(_: unit) : Types.SimpleQueryStringQuery =
            {
                Analyzer = None
                AnalyzeWildcard = None
                AutoGenerateSynonymsPhraseQuery = None
                DefaultOperator = None
                Fields = None
                Flags = None
                FuzzyMaxExpansions = None
                FuzzyPrefixLength = None
                FuzzyTranspositions = None
                Lenient = None
                MinimumShouldMatch = None
                Query = Unchecked.defaultof<_>
                QuoteFieldSuffix = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.SimpleQueryStringQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: Types.SimpleQueryStringQuery, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: Types.SimpleQueryStringQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: Types.SimpleQueryStringQuery, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.SimpleQueryStringQuery, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.SimpleQueryStringQuery, value: Types.SimpleQueryStringFlags) =
            { state with Flags = Some value }

        [<CustomOperation("fuzzyMaxExpansions")>]
        member _.FuzzyMaxExpansions(state: Types.SimpleQueryStringQuery, value: Types.Integer) =
            { state with FuzzyMaxExpansions = Some value }

        [<CustomOperation("fuzzyPrefixLength")>]
        member _.FuzzyPrefixLength(state: Types.SimpleQueryStringQuery, value: Types.Integer) =
            { state with FuzzyPrefixLength = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: Types.SimpleQueryStringQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: Types.SimpleQueryStringQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.SimpleQueryStringQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.SimpleQueryStringQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("quoteFieldSuffix")>]
        member _.QuoteFieldSuffix(state: Types.SimpleQueryStringQuery, value: string) =
            { state with QuoteFieldSuffix = Some value }

    let simpleQueryStringQuery = SimpleQueryStringQueryBuilder()

    type SpanNearQueryBuilder() =
        member _.Yield(_: unit) : Types.SpanNearQuery =
            {
                Clauses = Unchecked.defaultof<_>
                InOrder = None
                Slop = None
            }

        [<CustomOperation("clauses")>]
        member _.Clauses(state: Types.SpanNearQuery, value: Types.SpanQuery list) =
            { state with Clauses = value }

        [<CustomOperation("inOrder")>]
        member _.InOrder(state: Types.SpanNearQuery, value: bool) =
            { state with InOrder = Some value }

        [<CustomOperation("slop")>]
        member _.Slop(state: Types.SpanNearQuery, value: Types.Integer) =
            { state with Slop = Some value }

    let spanNearQuery = SpanNearQueryBuilder()

    type SpanNotQueryBuilder() =
        member _.Yield(_: unit) : Types.SpanNotQuery =
            {
                Dist = None
                Exclude = Unchecked.defaultof<_>
                Include = Unchecked.defaultof<_>
                Post = None
                Pre = None
            }

        [<CustomOperation("dist")>]
        member _.Dist(state: Types.SpanNotQuery, value: Types.Integer) =
            { state with Dist = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.SpanNotQuery, value: Types.SpanQuery) =
            { state with Exclude = value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.SpanNotQuery, value: Types.SpanQuery) =
            { state with Include = value }

        [<CustomOperation("post")>]
        member _.Post(state: Types.SpanNotQuery, value: Types.Integer) =
            { state with Post = Some value }

        [<CustomOperation("pre")>]
        member _.Pre(state: Types.SpanNotQuery, value: Types.Integer) =
            { state with Pre = Some value }

    let spanNotQuery = SpanNotQueryBuilder()

    module SpanQuery =

        let spanContaining (value: Types.SpanContainingQuery) =
            Types.SpanQuery.SpanContaining value

        let spanFieldMasking (value: Types.SpanFieldMaskingQuery) =
            Types.SpanQuery.SpanFieldMasking value

        let spanFirst (value: Types.SpanFirstQuery) =
            Types.SpanQuery.SpanFirst value

        let spanGap (value: Types.SpanGapQuery) =
            Types.SpanQuery.SpanGap value

        let spanMulti (value: Types.SpanMultiTermQuery) =
            Types.SpanQuery.SpanMulti value

        let spanNear (value: Types.SpanNearQuery) =
            Types.SpanQuery.SpanNear value

        let spanNot (value: Types.SpanNotQuery) =
            Types.SpanQuery.SpanNot value

        let spanOr (value: Types.SpanOrQuery) =
            Types.SpanQuery.SpanOr value

        let spanTerm (field: string) (value: Types.SpanTermQuery) =
            Types.SpanQuery.SpanTerm (field, value)

        let spanWithin (value: Types.SpanWithinQuery) =
            Types.SpanQuery.SpanWithin value

    module SparseVectorQuery =

        let queryVector (value: Map<string, Types.Float>) =
            Types.SparseVectorQuery.QueryVector value

        let inferenceId (value: Types.Id) =
            Types.SparseVectorQuery.InferenceId value

    type TermsSetQueryBuilder() =
        member _.Yield(_: unit) : Types.TermsSetQuery =
            {
                MinimumShouldMatch = None
                MinimumShouldMatchField = None
                MinimumShouldMatchScript = None
                Terms = Unchecked.defaultof<_>
            }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: Types.TermsSetQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("minimumShouldMatchField")>]
        member _.MinimumShouldMatchField(state: Types.TermsSetQuery, value: Types.Field) =
            { state with MinimumShouldMatchField = Some value }

        [<CustomOperation("minimumShouldMatchScript")>]
        member _.MinimumShouldMatchScript(state: Types.TermsSetQuery, value: Types.Script) =
            { state with MinimumShouldMatchScript = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Types.TermsSetQuery, value: Types.FieldValue list) =
            { state with Terms = value }

    let termsSetQuery = TermsSetQueryBuilder()

    type UntypedRangeQueryBuilder() =
        member _.Yield(_: unit) : Types.UntypedRangeQuery =
            {
                Format = None
                TimeZone = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.UntypedRangeQuery, value: Types.DateFormat) =
            { state with Format = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.UntypedRangeQuery, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let untypedRangeQuery = UntypedRangeQueryBuilder()

    type WildcardQueryBuilder() =
        member _.Yield(_: unit) : Types.WildcardQuery =
            {
                CaseInsensitive = None
                Rewrite = None
                Value = None
                Wildcard = None
            }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: Types.WildcardQuery, value: bool) =
            { state with CaseInsensitive = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: Types.WildcardQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.WildcardQuery, value: string) =
            { state with Value = Some value }

        [<CustomOperation("wildcard")>]
        member _.Wildcard(state: Types.WildcardQuery, value: string) =
            { state with Wildcard = Some value }

    let wildcardQuery = WildcardQueryBuilder()

    let ofValue (value: string) : Types.WildcardQuery =
        {
            CaseInsensitive = None
            Rewrite = None
            Value = value
            Wildcard = None
        }

