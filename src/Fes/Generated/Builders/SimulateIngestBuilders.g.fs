// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SimulateIngestBuilders =

    type IngestDocumentSimulationBuilder() =
        member _.Yield(_: unit) : Types.IngestDocumentSimulation =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Source = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                ExecutedPipelines = Unchecked.defaultof<_>
                IgnoredFields = None
                Error = None
                EffectiveMapping = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.IngestDocumentSimulation, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IngestDocumentSimulation, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.IngestDocumentSimulation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Source = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.IngestDocumentSimulation, value: Types.Stringified<Types.VersionNumber>) =
            { state with Version = value }

        [<CustomOperation("executedPipelines")>]
        member _.ExecutedPipelines(state: Types.IngestDocumentSimulation, value: string list) =
            { state with ExecutedPipelines = value }

        [<CustomOperation("ignoredFields")>]
        member _.IgnoredFields(state: Types.IngestDocumentSimulation, value: Map<string, string> list) =
            { state with IgnoredFields = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.IngestDocumentSimulation, value: Types.ErrorCause) =
            { state with Error = Some value }

        [<CustomOperation("effectiveMapping")>]
        member _.EffectiveMapping(state: Types.IngestDocumentSimulation, value: Types.TypeMapping) =
            { state with EffectiveMapping = Some value }

    let ingestDocumentSimulation = IngestDocumentSimulationBuilder()

