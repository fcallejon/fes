// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesPutDataStreamMappingsBuilders =

    type UpdatedDataStreamMappingsBuilder() =
        member _.Yield(_: unit) : UpdatedDataStreamMappings =
            {
                Name = Unchecked.defaultof<_>
                AppliedToDataStream = Unchecked.defaultof<_>
                Error = None
                Mappings = None
                EffectiveMappings = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: UpdatedDataStreamMappings, value: CoreTypes.IndexName) =
            { state with Name = value }

        [<CustomOperation("appliedToDataStream")>]
        member _.AppliedToDataStream(state: UpdatedDataStreamMappings, value: bool) =
            { state with AppliedToDataStream = value }

        [<CustomOperation("error")>]
        member _.Error(state: UpdatedDataStreamMappings, value: string) =
            { state with Error = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: UpdatedDataStreamMappings, value: CoreTypes.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("effectiveMappings")>]
        member _.EffectiveMappings(state: UpdatedDataStreamMappings, value: CoreTypes.TypeMapping) =
            { state with EffectiveMappings = Some value }

    let updatedDataStreamMappings = UpdatedDataStreamMappingsBuilder()

