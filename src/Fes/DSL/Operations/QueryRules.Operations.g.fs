// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module QueryRulesOperations =

    type QueryRulesGetRuleRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
        [<JsonPropertyName("rule_id")>]
        RuleId: Id
    } with
        static member ToRequest(request: QueryRulesGetRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}/_rule/{request.RuleId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesGetRuleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesGetRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesGetRuleRequest.ToRequest request

    type QueryRulesGetRuleRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesGetRuleRequest =
            {
                QueryRulesGetRuleRequest.RulesetId = Unchecked.defaultof<Id>
                QueryRulesGetRuleRequest.RuleId = Unchecked.defaultof<Id>
            } : QueryRulesGetRuleRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesGetRuleRequest, value: Id) =
            { state with QueryRulesGetRuleRequest.RulesetId = value } : QueryRulesGetRuleRequest

        [<CustomOperation("rule_id")>]
        member _.RuleId(state: QueryRulesGetRuleRequest, value: Id) =
            { state with QueryRulesGetRuleRequest.RuleId = value } : QueryRulesGetRuleRequest

    let queryRulesGetRuleRequest = QueryRulesGetRuleRequestBuilder()

    type QueryRulesGetRuleResponse = TypesQueryRule

    type QueryRulesPutRuleRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
        [<JsonPropertyName("rule_id")>]
        RuleId: Id
        [<JsonPropertyName("type")>]
        Type: TypesQueryRuleType
        [<JsonPropertyName("criteria")>]
        Criteria: System.Text.Json.JsonElement
        [<JsonPropertyName("actions")>]
        Actions: TypesQueryRuleActions
        [<JsonPropertyName("priority")>]
        Priority: float option
    } with
        static member ToRequest(request: QueryRulesPutRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}/_rule/{request.RuleId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesPutRuleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesPutRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesPutRuleRequest.ToRequest request

    type QueryRulesPutRuleRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesPutRuleRequest =
            {
                QueryRulesPutRuleRequest.RulesetId = Unchecked.defaultof<Id>
                QueryRulesPutRuleRequest.RuleId = Unchecked.defaultof<Id>
                QueryRulesPutRuleRequest.Type = Unchecked.defaultof<TypesQueryRuleType>
                QueryRulesPutRuleRequest.Criteria = Unchecked.defaultof<System.Text.Json.JsonElement>
                QueryRulesPutRuleRequest.Actions = Unchecked.defaultof<TypesQueryRuleActions>
                QueryRulesPutRuleRequest.Priority = Option.None
            } : QueryRulesPutRuleRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesPutRuleRequest, value: Id) =
            { state with QueryRulesPutRuleRequest.RulesetId = value } : QueryRulesPutRuleRequest

        [<CustomOperation("rule_id")>]
        member _.RuleId(state: QueryRulesPutRuleRequest, value: Id) =
            { state with QueryRulesPutRuleRequest.RuleId = value } : QueryRulesPutRuleRequest

        [<CustomOperation("type")>]
        member _.Type(state: QueryRulesPutRuleRequest, value: TypesQueryRuleType) =
            { state with QueryRulesPutRuleRequest.Type = value } : QueryRulesPutRuleRequest

        [<CustomOperation("criteria")>]
        member _.Criteria(state: QueryRulesPutRuleRequest, value: System.Text.Json.JsonElement) =
            { state with QueryRulesPutRuleRequest.Criteria = value } : QueryRulesPutRuleRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: QueryRulesPutRuleRequest, value: TypesQueryRuleActions) =
            { state with QueryRulesPutRuleRequest.Actions = value } : QueryRulesPutRuleRequest

        [<CustomOperation("priority")>]
        member _.Priority(state: QueryRulesPutRuleRequest, value: float) =
            { state with QueryRulesPutRuleRequest.Priority = Option.Some value } : QueryRulesPutRuleRequest

    let queryRulesPutRuleRequest = QueryRulesPutRuleRequestBuilder()

    type QueryRulesPutRuleResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type QueryRulesDeleteRuleRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
        [<JsonPropertyName("rule_id")>]
        RuleId: Id
    } with
        static member ToRequest(request: QueryRulesDeleteRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}/_rule/{request.RuleId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesDeleteRuleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesDeleteRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesDeleteRuleRequest.ToRequest request

    type QueryRulesDeleteRuleRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesDeleteRuleRequest =
            {
                QueryRulesDeleteRuleRequest.RulesetId = Unchecked.defaultof<Id>
                QueryRulesDeleteRuleRequest.RuleId = Unchecked.defaultof<Id>
            } : QueryRulesDeleteRuleRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesDeleteRuleRequest, value: Id) =
            { state with QueryRulesDeleteRuleRequest.RulesetId = value } : QueryRulesDeleteRuleRequest

        [<CustomOperation("rule_id")>]
        member _.RuleId(state: QueryRulesDeleteRuleRequest, value: Id) =
            { state with QueryRulesDeleteRuleRequest.RuleId = value } : QueryRulesDeleteRuleRequest

    let queryRulesDeleteRuleRequest = QueryRulesDeleteRuleRequestBuilder()

    type QueryRulesDeleteRuleResponse = AcknowledgedResponseBase

    type QueryRulesGetRulesetRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
    } with
        static member ToRequest(request: QueryRulesGetRulesetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesGetRulesetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesGetRulesetRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesGetRulesetRequest.ToRequest request

    type QueryRulesGetRulesetRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesGetRulesetRequest =
            {
                QueryRulesGetRulesetRequest.RulesetId = Unchecked.defaultof<Id>
            } : QueryRulesGetRulesetRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesGetRulesetRequest, value: Id) =
            { state with QueryRulesGetRulesetRequest.RulesetId = value } : QueryRulesGetRulesetRequest

    let queryRulesGetRulesetRequest = QueryRulesGetRulesetRequestBuilder()

    type QueryRulesGetRulesetResponse = TypesQueryRuleset

    type QueryRulesPutRulesetRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
        [<JsonPropertyName("rules")>]
        Rules: System.Text.Json.JsonElement
    } with
        static member ToRequest(request: QueryRulesPutRulesetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesPutRulesetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesPutRulesetRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesPutRulesetRequest.ToRequest request

    type QueryRulesPutRulesetRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesPutRulesetRequest =
            {
                QueryRulesPutRulesetRequest.RulesetId = Unchecked.defaultof<Id>
                QueryRulesPutRulesetRequest.Rules = Unchecked.defaultof<System.Text.Json.JsonElement>
            } : QueryRulesPutRulesetRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesPutRulesetRequest, value: Id) =
            { state with QueryRulesPutRulesetRequest.RulesetId = value } : QueryRulesPutRulesetRequest

        [<CustomOperation("rules")>]
        member _.Rules(state: QueryRulesPutRulesetRequest, value: System.Text.Json.JsonElement) =
            { state with QueryRulesPutRulesetRequest.Rules = value } : QueryRulesPutRulesetRequest

    let queryRulesPutRulesetRequest = QueryRulesPutRulesetRequestBuilder()

    type QueryRulesPutRulesetResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type QueryRulesDeleteRulesetRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
    } with
        static member ToRequest(request: QueryRulesDeleteRulesetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesDeleteRulesetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesDeleteRulesetRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesDeleteRulesetRequest.ToRequest request

    type QueryRulesDeleteRulesetRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesDeleteRulesetRequest =
            {
                QueryRulesDeleteRulesetRequest.RulesetId = Unchecked.defaultof<Id>
            } : QueryRulesDeleteRulesetRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesDeleteRulesetRequest, value: Id) =
            { state with QueryRulesDeleteRulesetRequest.RulesetId = value } : QueryRulesDeleteRulesetRequest

    let queryRulesDeleteRulesetRequest = QueryRulesDeleteRulesetRequestBuilder()

    type QueryRulesDeleteRulesetResponse = AcknowledgedResponseBase

    type QueryRulesListRulesetsRequest = {
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("size")>]
        Size: float option
    } with
        static member ToRequest(request: QueryRulesListRulesetsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_query_rules"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesListRulesetsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesListRulesetsRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesListRulesetsRequest.ToRequest request

    type QueryRulesListRulesetsRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesListRulesetsRequest =
            {
                QueryRulesListRulesetsRequest.From = Option.None
                QueryRulesListRulesetsRequest.Size = Option.None
            } : QueryRulesListRulesetsRequest

        [<CustomOperation("from")>]
        member _.From(state: QueryRulesListRulesetsRequest, value: float) =
            { state with QueryRulesListRulesetsRequest.From = Option.Some value } : QueryRulesListRulesetsRequest

        [<CustomOperation("size")>]
        member _.Size(state: QueryRulesListRulesetsRequest, value: float) =
            { state with QueryRulesListRulesetsRequest.Size = Option.Some value } : QueryRulesListRulesetsRequest

    let queryRulesListRulesetsRequest = QueryRulesListRulesetsRequestBuilder()

    type QueryRulesListRulesetsResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("results")>]
        Results: ListRulesetsQueryRulesetListItem array
    }

    type QueryRulesTestRequest = {
        [<JsonPropertyName("ruleset_id")>]
        RulesetId: Id
        [<JsonPropertyName("match_criteria")>]
        MatchCriteria: Map<string, obj>
    } with
        static member ToRequest(request: QueryRulesTestRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query_rules/{request.RulesetId}/_test"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module QueryRulesTestRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: QueryRulesTestRequest) : Result<Fes.Http.RequestMsg, exn> =
            QueryRulesTestRequest.ToRequest request

    type QueryRulesTestRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesTestRequest =
            {
                QueryRulesTestRequest.RulesetId = Unchecked.defaultof<Id>
                QueryRulesTestRequest.MatchCriteria = Unchecked.defaultof<Map<string, obj>>
            } : QueryRulesTestRequest

        [<CustomOperation("ruleset_id")>]
        member _.RulesetId(state: QueryRulesTestRequest, value: Id) =
            { state with QueryRulesTestRequest.RulesetId = value } : QueryRulesTestRequest

        [<CustomOperation("match_criteria")>]
        member _.MatchCriteria(state: QueryRulesTestRequest, value: Map<string, obj>) =
            { state with QueryRulesTestRequest.MatchCriteria = value } : QueryRulesTestRequest

    let queryRulesTestRequest = QueryRulesTestRequestBuilder()

    type QueryRulesTestResponse = {
        [<JsonPropertyName("total_matched_rules")>]
        TotalMatchedRules: float
        [<JsonPropertyName("matched_rules")>]
        MatchedRules: TestQueryRulesetMatchedRule array
    }

