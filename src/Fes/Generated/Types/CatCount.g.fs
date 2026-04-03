// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatCount =

    type CountRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("epoch")>]
        Epoch: SpecUtils.Stringified<Types.EpochTime<Types.UnitSeconds>> option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.TimeOfDay option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: string option
    }

