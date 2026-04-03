// Auto-generated endpoint tests — do not edit manually

module Fes.Tests.Generated.EndpointTests

open Xunit
open FsUnit.Xunit
open Fes.Generated
open Fes.Generated.Operations
open Elastic.Transport

[<Fact>]
let ``async_search_delete uses DELETE method`` () =
    let req = asyncSearchDeleteRequest {
        id "test-value"
    }
    let (endpoint, _) = AsyncSearchDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``async_search_delete has no request body`` () =
    let req = asyncSearchDeleteRequest {
        id "test-value"
    }
    let (_, postData) = AsyncSearchDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``async_search_get uses GET method`` () =
    let req = asyncSearchGetRequest {
        id "test-value"
    }
    let (endpoint, _) = AsyncSearchGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``async_search_get has no request body`` () =
    let req = asyncSearchGetRequest {
        id "test-value"
    }
    let (_, postData) = AsyncSearchGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``async_search_status uses GET method`` () =
    let req = asyncSearchStatusRequest {
        id "test-value"
    }
    let (endpoint, _) = AsyncSearchStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``async_search_status has no request body`` () =
    let req = asyncSearchStatusRequest {
        id "test-value"
    }
    let (_, postData) = AsyncSearchStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``autoscaling_delete_autoscaling_policy uses DELETE method`` () =
    let req = autoscalingDeleteAutoscalingPolicyRequest {
        name "test-value"
    }
    let (endpoint, _) = AutoscalingDeleteAutoscalingPolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``autoscaling_delete_autoscaling_policy has no request body`` () =
    let req = autoscalingDeleteAutoscalingPolicyRequest {
        name "test-value"
    }
    let (_, postData) = AutoscalingDeleteAutoscalingPolicyRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``autoscaling_get_autoscaling_capacity uses GET method`` () =
    let req = Unchecked.defaultof<AutoscalingGetAutoscalingCapacityRequest>
    let (endpoint, _) = AutoscalingGetAutoscalingCapacityRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``autoscaling_get_autoscaling_capacity has no request body`` () =
    let req = Unchecked.defaultof<AutoscalingGetAutoscalingCapacityRequest>
    let (_, postData) = AutoscalingGetAutoscalingCapacityRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``autoscaling_get_autoscaling_policy uses GET method`` () =
    let req = autoscalingGetAutoscalingPolicyRequest {
        name "test-value"
    }
    let (endpoint, _) = AutoscalingGetAutoscalingPolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``autoscaling_get_autoscaling_policy has no request body`` () =
    let req = autoscalingGetAutoscalingPolicyRequest {
        name "test-value"
    }
    let (_, postData) = AutoscalingGetAutoscalingPolicyRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``autoscaling_put_autoscaling_policy uses PUT method`` () =
    let req = autoscalingPutAutoscalingPolicyRequest {
        name "test-value"
    }
    let (endpoint, _) = AutoscalingPutAutoscalingPolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``autoscaling_put_autoscaling_policy has request body`` () =
    let req = autoscalingPutAutoscalingPolicyRequest {
        name "test-value"
    }
    let (_, postData) = AutoscalingPutAutoscalingPolicyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``capabilities uses GET method`` () =
    let req = Unchecked.defaultof<CapabilitiesRequest>
    let (endpoint, _) = CapabilitiesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``capabilities has no request body`` () =
    let req = Unchecked.defaultof<CapabilitiesRequest>
    let (_, postData) = CapabilitiesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_component_templates uses GET method`` () =
    let req = catComponentTemplatesRequest {
        name "test-value"
    }
    let (endpoint, _) = CatComponentTemplatesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_component_templates has no request body`` () =
    let req = catComponentTemplatesRequest {
        name "test-value"
    }
    let (_, postData) = CatComponentTemplatesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_health uses GET method`` () =
    let req = Unchecked.defaultof<CatHealthRequest>
    let (endpoint, _) = CatHealthRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_health has no request body`` () =
    let req = Unchecked.defaultof<CatHealthRequest>
    let (_, postData) = CatHealthRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_help uses GET method`` () =
    let req = Unchecked.defaultof<CatHelpRequest>
    let (endpoint, _) = CatHelpRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_help has no request body`` () =
    let req = Unchecked.defaultof<CatHelpRequest>
    let (_, postData) = CatHelpRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_master uses GET method`` () =
    let req = Unchecked.defaultof<CatMasterRequest>
    let (endpoint, _) = CatMasterRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_master has no request body`` () =
    let req = Unchecked.defaultof<CatMasterRequest>
    let (_, postData) = CatMasterRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_ml_data_frame_analytics uses GET method`` () =
    let req = catMlDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = CatMlDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_ml_data_frame_analytics has no request body`` () =
    let req = catMlDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = CatMlDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_ml_datafeeds uses GET method`` () =
    let req = catMlDatafeedsRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = CatMlDatafeedsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_ml_datafeeds has no request body`` () =
    let req = catMlDatafeedsRequest {
        datafeedId "test-value"
    }
    let (_, postData) = CatMlDatafeedsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_ml_jobs uses GET method`` () =
    let req = catMlJobsRequest {
        jobId "test-value"
    }
    let (endpoint, _) = CatMlJobsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_ml_jobs has no request body`` () =
    let req = catMlJobsRequest {
        jobId "test-value"
    }
    let (_, postData) = CatMlJobsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_ml_trained_models uses GET method`` () =
    let req = catMlTrainedModelsRequest {
        modelId "test-value"
    }
    let (endpoint, _) = CatMlTrainedModelsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_ml_trained_models has no request body`` () =
    let req = catMlTrainedModelsRequest {
        modelId "test-value"
    }
    let (_, postData) = CatMlTrainedModelsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_nodeattrs uses GET method`` () =
    let req = Unchecked.defaultof<CatNodeattrsRequest>
    let (endpoint, _) = CatNodeattrsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_nodeattrs has no request body`` () =
    let req = Unchecked.defaultof<CatNodeattrsRequest>
    let (_, postData) = CatNodeattrsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_nodes uses GET method`` () =
    let req = Unchecked.defaultof<CatNodesRequest>
    let (endpoint, _) = CatNodesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_nodes has no request body`` () =
    let req = Unchecked.defaultof<CatNodesRequest>
    let (_, postData) = CatNodesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_pending_tasks uses GET method`` () =
    let req = Unchecked.defaultof<CatPendingTasksRequest>
    let (endpoint, _) = CatPendingTasksRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_pending_tasks has no request body`` () =
    let req = Unchecked.defaultof<CatPendingTasksRequest>
    let (_, postData) = CatPendingTasksRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_plugins uses GET method`` () =
    let req = Unchecked.defaultof<CatPluginsRequest>
    let (endpoint, _) = CatPluginsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_plugins has no request body`` () =
    let req = Unchecked.defaultof<CatPluginsRequest>
    let (_, postData) = CatPluginsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_repositories uses GET method`` () =
    let req = Unchecked.defaultof<CatRepositoriesRequest>
    let (endpoint, _) = CatRepositoriesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_repositories has no request body`` () =
    let req = Unchecked.defaultof<CatRepositoriesRequest>
    let (_, postData) = CatRepositoriesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_tasks uses GET method`` () =
    let req = Unchecked.defaultof<CatTasksRequest>
    let (endpoint, _) = CatTasksRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_tasks has no request body`` () =
    let req = Unchecked.defaultof<CatTasksRequest>
    let (_, postData) = CatTasksRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_templates uses GET method`` () =
    let req = catTemplatesRequest {
        name "test-value"
    }
    let (endpoint, _) = CatTemplatesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_templates has no request body`` () =
    let req = catTemplatesRequest {
        name "test-value"
    }
    let (_, postData) = CatTemplatesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cat_transforms uses GET method`` () =
    let req = catTransformsRequest {
        transformId "test-value"
    }
    let (endpoint, _) = CatTransformsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cat_transforms has no request body`` () =
    let req = catTransformsRequest {
        transformId "test-value"
    }
    let (_, postData) = CatTransformsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_delete_auto_follow_pattern uses DELETE method`` () =
    let req = ccrDeleteAutoFollowPatternRequest {
        name "test-value"
    }
    let (endpoint, _) = CcrDeleteAutoFollowPatternRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ccr_delete_auto_follow_pattern has no request body`` () =
    let req = ccrDeleteAutoFollowPatternRequest {
        name "test-value"
    }
    let (_, postData) = CcrDeleteAutoFollowPatternRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_follow uses PUT method`` () =
    let req = ccrFollowRequest {
        index "test-value"
    }
    let (endpoint, _) = CcrFollowRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ccr_follow has request body`` () =
    let req = ccrFollowRequest {
        index "test-value"
    }
    let (_, postData) = CcrFollowRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ccr_forget_follower uses POST method`` () =
    let req = ccrForgetFollowerRequest {
        index "test-value"
    }
    let (endpoint, _) = CcrForgetFollowerRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ccr_forget_follower has request body`` () =
    let req = ccrForgetFollowerRequest {
        index "test-value"
    }
    let (_, postData) = CcrForgetFollowerRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ccr_get_auto_follow_pattern uses GET method`` () =
    let req = ccrGetAutoFollowPatternRequest {
        name "test-value"
    }
    let (endpoint, _) = CcrGetAutoFollowPatternRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ccr_get_auto_follow_pattern has no request body`` () =
    let req = ccrGetAutoFollowPatternRequest {
        name "test-value"
    }
    let (_, postData) = CcrGetAutoFollowPatternRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_pause_auto_follow_pattern uses POST method`` () =
    let req = ccrPauseAutoFollowPatternRequest {
        name "test-value"
    }
    let (endpoint, _) = CcrPauseAutoFollowPatternRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ccr_pause_auto_follow_pattern has no request body`` () =
    let req = ccrPauseAutoFollowPatternRequest {
        name "test-value"
    }
    let (_, postData) = CcrPauseAutoFollowPatternRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_pause_follow uses POST method`` () =
    let req = ccrPauseFollowRequest {
        index "test-value"
    }
    let (endpoint, _) = CcrPauseFollowRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ccr_pause_follow has no request body`` () =
    let req = ccrPauseFollowRequest {
        index "test-value"
    }
    let (_, postData) = CcrPauseFollowRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_put_auto_follow_pattern uses PUT method`` () =
    let req = ccrPutAutoFollowPatternRequest {
        name "test-value"
    }
    let (endpoint, _) = CcrPutAutoFollowPatternRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ccr_put_auto_follow_pattern has request body`` () =
    let req = ccrPutAutoFollowPatternRequest {
        name "test-value"
    }
    let (_, postData) = CcrPutAutoFollowPatternRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ccr_resume_auto_follow_pattern uses POST method`` () =
    let req = ccrResumeAutoFollowPatternRequest {
        name "test-value"
    }
    let (endpoint, _) = CcrResumeAutoFollowPatternRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ccr_resume_auto_follow_pattern has no request body`` () =
    let req = ccrResumeAutoFollowPatternRequest {
        name "test-value"
    }
    let (_, postData) = CcrResumeAutoFollowPatternRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_resume_follow uses POST method`` () =
    let req = ccrResumeFollowRequest {
        index "test-value"
    }
    let (endpoint, _) = CcrResumeFollowRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ccr_resume_follow has request body`` () =
    let req = ccrResumeFollowRequest {
        index "test-value"
    }
    let (_, postData) = CcrResumeFollowRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ccr_stats uses GET method`` () =
    let req = Unchecked.defaultof<CcrStatsRequest>
    let (endpoint, _) = CcrStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ccr_stats has no request body`` () =
    let req = Unchecked.defaultof<CcrStatsRequest>
    let (_, postData) = CcrStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ccr_unfollow uses POST method`` () =
    let req = ccrUnfollowRequest {
        index "test-value"
    }
    let (endpoint, _) = CcrUnfollowRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ccr_unfollow has no request body`` () =
    let req = ccrUnfollowRequest {
        index "test-value"
    }
    let (_, postData) = CcrUnfollowRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``close_point_in_time uses DELETE method`` () =
    let req = Unchecked.defaultof<ClosePointInTimeRequest>
    let (endpoint, _) = ClosePointInTimeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``close_point_in_time has request body`` () =
    let req = Unchecked.defaultof<ClosePointInTimeRequest>
    let (_, postData) = ClosePointInTimeRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``cluster_allocation_explain uses POST method`` () =
    let req = Unchecked.defaultof<ClusterAllocationExplainRequest>
    let (endpoint, _) = ClusterAllocationExplainRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``cluster_allocation_explain has request body`` () =
    let req = Unchecked.defaultof<ClusterAllocationExplainRequest>
    let (_, postData) = ClusterAllocationExplainRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``cluster_delete_voting_config_exclusions uses DELETE method`` () =
    let req = Unchecked.defaultof<ClusterDeleteVotingConfigExclusionsRequest>
    let (endpoint, _) = ClusterDeleteVotingConfigExclusionsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``cluster_delete_voting_config_exclusions has no request body`` () =
    let req = Unchecked.defaultof<ClusterDeleteVotingConfigExclusionsRequest>
    let (_, postData) = ClusterDeleteVotingConfigExclusionsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cluster_get_component_template uses GET method`` () =
    let req = clusterGetComponentTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = ClusterGetComponentTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cluster_get_component_template has no request body`` () =
    let req = clusterGetComponentTemplateRequest {
        name "test-value"
    }
    let (_, postData) = ClusterGetComponentTemplateRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cluster_get_settings uses GET method`` () =
    let req = Unchecked.defaultof<ClusterGetSettingsRequest>
    let (endpoint, _) = ClusterGetSettingsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cluster_get_settings has no request body`` () =
    let req = Unchecked.defaultof<ClusterGetSettingsRequest>
    let (_, postData) = ClusterGetSettingsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cluster_pending_tasks uses GET method`` () =
    let req = Unchecked.defaultof<ClusterPendingTasksRequest>
    let (endpoint, _) = ClusterPendingTasksRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cluster_pending_tasks has no request body`` () =
    let req = Unchecked.defaultof<ClusterPendingTasksRequest>
    let (_, postData) = ClusterPendingTasksRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cluster_post_voting_config_exclusions uses POST method`` () =
    let req = Unchecked.defaultof<ClusterPostVotingConfigExclusionsRequest>
    let (endpoint, _) = ClusterPostVotingConfigExclusionsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``cluster_post_voting_config_exclusions has no request body`` () =
    let req = Unchecked.defaultof<ClusterPostVotingConfigExclusionsRequest>
    let (_, postData) = ClusterPostVotingConfigExclusionsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cluster_put_component_template uses POST method`` () =
    let req = clusterPutComponentTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = ClusterPutComponentTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``cluster_put_component_template has request body`` () =
    let req = clusterPutComponentTemplateRequest {
        name "test-value"
    }
    let (_, postData) = ClusterPutComponentTemplateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``cluster_put_settings uses PUT method`` () =
    let req = Unchecked.defaultof<ClusterPutSettingsRequest>
    let (endpoint, _) = ClusterPutSettingsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``cluster_put_settings has request body`` () =
    let req = Unchecked.defaultof<ClusterPutSettingsRequest>
    let (_, postData) = ClusterPutSettingsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``cluster_remote_info uses GET method`` () =
    let req = Unchecked.defaultof<ClusterRemoteInfoRequest>
    let (endpoint, _) = ClusterRemoteInfoRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``cluster_remote_info has no request body`` () =
    let req = Unchecked.defaultof<ClusterRemoteInfoRequest>
    let (_, postData) = ClusterRemoteInfoRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``cluster_reroute uses POST method`` () =
    let req = Unchecked.defaultof<ClusterRerouteRequest>
    let (endpoint, _) = ClusterRerouteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``cluster_reroute has request body`` () =
    let req = Unchecked.defaultof<ClusterRerouteRequest>
    let (_, postData) = ClusterRerouteRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_check_in uses PUT method`` () =
    let req = connectorCheckInRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorCheckInRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_check_in has no request body`` () =
    let req = connectorCheckInRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorCheckInRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_delete uses DELETE method`` () =
    let req = connectorDeleteRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``connector_delete has no request body`` () =
    let req = connectorDeleteRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_get uses GET method`` () =
    let req = connectorGetRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``connector_get has no request body`` () =
    let req = connectorGetRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_last_sync uses PUT method`` () =
    let req = connectorLastSyncRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorLastSyncRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_last_sync has request body`` () =
    let req = connectorLastSyncRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorLastSyncRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_list uses GET method`` () =
    let req = Unchecked.defaultof<ConnectorListRequest>
    let (endpoint, _) = ConnectorListRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``connector_list has no request body`` () =
    let req = Unchecked.defaultof<ConnectorListRequest>
    let (_, postData) = ConnectorListRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_post uses POST method`` () =
    let req = Unchecked.defaultof<ConnectorPostRequest>
    let (endpoint, _) = ConnectorPostRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``connector_post has request body`` () =
    let req = Unchecked.defaultof<ConnectorPostRequest>
    let (_, postData) = ConnectorPostRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_put uses PUT method`` () =
    let req = connectorPutRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorPutRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_put has request body`` () =
    let req = connectorPutRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorPutRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_secret_delete uses DELETE method`` () =
    let req = connectorSecretDeleteRequest {
        id "test-value"
    }
    let (endpoint, _) = ConnectorSecretDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``connector_secret_delete has no request body`` () =
    let req = connectorSecretDeleteRequest {
        id "test-value"
    }
    let (_, postData) = ConnectorSecretDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_secret_get uses GET method`` () =
    let req = connectorSecretGetRequest {
        id "test-value"
    }
    let (endpoint, _) = ConnectorSecretGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``connector_secret_get has no request body`` () =
    let req = connectorSecretGetRequest {
        id "test-value"
    }
    let (_, postData) = ConnectorSecretGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_secret_post uses POST method`` () =
    let req = Unchecked.defaultof<ConnectorSecretPostRequest>
    let (endpoint, _) = ConnectorSecretPostRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``connector_secret_post has request body`` () =
    let req = Unchecked.defaultof<ConnectorSecretPostRequest>
    let (_, postData) = ConnectorSecretPostRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_secret_put uses PUT method`` () =
    let req = connectorSecretPutRequest {
        id "test-value"
    }
    let (endpoint, _) = ConnectorSecretPutRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_secret_put has request body`` () =
    let req = connectorSecretPutRequest {
        id "test-value"
    }
    let (_, postData) = ConnectorSecretPutRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_sync_job_cancel uses PUT method`` () =
    let req = connectorSyncJobCancelRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobCancelRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_sync_job_cancel has no request body`` () =
    let req = connectorSyncJobCancelRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobCancelRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_sync_job_check_in uses PUT method`` () =
    let req = connectorSyncJobCheckInRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobCheckInRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_sync_job_check_in has no request body`` () =
    let req = connectorSyncJobCheckInRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobCheckInRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_sync_job_claim uses PUT method`` () =
    let req = connectorSyncJobClaimRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobClaimRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_sync_job_claim has request body`` () =
    let req = connectorSyncJobClaimRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobClaimRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_sync_job_delete uses DELETE method`` () =
    let req = connectorSyncJobDeleteRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``connector_sync_job_delete has no request body`` () =
    let req = connectorSyncJobDeleteRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_sync_job_error uses PUT method`` () =
    let req = connectorSyncJobErrorRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobErrorRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_sync_job_error has request body`` () =
    let req = connectorSyncJobErrorRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobErrorRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_sync_job_get uses GET method`` () =
    let req = connectorSyncJobGetRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``connector_sync_job_get has no request body`` () =
    let req = connectorSyncJobGetRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_sync_job_list uses GET method`` () =
    let req = Unchecked.defaultof<ConnectorSyncJobListRequest>
    let (endpoint, _) = ConnectorSyncJobListRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``connector_sync_job_list has no request body`` () =
    let req = Unchecked.defaultof<ConnectorSyncJobListRequest>
    let (_, postData) = ConnectorSyncJobListRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_sync_job_post uses POST method`` () =
    let req = Unchecked.defaultof<ConnectorSyncJobPostRequest>
    let (endpoint, _) = ConnectorSyncJobPostRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``connector_sync_job_post has request body`` () =
    let req = Unchecked.defaultof<ConnectorSyncJobPostRequest>
    let (_, postData) = ConnectorSyncJobPostRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_sync_job_update_stats uses PUT method`` () =
    let req = connectorSyncJobUpdateStatsRequest {
        connectorSyncJobId "test-value"
    }
    let (endpoint, _) = ConnectorSyncJobUpdateStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_sync_job_update_stats has request body`` () =
    let req = connectorSyncJobUpdateStatsRequest {
        connectorSyncJobId "test-value"
    }
    let (_, postData) = ConnectorSyncJobUpdateStatsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_active_filtering uses PUT method`` () =
    let req = connectorUpdateActiveFilteringRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateActiveFilteringRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_active_filtering has no request body`` () =
    let req = connectorUpdateActiveFilteringRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateActiveFilteringRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``connector_update_api_key_id uses PUT method`` () =
    let req = connectorUpdateApiKeyIdRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateApiKeyIdRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_api_key_id has request body`` () =
    let req = connectorUpdateApiKeyIdRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateApiKeyIdRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_configuration uses PUT method`` () =
    let req = connectorUpdateConfigurationRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateConfigurationRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_configuration has request body`` () =
    let req = connectorUpdateConfigurationRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateConfigurationRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_error uses PUT method`` () =
    let req = connectorUpdateErrorRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateErrorRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_error has request body`` () =
    let req = connectorUpdateErrorRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateErrorRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_features uses PUT method`` () =
    let req = connectorUpdateFeaturesRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateFeaturesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_features has request body`` () =
    let req = connectorUpdateFeaturesRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateFeaturesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_filtering uses PUT method`` () =
    let req = connectorUpdateFilteringRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateFilteringRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_filtering has request body`` () =
    let req = connectorUpdateFilteringRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateFilteringRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_filtering_validation uses PUT method`` () =
    let req = connectorUpdateFilteringValidationRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateFilteringValidationRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_filtering_validation has request body`` () =
    let req = connectorUpdateFilteringValidationRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateFilteringValidationRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_index_name uses PUT method`` () =
    let req = connectorUpdateIndexNameRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateIndexNameRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_index_name has request body`` () =
    let req = connectorUpdateIndexNameRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateIndexNameRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_name uses PUT method`` () =
    let req = connectorUpdateNameRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateNameRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_name has request body`` () =
    let req = connectorUpdateNameRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateNameRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_native uses PUT method`` () =
    let req = connectorUpdateNativeRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateNativeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_native has request body`` () =
    let req = connectorUpdateNativeRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateNativeRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_pipeline uses PUT method`` () =
    let req = connectorUpdatePipelineRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdatePipelineRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_pipeline has request body`` () =
    let req = connectorUpdatePipelineRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdatePipelineRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_scheduling uses PUT method`` () =
    let req = connectorUpdateSchedulingRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateSchedulingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_scheduling has request body`` () =
    let req = connectorUpdateSchedulingRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateSchedulingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_service_type uses PUT method`` () =
    let req = connectorUpdateServiceTypeRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateServiceTypeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_service_type has request body`` () =
    let req = connectorUpdateServiceTypeRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateServiceTypeRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``connector_update_status uses PUT method`` () =
    let req = connectorUpdateStatusRequest {
        connectorId "test-value"
    }
    let (endpoint, _) = ConnectorUpdateStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``connector_update_status has request body`` () =
    let req = connectorUpdateStatusRequest {
        connectorId "test-value"
    }
    let (_, postData) = ConnectorUpdateStatusRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``dangling_indices_delete_dangling_index uses DELETE method`` () =
    let req = danglingIndicesDeleteDanglingIndexRequest {
        indexUuid "test-value"
    }
    let (endpoint, _) = DanglingIndicesDeleteDanglingIndexRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``dangling_indices_delete_dangling_index has no request body`` () =
    let req = danglingIndicesDeleteDanglingIndexRequest {
        indexUuid "test-value"
    }
    let (_, postData) = DanglingIndicesDeleteDanglingIndexRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``dangling_indices_import_dangling_index uses POST method`` () =
    let req = danglingIndicesImportDanglingIndexRequest {
        indexUuid "test-value"
    }
    let (endpoint, _) = DanglingIndicesImportDanglingIndexRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``dangling_indices_import_dangling_index has no request body`` () =
    let req = danglingIndicesImportDanglingIndexRequest {
        indexUuid "test-value"
    }
    let (_, postData) = DanglingIndicesImportDanglingIndexRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``dangling_indices_list_dangling_indices uses GET method`` () =
    let req = Unchecked.defaultof<DanglingIndicesListDanglingIndicesRequest>
    let (endpoint, _) = DanglingIndicesListDanglingIndicesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``dangling_indices_list_dangling_indices has no request body`` () =
    let req = Unchecked.defaultof<DanglingIndicesListDanglingIndicesRequest>
    let (_, postData) = DanglingIndicesListDanglingIndicesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``delete uses DELETE method`` () =
    let req = deleteRequest {
        id "test-value"
        index "test-value"
    }
    let (endpoint, _) = DeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``delete has no request body`` () =
    let req = deleteRequest {
        id "test-value"
        index "test-value"
    }
    let (_, postData) = DeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``delete_by_query_rethrottle uses POST method`` () =
    let req = deleteByQueryRethrottleRequest {
        taskId "test-value"
    }
    let (endpoint, _) = DeleteByQueryRethrottleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``delete_by_query_rethrottle has no request body`` () =
    let req = deleteByQueryRethrottleRequest {
        taskId "test-value"
    }
    let (_, postData) = DeleteByQueryRethrottleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``delete_script uses DELETE method`` () =
    let req = deleteScriptRequest {
        id "test-value"
    }
    let (endpoint, _) = DeleteScriptRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``delete_script has no request body`` () =
    let req = deleteScriptRequest {
        id "test-value"
    }
    let (_, postData) = DeleteScriptRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``enrich_delete_policy uses DELETE method`` () =
    let req = enrichDeletePolicyRequest {
        name "test-value"
    }
    let (endpoint, _) = EnrichDeletePolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``enrich_delete_policy has no request body`` () =
    let req = enrichDeletePolicyRequest {
        name "test-value"
    }
    let (_, postData) = EnrichDeletePolicyRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``enrich_execute_policy uses PUT method`` () =
    let req = enrichExecutePolicyRequest {
        name "test-value"
    }
    let (endpoint, _) = EnrichExecutePolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``enrich_execute_policy has no request body`` () =
    let req = enrichExecutePolicyRequest {
        name "test-value"
    }
    let (_, postData) = EnrichExecutePolicyRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``enrich_put_policy uses PUT method`` () =
    let req = enrichPutPolicyRequest {
        name "test-value"
    }
    let (endpoint, _) = EnrichPutPolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``enrich_put_policy has request body`` () =
    let req = enrichPutPolicyRequest {
        name "test-value"
    }
    let (_, postData) = EnrichPutPolicyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``enrich_stats uses GET method`` () =
    let req = Unchecked.defaultof<EnrichStatsRequest>
    let (endpoint, _) = EnrichStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``enrich_stats has no request body`` () =
    let req = Unchecked.defaultof<EnrichStatsRequest>
    let (_, postData) = EnrichStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``eql_delete uses DELETE method`` () =
    let req = eqlDeleteRequest {
        id "test-value"
    }
    let (endpoint, _) = EqlDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``eql_delete has no request body`` () =
    let req = eqlDeleteRequest {
        id "test-value"
    }
    let (_, postData) = EqlDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``eql_get uses GET method`` () =
    let req = eqlGetRequest {
        id "test-value"
    }
    let (endpoint, _) = EqlGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``eql_get has no request body`` () =
    let req = eqlGetRequest {
        id "test-value"
    }
    let (_, postData) = EqlGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``eql_get_status uses GET method`` () =
    let req = eqlGetStatusRequest {
        id "test-value"
    }
    let (endpoint, _) = EqlGetStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``eql_get_status has no request body`` () =
    let req = eqlGetStatusRequest {
        id "test-value"
    }
    let (_, postData) = EqlGetStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_async_query uses POST method`` () =
    let req = Unchecked.defaultof<EsqlAsyncQueryRequest>
    let (endpoint, _) = EsqlAsyncQueryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``esql_async_query has request body`` () =
    let req = Unchecked.defaultof<EsqlAsyncQueryRequest>
    let (_, postData) = EsqlAsyncQueryRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``esql_async_query_delete uses DELETE method`` () =
    let req = esqlAsyncQueryDeleteRequest {
        id "test-value"
    }
    let (endpoint, _) = EsqlAsyncQueryDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``esql_async_query_delete has no request body`` () =
    let req = esqlAsyncQueryDeleteRequest {
        id "test-value"
    }
    let (_, postData) = EsqlAsyncQueryDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_async_query_get uses GET method`` () =
    let req = esqlAsyncQueryGetRequest {
        id "test-value"
    }
    let (endpoint, _) = EsqlAsyncQueryGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``esql_async_query_get has no request body`` () =
    let req = esqlAsyncQueryGetRequest {
        id "test-value"
    }
    let (_, postData) = EsqlAsyncQueryGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_async_query_stop uses POST method`` () =
    let req = esqlAsyncQueryStopRequest {
        id "test-value"
    }
    let (endpoint, _) = EsqlAsyncQueryStopRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``esql_async_query_stop has no request body`` () =
    let req = esqlAsyncQueryStopRequest {
        id "test-value"
    }
    let (_, postData) = EsqlAsyncQueryStopRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_delete_view uses DELETE method`` () =
    let req = esqlDeleteViewRequest {
        name "test-value"
    }
    let (endpoint, _) = EsqlDeleteViewRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``esql_delete_view has no request body`` () =
    let req = esqlDeleteViewRequest {
        name "test-value"
    }
    let (_, postData) = EsqlDeleteViewRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_get_query uses GET method`` () =
    let req = esqlGetQueryRequest {
        id "test-value"
    }
    let (endpoint, _) = EsqlGetQueryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``esql_get_query has no request body`` () =
    let req = esqlGetQueryRequest {
        id "test-value"
    }
    let (_, postData) = EsqlGetQueryRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_get_view uses GET method`` () =
    let req = esqlGetViewRequest {
        name "test-value"
    }
    let (endpoint, _) = EsqlGetViewRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``esql_get_view has no request body`` () =
    let req = esqlGetViewRequest {
        name "test-value"
    }
    let (_, postData) = EsqlGetViewRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_list_queries uses GET method`` () =
    let req = Unchecked.defaultof<EsqlListQueriesRequest>
    let (endpoint, _) = EsqlListQueriesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``esql_list_queries has no request body`` () =
    let req = Unchecked.defaultof<EsqlListQueriesRequest>
    let (_, postData) = EsqlListQueriesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``esql_put_view uses PUT method`` () =
    let req = esqlPutViewRequest {
        name "test-value"
    }
    let (endpoint, _) = EsqlPutViewRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``esql_put_view has request body`` () =
    let req = esqlPutViewRequest {
        name "test-value"
    }
    let (_, postData) = EsqlPutViewRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``esql_query uses POST method`` () =
    let req = Unchecked.defaultof<EsqlQueryRequest>
    let (endpoint, _) = EsqlQueryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``esql_query has request body`` () =
    let req = Unchecked.defaultof<EsqlQueryRequest>
    let (_, postData) = EsqlQueryRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``exists uses HEAD method`` () =
    let req = existsRequest {
        id "test-value"
        index "test-value"
    }
    let (endpoint, _) = ExistsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.HEAD

