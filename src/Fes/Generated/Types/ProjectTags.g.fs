// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ProjectTags =

    type Tags = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("_alias")>]
        Alias: string
        [<System.Text.Json.Serialization.JsonPropertyName("_type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("_organisation")>]
        Organisation: string
    }

    type ProjectTags = {
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: Map<string, Tags>
        [<System.Text.Json.Serialization.JsonPropertyName("linked_projects")>]
        LinkedProjects: Map<string, Tags> option
    }

