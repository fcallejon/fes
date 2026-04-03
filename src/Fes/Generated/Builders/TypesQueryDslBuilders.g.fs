// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TypesQueryDslBuilders =

    type BoolQueryBuilder() =
        member _.Yield(_: unit) : BoolQuery =
            {
                Filter = None
                MinimumShouldMatch = None
                Must = None
                MustNot = None
                Should = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: BoolQuery, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: BoolQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("must")>]
        member _.Must(state: BoolQuery, value: System.Text.Json.JsonElement) =
            { state with Must = Some value }

        [<CustomOperation("mustNot")>]
        member _.MustNot(state: BoolQuery, value: System.Text.Json.JsonElement) =
            { state with MustNot = Some value }

        [<CustomOperation("should")>]
        member _.Should(state: BoolQuery, value: System.Text.Json.JsonElement) =
            { state with Should = Some value }

    let boolQuery = BoolQueryBuilder()

    type CombinedFieldsQueryBuilder() =
        member _.Yield(_: unit) : CombinedFieldsQuery =
            {
                Fields = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
                AutoGenerateSynonymsPhraseQuery = None
                Operator = None
                MinimumShouldMatch = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: CombinedFieldsQuery, value: Types.Field list) =
            { state with Fields = value }

        [<CustomOperation("query")>]
        member _.Query(state: CombinedFieldsQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: CombinedFieldsQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: CombinedFieldsQuery, value: TypesQueryDsl.CombinedFieldsOperator) =
            { state with Operator = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: CombinedFieldsQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: CombinedFieldsQuery, value: TypesQueryDsl.CombinedFieldsZeroTerms) =
            { state with ZeroTermsQuery = Some value }

    let combinedFieldsQuery = CombinedFieldsQueryBuilder()

    type CommonTermsQueryBuilder() =
        member _.Yield(_: unit) : CommonTermsQuery =
            {
                Analyzer = None
                CutoffFrequency = None
                HighFreqOperator = None
                LowFreqOperator = None
                MinimumShouldMatch = None
                Query = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: CommonTermsQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("cutoffFrequency")>]
        member _.CutoffFrequency(state: CommonTermsQuery, value: Types.Double) =
            { state with CutoffFrequency = Some value }

        [<CustomOperation("highFreqOperator")>]
        member _.HighFreqOperator(state: CommonTermsQuery, value: TypesQueryDsl.Operator) =
            { state with HighFreqOperator = Some value }

        [<CustomOperation("lowFreqOperator")>]
        member _.LowFreqOperator(state: CommonTermsQuery, value: TypesQueryDsl.Operator) =
            { state with LowFreqOperator = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: CommonTermsQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: CommonTermsQuery, value: string) =
            { state with Query = value }

    let commonTermsQuery = CommonTermsQueryBuilder()

    let ofQuery (value: string) : CommonTermsQuery =
        {
            Analyzer = None
            CutoffFrequency = None
            HighFreqOperator = None
            LowFreqOperator = None
            MinimumShouldMatch = None
            Query = value
        }

    type DateRangeQueryBuilder() =
        member _.Yield(_: unit) : DateRangeQuery =
            {
                Format = None
                TimeZone = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: DateRangeQuery, value: Types.DateFormat) =
            { state with Format = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: DateRangeQuery, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let dateRangeQuery = DateRangeQueryBuilder()

    type DecayPlacementBuilder() =
        member _.Yield(_: unit) : DecayPlacement =
            {
                Decay = None
                Offset = None
                Scale = None
                Origin = None
            }

        [<CustomOperation("decay")>]
        member _.Decay(state: DecayPlacement, value: Types.Double) =
            { state with Decay = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: DecayPlacement, value: 'tScale) =
            { state with Offset = Some value }

        [<CustomOperation("scale")>]
        member _.Scale(state: DecayPlacement, value: 'tScale) =
            { state with Scale = Some value }

        [<CustomOperation("origin")>]
        member _.Origin(state: DecayPlacement, value: 'tOrigin) =
            { state with Origin = Some value }

    let decayPlacement = DecayPlacementBuilder()

    type FieldAndFormatBuilder() =
        member _.Yield(_: unit) : FieldAndFormat =
            {
                Field = Unchecked.defaultof<_>
                Format = None
                IncludeUnmapped = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: FieldAndFormat, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("format")>]
        member _.Format(state: FieldAndFormat, value: string) =
            { state with Format = Some value }

        [<CustomOperation("includeUnmapped")>]
        member _.IncludeUnmapped(state: FieldAndFormat, value: bool) =
            { state with IncludeUnmapped = Some value }

    let fieldAndFormat = FieldAndFormatBuilder()

    let ofField (value: Types.Field) : FieldAndFormat =
        {
            Field = value
            Format = None
            IncludeUnmapped = None
        }

    type FieldLookupBuilder() =
        member _.Yield(_: unit) : FieldLookup =
            {
                Id = Unchecked.defaultof<_>
                Index = None
                Path = None
                Routing = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: FieldLookup, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: FieldLookup, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: FieldLookup, value: Types.Field) =
            { state with Path = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: FieldLookup, value: string) =
            { state with Routing = Some value }

    let fieldLookup = FieldLookupBuilder()

    type FieldValueFactorScoreFunctionBuilder() =
        member _.Yield(_: unit) : FieldValueFactorScoreFunction =
            {
                Field = Unchecked.defaultof<_>
                Factor = None
                Missing = None
                Modifier = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: FieldValueFactorScoreFunction, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("factor")>]
        member _.Factor(state: FieldValueFactorScoreFunction, value: Types.Double) =
            { state with Factor = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: FieldValueFactorScoreFunction, value: Types.Double) =
            { state with Missing = Some value }

        [<CustomOperation("modifier")>]
        member _.Modifier(state: FieldValueFactorScoreFunction, value: TypesQueryDsl.FieldValueFactorModifier) =
            { state with Modifier = Some value }

    let fieldValueFactorScoreFunction = FieldValueFactorScoreFunctionBuilder()

    module FunctionScore =

        let exp (value: TypesQueryDsl.DecayFunction) =
            FunctionScoreContainer.Exp value

        let gauss (value: TypesQueryDsl.DecayFunction) =
            FunctionScoreContainer.Gauss value

        let linear (value: TypesQueryDsl.DecayFunction) =
            FunctionScoreContainer.Linear value

        let fieldValueFactor (value: TypesQueryDsl.FieldValueFactorScoreFunction) =
            FunctionScoreContainer.FieldValueFactor value

        let randomScore (value: TypesQueryDsl.RandomScoreFunction) =
            FunctionScoreContainer.RandomScore value

        let scriptScore (value: TypesQueryDsl.ScriptScoreFunction) =
            FunctionScoreContainer.ScriptScore value

    type FunctionScoreQueryBuilder() =
        member _.Yield(_: unit) : FunctionScoreQuery =
            {
                BoostMode = None
                Functions = None
                MaxBoost = None
                MinScore = None
                Query = None
                ScoreMode = None
            }

        [<CustomOperation("boostMode")>]
        member _.BoostMode(state: FunctionScoreQuery, value: TypesQueryDsl.FunctionBoostMode) =
            { state with BoostMode = Some value }

        [<CustomOperation("functions")>]
        member _.Functions(state: FunctionScoreQuery, value: TypesQueryDsl.FunctionScoreContainer list) =
            { state with Functions = Some value }

        [<CustomOperation("maxBoost")>]
        member _.MaxBoost(state: FunctionScoreQuery, value: Types.Double) =
            { state with MaxBoost = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: FunctionScoreQuery, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: FunctionScoreQuery, value: TypesQueryDsl.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: FunctionScoreQuery, value: TypesQueryDsl.FunctionScoreMode) =
            { state with ScoreMode = Some value }

    let functionScoreQuery = FunctionScoreQueryBuilder()

    let ofFunctions (value: TypesQueryDsl.FunctionScoreContainer list) : FunctionScoreQuery =
        {
            BoostMode = None
            Functions = value
            MaxBoost = None
            MinScore = None
            Query = None
            ScoreMode = None
        }

    type FuzzyQueryBuilder() =
        member _.Yield(_: unit) : FuzzyQuery =
            {
                MaxExpansions = None
                PrefixLength = None
                Rewrite = None
                Transpositions = None
                Fuzziness = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: FuzzyQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: FuzzyQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: FuzzyQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("transpositions")>]
        member _.Transpositions(state: FuzzyQuery, value: bool) =
            { state with Transpositions = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: FuzzyQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: FuzzyQuery, value: System.Text.Json.JsonElement) =
            { state with Value = value }

    let fuzzyQuery = FuzzyQueryBuilder()

    let ofValue (value: System.Text.Json.JsonElement) : FuzzyQuery =
        {
            MaxExpansions = None
            PrefixLength = None
            Rewrite = None
            Transpositions = None
            Fuzziness = None
            Value = value
        }

    type GeoBoundingBoxQueryBuilder() =
        member _.Yield(_: unit) : GeoBoundingBoxQuery =
            {
                Type = None
                ValidationMethod = None
                IgnoreUnmapped = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: GeoBoundingBoxQuery, value: TypesQueryDsl.GeoExecution) =
            { state with Type = Some value }

        [<CustomOperation("validationMethod")>]
        member _.ValidationMethod(state: GeoBoundingBoxQuery, value: TypesQueryDsl.GeoValidationMethod) =
            { state with ValidationMethod = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: GeoBoundingBoxQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

    let geoBoundingBoxQuery = GeoBoundingBoxQueryBuilder()

    type GeoDistanceQueryBuilder() =
        member _.Yield(_: unit) : GeoDistanceQuery =
            {
                Distance = Unchecked.defaultof<_>
                DistanceType = None
                ValidationMethod = None
                IgnoreUnmapped = None
            }

        [<CustomOperation("distance")>]
        member _.Distance(state: GeoDistanceQuery, value: Types.Distance) =
            { state with Distance = value }

        [<CustomOperation("distanceType")>]
        member _.DistanceType(state: GeoDistanceQuery, value: Types.GeoDistanceType) =
            { state with DistanceType = Some value }

        [<CustomOperation("validationMethod")>]
        member _.ValidationMethod(state: GeoDistanceQuery, value: TypesQueryDsl.GeoValidationMethod) =
            { state with ValidationMethod = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: GeoDistanceQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

    let geoDistanceQuery = GeoDistanceQueryBuilder()

    module GeoGridQuery =

        let geotile (value: Types.GeoTile) =
            GeoGridQuery.Geotile value

        let geohash (value: Types.GeoHash) =
            GeoGridQuery.Geohash value

        let geohex (value: Types.GeoHexCell) =
            GeoGridQuery.Geohex value

    type GeoPolygonQueryBuilder() =
        member _.Yield(_: unit) : GeoPolygonQuery =
            {
                ValidationMethod = None
                IgnoreUnmapped = None
            }

        [<CustomOperation("validationMethod")>]
        member _.ValidationMethod(state: GeoPolygonQuery, value: TypesQueryDsl.GeoValidationMethod) =
            { state with ValidationMethod = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: GeoPolygonQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

    let geoPolygonQuery = GeoPolygonQueryBuilder()

    type GeoShapeFieldQueryBuilder() =
        member _.Yield(_: unit) : GeoShapeFieldQuery =
            {
                Shape = None
                IndexedShape = None
                Relation = None
            }

        [<CustomOperation("shape")>]
        member _.Shape(state: GeoShapeFieldQuery, value: Types.GeoShape) =
            { state with Shape = Some value }

        [<CustomOperation("indexedShape")>]
        member _.IndexedShape(state: GeoShapeFieldQuery, value: TypesQueryDsl.FieldLookup) =
            { state with IndexedShape = Some value }

        [<CustomOperation("relation")>]
        member _.Relation(state: GeoShapeFieldQuery, value: Types.GeoShapeRelation) =
            { state with Relation = Some value }

    let geoShapeFieldQuery = GeoShapeFieldQueryBuilder()

    type HasChildQueryBuilder() =
        member _.Yield(_: unit) : HasChildQuery =
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
        member _.IgnoreUnmapped(state: HasChildQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: HasChildQuery, value: GlobalSearchTypes.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("maxChildren")>]
        member _.MaxChildren(state: HasChildQuery, value: Types.Integer) =
            { state with MaxChildren = Some value }

        [<CustomOperation("minChildren")>]
        member _.MinChildren(state: HasChildQuery, value: Types.Integer) =
            { state with MinChildren = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: HasChildQuery, value: TypesQueryDsl.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: HasChildQuery, value: TypesQueryDsl.ChildScoreMode) =
            { state with ScoreMode = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: HasChildQuery, value: Types.RelationName) =
            { state with Type = value }

    let hasChildQuery = HasChildQueryBuilder()

    type HasParentQueryBuilder() =
        member _.Yield(_: unit) : HasParentQuery =
            {
                IgnoreUnmapped = None
                InnerHits = None
                ParentType = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
                Score = None
            }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: HasParentQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: HasParentQuery, value: GlobalSearchTypes.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("parentType")>]
        member _.ParentType(state: HasParentQuery, value: Types.RelationName) =
            { state with ParentType = value }

        [<CustomOperation("query")>]
        member _.Query(state: HasParentQuery, value: TypesQueryDsl.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("score")>]
        member _.Score(state: HasParentQuery, value: bool) =
            { state with Score = Some value }

    let hasParentQuery = HasParentQueryBuilder()

    type IntervalsAllOfBuilder() =
        member _.Yield(_: unit) : IntervalsAllOf =
            {
                Intervals = Unchecked.defaultof<_>
                MaxGaps = None
                Ordered = None
                Filter = None
            }

        [<CustomOperation("intervals")>]
        member _.Intervals(state: IntervalsAllOf, value: TypesQueryDsl.IntervalsContainer list) =
            { state with Intervals = value }

        [<CustomOperation("maxGaps")>]
        member _.MaxGaps(state: IntervalsAllOf, value: Types.Integer) =
            { state with MaxGaps = Some value }

        [<CustomOperation("ordered")>]
        member _.Ordered(state: IntervalsAllOf, value: bool) =
            { state with Ordered = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: IntervalsAllOf, value: TypesQueryDsl.IntervalsFilter) =
            { state with Filter = Some value }

    let intervalsAllOf = IntervalsAllOfBuilder()

    module Intervals =

        let allOf (value: TypesQueryDsl.IntervalsAllOf) =
            IntervalsContainer.AllOf value

        let anyOf (value: TypesQueryDsl.IntervalsAnyOf) =
            IntervalsContainer.AnyOf value

        let fuzzy (value: TypesQueryDsl.IntervalsFuzzy) =
            IntervalsContainer.Fuzzy value

        let match' (value: TypesQueryDsl.IntervalsMatch) =
            IntervalsContainer.Match value

        let prefix (value: TypesQueryDsl.IntervalsPrefix) =
            IntervalsContainer.Prefix value

        let range (value: TypesQueryDsl.IntervalsRange) =
            IntervalsContainer.Range value

        let regexp (value: TypesQueryDsl.IntervalsRegexp) =
            IntervalsContainer.Regexp value

        let wildcard (value: TypesQueryDsl.IntervalsWildcard) =
            IntervalsContainer.Wildcard value

    module IntervalsFilter =

        let after (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.After value

        let before (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.Before value

        let containedBy (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.ContainedBy value

        let containing (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.Containing value

        let notContainedBy (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.NotContainedBy value

        let notContaining (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.NotContaining value

        let notOverlapping (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.NotOverlapping value

        let overlapping (value: TypesQueryDsl.IntervalsContainer) =
            IntervalsFilter.Overlapping value

        let script (value: Types.Script) =
            IntervalsFilter.Script value

    type IntervalsFuzzyBuilder() =
        member _.Yield(_: unit) : IntervalsFuzzy =
            {
                Analyzer = None
                Fuzziness = None
                PrefixLength = None
                Term = Unchecked.defaultof<_>
                Transpositions = None
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IntervalsFuzzy, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: IntervalsFuzzy, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: IntervalsFuzzy, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("term")>]
        member _.Term(state: IntervalsFuzzy, value: string) =
            { state with Term = value }

        [<CustomOperation("transpositions")>]
        member _.Transpositions(state: IntervalsFuzzy, value: bool) =
            { state with Transpositions = Some value }

        [<CustomOperation("useField")>]
        member _.UseField(state: IntervalsFuzzy, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsFuzzy = IntervalsFuzzyBuilder()

    type IntervalsMatchBuilder() =
        member _.Yield(_: unit) : IntervalsMatch =
            {
                Analyzer = None
                MaxGaps = None
                Ordered = None
                Query = Unchecked.defaultof<_>
                UseField = None
                Filter = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IntervalsMatch, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("maxGaps")>]
        member _.MaxGaps(state: IntervalsMatch, value: Types.Integer) =
            { state with MaxGaps = Some value }

        [<CustomOperation("ordered")>]
        member _.Ordered(state: IntervalsMatch, value: bool) =
            { state with Ordered = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: IntervalsMatch, value: string) =
            { state with Query = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: IntervalsMatch, value: Types.Field) =
            { state with UseField = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: IntervalsMatch, value: TypesQueryDsl.IntervalsFilter) =
            { state with Filter = Some value }

    let intervalsMatch = IntervalsMatchBuilder()

    type IntervalsPrefixBuilder() =
        member _.Yield(_: unit) : IntervalsPrefix =
            {
                Analyzer = None
                Prefix = Unchecked.defaultof<_>
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IntervalsPrefix, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: IntervalsPrefix, value: string) =
            { state with Prefix = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: IntervalsPrefix, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsPrefix = IntervalsPrefixBuilder()

    module IntervalsQuery =

        let allOf (value: TypesQueryDsl.IntervalsAllOf) =
            IntervalsQuery.AllOf value

        let anyOf (value: TypesQueryDsl.IntervalsAnyOf) =
            IntervalsQuery.AnyOf value

        let fuzzy (value: TypesQueryDsl.IntervalsFuzzy) =
            IntervalsQuery.Fuzzy value

        let match' (value: TypesQueryDsl.IntervalsMatch) =
            IntervalsQuery.Match value

        let prefix (value: TypesQueryDsl.IntervalsPrefix) =
            IntervalsQuery.Prefix value

        let range (value: TypesQueryDsl.IntervalsRange) =
            IntervalsQuery.Range value

        let regexp (value: TypesQueryDsl.IntervalsRegexp) =
            IntervalsQuery.Regexp value

        let wildcard (value: TypesQueryDsl.IntervalsWildcard) =
            IntervalsQuery.Wildcard value

    type IntervalsRangeBuilder() =
        member _.Yield(_: unit) : IntervalsRange =
            {
                Analyzer = None
                Gte = None
                Gt = None
                Lte = None
                Lt = None
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IntervalsRange, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("gte")>]
        member _.Gte(state: IntervalsRange, value: string) =
            { state with Gte = Some value }

        [<CustomOperation("gt")>]
        member _.Gt(state: IntervalsRange, value: string) =
            { state with Gt = Some value }

        [<CustomOperation("lte")>]
        member _.Lte(state: IntervalsRange, value: string) =
            { state with Lte = Some value }

        [<CustomOperation("lt")>]
        member _.Lt(state: IntervalsRange, value: string) =
            { state with Lt = Some value }

        [<CustomOperation("useField")>]
        member _.UseField(state: IntervalsRange, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsRange = IntervalsRangeBuilder()

    type IntervalsRegexpBuilder() =
        member _.Yield(_: unit) : IntervalsRegexp =
            {
                Analyzer = None
                Pattern = Unchecked.defaultof<_>
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IntervalsRegexp, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: IntervalsRegexp, value: string) =
            { state with Pattern = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: IntervalsRegexp, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsRegexp = IntervalsRegexpBuilder()

    type IntervalsWildcardBuilder() =
        member _.Yield(_: unit) : IntervalsWildcard =
            {
                Analyzer = None
                Pattern = Unchecked.defaultof<_>
                UseField = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IntervalsWildcard, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: IntervalsWildcard, value: string) =
            { state with Pattern = value }

        [<CustomOperation("useField")>]
        member _.UseField(state: IntervalsWildcard, value: Types.Field) =
            { state with UseField = Some value }

    let intervalsWildcard = IntervalsWildcardBuilder()

    type LikeDocumentBuilder() =
        member _.Yield(_: unit) : LikeDocument =
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
        member _.Doc(state: LikeDocument, value: System.Text.Json.JsonElement) =
            { state with Doc = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: LikeDocument, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: LikeDocument, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: LikeDocument, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("perFieldAnalyzer")>]
        member _.PerFieldAnalyzer(state: LikeDocument, value: Map<Types.Field, string>) =
            { state with PerFieldAnalyzer = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: LikeDocument, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: LikeDocument, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: LikeDocument, value: Types.VersionType) =
            { state with VersionType = Some value }

    let likeDocument = LikeDocumentBuilder()

    type MatchBoolPrefixQueryBuilder() =
        member _.Yield(_: unit) : MatchBoolPrefixQuery =
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
        member _.Analyzer(state: MatchBoolPrefixQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: MatchBoolPrefixQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: MatchBoolPrefixQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: MatchBoolPrefixQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: MatchBoolPrefixQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: MatchBoolPrefixQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: MatchBoolPrefixQuery, value: TypesQueryDsl.Operator) =
            { state with Operator = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: MatchBoolPrefixQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MatchBoolPrefixQuery, value: string) =
            { state with Query = value }

    let matchBoolPrefixQuery = MatchBoolPrefixQueryBuilder()

    let ofQuery (value: string) : MatchBoolPrefixQuery =
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
        member _.Yield(_: unit) : MatchPhrasePrefixQuery =
            {
                Analyzer = None
                MaxExpansions = None
                Query = Unchecked.defaultof<_>
                Slop = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: MatchPhrasePrefixQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: MatchPhrasePrefixQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MatchPhrasePrefixQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("slop")>]
        member _.Slop(state: MatchPhrasePrefixQuery, value: Types.Integer) =
            { state with Slop = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: MatchPhrasePrefixQuery, value: TypesQueryDsl.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let matchPhrasePrefixQuery = MatchPhrasePrefixQueryBuilder()

    let ofQuery (value: string) : MatchPhrasePrefixQuery =
        {
            Analyzer = None
            MaxExpansions = None
            Query = value
            Slop = None
            ZeroTermsQuery = None
        }

    type MatchPhraseQueryBuilder() =
        member _.Yield(_: unit) : MatchPhraseQuery =
            {
                Analyzer = None
                Query = Unchecked.defaultof<_>
                Slop = None
                ZeroTermsQuery = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: MatchPhraseQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MatchPhraseQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("slop")>]
        member _.Slop(state: MatchPhraseQuery, value: Types.Integer) =
            { state with Slop = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: MatchPhraseQuery, value: TypesQueryDsl.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let matchPhraseQuery = MatchPhraseQueryBuilder()

    let ofQuery (value: string) : MatchPhraseQuery =
        {
            Analyzer = None
            Query = value
            Slop = None
            ZeroTermsQuery = None
        }

    type MatchQueryBuilder() =
        member _.Yield(_: unit) : MatchQuery =
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
        member _.Analyzer(state: MatchQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: MatchQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("cutoffFrequency")>]
        member _.CutoffFrequency(state: MatchQuery, value: Types.Double) =
            { state with CutoffFrequency = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: MatchQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: MatchQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: MatchQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: MatchQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: MatchQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: MatchQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: MatchQuery, value: TypesQueryDsl.Operator) =
            { state with Operator = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: MatchQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MatchQuery, value: System.Text.Json.JsonElement) =
            { state with Query = value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: MatchQuery, value: TypesQueryDsl.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let matchQuery = MatchQueryBuilder()

    let ofQuery (value: System.Text.Json.JsonElement) : MatchQuery =
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
        member _.Yield(_: unit) : MoreLikeThisQuery =
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
        member _.Analyzer(state: MoreLikeThisQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("boostTerms")>]
        member _.BoostTerms(state: MoreLikeThisQuery, value: Types.Double) =
            { state with BoostTerms = Some value }

        [<CustomOperation("failOnUnsupportedField")>]
        member _.FailOnUnsupportedField(state: MoreLikeThisQuery, value: bool) =
            { state with FailOnUnsupportedField = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: MoreLikeThisQuery, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: MoreLikeThisQuery, value: bool) =
            { state with Include = Some value }

        [<CustomOperation("like")>]
        member _.Like(state: MoreLikeThisQuery, value: System.Text.Json.JsonElement) =
            { state with Like = value }

        [<CustomOperation("maxDocFreq")>]
        member _.MaxDocFreq(state: MoreLikeThisQuery, value: Types.Integer) =
            { state with MaxDocFreq = Some value }

        [<CustomOperation("maxQueryTerms")>]
        member _.MaxQueryTerms(state: MoreLikeThisQuery, value: Types.Integer) =
            { state with MaxQueryTerms = Some value }

        [<CustomOperation("maxWordLength")>]
        member _.MaxWordLength(state: MoreLikeThisQuery, value: Types.Integer) =
            { state with MaxWordLength = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: MoreLikeThisQuery, value: Types.Integer) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: MoreLikeThisQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("minTermFreq")>]
        member _.MinTermFreq(state: MoreLikeThisQuery, value: Types.Integer) =
            { state with MinTermFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: MoreLikeThisQuery, value: Types.Integer) =
            { state with MinWordLength = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: MoreLikeThisQuery, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("stopWords")>]
        member _.StopWords(state: MoreLikeThisQuery, value: TypesAnalysis.StopWords) =
            { state with StopWords = Some value }

        [<CustomOperation("unlike")>]
        member _.Unlike(state: MoreLikeThisQuery, value: System.Text.Json.JsonElement) =
            { state with Unlike = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: MoreLikeThisQuery, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: MoreLikeThisQuery, value: Types.VersionType) =
            { state with VersionType = Some value }

    let moreLikeThisQuery = MoreLikeThisQueryBuilder()

    type MultiMatchQueryBuilder() =
        member _.Yield(_: unit) : MultiMatchQuery =
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
        member _.Analyzer(state: MultiMatchQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: MultiMatchQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("cutoffFrequency")>]
        member _.CutoffFrequency(state: MultiMatchQuery, value: Types.Double) =
            { state with CutoffFrequency = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: MultiMatchQuery, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: MultiMatchQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: MultiMatchQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: MultiMatchQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: MultiMatchQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxExpansions")>]
        member _.MaxExpansions(state: MultiMatchQuery, value: Types.Integer) =
            { state with MaxExpansions = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: MultiMatchQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("operator")>]
        member _.Operator(state: MultiMatchQuery, value: TypesQueryDsl.Operator) =
            { state with Operator = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: MultiMatchQuery, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MultiMatchQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("slop")>]
        member _.Slop(state: MultiMatchQuery, value: Types.Integer) =
            { state with Slop = Some value }

        [<CustomOperation("tieBreaker")>]
        member _.TieBreaker(state: MultiMatchQuery, value: Types.Double) =
            { state with TieBreaker = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: MultiMatchQuery, value: TypesQueryDsl.TextQueryType) =
            { state with Type = Some value }

        [<CustomOperation("zeroTermsQuery")>]
        member _.ZeroTermsQuery(state: MultiMatchQuery, value: TypesQueryDsl.ZeroTermsQuery) =
            { state with ZeroTermsQuery = Some value }

    let multiMatchQuery = MultiMatchQueryBuilder()

    type NestedQueryBuilder() =
        member _.Yield(_: unit) : NestedQuery =
            {
                IgnoreUnmapped = None
                InnerHits = None
                Path = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
                ScoreMode = None
            }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: NestedQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: NestedQuery, value: GlobalSearchTypes.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: NestedQuery, value: Types.Field) =
            { state with Path = value }

        [<CustomOperation("query")>]
        member _.Query(state: NestedQuery, value: TypesQueryDsl.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: NestedQuery, value: TypesQueryDsl.ChildScoreMode) =
            { state with ScoreMode = Some value }

    let nestedQuery = NestedQueryBuilder()

    type ParentIdQueryBuilder() =
        member _.Yield(_: unit) : ParentIdQuery =
            {
                Id = None
                IgnoreUnmapped = None
                Type = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ParentIdQuery, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: ParentIdQuery, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ParentIdQuery, value: Types.RelationName) =
            { state with Type = Some value }

    let parentIdQuery = ParentIdQueryBuilder()

    type PercolateQueryBuilder() =
        member _.Yield(_: unit) : PercolateQuery =
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
        member _.Document(state: PercolateQuery, value: System.Text.Json.JsonElement) =
            { state with Document = Some value }

        [<CustomOperation("documents")>]
        member _.Documents(state: PercolateQuery, value: System.Text.Json.JsonElement list) =
            { state with Documents = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: PercolateQuery, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("id")>]
        member _.Id(state: PercolateQuery, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: PercolateQuery, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: PercolateQuery, value: string) =
            { state with Name = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: PercolateQuery, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: PercolateQuery, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: PercolateQuery, value: Types.VersionNumber) =
            { state with Version = Some value }

    let percolateQuery = PercolateQueryBuilder()

    module PinnedQuery =

        let ids (value: Types.Id list) =
            PinnedQuery.Ids value

        let docs (value: TypesQueryDsl.PinnedDoc list) =
            PinnedQuery.Docs value

    type PrefixQueryBuilder() =
        member _.Yield(_: unit) : PrefixQuery =
            {
                Rewrite = None
                Value = Unchecked.defaultof<_>
                CaseInsensitive = None
            }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: PrefixQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: PrefixQuery, value: string) =
            { state with Value = value }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: PrefixQuery, value: bool) =
            { state with CaseInsensitive = Some value }

    let prefixQuery = PrefixQueryBuilder()

    let ofValue (value: string) : PrefixQuery =
        {
            Rewrite = None
            Value = value
            CaseInsensitive = None
        }

    type QueryBaseBuilder() =
        member _.Yield(_: unit) : QueryBase =
            {
                Boost = None
                Name = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: QueryBase, value: Types.Float) =
            { state with Boost = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: QueryBase, value: string) =
            { state with Name = Some value }

    let queryBase = QueryBaseBuilder()

    module Query =

        let bool (value: TypesQueryDsl.BoolQuery) =
            QueryContainer.Bool value

        let boosting (value: TypesQueryDsl.BoostingQuery) =
            QueryContainer.Boosting value

        let common (field: string) (value: TypesQueryDsl.CommonTermsQuery) =
            QueryContainer.Common (field, value)

        let combinedFields (value: TypesQueryDsl.CombinedFieldsQuery) =
            QueryContainer.CombinedFields value

        let constantScore (value: TypesQueryDsl.ConstantScoreQuery) =
            QueryContainer.ConstantScore value

        let disMax (value: TypesQueryDsl.DisMaxQuery) =
            QueryContainer.DisMax value

        let distanceFeature (value: TypesQueryDsl.DistanceFeatureQuery) =
            QueryContainer.DistanceFeature value

        let exists (value: TypesQueryDsl.ExistsQuery) =
            QueryContainer.Exists value

        let functionScore (value: TypesQueryDsl.FunctionScoreQuery) =
            QueryContainer.FunctionScore value

        let fuzzy (field: string) (value: TypesQueryDsl.FuzzyQuery) =
            QueryContainer.Fuzzy (field, value)

        let geoBoundingBox (value: TypesQueryDsl.GeoBoundingBoxQuery) =
            QueryContainer.GeoBoundingBox value

        let geoDistance (value: TypesQueryDsl.GeoDistanceQuery) =
            QueryContainer.GeoDistance value

        let geoGrid (field: string) (value: TypesQueryDsl.GeoGridQuery) =
            QueryContainer.GeoGrid (field, value)

        let geoPolygon (value: TypesQueryDsl.GeoPolygonQuery) =
            QueryContainer.GeoPolygon value

        let geoShape (value: TypesQueryDsl.GeoShapeQuery) =
            QueryContainer.GeoShape value

        let hasChild (value: TypesQueryDsl.HasChildQuery) =
            QueryContainer.HasChild value

        let hasParent (value: TypesQueryDsl.HasParentQuery) =
            QueryContainer.HasParent value

        let ids (value: TypesQueryDsl.IdsQuery) =
            QueryContainer.Ids value

        let intervals (field: string) (value: TypesQueryDsl.IntervalsQuery) =
            QueryContainer.Intervals (field, value)

        let knn (value: Types.KnnQuery) =
            QueryContainer.Knn value

        let match' (field: string) (value: TypesQueryDsl.MatchQuery) =
            QueryContainer.Match (field, value)

        let matchAll (value: TypesQueryDsl.MatchAllQuery) =
            QueryContainer.MatchAll value

        let matchBoolPrefix (field: string) (value: TypesQueryDsl.MatchBoolPrefixQuery) =
            QueryContainer.MatchBoolPrefix (field, value)

        let matchNone (value: TypesQueryDsl.MatchNoneQuery) =
            QueryContainer.MatchNone value

        let matchPhrase (field: string) (value: TypesQueryDsl.MatchPhraseQuery) =
            QueryContainer.MatchPhrase (field, value)

        let matchPhrasePrefix (field: string) (value: TypesQueryDsl.MatchPhrasePrefixQuery) =
            QueryContainer.MatchPhrasePrefix (field, value)

        let moreLikeThis (value: TypesQueryDsl.MoreLikeThisQuery) =
            QueryContainer.MoreLikeThis value

        let multiMatch (value: TypesQueryDsl.MultiMatchQuery) =
            QueryContainer.MultiMatch value

        let nested (value: TypesQueryDsl.NestedQuery) =
            QueryContainer.Nested value

        let parentId (value: TypesQueryDsl.ParentIdQuery) =
            QueryContainer.ParentId value

        let percolate (value: TypesQueryDsl.PercolateQuery) =
            QueryContainer.Percolate value

        let pinned (value: TypesQueryDsl.PinnedQuery) =
            QueryContainer.Pinned value

        let prefix (field: string) (value: TypesQueryDsl.PrefixQuery) =
            QueryContainer.Prefix (field, value)

        let queryString (value: TypesQueryDsl.QueryStringQuery) =
            QueryContainer.QueryString value

        let range (field: string) (value: TypesQueryDsl.RangeQuery) =
            QueryContainer.Range (field, value)

        let rankFeature (value: TypesQueryDsl.RankFeatureQuery) =
            QueryContainer.RankFeature value

        let regexp (field: string) (value: TypesQueryDsl.RegexpQuery) =
            QueryContainer.Regexp (field, value)

        let rule (value: TypesQueryDsl.RuleQuery) =
            QueryContainer.Rule value

        let script (value: TypesQueryDsl.ScriptQuery) =
            QueryContainer.Script value

        let scriptScore (value: TypesQueryDsl.ScriptScoreQuery) =
            QueryContainer.ScriptScore value

        let semantic (value: TypesQueryDsl.SemanticQuery) =
            QueryContainer.Semantic value

        let shape (value: TypesQueryDsl.ShapeQuery) =
            QueryContainer.Shape value

        let simpleQueryString (value: TypesQueryDsl.SimpleQueryStringQuery) =
            QueryContainer.SimpleQueryString value

        let spanContaining (value: TypesQueryDsl.SpanContainingQuery) =
            QueryContainer.SpanContaining value

        let spanFieldMasking (value: TypesQueryDsl.SpanFieldMaskingQuery) =
            QueryContainer.SpanFieldMasking value

        let spanFirst (value: TypesQueryDsl.SpanFirstQuery) =
            QueryContainer.SpanFirst value

        let spanMulti (value: TypesQueryDsl.SpanMultiTermQuery) =
            QueryContainer.SpanMulti value

        let spanNear (value: TypesQueryDsl.SpanNearQuery) =
            QueryContainer.SpanNear value

        let spanNot (value: TypesQueryDsl.SpanNotQuery) =
            QueryContainer.SpanNot value

        let spanOr (value: TypesQueryDsl.SpanOrQuery) =
            QueryContainer.SpanOr value

        let spanTerm (field: string) (value: TypesQueryDsl.SpanTermQuery) =
            QueryContainer.SpanTerm (field, value)

        let spanWithin (value: TypesQueryDsl.SpanWithinQuery) =
            QueryContainer.SpanWithin value

        let sparseVector (value: TypesQueryDsl.SparseVectorQuery) =
            QueryContainer.SparseVector value

        let term (field: string) (value: TypesQueryDsl.TermQuery) =
            QueryContainer.Term (field, value)

        let terms (value: TypesQueryDsl.TermsQuery) =
            QueryContainer.Terms value

        let termsSet (field: string) (value: TypesQueryDsl.TermsSetQuery) =
            QueryContainer.TermsSet (field, value)

        let textExpansion (field: string) (value: TypesQueryDsl.TextExpansionQuery) =
            QueryContainer.TextExpansion (field, value)

        let weightedTokens (field: string) (value: TypesQueryDsl.WeightedTokensQuery) =
            QueryContainer.WeightedTokens (field, value)

        let wildcard (field: string) (value: TypesQueryDsl.WildcardQuery) =
            QueryContainer.Wildcard (field, value)

        let wrapper (value: TypesQueryDsl.WrapperQuery) =
            QueryContainer.Wrapper value

        let type' (value: TypesQueryDsl.TypeQuery) =
            QueryContainer.Type value

    type QueryStringQueryBuilder() =
        member _.Yield(_: unit) : QueryStringQuery =
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
        member _.AllowLeadingWildcard(state: QueryStringQuery, value: bool) =
            { state with AllowLeadingWildcard = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: QueryStringQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: QueryStringQuery, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: QueryStringQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("defaultField")>]
        member _.DefaultField(state: QueryStringQuery, value: Types.Field) =
            { state with DefaultField = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: QueryStringQuery, value: TypesQueryDsl.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("enablePositionIncrements")>]
        member _.EnablePositionIncrements(state: QueryStringQuery, value: bool) =
            { state with EnablePositionIncrements = Some value }

        [<CustomOperation("escape")>]
        member _.Escape(state: QueryStringQuery, value: bool) =
            { state with Escape = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: QueryStringQuery, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: QueryStringQuery, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("fuzzyMaxExpansions")>]
        member _.FuzzyMaxExpansions(state: QueryStringQuery, value: Types.Integer) =
            { state with FuzzyMaxExpansions = Some value }

        [<CustomOperation("fuzzyPrefixLength")>]
        member _.FuzzyPrefixLength(state: QueryStringQuery, value: Types.Integer) =
            { state with FuzzyPrefixLength = Some value }

        [<CustomOperation("fuzzyRewrite")>]
        member _.FuzzyRewrite(state: QueryStringQuery, value: Types.MultiTermQueryRewrite) =
            { state with FuzzyRewrite = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: QueryStringQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: QueryStringQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxDeterminizedStates")>]
        member _.MaxDeterminizedStates(state: QueryStringQuery, value: Types.Integer) =
            { state with MaxDeterminizedStates = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: QueryStringQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("phraseSlop")>]
        member _.PhraseSlop(state: QueryStringQuery, value: Types.Double) =
            { state with PhraseSlop = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: QueryStringQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("quoteAnalyzer")>]
        member _.QuoteAnalyzer(state: QueryStringQuery, value: string) =
            { state with QuoteAnalyzer = Some value }

        [<CustomOperation("quoteFieldSuffix")>]
        member _.QuoteFieldSuffix(state: QueryStringQuery, value: string) =
            { state with QuoteFieldSuffix = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: QueryStringQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("tieBreaker")>]
        member _.TieBreaker(state: QueryStringQuery, value: Types.Double) =
            { state with TieBreaker = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: QueryStringQuery, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: QueryStringQuery, value: TypesQueryDsl.TextQueryType) =
            { state with Type = Some value }

    let queryStringQuery = QueryStringQueryBuilder()

    type RandomScoreFunctionBuilder() =
        member _.Yield(_: unit) : RandomScoreFunction =
            {
                Field = None
                Seed = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: RandomScoreFunction, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("seed")>]
        member _.Seed(state: RandomScoreFunction, value: System.Text.Json.JsonElement) =
            { state with Seed = Some value }

    let randomScoreFunction = RandomScoreFunctionBuilder()

    type RangeQueryBaseBuilder() =
        member _.Yield(_: unit) : RangeQueryBase =
            {
                Relation = None
                Gt = None
                Gte = None
                Lt = None
                Lte = None
            }

        [<CustomOperation("relation")>]
        member _.Relation(state: RangeQueryBase, value: TypesQueryDsl.RangeRelation) =
            { state with Relation = Some value }

        [<CustomOperation("gt")>]
        member _.Gt(state: RangeQueryBase, value: 't) =
            { state with Gt = Some value }

        [<CustomOperation("gte")>]
        member _.Gte(state: RangeQueryBase, value: 't) =
            { state with Gte = Some value }

        [<CustomOperation("lt")>]
        member _.Lt(state: RangeQueryBase, value: 't) =
            { state with Lt = Some value }

        [<CustomOperation("lte")>]
        member _.Lte(state: RangeQueryBase, value: 't) =
            { state with Lte = Some value }

    let rangeQueryBase = RangeQueryBaseBuilder()

    type RankFeatureQueryBuilder() =
        member _.Yield(_: unit) : RankFeatureQuery =
            {
                Field = Unchecked.defaultof<_>
                Saturation = None
                Log = None
                Linear = None
                Sigmoid = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: RankFeatureQuery, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("saturation")>]
        member _.Saturation(state: RankFeatureQuery, value: TypesQueryDsl.RankFeatureFunctionSaturation) =
            { state with Saturation = Some value }

        [<CustomOperation("log")>]
        member _.Log(state: RankFeatureQuery, value: TypesQueryDsl.RankFeatureFunctionLogarithm) =
            { state with Log = Some value }

        [<CustomOperation("linear")>]
        member _.Linear(state: RankFeatureQuery, value: TypesQueryDsl.RankFeatureFunctionLinear) =
            { state with Linear = Some value }

        [<CustomOperation("sigmoid")>]
        member _.Sigmoid(state: RankFeatureQuery, value: TypesQueryDsl.RankFeatureFunctionSigmoid) =
            { state with Sigmoid = Some value }

    let rankFeatureQuery = RankFeatureQueryBuilder()

    type RegexpQueryBuilder() =
        member _.Yield(_: unit) : RegexpQuery =
            {
                CaseInsensitive = None
                Flags = None
                MaxDeterminizedStates = None
                Rewrite = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: RegexpQuery, value: bool) =
            { state with CaseInsensitive = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: RegexpQuery, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("maxDeterminizedStates")>]
        member _.MaxDeterminizedStates(state: RegexpQuery, value: Types.Integer) =
            { state with MaxDeterminizedStates = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: RegexpQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: RegexpQuery, value: string) =
            { state with Value = value }

    let regexpQuery = RegexpQueryBuilder()

    let ofValue (value: string) : RegexpQuery =
        {
            CaseInsensitive = None
            Flags = None
            MaxDeterminizedStates = None
            Rewrite = None
            Value = value
        }

    type RuleQueryBuilder() =
        member _.Yield(_: unit) : RuleQuery =
            {
                Organic = Unchecked.defaultof<_>
                RulesetIds = None
                RulesetId = None
                MatchCriteria = Unchecked.defaultof<_>
            }

        [<CustomOperation("organic")>]
        member _.Organic(state: RuleQuery, value: TypesQueryDsl.QueryContainer) =
            { state with Organic = value }

        [<CustomOperation("rulesetIds")>]
        member _.RulesetIds(state: RuleQuery, value: System.Text.Json.JsonElement) =
            { state with RulesetIds = Some value }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: RuleQuery, value: string) =
            { state with RulesetId = Some value }

        [<CustomOperation("matchCriteria")>]
        member _.MatchCriteria(state: RuleQuery, value: System.Text.Json.JsonElement) =
            { state with MatchCriteria = value }

    let ruleQuery = RuleQueryBuilder()

    type ShapeFieldQueryBuilder() =
        member _.Yield(_: unit) : ShapeFieldQuery =
            {
                IndexedShape = None
                Relation = None
                Shape = None
            }

        [<CustomOperation("indexedShape")>]
        member _.IndexedShape(state: ShapeFieldQuery, value: TypesQueryDsl.FieldLookup) =
            { state with IndexedShape = Some value }

        [<CustomOperation("relation")>]
        member _.Relation(state: ShapeFieldQuery, value: Types.GeoShapeRelation) =
            { state with Relation = Some value }

        [<CustomOperation("shape")>]
        member _.Shape(state: ShapeFieldQuery, value: Types.GeoShape) =
            { state with Shape = Some value }

    let shapeFieldQuery = ShapeFieldQueryBuilder()

    type SimpleQueryStringQueryBuilder() =
        member _.Yield(_: unit) : SimpleQueryStringQuery =
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
        member _.Analyzer(state: SimpleQueryStringQuery, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: SimpleQueryStringQuery, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("autoGenerateSynonymsPhraseQuery")>]
        member _.AutoGenerateSynonymsPhraseQuery(state: SimpleQueryStringQuery, value: bool) =
            { state with AutoGenerateSynonymsPhraseQuery = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: SimpleQueryStringQuery, value: TypesQueryDsl.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SimpleQueryStringQuery, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: SimpleQueryStringQuery, value: TypesQueryDsl.SimpleQueryStringFlags) =
            { state with Flags = Some value }

        [<CustomOperation("fuzzyMaxExpansions")>]
        member _.FuzzyMaxExpansions(state: SimpleQueryStringQuery, value: Types.Integer) =
            { state with FuzzyMaxExpansions = Some value }

        [<CustomOperation("fuzzyPrefixLength")>]
        member _.FuzzyPrefixLength(state: SimpleQueryStringQuery, value: Types.Integer) =
            { state with FuzzyPrefixLength = Some value }

        [<CustomOperation("fuzzyTranspositions")>]
        member _.FuzzyTranspositions(state: SimpleQueryStringQuery, value: bool) =
            { state with FuzzyTranspositions = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: SimpleQueryStringQuery, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: SimpleQueryStringQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SimpleQueryStringQuery, value: string) =
            { state with Query = value }

        [<CustomOperation("quoteFieldSuffix")>]
        member _.QuoteFieldSuffix(state: SimpleQueryStringQuery, value: string) =
            { state with QuoteFieldSuffix = Some value }

    let simpleQueryStringQuery = SimpleQueryStringQueryBuilder()

    type SpanNearQueryBuilder() =
        member _.Yield(_: unit) : SpanNearQuery =
            {
                Clauses = Unchecked.defaultof<_>
                InOrder = None
                Slop = None
            }

        [<CustomOperation("clauses")>]
        member _.Clauses(state: SpanNearQuery, value: TypesQueryDsl.SpanQuery list) =
            { state with Clauses = value }

        [<CustomOperation("inOrder")>]
        member _.InOrder(state: SpanNearQuery, value: bool) =
            { state with InOrder = Some value }

        [<CustomOperation("slop")>]
        member _.Slop(state: SpanNearQuery, value: Types.Integer) =
            { state with Slop = Some value }

    let spanNearQuery = SpanNearQueryBuilder()

    type SpanNotQueryBuilder() =
        member _.Yield(_: unit) : SpanNotQuery =
            {
                Dist = None
                Exclude = Unchecked.defaultof<_>
                Include = Unchecked.defaultof<_>
                Post = None
                Pre = None
            }

        [<CustomOperation("dist")>]
        member _.Dist(state: SpanNotQuery, value: Types.Integer) =
            { state with Dist = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: SpanNotQuery, value: TypesQueryDsl.SpanQuery) =
            { state with Exclude = value }

        [<CustomOperation("include")>]
        member _.Include(state: SpanNotQuery, value: TypesQueryDsl.SpanQuery) =
            { state with Include = value }

        [<CustomOperation("post")>]
        member _.Post(state: SpanNotQuery, value: Types.Integer) =
            { state with Post = Some value }

        [<CustomOperation("pre")>]
        member _.Pre(state: SpanNotQuery, value: Types.Integer) =
            { state with Pre = Some value }

    let spanNotQuery = SpanNotQueryBuilder()

    module SpanQuery =

        let spanContaining (value: TypesQueryDsl.SpanContainingQuery) =
            SpanQuery.SpanContaining value

        let spanFieldMasking (value: TypesQueryDsl.SpanFieldMaskingQuery) =
            SpanQuery.SpanFieldMasking value

        let spanFirst (value: TypesQueryDsl.SpanFirstQuery) =
            SpanQuery.SpanFirst value

        let spanGap (value: TypesQueryDsl.SpanGapQuery) =
            SpanQuery.SpanGap value

        let spanMulti (value: TypesQueryDsl.SpanMultiTermQuery) =
            SpanQuery.SpanMulti value

        let spanNear (value: TypesQueryDsl.SpanNearQuery) =
            SpanQuery.SpanNear value

        let spanNot (value: TypesQueryDsl.SpanNotQuery) =
            SpanQuery.SpanNot value

        let spanOr (value: TypesQueryDsl.SpanOrQuery) =
            SpanQuery.SpanOr value

        let spanTerm (field: string) (value: TypesQueryDsl.SpanTermQuery) =
            SpanQuery.SpanTerm (field, value)

        let spanWithin (value: TypesQueryDsl.SpanWithinQuery) =
            SpanQuery.SpanWithin value

    module SparseVectorQuery =

        let queryVector (value: Map<string, Types.Float>) =
            SparseVectorQuery.QueryVector value

        let inferenceId (value: Types.Id) =
            SparseVectorQuery.InferenceId value

    type TermsSetQueryBuilder() =
        member _.Yield(_: unit) : TermsSetQuery =
            {
                MinimumShouldMatch = None
                MinimumShouldMatchField = None
                MinimumShouldMatchScript = None
                Terms = Unchecked.defaultof<_>
            }

        [<CustomOperation("minimumShouldMatch")>]
        member _.MinimumShouldMatch(state: TermsSetQuery, value: Types.MinimumShouldMatch) =
            { state with MinimumShouldMatch = Some value }

        [<CustomOperation("minimumShouldMatchField")>]
        member _.MinimumShouldMatchField(state: TermsSetQuery, value: Types.Field) =
            { state with MinimumShouldMatchField = Some value }

        [<CustomOperation("minimumShouldMatchScript")>]
        member _.MinimumShouldMatchScript(state: TermsSetQuery, value: Types.Script) =
            { state with MinimumShouldMatchScript = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: TermsSetQuery, value: Types.FieldValue list) =
            { state with Terms = value }

    let termsSetQuery = TermsSetQueryBuilder()

    type UntypedRangeQueryBuilder() =
        member _.Yield(_: unit) : UntypedRangeQuery =
            {
                Format = None
                TimeZone = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: UntypedRangeQuery, value: Types.DateFormat) =
            { state with Format = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: UntypedRangeQuery, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let untypedRangeQuery = UntypedRangeQueryBuilder()

    type WildcardQueryBuilder() =
        member _.Yield(_: unit) : WildcardQuery =
            {
                CaseInsensitive = None
                Rewrite = None
                Value = None
                Wildcard = None
            }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: WildcardQuery, value: bool) =
            { state with CaseInsensitive = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: WildcardQuery, value: Types.MultiTermQueryRewrite) =
            { state with Rewrite = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: WildcardQuery, value: string) =
            { state with Value = Some value }

        [<CustomOperation("wildcard")>]
        member _.Wildcard(state: WildcardQuery, value: string) =
            { state with Wildcard = Some value }

    let wildcardQuery = WildcardQueryBuilder()

    let ofValue (value: string) : WildcardQuery =
        {
            CaseInsensitive = None
            Rewrite = None
            Value = value
            Wildcard = None
        }

