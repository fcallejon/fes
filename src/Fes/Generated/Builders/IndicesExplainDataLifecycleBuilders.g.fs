// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesExplainDataLifecycleBuilders =

    type DataStreamLifecycleExplainBuilder() =
        member _.Yield(_: unit) : DataStreamLifecycleExplain =
            {
                Index = Unchecked.defaultof<_>
                ManagedByLifecycle = Unchecked.defaultof<_>
                IndexCreationDateMillis = None
                TimeSinceIndexCreation = None
                RolloverDateMillis = None
                TimeSinceRollover = None
                Lifecycle = None
                GenerationTime = None
                Error = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: DataStreamLifecycleExplain, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("managedByLifecycle")>]
        member _.ManagedByLifecycle(state: DataStreamLifecycleExplain, value: bool) =
            { state with ManagedByLifecycle = value }

        [<CustomOperation("indexCreationDateMillis")>]
        member _.IndexCreationDateMillis(state: DataStreamLifecycleExplain, value: Types.EpochTime<Types.UnitMillis>) =
            { state with IndexCreationDateMillis = Some value }

        [<CustomOperation("timeSinceIndexCreation")>]
        member _.TimeSinceIndexCreation(state: DataStreamLifecycleExplain, value: Types.Duration) =
            { state with TimeSinceIndexCreation = Some value }

        [<CustomOperation("rolloverDateMillis")>]
        member _.RolloverDateMillis(state: DataStreamLifecycleExplain, value: Types.EpochTime<Types.UnitMillis>) =
            { state with RolloverDateMillis = Some value }

        [<CustomOperation("timeSinceRollover")>]
        member _.TimeSinceRollover(state: DataStreamLifecycleExplain, value: Types.Duration) =
            { state with TimeSinceRollover = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: DataStreamLifecycleExplain, value: IndicesTypes.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("generationTime")>]
        member _.GenerationTime(state: DataStreamLifecycleExplain, value: Types.Duration) =
            { state with GenerationTime = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: DataStreamLifecycleExplain, value: string) =
            { state with Error = Some value }

    let dataStreamLifecycleExplain = DataStreamLifecycleExplainBuilder()

