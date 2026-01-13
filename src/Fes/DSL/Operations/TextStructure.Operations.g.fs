// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module TextStructureOperations =

    type TextStructureFindFieldStructureRequest = {
        [<JsonPropertyName("column_names")>]
        ColumnNames: System.Text.Json.JsonElement option
        [<JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<JsonPropertyName("documents_to_sample")>]
        DocumentsToSample: Uint option
        [<JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: TypesEcsCompatibilityType option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("field")>]
        Field: Field
        [<JsonPropertyName("format")>]
        Format: TypesFormatType option
        [<JsonPropertyName("grok_pattern")>]
        GrokPattern: GrokPattern option
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("quote")>]
        Quote: string option
        [<JsonPropertyName("should_trim_fields")>]
        ShouldTrimFields: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("timestamp_field")>]
        TimestampField: Field option
        [<JsonPropertyName("timestamp_format")>]
        TimestampFormat: string option
    } with
        static member ToRequest(request: TextStructureFindFieldStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_text_structure/find_field_structure"
                let queryParams =
                    [
                        request.ColumnNames |> Option.map (fun v -> "column_names", string v)
                        request.Delimiter |> Option.map (fun v -> "delimiter", string v)
                        request.DocumentsToSample |> Option.map (fun v -> "documents_to_sample", string v)
                        request.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        Some ("field", string request.Field)
                        request.Format |> Option.map (fun v -> "format", string v)
                        request.GrokPattern |> Option.map (fun v -> "grok_pattern", string v)
                        Some ("index", string request.Index)
                        request.Quote |> Option.map (fun v -> "quote", string v)
                        request.ShouldTrimFields |> Option.map (fun v -> "should_trim_fields", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.TimestampField |> Option.map (fun v -> "timestamp_field", string v)
                        request.TimestampFormat |> Option.map (fun v -> "timestamp_format", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module TextStructureFindFieldStructureRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TextStructureFindFieldStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            TextStructureFindFieldStructureRequest.ToRequest request

    type TextStructureFindFieldStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindFieldStructureRequest =
            {
                TextStructureFindFieldStructureRequest.ColumnNames = Option.None
                TextStructureFindFieldStructureRequest.Delimiter = Option.None
                TextStructureFindFieldStructureRequest.DocumentsToSample = Option.None
                TextStructureFindFieldStructureRequest.EcsCompatibility = Option.None
                TextStructureFindFieldStructureRequest.Explain = Option.None
                TextStructureFindFieldStructureRequest.Field = Unchecked.defaultof<Field>
                TextStructureFindFieldStructureRequest.Format = Option.None
                TextStructureFindFieldStructureRequest.GrokPattern = Option.None
                TextStructureFindFieldStructureRequest.Index = Unchecked.defaultof<IndexName>
                TextStructureFindFieldStructureRequest.Quote = Option.None
                TextStructureFindFieldStructureRequest.ShouldTrimFields = Option.None
                TextStructureFindFieldStructureRequest.Timeout = Option.None
                TextStructureFindFieldStructureRequest.TimestampField = Option.None
                TextStructureFindFieldStructureRequest.TimestampFormat = Option.None
            } : TextStructureFindFieldStructureRequest

        [<CustomOperation("column_names")>]
        member _.ColumnNames(state: TextStructureFindFieldStructureRequest, value: System.Text.Json.JsonElement) =
            { state with TextStructureFindFieldStructureRequest.ColumnNames = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindFieldStructureRequest, value: string) =
            { state with TextStructureFindFieldStructureRequest.Delimiter = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("documents_to_sample")>]
        member _.DocumentsToSample(state: TextStructureFindFieldStructureRequest, value: Uint) =
            { state with TextStructureFindFieldStructureRequest.DocumentsToSample = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("ecs_compatibility")>]
        member _.EcsCompatibility(state: TextStructureFindFieldStructureRequest, value: TypesEcsCompatibilityType) =
            { state with TextStructureFindFieldStructureRequest.EcsCompatibility = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindFieldStructureRequest, value: bool) =
            { state with TextStructureFindFieldStructureRequest.Explain = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("field")>]
        member _.Field(state: TextStructureFindFieldStructureRequest, value: Field) =
            { state with TextStructureFindFieldStructureRequest.Field = value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindFieldStructureRequest, value: TypesFormatType) =
            { state with TextStructureFindFieldStructureRequest.Format = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("grok_pattern")>]
        member _.GrokPattern(state: TextStructureFindFieldStructureRequest, value: GrokPattern) =
            { state with TextStructureFindFieldStructureRequest.GrokPattern = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("index")>]
        member _.Index(state: TextStructureFindFieldStructureRequest, value: IndexName) =
            { state with TextStructureFindFieldStructureRequest.Index = value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindFieldStructureRequest, value: string) =
            { state with TextStructureFindFieldStructureRequest.Quote = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("should_trim_fields")>]
        member _.ShouldTrimFields(state: TextStructureFindFieldStructureRequest, value: bool) =
            { state with TextStructureFindFieldStructureRequest.ShouldTrimFields = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindFieldStructureRequest, value: Duration) =
            { state with TextStructureFindFieldStructureRequest.Timeout = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("timestamp_field")>]
        member _.TimestampField(state: TextStructureFindFieldStructureRequest, value: Field) =
            { state with TextStructureFindFieldStructureRequest.TimestampField = Option.Some value } : TextStructureFindFieldStructureRequest

        [<CustomOperation("timestamp_format")>]
        member _.TimestampFormat(state: TextStructureFindFieldStructureRequest, value: string) =
            { state with TextStructureFindFieldStructureRequest.TimestampFormat = Option.Some value } : TextStructureFindFieldStructureRequest

    let textStructureFindFieldStructureRequest = TextStructureFindFieldStructureRequestBuilder()

    type TextStructureFindFieldStructureResponse = {
        [<JsonPropertyName("charset")>]
        Charset: string
        [<JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: TypesEcsCompatibilityType option
        [<JsonPropertyName("field_stats")>]
        FieldStats: Map<string, TypesFieldStat>
        [<JsonPropertyName("format")>]
        Format: TypesFormatType
        [<JsonPropertyName("grok_pattern")>]
        GrokPattern: GrokPattern option
        [<JsonPropertyName("java_timestamp_formats")>]
        JavaTimestampFormats: string array option
        [<JsonPropertyName("joda_timestamp_formats")>]
        JodaTimestampFormats: string array option
        [<JsonPropertyName("ingest_pipeline")>]
        IngestPipeline: TypesPipelineConfig
        [<JsonPropertyName("mappings")>]
        Mappings: MappingTypeMapping
        [<JsonPropertyName("multiline_start_pattern")>]
        MultilineStartPattern: string option
        [<JsonPropertyName("need_client_timezone")>]
        NeedClientTimezone: bool
        [<JsonPropertyName("num_lines_analyzed")>]
        NumLinesAnalyzed: float
        [<JsonPropertyName("num_messages_analyzed")>]
        NumMessagesAnalyzed: float
        [<JsonPropertyName("sample_start")>]
        SampleStart: string
        [<JsonPropertyName("timestamp_field")>]
        TimestampField: Field option
    }

    type TextStructureFindMessageStructureRequest = {
        [<JsonPropertyName("column_names")>]
        ColumnNames: System.Text.Json.JsonElement option
        [<JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: TypesEcsCompatibilityType option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("format")>]
        Format: TypesFormatType option
        [<JsonPropertyName("grok_pattern")>]
        GrokPattern: GrokPattern option
        [<JsonPropertyName("quote")>]
        Quote: string option
        [<JsonPropertyName("should_trim_fields")>]
        ShouldTrimFields: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("timestamp_field")>]
        TimestampField: Field option
        [<JsonPropertyName("timestamp_format")>]
        TimestampFormat: string option
        [<JsonPropertyName("messages")>]
        Messages: string array
    } with
        static member ToRequest(request: TextStructureFindMessageStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_text_structure/find_message_structure"
                let queryParams =
                    [
                        request.ColumnNames |> Option.map (fun v -> "column_names", string v)
                        request.Delimiter |> Option.map (fun v -> "delimiter", string v)
                        request.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        request.Format |> Option.map (fun v -> "format", string v)
                        request.GrokPattern |> Option.map (fun v -> "grok_pattern", string v)
                        request.Quote |> Option.map (fun v -> "quote", string v)
                        request.ShouldTrimFields |> Option.map (fun v -> "should_trim_fields", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.TimestampField |> Option.map (fun v -> "timestamp_field", string v)
                        request.TimestampFormat |> Option.map (fun v -> "timestamp_format", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module TextStructureFindMessageStructureRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TextStructureFindMessageStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            TextStructureFindMessageStructureRequest.ToRequest request

    type TextStructureFindMessageStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindMessageStructureRequest =
            {
                TextStructureFindMessageStructureRequest.ColumnNames = Option.None
                TextStructureFindMessageStructureRequest.Delimiter = Option.None
                TextStructureFindMessageStructureRequest.EcsCompatibility = Option.None
                TextStructureFindMessageStructureRequest.Explain = Option.None
                TextStructureFindMessageStructureRequest.Format = Option.None
                TextStructureFindMessageStructureRequest.GrokPattern = Option.None
                TextStructureFindMessageStructureRequest.Quote = Option.None
                TextStructureFindMessageStructureRequest.ShouldTrimFields = Option.None
                TextStructureFindMessageStructureRequest.Timeout = Option.None
                TextStructureFindMessageStructureRequest.TimestampField = Option.None
                TextStructureFindMessageStructureRequest.TimestampFormat = Option.None
                TextStructureFindMessageStructureRequest.Messages = [||]
            } : TextStructureFindMessageStructureRequest

        [<CustomOperation("column_names")>]
        member _.ColumnNames(state: TextStructureFindMessageStructureRequest, value: System.Text.Json.JsonElement) =
            { state with TextStructureFindMessageStructureRequest.ColumnNames = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindMessageStructureRequest, value: string) =
            { state with TextStructureFindMessageStructureRequest.Delimiter = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("ecs_compatibility")>]
        member _.EcsCompatibility(state: TextStructureFindMessageStructureRequest, value: TypesEcsCompatibilityType) =
            { state with TextStructureFindMessageStructureRequest.EcsCompatibility = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindMessageStructureRequest, value: bool) =
            { state with TextStructureFindMessageStructureRequest.Explain = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindMessageStructureRequest, value: TypesFormatType) =
            { state with TextStructureFindMessageStructureRequest.Format = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("grok_pattern")>]
        member _.GrokPattern(state: TextStructureFindMessageStructureRequest, value: GrokPattern) =
            { state with TextStructureFindMessageStructureRequest.GrokPattern = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindMessageStructureRequest, value: string) =
            { state with TextStructureFindMessageStructureRequest.Quote = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("should_trim_fields")>]
        member _.ShouldTrimFields(state: TextStructureFindMessageStructureRequest, value: bool) =
            { state with TextStructureFindMessageStructureRequest.ShouldTrimFields = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindMessageStructureRequest, value: Duration) =
            { state with TextStructureFindMessageStructureRequest.Timeout = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("timestamp_field")>]
        member _.TimestampField(state: TextStructureFindMessageStructureRequest, value: Field) =
            { state with TextStructureFindMessageStructureRequest.TimestampField = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("timestamp_format")>]
        member _.TimestampFormat(state: TextStructureFindMessageStructureRequest, value: string) =
            { state with TextStructureFindMessageStructureRequest.TimestampFormat = Option.Some value } : TextStructureFindMessageStructureRequest

        [<CustomOperation("messages")>]
        member _.Messages(state: TextStructureFindMessageStructureRequest, value: string array) =
            { state with TextStructureFindMessageStructureRequest.Messages = value } : TextStructureFindMessageStructureRequest

    let textStructureFindMessageStructureRequest = TextStructureFindMessageStructureRequestBuilder()

    type TextStructureFindStructureRequest = {
        [<JsonPropertyName("charset")>]
        Charset: string option
        [<JsonPropertyName("column_names")>]
        ColumnNames: System.Text.Json.JsonElement option
        [<JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: string option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("format")>]
        Format: FindStructureFindStructureFormat option
        [<JsonPropertyName("grok_pattern")>]
        GrokPattern: GrokPattern option
        [<JsonPropertyName("has_header_row")>]
        HasHeaderRow: bool option
        [<JsonPropertyName("line_merge_size_limit")>]
        LineMergeSizeLimit: Uint option
        [<JsonPropertyName("lines_to_sample")>]
        LinesToSample: Uint option
        [<JsonPropertyName("quote")>]
        Quote: string option
        [<JsonPropertyName("should_trim_fields")>]
        ShouldTrimFields: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("timestamp_field")>]
        TimestampField: Field option
        [<JsonPropertyName("timestamp_format")>]
        TimestampFormat: string option
    } with
        static member ToRequest(request: TextStructureFindStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_text_structure/find_structure"
                let queryParams =
                    [
                        request.Charset |> Option.map (fun v -> "charset", string v)
                        request.ColumnNames |> Option.map (fun v -> "column_names", string v)
                        request.Delimiter |> Option.map (fun v -> "delimiter", string v)
                        request.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        request.Format |> Option.map (fun v -> "format", string v)
                        request.GrokPattern |> Option.map (fun v -> "grok_pattern", string v)
                        request.HasHeaderRow |> Option.map (fun v -> "has_header_row", string v)
                        request.LineMergeSizeLimit |> Option.map (fun v -> "line_merge_size_limit", string v)
                        request.LinesToSample |> Option.map (fun v -> "lines_to_sample", string v)
                        request.Quote |> Option.map (fun v -> "quote", string v)
                        request.ShouldTrimFields |> Option.map (fun v -> "should_trim_fields", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.TimestampField |> Option.map (fun v -> "timestamp_field", string v)
                        request.TimestampFormat |> Option.map (fun v -> "timestamp_format", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module TextStructureFindStructureRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TextStructureFindStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            TextStructureFindStructureRequest.ToRequest request

    type TextStructureFindStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindStructureRequest =
            {
                TextStructureFindStructureRequest.Charset = Option.None
                TextStructureFindStructureRequest.ColumnNames = Option.None
                TextStructureFindStructureRequest.Delimiter = Option.None
                TextStructureFindStructureRequest.EcsCompatibility = Option.None
                TextStructureFindStructureRequest.Explain = Option.None
                TextStructureFindStructureRequest.Format = Option.None
                TextStructureFindStructureRequest.GrokPattern = Option.None
                TextStructureFindStructureRequest.HasHeaderRow = Option.None
                TextStructureFindStructureRequest.LineMergeSizeLimit = Option.None
                TextStructureFindStructureRequest.LinesToSample = Option.None
                TextStructureFindStructureRequest.Quote = Option.None
                TextStructureFindStructureRequest.ShouldTrimFields = Option.None
                TextStructureFindStructureRequest.Timeout = Option.None
                TextStructureFindStructureRequest.TimestampField = Option.None
                TextStructureFindStructureRequest.TimestampFormat = Option.None
            } : TextStructureFindStructureRequest

        [<CustomOperation("charset")>]
        member _.Charset(state: TextStructureFindStructureRequest, value: string) =
            { state with TextStructureFindStructureRequest.Charset = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("column_names")>]
        member _.ColumnNames(state: TextStructureFindStructureRequest, value: System.Text.Json.JsonElement) =
            { state with TextStructureFindStructureRequest.ColumnNames = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindStructureRequest, value: string) =
            { state with TextStructureFindStructureRequest.Delimiter = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("ecs_compatibility")>]
        member _.EcsCompatibility(state: TextStructureFindStructureRequest, value: string) =
            { state with TextStructureFindStructureRequest.EcsCompatibility = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindStructureRequest, value: bool) =
            { state with TextStructureFindStructureRequest.Explain = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindStructureRequest, value: FindStructureFindStructureFormat) =
            { state with TextStructureFindStructureRequest.Format = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("grok_pattern")>]
        member _.GrokPattern(state: TextStructureFindStructureRequest, value: GrokPattern) =
            { state with TextStructureFindStructureRequest.GrokPattern = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("has_header_row")>]
        member _.HasHeaderRow(state: TextStructureFindStructureRequest, value: bool) =
            { state with TextStructureFindStructureRequest.HasHeaderRow = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("line_merge_size_limit")>]
        member _.LineMergeSizeLimit(state: TextStructureFindStructureRequest, value: Uint) =
            { state with TextStructureFindStructureRequest.LineMergeSizeLimit = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("lines_to_sample")>]
        member _.LinesToSample(state: TextStructureFindStructureRequest, value: Uint) =
            { state with TextStructureFindStructureRequest.LinesToSample = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindStructureRequest, value: string) =
            { state with TextStructureFindStructureRequest.Quote = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("should_trim_fields")>]
        member _.ShouldTrimFields(state: TextStructureFindStructureRequest, value: bool) =
            { state with TextStructureFindStructureRequest.ShouldTrimFields = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindStructureRequest, value: Duration) =
            { state with TextStructureFindStructureRequest.Timeout = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("timestamp_field")>]
        member _.TimestampField(state: TextStructureFindStructureRequest, value: Field) =
            { state with TextStructureFindStructureRequest.TimestampField = Option.Some value } : TextStructureFindStructureRequest

        [<CustomOperation("timestamp_format")>]
        member _.TimestampFormat(state: TextStructureFindStructureRequest, value: string) =
            { state with TextStructureFindStructureRequest.TimestampFormat = Option.Some value } : TextStructureFindStructureRequest

    let textStructureFindStructureRequest = TextStructureFindStructureRequestBuilder()

    type TextStructureFindStructureResponse = {
        [<JsonPropertyName("charset")>]
        Charset: string
        [<JsonPropertyName("has_header_row")>]
        HasHeaderRow: bool option
        [<JsonPropertyName("has_byte_order_marker")>]
        HasByteOrderMarker: bool
        [<JsonPropertyName("format")>]
        Format: string
        [<JsonPropertyName("field_stats")>]
        FieldStats: Map<string, TypesFieldStat>
        [<JsonPropertyName("sample_start")>]
        SampleStart: string
        [<JsonPropertyName("num_messages_analyzed")>]
        NumMessagesAnalyzed: float
        [<JsonPropertyName("mappings")>]
        Mappings: MappingTypeMapping
        [<JsonPropertyName("quote")>]
        Quote: string option
        [<JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<JsonPropertyName("need_client_timezone")>]
        NeedClientTimezone: bool
        [<JsonPropertyName("num_lines_analyzed")>]
        NumLinesAnalyzed: float
        [<JsonPropertyName("column_names")>]
        ColumnNames: string array option
        [<JsonPropertyName("explanation")>]
        Explanation: string array option
        [<JsonPropertyName("grok_pattern")>]
        GrokPattern: GrokPattern option
        [<JsonPropertyName("multiline_start_pattern")>]
        MultilineStartPattern: string option
        [<JsonPropertyName("exclude_lines_pattern")>]
        ExcludeLinesPattern: string option
        [<JsonPropertyName("java_timestamp_formats")>]
        JavaTimestampFormats: string array option
        [<JsonPropertyName("joda_timestamp_formats")>]
        JodaTimestampFormats: string array option
        [<JsonPropertyName("timestamp_field")>]
        TimestampField: Field option
        [<JsonPropertyName("should_trim_fields")>]
        ShouldTrimFields: bool option
        [<JsonPropertyName("ingest_pipeline")>]
        IngestPipeline: TypesPipelineConfig
    }

    type TextStructureTestGrokPatternRequest = {
        [<JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: string option
        [<JsonPropertyName("grok_pattern")>]
        GrokPattern: GrokPattern
        [<JsonPropertyName("text")>]
        Text: string array
    } with
        static member ToRequest(request: TextStructureTestGrokPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_text_structure/test_grok_pattern"
                let queryParams =
                    [
                        request.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module TextStructureTestGrokPatternRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TextStructureTestGrokPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            TextStructureTestGrokPatternRequest.ToRequest request

    type TextStructureTestGrokPatternRequestBuilder() =
        member _.Yield(_: unit) : TextStructureTestGrokPatternRequest =
            {
                TextStructureTestGrokPatternRequest.EcsCompatibility = Option.None
                TextStructureTestGrokPatternRequest.GrokPattern = Unchecked.defaultof<GrokPattern>
                TextStructureTestGrokPatternRequest.Text = [||]
            } : TextStructureTestGrokPatternRequest

        [<CustomOperation("ecs_compatibility")>]
        member _.EcsCompatibility(state: TextStructureTestGrokPatternRequest, value: string) =
            { state with TextStructureTestGrokPatternRequest.EcsCompatibility = Option.Some value } : TextStructureTestGrokPatternRequest

        [<CustomOperation("grok_pattern")>]
        member _.GrokPattern(state: TextStructureTestGrokPatternRequest, value: GrokPattern) =
            { state with TextStructureTestGrokPatternRequest.GrokPattern = value } : TextStructureTestGrokPatternRequest

        [<CustomOperation("text")>]
        member _.Text(state: TextStructureTestGrokPatternRequest, value: string array) =
            { state with TextStructureTestGrokPatternRequest.Text = value } : TextStructureTestGrokPatternRequest

    let textStructureTestGrokPatternRequest = TextStructureTestGrokPatternRequestBuilder()

