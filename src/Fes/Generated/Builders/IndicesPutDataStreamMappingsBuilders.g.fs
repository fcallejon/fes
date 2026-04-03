// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesPutDataStreamMappingsBuilders =

    type UpdatedDataStreamMappingsBuilder() =
        member _.Yield(_: unit) : Types.UpdatedDataStreamMappings =
            {
                Name = Unchecked.defaultof<_>
                AppliedToDataStream = Unchecked.defaultof<_>
                Error = None
                Mappings = None
                EffectiveMappings = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.UpdatedDataStreamMappings, value: Types.IndexName) =
            { state with Name = value }

        [<CustomOperation("appliedToDataStream")>]
        member _.AppliedToDataStream(state: Types.UpdatedDataStreamMappings, value: bool) =
            { state with AppliedToDataStream = value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.UpdatedDataStreamMappings, value: string) =
            { state with Error = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.UpdatedDataStreamMappings, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("effectiveMappings")>]
        member _.EffectiveMappings(state: Types.UpdatedDataStreamMappings, value: Types.TypeMapping) =
            { state with EffectiveMappings = Some value }

    let updatedDataStreamMappings = UpdatedDataStreamMappingsBuilder()

