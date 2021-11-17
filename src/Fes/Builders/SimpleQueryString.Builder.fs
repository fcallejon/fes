namespace Fes.Builders

[<AutoOpen>]
module SimpleQueryStringBuilder =
    open Fes.DSL.Query.Queries
    open Fes.DSL.Query.FullTextQueries
    
    type SimpleQueryStringBuilder() =
        member _.Yield _ =
            { Query = defaultQuery
              Fields = None
              DefaultOperator = None
              AnalyzeWildcard = None
              Analyzer = None
              AutoGenerateSynonymsPhraseQuery = None
              Flags = None
              FuzzyTransportations = None
              FuzzyMaxExpansions = None
              FuzzyPrefixLength = None
              MinimumShouldMatch = None
              Lenient = None
              QuoteFieldSuffix = None }
            
        member _.Run state =
            state
            |> SimpleQueryString
            |> Query.FullTextQueries
        
        [<CustomOperation "query" >]
        member _.Query  (state: SimpleQueryString, value) = { state with Query = value }
        
        [<CustomOperation "fields" >]
        member _.Fields  (state: SimpleQueryString, value) = { state with Fields = Some value }
        
        [<CustomOperation "field" >]
        member _.Field  (state: SimpleQueryString, value) =
            let fields =
                match value with
                | Some f -> Some [| f |]
                | None -> None
            { state with Fields = fields }
        
        [<CustomOperation "defaultOperator" >]
        member _.DefaultOperator  (state: SimpleQueryString, value) = { state with DefaultOperator = Some value }
        
        [<CustomOperation "analyzeWildcard" >]
        member _.AnalyzeWildcard  (state: SimpleQueryString, value) = { state with AnalyzeWildcard = Some value }
        
        [<CustomOperation "analyzer" >]
        member _.Analyzer  (state: SimpleQueryString, value) = { state with Analyzer = Some value }
        
        [<CustomOperation "autoGenerateSynonymsPhraseQuery" >]
        member _.AutoGenerateSynonymsPhraseQuery  (state: SimpleQueryString, value) = { state with AutoGenerateSynonymsPhraseQuery = Some value }
        
        [<CustomOperation "flags" >]
        member _.Flags  (state: SimpleQueryString, value) = { state with Flags = Some value }
        
        [<CustomOperation "minimumShouldMatch" >]
        member _.MinimumShouldMatch  (state: SimpleQueryString, value) = { state with MinimumShouldMatch = Some value }
        
        [<CustomOperation "quoteFieldSuffix" >]
        member _.QuoteFieldSuffix  (state: SimpleQueryString, value) = { state with QuoteFieldSuffix = Some value }
        
        [<CustomOperation "fuzzyTransportations" >]
        member _.FuzzyTransportations  (state: SimpleQueryString, value) = { state with FuzzyTransportations = Some value }
        
        [<CustomOperation "lenient" >]
        member _.Lenient  (state: SimpleQueryString, value) = { state with Lenient = Some value }
        
        [<CustomOperation "fuzzyMaxExpansions" >]
        member _.FuzzyMaxExpansions  (state: SimpleQueryString, value) = { state with FuzzyMaxExpansions = Some value }
        
        [<CustomOperation "fuzzyPrefixLength" >]
        member _.FuzzyPrefixLength  (state: SimpleQueryString, value) = { state with FuzzyPrefixLength = Some value }
        
    let simpleQueryString = SimpleQueryStringBuilder()