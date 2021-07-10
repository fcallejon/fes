namespace Fes.Contracts.Query.FullTextQueries

open System
open Fes.Contracts.Queries
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

type ZeroTermsQueries =
| None
| All
with
    static member ToJson zeroTermsQueries =
        match zeroTermsQueries with
        | None -> "none"
        | All -> "all"
        |> JString

[<RequireQualifiedAccess>]
module Intervals =
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
    { Intervals: Intervals.IntervalRule[]
      MaxGaps: option<string>
      Ordered: option<bool>
      Filter: option<Intervals.IntervalFilter> }
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
    { Intervals: Intervals.IntervalRule[]
      Filter: option<Intervals.IntervalFilter> }
with
    static member ToJson anyOfInterval =
        let element =
            jobj [ "intervals" .= anyOfInterval.Intervals
                   "filter" .=? anyOfInterval.Filter ]
        in
        jobj [ "any_of" .= element ]
        
[<RequireQualifiedAccess>]
module MatchQueries =
    type CommonQuery =
        { Query: string
          Analyzer: option<string>
          AutoGenerateSynonymsPhraseQuery: option<bool>
          Fuzziness: option<string>
          MaxExpansions: option<int>
          PrefixLength: option<string>
          FuzzyTransportations: option<bool>
          FuzzyRewrite: option<Rewrite>
          Lenient: option<bool>
          Operator: option<QueryOperator>
          MinimumShouldMatch: option<string>
          ZeroTermsQuery: option<ZeroTermsQueries> }
    with
        static member ToJson commonQuery =
            jobj [ "query" .= commonQuery.Query
                   "analyzer" .=? commonQuery.Analyzer
                   "auto_generate_synonyms_phrase_query" .=? commonQuery.AutoGenerateSynonymsPhraseQuery
                   "fuzziness" .=? commonQuery.Fuzziness
                   "max_expansions" .=? commonQuery.MaxExpansions
                   "prefix_length" .=? commonQuery.PrefixLength
                   "fuzzy_transpositions" .=? commonQuery.FuzzyTransportations
                   "fuzzy_rewrite" .=? commonQuery.FuzzyRewrite
                   "lenient" .=? commonQuery.Lenient
                   "operator" .=? commonQuery.Operator
                   "minimum_should_match" .=? commonQuery.MinimumShouldMatch
                   "zero_terms_query" .=? commonQuery.ZeroTermsQuery ]
            
    type MatchCommonQuery =
        { Field: string
          Query: CommonQuery }
    with
        static member ToJson matchQuery =
            jobj [ matchQuery.Field .= matchQuery.Query ]
            
    type MatchPhrasePrefixQuery =
        { Field: string
          Query: string
          Analyzer: option<string>
          MaxExpansions: option<int>
          Slop: option<int>
          ZeroTermsQuery: option<ZeroTermsQueries> }
    with
        static member ToJson matchQuery =
            let element =
                jobj [ "query" .= matchQuery.Query
                       "analyzer" .=? matchQuery.Analyzer
                       "max_expansions" .=? matchQuery.MaxExpansions
                       "slop" .=? matchQuery.Slop
                       "zero_terms_query" .=? matchQuery.ZeroTermsQuery ]
            in
            jobj [ matchQuery.Field .= element ]

