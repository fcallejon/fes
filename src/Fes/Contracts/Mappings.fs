namespace Fes.Contracts.Mappings

open Fes.Contracts.Fields

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