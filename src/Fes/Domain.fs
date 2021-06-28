module Fes.Domain

open System.Collections.ObjectModel
open FSharp.Data.UnitSystems.SI
open System
open FSharpPlus
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

module FieldTypes =
    type Keywords =
        | Keyword
        | ConstantKeyword
        | Wildcard
        static member ToJson value =
            match value with
            | Keyword -> JString(string "keyword")
            | ConstantKeyword -> JString(string "constant_keyword")
            | Wildcard -> JString(string "wildcard")

        static member OfJson value =
            match value with
            | JString "keyword" -> Decode.Success Keyword
            | JString "constant_keyword" -> Decode.Success ConstantKeyword
            | JString "wildcard" -> Decode.Success Wildcard
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Keywords value: %s{x}"
            | x -> Decode.Fail.strExpected x

    type Numeric =
        | Long
        | Integer
        | Short
        | Byte
        | Double
        | Float
        | HalfFloat
        | ScaledFloat
        | UnsignedLong
        static member ToJson value =
            match value with
            | Long -> JString "long"
            | Integer -> JString "integer"
            | Short -> JString "short"
            | Byte -> JString "byte"
            | Double -> JString "double"
            | Float -> JString "float"
            | HalfFloat -> JString "half_float"
            | ScaledFloat -> JString "scaled_float"
            | UnsignedLong -> JString "unsigned_long"

        static member OfJson value =
            match value with
            | JString "long" -> Decode.Success Long
            | JString "integer" -> Decode.Success Integer
            | JString "short" -> Decode.Success Short
            | JString "byte" -> Decode.Success Byte
            | JString "double" -> Decode.Success Double
            | JString "float" -> Decode.Success Float
            | JString "half_float" -> Decode.Success HalfFloat
            | JString "scaled_float" -> Decode.Success ScaledFloat
            | JString "unsigned_long" -> Decode.Success UnsignedLong
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Numeric value: %s{x}"
            | x -> Decode.Fail.strExpected x

    type DateTypes =
        | Date
        | DateNanos
        static member OfJson value =
            match value with
            | JString "date" -> Decode.Success Date
            | JString "date_nanos" -> Decode.Success DateNanos
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Date value: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | Date -> JString "date"
            | DateNanos -> JString "date_nanos"

    type TextTypes =
        | Text
        | AnnotatedText
        | Completion
        | SearchAsYouType
        | TokenCount
        static member OfJson value =
            match value with
            | JString "text" -> Decode.Success Text
            | JString "annotated_text" -> Decode.Success AnnotatedText
            | JString "completion" -> Decode.Success Completion
            | JString "search_as_you_type" -> Decode.Success SearchAsYouType
            | JString "token_count" -> Decode.Success TokenCount
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Text value: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | Text -> JString "text"
            | AnnotatedText -> JString "annotated_text"
            | Completion -> JString "completion"
            | SearchAsYouType -> JString "search_as_you_type"
            | TokenCount -> JString "token_count"

module Fields =

    type FieldType =
        | Keywords of FieldTypes.Keywords
        | Text of FieldTypes.TextTypes
        | Numeric of FieldTypes.Numeric
        | Date of FieldTypes.DateTypes
        static member OfJson value =
            let fieldType =
                [| (FieldTypes.Keywords.OfJson value
                    |> Result.map FieldType.Keywords)
                   (FieldTypes.TextTypes.OfJson value
                    |> Result.map FieldType.Text)
                   (FieldTypes.Numeric.OfJson value
                    |> Result.map FieldType.Numeric)
                   (FieldTypes.DateTypes.OfJson value
                    |> Result.map FieldType.Date) |]
                |> Array.tryPick
                    (function
                    | Ok ft -> Some ft
                    | _ -> None)

            match fieldType with
            | Some fieldType' -> Decode.Success fieldType'
            | _ -> Decode.Fail.invalidValue value (sprintf "Wrong Text value: %s" <| string value)

        static member ToJson value =
            match value with
            | Text text -> toJson text
            | Keywords keywords -> toJson keywords
            | Numeric numeric -> toJson numeric
            | Date date -> toJson date

//TODO: Add types from https://www.elastic.co/guide/en/elasticsearch/reference/current/mapping-types.html#structured-data-types

module IdentityMetadata =
    type Index = string
    type Type = string
    type Id = string

module DocumentMetadata =
    type Source = string
    type Size = int64
    type DocCount = int64
    type Meta = string