module MultiMatchQueries =
    type BestFields =
        { Fields: string[]
          Query: string
          Analyzer: option<string>
          Boost: option<double>
          Operator: option<QueryOperator>
          MinimumShouldMatch: option<string>
          Fuzziness: option<string>
          Lenient: option<bool>
          PrefixLength: option<string>
          MaxExpansions: option<int>
          FuzzyRewrite: option<Rewrite>
          ZeroTermsQuery: option<ZeroTermsQueries>
          AutoGenerateSynonymsPhraseQuery: option<bool>
          FuzzyTransportations: option<bool>
          TieBreaker: option<double> }
    with
        static member ToJson bestFields =
            jobj [ "query" .= bestFields.Query
                   "fields" .= bestFields.Fields
                   "analyzer" .=? bestFields.Analyzer
                   "boost" .=? bestFields.Boost
                   "operator" .=? bestFields.Operator
                   "minimum_should_match" .=? bestFields.MinimumShouldMatch
                   "fuzziness" .=? bestFields.Fuzziness
                   "lenient" .=? bestFields.Lenient
                   "prefix_length" .=? bestFields.PrefixLength
                   "max_expansions" .=? bestFields.MaxExpansions
                   "fuzzy_rewrite" .=? bestFields.FuzzyRewrite
                   "zero_terms_query" .=? bestFields.ZeroTermsQuery
                   "auto_generate_synonyms_phrase_query" .=? bestFields.AutoGenerateSynonymsPhraseQuery
                   "fuzzy_transportations" .=? bestFields.FuzzyTransportations
                   "tie_breaker" .=? bestFields.TieBreaker ]
    
    type MostFields =
        { Fields: string[]
          Query: string
          Analyzer: option<string>
          Boost: option<double>
          Operator: option<QueryOperator>
          MinimumShouldMatch: option<string>
          Fuzziness: option<string>
          Lenient: option<bool>
          PrefixLength: option<string>
          MaxExpansions: option<int>
          FuzzyRewrite: option<Rewrite>
          ZeroTermsQuery: option<ZeroTermsQueries> }
    with
        static member ToJson mostFields =
            jobj [ "query" .= mostFields.Query
                   "fields" .= mostFields.Fields
                   "analyzer" .=? mostFields.Analyzer
                   "boost" .=? mostFields.Boost
                   "operator" .=? mostFields.Operator
                   "minimum_should_match" .=? mostFields.MinimumShouldMatch
                   "fuzziness" .=? mostFields.Fuzziness
                   "lenient" .=? mostFields.Lenient
                   "prefix_length" .=? mostFields.PrefixLength
                   "max_expansions" .=? mostFields.MaxExpansions
                   "fuzzy_rewrite" .=? mostFields.FuzzyRewrite
                   "zero_terms_query" .=? mostFields.ZeroTermsQuery ]
        
    type Phrase =
        { Fields: string[]
          Query: string
          Analyzer: option<string>
          Boost: option<double>
          Lenient: option<bool>
          Slop: option<int>
          ZeroTermsQuery: option<ZeroTermsQueries> }
    with
        static member ToJson phrase =
            jobj [ "query" .= phrase.Query
                   "fields" .= phrase.Fields
                   "analyzer" .=? phrase.Analyzer
                   "boost" .=? phrase.Boost
                   "lenient" .=? phrase.Lenient
                   "slop" .=? phrase.Slop
                   "zero_terms_query" .=? phrase.ZeroTermsQuery ]
        
    type CrossFields =
        { Fields: string[]
          Query: string
          Analyzer: option<string>
          Boost: option<double>
          Operator: option<QueryOperator>
          MinimumShouldMatch: option<string>
          Lenient: option<bool>
          ZeroTermsQuery: option<ZeroTermsQueries>
          TieBreaker: option<double> }
    with
        static member ToJson mostFields =
            jobj [ "query" .= mostFields.Query
                   "fields" .= mostFields.Fields
                   "analyzer" .=? mostFields.Analyzer
                   "boost" .=? mostFields.Boost
                   "operator" .=? mostFields.Operator
                   "minimum_should_match" .=? mostFields.MinimumShouldMatch
                   "lenient" .=? mostFields.Lenient
                   "zero_terms_query" .=? mostFields.ZeroTermsQuery
                   "tie_breaker" .=? mostFields.TieBreaker ]
        
    type BoolPrefix =
        { Fields: string[]
          Query: string
          Analyzer: option<string>
          Boost: option<double>
          Operator: option<QueryOperator>
          MinimumShouldMatch: option<string>
          Lenient: option<bool>
          AutoGenerateSynonymsPhraseQuery: option<bool>
          ZeroTermsQuery: option<ZeroTermsQueries>
          FuzzyTransportations: option<bool>
          FuzzyRewrite: option<Rewrite>
          Fuzziness: option<string>
          PrefixLength: option<string>
          MaxExpansions: option<int> }
    with
        static member ToJson boolPrefix =
            jobj [ "query" .= boolPrefix.Query
                   "fields" .= boolPrefix.Fields
                   "analyzer" .=? boolPrefix.Analyzer
                   "boost" .=? boolPrefix.Boost
                   "operator" .=? boolPrefix.Operator
                   "minimum_should_match" .=? boolPrefix.MinimumShouldMatch
                   "fuzziness" .=? boolPrefix.Fuzziness
                   "lenient" .=? boolPrefix.Lenient
                   "prefix_length" .=? boolPrefix.PrefixLength
                   "max_expansions" .=? boolPrefix.MaxExpansions
                   "fuzzy_rewrite" .=? boolPrefix.FuzzyRewrite
                   "fuzzy_transportations" .=? boolPrefix.FuzzyTransportations
                   "zero_terms_query" .=? boolPrefix.ZeroTermsQuery
                   "auto_generate_synonyms_phrase_query" .=? boolPrefix.AutoGenerateSynonymsPhraseQuery ]
        
    type Queries =
    | BestFields of BestFields
    | MostFields of MostFields
    | Phrase of Phrase
    | CrossFields of CrossFields
    | BoolPrefix of BoolPrefix
    with
        static member ToJson query =
            match query with
            | BestFields m -> toJson m
            | MostFields m -> toJson m
            | Phrase m -> toJson m
            | CrossFields m -> toJson m
            | BoolPrefix m -> toJson m

