// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalHealthReportBuilders =

    type BaseIndicatorBuilder() =
        member _.Yield(_: unit) : Types.BaseIndicator =
            {
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("status")>]
        member _.Status(state: Types.BaseIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.BaseIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.BaseIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.BaseIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let baseIndicator = BaseIndicatorBuilder()

    type DiagnosisAffectedResourcesBuilder() =
        member _.Yield(_: unit) : Types.DiagnosisAffectedResources =
            {
                Indices = None
                Nodes = None
                SlmPolicies = None
                FeatureStates = None
                SnapshotRepositories = None
            }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.DiagnosisAffectedResources, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: Types.DiagnosisAffectedResources, value: Types.IndicatorNode list) =
            { state with Nodes = Some value }

        [<CustomOperation("slmPolicies")>]
        member _.SlmPolicies(state: Types.DiagnosisAffectedResources, value: string list) =
            { state with SlmPolicies = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: Types.DiagnosisAffectedResources, value: string list) =
            { state with FeatureStates = Some value }

        [<CustomOperation("snapshotRepositories")>]
        member _.SnapshotRepositories(state: Types.DiagnosisAffectedResources, value: string list) =
            { state with SnapshotRepositories = Some value }

    let diagnosisAffectedResources = DiagnosisAffectedResourcesBuilder()

    type IndicatorsBuilder() =
        member _.Yield(_: unit) : Types.Indicators =
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
        member _.MasterIsStable(state: Types.Indicators, value: Types.MasterIsStableIndicator) =
            { state with MasterIsStable = Some value }

        [<CustomOperation("shardsAvailability")>]
        member _.ShardsAvailability(state: Types.Indicators, value: Types.ShardsAvailabilityIndicator) =
            { state with ShardsAvailability = Some value }

        [<CustomOperation("disk")>]
        member _.Disk(state: Types.Indicators, value: Types.DiskIndicator) =
            { state with Disk = Some value }

        [<CustomOperation("repositoryIntegrity")>]
        member _.RepositoryIntegrity(state: Types.Indicators, value: Types.RepositoryIntegrityIndicator) =
            { state with RepositoryIntegrity = Some value }

        [<CustomOperation("dataStreamLifecycle")>]
        member _.DataStreamLifecycle(state: Types.Indicators, value: Types.DataStreamLifecycleIndicator) =
            { state with DataStreamLifecycle = Some value }

        [<CustomOperation("ilm")>]
        member _.Ilm(state: Types.Indicators, value: Types.IlmIndicator) =
            { state with Ilm = Some value }

        [<CustomOperation("slm")>]
        member _.Slm(state: Types.Indicators, value: Types.SlmIndicator) =
            { state with Slm = Some value }

        [<CustomOperation("shardsCapacity")>]
        member _.ShardsCapacity(state: Types.Indicators, value: Types.ShardsCapacityIndicator) =
            { state with ShardsCapacity = Some value }

        [<CustomOperation("fileSettings")>]
        member _.FileSettings(state: Types.Indicators, value: Types.FileSettingsIndicator) =
            { state with FileSettings = Some value }

    let indicators = IndicatorsBuilder()

    type MasterIsStableIndicatorDetailsBuilder() =
        member _.Yield(_: unit) : Types.MasterIsStableIndicatorDetails =
            {
                CurrentMaster = Unchecked.defaultof<_>
                RecentMasters = Unchecked.defaultof<_>
                ExceptionFetchingHistory = None
                ClusterFormation = None
            }

        [<CustomOperation("currentMaster")>]
        member _.CurrentMaster(state: Types.MasterIsStableIndicatorDetails, value: Types.IndicatorNode) =
            { state with CurrentMaster = value }

        [<CustomOperation("recentMasters")>]
        member _.RecentMasters(state: Types.MasterIsStableIndicatorDetails, value: Types.IndicatorNode list) =
            { state with RecentMasters = value }

        [<CustomOperation("exceptionFetchingHistory")>]
        member _.ExceptionFetchingHistory(state: Types.MasterIsStableIndicatorDetails, value: Types.MasterIsStableIndicatorExceptionFetchingHistory) =
            { state with ExceptionFetchingHistory = Some value }

        [<CustomOperation("clusterFormation")>]
        member _.ClusterFormation(state: Types.MasterIsStableIndicatorDetails, value: Types.MasterIsStableIndicatorClusterFormationNode list) =
            { state with ClusterFormation = Some value }

    let masterIsStableIndicatorDetails = MasterIsStableIndicatorDetailsBuilder()

    type RepositoryIntegrityIndicatorDetailsBuilder() =
        member _.Yield(_: unit) : Types.RepositoryIntegrityIndicatorDetails =
            {
                TotalRepositories = None
                CorruptedRepositories = None
                Corrupted = None
            }

        [<CustomOperation("totalRepositories")>]
        member _.TotalRepositories(state: Types.RepositoryIntegrityIndicatorDetails, value: Types.Long) =
            { state with TotalRepositories = Some value }

        [<CustomOperation("corruptedRepositories")>]
        member _.CorruptedRepositories(state: Types.RepositoryIntegrityIndicatorDetails, value: Types.Long) =
            { state with CorruptedRepositories = Some value }

        [<CustomOperation("corrupted")>]
        member _.Corrupted(state: Types.RepositoryIntegrityIndicatorDetails, value: string list) =
            { state with Corrupted = Some value }

    let repositoryIntegrityIndicatorDetails = RepositoryIntegrityIndicatorDetailsBuilder()

