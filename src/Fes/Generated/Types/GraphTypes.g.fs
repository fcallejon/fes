// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GraphTypes =

    type Connection = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("target")>]
        Target: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Types.Double
    }

    type SampleDiversity = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs_per_value")>]
        MaxDocsPerValue: Types.Integer
    }

    type ExploreControls = {
        [<System.Text.Json.Serialization.JsonPropertyName("sample_diversity")>]
        SampleDiversity: GraphTypes.SampleDiversity option
        [<System.Text.Json.Serialization.JsonPropertyName("sample_size")>]
        SampleSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("use_significance")>]
        UseSignificance: bool
    }

    type VertexInclude = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("term")>]
        Term: string
    }

    type VertexDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: GraphTypes.VertexInclude list option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
    }

    type Hop = {
        [<System.Text.Json.Serialization.JsonPropertyName("connections")>]
        Connections: GraphTypes.Hop option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("vertices")>]
        Vertices: GraphTypes.VertexDefinition list
    }

    type Vertex = {
        [<System.Text.Json.Serialization.JsonPropertyName("depth")>]
        Depth: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("term")>]
        Term: string
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Types.Double
    }

