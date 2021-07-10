namespace Fes.DSL.Query.Queries

open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open Fes.DSL.Queries
open Fes.DSL.Query.FullTextQueries
open Fes.DSL.Query.TermLevel

type BoolOptions =
    { MinimumShouldMatch: option<int>
      Boost: option<double> }
        
type Nested =
    { Path: string
      Query: NestedQuery
      ScoreMode: option<ScoreMode>
      IgnoreUnmapped: option<bool> }
with
    static member ToJson nested =
        jobj [
            "path" .= nested.Path
            "query" .= nested.Query
            "score_mode" .= nested.ScoreMode
            "ignore_unmapped" .= nested.IgnoreUnmapped
        ]

and NestedQuery =
| FullTextQueries of FullTextQueries
| TermQuery of TermQuery
| Bool of Bool
with
    static member ToJson query =
        match query with
        | FullTextQueries q -> toJson q
        | TermQuery q -> toJson q
        | Bool q -> toJson q

and Query =
| FullTextQueries of FullTextQueries
| TermQuery of TermQuery
| Nested of Nested
with
    static member ToJson query =
        match query with
        | FullTextQueries q -> toJson q
        | TermQuery q -> toJson q
        | Nested q -> toJson q
    
and Bool =
    | Must of (Query * BoolOptions)
    | Filter of (Query * BoolOptions)
    | Should of (Query * BoolOptions)
    | MustNot of (Query * BoolOptions)
with
    static member ToJson boolQuery =
        let content, options =
            match boolQuery with
            | Must (query, options) ->
                jobj [ "must" .= query ], options
            | Filter (query, options) ->
                jobj [ "filter" .= query ], options
            | Should (query, options) ->
                jobj [ "should" .= query ], options
            | MustNot (query, options) ->
                jobj [ "must_not" .= query ], options
        in
        jobj [ "bool" .= content
               "boost" .=? options.Boost
               "minimum_should_match" .=? options.MinimumShouldMatch ]