module Mapping =
    type MappingSettingEnabled = MappingSettingEnabled of bool

    module IndexOptionValues =
        type Docs = option<MappingSettingEnabled>
        type Frequencies = option<MappingSettingEnabled>
        type Positions = option<MappingSettingEnabled>
        type Offsets = option<MappingSettingEnabled>

    type DocValues = MappingSettingEnabled
    type Dynamic = MappingSettingEnabled
    type EagerGlobalOrdinals = MappingSettingEnabled
    type Enabled = MappingSettingEnabled
    type FieldData = MappingSettingEnabled
    type Fields = string * Fields.FieldType
    type IgnoreAbove = int32
    type IgnoreMalformed = MappingSettingEnabled

    type IndexOptions =
        IndexOptionValues.Docs * IndexOptionValues.Frequencies * IndexOptionValues.Positions * IndexOptionValues.Offsets

    type IndexPhrases = MappingSettingEnabled
    type IndexPrefixes = int8 * int8
    type Index = MappingSettingEnabled

    type Meta =
        | Unit of string
        | MetricType of string

    type Normalizer = string
    type Norms = MappingSettingEnabled
    type NullValue = string
    type PositionIncrementGap = int32
    type Properties = string * Fields.FieldType
    type SearchAnalyzer = string

    type Similarity =
        | Boolean
        | BM25
        | Classic

    type Store = MappingSettingEnabled

    type TermVector =
        | No
        | Yes
        | WithPositions
        | WithOffsets
        | WithPositionsOffsets
        | WithPositionsPayloads
        | WithPositionsOffsetsPayloads

    module TermVector =
        let mkVector =
            function
            | TermVector.No -> "no"
            | TermVector.Yes -> "yes"
            | TermVector.WithPositions -> "with_positions"
            | TermVector.WithOffsets -> "with_offsets"
            | TermVector.WithPositionsOffsets -> "with_positions_offsets"
            | TermVector.WithPositionsPayloads -> "with_positions_payloads"
            | TermVector.WithPositionsOffsetsPayloads -> "with_positions_offsets_payloads"

    type FieldMapping =
        | Analyzer of string
        | Boost of int32
        | Coerce of MappingSettingEnabled
        | CopyTo of string
        | DocValues
        | Dynamic
        | EagerGlobalOrdinals
        | Enabled
        | FieldData
        | Fields
        | IgnoreAbove
        | IgnoreMalformed
        | IndexOptions
        | IndexPhrases
        | IndexPrefixes
        | Index
        | Meta
        | Normalizer
        | Norms
        | NullValue
        | PositionIncrementGap
        | Properties
        | SearchAnalyzer
        | Similarity
        | Store
        | TermVector

