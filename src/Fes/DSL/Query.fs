namespace Fes.DSL

open System.Text.Json
open Fes
open Fes.DSL.Models.Types

/// <summary>
/// Builder helpers for constructing <see cref="QueryDslQueryContainer"/> values without
/// having to spell out all 60+ optional fields as <c>None</c>. Every function returns a
/// complete container with only the relevant clause populated; all other fields are
/// <c>None</c>.
/// </summary>
[<RequireQualifiedAccess>]
module QueryBuilders =

    let private empty : QueryDslQueryContainer = {
        Bool = Option.None; Boosting = Option.None; Common = Option.None; CombinedFields = Option.None
        ConstantScore = Option.None; DisMax = Option.None; DistanceFeature = Option.None; Exists = Option.None
        FunctionScore = Option.None; Fuzzy = Option.None; GeoBoundingBox = Option.None; GeoDistance = Option.None
        GeoGrid = Option.None; GeoPolygon = Option.None; GeoShape = Option.None; HasChild = Option.None
        HasParent = Option.None; Ids = Option.None; Intervals = Option.None; Knn = Option.None; Match = Option.None
        MatchAll = Option.None; MatchBoolPrefix = Option.None; MatchNone = Option.None; MatchPhrase = Option.None
        MatchPhrasePrefix = Option.None; MoreLikeThis = Option.None; MultiMatch = Option.None; Nested = Option.None
        ParentId = Option.None; Percolate = Option.None; Pinned = Option.None; Prefix = Option.None
        QueryString = Option.None; Range = Option.None; RankFeature = Option.None; Regexp = Option.None
        Rule = Option.None; Script = Option.None; ScriptScore = Option.None; Semantic = Option.None; Shape = Option.None
        SimpleQueryString = Option.None; SpanContaining = Option.None; SpanFieldMasking = Option.None
        SpanFirst = Option.None; SpanMulti = Option.None; SpanNear = Option.None; SpanNot = Option.None
        SpanOr = Option.None; SpanTerm = Option.None; SpanWithin = Option.None; SparseVector = Option.None
        Term = Option.None; Terms = Option.None; TermsSet = Option.None; TextExpansion = Option.None
        WeightedTokens = Option.None; Wildcard = Option.None; Wrapper = Option.None; Type = Option.None
    }

    /// Creates a <c>match_all</c> query that matches every document.
    let matchAll () : QueryDslQueryContainer =
        { empty with MatchAll = Option.Some { Boost = Option.None; Name = Option.None } }

    /// Creates a <c>match</c> query for the given field and query value.
    /// The value is serialized to a <see cref="JsonElement"/> using the library's
    /// JSON settings so that strings, numbers, and booleans are all supported.
    let matchQuery (field: string) (value: 'a) : QueryDslQueryContainer =
        let jsonValue = JsonSerializer.SerializeToElement<'a>(value, Fes.JsonSettings.options)
        let clause : QueryDslMatchQuery = {
            Boost = Option.None; Name = Option.None; Analyzer = Option.None
            AutoGenerateSynonymsPhraseQuery = Option.None; CutoffFrequency = Option.None
            Fuzziness = Option.None; FuzzyRewrite = Option.None; FuzzyTranspositions = Option.None
            Lenient = Option.None; MaxExpansions = Option.None; MinimumShouldMatch = Option.None
            Operator = Option.None; PrefixLength = Option.None
            Query = jsonValue
            ZeroTermsQuery = Option.None
        }
        { empty with Match = Option.Some (Map.ofList [ field, clause ]) }

    /// Creates a <c>term</c> query for an exact field value.
    let term (field: string) (value: 'a) : QueryDslQueryContainer =
        let clause : QueryDslTermQuery = {
            Boost = Option.None; Name = Option.None
            Value = box value
            CaseInsensitive = Option.None
        }
        { empty with Term = Option.Some (Map.ofList [ field, clause ]) }

    /// Creates an <c>exists</c> query that matches documents where the field has a value.
    let exists (field: string) : QueryDslQueryContainer =
        let clause : QueryDslExistsQuery = { Boost = Option.None; Name = Option.None; Field = field }
        { empty with Exists = Option.Some clause }

    /// Creates an <c>ids</c> query that matches documents by their IDs.
    let ids (values: string list) : QueryDslQueryContainer =
        let clause : QueryDslIdsQuery = { Boost = Option.None; Name = Option.None; Values = Option.Some (box values) }
        { empty with Ids = Option.Some clause }

    /// Creates a <c>query_string</c> query using Elasticsearch's query string syntax.
    let queryString (query: string) : QueryDslQueryContainer =
        let clause : QueryDslQueryStringQuery = {
            Boost = Option.None; Name = Option.None; AllowLeadingWildcard = Option.None; Analyzer = Option.None
            AnalyzeWildcard = Option.None; AutoGenerateSynonymsPhraseQuery = Option.None
            DefaultField = Option.None; DefaultOperator = Option.None
            EnablePositionIncrements = Option.None; Escape = Option.None; Fields = Option.None
            Fuzziness = Option.None; FuzzyMaxExpansions = Option.None; FuzzyPrefixLength = Option.None
            FuzzyRewrite = Option.None; FuzzyTranspositions = Option.None; Lenient = Option.None
            MaxDeterminizedStates = Option.None; MinimumShouldMatch = Option.None; PhraseSlop = Option.None
            Query = query
            QuoteAnalyzer = Option.None; QuoteFieldSuffix = Option.None; Rewrite = Option.None
            TieBreaker = Option.None; TimeZone = Option.None; Type = Option.None
        }
        { empty with QueryString = Option.Some clause }

    /// Creates a <c>bool</c> query combining multiple clauses.
    /// Pass <c>Option.None</c> to omit a clause or <c>Option.Some [...]</c> to include it.
    let bool
            (must: QueryDslQueryContainer list option)
            (should: QueryDslQueryContainer list option)
            (mustNot: QueryDslQueryContainer list option)
            (filter: QueryDslQueryContainer list option) : QueryDslQueryContainer =
        let toElement (queries: QueryDslQueryContainer list) =
            JsonSerializer.SerializeToElement<QueryDslQueryContainer list>(queries, Fes.JsonSettings.options)
        let clause : QueryDslBoolQuery = {
            Boost = Option.None; Name = Option.None
            MinimumShouldMatch = Option.None
            Must    = must    |> Option.map toElement
            Should  = should  |> Option.map toElement
            MustNot = mustNot |> Option.map toElement
            Filter  = filter  |> Option.map toElement
        }
        { empty with Bool = Option.Some clause }
