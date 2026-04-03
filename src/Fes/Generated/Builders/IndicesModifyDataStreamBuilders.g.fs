// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesModifyDataStreamBuilders =

    module Action =

        let addBackingIndex (value: IndicesModifyDataStream.IndexAndDataStreamAction) =
            Action.AddBackingIndex value

        let removeBackingIndex (value: IndicesModifyDataStream.IndexAndDataStreamAction) =
            Action.RemoveBackingIndex value