module Formats =

    type BuiltInFormats =
        | EpochMillis
        | EpochSecond
        | DateOptionalTime
        | StrictDateOptionalTime
        | StrictDateOptionalTimeNanos
        | BasicDate
        | BasicDateTime
        | BasicDateTimeNoMillis
        | BasicOrdinalDate
        | BasicOrdinalDateTime
        | BasicOrdinalDateTimeNoMillis
        | BasicTime
        | BasicTimeNoMillis
        | BasicTTime
        | BasicTTimeNoMillis
        | BasicWeekDate
        | StrictBasicWeekDate
        | BasicWeekDateTime
        | StrictBasicWeekDateTime
        | BasicWeekDateTimeNoMillis
        | StrictBasicWeekDateTimeNoMillis
        | Date
        | StrictDate
        | DateHour
        | StrictDateHour
        | DateHourMinute
        | StrictDateHourMinute
        | DateHourMinuteSecond
        | StrictDateHourMinuteSecond
        | DateHourMinuteSecondFraction
        | StrictDateHourMinuteSecondFraction
        | DateHourMinuteSecondMillis
        | StrictDateHourMinuteSecondMillis
        | DateTime
        | StrictDateTime
        | DateTimeNoMillis
        | StrictDateTimeNoMillis
        | Hour
        | StrictHour
        | HourMinute
        | StrictHourMinute
        | HourMinuteSecond
        | StrictHourMinuteSecond
        | HourMinuteSecondFraction
        | StrictHourMinuteSecondFraction
        | HourMinuteSecondMillis
        | StrictHourMinuteSecondMillis
        | OrdinalDate
        | StrictOrdinalDate
        | OrdinalDateTime
        | StrictOrdinalDateTime
        | OrdinalDateTimeNoMillis
        | StrictOrdinalDateTimeNoMillis
        | Time
        | StrictTime
        | TimeNoMillis
        | StrictTimeNoMillis
        | TTime
        | StrictTTime
        | TTimeNoMillis
        | StrictTTimeNoMillis
        | WeekDate
        | StrictWeekDate
        | WeekDateTime
        | StrictWeekDateTime
        | WeekDateTimeNoMillis
        | StrictWeekDateTimeNoMillis
        | WeekYear
        | StrictWeekYear
        | WeekYearWeek
        | StrictWeekYearWeek
        | WeekYearWeekDay
        | StrictWeekYearWeekDay
        | Year
        | StrictYear
        | YearMonth
        | StrictYearMonth
        | YearMonthDay
        | StrictYearMonthDay

    type Format =
        | BuiltInFormats of BuiltInFormats
        | Custom of string

    let mkFormat =
        function
        | EpochMillis -> "epoch_millis"
        | EpochSecond -> "epoch_second"
        | DateOptionalTime -> "date_optional_time"
        | StrictDateOptionalTime -> "strict_date_optional_time"
        | StrictDateOptionalTimeNanos -> "strict_date_optional_time_nanos"
        | BasicDate -> "basic_date"
        | BasicDateTime -> "basic_date_time"
        | BasicDateTimeNoMillis -> "basic_date_time_no_millis"
        | BasicOrdinalDate -> "basic_ordinal_date"
        | BasicOrdinalDateTime -> "basic_ordinal_date_time"
        | BasicOrdinalDateTimeNoMillis -> "basic_ordinal_date_time_no_millis"
        | BasicTime -> "basic_time"
        | BasicTimeNoMillis -> "basic_time_no_millis"
        | BasicTTime -> "basic_t_time"
        | BasicTTimeNoMillis -> "basic_t_time_no_millis"
        | BasicWeekDate -> "basic_week_date"
        | StrictBasicWeekDate -> "strict_basic_week_date"
        | BasicWeekDateTime -> "basic_week_date_time"
        | StrictBasicWeekDateTime -> "strict_basic_week_date_time"
        | BasicWeekDateTimeNoMillis -> "basic_week_date_time_no_millis"
        | StrictBasicWeekDateTimeNoMillis -> "strict_basic_week_date_time_no_millis"
        | Date -> "date"
        | StrictDate -> "strict_date"
        | DateHour -> "date_hour"
        | StrictDateHour -> "strict_date_hour"
        | DateHourMinute -> "date_hour_minute"
        | StrictDateHourMinute -> "strict_date_hour_minute"
        | DateHourMinuteSecond -> "date_hour_minute_second"
        | StrictDateHourMinuteSecond -> "strict_date_hour_minute_second"
        | DateHourMinuteSecondFraction -> "date_hour_minute_second_fraction"
        | StrictDateHourMinuteSecondFraction -> "strict_date_hour_minute_second_fraction"
        | DateHourMinuteSecondMillis -> "date_hour_minute_second_millis"
        | StrictDateHourMinuteSecondMillis -> "strict_date_hour_minute_second_millis"
        | DateTime -> "date_time"
        | StrictDateTime -> "strict_date_time"
        | DateTimeNoMillis -> "date_time_no_millis"
        | StrictDateTimeNoMillis -> "strict_date_time_no_millis"
        | Hour -> "hour"
        | StrictHour -> "strict_hour"
        | HourMinute -> "hour_minute"
        | StrictHourMinute -> "strict_hour_minute"
        | HourMinuteSecond -> "hour_minute_second"
        | StrictHourMinuteSecond -> "strict_hour_minute_second"
        | HourMinuteSecondFraction -> "hour_minute_second_fraction"
        | StrictHourMinuteSecondFraction -> "strict_hour_minute_second_fraction"
        | HourMinuteSecondMillis -> "hour_minute_second_millis"
        | StrictHourMinuteSecondMillis -> "strict_hour_minute_second_millis"
        | OrdinalDate -> "ordinal_date"
        | StrictOrdinalDate -> "strict_ordinal_date"
        | OrdinalDateTime -> "ordinal_date_time"
        | StrictOrdinalDateTime -> "strict_ordinal_date_time"
        | OrdinalDateTimeNoMillis -> "ordinal_date_time_no_millis"
        | StrictOrdinalDateTimeNoMillis -> "strict_ordinal_date_time_no_millis"
        | Time -> "time"
        | StrictTime -> "strict_time"
        | TimeNoMillis -> "time_no_millis"
        | StrictTimeNoMillis -> "strict_time_no_millis"
        | TTime -> "t_time"
        | StrictTTime -> "strict_t_time"
        | TTimeNoMillis -> "t_time_no_millis"
        | StrictTTimeNoMillis -> "strict_t_time_no_millis"
        | WeekDate -> "week_date"
        | StrictWeekDate -> "strict_week_date"
        | WeekDateTime -> "week_date_time"
        | StrictWeekDateTime -> "strict_week_date_time"
        | WeekDateTimeNoMillis -> "week_date_time_no_millis"
        | StrictWeekDateTimeNoMillis -> "strict_week_date_time_no_millis"
        | WeekYear -> "weekyear"
        | StrictWeekYear -> "strict_weekyear"
        | WeekYearWeek -> "weekyear_week"
        | StrictWeekYearWeek -> "strict_weekyear_week"
        | WeekYearWeekDay -> "weekyear_week_day"
        | StrictWeekYearWeekDay -> "strict_weekyear_week_day"
        | Year -> "year"
        | StrictYear -> "strict_year"
        | YearMonth -> "year_month"
        | StrictYearMonth -> "strict_year_month"
        | YearMonthDay -> "year_month_day"
        | StrictYearMonthDay -> "strict_year_month_day"