[<Fact>]
let ``exists has no request body`` () =
    let req = existsRequest {
        id "test-value"
        index "test-value"
    }
    let (_, postData) = ExistsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``exists_source uses HEAD method`` () =
    let req = existsSourceRequest {
        id "test-value"
        index "test-value"
    }
    let (endpoint, _) = ExistsSourceRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.HEAD

[<Fact>]
let ``exists_source has no request body`` () =
    let req = existsSourceRequest {
        id "test-value"
        index "test-value"
    }
    let (_, postData) = ExistsSourceRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``explain uses POST method`` () =
    let req = explainRequest {
        id "test-value"
        index "test-value"
    }
    let (endpoint, _) = ExplainRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``explain has request body`` () =
    let req = explainRequest {
        id "test-value"
        index "test-value"
    }
    let (_, postData) = ExplainRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``features_get_features uses GET method`` () =
    let req = Unchecked.defaultof<FeaturesGetFeaturesRequest>
    let (endpoint, _) = FeaturesGetFeaturesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``features_get_features has no request body`` () =
    let req = Unchecked.defaultof<FeaturesGetFeaturesRequest>
    let (_, postData) = FeaturesGetFeaturesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``features_reset_features uses POST method`` () =
    let req = Unchecked.defaultof<FeaturesResetFeaturesRequest>
    let (endpoint, _) = FeaturesResetFeaturesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``features_reset_features has no request body`` () =
    let req = Unchecked.defaultof<FeaturesResetFeaturesRequest>
    let (_, postData) = FeaturesResetFeaturesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``fleet_delete_secret uses DELETE method`` () =
    let req = fleetDeleteSecretRequest {
        id "test-value"
    }
    let (endpoint, _) = FleetDeleteSecretRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``fleet_delete_secret has no request body`` () =
    let req = fleetDeleteSecretRequest {
        id "test-value"
    }
    let (_, postData) = FleetDeleteSecretRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``fleet_get_secret uses GET method`` () =
    let req = fleetGetSecretRequest {
        id "test-value"
    }
    let (endpoint, _) = FleetGetSecretRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``fleet_get_secret has no request body`` () =
    let req = fleetGetSecretRequest {
        id "test-value"
    }
    let (_, postData) = FleetGetSecretRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``fleet_post_secret uses POST method`` () =
    let req = Unchecked.defaultof<FleetPostSecretRequest>
    let (endpoint, _) = FleetPostSecretRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``fleet_post_secret has request body`` () =
    let req = Unchecked.defaultof<FleetPostSecretRequest>
    let (_, postData) = FleetPostSecretRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``get uses GET method`` () =
    let req = getRequest {
        id "test-value"
        index "test-value"
    }
    let (endpoint, _) = GetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``get has no request body`` () =
    let req = getRequest {
        id "test-value"
        index "test-value"
    }
    let (_, postData) = GetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``get_script uses GET method`` () =
    let req = getScriptRequest {
        id "test-value"
    }
    let (endpoint, _) = GetScriptRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``get_script has no request body`` () =
    let req = getScriptRequest {
        id "test-value"
    }
    let (_, postData) = GetScriptRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``get_script_context uses GET method`` () =
    let req = Unchecked.defaultof<GetScriptContextRequest>
    let (endpoint, _) = GetScriptContextRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``get_script_context has no request body`` () =
    let req = Unchecked.defaultof<GetScriptContextRequest>
    let (_, postData) = GetScriptContextRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``get_script_languages uses GET method`` () =
    let req = Unchecked.defaultof<GetScriptLanguagesRequest>
    let (endpoint, _) = GetScriptLanguagesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``get_script_languages has no request body`` () =
    let req = Unchecked.defaultof<GetScriptLanguagesRequest>
    let (_, postData) = GetScriptLanguagesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``get_source uses GET method`` () =
    let req = getSourceRequest {
        id "test-value"
        index "test-value"
    }
    let (endpoint, _) = GetSourceRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``get_source has no request body`` () =
    let req = getSourceRequest {
        id "test-value"
        index "test-value"
    }
    let (_, postData) = GetSourceRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_delete_lifecycle uses DELETE method`` () =
    let req = ilmDeleteLifecycleRequest {
        policy "test-value"
    }
    let (endpoint, _) = IlmDeleteLifecycleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ilm_delete_lifecycle has no request body`` () =
    let req = ilmDeleteLifecycleRequest {
        policy "test-value"
    }
    let (_, postData) = IlmDeleteLifecycleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_explain_lifecycle uses GET method`` () =
    let req = ilmExplainLifecycleRequest {
        index "test-value"
    }
    let (endpoint, _) = IlmExplainLifecycleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ilm_explain_lifecycle has no request body`` () =
    let req = ilmExplainLifecycleRequest {
        index "test-value"
    }
    let (_, postData) = IlmExplainLifecycleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_get_lifecycle uses GET method`` () =
    let req = ilmGetLifecycleRequest {
        policy "test-value"
    }
    let (endpoint, _) = IlmGetLifecycleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ilm_get_lifecycle has no request body`` () =
    let req = ilmGetLifecycleRequest {
        policy "test-value"
    }
    let (_, postData) = IlmGetLifecycleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_get_status uses GET method`` () =
    let req = Unchecked.defaultof<IlmGetStatusRequest>
    let (endpoint, _) = IlmGetStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ilm_get_status has no request body`` () =
    let req = Unchecked.defaultof<IlmGetStatusRequest>
    let (_, postData) = IlmGetStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_migrate_to_data_tiers uses POST method`` () =
    let req = Unchecked.defaultof<IlmMigrateToDataTiersRequest>
    let (endpoint, _) = IlmMigrateToDataTiersRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ilm_migrate_to_data_tiers has request body`` () =
    let req = Unchecked.defaultof<IlmMigrateToDataTiersRequest>
    let (_, postData) = IlmMigrateToDataTiersRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ilm_move_to_step uses POST method`` () =
    let req = ilmMoveToStepRequest {
        index "test-value"
    }
    let (endpoint, _) = IlmMoveToStepRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ilm_move_to_step has request body`` () =
    let req = ilmMoveToStepRequest {
        index "test-value"
    }
    let (_, postData) = IlmMoveToStepRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ilm_remove_policy uses POST method`` () =
    let req = ilmRemovePolicyRequest {
        index "test-value"
    }
    let (endpoint, _) = IlmRemovePolicyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ilm_remove_policy has no request body`` () =
    let req = ilmRemovePolicyRequest {
        index "test-value"
    }
    let (_, postData) = IlmRemovePolicyRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_retry uses POST method`` () =
    let req = ilmRetryRequest {
        index "test-value"
    }
    let (endpoint, _) = IlmRetryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ilm_retry has no request body`` () =
    let req = ilmRetryRequest {
        index "test-value"
    }
    let (_, postData) = IlmRetryRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_start uses POST method`` () =
    let req = Unchecked.defaultof<IlmStartRequest>
    let (endpoint, _) = IlmStartRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ilm_start has no request body`` () =
    let req = Unchecked.defaultof<IlmStartRequest>
    let (_, postData) = IlmStartRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ilm_stop uses POST method`` () =
    let req = Unchecked.defaultof<IlmStopRequest>
    let (endpoint, _) = IlmStopRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ilm_stop has no request body`` () =
    let req = Unchecked.defaultof<IlmStopRequest>
    let (_, postData) = IlmStopRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_analyze uses POST method`` () =
    let req = indicesAnalyzeRequest {
        index "test-value"
    }
    let (endpoint, _) = IndicesAnalyzeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_analyze has request body`` () =
    let req = indicesAnalyzeRequest {
        index "test-value"
    }
    let (_, postData) = IndicesAnalyzeRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_clone uses POST method`` () =
    let req = indicesCloneRequest {
        index "test-value"
        target "test-value"
    }
    let (endpoint, _) = IndicesCloneRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_clone has request body`` () =
    let req = indicesCloneRequest {
        index "test-value"
        target "test-value"
    }
    let (_, postData) = IndicesCloneRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_create uses PUT method`` () =
    let req = indicesCreateRequest {
        index "test-value"
    }
    let (endpoint, _) = IndicesCreateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``indices_create has request body`` () =
    let req = indicesCreateRequest {
        index "test-value"
    }
    let (_, postData) = IndicesCreateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_create_data_stream uses PUT method`` () =
    let req = indicesCreateDataStreamRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesCreateDataStreamRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``indices_create_data_stream has no request body`` () =
    let req = indicesCreateDataStreamRequest {
        name "test-value"
    }
    let (_, postData) = IndicesCreateDataStreamRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_create_from uses POST method`` () =
    let req = indicesCreateFromRequest {
        source "test-value"
        dest "test-value"
    }
    let (endpoint, _) = IndicesCreateFromRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_create_from has request body`` () =
    let req = indicesCreateFromRequest {
        source "test-value"
        dest "test-value"
    }
    let (_, postData) = IndicesCreateFromRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_delete_template uses DELETE method`` () =
    let req = indicesDeleteTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesDeleteTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``indices_delete_template has no request body`` () =
    let req = indicesDeleteTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesDeleteTemplateRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_downsample uses POST method`` () =
    let req = indicesDownsampleRequest {
        index "test-value"
        targetIndex "test-value"
    }
    let (endpoint, _) = IndicesDownsampleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_downsample has request body`` () =
    let req = indicesDownsampleRequest {
        index "test-value"
        targetIndex "test-value"
    }
    let (_, postData) = IndicesDownsampleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_exists_index_template uses HEAD method`` () =
    let req = indicesExistsIndexTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesExistsIndexTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.HEAD

