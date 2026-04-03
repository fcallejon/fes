// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module QueryRulesOperations =

    type QueryRulesDeleteRuleRequest = {
        RulesetId: Types.Id
        RuleId: Types.Id
    }

        with
        static member ToEndpoint(req: QueryRulesDeleteRuleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}/_rule/{Fes.Http.toPathSegment req.RuleId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type QueryRulesDeleteRuleResponse = Types.AcknowledgedResponseBase

    type QueryRulesDeleteRuleRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesDeleteRuleRequest =
            {
                RulesetId = Unchecked.defaultof<_>
                RuleId = Unchecked.defaultof<_>
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesDeleteRuleRequest, value: Types.Id) =
            { state with RulesetId = value }

        [<CustomOperation("ruleId")>]
        member _.RuleId(state: QueryRulesDeleteRuleRequest, value: Types.Id) =
            { state with RuleId = value }

    let queryRulesDeleteRuleRequest = QueryRulesDeleteRuleRequestBuilder()

    type QueryRulesDeleteRulesetRequest = {
        RulesetId: Types.Id
    }

        with
        static member ToEndpoint(req: QueryRulesDeleteRulesetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type QueryRulesDeleteRulesetResponse = Types.AcknowledgedResponseBase

    type QueryRulesDeleteRulesetRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesDeleteRulesetRequest =
            {
                RulesetId = Unchecked.defaultof<_>
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesDeleteRulesetRequest, value: Types.Id) =
            { state with RulesetId = value }

    let queryRulesDeleteRulesetRequest = QueryRulesDeleteRulesetRequestBuilder()

    type QueryRulesGetRuleRequest = {
        RulesetId: Types.Id
        RuleId: Types.Id
    }

        with
        static member ToEndpoint(req: QueryRulesGetRuleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}/_rule/{Fes.Http.toPathSegment req.RuleId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type QueryRulesGetRuleResponse = Types.QueryRule

    type QueryRulesGetRuleRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesGetRuleRequest =
            {
                RulesetId = Unchecked.defaultof<_>
                RuleId = Unchecked.defaultof<_>
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesGetRuleRequest, value: Types.Id) =
            { state with RulesetId = value }

        [<CustomOperation("ruleId")>]
        member _.RuleId(state: QueryRulesGetRuleRequest, value: Types.Id) =
            { state with RuleId = value }

    let queryRulesGetRuleRequest = QueryRulesGetRuleRequestBuilder()

    type QueryRulesGetRulesetRequest = {
        RulesetId: Types.Id
    }

        with
        static member ToEndpoint(req: QueryRulesGetRulesetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type QueryRulesGetRulesetResponse = Types.QueryRuleset

    type QueryRulesGetRulesetRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesGetRulesetRequest =
            {
                RulesetId = Unchecked.defaultof<_>
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesGetRulesetRequest, value: Types.Id) =
            { state with RulesetId = value }

    let queryRulesGetRulesetRequest = QueryRulesGetRulesetRequestBuilder()

    type QueryRulesListRulesetsRequest = {
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: QueryRulesListRulesetsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules"
            let queryParams =
                [
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type QueryRulesListRulesetsResponse = System.Text.Json.JsonElement

    type QueryRulesListRulesetsRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesListRulesetsRequest =
            {
                From = None
                Size = None
            }

        [<CustomOperation("from")>]
        member _.From(state: QueryRulesListRulesetsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: QueryRulesListRulesetsRequest, value: Types.Integer) =
            { state with Size = Some value }

    let queryRulesListRulesetsRequest = QueryRulesListRulesetsRequestBuilder()

    module ListRulesets =
        let withFrom (value: Types.Integer) (req: QueryRulesListRulesetsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: QueryRulesListRulesetsRequest) =
            { req with Size = Some value }

    type QueryRulesPutRuleRequest = {
        RulesetId: Types.Id
        RuleId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.QueryRuleType
        [<System.Text.Json.Serialization.JsonPropertyName("criteria")>]
        Criteria: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Types.QueryRuleActions
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Types.Integer option
    }

        with
        static member ToEndpoint(req: QueryRulesPutRuleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}/_rule/{Fes.Http.toPathSegment req.RuleId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type QueryRulesPutRuleResponse = System.Text.Json.JsonElement

    type QueryRulesPutRuleRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesPutRuleRequest =
            {
                RulesetId = Unchecked.defaultof<_>
                RuleId = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Criteria = Unchecked.defaultof<_>
                Actions = Unchecked.defaultof<_>
                Priority = None
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesPutRuleRequest, value: Types.Id) =
            { state with RulesetId = value }

        [<CustomOperation("ruleId")>]
        member _.RuleId(state: QueryRulesPutRuleRequest, value: Types.Id) =
            { state with RuleId = value }

        [<CustomOperation("type'")>]
        member _.Type(state: QueryRulesPutRuleRequest, value: Types.QueryRuleType) =
            { state with Type = value }

        [<CustomOperation("criteria")>]
        member _.Criteria(state: QueryRulesPutRuleRequest, value: System.Text.Json.JsonElement) =
            { state with Criteria = value }

        [<CustomOperation("actions")>]
        member _.Actions(state: QueryRulesPutRuleRequest, value: Types.QueryRuleActions) =
            { state with Actions = value }

        [<CustomOperation("priority")>]
        member _.Priority(state: QueryRulesPutRuleRequest, value: Types.Integer) =
            { state with Priority = Some value }

    let queryRulesPutRuleRequest = QueryRulesPutRuleRequestBuilder()

    module PutRule =
        let withType (value: Types.QueryRuleType) (req: QueryRulesPutRuleRequest) =
            { req with Type = value }
        let withCriteria (value: System.Text.Json.JsonElement) (req: QueryRulesPutRuleRequest) =
            { req with Criteria = value }
        let withActions (value: Types.QueryRuleActions) (req: QueryRulesPutRuleRequest) =
            { req with Actions = value }
        let withPriority (value: Types.Integer) (req: QueryRulesPutRuleRequest) =
            { req with Priority = Some value }

    type QueryRulesPutRulesetRequest = {
        RulesetId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: System.Text.Json.JsonElement
    }

        with
        static member ToEndpoint(req: QueryRulesPutRulesetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type QueryRulesPutRulesetResponse = System.Text.Json.JsonElement

    type QueryRulesPutRulesetRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesPutRulesetRequest =
            {
                RulesetId = Unchecked.defaultof<_>
                Rules = Unchecked.defaultof<_>
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesPutRulesetRequest, value: Types.Id) =
            { state with RulesetId = value }

        [<CustomOperation("rules")>]
        member _.Rules(state: QueryRulesPutRulesetRequest, value: System.Text.Json.JsonElement) =
            { state with Rules = value }

    let queryRulesPutRulesetRequest = QueryRulesPutRulesetRequestBuilder()

    module PutRuleset =
        let withRules (value: System.Text.Json.JsonElement) (req: QueryRulesPutRulesetRequest) =
            { req with Rules = value }

    type QueryRulesTestRequest = {
        RulesetId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("match_criteria")>]
        MatchCriteria: Map<string, System.Text.Json.JsonElement>
    }

        with
        static member ToEndpoint(req: QueryRulesTestRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query_rules/{Fes.Http.toPathSegment req.RulesetId}/_test"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type QueryRulesTestResponse = System.Text.Json.JsonElement

    type QueryRulesTestRequestBuilder() =
        member _.Yield(_: unit) : QueryRulesTestRequest =
            {
                RulesetId = Unchecked.defaultof<_>
                MatchCriteria = Unchecked.defaultof<_>
            }

        [<CustomOperation("rulesetId")>]
        member _.RulesetId(state: QueryRulesTestRequest, value: Types.Id) =
            { state with RulesetId = value }

        [<CustomOperation("matchCriteria")>]
        member _.MatchCriteria(state: QueryRulesTestRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with MatchCriteria = value }

    let queryRulesTestRequest = QueryRulesTestRequestBuilder()

    module Test =
        let withMatchCriteria (value: Map<string, System.Text.Json.JsonElement>) (req: QueryRulesTestRequest) =
            { req with MatchCriteria = value }

