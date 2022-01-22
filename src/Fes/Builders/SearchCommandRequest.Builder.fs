namespace Fes.Builders

[<AutoOpen>]
module SearchCommandRequestBuilder =
    open Fes.DSL

    type SearchCommandRequestBuilder() =
        member _.Yield _ =
            { Target = None
              DocValueFields = None
              Explain = None
              Fields = None
              From = None
              IndicesBoost = None
              MinScore = None
              PointInTime = None
              Query = None
              RuntimeMappings = None
              SeqNoPrimaryTerm = None
              Size = None
              Source = None
              Stats = None
              TerminateAfter = None
              Timeout = None
              Version = None
              QueryStringParameters = None }
            
        
        [<CustomOperation "target" >]
        member _.Target (state: SearchCommandRequest, value) = { state with Target = Some value }
        
        [<CustomOperation "docValueFields" >]
        member _.DocValueFields (state: SearchCommandRequest, value) = { state with DocValueFields = Some value }
        
        [<CustomOperation "explain" >]
        member _.Explain (state: SearchCommandRequest, value) = { state with Explain = Some value }
        
        [<CustomOperation "fields" >]
        member _.Fields (state: SearchCommandRequest, value) = { state with Fields = Some value }
        
        [<CustomOperation "from" >]
        member _.From (state: SearchCommandRequest, value) = { state with From = Some value }
        
        [<CustomOperation "indicesBoost" >]
        member _.IndicesBoost (state: SearchCommandRequest, value) = { state with IndicesBoost = Some value }
        
        [<CustomOperation "minScore" >]
        member _.MinScore (state: SearchCommandRequest, value) = { state with MinScore = Some value }
        
        [<CustomOperation "pointInTime" >]
        member _.PointInTime (state: SearchCommandRequest, value) = { state with PointInTime = Some value }
        
        [<CustomOperation "runtimeMappings" >]
        member _.RuntimeMappings (state: SearchCommandRequest, value) = { state with RuntimeMappings = Some value }
        
        [<CustomOperation "seqNoPrimaryTerm" >]
        member _.SeqNoPrimaryTerm (state: SearchCommandRequest, value) = { state with SeqNoPrimaryTerm = Some value }
        
        [<CustomOperation "size" >]
        member _.Size (state: SearchCommandRequest, value) = { state with Size = Some value }
        
        [<CustomOperation "source" >]
        member _.Source (state: SearchCommandRequest, value) = { state with Source = Some value }
        
        [<CustomOperation "stats" >]
        member _.Stats (state: SearchCommandRequest, value) = { state with Stats = Some value }
        
        [<CustomOperation "terminateAfter" >]
        member _.TerminateAfter (state: SearchCommandRequest, value) = { state with TerminateAfter = Some value }
        
        [<CustomOperation "timeout" >]
        member _.Timeout (state: SearchCommandRequest, value) = { state with Timeout = Some value }
        
        [<CustomOperation "includeVersion" >]
        member _.Version (state: SearchCommandRequest, value) = { state with Version = Some value }
        
        [<CustomOperation "queryStringParameters" >]
        member _.QueryStringParameters (state: SearchCommandRequest, value) = { state with QueryStringParameters = Some value }
        
        [<CustomOperation "query" >]
        member _.FullTextQueriesQueryString (state: SearchCommandRequest, value) =
            { state with Query = Some value }
        
    let searchCommandRequest = SearchCommandRequestBuilder()