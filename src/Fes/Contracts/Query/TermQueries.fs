namespace Fes.Contracts.Query.TermLevel

open System
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

type Rewrite =
| ConstantScore
| ConstantScoreBoolean
| ScoringBoolean
| TopTermsBlendedFreqsN
| TopTermsBoostN
| TopTermsN
with
    static member ToJson rewrite =
        match rewrite with
        | ConstantScore -> "constant_score"
        | ConstantScoreBoolean -> "constant_score_boolean"
        | ScoringBoolean -> "scoring_boolean"
        | TopTermsBlendedFreqsN -> "top_terms_blended_freqs_N"
        | TopTermsBoostN -> "top_terms_boost_N"
        | TopTermsN -> "top_terms_N"
        |> JString

type Exists = { Field: string }
with
    static member ToJson term =
        jobj [ "exists" .= jobj [ "field" .= term.Field ]  ]

type Fuzzy =
    { Field: string
      Value: string
      Fuzziness: option<string>
      MaxExpansions: option<int>
      PrefixLength: option<int>
      Transpositions: option<bool>
      Rewrite: option<Rewrite> }
with
    static member ToJson fuzzy =
        let element =
            let inner =
                jobj [ "value" .= fuzzy.Value
                       "fuzziness" .=? fuzzy.Fuzziness
                       "max_expansions" .=? fuzzy.MaxExpansions
                       "prefix_length" .=? fuzzy.PrefixLength
                       "transpositions" .=? fuzzy.Transpositions
                       "rewrite" .=? fuzzy.Rewrite ]
            in
            jobj [ fuzzy.Field .= inner ]
        in
        jobj [ "fuzzy" .= element ]

type Ids = { Values: string[] }
with
    static member ToJson ids =
        jobj [ "ids" .= jobj [ "values" .= ids.Values ]  ]

type Prefix =
    { Field: string
      Value: string }
with
    static member ToJson prefix =
        jobj [ "prefix" .= jobj [ prefix.Field .= prefix.Value ]  ]

type RangeRelation =
| Intersects
| Contains
| Within
with
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
      Operators: RangeOperator<'a>[]
      Format: option<string>
      Boost: option<double>
      TimeZone: option<string> }
with
    static member inline ToJson range =
        let getOperator =
            function
            | GreaterThan value -> "gt", value
            | LessThan value -> "lt", value
            | GreaterThanOrEqual value -> "gte", value
            | LessThanOrEqual value -> "lte", value
            
        let element =
            let inner =
                jobj [
                    yield "boost" .=? range.Boost
                    yield "time_zone" .=? range.TimeZone
                    for operator in range.Operators do
                        let op, value = getOperator operator
                        yield op .= value
                ]
            in
            jobj [ range.Field .= inner ]
        jobj [ "range" .= element ]            

type RegExpFlags =
| All
| Complement
| Interval
| Intersection
| AnyString
with
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
      CaseInsensitive : option<bool>
      MaxDeterminizedStates: option<int>
      Rewrite: option<Rewrite> }
with
    static member ToJson regexp =
        let element =
            let inner =
                jobj [ "value" .= regexp.Value
                       "flags" .=? regexp.Flags
                       "case_insensitive" .=? regexp.CaseInsensitive
                       "max_determinized_states" .=? regexp.MaxDeterminizedStates
                       "rewrite" .=? regexp.Rewrite ]
            in
            jobj [ regexp.Field .= inner ]
        in
        jobj [ "regexp" .= element ]

type Term =
    { Field: string
      Value: string
      Boost: option<double> }
with
    static member ToJson term =
        let element =
            let inner =
                jobj [ "value" .= term.Value
                       "boost" .=? term.Boost ]
            in
            jobj [ term.Field .= inner ]
        in
        jobj [ "term" .= element ]

type Terms =
    { Field: string
      Values: string[]
      Boost: option<double> }
with
    static member inline ToJson term =
        let element =
            jobj [ term.Field .= jobj [ "values" .= term.Values ] ]
        in
        jobj [ "terms" .= element
               "boost" .=? term.Boost ]

type TermsSet = 
    { Field: string
      Terms: string[]
      MinimumShouldMatchField: option<string>
      MinimumShouldMatchScript: option<string>
      Boost: option<double> }
with
    static member ToJson termSet =
        let element =
            jobj [ termSet.Field .=
                   jobj [ "terms" .= termSet.Terms
                          "minimum_should_match_field" .=? termSet.MinimumShouldMatchField
                          "minimum_should_match_script" .=? termSet.MinimumShouldMatchScript
                          "boost" .=? termSet.Boost ] ]
        in
        jobj [ "terms" .= element ]

type TypeTerm = { Value: string }
with
    static member ToJson typeTerm =
        jobj [ "type" .= jobj [ "value" .= typeTerm.Value ] ]

type Wildcard =
    { Field: string
      Value: string
      Boost: option<double>
      CaseInsensitive : option<bool>
      Rewrite: option<Rewrite> }
with
    static member inline ToJson wildcard =
        let element =
            jobj [ wildcard.Field .=
                   jobj [ "value" .= wildcard.Value
                          "boost" .=? wildcard.Boost
                          "case_insensitive" .=? wildcard.CaseInsensitive
                          "rewrite" .=? wildcard.Rewrite ] ]
        in
        jobj [ "terms" .= element ]

type TermQueryRange =
| IntegerRange of Range<int>
| DateTimeRange of Range<DateTime>

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