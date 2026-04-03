// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatPlugins =

    type PluginsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("component")>]
        Component: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

