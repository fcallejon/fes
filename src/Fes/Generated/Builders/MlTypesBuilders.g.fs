// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module MlTypesBuilders =

    type AdaptiveAllocationsSettingsBuilder() =
        member _.Yield(_: unit) : Types.AdaptiveAllocationsSettings =
            {
                Enabled = Unchecked.defaultof<_>
                MinNumberOfAllocations = None
                MaxNumberOfAllocations = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.AdaptiveAllocationsSettings, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("minNumberOfAllocations")>]
        member _.MinNumberOfAllocations(state: Types.AdaptiveAllocationsSettings, value: Types.Integer) =
            { state with MinNumberOfAllocations = Some value }

        [<CustomOperation("maxNumberOfAllocations")>]
        member _.MaxNumberOfAllocations(state: Types.AdaptiveAllocationsSettings, value: Types.Integer) =
            { state with MaxNumberOfAllocations = Some value }

    let adaptiveAllocationsSettings = AdaptiveAllocationsSettingsBuilder()

    type AnalysisConfigBuilder() =
        member _.Yield(_: unit) : Types.AnalysisConfig =
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
        member _.BucketSpan(state: Types.AnalysisConfig, value: Types.Duration) =
            { state with BucketSpan = Some value }

        [<CustomOperation("categorizationAnalyzer")>]
        member _.CategorizationAnalyzer(state: Types.AnalysisConfig, value: Types.CategorizationAnalyzer) =
            { state with CategorizationAnalyzer = Some value }

        [<CustomOperation("categorizationFieldName")>]
        member _.CategorizationFieldName(state: Types.AnalysisConfig, value: Types.Field) =
            { state with CategorizationFieldName = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: Types.AnalysisConfig, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("detectors")>]
        member _.Detectors(state: Types.AnalysisConfig, value: Types.Detector list) =
            { state with Detectors = value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: Types.AnalysisConfig, value: Types.Field list) =
            { state with Influencers = Some value }

        [<CustomOperation("latency")>]
        member _.Latency(state: Types.AnalysisConfig, value: Types.Duration) =
            { state with Latency = Some value }

        [<CustomOperation("modelPruneWindow")>]
        member _.ModelPruneWindow(state: Types.AnalysisConfig, value: Types.Duration) =
            { state with ModelPruneWindow = Some value }

        [<CustomOperation("multivariateByFields")>]
        member _.MultivariateByFields(state: Types.AnalysisConfig, value: bool) =
            { state with MultivariateByFields = Some value }

        [<CustomOperation("perPartitionCategorization")>]
        member _.PerPartitionCategorization(state: Types.AnalysisConfig, value: Types.PerPartitionCategorization) =
            { state with PerPartitionCategorization = Some value }

        [<CustomOperation("summaryCountFieldName")>]
        member _.SummaryCountFieldName(state: Types.AnalysisConfig, value: Types.Field) =
            { state with SummaryCountFieldName = Some value }

    let analysisConfig = AnalysisConfigBuilder()

    type AnalysisConfigReadBuilder() =
        member _.Yield(_: unit) : Types.AnalysisConfigRead =
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
        member _.BucketSpan(state: Types.AnalysisConfigRead, value: Types.Duration) =
            { state with BucketSpan = value }

        [<CustomOperation("detectors")>]
        member _.Detectors(state: Types.AnalysisConfigRead, value: Types.DetectorRead list) =
            { state with Detectors = value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: Types.AnalysisConfigRead, value: Types.Field list) =
            { state with Influencers = value }

        [<CustomOperation("categorizationAnalyzer")>]
        member _.CategorizationAnalyzer(state: Types.AnalysisConfigRead, value: Types.CategorizationAnalyzer) =
            { state with CategorizationAnalyzer = Some value }

        [<CustomOperation("categorizationFieldName")>]
        member _.CategorizationFieldName(state: Types.AnalysisConfigRead, value: Types.Field) =
            { state with CategorizationFieldName = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: Types.AnalysisConfigRead, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("latency")>]
        member _.Latency(state: Types.AnalysisConfigRead, value: Types.Duration) =
            { state with Latency = Some value }

        [<CustomOperation("modelPruneWindow")>]
        member _.ModelPruneWindow(state: Types.AnalysisConfigRead, value: Types.Duration) =
            { state with ModelPruneWindow = Some value }

        [<CustomOperation("multivariateByFields")>]
        member _.MultivariateByFields(state: Types.AnalysisConfigRead, value: bool) =
            { state with MultivariateByFields = Some value }

        [<CustomOperation("perPartitionCategorization")>]
        member _.PerPartitionCategorization(state: Types.AnalysisConfigRead, value: Types.PerPartitionCategorization) =
            { state with PerPartitionCategorization = Some value }

        [<CustomOperation("summaryCountFieldName")>]
        member _.SummaryCountFieldName(state: Types.AnalysisConfigRead, value: Types.Field) =
            { state with SummaryCountFieldName = Some value }

    let analysisConfigRead = AnalysisConfigReadBuilder()

    type AnalysisLimitsBuilder() =
        member _.Yield(_: unit) : Types.AnalysisLimits =
            {
                CategorizationExamplesLimit = None
                ModelMemoryLimit = None
            }

        [<CustomOperation("categorizationExamplesLimit")>]
        member _.CategorizationExamplesLimit(state: Types.AnalysisLimits, value: Types.Long) =
            { state with CategorizationExamplesLimit = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: Types.AnalysisLimits, value: Types.ByteSize) =
            { state with ModelMemoryLimit = Some value }

    let analysisLimits = AnalysisLimitsBuilder()

    type AnomalyBuilder() =
        member _.Yield(_: unit) : Types.Anomaly =
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
        member _.Actual(state: Types.Anomaly, value: Types.Double list) =
            { state with Actual = Some value }

        [<CustomOperation("anomalyScoreExplanation")>]
        member _.AnomalyScoreExplanation(state: Types.Anomaly, value: Types.AnomalyExplanation) =
            { state with AnomalyScoreExplanation = Some value }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: Types.Anomaly, value: Types.DurationValue<Types.UnitSeconds>) =
            { state with BucketSpan = value }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: Types.Anomaly, value: string) =
            { state with ByFieldName = Some value }

        [<CustomOperation("byFieldValue")>]
        member _.ByFieldValue(state: Types.Anomaly, value: string) =
            { state with ByFieldValue = Some value }

        [<CustomOperation("causes")>]
        member _.Causes(state: Types.Anomaly, value: Types.AnomalyCause list) =
            { state with Causes = Some value }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: Types.Anomaly, value: Types.Integer) =
            { state with DetectorIndex = value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: Types.Anomaly, value: string) =
            { state with FieldName = Some value }

        [<CustomOperation("function'")>]
        member _.Function(state: Types.Anomaly, value: string) =
            { state with Function = Some value }

        [<CustomOperation("functionDescription")>]
        member _.FunctionDescription(state: Types.Anomaly, value: string) =
            { state with FunctionDescription = Some value }

        [<CustomOperation("geoResults")>]
        member _.GeoResults(state: Types.Anomaly, value: Types.GeoResults) =
            { state with GeoResults = Some value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: Types.Anomaly, value: Types.Influence list) =
            { state with Influencers = Some value }

        [<CustomOperation("initialRecordScore")>]
        member _.InitialRecordScore(state: Types.Anomaly, value: Types.Double) =
            { state with InitialRecordScore = value }

        [<CustomOperation("isInterim")>]
        member _.IsInterim(state: Types.Anomaly, value: bool) =
            { state with IsInterim = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.Anomaly, value: string) =
            { state with JobId = value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: Types.Anomaly, value: string) =
            { state with OverFieldName = Some value }

        [<CustomOperation("overFieldValue")>]
        member _.OverFieldValue(state: Types.Anomaly, value: string) =
            { state with OverFieldValue = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Types.Anomaly, value: string) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: Types.Anomaly, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("probability")>]
        member _.Probability(state: Types.Anomaly, value: Types.Double) =
            { state with Probability = value }

        [<CustomOperation("recordScore")>]
        member _.RecordScore(state: Types.Anomaly, value: Types.Double) =
            { state with RecordScore = value }

        [<CustomOperation("resultType")>]
        member _.ResultType(state: Types.Anomaly, value: string) =
            { state with ResultType = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.Anomaly, value: Types.EpochTime<Types.UnitMillis>) =
            { state with Timestamp = value }

        [<CustomOperation("typical")>]
        member _.Typical(state: Types.Anomaly, value: Types.Double list) =
            { state with Typical = Some value }

    let anomaly = AnomalyBuilder()

    type AnomalyCauseBuilder() =
        member _.Yield(_: unit) : Types.AnomalyCause =
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
        member _.Actual(state: Types.AnomalyCause, value: Types.Double list) =
            { state with Actual = Some value }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: Types.AnomalyCause, value: Types.Name) =
            { state with ByFieldName = Some value }

        [<CustomOperation("byFieldValue")>]
        member _.ByFieldValue(state: Types.AnomalyCause, value: string) =
            { state with ByFieldValue = Some value }

        [<CustomOperation("correlatedByFieldValue")>]
        member _.CorrelatedByFieldValue(state: Types.AnomalyCause, value: string) =
            { state with CorrelatedByFieldValue = Some value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: Types.AnomalyCause, value: Types.Field) =
            { state with FieldName = Some value }

        [<CustomOperation("function'")>]
        member _.Function(state: Types.AnomalyCause, value: string) =
            { state with Function = Some value }

        [<CustomOperation("functionDescription")>]
        member _.FunctionDescription(state: Types.AnomalyCause, value: string) =
            { state with FunctionDescription = Some value }

        [<CustomOperation("geoResults")>]
        member _.GeoResults(state: Types.AnomalyCause, value: Types.GeoResults) =
            { state with GeoResults = Some value }

        [<CustomOperation("influencers")>]
        member _.Influencers(state: Types.AnomalyCause, value: Types.Influence list) =
            { state with Influencers = Some value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: Types.AnomalyCause, value: Types.Name) =
            { state with OverFieldName = Some value }

        [<CustomOperation("overFieldValue")>]
        member _.OverFieldValue(state: Types.AnomalyCause, value: string) =
            { state with OverFieldValue = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Types.AnomalyCause, value: string) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: Types.AnomalyCause, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("probability")>]
        member _.Probability(state: Types.AnomalyCause, value: Types.Double) =
            { state with Probability = value }

        [<CustomOperation("typical")>]
        member _.Typical(state: Types.AnomalyCause, value: Types.Double list) =
            { state with Typical = Some value }

    let anomalyCause = AnomalyCauseBuilder()

    type AnomalyExplanationBuilder() =
        member _.Yield(_: unit) : Types.AnomalyExplanation =
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
        member _.AnomalyCharacteristicsImpact(state: Types.AnomalyExplanation, value: Types.Integer) =
            { state with AnomalyCharacteristicsImpact = Some value }

        [<CustomOperation("anomalyLength")>]
        member _.AnomalyLength(state: Types.AnomalyExplanation, value: Types.Integer) =
            { state with AnomalyLength = Some value }

        [<CustomOperation("anomalyType")>]
        member _.AnomalyType(state: Types.AnomalyExplanation, value: string) =
            { state with AnomalyType = Some value }

        [<CustomOperation("highVariancePenalty")>]
        member _.HighVariancePenalty(state: Types.AnomalyExplanation, value: bool) =
            { state with HighVariancePenalty = Some value }

        [<CustomOperation("incompleteBucketPenalty")>]
        member _.IncompleteBucketPenalty(state: Types.AnomalyExplanation, value: bool) =
            { state with IncompleteBucketPenalty = Some value }

        [<CustomOperation("lowerConfidenceBound")>]
        member _.LowerConfidenceBound(state: Types.AnomalyExplanation, value: Types.Double) =
            { state with LowerConfidenceBound = Some value }

        [<CustomOperation("multiBucketImpact")>]
        member _.MultiBucketImpact(state: Types.AnomalyExplanation, value: Types.Integer) =
            { state with MultiBucketImpact = Some value }

        [<CustomOperation("singleBucketImpact")>]
        member _.SingleBucketImpact(state: Types.AnomalyExplanation, value: Types.Integer) =
            { state with SingleBucketImpact = Some value }

        [<CustomOperation("typicalValue")>]
        member _.TypicalValue(state: Types.AnomalyExplanation, value: Types.Double) =
            { state with TypicalValue = Some value }

        [<CustomOperation("upperConfidenceBound")>]
        member _.UpperConfidenceBound(state: Types.AnomalyExplanation, value: Types.Double) =
            { state with UpperConfidenceBound = Some value }

    let anomalyExplanation = AnomalyExplanationBuilder()

    type CalendarEventBuilder() =
        member _.Yield(_: unit) : Types.CalendarEvent =
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
        member _.CalendarId(state: Types.CalendarEvent, value: Types.Id) =
            { state with CalendarId = Some value }

        [<CustomOperation("eventId")>]
        member _.EventId(state: Types.CalendarEvent, value: Types.Id) =
            { state with EventId = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.CalendarEvent, value: string) =
            { state with Description = value }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: Types.CalendarEvent, value: Types.DateTime) =
            { state with EndTime = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.CalendarEvent, value: Types.DateTime) =
            { state with StartTime = value }

        [<CustomOperation("skipResult")>]
        member _.SkipResult(state: Types.CalendarEvent, value: bool) =
            { state with SkipResult = Some value }

        [<CustomOperation("skipModelUpdate")>]
        member _.SkipModelUpdate(state: Types.CalendarEvent, value: bool) =
            { state with SkipModelUpdate = Some value }

        [<CustomOperation("forceTimeShift")>]
        member _.ForceTimeShift(state: Types.CalendarEvent, value: Types.Integer) =
            { state with ForceTimeShift = Some value }

    let calendarEvent = CalendarEventBuilder()

    type CategorizationAnalyzerDefinitionBuilder() =
        member _.Yield(_: unit) : Types.CategorizationAnalyzerDefinition =
            {
                CharFilter = None
                Filter = None
                Tokenizer = None
            }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: Types.CategorizationAnalyzerDefinition, value: Types.CharFilter list) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.CategorizationAnalyzerDefinition, value: Types.TokenFilter list) =
            { state with Filter = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: Types.CategorizationAnalyzerDefinition, value: Types.Tokenizer) =
            { state with Tokenizer = Some value }

    let categorizationAnalyzerDefinition = CategorizationAnalyzerDefinitionBuilder()

    type CategoryBuilder() =
        member _.Yield(_: unit) : Types.Category =
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
        member _.CategoryId(state: Types.Category, value: Types.Ulong) =
            { state with CategoryId = value }

        [<CustomOperation("examples")>]
        member _.Examples(state: Types.Category, value: string list) =
            { state with Examples = value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: Types.Category, value: Types.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.Category, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("maxMatchingLength")>]
        member _.MaxMatchingLength(state: Types.Category, value: Types.Ulong) =
            { state with MaxMatchingLength = value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Types.Category, value: string) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: Types.Category, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("regex")>]
        member _.Regex(state: Types.Category, value: string) =
            { state with Regex = value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Types.Category, value: string) =
            { state with Terms = value }

        [<CustomOperation("numMatches")>]
        member _.NumMatches(state: Types.Category, value: Types.Long) =
            { state with NumMatches = Some value }

        [<CustomOperation("preferredToCategories")>]
        member _.PreferredToCategories(state: Types.Category, value: Types.Id list) =
            { state with PreferredToCategories = Some value }

        [<CustomOperation("p")>]
        member _.P(state: Types.Category, value: string) =
            { state with P = Some value }

        [<CustomOperation("resultType")>]
        member _.ResultType(state: Types.Category, value: string) =
            { state with ResultType = value }

        [<CustomOperation("mlcategory")>]
        member _.Mlcategory(state: Types.Category, value: string) =
            { state with Mlcategory = value }

    let category = CategoryBuilder()

    type ClassificationInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.ClassificationInferenceOptions =
            {
                NumTopClasses = None
                NumTopFeatureImportanceValues = None
                PredictionFieldType = None
                ResultsField = None
                TopClassesResultsField = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.ClassificationInferenceOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: Types.ClassificationInferenceOptions, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

        [<CustomOperation("predictionFieldType")>]
        member _.PredictionFieldType(state: Types.ClassificationInferenceOptions, value: string) =
            { state with PredictionFieldType = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.ClassificationInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("topClassesResultsField")>]
        member _.TopClassesResultsField(state: Types.ClassificationInferenceOptions, value: string) =
            { state with TopClassesResultsField = Some value }

    let classificationInferenceOptions = ClassificationInferenceOptionsBuilder()

    type CommonTokenizationConfigBuilder() =
        member _.Yield(_: unit) : Types.CommonTokenizationConfig =
            {
                DoLowerCase = None
                MaxSequenceLength = None
                Span = None
                Truncate = None
                WithSpecialTokens = None
            }

        [<CustomOperation("doLowerCase")>]
        member _.DoLowerCase(state: Types.CommonTokenizationConfig, value: bool) =
            { state with DoLowerCase = Some value }

        [<CustomOperation("maxSequenceLength")>]
        member _.MaxSequenceLength(state: Types.CommonTokenizationConfig, value: Types.Integer) =
            { state with MaxSequenceLength = Some value }

        [<CustomOperation("span")>]
        member _.Span(state: Types.CommonTokenizationConfig, value: Types.Integer) =
            { state with Span = Some value }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: Types.CommonTokenizationConfig, value: Types.TokenizationTruncate) =
            { state with Truncate = Some value }

        [<CustomOperation("withSpecialTokens")>]
        member _.WithSpecialTokens(state: Types.CommonTokenizationConfig, value: bool) =
            { state with WithSpecialTokens = Some value }

    let commonTokenizationConfig = CommonTokenizationConfigBuilder()

    type DataCountsBuilder() =
        member _.Yield(_: unit) : Types.DataCounts =
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
        member _.BucketCount(state: Types.DataCounts, value: Types.Long) =
            { state with BucketCount = value }

        [<CustomOperation("earliestRecordTimestamp")>]
        member _.EarliestRecordTimestamp(state: Types.DataCounts, value: Types.Long) =
            { state with EarliestRecordTimestamp = Some value }

        [<CustomOperation("emptyBucketCount")>]
        member _.EmptyBucketCount(state: Types.DataCounts, value: Types.Long) =
            { state with EmptyBucketCount = value }

        [<CustomOperation("inputBytes")>]
        member _.InputBytes(state: Types.DataCounts, value: Types.Long) =
            { state with InputBytes = value }

        [<CustomOperation("inputFieldCount")>]
        member _.InputFieldCount(state: Types.DataCounts, value: Types.Long) =
            { state with InputFieldCount = value }

        [<CustomOperation("inputRecordCount")>]
        member _.InputRecordCount(state: Types.DataCounts, value: Types.Long) =
            { state with InputRecordCount = value }

        [<CustomOperation("invalidDateCount")>]
        member _.InvalidDateCount(state: Types.DataCounts, value: Types.Long) =
            { state with InvalidDateCount = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.DataCounts, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("lastDataTime")>]
        member _.LastDataTime(state: Types.DataCounts, value: Types.Long) =
            { state with LastDataTime = Some value }

        [<CustomOperation("latestEmptyBucketTimestamp")>]
        member _.LatestEmptyBucketTimestamp(state: Types.DataCounts, value: Types.Long) =
            { state with LatestEmptyBucketTimestamp = Some value }

        [<CustomOperation("latestRecordTimestamp")>]
        member _.LatestRecordTimestamp(state: Types.DataCounts, value: Types.Long) =
            { state with LatestRecordTimestamp = Some value }

        [<CustomOperation("latestSparseBucketTimestamp")>]
        member _.LatestSparseBucketTimestamp(state: Types.DataCounts, value: Types.Long) =
            { state with LatestSparseBucketTimestamp = Some value }

        [<CustomOperation("latestBucketTimestamp")>]
        member _.LatestBucketTimestamp(state: Types.DataCounts, value: Types.Long) =
            { state with LatestBucketTimestamp = Some value }

        [<CustomOperation("logTime")>]
        member _.LogTime(state: Types.DataCounts, value: Types.Long) =
            { state with LogTime = Some value }

        [<CustomOperation("missingFieldCount")>]
        member _.MissingFieldCount(state: Types.DataCounts, value: Types.Long) =
            { state with MissingFieldCount = value }

        [<CustomOperation("outOfOrderTimestampCount")>]
        member _.OutOfOrderTimestampCount(state: Types.DataCounts, value: Types.Long) =
            { state with OutOfOrderTimestampCount = value }

        [<CustomOperation("processedFieldCount")>]
        member _.ProcessedFieldCount(state: Types.DataCounts, value: Types.Long) =
            { state with ProcessedFieldCount = value }

        [<CustomOperation("processedRecordCount")>]
        member _.ProcessedRecordCount(state: Types.DataCounts, value: Types.Long) =
            { state with ProcessedRecordCount = value }

        [<CustomOperation("sparseBucketCount")>]
        member _.SparseBucketCount(state: Types.DataCounts, value: Types.Long) =
            { state with SparseBucketCount = value }

    let dataCounts = DataCountsBuilder()

    type DataDescriptionBuilder() =
        member _.Yield(_: unit) : Types.DataDescription =
            {
                Format = None
                TimeField = None
                TimeFormat = None
                FieldDelimiter = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DataDescription, value: string) =
            { state with Format = Some value }

        [<CustomOperation("timeField")>]
        member _.TimeField(state: Types.DataDescription, value: Types.Field) =
            { state with TimeField = Some value }

        [<CustomOperation("timeFormat")>]
        member _.TimeFormat(state: Types.DataDescription, value: string) =
            { state with TimeFormat = Some value }

        [<CustomOperation("fieldDelimiter")>]
        member _.FieldDelimiter(state: Types.DataDescription, value: string) =
            { state with FieldDelimiter = Some value }

    let dataDescription = DataDescriptionBuilder()

    type MlTypesDatafeedBuilder() =
        member _.Yield(_: unit) : Types.MlTypesDatafeed =
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
        member _.Aggregations(state: Types.MlTypesDatafeed, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("authorization")>]
        member _.Authorization(state: Types.MlTypesDatafeed, value: Types.DatafeedAuthorization) =
            { state with Authorization = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: Types.MlTypesDatafeed, value: Types.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: Types.MlTypesDatafeed, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: Types.MlTypesDatafeed, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.MlTypesDatafeed, value: string list) =
            { state with Indices = value }

        [<CustomOperation("indexes")>]
        member _.Indexes(state: Types.MlTypesDatafeed, value: string list) =
            { state with Indexes = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.MlTypesDatafeed, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: Types.MlTypesDatafeed, value: Types.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.MlTypesDatafeed, value: Types.QueryContainer) =
            { state with Query = value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: Types.MlTypesDatafeed, value: Types.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: Types.MlTypesDatafeed, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: Types.MlTypesDatafeed, value: Types.Integer) =
            { state with ScrollSize = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: Types.MlTypesDatafeed, value: Types.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Types.MlTypesDatafeed, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: Types.MlTypesDatafeed, value: Types.IndicesOptions) =
            { state with IndicesOptions = Some value }

    let mlTypesDatafeed = MlTypesDatafeedBuilder()

    type DatafeedAuthorizationBuilder() =
        member _.Yield(_: unit) : Types.DatafeedAuthorization =
            {
                ApiKey = None
                Roles = None
                ServiceAccount = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.DatafeedAuthorization, value: Types.ApiKeyAuthorization) =
            { state with ApiKey = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.DatafeedAuthorization, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("serviceAccount")>]
        member _.ServiceAccount(state: Types.DatafeedAuthorization, value: string) =
            { state with ServiceAccount = Some value }

    let datafeedAuthorization = DatafeedAuthorizationBuilder()

    type DatafeedConfigBuilder() =
        member _.Yield(_: unit) : Types.DatafeedConfig =
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
        member _.Aggregations(state: Types.DatafeedConfig, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: Types.DatafeedConfig, value: Types.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: Types.DatafeedConfig, value: Types.Id) =
            { state with DatafeedId = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: Types.DatafeedConfig, value: Types.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: Types.DatafeedConfig, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.DatafeedConfig, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: Types.DatafeedConfig, value: Types.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.DatafeedConfig, value: Types.Id) =
            { state with JobId = Some value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: Types.DatafeedConfig, value: Types.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.DatafeedConfig, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: Types.DatafeedConfig, value: Types.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Types.DatafeedConfig, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: Types.DatafeedConfig, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: Types.DatafeedConfig, value: Types.Integer) =
            { state with ScrollSize = Some value }

    let datafeedConfig = DatafeedConfigBuilder()

    type DatafeedStatsBuilder() =
        member _.Yield(_: unit) : Types.DatafeedStats =
            {
                AssignmentExplanation = None
                DatafeedId = Unchecked.defaultof<_>
                Node = None
                State = Unchecked.defaultof<_>
                TimingStats = None
                RunningState = None
            }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: Types.DatafeedStats, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: Types.DatafeedStats, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.DatafeedStats, value: Types.DiscoveryNodeCompact) =
            { state with Node = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.DatafeedStats, value: Types.DatafeedState) =
            { state with State = value }

        [<CustomOperation("timingStats")>]
        member _.TimingStats(state: Types.DatafeedStats, value: Types.DatafeedTimingStats) =
            { state with TimingStats = Some value }

        [<CustomOperation("runningState")>]
        member _.RunningState(state: Types.DatafeedStats, value: Types.DatafeedRunningState) =
            { state with RunningState = Some value }

    let datafeedStats = DatafeedStatsBuilder()

    type DatafeedTimingStatsBuilder() =
        member _.Yield(_: unit) : Types.DatafeedTimingStats =
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
        member _.BucketCount(state: Types.DatafeedTimingStats, value: Types.Long) =
            { state with BucketCount = value }

        [<CustomOperation("exponentialAverageSearchTimePerHourMs")>]
        member _.ExponentialAverageSearchTimePerHourMs(state: Types.DatafeedTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with ExponentialAverageSearchTimePerHourMs = value }

        [<CustomOperation("exponentialAverageCalculationContext")>]
        member _.ExponentialAverageCalculationContext(state: Types.DatafeedTimingStats, value: Types.ExponentialAverageCalculationContext) =
            { state with ExponentialAverageCalculationContext = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.DatafeedTimingStats, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("searchCount")>]
        member _.SearchCount(state: Types.DatafeedTimingStats, value: Types.Long) =
            { state with SearchCount = value }

        [<CustomOperation("totalSearchTimeMs")>]
        member _.TotalSearchTimeMs(state: Types.DatafeedTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with TotalSearchTimeMs = value }

        [<CustomOperation("averageSearchTimePerBucketMs")>]
        member _.AverageSearchTimePerBucketMs(state: Types.DatafeedTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with AverageSearchTimePerBucketMs = Some value }

    let datafeedTimingStats = DatafeedTimingStatsBuilder()

    type DataframeAnalysisBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalysis =
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
        member _.Alpha(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with Alpha = Some value }

        [<CustomOperation("dependentVariable")>]
        member _.DependentVariable(state: Types.DataframeAnalysis, value: string) =
            { state with DependentVariable = value }

        [<CustomOperation("downsampleFactor")>]
        member _.DownsampleFactor(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with DownsampleFactor = Some value }

        [<CustomOperation("earlyStoppingEnabled")>]
        member _.EarlyStoppingEnabled(state: Types.DataframeAnalysis, value: bool) =
            { state with EarlyStoppingEnabled = Some value }

        [<CustomOperation("eta")>]
        member _.Eta(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with Eta = Some value }

        [<CustomOperation("etaGrowthRatePerTree")>]
        member _.EtaGrowthRatePerTree(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with EtaGrowthRatePerTree = Some value }

        [<CustomOperation("featureBagFraction")>]
        member _.FeatureBagFraction(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with FeatureBagFraction = Some value }

        [<CustomOperation("featureProcessors")>]
        member _.FeatureProcessors(state: Types.DataframeAnalysis, value: Types.DataframeAnalysisFeatureProcessor list) =
            { state with FeatureProcessors = Some value }

        [<CustomOperation("gamma")>]
        member _.Gamma(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with Gamma = Some value }

        [<CustomOperation("lambda")>]
        member _.Lambda(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with Lambda = Some value }

        [<CustomOperation("maxOptimizationRoundsPerHyperparameter")>]
        member _.MaxOptimizationRoundsPerHyperparameter(state: Types.DataframeAnalysis, value: Types.Integer) =
            { state with MaxOptimizationRoundsPerHyperparameter = Some value }

        [<CustomOperation("maxTrees")>]
        member _.MaxTrees(state: Types.DataframeAnalysis, value: Types.Integer) =
            { state with MaxTrees = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: Types.DataframeAnalysis, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

        [<CustomOperation("predictionFieldName")>]
        member _.PredictionFieldName(state: Types.DataframeAnalysis, value: Types.Field) =
            { state with PredictionFieldName = Some value }

        [<CustomOperation("randomizeSeed")>]
        member _.RandomizeSeed(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with RandomizeSeed = Some value }

        [<CustomOperation("softTreeDepthLimit")>]
        member _.SoftTreeDepthLimit(state: Types.DataframeAnalysis, value: Types.Integer) =
            { state with SoftTreeDepthLimit = Some value }

        [<CustomOperation("softTreeDepthTolerance")>]
        member _.SoftTreeDepthTolerance(state: Types.DataframeAnalysis, value: Types.Double) =
            { state with SoftTreeDepthTolerance = Some value }

        [<CustomOperation("trainingPercent")>]
        member _.TrainingPercent(state: Types.DataframeAnalysis, value: Types.Percentage) =
            { state with TrainingPercent = Some value }

    let dataframeAnalysis = DataframeAnalysisBuilder()

    type DataframeAnalysisAnalyzedFieldsBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalysisAnalyzedFields =
            {
                Includes = None
                Excludes = None
            }

        [<CustomOperation("includes")>]
        member _.Includes(state: Types.DataframeAnalysisAnalyzedFields, value: string list) =
            { state with Includes = Some value }

        [<CustomOperation("excludes")>]
        member _.Excludes(state: Types.DataframeAnalysisAnalyzedFields, value: string list) =
            { state with Excludes = Some value }

    let dataframeAnalysisAnalyzedFields = DataframeAnalysisAnalyzedFieldsBuilder()

    let ofIncludes (value: string list) : Types.DataframeAnalysisAnalyzedFields =
        {
            Includes = value
            Excludes = None
        }

    type DataframeAnalysisClassificationBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalysisClassification =
            {
                ClassAssignmentObjective = None
                NumTopClasses = None
            }

        [<CustomOperation("classAssignmentObjective")>]
        member _.ClassAssignmentObjective(state: Types.DataframeAnalysisClassification, value: string) =
            { state with ClassAssignmentObjective = Some value }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.DataframeAnalysisClassification, value: Types.Integer) =
            { state with NumTopClasses = Some value }

    let dataframeAnalysisClassification = DataframeAnalysisClassificationBuilder()

    module DataframeAnalysis =

        let classification (value: Types.DataframeAnalysisClassification) =
            Types.DataframeAnalysisContainer.Classification value

        let outlierDetection (value: Types.DataframeAnalysisOutlierDetection) =
            Types.DataframeAnalysisContainer.OutlierDetection value

        let regression (value: Types.DataframeAnalysisRegression) =
            Types.DataframeAnalysisContainer.Regression value

    module DataframeAnalysisFeatureProcessor =

        let frequencyEncoding (value: Types.DataframeAnalysisFeatureProcessorFrequencyEncoding) =
            Types.DataframeAnalysisFeatureProcessor.FrequencyEncoding value

        let multiEncoding (value: Types.DataframeAnalysisFeatureProcessorMultiEncoding) =
            Types.DataframeAnalysisFeatureProcessor.MultiEncoding value

        let nGramEncoding (value: Types.DataframeAnalysisFeatureProcessorNGramEncoding) =
            Types.DataframeAnalysisFeatureProcessor.NGramEncoding value

        let oneHotEncoding (value: Types.DataframeAnalysisFeatureProcessorOneHotEncoding) =
            Types.DataframeAnalysisFeatureProcessor.OneHotEncoding value

        let targetMeanEncoding (value: Types.DataframeAnalysisFeatureProcessorTargetMeanEncoding) =
            Types.DataframeAnalysisFeatureProcessor.TargetMeanEncoding value

    type DataframeAnalysisFeatureProcessorNGramEncodingBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalysisFeatureProcessorNGramEncoding =
            {
                FeaturePrefix = None
                Field = Unchecked.defaultof<_>
                Length = None
                NGrams = Unchecked.defaultof<_>
                Start = None
                Custom = None
            }

        [<CustomOperation("featurePrefix")>]
        member _.FeaturePrefix(state: Types.DataframeAnalysisFeatureProcessorNGramEncoding, value: string) =
            { state with FeaturePrefix = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DataframeAnalysisFeatureProcessorNGramEncoding, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("length")>]
        member _.Length(state: Types.DataframeAnalysisFeatureProcessorNGramEncoding, value: Types.Integer) =
            { state with Length = Some value }

        [<CustomOperation("nGrams")>]
        member _.NGrams(state: Types.DataframeAnalysisFeatureProcessorNGramEncoding, value: Types.Integer list) =
            { state with NGrams = value }

        [<CustomOperation("start")>]
        member _.Start(state: Types.DataframeAnalysisFeatureProcessorNGramEncoding, value: Types.Integer) =
            { state with Start = Some value }

        [<CustomOperation("custom")>]
        member _.Custom(state: Types.DataframeAnalysisFeatureProcessorNGramEncoding, value: bool) =
            { state with Custom = Some value }

    let dataframeAnalysisFeatureProcessorNGramEncoding = DataframeAnalysisFeatureProcessorNGramEncodingBuilder()

    type DataframeAnalysisOutlierDetectionBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalysisOutlierDetection =
            {
                ComputeFeatureInfluence = None
                FeatureInfluenceThreshold = None
                Method = None
                NNeighbors = None
                OutlierFraction = None
                StandardizationEnabled = None
            }

        [<CustomOperation("computeFeatureInfluence")>]
        member _.ComputeFeatureInfluence(state: Types.DataframeAnalysisOutlierDetection, value: bool) =
            { state with ComputeFeatureInfluence = Some value }

        [<CustomOperation("featureInfluenceThreshold")>]
        member _.FeatureInfluenceThreshold(state: Types.DataframeAnalysisOutlierDetection, value: Types.Double) =
            { state with FeatureInfluenceThreshold = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: Types.DataframeAnalysisOutlierDetection, value: string) =
            { state with Method = Some value }

        [<CustomOperation("nNeighbors")>]
        member _.NNeighbors(state: Types.DataframeAnalysisOutlierDetection, value: Types.Integer) =
            { state with NNeighbors = Some value }

        [<CustomOperation("outlierFraction")>]
        member _.OutlierFraction(state: Types.DataframeAnalysisOutlierDetection, value: Types.Double) =
            { state with OutlierFraction = Some value }

        [<CustomOperation("standardizationEnabled")>]
        member _.StandardizationEnabled(state: Types.DataframeAnalysisOutlierDetection, value: bool) =
            { state with StandardizationEnabled = Some value }

    let dataframeAnalysisOutlierDetection = DataframeAnalysisOutlierDetectionBuilder()

    type DataframeAnalysisRegressionBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalysisRegression =
            {
                LossFunction = None
                LossFunctionParameter = None
            }

        [<CustomOperation("lossFunction")>]
        member _.LossFunction(state: Types.DataframeAnalysisRegression, value: string) =
            { state with LossFunction = Some value }

        [<CustomOperation("lossFunctionParameter")>]
        member _.LossFunctionParameter(state: Types.DataframeAnalysisRegression, value: Types.Double) =
            { state with LossFunctionParameter = Some value }

    let dataframeAnalysisRegression = DataframeAnalysisRegressionBuilder()

    type DataframeAnalyticsBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalytics =
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
        member _.AnalysisStats(state: Types.DataframeAnalytics, value: Types.DataframeAnalyticsStatsContainer) =
            { state with AnalysisStats = Some value }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: Types.DataframeAnalytics, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("dataCounts")>]
        member _.DataCounts(state: Types.DataframeAnalytics, value: Types.DataframeAnalyticsStatsDataCounts) =
            { state with DataCounts = value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.DataframeAnalytics, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("memoryUsage")>]
        member _.MemoryUsage(state: Types.DataframeAnalytics, value: Types.DataframeAnalyticsStatsMemoryUsage) =
            { state with MemoryUsage = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.DataframeAnalytics, value: Types.NodeAttributes) =
            { state with Node = Some value }

        [<CustomOperation("progress")>]
        member _.Progress(state: Types.DataframeAnalytics, value: Types.DataframeAnalyticsStatsProgress list) =
            { state with Progress = value }

        [<CustomOperation("state")>]
        member _.State(state: Types.DataframeAnalytics, value: Types.DataframeState) =
            { state with State = value }

    let dataframeAnalytics = DataframeAnalyticsBuilder()

    type DataframeAnalyticsAuthorizationBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalyticsAuthorization =
            {
                ApiKey = None
                Roles = None
                ServiceAccount = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.DataframeAnalyticsAuthorization, value: Types.ApiKeyAuthorization) =
            { state with ApiKey = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.DataframeAnalyticsAuthorization, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("serviceAccount")>]
        member _.ServiceAccount(state: Types.DataframeAnalyticsAuthorization, value: string) =
            { state with ServiceAccount = Some value }

    let dataframeAnalyticsAuthorization = DataframeAnalyticsAuthorizationBuilder()

    type DataframeAnalyticsFieldSelectionBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalyticsFieldSelection =
            {
                IsIncluded = Unchecked.defaultof<_>
                IsRequired = Unchecked.defaultof<_>
                FeatureType = None
                MappingTypes = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                Reason = None
            }

        [<CustomOperation("isIncluded")>]
        member _.IsIncluded(state: Types.DataframeAnalyticsFieldSelection, value: bool) =
            { state with IsIncluded = value }

        [<CustomOperation("isRequired")>]
        member _.IsRequired(state: Types.DataframeAnalyticsFieldSelection, value: bool) =
            { state with IsRequired = value }

        [<CustomOperation("featureType")>]
        member _.FeatureType(state: Types.DataframeAnalyticsFieldSelection, value: string) =
            { state with FeatureType = Some value }

        [<CustomOperation("mappingTypes")>]
        member _.MappingTypes(state: Types.DataframeAnalyticsFieldSelection, value: string list) =
            { state with MappingTypes = value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.DataframeAnalyticsFieldSelection, value: Types.Field) =
            { state with Name = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.DataframeAnalyticsFieldSelection, value: string) =
            { state with Reason = Some value }

    let dataframeAnalyticsFieldSelection = DataframeAnalyticsFieldSelectionBuilder()

    type DataframeAnalyticsSourceBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalyticsSource =
            {
                Index = Unchecked.defaultof<_>
                Query = None
                RuntimeMappings = None
                Source = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DataframeAnalyticsSource, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.DataframeAnalyticsSource, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Types.DataframeAnalyticsSource, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.DataframeAnalyticsSource, value: Types.DataframeAnalysisAnalyzedFields) =
            { state with Source = Some value }

    let dataframeAnalyticsSource = DataframeAnalyticsSourceBuilder()

    module DataframeAnalyticsStats =

        let classificationStats (value: Types.DataframeAnalyticsStatsHyperparameters) =
            Types.DataframeAnalyticsStatsContainer.ClassificationStats value

        let outlierDetectionStats (value: Types.DataframeAnalyticsStatsOutlierDetection) =
            Types.DataframeAnalyticsStatsContainer.OutlierDetectionStats value

        let regressionStats (value: Types.DataframeAnalyticsStatsHyperparameters) =
            Types.DataframeAnalyticsStatsContainer.RegressionStats value

    type DataframeAnalyticsStatsMemoryUsageBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalyticsStatsMemoryUsage =
            {
                MemoryReestimateBytes = None
                PeakUsageBytes = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
                Timestamp = None
            }

        [<CustomOperation("memoryReestimateBytes")>]
        member _.MemoryReestimateBytes(state: Types.DataframeAnalyticsStatsMemoryUsage, value: Types.Long) =
            { state with MemoryReestimateBytes = Some value }

        [<CustomOperation("peakUsageBytes")>]
        member _.PeakUsageBytes(state: Types.DataframeAnalyticsStatsMemoryUsage, value: Types.Long) =
            { state with PeakUsageBytes = value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.DataframeAnalyticsStatsMemoryUsage, value: string) =
            { state with Status = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.DataframeAnalyticsStatsMemoryUsage, value: Types.EpochTime<Types.UnitMillis>) =
            { state with Timestamp = Some value }

    let dataframeAnalyticsStatsMemoryUsage = DataframeAnalyticsStatsMemoryUsageBuilder()

    type DataframeAnalyticsSummaryBuilder() =
        member _.Yield(_: unit) : Types.DataframeAnalyticsSummary =
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
        member _.AllowLazyStart(state: Types.DataframeAnalyticsSummary, value: bool) =
            { state with AllowLazyStart = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: Types.DataframeAnalyticsSummary, value: Types.DataframeAnalysisContainer) =
            { state with Analysis = value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: Types.DataframeAnalyticsSummary, value: Types.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

        [<CustomOperation("authorization")>]
        member _.Authorization(state: Types.DataframeAnalyticsSummary, value: Types.DataframeAnalyticsAuthorization) =
            { state with Authorization = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: Types.DataframeAnalyticsSummary, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreateTime = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DataframeAnalyticsSummary, value: string) =
            { state with Description = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: Types.DataframeAnalyticsSummary, value: Types.DataframeAnalyticsDestination) =
            { state with Dest = value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.DataframeAnalyticsSummary, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: Types.DataframeAnalyticsSummary, value: Types.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: Types.DataframeAnalyticsSummary, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.DataframeAnalyticsSummary, value: Types.DataframeAnalyticsSource) =
            { state with Source = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.DataframeAnalyticsSummary, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DataframeAnalyticsSummary, value: Types.Metadata) =
            { state with Meta = Some value }

    let dataframeAnalyticsSummary = DataframeAnalyticsSummaryBuilder()

    type DataframeEvaluationClassificationBuilder() =
        member _.Yield(_: unit) : Types.DataframeEvaluationClassification =
            {
                ActualField = Unchecked.defaultof<_>
                PredictedField = None
                TopClassesField = None
                Metrics = None
            }

        [<CustomOperation("actualField")>]
        member _.ActualField(state: Types.DataframeEvaluationClassification, value: Types.Field) =
            { state with ActualField = value }

        [<CustomOperation("predictedField")>]
        member _.PredictedField(state: Types.DataframeEvaluationClassification, value: Types.Field) =
            { state with PredictedField = Some value }

        [<CustomOperation("topClassesField")>]
        member _.TopClassesField(state: Types.DataframeEvaluationClassification, value: Types.Field) =
            { state with TopClassesField = Some value }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: Types.DataframeEvaluationClassification, value: Types.DataframeEvaluationClassificationMetrics) =
            { state with Metrics = Some value }

    let dataframeEvaluationClassification = DataframeEvaluationClassificationBuilder()

    type DataframeEvaluationClassificationMetricsBuilder() =
        member _.Yield(_: unit) : Types.DataframeEvaluationClassificationMetrics =
            {
                Accuracy = None
                MulticlassConfusionMatrix = None
            }

        [<CustomOperation("accuracy")>]
        member _.Accuracy(state: Types.DataframeEvaluationClassificationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Accuracy = Some value }

        [<CustomOperation("multiclassConfusionMatrix")>]
        member _.MulticlassConfusionMatrix(state: Types.DataframeEvaluationClassificationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with MulticlassConfusionMatrix = Some value }

    let dataframeEvaluationClassificationMetrics = DataframeEvaluationClassificationMetricsBuilder()

    type DataframeEvaluationClassificationMetricsAucRocBuilder() =
        member _.Yield(_: unit) : Types.DataframeEvaluationClassificationMetricsAucRoc =
            {
                ClassName = None
                IncludeCurve = None
            }

        [<CustomOperation("className")>]
        member _.ClassName(state: Types.DataframeEvaluationClassificationMetricsAucRoc, value: Types.Name) =
            { state with ClassName = Some value }

        [<CustomOperation("includeCurve")>]
        member _.IncludeCurve(state: Types.DataframeEvaluationClassificationMetricsAucRoc, value: bool) =
            { state with IncludeCurve = Some value }

    let dataframeEvaluationClassificationMetricsAucRoc = DataframeEvaluationClassificationMetricsAucRocBuilder()

    module DataframeEvaluation =

        let classification (value: Types.DataframeEvaluationClassification) =
            Types.DataframeEvaluationContainer.Classification value

        let outlierDetection (value: Types.DataframeEvaluationOutlierDetection) =
            Types.DataframeEvaluationContainer.OutlierDetection value

        let regression (value: Types.DataframeEvaluationRegression) =
            Types.DataframeEvaluationContainer.Regression value

    type DataframeEvaluationMetricsBuilder() =
        member _.Yield(_: unit) : Types.DataframeEvaluationMetrics =
            {
                AucRoc = None
                Precision = None
                Recall = None
            }

        [<CustomOperation("aucRoc")>]
        member _.AucRoc(state: Types.DataframeEvaluationMetrics, value: Types.DataframeEvaluationClassificationMetricsAucRoc) =
            { state with AucRoc = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.DataframeEvaluationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: Types.DataframeEvaluationMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Recall = Some value }

    let dataframeEvaluationMetrics = DataframeEvaluationMetricsBuilder()

    type DataframeEvaluationRegressionMetricsBuilder() =
        member _.Yield(_: unit) : Types.DataframeEvaluationRegressionMetrics =
            {
                Mse = None
                Msle = None
                Huber = None
                RSquared = None
            }

        [<CustomOperation("mse")>]
        member _.Mse(state: Types.DataframeEvaluationRegressionMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Mse = Some value }

        [<CustomOperation("msle")>]
        member _.Msle(state: Types.DataframeEvaluationRegressionMetrics, value: Types.DataframeEvaluationRegressionMetricsMsle) =
            { state with Msle = Some value }

        [<CustomOperation("huber")>]
        member _.Huber(state: Types.DataframeEvaluationRegressionMetrics, value: Types.DataframeEvaluationRegressionMetricsHuber) =
            { state with Huber = Some value }

        [<CustomOperation("rSquared")>]
        member _.RSquared(state: Types.DataframeEvaluationRegressionMetrics, value: Map<string, System.Text.Json.JsonElement>) =
            { state with RSquared = Some value }

    let dataframeEvaluationRegressionMetrics = DataframeEvaluationRegressionMetricsBuilder()

    type DetectionRuleBuilder() =
        member _.Yield(_: unit) : Types.DetectionRule =
            {
                Actions = None
                Conditions = None
                Scope = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Types.DetectionRule, value: Types.RuleAction list) =
            { state with Actions = Some value }

        [<CustomOperation("conditions")>]
        member _.Conditions(state: Types.DetectionRule, value: Types.RuleCondition list) =
            { state with Conditions = Some value }

        [<CustomOperation("scope")>]
        member _.Scope(state: Types.DetectionRule, value: Map<Types.Field, Types.FilterRef>) =
            { state with Scope = Some value }

    let detectionRule = DetectionRuleBuilder()

    type DetectorBuilder() =
        member _.Yield(_: unit) : Types.Detector =
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
        member _.ByFieldName(state: Types.Detector, value: Types.Field) =
            { state with ByFieldName = Some value }

        [<CustomOperation("customRules")>]
        member _.CustomRules(state: Types.Detector, value: Types.DetectionRule list) =
            { state with CustomRules = Some value }

        [<CustomOperation("detectorDescription")>]
        member _.DetectorDescription(state: Types.Detector, value: string) =
            { state with DetectorDescription = Some value }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: Types.Detector, value: Types.Integer) =
            { state with DetectorIndex = Some value }

        [<CustomOperation("excludeFrequent")>]
        member _.ExcludeFrequent(state: Types.Detector, value: Types.ExcludeFrequent) =
            { state with ExcludeFrequent = Some value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: Types.Detector, value: Types.Field) =
            { state with FieldName = Some value }

        [<CustomOperation("function'")>]
        member _.Function(state: Types.Detector, value: string) =
            { state with Function = Some value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: Types.Detector, value: Types.Field) =
            { state with OverFieldName = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Types.Detector, value: Types.Field) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("useNull")>]
        member _.UseNull(state: Types.Detector, value: bool) =
            { state with UseNull = Some value }

    let detector = DetectorBuilder()

    type DetectorReadBuilder() =
        member _.Yield(_: unit) : Types.DetectorRead =
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
        member _.Function(state: Types.DetectorRead, value: string) =
            { state with Function = value }

        [<CustomOperation("byFieldName")>]
        member _.ByFieldName(state: Types.DetectorRead, value: Types.Field) =
            { state with ByFieldName = Some value }

        [<CustomOperation("customRules")>]
        member _.CustomRules(state: Types.DetectorRead, value: Types.DetectionRule list) =
            { state with CustomRules = Some value }

        [<CustomOperation("detectorDescription")>]
        member _.DetectorDescription(state: Types.DetectorRead, value: string) =
            { state with DetectorDescription = Some value }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: Types.DetectorRead, value: Types.Integer) =
            { state with DetectorIndex = Some value }

        [<CustomOperation("excludeFrequent")>]
        member _.ExcludeFrequent(state: Types.DetectorRead, value: Types.ExcludeFrequent) =
            { state with ExcludeFrequent = Some value }

        [<CustomOperation("fieldName")>]
        member _.FieldName(state: Types.DetectorRead, value: Types.Field) =
            { state with FieldName = Some value }

        [<CustomOperation("overFieldName")>]
        member _.OverFieldName(state: Types.DetectorRead, value: Types.Field) =
            { state with OverFieldName = Some value }

        [<CustomOperation("partitionFieldName")>]
        member _.PartitionFieldName(state: Types.DetectorRead, value: Types.Field) =
            { state with PartitionFieldName = Some value }

        [<CustomOperation("useNull")>]
        member _.UseNull(state: Types.DetectorRead, value: bool) =
            { state with UseNull = Some value }

    let detectorRead = DetectorReadBuilder()

    type DetectorUpdateBuilder() =
        member _.Yield(_: unit) : Types.DetectorUpdate =
            {
                DetectorIndex = Unchecked.defaultof<_>
                Description = None
                CustomRules = None
            }

        [<CustomOperation("detectorIndex")>]
        member _.DetectorIndex(state: Types.DetectorUpdate, value: Types.Integer) =
            { state with DetectorIndex = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DetectorUpdate, value: string) =
            { state with Description = Some value }

        [<CustomOperation("customRules")>]
        member _.CustomRules(state: Types.DetectorUpdate, value: Types.DetectionRule list) =
            { state with CustomRules = Some value }

    let detectorUpdate = DetectorUpdateBuilder()

    type ExponentialAverageCalculationContextBuilder() =
        member _.Yield(_: unit) : Types.ExponentialAverageCalculationContext =
            {
                IncrementalMetricValueMs = Unchecked.defaultof<_>
                LatestTimestamp = None
                PreviousExponentialAverageMs = None
            }

        [<CustomOperation("incrementalMetricValueMs")>]
        member _.IncrementalMetricValueMs(state: Types.ExponentialAverageCalculationContext, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with IncrementalMetricValueMs = value }

        [<CustomOperation("latestTimestamp")>]
        member _.LatestTimestamp(state: Types.ExponentialAverageCalculationContext, value: Types.EpochTime<Types.UnitMillis>) =
            { state with LatestTimestamp = Some value }

        [<CustomOperation("previousExponentialAverageMs")>]
        member _.PreviousExponentialAverageMs(state: Types.ExponentialAverageCalculationContext, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with PreviousExponentialAverageMs = Some value }

    let exponentialAverageCalculationContext = ExponentialAverageCalculationContextBuilder()

    type FillMaskInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.FillMaskInferenceOptions =
            {
                MaskToken = None
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("maskToken")>]
        member _.MaskToken(state: Types.FillMaskInferenceOptions, value: string) =
            { state with MaskToken = Some value }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.FillMaskInferenceOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.FillMaskInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.FillMaskInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: Types.FillMaskInferenceOptions, value: Types.Vocabulary) =
            { state with Vocabulary = Some value }

    let fillMaskInferenceOptions = FillMaskInferenceOptionsBuilder()

    type FillMaskInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.FillMaskInferenceUpdateOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.FillMaskInferenceUpdateOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.FillMaskInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.FillMaskInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let fillMaskInferenceUpdateOptions = FillMaskInferenceUpdateOptionsBuilder()

    type GeoResultsBuilder() =
        member _.Yield(_: unit) : Types.GeoResults =
            {
                ActualPoint = None
                TypicalPoint = None
            }

        [<CustomOperation("actualPoint")>]
        member _.ActualPoint(state: Types.GeoResults, value: string) =
            { state with ActualPoint = Some value }

        [<CustomOperation("typicalPoint")>]
        member _.TypicalPoint(state: Types.GeoResults, value: string) =
            { state with TypicalPoint = Some value }

    let geoResults = GeoResultsBuilder()

    type HyperparameterBuilder() =
        member _.Yield(_: unit) : Types.Hyperparameter =
            {
                AbsoluteImportance = None
                Name = Unchecked.defaultof<_>
                RelativeImportance = None
                Supplied = Unchecked.defaultof<_>
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("absoluteImportance")>]
        member _.AbsoluteImportance(state: Types.Hyperparameter, value: Types.Double) =
            { state with AbsoluteImportance = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.Hyperparameter, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("relativeImportance")>]
        member _.RelativeImportance(state: Types.Hyperparameter, value: Types.Double) =
            { state with RelativeImportance = Some value }

        [<CustomOperation("supplied")>]
        member _.Supplied(state: Types.Hyperparameter, value: bool) =
            { state with Supplied = value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.Hyperparameter, value: Types.Double) =
            { state with Value = value }

    let hyperparameter = HyperparameterBuilder()

    type HyperparametersBuilder() =
        member _.Yield(_: unit) : Types.Hyperparameters =
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
        member _.Alpha(state: Types.Hyperparameters, value: Types.Double) =
            { state with Alpha = Some value }

        [<CustomOperation("lambda")>]
        member _.Lambda(state: Types.Hyperparameters, value: Types.Double) =
            { state with Lambda = Some value }

        [<CustomOperation("gamma")>]
        member _.Gamma(state: Types.Hyperparameters, value: Types.Double) =
            { state with Gamma = Some value }

        [<CustomOperation("eta")>]
        member _.Eta(state: Types.Hyperparameters, value: Types.Double) =
            { state with Eta = Some value }

        [<CustomOperation("etaGrowthRatePerTree")>]
        member _.EtaGrowthRatePerTree(state: Types.Hyperparameters, value: Types.Double) =
            { state with EtaGrowthRatePerTree = Some value }

        [<CustomOperation("featureBagFraction")>]
        member _.FeatureBagFraction(state: Types.Hyperparameters, value: Types.Double) =
            { state with FeatureBagFraction = Some value }

        [<CustomOperation("downsampleFactor")>]
        member _.DownsampleFactor(state: Types.Hyperparameters, value: Types.Double) =
            { state with DownsampleFactor = Some value }

        [<CustomOperation("maxAttemptsToAddTree")>]
        member _.MaxAttemptsToAddTree(state: Types.Hyperparameters, value: Types.Integer) =
            { state with MaxAttemptsToAddTree = Some value }

        [<CustomOperation("maxOptimizationRoundsPerHyperparameter")>]
        member _.MaxOptimizationRoundsPerHyperparameter(state: Types.Hyperparameters, value: Types.Integer) =
            { state with MaxOptimizationRoundsPerHyperparameter = Some value }

        [<CustomOperation("maxTrees")>]
        member _.MaxTrees(state: Types.Hyperparameters, value: Types.Integer) =
            { state with MaxTrees = Some value }

        [<CustomOperation("numFolds")>]
        member _.NumFolds(state: Types.Hyperparameters, value: Types.Integer) =
            { state with NumFolds = Some value }

        [<CustomOperation("numSplitsPerFeature")>]
        member _.NumSplitsPerFeature(state: Types.Hyperparameters, value: Types.Integer) =
            { state with NumSplitsPerFeature = Some value }

        [<CustomOperation("softTreeDepthLimit")>]
        member _.SoftTreeDepthLimit(state: Types.Hyperparameters, value: Types.Integer) =
            { state with SoftTreeDepthLimit = Some value }

        [<CustomOperation("softTreeDepthTolerance")>]
        member _.SoftTreeDepthTolerance(state: Types.Hyperparameters, value: Types.Double) =
            { state with SoftTreeDepthTolerance = Some value }

    let hyperparameters = HyperparametersBuilder()

    module InferenceConfigCreate =

        let regression (value: Types.RegressionInferenceOptions) =
            Types.InferenceConfigCreateContainer.Regression value

        let classification (value: Types.ClassificationInferenceOptions) =
            Types.InferenceConfigCreateContainer.Classification value

        let textClassification (value: Types.TextClassificationInferenceOptions) =
            Types.InferenceConfigCreateContainer.TextClassification value

        let zeroShotClassification (value: Types.ZeroShotClassificationInferenceOptions) =
            Types.InferenceConfigCreateContainer.ZeroShotClassification value

        let fillMask (value: Types.FillMaskInferenceOptions) =
            Types.InferenceConfigCreateContainer.FillMask value

        let learningToRank (value: Types.LearningToRankConfig) =
            Types.InferenceConfigCreateContainer.LearningToRank value

        let ner (value: Types.NerInferenceOptions) =
            Types.InferenceConfigCreateContainer.Ner value

        let passThrough (value: Types.PassThroughInferenceOptions) =
            Types.InferenceConfigCreateContainer.PassThrough value

        let textEmbedding (value: Types.TextEmbeddingInferenceOptions) =
            Types.InferenceConfigCreateContainer.TextEmbedding value

        let textExpansion (value: Types.TextExpansionInferenceOptions) =
            Types.InferenceConfigCreateContainer.TextExpansion value

        let questionAnswering (value: Types.QuestionAnsweringInferenceOptions) =
            Types.InferenceConfigCreateContainer.QuestionAnswering value

    module InferenceConfigUpdate =

        let regression (value: Types.RegressionInferenceOptions) =
            Types.InferenceConfigUpdateContainer.Regression value

        let classification (value: Types.ClassificationInferenceOptions) =
            Types.InferenceConfigUpdateContainer.Classification value

        let textClassification (value: Types.TextClassificationInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.TextClassification value

        let zeroShotClassification (value: Types.ZeroShotClassificationInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.ZeroShotClassification value

        let fillMask (value: Types.FillMaskInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.FillMask value

        let ner (value: Types.NerInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.Ner value

        let passThrough (value: Types.PassThroughInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.PassThrough value

        let textEmbedding (value: Types.TextEmbeddingInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.TextEmbedding value

        let textExpansion (value: Types.TextExpansionInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.TextExpansion value

        let questionAnswering (value: Types.QuestionAnsweringInferenceUpdateOptions) =
            Types.InferenceConfigUpdateContainer.QuestionAnswering value

    type InferenceResponseResultBuilder() =
        member _.Yield(_: unit) : Types.InferenceResponseResult =
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
        member _.Entities(state: Types.InferenceResponseResult, value: Types.TrainedModelEntities list) =
            { state with Entities = Some value }

        [<CustomOperation("isTruncated")>]
        member _.IsTruncated(state: Types.InferenceResponseResult, value: bool) =
            { state with IsTruncated = Some value }

        [<CustomOperation("predictedValue")>]
        member _.PredictedValue(state: Types.InferenceResponseResult, value: System.Text.Json.JsonElement) =
            { state with PredictedValue = Some value }

        [<CustomOperation("predictedValueSequence")>]
        member _.PredictedValueSequence(state: Types.InferenceResponseResult, value: string) =
            { state with PredictedValueSequence = Some value }

        [<CustomOperation("predictionProbability")>]
        member _.PredictionProbability(state: Types.InferenceResponseResult, value: Types.Double) =
            { state with PredictionProbability = Some value }

        [<CustomOperation("predictionScore")>]
        member _.PredictionScore(state: Types.InferenceResponseResult, value: Types.Double) =
            { state with PredictionScore = Some value }

        [<CustomOperation("topClasses")>]
        member _.TopClasses(state: Types.InferenceResponseResult, value: Types.TopClassEntry list) =
            { state with TopClasses = Some value }

        [<CustomOperation("warning")>]
        member _.Warning(state: Types.InferenceResponseResult, value: string) =
            { state with Warning = Some value }

        [<CustomOperation("featureImportance")>]
        member _.FeatureImportance(state: Types.InferenceResponseResult, value: Types.TrainedModelInferenceFeatureImportance list) =
            { state with FeatureImportance = Some value }

    let inferenceResponseResult = InferenceResponseResultBuilder()

    type JobBuilder() =
        member _.Yield(_: unit) : Types.Job =
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
        member _.AllowLazyOpen(state: Types.Job, value: bool) =
            { state with AllowLazyOpen = value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: Types.Job, value: Types.AnalysisConfig) =
            { state with AnalysisConfig = value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: Types.Job, value: Types.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: Types.Job, value: Types.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("blocked")>]
        member _.Blocked(state: Types.Job, value: Types.JobBlocked) =
            { state with Blocked = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: Types.Job, value: Types.DateTime) =
            { state with CreateTime = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: Types.Job, value: Types.CustomSettings) =
            { state with CustomSettings = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: Types.Job, value: Types.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: Types.Job, value: Types.DataDescription) =
            { state with DataDescription = value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: Types.Job, value: Types.MlTypesDatafeed) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("deleting")>]
        member _.Deleting(state: Types.Job, value: bool) =
            { state with Deleting = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.Job, value: string) =
            { state with Description = Some value }

        [<CustomOperation("finishedTime")>]
        member _.FinishedTime(state: Types.Job, value: Types.DateTime) =
            { state with FinishedTime = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: Types.Job, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.Job, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: Types.Job, value: string) =
            { state with JobType = Some value }

        [<CustomOperation("jobVersion")>]
        member _.JobVersion(state: Types.Job, value: Types.VersionString) =
            { state with JobVersion = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: Types.Job, value: Types.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelSnapshotId")>]
        member _.ModelSnapshotId(state: Types.Job, value: Types.Id) =
            { state with ModelSnapshotId = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: Types.Job, value: Types.Long) =
            { state with ModelSnapshotRetentionDays = value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: Types.Job, value: Types.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: Types.Job, value: Types.IndexName) =
            { state with ResultsIndexName = value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: Types.Job, value: Types.Long) =
            { state with ResultsRetentionDays = Some value }

    let job = JobBuilder()

    type JobConfigBuilder() =
        member _.Yield(_: unit) : Types.JobConfig =
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
        member _.AllowLazyOpen(state: Types.JobConfig, value: bool) =
            { state with AllowLazyOpen = Some value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: Types.JobConfig, value: Types.AnalysisConfig) =
            { state with AnalysisConfig = value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: Types.JobConfig, value: Types.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: Types.JobConfig, value: Types.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: Types.JobConfig, value: Types.CustomSettings) =
            { state with CustomSettings = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: Types.JobConfig, value: Types.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: Types.JobConfig, value: Types.DataDescription) =
            { state with DataDescription = value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: Types.JobConfig, value: Types.DatafeedConfig) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.JobConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: Types.JobConfig, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.JobConfig, value: Types.Id) =
            { state with JobId = Some value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: Types.JobConfig, value: string) =
            { state with JobType = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: Types.JobConfig, value: Types.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: Types.JobConfig, value: Types.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: Types.JobConfig, value: Types.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: Types.JobConfig, value: Types.IndexName) =
            { state with ResultsIndexName = Some value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: Types.JobConfig, value: Types.Long) =
            { state with ResultsRetentionDays = Some value }

    let jobConfig = JobConfigBuilder()

    type JobForecastStatisticsBuilder() =
        member _.Yield(_: unit) : Types.JobForecastStatistics =
            {
                MemoryBytes = None
                ProcessingTimeMs = None
                Records = None
                Status = None
                Total = Unchecked.defaultof<_>
                ForecastedJobs = Unchecked.defaultof<_>
            }

        [<CustomOperation("memoryBytes")>]
        member _.MemoryBytes(state: Types.JobForecastStatistics, value: Types.JobStatistics) =
            { state with MemoryBytes = Some value }

        [<CustomOperation("processingTimeMs")>]
        member _.ProcessingTimeMs(state: Types.JobForecastStatistics, value: Types.JobStatistics) =
            { state with ProcessingTimeMs = Some value }

        [<CustomOperation("records")>]
        member _.Records(state: Types.JobForecastStatistics, value: Types.JobStatistics) =
            { state with Records = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.JobForecastStatistics, value: Map<string, Types.Long>) =
            { state with Status = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.JobForecastStatistics, value: Types.Long) =
            { state with Total = value }

        [<CustomOperation("forecastedJobs")>]
        member _.ForecastedJobs(state: Types.JobForecastStatistics, value: Types.Integer) =
            { state with ForecastedJobs = value }

    let jobForecastStatistics = JobForecastStatisticsBuilder()

    type JobStatsBuilder() =
        member _.Yield(_: unit) : Types.JobStats =
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
        member _.AssignmentExplanation(state: Types.JobStats, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("dataCounts")>]
        member _.DataCounts(state: Types.JobStats, value: Types.DataCounts) =
            { state with DataCounts = value }

        [<CustomOperation("forecastsStats")>]
        member _.ForecastsStats(state: Types.JobStats, value: Types.JobForecastStatistics) =
            { state with ForecastsStats = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.JobStats, value: string) =
            { state with JobId = value }

        [<CustomOperation("modelSizeStats")>]
        member _.ModelSizeStats(state: Types.JobStats, value: Types.ModelSizeStats) =
            { state with ModelSizeStats = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.JobStats, value: Types.DiscoveryNodeCompact) =
            { state with Node = Some value }

        [<CustomOperation("openTime")>]
        member _.OpenTime(state: Types.JobStats, value: Types.DateTime) =
            { state with OpenTime = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.JobStats, value: Types.JobState) =
            { state with State = value }

        [<CustomOperation("timingStats")>]
        member _.TimingStats(state: Types.JobStats, value: Types.JobTimingStats) =
            { state with TimingStats = value }

        [<CustomOperation("deleting")>]
        member _.Deleting(state: Types.JobStats, value: bool) =
            { state with Deleting = Some value }

    let jobStats = JobStatsBuilder()

    type JobTimingStatsBuilder() =
        member _.Yield(_: unit) : Types.JobTimingStats =
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
        member _.AverageBucketProcessingTimeMs(state: Types.JobTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with AverageBucketProcessingTimeMs = Some value }

        [<CustomOperation("bucketCount")>]
        member _.BucketCount(state: Types.JobTimingStats, value: Types.Long) =
            { state with BucketCount = value }

        [<CustomOperation("exponentialAverageBucketProcessingTimeMs")>]
        member _.ExponentialAverageBucketProcessingTimeMs(state: Types.JobTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with ExponentialAverageBucketProcessingTimeMs = Some value }

        [<CustomOperation("exponentialAverageBucketProcessingTimePerHourMs")>]
        member _.ExponentialAverageBucketProcessingTimePerHourMs(state: Types.JobTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with ExponentialAverageBucketProcessingTimePerHourMs = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.JobTimingStats, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("totalBucketProcessingTimeMs")>]
        member _.TotalBucketProcessingTimeMs(state: Types.JobTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with TotalBucketProcessingTimeMs = value }

        [<CustomOperation("maximumBucketProcessingTimeMs")>]
        member _.MaximumBucketProcessingTimeMs(state: Types.JobTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with MaximumBucketProcessingTimeMs = Some value }

        [<CustomOperation("minimumBucketProcessingTimeMs")>]
        member _.MinimumBucketProcessingTimeMs(state: Types.JobTimingStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with MinimumBucketProcessingTimeMs = Some value }

    let jobTimingStats = JobTimingStatsBuilder()

    type LearningToRankConfigBuilder() =
        member _.Yield(_: unit) : Types.LearningToRankConfig =
            {
                DefaultParams = None
                FeatureExtractors = None
                NumTopFeatureImportanceValues = Unchecked.defaultof<_>
            }

        [<CustomOperation("defaultParams")>]
        member _.DefaultParams(state: Types.LearningToRankConfig, value: Map<string, System.Text.Json.JsonElement>) =
            { state with DefaultParams = Some value }

        [<CustomOperation("featureExtractors")>]
        member _.FeatureExtractors(state: Types.LearningToRankConfig, value: Map<string, Types.FeatureExtractor> list) =
            { state with FeatureExtractors = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: Types.LearningToRankConfig, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = value }

    let learningToRankConfig = LearningToRankConfigBuilder()

    type ModelPackageConfigBuilder() =
        member _.Yield(_: unit) : Types.ModelPackageConfig =
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
        member _.CreateTime(state: Types.ModelPackageConfig, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreateTime = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.ModelPackageConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: Types.ModelPackageConfig, value: Map<string, System.Text.Json.JsonElement>) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.ModelPackageConfig, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("minimumVersion")>]
        member _.MinimumVersion(state: Types.ModelPackageConfig, value: string) =
            { state with MinimumVersion = Some value }

        [<CustomOperation("modelRepository")>]
        member _.ModelRepository(state: Types.ModelPackageConfig, value: string) =
            { state with ModelRepository = Some value }

        [<CustomOperation("modelType")>]
        member _.ModelType(state: Types.ModelPackageConfig, value: string) =
            { state with ModelType = Some value }

        [<CustomOperation("packagedModelId")>]
        member _.PackagedModelId(state: Types.ModelPackageConfig, value: Types.Id) =
            { state with PackagedModelId = value }

        [<CustomOperation("platformArchitecture")>]
        member _.PlatformArchitecture(state: Types.ModelPackageConfig, value: string) =
            { state with PlatformArchitecture = Some value }

        [<CustomOperation("prefixStrings")>]
        member _.PrefixStrings(state: Types.ModelPackageConfig, value: Types.TrainedModelPrefixStrings) =
            { state with PrefixStrings = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.ModelPackageConfig, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("sha256")>]
        member _.Sha256(state: Types.ModelPackageConfig, value: string) =
            { state with Sha256 = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: Types.ModelPackageConfig, value: string list) =
            { state with Tags = Some value }

        [<CustomOperation("vocabularyFile")>]
        member _.VocabularyFile(state: Types.ModelPackageConfig, value: string) =
            { state with VocabularyFile = Some value }

    let modelPackageConfig = ModelPackageConfigBuilder()

    type ModelPlotConfigBuilder() =
        member _.Yield(_: unit) : Types.ModelPlotConfig =
            {
                AnnotationsEnabled = None
                Enabled = None
                Terms = None
            }

        [<CustomOperation("annotationsEnabled")>]
        member _.AnnotationsEnabled(state: Types.ModelPlotConfig, value: bool) =
            { state with AnnotationsEnabled = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.ModelPlotConfig, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Types.ModelPlotConfig, value: Types.Field) =
            { state with Terms = Some value }

    let modelPlotConfig = ModelPlotConfigBuilder()

    type ModelSizeStatsBuilder() =
        member _.Yield(_: unit) : Types.ModelSizeStats =
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
        member _.BucketAllocationFailuresCount(state: Types.ModelSizeStats, value: Types.Long) =
            { state with BucketAllocationFailuresCount = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.ModelSizeStats, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("logTime")>]
        member _.LogTime(state: Types.ModelSizeStats, value: Types.DateTime) =
            { state with LogTime = value }

        [<CustomOperation("memoryStatus")>]
        member _.MemoryStatus(state: Types.ModelSizeStats, value: Types.MemoryStatus) =
            { state with MemoryStatus = value }

        [<CustomOperation("modelBytes")>]
        member _.ModelBytes(state: Types.ModelSizeStats, value: Types.ByteSize) =
            { state with ModelBytes = value }

        [<CustomOperation("modelBytesExceeded")>]
        member _.ModelBytesExceeded(state: Types.ModelSizeStats, value: Types.ByteSize) =
            { state with ModelBytesExceeded = Some value }

        [<CustomOperation("modelBytesMemoryLimit")>]
        member _.ModelBytesMemoryLimit(state: Types.ModelSizeStats, value: Types.ByteSize) =
            { state with ModelBytesMemoryLimit = Some value }

        [<CustomOperation("outputMemoryAllocatorBytes")>]
        member _.OutputMemoryAllocatorBytes(state: Types.ModelSizeStats, value: Types.ByteSize) =
            { state with OutputMemoryAllocatorBytes = Some value }

        [<CustomOperation("peakModelBytes")>]
        member _.PeakModelBytes(state: Types.ModelSizeStats, value: Types.ByteSize) =
            { state with PeakModelBytes = Some value }

        [<CustomOperation("assignmentMemoryBasis")>]
        member _.AssignmentMemoryBasis(state: Types.ModelSizeStats, value: string) =
            { state with AssignmentMemoryBasis = Some value }

        [<CustomOperation("resultType")>]
        member _.ResultType(state: Types.ModelSizeStats, value: string) =
            { state with ResultType = value }

        [<CustomOperation("totalByFieldCount")>]
        member _.TotalByFieldCount(state: Types.ModelSizeStats, value: Types.Long) =
            { state with TotalByFieldCount = value }

        [<CustomOperation("totalOverFieldCount")>]
        member _.TotalOverFieldCount(state: Types.ModelSizeStats, value: Types.Long) =
            { state with TotalOverFieldCount = value }

        [<CustomOperation("totalPartitionFieldCount")>]
        member _.TotalPartitionFieldCount(state: Types.ModelSizeStats, value: Types.Long) =
            { state with TotalPartitionFieldCount = value }

        [<CustomOperation("categorizationStatus")>]
        member _.CategorizationStatus(state: Types.ModelSizeStats, value: Types.CategorizationStatus) =
            { state with CategorizationStatus = value }

        [<CustomOperation("categorizedDocCount")>]
        member _.CategorizedDocCount(state: Types.ModelSizeStats, value: Types.Integer) =
            { state with CategorizedDocCount = value }

        [<CustomOperation("deadCategoryCount")>]
        member _.DeadCategoryCount(state: Types.ModelSizeStats, value: Types.Integer) =
            { state with DeadCategoryCount = value }

        [<CustomOperation("failedCategoryCount")>]
        member _.FailedCategoryCount(state: Types.ModelSizeStats, value: Types.Integer) =
            { state with FailedCategoryCount = value }

        [<CustomOperation("frequentCategoryCount")>]
        member _.FrequentCategoryCount(state: Types.ModelSizeStats, value: Types.Integer) =
            { state with FrequentCategoryCount = value }

        [<CustomOperation("rareCategoryCount")>]
        member _.RareCategoryCount(state: Types.ModelSizeStats, value: Types.Integer) =
            { state with RareCategoryCount = value }

        [<CustomOperation("totalCategoryCount")>]
        member _.TotalCategoryCount(state: Types.ModelSizeStats, value: Types.Integer) =
            { state with TotalCategoryCount = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.ModelSizeStats, value: Types.Long) =
            { state with Timestamp = Some value }

    let modelSizeStats = ModelSizeStatsBuilder()

    type ModelSnapshotBuilder() =
        member _.Yield(_: unit) : Types.ModelSnapshot =
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
        member _.Description(state: Types.ModelSnapshot, value: string) =
            { state with Description = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: Types.ModelSnapshot, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("latestRecordTimeStamp")>]
        member _.LatestRecordTimeStamp(state: Types.ModelSnapshot, value: Types.Integer) =
            { state with LatestRecordTimeStamp = Some value }

        [<CustomOperation("latestResultTimeStamp")>]
        member _.LatestResultTimeStamp(state: Types.ModelSnapshot, value: Types.Integer) =
            { state with LatestResultTimeStamp = Some value }

        [<CustomOperation("minVersion")>]
        member _.MinVersion(state: Types.ModelSnapshot, value: Types.VersionString) =
            { state with MinVersion = value }

        [<CustomOperation("modelSizeStats")>]
        member _.ModelSizeStats(state: Types.ModelSnapshot, value: Types.ModelSizeStats) =
            { state with ModelSizeStats = Some value }

        [<CustomOperation("retain")>]
        member _.Retain(state: Types.ModelSnapshot, value: bool) =
            { state with Retain = value }

        [<CustomOperation("snapshotDocCount")>]
        member _.SnapshotDocCount(state: Types.ModelSnapshot, value: Types.Long) =
            { state with SnapshotDocCount = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: Types.ModelSnapshot, value: Types.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.ModelSnapshot, value: Types.Long) =
            { state with Timestamp = value }

    let modelSnapshot = ModelSnapshotBuilder()

    type NerInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.NerInferenceOptions =
            {
                Tokenization = None
                ResultsField = None
                ClassificationLabels = None
                Vocabulary = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.NerInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.NerInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Types.NerInferenceOptions, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: Types.NerInferenceOptions, value: Types.Vocabulary) =
            { state with Vocabulary = Some value }

    let nerInferenceOptions = NerInferenceOptionsBuilder()

    type NerInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.NerInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.NerInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.NerInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let nerInferenceUpdateOptions = NerInferenceUpdateOptionsBuilder()

    type NlpTokenizationUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.NlpTokenizationUpdateOptions =
            {
                Truncate = None
                Span = None
            }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: Types.NlpTokenizationUpdateOptions, value: Types.TokenizationTruncate) =
            { state with Truncate = Some value }

        [<CustomOperation("span")>]
        member _.Span(state: Types.NlpTokenizationUpdateOptions, value: Types.Integer) =
            { state with Span = Some value }

    let nlpTokenizationUpdateOptions = NlpTokenizationUpdateOptionsBuilder()

    type OutlierDetectionParametersBuilder() =
        member _.Yield(_: unit) : Types.OutlierDetectionParameters =
            {
                ComputeFeatureInfluence = None
                FeatureInfluenceThreshold = None
                Method = None
                NNeighbors = None
                OutlierFraction = None
                StandardizationEnabled = None
            }

        [<CustomOperation("computeFeatureInfluence")>]
        member _.ComputeFeatureInfluence(state: Types.OutlierDetectionParameters, value: bool) =
            { state with ComputeFeatureInfluence = Some value }

        [<CustomOperation("featureInfluenceThreshold")>]
        member _.FeatureInfluenceThreshold(state: Types.OutlierDetectionParameters, value: Types.Double) =
            { state with FeatureInfluenceThreshold = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: Types.OutlierDetectionParameters, value: string) =
            { state with Method = Some value }

        [<CustomOperation("nNeighbors")>]
        member _.NNeighbors(state: Types.OutlierDetectionParameters, value: Types.Integer) =
            { state with NNeighbors = Some value }

        [<CustomOperation("outlierFraction")>]
        member _.OutlierFraction(state: Types.OutlierDetectionParameters, value: Types.Double) =
            { state with OutlierFraction = Some value }

        [<CustomOperation("standardizationEnabled")>]
        member _.StandardizationEnabled(state: Types.OutlierDetectionParameters, value: bool) =
            { state with StandardizationEnabled = Some value }

    let outlierDetectionParameters = OutlierDetectionParametersBuilder()

    type PageBuilder() =
        member _.Yield(_: unit) : Types.Page =
            {
                From = None
                Size = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Types.Page, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.Page, value: Types.Integer) =
            { state with Size = Some value }

    let page = PageBuilder()

    type PassThroughInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.PassThroughInferenceOptions =
            {
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.PassThroughInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.PassThroughInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: Types.PassThroughInferenceOptions, value: Types.Vocabulary) =
            { state with Vocabulary = Some value }

    let passThroughInferenceOptions = PassThroughInferenceOptionsBuilder()

    type PassThroughInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.PassThroughInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.PassThroughInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.PassThroughInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let passThroughInferenceUpdateOptions = PassThroughInferenceUpdateOptionsBuilder()

    type PerPartitionCategorizationBuilder() =
        member _.Yield(_: unit) : Types.PerPartitionCategorization =
            {
                Enabled = None
                StopOnWarn = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.PerPartitionCategorization, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("stopOnWarn")>]
        member _.StopOnWarn(state: Types.PerPartitionCategorization, value: bool) =
            { state with StopOnWarn = Some value }

    let perPartitionCategorization = PerPartitionCategorizationBuilder()

    type QuestionAnsweringInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.QuestionAnsweringInferenceOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                MaxAnswerLength = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.QuestionAnsweringInferenceOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.QuestionAnsweringInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.QuestionAnsweringInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("maxAnswerLength")>]
        member _.MaxAnswerLength(state: Types.QuestionAnsweringInferenceOptions, value: Types.Integer) =
            { state with MaxAnswerLength = Some value }

    let questionAnsweringInferenceOptions = QuestionAnsweringInferenceOptionsBuilder()

    type QuestionAnsweringInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.QuestionAnsweringInferenceUpdateOptions =
            {
                Question = Unchecked.defaultof<_>
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                MaxAnswerLength = None
            }

        [<CustomOperation("question")>]
        member _.Question(state: Types.QuestionAnsweringInferenceUpdateOptions, value: string) =
            { state with Question = value }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.QuestionAnsweringInferenceUpdateOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.QuestionAnsweringInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.QuestionAnsweringInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("maxAnswerLength")>]
        member _.MaxAnswerLength(state: Types.QuestionAnsweringInferenceUpdateOptions, value: Types.Integer) =
            { state with MaxAnswerLength = Some value }

    let questionAnsweringInferenceUpdateOptions = QuestionAnsweringInferenceUpdateOptionsBuilder()

    type RegressionInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.RegressionInferenceOptions =
            {
                ResultsField = None
                NumTopFeatureImportanceValues = None
            }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.RegressionInferenceOptions, value: Types.Field) =
            { state with ResultsField = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: Types.RegressionInferenceOptions, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

    let regressionInferenceOptions = RegressionInferenceOptionsBuilder()

    type RunningStateSearchIntervalBuilder() =
        member _.Yield(_: unit) : Types.RunningStateSearchInterval =
            {
                End = None
                EndMs = Unchecked.defaultof<_>
                Start = None
                StartMs = Unchecked.defaultof<_>
            }

        [<CustomOperation("end'")>]
        member _.End(state: Types.RunningStateSearchInterval, value: Types.Duration) =
            { state with End = Some value }

        [<CustomOperation("endMs")>]
        member _.EndMs(state: Types.RunningStateSearchInterval, value: Types.DurationValue<Types.UnitMillis>) =
            { state with EndMs = value }

        [<CustomOperation("start")>]
        member _.Start(state: Types.RunningStateSearchInterval, value: Types.Duration) =
            { state with Start = Some value }

        [<CustomOperation("startMs")>]
        member _.StartMs(state: Types.RunningStateSearchInterval, value: Types.DurationValue<Types.UnitMillis>) =
            { state with StartMs = value }

    let runningStateSearchInterval = RunningStateSearchIntervalBuilder()

    type TextClassificationInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.TextClassificationInferenceOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                ClassificationLabels = None
                Vocabulary = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.TextClassificationInferenceOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.TextClassificationInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.TextClassificationInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Types.TextClassificationInferenceOptions, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: Types.TextClassificationInferenceOptions, value: Types.Vocabulary) =
            { state with Vocabulary = Some value }

    let textClassificationInferenceOptions = TextClassificationInferenceOptionsBuilder()

    type TextClassificationInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.TextClassificationInferenceUpdateOptions =
            {
                NumTopClasses = None
                Tokenization = None
                ResultsField = None
                ClassificationLabels = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.TextClassificationInferenceUpdateOptions, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.TextClassificationInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.TextClassificationInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Types.TextClassificationInferenceUpdateOptions, value: string list) =
            { state with ClassificationLabels = Some value }

    let textClassificationInferenceUpdateOptions = TextClassificationInferenceUpdateOptionsBuilder()

    type TextEmbeddingInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.TextEmbeddingInferenceOptions =
            {
                EmbeddingSize = None
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("embeddingSize")>]
        member _.EmbeddingSize(state: Types.TextEmbeddingInferenceOptions, value: Types.Integer) =
            { state with EmbeddingSize = Some value }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.TextEmbeddingInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.TextEmbeddingInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: Types.TextEmbeddingInferenceOptions, value: Types.Vocabulary) =
            { state with Vocabulary = Some value }

    let textEmbeddingInferenceOptions = TextEmbeddingInferenceOptionsBuilder()

    type TextEmbeddingInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.TextEmbeddingInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.TextEmbeddingInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.TextEmbeddingInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let textEmbeddingInferenceUpdateOptions = TextEmbeddingInferenceUpdateOptionsBuilder()

    type TextExpansionInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.TextExpansionInferenceOptions =
            {
                Tokenization = None
                ResultsField = None
                Vocabulary = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.TextExpansionInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.TextExpansionInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: Types.TextExpansionInferenceOptions, value: Types.Vocabulary) =
            { state with Vocabulary = Some value }

    let textExpansionInferenceOptions = TextExpansionInferenceOptionsBuilder()

    type TextExpansionInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.TextExpansionInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.TextExpansionInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.TextExpansionInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

    let textExpansionInferenceUpdateOptions = TextExpansionInferenceUpdateOptionsBuilder()

    module TokenizationConfig =

        let bert (value: Types.NlpBertTokenizationConfig) =
            Types.TokenizationConfigContainer.Bert value

        let bertJa (value: Types.NlpBertTokenizationConfig) =
            Types.TokenizationConfigContainer.BertJa value

        let mpnet (value: Types.NlpBertTokenizationConfig) =
            Types.TokenizationConfigContainer.Mpnet value

        let roberta (value: Types.NlpRobertaTokenizationConfig) =
            Types.TokenizationConfigContainer.Roberta value

        let xlmRoberta (value: Types.XlmRobertaTokenizationConfig) =
            Types.TokenizationConfigContainer.XlmRoberta value

    type TrainedModelAssignmentBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelAssignment =
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
        member _.AdaptiveAllocations(state: Types.TrainedModelAssignment, value: Types.AdaptiveAllocationsSettings option) =
            { state with AdaptiveAllocations = Some value }

        [<CustomOperation("assignmentState")>]
        member _.AssignmentState(state: Types.TrainedModelAssignment, value: Types.DeploymentAssignmentState) =
            { state with AssignmentState = value }

        [<CustomOperation("maxAssignedAllocations")>]
        member _.MaxAssignedAllocations(state: Types.TrainedModelAssignment, value: Types.Integer) =
            { state with MaxAssignedAllocations = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.TrainedModelAssignment, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("routingTable")>]
        member _.RoutingTable(state: Types.TrainedModelAssignment, value: Map<string, Types.TrainedModelAssignmentRoutingTable>) =
            { state with RoutingTable = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.TrainedModelAssignment, value: Types.DateTime) =
            { state with StartTime = value }

        [<CustomOperation("taskParameters")>]
        member _.TaskParameters(state: Types.TrainedModelAssignment, value: Types.TrainedModelAssignmentTaskParameters) =
            { state with TaskParameters = value }

    let trainedModelAssignment = TrainedModelAssignmentBuilder()

    type TrainedModelConfigBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelConfig =
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
        member _.ModelId(state: Types.TrainedModelConfig, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("modelType")>]
        member _.ModelType(state: Types.TrainedModelConfig, value: Types.TrainedModelType) =
            { state with ModelType = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: Types.TrainedModelConfig, value: string list) =
            { state with Tags = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.TrainedModelConfig, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("compressedDefinition")>]
        member _.CompressedDefinition(state: Types.TrainedModelConfig, value: string) =
            { state with CompressedDefinition = Some value }

        [<CustomOperation("createdBy")>]
        member _.CreatedBy(state: Types.TrainedModelConfig, value: string) =
            { state with CreatedBy = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: Types.TrainedModelConfig, value: Types.DateTime) =
            { state with CreateTime = Some value }

        [<CustomOperation("defaultFieldMap")>]
        member _.DefaultFieldMap(state: Types.TrainedModelConfig, value: Map<string, string>) =
            { state with DefaultFieldMap = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TrainedModelConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("estimatedHeapMemoryUsageBytes")>]
        member _.EstimatedHeapMemoryUsageBytes(state: Types.TrainedModelConfig, value: Types.Integer) =
            { state with EstimatedHeapMemoryUsageBytes = Some value }

        [<CustomOperation("estimatedOperations")>]
        member _.EstimatedOperations(state: Types.TrainedModelConfig, value: Types.Integer) =
            { state with EstimatedOperations = Some value }

        [<CustomOperation("fullyDefined")>]
        member _.FullyDefined(state: Types.TrainedModelConfig, value: bool) =
            { state with FullyDefined = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: Types.TrainedModelConfig, value: Types.InferenceConfigCreateContainer) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: Types.TrainedModelConfig, value: Types.TrainedModelConfigInput) =
            { state with Input = value }

        [<CustomOperation("licenseLevel")>]
        member _.LicenseLevel(state: Types.TrainedModelConfig, value: string) =
            { state with LicenseLevel = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.TrainedModelConfig, value: Types.TrainedModelConfigMetadata) =
            { state with Metadata = Some value }

        [<CustomOperation("modelSizeBytes")>]
        member _.ModelSizeBytes(state: Types.TrainedModelConfig, value: Types.ByteSize) =
            { state with ModelSizeBytes = Some value }

        [<CustomOperation("modelPackage")>]
        member _.ModelPackage(state: Types.TrainedModelConfig, value: Types.ModelPackageConfig) =
            { state with ModelPackage = Some value }

        [<CustomOperation("location")>]
        member _.Location(state: Types.TrainedModelConfig, value: Types.TrainedModelLocation) =
            { state with Location = Some value }

        [<CustomOperation("platformArchitecture")>]
        member _.PlatformArchitecture(state: Types.TrainedModelConfig, value: string) =
            { state with PlatformArchitecture = Some value }

        [<CustomOperation("prefixStrings")>]
        member _.PrefixStrings(state: Types.TrainedModelConfig, value: Types.TrainedModelPrefixStrings) =
            { state with PrefixStrings = Some value }

    let trainedModelConfig = TrainedModelConfigBuilder()

    type TrainedModelConfigMetadataBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelConfigMetadata =
            {
                ModelAliases = None
                FeatureImportanceBaseline = None
                Hyperparameters = None
                TotalFeatureImportance = None
            }

        [<CustomOperation("modelAliases")>]
        member _.ModelAliases(state: Types.TrainedModelConfigMetadata, value: string list) =
            { state with ModelAliases = Some value }

        [<CustomOperation("featureImportanceBaseline")>]
        member _.FeatureImportanceBaseline(state: Types.TrainedModelConfigMetadata, value: Map<string, string>) =
            { state with FeatureImportanceBaseline = Some value }

        [<CustomOperation("hyperparameters")>]
        member _.Hyperparameters(state: Types.TrainedModelConfigMetadata, value: Types.Hyperparameter list) =
            { state with Hyperparameters = Some value }

        [<CustomOperation("totalFeatureImportance")>]
        member _.TotalFeatureImportance(state: Types.TrainedModelConfigMetadata, value: Types.TotalFeatureImportance list) =
            { state with TotalFeatureImportance = Some value }

    let trainedModelConfigMetadata = TrainedModelConfigMetadataBuilder()

    type TrainedModelDeploymentNodesStatsBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelDeploymentNodesStats =
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
        member _.AverageInferenceTimeMs(state: Types.TrainedModelDeploymentNodesStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with AverageInferenceTimeMs = Some value }

        [<CustomOperation("averageInferenceTimeMsLastMinute")>]
        member _.AverageInferenceTimeMsLastMinute(state: Types.TrainedModelDeploymentNodesStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with AverageInferenceTimeMsLastMinute = Some value }

        [<CustomOperation("averageInferenceTimeMsExcludingCacheHits")>]
        member _.AverageInferenceTimeMsExcludingCacheHits(state: Types.TrainedModelDeploymentNodesStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with AverageInferenceTimeMsExcludingCacheHits = Some value }

        [<CustomOperation("errorCount")>]
        member _.ErrorCount(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with ErrorCount = Some value }

        [<CustomOperation("inferenceCount")>]
        member _.InferenceCount(state: Types.TrainedModelDeploymentNodesStats, value: Types.Long) =
            { state with InferenceCount = Some value }

        [<CustomOperation("inferenceCacheHitCount")>]
        member _.InferenceCacheHitCount(state: Types.TrainedModelDeploymentNodesStats, value: Types.Long) =
            { state with InferenceCacheHitCount = Some value }

        [<CustomOperation("inferenceCacheHitCountLastMinute")>]
        member _.InferenceCacheHitCountLastMinute(state: Types.TrainedModelDeploymentNodesStats, value: Types.Long) =
            { state with InferenceCacheHitCountLastMinute = Some value }

        [<CustomOperation("lastAccess")>]
        member _.LastAccess(state: Types.TrainedModelDeploymentNodesStats, value: Types.EpochTime<Types.UnitMillis>) =
            { state with LastAccess = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.TrainedModelDeploymentNodesStats, value: Types.DiscoveryNode) =
            { state with Node = Some value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("numberOfPendingRequests")>]
        member _.NumberOfPendingRequests(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with NumberOfPendingRequests = Some value }

        [<CustomOperation("peakThroughputPerMinute")>]
        member _.PeakThroughputPerMinute(state: Types.TrainedModelDeploymentNodesStats, value: Types.Long) =
            { state with PeakThroughputPerMinute = value }

        [<CustomOperation("rejectedExecutionCount")>]
        member _.RejectedExecutionCount(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with RejectedExecutionCount = Some value }

        [<CustomOperation("routingState")>]
        member _.RoutingState(state: Types.TrainedModelDeploymentNodesStats, value: Types.TrainedModelAssignmentRoutingStateAndReason) =
            { state with RoutingState = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.TrainedModelDeploymentNodesStats, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTime = Some value }

        [<CustomOperation("threadsPerAllocation")>]
        member _.ThreadsPerAllocation(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with ThreadsPerAllocation = Some value }

        [<CustomOperation("throughputLastMinute")>]
        member _.ThroughputLastMinute(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with ThroughputLastMinute = value }

        [<CustomOperation("timeoutCount")>]
        member _.TimeoutCount(state: Types.TrainedModelDeploymentNodesStats, value: Types.Integer) =
            { state with TimeoutCount = Some value }

    let trainedModelDeploymentNodesStats = TrainedModelDeploymentNodesStatsBuilder()

    type TrainedModelDeploymentStatsBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelDeploymentStats =
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
        member _.AdaptiveAllocations(state: Types.TrainedModelDeploymentStats, value: Types.AdaptiveAllocationsSettings) =
            { state with AdaptiveAllocations = Some value }

        [<CustomOperation("allocationStatus")>]
        member _.AllocationStatus(state: Types.TrainedModelDeploymentStats, value: Types.TrainedModelDeploymentAllocationStatus) =
            { state with AllocationStatus = Some value }

        [<CustomOperation("cacheSize")>]
        member _.CacheSize(state: Types.TrainedModelDeploymentStats, value: Types.ByteSize) =
            { state with CacheSize = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: Types.TrainedModelDeploymentStats, value: Types.Id) =
            { state with DeploymentId = value }

        [<CustomOperation("errorCount")>]
        member _.ErrorCount(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with ErrorCount = Some value }

        [<CustomOperation("inferenceCount")>]
        member _.InferenceCount(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with InferenceCount = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.TrainedModelDeploymentStats, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: Types.TrainedModelDeploymentStats, value: Types.TrainedModelDeploymentNodesStats list) =
            { state with Nodes = value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("peakThroughputPerMinute")>]
        member _.PeakThroughputPerMinute(state: Types.TrainedModelDeploymentStats, value: Types.Long) =
            { state with PeakThroughputPerMinute = value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.TrainedModelDeploymentStats, value: Types.TrainingPriority) =
            { state with Priority = value }

        [<CustomOperation("queueCapacity")>]
        member _.QueueCapacity(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with QueueCapacity = Some value }

        [<CustomOperation("rejectedExecutionCount")>]
        member _.RejectedExecutionCount(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with RejectedExecutionCount = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.TrainedModelDeploymentStats, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.TrainedModelDeploymentStats, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTime = value }

        [<CustomOperation("state")>]
        member _.State(state: Types.TrainedModelDeploymentStats, value: Types.DeploymentAssignmentState) =
            { state with State = Some value }

        [<CustomOperation("threadsPerAllocation")>]
        member _.ThreadsPerAllocation(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with ThreadsPerAllocation = Some value }

        [<CustomOperation("timeoutCount")>]
        member _.TimeoutCount(state: Types.TrainedModelDeploymentStats, value: Types.Integer) =
            { state with TimeoutCount = Some value }

    let trainedModelDeploymentStats = TrainedModelDeploymentStatsBuilder()

    type TrainedModelInferenceFeatureImportanceBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelInferenceFeatureImportance =
            {
                FeatureName = Unchecked.defaultof<_>
                Importance = None
                Classes = None
            }

        [<CustomOperation("featureName")>]
        member _.FeatureName(state: Types.TrainedModelInferenceFeatureImportance, value: string) =
            { state with FeatureName = value }

        [<CustomOperation("importance")>]
        member _.Importance(state: Types.TrainedModelInferenceFeatureImportance, value: Types.Double) =
            { state with Importance = Some value }

        [<CustomOperation("classes")>]
        member _.Classes(state: Types.TrainedModelInferenceFeatureImportance, value: Types.TrainedModelInferenceClassImportance list) =
            { state with Classes = Some value }

    let trainedModelInferenceFeatureImportance = TrainedModelInferenceFeatureImportanceBuilder()

    type TrainedModelPrefixStringsBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelPrefixStrings =
            {
                Ingest = None
                Search = None
            }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Types.TrainedModelPrefixStrings, value: string) =
            { state with Ingest = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Types.TrainedModelPrefixStrings, value: string) =
            { state with Search = Some value }

    let trainedModelPrefixStrings = TrainedModelPrefixStringsBuilder()

    type TrainedModelStatsBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelStats =
            {
                DeploymentStats = None
                InferenceStats = None
                Ingest = None
                ModelId = Unchecked.defaultof<_>
                ModelSizeStats = Unchecked.defaultof<_>
                PipelineCount = Unchecked.defaultof<_>
            }

        [<CustomOperation("deploymentStats")>]
        member _.DeploymentStats(state: Types.TrainedModelStats, value: Types.TrainedModelDeploymentStats) =
            { state with DeploymentStats = Some value }

        [<CustomOperation("inferenceStats")>]
        member _.InferenceStats(state: Types.TrainedModelStats, value: Types.TrainedModelInferenceStats) =
            { state with InferenceStats = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Types.TrainedModelStats, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ingest = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.TrainedModelStats, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("modelSizeStats")>]
        member _.ModelSizeStats(state: Types.TrainedModelStats, value: Types.TrainedModelSizeStats) =
            { state with ModelSizeStats = value }

        [<CustomOperation("pipelineCount")>]
        member _.PipelineCount(state: Types.TrainedModelStats, value: Types.Integer) =
            { state with PipelineCount = value }

    let trainedModelStats = TrainedModelStatsBuilder()

    type TransformAuthorizationBuilder() =
        member _.Yield(_: unit) : Types.TransformAuthorization =
            {
                ApiKey = None
                Roles = None
                ServiceAccount = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.TransformAuthorization, value: Types.ApiKeyAuthorization) =
            { state with ApiKey = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.TransformAuthorization, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("serviceAccount")>]
        member _.ServiceAccount(state: Types.TransformAuthorization, value: string) =
            { state with ServiceAccount = Some value }

    let transformAuthorization = TransformAuthorizationBuilder()

    type ZeroShotClassificationInferenceOptionsBuilder() =
        member _.Yield(_: unit) : Types.ZeroShotClassificationInferenceOptions =
            {
                Tokenization = None
                HypothesisTemplate = None
                ClassificationLabels = Unchecked.defaultof<_>
                ResultsField = None
                MultiLabel = None
                Labels = None
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.ZeroShotClassificationInferenceOptions, value: Types.TokenizationConfigContainer) =
            { state with Tokenization = Some value }

        [<CustomOperation("hypothesisTemplate")>]
        member _.HypothesisTemplate(state: Types.ZeroShotClassificationInferenceOptions, value: string) =
            { state with HypothesisTemplate = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Types.ZeroShotClassificationInferenceOptions, value: string list) =
            { state with ClassificationLabels = value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.ZeroShotClassificationInferenceOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("multiLabel")>]
        member _.MultiLabel(state: Types.ZeroShotClassificationInferenceOptions, value: bool) =
            { state with MultiLabel = Some value }

        [<CustomOperation("labels")>]
        member _.Labels(state: Types.ZeroShotClassificationInferenceOptions, value: string list) =
            { state with Labels = Some value }

    let zeroShotClassificationInferenceOptions = ZeroShotClassificationInferenceOptionsBuilder()

    type ZeroShotClassificationInferenceUpdateOptionsBuilder() =
        member _.Yield(_: unit) : Types.ZeroShotClassificationInferenceUpdateOptions =
            {
                Tokenization = None
                ResultsField = None
                MultiLabel = None
                Labels = Unchecked.defaultof<_>
            }

        [<CustomOperation("tokenization")>]
        member _.Tokenization(state: Types.ZeroShotClassificationInferenceUpdateOptions, value: Types.NlpTokenizationUpdateOptions) =
            { state with Tokenization = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.ZeroShotClassificationInferenceUpdateOptions, value: string) =
            { state with ResultsField = Some value }

        [<CustomOperation("multiLabel")>]
        member _.MultiLabel(state: Types.ZeroShotClassificationInferenceUpdateOptions, value: bool) =
            { state with MultiLabel = Some value }

        [<CustomOperation("labels")>]
        member _.Labels(state: Types.ZeroShotClassificationInferenceUpdateOptions, value: string list) =
            { state with Labels = value }

    let zeroShotClassificationInferenceUpdateOptions = ZeroShotClassificationInferenceUpdateOptionsBuilder()

