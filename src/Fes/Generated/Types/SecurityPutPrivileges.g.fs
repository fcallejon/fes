// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityPutPrivileges =

    type Actions = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: string list
        [<System.Text.Json.Serialization.JsonPropertyName("application")>]
        Application: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
    }

