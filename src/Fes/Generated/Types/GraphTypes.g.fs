// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GraphTypes =

    type Connection = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("target")>]
        Target: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: CoreTypes.Double
    }

    type SampleDiversity = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs_per_value")>]
        MaxDocsPerValue: CoreTypes.Integer
    }

    type ExploreControls = {
        [<System.Text.Json.Serialization.JsonPropertyName("sample_diversity")>]
        SampleDiversity: SampleDiversity option
        [<System.Text.Json.Serialization.JsonPropertyName("sample_size")>]
        SampleSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("use_significance")>]
        UseSignificance: bool
    }

    type VertexInclude = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("term")>]
        Term: string
    }

    type VertexDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: VertexInclude list option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
    }

    type Hop = {
        [<System.Text.Json.Serialization.JsonPropertyName("connections")>]
        Connections: Hop option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("vertices")>]
        Vertices: VertexDefinition list
    }

    type Vertex = {
        [<System.Text.Json.Serialization.JsonPropertyName("depth")>]
        Depth: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("term")>]
        Term: string
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: CoreTypes.Double
    }

