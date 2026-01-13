namespace Fes

open System
open System.Net
open System.Text.Json
open System.Text.Json.Serialization

module Exceptions =
    [<JsonConverter(typeof<ElasticsearchExceptionsConverter>)>]
    type ElasticsearchExceptions =
        | ResourceAlreadyExistsException
        | IllegalArgumentException
        | SearchPhaseExecutionException
        | ContentParseException
        | ParsingException
        | ClassCastException
        | IndexNotFoundException
        | MapperParsingException
        | ParseException
        | InvalidIndexNameException
        | Unknown of string

    and ElasticsearchExceptionsConverter() =
        inherit JsonConverter<ElasticsearchExceptions>()

        override _.Write(writer: Utf8JsonWriter, value: ElasticsearchExceptions, _options: JsonSerializerOptions) =
            let str =
                match value with
                | ResourceAlreadyExistsException -> "resource_already_exists_exception"
                | IllegalArgumentException -> "illegal_argument_exception"
                | SearchPhaseExecutionException -> "search_phase_execution_exception"
                | ContentParseException -> "x_content_parse_exception"
                | ParsingException -> "parsing_exception"
                | ClassCastException -> "class_cast_exception"
                | IndexNotFoundException -> "index_not_found_exception"
                | MapperParsingException -> "mapper_parsing_exception"
                | ParseException -> "parse_exception"
                | InvalidIndexNameException -> "invalid_index_name_exception"
                | Unknown s -> s
            writer.WriteStringValue(str)

        override _.Read(reader: byref<Utf8JsonReader>, _typeToConvert: Type, _options: JsonSerializerOptions) =
            match reader.GetString() with
            | "resource_already_exists_exception" -> ResourceAlreadyExistsException
            | "illegal_argument_exception" -> IllegalArgumentException
            | "search_phase_execution_exception" -> SearchPhaseExecutionException
            | "x_content_parse_exception" -> ContentParseException
            | "parsing_exception" -> ParsingException
            | "class_cast_exception" -> ClassCastException
            | "index_not_found_exception" -> IndexNotFoundException
            | "mapper_parsing_exception" -> MapperParsingException
            | "parse_exception" -> ParseException
            | "invalid_index_name_exception" -> InvalidIndexNameException
            | s -> Unknown s

    [<JsonConverter(typeof<ElasticsearchCauseByTypeConverter>)>]
    type ElasticsearchCauseByType =
        | NumberFormat
        | ContentParse
        | Parsing
        | Parse
        | Unknown of string

    and ElasticsearchCauseByTypeConverter() =
        inherit JsonConverter<ElasticsearchCauseByType>()

        override _.Write(writer: Utf8JsonWriter, value: ElasticsearchCauseByType, _options: JsonSerializerOptions) =
            let str =
                match value with
                | NumberFormat -> "number_format_exception"
                | ContentParse -> "x_content_parse_exception"
                | Parsing -> "parsing_exception"
                | Parse -> "parse_exception"
                | Unknown s -> s
            writer.WriteStringValue(str)

        override _.Read(reader: byref<Utf8JsonReader>, _typeToConvert: Type, _options: JsonSerializerOptions) =
            match reader.GetString() with
            | "number_format_exception" -> NumberFormat
            | "x_content_parse_exception" -> ContentParse
            | "parsing_exception" -> Parsing
            | "parse_exception" -> Parse
            | s -> Unknown s

    type ElasticsearchCausedBy =
        { [<JsonPropertyName("type")>] Type: ElasticsearchCauseByType
          [<JsonPropertyName("reason")>] Reason: string
          [<JsonPropertyName("stack_trace")>] Stack: string option
          [<JsonPropertyName("caused_by")>] CausedBy: ElasticsearchCausedBy option }

    type ElasticsearchRootCauseInfo =
        { [<JsonPropertyName("type")>] Type: ElasticsearchExceptions
          [<JsonPropertyName("reason")>] Reason: string }

    type FailedShards =
        { [<JsonPropertyName("shard")>] Shard: int
          [<JsonPropertyName("index")>] Index: string
          [<JsonPropertyName("node")>] Node: string
          [<JsonPropertyName("reason")>] Reason: ElasticsearchCausedBy }

    type ElasticsearchErrorInfo =
        { [<JsonPropertyName("type")>] Type: ElasticsearchExceptions
          [<JsonPropertyName("reason")>] Reason: string
          [<JsonPropertyName("index")>] Index: string option
          [<JsonPropertyName("caused_by")>] CausedBy: ElasticsearchCausedBy option
          [<JsonPropertyName("stack_trace")>] StackTrace: string option
          [<JsonPropertyName("root_cause")>] RootCause: ElasticsearchRootCauseInfo[] }

    type ElasticsearchErrorResponse =
        { [<JsonPropertyName("error")>] Error: ElasticsearchErrorInfo
          [<JsonPropertyName("status")>] Status: int
          [<JsonPropertyName("phase")>] Phase: string option
          [<JsonPropertyName("grouped")>] Grouped: bool option
          [<JsonPropertyName("failed_shards")>] FailedShards: FailedShards option }

    type ElasticsearchException(response: ElasticsearchErrorResponse, rawJson: string) =
        inherit Exception(response.Error.Reason)

        member _.RawJson = rawJson
        member _.ErrorType = response.Error.Type
        member _.Status = enum<HttpStatusCode> response.Status
        member _.Reason = response.Error.Reason
        member _.Cause = response.Error.CausedBy
        member _.StackTrace = response.Error.StackTrace
        member _.Index = response.Error.Index
        member _.RootCause = response.Error.RootCause
        member _.Phase = response.Phase
        member _.Grouped = response.Grouped
        member _.FailedShards = response.FailedShards

[<RequireQualifiedAccess>]
module ElasticsearchException =
    open Exceptions

    // Note: Can't use Json.deserialize here due to circular dependency (Json.fs references this file's converters)
    // Use inline deserialization with minimal options instead
    let private deserializeOptions =
        let opts = JsonSerializerOptions()
        opts.Converters.Add(ElasticsearchExceptionsConverter())
        opts.Converters.Add(ElasticsearchCauseByTypeConverter())
        opts.PropertyNamingPolicy <- JsonNamingPolicy.SnakeCaseLower
        opts

    let ofString (s: string) : Result<ElasticsearchException, exn> =
        try
            let response = JsonSerializer.Deserialize<ElasticsearchErrorResponse>(s, deserializeOptions)
            Ok (ElasticsearchException(response, s))
        with ex ->
            Error (exn ($"Server Raw Error: {s}\r\nParsing Error: {ex.Message}", ex))
