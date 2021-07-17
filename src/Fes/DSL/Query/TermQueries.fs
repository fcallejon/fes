namespace Fes.DSL.Query.TermLevel

open System
open Fes.DSL.Queries
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

type Exists =
    { Field: string }
    static member ToJson term =
        jobj [ "exists" .= jobj [ "field" .= term.Field ] ]

type Fuzzy =
    { Field: string
      Value: string
      Fuzziness: option<string>
      MaxExpansions: option<int>
      PrefixLength: option<int>
      Transpositions: option<bool>
      Rewrite: option<Rewrite> }
    static member ToJson fuzzy =
        let element =
            let inner =
                jobj [ "value" .= fuzzy.Value
                       "fuzziness" .=? fuzzy.Fuzziness
                       "max_expansions" .=? fuzzy.MaxExpansions
                       "prefix_length" .=? fuzzy.PrefixLength
                       "transpositions" .=? fuzzy.Transpositions
                       "rewrite" .=? fuzzy.Rewrite ]

            jobj [ fuzzy.Field .= inner ]

        jobj [ "fuzzy" .= element ]

type Ids =
    { Values: string [] }
    static member ToJson ids =
        jobj [ "ids" .= jobj [ "values" .= ids.Values ] ]

type Prefix =
    { Field: string
      Value: string }
    static member ToJson prefix =
        jobj [ "prefix" .= jobj [ prefix.Field .= prefix.Value ] ]

type RangeRelation =
    | Intersects
    | Contains
    | Within
    static member ToJson relation =
        match relation with
        | Intersects -> "INTERSECTS"
        | Contains -> "CONTAINS"
        | Within -> "WITHIN"
        |> JString

type RangeOperator<'a> =
    | GreaterThan of 'a
    | LessThan of 'a
    | GreaterThanOrEqual of 'a
    | LessThanOrEqual of 'a

type Range<'a> =
    { Field: string
      Operators: RangeOperator<'a> []
      Format: option<string>
      Boost: option<double>
      TimeZone: option<string> }
    static member inline ToJson range =
        let getOperator =
            function
            | GreaterThan value -> "gt", value
            | LessThan value -> "lt", value
            | GreaterThanOrEqual value -> "gte", value
            | LessThanOrEqual value -> "lte", value

        let element =
            let inner =
                jobj [ yield "boost" .=? range.Boost
                       yield "time_zone" .=? range.TimeZone
                       for operator in range.Operators do
                           let op, value = getOperator operator
                           yield op .= value ]

            jobj [ range.Field .= inner ]

        jobj [ "range" .= element ]

type RegExpFlags =
    | All
    | Complement
    | Interval
    | Intersection
    | AnyString
    static member ToJson flag =
        match flag with
        | All -> "ALL"
        | Complement -> "COMPLEMENT"
        | Interval -> "INTERVAL"
        | Intersection -> "INTERSECTION"
        | AnyString -> "ANYSTRING"
        |> JString

type RegExp =
    { Field: string
      Value: string
      Flags: option<RegExpFlags>
      CaseInsensitive: option<bool>
      MaxDeterminizedStates: option<int>
      Rewrite: option<Rewrite> }
    static member ToJson regexp =
        let element =
            let inner =
                jobj [ "value" .= regexp.Value
                       "flags" .=? regexp.Flags
                       "case_insensitive" .=? regexp.CaseInsensitive
                       "max_determinized_states"
                       .=? regexp.MaxDeterminizedStates
                       "rewrite" .=? regexp.Rewrite ]

            jobj [ regexp.Field .= inner ]

        jobj [ "regexp" .= element ]

type Term =
    { Field: string
      Value: string
      Boost: option<double> }
    static member ToJson term =
        let element =
            let inner =
                jobj [ "value" .= term.Value
                       "boost" .=? term.Boost ]

            jobj [ term.Field .= inner ]

        jobj [ "term" .= element ]

type Terms =
    { Field: string
      Values: string []
      Boost: option<double> }
    static member inline ToJson term =
        let element =
            jobj [ term.Field .= jobj [ "values" .= term.Values ] ]

        jobj [ "terms" .= element
               "boost" .=? term.Boost ]

type TermsSet =
    { Field: string
      Terms: string []
      MinimumShouldMatchField: option<string>
      MinimumShouldMatchScript: option<string>
      Boost: option<double> }
    static member ToJson termSet =
        let element =
            jobj [ termSet.Field
                   .= jobj [ "terms" .= termSet.Terms
                             "minimum_should_match_field"
                             .=? termSet.MinimumShouldMatchField
                             "minimum_should_match_script"
                             .=? termSet.MinimumShouldMatchScript
                             "boost" .=? termSet.Boost ] ]

        jobj [ "terms" .= element ]

type TypeTerm =
    { Value: string }
    static member ToJson typeTerm =
        jobj [ "type" .= jobj [ "value" .= typeTerm.Value ] ]

type Wildcard =
    { Field: string
      Value: string
      Boost: option<double>
      CaseInsensitive: option<bool>
      Rewrite: option<Rewrite> }
    static member inline ToJson wildcard =
        let element =
            jobj [ wildcard.Field
                   .= jobj [ "value" .= wildcard.Value
                             "boost" .=? wildcard.Boost
                             "case_insensitive" .=? wildcard.CaseInsensitive
                             "rewrite" .=? wildcard.Rewrite ] ]

        jobj [ "terms" .= element ]

type TermQueryRange =
    | IntegerRange of Range<int>
    | DateTimeRange of Range<DateTime>
with
    static member ToJson query =
        match query with
        | IntegerRange q -> toJson q
        | DateTimeRange q -> toJson q

type TermQuery =
    | Exists of Exists
    | Fuzzy of Fuzzy
    | Ids of Ids
    | Prefix of Prefix
    | Range of TermQueryRange
    | RegExp of RegExp
    | Term of Term
    | Terms of Terms
    | TermsSet of TermsSet
    | TypeTerm of TypeTerm
    | Wildcard of Wildcard
with
    static member ToJson query =
        match query with
        | Exists q -> toJson q
        | Fuzzy q -> toJson q
        | Ids q -> toJson q
        | Prefix q -> toJson q
        | Range q -> toJson q
        | RegExp q -> toJson q
        | Term q -> toJson q
        | Terms q -> toJson q
        | TermsSet q -> toJson q
        | TypeTerm q -> toJson q
        | Wildcard q -> toJson q
