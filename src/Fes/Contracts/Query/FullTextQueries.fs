namespace Fes.Contracts.Query.FullTextQueries

open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

type IntervalFilter =
| After
| Before
| ContainedBy
| Containing
| Overlapping
| NotContainedBy
| NotContaining
| NotOverlapping
| Script
with
    static member ToJson intervalFilter =
        match intervalFilter with
        | After -> "after"
        | Before -> "before"
        | ContainedBy -> "contained_by"
        | Containing -> "containing"
        | Overlapping -> "overlapping"
        | NotContainedBy -> "not_contained_by"
        | NotContaining -> "not_containing"
        | NotOverlapping -> "not_overlapping"
        | Script -> "script"
        |> JString

type MatchInterval =
    { Query: string
      MaxGaps: option<string>
      Ordered: option<bool>
      Analyzer: option<string>
      Filter: option<IntervalFilter>
      UseField: option<string> }
with
    static member ToJson matchInterval =
        let element =
            jobj [ "query" .= matchInterval.Query
                   "max_gaps" .=? matchInterval.MaxGaps
                   "ordered" .=? matchInterval.Ordered
                   "analyzer" .=? matchInterval.Analyzer
                   "filter" .=? matchInterval.Filter
                   "use_field" .=? matchInterval.UseField ]
        in
        jobj [ "match" .= element ]

type PrefixInterval =
    { Prefix: string
      Analyzer: option<string>
      UseField: option<string> }
with
    static member ToJson prefixInterval =
        let element =
            jobj [ "prefix" .= prefixInterval.Prefix
                   "analyzer" .=? prefixInterval.Analyzer
                   "use_field" .=? prefixInterval.UseField ]
        in
        jobj [ "prefix" .= element ]

type WildcardInterval =
    { Pattern: string
      Analyzer: option<string>
      UseField: option<string> }
with
    static member ToJson wildcardInterval =
        let element =
            jobj [ "wildcard" .= wildcardInterval.Pattern
                   "analyzer" .=? wildcardInterval.Analyzer
                   "use_field" .=? wildcardInterval.UseField ]
        in
        jobj [ "wildcard" .= element ]

type FuzzyInterval =
    { Term: string
      PrefixLength: option<int>
      Transportations: option<string>
      Fuzziness: option<string>
      Analyzer: option<string>
      UseField: option<string> }
with
    static member ToJson fuzzyInterval =
        let element =
            jobj [ "term" .= fuzzyInterval.Term
                   "prefix_length" .=? fuzzyInterval.PrefixLength
                   "transpositions" .=? fuzzyInterval.Transportations
                   "fuzziness" .=? fuzzyInterval.Fuzziness
                   "analyzer" .=? fuzzyInterval.Analyzer
                   "use_field" .=? fuzzyInterval.UseField ]
        in
        jobj [ "fuzzy" .= element ]

type IntervalRule =
| MatchRule of MatchInterval
| PrefixRule of PrefixInterval
| WildcardRule of WildcardInterval
| FuzzyRule of FuzzyInterval
with
    static member ToJson rule =
        match rule with
        | MatchRule r -> toJson r
        | PrefixRule r -> toJson r
        | WildcardRule r -> toJson r
        | FuzzyRule r -> toJson r

type AllOfInterval =
    { Intervals: IntervalRule[]
      MaxGaps: option<string>
      Ordered: option<bool>
      Filter: option<IntervalFilter> }
with
    static member ToJson allOfInterval =
        let element =
            jobj [ "intervals" .= allOfInterval.Intervals
                   "max_gaps" .=? allOfInterval.MaxGaps
                   "ordered" .=? allOfInterval.Ordered
                   "filter" .=? allOfInterval.Filter ]
        in
        jobj [ "all_of" .= element ]

type AnyOfInterval =
    { Intervals: IntervalRule[]
      Filter: option<IntervalFilter> }
with
    static member ToJson anyOfInterval =
        let element =
            jobj [ "intervals" .= anyOfInterval.Intervals
                   "filter" .=? anyOfInterval.Filter ]
        in
        jobj [ "any_of" .= element ]