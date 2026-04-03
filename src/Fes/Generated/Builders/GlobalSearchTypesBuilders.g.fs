// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalSearchTypesBuilders =

    type AggregationBreakdownBuilder() =
        member _.Yield(_: unit) : Types.AggregationBreakdown =
            {
                BuildAggregation = Unchecked.defaultof<_>
                BuildAggregationCount = Unchecked.defaultof<_>
                BuildLeafCollector = Unchecked.defaultof<_>
                BuildLeafCollectorCount = Unchecked.defaultof<_>
                Collect = Unchecked.defaultof<_>
                CollectCount = Unchecked.defaultof<_>
                Initialize = Unchecked.defaultof<_>
                InitializeCount = Unchecked.defaultof<_>
                PostCollection = None
                PostCollectionCount = None
                Reduce = Unchecked.defaultof<_>
                ReduceCount = Unchecked.defaultof<_>
            }

        [<CustomOperation("buildAggregation")>]
        member _.BuildAggregation(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with BuildAggregation = value }

        [<CustomOperation("buildAggregationCount")>]
        member _.BuildAggregationCount(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with BuildAggregationCount = value }

        [<CustomOperation("buildLeafCollector")>]
        member _.BuildLeafCollector(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with BuildLeafCollector = value }

        [<CustomOperation("buildLeafCollectorCount")>]
        member _.BuildLeafCollectorCount(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with BuildLeafCollectorCount = value }

        [<CustomOperation("collect")>]
        member _.Collect(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with Collect = value }

        [<CustomOperation("collectCount")>]
        member _.CollectCount(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with CollectCount = value }

        [<CustomOperation("initialize")>]
        member _.Initialize(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with Initialize = value }

        [<CustomOperation("initializeCount")>]
        member _.InitializeCount(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with InitializeCount = value }

        [<CustomOperation("postCollection")>]
        member _.PostCollection(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with PostCollection = Some value }

        [<CustomOperation("postCollectionCount")>]
        member _.PostCollectionCount(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with PostCollectionCount = Some value }

        [<CustomOperation("reduce")>]
        member _.Reduce(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with Reduce = value }

        [<CustomOperation("reduceCount")>]
        member _.ReduceCount(state: Types.AggregationBreakdown, value: Types.Long) =
            { state with ReduceCount = value }

    let aggregationBreakdown = AggregationBreakdownBuilder()

    type AggregationProfileBuilder() =
        member _.Yield(_: unit) : Types.AggregationProfile =
            {
                Breakdown = Unchecked.defaultof<_>
                Description = Unchecked.defaultof<_>
                TimeInNanos = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Debug = None
                Children = None
            }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: Types.AggregationProfile, value: Types.AggregationBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.AggregationProfile, value: string) =
            { state with Description = value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: Types.AggregationProfile, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.AggregationProfile, value: string) =
            { state with Type = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: Types.AggregationProfile, value: Types.AggregationProfileDebug) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: Types.AggregationProfile, value: Types.AggregationProfile list) =
            { state with Children = Some value }

    let aggregationProfile = AggregationProfileBuilder()

    type AggregationProfileDebugBuilder() =
        member _.Yield(_: unit) : Types.AggregationProfileDebug =
            {
                SegmentsWithMultiValuedOrds = None
                CollectionStrategy = None
                SegmentsWithSingleValuedOrds = None
                TotalBuckets = None
                BuiltBuckets = None
                ResultStrategy = None
                HasFilter = None
                Delegate = None
                DelegateDebug = None
                CharsFetched = None
                ExtractCount = None
                ExtractNs = None
                ValuesFetched = None
                CollectAnalyzedNs = None
                CollectAnalyzedCount = None
                SurvivingBuckets = None
                OrdinalsCollectorsUsed = None
                OrdinalsCollectorsOverheadTooHigh = None
                StringHashingCollectorsUsed = None
                NumericCollectorsUsed = None
                EmptyCollectorsUsed = None
                DeferredAggregators = None
                SegmentsWithDocCountField = None
                SegmentsWithDeletedDocs = None
                Filters = None
                SegmentsCounted = None
                SegmentsCollected = None
                MapReducer = None
                BruteForceUsed = None
                DynamicPruningAttempted = None
                DynamicPruningUsed = None
                SkippedDueToNoData = None
            }

        [<CustomOperation("segmentsWithMultiValuedOrds")>]
        member _.SegmentsWithMultiValuedOrds(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithMultiValuedOrds = Some value }

        [<CustomOperation("collectionStrategy")>]
        member _.CollectionStrategy(state: Types.AggregationProfileDebug, value: string) =
            { state with CollectionStrategy = Some value }

        [<CustomOperation("segmentsWithSingleValuedOrds")>]
        member _.SegmentsWithSingleValuedOrds(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithSingleValuedOrds = Some value }

        [<CustomOperation("totalBuckets")>]
        member _.TotalBuckets(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with TotalBuckets = Some value }

        [<CustomOperation("builtBuckets")>]
        member _.BuiltBuckets(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with BuiltBuckets = Some value }

        [<CustomOperation("resultStrategy")>]
        member _.ResultStrategy(state: Types.AggregationProfileDebug, value: string) =
            { state with ResultStrategy = Some value }

        [<CustomOperation("hasFilter")>]
        member _.HasFilter(state: Types.AggregationProfileDebug, value: bool) =
            { state with HasFilter = Some value }

        [<CustomOperation("delegate'")>]
        member _.Delegate(state: Types.AggregationProfileDebug, value: string) =
            { state with Delegate = Some value }

        [<CustomOperation("delegateDebug")>]
        member _.DelegateDebug(state: Types.AggregationProfileDebug, value: Types.AggregationProfileDebug) =
            { state with DelegateDebug = Some value }

        [<CustomOperation("charsFetched")>]
        member _.CharsFetched(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with CharsFetched = Some value }

        [<CustomOperation("extractCount")>]
        member _.ExtractCount(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with ExtractCount = Some value }

        [<CustomOperation("extractNs")>]
        member _.ExtractNs(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with ExtractNs = Some value }

        [<CustomOperation("valuesFetched")>]
        member _.ValuesFetched(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with ValuesFetched = Some value }

        [<CustomOperation("collectAnalyzedNs")>]
        member _.CollectAnalyzedNs(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with CollectAnalyzedNs = Some value }

        [<CustomOperation("collectAnalyzedCount")>]
        member _.CollectAnalyzedCount(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with CollectAnalyzedCount = Some value }

        [<CustomOperation("survivingBuckets")>]
        member _.SurvivingBuckets(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SurvivingBuckets = Some value }

        [<CustomOperation("ordinalsCollectorsUsed")>]
        member _.OrdinalsCollectorsUsed(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with OrdinalsCollectorsUsed = Some value }

        [<CustomOperation("ordinalsCollectorsOverheadTooHigh")>]
        member _.OrdinalsCollectorsOverheadTooHigh(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with OrdinalsCollectorsOverheadTooHigh = Some value }

        [<CustomOperation("stringHashingCollectorsUsed")>]
        member _.StringHashingCollectorsUsed(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with StringHashingCollectorsUsed = Some value }

        [<CustomOperation("numericCollectorsUsed")>]
        member _.NumericCollectorsUsed(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with NumericCollectorsUsed = Some value }

        [<CustomOperation("emptyCollectorsUsed")>]
        member _.EmptyCollectorsUsed(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with EmptyCollectorsUsed = Some value }

        [<CustomOperation("deferredAggregators")>]
        member _.DeferredAggregators(state: Types.AggregationProfileDebug, value: string list) =
            { state with DeferredAggregators = Some value }

        [<CustomOperation("segmentsWithDocCountField")>]
        member _.SegmentsWithDocCountField(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithDocCountField = Some value }

        [<CustomOperation("segmentsWithDeletedDocs")>]
        member _.SegmentsWithDeletedDocs(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithDeletedDocs = Some value }

        [<CustomOperation("filters")>]
        member _.Filters(state: Types.AggregationProfileDebug, value: Types.AggregationProfileDelegateDebugFilter list) =
            { state with Filters = Some value }

        [<CustomOperation("segmentsCounted")>]
        member _.SegmentsCounted(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsCounted = Some value }

        [<CustomOperation("segmentsCollected")>]
        member _.SegmentsCollected(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsCollected = Some value }

        [<CustomOperation("mapReducer")>]
        member _.MapReducer(state: Types.AggregationProfileDebug, value: string) =
            { state with MapReducer = Some value }

        [<CustomOperation("bruteForceUsed")>]
        member _.BruteForceUsed(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with BruteForceUsed = Some value }

        [<CustomOperation("dynamicPruningAttempted")>]
        member _.DynamicPruningAttempted(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with DynamicPruningAttempted = Some value }

        [<CustomOperation("dynamicPruningUsed")>]
        member _.DynamicPruningUsed(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with DynamicPruningUsed = Some value }

        [<CustomOperation("skippedDueToNoData")>]
        member _.SkippedDueToNoData(state: Types.AggregationProfileDebug, value: Types.Integer) =
            { state with SkippedDueToNoData = Some value }

    let aggregationProfileDebug = AggregationProfileDebugBuilder()

    type AggregationProfileDelegateDebugFilterBuilder() =
        member _.Yield(_: unit) : Types.AggregationProfileDelegateDebugFilter =
            {
                ResultsFromMetadata = None
                Query = None
                SpecializedFor = None
                SegmentsCountedInConstantTime = None
            }

        [<CustomOperation("resultsFromMetadata")>]
        member _.ResultsFromMetadata(state: Types.AggregationProfileDelegateDebugFilter, value: Types.Integer) =
            { state with ResultsFromMetadata = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.AggregationProfileDelegateDebugFilter, value: string) =
            { state with Query = Some value }

        [<CustomOperation("specializedFor")>]
        member _.SpecializedFor(state: Types.AggregationProfileDelegateDebugFilter, value: string) =
            { state with SpecializedFor = Some value }

        [<CustomOperation("segmentsCountedInConstantTime")>]
        member _.SegmentsCountedInConstantTime(state: Types.AggregationProfileDelegateDebugFilter, value: Types.Integer) =
            { state with SegmentsCountedInConstantTime = Some value }

    let aggregationProfileDelegateDebugFilter = AggregationProfileDelegateDebugFilterBuilder()

    type CompletionContextBuilder() =
        member _.Yield(_: unit) : Types.CompletionContext =
            {
                Boost = None
                Context = Unchecked.defaultof<_>
                Neighbours = None
                Precision = None
                Prefix = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.CompletionContext, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("context")>]
        member _.Context(state: Types.CompletionContext, value: Types.GlobalSearchTypesContext) =
            { state with Context = value }

        [<CustomOperation("neighbours")>]
        member _.Neighbours(state: Types.CompletionContext, value: Types.GeoHashPrecision list) =
            { state with Neighbours = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.CompletionContext, value: Types.GeoHashPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: Types.CompletionContext, value: bool) =
            { state with Prefix = Some value }

    let completionContext = CompletionContextBuilder()

    let createCompletionContext (value: Types.GlobalSearchTypesContext) : Types.CompletionContext =
        {
            Boost = None
            Context = value
            Neighbours = None
            Precision = None
            Prefix = None
        }

    type CompletionSuggesterBuilder() =
        member _.Yield(_: unit) : Types.CompletionSuggester =
            {
                Contexts = None
                Fuzzy = None
                Regex = None
                SkipDuplicates = None
            }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: Types.CompletionSuggester, value: Map<Types.Field, System.Text.Json.JsonElement>) =
            { state with Contexts = Some value }

        [<CustomOperation("fuzzy")>]
        member _.Fuzzy(state: Types.CompletionSuggester, value: Types.SuggestFuzziness) =
            { state with Fuzzy = Some value }

        [<CustomOperation("regex")>]
        member _.Regex(state: Types.CompletionSuggester, value: Types.RegexOptions) =
            { state with Regex = Some value }

        [<CustomOperation("skipDuplicates")>]
        member _.SkipDuplicates(state: Types.CompletionSuggester, value: bool) =
            { state with SkipDuplicates = Some value }

    let completionSuggester = CompletionSuggesterBuilder()

    type DfsProfileBuilder() =
        member _.Yield(_: unit) : Types.DfsProfile =
            {
                Statistics = None
                Knn = None
            }

        [<CustomOperation("statistics")>]
        member _.Statistics(state: Types.DfsProfile, value: Types.DfsStatisticsProfile) =
            { state with Statistics = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: Types.DfsProfile, value: Types.DfsKnnProfile list) =
            { state with Knn = Some value }

    let dfsProfile = DfsProfileBuilder()

    type DfsStatisticsProfileBuilder() =
        member _.Yield(_: unit) : Types.DfsStatisticsProfile =
            {
                Type = Unchecked.defaultof<_>
                Description = Unchecked.defaultof<_>
                Time = None
                TimeInNanos = Unchecked.defaultof<_>
                Breakdown = Unchecked.defaultof<_>
                Debug = None
                Children = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DfsStatisticsProfile, value: string) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DfsStatisticsProfile, value: string) =
            { state with Description = value }

        [<CustomOperation("time")>]
        member _.Time(state: Types.DfsStatisticsProfile, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: Types.DfsStatisticsProfile, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: Types.DfsStatisticsProfile, value: Types.DfsStatisticsBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: Types.DfsStatisticsProfile, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: Types.DfsStatisticsProfile, value: Types.DfsStatisticsProfile list) =
            { state with Children = Some value }

    let dfsStatisticsProfile = DfsStatisticsProfileBuilder()

    type DirectGeneratorBuilder() =
        member _.Yield(_: unit) : Types.DirectGenerator =
            {
                Field = Unchecked.defaultof<_>
                MaxEdits = None
                MaxInspections = None
                MaxTermFreq = None
                MinDocFreq = None
                MinWordLength = None
                PostFilter = None
                PreFilter = None
                PrefixLength = None
                Size = None
                SuggestMode = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DirectGenerator, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("maxEdits")>]
        member _.MaxEdits(state: Types.DirectGenerator, value: Types.Integer) =
            { state with MaxEdits = Some value }

        [<CustomOperation("maxInspections")>]
        member _.MaxInspections(state: Types.DirectGenerator, value: Types.Float) =
            { state with MaxInspections = Some value }

        [<CustomOperation("maxTermFreq")>]
        member _.MaxTermFreq(state: Types.DirectGenerator, value: Types.Float) =
            { state with MaxTermFreq = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: Types.DirectGenerator, value: Types.Float) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: Types.DirectGenerator, value: Types.Integer) =
            { state with MinWordLength = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: Types.DirectGenerator, value: string) =
            { state with PostFilter = Some value }

        [<CustomOperation("preFilter")>]
        member _.PreFilter(state: Types.DirectGenerator, value: string) =
            { state with PreFilter = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.DirectGenerator, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.DirectGenerator, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: Types.DirectGenerator, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

    let directGenerator = DirectGeneratorBuilder()

    type FetchProfileBuilder() =
        member _.Yield(_: unit) : Types.FetchProfile =
            {
                Type = Unchecked.defaultof<_>
                Description = Unchecked.defaultof<_>
                TimeInNanos = Unchecked.defaultof<_>
                Breakdown = Unchecked.defaultof<_>
                Debug = None
                Children = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FetchProfile, value: string) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.FetchProfile, value: string) =
            { state with Description = value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: Types.FetchProfile, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: Types.FetchProfile, value: Types.FetchProfileBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: Types.FetchProfile, value: Types.FetchProfileDebug) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: Types.FetchProfile, value: Types.FetchProfile list) =
            { state with Children = Some value }

    let fetchProfile = FetchProfileBuilder()

    type FetchProfileBreakdownBuilder() =
        member _.Yield(_: unit) : Types.FetchProfileBreakdown =
            {
                LoadSource = None
                LoadSourceCount = None
                LoadStoredFields = None
                LoadStoredFieldsCount = None
                NextReader = None
                NextReaderCount = None
                ProcessCount = None
                Process = None
            }

        [<CustomOperation("loadSource")>]
        member _.LoadSource(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadSource = Some value }

        [<CustomOperation("loadSourceCount")>]
        member _.LoadSourceCount(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadSourceCount = Some value }

        [<CustomOperation("loadStoredFields")>]
        member _.LoadStoredFields(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadStoredFields = Some value }

        [<CustomOperation("loadStoredFieldsCount")>]
        member _.LoadStoredFieldsCount(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadStoredFieldsCount = Some value }

        [<CustomOperation("nextReader")>]
        member _.NextReader(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with NextReader = Some value }

        [<CustomOperation("nextReaderCount")>]
        member _.NextReaderCount(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with NextReaderCount = Some value }

        [<CustomOperation("processCount")>]
        member _.ProcessCount(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with ProcessCount = Some value }

        [<CustomOperation("process")>]
        member _.Process(state: Types.FetchProfileBreakdown, value: Types.Integer) =
            { state with Process = Some value }

    let fetchProfileBreakdown = FetchProfileBreakdownBuilder()

    type FetchProfileDebugBuilder() =
        member _.Yield(_: unit) : Types.FetchProfileDebug =
            {
                StoredFields = None
                FastPath = None
            }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: Types.FetchProfileDebug, value: string list) =
            { state with StoredFields = Some value }

        [<CustomOperation("fastPath")>]
        member _.FastPath(state: Types.FetchProfileDebug, value: Types.Integer) =
            { state with FastPath = Some value }

    let fetchProfileDebug = FetchProfileDebugBuilder()

    type FieldCollapseBuilder() =
        member _.Yield(_: unit) : Types.FieldCollapse =
            {
                Field = Unchecked.defaultof<_>
                InnerHits = None
                MaxConcurrentGroupSearches = None
                Collapse = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.FieldCollapse, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: Types.FieldCollapse, value: System.Text.Json.JsonElement) =
            { state with InnerHits = Some value }

        [<CustomOperation("maxConcurrentGroupSearches")>]
        member _.MaxConcurrentGroupSearches(state: Types.FieldCollapse, value: Types.Integer) =
            { state with MaxConcurrentGroupSearches = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: Types.FieldCollapse, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

    let fieldCollapse = FieldCollapseBuilder()

    module FieldSuggester =

        let completion (value: Types.CompletionSuggester) =
            Types.FieldSuggester.Completion value

        let phrase (value: Types.PhraseSuggester) =
            Types.FieldSuggester.Phrase value

        let term (value: Types.TermSuggester) =
            Types.FieldSuggester.Term value

    type HighlightBaseBuilder() =
        member _.Yield(_: unit) : Types.HighlightBase =
            {
                Type = None
                BoundaryChars = None
                BoundaryMaxScan = None
                BoundaryScanner = None
                BoundaryScannerLocale = None
                ForceSource = None
                Fragmenter = None
                FragmentSize = None
                HighlightFilter = None
                HighlightQuery = None
                MaxFragmentLength = None
                MaxAnalyzedOffset = None
                NoMatchSize = None
                NumberOfFragments = None
                Options = None
                Order = None
                PhraseLimit = None
                PostTags = None
                PreTags = None
                RequireFieldMatch = None
                TagsSchema = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HighlightBase, value: Types.HighlighterType) =
            { state with Type = Some value }

        [<CustomOperation("boundaryChars")>]
        member _.BoundaryChars(state: Types.HighlightBase, value: string) =
            { state with BoundaryChars = Some value }

        [<CustomOperation("boundaryMaxScan")>]
        member _.BoundaryMaxScan(state: Types.HighlightBase, value: Types.Integer) =
            { state with BoundaryMaxScan = Some value }

        [<CustomOperation("boundaryScanner")>]
        member _.BoundaryScanner(state: Types.HighlightBase, value: Types.BoundaryScanner) =
            { state with BoundaryScanner = Some value }

        [<CustomOperation("boundaryScannerLocale")>]
        member _.BoundaryScannerLocale(state: Types.HighlightBase, value: string) =
            { state with BoundaryScannerLocale = Some value }

        [<CustomOperation("forceSource")>]
        member _.ForceSource(state: Types.HighlightBase, value: bool) =
            { state with ForceSource = Some value }

        [<CustomOperation("fragmenter")>]
        member _.Fragmenter(state: Types.HighlightBase, value: Types.HighlighterFragmenter) =
            { state with Fragmenter = Some value }

        [<CustomOperation("fragmentSize")>]
        member _.FragmentSize(state: Types.HighlightBase, value: Types.Integer) =
            { state with FragmentSize = Some value }

        [<CustomOperation("highlightFilter")>]
        member _.HighlightFilter(state: Types.HighlightBase, value: bool) =
            { state with HighlightFilter = Some value }

        [<CustomOperation("highlightQuery")>]
        member _.HighlightQuery(state: Types.HighlightBase, value: Types.QueryContainer) =
            { state with HighlightQuery = Some value }

        [<CustomOperation("maxFragmentLength")>]
        member _.MaxFragmentLength(state: Types.HighlightBase, value: Types.Integer) =
            { state with MaxFragmentLength = Some value }

        [<CustomOperation("maxAnalyzedOffset")>]
        member _.MaxAnalyzedOffset(state: Types.HighlightBase, value: Types.Integer) =
            { state with MaxAnalyzedOffset = Some value }

        [<CustomOperation("noMatchSize")>]
        member _.NoMatchSize(state: Types.HighlightBase, value: Types.Integer) =
            { state with NoMatchSize = Some value }

        [<CustomOperation("numberOfFragments")>]
        member _.NumberOfFragments(state: Types.HighlightBase, value: Types.Integer) =
            { state with NumberOfFragments = Some value }

        [<CustomOperation("options")>]
        member _.Options(state: Types.HighlightBase, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Options = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.HighlightBase, value: Types.HighlighterOrder) =
            { state with Order = Some value }

        [<CustomOperation("phraseLimit")>]
        member _.PhraseLimit(state: Types.HighlightBase, value: Types.Integer) =
            { state with PhraseLimit = Some value }

        [<CustomOperation("postTags")>]
        member _.PostTags(state: Types.HighlightBase, value: string list) =
            { state with PostTags = Some value }

        [<CustomOperation("preTags")>]
        member _.PreTags(state: Types.HighlightBase, value: string list) =
            { state with PreTags = Some value }

        [<CustomOperation("requireFieldMatch")>]
        member _.RequireFieldMatch(state: Types.HighlightBase, value: bool) =
            { state with RequireFieldMatch = Some value }

        [<CustomOperation("tagsSchema")>]
        member _.TagsSchema(state: Types.HighlightBase, value: Types.HighlighterTagsSchema) =
            { state with TagsSchema = Some value }

    let highlightBase = HighlightBaseBuilder()

    type HighlightFieldBuilder() =
        member _.Yield(_: unit) : Types.HighlightField =
            {
                FragmentOffset = None
                MatchedFields = None
            }

        [<CustomOperation("fragmentOffset")>]
        member _.FragmentOffset(state: Types.HighlightField, value: Types.Integer) =
            { state with FragmentOffset = Some value }

        [<CustomOperation("matchedFields")>]
        member _.MatchedFields(state: Types.HighlightField, value: Types.Fields) =
            { state with MatchedFields = Some value }

    let highlightField = HighlightFieldBuilder()

    type InnerHitsBuilder() =
        member _.Yield(_: unit) : Types.InnerHits =
            {
                Name = None
                Size = None
                From = None
                Collapse = None
                DocvalueFields = None
                Explain = None
                Highlight = None
                IgnoreUnmapped = None
                ScriptFields = None
                SeqNoPrimaryTerm = None
                Fields = None
                Sort = None
                Source = None
                StoredFields = None
                TrackScores = None
                Version = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.InnerHits, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.InnerHits, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.InnerHits, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: Types.InnerHits, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: Types.InnerHits, value: Types.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: Types.InnerHits, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: Types.InnerHits, value: Types.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.InnerHits, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: Types.InnerHits, value: Map<Types.Field, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: Types.InnerHits, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.InnerHits, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.InnerHits, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.InnerHits, value: Types.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: Types.InnerHits, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: Types.InnerHits, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.InnerHits, value: bool) =
            { state with Version = Some value }

    let innerHits = InnerHitsBuilder()

    type KnnCollectorResultBuilder() =
        member _.Yield(_: unit) : Types.KnnCollectorResult =
            {
                Name = Unchecked.defaultof<_>
                Reason = Unchecked.defaultof<_>
                Time = None
                TimeInNanos = Unchecked.defaultof<_>
                Children = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.KnnCollectorResult, value: string) =
            { state with Name = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.KnnCollectorResult, value: string) =
            { state with Reason = value }

        [<CustomOperation("time")>]
        member _.Time(state: Types.KnnCollectorResult, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: Types.KnnCollectorResult, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("children")>]
        member _.Children(state: Types.KnnCollectorResult, value: Types.KnnCollectorResult list) =
            { state with Children = Some value }

    let knnCollectorResult = KnnCollectorResultBuilder()

    type KnnQueryProfileResultBuilder() =
        member _.Yield(_: unit) : Types.KnnQueryProfileResult =
            {
                Type = Unchecked.defaultof<_>
                Description = Unchecked.defaultof<_>
                Time = None
                TimeInNanos = Unchecked.defaultof<_>
                Breakdown = Unchecked.defaultof<_>
                Debug = None
                Children = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KnnQueryProfileResult, value: string) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.KnnQueryProfileResult, value: string) =
            { state with Description = value }

        [<CustomOperation("time")>]
        member _.Time(state: Types.KnnQueryProfileResult, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: Types.KnnQueryProfileResult, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: Types.KnnQueryProfileResult, value: Types.KnnQueryProfileBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: Types.KnnQueryProfileResult, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: Types.KnnQueryProfileResult, value: Types.KnnQueryProfileResult list) =
            { state with Children = Some value }

    let knnQueryProfileResult = KnnQueryProfileResultBuilder()

    type PhraseSuggestCollateBuilder() =
        member _.Yield(_: unit) : Types.PhraseSuggestCollate =
            {
                Params = None
                Prune = None
                Query = Unchecked.defaultof<_>
            }

        [<CustomOperation("params")>]
        member _.Params(state: Types.PhraseSuggestCollate, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("prune")>]
        member _.Prune(state: Types.PhraseSuggestCollate, value: bool) =
            { state with Prune = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.PhraseSuggestCollate, value: Types.PhraseSuggestCollateQuery) =
            { state with Query = value }

    let phraseSuggestCollate = PhraseSuggestCollateBuilder()

    type PhraseSuggestCollateQueryBuilder() =
        member _.Yield(_: unit) : Types.PhraseSuggestCollateQuery =
            {
                Id = None
                Source = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.PhraseSuggestCollateQuery, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.PhraseSuggestCollateQuery, value: Types.ScriptSource) =
            { state with Source = Some value }

    let phraseSuggestCollateQuery = PhraseSuggestCollateQueryBuilder()

    type PhraseSuggestOptionBuilder() =
        member _.Yield(_: unit) : Types.PhraseSuggestOption =
            {
                Text = Unchecked.defaultof<_>
                Score = Unchecked.defaultof<_>
                Highlighted = None
                CollateMatch = None
            }

        [<CustomOperation("text")>]
        member _.Text(state: Types.PhraseSuggestOption, value: string) =
            { state with Text = value }

        [<CustomOperation("score")>]
        member _.Score(state: Types.PhraseSuggestOption, value: Types.Double) =
            { state with Score = value }

        [<CustomOperation("highlighted")>]
        member _.Highlighted(state: Types.PhraseSuggestOption, value: string) =
            { state with Highlighted = Some value }

        [<CustomOperation("collateMatch")>]
        member _.CollateMatch(state: Types.PhraseSuggestOption, value: bool) =
            { state with CollateMatch = Some value }

    let phraseSuggestOption = PhraseSuggestOptionBuilder()

    type PhraseSuggesterBuilder() =
        member _.Yield(_: unit) : Types.PhraseSuggester =
            {
                Collate = None
                Confidence = None
                DirectGenerator = None
                ForceUnigrams = None
                GramSize = None
                Highlight = None
                MaxErrors = None
                RealWordErrorLikelihood = None
                Separator = None
                ShardSize = None
                Smoothing = None
                TokenLimit = None
            }

        [<CustomOperation("collate")>]
        member _.Collate(state: Types.PhraseSuggester, value: Types.PhraseSuggestCollate) =
            { state with Collate = Some value }

        [<CustomOperation("confidence")>]
        member _.Confidence(state: Types.PhraseSuggester, value: Types.Double) =
            { state with Confidence = Some value }

        [<CustomOperation("directGenerator")>]
        member _.DirectGenerator(state: Types.PhraseSuggester, value: Types.DirectGenerator list) =
            { state with DirectGenerator = Some value }

        [<CustomOperation("forceUnigrams")>]
        member _.ForceUnigrams(state: Types.PhraseSuggester, value: bool) =
            { state with ForceUnigrams = Some value }

        [<CustomOperation("gramSize")>]
        member _.GramSize(state: Types.PhraseSuggester, value: Types.Integer) =
            { state with GramSize = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: Types.PhraseSuggester, value: Types.PhraseSuggestHighlight) =
            { state with Highlight = Some value }

        [<CustomOperation("maxErrors")>]
        member _.MaxErrors(state: Types.PhraseSuggester, value: Types.Double) =
            { state with MaxErrors = Some value }

        [<CustomOperation("realWordErrorLikelihood")>]
        member _.RealWordErrorLikelihood(state: Types.PhraseSuggester, value: Types.Double) =
            { state with RealWordErrorLikelihood = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.PhraseSuggester, value: string) =
            { state with Separator = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.PhraseSuggester, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("smoothing")>]
        member _.Smoothing(state: Types.PhraseSuggester, value: Types.SmoothingModelContainer) =
            { state with Smoothing = Some value }

        [<CustomOperation("tokenLimit")>]
        member _.TokenLimit(state: Types.PhraseSuggester, value: Types.Integer) =
            { state with TokenLimit = Some value }

    let phraseSuggester = PhraseSuggesterBuilder()

    type RegexOptionsBuilder() =
        member _.Yield(_: unit) : Types.RegexOptions =
            {
                Flags = None
                MaxDeterminizedStates = None
            }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.RegexOptions, value: System.Text.Json.JsonElement) =
            { state with Flags = Some value }

        [<CustomOperation("maxDeterminizedStates")>]
        member _.MaxDeterminizedStates(state: Types.RegexOptions, value: Types.Integer) =
            { state with MaxDeterminizedStates = Some value }

    let regexOptions = RegexOptionsBuilder()

    module Rescore =

        let query (value: Types.RescoreQuery) =
            Types.Rescore.Query value

        let learningToRank (value: Types.LearningToRank) =
            Types.Rescore.LearningToRank value

        let script (value: Types.ScriptRescore) =
            Types.Rescore.Script value

    type RescoreQueryBuilder() =
        member _.Yield(_: unit) : Types.RescoreQuery =
            {
                Query = Unchecked.defaultof<_>
                QueryWeight = None
                RescoreQueryWeight = None
                ScoreMode = None
            }

        [<CustomOperation("query")>]
        member _.Query(state: Types.RescoreQuery, value: Types.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("queryWeight")>]
        member _.QueryWeight(state: Types.RescoreQuery, value: Types.Double) =
            { state with QueryWeight = Some value }

        [<CustomOperation("rescoreQueryWeight")>]
        member _.RescoreQueryWeight(state: Types.RescoreQuery, value: Types.Double) =
            { state with RescoreQueryWeight = Some value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: Types.RescoreQuery, value: Types.ScoreMode) =
            { state with ScoreMode = Some value }

    let rescoreQuery = RescoreQueryBuilder()

    type SearchRequestBodyBuilder() =
        member _.Yield(_: unit) : Types.SearchRequestBody =
            {
                Aggregations = None
                Collapse = None
                Explain = None
                Ext = None
                From = None
                Highlight = None
                TrackTotalHits = None
                IndicesBoost = None
                DocvalueFields = None
                Knn = None
                Rank = None
                MinScore = None
                PostFilter = None
                Profile = None
                Query = None
                Rescore = None
                Retriever = None
                ScriptFields = None
                SearchAfter = None
                Size = None
                Slice = None
                Sort = None
                Source = None
                Fields = None
                Suggest = None
                TerminateAfter = None
                Timeout = None
                TrackScores = None
                Version = None
                SeqNoPrimaryTerm = None
                StoredFields = None
                Pit = None
                RuntimeMappings = None
                Stats = None
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: Types.SearchRequestBody, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: Types.SearchRequestBody, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: Types.SearchRequestBody, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: Types.SearchRequestBody, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.SearchRequestBody, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: Types.SearchRequestBody, value: Types.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: Types.SearchRequestBody, value: Types.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: Types.SearchRequestBody, value: Map<Types.IndexName, Types.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: Types.SearchRequestBody, value: Types.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: Types.SearchRequestBody, value: System.Text.Json.JsonElement) =
            { state with Knn = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: Types.SearchRequestBody, value: Types.RankContainer) =
            { state with Rank = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: Types.SearchRequestBody, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: Types.SearchRequestBody, value: Types.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: Types.SearchRequestBody, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.SearchRequestBody, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: Types.SearchRequestBody, value: System.Text.Json.JsonElement) =
            { state with Rescore = Some value }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: Types.SearchRequestBody, value: Types.RetrieverContainer) =
            { state with Retriever = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: Types.SearchRequestBody, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: Types.SearchRequestBody, value: Types.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.SearchRequestBody, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: Types.SearchRequestBody, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.SearchRequestBody, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.SearchRequestBody, value: Types.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.SearchRequestBody, value: Types.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: Types.SearchRequestBody, value: Types.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: Types.SearchRequestBody, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: Types.SearchRequestBody, value: string) =
            { state with Timeout = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: Types.SearchRequestBody, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.SearchRequestBody, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: Types.SearchRequestBody, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: Types.SearchRequestBody, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: Types.SearchRequestBody, value: Types.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Types.SearchRequestBody, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: Types.SearchRequestBody, value: string list) =
            { state with Stats = Some value }

    let searchRequestBody = SearchRequestBodyBuilder()

    type ShardProfileBuilder() =
        member _.Yield(_: unit) : Types.ShardProfile =
            {
                Aggregations = Unchecked.defaultof<_>
                Cluster = Unchecked.defaultof<_>
                Dfs = None
                Fetch = None
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                NodeId = Unchecked.defaultof<_>
                Searches = Unchecked.defaultof<_>
                ShardId = Unchecked.defaultof<_>
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: Types.ShardProfile, value: Types.AggregationProfile list) =
            { state with Aggregations = value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.ShardProfile, value: string) =
            { state with Cluster = value }

        [<CustomOperation("dfs")>]
        member _.Dfs(state: Types.ShardProfile, value: Types.DfsProfile) =
            { state with Dfs = Some value }

        [<CustomOperation("fetch")>]
        member _.Fetch(state: Types.ShardProfile, value: Types.FetchProfile) =
            { state with Fetch = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ShardProfile, value: string) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ShardProfile, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: Types.ShardProfile, value: Types.NodeId) =
            { state with NodeId = value }

        [<CustomOperation("searches")>]
        member _.Searches(state: Types.ShardProfile, value: Types.SearchProfile list) =
            { state with Searches = value }

        [<CustomOperation("shardId")>]
        member _.ShardId(state: Types.ShardProfile, value: Types.Integer) =
            { state with ShardId = value }

    let shardProfile = ShardProfileBuilder()

    module SmoothingModel =

        let laplace (value: Types.LaplaceSmoothingModel) =
            Types.SmoothingModelContainer.Laplace value

        let linearInterpolation (value: Types.LinearInterpolationSmoothingModel) =
            Types.SmoothingModelContainer.LinearInterpolation value

        let stupidBackoff (value: Types.StupidBackoffSmoothingModel) =
            Types.SmoothingModelContainer.StupidBackoff value

    type SourceFilterBuilder() =
        member _.Yield(_: unit) : Types.SourceFilter =
            {
                ExcludeVectors = None
                Excludes = None
                Includes = None
            }

        [<CustomOperation("excludeVectors")>]
        member _.ExcludeVectors(state: Types.SourceFilter, value: bool) =
            { state with ExcludeVectors = Some value }

        [<CustomOperation("excludes")>]
        member _.Excludes(state: Types.SourceFilter, value: Types.Fields) =
            { state with Excludes = Some value }

        [<CustomOperation("includes")>]
        member _.Includes(state: Types.SourceFilter, value: Types.Fields) =
            { state with Includes = Some value }

    let sourceFilter = SourceFilterBuilder()

    let createSourceFilter (value: Types.Fields) : Types.SourceFilter =
        {
            ExcludeVectors = None
            Excludes = None
            Includes = Some value
        }

    type SuggestFuzzinessBuilder() =
        member _.Yield(_: unit) : Types.SuggestFuzziness =
            {
                Fuzziness = None
                MinLength = None
                PrefixLength = None
                Transpositions = None
                UnicodeAware = None
            }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: Types.SuggestFuzziness, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("minLength")>]
        member _.MinLength(state: Types.SuggestFuzziness, value: Types.Integer) =
            { state with MinLength = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.SuggestFuzziness, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("transpositions")>]
        member _.Transpositions(state: Types.SuggestFuzziness, value: bool) =
            { state with Transpositions = Some value }

        [<CustomOperation("unicodeAware")>]
        member _.UnicodeAware(state: Types.SuggestFuzziness, value: bool) =
            { state with UnicodeAware = Some value }

    let suggestFuzziness = SuggestFuzzinessBuilder()

    type SuggesterBaseBuilder() =
        member _.Yield(_: unit) : Types.SuggesterBase =
            {
                Field = Unchecked.defaultof<_>
                Analyzer = None
                Size = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SuggesterBase, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.SuggesterBase, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.SuggesterBase, value: Types.Integer) =
            { state with Size = Some value }

    let suggesterBase = SuggesterBaseBuilder()

    type TermSuggestOptionBuilder() =
        member _.Yield(_: unit) : Types.TermSuggestOption =
            {
                Text = Unchecked.defaultof<_>
                Score = Unchecked.defaultof<_>
                Freq = Unchecked.defaultof<_>
                Highlighted = None
                CollateMatch = None
            }

        [<CustomOperation("text")>]
        member _.Text(state: Types.TermSuggestOption, value: string) =
            { state with Text = value }

        [<CustomOperation("score")>]
        member _.Score(state: Types.TermSuggestOption, value: Types.Double) =
            { state with Score = value }

        [<CustomOperation("freq")>]
        member _.Freq(state: Types.TermSuggestOption, value: Types.Long) =
            { state with Freq = value }

        [<CustomOperation("highlighted")>]
        member _.Highlighted(state: Types.TermSuggestOption, value: string) =
            { state with Highlighted = Some value }

        [<CustomOperation("collateMatch")>]
        member _.CollateMatch(state: Types.TermSuggestOption, value: bool) =
            { state with CollateMatch = Some value }

    let termSuggestOption = TermSuggestOptionBuilder()

    type TermSuggesterBuilder() =
        member _.Yield(_: unit) : Types.TermSuggester =
            {
                LowercaseTerms = None
                MaxEdits = None
                MaxInspections = None
                MaxTermFreq = None
                MinDocFreq = None
                MinWordLength = None
                PrefixLength = None
                ShardSize = None
                Sort = None
                StringDistance = None
                SuggestMode = None
            }

        [<CustomOperation("lowercaseTerms")>]
        member _.LowercaseTerms(state: Types.TermSuggester, value: bool) =
            { state with LowercaseTerms = Some value }

        [<CustomOperation("maxEdits")>]
        member _.MaxEdits(state: Types.TermSuggester, value: Types.Integer) =
            { state with MaxEdits = Some value }

        [<CustomOperation("maxInspections")>]
        member _.MaxInspections(state: Types.TermSuggester, value: Types.Integer) =
            { state with MaxInspections = Some value }

        [<CustomOperation("maxTermFreq")>]
        member _.MaxTermFreq(state: Types.TermSuggester, value: Types.Float) =
            { state with MaxTermFreq = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: Types.TermSuggester, value: Types.Float) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: Types.TermSuggester, value: Types.Integer) =
            { state with MinWordLength = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.TermSuggester, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.TermSuggester, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.TermSuggester, value: Types.SuggestSort) =
            { state with Sort = Some value }

        [<CustomOperation("stringDistance")>]
        member _.StringDistance(state: Types.TermSuggester, value: Types.StringDistance) =
            { state with StringDistance = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: Types.TermSuggester, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

    let termSuggester = TermSuggesterBuilder()

