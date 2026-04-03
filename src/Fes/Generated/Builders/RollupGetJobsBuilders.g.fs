// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module RollupGetJobsBuilders =

    type RollupJobStatusBuilder() =
        member _.Yield(_: unit) : Types.RollupJobStatus =
            {
                CurrentPosition = None
                JobState = Unchecked.defaultof<_>
                UpgradedDocId = None
            }

        [<CustomOperation("currentPosition")>]
        member _.CurrentPosition(state: Types.RollupJobStatus, value: Map<string, System.Text.Json.JsonElement>) =
            { state with CurrentPosition = Some value }

        [<CustomOperation("jobState")>]
        member _.JobState(state: Types.RollupJobStatus, value: Types.IndexingJobState) =
            { state with JobState = value }

        [<CustomOperation("upgradedDocId")>]
        member _.UpgradedDocId(state: Types.RollupJobStatus, value: bool) =
            { state with UpgradedDocId = Some value }

    let rollupJobStatus = RollupJobStatusBuilder()

