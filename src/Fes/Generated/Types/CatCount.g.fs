// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatCount =

    type CountRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("epoch")>]
        Epoch: CoreTypes.Stringified<CoreTypes.EpochTime<CoreTypes.UnitSeconds>> option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.TimeOfDay option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: string option
    }

