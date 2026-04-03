// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalSearchTypesBuilders =

    type AggregationBreakdownBuilder() =
        member _.Yield(_: unit) : AggregationBreakdown =
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
        member _.BuildAggregation(state: AggregationBreakdown, value: Types.Long) =
            { state with BuildAggregation = value }

        [<CustomOperation("buildAggregationCount")>]
        member _.BuildAggregationCount(state: AggregationBreakdown, value: Types.Long) =
            { state with BuildAggregationCount = value }

        [<CustomOperation("buildLeafCollector")>]
        member _.BuildLeafCollector(state: AggregationBreakdown, value: Types.Long) =
            { state with BuildLeafCollector = value }

        [<CustomOperation("buildLeafCollectorCount")>]
        member _.BuildLeafCollectorCount(state: AggregationBreakdown, value: Types.Long) =
            { state with BuildLeafCollectorCount = value }

        [<CustomOperation("collect")>]
        member _.Collect(state: AggregationBreakdown, value: Types.Long) =
            { state with Collect = value }

        [<CustomOperation("collectCount")>]
        member _.CollectCount(state: AggregationBreakdown, value: Types.Long) =
            { state with CollectCount = value }

        [<CustomOperation("initialize")>]
        member _.Initialize(state: AggregationBreakdown, value: Types.Long) =
            { state with Initialize = value }

        [<CustomOperation("initializeCount")>]
        member _.InitializeCount(state: AggregationBreakdown, value: Types.Long) =
            { state with InitializeCount = value }

        [<CustomOperation("postCollection")>]
        member _.PostCollection(state: AggregationBreakdown, value: Types.Long) =
            { state with PostCollection = Some value }

        [<CustomOperation("postCollectionCount")>]
        member _.PostCollectionCount(state: AggregationBreakdown, value: Types.Long) =
            { state with PostCollectionCount = Some value }

        [<CustomOperation("reduce")>]
        member _.Reduce(state: AggregationBreakdown, value: Types.Long) =
            { state with Reduce = value }

        [<CustomOperation("reduceCount")>]
        member _.ReduceCount(state: AggregationBreakdown, value: Types.Long) =
            { state with ReduceCount = value }

    let aggregationBreakdown = AggregationBreakdownBuilder()

    type AggregationProfileBuilder() =
        member _.Yield(_: unit) : AggregationProfile =
            {
                Breakdown = Unchecked.defaultof<_>
                Description = Unchecked.defaultof<_>
                TimeInNanos = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Debug = None
                Children = None
            }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: AggregationProfile, value: GlobalSearchTypes.AggregationBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("description")>]
        member _.Description(state: AggregationProfile, value: string) =
            { state with Description = value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: AggregationProfile, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("type'")>]
        member _.Type(state: AggregationProfile, value: string) =
            { state with Type = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: AggregationProfile, value: GlobalSearchTypes.AggregationProfileDebug) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: AggregationProfile, value: GlobalSearchTypes.AggregationProfile list) =
            { state with Children = Some value }

    let aggregationProfile = AggregationProfileBuilder()

    type AggregationProfileDebugBuilder() =
        member _.Yield(_: unit) : AggregationProfileDebug =
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
        member _.SegmentsWithMultiValuedOrds(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithMultiValuedOrds = Some value }

        [<CustomOperation("collectionStrategy")>]
        member _.CollectionStrategy(state: AggregationProfileDebug, value: string) =
            { state with CollectionStrategy = Some value }

        [<CustomOperation("segmentsWithSingleValuedOrds")>]
        member _.SegmentsWithSingleValuedOrds(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithSingleValuedOrds = Some value }

        [<CustomOperation("totalBuckets")>]
        member _.TotalBuckets(state: AggregationProfileDebug, value: Types.Integer) =
            { state with TotalBuckets = Some value }

        [<CustomOperation("builtBuckets")>]
        member _.BuiltBuckets(state: AggregationProfileDebug, value: Types.Integer) =
            { state with BuiltBuckets = Some value }

        [<CustomOperation("resultStrategy")>]
        member _.ResultStrategy(state: AggregationProfileDebug, value: string) =
            { state with ResultStrategy = Some value }

        [<CustomOperation("hasFilter")>]
        member _.HasFilter(state: AggregationProfileDebug, value: bool) =
            { state with HasFilter = Some value }

        [<CustomOperation("delegate'")>]
        member _.Delegate(state: AggregationProfileDebug, value: string) =
            { state with Delegate = Some value }

        [<CustomOperation("delegateDebug")>]
        member _.DelegateDebug(state: AggregationProfileDebug, value: GlobalSearchTypes.AggregationProfileDebug) =
            { state with DelegateDebug = Some value }

        [<CustomOperation("charsFetched")>]
        member _.CharsFetched(state: AggregationProfileDebug, value: Types.Integer) =
            { state with CharsFetched = Some value }

        [<CustomOperation("extractCount")>]
        member _.ExtractCount(state: AggregationProfileDebug, value: Types.Integer) =
            { state with ExtractCount = Some value }

        [<CustomOperation("extractNs")>]
        member _.ExtractNs(state: AggregationProfileDebug, value: Types.Integer) =
            { state with ExtractNs = Some value }

        [<CustomOperation("valuesFetched")>]
        member _.ValuesFetched(state: AggregationProfileDebug, value: Types.Integer) =
            { state with ValuesFetched = Some value }

        [<CustomOperation("collectAnalyzedNs")>]
        member _.CollectAnalyzedNs(state: AggregationProfileDebug, value: Types.Integer) =
            { state with CollectAnalyzedNs = Some value }

        [<CustomOperation("collectAnalyzedCount")>]
        member _.CollectAnalyzedCount(state: AggregationProfileDebug, value: Types.Integer) =
            { state with CollectAnalyzedCount = Some value }

        [<CustomOperation("survivingBuckets")>]
        member _.SurvivingBuckets(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SurvivingBuckets = Some value }

        [<CustomOperation("ordinalsCollectorsUsed")>]
        member _.OrdinalsCollectorsUsed(state: AggregationProfileDebug, value: Types.Integer) =
            { state with OrdinalsCollectorsUsed = Some value }

        [<CustomOperation("ordinalsCollectorsOverheadTooHigh")>]
        member _.OrdinalsCollectorsOverheadTooHigh(state: AggregationProfileDebug, value: Types.Integer) =
            { state with OrdinalsCollectorsOverheadTooHigh = Some value }

        [<CustomOperation("stringHashingCollectorsUsed")>]
        member _.StringHashingCollectorsUsed(state: AggregationProfileDebug, value: Types.Integer) =
            { state with StringHashingCollectorsUsed = Some value }

        [<CustomOperation("numericCollectorsUsed")>]
        member _.NumericCollectorsUsed(state: AggregationProfileDebug, value: Types.Integer) =
            { state with NumericCollectorsUsed = Some value }

        [<CustomOperation("emptyCollectorsUsed")>]
        member _.EmptyCollectorsUsed(state: AggregationProfileDebug, value: Types.Integer) =
            { state with EmptyCollectorsUsed = Some value }

        [<CustomOperation("deferredAggregators")>]
        member _.DeferredAggregators(state: AggregationProfileDebug, value: string list) =
            { state with DeferredAggregators = Some value }

        [<CustomOperation("segmentsWithDocCountField")>]
        member _.SegmentsWithDocCountField(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithDocCountField = Some value }

        [<CustomOperation("segmentsWithDeletedDocs")>]
        member _.SegmentsWithDeletedDocs(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsWithDeletedDocs = Some value }

        [<CustomOperation("filters")>]
        member _.Filters(state: AggregationProfileDebug, value: GlobalSearchTypes.AggregationProfileDelegateDebugFilter list) =
            { state with Filters = Some value }

        [<CustomOperation("segmentsCounted")>]
        member _.SegmentsCounted(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsCounted = Some value }

        [<CustomOperation("segmentsCollected")>]
        member _.SegmentsCollected(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SegmentsCollected = Some value }

        [<CustomOperation("mapReducer")>]
        member _.MapReducer(state: AggregationProfileDebug, value: string) =
            { state with MapReducer = Some value }

        [<CustomOperation("bruteForceUsed")>]
        member _.BruteForceUsed(state: AggregationProfileDebug, value: Types.Integer) =
            { state with BruteForceUsed = Some value }

        [<CustomOperation("dynamicPruningAttempted")>]
        member _.DynamicPruningAttempted(state: AggregationProfileDebug, value: Types.Integer) =
            { state with DynamicPruningAttempted = Some value }

        [<CustomOperation("dynamicPruningUsed")>]
        member _.DynamicPruningUsed(state: AggregationProfileDebug, value: Types.Integer) =
            { state with DynamicPruningUsed = Some value }

        [<CustomOperation("skippedDueToNoData")>]
        member _.SkippedDueToNoData(state: AggregationProfileDebug, value: Types.Integer) =
            { state with SkippedDueToNoData = Some value }

    let aggregationProfileDebug = AggregationProfileDebugBuilder()

    type AggregationProfileDelegateDebugFilterBuilder() =
        member _.Yield(_: unit) : AggregationProfileDelegateDebugFilter =
            {
                ResultsFromMetadata = None
                Query = None
                SpecializedFor = None
                SegmentsCountedInConstantTime = None
            }

        [<CustomOperation("resultsFromMetadata")>]
        member _.ResultsFromMetadata(state: AggregationProfileDelegateDebugFilter, value: Types.Integer) =
            { state with ResultsFromMetadata = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: AggregationProfileDelegateDebugFilter, value: string) =
            { state with Query = Some value }

        [<CustomOperation("specializedFor")>]
        member _.SpecializedFor(state: AggregationProfileDelegateDebugFilter, value: string) =
            { state with SpecializedFor = Some value }

        [<CustomOperation("segmentsCountedInConstantTime")>]
        member _.SegmentsCountedInConstantTime(state: AggregationProfileDelegateDebugFilter, value: Types.Integer) =
            { state with SegmentsCountedInConstantTime = Some value }

    let aggregationProfileDelegateDebugFilter = AggregationProfileDelegateDebugFilterBuilder()

    type CompletionContextBuilder() =
        member _.Yield(_: unit) : CompletionContext =
            {
                Boost = None
                Context = Unchecked.defaultof<_>
                Neighbours = None
                Precision = None
                Prefix = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: CompletionContext, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("context")>]
        member _.Context(state: CompletionContext, value: GlobalSearchTypes.Context) =
            { state with Context = value }

        [<CustomOperation("neighbours")>]
        member _.Neighbours(state: CompletionContext, value: Types.GeoHashPrecision list) =
            { state with Neighbours = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: CompletionContext, value: Types.GeoHashPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: CompletionContext, value: bool) =
            { state with Prefix = Some value }

    let completionContext = CompletionContextBuilder()

    let ofContext (value: GlobalSearchTypes.Context) : CompletionContext =
        {
            Boost = None
            Context = value
            Neighbours = None
            Precision = None
            Prefix = None
        }

    type CompletionSuggestOptionBuilder() =
        member _.Yield(_: unit) : CompletionSuggestOption =
            {
                CollateMatch = None
                Contexts = None
                Fields = None
                Id = None
                Index = None
                Routing = None
                Score = None
                Source = None
                Text = Unchecked.defaultof<_>
                Score = None
            }

        [<CustomOperation("collateMatch")>]
        member _.CollateMatch(state: CompletionSuggestOption, value: bool) =
            { state with CollateMatch = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: CompletionSuggestOption, value: Map<string, GlobalSearchTypes.Context list>) =
            { state with Contexts = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: CompletionSuggestOption, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Fields = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: CompletionSuggestOption, value: string) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: CompletionSuggestOption, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: CompletionSuggestOption, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("score")>]
        member _.Score(state: CompletionSuggestOption, value: Types.Double) =
            { state with Score = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: CompletionSuggestOption, value: 'tDocument) =
            { state with Source = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: CompletionSuggestOption, value: string) =
            { state with Text = value }

        [<CustomOperation("score")>]
        member _.Score(state: CompletionSuggestOption, value: Types.Double) =
            { state with Score = Some value }

    let completionSuggestOption = CompletionSuggestOptionBuilder()

    type CompletionSuggesterBuilder() =
        member _.Yield(_: unit) : CompletionSuggester =
            {
                Contexts = None
                Fuzzy = None
                Regex = None
                SkipDuplicates = None
            }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: CompletionSuggester, value: Map<Types.Field, System.Text.Json.JsonElement>) =
            { state with Contexts = Some value }

        [<CustomOperation("fuzzy")>]
        member _.Fuzzy(state: CompletionSuggester, value: GlobalSearchTypes.SuggestFuzziness) =
            { state with Fuzzy = Some value }

        [<CustomOperation("regex")>]
        member _.Regex(state: CompletionSuggester, value: GlobalSearchTypes.RegexOptions) =
            { state with Regex = Some value }

        [<CustomOperation("skipDuplicates")>]
        member _.SkipDuplicates(state: CompletionSuggester, value: bool) =
            { state with SkipDuplicates = Some value }

    let completionSuggester = CompletionSuggesterBuilder()

    type DfsProfileBuilder() =
        member _.Yield(_: unit) : DfsProfile =
            {
                Statistics = None
                Knn = None
            }

        [<CustomOperation("statistics")>]
        member _.Statistics(state: DfsProfile, value: GlobalSearchTypes.DfsStatisticsProfile) =
            { state with Statistics = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: DfsProfile, value: GlobalSearchTypes.DfsKnnProfile list) =
            { state with Knn = Some value }

    let dfsProfile = DfsProfileBuilder()

    type DfsStatisticsProfileBuilder() =
        member _.Yield(_: unit) : DfsStatisticsProfile =
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
        member _.Type(state: DfsStatisticsProfile, value: string) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: DfsStatisticsProfile, value: string) =
            { state with Description = value }

        [<CustomOperation("time")>]
        member _.Time(state: DfsStatisticsProfile, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: DfsStatisticsProfile, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: DfsStatisticsProfile, value: GlobalSearchTypes.DfsStatisticsBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: DfsStatisticsProfile, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: DfsStatisticsProfile, value: GlobalSearchTypes.DfsStatisticsProfile list) =
            { state with Children = Some value }

    let dfsStatisticsProfile = DfsStatisticsProfileBuilder()

    type DirectGeneratorBuilder() =
        member _.Yield(_: unit) : DirectGenerator =
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
        member _.Field(state: DirectGenerator, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("maxEdits")>]
        member _.MaxEdits(state: DirectGenerator, value: Types.Integer) =
            { state with MaxEdits = Some value }

        [<CustomOperation("maxInspections")>]
        member _.MaxInspections(state: DirectGenerator, value: Types.Float) =
            { state with MaxInspections = Some value }

        [<CustomOperation("maxTermFreq")>]
        member _.MaxTermFreq(state: DirectGenerator, value: Types.Float) =
            { state with MaxTermFreq = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: DirectGenerator, value: Types.Float) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: DirectGenerator, value: Types.Integer) =
            { state with MinWordLength = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: DirectGenerator, value: string) =
            { state with PostFilter = Some value }

        [<CustomOperation("preFilter")>]
        member _.PreFilter(state: DirectGenerator, value: string) =
            { state with PreFilter = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: DirectGenerator, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: DirectGenerator, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: DirectGenerator, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

    let directGenerator = DirectGeneratorBuilder()

    type FetchProfileBuilder() =
        member _.Yield(_: unit) : FetchProfile =
            {
                Type = Unchecked.defaultof<_>
                Description = Unchecked.defaultof<_>
                TimeInNanos = Unchecked.defaultof<_>
                Breakdown = Unchecked.defaultof<_>
                Debug = None
                Children = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: FetchProfile, value: string) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: FetchProfile, value: string) =
            { state with Description = value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: FetchProfile, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: FetchProfile, value: GlobalSearchTypes.FetchProfileBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: FetchProfile, value: GlobalSearchTypes.FetchProfileDebug) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: FetchProfile, value: GlobalSearchTypes.FetchProfile list) =
            { state with Children = Some value }

    let fetchProfile = FetchProfileBuilder()

    type FetchProfileBreakdownBuilder() =
        member _.Yield(_: unit) : FetchProfileBreakdown =
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
        member _.LoadSource(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadSource = Some value }

        [<CustomOperation("loadSourceCount")>]
        member _.LoadSourceCount(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadSourceCount = Some value }

        [<CustomOperation("loadStoredFields")>]
        member _.LoadStoredFields(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadStoredFields = Some value }

        [<CustomOperation("loadStoredFieldsCount")>]
        member _.LoadStoredFieldsCount(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with LoadStoredFieldsCount = Some value }

        [<CustomOperation("nextReader")>]
        member _.NextReader(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with NextReader = Some value }

        [<CustomOperation("nextReaderCount")>]
        member _.NextReaderCount(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with NextReaderCount = Some value }

        [<CustomOperation("processCount")>]
        member _.ProcessCount(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with ProcessCount = Some value }

        [<CustomOperation("process")>]
        member _.Process(state: FetchProfileBreakdown, value: Types.Integer) =
            { state with Process = Some value }

    let fetchProfileBreakdown = FetchProfileBreakdownBuilder()

    type FetchProfileDebugBuilder() =
        member _.Yield(_: unit) : FetchProfileDebug =
            {
                StoredFields = None
                FastPath = None
            }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: FetchProfileDebug, value: string list) =
            { state with StoredFields = Some value }

        [<CustomOperation("fastPath")>]
        member _.FastPath(state: FetchProfileDebug, value: Types.Integer) =
            { state with FastPath = Some value }

    let fetchProfileDebug = FetchProfileDebugBuilder()

    type FieldCollapseBuilder() =
        member _.Yield(_: unit) : FieldCollapse =
            {
                Field = Unchecked.defaultof<_>
                InnerHits = None
                MaxConcurrentGroupSearches = None
                Collapse = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: FieldCollapse, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: FieldCollapse, value: System.Text.Json.JsonElement) =
            { state with InnerHits = Some value }

        [<CustomOperation("maxConcurrentGroupSearches")>]
        member _.MaxConcurrentGroupSearches(state: FieldCollapse, value: Types.Integer) =
            { state with MaxConcurrentGroupSearches = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: FieldCollapse, value: GlobalSearchTypes.FieldCollapse) =
            { state with Collapse = Some value }

    let fieldCollapse = FieldCollapseBuilder()

    module FieldSuggester =

        let completion (value: GlobalSearchTypes.CompletionSuggester) =
            FieldSuggester.Completion value

        let phrase (value: GlobalSearchTypes.PhraseSuggester) =
            FieldSuggester.Phrase value

        let term (value: GlobalSearchTypes.TermSuggester) =
            FieldSuggester.Term value

    type HighlightBaseBuilder() =
        member _.Yield(_: unit) : HighlightBase =
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
        member _.Type(state: HighlightBase, value: GlobalSearchTypes.HighlighterType) =
            { state with Type = Some value }

        [<CustomOperation("boundaryChars")>]
        member _.BoundaryChars(state: HighlightBase, value: string) =
            { state with BoundaryChars = Some value }

        [<CustomOperation("boundaryMaxScan")>]
        member _.BoundaryMaxScan(state: HighlightBase, value: Types.Integer) =
            { state with BoundaryMaxScan = Some value }

        [<CustomOperation("boundaryScanner")>]
        member _.BoundaryScanner(state: HighlightBase, value: GlobalSearchTypes.BoundaryScanner) =
            { state with BoundaryScanner = Some value }

        [<CustomOperation("boundaryScannerLocale")>]
        member _.BoundaryScannerLocale(state: HighlightBase, value: string) =
            { state with BoundaryScannerLocale = Some value }

        [<CustomOperation("forceSource")>]
        member _.ForceSource(state: HighlightBase, value: bool) =
            { state with ForceSource = Some value }

        [<CustomOperation("fragmenter")>]
        member _.Fragmenter(state: HighlightBase, value: GlobalSearchTypes.HighlighterFragmenter) =
            { state with Fragmenter = Some value }

        [<CustomOperation("fragmentSize")>]
        member _.FragmentSize(state: HighlightBase, value: Types.Integer) =
            { state with FragmentSize = Some value }

        [<CustomOperation("highlightFilter")>]
        member _.HighlightFilter(state: HighlightBase, value: bool) =
            { state with HighlightFilter = Some value }

        [<CustomOperation("highlightQuery")>]
        member _.HighlightQuery(state: HighlightBase, value: TypesQueryDsl.QueryContainer) =
            { state with HighlightQuery = Some value }

        [<CustomOperation("maxFragmentLength")>]
        member _.MaxFragmentLength(state: HighlightBase, value: Types.Integer) =
            { state with MaxFragmentLength = Some value }

        [<CustomOperation("maxAnalyzedOffset")>]
        member _.MaxAnalyzedOffset(state: HighlightBase, value: Types.Integer) =
            { state with MaxAnalyzedOffset = Some value }

        [<CustomOperation("noMatchSize")>]
        member _.NoMatchSize(state: HighlightBase, value: Types.Integer) =
            { state with NoMatchSize = Some value }

        [<CustomOperation("numberOfFragments")>]
        member _.NumberOfFragments(state: HighlightBase, value: Types.Integer) =
            { state with NumberOfFragments = Some value }

        [<CustomOperation("options")>]
        member _.Options(state: HighlightBase, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Options = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: HighlightBase, value: GlobalSearchTypes.HighlighterOrder) =
            { state with Order = Some value }

        [<CustomOperation("phraseLimit")>]
        member _.PhraseLimit(state: HighlightBase, value: Types.Integer) =
            { state with PhraseLimit = Some value }

        [<CustomOperation("postTags")>]
        member _.PostTags(state: HighlightBase, value: string list) =
            { state with PostTags = Some value }

        [<CustomOperation("preTags")>]
        member _.PreTags(state: HighlightBase, value: string list) =
            { state with PreTags = Some value }

        [<CustomOperation("requireFieldMatch")>]
        member _.RequireFieldMatch(state: HighlightBase, value: bool) =
            { state with RequireFieldMatch = Some value }

        [<CustomOperation("tagsSchema")>]
        member _.TagsSchema(state: HighlightBase, value: GlobalSearchTypes.HighlighterTagsSchema) =
            { state with TagsSchema = Some value }

    let highlightBase = HighlightBaseBuilder()

    type HighlightFieldBuilder() =
        member _.Yield(_: unit) : HighlightField =
            {
                FragmentOffset = None
                MatchedFields = None
            }

        [<CustomOperation("fragmentOffset")>]
        member _.FragmentOffset(state: HighlightField, value: Types.Integer) =
            { state with FragmentOffset = Some value }

        [<CustomOperation("matchedFields")>]
        member _.MatchedFields(state: HighlightField, value: Types.Fields) =
            { state with MatchedFields = Some value }

    let highlightField = HighlightFieldBuilder()

    type HitBuilder() =
        member _.Yield(_: unit) : Hit =
            {
                Index = Unchecked.defaultof<_>
                Id = None
                Score = None
                Explanation = None
                Fields = None
                Highlight = None
                InnerHits = None
                MatchedQueries = None
                Nested = None
                Ignored = None
                IgnoredFieldValues = None
                Shard = None
                Node = None
                Routing = None
                Source = None
                Rank = None
                SeqNo = None
                PrimaryTerm = None
                Version = None
                Sort = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Hit, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("id")>]
        member _.Id(state: Hit, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("score")>]
        member _.Score(state: Hit, value: Types.Double option) =
            { state with Score = Some value }

        [<CustomOperation("explanation")>]
        member _.Explanation(state: Hit, value: GlobalExplain.Explanation) =
            { state with Explanation = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Hit, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Fields = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: Hit, value: Map<string, string list>) =
            { state with Highlight = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: Hit, value: Map<string, GlobalSearchTypes.InnerHitsResult>) =
            { state with InnerHits = Some value }

        [<CustomOperation("matchedQueries")>]
        member _.MatchedQueries(state: Hit, value: System.Text.Json.JsonElement) =
            { state with MatchedQueries = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: Hit, value: GlobalSearchTypes.NestedIdentity) =
            { state with Nested = Some value }

        [<CustomOperation("ignored")>]
        member _.Ignored(state: Hit, value: string list) =
            { state with Ignored = Some value }

        [<CustomOperation("ignoredFieldValues")>]
        member _.IgnoredFieldValues(state: Hit, value: Map<string, System.Text.Json.JsonElement list>) =
            { state with IgnoredFieldValues = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Hit, value: string) =
            { state with Shard = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Hit, value: string) =
            { state with Node = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Hit, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Hit, value: 'tDocument) =
            { state with Source = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: Hit, value: Types.Integer) =
            { state with Rank = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: Hit, value: Types.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: Hit, value: Types.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Hit, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Hit, value: Types.SortResults) =
            { state with Sort = Some value }

    let hit = HitBuilder()

    type HitsMetadataBuilder() =
        member _.Yield(_: unit) : HitsMetadata =
            {
                Total = None
                Hits = Unchecked.defaultof<_>
                MaxScore = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: HitsMetadata, value: System.Text.Json.JsonElement) =
            { state with Total = Some value }

        [<CustomOperation("hits")>]
        member _.Hits(state: HitsMetadata, value: GlobalSearchTypes.Hit<'t> list) =
            { state with Hits = value }

        [<CustomOperation("maxScore")>]
        member _.MaxScore(state: HitsMetadata, value: Types.Double option) =
            { state with MaxScore = Some value }

    let hitsMetadata = HitsMetadataBuilder()

    type InnerHitsBuilder() =
        member _.Yield(_: unit) : InnerHits =
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
        member _.Name(state: InnerHits, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: InnerHits, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: InnerHits, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: InnerHits, value: GlobalSearchTypes.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: InnerHits, value: TypesQueryDsl.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: InnerHits, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: InnerHits, value: GlobalSearchTypes.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: InnerHits, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: InnerHits, value: Map<Types.Field, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: InnerHits, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: InnerHits, value: Types.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: InnerHits, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: InnerHits, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: InnerHits, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: InnerHits, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: InnerHits, value: bool) =
            { state with Version = Some value }

    let innerHits = InnerHitsBuilder()

    type KnnCollectorResultBuilder() =
        member _.Yield(_: unit) : KnnCollectorResult =
            {
                Name = Unchecked.defaultof<_>
                Reason = Unchecked.defaultof<_>
                Time = None
                TimeInNanos = Unchecked.defaultof<_>
                Children = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: KnnCollectorResult, value: string) =
            { state with Name = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: KnnCollectorResult, value: string) =
            { state with Reason = value }

        [<CustomOperation("time")>]
        member _.Time(state: KnnCollectorResult, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: KnnCollectorResult, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("children")>]
        member _.Children(state: KnnCollectorResult, value: GlobalSearchTypes.KnnCollectorResult list) =
            { state with Children = Some value }

    let knnCollectorResult = KnnCollectorResultBuilder()

    type KnnQueryProfileResultBuilder() =
        member _.Yield(_: unit) : KnnQueryProfileResult =
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
        member _.Type(state: KnnQueryProfileResult, value: string) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: KnnQueryProfileResult, value: string) =
            { state with Description = value }

        [<CustomOperation("time")>]
        member _.Time(state: KnnQueryProfileResult, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInNanos")>]
        member _.TimeInNanos(state: KnnQueryProfileResult, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeInNanos = value }

        [<CustomOperation("breakdown")>]
        member _.Breakdown(state: KnnQueryProfileResult, value: GlobalSearchTypes.KnnQueryProfileBreakdown) =
            { state with Breakdown = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: KnnQueryProfileResult, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Debug = Some value }

        [<CustomOperation("children")>]
        member _.Children(state: KnnQueryProfileResult, value: GlobalSearchTypes.KnnQueryProfileResult list) =
            { state with Children = Some value }

    let knnQueryProfileResult = KnnQueryProfileResultBuilder()

    type PhraseSuggestCollateBuilder() =
        member _.Yield(_: unit) : PhraseSuggestCollate =
            {
                Params = None
                Prune = None
                Query = Unchecked.defaultof<_>
            }

        [<CustomOperation("params")>]
        member _.Params(state: PhraseSuggestCollate, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("prune")>]
        member _.Prune(state: PhraseSuggestCollate, value: bool) =
            { state with Prune = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: PhraseSuggestCollate, value: GlobalSearchTypes.PhraseSuggestCollateQuery) =
            { state with Query = value }

    let phraseSuggestCollate = PhraseSuggestCollateBuilder()

    type PhraseSuggestCollateQueryBuilder() =
        member _.Yield(_: unit) : PhraseSuggestCollateQuery =
            {
                Id = None
                Source = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: PhraseSuggestCollateQuery, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: PhraseSuggestCollateQuery, value: Types.ScriptSource) =
            { state with Source = Some value }

    let phraseSuggestCollateQuery = PhraseSuggestCollateQueryBuilder()

    type PhraseSuggestOptionBuilder() =
        member _.Yield(_: unit) : PhraseSuggestOption =
            {
                Text = Unchecked.defaultof<_>
                Score = Unchecked.defaultof<_>
                Highlighted = None
                CollateMatch = None
            }

        [<CustomOperation("text")>]
        member _.Text(state: PhraseSuggestOption, value: string) =
            { state with Text = value }

        [<CustomOperation("score")>]
        member _.Score(state: PhraseSuggestOption, value: Types.Double) =
            { state with Score = value }

        [<CustomOperation("highlighted")>]
        member _.Highlighted(state: PhraseSuggestOption, value: string) =
            { state with Highlighted = Some value }

        [<CustomOperation("collateMatch")>]
        member _.CollateMatch(state: PhraseSuggestOption, value: bool) =
            { state with CollateMatch = Some value }

    let phraseSuggestOption = PhraseSuggestOptionBuilder()

    type PhraseSuggesterBuilder() =
        member _.Yield(_: unit) : PhraseSuggester =
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
        member _.Collate(state: PhraseSuggester, value: GlobalSearchTypes.PhraseSuggestCollate) =
            { state with Collate = Some value }

        [<CustomOperation("confidence")>]
        member _.Confidence(state: PhraseSuggester, value: Types.Double) =
            { state with Confidence = Some value }

        [<CustomOperation("directGenerator")>]
        member _.DirectGenerator(state: PhraseSuggester, value: GlobalSearchTypes.DirectGenerator list) =
            { state with DirectGenerator = Some value }

        [<CustomOperation("forceUnigrams")>]
        member _.ForceUnigrams(state: PhraseSuggester, value: bool) =
            { state with ForceUnigrams = Some value }

        [<CustomOperation("gramSize")>]
        member _.GramSize(state: PhraseSuggester, value: Types.Integer) =
            { state with GramSize = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: PhraseSuggester, value: GlobalSearchTypes.PhraseSuggestHighlight) =
            { state with Highlight = Some value }

        [<CustomOperation("maxErrors")>]
        member _.MaxErrors(state: PhraseSuggester, value: Types.Double) =
            { state with MaxErrors = Some value }

        [<CustomOperation("realWordErrorLikelihood")>]
        member _.RealWordErrorLikelihood(state: PhraseSuggester, value: Types.Double) =
            { state with RealWordErrorLikelihood = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: PhraseSuggester, value: string) =
            { state with Separator = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: PhraseSuggester, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("smoothing")>]
        member _.Smoothing(state: PhraseSuggester, value: GlobalSearchTypes.SmoothingModelContainer) =
            { state with Smoothing = Some value }

        [<CustomOperation("tokenLimit")>]
        member _.TokenLimit(state: PhraseSuggester, value: Types.Integer) =
            { state with TokenLimit = Some value }

    let phraseSuggester = PhraseSuggesterBuilder()

    type RegexOptionsBuilder() =
        member _.Yield(_: unit) : RegexOptions =
            {
                Flags = None
                MaxDeterminizedStates = None
            }

        [<CustomOperation("flags")>]
        member _.Flags(state: RegexOptions, value: System.Text.Json.JsonElement) =
            { state with Flags = Some value }

        [<CustomOperation("maxDeterminizedStates")>]
        member _.MaxDeterminizedStates(state: RegexOptions, value: Types.Integer) =
            { state with MaxDeterminizedStates = Some value }

    let regexOptions = RegexOptionsBuilder()

    module Rescore =

        let query (value: GlobalSearchTypes.RescoreQuery) =
            Rescore.Query value

        let learningToRank (value: GlobalSearchTypes.LearningToRank) =
            Rescore.LearningToRank value

        let script (value: GlobalSearchTypes.ScriptRescore) =
            Rescore.Script value

    type RescoreQueryBuilder() =
        member _.Yield(_: unit) : RescoreQuery =
            {
                RescoreQuery = Unchecked.defaultof<_>
                QueryWeight = None
                RescoreQueryWeight = None
                ScoreMode = None
            }

        [<CustomOperation("rescoreQuery")>]
        member _.RescoreQuery(state: RescoreQuery, value: TypesQueryDsl.QueryContainer) =
            { state with RescoreQuery = value }

        [<CustomOperation("queryWeight")>]
        member _.QueryWeight(state: RescoreQuery, value: Types.Double) =
            { state with QueryWeight = Some value }

        [<CustomOperation("rescoreQueryWeight")>]
        member _.RescoreQueryWeight(state: RescoreQuery, value: Types.Double) =
            { state with RescoreQueryWeight = Some value }

        [<CustomOperation("scoreMode")>]
        member _.ScoreMode(state: RescoreQuery, value: GlobalSearchTypes.ScoreMode) =
            { state with ScoreMode = Some value }

    let rescoreQuery = RescoreQueryBuilder()

    type SearchRequestBodyBuilder() =
        member _.Yield(_: unit) : SearchRequestBody =
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
        member _.Aggregations(state: SearchRequestBody, value: Map<string, TypesAggregations.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: SearchRequestBody, value: GlobalSearchTypes.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchRequestBody, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: SearchRequestBody, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SearchRequestBody, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: SearchRequestBody, value: GlobalSearchTypes.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchRequestBody, value: GlobalSearchTypes.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: SearchRequestBody, value: Map<Types.IndexName, Types.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: SearchRequestBody, value: TypesQueryDsl.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: SearchRequestBody, value: System.Text.Json.JsonElement) =
            { state with Knn = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: SearchRequestBody, value: Types.RankContainer) =
            { state with Rank = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: SearchRequestBody, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: SearchRequestBody, value: TypesQueryDsl.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchRequestBody, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SearchRequestBody, value: TypesQueryDsl.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: SearchRequestBody, value: System.Text.Json.JsonElement) =
            { state with Rescore = Some value }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: SearchRequestBody, value: Types.RetrieverContainer) =
            { state with Retriever = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: SearchRequestBody, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: SearchRequestBody, value: Types.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchRequestBody, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: SearchRequestBody, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchRequestBody, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SearchRequestBody, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchRequestBody, value: TypesQueryDsl.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: SearchRequestBody, value: GlobalSearchTypes.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: SearchRequestBody, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SearchRequestBody, value: string) =
            { state with Timeout = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: SearchRequestBody, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: SearchRequestBody, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: SearchRequestBody, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: SearchRequestBody, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: SearchRequestBody, value: GlobalSearchTypes.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: SearchRequestBody, value: TypesMapping.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: SearchRequestBody, value: string list) =
            { state with Stats = Some value }

    let searchRequestBody = SearchRequestBodyBuilder()

    type ShardProfileBuilder() =
        member _.Yield(_: unit) : ShardProfile =
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
        member _.Aggregations(state: ShardProfile, value: GlobalSearchTypes.AggregationProfile list) =
            { state with Aggregations = value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: ShardProfile, value: string) =
            { state with Cluster = value }

        [<CustomOperation("dfs")>]
        member _.Dfs(state: ShardProfile, value: GlobalSearchTypes.DfsProfile) =
            { state with Dfs = Some value }

        [<CustomOperation("fetch")>]
        member _.Fetch(state: ShardProfile, value: GlobalSearchTypes.FetchProfile) =
            { state with Fetch = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: ShardProfile, value: string) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ShardProfile, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: ShardProfile, value: Types.NodeId) =
            { state with NodeId = value }

        [<CustomOperation("searches")>]
        member _.Searches(state: ShardProfile, value: GlobalSearchTypes.SearchProfile list) =
            { state with Searches = value }

        [<CustomOperation("shardId")>]
        member _.ShardId(state: ShardProfile, value: Types.Integer) =
            { state with ShardId = value }

    let shardProfile = ShardProfileBuilder()

    module SmoothingModel =

        let laplace (value: GlobalSearchTypes.LaplaceSmoothingModel) =
            SmoothingModelContainer.Laplace value

        let linearInterpolation (value: GlobalSearchTypes.LinearInterpolationSmoothingModel) =
            SmoothingModelContainer.LinearInterpolation value

        let stupidBackoff (value: GlobalSearchTypes.StupidBackoffSmoothingModel) =
            SmoothingModelContainer.StupidBackoff value

    type SourceFilterBuilder() =
        member _.Yield(_: unit) : SourceFilter =
            {
                ExcludeVectors = None
                Excludes = None
                Includes = None
            }

        [<CustomOperation("excludeVectors")>]
        member _.ExcludeVectors(state: SourceFilter, value: bool) =
            { state with ExcludeVectors = Some value }

        [<CustomOperation("excludes")>]
        member _.Excludes(state: SourceFilter, value: Types.Fields) =
            { state with Excludes = Some value }

        [<CustomOperation("includes")>]
        member _.Includes(state: SourceFilter, value: Types.Fields) =
            { state with Includes = Some value }

    let sourceFilter = SourceFilterBuilder()

    let ofIncludes (value: Types.Fields) : SourceFilter =
        {
            ExcludeVectors = None
            Excludes = None
            Includes = value
        }

    type SuggestFuzzinessBuilder() =
        member _.Yield(_: unit) : SuggestFuzziness =
            {
                Fuzziness = None
                MinLength = None
                PrefixLength = None
                Transpositions = None
                UnicodeAware = None
            }

        [<CustomOperation("fuzziness")>]
        member _.Fuzziness(state: SuggestFuzziness, value: Types.Fuzziness) =
            { state with Fuzziness = Some value }

        [<CustomOperation("minLength")>]
        member _.MinLength(state: SuggestFuzziness, value: Types.Integer) =
            { state with MinLength = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: SuggestFuzziness, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("transpositions")>]
        member _.Transpositions(state: SuggestFuzziness, value: bool) =
            { state with Transpositions = Some value }

        [<CustomOperation("unicodeAware")>]
        member _.UnicodeAware(state: SuggestFuzziness, value: bool) =
            { state with UnicodeAware = Some value }

    let suggestFuzziness = SuggestFuzzinessBuilder()

    type SuggesterBaseBuilder() =
        member _.Yield(_: unit) : SuggesterBase =
            {
                Field = Unchecked.defaultof<_>
                Analyzer = None
                Size = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: SuggesterBase, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: SuggesterBase, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SuggesterBase, value: Types.Integer) =
            { state with Size = Some value }

    let suggesterBase = SuggesterBaseBuilder()

    type TermSuggestOptionBuilder() =
        member _.Yield(_: unit) : TermSuggestOption =
            {
                Text = Unchecked.defaultof<_>
                Score = Unchecked.defaultof<_>
                Freq = Unchecked.defaultof<_>
                Highlighted = None
                CollateMatch = None
            }

        [<CustomOperation("text")>]
        member _.Text(state: TermSuggestOption, value: string) =
            { state with Text = value }

        [<CustomOperation("score")>]
        member _.Score(state: TermSuggestOption, value: Types.Double) =
            { state with Score = value }

        [<CustomOperation("freq")>]
        member _.Freq(state: TermSuggestOption, value: Types.Long) =
            { state with Freq = value }

        [<CustomOperation("highlighted")>]
        member _.Highlighted(state: TermSuggestOption, value: string) =
            { state with Highlighted = Some value }

        [<CustomOperation("collateMatch")>]
        member _.CollateMatch(state: TermSuggestOption, value: bool) =
            { state with CollateMatch = Some value }

    let termSuggestOption = TermSuggestOptionBuilder()

    type TermSuggesterBuilder() =
        member _.Yield(_: unit) : TermSuggester =
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
        member _.LowercaseTerms(state: TermSuggester, value: bool) =
            { state with LowercaseTerms = Some value }

        [<CustomOperation("maxEdits")>]
        member _.MaxEdits(state: TermSuggester, value: Types.Integer) =
            { state with MaxEdits = Some value }

        [<CustomOperation("maxInspections")>]
        member _.MaxInspections(state: TermSuggester, value: Types.Integer) =
            { state with MaxInspections = Some value }

        [<CustomOperation("maxTermFreq")>]
        member _.MaxTermFreq(state: TermSuggester, value: Types.Float) =
            { state with MaxTermFreq = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: TermSuggester, value: Types.Float) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: TermSuggester, value: Types.Integer) =
            { state with MinWordLength = Some value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: TermSuggester, value: Types.Integer) =
            { state with PrefixLength = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: TermSuggester, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: TermSuggester, value: GlobalSearchTypes.SuggestSort) =
            { state with Sort = Some value }

        [<CustomOperation("stringDistance")>]
        member _.StringDistance(state: TermSuggester, value: GlobalSearchTypes.StringDistance) =
            { state with StringDistance = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: TermSuggester, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

    let termSuggester = TermSuggesterBuilder()