type MappingDefinition =
    { Name: string
      Type: Fields.FieldType
      Mappings: Mapping.FieldMapping [] }

type WaitForActiveShards =
    | One
    | All
    | Other of uint8

[<RequireQualifiedAccess>]
module WaitForActiveShards =
    let mkValue =
        function
        | One -> "1"
        | All -> "All"
        | Other value -> string value

type IndexSettings =
    { NumberOfShards: option<uint16>
      NumberOfReplicas: option<uint16> }
    static member ToJson settings =
        jobj [
           "number_of_shards" .=
                (settings.NumberOfShards |> Option.defaultValue 3us)
           "number_of_replicas" .=
                (settings.NumberOfReplicas |> Option.defaultValue 3us) ]

type Alias =
    { Name: string
      Filter: option<string>
      IndexRouting: option<string>
      IsHidden: option<bool>
      IsWriteIndex: option<bool>
      Routing: option<string>
      SearchRouting: option<string> }
    static member ToJson settings =
        let alias =
            jobj [
               "filter" .=? settings.Filter
               "index_routing" .=? settings.IndexRouting
               "is_hidden" .=? settings.IsHidden
               "is_write_index" .=? settings.IsWriteIndex
               "routing" .=? settings.Routing
               "search_routing" .=? settings.SearchRouting ]
        jobj [ settings.Name .= alias ]

type IndexRequestQueryParams =
    { WaitForActiveShards: option<WaitForActiveShards>
      MasterTimeout: option<uint16<UnitSymbols.s>>
      Timeout: option<uint16<UnitSymbols.s>> }
    
    with
    static member toQueryParams queryParams =
        let waitForActiveShards =
            queryParams.WaitForActiveShards
            |> Option.map (
                WaitForActiveShards.mkValue
                >> sprintf "wait_for_active_shards=%s"
            )

        let masterTimeout =
            queryParams.MasterTimeout
            |> Option.map (sprintf "master_timeout=%A")

        let timeout =
            queryParams.Timeout |> Option.map (sprintf "timeout=%A")

        let mk (values: string []) = sprintf "?%s" <| String.Join("&", values)

        [| waitForActiveShards
           masterTimeout
           timeout |]
        |> Array.choose id
        |> mk

type IndexRequest =
    { Name: string
      Mappings: option<MappingDefinition []>
      Settings: option<IndexSettings>
      Aliases: option<Alias[]>
      Parameters: option<IndexRequestQueryParams> }
    static member ToJson index =
        let mappings =
            let mkMapping (mapping: MappingDefinition) =
                mapping.Name, jobj [ "type" .= mapping.Type ]

            let mkJson mappings =
                let rod = ReadOnlyDictionary(mappings)
                jobj [ "properties" .= (dictAsJsonObject rod) ]

            index.Mappings
            |> Option.map (Array.map mkMapping)
            |> Option.map (dict >> mkJson)
            
        let aliases =
            let mk aliases =
                jobj [
                    "aliases" .= aliases
                ]
            index.Aliases
            |> Option.map (Array.map Alias.ToJson)
            |> Option.map mk

        jobj [ "aliases" .=? aliases
               "settings" .=? index.Settings
               "mappings" .=? mappings ]
        
    static member ToRequest (indexRequest: IndexRequest) =
        let query =
            indexRequest.Parameters
            |> Option.map IndexRequestQueryParams.toQueryParams
            |> Option.defaultValue String.Empty
            
        $"%s{indexRequest.Name}%s{query}"
        |> Http.Request.mk
        |> Http.Request.withMethod Http.Put
        |> Http.Request.withJsonBody indexRequest

type Request = { Query: string }