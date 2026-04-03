// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module XpackUsageBuilders =

    type MlDataFrameAnalyticsJobsBuilder() =
        member _.Yield(_: unit) : MlDataFrameAnalyticsJobs =
            {
                MemoryUsage = None
                All = Unchecked.defaultof<_>
                AnalysisCounts = None
                Stopped = None
            }

        [<CustomOperation("memoryUsage")>]
        member _.MemoryUsage(state: MlDataFrameAnalyticsJobs, value: XpackUsage.MlDataFrameAnalyticsJobsMemory) =
            { state with MemoryUsage = Some value }

        [<CustomOperation("all")>]
        member _.All(state: MlDataFrameAnalyticsJobs, value: XpackUsage.MlDataFrameAnalyticsJobsCount) =
            { state with All = value }

        [<CustomOperation("analysisCounts")>]
        member _.AnalysisCounts(state: MlDataFrameAnalyticsJobs, value: XpackUsage.MlDataFrameAnalyticsJobsAnalysis) =
            { state with AnalysisCounts = Some value }

        [<CustomOperation("stopped")>]
        member _.Stopped(state: MlDataFrameAnalyticsJobs, value: XpackUsage.MlDataFrameAnalyticsJobsCount) =
            { state with Stopped = Some value }

    let mlDataFrameAnalyticsJobs = MlDataFrameAnalyticsJobsBuilder()

    type MlDataFrameAnalyticsJobsAnalysisBuilder() =
        member _.Yield(_: unit) : MlDataFrameAnalyticsJobsAnalysis =
            {
                Classification = None
                OutlierDetection = None
                Regression = None
            }

        [<CustomOperation("classification")>]
        member _.Classification(state: MlDataFrameAnalyticsJobsAnalysis, value: Types.Integer) =
            { state with Classification = Some value }

        [<CustomOperation("outlierDetection")>]
        member _.OutlierDetection(state: MlDataFrameAnalyticsJobsAnalysis, value: Types.Integer) =
            { state with OutlierDetection = Some value }

        [<CustomOperation("regression")>]
        member _.Regression(state: MlDataFrameAnalyticsJobsAnalysis, value: Types.Integer) =
            { state with Regression = Some value }

    let mlDataFrameAnalyticsJobsAnalysis = MlDataFrameAnalyticsJobsAnalysisBuilder()

    type MlInferenceTrainedModelsBuilder() =
        member _.Yield(_: unit) : MlInferenceTrainedModels =
            {
                EstimatedOperations = None
                EstimatedHeapMemoryUsageBytes = None
                Count = None
                All = Unchecked.defaultof<_>
                ModelSizeBytes = None
            }

        [<CustomOperation("estimatedOperations")>]
        member _.EstimatedOperations(state: MlInferenceTrainedModels, value: MlTypes.JobStatistics) =
            { state with EstimatedOperations = Some value }

        [<CustomOperation("estimatedHeapMemoryUsageBytes")>]
        member _.EstimatedHeapMemoryUsageBytes(state: MlInferenceTrainedModels, value: MlTypes.JobStatistics) =
            { state with EstimatedHeapMemoryUsageBytes = Some value }

        [<CustomOperation("count")>]
        member _.Count(state: MlInferenceTrainedModels, value: XpackUsage.MlInferenceTrainedModelsCount) =
            { state with Count = Some value }

        [<CustomOperation("all")>]
        member _.All(state: MlInferenceTrainedModels, value: XpackUsage.MlCounter) =
            { state with All = value }

        [<CustomOperation("modelSizeBytes")>]
        member _.ModelSizeBytes(state: MlInferenceTrainedModels, value: MlTypes.JobStatistics) =
            { state with ModelSizeBytes = Some value }

    let mlInferenceTrainedModels = MlInferenceTrainedModelsBuilder()

    type MlInferenceTrainedModelsCountBuilder() =
        member _.Yield(_: unit) : MlInferenceTrainedModelsCount =
            {
                Total = Unchecked.defaultof<_>
                Prepackaged = Unchecked.defaultof<_>
                Other = Unchecked.defaultof<_>
                PassThrough = None
                Regression = None
                Classification = None
                Ner = None
                TextEmbedding = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Total = value }

        [<CustomOperation("prepackaged")>]
        member _.Prepackaged(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Prepackaged = value }

        [<CustomOperation("other")>]
        member _.Other(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Other = value }

        [<CustomOperation("passThrough")>]
        member _.PassThrough(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with PassThrough = Some value }

        [<CustomOperation("regression")>]
        member _.Regression(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Regression = Some value }

        [<CustomOperation("classification")>]
        member _.Classification(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Classification = Some value }

        [<CustomOperation("ner")>]
        member _.Ner(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Ner = Some value }

        [<CustomOperation("textEmbedding")>]
        member _.TextEmbedding(state: MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with TextEmbedding = Some value }

    let mlInferenceTrainedModelsCount = MlInferenceTrainedModelsCountBuilder()

    type PhasesBuilder() =
        member _.Yield(_: unit) : Phases =
            {
                Cold = None
                Delete = None
                Frozen = None
                Hot = None
                Warm = None
            }

        [<CustomOperation("cold")>]
        member _.Cold(state: Phases, value: XpackUsage.Phase) =
            { state with Cold = Some value }

        [<CustomOperation("delete")>]
        member _.Delete(state: Phases, value: XpackUsage.Phase) =
            { state with Delete = Some value }

        [<CustomOperation("frozen")>]
        member _.Frozen(state: Phases, value: XpackUsage.Phase) =
            { state with Frozen = Some value }

        [<CustomOperation("hot")>]
        member _.Hot(state: Phases, value: XpackUsage.Phase) =
            { state with Hot = Some value }

        [<CustomOperation("warm")>]
        member _.Warm(state: Phases, value: XpackUsage.Phase) =
            { state with Warm = Some value }

    let phases = PhasesBuilder()

    type QueryBuilder() =
        member _.Yield(_: unit) : Query =
            {
                Count = None
                Failed = None
                Paging = None
                Total = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Query, value: Types.Integer) =
            { state with Count = Some value }

        [<CustomOperation("failed")>]
        member _.Failed(state: Query, value: Types.Integer) =
            { state with Failed = Some value }

        [<CustomOperation("paging")>]
        member _.Paging(state: Query, value: Types.Integer) =
            { state with Paging = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Query, value: Types.Integer) =
            { state with Total = Some value }

    let query = QueryBuilder()

    type RealmBuilder() =
        member _.Yield(_: unit) : Realm =
            {
                Name = None
                Order = None
                Size = None
                Cache = None
                HasAuthorizationRealms = None
                HasDefaultUsernamePattern = None
                HasTruststore = None
                IsAuthenticationDelegated = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Realm, value: string list) =
            { state with Name = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Realm, value: Types.Long list) =
            { state with Order = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Realm, value: Types.Long list) =
            { state with Size = Some value }

        [<CustomOperation("cache")>]
        member _.Cache(state: Realm, value: XpackUsage.RealmCache list) =
            { state with Cache = Some value }

        [<CustomOperation("hasAuthorizationRealms")>]
        member _.HasAuthorizationRealms(state: Realm, value: bool list) =
            { state with HasAuthorizationRealms = Some value }

        [<CustomOperation("hasDefaultUsernamePattern")>]
        member _.HasDefaultUsernamePattern(state: Realm, value: bool list) =
            { state with HasDefaultUsernamePattern = Some value }

        [<CustomOperation("hasTruststore")>]
        member _.HasTruststore(state: Realm, value: bool list) =
            { state with HasTruststore = Some value }

        [<CustomOperation("isAuthenticationDelegated")>]
        member _.IsAuthenticationDelegated(state: Realm, value: bool list) =
            { state with IsAuthenticationDelegated = Some value }

    let realm = RealmBuilder()

    type SearchableSnapshotsBuilder() =
        member _.Yield(_: unit) : SearchableSnapshots =
            {
                IndicesCount = Unchecked.defaultof<_>
                FullCopyIndicesCount = None
                SharedCacheIndicesCount = None
            }

        [<CustomOperation("indicesCount")>]
        member _.IndicesCount(state: SearchableSnapshots, value: Types.Integer) =
            { state with IndicesCount = value }

        [<CustomOperation("fullCopyIndicesCount")>]
        member _.FullCopyIndicesCount(state: SearchableSnapshots, value: Types.Integer) =
            { state with FullCopyIndicesCount = Some value }

        [<CustomOperation("sharedCacheIndicesCount")>]
        member _.SharedCacheIndicesCount(state: SearchableSnapshots, value: Types.Integer) =
            { state with SharedCacheIndicesCount = Some value }

    let searchableSnapshots = SearchableSnapshotsBuilder()

    type SlmBuilder() =
        member _.Yield(_: unit) : Slm =
            {
                PolicyCount = None
                PolicyStats = None
            }

        [<CustomOperation("policyCount")>]
        member _.PolicyCount(state: Slm, value: Types.Integer) =
            { state with PolicyCount = Some value }

        [<CustomOperation("policyStats")>]
        member _.PolicyStats(state: Slm, value: SlmTypes.Statistics) =
            { state with PolicyStats = Some value }

    let slm = SlmBuilder()

    type WatcherWatchBuilder() =
        member _.Yield(_: unit) : WatcherWatch =
            {
                Input = Unchecked.defaultof<_>
                Condition = None
                Action = None
                Trigger = Unchecked.defaultof<_>
            }

        [<CustomOperation("input")>]
        member _.Input(state: WatcherWatch, value: Map<Types.Name, XpackUsage.Counter>) =
            { state with Input = value }

        [<CustomOperation("condition")>]
        member _.Condition(state: WatcherWatch, value: Map<Types.Name, XpackUsage.Counter>) =
            { state with Condition = Some value }

        [<CustomOperation("action")>]
        member _.Action(state: WatcherWatch, value: Map<Types.Name, XpackUsage.Counter>) =
            { state with Action = Some value }

        [<CustomOperation("trigger")>]
        member _.Trigger(state: WatcherWatch, value: XpackUsage.WatcherWatchTrigger) =
            { state with Trigger = value }

    let watcherWatch = WatcherWatchBuilder()

