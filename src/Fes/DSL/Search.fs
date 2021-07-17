namespace Fes.DSL.Search

open FSharpPlus
open Fes
open Fes.DSL
open Fes.DSL.Fields
open Fes.DSL.Mappings
open Fes.DSL.Query.Queries
open Fes.DSL.Units
open Fes.QueryParams.Builder
open Fes.QueryParams.Builder.Operators
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open System

type SearchTrackTotalHits =
| True
| False
| Value of int
with
    member this.ToString =
        match this with
        | True -> "true"
        | False -> "false"
        | Value value -> value |> string

type SearchSource =
| True
| False
| Custom of string[]
with
    member this.ToString =
        match this with
        | True -> "true"
        | False -> "false"
        | Custom values -> joinByChar ',' values

type SearchBodySourceExclude = string[]
type SearchBodySourceInclude = string[]
        
type SearchBodySource =
| True
| False
| Wildcard of string[]
| Custom of (SearchBodySourceExclude * SearchBodySourceInclude)[]
with
    static member ToJson x =
        match x with
        | True -> "true" |> JString
        | False -> "false"  |> JString
        | Wildcard values -> joinByChar ',' values  |> JString
        | Custom values ->
            let mkInner (excludes, includes) =
                jobj [ "excludes" .= (csv excludes)
                       "includes" .= (csv includes) ]
            values
            |> Array.map mkInner
            |> JArray

type SearchSortingOrientation =
| Ascending
| Descending
with
    member this.ToString =
        match this with
        | Ascending -> "asc"
        | Descending -> "desc"
    static member ToJson x =
        match x with
        | Ascending -> "asc"
        | Descending -> "desc"
        |> JString

type SearchSorting =
    { Field: string
      SearchOrientation: SearchSortingOrientation }
with
    member this.ToString =
        this.SearchOrientation
        |> string
        |> sprintf "%s:%s" this.Field

type SearchType =
| QueryThenFetch
| DfsQueryThenFetch
with
    member this.ToString =
        match this with
        | QueryThenFetch -> "query_then_fetch"
        | DfsQueryThenFetch -> "dfs_query_then_fetch"

type SearchPreferenceShards =
| SpecificShards of string[]
| SearchPreference of SearchPreference
with
    member this.ToString =
        match this with
        | SpecificShards shards -> joinByChar ',' shards |> sprintf "_shards:%s"
        | SearchPreference pref -> pref |> string

and SearchPreference =
| OnlyLocal
| Local
| OnlyNodes of string[]
| PreferNodes of string[]
| Shards of SearchPreferenceShards[]
| Custom of string
with
    member this.ToString =
        match this with
        | OnlyLocal -> "_only_local"
        | Local -> "_local"
        | OnlyNodes nodes -> joinByChar ',' nodes |> sprintf "_only_nodes:%s"
        | PreferNodes nodes -> joinByChar ',' nodes |> sprintf "_prefer_nodes:%s"
        | Shards shards -> string shards
        | Custom custom -> custom
        
type SearchPointInTime =
    { Id: string
      KeepAlive: option<TimeoutUnit> }
with
    static member ToJson pit =
        jobj [ "id" .= pit.Id
               "keep_alive" .=? pit.KeepAlive ]
        
type SearchField =
    { Name: string
      Format: option<Formats.DateFormat> }
with
    static member ToJson field =
        match field.Format with
        | Some format -> jobj [ field.Name .= format ]
        | None -> field.Name |> JString

