// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatSegments =

    type SegmentsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prirep")>]
        Prirep: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("segment")>]
        Segment: string option
        [<System.Text.Json.Serialization.JsonPropertyName("generation")>]
        Generation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs.count")>]
        DocsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs.deleted")>]
        DocsDeleted: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size.memory")>]
        SizeMemory: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("committed")>]
        Committed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable")>]
        Searchable: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("compound")>]
        Compound: string option
    }

