// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module IndicesOperations =

    type IndicesAddBlockRequest = {
        Index: Types.Indices
        Block: Types.IndicesBlockOptions
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesAddBlockRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_block/{req.Block}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesAddBlockResponse = System.Text.Json.JsonElement

    type IndicesAddBlockRequestBuilder() =
        member _.Yield(_: unit) : IndicesAddBlockRequest =
            {
                Index = Unchecked.defaultof<_>
                Block = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesAddBlockRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("block")>]
        member _.Block(state: IndicesAddBlockRequest, value: Types.IndicesBlockOptions) =
            { state with Block = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesAddBlockRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesAddBlockRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesAddBlockRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesAddBlockRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesAddBlockRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesAddBlockRequest = IndicesAddBlockRequestBuilder()

    module AddBlock =
        let withAllowNoIndices (value: bool) (req: IndicesAddBlockRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesAddBlockRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesAddBlockRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesAddBlockRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesAddBlockRequest) =
            { req with Timeout = Some value }

    type IndicesAnalyzeRequest = {
        Index: Types.IndexName
        Index: Types.IndexName option
        Analyzer: string option
        Attributes: string list option
        CharFilter: Types.CharFilter list option
        Explain: bool option
        Field: Types.Field option
        Filter: Types.TokenFilter list option
        Normalizer: string option
        Text: Types.TextToAnalyze option
        Tokenizer: Types.Tokenizer option
    }

        with
        static member ToRequest(req: IndicesAnalyzeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_analyze"
                let queryParams =
                    [
                        req.Index |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesAnalyzeResponse = System.Text.Json.JsonElement

    type IndicesAnalyzeRequestBuilder() =
        member _.Yield(_: unit) : IndicesAnalyzeRequest =
            {
                Index = Unchecked.defaultof<_>
                Index = None
                Analyzer = None
                Attributes = None
                CharFilter = None
                Explain = None
                Field = None
                Filter = None
                Normalizer = None
                Text = None
                Tokenizer = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesAnalyzeRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesAnalyzeRequest, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IndicesAnalyzeRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: IndicesAnalyzeRequest, value: string list) =
            { state with Attributes = Some value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: IndicesAnalyzeRequest, value: Types.CharFilter list) =
            { state with CharFilter = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: IndicesAnalyzeRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: IndicesAnalyzeRequest, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: IndicesAnalyzeRequest, value: Types.TokenFilter list) =
            { state with Filter = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: IndicesAnalyzeRequest, value: string) =
            { state with Normalizer = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: IndicesAnalyzeRequest, value: Types.TextToAnalyze) =
            { state with Text = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: IndicesAnalyzeRequest, value: Types.Tokenizer) =
            { state with Tokenizer = Some value }

    let indicesAnalyzeRequest = IndicesAnalyzeRequestBuilder()

    module Analyze =
        let withIndex (value: Types.IndexName) (req: IndicesAnalyzeRequest) =
            { req with Index = Some value }
        let withAnalyzer (value: string) (req: IndicesAnalyzeRequest) =
            { req with Analyzer = Some value }
        let withAttributes (value: string list) (req: IndicesAnalyzeRequest) =
            { req with Attributes = Some value }
        let withCharFilter (value: Types.CharFilter list) (req: IndicesAnalyzeRequest) =
            { req with CharFilter = Some value }
        let withExplain (value: bool) (req: IndicesAnalyzeRequest) =
            { req with Explain = Some value }
        let withField (value: Types.Field) (req: IndicesAnalyzeRequest) =
            { req with Field = Some value }
        let withFilter (value: Types.TokenFilter list) (req: IndicesAnalyzeRequest) =
            { req with Filter = Some value }
        let withNormalizer (value: string) (req: IndicesAnalyzeRequest) =
            { req with Normalizer = Some value }
        let withText (value: Types.TextToAnalyze) (req: IndicesAnalyzeRequest) =
            { req with Text = Some value }
        let withTokenizer (value: Types.Tokenizer) (req: IndicesAnalyzeRequest) =
            { req with Tokenizer = Some value }

    type IndicesCancelMigrateReindexRequest = {
        Index: Types.Indices
    }

        with
        static member ToRequest(req: IndicesCancelMigrateReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/reindex/{req.Index}/_cancel"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesCancelMigrateReindexResponse = Types.AcknowledgedResponseBase

    type IndicesCancelMigrateReindexRequestBuilder() =
        member _.Yield(_: unit) : IndicesCancelMigrateReindexRequest =
            {
                Index = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCancelMigrateReindexRequest, value: Types.Indices) =
            { state with Index = value }

    let indicesCancelMigrateReindexRequest = IndicesCancelMigrateReindexRequestBuilder()

    type IndicesClearCacheRequest = {
        Index: Types.Indices
        Index: Types.Indices option
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        Fielddata: bool option
        Fields: Types.Fields option
        IgnoreUnavailable: bool option
        Query: bool option
        Request: bool option
    }

        with
        static member ToRequest(req: IndicesClearCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_cache/clear"
                let queryParams =
                    [
                        req.Index |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.Fielddata |> Option.map (fun v -> "fielddata", Fes.Http.toQueryValue v)
                        req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Query |> Option.map (fun v -> "query", Fes.Http.toQueryValue v)
                        req.Request |> Option.map (fun v -> "request", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesClearCacheResponse = Types.ShardsOperationResponseBase

    type IndicesClearCacheRequestBuilder() =
        member _.Yield(_: unit) : IndicesClearCacheRequest =
            {
                Index = Unchecked.defaultof<_>
                Index = None
                AllowNoIndices = None
                ExpandWildcards = None
                Fielddata = None
                Fields = None
                IgnoreUnavailable = None
                Query = None
                Request = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesClearCacheRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesClearCacheRequest, value: Types.Indices) =
            { state with Index = Some value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesClearCacheRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesClearCacheRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: IndicesClearCacheRequest, value: bool) =
            { state with Fielddata = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesClearCacheRequest, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesClearCacheRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: IndicesClearCacheRequest, value: bool) =
            { state with Query = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: IndicesClearCacheRequest, value: bool) =
            { state with Request = Some value }

    let indicesClearCacheRequest = IndicesClearCacheRequestBuilder()

    module ClearCache =
        let withIndex (value: Types.Indices) (req: IndicesClearCacheRequest) =
            { req with Index = Some value }
        let withAllowNoIndices (value: bool) (req: IndicesClearCacheRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesClearCacheRequest) =
            { req with ExpandWildcards = Some value }
        let withFielddata (value: bool) (req: IndicesClearCacheRequest) =
            { req with Fielddata = Some value }
        let withFields (value: Types.Fields) (req: IndicesClearCacheRequest) =
            { req with Fields = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesClearCacheRequest) =
            { req with IgnoreUnavailable = Some value }
        let withQuery (value: bool) (req: IndicesClearCacheRequest) =
            { req with Query = Some value }
        let withRequest (value: bool) (req: IndicesClearCacheRequest) =
            { req with Request = Some value }

    type IndicesCloneRequest = {
        Index: Types.IndexName
        Target: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        Aliases: Map<Types.IndexName, Types.Alias> option
        Settings: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: IndicesCloneRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_clone/{req.Target}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesCloneResponse = System.Text.Json.JsonElement

    type IndicesCloneRequestBuilder() =
        member _.Yield(_: unit) : IndicesCloneRequest =
            {
                Index = Unchecked.defaultof<_>
                Target = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
                Aliases = None
                Settings = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCloneRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("target")>]
        member _.Target(state: IndicesCloneRequest, value: Types.Name) =
            { state with Target = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesCloneRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCloneRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesCloneRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesCloneRequest, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesCloneRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Settings = Some value }

    let indicesCloneRequest = IndicesCloneRequestBuilder()

    module Clone =
        let withMasterTimeout (value: Types.Duration) (req: IndicesCloneRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesCloneRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesCloneRequest) =
            { req with WaitForActiveShards = Some value }
        let withAliases (value: Map<Types.IndexName, Types.Alias>) (req: IndicesCloneRequest) =
            { req with Aliases = Some value }
        let withSettings (value: Map<string, System.Text.Json.JsonElement>) (req: IndicesCloneRequest) =
            { req with Settings = Some value }

    type IndicesCloseRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
    }

        with
        static member ToRequest(req: IndicesCloseRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_close"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesCloseResponse = System.Text.Json.JsonElement

    type IndicesCloseRequestBuilder() =
        member _.Yield(_: unit) : IndicesCloseRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCloseRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesCloseRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesCloseRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesCloseRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesCloseRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCloseRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesCloseRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

    let indicesCloseRequest = IndicesCloseRequestBuilder()

    module Close =
        let withAllowNoIndices (value: bool) (req: IndicesCloseRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesCloseRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesCloseRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesCloseRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesCloseRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesCloseRequest) =
            { req with WaitForActiveShards = Some value }

    type IndicesCreateRequest = {
        Index: Types.IndexName
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        Aliases: Map<Types.Name, Types.Alias> option
        Mappings: Types.TypeMapping option
        Settings: Types.IndexSettings option
    }

        with
        static member ToRequest(req: IndicesCreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesCreateResponse = System.Text.Json.JsonElement

    type IndicesCreateRequestBuilder() =
        member _.Yield(_: unit) : IndicesCreateRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
                Aliases = None
                Mappings = None
                Settings = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCreateRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesCreateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCreateRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesCreateRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesCreateRequest, value: Map<Types.Name, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndicesCreateRequest, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesCreateRequest, value: Types.IndexSettings) =
            { state with Settings = Some value }

    let indicesCreateRequest = IndicesCreateRequestBuilder()

    module Create =
        let withMasterTimeout (value: Types.Duration) (req: IndicesCreateRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesCreateRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesCreateRequest) =
            { req with WaitForActiveShards = Some value }
        let withAliases (value: Map<Types.Name, Types.Alias>) (req: IndicesCreateRequest) =
            { req with Aliases = Some value }
        let withMappings (value: Types.TypeMapping) (req: IndicesCreateRequest) =
            { req with Mappings = Some value }
        let withSettings (value: Types.IndexSettings) (req: IndicesCreateRequest) =
            { req with Settings = Some value }

    type IndicesCreateDataStreamRequest = {
        Name: Types.DataStreamName
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesCreateDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesCreateDataStreamResponse = Types.AcknowledgedResponseBase

    type IndicesCreateDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesCreateDataStreamRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesCreateDataStreamRequest, value: Types.DataStreamName) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesCreateDataStreamRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCreateDataStreamRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesCreateDataStreamRequest = IndicesCreateDataStreamRequestBuilder()

    module CreateDataStream =
        let withMasterTimeout (value: Types.Duration) (req: IndicesCreateDataStreamRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesCreateDataStreamRequest) =
            { req with Timeout = Some value }

    type IndicesCreateFromRequest = {
        Source: Types.IndexName
        Dest: Types.IndexName
        Document: obj
    }

        with
        static member ToRequest(req: IndicesCreateFromRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_create_from/{req.Source}/{req.Dest}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesCreateFromResponse = System.Text.Json.JsonElement

    type IndicesCreateFromRequestBuilder() =
        member _.Yield(_: unit) : IndicesCreateFromRequest =
            {
                Source = Unchecked.defaultof<_>
                Dest = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("source")>]
        member _.Source(state: IndicesCreateFromRequest, value: Types.IndexName) =
            { state with Source = value }

        [<CustomOperation("dest")>]
        member _.Dest(state: IndicesCreateFromRequest, value: Types.IndexName) =
            { state with Dest = value }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesCreateFromRequest, value) =
            { state with Document = value }

    let indicesCreateFromRequest = IndicesCreateFromRequestBuilder()

    type IndicesDataStreamsStatsRequest = {
        Name: Types.Indices
        ExpandWildcards: Types.ExpandWildcards option
    }

        with
        static member ToRequest(req: IndicesDataStreamsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_stats"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDataStreamsStatsResponse = System.Text.Json.JsonElement

    type IndicesDataStreamsStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesDataStreamsStatsRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDataStreamsStatsRequest, value: Types.Indices) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesDataStreamsStatsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

    let indicesDataStreamsStatsRequest = IndicesDataStreamsStatsRequestBuilder()

    module DataStreamsStats =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesDataStreamsStatsRequest) =
            { req with ExpandWildcards = Some value }

    type IndicesDeleteRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteResponse = Types.IndicesResponseBase

    type IndicesDeleteRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDeleteRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesDeleteRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesDeleteRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesDeleteRequest = IndicesDeleteRequestBuilder()

    module Delete =
        let withAllowNoIndices (value: bool) (req: IndicesDeleteRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesDeleteRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesDeleteRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesDeleteRequest) =
            { req with Timeout = Some value }

    type IndicesDeleteAliasRequest = {
        Index: Types.Indices
        Name: Types.Names
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesDeleteAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_alias/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteAliasResponse = Types.IndicesAliasesResponseBody

    type IndicesDeleteAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteAliasRequest =
            {
                Index = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDeleteAliasRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteAliasRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteAliasRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteAliasRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesDeleteAliasRequest = IndicesDeleteAliasRequestBuilder()

    module DeleteAlias =
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteAliasRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesDeleteAliasRequest) =
            { req with Timeout = Some value }

    type IndicesDeleteDataLifecycleRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesDeleteDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_lifecycle"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteDataLifecycleResponse = Types.AcknowledgedResponseBase

    type IndicesDeleteDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteDataLifecycleRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteDataLifecycleRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteDataLifecycleRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteDataLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteDataLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesDeleteDataLifecycleRequest = IndicesDeleteDataLifecycleRequestBuilder()

    module DeleteDataLifecycle =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesDeleteDataLifecycleRequest) =
            { req with ExpandWildcards = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteDataLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesDeleteDataLifecycleRequest) =
            { req with Timeout = Some value }

    type IndicesDeleteDataStreamRequest = {
        Name: Types.DataStreamNames
        MasterTimeout: Types.Duration option
        ExpandWildcards: Types.ExpandWildcards option
    }

        with
        static member ToRequest(req: IndicesDeleteDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteDataStreamResponse = Types.AcknowledgedResponseBase

    type IndicesDeleteDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteDataStreamRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                ExpandWildcards = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteDataStreamRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteDataStreamRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteDataStreamRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

    let indicesDeleteDataStreamRequest = IndicesDeleteDataStreamRequestBuilder()

    module DeleteDataStream =
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteDataStreamRequest) =
            { req with MasterTimeout = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesDeleteDataStreamRequest) =
            { req with ExpandWildcards = Some value }

    type IndicesDeleteDataStreamOptionsRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesDeleteDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_options"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteDataStreamOptionsResponse = Types.AcknowledgedResponseBase

    type IndicesDeleteDataStreamOptionsRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteDataStreamOptionsRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteDataStreamOptionsRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteDataStreamOptionsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteDataStreamOptionsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteDataStreamOptionsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesDeleteDataStreamOptionsRequest = IndicesDeleteDataStreamOptionsRequestBuilder()

    module DeleteDataStreamOptions =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesDeleteDataStreamOptionsRequest) =
            { req with ExpandWildcards = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteDataStreamOptionsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesDeleteDataStreamOptionsRequest) =
            { req with Timeout = Some value }

    type IndicesDeleteIndexTemplateRequest = {
        Name: Types.Names
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesDeleteIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteIndexTemplateResponse = Types.AcknowledgedResponseBase

    type IndicesDeleteIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteIndexTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteIndexTemplateRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteIndexTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteIndexTemplateRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesDeleteIndexTemplateRequest = IndicesDeleteIndexTemplateRequestBuilder()

    module DeleteIndexTemplate =
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteIndexTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesDeleteIndexTemplateRequest) =
            { req with Timeout = Some value }

    type IndicesDeleteTemplateRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesDeleteTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDeleteTemplateResponse = Types.AcknowledgedResponseBase

    type IndicesDeleteTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesDeleteTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteTemplateRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesDeleteTemplateRequest = IndicesDeleteTemplateRequestBuilder()

    module DeleteTemplate =
        let withMasterTimeout (value: Types.Duration) (req: IndicesDeleteTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesDeleteTemplateRequest) =
            { req with Timeout = Some value }

    type IndicesDiskUsageRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        Flush: bool option
        IgnoreUnavailable: bool option
        RunExpensiveTasks: bool option
    }

        with
        static member ToRequest(req: IndicesDiskUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_disk_usage"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.Flush |> Option.map (fun v -> "flush", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.RunExpensiveTasks |> Option.map (fun v -> "run_expensive_tasks", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDiskUsageResponse = System.Text.Json.JsonElement

    type IndicesDiskUsageRequestBuilder() =
        member _.Yield(_: unit) : IndicesDiskUsageRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                Flush = None
                IgnoreUnavailable = None
                RunExpensiveTasks = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDiskUsageRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesDiskUsageRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesDiskUsageRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flush")>]
        member _.Flush(state: IndicesDiskUsageRequest, value: bool) =
            { state with Flush = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesDiskUsageRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("runExpensiveTasks")>]
        member _.RunExpensiveTasks(state: IndicesDiskUsageRequest, value: bool) =
            { state with RunExpensiveTasks = Some value }

    let indicesDiskUsageRequest = IndicesDiskUsageRequestBuilder()

    module DiskUsage =
        let withAllowNoIndices (value: bool) (req: IndicesDiskUsageRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesDiskUsageRequest) =
            { req with ExpandWildcards = Some value }
        let withFlush (value: bool) (req: IndicesDiskUsageRequest) =
            { req with Flush = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesDiskUsageRequest) =
            { req with IgnoreUnavailable = Some value }
        let withRunExpensiveTasks (value: bool) (req: IndicesDiskUsageRequest) =
            { req with RunExpensiveTasks = Some value }

    type IndicesDownsampleRequest = {
        Index: Types.IndexName
        TargetIndex: Types.IndexName
        Document: obj
    }

        with
        static member ToRequest(req: IndicesDownsampleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_downsample/{req.TargetIndex}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesDownsampleResponse = System.Text.Json.JsonElement

    type IndicesDownsampleRequestBuilder() =
        member _.Yield(_: unit) : IndicesDownsampleRequest =
            {
                Index = Unchecked.defaultof<_>
                TargetIndex = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDownsampleRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("targetIndex")>]
        member _.TargetIndex(state: IndicesDownsampleRequest, value: Types.IndexName) =
            { state with TargetIndex = value }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesDownsampleRequest, value) =
            { state with Document = value }

    let indicesDownsampleRequest = IndicesDownsampleRequestBuilder()

    type IndicesExistsRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
        Local: bool option
    }

        with
        static member ToRequest(req: IndicesExistsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesExistsResponse = unit

    type IndicesExistsRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                FlatSettings = None
                IgnoreUnavailable = None
                IncludeDefaults = None
                Local = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesExistsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesExistsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesExistsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesExistsRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesExistsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesExistsRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesExistsRequest, value: bool) =
            { state with Local = Some value }

    let indicesExistsRequest = IndicesExistsRequestBuilder()

    module Exists =
        let withAllowNoIndices (value: bool) (req: IndicesExistsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesExistsRequest) =
            { req with ExpandWildcards = Some value }
        let withFlatSettings (value: bool) (req: IndicesExistsRequest) =
            { req with FlatSettings = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesExistsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesExistsRequest) =
            { req with IncludeDefaults = Some value }
        let withLocal (value: bool) (req: IndicesExistsRequest) =
            { req with Local = Some value }

    type IndicesExistsAliasRequest = {
        Name: Types.Names
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesExistsAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_alias/{req.Name}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesExistsAliasResponse = unit

    type IndicesExistsAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsAliasRequest =
            {
                Name = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesExistsAliasRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesExistsAliasRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesExistsAliasRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesExistsAliasRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesExistsAliasRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesExistsAliasRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesExistsAliasRequest = IndicesExistsAliasRequestBuilder()

    module ExistsAlias =
        let withAllowNoIndices (value: bool) (req: IndicesExistsAliasRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesExistsAliasRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesExistsAliasRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesExistsAliasRequest) =
            { req with MasterTimeout = Some value }

    type IndicesExistsIndexTemplateRequest = {
        Name: Types.Name
        Local: bool option
        FlatSettings: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesExistsIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{req.Name}"
                let queryParams =
                    [
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesExistsIndexTemplateResponse = unit

    type IndicesExistsIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsIndexTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Local = None
                FlatSettings = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesExistsIndexTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesExistsIndexTemplateRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesExistsIndexTemplateRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesExistsIndexTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesExistsIndexTemplateRequest = IndicesExistsIndexTemplateRequestBuilder()

    module ExistsIndexTemplate =
        let withLocal (value: bool) (req: IndicesExistsIndexTemplateRequest) =
            { req with Local = Some value }
        let withFlatSettings (value: bool) (req: IndicesExistsIndexTemplateRequest) =
            { req with FlatSettings = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesExistsIndexTemplateRequest) =
            { req with MasterTimeout = Some value }

    type IndicesExistsTemplateRequest = {
        Name: Types.Names
        FlatSettings: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesExistsTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{req.Name}"
                let queryParams =
                    [
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesExistsTemplateResponse = unit

    type IndicesExistsTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesExistsTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                FlatSettings = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesExistsTemplateRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesExistsTemplateRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesExistsTemplateRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesExistsTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesExistsTemplateRequest = IndicesExistsTemplateRequestBuilder()

    module ExistsTemplate =
        let withFlatSettings (value: bool) (req: IndicesExistsTemplateRequest) =
            { req with FlatSettings = Some value }
        let withLocal (value: bool) (req: IndicesExistsTemplateRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesExistsTemplateRequest) =
            { req with MasterTimeout = Some value }

    type IndicesExplainDataLifecycleRequest = {
        Index: Types.Indices
        IncludeDefaults: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesExplainDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_lifecycle/explain"
                let queryParams =
                    [
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesExplainDataLifecycleResponse = System.Text.Json.JsonElement

    type IndicesExplainDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesExplainDataLifecycleRequest =
            {
                Index = Unchecked.defaultof<_>
                IncludeDefaults = None
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesExplainDataLifecycleRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesExplainDataLifecycleRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesExplainDataLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesExplainDataLifecycleRequest = IndicesExplainDataLifecycleRequestBuilder()

    module ExplainDataLifecycle =
        let withIncludeDefaults (value: bool) (req: IndicesExplainDataLifecycleRequest) =
            { req with IncludeDefaults = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesExplainDataLifecycleRequest) =
            { req with MasterTimeout = Some value }

    type IndicesFieldUsageStatsRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        Fields: Types.Fields option
    }

        with
        static member ToRequest(req: IndicesFieldUsageStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_field_usage_stats"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesFieldUsageStatsResponse = Types.FieldsUsageBody

    type IndicesFieldUsageStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesFieldUsageStatsRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                Fields = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesFieldUsageStatsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesFieldUsageStatsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesFieldUsageStatsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesFieldUsageStatsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesFieldUsageStatsRequest, value: Types.Fields) =
            { state with Fields = Some value }

    let indicesFieldUsageStatsRequest = IndicesFieldUsageStatsRequestBuilder()

    module FieldUsageStats =
        let withAllowNoIndices (value: bool) (req: IndicesFieldUsageStatsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesFieldUsageStatsRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesFieldUsageStatsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withFields (value: Types.Fields) (req: IndicesFieldUsageStatsRequest) =
            { req with Fields = Some value }

    type IndicesFlushRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        Force: bool option
        IgnoreUnavailable: bool option
        WaitIfOngoing: bool option
    }

        with
        static member ToRequest(req: IndicesFlushRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_flush"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.WaitIfOngoing |> Option.map (fun v -> "wait_if_ongoing", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesFlushResponse = Types.ShardsOperationResponseBase

    type IndicesFlushRequestBuilder() =
        member _.Yield(_: unit) : IndicesFlushRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                Force = None
                IgnoreUnavailable = None
                WaitIfOngoing = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesFlushRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesFlushRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesFlushRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: IndicesFlushRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesFlushRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("waitIfOngoing")>]
        member _.WaitIfOngoing(state: IndicesFlushRequest, value: bool) =
            { state with WaitIfOngoing = Some value }

    let indicesFlushRequest = IndicesFlushRequestBuilder()

    module Flush =
        let withAllowNoIndices (value: bool) (req: IndicesFlushRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesFlushRequest) =
            { req with ExpandWildcards = Some value }
        let withForce (value: bool) (req: IndicesFlushRequest) =
            { req with Force = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesFlushRequest) =
            { req with IgnoreUnavailable = Some value }
        let withWaitIfOngoing (value: bool) (req: IndicesFlushRequest) =
            { req with WaitIfOngoing = Some value }

    type IndicesForcemergeRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        Flush: bool option
        IgnoreUnavailable: bool option
        MaxNumSegments: Types.Long option
        OnlyExpungeDeletes: bool option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: IndicesForcemergeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_forcemerge"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.Flush |> Option.map (fun v -> "flush", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MaxNumSegments |> Option.map (fun v -> "max_num_segments", Fes.Http.toQueryValue v)
                        req.OnlyExpungeDeletes |> Option.map (fun v -> "only_expunge_deletes", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesForcemergeResponse = Types.ForceMergeResponseBody

    type IndicesForcemergeRequestBuilder() =
        member _.Yield(_: unit) : IndicesForcemergeRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                Flush = None
                IgnoreUnavailable = None
                MaxNumSegments = None
                OnlyExpungeDeletes = None
                WaitForCompletion = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesForcemergeRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesForcemergeRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesForcemergeRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flush")>]
        member _.Flush(state: IndicesForcemergeRequest, value: bool) =
            { state with Flush = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesForcemergeRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("maxNumSegments")>]
        member _.MaxNumSegments(state: IndicesForcemergeRequest, value: Types.Long) =
            { state with MaxNumSegments = Some value }

        [<CustomOperation("onlyExpungeDeletes")>]
        member _.OnlyExpungeDeletes(state: IndicesForcemergeRequest, value: bool) =
            { state with OnlyExpungeDeletes = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: IndicesForcemergeRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let indicesForcemergeRequest = IndicesForcemergeRequestBuilder()

    module Forcemerge =
        let withAllowNoIndices (value: bool) (req: IndicesForcemergeRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesForcemergeRequest) =
            { req with ExpandWildcards = Some value }
        let withFlush (value: bool) (req: IndicesForcemergeRequest) =
            { req with Flush = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesForcemergeRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMaxNumSegments (value: Types.Long) (req: IndicesForcemergeRequest) =
            { req with MaxNumSegments = Some value }
        let withOnlyExpungeDeletes (value: bool) (req: IndicesForcemergeRequest) =
            { req with OnlyExpungeDeletes = Some value }
        let withWaitForCompletion (value: bool) (req: IndicesForcemergeRequest) =
            { req with WaitForCompletion = Some value }

    type IndicesGetRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
        Features: Types.IndicesGetFeatures option
    }

        with
        static member ToRequest(req: IndicesGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Features |> Option.map (fun v -> "features", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetResponse = Map<Types.IndexName, Types.IndexState>

    type IndicesGetRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                FlatSettings = None
                IgnoreUnavailable = None
                IncludeDefaults = None
                Local = None
                MasterTimeout = None
                Features = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesGetRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesGetRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesGetRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("features")>]
        member _.Features(state: IndicesGetRequest, value: Types.IndicesGetFeatures) =
            { state with Features = Some value }

    let indicesGetRequest = IndicesGetRequestBuilder()

    module Get =
        let withAllowNoIndices (value: bool) (req: IndicesGetRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetRequest) =
            { req with ExpandWildcards = Some value }
        let withFlatSettings (value: bool) (req: IndicesGetRequest) =
            { req with FlatSettings = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesGetRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesGetRequest) =
            { req with IncludeDefaults = Some value }
        let withLocal (value: bool) (req: IndicesGetRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetRequest) =
            { req with MasterTimeout = Some value }
        let withFeatures (value: Types.IndicesGetFeatures) (req: IndicesGetRequest) =
            { req with Features = Some value }

    type IndicesGetAliasRequest = {
        Name: Types.Names
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_alias/{req.Name}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetAliasResponse = Map<Types.IndexName, Types.IndexAliases>

    type IndicesGetAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetAliasRequest =
            {
                Name = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetAliasRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetAliasRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesGetAliasRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetAliasRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetAliasRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetAliasRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetAliasRequest = IndicesGetAliasRequestBuilder()

    module GetAlias =
        let withAllowNoIndices (value: bool) (req: IndicesGetAliasRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetAliasRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesGetAliasRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetAliasRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetDataLifecycleRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        IncludeDefaults: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_lifecycle"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetDataLifecycleResponse = System.Text.Json.JsonElement

    type IndicesGetDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataLifecycleRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                IncludeDefaults = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataLifecycleRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetDataLifecycleRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesGetDataLifecycleRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetDataLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetDataLifecycleRequest = IndicesGetDataLifecycleRequestBuilder()

    module GetDataLifecycle =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetDataLifecycleRequest) =
            { req with ExpandWildcards = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesGetDataLifecycleRequest) =
            { req with IncludeDefaults = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetDataLifecycleRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetDataLifecycleStatsRequest = | IndicesGetDataLifecycleStatsRequest

        with
        static member ToRequest(req: IndicesGetDataLifecycleStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_lifecycle/stats"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetDataLifecycleStatsResponse = System.Text.Json.JsonElement

    type IndicesGetDataLifecycleStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataLifecycleStatsRequest =
            {
            }

    let indicesGetDataLifecycleStatsRequest = IndicesGetDataLifecycleStatsRequestBuilder()

    type IndicesGetDataStreamRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        IncludeDefaults: bool option
        MasterTimeout: Types.Duration option
        Verbose: bool option
    }

        with
        static member ToRequest(req: IndicesGetDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetDataStreamResponse = System.Text.Json.JsonElement

    type IndicesGetDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                IncludeDefaults = None
                MasterTimeout = None
                Verbose = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetDataStreamRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesGetDataStreamRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: IndicesGetDataStreamRequest, value: bool) =
            { state with Verbose = Some value }

    let indicesGetDataStreamRequest = IndicesGetDataStreamRequestBuilder()

    module GetDataStream =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetDataStreamRequest) =
            { req with ExpandWildcards = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesGetDataStreamRequest) =
            { req with IncludeDefaults = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetDataStreamRequest) =
            { req with MasterTimeout = Some value }
        let withVerbose (value: bool) (req: IndicesGetDataStreamRequest) =
            { req with Verbose = Some value }

    type IndicesGetDataStreamMappingsRequest = {
        Name: Types.Indices
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetDataStreamMappingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_mappings"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetDataStreamMappingsResponse = System.Text.Json.JsonElement

    type IndicesGetDataStreamMappingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamMappingsRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamMappingsRequest, value: Types.Indices) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamMappingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetDataStreamMappingsRequest = IndicesGetDataStreamMappingsRequestBuilder()

    module GetDataStreamMappings =
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetDataStreamMappingsRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetDataStreamOptionsRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_options"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetDataStreamOptionsResponse = System.Text.Json.JsonElement

    type IndicesGetDataStreamOptionsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamOptionsRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamOptionsRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetDataStreamOptionsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamOptionsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetDataStreamOptionsRequest = IndicesGetDataStreamOptionsRequestBuilder()

    module GetDataStreamOptions =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetDataStreamOptionsRequest) =
            { req with ExpandWildcards = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetDataStreamOptionsRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetDataStreamSettingsRequest = {
        Name: Types.Indices
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetDataStreamSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_settings"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetDataStreamSettingsResponse = System.Text.Json.JsonElement

    type IndicesGetDataStreamSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamSettingsRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamSettingsRequest, value: Types.Indices) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetDataStreamSettingsRequest = IndicesGetDataStreamSettingsRequestBuilder()

    module GetDataStreamSettings =
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetDataStreamSettingsRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetFieldMappingRequest = {
        Fields: Types.Fields
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
    }

        with
        static member ToRequest(req: IndicesGetFieldMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_mapping/field/{req.Fields}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetFieldMappingResponse = Map<Types.IndexName, Types.TypeFieldMappings>

    type IndicesGetFieldMappingRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetFieldMappingRequest =
            {
                Fields = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                IncludeDefaults = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesGetFieldMappingRequest, value: Types.Fields) =
            { state with Fields = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetFieldMappingRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesGetFieldMappingRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetFieldMappingRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetFieldMappingRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesGetFieldMappingRequest, value: bool) =
            { state with IncludeDefaults = Some value }

    let indicesGetFieldMappingRequest = IndicesGetFieldMappingRequestBuilder()

    module GetFieldMapping =
        let withAllowNoIndices (value: bool) (req: IndicesGetFieldMappingRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetFieldMappingRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesGetFieldMappingRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesGetFieldMappingRequest) =
            { req with IncludeDefaults = Some value }

    type IndicesGetIndexTemplateRequest = {
        Name: Types.Name
        Local: bool option
        FlatSettings: bool option
        MasterTimeout: Types.Duration option
        IncludeDefaults: bool option
    }

        with
        static member ToRequest(req: IndicesGetIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{req.Name}"
                let queryParams =
                    [
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetIndexTemplateResponse = System.Text.Json.JsonElement

    type IndicesGetIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetIndexTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Local = None
                FlatSettings = None
                MasterTimeout = None
                IncludeDefaults = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetIndexTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetIndexTemplateRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesGetIndexTemplateRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetIndexTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesGetIndexTemplateRequest, value: bool) =
            { state with IncludeDefaults = Some value }

    let indicesGetIndexTemplateRequest = IndicesGetIndexTemplateRequestBuilder()

    module GetIndexTemplate =
        let withLocal (value: bool) (req: IndicesGetIndexTemplateRequest) =
            { req with Local = Some value }
        let withFlatSettings (value: bool) (req: IndicesGetIndexTemplateRequest) =
            { req with FlatSettings = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetIndexTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesGetIndexTemplateRequest) =
            { req with IncludeDefaults = Some value }

    type IndicesGetMappingRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_mapping"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetMappingResponse = Map<Types.IndexName, Types.IndexMappingRecord>

    type IndicesGetMappingRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetMappingRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetMappingRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesGetMappingRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetMappingRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetMappingRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetMappingRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetMappingRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetMappingRequest = IndicesGetMappingRequestBuilder()

    module GetMapping =
        let withAllowNoIndices (value: bool) (req: IndicesGetMappingRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetMappingRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesGetMappingRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLocal (value: bool) (req: IndicesGetMappingRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetMappingRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetMigrateReindexStatusRequest = {
        Index: Types.Indices
    }

        with
        static member ToRequest(req: IndicesGetMigrateReindexStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/reindex/{req.Index}/_status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetMigrateReindexStatusResponse = System.Text.Json.JsonElement

    type IndicesGetMigrateReindexStatusRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetMigrateReindexStatusRequest =
            {
                Index = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetMigrateReindexStatusRequest, value: Types.Indices) =
            { state with Index = value }

    let indicesGetMigrateReindexStatusRequest = IndicesGetMigrateReindexStatusRequestBuilder()

    type IndicesGetSettingsRequest = {
        Index: Types.Indices
        Name: Types.Names
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        IncludeDefaults: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_settings/{req.Name}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetSettingsResponse = Map<Types.IndexName, Types.IndexState>

    type IndicesGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetSettingsRequest =
            {
                Index = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                FlatSettings = None
                IgnoreUnavailable = None
                IncludeDefaults = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetSettingsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetSettingsRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesGetSettingsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesGetSettingsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesGetSettingsRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesGetSettingsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesGetSettingsRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetSettingsRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetSettingsRequest = IndicesGetSettingsRequestBuilder()

    module GetSettings =
        let withAllowNoIndices (value: bool) (req: IndicesGetSettingsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesGetSettingsRequest) =
            { req with ExpandWildcards = Some value }
        let withFlatSettings (value: bool) (req: IndicesGetSettingsRequest) =
            { req with FlatSettings = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesGetSettingsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesGetSettingsRequest) =
            { req with IncludeDefaults = Some value }
        let withLocal (value: bool) (req: IndicesGetSettingsRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetSettingsRequest) =
            { req with MasterTimeout = Some value }

    type IndicesGetTemplateRequest = {
        Name: Types.Names
        FlatSettings: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesGetTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{req.Name}"
                let queryParams =
                    [
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesGetTemplateResponse = Map<string, Types.TemplateMapping>

    type IndicesGetTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                FlatSettings = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetTemplateRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesGetTemplateRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: IndicesGetTemplateRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesGetTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesGetTemplateRequest = IndicesGetTemplateRequestBuilder()

    module GetTemplate =
        let withFlatSettings (value: bool) (req: IndicesGetTemplateRequest) =
            { req with FlatSettings = Some value }
        let withLocal (value: bool) (req: IndicesGetTemplateRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesGetTemplateRequest) =
            { req with MasterTimeout = Some value }

    type IndicesMigrateReindexRequest = {
        Document: obj
    }

        with
        static member ToRequest(req: IndicesMigrateReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/reindex"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesMigrateReindexResponse = Types.AcknowledgedResponseBase

    type IndicesMigrateReindexRequestBuilder() =
        member _.Yield(_: unit) : IndicesMigrateReindexRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesMigrateReindexRequest, value) =
            { state with Document = value }

    let indicesMigrateReindexRequest = IndicesMigrateReindexRequestBuilder()

    type IndicesMigrateToDataStreamRequest = {
        Name: Types.IndexName
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesMigrateToDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/_migrate/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesMigrateToDataStreamResponse = Types.AcknowledgedResponseBase

    type IndicesMigrateToDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesMigrateToDataStreamRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesMigrateToDataStreamRequest, value: Types.IndexName) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesMigrateToDataStreamRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesMigrateToDataStreamRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesMigrateToDataStreamRequest = IndicesMigrateToDataStreamRequestBuilder()

    module MigrateToDataStream =
        let withMasterTimeout (value: Types.Duration) (req: IndicesMigrateToDataStreamRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesMigrateToDataStreamRequest) =
            { req with Timeout = Some value }

    type IndicesModifyDataStreamRequest = {
        Actions: Types.IndicesModifyDataStreamAction list
    }

        with
        static member ToRequest(req: IndicesModifyDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/_modify"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesModifyDataStreamResponse = Types.AcknowledgedResponseBase

    type IndicesModifyDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesModifyDataStreamRequest =
            {
                Actions = Unchecked.defaultof<_>
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: IndicesModifyDataStreamRequest, value: Types.IndicesModifyDataStreamAction list) =
            { state with Actions = value }

    let indicesModifyDataStreamRequest = IndicesModifyDataStreamRequestBuilder()

    module ModifyDataStream =
        let withActions (value: Types.IndicesModifyDataStreamAction list) (req: IndicesModifyDataStreamRequest) =
            { req with Actions = value }

    type IndicesOpenRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
    }

        with
        static member ToRequest(req: IndicesOpenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_open"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesOpenResponse = System.Text.Json.JsonElement

    type IndicesOpenRequestBuilder() =
        member _.Yield(_: unit) : IndicesOpenRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesOpenRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesOpenRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesOpenRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesOpenRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesOpenRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesOpenRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesOpenRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

    let indicesOpenRequest = IndicesOpenRequestBuilder()

    module Open =
        let withAllowNoIndices (value: bool) (req: IndicesOpenRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesOpenRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesOpenRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesOpenRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesOpenRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesOpenRequest) =
            { req with WaitForActiveShards = Some value }

    type IndicesPromoteDataStreamRequest = {
        Name: Types.IndexName
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesPromoteDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/_promote/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPromoteDataStreamResponse = System.Text.Json.JsonElement

    type IndicesPromoteDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesPromoteDataStreamRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPromoteDataStreamRequest, value: Types.IndexName) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPromoteDataStreamRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let indicesPromoteDataStreamRequest = IndicesPromoteDataStreamRequestBuilder()

    module PromoteDataStream =
        let withMasterTimeout (value: Types.Duration) (req: IndicesPromoteDataStreamRequest) =
            { req with MasterTimeout = Some value }

    type IndicesPutAliasRequest = {
        Index: Types.Indices
        Name: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Filter: Types.QueryContainer option
        IndexRouting: string option
        IsWriteIndex: bool option
        Routing: string option
        SearchRouting: string option
    }

        with
        static member ToRequest(req: IndicesPutAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_alias/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutAliasResponse = Types.AcknowledgedResponseBase

    type IndicesPutAliasRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutAliasRequest =
            {
                Index = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Filter = None
                IndexRouting = None
                IsWriteIndex = None
                Routing = None
                SearchRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesPutAliasRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutAliasRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutAliasRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutAliasRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: IndicesPutAliasRequest, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: IndicesPutAliasRequest, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: IndicesPutAliasRequest, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: IndicesPutAliasRequest, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: IndicesPutAliasRequest, value: string) =
            { state with SearchRouting = Some value }

    let indicesPutAliasRequest = IndicesPutAliasRequestBuilder()

    module PutAlias =
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutAliasRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutAliasRequest) =
            { req with Timeout = Some value }
        let withFilter (value: Types.QueryContainer) (req: IndicesPutAliasRequest) =
            { req with Filter = Some value }
        let withIndexRouting (value: string) (req: IndicesPutAliasRequest) =
            { req with IndexRouting = Some value }
        let withIsWriteIndex (value: bool) (req: IndicesPutAliasRequest) =
            { req with IsWriteIndex = Some value }
        let withRouting (value: string) (req: IndicesPutAliasRequest) =
            { req with Routing = Some value }
        let withSearchRouting (value: string) (req: IndicesPutAliasRequest) =
            { req with SearchRouting = Some value }

    type IndicesPutDataLifecycleRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        DataRetention: Types.Duration option
        Downsampling: Types.DownsamplingRound list option
        DownsamplingMethod: Types.SamplingMethod option
        Enabled: bool option
    }

        with
        static member ToRequest(req: IndicesPutDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_lifecycle"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutDataLifecycleResponse = Types.AcknowledgedResponseBase

    type IndicesPutDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataLifecycleRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                MasterTimeout = None
                Timeout = None
                DataRetention = None
                Downsampling = None
                DownsamplingMethod = None
                Enabled = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataLifecycleRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesPutDataLifecycleRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutDataLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: IndicesPutDataLifecycleRequest, value: Types.Duration) =
            { state with DataRetention = Some value }

        [<CustomOperation("downsampling")>]
        member _.Downsampling(state: IndicesPutDataLifecycleRequest, value: Types.DownsamplingRound list) =
            { state with Downsampling = Some value }

        [<CustomOperation("downsamplingMethod")>]
        member _.DownsamplingMethod(state: IndicesPutDataLifecycleRequest, value: Types.SamplingMethod) =
            { state with DownsamplingMethod = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: IndicesPutDataLifecycleRequest, value: bool) =
            { state with Enabled = Some value }

    let indicesPutDataLifecycleRequest = IndicesPutDataLifecycleRequestBuilder()

    module PutDataLifecycle =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesPutDataLifecycleRequest) =
            { req with ExpandWildcards = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutDataLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutDataLifecycleRequest) =
            { req with Timeout = Some value }
        let withDataRetention (value: Types.Duration) (req: IndicesPutDataLifecycleRequest) =
            { req with DataRetention = Some value }
        let withDownsampling (value: Types.DownsamplingRound list) (req: IndicesPutDataLifecycleRequest) =
            { req with Downsampling = Some value }
        let withDownsamplingMethod (value: Types.SamplingMethod) (req: IndicesPutDataLifecycleRequest) =
            { req with DownsamplingMethod = Some value }
        let withEnabled (value: bool) (req: IndicesPutDataLifecycleRequest) =
            { req with Enabled = Some value }

    type IndicesPutDataStreamMappingsRequest = {
        Name: Types.Indices
        DryRun: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: IndicesPutDataStreamMappingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_mappings"
                let queryParams =
                    [
                        req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutDataStreamMappingsResponse = System.Text.Json.JsonElement

    type IndicesPutDataStreamMappingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataStreamMappingsRequest =
            {
                Name = Unchecked.defaultof<_>
                DryRun = None
                MasterTimeout = None
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataStreamMappingsRequest, value: Types.Indices) =
            { state with Name = value }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: IndicesPutDataStreamMappingsRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutDataStreamMappingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataStreamMappingsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesPutDataStreamMappingsRequest, value) =
            { state with Document = value }

    let indicesPutDataStreamMappingsRequest = IndicesPutDataStreamMappingsRequestBuilder()

    module PutDataStreamMappings =
        let withDryRun (value: bool) (req: IndicesPutDataStreamMappingsRequest) =
            { req with DryRun = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutDataStreamMappingsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutDataStreamMappingsRequest) =
            { req with Timeout = Some value }

    type IndicesPutDataStreamOptionsRequest = {
        Name: Types.DataStreamNames
        ExpandWildcards: Types.ExpandWildcards option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        FailureStore: Types.DataStreamFailureStore option
    }

        with
        static member ToRequest(req: IndicesPutDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_options"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutDataStreamOptionsResponse = Types.AcknowledgedResponseBase

    type IndicesPutDataStreamOptionsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataStreamOptionsRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                MasterTimeout = None
                Timeout = None
                FailureStore = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataStreamOptionsRequest, value: Types.DataStreamNames) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesPutDataStreamOptionsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutDataStreamOptionsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataStreamOptionsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: IndicesPutDataStreamOptionsRequest, value: Types.DataStreamFailureStore) =
            { state with FailureStore = Some value }

    let indicesPutDataStreamOptionsRequest = IndicesPutDataStreamOptionsRequestBuilder()

    module PutDataStreamOptions =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesPutDataStreamOptionsRequest) =
            { req with ExpandWildcards = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutDataStreamOptionsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutDataStreamOptionsRequest) =
            { req with Timeout = Some value }
        let withFailureStore (value: Types.DataStreamFailureStore) (req: IndicesPutDataStreamOptionsRequest) =
            { req with FailureStore = Some value }

    type IndicesPutDataStreamSettingsRequest = {
        Name: Types.Indices
        DryRun: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: IndicesPutDataStreamSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{req.Name}/_settings"
                let queryParams =
                    [
                        req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutDataStreamSettingsResponse = System.Text.Json.JsonElement

    type IndicesPutDataStreamSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataStreamSettingsRequest =
            {
                Name = Unchecked.defaultof<_>
                DryRun = None
                MasterTimeout = None
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataStreamSettingsRequest, value: Types.Indices) =
            { state with Name = value }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: IndicesPutDataStreamSettingsRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutDataStreamSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataStreamSettingsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesPutDataStreamSettingsRequest, value) =
            { state with Document = value }

    let indicesPutDataStreamSettingsRequest = IndicesPutDataStreamSettingsRequestBuilder()

    module PutDataStreamSettings =
        let withDryRun (value: bool) (req: IndicesPutDataStreamSettingsRequest) =
            { req with DryRun = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutDataStreamSettingsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutDataStreamSettingsRequest) =
            { req with Timeout = Some value }

    type IndicesPutIndexTemplateRequest = {
        Name: Types.Name
        Create: bool option
        MasterTimeout: Types.Duration option
        Cause: string option
        IndexPatterns: Types.Indices option
        ComposedOf: Types.Name list option
        Template: Types.IndexTemplateMapping option
        DataStream: Types.DataStreamVisibility option
        Priority: Types.Long option
        Version: Types.VersionNumber option
        Meta: Types.Metadata option
        AllowAutoCreate: bool option
        IgnoreMissingComponentTemplates: string list option
        Deprecated: bool option
    }

        with
        static member ToRequest(req: IndicesPutIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/{req.Name}"
                let queryParams =
                    [
                        req.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutIndexTemplateResponse = Types.AcknowledgedResponseBase

    type IndicesPutIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutIndexTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Create = None
                MasterTimeout = None
                Cause = None
                IndexPatterns = None
                ComposedOf = None
                Template = None
                DataStream = None
                Priority = None
                Version = None
                Meta = None
                AllowAutoCreate = None
                IgnoreMissingComponentTemplates = None
                Deprecated = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutIndexTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("create")>]
        member _.Create(state: IndicesPutIndexTemplateRequest, value: bool) =
            { state with Create = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutIndexTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesPutIndexTemplateRequest, value: string) =
            { state with Cause = Some value }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: IndicesPutIndexTemplateRequest, value: Types.Indices) =
            { state with IndexPatterns = Some value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: IndicesPutIndexTemplateRequest, value: Types.Name list) =
            { state with ComposedOf = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: IndicesPutIndexTemplateRequest, value: Types.IndexTemplateMapping) =
            { state with Template = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: IndicesPutIndexTemplateRequest, value: Types.DataStreamVisibility) =
            { state with DataStream = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: IndicesPutIndexTemplateRequest, value: Types.Long) =
            { state with Priority = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndicesPutIndexTemplateRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: IndicesPutIndexTemplateRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowAutoCreate")>]
        member _.AllowAutoCreate(state: IndicesPutIndexTemplateRequest, value: bool) =
            { state with AllowAutoCreate = Some value }

        [<CustomOperation("ignoreMissingComponentTemplates")>]
        member _.IgnoreMissingComponentTemplates(state: IndicesPutIndexTemplateRequest, value: string list) =
            { state with IgnoreMissingComponentTemplates = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IndicesPutIndexTemplateRequest, value: bool) =
            { state with Deprecated = Some value }

    let indicesPutIndexTemplateRequest = IndicesPutIndexTemplateRequestBuilder()

    module PutIndexTemplate =
        let withCreate (value: bool) (req: IndicesPutIndexTemplateRequest) =
            { req with Create = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutIndexTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withCause (value: string) (req: IndicesPutIndexTemplateRequest) =
            { req with Cause = Some value }
        let withIndexPatterns (value: Types.Indices) (req: IndicesPutIndexTemplateRequest) =
            { req with IndexPatterns = Some value }
        let withComposedOf (value: Types.Name list) (req: IndicesPutIndexTemplateRequest) =
            { req with ComposedOf = Some value }
        let withTemplate (value: Types.IndexTemplateMapping) (req: IndicesPutIndexTemplateRequest) =
            { req with Template = Some value }
        let withDataStream (value: Types.DataStreamVisibility) (req: IndicesPutIndexTemplateRequest) =
            { req with DataStream = Some value }
        let withPriority (value: Types.Long) (req: IndicesPutIndexTemplateRequest) =
            { req with Priority = Some value }
        let withVersion (value: Types.VersionNumber) (req: IndicesPutIndexTemplateRequest) =
            { req with Version = Some value }
        let withMeta (value: Types.Metadata) (req: IndicesPutIndexTemplateRequest) =
            { req with Meta = Some value }
        let withAllowAutoCreate (value: bool) (req: IndicesPutIndexTemplateRequest) =
            { req with AllowAutoCreate = Some value }
        let withIgnoreMissingComponentTemplates (value: string list) (req: IndicesPutIndexTemplateRequest) =
            { req with IgnoreMissingComponentTemplates = Some value }
        let withDeprecated (value: bool) (req: IndicesPutIndexTemplateRequest) =
            { req with Deprecated = Some value }

    type IndicesPutMappingRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WriteIndexOnly: bool option
        DateDetection: bool option
        Dynamic: Types.DynamicMapping option
        DynamicDateFormats: string list option
        DynamicTemplates: Map<string, Types.DynamicTemplate> list option
        FieldNames: Types.FieldNamesField option
        Meta: Types.Metadata option
        NumericDetection: bool option
        Properties: Map<Types.PropertyName, Types.Property> option
        Routing: Types.RoutingField option
        Source: Types.SourceField option
        Runtime: Types.RuntimeFields option
    }

        with
        static member ToRequest(req: IndicesPutMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_mapping"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WriteIndexOnly |> Option.map (fun v -> "write_index_only", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutMappingResponse = Types.IndicesResponseBase

    type IndicesPutMappingRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutMappingRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
                WriteIndexOnly = None
                DateDetection = None
                Dynamic = None
                DynamicDateFormats = None
                DynamicTemplates = None
                FieldNames = None
                Meta = None
                NumericDetection = None
                Properties = None
                Routing = None
                Source = None
                Runtime = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesPutMappingRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesPutMappingRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesPutMappingRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesPutMappingRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutMappingRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutMappingRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("writeIndexOnly")>]
        member _.WriteIndexOnly(state: IndicesPutMappingRequest, value: bool) =
            { state with WriteIndexOnly = Some value }

        [<CustomOperation("dateDetection")>]
        member _.DateDetection(state: IndicesPutMappingRequest, value: bool) =
            { state with DateDetection = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: IndicesPutMappingRequest, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("dynamicDateFormats")>]
        member _.DynamicDateFormats(state: IndicesPutMappingRequest, value: string list) =
            { state with DynamicDateFormats = Some value }

        [<CustomOperation("dynamicTemplates")>]
        member _.DynamicTemplates(state: IndicesPutMappingRequest, value: Map<string, Types.DynamicTemplate> list) =
            { state with DynamicTemplates = Some value }

        [<CustomOperation("fieldNames")>]
        member _.FieldNames(state: IndicesPutMappingRequest, value: Types.FieldNamesField) =
            { state with FieldNames = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: IndicesPutMappingRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("numericDetection")>]
        member _.NumericDetection(state: IndicesPutMappingRequest, value: bool) =
            { state with NumericDetection = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: IndicesPutMappingRequest, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: IndicesPutMappingRequest, value: Types.RoutingField) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: IndicesPutMappingRequest, value: Types.SourceField) =
            { state with Source = Some value }

        [<CustomOperation("runtime")>]
        member _.Runtime(state: IndicesPutMappingRequest, value: Types.RuntimeFields) =
            { state with Runtime = Some value }

    let indicesPutMappingRequest = IndicesPutMappingRequestBuilder()

    module PutMapping =
        let withAllowNoIndices (value: bool) (req: IndicesPutMappingRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesPutMappingRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesPutMappingRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutMappingRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutMappingRequest) =
            { req with Timeout = Some value }
        let withWriteIndexOnly (value: bool) (req: IndicesPutMappingRequest) =
            { req with WriteIndexOnly = Some value }
        let withDateDetection (value: bool) (req: IndicesPutMappingRequest) =
            { req with DateDetection = Some value }
        let withDynamic (value: Types.DynamicMapping) (req: IndicesPutMappingRequest) =
            { req with Dynamic = Some value }
        let withDynamicDateFormats (value: string list) (req: IndicesPutMappingRequest) =
            { req with DynamicDateFormats = Some value }
        let withDynamicTemplates (value: Map<string, Types.DynamicTemplate> list) (req: IndicesPutMappingRequest) =
            { req with DynamicTemplates = Some value }
        let withFieldNames (value: Types.FieldNamesField) (req: IndicesPutMappingRequest) =
            { req with FieldNames = Some value }
        let withMeta (value: Types.Metadata) (req: IndicesPutMappingRequest) =
            { req with Meta = Some value }
        let withNumericDetection (value: bool) (req: IndicesPutMappingRequest) =
            { req with NumericDetection = Some value }
        let withProperties (value: Map<Types.PropertyName, Types.Property>) (req: IndicesPutMappingRequest) =
            { req with Properties = Some value }
        let withRouting (value: Types.RoutingField) (req: IndicesPutMappingRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceField) (req: IndicesPutMappingRequest) =
            { req with Source = Some value }
        let withRuntime (value: Types.RuntimeFields) (req: IndicesPutMappingRequest) =
            { req with Runtime = Some value }

    type IndicesPutSettingsRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        PreserveExisting: bool option
        Reopen: bool option
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: IndicesPutSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_settings"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.PreserveExisting |> Option.map (fun v -> "preserve_existing", Fes.Http.toQueryValue v)
                        req.Reopen |> Option.map (fun v -> "reopen", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutSettingsResponse = Types.AcknowledgedResponseBase

    type IndicesPutSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutSettingsRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                FlatSettings = None
                IgnoreUnavailable = None
                MasterTimeout = None
                PreserveExisting = None
                Reopen = None
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesPutSettingsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesPutSettingsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesPutSettingsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: IndicesPutSettingsRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesPutSettingsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("preserveExisting")>]
        member _.PreserveExisting(state: IndicesPutSettingsRequest, value: bool) =
            { state with PreserveExisting = Some value }

        [<CustomOperation("reopen")>]
        member _.Reopen(state: IndicesPutSettingsRequest, value: bool) =
            { state with Reopen = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutSettingsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesPutSettingsRequest, value) =
            { state with Document = value }

    let indicesPutSettingsRequest = IndicesPutSettingsRequestBuilder()

    module PutSettings =
        let withAllowNoIndices (value: bool) (req: IndicesPutSettingsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesPutSettingsRequest) =
            { req with ExpandWildcards = Some value }
        let withFlatSettings (value: bool) (req: IndicesPutSettingsRequest) =
            { req with FlatSettings = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesPutSettingsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutSettingsRequest) =
            { req with MasterTimeout = Some value }
        let withPreserveExisting (value: bool) (req: IndicesPutSettingsRequest) =
            { req with PreserveExisting = Some value }
        let withReopen (value: bool) (req: IndicesPutSettingsRequest) =
            { req with Reopen = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesPutSettingsRequest) =
            { req with Timeout = Some value }

    type IndicesPutTemplateRequest = {
        Name: Types.Name
        Create: bool option
        MasterTimeout: Types.Duration option
        Order: Types.Integer option
        Cause: string option
        Aliases: Map<Types.IndexName, Types.Alias> option
        IndexPatterns: System.Text.Json.JsonElement option
        Mappings: Types.TypeMapping option
        Order: Types.Integer option
        Settings: Types.IndexSettings option
        Version: Types.VersionNumber option
    }

        with
        static member ToRequest(req: IndicesPutTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_template/{req.Name}"
                let queryParams =
                    [
                        req.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Order |> Option.map (fun v -> "order", Fes.Http.toQueryValue v)
                        req.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesPutTemplateResponse = Types.AcknowledgedResponseBase

    type IndicesPutTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Create = None
                MasterTimeout = None
                Order = None
                Cause = None
                Aliases = None
                IndexPatterns = None
                Mappings = None
                Order = None
                Settings = None
                Version = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("create")>]
        member _.Create(state: IndicesPutTemplateRequest, value: bool) =
            { state with Create = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesPutTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: IndicesPutTemplateRequest, value: Types.Integer) =
            { state with Order = Some value }

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesPutTemplateRequest, value: string) =
            { state with Cause = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesPutTemplateRequest, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: IndicesPutTemplateRequest, value: System.Text.Json.JsonElement) =
            { state with IndexPatterns = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndicesPutTemplateRequest, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: IndicesPutTemplateRequest, value: Types.Integer) =
            { state with Order = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesPutTemplateRequest, value: Types.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndicesPutTemplateRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

    let indicesPutTemplateRequest = IndicesPutTemplateRequestBuilder()

    module PutTemplate =
        let withCreate (value: bool) (req: IndicesPutTemplateRequest) =
            { req with Create = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesPutTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withOrder (value: Types.Integer) (req: IndicesPutTemplateRequest) =
            { req with Order = Some value }
        let withCause (value: string) (req: IndicesPutTemplateRequest) =
            { req with Cause = Some value }
        let withAliases (value: Map<Types.IndexName, Types.Alias>) (req: IndicesPutTemplateRequest) =
            { req with Aliases = Some value }
        let withIndexPatterns (value: System.Text.Json.JsonElement) (req: IndicesPutTemplateRequest) =
            { req with IndexPatterns = Some value }
        let withMappings (value: Types.TypeMapping) (req: IndicesPutTemplateRequest) =
            { req with Mappings = Some value }
        let withOrder (value: Types.Integer) (req: IndicesPutTemplateRequest) =
            { req with Order = Some value }
        let withSettings (value: Types.IndexSettings) (req: IndicesPutTemplateRequest) =
            { req with Settings = Some value }
        let withVersion (value: Types.VersionNumber) (req: IndicesPutTemplateRequest) =
            { req with Version = Some value }

    type IndicesRecoveryRequest = {
        Index: Types.Indices
        ActiveOnly: bool option
        Detailed: bool option
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
    }

        with
        static member ToRequest(req: IndicesRecoveryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_recovery"
                let queryParams =
                    [
                        req.ActiveOnly |> Option.map (fun v -> "active_only", Fes.Http.toQueryValue v)
                        req.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesRecoveryResponse = Map<Types.IndexName, Types.RecoveryStatus>

    type IndicesRecoveryRequestBuilder() =
        member _.Yield(_: unit) : IndicesRecoveryRequest =
            {
                Index = Unchecked.defaultof<_>
                ActiveOnly = None
                Detailed = None
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRecoveryRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("activeOnly")>]
        member _.ActiveOnly(state: IndicesRecoveryRequest, value: bool) =
            { state with ActiveOnly = Some value }

        [<CustomOperation("detailed")>]
        member _.Detailed(state: IndicesRecoveryRequest, value: bool) =
            { state with Detailed = Some value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesRecoveryRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesRecoveryRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesRecoveryRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

    let indicesRecoveryRequest = IndicesRecoveryRequestBuilder()

    module Recovery =
        let withActiveOnly (value: bool) (req: IndicesRecoveryRequest) =
            { req with ActiveOnly = Some value }
        let withDetailed (value: bool) (req: IndicesRecoveryRequest) =
            { req with Detailed = Some value }
        let withAllowNoIndices (value: bool) (req: IndicesRecoveryRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesRecoveryRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesRecoveryRequest) =
            { req with IgnoreUnavailable = Some value }

    type IndicesRefreshRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
    }

        with
        static member ToRequest(req: IndicesRefreshRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_refresh"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesRefreshResponse = Types.ShardsOperationResponseBase

    type IndicesRefreshRequestBuilder() =
        member _.Yield(_: unit) : IndicesRefreshRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRefreshRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesRefreshRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesRefreshRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesRefreshRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

    let indicesRefreshRequest = IndicesRefreshRequestBuilder()

    module Refresh =
        let withAllowNoIndices (value: bool) (req: IndicesRefreshRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesRefreshRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesRefreshRequest) =
            { req with IgnoreUnavailable = Some value }

    type IndicesReloadSearchAnalyzersRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        Resource: string option
    }

        with
        static member ToRequest(req: IndicesReloadSearchAnalyzersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_reload_search_analyzers"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Resource |> Option.map (fun v -> "resource", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesReloadSearchAnalyzersResponse = Types.ReloadResult

    type IndicesReloadSearchAnalyzersRequestBuilder() =
        member _.Yield(_: unit) : IndicesReloadSearchAnalyzersRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                Resource = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesReloadSearchAnalyzersRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesReloadSearchAnalyzersRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesReloadSearchAnalyzersRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesReloadSearchAnalyzersRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("resource")>]
        member _.Resource(state: IndicesReloadSearchAnalyzersRequest, value: string) =
            { state with Resource = Some value }

    let indicesReloadSearchAnalyzersRequest = IndicesReloadSearchAnalyzersRequestBuilder()

    module ReloadSearchAnalyzers =
        let withAllowNoIndices (value: bool) (req: IndicesReloadSearchAnalyzersRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesReloadSearchAnalyzersRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesReloadSearchAnalyzersRequest) =
            { req with IgnoreUnavailable = Some value }
        let withResource (value: string) (req: IndicesReloadSearchAnalyzersRequest) =
            { req with Resource = Some value }

    type IndicesRemoveBlockRequest = {
        Index: Types.Indices
        Block: Types.IndicesBlockOptions
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesRemoveBlockRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_block/{req.Block}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesRemoveBlockResponse = System.Text.Json.JsonElement

    type IndicesRemoveBlockRequestBuilder() =
        member _.Yield(_: unit) : IndicesRemoveBlockRequest =
            {
                Index = Unchecked.defaultof<_>
                Block = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRemoveBlockRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("block")>]
        member _.Block(state: IndicesRemoveBlockRequest, value: Types.IndicesBlockOptions) =
            { state with Block = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesRemoveBlockRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesRemoveBlockRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesRemoveBlockRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesRemoveBlockRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesRemoveBlockRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesRemoveBlockRequest = IndicesRemoveBlockRequestBuilder()

    module RemoveBlock =
        let withAllowNoIndices (value: bool) (req: IndicesRemoveBlockRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesRemoveBlockRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesRemoveBlockRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesRemoveBlockRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesRemoveBlockRequest) =
            { req with Timeout = Some value }

    type IndicesResolveClusterRequest = {
        Name: Types.Names
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IndicesResolveClusterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_resolve/cluster/{req.Name}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesResolveClusterResponse = Map<Types.ClusterAlias, Types.ResolveClusterInfo>

    type IndicesResolveClusterRequestBuilder() =
        member _.Yield(_: unit) : IndicesResolveClusterRequest =
            {
                Name = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesResolveClusterRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesResolveClusterRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesResolveClusterRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: IndicesResolveClusterRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesResolveClusterRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesResolveClusterRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesResolveClusterRequest = IndicesResolveClusterRequestBuilder()

    module ResolveCluster =
        let withAllowNoIndices (value: bool) (req: IndicesResolveClusterRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesResolveClusterRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: IndicesResolveClusterRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesResolveClusterRequest) =
            { req with IgnoreUnavailable = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesResolveClusterRequest) =
            { req with Timeout = Some value }

    type IndicesResolveIndexRequest = {
        Name: Types.Names
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        AllowNoIndices: bool option
        Mode: System.Text.Json.JsonElement option
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToRequest(req: IndicesResolveIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_resolve/index/{req.Name}"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.Mode |> Option.map (fun v -> "mode", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesResolveIndexResponse = System.Text.Json.JsonElement

    type IndicesResolveIndexRequestBuilder() =
        member _.Yield(_: unit) : IndicesResolveIndexRequest =
            {
                Name = Unchecked.defaultof<_>
                ExpandWildcards = None
                IgnoreUnavailable = None
                AllowNoIndices = None
                Mode = None
                ProjectRouting = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesResolveIndexRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesResolveIndexRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesResolveIndexRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesResolveIndexRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: IndicesResolveIndexRequest, value: System.Text.Json.JsonElement) =
            { state with Mode = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: IndicesResolveIndexRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let indicesResolveIndexRequest = IndicesResolveIndexRequestBuilder()

    module ResolveIndex =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesResolveIndexRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesResolveIndexRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAllowNoIndices (value: bool) (req: IndicesResolveIndexRequest) =
            { req with AllowNoIndices = Some value }
        let withMode (value: System.Text.Json.JsonElement) (req: IndicesResolveIndexRequest) =
            { req with Mode = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: IndicesResolveIndexRequest) =
            { req with ProjectRouting = Some value }

    type IndicesRolloverRequest = {
        Alias: Types.IndexAlias
        NewIndex: Types.IndexName
        DryRun: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        Lazy: bool option
        Aliases: Map<Types.IndexName, Types.Alias> option
        Conditions: Types.RolloverConditions option
        Mappings: Types.TypeMapping option
        Settings: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: IndicesRolloverRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Alias}/_rollover/{req.NewIndex}"
                let queryParams =
                    [
                        req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        req.Lazy |> Option.map (fun v -> "lazy", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesRolloverResponse = System.Text.Json.JsonElement

    type IndicesRolloverRequestBuilder() =
        member _.Yield(_: unit) : IndicesRolloverRequest =
            {
                Alias = Unchecked.defaultof<_>
                NewIndex = Unchecked.defaultof<_>
                DryRun = None
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
                Lazy = None
                Aliases = None
                Conditions = None
                Mappings = None
                Settings = None
            }

        [<CustomOperation("alias")>]
        member _.Alias(state: IndicesRolloverRequest, value: Types.IndexAlias) =
            { state with Alias = value }

        [<CustomOperation("newIndex")>]
        member _.NewIndex(state: IndicesRolloverRequest, value: Types.IndexName) =
            { state with NewIndex = value }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: IndicesRolloverRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesRolloverRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesRolloverRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesRolloverRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("lazy'")>]
        member _.Lazy(state: IndicesRolloverRequest, value: bool) =
            { state with Lazy = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesRolloverRequest, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("conditions")>]
        member _.Conditions(state: IndicesRolloverRequest, value: Types.RolloverConditions) =
            { state with Conditions = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndicesRolloverRequest, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesRolloverRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Settings = Some value }

    let indicesRolloverRequest = IndicesRolloverRequestBuilder()

    module Rollover =
        let withDryRun (value: bool) (req: IndicesRolloverRequest) =
            { req with DryRun = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesRolloverRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesRolloverRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesRolloverRequest) =
            { req with WaitForActiveShards = Some value }
        let withLazy (value: bool) (req: IndicesRolloverRequest) =
            { req with Lazy = Some value }
        let withAliases (value: Map<Types.IndexName, Types.Alias>) (req: IndicesRolloverRequest) =
            { req with Aliases = Some value }
        let withConditions (value: Types.RolloverConditions) (req: IndicesRolloverRequest) =
            { req with Conditions = Some value }
        let withMappings (value: Types.TypeMapping) (req: IndicesRolloverRequest) =
            { req with Mappings = Some value }
        let withSettings (value: Map<string, System.Text.Json.JsonElement>) (req: IndicesRolloverRequest) =
            { req with Settings = Some value }

    type IndicesSegmentsRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
    }

        with
        static member ToRequest(req: IndicesSegmentsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_segments"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesSegmentsResponse = System.Text.Json.JsonElement

    type IndicesSegmentsRequestBuilder() =
        member _.Yield(_: unit) : IndicesSegmentsRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesSegmentsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesSegmentsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesSegmentsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesSegmentsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

    let indicesSegmentsRequest = IndicesSegmentsRequestBuilder()

    module Segments =
        let withAllowNoIndices (value: bool) (req: IndicesSegmentsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesSegmentsRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesSegmentsRequest) =
            { req with IgnoreUnavailable = Some value }

    type IndicesShardStoresRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        Status: System.Text.Json.JsonElement option
    }

        with
        static member ToRequest(req: IndicesShardStoresRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_shard_stores"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Status |> Option.map (fun v -> "status", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesShardStoresResponse = System.Text.Json.JsonElement

    type IndicesShardStoresRequestBuilder() =
        member _.Yield(_: unit) : IndicesShardStoresRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                Status = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesShardStoresRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesShardStoresRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesShardStoresRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesShardStoresRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: IndicesShardStoresRequest, value: System.Text.Json.JsonElement) =
            { state with Status = Some value }

    let indicesShardStoresRequest = IndicesShardStoresRequestBuilder()

    module ShardStores =
        let withAllowNoIndices (value: bool) (req: IndicesShardStoresRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesShardStoresRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesShardStoresRequest) =
            { req with IgnoreUnavailable = Some value }
        let withStatus (value: System.Text.Json.JsonElement) (req: IndicesShardStoresRequest) =
            { req with Status = Some value }

    type IndicesShrinkRequest = {
        Index: Types.IndexName
        Target: Types.IndexName
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        Aliases: Map<Types.IndexName, Types.Alias> option
        Settings: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: IndicesShrinkRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_shrink/{req.Target}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesShrinkResponse = System.Text.Json.JsonElement

    type IndicesShrinkRequestBuilder() =
        member _.Yield(_: unit) : IndicesShrinkRequest =
            {
                Index = Unchecked.defaultof<_>
                Target = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
                Aliases = None
                Settings = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesShrinkRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("target")>]
        member _.Target(state: IndicesShrinkRequest, value: Types.IndexName) =
            { state with Target = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesShrinkRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesShrinkRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesShrinkRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesShrinkRequest, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesShrinkRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Settings = Some value }

    let indicesShrinkRequest = IndicesShrinkRequestBuilder()

    module Shrink =
        let withMasterTimeout (value: Types.Duration) (req: IndicesShrinkRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesShrinkRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesShrinkRequest) =
            { req with WaitForActiveShards = Some value }
        let withAliases (value: Map<Types.IndexName, Types.Alias>) (req: IndicesShrinkRequest) =
            { req with Aliases = Some value }
        let withSettings (value: Map<string, System.Text.Json.JsonElement>) (req: IndicesShrinkRequest) =
            { req with Settings = Some value }

    type IndicesSimulateIndexTemplateRequest = {
        Name: Types.Name
        Create: bool option
        Cause: string option
        MasterTimeout: Types.Duration option
        IncludeDefaults: bool option
        Document: obj
    }

        with
        static member ToRequest(req: IndicesSimulateIndexTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/_simulate_index/{req.Name}"
                let queryParams =
                    [
                        req.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        req.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesSimulateIndexTemplateResponse = System.Text.Json.JsonElement

    type IndicesSimulateIndexTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesSimulateIndexTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Create = None
                Cause = None
                MasterTimeout = None
                IncludeDefaults = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesSimulateIndexTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("create")>]
        member _.Create(state: IndicesSimulateIndexTemplateRequest, value: bool) =
            { state with Create = Some value }

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesSimulateIndexTemplateRequest, value: string) =
            { state with Cause = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesSimulateIndexTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesSimulateIndexTemplateRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IndicesSimulateIndexTemplateRequest, value) =
            { state with Document = value }

    let indicesSimulateIndexTemplateRequest = IndicesSimulateIndexTemplateRequestBuilder()

    module SimulateIndexTemplate =
        let withCreate (value: bool) (req: IndicesSimulateIndexTemplateRequest) =
            { req with Create = Some value }
        let withCause (value: string) (req: IndicesSimulateIndexTemplateRequest) =
            { req with Cause = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesSimulateIndexTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesSimulateIndexTemplateRequest) =
            { req with IncludeDefaults = Some value }

    type IndicesSimulateTemplateRequest = {
        Name: Types.Name
        Create: bool option
        Cause: string option
        MasterTimeout: Types.Duration option
        IncludeDefaults: bool option
        AllowAutoCreate: bool option
        IndexPatterns: Types.Indices option
        ComposedOf: Types.Name list option
        Template: Types.IndexTemplateMapping option
        DataStream: Types.DataStreamVisibility option
        Priority: Types.Long option
        Version: Types.VersionNumber option
        Meta: Types.Metadata option
        IgnoreMissingComponentTemplates: string list option
        Deprecated: bool option
    }

        with
        static member ToRequest(req: IndicesSimulateTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_index_template/_simulate/{req.Name}"
                let queryParams =
                    [
                        req.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        req.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesSimulateTemplateResponse = System.Text.Json.JsonElement

    type IndicesSimulateTemplateRequestBuilder() =
        member _.Yield(_: unit) : IndicesSimulateTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Create = None
                Cause = None
                MasterTimeout = None
                IncludeDefaults = None
                AllowAutoCreate = None
                IndexPatterns = None
                ComposedOf = None
                Template = None
                DataStream = None
                Priority = None
                Version = None
                Meta = None
                IgnoreMissingComponentTemplates = None
                Deprecated = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: IndicesSimulateTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("create")>]
        member _.Create(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with Create = Some value }

        [<CustomOperation("cause")>]
        member _.Cause(state: IndicesSimulateTemplateRequest, value: string) =
            { state with Cause = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesSimulateTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("allowAutoCreate")>]
        member _.AllowAutoCreate(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with AllowAutoCreate = Some value }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: IndicesSimulateTemplateRequest, value: Types.Indices) =
            { state with IndexPatterns = Some value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: IndicesSimulateTemplateRequest, value: Types.Name list) =
            { state with ComposedOf = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: IndicesSimulateTemplateRequest, value: Types.IndexTemplateMapping) =
            { state with Template = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: IndicesSimulateTemplateRequest, value: Types.DataStreamVisibility) =
            { state with DataStream = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: IndicesSimulateTemplateRequest, value: Types.Long) =
            { state with Priority = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndicesSimulateTemplateRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: IndicesSimulateTemplateRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("ignoreMissingComponentTemplates")>]
        member _.IgnoreMissingComponentTemplates(state: IndicesSimulateTemplateRequest, value: string list) =
            { state with IgnoreMissingComponentTemplates = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IndicesSimulateTemplateRequest, value: bool) =
            { state with Deprecated = Some value }

    let indicesSimulateTemplateRequest = IndicesSimulateTemplateRequestBuilder()

    module SimulateTemplate =
        let withCreate (value: bool) (req: IndicesSimulateTemplateRequest) =
            { req with Create = Some value }
        let withCause (value: string) (req: IndicesSimulateTemplateRequest) =
            { req with Cause = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesSimulateTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withIncludeDefaults (value: bool) (req: IndicesSimulateTemplateRequest) =
            { req with IncludeDefaults = Some value }
        let withAllowAutoCreate (value: bool) (req: IndicesSimulateTemplateRequest) =
            { req with AllowAutoCreate = Some value }
        let withIndexPatterns (value: Types.Indices) (req: IndicesSimulateTemplateRequest) =
            { req with IndexPatterns = Some value }
        let withComposedOf (value: Types.Name list) (req: IndicesSimulateTemplateRequest) =
            { req with ComposedOf = Some value }
        let withTemplate (value: Types.IndexTemplateMapping) (req: IndicesSimulateTemplateRequest) =
            { req with Template = Some value }
        let withDataStream (value: Types.DataStreamVisibility) (req: IndicesSimulateTemplateRequest) =
            { req with DataStream = Some value }
        let withPriority (value: Types.Long) (req: IndicesSimulateTemplateRequest) =
            { req with Priority = Some value }
        let withVersion (value: Types.VersionNumber) (req: IndicesSimulateTemplateRequest) =
            { req with Version = Some value }
        let withMeta (value: Types.Metadata) (req: IndicesSimulateTemplateRequest) =
            { req with Meta = Some value }
        let withIgnoreMissingComponentTemplates (value: string list) (req: IndicesSimulateTemplateRequest) =
            { req with IgnoreMissingComponentTemplates = Some value }
        let withDeprecated (value: bool) (req: IndicesSimulateTemplateRequest) =
            { req with Deprecated = Some value }

    type IndicesSplitRequest = {
        Index: Types.IndexName
        Target: Types.IndexName
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        Aliases: Map<Types.IndexName, Types.Alias> option
        Settings: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: IndicesSplitRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_split/{req.Target}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesSplitResponse = System.Text.Json.JsonElement

    type IndicesSplitRequestBuilder() =
        member _.Yield(_: unit) : IndicesSplitRequest =
            {
                Index = Unchecked.defaultof<_>
                Target = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
                Aliases = None
                Settings = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesSplitRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("target")>]
        member _.Target(state: IndicesSplitRequest, value: Types.IndexName) =
            { state with Target = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesSplitRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesSplitRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndicesSplitRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndicesSplitRequest, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndicesSplitRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Settings = Some value }

    let indicesSplitRequest = IndicesSplitRequestBuilder()

    module Split =
        let withMasterTimeout (value: Types.Duration) (req: IndicesSplitRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesSplitRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndicesSplitRequest) =
            { req with WaitForActiveShards = Some value }
        let withAliases (value: Map<Types.IndexName, Types.Alias>) (req: IndicesSplitRequest) =
            { req with Aliases = Some value }
        let withSettings (value: Map<string, System.Text.Json.JsonElement>) (req: IndicesSplitRequest) =
            { req with Settings = Some value }

    type IndicesStatsRequest = {
        Metric: Types.CommonStatsFlags
        Index: Types.Indices
        CompletionFields: Types.Fields option
        ExpandWildcards: Types.ExpandWildcards option
        FielddataFields: Types.Fields option
        Fields: Types.Fields option
        ForbidClosedIndices: bool option
        Groups: System.Text.Json.JsonElement option
        IncludeSegmentFileSizes: bool option
        IncludeUnloadedSegments: bool option
        Level: Types.Level option
    }

        with
        static member ToRequest(req: IndicesStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_stats/{req.Metric}"
                let queryParams =
                    [
                        req.CompletionFields |> Option.map (fun v -> "completion_fields", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.FielddataFields |> Option.map (fun v -> "fielddata_fields", Fes.Http.toQueryValue v)
                        req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        req.ForbidClosedIndices |> Option.map (fun v -> "forbid_closed_indices", Fes.Http.toQueryValue v)
                        req.Groups |> Option.map (fun v -> "groups", Fes.Http.toQueryValue v)
                        req.IncludeSegmentFileSizes |> Option.map (fun v -> "include_segment_file_sizes", Fes.Http.toQueryValue v)
                        req.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", Fes.Http.toQueryValue v)
                        req.Level |> Option.map (fun v -> "level", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesStatsResponse = System.Text.Json.JsonElement

    type IndicesStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesStatsRequest =
            {
                Metric = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                CompletionFields = None
                ExpandWildcards = None
                FielddataFields = None
                Fields = None
                ForbidClosedIndices = None
                Groups = None
                IncludeSegmentFileSizes = None
                IncludeUnloadedSegments = None
                Level = None
            }

        [<CustomOperation("metric")>]
        member _.Metric(state: IndicesStatsRequest, value: Types.CommonStatsFlags) =
            { state with Metric = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesStatsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("completionFields")>]
        member _.CompletionFields(state: IndicesStatsRequest, value: Types.Fields) =
            { state with CompletionFields = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesStatsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("fielddataFields")>]
        member _.FielddataFields(state: IndicesStatsRequest, value: Types.Fields) =
            { state with FielddataFields = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: IndicesStatsRequest, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("forbidClosedIndices")>]
        member _.ForbidClosedIndices(state: IndicesStatsRequest, value: bool) =
            { state with ForbidClosedIndices = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: IndicesStatsRequest, value: System.Text.Json.JsonElement) =
            { state with Groups = Some value }

        [<CustomOperation("includeSegmentFileSizes")>]
        member _.IncludeSegmentFileSizes(state: IndicesStatsRequest, value: bool) =
            { state with IncludeSegmentFileSizes = Some value }

        [<CustomOperation("includeUnloadedSegments")>]
        member _.IncludeUnloadedSegments(state: IndicesStatsRequest, value: bool) =
            { state with IncludeUnloadedSegments = Some value }

        [<CustomOperation("level")>]
        member _.Level(state: IndicesStatsRequest, value: Types.Level) =
            { state with Level = Some value }

    let indicesStatsRequest = IndicesStatsRequestBuilder()

    module Stats =
        let withCompletionFields (value: Types.Fields) (req: IndicesStatsRequest) =
            { req with CompletionFields = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesStatsRequest) =
            { req with ExpandWildcards = Some value }
        let withFielddataFields (value: Types.Fields) (req: IndicesStatsRequest) =
            { req with FielddataFields = Some value }
        let withFields (value: Types.Fields) (req: IndicesStatsRequest) =
            { req with Fields = Some value }
        let withForbidClosedIndices (value: bool) (req: IndicesStatsRequest) =
            { req with ForbidClosedIndices = Some value }
        let withGroups (value: System.Text.Json.JsonElement) (req: IndicesStatsRequest) =
            { req with Groups = Some value }
        let withIncludeSegmentFileSizes (value: bool) (req: IndicesStatsRequest) =
            { req with IncludeSegmentFileSizes = Some value }
        let withIncludeUnloadedSegments (value: bool) (req: IndicesStatsRequest) =
            { req with IncludeUnloadedSegments = Some value }
        let withLevel (value: Types.Level) (req: IndicesStatsRequest) =
            { req with Level = Some value }

    type IndicesUpdateAliasesRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Actions: Types.IndicesUpdateAliasesAction list option
    }

        with
        static member ToRequest(req: IndicesUpdateAliasesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_aliases"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesUpdateAliasesResponse = Types.AcknowledgedResponseBase

    type IndicesUpdateAliasesRequestBuilder() =
        member _.Yield(_: unit) : IndicesUpdateAliasesRequest =
            {
                MasterTimeout = None
                Timeout = None
                Actions = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesUpdateAliasesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesUpdateAliasesRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("actions")>]
        member _.Actions(state: IndicesUpdateAliasesRequest, value: Types.IndicesUpdateAliasesAction list) =
            { state with Actions = Some value }

    let indicesUpdateAliasesRequest = IndicesUpdateAliasesRequestBuilder()

    module UpdateAliases =
        let withMasterTimeout (value: Types.Duration) (req: IndicesUpdateAliasesRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesUpdateAliasesRequest) =
            { req with Timeout = Some value }
        let withActions (value: Types.IndicesUpdateAliasesAction list) (req: IndicesUpdateAliasesRequest) =
            { req with Actions = Some value }

    type IndicesValidateQueryRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        AllShards: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        DefaultOperator: Types.Operator option
        Df: string option
        ExpandWildcards: Types.ExpandWildcards option
        Explain: bool option
        IgnoreUnavailable: bool option
        Lenient: bool option
        Rewrite: bool option
        Q: string option
        Query: Types.QueryContainer option
    }

        with
        static member ToRequest(req: IndicesValidateQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_validate/query"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.AllShards |> Option.map (fun v -> "all_shards", Fes.Http.toQueryValue v)
                        req.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                        req.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                        req.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                        req.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                        req.Rewrite |> Option.map (fun v -> "rewrite", Fes.Http.toQueryValue v)
                        req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesValidateQueryResponse = System.Text.Json.JsonElement

    type IndicesValidateQueryRequestBuilder() =
        member _.Yield(_: unit) : IndicesValidateQueryRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                AllShards = None
                Analyzer = None
                AnalyzeWildcard = None
                DefaultOperator = None
                Df = None
                ExpandWildcards = None
                Explain = None
                IgnoreUnavailable = None
                Lenient = None
                Rewrite = None
                Q = None
                Query = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesValidateQueryRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesValidateQueryRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("allShards")>]
        member _.AllShards(state: IndicesValidateQueryRequest, value: bool) =
            { state with AllShards = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IndicesValidateQueryRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: IndicesValidateQueryRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: IndicesValidateQueryRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: IndicesValidateQueryRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesValidateQueryRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: IndicesValidateQueryRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesValidateQueryRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: IndicesValidateQueryRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("rewrite")>]
        member _.Rewrite(state: IndicesValidateQueryRequest, value: bool) =
            { state with Rewrite = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: IndicesValidateQueryRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: IndicesValidateQueryRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

    let indicesValidateQueryRequest = IndicesValidateQueryRequestBuilder()

    module ValidateQuery =
        let withAllowNoIndices (value: bool) (req: IndicesValidateQueryRequest) =
            { req with AllowNoIndices = Some value }
        let withAllShards (value: bool) (req: IndicesValidateQueryRequest) =
            { req with AllShards = Some value }
        let withAnalyzer (value: string) (req: IndicesValidateQueryRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: IndicesValidateQueryRequest) =
            { req with AnalyzeWildcard = Some value }
        let withDefaultOperator (value: Types.Operator) (req: IndicesValidateQueryRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: IndicesValidateQueryRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesValidateQueryRequest) =
            { req with ExpandWildcards = Some value }
        let withExplain (value: bool) (req: IndicesValidateQueryRequest) =
            { req with Explain = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesValidateQueryRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: IndicesValidateQueryRequest) =
            { req with Lenient = Some value }
        let withRewrite (value: bool) (req: IndicesValidateQueryRequest) =
            { req with Rewrite = Some value }
        let withQ (value: string) (req: IndicesValidateQueryRequest) =
            { req with Q = Some value }
        let withQuery (value: Types.QueryContainer) (req: IndicesValidateQueryRequest) =
            { req with Query = Some value }

