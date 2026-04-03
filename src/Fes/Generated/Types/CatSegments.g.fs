// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatSegments =

    type SegmentsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prirep")>]
        Prirep: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("segment")>]
        Segment: string option
        [<System.Text.Json.Serialization.JsonPropertyName("generation")>]
        Generation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs.count")>]
        DocsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs.deleted")>]
        DocsDeleted: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size.memory")>]
        SizeMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("committed")>]
        Committed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable")>]
        Searchable: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("compound")>]
        Compound: string option
    }