[<Fact>]
let ``indices_exists_index_template has no request body`` () =
    let req = indicesExistsIndexTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesExistsIndexTemplateRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_get_data_lifecycle_stats uses GET method`` () =
    let req = Unchecked.defaultof<IndicesGetDataLifecycleStatsRequest>
    let (endpoint, _) = IndicesGetDataLifecycleStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``indices_get_data_lifecycle_stats has no request body`` () =
    let req = Unchecked.defaultof<IndicesGetDataLifecycleStatsRequest>
    let (_, postData) = IndicesGetDataLifecycleStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_get_index_template uses GET method`` () =
    let req = indicesGetIndexTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesGetIndexTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``indices_get_index_template has no request body`` () =
    let req = indicesGetIndexTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesGetIndexTemplateRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_migrate_reindex uses POST method`` () =
    let req = Unchecked.defaultof<IndicesMigrateReindexRequest>
    let (endpoint, _) = IndicesMigrateReindexRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_migrate_reindex has request body`` () =
    let req = Unchecked.defaultof<IndicesMigrateReindexRequest>
    let (_, postData) = IndicesMigrateReindexRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_migrate_to_data_stream uses POST method`` () =
    let req = indicesMigrateToDataStreamRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesMigrateToDataStreamRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_migrate_to_data_stream has no request body`` () =
    let req = indicesMigrateToDataStreamRequest {
        name "test-value"
    }
    let (_, postData) = IndicesMigrateToDataStreamRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_modify_data_stream uses POST method`` () =
    let req = Unchecked.defaultof<IndicesModifyDataStreamRequest>
    let (endpoint, _) = IndicesModifyDataStreamRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_modify_data_stream has request body`` () =
    let req = Unchecked.defaultof<IndicesModifyDataStreamRequest>
    let (_, postData) = IndicesModifyDataStreamRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_promote_data_stream uses POST method`` () =
    let req = indicesPromoteDataStreamRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesPromoteDataStreamRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_promote_data_stream has no request body`` () =
    let req = indicesPromoteDataStreamRequest {
        name "test-value"
    }
    let (_, postData) = IndicesPromoteDataStreamRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``indices_put_index_template uses POST method`` () =
    let req = indicesPutIndexTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesPutIndexTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_put_index_template has request body`` () =
    let req = indicesPutIndexTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesPutIndexTemplateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_put_template uses POST method`` () =
    let req = indicesPutTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesPutTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_put_template has request body`` () =
    let req = indicesPutTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesPutTemplateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_rollover uses POST method`` () =
    let req = indicesRolloverRequest {
        alias "test-value"
        newIndex "test-value"
    }
    let (endpoint, _) = IndicesRolloverRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_rollover has request body`` () =
    let req = indicesRolloverRequest {
        alias "test-value"
        newIndex "test-value"
    }
    let (_, postData) = IndicesRolloverRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_shrink uses POST method`` () =
    let req = indicesShrinkRequest {
        index "test-value"
        target "test-value"
    }
    let (endpoint, _) = IndicesShrinkRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_shrink has request body`` () =
    let req = indicesShrinkRequest {
        index "test-value"
        target "test-value"
    }
    let (_, postData) = IndicesShrinkRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_simulate_index_template uses POST method`` () =
    let req = indicesSimulateIndexTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesSimulateIndexTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_simulate_index_template has request body`` () =
    let req = indicesSimulateIndexTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesSimulateIndexTemplateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_simulate_template uses POST method`` () =
    let req = indicesSimulateTemplateRequest {
        name "test-value"
    }
    let (endpoint, _) = IndicesSimulateTemplateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_simulate_template has request body`` () =
    let req = indicesSimulateTemplateRequest {
        name "test-value"
    }
    let (_, postData) = IndicesSimulateTemplateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_split uses POST method`` () =
    let req = indicesSplitRequest {
        index "test-value"
        target "test-value"
    }
    let (endpoint, _) = IndicesSplitRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_split has request body`` () =
    let req = indicesSplitRequest {
        index "test-value"
        target "test-value"
    }
    let (_, postData) = IndicesSplitRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``indices_update_aliases uses POST method`` () =
    let req = Unchecked.defaultof<IndicesUpdateAliasesRequest>
    let (endpoint, _) = IndicesUpdateAliasesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``indices_update_aliases has request body`` () =
    let req = Unchecked.defaultof<IndicesUpdateAliasesRequest>
    let (_, postData) = IndicesUpdateAliasesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_chat_completion_unified uses POST method`` () =
    let req = inferenceChatCompletionUnifiedRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceChatCompletionUnifiedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_chat_completion_unified has request body`` () =
    let req = inferenceChatCompletionUnifiedRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceChatCompletionUnifiedRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_completion uses POST method`` () =
    let req = inferenceCompletionRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceCompletionRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_completion has request body`` () =
    let req = inferenceCompletionRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceCompletionRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_embedding uses POST method`` () =
    let req = inferenceEmbeddingRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceEmbeddingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_embedding has request body`` () =
    let req = inferenceEmbeddingRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceEmbeddingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_rerank uses POST method`` () =
    let req = inferenceRerankRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceRerankRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_rerank has request body`` () =
    let req = inferenceRerankRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceRerankRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_sparse_embedding uses POST method`` () =
    let req = inferenceSparseEmbeddingRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceSparseEmbeddingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_sparse_embedding has request body`` () =
    let req = inferenceSparseEmbeddingRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceSparseEmbeddingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_stream_completion uses POST method`` () =
    let req = inferenceStreamCompletionRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceStreamCompletionRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_stream_completion has request body`` () =
    let req = inferenceStreamCompletionRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceStreamCompletionRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``inference_text_embedding uses POST method`` () =
    let req = inferenceTextEmbeddingRequest {
        inferenceId "test-value"
    }
    let (endpoint, _) = InferenceTextEmbeddingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``inference_text_embedding has request body`` () =
    let req = inferenceTextEmbeddingRequest {
        inferenceId "test-value"
    }
    let (_, postData) = InferenceTextEmbeddingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``info uses GET method`` () =
    let req = Unchecked.defaultof<InfoRequest>
    let (endpoint, _) = InfoRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``info has no request body`` () =
    let req = Unchecked.defaultof<InfoRequest>
    let (_, postData) = InfoRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ingest_delete_pipeline uses DELETE method`` () =
    let req = ingestDeletePipelineRequest {
        id "test-value"
    }
    let (endpoint, _) = IngestDeletePipelineRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ingest_delete_pipeline has no request body`` () =
    let req = ingestDeletePipelineRequest {
        id "test-value"
    }
    let (_, postData) = IngestDeletePipelineRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ingest_geo_ip_stats uses GET method`` () =
    let req = Unchecked.defaultof<IngestGeoIpStatsRequest>
    let (endpoint, _) = IngestGeoIpStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ingest_geo_ip_stats has no request body`` () =
    let req = Unchecked.defaultof<IngestGeoIpStatsRequest>
    let (_, postData) = IngestGeoIpStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ingest_get_pipeline uses GET method`` () =
    let req = ingestGetPipelineRequest {
        id "test-value"
    }
    let (endpoint, _) = IngestGetPipelineRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ingest_get_pipeline has no request body`` () =
    let req = ingestGetPipelineRequest {
        id "test-value"
    }
    let (_, postData) = IngestGetPipelineRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ingest_processor_grok uses GET method`` () =
    let req = Unchecked.defaultof<IngestProcessorGrokRequest>
    let (endpoint, _) = IngestProcessorGrokRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ingest_processor_grok has no request body`` () =
    let req = Unchecked.defaultof<IngestProcessorGrokRequest>
    let (_, postData) = IngestProcessorGrokRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ingest_put_geoip_database uses PUT method`` () =
    let req = ingestPutGeoipDatabaseRequest {
        id "test-value"
    }
    let (endpoint, _) = IngestPutGeoipDatabaseRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ingest_put_geoip_database has request body`` () =
    let req = ingestPutGeoipDatabaseRequest {
        id "test-value"
    }
    let (_, postData) = IngestPutGeoipDatabaseRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ingest_put_ip_location_database uses PUT method`` () =
    let req = ingestPutIpLocationDatabaseRequest {
        id "test-value"
    }
    let (endpoint, _) = IngestPutIpLocationDatabaseRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ingest_put_ip_location_database has request body`` () =
    let req = ingestPutIpLocationDatabaseRequest {
        id "test-value"
    }
    let (_, postData) = IngestPutIpLocationDatabaseRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ingest_put_pipeline uses PUT method`` () =
    let req = ingestPutPipelineRequest {
        id "test-value"
    }
    let (endpoint, _) = IngestPutPipelineRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ingest_put_pipeline has request body`` () =
    let req = ingestPutPipelineRequest {
        id "test-value"
    }
    let (_, postData) = IngestPutPipelineRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ingest_simulate uses POST method`` () =
    let req = ingestSimulateRequest {
        id "test-value"
    }
    let (endpoint, _) = IngestSimulateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ingest_simulate has request body`` () =
    let req = ingestSimulateRequest {
        id "test-value"
    }
    let (_, postData) = IngestSimulateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``license_delete uses DELETE method`` () =
    let req = Unchecked.defaultof<LicenseDeleteRequest>
    let (endpoint, _) = LicenseDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``license_delete has no request body`` () =
    let req = Unchecked.defaultof<LicenseDeleteRequest>
    let (_, postData) = LicenseDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``license_get uses GET method`` () =
    let req = Unchecked.defaultof<LicenseGetRequest>
    let (endpoint, _) = LicenseGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``license_get has no request body`` () =
    let req = Unchecked.defaultof<LicenseGetRequest>
    let (_, postData) = LicenseGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``license_get_basic_status uses GET method`` () =
    let req = Unchecked.defaultof<LicenseGetBasicStatusRequest>
    let (endpoint, _) = LicenseGetBasicStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``license_get_basic_status has no request body`` () =
    let req = Unchecked.defaultof<LicenseGetBasicStatusRequest>
    let (_, postData) = LicenseGetBasicStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``license_get_trial_status uses GET method`` () =
    let req = Unchecked.defaultof<LicenseGetTrialStatusRequest>
    let (endpoint, _) = LicenseGetTrialStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``license_get_trial_status has no request body`` () =
    let req = Unchecked.defaultof<LicenseGetTrialStatusRequest>
    let (_, postData) = LicenseGetTrialStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``license_post uses POST method`` () =
    let req = Unchecked.defaultof<LicensePostRequest>
    let (endpoint, _) = LicensePostRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``license_post has request body`` () =
    let req = Unchecked.defaultof<LicensePostRequest>
    let (_, postData) = LicensePostRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``license_post_start_basic uses POST method`` () =
    let req = Unchecked.defaultof<LicensePostStartBasicRequest>
    let (endpoint, _) = LicensePostStartBasicRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``license_post_start_basic has no request body`` () =
    let req = Unchecked.defaultof<LicensePostStartBasicRequest>
    let (_, postData) = LicensePostStartBasicRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``license_post_start_trial uses POST method`` () =
    let req = Unchecked.defaultof<LicensePostStartTrialRequest>
    let (endpoint, _) = LicensePostStartTrialRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``license_post_start_trial has no request body`` () =
    let req = Unchecked.defaultof<LicensePostStartTrialRequest>
    let (_, postData) = LicensePostStartTrialRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``logstash_delete_pipeline uses DELETE method`` () =
    let req = logstashDeletePipelineRequest {
        id "test-value"
    }
    let (endpoint, _) = LogstashDeletePipelineRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``logstash_delete_pipeline has no request body`` () =
    let req = logstashDeletePipelineRequest {
        id "test-value"
    }
    let (_, postData) = LogstashDeletePipelineRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``logstash_put_pipeline uses PUT method`` () =
    let req = logstashPutPipelineRequest {
        id "test-value"
    }
    let (endpoint, _) = LogstashPutPipelineRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``logstash_put_pipeline has request body`` () =
    let req = logstashPutPipelineRequest {
        id "test-value"
    }
    let (_, postData) = LogstashPutPipelineRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``mget uses POST method`` () =
    let req = mgetRequest {
        index "test-value"
    }
    let (endpoint, _) = MgetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``mget has request body`` () =
    let req = mgetRequest {
        index "test-value"
    }
    let (_, postData) = MgetRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``migration_deprecations uses GET method`` () =
    let req = migrationDeprecationsRequest {
        index "test-value"
    }
    let (endpoint, _) = MigrationDeprecationsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``migration_deprecations has no request body`` () =
    let req = migrationDeprecationsRequest {
        index "test-value"
    }
    let (_, postData) = MigrationDeprecationsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``migration_get_feature_upgrade_status uses GET method`` () =
    let req = Unchecked.defaultof<MigrationGetFeatureUpgradeStatusRequest>
    let (endpoint, _) = MigrationGetFeatureUpgradeStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``migration_get_feature_upgrade_status has no request body`` () =
    let req = Unchecked.defaultof<MigrationGetFeatureUpgradeStatusRequest>
    let (_, postData) = MigrationGetFeatureUpgradeStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``migration_post_feature_upgrade uses POST method`` () =
    let req = Unchecked.defaultof<MigrationPostFeatureUpgradeRequest>
    let (endpoint, _) = MigrationPostFeatureUpgradeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``migration_post_feature_upgrade has no request body`` () =
    let req = Unchecked.defaultof<MigrationPostFeatureUpgradeRequest>
    let (_, postData) = MigrationPostFeatureUpgradeRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_clear_trained_model_deployment_cache uses POST method`` () =
    let req = mlClearTrainedModelDeploymentCacheRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlClearTrainedModelDeploymentCacheRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_clear_trained_model_deployment_cache has no request body`` () =
    let req = mlClearTrainedModelDeploymentCacheRequest {
        modelId "test-value"
    }
    let (_, postData) = MlClearTrainedModelDeploymentCacheRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_close_job uses POST method`` () =
    let req = mlCloseJobRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlCloseJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_close_job has request body`` () =
    let req = mlCloseJobRequest {
        jobId "test-value"
    }
    let (_, postData) = MlCloseJobRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_delete_calendar uses DELETE method`` () =
    let req = mlDeleteCalendarRequest {
        calendarId "test-value"
    }
    let (endpoint, _) = MlDeleteCalendarRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_calendar has no request body`` () =
    let req = mlDeleteCalendarRequest {
        calendarId "test-value"
    }
    let (_, postData) = MlDeleteCalendarRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_calendar_event uses DELETE method`` () =
    let req = mlDeleteCalendarEventRequest {
        calendarId "test-value"
        eventId "test-value"
    }
    let (endpoint, _) = MlDeleteCalendarEventRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_calendar_event has no request body`` () =
    let req = mlDeleteCalendarEventRequest {
        calendarId "test-value"
        eventId "test-value"
    }
    let (_, postData) = MlDeleteCalendarEventRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_data_frame_analytics uses DELETE method`` () =
    let req = mlDeleteDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlDeleteDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_data_frame_analytics has no request body`` () =
    let req = mlDeleteDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = MlDeleteDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_datafeed uses DELETE method`` () =
    let req = mlDeleteDatafeedRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = MlDeleteDatafeedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_datafeed has no request body`` () =
    let req = mlDeleteDatafeedRequest {
        datafeedId "test-value"
    }
    let (_, postData) = MlDeleteDatafeedRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_expired_data uses DELETE method`` () =
    let req = mlDeleteExpiredDataRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlDeleteExpiredDataRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_expired_data has request body`` () =
    let req = mlDeleteExpiredDataRequest {
        jobId "test-value"
    }
    let (_, postData) = MlDeleteExpiredDataRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_delete_filter uses DELETE method`` () =
    let req = mlDeleteFilterRequest {
        filterId "test-value"
    }
    let (endpoint, _) = MlDeleteFilterRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_filter has no request body`` () =
    let req = mlDeleteFilterRequest {
        filterId "test-value"
    }
    let (_, postData) = MlDeleteFilterRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_forecast uses DELETE method`` () =
    let req = mlDeleteForecastRequest {
        jobId "test-value"
        forecastId "test-value"
    }
    let (endpoint, _) = MlDeleteForecastRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_forecast has no request body`` () =
    let req = mlDeleteForecastRequest {
        jobId "test-value"
        forecastId "test-value"
    }
    let (_, postData) = MlDeleteForecastRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_job uses DELETE method`` () =
    let req = mlDeleteJobRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlDeleteJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_job has no request body`` () =
    let req = mlDeleteJobRequest {
        jobId "test-value"
    }
    let (_, postData) = MlDeleteJobRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_model_snapshot uses DELETE method`` () =
    let req = mlDeleteModelSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (endpoint, _) = MlDeleteModelSnapshotRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_model_snapshot has no request body`` () =
    let req = mlDeleteModelSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (_, postData) = MlDeleteModelSnapshotRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_trained_model uses DELETE method`` () =
    let req = mlDeleteTrainedModelRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlDeleteTrainedModelRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_trained_model has no request body`` () =
    let req = mlDeleteTrainedModelRequest {
        modelId "test-value"
    }
    let (_, postData) = MlDeleteTrainedModelRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_delete_trained_model_alias uses DELETE method`` () =
    let req = mlDeleteTrainedModelAliasRequest {
        modelAlias "test-value"
        modelId "test-value"
    }
    let (endpoint, _) = MlDeleteTrainedModelAliasRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``ml_delete_trained_model_alias has no request body`` () =
    let req = mlDeleteTrainedModelAliasRequest {
        modelAlias "test-value"
        modelId "test-value"
    }
    let (_, postData) = MlDeleteTrainedModelAliasRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_estimate_model_memory uses POST method`` () =
    let req = Unchecked.defaultof<MlEstimateModelMemoryRequest>
    let (endpoint, _) = MlEstimateModelMemoryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_estimate_model_memory has request body`` () =
    let req = Unchecked.defaultof<MlEstimateModelMemoryRequest>
    let (_, postData) = MlEstimateModelMemoryRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_evaluate_data_frame uses POST method`` () =
    let req = Unchecked.defaultof<MlEvaluateDataFrameRequest>
    let (endpoint, _) = MlEvaluateDataFrameRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_evaluate_data_frame has request body`` () =
    let req = Unchecked.defaultof<MlEvaluateDataFrameRequest>
    let (_, postData) = MlEvaluateDataFrameRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_explain_data_frame_analytics uses POST method`` () =
    let req = mlExplainDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlExplainDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_explain_data_frame_analytics has request body`` () =
    let req = mlExplainDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = MlExplainDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_flush_job uses POST method`` () =
    let req = mlFlushJobRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlFlushJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_flush_job has request body`` () =
    let req = mlFlushJobRequest {
        jobId "test-value"
    }
    let (_, postData) = MlFlushJobRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_forecast uses POST method`` () =
    let req = mlForecastRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlForecastRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_forecast has request body`` () =
    let req = mlForecastRequest {
        jobId "test-value"
    }
    let (_, postData) = MlForecastRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_get_calendar_events uses GET method`` () =
    let req = mlGetCalendarEventsRequest {
        calendarId "test-value"
    }
    let (endpoint, _) = MlGetCalendarEventsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_get_calendar_events has no request body`` () =
    let req = mlGetCalendarEventsRequest {
        calendarId "test-value"
    }
    let (_, postData) = MlGetCalendarEventsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_get_calendars uses POST method`` () =
    let req = mlGetCalendarsRequest {
        calendarId "test-value"
    }
    let (endpoint, _) = MlGetCalendarsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_get_calendars has request body`` () =
    let req = mlGetCalendarsRequest {
        calendarId "test-value"
    }
    let (_, postData) = MlGetCalendarsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_get_data_frame_analytics uses GET method`` () =
    let req = mlGetDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlGetDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_get_data_frame_analytics has no request body`` () =
    let req = mlGetDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = MlGetDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_get_data_frame_analytics_stats uses GET method`` () =
    let req = mlGetDataFrameAnalyticsStatsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlGetDataFrameAnalyticsStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_get_data_frame_analytics_stats has no request body`` () =
    let req = mlGetDataFrameAnalyticsStatsRequest {
        id "test-value"
    }
    let (_, postData) = MlGetDataFrameAnalyticsStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_get_influencers uses POST method`` () =
    let req = mlGetInfluencersRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlGetInfluencersRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_get_influencers has request body`` () =
    let req = mlGetInfluencersRequest {
        jobId "test-value"
    }
    let (_, postData) = MlGetInfluencersRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_get_job_stats uses GET method`` () =
    let req = mlGetJobStatsRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlGetJobStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_get_job_stats has no request body`` () =
    let req = mlGetJobStatsRequest {
        jobId "test-value"
    }
    let (_, postData) = MlGetJobStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_get_memory_stats uses GET method`` () =
    let req = mlGetMemoryStatsRequest {
        nodeId "test-value"
    }
    let (endpoint, _) = MlGetMemoryStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_get_memory_stats has no request body`` () =
    let req = mlGetMemoryStatsRequest {
        nodeId "test-value"
    }
    let (_, postData) = MlGetMemoryStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_get_model_snapshot_upgrade_stats uses GET method`` () =
    let req = mlGetModelSnapshotUpgradeStatsRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (endpoint, _) = MlGetModelSnapshotUpgradeStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_get_model_snapshot_upgrade_stats has no request body`` () =
    let req = mlGetModelSnapshotUpgradeStatsRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (_, postData) = MlGetModelSnapshotUpgradeStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_get_model_snapshots uses POST method`` () =
    let req = mlGetModelSnapshotsRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (endpoint, _) = MlGetModelSnapshotsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_get_model_snapshots has request body`` () =
    let req = mlGetModelSnapshotsRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (_, postData) = MlGetModelSnapshotsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_get_overall_buckets uses POST method`` () =
    let req = mlGetOverallBucketsRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlGetOverallBucketsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_get_overall_buckets has request body`` () =
    let req = mlGetOverallBucketsRequest {
        jobId "test-value"
    }
    let (_, postData) = MlGetOverallBucketsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_get_records uses POST method`` () =
    let req = mlGetRecordsRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlGetRecordsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_get_records has request body`` () =
    let req = mlGetRecordsRequest {
        jobId "test-value"
    }
    let (_, postData) = MlGetRecordsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_infer_trained_model uses POST method`` () =
    let req = mlInferTrainedModelRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlInferTrainedModelRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_infer_trained_model has request body`` () =
    let req = mlInferTrainedModelRequest {
        modelId "test-value"
    }
    let (_, postData) = MlInferTrainedModelRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_info uses GET method`` () =
    let req = Unchecked.defaultof<MlInfoRequest>
    let (endpoint, _) = MlInfoRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ml_info has no request body`` () =
    let req = Unchecked.defaultof<MlInfoRequest>
    let (_, postData) = MlInfoRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_open_job uses POST method`` () =
    let req = mlOpenJobRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlOpenJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_open_job has request body`` () =
    let req = mlOpenJobRequest {
        jobId "test-value"
    }
    let (_, postData) = MlOpenJobRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_post_calendar_events uses POST method`` () =
    let req = mlPostCalendarEventsRequest {
        calendarId "test-value"
    }
    let (endpoint, _) = MlPostCalendarEventsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_post_calendar_events has request body`` () =
    let req = mlPostCalendarEventsRequest {
        calendarId "test-value"
    }
    let (_, postData) = MlPostCalendarEventsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_preview_data_frame_analytics uses POST method`` () =
    let req = mlPreviewDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlPreviewDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_preview_data_frame_analytics has request body`` () =
    let req = mlPreviewDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = MlPreviewDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_preview_datafeed uses POST method`` () =
    let req = mlPreviewDatafeedRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = MlPreviewDatafeedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_preview_datafeed has request body`` () =
    let req = mlPreviewDatafeedRequest {
        datafeedId "test-value"
    }
    let (_, postData) = MlPreviewDatafeedRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_put_calendar uses PUT method`` () =
    let req = mlPutCalendarRequest {
        calendarId "test-value"
    }
    let (endpoint, _) = MlPutCalendarRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_calendar has request body`` () =
    let req = mlPutCalendarRequest {
        calendarId "test-value"
    }
    let (_, postData) = MlPutCalendarRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_put_data_frame_analytics uses PUT method`` () =
    let req = mlPutDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlPutDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_data_frame_analytics has request body`` () =
    let req = mlPutDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = MlPutDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_put_datafeed uses PUT method`` () =
    let req = mlPutDatafeedRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = MlPutDatafeedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_datafeed has request body`` () =
    let req = mlPutDatafeedRequest {
        datafeedId "test-value"
    }
    let (_, postData) = MlPutDatafeedRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_put_filter uses PUT method`` () =
    let req = mlPutFilterRequest {
        filterId "test-value"
    }
    let (endpoint, _) = MlPutFilterRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_filter has request body`` () =
    let req = mlPutFilterRequest {
        filterId "test-value"
    }
    let (_, postData) = MlPutFilterRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_put_trained_model uses PUT method`` () =
    let req = mlPutTrainedModelRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlPutTrainedModelRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_trained_model has request body`` () =
    let req = mlPutTrainedModelRequest {
        modelId "test-value"
    }
    let (_, postData) = MlPutTrainedModelRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_put_trained_model_alias uses PUT method`` () =
    let req = mlPutTrainedModelAliasRequest {
        modelAlias "test-value"
        modelId "test-value"
    }
    let (endpoint, _) = MlPutTrainedModelAliasRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_trained_model_alias has no request body`` () =
    let req = mlPutTrainedModelAliasRequest {
        modelAlias "test-value"
        modelId "test-value"
    }
    let (_, postData) = MlPutTrainedModelAliasRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_put_trained_model_vocabulary uses PUT method`` () =
    let req = mlPutTrainedModelVocabularyRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlPutTrainedModelVocabularyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``ml_put_trained_model_vocabulary has request body`` () =
    let req = mlPutTrainedModelVocabularyRequest {
        modelId "test-value"
    }
    let (_, postData) = MlPutTrainedModelVocabularyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_reset_job uses POST method`` () =
    let req = mlResetJobRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlResetJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_reset_job has no request body`` () =
    let req = mlResetJobRequest {
        jobId "test-value"
    }
    let (_, postData) = MlResetJobRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_revert_model_snapshot uses POST method`` () =
    let req = mlRevertModelSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (endpoint, _) = MlRevertModelSnapshotRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_revert_model_snapshot has request body`` () =
    let req = mlRevertModelSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (_, postData) = MlRevertModelSnapshotRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_set_upgrade_mode uses POST method`` () =
    let req = Unchecked.defaultof<MlSetUpgradeModeRequest>
    let (endpoint, _) = MlSetUpgradeModeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_set_upgrade_mode has no request body`` () =
    let req = Unchecked.defaultof<MlSetUpgradeModeRequest>
    let (_, postData) = MlSetUpgradeModeRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_start_datafeed uses POST method`` () =
    let req = mlStartDatafeedRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = MlStartDatafeedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_start_datafeed has request body`` () =
    let req = mlStartDatafeedRequest {
        datafeedId "test-value"
    }
    let (_, postData) = MlStartDatafeedRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_start_trained_model_deployment uses POST method`` () =
    let req = mlStartTrainedModelDeploymentRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlStartTrainedModelDeploymentRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_start_trained_model_deployment has request body`` () =
    let req = mlStartTrainedModelDeploymentRequest {
        modelId "test-value"
    }
    let (_, postData) = MlStartTrainedModelDeploymentRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_stop_datafeed uses POST method`` () =
    let req = mlStopDatafeedRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = MlStopDatafeedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_stop_datafeed has request body`` () =
    let req = mlStopDatafeedRequest {
        datafeedId "test-value"
    }
    let (_, postData) = MlStopDatafeedRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_stop_trained_model_deployment uses POST method`` () =
    let req = mlStopTrainedModelDeploymentRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlStopTrainedModelDeploymentRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_stop_trained_model_deployment has request body`` () =
    let req = mlStopTrainedModelDeploymentRequest {
        modelId "test-value"
    }
    let (_, postData) = MlStopTrainedModelDeploymentRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_update_data_frame_analytics uses POST method`` () =
    let req = mlUpdateDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (endpoint, _) = MlUpdateDataFrameAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_update_data_frame_analytics has request body`` () =
    let req = mlUpdateDataFrameAnalyticsRequest {
        id "test-value"
    }
    let (_, postData) = MlUpdateDataFrameAnalyticsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_update_datafeed uses POST method`` () =
    let req = mlUpdateDatafeedRequest {
        datafeedId "test-value"
    }
    let (endpoint, _) = MlUpdateDatafeedRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_update_datafeed has request body`` () =
    let req = mlUpdateDatafeedRequest {
        datafeedId "test-value"
    }
    let (_, postData) = MlUpdateDatafeedRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_update_filter uses POST method`` () =
    let req = mlUpdateFilterRequest {
        filterId "test-value"
    }
    let (endpoint, _) = MlUpdateFilterRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_update_filter has request body`` () =
    let req = mlUpdateFilterRequest {
        filterId "test-value"
    }
    let (_, postData) = MlUpdateFilterRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_update_job uses POST method`` () =
    let req = mlUpdateJobRequest {
        jobId "test-value"
    }
    let (endpoint, _) = MlUpdateJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_update_job has request body`` () =
    let req = mlUpdateJobRequest {
        jobId "test-value"
    }
    let (_, postData) = MlUpdateJobRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_update_model_snapshot uses POST method`` () =
    let req = mlUpdateModelSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (endpoint, _) = MlUpdateModelSnapshotRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_update_model_snapshot has request body`` () =
    let req = mlUpdateModelSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (_, postData) = MlUpdateModelSnapshotRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_update_trained_model_deployment uses POST method`` () =
    let req = mlUpdateTrainedModelDeploymentRequest {
        modelId "test-value"
    }
    let (endpoint, _) = MlUpdateTrainedModelDeploymentRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_update_trained_model_deployment has request body`` () =
    let req = mlUpdateTrainedModelDeploymentRequest {
        modelId "test-value"
    }
    let (_, postData) = MlUpdateTrainedModelDeploymentRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_upgrade_job_snapshot uses POST method`` () =
    let req = mlUpgradeJobSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (endpoint, _) = MlUpgradeJobSnapshotRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_upgrade_job_snapshot has no request body`` () =
    let req = mlUpgradeJobSnapshotRequest {
        jobId "test-value"
        snapshotId "test-value"
    }
    let (_, postData) = MlUpgradeJobSnapshotRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``ml_validate uses POST method`` () =
    let req = Unchecked.defaultof<MlValidateRequest>
    let (endpoint, _) = MlValidateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_validate has request body`` () =
    let req = Unchecked.defaultof<MlValidateRequest>
    let (_, postData) = MlValidateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ml_validate_detector uses POST method`` () =
    let req = Unchecked.defaultof<MlValidateDetectorRequest>
    let (endpoint, _) = MlValidateDetectorRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``ml_validate_detector has request body`` () =
    let req = Unchecked.defaultof<MlValidateDetectorRequest>
    let (_, postData) = MlValidateDetectorRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``mtermvectors uses POST method`` () =
    let req = mtermvectorsRequest {
        index "test-value"
    }
    let (endpoint, _) = MtermvectorsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``mtermvectors has request body`` () =
    let req = mtermvectorsRequest {
        index "test-value"
    }
    let (_, postData) = MtermvectorsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ping uses HEAD method`` () =
    let req = Unchecked.defaultof<PingRequest>
    let (endpoint, _) = PingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.HEAD