type MatchQueries =
| Match of MatchQueries.MatchCommonQuery
| MatchBoolPrefix of MatchQueries.MatchCommonQuery
| MatchPhrase of MatchQueries.MatchCommonQuery
| MatchPhrasePrefix of MatchQueries.MatchPhrasePrefixQuery
| MultiMatch of MultiMatchQueries.Queries
with
    static member ToJson query =
        match query with
        | Match m -> jobj [ "match" .= m ]
        | MatchBoolPrefix m -> jobj [ "match_bool_prefix" .= m ]
        | MatchPhrase m -> jobj [ "match_phrase" .= m ]
        | MatchPhrasePrefix m -> jobj [ "match_phrase_prefix" .= m ]
        | MultiMatch m -> jobj [ "multi_match" .= m ]
        
type CombinedFields =
    { Query: string
      Fields: string[]
      Operator: option<QueryOperator>
      AutoGenerateSynonymsPhraseQuery: option<bool>
      MinimumShouldMatch: option<string>
      ZeroTermsQuery: option<ZeroTermsQueries> }
with
    static member ToJson queryString =
        jobj [ "query" .= queryString.Query
               "fields" .= queryString.Fields
               "operator" .=? queryString.Operator
               "minimum_should_match" .=? queryString.MinimumShouldMatch
               "zero_terms_query" .=? queryString.ZeroTermsQuery
               "auto_generate_synonyms_phrase_query" .=? queryString.AutoGenerateSynonymsPhraseQuery ]
        
type QueryString =
    { Query: string
      DefaultField: option<string>
      Fields: option<string[]>
      DefaultOperator: option<BooleanLogicOperator>
      AllowLeadingWildcard: option<bool>
      AnalyzeWildcard: option<bool>
      Analyzer: option<string>
      AutoGenerateSynonymsPhraseQuery: option<bool>
      Boost: option<double>
      MinimumShouldMatch: option<string>
      ZeroTermsQuery: option<ZeroTermsQueries>
      FuzzyTransportations: option<bool>
      FuzzyRewrite: option<Rewrite>
      Fuzziness: option<string>
      FuzzyMaxExpansions: option<int>
      FuzzyPrefixLength: option<int>
      Lenient: option<bool>
      PhraseSlop: option<int>
      Rewrite: option<Rewrite>
      QuoteFieldSuffix: option<string>
      QuoteAnalyzer: option<string>
      MaxDeterminizedStates: option<int>
      EnablePositionIncrements: option<bool>
      TimeZone: option<string> }