type SearchCommandParameters =
    { AllowNoIndices: option<bool>
      AllowPartialSearchResults: option<bool>
      BatchedReduceSize: option<int>
      CcsMinimizeRoundTrips: option<bool>
      DocValueFields: option<string[]>
      ExpandWildcards: option<ExpandWildcardsOptions[]>
      Explain: option<bool>
      From: option<int>
      IgnoreThrottled: option<bool>
      IgnoreUnavailable: option<bool>
      MaxConcurrentShardRequests: option<int>
      PreFilterShardSize: option<int>
      Preference: option<SearchPreference>
      LuceneQuery: option<string>
      RequestCache: option<bool>
      RestTotalHitsAsInt: option<bool>
      Routing: option<string>
      Scroll: option<TimeoutUnit>
      SearchType: option<SearchType>
      SeqNoPrimaryTerm: option<bool> 
      To: option<int>
      Size: option<int>
      Sort: option<SearchSorting[]>
      Source: option<SearchSource>
      SourceExcludes: option<string[]>
      SourceIncludes: option<string[]>
      Stats: option<string>
      StoredFields: option<string[]>
      SuggestField: option<string>
      SuggestText: option<string>
      TerminateAfter: option<int>
      Timeout: option<TimeoutUnit>
      TrackScores: option<bool>
      TrackTotalHits: option<SearchTrackTotalHits>
      TypedKeys: option<bool>
      Version: option<bool> }
    static member ToQueryParams queryParams =
        let expandWildcards = queryParams.ExpandWildcards |> Option.map ((Array.map string) >> csv)
        qparams [
            "allow_no_indices" &=? queryParams.AllowNoIndices
            "allow_partial_search_results" &=? queryParams.AllowPartialSearchResults
            "batched_reduce_size" &=? queryParams.BatchedReduceSize
            "ccs_minimize_roundtrips" &=? queryParams.CcsMinimizeRoundTrips
            "docvalue_fields" &=? (csvOpt queryParams.DocValueFields)
            "expand_wildcards" &=? expandWildcards
            "explain" &=? queryParams.Explain
            "from" &=? queryParams.From
            "ignore_throttled" &=? queryParams.IgnoreThrottled
            "ignore_unavailable" &=? queryParams.IgnoreUnavailable
            "max_concurrent_shard_requests" &=? queryParams.MaxConcurrentShardRequests
            "pre_filter_shard_size" &=? queryParams.PreFilterShardSize
            "preference" &=? queryParams.Preference
            "q" &=? queryParams.LuceneQuery
            "request_cache" &=? queryParams.RequestCache
            "rest_total_hits_as_int" &=? queryParams.RestTotalHitsAsInt
            "routing" &=? queryParams.Routing
            "scroll" &=? queryParams.Scroll
            "search_type" &=? queryParams.SearchType
            "seq_no_primary_term" &=? queryParams.SeqNoPrimaryTerm
            "size" &=? queryParams.Size
            "sort" &=? (queryParams.Sort |> Option.map ((Array.map string) >> csv))
            "_source" &=? queryParams.Source
            "_source_excludes" &=? (csvOpt queryParams.SourceExcludes)
            "_source_includes" &=? (csvOpt queryParams.SourceIncludes)
            "stats" &=? queryParams.Stats
            "stored_fields" &=? (csvOpt queryParams.StoredFields)
            "suggest_field" &=? queryParams.SuggestField
            "suggest_text" &=? queryParams.SuggestText
            "terminate_after" &=? queryParams.TerminateAfter
            "timeout" &=? queryParams.Timeout
            "track_scores" &=? queryParams.TrackScores
            "track_total_hits" &=? queryParams.TrackTotalHits
            "typed_keys" &=? queryParams.TypedKeys
            "version" &=? queryParams.Version ]

type SearchCommandRequest =
    { Target: option<string>
      DocValueFields: option<SearchField[]>
      Explain: option<bool>
      Fields: option<SearchField[]>
      From: option<int>
      IndicesBoost: option<string * float>
      MinScore: option<float>
      PointInTime: option<SearchPointInTime>
      Query: option<Query>
      RuntimeMappings: option<RuntimeMapping []>
      SeqNoPrimaryTerm: option<bool>
      Size: option<int>
      Source: option<SearchBodySource>
      Stats: option<string[]>
      TerminateAfter: option<int>
      Timeout: option<TimeoutUnit>
      Version: option<bool>
      QueryStringParameters: option<SearchCommandParameters> }
    static member ToJson command =
        let indicesBoost =
            let mapBoost (index, boost) =
                jobj [ index .= boost ]
            command.IndicesBoost
            |> Option.map mapBoost
            
        let mappings =
            let mkPair (x: RuntimeMapping) =
                x.Name,
                    jobj [ "type" .= x.Type
                           "script" .=? x.Script ]
            
            command.RuntimeMappings
            |> Option.map ((Array.map mkPair) >> seqPairToJsonObject)
            
        jobj [ "docvalue_fields" .=? command.DocValueFields
               "explain" .=? command.Explain
               "fields" .=? command.Fields
               "from" .=? command.Fields
               "indices_boost" .=? indicesBoost
               "min_score" .=? command.MinScore
               "pit" .=? command.PointInTime
               "query" .=? command.Query
               "runtime_mappings" .=? mappings
               "seq_no_primary_term" .=? command.SeqNoPrimaryTerm
               "size" .=? command.Size
               "source" .=? command.Source
               "stats" .=? command.Stats
               "terminate_after" .=? command.TerminateAfter
               "timeout" .=? command.Timeout
               "version" .=? command.Version ]

    static member ToRequest(request: SearchCommandRequest) =
        let query = queryParamsOfOption request.QueryStringParameters
        let target =
            request.Target
            |> Option.map (sprintf "%s/")
            |> Option.defaultValue ""

        let mk query =
            $"{target}_search{query}"
            |> Http.Request.mk
            |> Http.Request.withMethod Http.Post
            |> Http.Request.withJsonBody request

        mk <!> query