[<Fact>]
let ``ping has no request body`` () =
    let req = Unchecked.defaultof<PingRequest>
    let (_, postData) = PingRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``profiling_flamegraph uses POST method`` () =
    let req = Unchecked.defaultof<ProfilingFlamegraphRequest>
    let (endpoint, _) = ProfilingFlamegraphRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``profiling_flamegraph has request body`` () =
    let req = Unchecked.defaultof<ProfilingFlamegraphRequest>
    let (_, postData) = ProfilingFlamegraphRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``profiling_stacktraces uses POST method`` () =
    let req = Unchecked.defaultof<ProfilingStacktracesRequest>
    let (endpoint, _) = ProfilingStacktracesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``profiling_stacktraces has request body`` () =
    let req = Unchecked.defaultof<ProfilingStacktracesRequest>
    let (_, postData) = ProfilingStacktracesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``profiling_status uses GET method`` () =
    let req = Unchecked.defaultof<ProfilingStatusRequest>
    let (endpoint, _) = ProfilingStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``profiling_status has no request body`` () =
    let req = Unchecked.defaultof<ProfilingStatusRequest>
    let (_, postData) = ProfilingStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``profiling_topn_functions uses POST method`` () =
    let req = Unchecked.defaultof<ProfilingTopnFunctionsRequest>
    let (endpoint, _) = ProfilingTopnFunctionsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``profiling_topn_functions has request body`` () =
    let req = Unchecked.defaultof<ProfilingTopnFunctionsRequest>
    let (_, postData) = ProfilingTopnFunctionsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``project_create_many_routing uses PUT method`` () =
    let req = Unchecked.defaultof<ProjectCreateManyRoutingRequest>
    let (endpoint, _) = ProjectCreateManyRoutingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``project_create_many_routing has request body`` () =
    let req = Unchecked.defaultof<ProjectCreateManyRoutingRequest>
    let (_, postData) = ProjectCreateManyRoutingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``project_create_routing uses PUT method`` () =
    let req = projectCreateRoutingRequest {
        name "test-value"
    }
    let (endpoint, _) = ProjectCreateRoutingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``project_create_routing has request body`` () =
    let req = projectCreateRoutingRequest {
        name "test-value"
    }
    let (_, postData) = ProjectCreateRoutingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``project_delete_routing uses DELETE method`` () =
    let req = projectDeleteRoutingRequest {
        name "test-value"
    }
    let (endpoint, _) = ProjectDeleteRoutingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``project_delete_routing has no request body`` () =
    let req = projectDeleteRoutingRequest {
        name "test-value"
    }
    let (_, postData) = ProjectDeleteRoutingRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``project_get_many_routing uses GET method`` () =
    let req = Unchecked.defaultof<ProjectGetManyRoutingRequest>
    let (endpoint, _) = ProjectGetManyRoutingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``project_get_many_routing has no request body`` () =
    let req = Unchecked.defaultof<ProjectGetManyRoutingRequest>
    let (_, postData) = ProjectGetManyRoutingRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``project_get_routing uses GET method`` () =
    let req = projectGetRoutingRequest {
        name "test-value"
    }
    let (endpoint, _) = ProjectGetRoutingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``project_get_routing has no request body`` () =
    let req = projectGetRoutingRequest {
        name "test-value"
    }
    let (_, postData) = ProjectGetRoutingRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``project_tags uses POST method`` () =
    let req = Unchecked.defaultof<ProjectTagsRequest>
    let (endpoint, _) = ProjectTagsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``project_tags has request body`` () =
    let req = Unchecked.defaultof<ProjectTagsRequest>
    let (_, postData) = ProjectTagsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``put_script uses POST method`` () =
    let req = putScriptRequest {
        id "test-value"
        context "test-value"
    }
    let (endpoint, _) = PutScriptRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``put_script has request body`` () =
    let req = putScriptRequest {
        id "test-value"
        context "test-value"
    }
    let (_, postData) = PutScriptRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``query_rules_delete_rule uses DELETE method`` () =
    let req = queryRulesDeleteRuleRequest {
        rulesetId "test-value"
        ruleId "test-value"
    }
    let (endpoint, _) = QueryRulesDeleteRuleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``query_rules_delete_rule has no request body`` () =
    let req = queryRulesDeleteRuleRequest {
        rulesetId "test-value"
        ruleId "test-value"
    }
    let (_, postData) = QueryRulesDeleteRuleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``query_rules_delete_ruleset uses DELETE method`` () =
    let req = queryRulesDeleteRulesetRequest {
        rulesetId "test-value"
    }
    let (endpoint, _) = QueryRulesDeleteRulesetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``query_rules_delete_ruleset has no request body`` () =
    let req = queryRulesDeleteRulesetRequest {
        rulesetId "test-value"
    }
    let (_, postData) = QueryRulesDeleteRulesetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``query_rules_get_rule uses GET method`` () =
    let req = queryRulesGetRuleRequest {
        rulesetId "test-value"
        ruleId "test-value"
    }
    let (endpoint, _) = QueryRulesGetRuleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``query_rules_get_rule has no request body`` () =
    let req = queryRulesGetRuleRequest {
        rulesetId "test-value"
        ruleId "test-value"
    }
    let (_, postData) = QueryRulesGetRuleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``query_rules_get_ruleset uses GET method`` () =
    let req = queryRulesGetRulesetRequest {
        rulesetId "test-value"
    }
    let (endpoint, _) = QueryRulesGetRulesetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``query_rules_get_ruleset has no request body`` () =
    let req = queryRulesGetRulesetRequest {
        rulesetId "test-value"
    }
    let (_, postData) = QueryRulesGetRulesetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``query_rules_list_rulesets uses GET method`` () =
    let req = Unchecked.defaultof<QueryRulesListRulesetsRequest>
    let (endpoint, _) = QueryRulesListRulesetsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``query_rules_list_rulesets has no request body`` () =
    let req = Unchecked.defaultof<QueryRulesListRulesetsRequest>
    let (_, postData) = QueryRulesListRulesetsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``query_rules_put_rule uses PUT method`` () =
    let req = queryRulesPutRuleRequest {
        rulesetId "test-value"
        ruleId "test-value"
    }
    let (endpoint, _) = QueryRulesPutRuleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``query_rules_put_rule has request body`` () =
    let req = queryRulesPutRuleRequest {
        rulesetId "test-value"
        ruleId "test-value"
    }
    let (_, postData) = QueryRulesPutRuleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``query_rules_put_ruleset uses PUT method`` () =
    let req = queryRulesPutRulesetRequest {
        rulesetId "test-value"
    }
    let (endpoint, _) = QueryRulesPutRulesetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``query_rules_put_ruleset has request body`` () =
    let req = queryRulesPutRulesetRequest {
        rulesetId "test-value"
    }
    let (_, postData) = QueryRulesPutRulesetRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``query_rules_test uses POST method`` () =
    let req = queryRulesTestRequest {
        rulesetId "test-value"
    }
    let (endpoint, _) = QueryRulesTestRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``query_rules_test has request body`` () =
    let req = queryRulesTestRequest {
        rulesetId "test-value"
    }
    let (_, postData) = QueryRulesTestRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``reindex uses POST method`` () =
    let req = Unchecked.defaultof<ReindexRequest>
    let (endpoint, _) = ReindexRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``reindex has request body`` () =
    let req = Unchecked.defaultof<ReindexRequest>
    let (_, postData) = ReindexRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``reindex_rethrottle uses POST method`` () =
    let req = reindexRethrottleRequest {
        taskId "test-value"
    }
    let (endpoint, _) = ReindexRethrottleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``reindex_rethrottle has no request body`` () =
    let req = reindexRethrottleRequest {
        taskId "test-value"
    }
    let (_, postData) = ReindexRethrottleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``rollup_delete_job uses DELETE method`` () =
    let req = rollupDeleteJobRequest {
        id "test-value"
    }
    let (endpoint, _) = RollupDeleteJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``rollup_delete_job has no request body`` () =
    let req = rollupDeleteJobRequest {
        id "test-value"
    }
    let (_, postData) = RollupDeleteJobRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``rollup_get_jobs uses GET method`` () =
    let req = rollupGetJobsRequest {
        id "test-value"
    }
    let (endpoint, _) = RollupGetJobsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``rollup_get_jobs has no request body`` () =
    let req = rollupGetJobsRequest {
        id "test-value"
    }
    let (_, postData) = RollupGetJobsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``rollup_get_rollup_caps uses GET method`` () =
    let req = rollupGetRollupCapsRequest {
        id "test-value"
    }
    let (endpoint, _) = RollupGetRollupCapsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``rollup_get_rollup_caps has no request body`` () =
    let req = rollupGetRollupCapsRequest {
        id "test-value"
    }
    let (_, postData) = RollupGetRollupCapsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``rollup_put_job uses PUT method`` () =
    let req = rollupPutJobRequest {
        id "test-value"
    }
    let (endpoint, _) = RollupPutJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``rollup_put_job has request body`` () =
    let req = rollupPutJobRequest {
        id "test-value"
    }
    let (_, postData) = RollupPutJobRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``rollup_start_job uses POST method`` () =
    let req = rollupStartJobRequest {
        id "test-value"
    }
    let (endpoint, _) = RollupStartJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``rollup_start_job has no request body`` () =
    let req = rollupStartJobRequest {
        id "test-value"
    }
    let (_, postData) = RollupStartJobRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``rollup_stop_job uses POST method`` () =
    let req = rollupStopJobRequest {
        id "test-value"
    }
    let (endpoint, _) = RollupStopJobRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``rollup_stop_job has no request body`` () =
    let req = rollupStopJobRequest {
        id "test-value"
    }
    let (_, postData) = RollupStopJobRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``scripts_painless_execute uses POST method`` () =
    let req = Unchecked.defaultof<ScriptsPainlessExecuteRequest>
    let (endpoint, _) = ScriptsPainlessExecuteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``scripts_painless_execute has request body`` () =
    let req = Unchecked.defaultof<ScriptsPainlessExecuteRequest>
    let (_, postData) = ScriptsPainlessExecuteRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``search_application_delete uses DELETE method`` () =
    let req = searchApplicationDeleteRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationDeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``search_application_delete has no request body`` () =
    let req = searchApplicationDeleteRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationDeleteRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``search_application_delete_behavioral_analytics uses DELETE method`` () =
    let req = searchApplicationDeleteBehavioralAnalyticsRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationDeleteBehavioralAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``search_application_delete_behavioral_analytics has no request body`` () =
    let req = searchApplicationDeleteBehavioralAnalyticsRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationDeleteBehavioralAnalyticsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``search_application_get uses GET method`` () =
    let req = searchApplicationGetRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``search_application_get has no request body`` () =
    let req = searchApplicationGetRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``search_application_list uses GET method`` () =
    let req = Unchecked.defaultof<SearchApplicationListRequest>
    let (endpoint, _) = SearchApplicationListRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``search_application_list has no request body`` () =
    let req = Unchecked.defaultof<SearchApplicationListRequest>
    let (_, postData) = SearchApplicationListRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``search_application_put uses PUT method`` () =
    let req = searchApplicationPutRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationPutRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``search_application_put has request body`` () =
    let req = searchApplicationPutRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationPutRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``search_application_put_behavioral_analytics uses PUT method`` () =
    let req = searchApplicationPutBehavioralAnalyticsRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationPutBehavioralAnalyticsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``search_application_put_behavioral_analytics has no request body`` () =
    let req = searchApplicationPutBehavioralAnalyticsRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationPutBehavioralAnalyticsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``search_application_render_query uses POST method`` () =
    let req = searchApplicationRenderQueryRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationRenderQueryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``search_application_render_query has request body`` () =
    let req = searchApplicationRenderQueryRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationRenderQueryRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``search_application_search uses POST method`` () =
    let req = searchApplicationSearchRequest {
        name "test-value"
    }
    let (endpoint, _) = SearchApplicationSearchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``search_application_search has request body`` () =
    let req = searchApplicationSearchRequest {
        name "test-value"
    }
    let (_, postData) = SearchApplicationSearchRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``searchable_snapshots_mount uses POST method`` () =
    let req = searchableSnapshotsMountRequest {
        repository "test-value"
        snapshot "test-value"
    }
    let (endpoint, _) = SearchableSnapshotsMountRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``searchable_snapshots_mount has request body`` () =
    let req = searchableSnapshotsMountRequest {
        repository "test-value"
        snapshot "test-value"
    }
    let (_, postData) = SearchableSnapshotsMountRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_activate_user_profile uses POST method`` () =
    let req = Unchecked.defaultof<SecurityActivateUserProfileRequest>
    let (endpoint, _) = SecurityActivateUserProfileRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_activate_user_profile has request body`` () =
    let req = Unchecked.defaultof<SecurityActivateUserProfileRequest>
    let (_, postData) = SecurityActivateUserProfileRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_authenticate uses GET method`` () =
    let req = Unchecked.defaultof<SecurityAuthenticateRequest>
    let (endpoint, _) = SecurityAuthenticateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_authenticate has no request body`` () =
    let req = Unchecked.defaultof<SecurityAuthenticateRequest>
    let (_, postData) = SecurityAuthenticateRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_bulk_delete_role uses DELETE method`` () =
    let req = Unchecked.defaultof<SecurityBulkDeleteRoleRequest>
    let (endpoint, _) = SecurityBulkDeleteRoleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_bulk_delete_role has request body`` () =
    let req = Unchecked.defaultof<SecurityBulkDeleteRoleRequest>
    let (_, postData) = SecurityBulkDeleteRoleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_bulk_put_role uses POST method`` () =
    let req = Unchecked.defaultof<SecurityBulkPutRoleRequest>
    let (endpoint, _) = SecurityBulkPutRoleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_bulk_put_role has request body`` () =
    let req = Unchecked.defaultof<SecurityBulkPutRoleRequest>
    let (_, postData) = SecurityBulkPutRoleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_bulk_update_api_keys uses POST method`` () =
    let req = Unchecked.defaultof<SecurityBulkUpdateApiKeysRequest>
    let (endpoint, _) = SecurityBulkUpdateApiKeysRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_bulk_update_api_keys has request body`` () =
    let req = Unchecked.defaultof<SecurityBulkUpdateApiKeysRequest>
    let (_, postData) = SecurityBulkUpdateApiKeysRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_change_password uses POST method`` () =
    let req = securityChangePasswordRequest {
        username "test-value"
    }
    let (endpoint, _) = SecurityChangePasswordRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_change_password has request body`` () =
    let req = securityChangePasswordRequest {
        username "test-value"
    }
    let (_, postData) = SecurityChangePasswordRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_create_api_key uses POST method`` () =
    let req = Unchecked.defaultof<SecurityCreateApiKeyRequest>
    let (endpoint, _) = SecurityCreateApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_create_api_key has request body`` () =
    let req = Unchecked.defaultof<SecurityCreateApiKeyRequest>
    let (_, postData) = SecurityCreateApiKeyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_create_cross_cluster_api_key uses POST method`` () =
    let req = Unchecked.defaultof<SecurityCreateCrossClusterApiKeyRequest>
    let (endpoint, _) = SecurityCreateCrossClusterApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_create_cross_cluster_api_key has request body`` () =
    let req = Unchecked.defaultof<SecurityCreateCrossClusterApiKeyRequest>
    let (_, postData) = SecurityCreateCrossClusterApiKeyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_create_service_token uses POST method`` () =
    let req = securityCreateServiceTokenRequest {
        namespace' "test-value"
        service "test-value"
        name "test-value"
    }
    let (endpoint, _) = SecurityCreateServiceTokenRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_create_service_token has no request body`` () =
    let req = securityCreateServiceTokenRequest {
        namespace' "test-value"
        service "test-value"
        name "test-value"
    }
    let (_, postData) = SecurityCreateServiceTokenRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_delegate_pki uses POST method`` () =
    let req = Unchecked.defaultof<SecurityDelegatePkiRequest>
    let (endpoint, _) = SecurityDelegatePkiRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_delegate_pki has request body`` () =
    let req = Unchecked.defaultof<SecurityDelegatePkiRequest>
    let (_, postData) = SecurityDelegatePkiRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_delete_role uses DELETE method`` () =
    let req = securityDeleteRoleRequest {
        name "test-value"
    }
    let (endpoint, _) = SecurityDeleteRoleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_delete_role has no request body`` () =
    let req = securityDeleteRoleRequest {
        name "test-value"
    }
    let (_, postData) = SecurityDeleteRoleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_delete_role_mapping uses DELETE method`` () =
    let req = securityDeleteRoleMappingRequest {
        name "test-value"
    }
    let (endpoint, _) = SecurityDeleteRoleMappingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_delete_role_mapping has no request body`` () =
    let req = securityDeleteRoleMappingRequest {
        name "test-value"
    }
    let (_, postData) = SecurityDeleteRoleMappingRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_delete_service_token uses DELETE method`` () =
    let req = securityDeleteServiceTokenRequest {
        namespace' "test-value"
        service "test-value"
        name "test-value"
    }
    let (endpoint, _) = SecurityDeleteServiceTokenRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_delete_service_token has no request body`` () =
    let req = securityDeleteServiceTokenRequest {
        namespace' "test-value"
        service "test-value"
        name "test-value"
    }
    let (_, postData) = SecurityDeleteServiceTokenRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_delete_user uses DELETE method`` () =
    let req = securityDeleteUserRequest {
        username "test-value"
    }
    let (endpoint, _) = SecurityDeleteUserRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_delete_user has no request body`` () =
    let req = securityDeleteUserRequest {
        username "test-value"
    }
    let (_, postData) = SecurityDeleteUserRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_disable_user uses POST method`` () =
    let req = securityDisableUserRequest {
        username "test-value"
    }
    let (endpoint, _) = SecurityDisableUserRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_disable_user has no request body`` () =
    let req = securityDisableUserRequest {
        username "test-value"
    }
    let (_, postData) = SecurityDisableUserRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_disable_user_profile uses POST method`` () =
    let req = securityDisableUserProfileRequest {
        uid "test-value"
    }
    let (endpoint, _) = SecurityDisableUserProfileRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_disable_user_profile has no request body`` () =
    let req = securityDisableUserProfileRequest {
        uid "test-value"
    }
    let (_, postData) = SecurityDisableUserProfileRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_enable_user uses POST method`` () =
    let req = securityEnableUserRequest {
        username "test-value"
    }
    let (endpoint, _) = SecurityEnableUserRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_enable_user has no request body`` () =
    let req = securityEnableUserRequest {
        username "test-value"
    }
    let (_, postData) = SecurityEnableUserRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_enable_user_profile uses POST method`` () =
    let req = securityEnableUserProfileRequest {
        uid "test-value"
    }
    let (endpoint, _) = SecurityEnableUserProfileRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_enable_user_profile has no request body`` () =
    let req = securityEnableUserProfileRequest {
        uid "test-value"
    }
    let (_, postData) = SecurityEnableUserProfileRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_enroll_kibana uses GET method`` () =
    let req = Unchecked.defaultof<SecurityEnrollKibanaRequest>
    let (endpoint, _) = SecurityEnrollKibanaRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_enroll_kibana has no request body`` () =
    let req = Unchecked.defaultof<SecurityEnrollKibanaRequest>
    let (_, postData) = SecurityEnrollKibanaRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_enroll_node uses GET method`` () =
    let req = Unchecked.defaultof<SecurityEnrollNodeRequest>
    let (endpoint, _) = SecurityEnrollNodeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_enroll_node has no request body`` () =
    let req = Unchecked.defaultof<SecurityEnrollNodeRequest>
    let (_, postData) = SecurityEnrollNodeRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_api_key uses GET method`` () =
    let req = Unchecked.defaultof<SecurityGetApiKeyRequest>
    let (endpoint, _) = SecurityGetApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_api_key has no request body`` () =
    let req = Unchecked.defaultof<SecurityGetApiKeyRequest>
    let (_, postData) = SecurityGetApiKeyRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_builtin_privileges uses GET method`` () =
    let req = Unchecked.defaultof<SecurityGetBuiltinPrivilegesRequest>
    let (endpoint, _) = SecurityGetBuiltinPrivilegesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_builtin_privileges has no request body`` () =
    let req = Unchecked.defaultof<SecurityGetBuiltinPrivilegesRequest>
    let (_, postData) = SecurityGetBuiltinPrivilegesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_service_accounts uses GET method`` () =
    let req = securityGetServiceAccountsRequest {
        namespace' "test-value"
        service "test-value"
    }
    let (endpoint, _) = SecurityGetServiceAccountsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_service_accounts has no request body`` () =
    let req = securityGetServiceAccountsRequest {
        namespace' "test-value"
        service "test-value"
    }
    let (_, postData) = SecurityGetServiceAccountsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_service_credentials uses GET method`` () =
    let req = securityGetServiceCredentialsRequest {
        namespace' "test-value"
        service "test-value"
    }
    let (endpoint, _) = SecurityGetServiceCredentialsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_service_credentials has no request body`` () =
    let req = securityGetServiceCredentialsRequest {
        namespace' "test-value"
        service "test-value"
    }
    let (_, postData) = SecurityGetServiceCredentialsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_settings uses GET method`` () =
    let req = Unchecked.defaultof<SecurityGetSettingsRequest>
    let (endpoint, _) = SecurityGetSettingsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_settings has no request body`` () =
    let req = Unchecked.defaultof<SecurityGetSettingsRequest>
    let (_, postData) = SecurityGetSettingsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_stats uses GET method`` () =
    let req = Unchecked.defaultof<SecurityGetStatsRequest>
    let (endpoint, _) = SecurityGetStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_stats has no request body`` () =
    let req = Unchecked.defaultof<SecurityGetStatsRequest>
    let (_, postData) = SecurityGetStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_get_token uses POST method`` () =
    let req = Unchecked.defaultof<SecurityGetTokenRequest>
    let (endpoint, _) = SecurityGetTokenRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_get_token has request body`` () =
    let req = Unchecked.defaultof<SecurityGetTokenRequest>
    let (_, postData) = SecurityGetTokenRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_get_user_privileges uses GET method`` () =
    let req = Unchecked.defaultof<SecurityGetUserPrivilegesRequest>
    let (endpoint, _) = SecurityGetUserPrivilegesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_get_user_privileges has no request body`` () =
    let req = Unchecked.defaultof<SecurityGetUserPrivilegesRequest>
    let (_, postData) = SecurityGetUserPrivilegesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_grant_api_key uses POST method`` () =
    let req = Unchecked.defaultof<SecurityGrantApiKeyRequest>
    let (endpoint, _) = SecurityGrantApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_grant_api_key has request body`` () =
    let req = Unchecked.defaultof<SecurityGrantApiKeyRequest>
    let (_, postData) = SecurityGrantApiKeyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_has_privileges uses POST method`` () =
    let req = securityHasPrivilegesRequest {
        user "test-value"
    }
    let (endpoint, _) = SecurityHasPrivilegesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_has_privileges has request body`` () =
    let req = securityHasPrivilegesRequest {
        user "test-value"
    }
    let (_, postData) = SecurityHasPrivilegesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_has_privileges_user_profile uses POST method`` () =
    let req = Unchecked.defaultof<SecurityHasPrivilegesUserProfileRequest>
    let (endpoint, _) = SecurityHasPrivilegesUserProfileRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_has_privileges_user_profile has request body`` () =
    let req = Unchecked.defaultof<SecurityHasPrivilegesUserProfileRequest>
    let (_, postData) = SecurityHasPrivilegesUserProfileRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_invalidate_api_key uses DELETE method`` () =
    let req = Unchecked.defaultof<SecurityInvalidateApiKeyRequest>
    let (endpoint, _) = SecurityInvalidateApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_invalidate_api_key has request body`` () =
    let req = Unchecked.defaultof<SecurityInvalidateApiKeyRequest>
    let (_, postData) = SecurityInvalidateApiKeyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_invalidate_token uses DELETE method`` () =
    let req = Unchecked.defaultof<SecurityInvalidateTokenRequest>
    let (endpoint, _) = SecurityInvalidateTokenRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``security_invalidate_token has request body`` () =
    let req = Unchecked.defaultof<SecurityInvalidateTokenRequest>
    let (_, postData) = SecurityInvalidateTokenRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_oidc_authenticate uses POST method`` () =
    let req = Unchecked.defaultof<SecurityOidcAuthenticateRequest>
    let (endpoint, _) = SecurityOidcAuthenticateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_oidc_authenticate has request body`` () =
    let req = Unchecked.defaultof<SecurityOidcAuthenticateRequest>
    let (_, postData) = SecurityOidcAuthenticateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_oidc_logout uses POST method`` () =
    let req = Unchecked.defaultof<SecurityOidcLogoutRequest>
    let (endpoint, _) = SecurityOidcLogoutRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_oidc_logout has request body`` () =
    let req = Unchecked.defaultof<SecurityOidcLogoutRequest>
    let (_, postData) = SecurityOidcLogoutRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_oidc_prepare_authentication uses POST method`` () =
    let req = Unchecked.defaultof<SecurityOidcPrepareAuthenticationRequest>
    let (endpoint, _) = SecurityOidcPrepareAuthenticationRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_oidc_prepare_authentication has request body`` () =
    let req = Unchecked.defaultof<SecurityOidcPrepareAuthenticationRequest>
    let (_, postData) = SecurityOidcPrepareAuthenticationRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_put_privileges uses POST method`` () =
    let req = Unchecked.defaultof<SecurityPutPrivilegesRequest>
    let (endpoint, _) = SecurityPutPrivilegesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_put_privileges has request body`` () =
    let req = Unchecked.defaultof<SecurityPutPrivilegesRequest>
    let (_, postData) = SecurityPutPrivilegesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_put_role uses POST method`` () =
    let req = securityPutRoleRequest {
        name "test-value"
    }
    let (endpoint, _) = SecurityPutRoleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_put_role has request body`` () =
    let req = securityPutRoleRequest {
        name "test-value"
    }
    let (_, postData) = SecurityPutRoleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_put_role_mapping uses POST method`` () =
    let req = securityPutRoleMappingRequest {
        name "test-value"
    }
    let (endpoint, _) = SecurityPutRoleMappingRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_put_role_mapping has request body`` () =
    let req = securityPutRoleMappingRequest {
        name "test-value"
    }
    let (_, postData) = SecurityPutRoleMappingRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_query_api_keys uses POST method`` () =
    let req = Unchecked.defaultof<SecurityQueryApiKeysRequest>
    let (endpoint, _) = SecurityQueryApiKeysRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_query_api_keys has request body`` () =
    let req = Unchecked.defaultof<SecurityQueryApiKeysRequest>
    let (_, postData) = SecurityQueryApiKeysRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_query_role uses POST method`` () =
    let req = Unchecked.defaultof<SecurityQueryRoleRequest>
    let (endpoint, _) = SecurityQueryRoleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_query_role has request body`` () =
    let req = Unchecked.defaultof<SecurityQueryRoleRequest>
    let (_, postData) = SecurityQueryRoleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_query_user uses POST method`` () =
    let req = Unchecked.defaultof<SecurityQueryUserRequest>
    let (endpoint, _) = SecurityQueryUserRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_query_user has request body`` () =
    let req = Unchecked.defaultof<SecurityQueryUserRequest>
    let (_, postData) = SecurityQueryUserRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_saml_authenticate uses POST method`` () =
    let req = Unchecked.defaultof<SecuritySamlAuthenticateRequest>
    let (endpoint, _) = SecuritySamlAuthenticateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_saml_authenticate has request body`` () =
    let req = Unchecked.defaultof<SecuritySamlAuthenticateRequest>
    let (_, postData) = SecuritySamlAuthenticateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_saml_complete_logout uses POST method`` () =
    let req = Unchecked.defaultof<SecuritySamlCompleteLogoutRequest>
    let (endpoint, _) = SecuritySamlCompleteLogoutRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_saml_complete_logout has request body`` () =
    let req = Unchecked.defaultof<SecuritySamlCompleteLogoutRequest>
    let (_, postData) = SecuritySamlCompleteLogoutRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_saml_invalidate uses POST method`` () =
    let req = Unchecked.defaultof<SecuritySamlInvalidateRequest>
    let (endpoint, _) = SecuritySamlInvalidateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_saml_invalidate has request body`` () =
    let req = Unchecked.defaultof<SecuritySamlInvalidateRequest>
    let (_, postData) = SecuritySamlInvalidateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_saml_logout uses POST method`` () =
    let req = Unchecked.defaultof<SecuritySamlLogoutRequest>
    let (endpoint, _) = SecuritySamlLogoutRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_saml_logout has request body`` () =
    let req = Unchecked.defaultof<SecuritySamlLogoutRequest>
    let (_, postData) = SecuritySamlLogoutRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_saml_prepare_authentication uses POST method`` () =
    let req = Unchecked.defaultof<SecuritySamlPrepareAuthenticationRequest>
    let (endpoint, _) = SecuritySamlPrepareAuthenticationRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_saml_prepare_authentication has request body`` () =
    let req = Unchecked.defaultof<SecuritySamlPrepareAuthenticationRequest>
    let (_, postData) = SecuritySamlPrepareAuthenticationRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_saml_service_provider_metadata uses GET method`` () =
    let req = securitySamlServiceProviderMetadataRequest {
        realmName "test-value"
    }
    let (endpoint, _) = SecuritySamlServiceProviderMetadataRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``security_saml_service_provider_metadata has no request body`` () =
    let req = securitySamlServiceProviderMetadataRequest {
        realmName "test-value"
    }
    let (_, postData) = SecuritySamlServiceProviderMetadataRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``security_suggest_user_profiles uses POST method`` () =
    let req = Unchecked.defaultof<SecuritySuggestUserProfilesRequest>
    let (endpoint, _) = SecuritySuggestUserProfilesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_suggest_user_profiles has request body`` () =
    let req = Unchecked.defaultof<SecuritySuggestUserProfilesRequest>
    let (_, postData) = SecuritySuggestUserProfilesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_update_api_key uses PUT method`` () =
    let req = securityUpdateApiKeyRequest {
        id "test-value"
    }
    let (endpoint, _) = SecurityUpdateApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``security_update_api_key has request body`` () =
    let req = securityUpdateApiKeyRequest {
        id "test-value"
    }
    let (_, postData) = SecurityUpdateApiKeyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_update_cross_cluster_api_key uses PUT method`` () =
    let req = securityUpdateCrossClusterApiKeyRequest {
        id "test-value"
    }
    let (endpoint, _) = SecurityUpdateCrossClusterApiKeyRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``security_update_cross_cluster_api_key has request body`` () =
    let req = securityUpdateCrossClusterApiKeyRequest {
        id "test-value"
    }
    let (_, postData) = SecurityUpdateCrossClusterApiKeyRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_update_settings uses PUT method`` () =
    let req = Unchecked.defaultof<SecurityUpdateSettingsRequest>
    let (endpoint, _) = SecurityUpdateSettingsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``security_update_settings has request body`` () =
    let req = Unchecked.defaultof<SecurityUpdateSettingsRequest>
    let (_, postData) = SecurityUpdateSettingsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``security_update_user_profile_data uses POST method`` () =
    let req = securityUpdateUserProfileDataRequest {
        uid "test-value"
    }
    let (endpoint, _) = SecurityUpdateUserProfileDataRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``security_update_user_profile_data has request body`` () =
    let req = securityUpdateUserProfileDataRequest {
        uid "test-value"
    }
    let (_, postData) = SecurityUpdateUserProfileDataRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``shutdown_delete_node uses DELETE method`` () =
    let req = shutdownDeleteNodeRequest {
        nodeId "test-value"
    }
    let (endpoint, _) = ShutdownDeleteNodeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``shutdown_delete_node has no request body`` () =
    let req = shutdownDeleteNodeRequest {
        nodeId "test-value"
    }
    let (_, postData) = ShutdownDeleteNodeRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``shutdown_put_node uses PUT method`` () =
    let req = shutdownPutNodeRequest {
        nodeId "test-value"
    }
    let (endpoint, _) = ShutdownPutNodeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``shutdown_put_node has request body`` () =
    let req = shutdownPutNodeRequest {
        nodeId "test-value"
    }
    let (_, postData) = ShutdownPutNodeRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``simulate_ingest uses POST method`` () =
    let req = simulateIngestRequest {
        index "test-value"
    }
    let (endpoint, _) = SimulateIngestRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``simulate_ingest has request body`` () =
    let req = simulateIngestRequest {
        index "test-value"
    }
    let (_, postData) = SimulateIngestRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``slm_delete_lifecycle uses DELETE method`` () =
    let req = slmDeleteLifecycleRequest {
        policyId "test-value"
    }
    let (endpoint, _) = SlmDeleteLifecycleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``slm_delete_lifecycle has no request body`` () =
    let req = slmDeleteLifecycleRequest {
        policyId "test-value"
    }
    let (_, postData) = SlmDeleteLifecycleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``slm_execute_lifecycle uses PUT method`` () =
    let req = slmExecuteLifecycleRequest {
        policyId "test-value"
    }
    let (endpoint, _) = SlmExecuteLifecycleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``slm_execute_lifecycle has no request body`` () =
    let req = slmExecuteLifecycleRequest {
        policyId "test-value"
    }
    let (_, postData) = SlmExecuteLifecycleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``slm_execute_retention uses POST method`` () =
    let req = Unchecked.defaultof<SlmExecuteRetentionRequest>
    let (endpoint, _) = SlmExecuteRetentionRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``slm_execute_retention has no request body`` () =
    let req = Unchecked.defaultof<SlmExecuteRetentionRequest>
    let (_, postData) = SlmExecuteRetentionRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``slm_get_stats uses GET method`` () =
    let req = Unchecked.defaultof<SlmGetStatsRequest>
    let (endpoint, _) = SlmGetStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``slm_get_stats has no request body`` () =
    let req = Unchecked.defaultof<SlmGetStatsRequest>
    let (_, postData) = SlmGetStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``slm_get_status uses GET method`` () =
    let req = Unchecked.defaultof<SlmGetStatusRequest>
    let (endpoint, _) = SlmGetStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``slm_get_status has no request body`` () =
    let req = Unchecked.defaultof<SlmGetStatusRequest>
    let (_, postData) = SlmGetStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``slm_put_lifecycle uses PUT method`` () =
    let req = slmPutLifecycleRequest {
        policyId "test-value"
    }
    let (endpoint, _) = SlmPutLifecycleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``slm_put_lifecycle has request body`` () =
    let req = slmPutLifecycleRequest {
        policyId "test-value"
    }
    let (_, postData) = SlmPutLifecycleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``slm_start uses POST method`` () =
    let req = Unchecked.defaultof<SlmStartRequest>
    let (endpoint, _) = SlmStartRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``slm_start has no request body`` () =
    let req = Unchecked.defaultof<SlmStartRequest>
    let (_, postData) = SlmStartRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``slm_stop uses POST method`` () =
    let req = Unchecked.defaultof<SlmStopRequest>
    let (endpoint, _) = SlmStopRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``slm_stop has no request body`` () =
    let req = Unchecked.defaultof<SlmStopRequest>
    let (_, postData) = SlmStopRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``snapshot_cleanup_repository uses POST method`` () =
    let req = snapshotCleanupRepositoryRequest {
        repository "test-value"
    }
    let (endpoint, _) = SnapshotCleanupRepositoryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``snapshot_cleanup_repository has no request body`` () =
    let req = snapshotCleanupRepositoryRequest {
        repository "test-value"
    }
    let (_, postData) = SnapshotCleanupRepositoryRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``snapshot_clone uses PUT method`` () =
    let req = snapshotCloneRequest {
        repository "test-value"
        snapshot "test-value"
        targetSnapshot "test-value"
    }
    let (endpoint, _) = SnapshotCloneRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``snapshot_clone has request body`` () =
    let req = snapshotCloneRequest {
        repository "test-value"
        snapshot "test-value"
        targetSnapshot "test-value"
    }
    let (_, postData) = SnapshotCloneRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``snapshot_create uses POST method`` () =
    let req = snapshotCreateRequest {
        repository "test-value"
        snapshot "test-value"
    }
    let (endpoint, _) = SnapshotCreateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``snapshot_create has request body`` () =
    let req = snapshotCreateRequest {
        repository "test-value"
        snapshot "test-value"
    }
    let (_, postData) = SnapshotCreateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``snapshot_create_repository uses POST method`` () =
    let req = snapshotCreateRepositoryRequest {
        repository "test-value"
    }
    let (endpoint, _) = SnapshotCreateRepositoryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``snapshot_create_repository has request body`` () =
    let req = snapshotCreateRepositoryRequest {
        repository "test-value"
    }
    let (_, postData) = SnapshotCreateRepositoryRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``snapshot_repository_analyze uses POST method`` () =
    let req = snapshotRepositoryAnalyzeRequest {
        repository "test-value"
    }
    let (endpoint, _) = SnapshotRepositoryAnalyzeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``snapshot_repository_analyze has no request body`` () =
    let req = snapshotRepositoryAnalyzeRequest {
        repository "test-value"
    }
    let (_, postData) = SnapshotRepositoryAnalyzeRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``snapshot_restore uses POST method`` () =
    let req = snapshotRestoreRequest {
        repository "test-value"
        snapshot "test-value"
    }
    let (endpoint, _) = SnapshotRestoreRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``snapshot_restore has request body`` () =
    let req = snapshotRestoreRequest {
        repository "test-value"
        snapshot "test-value"
    }
    let (_, postData) = SnapshotRestoreRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``snapshot_verify_repository uses POST method`` () =
    let req = snapshotVerifyRepositoryRequest {
        repository "test-value"
    }
    let (endpoint, _) = SnapshotVerifyRepositoryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``snapshot_verify_repository has no request body`` () =
    let req = snapshotVerifyRepositoryRequest {
        repository "test-value"
    }
    let (_, postData) = SnapshotVerifyRepositoryRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``sql_clear_cursor uses POST method`` () =
    let req = Unchecked.defaultof<SqlClearCursorRequest>
    let (endpoint, _) = SqlClearCursorRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``sql_clear_cursor has request body`` () =
    let req = Unchecked.defaultof<SqlClearCursorRequest>
    let (_, postData) = SqlClearCursorRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``sql_delete_async uses DELETE method`` () =
    let req = sqlDeleteAsyncRequest {
        id "test-value"
    }
    let (endpoint, _) = SqlDeleteAsyncRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``sql_delete_async has no request body`` () =
    let req = sqlDeleteAsyncRequest {
        id "test-value"
    }
    let (_, postData) = SqlDeleteAsyncRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``sql_get_async uses GET method`` () =
    let req = sqlGetAsyncRequest {
        id "test-value"
    }
    let (endpoint, _) = SqlGetAsyncRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``sql_get_async has no request body`` () =
    let req = sqlGetAsyncRequest {
        id "test-value"
    }
    let (_, postData) = SqlGetAsyncRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``sql_get_async_status uses GET method`` () =
    let req = sqlGetAsyncStatusRequest {
        id "test-value"
    }
    let (endpoint, _) = SqlGetAsyncStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``sql_get_async_status has no request body`` () =
    let req = sqlGetAsyncStatusRequest {
        id "test-value"
    }
    let (_, postData) = SqlGetAsyncStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``sql_query uses POST method`` () =
    let req = Unchecked.defaultof<SqlQueryRequest>
    let (endpoint, _) = SqlQueryRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``sql_query has request body`` () =
    let req = Unchecked.defaultof<SqlQueryRequest>
    let (_, postData) = SqlQueryRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``sql_translate uses POST method`` () =
    let req = Unchecked.defaultof<SqlTranslateRequest>
    let (endpoint, _) = SqlTranslateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``sql_translate has request body`` () =
    let req = Unchecked.defaultof<SqlTranslateRequest>
    let (_, postData) = SqlTranslateRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``ssl_certificates uses GET method`` () =
    let req = Unchecked.defaultof<SslCertificatesRequest>
    let (endpoint, _) = SslCertificatesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``ssl_certificates has no request body`` () =
    let req = Unchecked.defaultof<SslCertificatesRequest>
    let (_, postData) = SslCertificatesRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``streams_status uses GET method`` () =
    let req = Unchecked.defaultof<StreamsStatusRequest>
    let (endpoint, _) = StreamsStatusRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``streams_status has no request body`` () =
    let req = Unchecked.defaultof<StreamsStatusRequest>
    let (_, postData) = StreamsStatusRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``synonyms_delete_synonym uses DELETE method`` () =
    let req = synonymsDeleteSynonymRequest {
        id "test-value"
    }
    let (endpoint, _) = SynonymsDeleteSynonymRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``synonyms_delete_synonym has no request body`` () =
    let req = synonymsDeleteSynonymRequest {
        id "test-value"
    }
    let (_, postData) = SynonymsDeleteSynonymRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``synonyms_delete_synonym_rule uses DELETE method`` () =
    let req = synonymsDeleteSynonymRuleRequest {
        setId "test-value"
        ruleId "test-value"
    }
    let (endpoint, _) = SynonymsDeleteSynonymRuleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``synonyms_delete_synonym_rule has no request body`` () =
    let req = synonymsDeleteSynonymRuleRequest {
        setId "test-value"
        ruleId "test-value"
    }
    let (_, postData) = SynonymsDeleteSynonymRuleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``synonyms_get_synonym uses GET method`` () =
    let req = synonymsGetSynonymRequest {
        id "test-value"
    }
    let (endpoint, _) = SynonymsGetSynonymRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``synonyms_get_synonym has no request body`` () =
    let req = synonymsGetSynonymRequest {
        id "test-value"
    }
    let (_, postData) = SynonymsGetSynonymRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``synonyms_get_synonym_rule uses GET method`` () =
    let req = synonymsGetSynonymRuleRequest {
        setId "test-value"
        ruleId "test-value"
    }
    let (endpoint, _) = SynonymsGetSynonymRuleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``synonyms_get_synonym_rule has no request body`` () =
    let req = synonymsGetSynonymRuleRequest {
        setId "test-value"
        ruleId "test-value"
    }
    let (_, postData) = SynonymsGetSynonymRuleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``synonyms_get_synonyms_sets uses GET method`` () =
    let req = Unchecked.defaultof<SynonymsGetSynonymsSetsRequest>
    let (endpoint, _) = SynonymsGetSynonymsSetsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``synonyms_get_synonyms_sets has no request body`` () =
    let req = Unchecked.defaultof<SynonymsGetSynonymsSetsRequest>
    let (_, postData) = SynonymsGetSynonymsSetsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``synonyms_put_synonym uses PUT method`` () =
    let req = synonymsPutSynonymRequest {
        id "test-value"
    }
    let (endpoint, _) = SynonymsPutSynonymRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``synonyms_put_synonym has request body`` () =
    let req = synonymsPutSynonymRequest {
        id "test-value"
    }
    let (_, postData) = SynonymsPutSynonymRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``synonyms_put_synonym_rule uses PUT method`` () =
    let req = synonymsPutSynonymRuleRequest {
        setId "test-value"
        ruleId "test-value"
    }
    let (endpoint, _) = SynonymsPutSynonymRuleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``synonyms_put_synonym_rule has request body`` () =
    let req = synonymsPutSynonymRuleRequest {
        setId "test-value"
        ruleId "test-value"
    }
    let (_, postData) = SynonymsPutSynonymRuleRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``tasks_cancel uses POST method`` () =
    let req = tasksCancelRequest {
        taskId "test-value"
    }
    let (endpoint, _) = TasksCancelRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``tasks_cancel has no request body`` () =
    let req = tasksCancelRequest {
        taskId "test-value"
    }
    let (_, postData) = TasksCancelRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``tasks_get uses GET method`` () =
    let req = tasksGetRequest {
        taskId "test-value"
    }
    let (endpoint, _) = TasksGetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``tasks_get has no request body`` () =
    let req = tasksGetRequest {
        taskId "test-value"
    }
    let (_, postData) = TasksGetRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``tasks_list uses GET method`` () =
    let req = Unchecked.defaultof<TasksListRequest>
    let (endpoint, _) = TasksListRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``tasks_list has no request body`` () =
    let req = Unchecked.defaultof<TasksListRequest>
    let (_, postData) = TasksListRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``text_structure_find_field_structure uses GET method`` () =
    let req = Unchecked.defaultof<TextStructureFindFieldStructureRequest>
    let (endpoint, _) = TextStructureFindFieldStructureRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``text_structure_find_field_structure has no request body`` () =
    let req = Unchecked.defaultof<TextStructureFindFieldStructureRequest>
    let (_, postData) = TextStructureFindFieldStructureRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``text_structure_find_message_structure uses POST method`` () =
    let req = Unchecked.defaultof<TextStructureFindMessageStructureRequest>
    let (endpoint, _) = TextStructureFindMessageStructureRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``text_structure_find_message_structure has request body`` () =
    let req = Unchecked.defaultof<TextStructureFindMessageStructureRequest>
    let (_, postData) = TextStructureFindMessageStructureRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``text_structure_test_grok_pattern uses POST method`` () =
    let req = Unchecked.defaultof<TextStructureTestGrokPatternRequest>
    let (endpoint, _) = TextStructureTestGrokPatternRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``text_structure_test_grok_pattern has request body`` () =
    let req = Unchecked.defaultof<TextStructureTestGrokPatternRequest>
    let (_, postData) = TextStructureTestGrokPatternRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``transform_delete_transform uses DELETE method`` () =
    let req = transformDeleteTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformDeleteTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``transform_delete_transform has no request body`` () =
    let req = transformDeleteTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformDeleteTransformRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_get_node_stats uses GET method`` () =
    let req = Unchecked.defaultof<TransformGetNodeStatsRequest>
    let (endpoint, _) = TransformGetNodeStatsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``transform_get_node_stats has no request body`` () =
    let req = Unchecked.defaultof<TransformGetNodeStatsRequest>
    let (_, postData) = TransformGetNodeStatsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_preview_transform uses POST method`` () =
    let req = transformPreviewTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformPreviewTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_preview_transform has request body`` () =
    let req = transformPreviewTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformPreviewTransformRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``transform_put_transform uses PUT method`` () =
    let req = transformPutTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformPutTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``transform_put_transform has request body`` () =
    let req = transformPutTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformPutTransformRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``transform_reset_transform uses POST method`` () =
    let req = transformResetTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformResetTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_reset_transform has no request body`` () =
    let req = transformResetTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformResetTransformRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_schedule_now_transform uses POST method`` () =
    let req = transformScheduleNowTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformScheduleNowTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_schedule_now_transform has no request body`` () =
    let req = transformScheduleNowTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformScheduleNowTransformRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_set_upgrade_mode uses POST method`` () =
    let req = Unchecked.defaultof<TransformSetUpgradeModeRequest>
    let (endpoint, _) = TransformSetUpgradeModeRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_set_upgrade_mode has no request body`` () =
    let req = Unchecked.defaultof<TransformSetUpgradeModeRequest>
    let (_, postData) = TransformSetUpgradeModeRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_start_transform uses POST method`` () =
    let req = transformStartTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformStartTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_start_transform has no request body`` () =
    let req = transformStartTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformStartTransformRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_stop_transform uses POST method`` () =
    let req = transformStopTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformStopTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_stop_transform has no request body`` () =
    let req = transformStopTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformStopTransformRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``transform_update_transform uses POST method`` () =
    let req = transformUpdateTransformRequest {
        transformId "test-value"
    }
    let (endpoint, _) = TransformUpdateTransformRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_update_transform has request body`` () =
    let req = transformUpdateTransformRequest {
        transformId "test-value"
    }
    let (_, postData) = TransformUpdateTransformRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``transform_upgrade_transforms uses POST method`` () =
    let req = Unchecked.defaultof<TransformUpgradeTransformsRequest>
    let (endpoint, _) = TransformUpgradeTransformsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``transform_upgrade_transforms has no request body`` () =
    let req = Unchecked.defaultof<TransformUpgradeTransformsRequest>
    let (_, postData) = TransformUpgradeTransformsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``update_by_query_rethrottle uses POST method`` () =
    let req = updateByQueryRethrottleRequest {
        taskId "test-value"
    }
    let (endpoint, _) = UpdateByQueryRethrottleRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``update_by_query_rethrottle has no request body`` () =
    let req = updateByQueryRethrottleRequest {
        taskId "test-value"
    }
    let (_, postData) = UpdateByQueryRethrottleRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_activate_watch uses POST method`` () =
    let req = watcherActivateWatchRequest {
        watchId "test-value"
    }
    let (endpoint, _) = WatcherActivateWatchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_activate_watch has no request body`` () =
    let req = watcherActivateWatchRequest {
        watchId "test-value"
    }
    let (_, postData) = WatcherActivateWatchRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_deactivate_watch uses POST method`` () =
    let req = watcherDeactivateWatchRequest {
        watchId "test-value"
    }
    let (endpoint, _) = WatcherDeactivateWatchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_deactivate_watch has no request body`` () =
    let req = watcherDeactivateWatchRequest {
        watchId "test-value"
    }
    let (_, postData) = WatcherDeactivateWatchRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_delete_watch uses DELETE method`` () =
    let req = watcherDeleteWatchRequest {
        id "test-value"
    }
    let (endpoint, _) = WatcherDeleteWatchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE

[<Fact>]
let ``watcher_delete_watch has no request body`` () =
    let req = watcherDeleteWatchRequest {
        id "test-value"
    }
    let (_, postData) = WatcherDeleteWatchRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_execute_watch uses POST method`` () =
    let req = watcherExecuteWatchRequest {
        id "test-value"
    }
    let (endpoint, _) = WatcherExecuteWatchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_execute_watch has request body`` () =
    let req = watcherExecuteWatchRequest {
        id "test-value"
    }
    let (_, postData) = WatcherExecuteWatchRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``watcher_get_settings uses GET method`` () =
    let req = Unchecked.defaultof<WatcherGetSettingsRequest>
    let (endpoint, _) = WatcherGetSettingsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``watcher_get_settings has no request body`` () =
    let req = Unchecked.defaultof<WatcherGetSettingsRequest>
    let (_, postData) = WatcherGetSettingsRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_get_watch uses GET method`` () =
    let req = watcherGetWatchRequest {
        id "test-value"
    }
    let (endpoint, _) = WatcherGetWatchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``watcher_get_watch has no request body`` () =
    let req = watcherGetWatchRequest {
        id "test-value"
    }
    let (_, postData) = WatcherGetWatchRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_put_watch uses POST method`` () =
    let req = watcherPutWatchRequest {
        id "test-value"
    }
    let (endpoint, _) = WatcherPutWatchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_put_watch has request body`` () =
    let req = watcherPutWatchRequest {
        id "test-value"
    }
    let (_, postData) = WatcherPutWatchRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``watcher_query_watches uses POST method`` () =
    let req = Unchecked.defaultof<WatcherQueryWatchesRequest>
    let (endpoint, _) = WatcherQueryWatchesRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_query_watches has request body`` () =
    let req = Unchecked.defaultof<WatcherQueryWatchesRequest>
    let (_, postData) = WatcherQueryWatchesRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``watcher_start uses POST method`` () =
    let req = Unchecked.defaultof<WatcherStartRequest>
    let (endpoint, _) = WatcherStartRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_start has no request body`` () =
    let req = Unchecked.defaultof<WatcherStartRequest>
    let (_, postData) = WatcherStartRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_stop uses POST method`` () =
    let req = Unchecked.defaultof<WatcherStopRequest>
    let (endpoint, _) = WatcherStopRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST

