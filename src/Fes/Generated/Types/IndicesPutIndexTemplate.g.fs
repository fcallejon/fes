// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesPutIndexTemplate =

    type IndexTemplateMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<Types.IndexName, IndicesTypes.Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptionsTemplate option option
    }

