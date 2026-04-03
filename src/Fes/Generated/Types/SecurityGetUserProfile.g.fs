// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityGetUserProfile =

    type GetUserProfileErrors = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<SecurityTypes.UserProfileId, Types.ErrorCause>
    }

