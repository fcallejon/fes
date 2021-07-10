namespace Fes.DSL.Query.Booleans

open Fes.DSL.Query.Queries
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

type Must =
    class
    end

type Filter =
    class
    end

type Should =
    class
    end

type MustNot =
    class
    end

type BoolOptions =
    { MinimumShouldMatch: option<int>
      Boost: option<double> }
    
type Bool =
    | Must of (Must * Query * BoolOptions)
    | Filter of (Filter * Query * BoolOptions)
    | Should of (Should * Query * BoolOptions)
    | MustNot of (MustNot * Query * BoolOptions)
with
    static member ToJson boolQuery =
        let content, options =
            match boolQuery with
            | Must (_, query, options) ->
                jobj [ "must" .= query ], options
            | Filter (_, query, options) ->
                jobj [ "filter" .= query ], options
            | Should (_, query, options) ->
                jobj [ "should" .= query ], options
            | MustNot (_, query, options) ->
                jobj [ "must_not" .= query ], options
        in
        jobj [ "bool" .= content
               "boost" .=? options.Boost
               "minimum_should_match" .=? options.MinimumShouldMatch ]