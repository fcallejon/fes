namespace Fes.DSL.Queries

open FSharpPlus.Control
open Fleece.SystemTextJson

type Rewrite =
    | ConstantScore
    | ConstantScoreBoolean
    | ScoringBoolean
    | TopTermsBlendedFreqsN
    | TopTermsBoostN
    | TopTermsN
    static member ToJson rewrite =
        match rewrite with
        | ConstantScore -> "constant_score"
        | ConstantScoreBoolean -> "constant_score_boolean"
        | ScoringBoolean -> "scoring_boolean"
        | TopTermsBlendedFreqsN -> "top_terms_blended_freqs_N"
        | TopTermsBoostN -> "top_terms_boost_N"
        | TopTermsN -> "top_terms_N"
        |> JString

type BooleanLogicOperator =
    | And
    | Or
    static member ToJson op =
        match op with
        | And -> "AND"
        | Or -> "OR"
        |> JString

type QueryOperator =
    | And
    | Or
    static member ToJson op =
        match op with
        | And -> "and"
        | Or -> "or"
        |> JString
        
type ScoreMode =
| Average
| Max
| Min
| NoScore
| Sum
    static member ToJson op =
        match op with
        | Average -> "avg"
        | Max -> "max"
        | Min -> "min"
        | NoScore -> "none"
        | Sum -> "sum"
        |> JString