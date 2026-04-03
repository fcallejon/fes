// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module TextStructureOperations =

    type TextStructureFindFieldStructureRequest = {
        ColumnNames: System.Text.Json.JsonElement option
        Delimiter: string option
        DocumentsToSample: CoreTypes.Uint option
        EcsCompatibility: TextStructureTypes.EcsCompatibilityType option
        Explain: bool option
        Field: CoreTypes.Field
        Format: TextStructureTypes.FormatType option
        GrokPattern: CoreTypes.GrokPattern option
        Index: CoreTypes.IndexName
        Quote: string option
        ShouldTrimFields: bool option
        ShouldParseRecursively: bool option
        Timeout: CoreTypes.Duration option
        TimestampField: CoreTypes.Field option
        TimestampFormat: string option
    }

        with
        static member ToRequest(req: TextStructureFindFieldStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_text_structure/find_field_structure"
                let queryParams =
                    [
                        req.ColumnNames |> Option.map (fun v -> "column_names", Fes.Http.toQueryValue v)
                        req.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        req.DocumentsToSample |> Option.map (fun v -> "documents_to_sample", Fes.Http.toQueryValue v)
                        req.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", Fes.Http.toQueryValue v)
                        req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        req.GrokPattern |> Option.map (fun v -> "grok_pattern", Fes.Http.toQueryValue v)
                        req.Quote |> Option.map (fun v -> "quote", Fes.Http.toQueryValue v)
                        req.ShouldTrimFields |> Option.map (fun v -> "should_trim_fields", Fes.Http.toQueryValue v)
                        req.ShouldParseRecursively |> Option.map (fun v -> "should_parse_recursively", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.TimestampField |> Option.map (fun v -> "timestamp_field", Fes.Http.toQueryValue v)
                        req.TimestampFormat |> Option.map (fun v -> "timestamp_format", Fes.Http.toQueryValue v)
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

    type TextStructureFindFieldStructureResponse = System.Text.Json.JsonElement

    type TextStructureFindFieldStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindFieldStructureRequest =
            {
                ColumnNames = None
                Delimiter = None
                DocumentsToSample = None
                EcsCompatibility = None
                Explain = None
                Field = Unchecked.defaultof<_>
                Format = None
                GrokPattern = None
                Index = Unchecked.defaultof<_>
                Quote = None
                ShouldTrimFields = None
                ShouldParseRecursively = None
                Timeout = None
                TimestampField = None
                TimestampFormat = None
            }

        [<CustomOperation("columnNames")>]
        member _.ColumnNames(state: TextStructureFindFieldStructureRequest, value: System.Text.Json.JsonElement) =
            { state with ColumnNames = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindFieldStructureRequest, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("documentsToSample")>]
        member _.DocumentsToSample(state: TextStructureFindFieldStructureRequest, value: CoreTypes.Uint) =
            { state with DocumentsToSample = Some value }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: TextStructureFindFieldStructureRequest, value: TextStructureTypes.EcsCompatibilityType) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindFieldStructureRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: TextStructureFindFieldStructureRequest, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindFieldStructureRequest, value: TextStructureTypes.FormatType) =
            { state with Format = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureFindFieldStructureRequest, value: CoreTypes.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: TextStructureFindFieldStructureRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindFieldStructureRequest, value: string) =
            { state with Quote = Some value }

        [<CustomOperation("shouldTrimFields")>]
        member _.ShouldTrimFields(state: TextStructureFindFieldStructureRequest, value: bool) =
            { state with ShouldTrimFields = Some value }

        [<CustomOperation("shouldParseRecursively")>]
        member _.ShouldParseRecursively(state: TextStructureFindFieldStructureRequest, value: bool) =
            { state with ShouldParseRecursively = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindFieldStructureRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: TextStructureFindFieldStructureRequest, value: CoreTypes.Field) =
            { state with TimestampField = Some value }

        [<CustomOperation("timestampFormat")>]
        member _.TimestampFormat(state: TextStructureFindFieldStructureRequest, value: string) =
            { state with TimestampFormat = Some value }

    let textStructureFindFieldStructureRequest = TextStructureFindFieldStructureRequestBuilder()

    module FindFieldStructure =
        let withColumnNames (value: System.Text.Json.JsonElement) (req: TextStructureFindFieldStructureRequest) =
            { req with ColumnNames = Some value }
        let withDelimiter (value: string) (req: TextStructureFindFieldStructureRequest) =
            { req with Delimiter = Some value }
        let withDocumentsToSample (value: CoreTypes.Uint) (req: TextStructureFindFieldStructureRequest) =
            { req with DocumentsToSample = Some value }
        let withEcsCompatibility (value: TextStructureTypes.EcsCompatibilityType) (req: TextStructureFindFieldStructureRequest) =
            { req with EcsCompatibility = Some value }
        let withExplain (value: bool) (req: TextStructureFindFieldStructureRequest) =
            { req with Explain = Some value }
        let withField (value: CoreTypes.Field) (req: TextStructureFindFieldStructureRequest) =
            { req with Field = value }
        let withFormat (value: TextStructureTypes.FormatType) (req: TextStructureFindFieldStructureRequest) =
            { req with Format = Some value }
        let withGrokPattern (value: CoreTypes.GrokPattern) (req: TextStructureFindFieldStructureRequest) =
            { req with GrokPattern = Some value }
        let withIndex (value: CoreTypes.IndexName) (req: TextStructureFindFieldStructureRequest) =
            { req with Index = value }
        let withQuote (value: string) (req: TextStructureFindFieldStructureRequest) =
            { req with Quote = Some value }
        let withShouldTrimFields (value: bool) (req: TextStructureFindFieldStructureRequest) =
            { req with ShouldTrimFields = Some value }
        let withShouldParseRecursively (value: bool) (req: TextStructureFindFieldStructureRequest) =
            { req with ShouldParseRecursively = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: TextStructureFindFieldStructureRequest) =
            { req with Timeout = Some value }
        let withTimestampField (value: CoreTypes.Field) (req: TextStructureFindFieldStructureRequest) =
            { req with TimestampField = Some value }
        let withTimestampFormat (value: string) (req: TextStructureFindFieldStructureRequest) =
            { req with TimestampFormat = Some value }

    type TextStructureFindMessageStructureRequest = {
        ColumnNames: System.Text.Json.JsonElement option
        Delimiter: string option
        EcsCompatibility: TextStructureTypes.EcsCompatibilityType option
        Explain: bool option
        Format: TextStructureTypes.FormatType option
        GrokPattern: CoreTypes.GrokPattern option
        Quote: string option
        ShouldTrimFields: bool option
        ShouldParseRecursively: bool option
        Timeout: CoreTypes.Duration option
        TimestampField: CoreTypes.Field option
        TimestampFormat: string option
        Messages: string list
    }

        with
        static member ToRequest(req: TextStructureFindMessageStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_text_structure/find_message_structure"
                let queryParams =
                    [
                        req.ColumnNames |> Option.map (fun v -> "column_names", Fes.Http.toQueryValue v)
                        req.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        req.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", Fes.Http.toQueryValue v)
                        req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        req.GrokPattern |> Option.map (fun v -> "grok_pattern", Fes.Http.toQueryValue v)
                        req.Quote |> Option.map (fun v -> "quote", Fes.Http.toQueryValue v)
                        req.ShouldTrimFields |> Option.map (fun v -> "should_trim_fields", Fes.Http.toQueryValue v)
                        req.ShouldParseRecursively |> Option.map (fun v -> "should_parse_recursively", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.TimestampField |> Option.map (fun v -> "timestamp_field", Fes.Http.toQueryValue v)
                        req.TimestampFormat |> Option.map (fun v -> "timestamp_format", Fes.Http.toQueryValue v)
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

    type TextStructureFindMessageStructureResponse = System.Text.Json.JsonElement

    type TextStructureFindMessageStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindMessageStructureRequest =
            {
                ColumnNames = None
                Delimiter = None
                EcsCompatibility = None
                Explain = None
                Format = None
                GrokPattern = None
                Quote = None
                ShouldTrimFields = None
                ShouldParseRecursively = None
                Timeout = None
                TimestampField = None
                TimestampFormat = None
                Messages = Unchecked.defaultof<_>
            }

        [<CustomOperation("columnNames")>]
        member _.ColumnNames(state: TextStructureFindMessageStructureRequest, value: System.Text.Json.JsonElement) =
            { state with ColumnNames = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindMessageStructureRequest, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: TextStructureFindMessageStructureRequest, value: TextStructureTypes.EcsCompatibilityType) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindMessageStructureRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindMessageStructureRequest, value: TextStructureTypes.FormatType) =
            { state with Format = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureFindMessageStructureRequest, value: CoreTypes.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindMessageStructureRequest, value: string) =
            { state with Quote = Some value }

        [<CustomOperation("shouldTrimFields")>]
        member _.ShouldTrimFields(state: TextStructureFindMessageStructureRequest, value: bool) =
            { state with ShouldTrimFields = Some value }

        [<CustomOperation("shouldParseRecursively")>]
        member _.ShouldParseRecursively(state: TextStructureFindMessageStructureRequest, value: bool) =
            { state with ShouldParseRecursively = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindMessageStructureRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: TextStructureFindMessageStructureRequest, value: CoreTypes.Field) =
            { state with TimestampField = Some value }

        [<CustomOperation("timestampFormat")>]
        member _.TimestampFormat(state: TextStructureFindMessageStructureRequest, value: string) =
            { state with TimestampFormat = Some value }

        [<CustomOperation("messages")>]
        member _.Messages(state: TextStructureFindMessageStructureRequest, value: string list) =
            { state with Messages = value }

    let textStructureFindMessageStructureRequest = TextStructureFindMessageStructureRequestBuilder()

    module FindMessageStructure =
        let withColumnNames (value: System.Text.Json.JsonElement) (req: TextStructureFindMessageStructureRequest) =
            { req with ColumnNames = Some value }
        let withDelimiter (value: string) (req: TextStructureFindMessageStructureRequest) =
            { req with Delimiter = Some value }
        let withEcsCompatibility (value: TextStructureTypes.EcsCompatibilityType) (req: TextStructureFindMessageStructureRequest) =
            { req with EcsCompatibility = Some value }
        let withExplain (value: bool) (req: TextStructureFindMessageStructureRequest) =
            { req with Explain = Some value }
        let withFormat (value: TextStructureTypes.FormatType) (req: TextStructureFindMessageStructureRequest) =
            { req with Format = Some value }
        let withGrokPattern (value: CoreTypes.GrokPattern) (req: TextStructureFindMessageStructureRequest) =
            { req with GrokPattern = Some value }
        let withQuote (value: string) (req: TextStructureFindMessageStructureRequest) =
            { req with Quote = Some value }
        let withShouldTrimFields (value: bool) (req: TextStructureFindMessageStructureRequest) =
            { req with ShouldTrimFields = Some value }
        let withShouldParseRecursively (value: bool) (req: TextStructureFindMessageStructureRequest) =
            { req with ShouldParseRecursively = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: TextStructureFindMessageStructureRequest) =
            { req with Timeout = Some value }
        let withTimestampField (value: CoreTypes.Field) (req: TextStructureFindMessageStructureRequest) =
            { req with TimestampField = Some value }
        let withTimestampFormat (value: string) (req: TextStructureFindMessageStructureRequest) =
            { req with TimestampFormat = Some value }
        let withMessages (value: string list) (req: TextStructureFindMessageStructureRequest) =
            { req with Messages = value }

    type TextStructureFindStructureRequest = {
        Charset: string option
        ColumnNames: System.Text.Json.JsonElement option
        Delimiter: string option
        EcsCompatibility: string option
        Explain: bool option
        Format: TextStructureFindStructure.FindStructureFormat option
        GrokPattern: CoreTypes.GrokPattern option
        HasHeaderRow: bool option
        LineMergeSizeLimit: CoreTypes.Uint option
        LinesToSample: CoreTypes.Uint option
        Quote: string option
        ShouldTrimFields: bool option
        ShouldParseRecursively: bool option
        Timeout: CoreTypes.Duration option
        TimestampField: CoreTypes.Field option
        TimestampFormat: string option
        Document: obj
    }

        with
        static member ToRequest(req: TextStructureFindStructureRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_text_structure/find_structure"
                let queryParams =
                    [
                        req.Charset |> Option.map (fun v -> "charset", Fes.Http.toQueryValue v)
                        req.ColumnNames |> Option.map (fun v -> "column_names", Fes.Http.toQueryValue v)
                        req.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        req.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", Fes.Http.toQueryValue v)
                        req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        req.GrokPattern |> Option.map (fun v -> "grok_pattern", Fes.Http.toQueryValue v)
                        req.HasHeaderRow |> Option.map (fun v -> "has_header_row", Fes.Http.toQueryValue v)
                        req.LineMergeSizeLimit |> Option.map (fun v -> "line_merge_size_limit", Fes.Http.toQueryValue v)
                        req.LinesToSample |> Option.map (fun v -> "lines_to_sample", Fes.Http.toQueryValue v)
                        req.Quote |> Option.map (fun v -> "quote", Fes.Http.toQueryValue v)
                        req.ShouldTrimFields |> Option.map (fun v -> "should_trim_fields", Fes.Http.toQueryValue v)
                        req.ShouldParseRecursively |> Option.map (fun v -> "should_parse_recursively", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.TimestampField |> Option.map (fun v -> "timestamp_field", Fes.Http.toQueryValue v)
                        req.TimestampFormat |> Option.map (fun v -> "timestamp_format", Fes.Http.toQueryValue v)
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

    type TextStructureFindStructureResponse = System.Text.Json.JsonElement

    type TextStructureFindStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindStructureRequest =
            {
                Charset = None
                ColumnNames = None
                Delimiter = None
                EcsCompatibility = None
                Explain = None
                Format = None
                GrokPattern = None
                HasHeaderRow = None
                LineMergeSizeLimit = None
                LinesToSample = None
                Quote = None
                ShouldTrimFields = None
                ShouldParseRecursively = None
                Timeout = None
                TimestampField = None
                TimestampFormat = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("charset")>]
        member _.Charset(state: TextStructureFindStructureRequest, value: string) =
            { state with Charset = Some value }

        [<CustomOperation("columnNames")>]
        member _.ColumnNames(state: TextStructureFindStructureRequest, value: System.Text.Json.JsonElement) =
            { state with ColumnNames = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindStructureRequest, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: TextStructureFindStructureRequest, value: string) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindStructureRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindStructureRequest, value: TextStructureFindStructure.FindStructureFormat) =
            { state with Format = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureFindStructureRequest, value: CoreTypes.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("hasHeaderRow")>]
        member _.HasHeaderRow(state: TextStructureFindStructureRequest, value: bool) =
            { state with HasHeaderRow = Some value }

        [<CustomOperation("lineMergeSizeLimit")>]
        member _.LineMergeSizeLimit(state: TextStructureFindStructureRequest, value: CoreTypes.Uint) =
            { state with LineMergeSizeLimit = Some value }

        [<CustomOperation("linesToSample")>]
        member _.LinesToSample(state: TextStructureFindStructureRequest, value: CoreTypes.Uint) =
            { state with LinesToSample = Some value }

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindStructureRequest, value: string) =
            { state with Quote = Some value }

        [<CustomOperation("shouldTrimFields")>]
        member _.ShouldTrimFields(state: TextStructureFindStructureRequest, value: bool) =
            { state with ShouldTrimFields = Some value }

        [<CustomOperation("shouldParseRecursively")>]
        member _.ShouldParseRecursively(state: TextStructureFindStructureRequest, value: bool) =
            { state with ShouldParseRecursively = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindStructureRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: TextStructureFindStructureRequest, value: CoreTypes.Field) =
            { state with TimestampField = Some value }

        [<CustomOperation("timestampFormat")>]
        member _.TimestampFormat(state: TextStructureFindStructureRequest, value: string) =
            { state with TimestampFormat = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: TextStructureFindStructureRequest, value) =
            { state with Document = value }

    let textStructureFindStructureRequest = TextStructureFindStructureRequestBuilder()

    module FindStructure =
        let withCharset (value: string) (req: TextStructureFindStructureRequest) =
            { req with Charset = Some value }
        let withColumnNames (value: System.Text.Json.JsonElement) (req: TextStructureFindStructureRequest) =
            { req with ColumnNames = Some value }
        let withDelimiter (value: string) (req: TextStructureFindStructureRequest) =
            { req with Delimiter = Some value }
        let withEcsCompatibility (value: string) (req: TextStructureFindStructureRequest) =
            { req with EcsCompatibility = Some value }
        let withExplain (value: bool) (req: TextStructureFindStructureRequest) =
            { req with Explain = Some value }
        let withFormat (value: TextStructureFindStructure.FindStructureFormat) (req: TextStructureFindStructureRequest) =
            { req with Format = Some value }
        let withGrokPattern (value: CoreTypes.GrokPattern) (req: TextStructureFindStructureRequest) =
            { req with GrokPattern = Some value }
        let withHasHeaderRow (value: bool) (req: TextStructureFindStructureRequest) =
            { req with HasHeaderRow = Some value }
        let withLineMergeSizeLimit (value: CoreTypes.Uint) (req: TextStructureFindStructureRequest) =
            { req with LineMergeSizeLimit = Some value }
        let withLinesToSample (value: CoreTypes.Uint) (req: TextStructureFindStructureRequest) =
            { req with LinesToSample = Some value }
        let withQuote (value: string) (req: TextStructureFindStructureRequest) =
            { req with Quote = Some value }
        let withShouldTrimFields (value: bool) (req: TextStructureFindStructureRequest) =
            { req with ShouldTrimFields = Some value }
        let withShouldParseRecursively (value: bool) (req: TextStructureFindStructureRequest) =
            { req with ShouldParseRecursively = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: TextStructureFindStructureRequest) =
            { req with Timeout = Some value }
        let withTimestampField (value: CoreTypes.Field) (req: TextStructureFindStructureRequest) =
            { req with TimestampField = Some value }
        let withTimestampFormat (value: string) (req: TextStructureFindStructureRequest) =
            { req with TimestampFormat = Some value }

    type TextStructureTestGrokPatternRequest = {
        EcsCompatibility: string option
        GrokPattern: CoreTypes.GrokPattern
        Text: string list
    }

        with
        static member ToRequest(req: TextStructureTestGrokPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_text_structure/test_grok_pattern"
                let queryParams =
                    [
                        req.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", Fes.Http.toQueryValue v)
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

    type TextStructureTestGrokPatternResponse = System.Text.Json.JsonElement

    type TextStructureTestGrokPatternRequestBuilder() =
        member _.Yield(_: unit) : TextStructureTestGrokPatternRequest =
            {
                EcsCompatibility = None
                GrokPattern = Unchecked.defaultof<_>
                Text = Unchecked.defaultof<_>
            }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: TextStructureTestGrokPatternRequest, value: string) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureTestGrokPatternRequest, value: CoreTypes.GrokPattern) =
            { state with GrokPattern = value }

        [<CustomOperation("text")>]
        member _.Text(state: TextStructureTestGrokPatternRequest, value: string list) =
            { state with Text = value }

    let textStructureTestGrokPatternRequest = TextStructureTestGrokPatternRequestBuilder()

    module TestGrokPattern =
        let withEcsCompatibility (value: string) (req: TextStructureTestGrokPatternRequest) =
            { req with EcsCompatibility = Some value }
        let withGrokPattern (value: CoreTypes.GrokPattern) (req: TextStructureTestGrokPatternRequest) =
            { req with GrokPattern = value }
        let withText (value: string list) (req: TextStructureTestGrokPatternRequest) =
            { req with Text = value }

