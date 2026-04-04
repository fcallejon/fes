// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module TextStructureOperations =

    type TextStructureFindFieldStructureRequest = {
        ColumnNames: System.Text.Json.JsonElement option
        Delimiter: string option
        DocumentsToSample: Types.Uint option
        EcsCompatibility: Types.EcsCompatibilityType option
        Explain: bool option
        Field: Types.Field
        Format: Types.FormatType option
        GrokPattern: Types.GrokPattern option
        Index: Types.IndexName
        Quote: string option
        ShouldTrimFields: bool option
        ShouldParseRecursively: bool option
        Timeout: Types.Duration option
        TimestampField: Types.Field option
        TimestampFormat: string option
    }

        with
        static member ToEndpoint(req: TextStructureFindFieldStructureRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.DocumentsToSample(state: TextStructureFindFieldStructureRequest, value: Types.Uint) =
            { state with DocumentsToSample = Some value }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: TextStructureFindFieldStructureRequest, value: Types.EcsCompatibilityType) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindFieldStructureRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: TextStructureFindFieldStructureRequest, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindFieldStructureRequest, value: Types.FormatType) =
            { state with Format = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureFindFieldStructureRequest, value: Types.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: TextStructureFindFieldStructureRequest, value: Types.IndexName) =
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
        member _.Timeout(state: TextStructureFindFieldStructureRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: TextStructureFindFieldStructureRequest, value: Types.Field) =
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
        let withDocumentsToSample (value: Types.Uint) (req: TextStructureFindFieldStructureRequest) =
            { req with DocumentsToSample = Some value }
        let withEcsCompatibility (value: Types.EcsCompatibilityType) (req: TextStructureFindFieldStructureRequest) =
            { req with EcsCompatibility = Some value }
        let withExplain (value: bool) (req: TextStructureFindFieldStructureRequest) =
            { req with Explain = Some value }
        let withField (value: Types.Field) (req: TextStructureFindFieldStructureRequest) =
            { req with Field = value }
        let withFormat (value: Types.FormatType) (req: TextStructureFindFieldStructureRequest) =
            { req with Format = Some value }
        let withGrokPattern (value: Types.GrokPattern) (req: TextStructureFindFieldStructureRequest) =
            { req with GrokPattern = Some value }
        let withIndex (value: Types.IndexName) (req: TextStructureFindFieldStructureRequest) =
            { req with Index = value }
        let withQuote (value: string) (req: TextStructureFindFieldStructureRequest) =
            { req with Quote = Some value }
        let withShouldTrimFields (value: bool) (req: TextStructureFindFieldStructureRequest) =
            { req with ShouldTrimFields = Some value }
        let withShouldParseRecursively (value: bool) (req: TextStructureFindFieldStructureRequest) =
            { req with ShouldParseRecursively = Some value }
        let withTimeout (value: Types.Duration) (req: TextStructureFindFieldStructureRequest) =
            { req with Timeout = Some value }
        let withTimestampField (value: Types.Field) (req: TextStructureFindFieldStructureRequest) =
            { req with TimestampField = Some value }
        let withTimestampFormat (value: string) (req: TextStructureFindFieldStructureRequest) =
            { req with TimestampFormat = Some value }

    type TextStructureFindMessageStructureRequest = {
        ColumnNames: System.Text.Json.JsonElement option
        Delimiter: string option
        EcsCompatibility: Types.EcsCompatibilityType option
        Explain: bool option
        Format: Types.FormatType option
        GrokPattern: Types.GrokPattern option
        Quote: string option
        ShouldTrimFields: bool option
        ShouldParseRecursively: bool option
        Timeout: Types.Duration option
        TimestampField: Types.Field option
        TimestampFormat: string option
        [<System.Text.Json.Serialization.JsonPropertyName("messages")>]
        Messages: string list
    }

        with
        static member ToEndpoint(req: TextStructureFindMessageStructureRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.EcsCompatibility(state: TextStructureFindMessageStructureRequest, value: Types.EcsCompatibilityType) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindMessageStructureRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindMessageStructureRequest, value: Types.FormatType) =
            { state with Format = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureFindMessageStructureRequest, value: Types.GrokPattern) =
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
        member _.Timeout(state: TextStructureFindMessageStructureRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: TextStructureFindMessageStructureRequest, value: Types.Field) =
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
        let withEcsCompatibility (value: Types.EcsCompatibilityType) (req: TextStructureFindMessageStructureRequest) =
            { req with EcsCompatibility = Some value }
        let withExplain (value: bool) (req: TextStructureFindMessageStructureRequest) =
            { req with Explain = Some value }
        let withFormat (value: Types.FormatType) (req: TextStructureFindMessageStructureRequest) =
            { req with Format = Some value }
        let withGrokPattern (value: Types.GrokPattern) (req: TextStructureFindMessageStructureRequest) =
            { req with GrokPattern = Some value }
        let withQuote (value: string) (req: TextStructureFindMessageStructureRequest) =
            { req with Quote = Some value }
        let withShouldTrimFields (value: bool) (req: TextStructureFindMessageStructureRequest) =
            { req with ShouldTrimFields = Some value }
        let withShouldParseRecursively (value: bool) (req: TextStructureFindMessageStructureRequest) =
            { req with ShouldParseRecursively = Some value }
        let withTimeout (value: Types.Duration) (req: TextStructureFindMessageStructureRequest) =
            { req with Timeout = Some value }
        let withTimestampField (value: Types.Field) (req: TextStructureFindMessageStructureRequest) =
            { req with TimestampField = Some value }
        let withTimestampFormat (value: string) (req: TextStructureFindMessageStructureRequest) =
            { req with TimestampFormat = Some value }
        let withMessages (value: string list) (req: TextStructureFindMessageStructureRequest) =
            { req with Messages = value }

    type TextStructureFindStructureRequest<'TJsonDocument> = {
        Charset: string option
        ColumnNames: System.Text.Json.JsonElement option
        Delimiter: string option
        EcsCompatibility: string option
        Explain: bool option
        Format: Types.FindStructureFormat option
        GrokPattern: Types.GrokPattern option
        HasHeaderRow: bool option
        LineMergeSizeLimit: Types.Uint option
        LinesToSample: Types.Uint option
        Quote: string option
        ShouldTrimFields: bool option
        ShouldParseRecursively: bool option
        Timeout: Types.Duration option
        TimestampField: Types.Field option
        TimestampFormat: string option
        Document: 'TJsonDocument list
    }

        with
        static member ToEndpoint(req: TextStructureFindStructureRequest<'TJsonDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type TextStructureFindStructureResponse = System.Text.Json.JsonElement

    type TextStructureFindStructureRequestBuilder() =
        member _.Yield(_: unit) : TextStructureFindStructureRequest<_> =
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
        member _.Charset(state: TextStructureFindStructureRequest<_>, value: string) =
            { state with Charset = Some value }

        [<CustomOperation("columnNames")>]
        member _.ColumnNames(state: TextStructureFindStructureRequest<_>, value: System.Text.Json.JsonElement) =
            { state with ColumnNames = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: TextStructureFindStructureRequest<_>, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: TextStructureFindStructureRequest<_>, value: string) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TextStructureFindStructureRequest<_>, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: TextStructureFindStructureRequest<_>, value: Types.FindStructureFormat) =
            { state with Format = Some value }

        [<CustomOperation("grokPattern")>]
        member _.GrokPattern(state: TextStructureFindStructureRequest<_>, value: Types.GrokPattern) =
            { state with GrokPattern = Some value }

        [<CustomOperation("hasHeaderRow")>]
        member _.HasHeaderRow(state: TextStructureFindStructureRequest<_>, value: bool) =
            { state with HasHeaderRow = Some value }

        [<CustomOperation("lineMergeSizeLimit")>]
        member _.LineMergeSizeLimit(state: TextStructureFindStructureRequest<_>, value: Types.Uint) =
            { state with LineMergeSizeLimit = Some value }

        [<CustomOperation("linesToSample")>]
        member _.LinesToSample(state: TextStructureFindStructureRequest<_>, value: Types.Uint) =
            { state with LinesToSample = Some value }

        [<CustomOperation("quote")>]
        member _.Quote(state: TextStructureFindStructureRequest<_>, value: string) =
            { state with Quote = Some value }

        [<CustomOperation("shouldTrimFields")>]
        member _.ShouldTrimFields(state: TextStructureFindStructureRequest<_>, value: bool) =
            { state with ShouldTrimFields = Some value }

        [<CustomOperation("shouldParseRecursively")>]
        member _.ShouldParseRecursively(state: TextStructureFindStructureRequest<_>, value: bool) =
            { state with ShouldParseRecursively = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TextStructureFindStructureRequest<_>, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: TextStructureFindStructureRequest<_>, value: Types.Field) =
            { state with TimestampField = Some value }

        [<CustomOperation("timestampFormat")>]
        member _.TimestampFormat(state: TextStructureFindStructureRequest<_>, value: string) =
            { state with TimestampFormat = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: TextStructureFindStructureRequest<_>, value) =
            { state with Document = value }

    let textStructureFindStructureRequest = TextStructureFindStructureRequestBuilder()

    module FindStructure =
        let withCharset (value: string) (req: TextStructureFindStructureRequest<_>) =
            { req with Charset = Some value }
        let withColumnNames (value: System.Text.Json.JsonElement) (req: TextStructureFindStructureRequest<_>) =
            { req with ColumnNames = Some value }
        let withDelimiter (value: string) (req: TextStructureFindStructureRequest<_>) =
            { req with Delimiter = Some value }
        let withEcsCompatibility (value: string) (req: TextStructureFindStructureRequest<_>) =
            { req with EcsCompatibility = Some value }
        let withExplain (value: bool) (req: TextStructureFindStructureRequest<_>) =
            { req with Explain = Some value }
        let withFormat (value: Types.FindStructureFormat) (req: TextStructureFindStructureRequest<_>) =
            { req with Format = Some value }
        let withGrokPattern (value: Types.GrokPattern) (req: TextStructureFindStructureRequest<_>) =
            { req with GrokPattern = Some value }
        let withHasHeaderRow (value: bool) (req: TextStructureFindStructureRequest<_>) =
            { req with HasHeaderRow = Some value }
        let withLineMergeSizeLimit (value: Types.Uint) (req: TextStructureFindStructureRequest<_>) =
            { req with LineMergeSizeLimit = Some value }
        let withLinesToSample (value: Types.Uint) (req: TextStructureFindStructureRequest<_>) =
            { req with LinesToSample = Some value }
        let withQuote (value: string) (req: TextStructureFindStructureRequest<_>) =
            { req with Quote = Some value }
        let withShouldTrimFields (value: bool) (req: TextStructureFindStructureRequest<_>) =
            { req with ShouldTrimFields = Some value }
        let withShouldParseRecursively (value: bool) (req: TextStructureFindStructureRequest<_>) =
            { req with ShouldParseRecursively = Some value }
        let withTimeout (value: Types.Duration) (req: TextStructureFindStructureRequest<_>) =
            { req with Timeout = Some value }
        let withTimestampField (value: Types.Field) (req: TextStructureFindStructureRequest<_>) =
            { req with TimestampField = Some value }
        let withTimestampFormat (value: string) (req: TextStructureFindStructureRequest<_>) =
            { req with TimestampFormat = Some value }

    type TextStructureTestGrokPatternRequest = {
        EcsCompatibility: string option
        [<System.Text.Json.Serialization.JsonPropertyName("grok_pattern")>]
        GrokPattern: Types.GrokPattern
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string list
    }

        with
        static member ToEndpoint(req: TextStructureTestGrokPatternRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_text_structure/test_grok_pattern"
            let queryParams =
                [
                    req.EcsCompatibility |> Option.map (fun v -> "ecs_compatibility", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.GrokPattern(state: TextStructureTestGrokPatternRequest, value: Types.GrokPattern) =
            { state with GrokPattern = value }

        [<CustomOperation("text")>]
        member _.Text(state: TextStructureTestGrokPatternRequest, value: string list) =
            { state with Text = value }

    let textStructureTestGrokPatternRequest = TextStructureTestGrokPatternRequestBuilder()

    module TestGrokPattern =
        let withEcsCompatibility (value: string) (req: TextStructureTestGrokPatternRequest) =
            { req with EcsCompatibility = Some value }
        let withGrokPattern (value: Types.GrokPattern) (req: TextStructureTestGrokPatternRequest) =
            { req with GrokPattern = value }
        let withText (value: string list) (req: TextStructureTestGrokPatternRequest) =
            { req with Text = value }

