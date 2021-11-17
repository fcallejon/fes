namespace Fes.Builders


[<AutoOpen>]
module QueryStringBuilder =
    open Fes.DSL.Query.Queries
    open Fes.DSL.Query.FullTextQueries
    
    type QueryStringBuilder() =
        member _.Yield _ =
            { Query = defaultQuery
              DefaultField = None 
              Fields = None 
              DefaultOperator = None 
              AllowLeadingWildcard = None 
              AnalyzeWildcard = None 
              Analyzer = None 
              AutoGenerateSynonymsPhraseQuery = None 
              Boost = None 
              MinimumShouldMatch = None 
              ZeroTermsQuery = None 
              FuzzyTransportations = None 
              FuzzyRewrite = None 
              Fuzziness = None 
              FuzzyMaxExpansions = None 
              FuzzyPrefixLength = None 
              Lenient = None 
              PhraseSlop = None 
              Rewrite = None 
              QuoteFieldSuffix = None 
              QuoteAnalyzer = None 
              MaxDeterminizedStates = None 
              EnablePositionIncrements = None 
              TimeZone = None }
            
        member _.Run state =
            state
            |> QueryString
            |> Query.FullTextQueries
        
        [<CustomOperation "query" >]
        member _.Query (state: QueryString, value) = { state with Query = value }
        
        [<CustomOperation "defaultField" >]
        member _.DefaultField (state: QueryString, value) = { state with DefaultField = Some value }
        
        [<CustomOperation "fields" >]
        member _.Fields (state: QueryString, value) = { state with Fields = Some value }
        
        [<CustomOperation "field" >]
        member _.Field (state: QueryString, value) =
            let fields =
                match value with
                | Some f -> Some [| f |]
                | None -> None
            { state with Fields = fields }
        
        [<CustomOperation "defaultOperator" >]
        member _.DefaultOperator (state: QueryString, value) = { state with DefaultOperator = Some value }
        
        [<CustomOperation "allowLeadingWildcard" >]
        member _.AllowLeadingWildcard (state: QueryString, value) = { state with AllowLeadingWildcard = Some value }
        
        [<CustomOperation "analyzeWildcard" >]
        member _.AnalyzeWildcard (state: QueryString, value) = { state with AnalyzeWildcard = Some value }
        
        [<CustomOperation "analyzer" >]
        member _.Analyzer (state: QueryString, value) = { state with Analyzer = Some value }
        
        [<CustomOperation "autoGenerateSynonymsPhraseQuery" >]
        member _.AutoGenerateSynonymsPhraseQuery (state: QueryString, value) = { state with AutoGenerateSynonymsPhraseQuery = Some value }
        
        [<CustomOperation "boost" >]
        member _.Boost (state: QueryString, value) = { state with Boost = Some value }
        
        [<CustomOperation "minimumShouldMatch" >]
        member _.MinimumShouldMatch (state: QueryString, value) = { state with MinimumShouldMatch = Some value }
        
        [<CustomOperation "zeroTermsQuery" >]
        member _.ZeroTermsQuery (state: QueryString, value) = { state with ZeroTermsQuery = Some value }
        
        [<CustomOperation "fuzzyTransportations" >]
        member _.FuzzyTransportations (state: QueryString, value) = { state with FuzzyTransportations = Some value }
        
        [<CustomOperation "fuzzyRewrite" >]
        member _.FuzzyRewrite (state: QueryString, value) = { state with FuzzyRewrite = Some value }
        
        [<CustomOperation "fuzziness" >]
        member _.Fuzziness (state: QueryString, value) = { state with Fuzziness = Some value }
        
        [<CustomOperation "fuzzyMaxExpansions" >]
        member _.FuzzyMaxExpansions (state: QueryString, value) = { state with FuzzyMaxExpansions = Some value }
        
        [<CustomOperation "fuzzyPrefixLength" >]
        member _.FuzzyPrefixLength (state: QueryString, value) = { state with FuzzyPrefixLength = Some value }
        
        [<CustomOperation "lenient" >]
        member _.Lenient (state: QueryString, value) = { state with Lenient = Some value }
        
        [<CustomOperation "phraseSlop" >]
        member _.PhraseSlop (state: QueryString, value) = { state with PhraseSlop = Some value }
        
        [<CustomOperation "rewrite" >]
        member _.Rewrite (state: QueryString, value) = { state with Rewrite = Some value }
        
        [<CustomOperation "quoteFieldSuffix" >]
        member _.QuoteFieldSuffix (state: QueryString, value) = { state with QuoteFieldSuffix = Some value }
        
        [<CustomOperation "quoteAnalyzer" >]
        member _.QuoteAnalyzer (state: QueryString, value) = { state with QuoteAnalyzer = Some value }
        
        [<CustomOperation "maxDeterminizedStates" >]
        member _.MaxDeterminizedStates (state: QueryString, value) = { state with MaxDeterminizedStates = Some value }
        
        [<CustomOperation "enablePositionIncrements" >]
        member _.EnablePositionIncrements (state: QueryString, value) = { state with EnablePositionIncrements = Some value }
        
        [<CustomOperation "timeZone" >]
        member _.TimeZone (state: QueryString, value) = { state with TimeZone = Some value }
        
    let queryString = QueryStringBuilder()