with
    static member ToJson queryString =
        jobj [ "query" .= queryString.Query
               "fields" .= queryString.Fields
               "default_operator" .=? queryString.DefaultOperator
               "default_field" .=? queryString.DefaultField
               "allow_leading_wildcard" .=? queryString.AllowLeadingWildcard
               "analyze_wildcard" .=? queryString.AnalyzeWildcard
               "analyzer" .=? queryString.Analyzer
               "auto_generate_synonyms_phrase_query" .=? queryString.AutoGenerateSynonymsPhraseQuery
               "boost" .=? queryString.Boost
               "enable_position_increments" .=? queryString.EnablePositionIncrements
               "fields" .=? queryString.Fields
               "fuzziness" .=? queryString.Fuzziness
               "fuzzy_max_expansions" .=? queryString.FuzzyMaxExpansions
               "fuzzy_prefix_length" .=? queryString.FuzzyPrefixLength
               "fuzzy_transpositions" .=? queryString.FuzzyTransportations
               "lenient" .=? queryString.Lenient
               "max_determinized_states" .=? queryString.MaxDeterminizedStates
               "quote_analyzer" .=? queryString.QuoteAnalyzer
               "phrase_slop" .=? queryString.PhraseSlop
               "quote_field_suffix" .=? queryString.QuoteFieldSuffix
               "rewrite" .=? queryString.Rewrite
               "time_zone" .=? queryString.TimeZone ]
        
type SimpleQueryStringLimitOperator =
| All
| And
| Escape
| Fuzzy
| Near
| None
| Not
| Or
| Phrase
| Precedence
| Prefix
| Slop
| Whitespace
with
    static member ToString op =
        match op with
        | All -> "ALL"
        | And -> "AND"
        | Escape -> "ESCAPE"
        | Fuzzy -> "FUZZY"
        | Near -> "NEAR"
        | None -> "NONE"
        | Not -> "NOT"
        | Or -> "OR"
        | Phrase -> "PHRASE"
        | Precedence -> "PRECEDENCE"
        | Prefix -> "PREFIX"
        | Slop -> "SLOP"
        | Whitespace -> "WHITESPACE"

type SimpleQueryString =
    { Query: string
      Fields: option<string[]>
      DefaultOperator: option<BooleanLogicOperator>
      AnalyzeWildcard: option<bool>
      Analyzer: option<string>
      AutoGenerateSynonymsPhraseQuery: option<bool>
      Flags: option<SimpleQueryStringLimitOperator[]>
      FuzzyTransportations: option<bool>
      FuzzyMaxExpansions: option<int>
      FuzzyPrefixLength: option<int>
      MinimumShouldMatch: option<string>
      Lenient: option<bool>
      QuoteFieldSuffix: option<string> }
with
    static member ToJson simpleQueryString =
        let flags =
            let join =
                (Array.map SimpleQueryStringLimitOperator.ToString) >> (fun x -> String.Join("|", x))
            simpleQueryString.Flags
            |> Option.map join
        jobj [ "query" .= simpleQueryString.Query
               "fields" .= simpleQueryString.Fields
               "default_operator" .=? simpleQueryString.DefaultOperator
               "analyze_wildcard" .=? simpleQueryString.AnalyzeWildcard
               "analyzer" .=? simpleQueryString.Analyzer
               "auto_generate_synonyms_phrase_query" .=? simpleQueryString.AutoGenerateSynonymsPhraseQuery
               "flags" .=? flags
               "fuzzy_max_expansions" .=? simpleQueryString.FuzzyMaxExpansions
               "fuzzy_prefix_length" .=? simpleQueryString.FuzzyPrefixLength
               "fuzzy_transpositions" .=? simpleQueryString.FuzzyTransportations
               "lenient" .=? simpleQueryString.Lenient
               "minimum_should_match" .=? simpleQueryString.MinimumShouldMatch
               "quote_field_suffix" .=? simpleQueryString.QuoteFieldSuffix ]
        
type FullTextQueries =
| AllOfInterval of AllOfInterval
| AnyOfInterval of AnyOfInterval
| MatchQueries of MatchQueries
| CombinedFields of CombinedFields
| QueryString of QueryString
| SimpleQueryString of SimpleQueryString