type SearchShardsInfoResponse =
    { Total: int
      Skipped: int
      Successful: int
      Failed: int }
with
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! total = o .@ "total"
                let! successful = o .@ "successful"
                let! skipped = o .@ "skipped"
                let! failed = o .@ "failed"

                return
                    { SearchShardsInfoResponse.Total = total
                      Skipped = skipped
                      Successful = successful 
                      Failed = failed }
            }
        | x -> Decode.Fail.objExpected x

type SearchHitTotalRelation =
| Equal
| GreaterThanOrEqual
with
    static member OfJson json =
        match json with
        | JString "eq" -> Decode.Success Equal
        | JString "gte" -> Decode.Success GreaterThanOrEqual
        | JString x as v -> Decode.Fail.invalidValue v $"Wrong SearchHitTotalRelation value: %s{x}"
        | x -> Decode.Fail.strExpected x
    

type SearchHitTotal =
    { Value: int
      Relation: SearchHitTotalRelation }
with
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! value = o .@ "value"
                let! relation = o .@ "relation"
                
                return { SearchHitTotal.Value = value
                         Relation = relation }
            }
        | x -> Decode.Fail.strExpected x

type SearchHitMaxScore =
| Empty
| Value of float
    static member OfJson value =
        match value with
        | JNumber number -> number |> string |> float |> Value |> Decode.Success
        | JNull -> Decode.Success Empty
        | x -> Decode.Fail.strExpected x

type SearchHits =
    { Total: SearchHitTotal
      MaxScore: SearchHitMaxScore
      Hits: string }
with
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! total = o .@ "total"
                let! maxScore = o .@ "max_score"
                let! hits = o .@ "hits" |> Result.map (fun (d: JsonValue) -> string d)
                
                return { SearchHits.Total = total
                         MaxScore = maxScore
                         Hits = hits }
            }
        | x -> Decode.Fail.strExpected x

type SearchResponse =
    { Hits: SearchHits
      ScrollId: option<string>
      Took: int
      TimedOut: bool
      ShardsInfo: SearchShardsInfoResponse }
with
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! scrollId = o .@? "_scroll_id"
                let! took = o .@ "took"
                let! timedOut = o .@ "timed_out"
                let! shards = o .@ "_shards"
                let! hits = o .@ "hits"

                return
                    { SearchResponse.Hits = hits
                      ScrollId = scrollId
                      Took = took
                      TimedOut = timedOut 
                      ShardsInfo = shards }
            }
        | x -> Decode.Fail.objExpected x
        
[<RequireQualifiedAccess>]
module Search =
    let mkTermSearch target field value =
        { SearchCommandRequest.Target = Some target
          Query = Some <| Query.mkTermQuery field value
          DocValueFields = None
          Explain = None
          Fields = None
          From = None
          IndicesBoost = None
          MinScore = None
          PointInTime = None
          RuntimeMappings = None
          SeqNoPrimaryTerm = None
          Size = None
          Source = None
          Stats = None
          TerminateAfter = None
          Timeout = None
          Version = None
          QueryStringParameters = None }
        