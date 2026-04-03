// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalHealthReportBuilders =

    type BaseIndicatorBuilder() =
        member _.Yield(_: unit) : BaseIndicator =
            {
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("status")>]
        member _.Status(state: BaseIndicator, value: GlobalHealthReport.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: BaseIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: BaseIndicator, value: GlobalHealthReport.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: BaseIndicator, value: GlobalHealthReport.Diagnosis list) =
            { state with Diagnosis = Some value }

    let baseIndicator = BaseIndicatorBuilder()

    type DiagnosisAffectedResourcesBuilder() =
        member _.Yield(_: unit) : DiagnosisAffectedResources =
            {
                Indices = None
                Nodes = None
                SlmPolicies = None
                FeatureStates = None
                SnapshotRepositories = None
            }

        [<CustomOperation("indices")>]
        member _.Indices(state: DiagnosisAffectedResources, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: DiagnosisAffectedResources, value: GlobalHealthReport.IndicatorNode list) =
            { state with Nodes = Some value }

        [<CustomOperation("slmPolicies")>]
        member _.SlmPolicies(state: DiagnosisAffectedResources, value: string list) =
            { state with SlmPolicies = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: DiagnosisAffectedResources, value: string list) =
            { state with FeatureStates = Some value }

        [<CustomOperation("snapshotRepositories")>]
        member _.SnapshotRepositories(state: DiagnosisAffectedResources, value: string list) =
            { state with SnapshotRepositories = Some value }

    let diagnosisAffectedResources = DiagnosisAffectedResourcesBuilder()

    type IndicatorsBuilder() =
        member _.Yield(_: unit) : Indicators =
            {
                MasterIsStable = None
                ShardsAvailability = None
                Disk = None
                RepositoryIntegrity = None
                DataStreamLifecycle = None
                Ilm = None
                Slm = None
                ShardsCapacity = None
                FileSettings = None
            }

        [<CustomOperation("masterIsStable")>]
        member _.MasterIsStable(state: Indicators, value: GlobalHealthReport.MasterIsStableIndicator) =
            { state with MasterIsStable = Some value }

        [<CustomOperation("shardsAvailability")>]
        member _.ShardsAvailability(state: Indicators, value: GlobalHealthReport.ShardsAvailabilityIndicator) =
            { state with ShardsAvailability = Some value }

        [<CustomOperation("disk")>]
        member _.Disk(state: Indicators, value: GlobalHealthReport.DiskIndicator) =
            { state with Disk = Some value }

        [<CustomOperation("repositoryIntegrity")>]
        member _.RepositoryIntegrity(state: Indicators, value: GlobalHealthReport.RepositoryIntegrityIndicator) =
            { state with RepositoryIntegrity = Some value }

        [<CustomOperation("dataStreamLifecycle")>]
        member _.DataStreamLifecycle(state: Indicators, value: GlobalHealthReport.DataStreamLifecycleIndicator) =
            { state with DataStreamLifecycle = Some value }

        [<CustomOperation("ilm")>]
        member _.Ilm(state: Indicators, value: GlobalHealthReport.IlmIndicator) =
            { state with Ilm = Some value }

        [<CustomOperation("slm")>]
        member _.Slm(state: Indicators, value: GlobalHealthReport.SlmIndicator) =
            { state with Slm = Some value }

        [<CustomOperation("shardsCapacity")>]
        member _.ShardsCapacity(state: Indicators, value: GlobalHealthReport.ShardsCapacityIndicator) =
            { state with ShardsCapacity = Some value }

        [<CustomOperation("fileSettings")>]
        member _.FileSettings(state: Indicators, value: GlobalHealthReport.FileSettingsIndicator) =
            { state with FileSettings = Some value }

    let indicators = IndicatorsBuilder()

    type MasterIsStableIndicatorDetailsBuilder() =
        member _.Yield(_: unit) : MasterIsStableIndicatorDetails =
            {
                CurrentMaster = Unchecked.defaultof<_>
                RecentMasters = Unchecked.defaultof<_>
                ExceptionFetchingHistory = None
                ClusterFormation = None
            }

        [<CustomOperation("currentMaster")>]
        member _.CurrentMaster(state: MasterIsStableIndicatorDetails, value: GlobalHealthReport.IndicatorNode) =
            { state with CurrentMaster = value }

        [<CustomOperation("recentMasters")>]
        member _.RecentMasters(state: MasterIsStableIndicatorDetails, value: GlobalHealthReport.IndicatorNode list) =
            { state with RecentMasters = value }

        [<CustomOperation("exceptionFetchingHistory")>]
        member _.ExceptionFetchingHistory(state: MasterIsStableIndicatorDetails, value: GlobalHealthReport.MasterIsStableIndicatorExceptionFetchingHistory) =
            { state with ExceptionFetchingHistory = Some value }

        [<CustomOperation("clusterFormation")>]
        member _.ClusterFormation(state: MasterIsStableIndicatorDetails, value: GlobalHealthReport.MasterIsStableIndicatorClusterFormationNode list) =
            { state with ClusterFormation = Some value }

    let masterIsStableIndicatorDetails = MasterIsStableIndicatorDetailsBuilder()

    type RepositoryIntegrityIndicatorDetailsBuilder() =
        member _.Yield(_: unit) : RepositoryIntegrityIndicatorDetails =
            {
                TotalRepositories = None
                CorruptedRepositories = None
                Corrupted = None
            }

        [<CustomOperation("totalRepositories")>]
        member _.TotalRepositories(state: RepositoryIntegrityIndicatorDetails, value: Types.Long) =
            { state with TotalRepositories = Some value }

        [<CustomOperation("corruptedRepositories")>]
        member _.CorruptedRepositories(state: RepositoryIntegrityIndicatorDetails, value: Types.Long) =
            { state with CorruptedRepositories = Some value }

        [<CustomOperation("corrupted")>]
        member _.Corrupted(state: RepositoryIntegrityIndicatorDetails, value: string list) =
            { state with Corrupted = Some value }

    let repositoryIntegrityIndicatorDetails = RepositoryIntegrityIndicatorDetailsBuilder()

