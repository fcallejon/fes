// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module RollupGetJobsBuilders =

    type RollupJobStatusBuilder() =
        member _.Yield(_: unit) : RollupJobStatus =
            {
                CurrentPosition = None
                JobState = Unchecked.defaultof<_>
                UpgradedDocId = None
            }

        [<CustomOperation("currentPosition")>]
        member _.CurrentPosition(state: RollupJobStatus, value: Map<string, System.Text.Json.JsonElement>) =
            { state with CurrentPosition = Some value }

        [<CustomOperation("jobState")>]
        member _.JobState(state: RollupJobStatus, value: RollupGetJobs.IndexingJobState) =
            { state with JobState = value }

        [<CustomOperation("upgradedDocId")>]
        member _.UpgradedDocId(state: RollupJobStatus, value: bool) =
            { state with UpgradedDocId = Some value }

    let rollupJobStatus = RollupJobStatusBuilder()

