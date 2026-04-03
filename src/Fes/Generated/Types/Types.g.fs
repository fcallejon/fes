// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module Types =

    type AcknowledgedResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("acknowledged")>]
        Acknowledged: bool
    }

    /// The aggregation name as returned from the server. Depending whether typed_keys is specified this could come back
    type AggregateName = string

    /// Cause and details about a request failure. This class defines the properties common to all error types.
    type ErrorCause = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("stack_trace")>]
        StackTrace: string option
        [<System.Text.Json.Serialization.JsonPropertyName("caused_by")>]
        CausedBy: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("root_cause")>]
        RootCause: Types.ErrorCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("suppressed")>]
        Suppressed: Types.ErrorCause list option
    }

    type Id = string

    type IndexName = string

    type Integer = float

    type BulkIndexByScrollFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("cause")>]
        Cause: Types.ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.Integer
    }

    type Long = float

    /// A duration. Units can be `nanos`, `micros`, `ms` (milliseconds), `s` (seconds), `m` (minutes), `h` (hours) and
    [<RequireQualifiedAccess>]
    type Duration =
        | String of string
        | Case1 of string
        | Case2 of string

    type DurationValue<'unit> = 'unit

    /// Time unit for milliseconds
    type UnitMillis = Types.Long

    [<RequireQualifiedAccess>]
    type ByteSize =
        | Long of Types.Long
        | String of string

    type BulkStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_operations")>]
        TotalOperations: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("avg_time")>]
        AvgTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_time_in_millis")>]
        AvgTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("avg_size")>]
        AvgSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_size_in_bytes")>]
        AvgSizeInBytes: Types.Long
    }

    [<RequireQualifiedAccess>]
    type Bytes =
        | B
        | Kb
        | Mb
        | Gb
        | Tb
        | Pb

    type Double = float

    type CartesianPoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("x")>]
        X: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("y")>]
        Y: Types.Double
    }

    type CategoryId = Types.Long

    type ChunkRescorer = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesMapping.ChunkRescorerChunkingSettings option
    }

    type ClusterAlias = string

    [<RequireQualifiedAccess>]
    type ClusterSearchStatus =
        | Running
        | Successful
        | Partial
        | Skipped
        | Failed

    type Uint = float

    type ShardFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: Types.ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string option
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool option
    }

    type ShardStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: Types.ShardFailure list option
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Types.Uint option
    }

    type ClusterDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.ClusterSearchStatus
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: Types.ShardFailure list option
    }

    [<RequireQualifiedAccess>]
    type ClusterInfoTarget =
        | All
        | Http
        | Ingest
        | ThreadPool
        | Script

    [<RequireQualifiedAccess>]
    type ClusterInfoTargets =
        | ClusterInfoTarget of Types.ClusterInfoTarget
        | Array of Types.ClusterInfoTarget list

    type ClusterStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("running")>]
        Running: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<Types.ClusterAlias, Types.ClusterDetails> option
    }

    [<RequireQualifiedAccess>]
    type CommonStatsFlag =
        | All
        | Store
        | Indexing
        | Get
        | Search
        | Merge
        | Flush
        | Refresh
        | QueryCache
        | Fielddata
        | Docs
        | Warmer
        | Completion
        | Segments
        | Translog
        | RequestCache
        | Recovery
        | Bulk
        | ShardStats
        | Mappings
        | DenseVector
        | SparseVector

    [<RequireQualifiedAccess>]
    type CommonStatsFlags =
        | CommonStatsFlag of Types.CommonStatsFlag
        | Array of Types.CommonStatsFlag list

    /// Path to field or array of paths. Some API's support wildcards in the path to select multiple fields.
    type Field = string

    type FieldSizeUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
    }

    type CompletionStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Field, Types.FieldSizeUsage> option
    }

    [<RequireQualifiedAccess>]
    type Conflicts =
        | Abort
        | Proceed

    type CoordsGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("top")>]
        Top: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("bottom")>]
        Bottom: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("left")>]
        Left: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("right")>]
        Right: Types.Double
    }

    [<RequireQualifiedAccess>]
    type DFIIndependenceMeasure =
        | Standardized
        | Saturated
        | Chisquared

    [<RequireQualifiedAccess>]
    type DFRAfterEffect =
        | No
        | B
        | L

    [<RequireQualifiedAccess>]
    type DFRBasicModel =
        | Be
        | D
        | G
        | If
        | In
        | Ine
        | P

    type DataStreamName = string

    [<RequireQualifiedAccess>]
    type DataStreamNames =
        | DataStreamName of Types.DataStreamName
        | Array of Types.DataStreamName list

    type DateFormat = string

    type DateMath = string

    type EpochTime<'unit> = 'unit

    /// A date and time, either as a string whose format can depend on the context (defaulting to ISO 8601), or a
    [<RequireQualifiedAccess>]
    type DateTime =
        | String of string
        | EpochTime of Types.EpochTime<Types.UnitMillis>

    type Distance = string

    [<RequireQualifiedAccess>]
    type DistanceUnit =
        | In
        | Ft
        | Yd
        | Mi
        | Nmi
        | Km
        | M
        | Cm
        | Mm

    [<RequireQualifiedAccess>]
    type DiversifyRetrieverTypes =
        | Mmr

    /// A field value.
    [<RequireQualifiedAccess>]
    type FieldValue =
        | Long of Types.Long
        | Double of Types.Double
        | String of string
        | Boolean of bool
        | Null of unit

    type SortResults = Types.FieldValue list

    [<RequireQualifiedAccess>]
    type SortOrder =
        | Asc
        | Desc

    type ScoreSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.SortOrder option
    }

    [<RequireQualifiedAccess>]
    type SortMode =
        | Min
        | Max
        | Sum
        | Avg
        | Median

    [<RequireQualifiedAccess>]
    type GeoDistanceType =
        | Arc
        | Plane

    type NestedSortValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_children")>]
        MaxChildren: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: Types.NestedSortValue option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field
    }

    type GeoDistanceSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: Types.SortMode option
        [<System.Text.Json.Serialization.JsonPropertyName("distance_type")>]
        DistanceType: Types.GeoDistanceType option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("unit")>]
        Unit: Types.DistanceUnit option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: Types.NestedSortValue option
    }

    [<RequireQualifiedAccess>]
    type ScriptSource =
        | String of string
        | SearchRequestBody of GlobalSearchTypes.SearchRequestBody

    [<RequireQualifiedAccess>]
    type ScriptLanguage =
        | Painless
        | Expression
        | Mustache
        | Java
        | Custom of string

    type Script = {
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: Types.ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, string> option
    }

    [<RequireQualifiedAccess>]
    type ScriptSortType =
        | String
        | Number
        | Version

    type ScriptSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.ScriptSortType option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: Types.SortMode option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: Types.NestedSortValue option
    }

    [<RequireQualifiedAccess>]
    type SortOptions =
        | Score of Types.ScoreSort
        | Doc of Types.ScoreSort
        | GeoDistance of Types.GeoDistanceSort
        | Script of Types.ScriptSort

    [<RequireQualifiedAccess>]
    type SortCombinations =
        | Field of Types.Field
        | SortOptions of Types.SortOptions

    [<RequireQualifiedAccess>]
    type Sort =
        | SortCombinations of Types.SortCombinations
        | Array of Types.SortCombinations list

    type Float = float

    type RetrieverBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    type StandardRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: Types.SortResults option
        [<System.Text.Json.Serialization.JsonPropertyName("terminate_after")>]
        TerminateAfter: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: GlobalSearchTypes.FieldCollapse option
    }

    type QueryVector = Types.Float list

    type TextEmbedding = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_text")>]
        ModelText: string
    }

    type LookupQueryVectorBuilder = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
    }

    [<RequireQualifiedAccess>]
    type QueryVectorBuilder =
        | TextEmbedding of Types.TextEmbedding
        | Lookup of Types.LookupQueryVectorBuilder

    type RescoreVector = {
        [<System.Text.Json.Serialization.JsonPropertyName("oversample")>]
        Oversample: Types.Float
    }

    type KnnRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: Types.QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: Types.QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("visit_percentage")>]
        VisitPercentage: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: Types.RescoreVector option
    }

    [<RequireQualifiedAccess>]
    type ScoreNormalizer =
        | None
        | Minmax
        | L2Norm

    type SpecifiedDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
    }

    type DiversifyRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.DiversifyRetrieverTypes
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: Types.QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: Types.QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: Types.Float option
    }

    [<RequireQualifiedAccess>]
    and RetrieverContainer =
        | Standard of Types.StandardRetriever
        | Knn of Types.KnnRetriever
        | Rrf of Types.RRFRetriever
        | TextSimilarityReranker of Types.TextSimilarityReranker
        | Rule of Types.RuleRetriever
        | Rescorer of Types.RescorerRetriever
        | Linear of Types.LinearRetriever
        | Pinned of Types.PinnedRetriever
        | Diversify of Types.DiversifyRetriever

    and RRFRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: Types.RRFRetrieverEntry list
        [<System.Text.Json.Serialization.JsonPropertyName("rank_constant")>]
        RankConstant: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: string list option
    }

    /// Either a direct RetrieverContainer (backward compatible) or an RRFRetrieverComponent with weight.
    [<RequireQualifiedAccess>]
    and RRFRetrieverEntry =
        | RetrieverContainer of Types.RetrieverContainer
        | RRFRetrieverComponent of Types.RRFRetrieverComponent

    /// Wraps a retriever with an optional weight for RRF scoring.
    and RRFRetrieverComponent = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Types.Float option
    }

    and TextSimilarityReranker = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_text")>]
        InferenceText: string
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("chunk_rescorer")>]
        ChunkRescorer: Types.ChunkRescorer option
    }

    and RuleRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_ids")>]
        RulesetIds: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("match_criteria")>]
        MatchCriteria: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Integer option
    }

    and RescorerRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement
    }

    and LinearRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: Types.InnerRetriever list option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: Types.ScoreNormalizer option
    }

    and InnerRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Types.Float
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: Types.ScoreNormalizer
    }

    and PinnedRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.SpecifiedDocument list option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Integer option
    }

    type DocStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("deleted")>]
        Deleted: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: Types.ByteSize option
    }

    /// A date histogram interval. Similar to `Duration` with additional units: `w` (week), `M` (month), `q` (quarter) and
    type DurationLarge = string

    type VersionString = string

    type ElasticsearchVersionInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_date")>]
        BuildDate: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("build_flavor")>]
        BuildFlavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("build_snapshot")>]
        BuildSnapshot: bool
        [<System.Text.Json.Serialization.JsonPropertyName("build_type")>]
        BuildType: string
        [<System.Text.Json.Serialization.JsonPropertyName("lucene_version")>]
        LuceneVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_index_compatibility_version")>]
        MinimumIndexCompatibilityVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_wire_compatibility_version")>]
        MinimumWireCompatibilityVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("number")>]
        Number: string
    }

    /// Reduced (minimal) info ElasticsearchVersion
    type ElasticsearchVersionMinInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_flavor")>]
        BuildFlavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_index_compatibility_version")>]
        MinimumIndexCompatibilityVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_wire_compatibility_version")>]
        MinimumWireCompatibilityVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("number")>]
        Number: string
    }

    /// For empty Class assignments
    type EmptyObject = {
    }

    /// The response returned by Elasticsearch when request execution did not succeed.
    type ErrorResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type ExpandWildcard =
        | All
        | Open
        | Closed
        | Hidden
        | None

    [<RequireQualifiedAccess>]
    type ExpandWildcards =
        | ExpandWildcard of Types.ExpandWildcard
        | Array of Types.ExpandWildcard list

    type FieldMemoryUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Types.Long
    }

    [<RequireQualifiedAccess>]
    type FieldSortNumericType =
        | Long
        | Double
        | Date
        | DateNanos

    type FieldSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: Types.SortMode option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: Types.NestedSortValue option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("unmapped_type")>]
        UnmappedType: TypesMapping.FieldType option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric_type")>]
        NumericType: Types.FieldSortNumericType option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type Name = string

    type GlobalOrdinalFieldStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_time_in_millis")>]
        BuildTimeInMillis: Types.UnitMillis
        [<System.Text.Json.Serialization.JsonPropertyName("build_time")>]
        BuildTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_max_value_count")>]
        ShardMaxValueCount: Types.Long
    }

    type GlobalOrdinalsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_time_in_millis")>]
        BuildTimeInMillis: Types.UnitMillis
        [<System.Text.Json.Serialization.JsonPropertyName("build_time")>]
        BuildTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Name, Types.GlobalOrdinalFieldStats> option
    }

    type FielddataStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Field, Types.FieldMemoryUsage> option
        [<System.Text.Json.Serialization.JsonPropertyName("global_ordinals")>]
        GlobalOrdinals: Types.GlobalOrdinalsStats
    }

    [<RequireQualifiedAccess>]
    type Fields =
        | Field of Types.Field
        | Array of Types.Field list

    type FlushStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("periodic")>]
        Periodic: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    [<RequireQualifiedAccess>]
    type Fuzziness =
        | String of string
        | Integer of Types.Integer

    type LatLonGeoLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("lat")>]
        Lat: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("lon")>]
        Lon: Types.Double
    }

    type GeoHash = string

    type GeoHashLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("geohash")>]
        Geohash: Types.GeoHash
    }

    /// A latitude/longitude as a 2 dimensional point. It can be represented in various ways:
    [<RequireQualifiedAccess>]
    type GeoLocation =
        | LatLonGeoLocation of Types.LatLonGeoLocation
        | GeoHashLocation of Types.GeoHashLocation
        | Array of Types.Double list
        | String of string

    type TopLeftBottomRightGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("top_left")>]
        TopLeft: Types.GeoLocation
        [<System.Text.Json.Serialization.JsonPropertyName("bottom_right")>]
        BottomRight: Types.GeoLocation
    }

    type TopRightBottomLeftGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("top_right")>]
        TopRight: Types.GeoLocation
        [<System.Text.Json.Serialization.JsonPropertyName("bottom_left")>]
        BottomLeft: Types.GeoLocation
    }

    type WktGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("wkt")>]
        Wkt: string
    }

    /// A geo bounding box. It can be represented in various ways:
    [<RequireQualifiedAccess>]
    type GeoBounds =
        | CoordsGeoBounds of Types.CoordsGeoBounds
        | TopLeftBottomRightGeoBounds of Types.TopLeftBottomRightGeoBounds
        | TopRightBottomLeftGeoBounds of Types.TopRightBottomLeftGeoBounds
        | WktGeoBounds of Types.WktGeoBounds

    /// A precision that can be expressed as a geohash length between 1 and 12, or a distance measure like "1km", "10m".
    [<RequireQualifiedAccess>]
    type GeoHashPrecision =
        | Integer of Types.Integer
        | String of string

    /// A map hex cell (H3) reference
    type GeoHexCell = string

    /// A GeoJson GeoLine.
    type GeoLine = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("coordinates")>]
        Coordinates: Types.Double list list
    }

    /// A GeoJson shape, that can also use Elasticsearch's `envelope` extension.
    type GeoShape = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type GeoShapeRelation =
        | Intersects
        | Disjoint
        | Within
        | Contains

    /// A map tile reference, represented as `{zoom}/{x}/{y}`
    type GeoTile = string

    type GeoTilePrecision = Types.Integer

    type GetStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exists_time")>]
        ExistsTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("exists_time_in_millis")>]
        ExistsTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("exists_total")>]
        ExistsTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("missing_time")>]
        MissingTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_time_in_millis")>]
        MissingTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("missing_total")>]
        MissingTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
    }

    type GrokPattern = string

    [<RequireQualifiedAccess>]
    type HealthStatus =
        | Green
        | Yellow
        | Red
        | Unknown
        | Unavailable

    type Host = string

    type HttpHeaders = Map<string, System.Text.Json.JsonElement>

    [<RequireQualifiedAccess>]
    type IBDistribution =
        | Ll
        | Spl

    [<RequireQualifiedAccess>]
    type IBLambda =
        | Df
        | Ttf

    [<RequireQualifiedAccess>]
    type Ids =
        | Id of Types.Id
        | Array of Types.Id list

    type IndexAlias = string

    type IndexPattern = string

    type IndexPatterns = Types.IndexPattern list

    type IndexingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_current")>]
        IndexCurrent: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("delete_current")>]
        DeleteCurrent: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time")>]
        DeleteTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time_in_millis")>]
        DeleteTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("delete_total")>]
        DeleteTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("is_throttled")>]
        IsThrottled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("noop_update_total")>]
        NoopUpdateTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time")>]
        ThrottleTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time_in_millis")>]
        ThrottleTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_time")>]
        IndexTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("index_time_in_millis")>]
        IndexTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_failed")>]
        IndexFailed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("types")>]
        Types: Map<string, Types.IndexingStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("write_load")>]
        WriteLoad: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("recent_write_load")>]
        RecentWriteLoad: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_write_load")>]
        PeakWriteLoad: Types.Double option
    }

    [<RequireQualifiedAccess>]
    type Indices =
        | IndexName of Types.IndexName
        | Array of Types.IndexName list

    /// Controls how to deal with unavailable concrete indices (closed or missing), how wildcard expressions are expanded
    type IndicesOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: Types.ExpandWildcards option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
    }

    type IndicesResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics option
    }

    type SequenceNumber = Types.Long

    /// Only to be used in query and path parameters, as the array form is actually a csv
    [<RequireQualifiedAccess>]
    type Routing =
        | String of string
        | Array of string list

    type InlineGet<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: Types.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tDocument option
    }

    type Ip = string

    type KnnQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: Types.QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: Types.QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("visit_percentage")>]
        VisitPercentage: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: Types.RescoreVector option
    }

    type KnnSearch = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: Types.QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: Types.QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("visit_percentage")>]
        VisitPercentage: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: Types.RescoreVector option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    [<RequireQualifiedAccess>]
    type Level =
        | Cluster
        | Indices
        | Shards

    [<RequireQualifiedAccess>]
    type LifecycleOperationMode =
        | RUNNING
        | STOPPING
        | STOPPED

    type MapboxVectorTiles = byte array

    type MergesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current_docs")>]
        CurrentDocs: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current_size")>]
        CurrentSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("current_size_in_bytes")>]
        CurrentSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_auto_throttle")>]
        TotalAutoThrottle: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_auto_throttle_in_bytes")>]
        TotalAutoThrottleInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_docs")>]
        TotalDocs: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_stopped_time")>]
        TotalStoppedTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_stopped_time_in_millis")>]
        TotalStoppedTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_time")>]
        TotalThrottledTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_time_in_millis")>]
        TotalThrottledTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type Metadata = Map<string, System.Text.Json.JsonElement>

    /// The minimum number of terms that should match as integer, percentage or range
    [<RequireQualifiedAccess>]
    type MinimumShouldMatch =
        | Integer of Types.Integer
        | String of string

    type MultiTermQueryRewrite = string

    [<RequireQualifiedAccess>]
    type Names =
        | Name of Types.Name
        | Array of Types.Name list

    type Namespace = string

    type NodeId = string

    type NodeName = string

    type TransportAddress = string

    type NodeAttributes = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.NodeName
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
    }

    [<RequireQualifiedAccess>]
    type NodeIds =
        | NodeId of Types.NodeId
        | Array of Types.NodeId list

    [<RequireQualifiedAccess>]
    type NodeRole =
        | Master
        | Data
        | DataCold
        | DataContent
        | DataFrozen
        | DataHot
        | DataWarm
        | Client
        | Ingest
        | Ml
        | VotingOnly
        | Transform
        | RemoteClusterClient
        | CoordinatingOnly

    type NodeRoles = Types.NodeRole list

    type RelocationFailureInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("failed_attempts")>]
        FailedAttempts: Types.Integer
    }

    type NodeShard = {
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: IndicesStats.ShardRoutingState
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeName option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_id")>]
        AllocationId: Map<string, Types.Id> option
        [<System.Text.Json.Serialization.JsonPropertyName("recovery_source")>]
        RecoverySource: Map<string, Types.Id> option
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_info")>]
        UnassignedInfo: ClusterAllocationExplain.UnassignedInformation option
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_node")>]
        RelocatingNode: Types.NodeId option option
        [<System.Text.Json.Serialization.JsonPropertyName("relocation_failure_info")>]
        RelocationFailureInfo: Types.RelocationFailureInfo option
    }

    /// Contains statistics about the number of nodes selected by the request.
    type NodeStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: Types.ErrorCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type NodeStatsLevel =
        | Node
        | Indices
        | Shards

    [<RequireQualifiedAccess>]
    type Normalization =
        | No
        | H1
        | H2
        | H3
        | Z

    [<RequireQualifiedAccess>]
    type OpType =
        | Index
        | Create

    type Password = string

    [<RequireQualifiedAccess>]
    type Percentage =
        | String of string
        | Float of Types.Float

    type PipelineName = string

    type PluginStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("classname")>]
        Classname: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("elasticsearch_version")>]
        ElasticsearchVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("extended_plugins")>]
        ExtendedPlugins: string list
        [<System.Text.Json.Serialization.JsonPropertyName("has_native_controller")>]
        HasNativeController: bool
        [<System.Text.Json.Serialization.JsonPropertyName("java_version")>]
        JavaVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("licensed")>]
        Licensed: bool
    }

    type ProjectRouting = string

    type PropertyName = string

    type QueryCacheStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_count")>]
        CacheCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("hit_count")>]
        HitCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("miss_count")>]
        MissCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: Types.Long
    }

    type RankBase = {
    }

    type RrfRank = {
        [<System.Text.Json.Serialization.JsonPropertyName("rank_constant")>]
        RankConstant: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Types.Long option
    }

    [<RequireQualifiedAccess>]
    type RankContainer =
        | Rrf of Types.RrfRank

    type RecoveryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_as_source")>]
        CurrentAsSource: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current_as_target")>]
        CurrentAsTarget: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time")>]
        ThrottleTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time_in_millis")>]
        ThrottleTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    [<RequireQualifiedAccess>]
    type Refresh =
        | True
        | False
        | WaitFor

    type RefreshStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("external_total")>]
        ExternalTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("external_total_time_in_millis")>]
        ExternalTotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("listeners")>]
        Listeners: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type Retries = {
        [<System.Text.Json.Serialization.JsonPropertyName("bulk")>]
        Bulk: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: Types.Long
    }

    type ReindexStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("slice_id")>]
        SliceId: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("batches")>]
        Batches: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("created")>]
        Created: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("deleted")>]
        Deleted: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("noops")>]
        Noops: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("requests_per_second")>]
        RequestsPerSecond: Types.Float
        [<System.Text.Json.Serialization.JsonPropertyName("retries")>]
        Retries: Types.Retries
        [<System.Text.Json.Serialization.JsonPropertyName("throttled")>]
        Throttled: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_millis")>]
        ThrottledMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_until")>]
        ThrottledUntil: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_until_millis")>]
        ThrottledUntilMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("updated")>]
        Updated: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("version_conflicts")>]
        VersionConflicts: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("cancelled")>]
        Cancelled: string option
    }

    type RelationName = string

    type RequestBase = {
    }

    type RequestCacheStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("hit_count")>]
        HitCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("miss_count")>]
        MissCount: Types.Long
    }

    [<RequireQualifiedAccess>]
    type Result =
        | Created
        | Updated
        | Deleted
        | NotFound
        | Noop

    /// A scalar value.
    [<RequireQualifiedAccess>]
    type ScalarValue =
        | Long of Types.Long
        | Double of Types.Double
        | String of string
        | Boolean of bool
        | Null of unit

    type ScriptField = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_failure")>]
        IgnoreFailure: bool option
    }

    type ScriptTransform = {
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
    }

    type ScrollId = string

    [<RequireQualifiedAccess>]
    type ScrollIds =
        | ScrollId of Types.ScrollId
        | Array of Types.ScrollId list

    type SearchStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_current")>]
        FetchCurrent: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_time")>]
        FetchTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_time_in_millis")>]
        FetchTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_total")>]
        FetchTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("open_contexts")>]
        OpenContexts: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("query_current")>]
        QueryCurrent: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("query_time")>]
        QueryTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("query_time_in_millis")>]
        QueryTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("query_total")>]
        QueryTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_current")>]
        ScrollCurrent: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_time")>]
        ScrollTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_time_in_millis")>]
        ScrollTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_total")>]
        ScrollTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_current")>]
        SuggestCurrent: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_time")>]
        SuggestTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_time_in_millis")>]
        SuggestTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_total")>]
        SuggestTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("recent_search_load")>]
        RecentSearchLoad: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: Map<string, Types.SearchStats> option
    }

    type SearchTransform = {
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.SearchInputRequestDefinition
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Types.Duration
    }

    [<RequireQualifiedAccess>]
    type SearchType =
        | QueryThenFetch
        | DfsQueryThenFetch

    type SegmentsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values_memory")>]
        DocValuesMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values_memory_in_bytes")>]
        DocValuesMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("file_sizes")>]
        FileSizes: Map<string, IndicesStats.ShardFileSizeInfo>
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_bit_set")>]
        FixedBitSet: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_bit_set_memory_in_bytes")>]
        FixedBitSetMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_writer_memory")>]
        IndexWriterMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("index_writer_memory_in_bytes")>]
        IndexWriterMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_unsafe_auto_id_timestamp")>]
        MaxUnsafeAutoIdTimestamp: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")>]
        MemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("norms_memory")>]
        NormsMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("norms_memory_in_bytes")>]
        NormsMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("points_memory")>]
        PointsMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("points_memory_in_bytes")>]
        PointsMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields_memory_in_bytes")>]
        StoredFieldsMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields_memory")>]
        StoredFieldsMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("terms_memory_in_bytes")>]
        TermsMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("terms_memory")>]
        TermsMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors_memory")>]
        TermVectorsMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors_memory_in_bytes")>]
        TermVectorsMemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("version_map_memory")>]
        VersionMapMemory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("version_map_memory_in_bytes")>]
        VersionMapMemoryInBytes: Types.Long
    }

    type Service = string

    type ShardsOperationResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics option
    }

    type SlicedScroll = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type SlicesCalculation =
        | Auto

    /// Slices configuration used to parallelize a process.
    [<RequireQualifiedAccess>]
    type Slices =
        | Integer of Types.Integer
        | SlicesCalculation of Types.SlicesCalculation

    type StoreStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reserved")>]
        Reserved: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("reserved_in_bytes")>]
        ReservedInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_data_set_size")>]
        TotalDataSetSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_data_set_size_in_bytes")>]
        TotalDataSetSizeInBytes: Types.Long option
    }

    type StoredScript = {
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: Types.ScriptLanguage
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource
    }

    type StreamResult = byte array

    [<RequireQualifiedAccess>]
    type SuggestMode =
        | Missing
        | Popular
        | Always

    /// The suggestion name as returned from the server. Depending whether typed_keys is specified this could come back
    type SuggestionName = string

    type TaskFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("task_id")>]
        TaskId: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: Types.ErrorCause
    }

    type TaskId = string

    [<RequireQualifiedAccess>]
    type ThreadType =
        | Cpu
        | Wait
        | Block
        | Gpu
        | Mem

    /// Time of day, expressed as HH:MM:SS
    type TimeOfDay = string

    [<RequireQualifiedAccess>]
    type TimeUnit =
        | Nanos
        | Micros
        | Ms
        | S
        | M
        | H
        | D

    type TimeZone = string

    type TokenPruningConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokens_freq_ratio_threshold")>]
        TokensFreqRatioThreshold: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokens_weight_threshold")>]
        TokensWeightThreshold: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("only_score_pruned_tokens")>]
        OnlyScorePrunedTokens: bool option
    }

    [<RequireQualifiedAccess>]
    type TransformContainer =
        | Chain of Types.TransformContainer list
        | Script of Types.ScriptTransform
        | Search of Types.SearchTransform

    type TranslogStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("earliest_last_modified_age")>]
        EarliestLastModifiedAge: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("operations")>]
        Operations: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("uncommitted_operations")>]
        UncommittedOperations: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("uncommitted_size")>]
        UncommittedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uncommitted_size_in_bytes")>]
        UncommittedSizeInBytes: Types.Long
    }

    /// Time unit for fractional milliseconds
    type UnitFloatMillis = Types.Double

    /// Time unit for nanoseconds
    type UnitNanos = Types.Long

    /// Time unit for seconds
    type UnitSeconds = Types.Long

    type Username = string

    type Uuid = string

    type VersionNumber = Types.Long

    [<RequireQualifiedAccess>]
    type VersionType =
        | Internal
        | External
        | ExternalGte

    [<RequireQualifiedAccess>]
    type WaitForActiveShardOptions =
        | All
        | IndexSetting

    [<RequireQualifiedAccess>]
    type WaitForActiveShards =
        | Integer of Types.Integer
        | WaitForActiveShardOptions of Types.WaitForActiveShardOptions

    [<RequireQualifiedAccess>]
    type WaitForEvents =
        | Immediate
        | Urgent
        | High
        | Normal
        | Low
        | Languid

    type WarmerStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type WriteResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: Types.Result
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: Types.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: GlobalBulk.FailureStoreStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("forced_refresh")>]
        ForcedRefresh: bool option
    }

    type Byte = float

    type Short = float

    type Ulong = float

