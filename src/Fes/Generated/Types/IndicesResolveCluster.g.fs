// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesResolveCluster =

    /// Provides information about each cluster request relevant to doing a cross-cluster search.
    type ResolveClusterInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("connected")>]
        Connected: bool
        [<System.Text.Json.Serialization.JsonPropertyName("skip_unavailable")>]
        SkipUnavailable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("matching_indices")>]
        MatchingIndices: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.ElasticsearchVersionMinInfo option
    }