[<Fact>]
let ``watcher_stop has no request body`` () =
    let req = Unchecked.defaultof<WatcherStopRequest>
    let (_, postData) = WatcherStopRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``watcher_update_settings uses PUT method`` () =
    let req = Unchecked.defaultof<WatcherUpdateSettingsRequest>
    let (endpoint, _) = WatcherUpdateSettingsRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT

[<Fact>]
let ``watcher_update_settings has request body`` () =
    let req = Unchecked.defaultof<WatcherUpdateSettingsRequest>
    let (_, postData) = WatcherUpdateSettingsRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``xpack_info uses GET method`` () =
    let req = Unchecked.defaultof<XpackInfoRequest>
    let (endpoint, _) = XpackInfoRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``xpack_info has no request body`` () =
    let req = Unchecked.defaultof<XpackInfoRequest>
    let (_, postData) = XpackInfoRequest.ToEndpoint(req)
    postData.IsNone |> should be True

[<Fact>]
let ``xpack_usage uses GET method`` () =
    let req = Unchecked.defaultof<XpackUsageRequest>
    let (endpoint, _) = XpackUsageRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET

[<Fact>]
let ``xpack_usage has no request body`` () =
    let req = Unchecked.defaultof<XpackUsageRequest>
    let (_, postData) = XpackUsageRequest.ToEndpoint(req)
    postData.IsNone |> should be True

