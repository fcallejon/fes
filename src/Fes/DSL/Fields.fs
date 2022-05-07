namespace Fes.DSL

open Fleece

module Formats =
    type DateBuiltInFormats =
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

    type DateFormat =
        | BuiltInFormats of DateBuiltInFormats
        | Custom of string
        
        static member AsJString format =
            match format with
            | Custom value -> value
            | BuiltInFormats EpochMillis -> "epoch_millis"
            | BuiltInFormats EpochSecond -> "epoch_second"
            | BuiltInFormats DateOptionalTime -> "date_optional_time"
            | BuiltInFormats StrictDateOptionalTime -> "strict_date_optional_time"
            | BuiltInFormats StrictDateOptionalTimeNanos -> "strict_date_optional_time_nanos"
            | BuiltInFormats BasicDate -> "basic_date"
            | BuiltInFormats BasicDateTime -> "basic_date_time"
            | BuiltInFormats BasicDateTimeNoMillis -> "basic_date_time_no_millis"
            | BuiltInFormats BasicOrdinalDate -> "basic_ordinal_date"
            | BuiltInFormats BasicOrdinalDateTime -> "basic_ordinal_date_time"
            | BuiltInFormats BasicOrdinalDateTimeNoMillis -> "basic_ordinal_date_time_no_millis"
            | BuiltInFormats BasicTime -> "basic_time"
            | BuiltInFormats BasicTimeNoMillis -> "basic_time_no_millis"
            | BuiltInFormats BasicTTime -> "basic_t_time"
            | BuiltInFormats BasicTTimeNoMillis -> "basic_t_time_no_millis"
            | BuiltInFormats BasicWeekDate -> "basic_week_date"
            | BuiltInFormats StrictBasicWeekDate -> "strict_basic_week_date"
            | BuiltInFormats BasicWeekDateTime -> "basic_week_date_time"
            | BuiltInFormats StrictBasicWeekDateTime -> "strict_basic_week_date_time"
            | BuiltInFormats BasicWeekDateTimeNoMillis -> "basic_week_date_time_no_millis"
            | BuiltInFormats StrictBasicWeekDateTimeNoMillis -> "strict_basic_week_date_time_no_millis"
            | BuiltInFormats Date -> "date"
            | BuiltInFormats StrictDate -> "strict_date"
            | BuiltInFormats DateHour -> "date_hour"
            | BuiltInFormats StrictDateHour -> "strict_date_hour"
            | BuiltInFormats DateHourMinute -> "date_hour_minute"
            | BuiltInFormats StrictDateHourMinute -> "strict_date_hour_minute"
            | BuiltInFormats DateHourMinuteSecond -> "date_hour_minute_second"
            | BuiltInFormats StrictDateHourMinuteSecond -> "strict_date_hour_minute_second"
            | BuiltInFormats DateHourMinuteSecondFraction -> "date_hour_minute_second_fraction"
            | BuiltInFormats StrictDateHourMinuteSecondFraction -> "strict_date_hour_minute_second_fraction"
            | BuiltInFormats DateHourMinuteSecondMillis -> "date_hour_minute_second_millis"
            | BuiltInFormats StrictDateHourMinuteSecondMillis -> "strict_date_hour_minute_second_millis"
            | BuiltInFormats DateTime -> "date_time"
            | BuiltInFormats StrictDateTime -> "strict_date_time"
            | BuiltInFormats DateTimeNoMillis -> "date_time_no_millis"
            | BuiltInFormats StrictDateTimeNoMillis -> "strict_date_time_no_millis"
            | BuiltInFormats Hour -> "hour"
            | BuiltInFormats StrictHour -> "strict_hour"
            | BuiltInFormats HourMinute -> "hour_minute"
            | BuiltInFormats StrictHourMinute -> "strict_hour_minute"
            | BuiltInFormats HourMinuteSecond -> "hour_minute_second"
            | BuiltInFormats StrictHourMinuteSecond -> "strict_hour_minute_second"
            | BuiltInFormats HourMinuteSecondFraction -> "hour_minute_second_fraction"
            | BuiltInFormats StrictHourMinuteSecondFraction -> "strict_hour_minute_second_fraction"
            | BuiltInFormats HourMinuteSecondMillis -> "hour_minute_second_millis"
            | BuiltInFormats StrictHourMinuteSecondMillis -> "strict_hour_minute_second_millis"
            | BuiltInFormats OrdinalDate -> "ordinal_date"
            | BuiltInFormats StrictOrdinalDate -> "strict_ordinal_date"
            | BuiltInFormats OrdinalDateTime -> "ordinal_date_time"
            | BuiltInFormats StrictOrdinalDateTime -> "strict_ordinal_date_time"
            | BuiltInFormats OrdinalDateTimeNoMillis -> "ordinal_date_time_no_millis"
            | BuiltInFormats StrictOrdinalDateTimeNoMillis -> "strict_ordinal_date_time_no_millis"
            | BuiltInFormats Time -> "time"
            | BuiltInFormats StrictTime -> "strict_time"
            | BuiltInFormats TimeNoMillis -> "time_no_millis"
            | BuiltInFormats StrictTimeNoMillis -> "strict_time_no_millis"
            | BuiltInFormats TTime -> "t_time"
            | BuiltInFormats StrictTTime -> "strict_t_time"
            | BuiltInFormats TTimeNoMillis -> "t_time_no_millis"
            | BuiltInFormats StrictTTimeNoMillis -> "strict_t_time_no_millis"
            | BuiltInFormats WeekDate -> "week_date"
            | BuiltInFormats StrictWeekDate -> "strict_week_date"
            | BuiltInFormats WeekDateTime -> "week_date_time"
            | BuiltInFormats StrictWeekDateTime -> "strict_week_date_time"
            | BuiltInFormats WeekDateTimeNoMillis -> "week_date_time_no_millis"
            | BuiltInFormats StrictWeekDateTimeNoMillis -> "strict_week_date_time_no_millis"
            | BuiltInFormats WeekYear -> "weekyear"
            | BuiltInFormats StrictWeekYear -> "strict_weekyear"
            | BuiltInFormats WeekYearWeek -> "weekyear_week"
            | BuiltInFormats StrictWeekYearWeek -> "strict_weekyear_week"
            | BuiltInFormats WeekYearWeekDay -> "weekyear_week_day"
            | BuiltInFormats StrictWeekYearWeekDay -> "strict_weekyear_week_day"
            | BuiltInFormats Year -> "year"
            | BuiltInFormats StrictYear -> "strict_year"
            | BuiltInFormats YearMonth -> "year_month"
            | BuiltInFormats StrictYearMonth -> "strict_year_month"
            | BuiltInFormats YearMonthDay -> "year_month_day"
            | BuiltInFormats StrictYearMonthDay -> "strict_year_month_day"
            |> JString

