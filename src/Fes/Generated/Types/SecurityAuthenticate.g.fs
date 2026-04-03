// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityAuthenticate =

    type AuthenticateApiKey = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("managed_by")>]
        ManagedBy: SecurityTypes.ApiKeyManagedBy
        [<System.Text.Json.Serialization.JsonPropertyName("internal")>]
        Internal: bool option
    }

    type Token = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

