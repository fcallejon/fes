// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesSegments =

    type ShardSegmentRouting = {
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
    }

    type Segment = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("committed")>]
        Committed: bool
        [<System.Text.Json.Serialization.JsonPropertyName("compound")>]
        Compound: bool
        [<System.Text.Json.Serialization.JsonPropertyName("deleted_docs")>]
        DeletedDocs: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("generation")>]
        Generation: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: bool
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("num_docs")>]
        NumDocs: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
    }

    type ShardsSegment = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_committed_segments")>]
        NumCommittedSegments: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: ShardSegmentRouting
        [<System.Text.Json.Serialization.JsonPropertyName("num_search_segments")>]
        NumSearchSegments: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: Map<string, Segment>
    }

    type IndexSegment = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, System.Text.Json.JsonElement>
    }