module FieldTypes =

    type Keywords =
        | Keyword
        | ConstantKeyword
        | Wildcard
        static member ToJson value =
            match value with
            | Keyword -> "keyword"
            | ConstantKeyword -> "constant_keyword"
            | Wildcard -> "wildcard"
            |> JString

        static member OfJson value =
            match value with
            | JString "keyword" -> Decode.Success Keyword
            | JString "constant_keyword" -> Decode.Success ConstantKeyword
            | JString "wildcard" -> Decode.Success Wildcard
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Keyword Type: %s{x}"
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
            | Long -> "long"
            | Integer -> "integer"
            | Short -> "short"
            | Byte -> "byte"
            | Double -> "double"
            | Float -> "float"
            | HalfFloat -> "half_float"
            | ScaledFloat -> "scaled_float"
            | UnsignedLong -> "unsigned_long"
            |> JString

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
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Numeric Type: %s{x}"
            | x -> Decode.Fail.strExpected x

    type DateTypes =
        | Date
        | DateNanos
        static member OfJson value =
            match value with
            | JString "date" -> Decode.Success Date
            | JString "date_nanos" -> Decode.Success DateNanos
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Date Type: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | Date -> "date"
            | DateNanos -> "date_nanos"
            |> JString

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
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Text Type: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | Text -> "text"
            | AnnotatedText -> "annotated_text"
            | Completion -> "completion"
            | SearchAsYouType -> "search_as_you_type"
            | TokenCount -> "token_count"
            |> JString

open FieldTypes

module Fields =

    type FieldType =
        | Keywords of FieldTypes.Keywords
        | Text of TextTypes
        | Numeric of FieldTypes.Numeric
        | Date of DateTypes
        | Nested
        static member OfJson value =
            let nestedFromJson value =
                match value with
                | JString "nested" -> Decode.Success Nested
                | x -> Decode.Fail.strExpected x
            
            let fieldType =
                [| (FieldTypes.Keywords.OfJson value
                    |> Result.map FieldType.Keywords)
                   (TextTypes.OfJson value
                    |> Result.map FieldType.Text)
                   (FieldTypes.Numeric.OfJson value
                    |> Result.map FieldType.Numeric)
                   (DateTypes.OfJson value
                    |> Result.map FieldType.Date)
                   nestedFromJson value |]
                |> Array.tryPick
                    (function
                    | Result.Ok ft -> Some ft
                    | _ -> None)

            match fieldType with
            | Some fieldType' -> Decode.Success fieldType'
            | _ -> Decode.Fail.invalidValue value (sprintf "Wrong Field Type: %s" <| string value)

        static member ToJson value =
            match value with
            | Text text -> TextTypes.ToJson text
            | Keywords keywords -> Keywords.ToJson keywords
            | Numeric numeric -> Numeric.ToJson numeric
            | Date date -> DateTypes.ToJson date
            | Nested -> JString "nested"

        static member Codec () =
            ofObjCodec (
                Text <!> jreq "text" (function Text t -> Some t | _ -> None)
                )

//TODO: Add parameters for Numeric Types
//TODO: Add types from https://www.elastic.co/guide/en/elasticsearch/reference/current/mapping-types.html#structured-data-types