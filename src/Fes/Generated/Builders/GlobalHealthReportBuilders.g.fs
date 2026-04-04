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

    type DataStreamLifecycleIndicatorBuilder() =
        member _.Yield(_: unit) : Types.DataStreamLifecycleIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.DataStreamLifecycleIndicator, value: Types.DataStreamLifecycleDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.DataStreamLifecycleIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.DataStreamLifecycleIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.DataStreamLifecycleIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.DataStreamLifecycleIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let dataStreamLifecycleIndicator = DataStreamLifecycleIndicatorBuilder()

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

    type DiskIndicatorBuilder() =
        member _.Yield(_: unit) : Types.DiskIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.DiskIndicator, value: Types.DiskIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.DiskIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.DiskIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.DiskIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.DiskIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let diskIndicator = DiskIndicatorBuilder()

    type FileSettingsIndicatorBuilder() =
        member _.Yield(_: unit) : Types.FileSettingsIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.FileSettingsIndicator, value: Types.FileSettingsIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.FileSettingsIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.FileSettingsIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.FileSettingsIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.FileSettingsIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let fileSettingsIndicator = FileSettingsIndicatorBuilder()

    type IlmIndicatorBuilder() =
        member _.Yield(_: unit) : Types.IlmIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.IlmIndicator, value: Types.IlmIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.IlmIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.IlmIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.IlmIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.IlmIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let ilmIndicator = IlmIndicatorBuilder()

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

    type MasterIsStableIndicatorBuilder() =
        member _.Yield(_: unit) : Types.MasterIsStableIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.MasterIsStableIndicator, value: Types.MasterIsStableIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.MasterIsStableIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.MasterIsStableIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.MasterIsStableIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.MasterIsStableIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let masterIsStableIndicator = MasterIsStableIndicatorBuilder()

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

    type RepositoryIntegrityIndicatorBuilder() =
        member _.Yield(_: unit) : Types.RepositoryIntegrityIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.RepositoryIntegrityIndicator, value: Types.RepositoryIntegrityIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.RepositoryIntegrityIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.RepositoryIntegrityIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.RepositoryIntegrityIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.RepositoryIntegrityIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let repositoryIntegrityIndicator = RepositoryIntegrityIndicatorBuilder()

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

    type ShardsAvailabilityIndicatorBuilder() =
        member _.Yield(_: unit) : Types.ShardsAvailabilityIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.ShardsAvailabilityIndicator, value: Types.ShardsAvailabilityIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.ShardsAvailabilityIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.ShardsAvailabilityIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.ShardsAvailabilityIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.ShardsAvailabilityIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let shardsAvailabilityIndicator = ShardsAvailabilityIndicatorBuilder()

    type ShardsCapacityIndicatorBuilder() =
        member _.Yield(_: unit) : Types.ShardsCapacityIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.ShardsCapacityIndicator, value: Types.ShardsCapacityIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.ShardsCapacityIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.ShardsCapacityIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.ShardsCapacityIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.ShardsCapacityIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let shardsCapacityIndicator = ShardsCapacityIndicatorBuilder()

    type SlmIndicatorBuilder() =
        member _.Yield(_: unit) : Types.SlmIndicator =
            {
                Details = None
                Status = Unchecked.defaultof<_>
                Symptom = Unchecked.defaultof<_>
                Impacts = None
                Diagnosis = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.SlmIndicator, value: Types.SlmIndicatorDetails) =
            { state with Details = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.SlmIndicator, value: Types.IndicatorHealthStatus) =
            { state with Status = value }

        [<CustomOperation("symptom")>]
        member _.Symptom(state: Types.SlmIndicator, value: string) =
            { state with Symptom = value }

        [<CustomOperation("impacts")>]
        member _.Impacts(state: Types.SlmIndicator, value: Types.Impact list) =
            { state with Impacts = Some value }

        [<CustomOperation("diagnosis")>]
        member _.Diagnosis(state: Types.SlmIndicator, value: Types.Diagnosis list) =
            { state with Diagnosis = Some value }

    let slmIndicator = SlmIndicatorBuilder()

