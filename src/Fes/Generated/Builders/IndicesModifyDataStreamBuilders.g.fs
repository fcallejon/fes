// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesModifyDataStreamBuilders =

    module Action =

        let addBackingIndex (value: Types.IndexAndDataStreamAction) =
            Types.IndicesModifyDataStreamAction.AddBackingIndex value

        let removeBackingIndex (value: Types.IndexAndDataStreamAction) =
            Types.IndicesModifyDataStreamAction.RemoveBackingIndex value

