namespace Fes.DSL.Query.Queries

open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open Fes.DSL.Queries
open Fes.DSL.Query.FullTextQueries
open Fes.DSL.Query.TermLevel

type NestedQuery =
| FullTextQueries of FullTextQueries
| TermQuery of TermQuery
with
    static member ToJson query =
        match query with
        | FullTextQueries q -> toJson q
        | TermQuery q -> toJson q
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

type Query =
| FullTextQueries of FullTextQueries
| TermQuery of TermQuery
| Nested of Nested
with
    static member ToJson query =
        match query with
        | FullTextQueries q -> toJson q
        | TermQuery q -> toJson q
        | Nested q -> toJson q