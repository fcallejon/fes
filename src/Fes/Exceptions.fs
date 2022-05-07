namespace Fes

open System
open System.Net

module Exceptions =
    open Fleece

    type FailedShards =
        { Shard: int
          Index: string
          Node: string
          Reason: ElasticsearchCausedBy }

        static member get_Codec () =
            codec {
                let! shard = jreq "shard" (fun x -> Some x.Shard)
                and! index = jreq "index" (fun x -> Some x.Index)
                and! node = jreq "node" (fun x -> Some x.Node)
                and! reason = jreq "reason" (fun x -> Some x.Reason)

                return
                    { FailedShards.Shard = shard
                      Index = index
                      Node = node
                      Reason = reason }
            } |> ofObjCodec

    and ElasticsearchExceptions =
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
        static member OfJson value =
            match value with
            | JString "resource_already_exists_exception" -> Decode.Success ResourceAlreadyExistsException
            | JString "illegal_argument_exception" -> Decode.Success IllegalArgumentException
            | JString "search_phase_execution_exception" -> Decode.Success SearchPhaseExecutionException
            | JString "x_content_parse_exception" -> Decode.Success ContentParseException
            | JString "parsing_exception" -> Decode.Success ParsingException
            | JString "class_cast_exception" -> Decode.Success ClassCastException
            | JString "index_not_found_exception" -> Decode.Success IndexNotFoundException
            | JString "mapper_parsing_exception" -> Decode.Success MapperParsingException
            | JString "parse_exception" -> Decode.Success ParseException
            | JString "invalid_index_name_exception" -> Decode.Success InvalidIndexNameException
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong ElasticsearchException value: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | ResourceAlreadyExistsException -> JString "resource_already_exists_exception"
            | IllegalArgumentException -> JString "illegal_argument_exception"
            | SearchPhaseExecutionException -> JString "search_phase_execution_exception"
            | ContentParseException -> JString "x_content_parse_exception"
            | ParsingException -> JString "parsing_exception"
            | ClassCastException -> JString "class_cast_exception"
            | IndexNotFoundException -> JString "index_not_found_exception"
            | MapperParsingException -> JString "mapper_parsing_exception"
            | ParseException -> JString "parse_exception"
            | InvalidIndexNameException -> JString "invalid_index_name_exception"

        static member get_Codec () = ElasticsearchExceptions.OfJson <-> ElasticsearchExceptions.ToJson

    and ElasticsearchCauseByType =
        | NumberFormat
        | ContentParse
        | Parsing
        | Parse
        static member OfJson value =
            match value with
            | JString "number_format_exception" -> Decode.Success NumberFormat
            | JString "x_content_parse_exception" -> Decode.Success ContentParse
            | JString "parsing_exception" -> Decode.Success Parsing
            | JString "parse_exception" -> Decode.Success Parse
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong ElasticsearchCauseByType value: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | NumberFormat -> JString "number_format_exception"
            | ContentParse -> JString "x_content_parse_exception"
            | Parsing -> JString "parsing_exception"
            | Parse -> JString "parse_exception"

        static member get_Codec () = ElasticsearchCauseByType.OfJson <-> ElasticsearchCauseByType.ToJson

    and ElasticsearchRootCauseInfo =
        { Type: ElasticsearchExceptions
          Reason: string }

        static member get_Codec () : Codec<'Encoding, _> =
            codec {
                let! esType = jreq "type" (fun x -> Some x.Type)
                and! reason = jreq "reason" (fun x -> Some x.Reason)

                return
                    { ElasticsearchRootCauseInfo.Type = esType
                      Reason = reason }
            } |> ofObjCodec

    and ElasticsearchCausedBy =
        { Type: ElasticsearchCauseByType
          Reason: string
          Stack: option<string>
          CausedBy: option<ElasticsearchCausedBy> }

        static member get_Codec () : Codec<'Encoding, _> =
            codec {
                let! esType = jreq "type" (fun x -> Some x.Type)
                and! reason = jreq "reason" (fun x -> Some x.Reason)
                and! stack = jopt "stack_trace" (fun x -> x.Stack)
                and! causedBy = jopt "caused_by" (fun x -> x.CausedBy)

                return
                    { ElasticsearchCausedBy.Type = esType
                      Reason = reason
                      Stack = stack
                      CausedBy = causedBy }
            } |> ofObjCodec


    and ElasticsearchError =
        { Type: ElasticsearchExceptions
          Reason: string
          Index: option<string>
          CausedBy: option<ElasticsearchCausedBy>
          Stack: option<string>
          RootCauses: ElasticsearchRootCauseInfo []}

        static member get_Codec () : Codec<'Encoding, _> =
            codec {
                let! esType = jreq "type" (fun x -> Some x.Type)
                and! reason = jreq "reason" (fun x -> Some x.Reason)
                and! root = jreq "root_cause" (fun x -> Some x.RootCauses)
                and! index = jopt "index" (fun x -> x.Index)
                and! causedBy = jopt "caused_by" (fun x -> x.CausedBy)
                and! stack = jopt "stack_trace" (fun x -> x.Stack)

                return
                 { ElasticsearchError.CausedBy = causedBy
                   Type = esType
                   Reason = reason
                   Index = index
                   Stack = stack
                   RootCauses = root }
            } |> ofObjCodec

    and ElasticsearchException =
        inherit Exception
        val Error: ElasticsearchError
        val Phase: option<string>
        val Grouped: option<bool>
        val FailedShards: option<FailedShards>
        val StatusCode: HttpStatusCode

        private new(error',
                    phase',
                    grouped',
                    status',
                    failedShards') =
            { inherit Exception(error'.Reason)
              Error = error'
              Phase = phase'
              Grouped = grouped'
              StatusCode = status'
              FailedShards = failedShards' }

        static member Codec () =
            codec {
                let! error = jreq "error" (fun (x: ElasticsearchException) -> Some x.Error)
                and! phase = jopt "phase" (fun x -> x.Phase)
                and! grouped = jopt "grouped" (fun x -> x.Grouped)
                and! failedShards = jopt "failed_shards" (fun x -> x.FailedShards)
                and! status = jreq "status" (fun x -> Some x.StatusCode)

                return ElasticsearchException(
                        error,
                        phase,
                        grouped,
                        status,
                        failedShards
                    )
            } |> ofObjCodec

[<RequireQualifiedAccess>]
module ElasticsearchException =
    open Fleece.SystemTextJson

    let ofString s =
        Encoding.Parse s
        |> Exceptions.ElasticsearchException.Codec().Decoder
        |> Result.mapError ((sprintf "Server Raw Error: %s\r\nParsing Error: %O" s) >> exn)
