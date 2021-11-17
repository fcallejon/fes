namespace Fes.Builders

open System
open Fes.DSL.Query.Queries

[<AutoOpen>]
module TermQueriesBuilder =
    open Fes.DSL.Query.TermLevel
    
    type ExistsBuilder () =
        member _.Yield _ =
            { Exists.Field = String.Empty }
            
        [<CustomOperation "field" >]
        member _.Field (state: Exists, value) = { state with Field = value }
            
        member _.Run state =
            state
            |> Exists
            |> Query.TermQuery
            
    type FuzzyBuilder() =
        member _.Yield _ =
            { Fuzzy.Field = String.Empty
              Value = String.Empty
              Fuzziness = None
              MaxExpansions = None
              PrefixLength = None
              Transpositions = None
              Rewrite = None }
            
        [<CustomOperation "field" >]
        member _.Field (state: Fuzzy, value) = { state with Field = value }
            
        [<CustomOperation "value" >]
        member _.Value (state: Fuzzy, value) = { state with Value = value }
            
        [<CustomOperation "fuzziness" >]
        member _.Fuzziness (state: Fuzzy, value) = { state with Fuzziness = Some value }
            
        [<CustomOperation "maxExpansions" >]
        member _.MaxExpansions (state: Fuzzy, value) = { state with MaxExpansions = Some value }
            
        [<CustomOperation "prefixLength" >]
        member _.PrefixLength (state: Fuzzy, value) = { state with PrefixLength = Some value }
            
        [<CustomOperation "transpositions" >]
        member _.Transpositions (state: Fuzzy, value) = { state with Transpositions = Some value }
            
        [<CustomOperation "rewrite" >]
        member _.Rewrite (state: Fuzzy, value) = { state with Rewrite = Some value }
            
        member _.Run state =
            state
            |> Fuzzy
            |> Query.TermQuery
    
    type IdsBuilder () =
        member _.Yield _ =
            { Ids.Values = Array.empty }
            
        [<CustomOperation "values" >]
        member _.Values (state: Ids, value) = { state with Values = value }
            
        member _.Run state =
            state
            |> Ids
            |> Query.TermQuery
    
    type PrefixBuilder () =
        member _.Yield _ =
            { Prefix.Field = String.Empty
              Value = String.Empty }
            
        [<CustomOperation "field" >]
        member _.Field (state: Prefix, value) = { state with Field = value }
            
        [<CustomOperation "value" >]
        member _.Value (state: Prefix, value) = { state with Value = value }
            
        member _.Run state =
            state
            |> Prefix
            |> Query.TermQuery
        
    type RangeBuilder<'a> (toTermQueryRange: Range<'a> -> TermQueryRange) =
        member _.Yield _ =
            { Range.Field = String.Empty
              Operators = Array.empty
              Format = None
              Boost = None
              TimeZone = None
              RangeRelation = None }
            
        [<CustomOperation "field" >]
        member _.Field (state: Range<'a>, value) = { state with Field = value }
            
        [<CustomOperation "operators" >]
        member _.Operators (state: Range<'a>, value) = { state with Operators = value }
            
        [<CustomOperation "format" >]
        member _.Format (state: Range<'a>, value) = { state with Format = Some value }
            
        [<CustomOperation "boost" >]
        member _.Boost (state: Range<'a>, value) = { state with Boost = Some value }
            
        [<CustomOperation "timeZone" >]
        member _.TimeZone (state: Range<'a>, value) = { state with TimeZone = Some value }
            
        [<CustomOperation "rangeRelation" >]
        member _.RangeRelation (state: Range<'a>, value) = { state with RangeRelation = Some value }
            
        member _.Run state =
            state
            |> toTermQueryRange
            |> Range
            |> Query.TermQuery
        
    type RegExpBuilder () =
        member _.Yield _ =
            { RegExp.Field = String.Empty
              Value = String.Empty
              Flags = None
              CaseInsensitive = None
              MaxDeterminizedStates = None
              Rewrite = None }
            
        [<CustomOperation "field" >]
        member _.Field (state: RegExp, value) = { state with Field = value }
            
        [<CustomOperation "value" >]
        member _.Value (state: RegExp, value) = { state with Value = value }
            
        [<CustomOperation "flags" >]
        member _.Flags (state: RegExp, value) = { state with Flags = Some value }
            
        [<CustomOperation "ci" >]
        member _.CaseInsensitive (state: RegExp, value) = { state with CaseInsensitive = Some value }
            
        [<CustomOperation "maxDeterminizedStates" >]
        member _.MaxDeterminizedStates (state: RegExp, value) = { state with MaxDeterminizedStates = Some value }
            
        [<CustomOperation "rewrite" >]
        member _.Rewrite (state: RegExp, value) = { state with Rewrite = Some value }
            
        member _.Run state =
            state
            |> RegExp
            |> Query.TermQuery
        
    type TermBuilder () =
        member _.Yield _ =
            { Term.Field = String.Empty
              Value = String.Empty
              Boost = None }
            
        member _.Run state =
            state
            |> Term
            |> Query.TermQuery
            
        [<CustomOperation "field" >]
        member _.Field (state: Term, value) = { state with Field = value }
            
        [<CustomOperation "value" >]
        member _.Value (state: Term, value) = { state with Value = value }
            
        [<CustomOperation "boost" >]
        member _.Boost (state: Term, value) = { state with Boost = Some value }
        
    type TermsBuilder () =
        member _.Yield _ =
            { Terms.Field = String.Empty
              Values = Array.empty
              Boost = None }
            
        [<CustomOperation "field" >]
        member _.Field (state: Terms, value) = { state with Field = value }
            
        [<CustomOperation "values" >]
        member _.Value (state: Terms, value) = { state with Values = value }
            
        [<CustomOperation "boost" >]
        member _.Boost (state: Terms, value) = { state with Boost = Some value }
            
        member _.Run state =
            state
            |> Terms
            |> Query.TermQuery
        
    type TermsSetBuilder () =
        member _.Yield _ =
            { TermsSet.Field = String.Empty
              Terms = Array.empty
              Boost = None
              MinimumShouldMatchField = None
              MinimumShouldMatchScript = None }
            
        [<CustomOperation "field" >]
        member _.Field (state: TermsSet, value) = { state with Field = value }
            
        [<CustomOperation "terms" >]
        member _.Terms (state: TermsSet, value) = { state with Terms = value }
            
        [<CustomOperation "boost" >]
        member _.Boost (state: TermsSet, value) = { state with Boost = Some value }
            
        [<CustomOperation "minimumShouldMatchField" >]
        member _.MinimumShouldMatchField (state: TermsSet, value) = { state with MinimumShouldMatchField = Some value }
            
        [<CustomOperation "minimumShouldMatchScript" >]
        member _.MinimumShouldMatchScript (state: TermsSet, value) = { state with MinimumShouldMatchScript = Some value }
            
        member _.Run state =
            state
            |> TermsSet
            |> Query.TermQuery
    
    type TypeTermBuilder () =
        member _.Yield _ =
            { TypeTerm.Value = String.Empty }
            
        [<CustomOperation "value" >]
        member _.Value (state: TypeTerm, value) = { state with Value = value }
            
        member _.Run state =
            state
            |> TypeTerm
            |> Query.TermQuery
    
    type WildcardBuilder () =
        member _.Yield _ =
            { Wildcard.Field = String.Empty
              Value = String.Empty
              Boost = None
              CaseInsensitive = None
              Rewrite = None }
            
        [<CustomOperation "field" >]
        member _.Field (state: Wildcard, value) = { state with Field = value }
            
        [<CustomOperation "value" >]
        member _.Value (state: Wildcard, value) = { state with Value = value }
            
        [<CustomOperation "ci" >]
        member _.CaseInsensitive (state: Wildcard, value) = { state with CaseInsensitive = Some value }
            
        [<CustomOperation "boost" >]
        member _.Boost (state: Wildcard, value) = { state with Boost = Some value }
            
        [<CustomOperation "rewrite" >]
        member _.Rewrite (state: Wildcard, value) = { state with Rewrite = Some value }
            
        member _.Run state =
            state
            |> Wildcard
            |> Query.TermQuery
            
    let exists = ExistsBuilder()
    let fuzzy = FuzzyBuilder()
    let ids = IdsBuilder()
    let prefix = PrefixBuilder()
    let dateRangeTerm = RangeBuilder<DateTime> DateTimeRange
    let intRangeTerm = RangeBuilder<int> IntegerRange
    let longRangeTerm = RangeBuilder<int64> LongRange
    let stringRangeTerm = RangeBuilder<string> TermRange
    let regExTerm = RegExpBuilder()
    let fieldTerms = TermsBuilder()
    let term = TermBuilder()
    let fieldSetTerms = TermsSetBuilder()
    let typeTerm = TypeTermBuilder()
    let wildcardTerm = WildcardBuilder()