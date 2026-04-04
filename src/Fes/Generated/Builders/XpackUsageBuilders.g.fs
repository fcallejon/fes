// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module XpackUsageBuilders =

    type MlDataFrameAnalyticsJobsBuilder() =
        member _.Yield(_: unit) : Types.MlDataFrameAnalyticsJobs =
            {
                MemoryUsage = None
                All = Unchecked.defaultof<_>
                AnalysisCounts = None
                Stopped = None
            }

        [<CustomOperation("memoryUsage")>]
        member _.MemoryUsage(state: Types.MlDataFrameAnalyticsJobs, value: Types.MlDataFrameAnalyticsJobsMemory) =
            { state with MemoryUsage = Some value }

        [<CustomOperation("all")>]
        member _.All(state: Types.MlDataFrameAnalyticsJobs, value: Types.MlDataFrameAnalyticsJobsCount) =
            { state with All = value }

        [<CustomOperation("analysisCounts")>]
        member _.AnalysisCounts(state: Types.MlDataFrameAnalyticsJobs, value: Types.MlDataFrameAnalyticsJobsAnalysis) =
            { state with AnalysisCounts = Some value }

        [<CustomOperation("stopped")>]
        member _.Stopped(state: Types.MlDataFrameAnalyticsJobs, value: Types.MlDataFrameAnalyticsJobsCount) =
            { state with Stopped = Some value }

    let mlDataFrameAnalyticsJobs = MlDataFrameAnalyticsJobsBuilder()

    type MlDataFrameAnalyticsJobsAnalysisBuilder() =
        member _.Yield(_: unit) : Types.MlDataFrameAnalyticsJobsAnalysis =
            {
                Classification = None
                OutlierDetection = None
                Regression = None
            }

        [<CustomOperation("classification")>]
        member _.Classification(state: Types.MlDataFrameAnalyticsJobsAnalysis, value: Types.Integer) =
            { state with Classification = Some value }

        [<CustomOperation("outlierDetection")>]
        member _.OutlierDetection(state: Types.MlDataFrameAnalyticsJobsAnalysis, value: Types.Integer) =
            { state with OutlierDetection = Some value }

        [<CustomOperation("regression")>]
        member _.Regression(state: Types.MlDataFrameAnalyticsJobsAnalysis, value: Types.Integer) =
            { state with Regression = Some value }

    let mlDataFrameAnalyticsJobsAnalysis = MlDataFrameAnalyticsJobsAnalysisBuilder()

    type MlInferenceTrainedModelsBuilder() =
        member _.Yield(_: unit) : Types.MlInferenceTrainedModels =
            {
                EstimatedOperations = None
                EstimatedHeapMemoryUsageBytes = None
                Count = None
                All = Unchecked.defaultof<_>
                ModelSizeBytes = None
            }

        [<CustomOperation("estimatedOperations")>]
        member _.EstimatedOperations(state: Types.MlInferenceTrainedModels, value: Types.JobStatistics) =
            { state with EstimatedOperations = Some value }

        [<CustomOperation("estimatedHeapMemoryUsageBytes")>]
        member _.EstimatedHeapMemoryUsageBytes(state: Types.MlInferenceTrainedModels, value: Types.JobStatistics) =
            { state with EstimatedHeapMemoryUsageBytes = Some value }

        [<CustomOperation("count")>]
        member _.Count(state: Types.MlInferenceTrainedModels, value: Types.MlInferenceTrainedModelsCount) =
            { state with Count = Some value }

        [<CustomOperation("all")>]
        member _.All(state: Types.MlInferenceTrainedModels, value: Types.MlCounter) =
            { state with All = value }

        [<CustomOperation("modelSizeBytes")>]
        member _.ModelSizeBytes(state: Types.MlInferenceTrainedModels, value: Types.JobStatistics) =
            { state with ModelSizeBytes = Some value }

    let mlInferenceTrainedModels = MlInferenceTrainedModelsBuilder()

    type MlInferenceTrainedModelsCountBuilder() =
        member _.Yield(_: unit) : Types.MlInferenceTrainedModelsCount =
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
        member _.Total(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Total = value }

        [<CustomOperation("prepackaged")>]
        member _.Prepackaged(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Prepackaged = value }

        [<CustomOperation("other")>]
        member _.Other(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Other = value }

        [<CustomOperation("passThrough")>]
        member _.PassThrough(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with PassThrough = Some value }

        [<CustomOperation("regression")>]
        member _.Regression(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Regression = Some value }

        [<CustomOperation("classification")>]
        member _.Classification(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Classification = Some value }

        [<CustomOperation("ner")>]
        member _.Ner(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with Ner = Some value }

        [<CustomOperation("textEmbedding")>]
        member _.TextEmbedding(state: Types.MlInferenceTrainedModelsCount, value: Types.Long) =
            { state with TextEmbedding = Some value }

    let mlInferenceTrainedModelsCount = MlInferenceTrainedModelsCountBuilder()

    type XpackUsagePhasesBuilder() =
        member _.Yield(_: unit) : Types.XpackUsagePhases =
            {
                Cold = None
                Delete = None
                Frozen = None
                Hot = None
                Warm = None
            }

        [<CustomOperation("cold")>]
        member _.Cold(state: Types.XpackUsagePhases, value: Types.XpackUsagePhase) =
            { state with Cold = Some value }

        [<CustomOperation("delete")>]
        member _.Delete(state: Types.XpackUsagePhases, value: Types.XpackUsagePhase) =
            { state with Delete = Some value }

        [<CustomOperation("frozen")>]
        member _.Frozen(state: Types.XpackUsagePhases, value: Types.XpackUsagePhase) =
            { state with Frozen = Some value }

        [<CustomOperation("hot")>]
        member _.Hot(state: Types.XpackUsagePhases, value: Types.XpackUsagePhase) =
            { state with Hot = Some value }

        [<CustomOperation("warm")>]
        member _.Warm(state: Types.XpackUsagePhases, value: Types.XpackUsagePhase) =
            { state with Warm = Some value }

    let xpackUsagePhases = XpackUsagePhasesBuilder()

    type QueryBuilder() =
        member _.Yield(_: unit) : Types.Query =
            {
                Count = None
                Failed = None
                Paging = None
                Total = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.Query, value: Types.Integer) =
            { state with Count = Some value }

        [<CustomOperation("failed")>]
        member _.Failed(state: Types.Query, value: Types.Integer) =
            { state with Failed = Some value }

        [<CustomOperation("paging")>]
        member _.Paging(state: Types.Query, value: Types.Integer) =
            { state with Paging = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.Query, value: Types.Integer) =
            { state with Total = Some value }

    let query = QueryBuilder()

    type RealmBuilder() =
        member _.Yield(_: unit) : Types.Realm =
            {
                Name = None
                Order = None
                Size = None
                Cache = None
                HasAuthorizationRealms = None
                HasDefaultUsernamePattern = None
                HasTruststore = None
                IsAuthenticationDelegated = None
                Available = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.Realm, value: string list) =
            { state with Name = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.Realm, value: Types.Long list) =
            { state with Order = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.Realm, value: Types.Long list) =
            { state with Size = Some value }

        [<CustomOperation("cache")>]
        member _.Cache(state: Types.Realm, value: Types.RealmCache list) =
            { state with Cache = Some value }

        [<CustomOperation("hasAuthorizationRealms")>]
        member _.HasAuthorizationRealms(state: Types.Realm, value: bool list) =
            { state with HasAuthorizationRealms = Some value }

        [<CustomOperation("hasDefaultUsernamePattern")>]
        member _.HasDefaultUsernamePattern(state: Types.Realm, value: bool list) =
            { state with HasDefaultUsernamePattern = Some value }

        [<CustomOperation("hasTruststore")>]
        member _.HasTruststore(state: Types.Realm, value: bool list) =
            { state with HasTruststore = Some value }

        [<CustomOperation("isAuthenticationDelegated")>]
        member _.IsAuthenticationDelegated(state: Types.Realm, value: bool list) =
            { state with IsAuthenticationDelegated = Some value }

        [<CustomOperation("available")>]
        member _.Available(state: Types.Realm, value: bool) =
            { state with Available = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.Realm, value: bool) =
            { state with Enabled = value }

    let realm = RealmBuilder()

    type SearchableSnapshotsBuilder() =
        member _.Yield(_: unit) : Types.SearchableSnapshots =
            {
                IndicesCount = Unchecked.defaultof<_>
                FullCopyIndicesCount = None
                SharedCacheIndicesCount = None
                Available = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
            }

        [<CustomOperation("indicesCount")>]
        member _.IndicesCount(state: Types.SearchableSnapshots, value: Types.Integer) =
            { state with IndicesCount = value }

        [<CustomOperation("fullCopyIndicesCount")>]
        member _.FullCopyIndicesCount(state: Types.SearchableSnapshots, value: Types.Integer) =
            { state with FullCopyIndicesCount = Some value }

        [<CustomOperation("sharedCacheIndicesCount")>]
        member _.SharedCacheIndicesCount(state: Types.SearchableSnapshots, value: Types.Integer) =
            { state with SharedCacheIndicesCount = Some value }

        [<CustomOperation("available")>]
        member _.Available(state: Types.SearchableSnapshots, value: bool) =
            { state with Available = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.SearchableSnapshots, value: bool) =
            { state with Enabled = value }

    let searchableSnapshots = SearchableSnapshotsBuilder()

    type SlmBuilder() =
        member _.Yield(_: unit) : Types.Slm =
            {
                PolicyCount = None
                PolicyStats = None
                Available = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
            }

        [<CustomOperation("policyCount")>]
        member _.PolicyCount(state: Types.Slm, value: Types.Integer) =
            { state with PolicyCount = Some value }

        [<CustomOperation("policyStats")>]
        member _.PolicyStats(state: Types.Slm, value: Types.Statistics) =
            { state with PolicyStats = Some value }

        [<CustomOperation("available")>]
        member _.Available(state: Types.Slm, value: bool) =
            { state with Available = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.Slm, value: bool) =
            { state with Enabled = value }

    let slm = SlmBuilder()

    type WatcherWatchBuilder() =
        member _.Yield(_: unit) : Types.WatcherWatch =
            {
                Input = Unchecked.defaultof<_>
                Condition = None
                Action = None
                Trigger = Unchecked.defaultof<_>
            }

        [<CustomOperation("input")>]
        member _.Input(state: Types.WatcherWatch, value: Map<Types.Name, Types.Counter>) =
            { state with Input = value }

        [<CustomOperation("condition")>]
        member _.Condition(state: Types.WatcherWatch, value: Map<Types.Name, Types.Counter>) =
            { state with Condition = Some value }

        [<CustomOperation("action")>]
        member _.Action(state: Types.WatcherWatch, value: Map<Types.Name, Types.Counter>) =
            { state with Action = Some value }

        [<CustomOperation("trigger")>]
        member _.Trigger(state: Types.WatcherWatch, value: Types.WatcherWatchTrigger) =
            { state with Trigger = value }

    let watcherWatch = WatcherWatchBuilder()

