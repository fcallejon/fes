// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecuritySuggestUserProfiles =

    type Hint = {
        [<System.Text.Json.Serialization.JsonPropertyName("uids")>]
        Uids: SecurityTypes.UserProfileId list option
        [<System.Text.Json.Serialization.JsonPropertyName("labels")>]
        Labels: Map<string, System.Text.Json.JsonElement> option
    }

    type TotalUserProfiles = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: Types.RelationName
    }

