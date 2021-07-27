namespace Fes.Sample

open Fes.DSL.Query.FullTextQueries
open Fes.DSL.Query.Queries
open Fes.DSL.Query.TermLevel
open Fes.DSL.Search

[<RequireQualifiedAccess>]
module Query =
    let mkTermQuery field value =
        { Term.Field = field
          Value = string value
          Boost = Option.None }
        |> Term
        |> TermQuery
        
    let mkQueryString field value =
        let fields =
            match field with
            | Some f -> Some [| f |]
            | None -> None
        in
        { QueryString.Query = value
          DefaultField = None
          Fields = fields
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
        |> QueryString
        |> FullTextQueries
        
[<RequireQualifiedAccess>]
module Search =
    let mkTermSearch target field value =
        { SearchCommandRequest.Target = Some target
          Query = Some <| Query.mkTermQuery field value
          SeqNoPrimaryTerm = Some true
          Version = Some true
          DocValueFields = None
          Explain = None
          Fields = None
          From = None
          IndicesBoost = None
          MinScore = None
          PointInTime = None
          RuntimeMappings = None
          Size = None
          Source = None
          Stats = None
          TerminateAfter = None
          Timeout = None
          QueryStringParameters = None }
        
    
    let mkQueryString target field value =
        { SearchCommandRequest.Target = Some target
          Query = Some <| Query.mkQueryString field value
          SeqNoPrimaryTerm = Some true
          Version = Some true
          DocValueFields = None
          Explain = None
          Fields = None
          From = None
          IndicesBoost = None
          MinScore = None
          PointInTime = None
          RuntimeMappings = None
          Size = None
          Source = None
          Stats = None
          TerminateAfter = None
          Timeout = None
          QueryStringParameters = None }