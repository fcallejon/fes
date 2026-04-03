// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalUpdate =

    type UpdateWriteResponseBase<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("get")>]
        Get: Types.InlineGet<'tDocument> option
    }

