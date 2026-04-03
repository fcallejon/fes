// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MlTypesBuilders =

    type AdaptiveAllocationsSettingsBuilder() =
        member _.Yield(_: unit) : AdaptiveAllocationsSettings =
            {
                Enabled = Unchecked.defaultof<_>
                MinNumberOfAllocations = None
                MaxNumberOfAllocations = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: AdaptiveAllocationsSettings, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("minNumberOfAllocations")>]
        member _.MinNumberOfAllocations(state: AdaptiveAllocationsSettings, value: CoreTypes.Integer) =
            { state with MinNumberOfAllocations = Some value }

        [<CustomOperation("maxNumberOfAllocations")>]
        member _.MaxNumberOfAllocations(state: AdaptiveAllocationsSettings, value: CoreTypes.Integer) =
            { state with MaxNumberOfAllocations = Some value }

    let adaptiveAllocationsSettings = AdaptiveAllocationsSettingsBuilder()

    type AnalysisConfigBuilder() =
        member _.Yield(_: unit) : AnalysisConfig =
            {
                BucketSpan = None
                CategorizationAnalyzer = None
                CategorizationFieldName = None
                CategorizationFilters = None
                Detectors = Unchecked.defaultof<_>
                Influencers = None
                Latency = None
                ModelPruneWindow = None
                MultivariateByFields = None
                PerPartitionCategorization = None
                SummaryCountFieldName = None
            }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: AnalysisConfig, value: CoreTypes.Duration) =
            { state with BucketSpan = Some value }

        [<CustomOperation("categorizationAnalyzer")>]
        member _.CategorizationAnalyzer(state: AnalysisConfig, value: MlTypes.CategorizationAnalyzer) =
            { state with CategorizationAnalyzer = Some value }

        [<CustomOperation("categorizationFieldName")>]
        member _.CategorizationFieldName(state: AnalysisConfig, value: CoreTypes.Field) =
            { state with CategorizationFieldName = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: AnalysisConfig, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("detectors")>]
        member _.Detectors(state: AnalysisConfig, value: MlTypes.Detector list) =
            { state with Detectors = value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: AnalysisConfig, value: CoreTypes.Field list) =
            { state with Influencers = Some value }

        [<CustomOperation("latency")>]
        member _.Latency(state: AnalysisConfig, value: CoreTypes.Duration) =
            { state with Latency = Some value }

        [<CustomOperation("modelPruneWindow")>]
        member _.ModelPruneWindow(state: AnalysisConfig, value: CoreTypes.Duration) =
            { state with ModelPruneWindow = Some value }

        [<CustomOperation("multivariateByFields")>]
        member _.MultivariateByFields(state: AnalysisConfig, value: bool) =
            { state with MultivariateByFields = Some value }

        [<CustomOperation("perPartitionCategorization")>]
        member _.PerPartitionCategorization(state: AnalysisConfig, value: MlTypes.PerPartitionCategorization) =
            { state with PerPartitionCategorization = Some value }

        [<CustomOperation("summaryCountFieldName")>]
        member _.SummaryCountFieldName(state: AnalysisConfig, value: CoreTypes.Field) =
            { state with SummaryCountFieldName = Some value }

    let analysisConfig = AnalysisConfigBuilder()

    type AnalysisConfigReadBuilder() =
        member _.Yield(_: unit) : AnalysisConfigRead =
            {
                BucketSpan = Unchecked.defaultof<_>
                Detectors = Unchecked.defaultof<_>
                Influencers = Unchecked.defaultof<_>
                CategorizationAnalyzer = None
                CategorizationFieldName = None
                CategorizationFilters = None
                Latency = None
                ModelPruneWindow = None
                MultivariateByFields = None
                PerPartitionCategorization = None
                SummaryCountFieldName = None
            }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: AnalysisConfigRead, value: CoreTypes.Duration) =
            { state with BucketSpan = value }

        [<CustomOperation("detectors")>]
        member _.Detectors(state: AnalysisConfigRead, value: MlTypes.DetectorRead list) =
            { state with Detectors = value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: AnalysisConfigRead, value: CoreTypes.Field list) =
            { state with Influencers = value }

        [<CustomOperation("categorizationAnalyzer")>]
        member _.CategorizationAnalyzer(state: AnalysisConfigRead, value: MlTypes.CategorizationAnalyzer) =
            { state with CategorizationAnalyzer = Some value }

        [<CustomOperation("categorizationFieldName")>]
        member _.CategorizationFieldName(state: AnalysisConfigRead, value: CoreTypes.Field) =
            { state with CategorizationFieldName = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: AnalysisConfigRead, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("latency")>]
        member _.Latency(state: AnalysisConfigRead, value: CoreTypes.Duration) =
            { state with Latency = Some value }

        [<CustomOperation("modelPruneWindow")>]
        member _.ModelPruneWindow(state: AnalysisConfigRead, value: CoreTypes.Duration) =
            { state with ModelPruneWindow = Some value }

        [<CustomOperation("multivariateByFields")>]
        member _.MultivariateByFields(state: AnalysisConfigRead, value: bool) =
            { state with MultivariateByFields = Some value }

        [<CustomOperation("perPartitionCategorization")>]
        member _.PerPartitionCategorization(state: AnalysisConfigRead, value: MlTypes.PerPartitionCategorization) =
            { state with PerPartitionCategorization = Some value }

        [<CustomOperation("summaryCountFieldName")>]
        member _.SummaryCountFieldName(state: AnalysisConfigRead, value: CoreTypes.Field) =
            { state with SummaryCountFieldName = Some value }

    let analysisConfigRead = AnalysisConfigReadBuilder()

    type AnalysisLimitsBuilder() =
        member _.Yield(_: unit) : AnalysisLimits =
            {
                CategorizationExamplesLimit = None
                ModelMemoryLimit = None
            }

        [<CustomOperation("categorizationExamplesLimit")>]
        member _.CategorizationExamplesLimit(state: AnalysisLimits, value: CoreTypes.Long) =
            { state with CategorizationExamplesLimit = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: AnalysisLimits, value: CoreTypes.ByteSize) =
            { state with ModelMemoryLimit = Some value }

    let analysisLimits = AnalysisLimitsBuilder()

    type AnomalyBuilder() =
        member _.Yield(_: unit) : Anomaly =
            {
                Actual = None
                AnomalyScoreExplanation = None
                BucketSpan = Unchecked.defaultof<_>
                ByFieldName = None
                ByFieldValue = None
                Causes = None
                DetectorIndex = Unchecked.defaultof<_>
                FieldName = None
                Function = None
                FunctionDescription = None
                GeoResults = None
                Influencers = None
                InitialRecordScore = Unchecked.defaultof<_>
                IsInterim = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
                OverFieldName = None
                OverFieldValue = None
                PartitionFieldName = None
                PartitionFieldValue = None
                Probability = Unchecked.defaultof<_>
                RecordScore = Unchecked.defaultof<_>
                ResultType = Unchecked.defaultof<_>
                Timestamp = Unchecked.defaultof<_>
                Typical = None
            }

        [<CustomOperation("actual")>]
        member _.Actual(state: Anomaly, value: CoreTypes.Double list) =
            { state with Actual = Some value }

        [<CustomOperation("anomalyScoreExplanation")>]
        member _.AnomalyScoreExplanation(state: Anomaly, value: MlTypes.AnomalyExplanation) =
            { state with AnomalyScoreExplanation = Some value }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: Anomaly, value: CoreTypes.DurationValue<CoreTypes.UnitSeconds>) =
            { state with BucketSpan = value }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: Anomaly, value: string) =
            { state with ByFieldName = Some value }

        [<CustomOperation("byFieldValue")>]
        member _.ByFieldValue(state: Anomaly, value: string) =
            { state with ByFieldValue = Some value }

        [<CustomOperation("causes")>]
        member _.Causes(state: Anomaly, value: MlTypes.AnomalyCause list) =
            { state with Causes = Some value }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: Anomaly, value: CoreTypes.Integer) =
            { state with DetectorIndex = value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: Anomaly, value: string) =
            { state with FieldName = Some value }

        [<CustomOperation("function'")>]
        member _.Function(state: Anomaly, value: string) =
            { state with Function = Some value }

        [<CustomOperation("functionDescription")>]
        member _.FunctionDescription(state: Anomaly, value: string) =
            { state with FunctionDescription = Some value }

        [<CustomOperation("geoResults")>]
        member _.GeoResults(state: Anomaly, value: MlTypes.GeoResults) =
            { state with GeoResults = Some value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: Anomaly, value: MlTypes.Influence list) =
            { state with Influencers = Some value }

        [<CustomOperation("initialRecordScore")>]
        member _.InitialRecordScore(state: Anomaly, value: CoreTypes.Double) =
            { state with InitialRecordScore = value }

        [<CustomOperation("isInterim")>]
        member _.IsInterim(state: Anomaly, value: bool) =
            { state with IsInterim = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Anomaly, value: string) =
            { state with JobId = value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: Anomaly, value: string) =
            { state with OverFieldName = Some value }

        [<CustomOperation("overFieldValue")>]
        member _.OverFieldValue(state: Anomaly, value: string) =
            { state with OverFieldValue = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Anomaly, value: string) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: Anomaly, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("probability")>]
        member _.Probability(state: Anomaly, value: CoreTypes.Double) =
            { state with Probability = value }

        [<CustomOperation("recordScore")>]
        member _.RecordScore(state: Anomaly, value: CoreTypes.Double) =
            { state with RecordScore = value }

        [<CustomOperation("resultType")>]
        member _.ResultType(state: Anomaly, value: string) =
            { state with ResultType = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Anomaly, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with Timestamp = value }

        [<CustomOperation("typical")>]
        member _.Typical(state: Anomaly, value: CoreTypes.Double list) =
            { state with Typical = Some value }

    let anomaly = AnomalyBuilder()

    type AnomalyCauseBuilder() =
        member _.Yield(_: unit) : AnomalyCause =
            {
                Actual = None
                ByFieldName = None
                ByFieldValue = None
                CorrelatedByFieldValue = None
                FieldName = None
                Function = None
                FunctionDescription = None
                GeoResults = None
                Influencers = None
                OverFieldName = None
                OverFieldValue = None
                PartitionFieldName = None
                PartitionFieldValue = None
                Probability = Unchecked.defaultof<_>
                Typical = None
            }

        [<CustomOperation("actual")>]
        member _.Actual(state: AnomalyCause, value: CoreTypes.Double list) =
            { state with Actual = Some value }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: AnomalyCause, value: CoreTypes.Name) =
            { state with ByFieldName = Some value }

        [<CustomOperation("byFieldValue")>]
        member _.ByFieldValue(state: AnomalyCause, value: string) =
            { state with ByFieldValue = Some value }

        [<CustomOperation("correlatedByFieldValue")>]
        member _.CorrelatedByFieldValue(state: AnomalyCause, value: string) =
            { state with CorrelatedByFieldValue = Some value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: AnomalyCause, value: CoreTypes.Field) =
            { state with FieldName = Some value }

        [<CustomOperation("function'")>]
        member _.Function(state: AnomalyCause, value: string) =
            { state with Function = Some value }

        [<CustomOperation("functionDescription")>]
        member _.FunctionDescription(state: AnomalyCause, value: string) =
            { state with FunctionDescription = Some value }

        [<CustomOperation("geoResults")>]
        member _.GeoResults(state: AnomalyCause, value: MlTypes.GeoResults) =
            { state with GeoResults = Some value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: AnomalyCause, value: MlTypes.Influence list) =
            { state with Influencers = Some value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: AnomalyCause, value: CoreTypes.Name) =
            { state with OverFieldName = Some value }

        [<CustomOperation("overFieldValue")>]
        member _.OverFieldValue(state: AnomalyCause, value: string) =
            { state with OverFieldValue = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: AnomalyCause, value: string) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: AnomalyCause, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("probability")>]
        member _.Probability(state: AnomalyCause, value: CoreTypes.Double) =
            { state with Probability = value }

        [<CustomOperation("typical")>]
        member _.Typical(state: AnomalyCause, value: CoreTypes.Double list) =
            { state with Typical = Some value }

    let anomalyCause = AnomalyCauseBuilder()

    type AnomalyExplanationBuilder() =
        member _.Yield(_: unit) : AnomalyExplanation =
            {
                AnomalyCharacteristicsImpact = None
                AnomalyLength = None
                AnomalyType = None
                HighVariancePenalty = None
                IncompleteBucketPenalty = None
                LowerConfidenceBound = None
                MultiBucketImpact = None
                SingleBucketImpact = None
                TypicalValue = None
                UpperConfidenceBound = None
            }

        [<CustomOperation("anomalyCharacteristicsImpact")>]
        member _.AnomalyCharacteristicsImpact(state: AnomalyExplanation, value: CoreTypes.Integer) =
            { state with AnomalyCharacteristicsImpact = Some value }

        [<CustomOperation("anomalyLength")>]
        member _.AnomalyLength(state: AnomalyExplanation, value: CoreTypes.Integer) =
            { state with AnomalyLength = Some value }

        [<CustomOperation("anomalyType")>]
        member _.AnomalyType(state: AnomalyExplanation, value: string) =
            { state with AnomalyType = Some value }

        [<CustomOperation("highVariancePenalty")>]
        member _.HighVariancePenalty(state: AnomalyExplanation, value: bool) =
            { state with HighVariancePenalty = Some value }

        [<CustomOperation("incompleteBucketPenalty")>]
        member _.IncompleteBucketPenalty(state: AnomalyExplanation, value: bool) =
            { state with IncompleteBucketPenalty = Some value }

        [<CustomOperation("lowerConfidenceBound")>]
        member _.LowerConfidenceBound(state: AnomalyExplanation, value: CoreTypes.Double) =
            { state with LowerConfidenceBound = Some value }

        [<CustomOperation("multiBucketImpact")>]
        member _.MultiBucketImpact(state: AnomalyExplanation, value: CoreTypes.Integer) =
            { state with MultiBucketImpact = Some value }

        [<CustomOperation("singleBucketImpact")>]
        member _.SingleBucketImpact(state: AnomalyExplanation, value: CoreTypes.Integer) =
            { state with SingleBucketImpact = Some value }

        [<CustomOperation("typicalValue")>]
        member _.TypicalValue(state: AnomalyExplanation, value: CoreTypes.Double) =
            { state with TypicalValue = Some value }

        [<CustomOperation("upperConfidenceBound")>]
        member _.UpperConfidenceBound(state: AnomalyExplanation, value: CoreTypes.Double) =
            { state with UpperConfidenceBound = Some value }

    let anomalyExplanation = AnomalyExplanationBuilder()

    type CalendarEventBuilder() =
        member _.Yield(_: unit) : CalendarEvent =
            {
                CalendarId = None
                EventId = None
                Description = Unchecked.defaultof<_>
                EndTime = Unchecked.defaultof<_>
                StartTime = Unchecked.defaultof<_>
                SkipResult = None
                SkipModelUpdate = None
                ForceTimeShift = None
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: CalendarEvent, value: CoreTypes.Id) =
            { state with CalendarId = Some value }

        [<CustomOperation("eventId")>]
        member _.EventId(state: CalendarEvent, value: CoreTypes.Id) =
            { state with EventId = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: CalendarEvent, value: string) =
            { state with Description = value }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: CalendarEvent, value: CoreTypes.DateTime) =
            { state with EndTime = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: CalendarEvent, value: CoreTypes.DateTime) =
            { state with StartTime = value }

        [<CustomOperation("skipResult")>]
        member _.SkipResult(state: CalendarEvent, value: bool) =
            { state with SkipResult = Some value }

        [<CustomOperation("skipModelUpdate")>]
        member _.SkipModelUpdate(state: CalendarEvent, value: bool) =
            { state with SkipModelUpdate = Some value }

        [<CustomOperation("forceTimeShift")>]
        member _.ForceTimeShift(state: CalendarEvent, value: CoreTypes.Integer) =
            { state with ForceTimeShift = Some value }

    let calendarEvent = CalendarEventBuilder()

    type CategorizationAnalyzerDefinitionBuilder() =
        member _.Yield(_: unit) : CategorizationAnalyzerDefinition =
            {
                CharFilter = None
                Filter = None
                Tokenizer = None
            }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: CategorizationAnalyzerDefinition, value: CoreTypes.CharFilter list) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: CategorizationAnalyzerDefinition, value: CoreTypes.TokenFilter list) =
            { state with Filter = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: CategorizationAnalyzerDefinition, value: CoreTypes.Tokenizer) =
            { state with Tokenizer = Some value }

    let categorizationAnalyzerDefinition = CategorizationAnalyzerDefinitionBuilder()

    type CategoryBuilder() =
        member _.Yield(_: unit) : Category =
            {
                CategoryId = Unchecked.defaultof<_>
                Examples = Unchecked.defaultof<_>
                GrokPattern = None
                JobId = Unchecked.defaultof<_>
                MaxMatchingLength = Unchecked.defaultof<_>
                PartitionFieldName = None
                PartitionFieldValue = None
                Regex = Unchecked.defaultof<_>
                Terms = Unchecked.defaultof<_>
                NumMatches = None
                PreferredToCategories = None
                P = None
                ResultType = Unchecked.defaultof<_>
                Mlcategory = Unchecked.defaultof<_>
            }

        [<CustomOperation("categoryId")>]
        member _.CategoryId(state: Category, value: CoreTypes.Ulong) =
            { state with CategoryId = value }

        [<CustomOperation("examples")>]
        member _.Examples(state: Category, value: string list) =
            { state with Examples = value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: Category, value: CoreTypes.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Category, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("maxMatchingLength")>]
        member _.MaxMatchingLength(state: Category, value: CoreTypes.Ulong) =
            { state with MaxMatchingLength = value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Category, value: string) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: Category, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("regex")>]
        member _.Regex(state: Category, value: string) =
            { state with Regex = value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Category, value: string) =
            { state with Terms = value }

        [<CustomOperation("numMatches")>]
        member _.NumMatches(state: Category, value: CoreTypes.Long) =
            { state with NumMatches = Some value }

        [<CustomOperation("preferredToCategories")>]
        member _.PreferredToCategories(state: Category, value: CoreTypes.Id list) =
            { state with PreferredToCategories = Some value }

        [<CustomOperation("p")>]
        member _.P(state: Category, value: string) =
            { state with P = Some value }

        [<CustomOperation("resultType")>]
        member _.ResultType(state: Category, value: string) =
            { state with ResultType = value }

        [<CustomOperation("mlcategory")>]
        member _.Mlcategory(state: Category, value: string) =
            { state with Mlcategory = value }

    let category = CategoryBuilder()

    type ClassificationInferenceOptionsBuilder() =
        member _.Yield(_: unit) : ClassificationInferenceOptions =
            {
                NumTopClasses = None
                NumTopFeatureImportanceValues = None
                PredictionFieldType = None
                ResultsField = None
                TopClassesResultsField = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: ClassificationInferenceOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: ClassificationInferenceOptions, value: CoreTypes.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

        [<CustomOperation("predictionFieldType")>]
        member _.PredictionFieldType(state: ClassificationInferenceOptions, value: string) =
            { state with PredictionFieldType = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: ClassificationInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("topClassesResultsField")>]
        member _.TopClassesResultsField(state: ClassificationInferenceOptions, value: string) =
            { state with TopClassesResultsField = Some value }

    let classificationInferenceOptions = ClassificationInferenceOptionsBuilder()

    type CommonTokenizationConfigBuilder() =
        member _.Yield(_: unit) : CommonTokenizationConfig =
            {
                DoLowerCase = None
                MaxSequenceLength = None
                Span = None
                Truncate = None
                WithSpecialTokens = None
            }

        [<CustomOperation("doLowerCase")>]
        member _.DoLowerCase(state: CommonTokenizationConfig, value: bool) =
            { state with DoLowerCase = Some value }

        [<CustomOperation("maxSequenceLength")>]
        member _.MaxSequenceLength(state: CommonTokenizationConfig, value: CoreTypes.Integer) =
            { state with MaxSequenceLength = Some value }

        [<CustomOperation("span")>]
        member _.Span(state: CommonTokenizationConfig, value: CoreTypes.Integer) =
            { state with Span = Some value }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: CommonTokenizationConfig, value: MlTypes.TokenizationTruncate) =
            { state with Truncate = Some value }

        [<CustomOperation("withSpecialTokens")>]
        member _.WithSpecialTokens(state: CommonTokenizationConfig, value: bool) =
            { state with WithSpecialTokens = Some value }

    let commonTokenizationConfig = CommonTokenizationConfigBuilder()

    type DataCountsBuilder() =
        member _.Yield(_: unit) : DataCounts =
            {
                BucketCount = Unchecked.defaultof<_>
                EarliestRecordTimestamp = None
                EmptyBucketCount = Unchecked.defaultof<_>
                InputBytes = Unchecked.defaultof<_>
                InputFieldCount = Unchecked.defaultof<_>
                InputRecordCount = Unchecked.defaultof<_>
                InvalidDateCount = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
                LastDataTime = None
                LatestEmptyBucketTimestamp = None
                LatestRecordTimestamp = None
                LatestSparseBucketTimestamp = None
                LatestBucketTimestamp = None
                LogTime = None
                MissingFieldCount = Unchecked.defaultof<_>
                OutOfOrderTimestampCount = Unchecked.defaultof<_>
                ProcessedFieldCount = Unchecked.defaultof<_>
                ProcessedRecordCount = Unchecked.defaultof<_>
                SparseBucketCount = Unchecked.defaultof<_>
            }

        [<CustomOperation("bucketCount")>]
        member _.BucketCount(state: DataCounts, value: CoreTypes.Long) =
            { state with BucketCount = value }

        [<CustomOperation("earliestRecordTimestamp")>]
        member _.EarliestRecordTimestamp(state: DataCounts, value: CoreTypes.Long) =
            { state with EarliestRecordTimestamp = Some value }

        [<CustomOperation("emptyBucketCount")>]
        member _.EmptyBucketCount(state: DataCounts, value: CoreTypes.Long) =
            { state with EmptyBucketCount = value }

        [<CustomOperation("inputBytes")>]
        member _.InputBytes(state: DataCounts, value: CoreTypes.Long) =
            { state with InputBytes = value }

        [<CustomOperation("inputFieldCount")>]
        member _.InputFieldCount(state: DataCounts, value: CoreTypes.Long) =
            { state with InputFieldCount = value }

        [<CustomOperation("inputRecordCount")>]
        member _.InputRecordCount(state: DataCounts, value: CoreTypes.Long) =
            { state with InputRecordCount = value }

        [<CustomOperation("invalidDateCount")>]
        member _.InvalidDateCount(state: DataCounts, value: CoreTypes.Long) =
            { state with InvalidDateCount = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: DataCounts, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("lastDataTime")>]
        member _.LastDataTime(state: DataCounts, value: CoreTypes.Long) =
            { state with LastDataTime = Some value }

        [<CustomOperation("latestEmptyBucketTimestamp")>]
        member _.LatestEmptyBucketTimestamp(state: DataCounts, value: CoreTypes.Long) =
            { state with LatestEmptyBucketTimestamp = Some value }

        [<CustomOperation("latestRecordTimestamp")>]
        member _.LatestRecordTimestamp(state: DataCounts, value: CoreTypes.Long) =
            { state with LatestRecordTimestamp = Some value }

        [<CustomOperation("latestSparseBucketTimestamp")>]
        member _.LatestSparseBucketTimestamp(state: DataCounts, value: CoreTypes.Long) =
            { state with LatestSparseBucketTimestamp = Some value }

        [<CustomOperation("latestBucketTimestamp")>]
        member _.LatestBucketTimestamp(state: DataCounts, value: CoreTypes.Long) =
            { state with LatestBucketTimestamp = Some value }

        [<CustomOperation("logTime")>]
        member _.LogTime(state: DataCounts, value: CoreTypes.Long) =
            { state with LogTime = Some value }

        [<CustomOperation("missingFieldCount")>]
        member _.MissingFieldCount(state: DataCounts, value: CoreTypes.Long) =
            { state with MissingFieldCount = value }

        [<CustomOperation("outOfOrderTimestampCount")>]
        member _.OutOfOrderTimestampCount(state: DataCounts, value: CoreTypes.Long) =
            { state with OutOfOrderTimestampCount = value }

        [<CustomOperation("processedFieldCount")>]
        member _.ProcessedFieldCount(state: DataCounts, value: CoreTypes.Long) =
            { state with ProcessedFieldCount = value }

        [<CustomOperation("processedRecordCount")>]
        member _.ProcessedRecordCount(state: DataCounts, value: CoreTypes.Long) =
            { state with ProcessedRecordCount = value }

        [<CustomOperation("sparseBucketCount")>]
        member _.SparseBucketCount(state: DataCounts, value: CoreTypes.Long) =
            { state with SparseBucketCount = value }

    let dataCounts = DataCountsBuilder()

    type DataDescriptionBuilder() =
        member _.Yield(_: unit) : DataDescription =
            {
                Format = None
                TimeField = None
                TimeFormat = None
                FieldDelimiter = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: DataDescription, value: string) =
            { state with Format = Some value }

        [<CustomOperation("timeField")>]
        member _.TimeField(state: DataDescription, value: CoreTypes.Field) =
            { state with TimeField = Some value }

        [<CustomOperation("timeFormat")>]
        member _.TimeFormat(state: DataDescription, value: string) =
            { state with TimeFormat = Some value }

        [<CustomOperation("fieldDelimiter")>]
        member _.FieldDelimiter(state: DataDescription, value: string) =
            { state with FieldDelimiter = Some value }

    let dataDescription = DataDescriptionBuilder()

    type DatafeedBuilder() =
        member _.Yield(_: unit) : Datafeed =
            {
                Aggregations = None
                Authorization = None
                ChunkingConfig = None
                DatafeedId = Unchecked.defaultof<_>
                Frequency = None
                Indices = Unchecked.defaultof<_>
                Indexes = None
                JobId = Unchecked.defaultof<_>
                MaxEmptySearches = None
                Query = Unchecked.defaultof<_>
                QueryDelay = None
                ScriptFields = None
                ScrollSize = None
                DelayedDataCheckConfig = Unchecked.defaultof<_>
                RuntimeMappings = None
                IndicesOptions = None
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: Datafeed, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("authorization")>]
        member _.Authorization(state: Datafeed, value: MlTypes.DatafeedAuthorization) =
            { state with Authorization = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: Datafeed, value: MlTypes.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: Datafeed, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: Datafeed, value: CoreTypes.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Datafeed, value: string list) =
            { state with Indices = value }

        [<CustomOperation("indexes")>]
        member _.Indexes(state: Datafeed, value: string list) =
            { state with Indexes = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Datafeed, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: Datafeed, value: CoreTypes.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Datafeed, value: CoreTypes.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: Datafeed, value: CoreTypes.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: Datafeed, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: Datafeed, value: CoreTypes.Integer) =
            { state with ScrollSize = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: Datafeed, value: MlTypes.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Datafeed, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: Datafeed, value: CoreTypes.IndicesOptions) =
            { state with IndicesOptions = Some value }

    let datafeed = DatafeedBuilder()

    type DatafeedAuthorizationBuilder() =
        member _.Yield(_: unit) : DatafeedAuthorization =
            {
                ApiKey = None
                Roles = None
                ServiceAccount = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: DatafeedAuthorization, value: MlTypes.ApiKeyAuthorization) =
            { state with ApiKey = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: DatafeedAuthorization, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("serviceAccount")>]
        member _.ServiceAccount(state: DatafeedAuthorization, value: string) =
            { state with ServiceAccount = Some value }

    let datafeedAuthorization = DatafeedAuthorizationBuilder()

    type DatafeedConfigBuilder() =
        member _.Yield(_: unit) : DatafeedConfig =
            {
                Aggregations = None
                ChunkingConfig = None
                DatafeedId = None
                DelayedDataCheckConfig = None
                Frequency = None
                Indices = None
                IndicesOptions = None
                JobId = None
                MaxEmptySearches = None
                Query = None
                QueryDelay = None
                RuntimeMappings = None
                ScriptFields = None
                ScrollSize = None
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: DatafeedConfig, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: DatafeedConfig, value: MlTypes.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: DatafeedConfig, value: CoreTypes.Id) =
            { state with DatafeedId = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: DatafeedConfig, value: MlTypes.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: DatafeedConfig, value: CoreTypes.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: DatafeedConfig, value: CoreTypes.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: DatafeedConfig, value: CoreTypes.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: DatafeedConfig, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: DatafeedConfig, value: CoreTypes.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: DatafeedConfig, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: DatafeedConfig, value: CoreTypes.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: DatafeedConfig, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: DatafeedConfig, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: DatafeedConfig, value: CoreTypes.Integer) =
            { state with ScrollSize = Some value }

    let datafeedConfig = DatafeedConfigBuilder()

    type DatafeedStatsBuilder() =
        member _.Yield(_: unit) : DatafeedStats =
            {
                AssignmentExplanation = None
                DatafeedId = Unchecked.defaultof<_>
                Node = None
                State = Unchecked.defaultof<_>
                TimingStats = None
                RunningState = None
            }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: DatafeedStats, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: DatafeedStats, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("node")>]
        member _.Node(state: DatafeedStats, value: MlTypes.DiscoveryNodeCompact) =
            { state with Node = Some value }

        [<CustomOperation("state")>]
        member _.State(state: DatafeedStats, value: MlTypes.DatafeedState) =
            { state with State = value }

        [<CustomOperation("timingStats")>]
        member _.TimingStats(state: DatafeedStats, value: MlTypes.DatafeedTimingStats) =
            { state with TimingStats = Some value }

        [<CustomOperation("runningState")>]
        member _.RunningState(state: DatafeedStats, value: MlTypes.DatafeedRunningState) =
            { state with RunningState = Some value }

    let datafeedStats = DatafeedStatsBuilder()

    type DatafeedTimingStatsBuilder() =
        member _.Yield(_: unit) : DatafeedTimingStats =
            {
                BucketCount = Unchecked.defaultof<_>
                ExponentialAverageSearchTimePerHourMs = Unchecked.defaultof<_>
                ExponentialAverageCalculationContext = None
                JobId = Unchecked.defaultof<_>
                SearchCount = Unchecked.defaultof<_>
                TotalSearchTimeMs = Unchecked.defaultof<_>
                AverageSearchTimePerBucketMs = None
            }

        [<CustomOperation("bucketCount")>]
        member _.BucketCount(state: DatafeedTimingStats, value: CoreTypes.Long) =
            { state with BucketCount = value }

        [<CustomOperation("exponentialAverageSearchTimePerHourMs")>]
        member _.ExponentialAverageSearchTimePerHourMs(state: DatafeedTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with ExponentialAverageSearchTimePerHourMs = value }

        [<CustomOperation("exponentialAverageCalculationContext")>]
        member _.ExponentialAverageCalculationContext(state: DatafeedTimingStats, value: MlTypes.ExponentialAverageCalculationContext) =
            { state with ExponentialAverageCalculationContext = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: DatafeedTimingStats, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("searchCount")>]
        member _.SearchCount(state: DatafeedTimingStats, value: CoreTypes.Long) =
            { state with SearchCount = value }

        [<CustomOperation("totalSearchTimeMs")>]
        member _.TotalSearchTimeMs(state: DatafeedTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with TotalSearchTimeMs = value }

        [<CustomOperation("averageSearchTimePerBucketMs")>]
        member _.AverageSearchTimePerBucketMs(state: DatafeedTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with AverageSearchTimePerBucketMs = Some value }

    let datafeedTimingStats = DatafeedTimingStatsBuilder()

    type DataframeAnalysisBuilder() =
        member _.Yield(_: unit) : DataframeAnalysis =
            {
                Alpha = None
                DependentVariable = Unchecked.defaultof<_>
                DownsampleFactor = None
                EarlyStoppingEnabled = None
                Eta = None
                EtaGrowthRatePerTree = None
                FeatureBagFraction = None
                FeatureProcessors = None
                Gamma = None
                Lambda = None
                MaxOptimizationRoundsPerHyperparameter = None
                MaxTrees = None
                NumTopFeatureImportanceValues = None
                PredictionFieldName = None
                RandomizeSeed = None
                SoftTreeDepthLimit = None
                SoftTreeDepthTolerance = None
                TrainingPercent = None
            }

        [<CustomOperation("alpha")>]
        member _.Alpha(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with Alpha = Some value }

        [<CustomOperation("dependentVariable")>]
        member _.DependentVariable(state: DataframeAnalysis, value: string) =
            { state with DependentVariable = value }

        [<CustomOperation("downsampleFactor")>]
        member _.DownsampleFactor(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with DownsampleFactor = Some value }

        [<CustomOperation("earlyStoppingEnabled")>]
        member _.EarlyStoppingEnabled(state: DataframeAnalysis, value: bool) =
            { state with EarlyStoppingEnabled = Some value }

        [<CustomOperation("eta")>]
        member _.Eta(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with Eta = Some value }

        [<CustomOperation("etaGrowthRatePerTree")>]
        member _.EtaGrowthRatePerTree(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with EtaGrowthRatePerTree = Some value }

        [<CustomOperation("featureBagFraction")>]
        member _.FeatureBagFraction(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with FeatureBagFraction = Some value }

        [<CustomOperation("featureProcessors")>]
        member _.FeatureProcessors(state: DataframeAnalysis, value: MlTypes.DataframeAnalysisFeatureProcessor list) =
            { state with FeatureProcessors = Some value }

        [<CustomOperation("gamma")>]
        member _.Gamma(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with Gamma = Some value }

        [<CustomOperation("lambda")>]
        member _.Lambda(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with Lambda = Some value }

        [<CustomOperation("maxOptimizationRoundsPerHyperparameter")>]
        member _.MaxOptimizationRoundsPerHyperparameter(state: DataframeAnalysis, value: CoreTypes.Integer) =
            { state with MaxOptimizationRoundsPerHyperparameter = Some value }

        [<CustomOperation("maxTrees")>]
        member _.MaxTrees(state: DataframeAnalysis, value: CoreTypes.Integer) =
            { state with MaxTrees = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: DataframeAnalysis, value: CoreTypes.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

        [<CustomOperation("predictionFieldName")>]
        member _.PredictionFieldName(state: DataframeAnalysis, value: CoreTypes.Field) =
            { state with PredictionFieldName = Some value }

        [<CustomOperation("randomizeSeed")>]
        member _.RandomizeSeed(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with RandomizeSeed = Some value }

        [<CustomOperation("softTreeDepthLimit")>]
        member _.SoftTreeDepthLimit(state: DataframeAnalysis, value: CoreTypes.Integer) =
            { state with SoftTreeDepthLimit = Some value }

        [<CustomOperation("softTreeDepthTolerance")>]
        member _.SoftTreeDepthTolerance(state: DataframeAnalysis, value: CoreTypes.Double) =
            { state with SoftTreeDepthTolerance = Some value }

        [<CustomOperation("trainingPercent")>]
        member _.TrainingPercent(state: DataframeAnalysis, value: CoreTypes.Percentage) =
            { state with TrainingPercent = Some value }

    let dataframeAnalysis = DataframeAnalysisBuilder()

    type DataframeAnalysisAnalyzedFieldsBuilder() =
        member _.Yield(_: unit) : DataframeAnalysisAnalyzedFields =
            {
                Includes = None
                Excludes = None
            }

        [<CustomOperation("includes")>]
        member _.Includes(state: DataframeAnalysisAnalyzedFields, value: string list) =
            { state with Includes = Some value }

        [<CustomOperation("excludes")>]
        member _.Excludes(state: DataframeAnalysisAnalyzedFields, value: string list) =
            { state with Excludes = Some value }

    let dataframeAnalysisAnalyzedFields = DataframeAnalysisAnalyzedFieldsBuilder()

    let ofIncludes (value: string list) : DataframeAnalysisAnalyzedFields =
        {
            Includes = value
            Excludes = None
        }

    type DataframeAnalysisClassificationBuilder() =
        member _.Yield(_: unit) : DataframeAnalysisClassification =
            {
                ClassAssignmentObjective = None
                NumTopClasses = None
            }

        [<CustomOperation("classAssignmentObjective")>]
        member _.ClassAssignmentObjective(state: DataframeAnalysisClassification, value: string) =
            { state with ClassAssignmentObjective = Some value }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: DataframeAnalysisClassification, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

    let dataframeAnalysisClassification = DataframeAnalysisClassificationBuilder()

    module DataframeAnalysis =

        let classification (value: MlTypes.DataframeAnalysisClassification) =
            DataframeAnalysisContainer.Classification value

        let outlierDetection (value: MlTypes.DataframeAnalysisOutlierDetection) =
            DataframeAnalysisContainer.OutlierDetection value

        let regression (value: MlTypes.DataframeAnalysisRegression) =
            DataframeAnalysisContainer.Regression value

    module DataframeAnalysisFeatureProcessor =

        let frequencyEncoding (value: MlTypes.DataframeAnalysisFeatureProcessorFrequencyEncoding) =
            DataframeAnalysisFeatureProcessor.FrequencyEncoding value

        let multiEncoding (value: MlTypes.DataframeAnalysisFeatureProcessorMultiEncoding) =
            DataframeAnalysisFeatureProcessor.MultiEncoding value

        let nGramEncoding (value: MlTypes.DataframeAnalysisFeatureProcessorNGramEncoding) =
            DataframeAnalysisFeatureProcessor.NGramEncoding value

        let oneHotEncoding (value: MlTypes.DataframeAnalysisFeatureProcessorOneHotEncoding) =
            DataframeAnalysisFeatureProcessor.OneHotEncoding value

        let targetMeanEncoding (value: MlTypes.DataframeAnalysisFeatureProcessorTargetMeanEncoding) =
            DataframeAnalysisFeatureProcessor.TargetMeanEncoding value

    type DataframeAnalysisFeatureProcessorNGramEncodingBuilder() =
        member _.Yield(_: unit) : DataframeAnalysisFeatureProcessorNGramEncoding =
            {
                FeaturePrefix = None
                Field = Unchecked.defaultof<_>
                Length = None
                NGrams = Unchecked.defaultof<_>
                Start = None
                Custom = None
            }

        [<CustomOperation("featurePrefix")>]
        member _.FeaturePrefix(state: DataframeAnalysisFeatureProcessorNGramEncoding, value: string) =
            { state with FeaturePrefix = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: DataframeAnalysisFeatureProcessorNGramEncoding, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("length")>]
        member _.Length(state: DataframeAnalysisFeatureProcessorNGramEncoding, value: CoreTypes.Integer) =
            { state with Length = Some value }

        [<CustomOperation("nGrams")>]
        member _.NGrams(state: DataframeAnalysisFeatureProcessorNGramEncoding, value: CoreTypes.Integer list) =
            { state with NGrams = value }

        [<CustomOperation("start")>]
        member _.Start(state: DataframeAnalysisFeatureProcessorNGramEncoding, value: CoreTypes.Integer) =
            { state with Start = Some value }

        [<CustomOperation("custom")>]
        member _.Custom(state: DataframeAnalysisFeatureProcessorNGramEncoding, value: bool) =
            { state with Custom = Some value }

    let dataframeAnalysisFeatureProcessorNGramEncoding = DataframeAnalysisFeatureProcessorNGramEncodingBuilder()

    type DataframeAnalysisOutlierDetectionBuilder() =
        member _.Yield(_: unit) : DataframeAnalysisOutlierDetection =
            {
                ComputeFeatureInfluence = None
                FeatureInfluenceThreshold = None
                Method = None
                NNeighbors = None
                OutlierFraction = None
                StandardizationEnabled = None
            }

        [<CustomOperation("computeFeatureInfluence")>]
        member _.ComputeFeatureInfluence(state: DataframeAnalysisOutlierDetection, value: bool) =
            { state with ComputeFeatureInfluence = Some value }

        [<CustomOperation("featureInfluenceThreshold")>]
        member _.FeatureInfluenceThreshold(state: DataframeAnalysisOutlierDetection, value: CoreTypes.Double) =
            { state with FeatureInfluenceThreshold = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: DataframeAnalysisOutlierDetection, value: string) =
            { state with Method = Some value }

        [<CustomOperation("nNeighbors")>]
        member _.NNeighbors(state: DataframeAnalysisOutlierDetection, value: CoreTypes.Integer) =
            { state with NNeighbors = Some value }

        [<CustomOperation("outlierFraction")>]
        member _.OutlierFraction(state: DataframeAnalysisOutlierDetection, value: CoreTypes.Double) =
            { state with OutlierFraction = Some value }

        [<CustomOperation("standardizationEnabled")>]
        member _.StandardizationEnabled(state: DataframeAnalysisOutlierDetection, value: bool) =
            { state with StandardizationEnabled = Some value }

    let dataframeAnalysisOutlierDetection = DataframeAnalysisOutlierDetectionBuilder()

    type DataframeAnalysisRegressionBuilder() =
        member _.Yield(_: unit) : DataframeAnalysisRegression =
            {
                LossFunction = None
                LossFunctionParameter = None
            }

        [<CustomOperation("lossFunction")>]
        member _.LossFunction(state: DataframeAnalysisRegression, value: string) =
            { state with LossFunction = Some value }

        [<CustomOperation("lossFunctionParameter")>]
        member _.LossFunctionParameter(state: DataframeAnalysisRegression, value: CoreTypes.Double) =
            { state with LossFunctionParameter = Some value }

    let dataframeAnalysisRegression = DataframeAnalysisRegressionBuilder()

    type DataframeAnalyticsBuilder() =
        member _.Yield(_: unit) : DataframeAnalytics =
            {
                AnalysisStats = None
                AssignmentExplanation = None
                DataCounts = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                MemoryUsage = Unchecked.defaultof<_>
                Node = None
                Progress = Unchecked.defaultof<_>
                State = Unchecked.defaultof<_>
            }

        [<CustomOperation("analysisStats")>]
        member _.AnalysisStats(state: DataframeAnalytics, value: MlTypes.DataframeAnalyticsStatsContainer) =
            { state with AnalysisStats = Some value }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: DataframeAnalytics, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("dataCounts")>]
        member _.DataCounts(state: DataframeAnalytics, value: MlTypes.DataframeAnalyticsStatsDataCounts) =
            { state with DataCounts = value }

        [<CustomOperation("id")>]
        member _.Id(state: DataframeAnalytics, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("memoryUsage")>]
        member _.MemoryUsage(state: DataframeAnalytics, value: MlTypes.DataframeAnalyticsStatsMemoryUsage) =
            { state with MemoryUsage = value }

        [<CustomOperation("node")>]
        member _.Node(state: DataframeAnalytics, value: CoreTypes.NodeAttributes) =
            { state with Node = Some value }

        [<CustomOperation("progress")>]
        member _.Progress(state: DataframeAnalytics, value: MlTypes.DataframeAnalyticsStatsProgress list) =
            { state with Progress = value }

        [<CustomOperation("state")>]
        member _.State(state: DataframeAnalytics, value: MlTypes.DataframeState) =
            { state with State = value }

    let dataframeAnalytics = DataframeAnalyticsBuilder()

    type DataframeAnalyticsAuthorizationBuilder() =
        member _.Yield(_: unit) : DataframeAnalyticsAuthorization =
            {
                ApiKey = None
                Roles = None
                ServiceAccount = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: DataframeAnalyticsAuthorization, value: MlTypes.ApiKeyAuthorization) =
            { state with ApiKey = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: DataframeAnalyticsAuthorization, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("serviceAccount")>]
        member _.ServiceAccount(state: DataframeAnalyticsAuthorization, value: string) =
            { state with ServiceAccount = Some value }

    let dataframeAnalyticsAuthorization = DataframeAnalyticsAuthorizationBuilder()

    type DataframeAnalyticsFieldSelectionBuilder() =
        member _.Yield(_: unit) : DataframeAnalyticsFieldSelection =
            {
                IsIncluded = Unchecked.defaultof<_>
                IsRequired = Unchecked.defaultof<_>
                FeatureType = None
                MappingTypes = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                Reason = None
            }

        [<CustomOperation("isIncluded")>]
        member _.IsIncluded(state: DataframeAnalyticsFieldSelection, value: bool) =
            { state with IsIncluded = value }

        [<CustomOperation("isRequired")>]
        member _.IsRequired(state: DataframeAnalyticsFieldSelection, value: bool) =
            { state with IsRequired = value }

        [<CustomOperation("featureType")>]
        member _.FeatureType(state: DataframeAnalyticsFieldSelection, value: string) =
            { state with FeatureType = Some value }

        [<CustomOperation("mappingTypes")>]
        member _.MappingTypes(state: DataframeAnalyticsFieldSelection, value: string list) =
            { state with MappingTypes = value }

        [<CustomOperation("name")>]
        member _.Name(state: DataframeAnalyticsFieldSelection, value: CoreTypes.Field) =
            { state with Name = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: DataframeAnalyticsFieldSelection, value: string) =
            { state with Reason = Some value }

    let dataframeAnalyticsFieldSelection = DataframeAnalyticsFieldSelectionBuilder()

    type DataframeAnalyticsSourceBuilder() =
        member _.Yield(_: unit) : DataframeAnalyticsSource =
            {
                Index = Unchecked.defaultof<_>
                Query = None
                RuntimeMappings = None
                Source = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: DataframeAnalyticsSource, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: DataframeAnalyticsSource, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: DataframeAnalyticsSource, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: DataframeAnalyticsSource, value: MlTypes.DataframeAnalysisAnalyzedFields) =
            { state with Source = Some value }

    let dataframeAnalyticsSource = DataframeAnalyticsSourceBuilder()

    module DataframeAnalyticsStats =

        let classificationStats (value: MlTypes.DataframeAnalyticsStatsHyperparameters) =
            DataframeAnalyticsStatsContainer.ClassificationStats value

        let outlierDetectionStats (value: MlTypes.DataframeAnalyticsStatsOutlierDetection) =
            DataframeAnalyticsStatsContainer.OutlierDetectionStats value

        let regressionStats (value: MlTypes.DataframeAnalyticsStatsHyperparameters) =
            DataframeAnalyticsStatsContainer.RegressionStats value

    type DataframeAnalyticsStatsMemoryUsageBuilder() =
        member _.Yield(_: unit) : DataframeAnalyticsStatsMemoryUsage =
            {
                MemoryReestimateBytes = None
                PeakUsageBytes = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
                Timestamp = None
            }

        [<CustomOperation("memoryReestimateBytes")>]
        member _.MemoryReestimateBytes(state: DataframeAnalyticsStatsMemoryUsage, value: CoreTypes.Long) =
            { state with MemoryReestimateBytes = Some value }

        [<CustomOperation("peakUsageBytes")>]
        member _.PeakUsageBytes(state: DataframeAnalyticsStatsMemoryUsage, value: CoreTypes.Long) =
            { state with PeakUsageBytes = value }

        [<CustomOperation("status")>]
        member _.Status(state: DataframeAnalyticsStatsMemoryUsage, value: string) =
            { state with Status = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: DataframeAnalyticsStatsMemoryUsage, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with Timestamp = Some value }

    let dataframeAnalyticsStatsMemoryUsage = DataframeAnalyticsStatsMemoryUsageBuilder()

    type DataframeAnalyticsSummaryBuilder() =
        member _.Yield(_: unit) : DataframeAnalyticsSummary =
            {
                AllowLazyStart = None
                Analysis = Unchecked.defaultof<_>
                AnalyzedFields = None
                Authorization = None
                CreateTime = None
                Description = None
                Dest = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                MaxNumThreads = None
                ModelMemoryLimit = None
                Source = Unchecked.defaultof<_>
                Version = None
                Meta = None
            }

        [<CustomOperation("allowLazyStart")>]
        member _.AllowLazyStart(state: DataframeAnalyticsSummary, value: bool) =
            { state with AllowLazyStart = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: DataframeAnalyticsSummary, value: MlTypes.DataframeAnalysisContainer) =
            { state with Analysis = value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: DataframeAnalyticsSummary, value: MlTypes.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

        [<CustomOperation("authorization")>]
        member _.Authorization(state: DataframeAnalyticsSummary, value: MlTypes.DataframeAnalyticsAuthorization) =
            { state with Authorization = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: DataframeAnalyticsSummary, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CreateTime = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: DataframeAnalyticsSummary, value: string) =
            { state with Description = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: DataframeAnalyticsSummary, value: MlTypes.DataframeAnalyticsDestination) =
            { state with Dest = value }

        [<CustomOperation("id")>]
        member _.Id(state: DataframeAnalyticsSummary, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: DataframeAnalyticsSummary, value: CoreTypes.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: DataframeAnalyticsSummary, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: DataframeAnalyticsSummary, value: MlTypes.DataframeAnalyticsSource) =
            { state with Source = value }

        [<CustomOperation("version")>]
        member _.Version(state: DataframeAnalyticsSummary, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: DataframeAnalyticsSummary, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

    let dataframeAnalyticsSummary = DataframeAnalyticsSummaryBuilder()

    type DataframeEvaluationClassificationBuilder() =
        member _.Yield(_: unit) : DataframeEvaluationClassification =
            {
                ActualField = Unchecked.defaultof<_>
                PredictedField = None
                TopClassesField = None
                Metrics = None
            }

        [<CustomOperation("actualField")>]
        member _.ActualField(state: DataframeEvaluationClassification, value: CoreTypes.Field) =
            { state with ActualField = value }

        [<CustomOperation("predictedField")>]
        member _.PredictedField(state: DataframeEvaluationClassification, value: CoreTypes.Field) =
            { state with PredictedField = Some value }

        [<CustomOperation("topClassesField")>]
        member _.TopClassesField(state: DataframeEvaluationClassification, value: CoreTypes.Field) =
            { state with TopClassesField = Some value }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: DataframeEvaluationClassification, value: MlTypes.DataframeEvaluationClassificationMetrics) =
            { state with Metrics = Some value }

    let dataframeEvaluationClassification = DataframeEvaluationClassificationBuilder()

    type DataframeEvaluationClassificationMetricsBuilder() =
        member _.Yield(_: unit) : DataframeEvaluationClassificationMetrics =
            {
                Accuracy = None
                MulticlassConfusionMatrix = None
            }

        [<CustomOperation("accuracy")>]
        member _.Accuracy(state: DataframeEvaluationClassificationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Accuracy = Some value }

        [<CustomOperation("multiclassConfusionMatrix")>]
        member _.MulticlassConfusionMatrix(state: DataframeEvaluationClassificationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with MulticlassConfusionMatrix = Some value }

    let dataframeEvaluationClassificationMetrics = DataframeEvaluationClassificationMetricsBuilder()

    type DataframeEvaluationClassificationMetricsAucRocBuilder() =
        member _.Yield(_: unit) : DataframeEvaluationClassificationMetricsAucRoc =
            {
                ClassName = None
                IncludeCurve = None
            }

        [<CustomOperation("className")>]
        member _.ClassName(state: DataframeEvaluationClassificationMetricsAucRoc, value: CoreTypes.Name) =
            { state with ClassName = Some value }

        [<CustomOperation("includeCurve")>]
        member _.IncludeCurve(state: DataframeEvaluationClassificationMetricsAucRoc, value: bool) =
            { state with IncludeCurve = Some value }

    let dataframeEvaluationClassificationMetricsAucRoc = DataframeEvaluationClassificationMetricsAucRocBuilder()

    module DataframeEvaluation =

        let classification (value: MlTypes.DataframeEvaluationClassification) =
            DataframeEvaluationContainer.Classification value

        let outlierDetection (value: MlTypes.DataframeEvaluationOutlierDetection) =
            DataframeEvaluationContainer.OutlierDetection value

        let regression (value: MlTypes.DataframeEvaluationRegression) =
            DataframeEvaluationContainer.Regression value

    type DataframeEvaluationMetricsBuilder() =
        member _.Yield(_: unit) : DataframeEvaluationMetrics =
            {
                AucRoc = None
                Precision = None
                Recall = None
            }

        [<CustomOperation("aucRoc")>]
        member _.AucRoc(state: DataframeEvaluationMetrics, value: MlTypes.DataframeEvaluationClassificationMetricsAucRoc) =
            { state with AucRoc = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: DataframeEvaluationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: DataframeEvaluationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Recall = Some value }

    let dataframeEvaluationMetrics = DataframeEvaluationMetricsBuilder()

    type DataframeEvaluationRegressionMetricsBuilder() =
        member _.Yield(_: unit) : DataframeEvaluationRegressionMetrics =
            {
                Mse = None
                Msle = None
                Huber = None
                RSquared = None
            }

        [<CustomOperation("mse")>]
        member _.Mse(state: DataframeEvaluationRegressionMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Mse = Some value }

        [<CustomOperation("msle")>]
        member _.Msle(state: DataframeEvaluationRegressionMetrics, value: MlTypes.DataframeEvaluationRegressionMetricsMsle) =
            { state with Msle = Some value }

        [<CustomOperation("huber")>]
        member _.Huber(state: DataframeEvaluationRegressionMetrics, value: MlTypes.DataframeEvaluationRegressionMetricsHuber) =
            { state with Huber = Some value }

        [<CustomOperation("rSquared")>]
        member _.RSquared(state: DataframeEvaluationRegressionMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with RSquared = Some value }

    let dataframeEvaluationRegressionMetrics = DataframeEvaluationRegressionMetricsBuilder()

    type DetectionRuleBuilder() =
        member _.Yield(_: unit) : DetectionRule =
            {
                Actions = None
                Conditions = None
                Scope = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: DetectionRule, value: MlTypes.RuleAction list) =
            { state with Actions = Some value }

        [<CustomOperation("conditions")>]
        member _.Conditions(state: DetectionRule, value: MlTypes.RuleCondition list) =
            { state with Conditions = Some value }

        [<CustomOperation("scope")>]
        member _.Scope(state: DetectionRule, value: Map<CoreTypes.Field, MlTypes.FilterRef>) =
            { state with Scope = Some value }

    let detectionRule = DetectionRuleBuilder()

    type DetectorBuilder() =
        member _.Yield(_: unit) : Detector =
            {
                ByFieldName = None
                CustomRules = None
                DetectorDescription = None
                DetectorIndex = None
                ExcludeFrequent = None
                FieldName = None
                Function = None
                OverFieldName = None
                PartitionFieldName = None
                UseNull = None
            }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: Detector, value: CoreTypes.Field) =
            { state with ByFieldName = Some value }

        [<CustomOperation("customRules")>]
        member _.CustomRules(state: Detector, value: MlTypes.DetectionRule list) =
            { state with CustomRules = Some value }

        [<CustomOperation("detectorDescription")>]
        member _.DetectorDescription(state: Detector, value: string) =
            { state with DetectorDescription = Some value }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: Detector, value: CoreTypes.Integer) =
            { state with DetectorIndex = Some value }

        [<CustomOperation("excludeFrequent")>]
        member _.ExcludeFrequent(state: Detector, value: MlTypes.ExcludeFrequent) =
            { state with ExcludeFrequent = Some value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: Detector, value: CoreTypes.Field) =
            { state with FieldName = Some value }

        [<CustomOperation("function'")>]
        member _.Function(state: Detector, value: string) =
            { state with Function = Some value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: Detector, value: CoreTypes.Field) =
            { state with OverFieldName = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Detector, value: CoreTypes.Field) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("useNull")>]
        member _.UseNull(state: Detector, value: bool) =
            { state with UseNull = Some value }

    let detector = DetectorBuilder()

    type DetectorReadBuilder() =
        member _.Yield(_: unit) : DetectorRead =
            {
                Function = Unchecked.defaultof<_>
                ByFieldName = None
                CustomRules = None
                DetectorDescription = None
                DetectorIndex = None
                ExcludeFrequent = None
                FieldName = None
                OverFieldName = None
                PartitionFieldName = None
                UseNull = None
            }

        [<CustomOperation("function'")>]
        member _.Function(state: DetectorRead, value: string) =
            { state with Function = value }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: DetectorRead, value: CoreTypes.Field) =
            { state with ByFieldName = Some value }

        [<CustomOperation("customRules")>]
        member _.CustomRules(state: DetectorRead, value: MlTypes.DetectionRule list) =
            { state with CustomRules = Some value }

        [<CustomOperation("detectorDescription")>]
        member _.DetectorDescription(state: DetectorRead, value: string) =
            { state with DetectorDescription = Some value }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: DetectorRead, value: CoreTypes.Integer) =
            { state with DetectorIndex = Some value }

        [<CustomOperation("excludeFrequent")>]
        member _.ExcludeFrequent(state: DetectorRead, value: MlTypes.ExcludeFrequent) =
            { state with ExcludeFrequent = Some value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: DetectorRead, value: CoreTypes.Field) =
            { state with FieldName = Some value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: DetectorRead, value: CoreTypes.Field) =
            { state with OverFieldName = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: DetectorRead, value: CoreTypes.Field) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("useNull")>]
        member _.UseNull(state: DetectorRead, value: bool) =
            { state with UseNull = Some value }

    let detectorRead = DetectorReadBuilder()

    type DetectorUpdateBuilder() =
        member _.Yield(_: unit) : DetectorUpdate =
            {
                DetectorIndex = Unchecked.defaultof<_>
                Description = None
                CustomRules = None
            }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: DetectorUpdate, value: CoreTypes.Integer) =
            { state with DetectorIndex = value }

        [<CustomOperation("description")>]
        member _.Description(state: DetectorUpdate, value: string) =
            { state with Description = Some value }

        [<CustomOperation("customRules")>]
        member _.CustomRules(state: DetectorUpdate, value: MlTypes.DetectionRule list) =
            { state with CustomRules = Some value }

    let detectorUpdate = DetectorUpdateBuilder()

    type ExponentialAverageCalculationContextBuilder() =
        member _.Yield(_: unit) : ExponentialAverageCalculationContext =
            {
                IncrementalMetricValueMs = Unchecked.defaultof<_>
                LatestTimestamp = None
                PreviousExponentialAverageMs = None
            }

        [<CustomOperation("incrementalMetricValueMs")>]
        member _.IncrementalMetricValueMs(state: ExponentialAverageCalculationContext, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with IncrementalMetricValueMs = value }

        [<CustomOperation("latestTimestamp")>]
        member _.LatestTimestamp(state: ExponentialAverageCalculationContext, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with LatestTimestamp = Some value }

        [<CustomOperation("previousExponentialAverageMs")>]
        member _.PreviousExponentialAverageMs(state: ExponentialAverageCalculationContext, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with PreviousExponentialAverageMs = Some value }

    let exponentialAverageCalculationContext = ExponentialAverageCalculationContextBuilder()

    type FillMaskInferenceOptionsBuilder() =
        member _.Yield(_: unit) : FillMaskInferenceOptions =
            {
                MaskToken = None
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("maskToken")>]
        member _.MaskToken(state: FillMaskInferenceOptions, value: string) =
            { state with MaskToken = Some value }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: FillMaskInferenceOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: FillMaskInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: FillMaskInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: FillMaskInferenceOptions, value: MlTypes.Vocabulary) =
            { state with Vocabulary = Some value }

    let fillMaskInferenceOptions = FillMaskInferenceOptionsBuilder()

    type FillMaskInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : FillMaskInferenceUpdateOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: FillMaskInferenceUpdateOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: FillMaskInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: FillMaskInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let fillMaskInferenceUpdateOptions = FillMaskInferenceUpdateOptionsBuilder()

    type GeoResultsBuilder() =
        member _.Yield(_: unit) : GeoResults =
            {
                ActualPoint = None
                TypicalPoint = None
            }

        [<CustomOperation("actualPoint")>]
        member _.ActualPoint(state: GeoResults, value: string) =
            { state with ActualPoint = Some value }

        [<CustomOperation("typicalPoint")>]
        member _.TypicalPoint(state: GeoResults, value: string) =
            { state with TypicalPoint = Some value }

    let geoResults = GeoResultsBuilder()

    type HyperparameterBuilder() =
        member _.Yield(_: unit) : Hyperparameter =
            {
                AbsoluteImportance = None
                Name = Unchecked.defaultof<_>
                RelativeImportance = None
                Supplied = Unchecked.defaultof<_>
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("absoluteImportance")>]
        member _.AbsoluteImportance(state: Hyperparameter, value: CoreTypes.Double) =
            { state with AbsoluteImportance = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Hyperparameter, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("relativeImportance")>]
        member _.RelativeImportance(state: Hyperparameter, value: CoreTypes.Double) =
            { state with RelativeImportance = Some value }

        [<CustomOperation("supplied")>]
        member _.Supplied(state: Hyperparameter, value: bool) =
            { state with Supplied = value }

        [<CustomOperation("value")>]
        member _.Value(state: Hyperparameter, value: CoreTypes.Double) =
            { state with Value = value }

    let hyperparameter = HyperparameterBuilder()

    type HyperparametersBuilder() =
        member _.Yield(_: unit) : Hyperparameters =
            {
                Alpha = None
                Lambda = None
                Gamma = None
                Eta = None
                EtaGrowthRatePerTree = None
                FeatureBagFraction = None
                DownsampleFactor = None
                MaxAttemptsToAddTree = None
                MaxOptimizationRoundsPerHyperparameter = None
                MaxTrees = None
                NumFolds = None
                NumSplitsPerFeature = None
                SoftTreeDepthLimit = None
                SoftTreeDepthTolerance = None
            }

        [<CustomOperation("alpha")>]
        member _.Alpha(state: Hyperparameters, value: CoreTypes.Double) =
            { state with Alpha = Some value }

        [<CustomOperation("lambda")>]
        member _.Lambda(state: Hyperparameters, value: CoreTypes.Double) =
            { state with Lambda = Some value }

        [<CustomOperation("gamma")>]
        member _.Gamma(state: Hyperparameters, value: CoreTypes.Double) =
            { state with Gamma = Some value }

        [<CustomOperation("eta")>]
        member _.Eta(state: Hyperparameters, value: CoreTypes.Double) =
            { state with Eta = Some value }

        [<CustomOperation("etaGrowthRatePerTree")>]
        member _.EtaGrowthRatePerTree(state: Hyperparameters, value: CoreTypes.Double) =
            { state with EtaGrowthRatePerTree = Some value }

        [<CustomOperation("featureBagFraction")>]
        member _.FeatureBagFraction(state: Hyperparameters, value: CoreTypes.Double) =
            { state with FeatureBagFraction = Some value }

        [<CustomOperation("downsampleFactor")>]
        member _.DownsampleFactor(state: Hyperparameters, value: CoreTypes.Double) =
            { state with DownsampleFactor = Some value }

        [<CustomOperation("maxAttemptsToAddTree")>]
        member _.MaxAttemptsToAddTree(state: Hyperparameters, value: CoreTypes.Integer) =
            { state with MaxAttemptsToAddTree = Some value }

        [<CustomOperation("maxOptimizationRoundsPerHyperparameter")>]
        member _.MaxOptimizationRoundsPerHyperparameter(state: Hyperparameters, value: CoreTypes.Integer) =
            { state with MaxOptimizationRoundsPerHyperparameter = Some value }

        [<CustomOperation("maxTrees")>]
        member _.MaxTrees(state: Hyperparameters, value: CoreTypes.Integer) =
            { state with MaxTrees = Some value }

        [<CustomOperation("numFolds")>]
        member _.NumFolds(state: Hyperparameters, value: CoreTypes.Integer) =
            { state with NumFolds = Some value }

        [<CustomOperation("numSplitsPerFeature")>]
        member _.NumSplitsPerFeature(state: Hyperparameters, value: CoreTypes.Integer) =
            { state with NumSplitsPerFeature = Some value }

        [<CustomOperation("softTreeDepthLimit")>]
        member _.SoftTreeDepthLimit(state: Hyperparameters, value: CoreTypes.Integer) =
            { state with SoftTreeDepthLimit = Some value }

        [<CustomOperation("softTreeDepthTolerance")>]
        member _.SoftTreeDepthTolerance(state: Hyperparameters, value: CoreTypes.Double) =
            { state with SoftTreeDepthTolerance = Some value }

    let hyperparameters = HyperparametersBuilder()

    module InferenceConfigCreate =

        let regression (value: MlTypes.RegressionInferenceOptions) =
            InferenceConfigCreateContainer.Regression value

        let classification (value: MlTypes.ClassificationInferenceOptions) =
            InferenceConfigCreateContainer.Classification value

        let textClassification (value: MlTypes.TextClassificationInferenceOptions) =
            InferenceConfigCreateContainer.TextClassification value

        let zeroShotClassification (value: MlTypes.ZeroShotClassificationInferenceOptions) =
            InferenceConfigCreateContainer.ZeroShotClassification value

        let fillMask (value: MlTypes.FillMaskInferenceOptions) =
            InferenceConfigCreateContainer.FillMask value

        let learningToRank (value: MlTypes.LearningToRankConfig) =
            InferenceConfigCreateContainer.LearningToRank value

        let ner (value: MlTypes.NerInferenceOptions) =
            InferenceConfigCreateContainer.Ner value

        let passThrough (value: MlTypes.PassThroughInferenceOptions) =
            InferenceConfigCreateContainer.PassThrough value

        let textEmbedding (value: MlTypes.TextEmbeddingInferenceOptions) =
            InferenceConfigCreateContainer.TextEmbedding value

        let textExpansion (value: MlTypes.TextExpansionInferenceOptions) =
            InferenceConfigCreateContainer.TextExpansion value

        let questionAnswering (value: MlTypes.QuestionAnsweringInferenceOptions) =
            InferenceConfigCreateContainer.QuestionAnswering value

    module InferenceConfigUpdate =

        let regression (value: MlTypes.RegressionInferenceOptions) =
            InferenceConfigUpdateContainer.Regression value

        let classification (value: MlTypes.ClassificationInferenceOptions) =
            InferenceConfigUpdateContainer.Classification value

        let textClassification (value: MlTypes.TextClassificationInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.TextClassification value

        let zeroShotClassification (value: MlTypes.ZeroShotClassificationInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.ZeroShotClassification value

        let fillMask (value: MlTypes.FillMaskInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.FillMask value

        let ner (value: MlTypes.NerInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.Ner value

        let passThrough (value: MlTypes.PassThroughInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.PassThrough value

        let textEmbedding (value: MlTypes.TextEmbeddingInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.TextEmbedding value

        let textExpansion (value: MlTypes.TextExpansionInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.TextExpansion value

        let questionAnswering (value: MlTypes.QuestionAnsweringInferenceUpdateOptions) =
            InferenceConfigUpdateContainer.QuestionAnswering value

    type InferenceResponseResultBuilder() =
        member _.Yield(_: unit) : InferenceResponseResult =
            {
                Entities = None
                IsTruncated = None
                PredictedValue = None
                PredictedValueSequence = None
                PredictionProbability = None
                PredictionScore = None
                TopClasses = None
                Warning = None
                FeatureImportance = None
            }

        [<CustomOperation("entities")>]
        member _.Entities(state: InferenceResponseResult, value: MlTypes.TrainedModelEntities list) =
            { state with Entities = Some value }

        [<CustomOperation("isTruncated")>]
        member _.IsTruncated(state: InferenceResponseResult, value: bool) =
            { state with IsTruncated = Some value }

        [<CustomOperation("predictedValue")>]
        member _.PredictedValue(state: InferenceResponseResult, value: System.Text.Json.JsonElement) =
            { state with PredictedValue = Some value }

        [<CustomOperation("predictedValueSequence")>]
        member _.PredictedValueSequence(state: InferenceResponseResult, value: string) =
            { state with PredictedValueSequence = Some value }

        [<CustomOperation("predictionProbability")>]
        member _.PredictionProbability(state: InferenceResponseResult, value: CoreTypes.Double) =
            { state with PredictionProbability = Some value }

        [<CustomOperation("predictionScore")>]
        member _.PredictionScore(state: InferenceResponseResult, value: CoreTypes.Double) =
            { state with PredictionScore = Some value }

        [<CustomOperation("topClasses")>]
        member _.TopClasses(state: InferenceResponseResult, value: MlTypes.TopClassEntry list) =
            { state with TopClasses = Some value }

        [<CustomOperation("warning")>]
        member _.Warning(state: InferenceResponseResult, value: string) =
            { state with Warning = Some value }

        [<CustomOperation("featureImportance")>]
        member _.FeatureImportance(state: InferenceResponseResult, value: MlTypes.TrainedModelInferenceFeatureImportance list) =
            { state with FeatureImportance = Some value }

    let inferenceResponseResult = InferenceResponseResultBuilder()

    type JobBuilder() =
        member _.Yield(_: unit) : Job =
            {
                AllowLazyOpen = Unchecked.defaultof<_>
                AnalysisConfig = Unchecked.defaultof<_>
                AnalysisLimits = None
                BackgroundPersistInterval = None
                Blocked = None
                CreateTime = None
                CustomSettings = None
                DailyModelSnapshotRetentionAfterDays = None
                DataDescription = Unchecked.defaultof<_>
                DatafeedConfig = None
                Deleting = None
                Description = None
                FinishedTime = None
                Groups = None
                JobId = Unchecked.defaultof<_>
                JobType = None
                JobVersion = None
                ModelPlotConfig = None
                ModelSnapshotId = None
                ModelSnapshotRetentionDays = Unchecked.defaultof<_>
                RenormalizationWindowDays = None
                ResultsIndexName = Unchecked.defaultof<_>
                ResultsRetentionDays = None
            }

        [<CustomOperation("allowLazyOpen")>]
        member _.AllowLazyOpen(state: Job, value: bool) =
            { state with AllowLazyOpen = value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: Job, value: MlTypes.AnalysisConfig) =
            { state with AnalysisConfig = value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: Job, value: MlTypes.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: Job, value: CoreTypes.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("blocked")>]
        member _.Blocked(state: Job, value: MlTypes.JobBlocked) =
            { state with Blocked = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: Job, value: CoreTypes.DateTime) =
            { state with CreateTime = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: Job, value: MlTypes.CustomSettings) =
            { state with CustomSettings = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: Job, value: CoreTypes.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: Job, value: MlTypes.DataDescription) =
            { state with DataDescription = value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: Job, value: MlTypes.Datafeed) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("deleting")>]
        member _.Deleting(state: Job, value: bool) =
            { state with Deleting = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Job, value: string) =
            { state with Description = Some value }

        [<CustomOperation("finishedTime")>]
        member _.FinishedTime(state: Job, value: CoreTypes.DateTime) =
            { state with FinishedTime = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: Job, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Job, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: Job, value: string) =
            { state with JobType = Some value }

        [<CustomOperation("jobVersion")>]
        member _.JobVersion(state: Job, value: CoreTypes.VersionString) =
            { state with JobVersion = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: Job, value: MlTypes.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelSnapshotId")>]
        member _.ModelSnapshotId(state: Job, value: CoreTypes.Id) =
            { state with ModelSnapshotId = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: Job, value: CoreTypes.Long) =
            { state with ModelSnapshotRetentionDays = value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: Job, value: CoreTypes.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: Job, value: CoreTypes.IndexName) =
            { state with ResultsIndexName = value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: Job, value: CoreTypes.Long) =
            { state with ResultsRetentionDays = Some value }

    let job = JobBuilder()

    type JobConfigBuilder() =
        member _.Yield(_: unit) : JobConfig =
            {
                AllowLazyOpen = None
                AnalysisConfig = Unchecked.defaultof<_>
                AnalysisLimits = None
                BackgroundPersistInterval = None
                CustomSettings = None
                DailyModelSnapshotRetentionAfterDays = None
                DataDescription = Unchecked.defaultof<_>
                DatafeedConfig = None
                Description = None
                Groups = None
                JobId = None
                JobType = None
                ModelPlotConfig = None
                ModelSnapshotRetentionDays = None
                RenormalizationWindowDays = None
                ResultsIndexName = None
                ResultsRetentionDays = None
            }

        [<CustomOperation("allowLazyOpen")>]
        member _.AllowLazyOpen(state: JobConfig, value: bool) =
            { state with AllowLazyOpen = Some value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: JobConfig, value: MlTypes.AnalysisConfig) =
            { state with AnalysisConfig = value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: JobConfig, value: MlTypes.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: JobConfig, value: CoreTypes.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: JobConfig, value: MlTypes.CustomSettings) =
            { state with CustomSettings = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: JobConfig, value: CoreTypes.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: JobConfig, value: MlTypes.DataDescription) =
            { state with DataDescription = value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: JobConfig, value: MlTypes.DatafeedConfig) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: JobConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: JobConfig, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: JobConfig, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: JobConfig, value: string) =
            { state with JobType = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: JobConfig, value: MlTypes.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: JobConfig, value: CoreTypes.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: JobConfig, value: CoreTypes.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: JobConfig, value: CoreTypes.IndexName) =
            { state with ResultsIndexName = Some value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: JobConfig, value: CoreTypes.Long) =
            { state with ResultsRetentionDays = Some value }

    let jobConfig = JobConfigBuilder()

    type JobForecastStatisticsBuilder() =
        member _.Yield(_: unit) : JobForecastStatistics =
            {
                MemoryBytes = None
                ProcessingTimeMs = None
                Records = None
                Status = None
                Total = Unchecked.defaultof<_>
                ForecastedJobs = Unchecked.defaultof<_>
            }

        [<CustomOperation("memoryBytes")>]
        member _.MemoryBytes(state: JobForecastStatistics, value: MlTypes.JobStatistics) =
            { state with MemoryBytes = Some value }

        [<CustomOperation("processingTimeMs")>]
        member _.ProcessingTimeMs(state: JobForecastStatistics, value: MlTypes.JobStatistics) =
            { state with ProcessingTimeMs = Some value }

        [<CustomOperation("records")>]
        member _.Records(state: JobForecastStatistics, value: MlTypes.JobStatistics) =
            { state with Records = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: JobForecastStatistics, value: Map<string, CoreTypes.Long>) =
            { state with Status = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: JobForecastStatistics, value: CoreTypes.Long) =
            { state with Total = value }

        [<CustomOperation("forecastedJobs")>]
        member _.ForecastedJobs(state: JobForecastStatistics, value: CoreTypes.Integer) =
            { state with ForecastedJobs = value }

    let jobForecastStatistics = JobForecastStatisticsBuilder()

    type JobStatsBuilder() =
        member _.Yield(_: unit) : JobStats =
            {
                AssignmentExplanation = None
                DataCounts = Unchecked.defaultof<_>
                ForecastsStats = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
                ModelSizeStats = Unchecked.defaultof<_>
                Node = None
                OpenTime = None
                State = Unchecked.defaultof<_>
                TimingStats = Unchecked.defaultof<_>
                Deleting = None
            }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: JobStats, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("dataCounts")>]
        member _.DataCounts(state: JobStats, value: MlTypes.DataCounts) =
            { state with DataCounts = value }

        [<CustomOperation("forecastsStats")>]
        member _.ForecastsStats(state: JobStats, value: MlTypes.JobForecastStatistics) =
            { state with ForecastsStats = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: JobStats, value: string) =
            { state with JobId = value }

        [<CustomOperation("modelSizeStats")>]
        member _.ModelSizeStats(state: JobStats, value: MlTypes.ModelSizeStats) =
            { state with ModelSizeStats = value }

        [<CustomOperation("node")>]
        member _.Node(state: JobStats, value: MlTypes.DiscoveryNodeCompact) =
            { state with Node = Some value }

        [<CustomOperation("openTime")>]
        member _.OpenTime(state: JobStats, value: CoreTypes.DateTime) =
            { state with OpenTime = Some value }

        [<CustomOperation("state")>]
        member _.State(state: JobStats, value: MlTypes.JobState) =
            { state with State = value }

        [<CustomOperation("timingStats")>]
        member _.TimingStats(state: JobStats, value: MlTypes.JobTimingStats) =
            { state with TimingStats = value }

        [<CustomOperation("deleting")>]
        member _.Deleting(state: JobStats, value: bool) =
            { state with Deleting = Some value }

    let jobStats = JobStatsBuilder()

    type JobTimingStatsBuilder() =
        member _.Yield(_: unit) : JobTimingStats =
            {
                AverageBucketProcessingTimeMs = None
                BucketCount = Unchecked.defaultof<_>
                ExponentialAverageBucketProcessingTimeMs = None
                ExponentialAverageBucketProcessingTimePerHourMs = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
                TotalBucketProcessingTimeMs = Unchecked.defaultof<_>
                MaximumBucketProcessingTimeMs = None
                MinimumBucketProcessingTimeMs = None
            }

        [<CustomOperation("averageBucketProcessingTimeMs")>]
        member _.AverageBucketProcessingTimeMs(state: JobTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with AverageBucketProcessingTimeMs = Some value }

        [<CustomOperation("bucketCount")>]
        member _.BucketCount(state: JobTimingStats, value: CoreTypes.Long) =
            { state with BucketCount = value }

        [<CustomOperation("exponentialAverageBucketProcessingTimeMs")>]
        member _.ExponentialAverageBucketProcessingTimeMs(state: JobTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with ExponentialAverageBucketProcessingTimeMs = Some value }

        [<CustomOperation("exponentialAverageBucketProcessingTimePerHourMs")>]
        member _.ExponentialAverageBucketProcessingTimePerHourMs(state: JobTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with ExponentialAverageBucketProcessingTimePerHourMs = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: JobTimingStats, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("totalBucketProcessingTimeMs")>]
        member _.TotalBucketProcessingTimeMs(state: JobTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with TotalBucketProcessingTimeMs = value }

        [<CustomOperation("maximumBucketProcessingTimeMs")>]
        member _.MaximumBucketProcessingTimeMs(state: JobTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with MaximumBucketProcessingTimeMs = Some value }

        [<CustomOperation("minimumBucketProcessingTimeMs")>]
        member _.MinimumBucketProcessingTimeMs(state: JobTimingStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with MinimumBucketProcessingTimeMs = Some value }

    let jobTimingStats = JobTimingStatsBuilder()

    type LearningToRankConfigBuilder() =
        member _.Yield(_: unit) : LearningToRankConfig =
            {
                DefaultParams = None
                FeatureExtractors = None
                NumTopFeatureImportanceValues = Unchecked.defaultof<_>
            }

        [<CustomOperation("defaultParams")>]
        member _.DefaultParams(state: LearningToRankConfig, value: Map<string, System.Text.Json.JsonElement>) =
            { state with DefaultParams = Some value }

        [<CustomOperation("featureExtractors")>]
        member _.FeatureExtractors(state: LearningToRankConfig, value: Map<string, MlTypes.FeatureExtractor> list) =
            { state with FeatureExtractors = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: LearningToRankConfig, value: CoreTypes.Integer) =
            { state with NumTopFeatureImportanceValues = value }

    let learningToRankConfig = LearningToRankConfigBuilder()

    type ModelPackageConfigBuilder() =
        member _.Yield(_: unit) : ModelPackageConfig =
            {
                CreateTime = None
                Description = None
                InferenceConfig = None
                Metadata = None
                MinimumVersion = None
                ModelRepository = None
                ModelType = None
                PackagedModelId = Unchecked.defaultof<_>
                PlatformArchitecture = None
                PrefixStrings = None
                Size = None
                Sha256 = None
                Tags = None
                VocabularyFile = None
            }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: ModelPackageConfig, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CreateTime = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: ModelPackageConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: ModelPackageConfig, value: Map<string, System.Text.Json.JsonElement>) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: ModelPackageConfig, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("minimumVersion")>]
        member _.MinimumVersion(state: ModelPackageConfig, value: string) =
            { state with MinimumVersion = Some value }

        [<CustomOperation("modelRepository")>]
        member _.ModelRepository(state: ModelPackageConfig, value: string) =
            { state with ModelRepository = Some value }

        [<CustomOperation("modelType")>]
        member _.ModelType(state: ModelPackageConfig, value: string) =
            { state with ModelType = Some value }

        [<CustomOperation("packagedModelId")>]
        member _.PackagedModelId(state: ModelPackageConfig, value: CoreTypes.Id) =
            { state with PackagedModelId = value }

        [<CustomOperation("platformArchitecture")>]
        member _.PlatformArchitecture(state: ModelPackageConfig, value: string) =
            { state with PlatformArchitecture = Some value }

        [<CustomOperation("prefixStrings")>]
        member _.PrefixStrings(state: ModelPackageConfig, value: MlTypes.TrainedModelPrefixStrings) =
            { state with PrefixStrings = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: ModelPackageConfig, value: CoreTypes.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("sha256")>]
        member _.Sha256(state: ModelPackageConfig, value: string) =
            { state with Sha256 = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: ModelPackageConfig, value: string list) =
            { state with Tags = Some value }

        [<CustomOperation("vocabularyFile")>]
        member _.VocabularyFile(state: ModelPackageConfig, value: string) =
            { state with VocabularyFile = Some value }

    let modelPackageConfig = ModelPackageConfigBuilder()

    type ModelPlotConfigBuilder() =
        member _.Yield(_: unit) : ModelPlotConfig =
            {
                AnnotationsEnabled = None
                Enabled = None
                Terms = None
            }

        [<CustomOperation("annotationsEnabled")>]
        member _.AnnotationsEnabled(state: ModelPlotConfig, value: bool) =
            { state with AnnotationsEnabled = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: ModelPlotConfig, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: ModelPlotConfig, value: CoreTypes.Field) =
            { state with Terms = Some value }

    let modelPlotConfig = ModelPlotConfigBuilder()

    type ModelSizeStatsBuilder() =
        member _.Yield(_: unit) : ModelSizeStats =
            {
                BucketAllocationFailuresCount = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
                LogTime = Unchecked.defaultof<_>
                MemoryStatus = Unchecked.defaultof<_>
                ModelBytes = Unchecked.defaultof<_>
                ModelBytesExceeded = None
                ModelBytesMemoryLimit = None
                OutputMemoryAllocatorBytes = None
                PeakModelBytes = None
                AssignmentMemoryBasis = None
                ResultType = Unchecked.defaultof<_>
                TotalByFieldCount = Unchecked.defaultof<_>
                TotalOverFieldCount = Unchecked.defaultof<_>
                TotalPartitionFieldCount = Unchecked.defaultof<_>
                CategorizationStatus = Unchecked.defaultof<_>
                CategorizedDocCount = Unchecked.defaultof<_>
                DeadCategoryCount = Unchecked.defaultof<_>
                FailedCategoryCount = Unchecked.defaultof<_>
                FrequentCategoryCount = Unchecked.defaultof<_>
                RareCategoryCount = Unchecked.defaultof<_>
                TotalCategoryCount = Unchecked.defaultof<_>
                Timestamp = None
            }

        [<CustomOperation("bucketAllocationFailuresCount")>]
        member _.BucketAllocationFailuresCount(state: ModelSizeStats, value: CoreTypes.Long) =
            { state with BucketAllocationFailuresCount = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: ModelSizeStats, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("logTime")>]
        member _.LogTime(state: ModelSizeStats, value: CoreTypes.DateTime) =
            { state with LogTime = value }

        [<CustomOperation("memoryStatus")>]
        member _.MemoryStatus(state: ModelSizeStats, value: MlTypes.MemoryStatus) =
            { state with MemoryStatus = value }

        [<CustomOperation("modelBytes")>]
        member _.ModelBytes(state: ModelSizeStats, value: CoreTypes.ByteSize) =
            { state with ModelBytes = value }

        [<CustomOperation("modelBytesExceeded")>]
        member _.ModelBytesExceeded(state: ModelSizeStats, value: CoreTypes.ByteSize) =
            { state with ModelBytesExceeded = Some value }

        [<CustomOperation("modelBytesMemoryLimit")>]
        member _.ModelBytesMemoryLimit(state: ModelSizeStats, value: CoreTypes.ByteSize) =
            { state with ModelBytesMemoryLimit = Some value }

        [<CustomOperation("outputMemoryAllocatorBytes")>]
        member _.OutputMemoryAllocatorBytes(state: ModelSizeStats, value: CoreTypes.ByteSize) =
            { state with OutputMemoryAllocatorBytes = Some value }

        [<CustomOperation("peakModelBytes")>]
        member _.PeakModelBytes(state: ModelSizeStats, value: CoreTypes.ByteSize) =
            { state with PeakModelBytes = Some value }

        [<CustomOperation("assignmentMemoryBasis")>]
        member _.AssignmentMemoryBasis(state: ModelSizeStats, value: string) =
            { state with AssignmentMemoryBasis = Some value }

        [<CustomOperation("resultType")>]
        member _.ResultType(state: ModelSizeStats, value: string) =
            { state with ResultType = value }

        [<CustomOperation("totalByFieldCount")>]
        member _.TotalByFieldCount(state: ModelSizeStats, value: CoreTypes.Long) =
            { state with TotalByFieldCount = value }

        [<CustomOperation("totalOverFieldCount")>]
        member _.TotalOverFieldCount(state: ModelSizeStats, value: CoreTypes.Long) =
            { state with TotalOverFieldCount = value }

        [<CustomOperation("totalPartitionFieldCount")>]
        member _.TotalPartitionFieldCount(state: ModelSizeStats, value: CoreTypes.Long) =
            { state with TotalPartitionFieldCount = value }

        [<CustomOperation("categorizationStatus")>]
        member _.CategorizationStatus(state: ModelSizeStats, value: MlTypes.CategorizationStatus) =
            { state with CategorizationStatus = value }

        [<CustomOperation("categorizedDocCount")>]
        member _.CategorizedDocCount(state: ModelSizeStats, value: CoreTypes.Integer) =
            { state with CategorizedDocCount = value }

        [<CustomOperation("deadCategoryCount")>]
        member _.DeadCategoryCount(state: ModelSizeStats, value: CoreTypes.Integer) =
            { state with DeadCategoryCount = value }

        [<CustomOperation("failedCategoryCount")>]
        member _.FailedCategoryCount(state: ModelSizeStats, value: CoreTypes.Integer) =
            { state with FailedCategoryCount = value }

        [<CustomOperation("frequentCategoryCount")>]
        member _.FrequentCategoryCount(state: ModelSizeStats, value: CoreTypes.Integer) =
            { state with FrequentCategoryCount = value }

        [<CustomOperation("rareCategoryCount")>]
        member _.RareCategoryCount(state: ModelSizeStats, value: CoreTypes.Integer) =
            { state with RareCategoryCount = value }

        [<CustomOperation("totalCategoryCount")>]
        member _.TotalCategoryCount(state: ModelSizeStats, value: CoreTypes.Integer) =
            { state with TotalCategoryCount = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: ModelSizeStats, value: CoreTypes.Long) =
            { state with Timestamp = Some value }

    let modelSizeStats = ModelSizeStatsBuilder()

    type ModelSnapshotBuilder() =
        member _.Yield(_: unit) : ModelSnapshot =
            {
                Description = None
                JobId = Unchecked.defaultof<_>
                LatestRecordTimeStamp = None
                LatestResultTimeStamp = None
                MinVersion = Unchecked.defaultof<_>
                ModelSizeStats = None
                Retain = Unchecked.defaultof<_>
                SnapshotDocCount = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                Timestamp = Unchecked.defaultof<_>
            }

        [<CustomOperation("description")>]
        member _.Description(state: ModelSnapshot, value: string) =
            { state with Description = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: ModelSnapshot, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("latestRecordTimeStamp")>]
        member _.LatestRecordTimeStamp(state: ModelSnapshot, value: CoreTypes.Integer) =
            { state with LatestRecordTimeStamp = Some value }

        [<CustomOperation("latestResultTimeStamp")>]
        member _.LatestResultTimeStamp(state: ModelSnapshot, value: CoreTypes.Integer) =
            { state with LatestResultTimeStamp = Some value }

        [<CustomOperation("minVersion")>]
        member _.MinVersion(state: ModelSnapshot, value: CoreTypes.VersionString) =
            { state with MinVersion = value }

        [<CustomOperation("modelSizeStats")>]
        member _.ModelSizeStats(state: ModelSnapshot, value: MlTypes.ModelSizeStats) =
            { state with ModelSizeStats = Some value }

        [<CustomOperation("retain")>]
        member _.Retain(state: ModelSnapshot, value: bool) =
            { state with Retain = value }

        [<CustomOperation("snapshotDocCount")>]
        member _.SnapshotDocCount(state: ModelSnapshot, value: CoreTypes.Long) =
            { state with SnapshotDocCount = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: ModelSnapshot, value: CoreTypes.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: ModelSnapshot, value: CoreTypes.Long) =
            { state with Timestamp = value }

    let modelSnapshot = ModelSnapshotBuilder()

    type NerInferenceOptionsBuilder() =
        member _.Yield(_: unit) : NerInferenceOptions =
            {
                Tokenization = None
                ResultsField = None
                ClassificationLabels = None
                Vocabulary = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: NerInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: NerInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: NerInferenceOptions, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: NerInferenceOptions, value: MlTypes.Vocabulary) =
            { state with Vocabulary = Some value }

    let nerInferenceOptions = NerInferenceOptionsBuilder()

    type NerInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : NerInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: NerInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: NerInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let nerInferenceUpdateOptions = NerInferenceUpdateOptionsBuilder()

    type NlpTokenizationUpdateOptionsBuilder() =
        member _.Yield(_: unit) : NlpTokenizationUpdateOptions =
            {
                Truncate = None
                Span = None
            }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: NlpTokenizationUpdateOptions, value: MlTypes.TokenizationTruncate) =
            { state with Truncate = Some value }

        [<CustomOperation("span")>]
        member _.Span(state: NlpTokenizationUpdateOptions, value: CoreTypes.Integer) =
            { state with Span = Some value }

    let nlpTokenizationUpdateOptions = NlpTokenizationUpdateOptionsBuilder()

    type OutlierDetectionParametersBuilder() =
        member _.Yield(_: unit) : OutlierDetectionParameters =
            {
                ComputeFeatureInfluence = None
                FeatureInfluenceThreshold = None
                Method = None
                NNeighbors = None
                OutlierFraction = None
                StandardizationEnabled = None
            }

        [<CustomOperation("computeFeatureInfluence")>]
        member _.ComputeFeatureInfluence(state: OutlierDetectionParameters, value: bool) =
            { state with ComputeFeatureInfluence = Some value }

        [<CustomOperation("featureInfluenceThreshold")>]
        member _.FeatureInfluenceThreshold(state: OutlierDetectionParameters, value: CoreTypes.Double) =
            { state with FeatureInfluenceThreshold = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: OutlierDetectionParameters, value: string) =
            { state with Method = Some value }

        [<CustomOperation("nNeighbors")>]
        member _.NNeighbors(state: OutlierDetectionParameters, value: CoreTypes.Integer) =
            { state with NNeighbors = Some value }

        [<CustomOperation("outlierFraction")>]
        member _.OutlierFraction(state: OutlierDetectionParameters, value: CoreTypes.Double) =
            { state with OutlierFraction = Some value }

        [<CustomOperation("standardizationEnabled")>]
        member _.StandardizationEnabled(state: OutlierDetectionParameters, value: bool) =
            { state with StandardizationEnabled = Some value }

    let outlierDetectionParameters = OutlierDetectionParametersBuilder()

    type PageBuilder() =
        member _.Yield(_: unit) : Page =
            {
                From = None
                Size = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Page, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Page, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let page = PageBuilder()

    type PassThroughInferenceOptionsBuilder() =
        member _.Yield(_: unit) : PassThroughInferenceOptions =
            {
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: PassThroughInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: PassThroughInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: PassThroughInferenceOptions, value: MlTypes.Vocabulary) =
            { state with Vocabulary = Some value }

    let passThroughInferenceOptions = PassThroughInferenceOptionsBuilder()

    type PassThroughInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : PassThroughInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: PassThroughInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: PassThroughInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let passThroughInferenceUpdateOptions = PassThroughInferenceUpdateOptionsBuilder()

    type PerPartitionCategorizationBuilder() =
        member _.Yield(_: unit) : PerPartitionCategorization =
            {
                Enabled = None
                StopOnWarn = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: PerPartitionCategorization, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("stopOnWarn")>]
        member _.StopOnWarn(state: PerPartitionCategorization, value: bool) =
            { state with StopOnWarn = Some value }

    let perPartitionCategorization = PerPartitionCategorizationBuilder()

    type QuestionAnsweringInferenceOptionsBuilder() =
        member _.Yield(_: unit) : QuestionAnsweringInferenceOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                MaxAnswerLength = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: QuestionAnsweringInferenceOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: QuestionAnsweringInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: QuestionAnsweringInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("maxAnswerLength")>]
        member _.MaxAnswerLength(state: QuestionAnsweringInferenceOptions, value: CoreTypes.Integer) =
            { state with MaxAnswerLength = Some value }

    let questionAnsweringInferenceOptions = QuestionAnsweringInferenceOptionsBuilder()

    type QuestionAnsweringInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : QuestionAnsweringInferenceUpdateOptions =
            {
                Question = Unchecked.defaultof<_>
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                MaxAnswerLength = None
            }

        [<CustomOperation("question")>]
        member _.Question(state: QuestionAnsweringInferenceUpdateOptions, value: string) =
            { state with Question = value }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: QuestionAnsweringInferenceUpdateOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: QuestionAnsweringInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: QuestionAnsweringInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("maxAnswerLength")>]
        member _.MaxAnswerLength(state: QuestionAnsweringInferenceUpdateOptions, value: CoreTypes.Integer) =
            { state with MaxAnswerLength = Some value }

    let questionAnsweringInferenceUpdateOptions = QuestionAnsweringInferenceUpdateOptionsBuilder()

    type RegressionInferenceOptionsBuilder() =
        member _.Yield(_: unit) : RegressionInferenceOptions =
            {
                ResultsField = None
                NumTopFeatureImportanceValues = None
            }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: RegressionInferenceOptions, value: CoreTypes.Field) =
            { state with ResultsField = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: RegressionInferenceOptions, value: CoreTypes.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

    let regressionInferenceOptions = RegressionInferenceOptionsBuilder()

    type RunningStateSearchIntervalBuilder() =
        member _.Yield(_: unit) : RunningStateSearchInterval =
            {
                End = None
                EndMs = Unchecked.defaultof<_>
                Start = None
                StartMs = Unchecked.defaultof<_>
            }

        [<CustomOperation("end'")>]
        member _.End(state: RunningStateSearchInterval, value: CoreTypes.Duration) =
            { state with End = Some value }

        [<CustomOperation("endMs")>]
        member _.EndMs(state: RunningStateSearchInterval, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with EndMs = value }

        [<CustomOperation("start")>]
        member _.Start(state: RunningStateSearchInterval, value: CoreTypes.Duration) =
            { state with Start = Some value }

        [<CustomOperation("startMs")>]
        member _.StartMs(state: RunningStateSearchInterval, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with StartMs = value }

    let runningStateSearchInterval = RunningStateSearchIntervalBuilder()

    type TextClassificationInferenceOptionsBuilder() =
        member _.Yield(_: unit) : TextClassificationInferenceOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                ClassificationLabels = None
                Vocabulary = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: TextClassificationInferenceOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: TextClassificationInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: TextClassificationInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: TextClassificationInferenceOptions, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: TextClassificationInferenceOptions, value: MlTypes.Vocabulary) =
            { state with Vocabulary = Some value }

    let textClassificationInferenceOptions = TextClassificationInferenceOptionsBuilder()

    type TextClassificationInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : TextClassificationInferenceUpdateOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                ClassificationLabels = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: TextClassificationInferenceUpdateOptions, value: CoreTypes.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: TextClassificationInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: TextClassificationInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: TextClassificationInferenceUpdateOptions, value: string list) =
            { state with ClassificationLabels = Some value }

    let textClassificationInferenceUpdateOptions = TextClassificationInferenceUpdateOptionsBuilder()

    type TextEmbeddingInferenceOptionsBuilder() =
        member _.Yield(_: unit) : TextEmbeddingInferenceOptions =
            {
                EmbeddingSize = None
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("embeddingSize")>]
        member _.EmbeddingSize(state: TextEmbeddingInferenceOptions, value: CoreTypes.Integer) =
            { state with EmbeddingSize = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: TextEmbeddingInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: TextEmbeddingInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: TextEmbeddingInferenceOptions, value: MlTypes.Vocabulary) =
            { state with Vocabulary = Some value }

    let textEmbeddingInferenceOptions = TextEmbeddingInferenceOptionsBuilder()

    type TextEmbeddingInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : TextEmbeddingInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: TextEmbeddingInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: TextEmbeddingInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let textEmbeddingInferenceUpdateOptions = TextEmbeddingInferenceUpdateOptionsBuilder()

    type TextExpansionInferenceOptionsBuilder() =
        member _.Yield(_: unit) : TextExpansionInferenceOptions =
            {
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: TextExpansionInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: TextExpansionInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: TextExpansionInferenceOptions, value: MlTypes.Vocabulary) =
            { state with Vocabulary = Some value }

    let textExpansionInferenceOptions = TextExpansionInferenceOptionsBuilder()

    type TextExpansionInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : TextExpansionInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: TextExpansionInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: TextExpansionInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let textExpansionInferenceUpdateOptions = TextExpansionInferenceUpdateOptionsBuilder()

    module TokenizationConfig =

        let bert (value: MlTypes.NlpBertTokenizationConfig) =
            TokenizationConfigContainer.Bert value

        let bertJa (value: MlTypes.NlpBertTokenizationConfig) =
            TokenizationConfigContainer.BertJa value

        let mpnet (value: MlTypes.NlpBertTokenizationConfig) =
            TokenizationConfigContainer.Mpnet value

        let roberta (value: MlTypes.NlpRobertaTokenizationConfig) =
            TokenizationConfigContainer.Roberta value

        let xlmRoberta (value: MlTypes.XlmRobertaTokenizationConfig) =
            TokenizationConfigContainer.XlmRoberta value

    type TrainedModelAssignmentBuilder() =
        member _.Yield(_: unit) : TrainedModelAssignment =
            {
                AdaptiveAllocations = None
                AssignmentState = Unchecked.defaultof<_>
                MaxAssignedAllocations = None
                Reason = None
                RoutingTable = Unchecked.defaultof<_>
                StartTime = Unchecked.defaultof<_>
                TaskParameters = Unchecked.defaultof<_>
            }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: TrainedModelAssignment, value: MlTypes.AdaptiveAllocationsSettings option) =
            { state with AdaptiveAllocations = Some value }

        [<CustomOperation("assignmentState")>]
        member _.AssignmentState(state: TrainedModelAssignment, value: MlTypes.DeploymentAssignmentState) =
            { state with AssignmentState = value }

        [<CustomOperation("maxAssignedAllocations")>]
        member _.MaxAssignedAllocations(state: TrainedModelAssignment, value: CoreTypes.Integer) =
            { state with MaxAssignedAllocations = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: TrainedModelAssignment, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("routingTable")>]
        member _.RoutingTable(state: TrainedModelAssignment, value: Map<string, MlTypes.TrainedModelAssignmentRoutingTable>) =
            { state with RoutingTable = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: TrainedModelAssignment, value: CoreTypes.DateTime) =
            { state with StartTime = value }

        [<CustomOperation("taskParameters")>]
        member _.TaskParameters(state: TrainedModelAssignment, value: MlTypes.TrainedModelAssignmentTaskParameters) =
            { state with TaskParameters = value }

    let trainedModelAssignment = TrainedModelAssignmentBuilder()

    type TrainedModelConfigBuilder() =
        member _.Yield(_: unit) : TrainedModelConfig =
            {
                ModelId = Unchecked.defaultof<_>
                ModelType = None
                Tags = Unchecked.defaultof<_>
                Version = None
                CompressedDefinition = None
                CreatedBy = None
                CreateTime = None
                DefaultFieldMap = None
                Description = None
                EstimatedHeapMemoryUsageBytes = None
                EstimatedOperations = None
                FullyDefined = None
                InferenceConfig = None
                Input = Unchecked.defaultof<_>
                LicenseLevel = None
                Metadata = None
                ModelSizeBytes = None
                ModelPackage = None
                Location = None
                PlatformArchitecture = None
                PrefixStrings = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: TrainedModelConfig, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("modelType")>]
        member _.ModelType(state: TrainedModelConfig, value: MlTypes.TrainedModelType) =
            { state with ModelType = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: TrainedModelConfig, value: string list) =
            { state with Tags = value }

        [<CustomOperation("version")>]
        member _.Version(state: TrainedModelConfig, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("compressedDefinition")>]
        member _.CompressedDefinition(state: TrainedModelConfig, value: string) =
            { state with CompressedDefinition = Some value }

        [<CustomOperation("createdBy")>]
        member _.CreatedBy(state: TrainedModelConfig, value: string) =
            { state with CreatedBy = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: TrainedModelConfig, value: CoreTypes.DateTime) =
            { state with CreateTime = Some value }

        [<CustomOperation("defaultFieldMap")>]
        member _.DefaultFieldMap(state: TrainedModelConfig, value: Map<string, string>) =
            { state with DefaultFieldMap = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: TrainedModelConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("estimatedHeapMemoryUsageBytes")>]
        member _.EstimatedHeapMemoryUsageBytes(state: TrainedModelConfig, value: CoreTypes.Integer) =
            { state with EstimatedHeapMemoryUsageBytes = Some value }

        [<CustomOperation("estimatedOperations")>]
        member _.EstimatedOperations(state: TrainedModelConfig, value: CoreTypes.Integer) =
            { state with EstimatedOperations = Some value }

        [<CustomOperation("fullyDefined")>]
        member _.FullyDefined(state: TrainedModelConfig, value: bool) =
            { state with FullyDefined = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: TrainedModelConfig, value: MlTypes.InferenceConfigCreateContainer) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: TrainedModelConfig, value: MlTypes.TrainedModelConfigInput) =
            { state with Input = value }

        [<CustomOperation("licenseLevel")>]
        member _.LicenseLevel(state: TrainedModelConfig, value: string) =
            { state with LicenseLevel = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: TrainedModelConfig, value: MlTypes.TrainedModelConfigMetadata) =
            { state with Metadata = Some value }

        [<CustomOperation("modelSizeBytes")>]
        member _.ModelSizeBytes(state: TrainedModelConfig, value: CoreTypes.ByteSize) =
            { state with ModelSizeBytes = Some value }

        [<CustomOperation("modelPackage")>]
        member _.ModelPackage(state: TrainedModelConfig, value: MlTypes.ModelPackageConfig) =
            { state with ModelPackage = Some value }

        [<CustomOperation("location")>]
        member _.Location(state: TrainedModelConfig, value: MlTypes.TrainedModelLocation) =
            { state with Location = Some value }

        [<CustomOperation("platformArchitecture")>]
        member _.PlatformArchitecture(state: TrainedModelConfig, value: string) =
            { state with PlatformArchitecture = Some value }

        [<CustomOperation("prefixStrings")>]
        member _.PrefixStrings(state: TrainedModelConfig, value: MlTypes.TrainedModelPrefixStrings) =
            { state with PrefixStrings = Some value }

    let trainedModelConfig = TrainedModelConfigBuilder()

    type TrainedModelConfigMetadataBuilder() =
        member _.Yield(_: unit) : TrainedModelConfigMetadata =
            {
                ModelAliases = None
                FeatureImportanceBaseline = None
                Hyperparameters = None
                TotalFeatureImportance = None
            }

        [<CustomOperation("modelAliases")>]
        member _.ModelAliases(state: TrainedModelConfigMetadata, value: string list) =
            { state with ModelAliases = Some value }

        [<CustomOperation("featureImportanceBaseline")>]
        member _.FeatureImportanceBaseline(state: TrainedModelConfigMetadata, value: Map<string, string>) =
            { state with FeatureImportanceBaseline = Some value }

        [<CustomOperation("hyperparameters")>]
        member _.Hyperparameters(state: TrainedModelConfigMetadata, value: MlTypes.Hyperparameter list) =
            { state with Hyperparameters = Some value }

        [<CustomOperation("totalFeatureImportance")>]
        member _.TotalFeatureImportance(state: TrainedModelConfigMetadata, value: MlTypes.TotalFeatureImportance list) =
            { state with TotalFeatureImportance = Some value }

    let trainedModelConfigMetadata = TrainedModelConfigMetadataBuilder()

    type TrainedModelDeploymentNodesStatsBuilder() =
        member _.Yield(_: unit) : TrainedModelDeploymentNodesStats =
            {
                AverageInferenceTimeMs = None
                AverageInferenceTimeMsLastMinute = None
                AverageInferenceTimeMsExcludingCacheHits = None
                ErrorCount = None
                InferenceCount = None
                InferenceCacheHitCount = None
                InferenceCacheHitCountLastMinute = None
                LastAccess = None
                Node = None
                NumberOfAllocations = None
                NumberOfPendingRequests = None
                PeakThroughputPerMinute = Unchecked.defaultof<_>
                RejectedExecutionCount = None
                RoutingState = Unchecked.defaultof<_>
                StartTime = None
                ThreadsPerAllocation = None
                ThroughputLastMinute = Unchecked.defaultof<_>
                TimeoutCount = None
            }

        [<CustomOperation("averageInferenceTimeMs")>]
        member _.AverageInferenceTimeMs(state: TrainedModelDeploymentNodesStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with AverageInferenceTimeMs = Some value }

        [<CustomOperation("averageInferenceTimeMsLastMinute")>]
        member _.AverageInferenceTimeMsLastMinute(state: TrainedModelDeploymentNodesStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with AverageInferenceTimeMsLastMinute = Some value }

        [<CustomOperation("averageInferenceTimeMsExcludingCacheHits")>]
        member _.AverageInferenceTimeMsExcludingCacheHits(state: TrainedModelDeploymentNodesStats, value: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>) =
            { state with AverageInferenceTimeMsExcludingCacheHits = Some value }

        [<CustomOperation("errorCount")>]
        member _.ErrorCount(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with ErrorCount = Some value }

        [<CustomOperation("inferenceCount")>]
        member _.InferenceCount(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Long) =
            { state with InferenceCount = Some value }

        [<CustomOperation("inferenceCacheHitCount")>]
        member _.InferenceCacheHitCount(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Long) =
            { state with InferenceCacheHitCount = Some value }

        [<CustomOperation("inferenceCacheHitCountLastMinute")>]
        member _.InferenceCacheHitCountLastMinute(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Long) =
            { state with InferenceCacheHitCountLastMinute = Some value }

        [<CustomOperation("lastAccess")>]
        member _.LastAccess(state: TrainedModelDeploymentNodesStats, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with LastAccess = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: TrainedModelDeploymentNodesStats, value: MlTypes.DiscoveryNode) =
            { state with Node = Some value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("numberOfPendingRequests")>]
        member _.NumberOfPendingRequests(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with NumberOfPendingRequests = Some value }

        [<CustomOperation("peakThroughputPerMinute")>]
        member _.PeakThroughputPerMinute(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Long) =
            { state with PeakThroughputPerMinute = value }

        [<CustomOperation("rejectedExecutionCount")>]
        member _.RejectedExecutionCount(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with RejectedExecutionCount = Some value }

        [<CustomOperation("routingState")>]
        member _.RoutingState(state: TrainedModelDeploymentNodesStats, value: MlTypes.TrainedModelAssignmentRoutingStateAndReason) =
            { state with RoutingState = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: TrainedModelDeploymentNodesStats, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTime = Some value }

        [<CustomOperation("threadsPerAllocation")>]
        member _.ThreadsPerAllocation(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with ThreadsPerAllocation = Some value }

        [<CustomOperation("throughputLastMinute")>]
        member _.ThroughputLastMinute(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with ThroughputLastMinute = value }

        [<CustomOperation("timeoutCount")>]
        member _.TimeoutCount(state: TrainedModelDeploymentNodesStats, value: CoreTypes.Integer) =
            { state with TimeoutCount = Some value }

    let trainedModelDeploymentNodesStats = TrainedModelDeploymentNodesStatsBuilder()

    type TrainedModelDeploymentStatsBuilder() =
        member _.Yield(_: unit) : TrainedModelDeploymentStats =
            {
                AdaptiveAllocations = None
                AllocationStatus = None
                CacheSize = None
                DeploymentId = Unchecked.defaultof<_>
                ErrorCount = None
                InferenceCount = None
                ModelId = Unchecked.defaultof<_>
                Nodes = Unchecked.defaultof<_>
                NumberOfAllocations = None
                PeakThroughputPerMinute = Unchecked.defaultof<_>
                Priority = Unchecked.defaultof<_>
                QueueCapacity = None
                RejectedExecutionCount = None
                Reason = None
                StartTime = Unchecked.defaultof<_>
                State = None
                ThreadsPerAllocation = None
                TimeoutCount = None
            }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: TrainedModelDeploymentStats, value: MlTypes.AdaptiveAllocationsSettings) =
            { state with AdaptiveAllocations = Some value }

        [<CustomOperation("allocationStatus")>]
        member _.AllocationStatus(state: TrainedModelDeploymentStats, value: MlTypes.TrainedModelDeploymentAllocationStatus) =
            { state with AllocationStatus = Some value }

        [<CustomOperation("cacheSize")>]
        member _.CacheSize(state: TrainedModelDeploymentStats, value: CoreTypes.ByteSize) =
            { state with CacheSize = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: TrainedModelDeploymentStats, value: CoreTypes.Id) =
            { state with DeploymentId = value }

        [<CustomOperation("errorCount")>]
        member _.ErrorCount(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with ErrorCount = Some value }

        [<CustomOperation("inferenceCount")>]
        member _.InferenceCount(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with InferenceCount = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: TrainedModelDeploymentStats, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: TrainedModelDeploymentStats, value: MlTypes.TrainedModelDeploymentNodesStats list) =
            { state with Nodes = value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("peakThroughputPerMinute")>]
        member _.PeakThroughputPerMinute(state: TrainedModelDeploymentStats, value: CoreTypes.Long) =
            { state with PeakThroughputPerMinute = value }

        [<CustomOperation("priority")>]
        member _.Priority(state: TrainedModelDeploymentStats, value: MlTypes.TrainingPriority) =
            { state with Priority = value }

        [<CustomOperation("queueCapacity")>]
        member _.QueueCapacity(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with QueueCapacity = Some value }

        [<CustomOperation("rejectedExecutionCount")>]
        member _.RejectedExecutionCount(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with RejectedExecutionCount = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: TrainedModelDeploymentStats, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: TrainedModelDeploymentStats, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTime = value }

        [<CustomOperation("state")>]
        member _.State(state: TrainedModelDeploymentStats, value: MlTypes.DeploymentAssignmentState) =
            { state with State = Some value }

        [<CustomOperation("threadsPerAllocation")>]
        member _.ThreadsPerAllocation(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with ThreadsPerAllocation = Some value }

        [<CustomOperation("timeoutCount")>]
        member _.TimeoutCount(state: TrainedModelDeploymentStats, value: CoreTypes.Integer) =
            { state with TimeoutCount = Some value }

    let trainedModelDeploymentStats = TrainedModelDeploymentStatsBuilder()

    type TrainedModelInferenceFeatureImportanceBuilder() =
        member _.Yield(_: unit) : TrainedModelInferenceFeatureImportance =
            {
                FeatureName = Unchecked.defaultof<_>
                Importance = None
                Classes = None
            }

        [<CustomOperation("featureName")>]
        member _.FeatureName(state: TrainedModelInferenceFeatureImportance, value: string) =
            { state with FeatureName = value }

        [<CustomOperation("importance")>]
        member _.Importance(state: TrainedModelInferenceFeatureImportance, value: CoreTypes.Double) =
            { state with Importance = Some value }

        [<CustomOperation("classes")>]
        member _.Classes(state: TrainedModelInferenceFeatureImportance, value: MlTypes.TrainedModelInferenceClassImportance list) =
            { state with Classes = Some value }

    let trainedModelInferenceFeatureImportance = TrainedModelInferenceFeatureImportanceBuilder()

    type TrainedModelPrefixStringsBuilder() =
        member _.Yield(_: unit) : TrainedModelPrefixStrings =
            {
                Ingest = None
                Search = None
            }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: TrainedModelPrefixStrings, value: string) =
            { state with Ingest = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: TrainedModelPrefixStrings, value: string) =
            { state with Search = Some value }

    let trainedModelPrefixStrings = TrainedModelPrefixStringsBuilder()

    type TrainedModelStatsBuilder() =
        member _.Yield(_: unit) : TrainedModelStats =
            {
                DeploymentStats = None
                InferenceStats = None
                Ingest = None
                ModelId = Unchecked.defaultof<_>
                ModelSizeStats = Unchecked.defaultof<_>
                PipelineCount = Unchecked.defaultof<_>
            }

        [<CustomOperation("deploymentStats")>]
        member _.DeploymentStats(state: TrainedModelStats, value: MlTypes.TrainedModelDeploymentStats) =
            { state with DeploymentStats = Some value }

        [<CustomOperation("inferenceStats")>]
        member _.InferenceStats(state: TrainedModelStats, value: MlTypes.TrainedModelInferenceStats) =
            { state with InferenceStats = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: TrainedModelStats, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ingest = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: TrainedModelStats, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("modelSizeStats")>]
        member _.ModelSizeStats(state: TrainedModelStats, value: MlTypes.TrainedModelSizeStats) =
            { state with ModelSizeStats = value }

        [<CustomOperation("pipelineCount")>]
        member _.PipelineCount(state: TrainedModelStats, value: CoreTypes.Integer) =
            { state with PipelineCount = value }

    let trainedModelStats = TrainedModelStatsBuilder()

    type TransformAuthorizationBuilder() =
        member _.Yield(_: unit) : TransformAuthorization =
            {
                ApiKey = None
                Roles = None
                ServiceAccount = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: TransformAuthorization, value: MlTypes.ApiKeyAuthorization) =
            { state with ApiKey = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: TransformAuthorization, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("serviceAccount")>]
        member _.ServiceAccount(state: TransformAuthorization, value: string) =
            { state with ServiceAccount = Some value }

    let transformAuthorization = TransformAuthorizationBuilder()

    type ZeroShotClassificationInferenceOptionsBuilder() =
        member _.Yield(_: unit) : ZeroShotClassificationInferenceOptions =
            {
                Tokenization = None
                HypothesisTemplate = None
                ClassificationLabels = Unchecked.defaultof<_>
                ResultsField = None
                MultiLabel = None
                Labels = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: ZeroShotClassificationInferenceOptions, value: MlTypes.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("hypothesisTemplate")>]
        member _.HypothesisTemplate(state: ZeroShotClassificationInferenceOptions, value: string) =
            { state with HypothesisTemplate = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: ZeroShotClassificationInferenceOptions, value: string list) =
            { state with ClassificationLabels = value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: ZeroShotClassificationInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("multiLabel")>]
        member _.MultiLabel(state: ZeroShotClassificationInferenceOptions, value: bool) =
            { state with MultiLabel = Some value }

        [<CustomOperation("labels")>]
        member _.Labels(state: ZeroShotClassificationInferenceOptions, value: string list) =
            { state with Labels = Some value }

    let zeroShotClassificationInferenceOptions = ZeroShotClassificationInferenceOptionsBuilder()

    type ZeroShotClassificationInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : ZeroShotClassificationInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
                MultiLabel = None
                Labels = Unchecked.defaultof<_>
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: ZeroShotClassificationInferenceUpdateOptions, value: MlTypes.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: ZeroShotClassificationInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("multiLabel")>]
        member _.MultiLabel(state: ZeroShotClassificationInferenceUpdateOptions, value: bool) =
            { state with MultiLabel = Some value }

        [<CustomOperation("labels")>]
        member _.Labels(state: ZeroShotClassificationInferenceUpdateOptions, value: string list) =
            { state with Labels = value }

    let zeroShotClassificationInferenceUpdateOptions = ZeroShotClassificationInferenceUpdateOptionsBuilder()

