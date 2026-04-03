// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open Fes
open Fes.Generated
open Fes.Generated.Operations

module Endpoints =


    module AsyncSearch =

        /// Delete an async search.
        let delete (id: Types.Id) =
            let mutable req = Unchecked.defaultof<AsyncSearchDeleteRequest>
            req <- { req with Id = id }
            req

        /// Get async search results.
        let get (id: Types.Id) =
            let mutable req = Unchecked.defaultof<AsyncSearchGetRequest>
            req <- { req with Id = id }
            req

        /// Get the async search status.
        let status (id: Types.Id) =
            let mutable req = Unchecked.defaultof<AsyncSearchStatusRequest>
            req <- { req with Id = id }
            req

        /// Run an async search.
        let submit (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<AsyncSearchSubmitRequest>
            req <- { req with Index = index }
            req

    module Autoscaling =

        /// Delete an autoscaling policy.
        let deleteAutoscalingPolicy (name: Types.Name) =
            let mutable req = Unchecked.defaultof<AutoscalingDeleteAutoscalingPolicyRequest>
            req <- { req with Name = name }
            req

        /// Get the autoscaling capacity.
        let getAutoscalingCapacity () =
            Unchecked.defaultof<AutoscalingGetAutoscalingCapacityRequest>

        /// Get an autoscaling policy.
        let getAutoscalingPolicy (name: Types.Name) =
            let mutable req = Unchecked.defaultof<AutoscalingGetAutoscalingPolicyRequest>
            req <- { req with Name = name }
            req

        /// Create or update an autoscaling policy.
        let putAutoscalingPolicy (name: Types.Name) =
            let mutable req = Unchecked.defaultof<AutoscalingPutAutoscalingPolicyRequest>
            req <- { req with Name = name }
            req

    /// Checks if the specified combination of method, API, parameters, and arbitrary capabilities are supported.
    let capabilities  =
        let mutable req = Unchecked.defaultof<CapabilitiesRequest>
        req

    /// Clear a scrolling search.
    let clearScroll (scrollId: Types.ScrollIds) =
        let mutable req = Unchecked.defaultof<ClearScrollRequest>
        req <- { req with ScrollId = scrollId }
        req

    /// Close a point in time.
    let closePointInTime  =
        let mutable req = Unchecked.defaultof<ClosePointInTimeRequest>
        req

    /// Count search results.
    let count (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<CountRequest>
        req <- { req with Index = index }
        req

    /// Delete a document.
    let delete (id: Types.Id) (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<DeleteRequest>
        req <- { req with Id = id }
        req <- { req with Index = index }
        req

    /// Delete documents.
    let deleteByQuery (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<DeleteByQueryRequest>
        req <- { req with Index = index }
        req

    /// Throttle a delete by query operation.
    let deleteByQueryRethrottle (taskId: Types.TaskId) =
        let mutable req = Unchecked.defaultof<DeleteByQueryRethrottleRequest>
        req <- { req with TaskId = taskId }
        req

    /// Delete a script or search template.
    let deleteScript (id: Types.Id) =
        let mutable req = Unchecked.defaultof<DeleteScriptRequest>
        req <- { req with Id = id }
        req

    /// Check a document.
    let exists (id: Types.Id) (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<ExistsRequest>
        req <- { req with Id = id }
        req <- { req with Index = index }
        req

    /// Check for a document source.
    let existsSource (id: Types.Id) (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<ExistsSourceRequest>
        req <- { req with Id = id }
        req <- { req with Index = index }
        req

    /// Explain a document match result.
    let explain (id: Types.Id) (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<ExplainRequest>
        req <- { req with Id = id }
        req <- { req with Index = index }
        req

    /// Get the field capabilities.
    let fieldCaps (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<FieldCapsRequest>
        req <- { req with Index = index }
        req

    /// Get a document by its ID.
    let get (id: Types.Id) (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<GetRequest>
        req <- { req with Id = id }
        req <- { req with Index = index }
        req

    /// Get a script or search template.
    let getScript (id: Types.Id) =
        let mutable req = Unchecked.defaultof<GetScriptRequest>
        req <- { req with Id = id }
        req

    /// Get script contexts.
    let getScriptContext  : GetScriptContextRequest =
        Unchecked.defaultof<GetScriptContextRequest>

    /// Get script languages.
    let getScriptLanguages  : GetScriptLanguagesRequest =
        Unchecked.defaultof<GetScriptLanguagesRequest>

    /// Get a document's source.
    let getSource (id: Types.Id) (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<GetSourceRequest>
        req <- { req with Id = id }
        req <- { req with Index = index }
        req

    /// Get the cluster health.
    let healthReport (feature: System.Text.Json.JsonElement) =
        let mutable req = Unchecked.defaultof<HealthReportRequest>
        req <- { req with Feature = feature }
        req

    /// Get cluster info.
    let info  : InfoRequest =
        Unchecked.defaultof<InfoRequest>

    /// Run a knn search.
    let knnSearch (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<KnnSearchRequest>
        req <- { req with Index = index }
        req

    /// Get multiple documents.
    let mget (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<MgetRequest>
        req <- { req with Index = index }
        req

    /// Run multiple searches.
    let msearch (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<MsearchRequest>
        req <- { req with Index = index }
        req

    /// Run multiple templated searches.
    let msearchTemplate (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<MsearchTemplateRequest>
        req <- { req with Index = index }
        req

    /// Get multiple term vectors.
    let mtermvectors (index: Types.IndexName) =
        let mutable req = Unchecked.defaultof<MtermvectorsRequest>
        req <- { req with Index = index }
        req

    /// Open a point in time.
    let openPointInTime (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<OpenPointInTimeRequest>
        req <- { req with Index = index }
        req

    /// Ping the cluster.
    let ping  : PingRequest =
        Unchecked.defaultof<PingRequest>

    /// Create or update a script or search template.
    let putScript (id: Types.Id) (context: Types.Name) =
        let mutable req = Unchecked.defaultof<PutScriptRequest>
        req <- { req with Id = id }
        req <- { req with Context = context }
        req

    /// Evaluate ranked search results.
    let rankEval (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<RankEvalRequest>
        req <- { req with Index = index }
        req

    /// Reindex documents.
    let reindex  =
        let mutable req = Unchecked.defaultof<ReindexRequest>
        req

    /// Throttle a reindex operation.
    let reindexRethrottle (taskId: Types.Id) =
        let mutable req = Unchecked.defaultof<ReindexRethrottleRequest>
        req <- { req with TaskId = taskId }
        req

    /// Render a search template.
    let renderSearchTemplate (id: Types.Id) =
        let mutable req = Unchecked.defaultof<RenderSearchTemplateRequest>
        req <- { req with Id = id }
        req

    /// Run a script.
    let scriptsPainlessExecute  =
        let mutable req = Unchecked.defaultof<ScriptsPainlessExecuteRequest>
        req

    /// Run a scrolling search.
    let scroll (scrollId: Types.ScrollId) =
        let mutable req = Unchecked.defaultof<ScrollRequest>
        req <- { req with ScrollId = scrollId }
        req

    /// Run a search.
    let search (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<SearchRequest>
        req <- { req with Index = index }
        req

    /// Search a vector tile.
    let searchMvt (index: Types.Indices) (field: Types.Field) (zoom: Types.ZoomLevel) (x: Types.Coordinate) (y: Types.Coordinate) =
        let mutable req = Unchecked.defaultof<SearchMvtRequest>
        req <- { req with Index = index }
        req <- { req with Field = field }
        req <- { req with Zoom = zoom }
        req <- { req with X = x }
        req <- { req with Y = y }
        req

    /// Get the search shards.
    let searchShards (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<SearchShardsRequest>
        req <- { req with Index = index }
        req

    /// Run a search with a search template.
    let searchTemplate (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<SearchTemplateRequest>
        req <- { req with Index = index }
        req

    /// Get terms in an index.
    let termsEnum (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<TermsEnumRequest>
        req <- { req with Index = index }
        req

    /// Update documents.
    let updateByQuery (index: Types.Indices) =
        let mutable req = Unchecked.defaultof<UpdateByQueryRequest>
        req <- { req with Index = index }
        req

    /// Throttle an update by query operation.
    let updateByQueryRethrottle (taskId: Types.Id) =
        let mutable req = Unchecked.defaultof<UpdateByQueryRethrottleRequest>
        req <- { req with TaskId = taskId }
        req

    module Cat =

        /// Get aliases.
        let aliases (name: Types.Names) =
            let mutable req = Unchecked.defaultof<CatAliasesRequest>
            req <- { req with Name = name }
            req

        /// Get shard allocation information.
        let allocation (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<CatAllocationRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Get circuit breakers statistics.
        let circuitBreaker (circuitBreakerPatterns: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<CatCircuitBreakerRequest>
            req <- { req with CircuitBreakerPatterns = circuitBreakerPatterns }
            req

        /// Get component templates.
        let componentTemplates (name: string) =
            let mutable req = Unchecked.defaultof<CatComponentTemplatesRequest>
            req <- { req with Name = name }
            req

        /// Get a document count.
        let count (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CatCountRequest>
            req <- { req with Index = index }
            req

        /// Get field data cache information.
        let fielddata (fields: Types.Fields) =
            let mutable req = Unchecked.defaultof<CatFielddataRequest>
            req <- { req with Fields = fields }
            req

        /// Get the cluster health status.
        let health () =
            Unchecked.defaultof<CatHealthRequest>

        /// Get CAT help.
        let help () : CatHelpRequest =
            Unchecked.defaultof<CatHelpRequest>

        /// Get index information.
        let indices (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CatIndicesRequest>
            req <- { req with Index = index }
            req

        /// Get master node information.
        let master () =
            Unchecked.defaultof<CatMasterRequest>

        /// Get data frame analytics jobs.
        let mlDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<CatMlDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Get datafeeds.
        let mlDatafeeds (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<CatMlDatafeedsRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Get anomaly detection jobs.
        let mlJobs (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<CatMlJobsRequest>
            req <- { req with JobId = jobId }
            req

        /// Get trained models.
        let mlTrainedModels (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<CatMlTrainedModelsRequest>
            req <- { req with ModelId = modelId }
            req

        /// Get node attribute information.
        let nodeattrs () =
            Unchecked.defaultof<CatNodeattrsRequest>

        /// Get node information.
        let nodes () =
            Unchecked.defaultof<CatNodesRequest>

        /// Get pending task information.
        let pendingTasks () =
            Unchecked.defaultof<CatPendingTasksRequest>

        /// Get plugin information.
        let plugins () =
            Unchecked.defaultof<CatPluginsRequest>

        /// Get shard recovery information.
        let recovery (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CatRecoveryRequest>
            req <- { req with Index = index }
            req

        /// Get snapshot repository information.
        let repositories () =
            Unchecked.defaultof<CatRepositoriesRequest>

        /// Get segment information.
        let segments (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CatSegmentsRequest>
            req <- { req with Index = index }
            req

        /// Get shard information.
        let shards (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CatShardsRequest>
            req <- { req with Index = index }
            req

        /// Get snapshot information.
        let snapshots (repository: Types.Names) =
            let mutable req = Unchecked.defaultof<CatSnapshotsRequest>
            req <- { req with Repository = repository }
            req

        /// Get task information.
        let tasks () =
            Unchecked.defaultof<CatTasksRequest>

        /// Get index template information.
        let templates (name: Types.Name) =
            let mutable req = Unchecked.defaultof<CatTemplatesRequest>
            req <- { req with Name = name }
            req

        /// Get thread pool statistics.
        let threadPool (threadPoolPatterns: Types.Names) =
            let mutable req = Unchecked.defaultof<CatThreadPoolRequest>
            req <- { req with ThreadPoolPatterns = threadPoolPatterns }
            req

        /// Get transform information.
        let transforms (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<CatTransformsRequest>
            req <- { req with TransformId = transformId }
            req

    module Ccr =

        /// Delete auto-follow patterns.
        let deleteAutoFollowPattern (name: Types.Name) =
            let mutable req = Unchecked.defaultof<CcrDeleteAutoFollowPatternRequest>
            req <- { req with Name = name }
            req

        /// Create a follower.
        let follow (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<CcrFollowRequest>
            req <- { req with Index = index }
            req

        /// Get follower information.
        let followInfo (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CcrFollowInfoRequest>
            req <- { req with Index = index }
            req

        /// Get follower stats.
        let followStats (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<CcrFollowStatsRequest>
            req <- { req with Index = index }
            req

        /// Forget a follower.
        let forgetFollower (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<CcrForgetFollowerRequest>
            req <- { req with Index = index }
            req

        /// Get auto-follow patterns.
        let getAutoFollowPattern (name: Types.Name) =
            let mutable req = Unchecked.defaultof<CcrGetAutoFollowPatternRequest>
            req <- { req with Name = name }
            req

        /// Pause an auto-follow pattern.
        let pauseAutoFollowPattern (name: Types.Name) =
            let mutable req = Unchecked.defaultof<CcrPauseAutoFollowPatternRequest>
            req <- { req with Name = name }
            req

        /// Pause a follower.
        let pauseFollow (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<CcrPauseFollowRequest>
            req <- { req with Index = index }
            req

        /// Create or update auto-follow patterns.
        let putAutoFollowPattern (name: Types.Name) =
            let mutable req = Unchecked.defaultof<CcrPutAutoFollowPatternRequest>
            req <- { req with Name = name }
            req

        /// Resume an auto-follow pattern.
        let resumeAutoFollowPattern (name: Types.Name) =
            let mutable req = Unchecked.defaultof<CcrResumeAutoFollowPatternRequest>
            req <- { req with Name = name }
            req

        /// Resume a follower.
        let resumeFollow (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<CcrResumeFollowRequest>
            req <- { req with Index = index }
            req

        /// Get cross-cluster replication stats.
        let stats () =
            Unchecked.defaultof<CcrStatsRequest>

        /// Unfollow an index.
        let unfollow (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<CcrUnfollowRequest>
            req <- { req with Index = index }
            req

    module Cluster =

        /// Explain the shard allocations.
        let allocationExplain () =
            Unchecked.defaultof<ClusterAllocationExplainRequest>

        /// Delete component templates.
        let deleteComponentTemplate (name: Types.Names) =
            let mutable req = Unchecked.defaultof<ClusterDeleteComponentTemplateRequest>
            req <- { req with Name = name }
            req

        /// Clear cluster voting config exclusions.
        let deleteVotingConfigExclusions () =
            Unchecked.defaultof<ClusterDeleteVotingConfigExclusionsRequest>

        /// Check component templates.
        let existsComponentTemplate (name: Types.Names) =
            let mutable req = Unchecked.defaultof<ClusterExistsComponentTemplateRequest>
            req <- { req with Name = name }
            req

        /// Get component templates.
        let getComponentTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<ClusterGetComponentTemplateRequest>
            req <- { req with Name = name }
            req

        /// Get cluster-wide settings.
        let getSettings () =
            Unchecked.defaultof<ClusterGetSettingsRequest>

        /// Get the cluster health status.
        let health (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<ClusterHealthRequest>
            req <- { req with Index = index }
            req

        /// Get cluster info.
        let info (target: Types.ClusterInfoTargets) =
            let mutable req = Unchecked.defaultof<ClusterInfoRequest>
            req <- { req with Target = target }
            req

        /// Get the pending cluster tasks.
        let pendingTasks () =
            Unchecked.defaultof<ClusterPendingTasksRequest>

        /// Update voting configuration exclusions.
        let postVotingConfigExclusions () =
            Unchecked.defaultof<ClusterPostVotingConfigExclusionsRequest>

        /// Create or update a component template.
        let putComponentTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<ClusterPutComponentTemplateRequest>
            req <- { req with Name = name }
            req

        /// Update the cluster settings.
        let putSettings () =
            Unchecked.defaultof<ClusterPutSettingsRequest>

        /// Get remote cluster information.
        let remoteInfo () : ClusterRemoteInfoRequest =
            Unchecked.defaultof<ClusterRemoteInfoRequest>

        /// Reroute the cluster.
        let reroute () =
            Unchecked.defaultof<ClusterRerouteRequest>

        /// Get the cluster state.
        let state (metric: Types.ClusterStateMetrics) (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<ClusterStateRequest>
            req <- { req with Metric = metric }
            req <- { req with Index = index }
            req

        /// Get cluster statistics.
        let stats (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<ClusterStatsRequest>
            req <- { req with NodeId = nodeId }
            req

    module Connector =

        /// Check in a connector.
        let checkIn (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorCheckInRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Delete a connector.
        let delete (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorDeleteRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Get a connector.
        let get (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorGetRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector last sync stats.
        let lastSync (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorLastSyncRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Get all connectors.
        let list () =
            Unchecked.defaultof<ConnectorListRequest>

        /// Create a connector.
        let post () =
            Unchecked.defaultof<ConnectorPostRequest>

        /// Create or update a connector.
        let put (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorPutRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Deletes a connector secret.
        let secretDelete (id: string) =
            let mutable req = Unchecked.defaultof<ConnectorSecretDeleteRequest>
            req <- { req with Id = id }
            req

        /// Retrieves a secret stored by Connectors.
        let secretGet (id: string) =
            let mutable req = Unchecked.defaultof<ConnectorSecretGetRequest>
            req <- { req with Id = id }
            req

        /// Creates a secret for a Connector.
        let secretPost () =
            Unchecked.defaultof<ConnectorSecretPostRequest>

        /// Creates or updates a secret for a Connector.
        let secretPut (id: string) =
            let mutable req = Unchecked.defaultof<ConnectorSecretPutRequest>
            req <- { req with Id = id }
            req

        /// Cancel a connector sync job.
        let syncJobCancel (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobCancelRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Check in a connector sync job.
        let syncJobCheckIn (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobCheckInRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Claim a connector sync job.
        let syncJobClaim (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobClaimRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Delete a connector sync job.
        let syncJobDelete (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobDeleteRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Set a connector sync job error.
        let syncJobError (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobErrorRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Get a connector sync job.
        let syncJobGet (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobGetRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Get all connector sync jobs.
        let syncJobList () =
            Unchecked.defaultof<ConnectorSyncJobListRequest>

        /// Create a connector sync job.
        let syncJobPost () =
            Unchecked.defaultof<ConnectorSyncJobPostRequest>

        /// Set the connector sync job stats.
        let syncJobUpdateStats (connectorSyncJobId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorSyncJobUpdateStatsRequest>
            req <- { req with ConnectorSyncJobId = connectorSyncJobId }
            req

        /// Activate the connector draft filter.
        let updateActiveFiltering (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateActiveFilteringRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector API key ID.
        let updateApiKeyId (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateApiKeyIdRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector configuration.
        let updateConfiguration (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateConfigurationRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector error field.
        let updateError (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateErrorRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector features.
        let updateFeatures (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateFeaturesRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector filtering.
        let updateFiltering (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateFilteringRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector draft filtering validation.
        let updateFilteringValidation (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateFilteringValidationRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector index name.
        let updateIndexName (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateIndexNameRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector name and description.
        let updateName (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateNameRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector is_native flag.
        let updateNative (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateNativeRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector pipeline.
        let updatePipeline (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdatePipelineRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector scheduling.
        let updateScheduling (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateSchedulingRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector service type.
        let updateServiceType (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateServiceTypeRequest>
            req <- { req with ConnectorId = connectorId }
            req

        /// Update the connector status.
        let updateStatus (connectorId: Types.Id) =
            let mutable req = Unchecked.defaultof<ConnectorUpdateStatusRequest>
            req <- { req with ConnectorId = connectorId }
            req

    module DanglingIndices =

        /// Delete a dangling index.
        let deleteDanglingIndex (indexUuid: Types.Uuid) =
            let mutable req = Unchecked.defaultof<DanglingIndicesDeleteDanglingIndexRequest>
            req <- { req with IndexUuid = indexUuid }
            req

        /// Import a dangling index.
        let importDanglingIndex (indexUuid: Types.Uuid) =
            let mutable req = Unchecked.defaultof<DanglingIndicesImportDanglingIndexRequest>
            req <- { req with IndexUuid = indexUuid }
            req

        /// Get the dangling indices.
        let listDanglingIndices () : DanglingIndicesListDanglingIndicesRequest =
            Unchecked.defaultof<DanglingIndicesListDanglingIndicesRequest>

    module Enrich =

        /// Delete an enrich policy.
        let deletePolicy (name: Types.Name) =
            let mutable req = Unchecked.defaultof<EnrichDeletePolicyRequest>
            req <- { req with Name = name }
            req

        /// Run an enrich policy.
        let executePolicy (name: Types.Name) =
            let mutable req = Unchecked.defaultof<EnrichExecutePolicyRequest>
            req <- { req with Name = name }
            req

        /// Get an enrich policy.
        let getPolicy (name: Types.Names) =
            let mutable req = Unchecked.defaultof<EnrichGetPolicyRequest>
            req <- { req with Name = name }
            req

        /// Create an enrich policy.
        let putPolicy (name: Types.Name) =
            let mutable req = Unchecked.defaultof<EnrichPutPolicyRequest>
            req <- { req with Name = name }
            req

        /// Get enrich stats.
        let stats () =
            Unchecked.defaultof<EnrichStatsRequest>

    module Eql =

        /// Delete an async EQL search.
        let delete (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EqlDeleteRequest>
            req <- { req with Id = id }
            req

        /// Get async EQL search results.
        let get (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EqlGetRequest>
            req <- { req with Id = id }
            req

        /// Get the async EQL status.
        let getStatus (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EqlGetStatusRequest>
            req <- { req with Id = id }
            req

        /// Get EQL search results.
        let search (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<EqlSearchRequest>
            req <- { req with Index = index }
            req

    module Esql =

        /// Run an async ES|QL query.
        let asyncQuery () =
            Unchecked.defaultof<EsqlAsyncQueryRequest>

        /// Delete an async ES|QL query.
        let asyncQueryDelete (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlAsyncQueryDeleteRequest>
            req <- { req with Id = id }
            req

        /// Get async ES|QL query results.
        let asyncQueryGet (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlAsyncQueryGetRequest>
            req <- { req with Id = id }
            req

        /// Stop async ES|QL query.
        let asyncQueryStop (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlAsyncQueryStopRequest>
            req <- { req with Id = id }
            req

        /// Delete an ES|QL view.
        let deleteView (name: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlDeleteViewRequest>
            req <- { req with Name = name }
            req

        /// Get a specific running ES|QL query information.
        let getQuery (id: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlGetQueryRequest>
            req <- { req with Id = id }
            req

        /// Get an ES|QL view.
        let getView (name: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlGetViewRequest>
            req <- { req with Name = name }
            req

        /// Get running ES|QL queries information.
        let listQueries () : EsqlListQueriesRequest =
            Unchecked.defaultof<EsqlListQueriesRequest>

        /// Create or update an ES|QL view.
        let putView (name: Types.Id) =
            let mutable req = Unchecked.defaultof<EsqlPutViewRequest>
            req <- { req with Name = name }
            req

        /// Run an ES|QL query.
        let query () =
            Unchecked.defaultof<EsqlQueryRequest>

    module Features =

        /// Get the features.
        let getFeatures () =
            Unchecked.defaultof<FeaturesGetFeaturesRequest>

        /// Reset the features.
        let resetFeatures () =
            Unchecked.defaultof<FeaturesResetFeaturesRequest>

    module Fleet =

        /// Deletes a secret stored by Fleet.
        let deleteSecret (id: string) =
            let mutable req = Unchecked.defaultof<FleetDeleteSecretRequest>
            req <- { req with Id = id }
            req

        /// Retrieves a secret stored by Fleet.
        let getSecret (id: string) =
            let mutable req = Unchecked.defaultof<FleetGetSecretRequest>
            req <- { req with Id = id }
            req

        /// Get global checkpoints.
        let globalCheckpoints (index: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<FleetGlobalCheckpointsRequest>
            req <- { req with Index = index }
            req

        /// Run multiple Fleet searches.
        let msearch (index: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<FleetMsearchRequest>
            req <- { req with Index = index }
            req

        /// Creates a secret stored by Fleet.
        let postSecret () =
            Unchecked.defaultof<FleetPostSecretRequest>

        /// Run a Fleet search.
        let search (index: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<FleetSearchRequest>
            req <- { req with Index = index }
            req

    module Graph =

        /// Explore graph analytics.
        let explore (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<GraphExploreRequest>
            req <- { req with Index = index }
            req

    module Ilm =

        /// Delete a lifecycle policy.
        let deleteLifecycle (policy: Types.Name) =
            let mutable req = Unchecked.defaultof<IlmDeleteLifecycleRequest>
            req <- { req with Policy = policy }
            req

        /// Explain the lifecycle state.
        let explainLifecycle (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IlmExplainLifecycleRequest>
            req <- { req with Index = index }
            req

        /// Get lifecycle policies.
        let getLifecycle (policy: Types.Name) =
            let mutable req = Unchecked.defaultof<IlmGetLifecycleRequest>
            req <- { req with Policy = policy }
            req

        /// Get the ILM status.
        let getStatus () : IlmGetStatusRequest =
            Unchecked.defaultof<IlmGetStatusRequest>

        /// Migrate to data tiers routing.
        let migrateToDataTiers () =
            Unchecked.defaultof<IlmMigrateToDataTiersRequest>

        /// Move to a lifecycle step.
        let moveToStep (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IlmMoveToStepRequest>
            req <- { req with Index = index }
            req

        /// Create or update a lifecycle policy.
        let putLifecycle (policy: Types.Name) =
            let mutable req = Unchecked.defaultof<IlmPutLifecycleRequest>
            req <- { req with Policy = policy }
            req

        /// Remove policies from an index.
        let removePolicy (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IlmRemovePolicyRequest>
            req <- { req with Index = index }
            req

        /// Retry a policy.
        let retry (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IlmRetryRequest>
            req <- { req with Index = index }
            req

        /// Start the ILM plugin.
        let start () =
            Unchecked.defaultof<IlmStartRequest>

        /// Stop the ILM plugin.
        let stop () =
            Unchecked.defaultof<IlmStopRequest>

    module Indices =

        /// Add an index block.
        let addBlock (index: Types.Indices) (block: Types.IndicesBlockOptions) =
            let mutable req = Unchecked.defaultof<IndicesAddBlockRequest>
            req <- { req with Index = index }
            req <- { req with Block = block }
            req

        /// Get tokens from text analysis.
        let analyze (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesAnalyzeRequest>
            req <- { req with Index = index }
            req

        /// Cancel a migration reindex operation.
        let cancelMigrateReindex (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesCancelMigrateReindexRequest>
            req <- { req with Index = index }
            req

        /// Clear the cache.
        let clearCache (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesClearCacheRequest>
            req <- { req with Index = index }
            req

        /// Clone an index.
        let clone (index: Types.IndexName) (target: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesCloneRequest>
            req <- { req with Index = index }
            req <- { req with Target = target }
            req

        /// Close an index.
        let close (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesCloseRequest>
            req <- { req with Index = index }
            req

        /// Create an index.
        let create (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesCreateRequest>
            req <- { req with Index = index }
            req

        /// Create a data stream.
        let createDataStream (name: Types.DataStreamName) =
            let mutable req = Unchecked.defaultof<IndicesCreateDataStreamRequest>
            req <- { req with Name = name }
            req

        /// Create an index from a source index.
        let createFrom (source: Types.IndexName) (dest: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesCreateFromRequest>
            req <- { req with Source = source }
            req <- { req with Dest = dest }
            req

        /// Get data stream stats.
        let dataStreamsStats (name: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesDataStreamsStatsRequest>
            req <- { req with Name = name }
            req

        /// Delete indices.
        let delete (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesDeleteRequest>
            req <- { req with Index = index }
            req

        /// Delete an alias.
        let deleteAlias (index: Types.Indices) (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesDeleteAliasRequest>
            req <- { req with Index = index }
            req <- { req with Name = name }
            req

        /// Delete data stream lifecycles.
        let deleteDataLifecycle (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesDeleteDataLifecycleRequest>
            req <- { req with Name = name }
            req

        /// Delete data streams.
        let deleteDataStream (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesDeleteDataStreamRequest>
            req <- { req with Name = name }
            req

        /// Delete data stream options.
        let deleteDataStreamOptions (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesDeleteDataStreamOptionsRequest>
            req <- { req with Name = name }
            req

        /// Delete an index template.
        let deleteIndexTemplate (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesDeleteIndexTemplateRequest>
            req <- { req with Name = name }
            req

        /// Delete a legacy index template.
        let deleteTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesDeleteTemplateRequest>
            req <- { req with Name = name }
            req

        /// Analyze the index disk usage.
        let diskUsage (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesDiskUsageRequest>
            req <- { req with Index = index }
            req

        /// Downsample an index.
        let downsample (index: Types.IndexName) (targetIndex: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesDownsampleRequest>
            req <- { req with Index = index }
            req <- { req with TargetIndex = targetIndex }
            req

        /// Check indices.
        let exists (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesExistsRequest>
            req <- { req with Index = index }
            req

        /// Check aliases.
        let existsAlias (name: Types.Names) (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesExistsAliasRequest>
            req <- { req with Name = name }
            req <- { req with Index = index }
            req

        /// Check index templates.
        let existsIndexTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesExistsIndexTemplateRequest>
            req <- { req with Name = name }
            req

        /// Check existence of index templates.
        let existsTemplate (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesExistsTemplateRequest>
            req <- { req with Name = name }
            req

        /// Get the status for a data stream lifecycle.
        let explainDataLifecycle (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesExplainDataLifecycleRequest>
            req <- { req with Index = index }
            req

        /// Get field usage stats.
        let fieldUsageStats (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesFieldUsageStatsRequest>
            req <- { req with Index = index }
            req

        /// Flush data streams or indices.
        let flush (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesFlushRequest>
            req <- { req with Index = index }
            req

        /// Force a merge.
        let forcemerge (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesForcemergeRequest>
            req <- { req with Index = index }
            req

        /// Get index information.
        let get (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetRequest>
            req <- { req with Index = index }
            req

        /// Get aliases.
        let getAlias (name: Types.Names) (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetAliasRequest>
            req <- { req with Name = name }
            req <- { req with Index = index }
            req

        /// Get data stream lifecycles.
        let getDataLifecycle (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesGetDataLifecycleRequest>
            req <- { req with Name = name }
            req

        /// Get data stream lifecycle stats.
        let getDataLifecycleStats () : IndicesGetDataLifecycleStatsRequest =
            Unchecked.defaultof<IndicesGetDataLifecycleStatsRequest>

        /// Get data streams.
        let getDataStream (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesGetDataStreamRequest>
            req <- { req with Name = name }
            req

        /// Get data stream mappings.
        let getDataStreamMappings (name: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetDataStreamMappingsRequest>
            req <- { req with Name = name }
            req

        /// Get data stream options.
        let getDataStreamOptions (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesGetDataStreamOptionsRequest>
            req <- { req with Name = name }
            req

        /// Get data stream settings.
        let getDataStreamSettings (name: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetDataStreamSettingsRequest>
            req <- { req with Name = name }
            req

        /// Get mapping definitions.
        let getFieldMapping (fields: Types.Fields) (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetFieldMappingRequest>
            req <- { req with Fields = fields }
            req <- { req with Index = index }
            req

        /// Get index templates.
        let getIndexTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesGetIndexTemplateRequest>
            req <- { req with Name = name }
            req

        /// Get mapping definitions.
        let getMapping (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetMappingRequest>
            req <- { req with Index = index }
            req

        /// Get the migration reindexing status.
        let getMigrateReindexStatus (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesGetMigrateReindexStatusRequest>
            req <- { req with Index = index }
            req

        /// Get index settings.
        let getSettings (index: Types.Indices) (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesGetSettingsRequest>
            req <- { req with Index = index }
            req <- { req with Name = name }
            req

        /// Get legacy index templates.
        let getTemplate (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesGetTemplateRequest>
            req <- { req with Name = name }
            req

        /// Reindex legacy backing indices.
        let migrateReindex () =
            Unchecked.defaultof<IndicesMigrateReindexRequest>

        /// Convert an index alias to a data stream.
        let migrateToDataStream (name: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesMigrateToDataStreamRequest>
            req <- { req with Name = name }
            req

        /// Update data streams.
        let modifyDataStream () =
            Unchecked.defaultof<IndicesModifyDataStreamRequest>

        /// Open a closed index.
        let open' (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesOpenRequest>
            req <- { req with Index = index }
            req

        /// Promote a data stream.
        let promoteDataStream (name: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesPromoteDataStreamRequest>
            req <- { req with Name = name }
            req

        /// Create or update an alias.
        let putAlias (index: Types.Indices) (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesPutAliasRequest>
            req <- { req with Index = index }
            req <- { req with Name = name }
            req

        /// Update data stream lifecycles.
        let putDataLifecycle (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesPutDataLifecycleRequest>
            req <- { req with Name = name }
            req

        /// Update data stream mappings.
        let putDataStreamMappings (name: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesPutDataStreamMappingsRequest>
            req <- { req with Name = name }
            req

        /// Update data stream options.
        let putDataStreamOptions (name: Types.DataStreamNames) =
            let mutable req = Unchecked.defaultof<IndicesPutDataStreamOptionsRequest>
            req <- { req with Name = name }
            req

        /// Update data stream settings.
        let putDataStreamSettings (name: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesPutDataStreamSettingsRequest>
            req <- { req with Name = name }
            req

        /// Create or update an index template.
        let putIndexTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesPutIndexTemplateRequest>
            req <- { req with Name = name }
            req

        /// Update field mappings.
        let putMapping (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesPutMappingRequest>
            req <- { req with Index = index }
            req

        /// Update index settings.
        let putSettings (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesPutSettingsRequest>
            req <- { req with Index = index }
            req

        /// Create or update a legacy index template.
        let putTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesPutTemplateRequest>
            req <- { req with Name = name }
            req

        /// Get index recovery information.
        let recovery (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesRecoveryRequest>
            req <- { req with Index = index }
            req

        /// Refresh an index.
        let refresh (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesRefreshRequest>
            req <- { req with Index = index }
            req

        /// Reload search analyzers.
        let reloadSearchAnalyzers (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesReloadSearchAnalyzersRequest>
            req <- { req with Index = index }
            req

        /// Remove an index block.
        let removeBlock (index: Types.Indices) (block: Types.IndicesBlockOptions) =
            let mutable req = Unchecked.defaultof<IndicesRemoveBlockRequest>
            req <- { req with Index = index }
            req <- { req with Block = block }
            req

        /// Resolve the cluster.
        let resolveCluster (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesResolveClusterRequest>
            req <- { req with Name = name }
            req

        /// Resolve indices.
        let resolveIndex (name: Types.Names) =
            let mutable req = Unchecked.defaultof<IndicesResolveIndexRequest>
            req <- { req with Name = name }
            req

        /// Roll over to a new index.
        let rollover (alias: Types.IndexAlias) (newIndex: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesRolloverRequest>
            req <- { req with Alias = alias }
            req <- { req with NewIndex = newIndex }
            req

        /// Get index segments.
        let segments (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesSegmentsRequest>
            req <- { req with Index = index }
            req

        /// Get index shard stores.
        let shardStores (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesShardStoresRequest>
            req <- { req with Index = index }
            req

        /// Shrink an index.
        let shrink (index: Types.IndexName) (target: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesShrinkRequest>
            req <- { req with Index = index }
            req <- { req with Target = target }
            req

        /// Simulate an index.
        let simulateIndexTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesSimulateIndexTemplateRequest>
            req <- { req with Name = name }
            req

        /// Simulate an index template.
        let simulateTemplate (name: Types.Name) =
            let mutable req = Unchecked.defaultof<IndicesSimulateTemplateRequest>
            req <- { req with Name = name }
            req

        /// Split an index.
        let split (index: Types.IndexName) (target: Types.IndexName) =
            let mutable req = Unchecked.defaultof<IndicesSplitRequest>
            req <- { req with Index = index }
            req <- { req with Target = target }
            req

        /// Get index statistics.
        let stats (metric: Types.CommonStatsFlags) (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesStatsRequest>
            req <- { req with Metric = metric }
            req <- { req with Index = index }
            req

        /// Create or update an alias.
        let updateAliases () =
            Unchecked.defaultof<IndicesUpdateAliasesRequest>

        /// Validate a query.
        let validateQuery (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<IndicesValidateQueryRequest>
            req <- { req with Index = index }
            req

    module Inference =

        /// Perform chat completion inference on the service.
        let chatCompletionUnified (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceChatCompletionUnifiedRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Perform completion inference on the service.
        let completion (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceCompletionRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Delete an inference endpoint.
        let delete (taskType: Types.TaskType) (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceDeleteRequest>
            req <- { req with TaskType = taskType }
            req <- { req with InferenceId = inferenceId }
            req

        /// Perform dense embedding inference on the service.
        let embedding (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceEmbeddingRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Get an inference endpoint.
        let get (taskType: Types.TaskType) (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceGetRequest>
            req <- { req with TaskType = taskType }
            req <- { req with InferenceId = inferenceId }
            req

        /// Perform inference on the service.
        let inference (taskType: Types.TaskType) (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceInferenceRequest>
            req <- { req with TaskType = taskType }
            req <- { req with InferenceId = inferenceId }
            req

        /// Create an inference endpoint.
        let put (taskType: Types.TaskType) (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutRequest>
            req <- { req with TaskType = taskType }
            req <- { req with InferenceId = inferenceId }
            req

        /// Create a AI21 inference endpoint.
        let putAi21 (taskType: Types.Ai21TaskType) (ai21InferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAi21Request>
            req <- { req with TaskType = taskType }
            req <- { req with Ai21InferenceId = ai21InferenceId }
            req

        /// Create an AlibabaCloud AI Search inference endpoint.
        let putAlibabacloud (taskType: Types.AlibabaCloudTaskType) (alibabacloudInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAlibabacloudRequest>
            req <- { req with TaskType = taskType }
            req <- { req with AlibabacloudInferenceId = alibabacloudInferenceId }
            req

        /// Create an Amazon Bedrock inference endpoint.
        let putAmazonbedrock (taskType: Types.AmazonBedrockTaskType) (amazonbedrockInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAmazonbedrockRequest>
            req <- { req with TaskType = taskType }
            req <- { req with AmazonbedrockInferenceId = amazonbedrockInferenceId }
            req

        /// Create an Amazon SageMaker inference endpoint.
        let putAmazonsagemaker (taskType: Types.TaskTypeAmazonSageMaker) (amazonsagemakerInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAmazonsagemakerRequest>
            req <- { req with TaskType = taskType }
            req <- { req with AmazonsagemakerInferenceId = amazonsagemakerInferenceId }
            req

        /// Create an Anthropic inference endpoint.
        let putAnthropic (taskType: Types.AnthropicTaskType) (anthropicInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAnthropicRequest>
            req <- { req with TaskType = taskType }
            req <- { req with AnthropicInferenceId = anthropicInferenceId }
            req

        /// Create an Azure AI studio inference endpoint.
        let putAzureaistudio (taskType: Types.AzureAiStudioTaskType) (azureaistudioInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAzureaistudioRequest>
            req <- { req with TaskType = taskType }
            req <- { req with AzureaistudioInferenceId = azureaistudioInferenceId }
            req

        /// Create an Azure OpenAI inference endpoint.
        let putAzureopenai (taskType: Types.AzureOpenAITaskType) (azureopenaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutAzureopenaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with AzureopenaiInferenceId = azureopenaiInferenceId }
            req

        /// Create a Cohere inference endpoint.
        let putCohere (taskType: Types.CohereTaskType) (cohereInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutCohereRequest>
            req <- { req with TaskType = taskType }
            req <- { req with CohereInferenceId = cohereInferenceId }
            req

        /// Create an Contextual AI inference endpoint.
        let putContextualai (taskType: Types.TaskTypeContextualAI) (contextualaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutContextualaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with ContextualaiInferenceId = contextualaiInferenceId }
            req

        /// Create a custom inference endpoint.
        let putCustom (taskType: Types.CustomTaskType) (customInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutCustomRequest>
            req <- { req with TaskType = taskType }
            req <- { req with CustomInferenceId = customInferenceId }
            req

        /// Create a DeepSeek inference endpoint.
        let putDeepseek (taskType: Types.TaskTypeDeepSeek) (deepseekInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutDeepseekRequest>
            req <- { req with TaskType = taskType }
            req <- { req with DeepseekInferenceId = deepseekInferenceId }
            req

        /// Create an Elasticsearch inference endpoint.
        let putElasticsearch (taskType: Types.ElasticsearchTaskType) (elasticsearchInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutElasticsearchRequest>
            req <- { req with TaskType = taskType }
            req <- { req with ElasticsearchInferenceId = elasticsearchInferenceId }
            req

        /// Create an ELSER inference endpoint.
        let putElser (taskType: Types.ElserTaskType) (elserInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutElserRequest>
            req <- { req with TaskType = taskType }
            req <- { req with ElserInferenceId = elserInferenceId }
            req

        /// Create a Fireworks AI inference endpoint.
        let putFireworksai (taskType: Types.FireworksAITaskType) (fireworksaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutFireworksaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with FireworksaiInferenceId = fireworksaiInferenceId }
            req

        /// Create an Google AI Studio inference endpoint.
        let putGoogleaistudio (taskType: Types.GoogleAiStudioTaskType) (googleaistudioInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutGoogleaistudioRequest>
            req <- { req with TaskType = taskType }
            req <- { req with GoogleaistudioInferenceId = googleaistudioInferenceId }
            req

        /// Create a Google Vertex AI inference endpoint.
        let putGooglevertexai (taskType: Types.GoogleVertexAITaskType) (googlevertexaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutGooglevertexaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with GooglevertexaiInferenceId = googlevertexaiInferenceId }
            req

        /// Create a Groq inference endpoint.
        let putGroq (taskType: Types.GroqTaskType) (groqInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutGroqRequest>
            req <- { req with TaskType = taskType }
            req <- { req with GroqInferenceId = groqInferenceId }
            req

        /// Create a Hugging Face inference endpoint.
        let putHuggingFace (taskType: Types.HuggingFaceTaskType) (huggingfaceInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutHuggingFaceRequest>
            req <- { req with TaskType = taskType }
            req <- { req with HuggingfaceInferenceId = huggingfaceInferenceId }
            req

        /// Create an JinaAI inference endpoint.
        let putJinaai (taskType: Types.JinaAITaskType) (jinaaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutJinaaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with JinaaiInferenceId = jinaaiInferenceId }
            req

        /// Create a Llama inference endpoint.
        let putLlama (taskType: Types.LlamaTaskType) (llamaInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutLlamaRequest>
            req <- { req with TaskType = taskType }
            req <- { req with LlamaInferenceId = llamaInferenceId }
            req

        /// Create a Mistral inference endpoint.
        let putMistral (taskType: Types.MistralTaskType) (mistralInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutMistralRequest>
            req <- { req with TaskType = taskType }
            req <- { req with MistralInferenceId = mistralInferenceId }
            req

        /// Create an Nvidia inference endpoint.
        let putNvidia (taskType: Types.NvidiaTaskType) (nvidiaInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutNvidiaRequest>
            req <- { req with TaskType = taskType }
            req <- { req with NvidiaInferenceId = nvidiaInferenceId }
            req

        /// Create an OpenAI inference endpoint.
        let putOpenai (taskType: Types.OpenAITaskType) (openaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutOpenaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with OpenaiInferenceId = openaiInferenceId }
            req

        /// Create an OpenShift AI inference endpoint.
        let putOpenshiftAi (taskType: Types.OpenShiftAiTaskType) (openshiftaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutOpenshiftAiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with OpenshiftaiInferenceId = openshiftaiInferenceId }
            req

        /// Create a VoyageAI inference endpoint.
        let putVoyageai (taskType: Types.VoyageAITaskType) (voyageaiInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutVoyageaiRequest>
            req <- { req with TaskType = taskType }
            req <- { req with VoyageaiInferenceId = voyageaiInferenceId }
            req

        /// Create a Watsonx inference endpoint.
        let putWatsonx (taskType: Types.WatsonxTaskType) (watsonxInferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferencePutWatsonxRequest>
            req <- { req with TaskType = taskType }
            req <- { req with WatsonxInferenceId = watsonxInferenceId }
            req

        /// Perform reranking inference on the service.
        let rerank (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceRerankRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Perform sparse embedding inference on the service.
        let sparseEmbedding (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceSparseEmbeddingRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Perform streaming completion inference on the service.
        let streamCompletion (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceStreamCompletionRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Perform text embedding inference on the service.
        let textEmbedding (inferenceId: Types.Id) =
            let mutable req = Unchecked.defaultof<InferenceTextEmbeddingRequest>
            req <- { req with InferenceId = inferenceId }
            req

        /// Update an inference endpoint.
        let update (inferenceId: Types.Id) (taskType: Types.TaskType) =
            let mutable req = Unchecked.defaultof<InferenceUpdateRequest>
            req <- { req with InferenceId = inferenceId }
            req <- { req with TaskType = taskType }
            req

    module Ingest =

        /// Delete GeoIP database configurations.
        let deleteGeoipDatabase (id: Types.Ids) =
            let mutable req = Unchecked.defaultof<IngestDeleteGeoipDatabaseRequest>
            req <- { req with Id = id }
            req

        /// Delete IP geolocation database configurations.
        let deleteIpLocationDatabase (id: Types.Ids) =
            let mutable req = Unchecked.defaultof<IngestDeleteIpLocationDatabaseRequest>
            req <- { req with Id = id }
            req

        /// Delete pipelines.
        let deletePipeline (id: Types.Id) =
            let mutable req = Unchecked.defaultof<IngestDeletePipelineRequest>
            req <- { req with Id = id }
            req

        /// Get GeoIP statistics.
        let geoIpStats () : IngestGeoIpStatsRequest =
            Unchecked.defaultof<IngestGeoIpStatsRequest>

        /// Get GeoIP database configurations.
        let getGeoipDatabase (id: Types.Ids) =
            let mutable req = Unchecked.defaultof<IngestGetGeoipDatabaseRequest>
            req <- { req with Id = id }
            req

        /// Get IP geolocation database configurations.
        let getIpLocationDatabase (id: Types.Ids) =
            let mutable req = Unchecked.defaultof<IngestGetIpLocationDatabaseRequest>
            req <- { req with Id = id }
            req

        /// Get pipelines.
        let getPipeline (id: Types.Id) =
            let mutable req = Unchecked.defaultof<IngestGetPipelineRequest>
            req <- { req with Id = id }
            req

        /// Run a grok processor.
        let processorGrok () : IngestProcessorGrokRequest =
            Unchecked.defaultof<IngestProcessorGrokRequest>

        /// Create or update a GeoIP database configuration.
        let putGeoipDatabase (id: Types.Id) =
            let mutable req = Unchecked.defaultof<IngestPutGeoipDatabaseRequest>
            req <- { req with Id = id }
            req

        /// Create or update an IP geolocation database configuration.
        let putIpLocationDatabase (id: Types.Id) =
            let mutable req = Unchecked.defaultof<IngestPutIpLocationDatabaseRequest>
            req <- { req with Id = id }
            req

        /// Create or update a pipeline.
        let putPipeline (id: Types.Id) =
            let mutable req = Unchecked.defaultof<IngestPutPipelineRequest>
            req <- { req with Id = id }
            req

        /// Simulate a pipeline.
        let simulate (id: Types.Id) =
            let mutable req = Unchecked.defaultof<IngestSimulateRequest>
            req <- { req with Id = id }
            req

    module License =

        /// Delete the license.
        let delete () =
            Unchecked.defaultof<LicenseDeleteRequest>

        /// Get license information.
        let get () =
            Unchecked.defaultof<LicenseGetRequest>

        /// Get the basic license status.
        let getBasicStatus () : LicenseGetBasicStatusRequest =
            Unchecked.defaultof<LicenseGetBasicStatusRequest>

        /// Get the trial status.
        let getTrialStatus () : LicenseGetTrialStatusRequest =
            Unchecked.defaultof<LicenseGetTrialStatusRequest>

        /// Update the license.
        let post () =
            Unchecked.defaultof<LicensePostRequest>

        /// Start a basic license.
        let postStartBasic () =
            Unchecked.defaultof<LicensePostStartBasicRequest>

        /// Start a trial.
        let postStartTrial () =
            Unchecked.defaultof<LicensePostStartTrialRequest>

    module Logstash =

        /// Delete a Logstash pipeline.
        let deletePipeline (id: Types.Id) =
            let mutable req = Unchecked.defaultof<LogstashDeletePipelineRequest>
            req <- { req with Id = id }
            req

        /// Get Logstash pipelines.
        let getPipeline (id: Types.Ids) =
            let mutable req = Unchecked.defaultof<LogstashGetPipelineRequest>
            req <- { req with Id = id }
            req

        /// Create or update a Logstash pipeline.
        let putPipeline (id: Types.Id) =
            let mutable req = Unchecked.defaultof<LogstashPutPipelineRequest>
            req <- { req with Id = id }
            req

    module Migration =

        /// Get deprecation information.
        let deprecations (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<MigrationDeprecationsRequest>
            req <- { req with Index = index }
            req

        /// Get feature migration information.
        let getFeatureUpgradeStatus () : MigrationGetFeatureUpgradeStatusRequest =
            Unchecked.defaultof<MigrationGetFeatureUpgradeStatusRequest>

        /// Start the feature migration.
        let postFeatureUpgrade () : MigrationPostFeatureUpgradeRequest =
            Unchecked.defaultof<MigrationPostFeatureUpgradeRequest>

    module Ml =

        /// Clear trained model deployment cache.
        let clearTrainedModelDeploymentCache (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlClearTrainedModelDeploymentCacheRequest>
            req <- { req with ModelId = modelId }
            req

        /// Close anomaly detection jobs.
        let closeJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlCloseJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Delete a calendar.
        let deleteCalendar (calendarId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteCalendarRequest>
            req <- { req with CalendarId = calendarId }
            req

        /// Delete events from a calendar.
        let deleteCalendarEvent (calendarId: Types.Id) (eventId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteCalendarEventRequest>
            req <- { req with CalendarId = calendarId }
            req <- { req with EventId = eventId }
            req

        /// Delete anomaly jobs from a calendar.
        let deleteCalendarJob (calendarId: Types.Id) (jobId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlDeleteCalendarJobRequest>
            req <- { req with CalendarId = calendarId }
            req <- { req with JobId = jobId }
            req

        /// Delete a data frame analytics job.
        let deleteDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Delete a datafeed.
        let deleteDatafeed (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteDatafeedRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Delete expired ML data.
        let deleteExpiredData (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteExpiredDataRequest>
            req <- { req with JobId = jobId }
            req

        /// Delete a filter.
        let deleteFilter (filterId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteFilterRequest>
            req <- { req with FilterId = filterId }
            req

        /// Delete forecasts from a job.
        let deleteForecast (jobId: Types.Id) (forecastId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteForecastRequest>
            req <- { req with JobId = jobId }
            req <- { req with ForecastId = forecastId }
            req

        /// Delete an anomaly detection job.
        let deleteJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Delete a model snapshot.
        let deleteModelSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteModelSnapshotRequest>
            req <- { req with JobId = jobId }
            req <- { req with SnapshotId = snapshotId }
            req

        /// Delete an unreferenced trained model.
        let deleteTrainedModel (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteTrainedModelRequest>
            req <- { req with ModelId = modelId }
            req

        /// Delete a trained model alias.
        let deleteTrainedModelAlias (modelAlias: Types.Name) (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlDeleteTrainedModelAliasRequest>
            req <- { req with ModelAlias = modelAlias }
            req <- { req with ModelId = modelId }
            req

        /// Estimate job model memory usage.
        let estimateModelMemory () =
            Unchecked.defaultof<MlEstimateModelMemoryRequest>

        /// Evaluate data frame analytics.
        let evaluateDataFrame () =
            Unchecked.defaultof<MlEvaluateDataFrameRequest>

        /// Explain data frame analytics config.
        let explainDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlExplainDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Force buffered data to be processed.
        let flushJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlFlushJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Predict future behavior of a time series.
        let forecast (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlForecastRequest>
            req <- { req with JobId = jobId }
            req

        /// Get anomaly detection job results for buckets.
        let getBuckets (jobId: Types.Id) (timestamp: Types.DateTime) =
            let mutable req = Unchecked.defaultof<MlGetBucketsRequest>
            req <- { req with JobId = jobId }
            req <- { req with Timestamp = timestamp }
            req

        /// Get info about events in calendars.
        let getCalendarEvents (calendarId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetCalendarEventsRequest>
            req <- { req with CalendarId = calendarId }
            req

        /// Get calendar configuration info.
        let getCalendars (calendarId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetCalendarsRequest>
            req <- { req with CalendarId = calendarId }
            req

        /// Get anomaly detection job results for categories.
        let getCategories (jobId: Types.Id) (categoryId: Types.CategoryId) =
            let mutable req = Unchecked.defaultof<MlGetCategoriesRequest>
            req <- { req with JobId = jobId }
            req <- { req with CategoryId = categoryId }
            req

        /// Get data frame analytics job configuration info.
        let getDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Get data frame analytics job stats.
        let getDataFrameAnalyticsStats (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetDataFrameAnalyticsStatsRequest>
            req <- { req with Id = id }
            req

        /// Get datafeed stats.
        let getDatafeedStats (datafeedId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlGetDatafeedStatsRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Get datafeeds configuration info.
        let getDatafeeds (datafeedId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlGetDatafeedsRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Get filters.
        let getFilters (filterId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlGetFiltersRequest>
            req <- { req with FilterId = filterId }
            req

        /// Get anomaly detection job results for influencers.
        let getInfluencers (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetInfluencersRequest>
            req <- { req with JobId = jobId }
            req

        /// Get anomaly detection job stats.
        let getJobStats (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetJobStatsRequest>
            req <- { req with JobId = jobId }
            req

        /// Get anomaly detection jobs configuration info.
        let getJobs (jobId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlGetJobsRequest>
            req <- { req with JobId = jobId }
            req

        /// Get machine learning memory usage info.
        let getMemoryStats (nodeId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetMemoryStatsRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Get anomaly detection job model snapshot upgrade usage info.
        let getModelSnapshotUpgradeStats (jobId: Types.Id) (snapshotId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetModelSnapshotUpgradeStatsRequest>
            req <- { req with JobId = jobId }
            req <- { req with SnapshotId = snapshotId }
            req

        /// Get model snapshots info.
        let getModelSnapshots (jobId: Types.Id) (snapshotId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetModelSnapshotsRequest>
            req <- { req with JobId = jobId }
            req <- { req with SnapshotId = snapshotId }
            req

        /// Get overall bucket results.
        let getOverallBuckets (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetOverallBucketsRequest>
            req <- { req with JobId = jobId }
            req

        /// Get anomaly records for an anomaly detection job.
        let getRecords (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlGetRecordsRequest>
            req <- { req with JobId = jobId }
            req

        /// Get trained model configuration info.
        let getTrainedModels (modelId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlGetTrainedModelsRequest>
            req <- { req with ModelId = modelId }
            req

        /// Get trained models usage info.
        let getTrainedModelsStats (modelId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlGetTrainedModelsStatsRequest>
            req <- { req with ModelId = modelId }
            req

        /// Evaluate a trained model.
        let inferTrainedModel (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlInferTrainedModelRequest>
            req <- { req with ModelId = modelId }
            req

        /// Get machine learning information.
        let info () : MlInfoRequest =
            Unchecked.defaultof<MlInfoRequest>

        /// Open anomaly detection jobs.
        let openJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlOpenJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Add scheduled events to the calendar.
        let postCalendarEvents (calendarId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPostCalendarEventsRequest>
            req <- { req with CalendarId = calendarId }
            req

        /// Preview features used by data frame analytics.
        let previewDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPreviewDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Preview a datafeed.
        let previewDatafeed (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPreviewDatafeedRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Create a calendar.
        let putCalendar (calendarId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutCalendarRequest>
            req <- { req with CalendarId = calendarId }
            req

        /// Add anomaly detection job to calendar.
        let putCalendarJob (calendarId: Types.Id) (jobId: Types.Ids) =
            let mutable req = Unchecked.defaultof<MlPutCalendarJobRequest>
            req <- { req with CalendarId = calendarId }
            req <- { req with JobId = jobId }
            req

        /// Create a data frame analytics job.
        let putDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Create a datafeed.
        let putDatafeed (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutDatafeedRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Create a filter.
        let putFilter (filterId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutFilterRequest>
            req <- { req with FilterId = filterId }
            req

        /// Create an anomaly detection job.
        let putJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Create a trained model.
        let putTrainedModel (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutTrainedModelRequest>
            req <- { req with ModelId = modelId }
            req

        /// Create or update a trained model alias.
        let putTrainedModelAlias (modelAlias: Types.Name) (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutTrainedModelAliasRequest>
            req <- { req with ModelAlias = modelAlias }
            req <- { req with ModelId = modelId }
            req

        /// Create part of a trained model definition.
        let putTrainedModelDefinitionPart (modelId: Types.Id) (part: Types.Integer) =
            let mutable req = Unchecked.defaultof<MlPutTrainedModelDefinitionPartRequest>
            req <- { req with ModelId = modelId }
            req <- { req with Part = part }
            req

        /// Create a trained model vocabulary.
        let putTrainedModelVocabulary (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlPutTrainedModelVocabularyRequest>
            req <- { req with ModelId = modelId }
            req

        /// Reset an anomaly detection job.
        let resetJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlResetJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Revert to a snapshot.
        let revertModelSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlRevertModelSnapshotRequest>
            req <- { req with JobId = jobId }
            req <- { req with SnapshotId = snapshotId }
            req

        /// Set upgrade_mode for ML indices.
        let setUpgradeMode () =
            Unchecked.defaultof<MlSetUpgradeModeRequest>

        /// Start a data frame analytics job.
        let startDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlStartDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Start datafeeds.
        let startDatafeed (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlStartDatafeedRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Start a trained model deployment.
        let startTrainedModelDeployment (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlStartTrainedModelDeploymentRequest>
            req <- { req with ModelId = modelId }
            req

        /// Stop data frame analytics jobs.
        let stopDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlStopDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Stop datafeeds.
        let stopDatafeed (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlStopDatafeedRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Stop a trained model deployment.
        let stopTrainedModelDeployment (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlStopTrainedModelDeploymentRequest>
            req <- { req with ModelId = modelId }
            req

        /// Update a data frame analytics job.
        let updateDataFrameAnalytics (id: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpdateDataFrameAnalyticsRequest>
            req <- { req with Id = id }
            req

        /// Update a datafeed.
        let updateDatafeed (datafeedId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpdateDatafeedRequest>
            req <- { req with DatafeedId = datafeedId }
            req

        /// Update a filter.
        let updateFilter (filterId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpdateFilterRequest>
            req <- { req with FilterId = filterId }
            req

        /// Update an anomaly detection job.
        let updateJob (jobId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpdateJobRequest>
            req <- { req with JobId = jobId }
            req

        /// Update a snapshot.
        let updateModelSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpdateModelSnapshotRequest>
            req <- { req with JobId = jobId }
            req <- { req with SnapshotId = snapshotId }
            req

        /// Update a trained model deployment.
        let updateTrainedModelDeployment (modelId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpdateTrainedModelDeploymentRequest>
            req <- { req with ModelId = modelId }
            req

        /// Upgrade a snapshot.
        let upgradeJobSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let mutable req = Unchecked.defaultof<MlUpgradeJobSnapshotRequest>
            req <- { req with JobId = jobId }
            req <- { req with SnapshotId = snapshotId }
            req

        /// Validate an anomaly detection job.
        let validate () =
            Unchecked.defaultof<MlValidateRequest>

        /// Validate an anomaly detection job.
        let validateDetector () =
            Unchecked.defaultof<MlValidateDetectorRequest>

    module Nodes =

        /// Clear the archived repositories metering.
        let clearRepositoriesMeteringArchive (nodeId: Types.NodeIds) (maxArchiveVersion: Types.Long) =
            let mutable req = Unchecked.defaultof<NodesClearRepositoriesMeteringArchiveRequest>
            req <- { req with NodeId = nodeId }
            req <- { req with MaxArchiveVersion = maxArchiveVersion }
            req

        /// Get cluster repositories metering.
        let getRepositoriesMeteringInfo (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<NodesGetRepositoriesMeteringInfoRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Get the hot threads for nodes.
        let hotThreads (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<NodesHotThreadsRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Get node information.
        let info (nodeId: Types.NodeIds) (metric: Types.NodesInfoMetrics) =
            let mutable req = Unchecked.defaultof<NodesInfoRequest>
            req <- { req with NodeId = nodeId }
            req <- { req with Metric = metric }
            req

        /// Reload the keystore on nodes in the cluster.
        let reloadSecureSettings (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<NodesReloadSecureSettingsRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Get node statistics.
        let stats (nodeId: Types.NodeIds) (metric: Types.NodeStatsMetrics) (indexMetric: Types.CommonStatsFlags) =
            let mutable req = Unchecked.defaultof<NodesStatsRequest>
            req <- { req with NodeId = nodeId }
            req <- { req with Metric = metric }
            req <- { req with IndexMetric = indexMetric }
            req

        /// Get feature usage information.
        let usage (nodeId: Types.NodeIds) (metric: Types.NodesUsageMetrics) =
            let mutable req = Unchecked.defaultof<NodesUsageRequest>
            req <- { req with NodeId = nodeId }
            req <- { req with Metric = metric }
            req

    module Profiling =

        /// Returns basic information about the status of Universal Profiling.
        let flamegraph () =
            Unchecked.defaultof<ProfilingFlamegraphRequest>

        /// Extracts raw stacktrace information from Universal Profiling.
        let stacktraces () =
            Unchecked.defaultof<ProfilingStacktracesRequest>

        /// Returns basic information about the status of Universal Profiling.
        let status () =
            Unchecked.defaultof<ProfilingStatusRequest>

        /// Extracts a list of topN functions from Universal Profiling.
        let topnFunctions () =
            Unchecked.defaultof<ProfilingTopnFunctionsRequest>

    module Project =

        /// Create or update project routing expressions.
        let createManyRouting () =
            Unchecked.defaultof<ProjectCreateManyRoutingRequest>

        /// Create or update a project routing expression.
        let createRouting (name: string) =
            let mutable req = Unchecked.defaultof<ProjectCreateRoutingRequest>
            req <- { req with Name = name }
            req

        /// Delete a project routing expression.
        let deleteRouting (name: string) =
            let mutable req = Unchecked.defaultof<ProjectDeleteRoutingRequest>
            req <- { req with Name = name }
            req

        /// Get project routing expressions.
        let getManyRouting () : ProjectGetManyRoutingRequest =
            Unchecked.defaultof<ProjectGetManyRoutingRequest>

        /// Get a project routing expression.
        let getRouting (name: string) =
            let mutable req = Unchecked.defaultof<ProjectGetRoutingRequest>
            req <- { req with Name = name }
            req

        /// Get tags.
        let tags () =
            Unchecked.defaultof<ProjectTagsRequest>

    module QueryRules =

        /// Delete a query rule.
        let deleteRule (rulesetId: Types.Id) (ruleId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesDeleteRuleRequest>
            req <- { req with RulesetId = rulesetId }
            req <- { req with RuleId = ruleId }
            req

        /// Delete a query ruleset.
        let deleteRuleset (rulesetId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesDeleteRulesetRequest>
            req <- { req with RulesetId = rulesetId }
            req

        /// Get a query rule.
        let getRule (rulesetId: Types.Id) (ruleId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesGetRuleRequest>
            req <- { req with RulesetId = rulesetId }
            req <- { req with RuleId = ruleId }
            req

        /// Get a query ruleset.
        let getRuleset (rulesetId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesGetRulesetRequest>
            req <- { req with RulesetId = rulesetId }
            req

        /// Get all query rulesets.
        let listRulesets () =
            Unchecked.defaultof<QueryRulesListRulesetsRequest>

        /// Create or update a query rule.
        let putRule (rulesetId: Types.Id) (ruleId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesPutRuleRequest>
            req <- { req with RulesetId = rulesetId }
            req <- { req with RuleId = ruleId }
            req

        /// Create or update a query ruleset.
        let putRuleset (rulesetId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesPutRulesetRequest>
            req <- { req with RulesetId = rulesetId }
            req

        /// Test a query ruleset.
        let test (rulesetId: Types.Id) =
            let mutable req = Unchecked.defaultof<QueryRulesTestRequest>
            req <- { req with RulesetId = rulesetId }
            req

    module Rollup =

        /// Delete a rollup job.
        let deleteJob (id: Types.Id) =
            let mutable req = Unchecked.defaultof<RollupDeleteJobRequest>
            req <- { req with Id = id }
            req

        /// Get rollup job information.
        let getJobs (id: Types.Id) =
            let mutable req = Unchecked.defaultof<RollupGetJobsRequest>
            req <- { req with Id = id }
            req

        /// Get the rollup job capabilities.
        let getRollupCaps (id: Types.Id) =
            let mutable req = Unchecked.defaultof<RollupGetRollupCapsRequest>
            req <- { req with Id = id }
            req

        /// Get the rollup index capabilities.
        let getRollupIndexCaps (index: Types.Ids) =
            let mutable req = Unchecked.defaultof<RollupGetRollupIndexCapsRequest>
            req <- { req with Index = index }
            req

        /// Create a rollup job.
        let putJob (id: Types.Id) =
            let mutable req = Unchecked.defaultof<RollupPutJobRequest>
            req <- { req with Id = id }
            req

        /// Search rolled-up data.
        let rollupSearch (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<RollupRollupSearchRequest>
            req <- { req with Index = index }
            req

        /// Start rollup jobs.
        let startJob (id: Types.Id) =
            let mutable req = Unchecked.defaultof<RollupStartJobRequest>
            req <- { req with Id = id }
            req

        /// Stop rollup jobs.
        let stopJob (id: Types.Id) =
            let mutable req = Unchecked.defaultof<RollupStopJobRequest>
            req <- { req with Id = id }
            req

    module SearchApplication =

        /// Delete a search application.
        let delete (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationDeleteRequest>
            req <- { req with Name = name }
            req

        /// Delete a behavioral analytics collection.
        let deleteBehavioralAnalytics (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationDeleteBehavioralAnalyticsRequest>
            req <- { req with Name = name }
            req

        /// Get search application details.
        let get (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationGetRequest>
            req <- { req with Name = name }
            req

        /// Get behavioral analytics collections.
        let getBehavioralAnalytics (name: Types.Name list) =
            let mutable req = Unchecked.defaultof<SearchApplicationGetBehavioralAnalyticsRequest>
            req <- { req with Name = name }
            req

        /// Get search applications.
        let list () =
            Unchecked.defaultof<SearchApplicationListRequest>

        /// Create a behavioral analytics collection event.
        let postBehavioralAnalyticsEvent (collectionName: Types.Name) (eventType: Types.EventType) =
            let mutable req = Unchecked.defaultof<SearchApplicationPostBehavioralAnalyticsEventRequest>
            req <- { req with CollectionName = collectionName }
            req <- { req with EventType = eventType }
            req

        /// Create or update a search application.
        let put (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationPutRequest>
            req <- { req with Name = name }
            req

        /// Create a behavioral analytics collection.
        let putBehavioralAnalytics (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationPutBehavioralAnalyticsRequest>
            req <- { req with Name = name }
            req

        /// Render a search application query.
        let renderQuery (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationRenderQueryRequest>
            req <- { req with Name = name }
            req

        /// Run a search application search.
        let search (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchApplicationSearchRequest>
            req <- { req with Name = name }
            req

    module SearchableSnapshots =

        /// Get cache statistics.
        let cacheStats (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<SearchableSnapshotsCacheStatsRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Clear the cache.
        let clearCache (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<SearchableSnapshotsClearCacheRequest>
            req <- { req with Index = index }
            req

        /// Mount a snapshot.
        let mount (repository: Types.Name) (snapshot: Types.Name) =
            let mutable req = Unchecked.defaultof<SearchableSnapshotsMountRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req

        /// Get searchable snapshot statistics.
        let stats (index: Types.Indices) =
            let mutable req = Unchecked.defaultof<SearchableSnapshotsStatsRequest>
            req <- { req with Index = index }
            req

    module Security =

        /// Activate a user profile.
        let activateUserProfile () =
            Unchecked.defaultof<SecurityActivateUserProfileRequest>

        /// Authenticate a user.
        let authenticate () : SecurityAuthenticateRequest =
            Unchecked.defaultof<SecurityAuthenticateRequest>

        /// Bulk delete roles.
        let bulkDeleteRole () =
            Unchecked.defaultof<SecurityBulkDeleteRoleRequest>

        /// Bulk create or update roles.
        let bulkPutRole () =
            Unchecked.defaultof<SecurityBulkPutRoleRequest>

        /// Bulk update API keys.
        let bulkUpdateApiKeys () =
            Unchecked.defaultof<SecurityBulkUpdateApiKeysRequest>

        /// Change passwords.
        let changePassword (username: Types.Username) =
            let mutable req = Unchecked.defaultof<SecurityChangePasswordRequest>
            req <- { req with Username = username }
            req

        /// Clear the API key cache.
        let clearApiKeyCache (ids: Types.Ids) =
            let mutable req = Unchecked.defaultof<SecurityClearApiKeyCacheRequest>
            req <- { req with Ids = ids }
            req

        /// Clear the privileges cache.
        let clearCachedPrivileges (application: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityClearCachedPrivilegesRequest>
            req <- { req with Application = application }
            req

        /// Clear the user cache.
        let clearCachedRealms (realms: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityClearCachedRealmsRequest>
            req <- { req with Realms = realms }
            req

        /// Clear the roles cache.
        let clearCachedRoles (name: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityClearCachedRolesRequest>
            req <- { req with Name = name }
            req

        /// Clear service account token caches.
        let clearCachedServiceTokens (namespace': Types.Namespace) (service: Types.Service) (name: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityClearCachedServiceTokensRequest>
            req <- { req with Namespace = namespace' }
            req <- { req with Service = service }
            req <- { req with Name = name }
            req

        /// Create an API key.
        let createApiKey () =
            Unchecked.defaultof<SecurityCreateApiKeyRequest>

        /// Create a cross-cluster API key.
        let createCrossClusterApiKey () =
            Unchecked.defaultof<SecurityCreateCrossClusterApiKeyRequest>

        /// Create a service account token.
        let createServiceToken (namespace': Types.Namespace) (service: Types.Service) (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityCreateServiceTokenRequest>
            req <- { req with Namespace = namespace' }
            req <- { req with Service = service }
            req <- { req with Name = name }
            req

        /// Delegate PKI authentication.
        let delegatePki () =
            Unchecked.defaultof<SecurityDelegatePkiRequest>

        /// Delete application privileges.
        let deletePrivileges (application: Types.Name) (name: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityDeletePrivilegesRequest>
            req <- { req with Application = application }
            req <- { req with Name = name }
            req

        /// Delete roles.
        let deleteRole (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityDeleteRoleRequest>
            req <- { req with Name = name }
            req

        /// Delete role mappings.
        let deleteRoleMapping (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityDeleteRoleMappingRequest>
            req <- { req with Name = name }
            req

        /// Delete service account tokens.
        let deleteServiceToken (namespace': Types.Namespace) (service: Types.Service) (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityDeleteServiceTokenRequest>
            req <- { req with Namespace = namespace' }
            req <- { req with Service = service }
            req <- { req with Name = name }
            req

        /// Delete users.
        let deleteUser (username: Types.Username) =
            let mutable req = Unchecked.defaultof<SecurityDeleteUserRequest>
            req <- { req with Username = username }
            req

        /// Disable users.
        let disableUser (username: Types.Username) =
            let mutable req = Unchecked.defaultof<SecurityDisableUserRequest>
            req <- { req with Username = username }
            req

        /// Disable a user profile.
        let disableUserProfile (uid: Types.UserProfileId) =
            let mutable req = Unchecked.defaultof<SecurityDisableUserProfileRequest>
            req <- { req with Uid = uid }
            req

        /// Enable users.
        let enableUser (username: Types.Username) =
            let mutable req = Unchecked.defaultof<SecurityEnableUserRequest>
            req <- { req with Username = username }
            req

        /// Enable a user profile.
        let enableUserProfile (uid: Types.UserProfileId) =
            let mutable req = Unchecked.defaultof<SecurityEnableUserProfileRequest>
            req <- { req with Uid = uid }
            req

        /// Enroll Kibana.
        let enrollKibana () : SecurityEnrollKibanaRequest =
            Unchecked.defaultof<SecurityEnrollKibanaRequest>

        /// Enroll a node.
        let enrollNode () : SecurityEnrollNodeRequest =
            Unchecked.defaultof<SecurityEnrollNodeRequest>

        /// Get API key information.
        let getApiKey () =
            Unchecked.defaultof<SecurityGetApiKeyRequest>

        /// Get builtin privileges.
        let getBuiltinPrivileges () : SecurityGetBuiltinPrivilegesRequest =
            Unchecked.defaultof<SecurityGetBuiltinPrivilegesRequest>

        /// Get application privileges.
        let getPrivileges (application: Types.Name) (name: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityGetPrivilegesRequest>
            req <- { req with Application = application }
            req <- { req with Name = name }
            req

        /// Get roles.
        let getRole (name: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityGetRoleRequest>
            req <- { req with Name = name }
            req

        /// Get role mappings.
        let getRoleMapping (name: Types.Names) =
            let mutable req = Unchecked.defaultof<SecurityGetRoleMappingRequest>
            req <- { req with Name = name }
            req

        /// Get service accounts.
        let getServiceAccounts (namespace': Types.Namespace) (service: Types.Service) =
            let mutable req = Unchecked.defaultof<SecurityGetServiceAccountsRequest>
            req <- { req with Namespace = namespace' }
            req <- { req with Service = service }
            req

        /// Get service account credentials.
        let getServiceCredentials (namespace': Types.Namespace) (service: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityGetServiceCredentialsRequest>
            req <- { req with Namespace = namespace' }
            req <- { req with Service = service }
            req

        /// Get security index settings.
        let getSettings () =
            Unchecked.defaultof<SecurityGetSettingsRequest>

        /// Get security stats.
        let getStats () : SecurityGetStatsRequest =
            Unchecked.defaultof<SecurityGetStatsRequest>

        /// Get a token.
        let getToken () =
            Unchecked.defaultof<SecurityGetTokenRequest>

        /// Get users.
        let getUser (username: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<SecurityGetUserRequest>
            req <- { req with Username = username }
            req

        /// Get user privileges.
        let getUserPrivileges () : SecurityGetUserPrivilegesRequest =
            Unchecked.defaultof<SecurityGetUserPrivilegesRequest>

        /// Get a user profile.
        let getUserProfile (uid: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<SecurityGetUserProfileRequest>
            req <- { req with Uid = uid }
            req

        /// Grant an API key.
        let grantApiKey () =
            Unchecked.defaultof<SecurityGrantApiKeyRequest>

        /// Check user privileges.
        let hasPrivileges (user: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityHasPrivilegesRequest>
            req <- { req with User = user }
            req

        /// Check user profile privileges.
        let hasPrivilegesUserProfile () =
            Unchecked.defaultof<SecurityHasPrivilegesUserProfileRequest>

        /// Invalidate API keys.
        let invalidateApiKey () =
            Unchecked.defaultof<SecurityInvalidateApiKeyRequest>

        /// Invalidate a token.
        let invalidateToken () =
            Unchecked.defaultof<SecurityInvalidateTokenRequest>

        /// Authenticate OpenID Connect.
        let oidcAuthenticate () =
            Unchecked.defaultof<SecurityOidcAuthenticateRequest>

        /// Logout of OpenID Connect.
        let oidcLogout () =
            Unchecked.defaultof<SecurityOidcLogoutRequest>

        /// Prepare OpenID connect authentication.
        let oidcPrepareAuthentication () =
            Unchecked.defaultof<SecurityOidcPrepareAuthenticationRequest>

        /// Create or update application privileges.
        let putPrivileges () =
            Unchecked.defaultof<SecurityPutPrivilegesRequest>

        /// Create or update roles.
        let putRole (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityPutRoleRequest>
            req <- { req with Name = name }
            req

        /// Create or update role mappings.
        let putRoleMapping (name: Types.Name) =
            let mutable req = Unchecked.defaultof<SecurityPutRoleMappingRequest>
            req <- { req with Name = name }
            req

        /// Create or update users.
        let putUser (username: Types.Username) =
            let mutable req = Unchecked.defaultof<SecurityPutUserRequest>
            req <- { req with Username = username }
            req

        /// Find API keys with a query.
        let queryApiKeys () =
            Unchecked.defaultof<SecurityQueryApiKeysRequest>

        /// Find roles with a query.
        let queryRole () =
            Unchecked.defaultof<SecurityQueryRoleRequest>

        /// Find users with a query.
        let queryUser () =
            Unchecked.defaultof<SecurityQueryUserRequest>

        /// Authenticate SAML.
        let samlAuthenticate () =
            Unchecked.defaultof<SecuritySamlAuthenticateRequest>

        /// Logout of SAML completely.
        let samlCompleteLogout () =
            Unchecked.defaultof<SecuritySamlCompleteLogoutRequest>

        /// Invalidate SAML.
        let samlInvalidate () =
            Unchecked.defaultof<SecuritySamlInvalidateRequest>

        /// Logout of SAML.
        let samlLogout () =
            Unchecked.defaultof<SecuritySamlLogoutRequest>

        /// Prepare SAML authentication.
        let samlPrepareAuthentication () =
            Unchecked.defaultof<SecuritySamlPrepareAuthenticationRequest>

        /// Create SAML service provider metadata.
        let samlServiceProviderMetadata (realmName: Types.Name) =
            let mutable req = Unchecked.defaultof<SecuritySamlServiceProviderMetadataRequest>
            req <- { req with RealmName = realmName }
            req

        /// Suggest a user profile.
        let suggestUserProfiles () =
            Unchecked.defaultof<SecuritySuggestUserProfilesRequest>

        /// Update an API key.
        let updateApiKey (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SecurityUpdateApiKeyRequest>
            req <- { req with Id = id }
            req

        /// Update a cross-cluster API key.
        let updateCrossClusterApiKey (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SecurityUpdateCrossClusterApiKeyRequest>
            req <- { req with Id = id }
            req

        /// Update security index settings.
        let updateSettings () =
            Unchecked.defaultof<SecurityUpdateSettingsRequest>

        /// Update user profile data.
        let updateUserProfileData (uid: Types.UserProfileId) =
            let mutable req = Unchecked.defaultof<SecurityUpdateUserProfileDataRequest>
            req <- { req with Uid = uid }
            req

    module Shutdown =

        /// Cancel node shutdown preparations.
        let deleteNode (nodeId: Types.NodeId) =
            let mutable req = Unchecked.defaultof<ShutdownDeleteNodeRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Get the shutdown status.
        let getNode (nodeId: Types.NodeIds) =
            let mutable req = Unchecked.defaultof<ShutdownGetNodeRequest>
            req <- { req with NodeId = nodeId }
            req

        /// Prepare a node to be shut down.
        let putNode (nodeId: Types.NodeId) =
            let mutable req = Unchecked.defaultof<ShutdownPutNodeRequest>
            req <- { req with NodeId = nodeId }
            req

    module Simulate =

        /// Simulate data ingestion.
        let ingest (index: Types.IndexName) =
            let mutable req = Unchecked.defaultof<SimulateIngestRequest>
            req <- { req with Index = index }
            req

    module Slm =

        /// Delete a policy.
        let deleteLifecycle (policyId: Types.Name) =
            let mutable req = Unchecked.defaultof<SlmDeleteLifecycleRequest>
            req <- { req with PolicyId = policyId }
            req

        /// Run a policy.
        let executeLifecycle (policyId: Types.Name) =
            let mutable req = Unchecked.defaultof<SlmExecuteLifecycleRequest>
            req <- { req with PolicyId = policyId }
            req

        /// Run a retention policy.
        let executeRetention () =
            Unchecked.defaultof<SlmExecuteRetentionRequest>

        /// Get policy information.
        let getLifecycle (policyId: Types.Names) =
            let mutable req = Unchecked.defaultof<SlmGetLifecycleRequest>
            req <- { req with PolicyId = policyId }
            req

        /// Get snapshot lifecycle management statistics.
        let getStats () =
            Unchecked.defaultof<SlmGetStatsRequest>

        /// Get the snapshot lifecycle management status.
        let getStatus () =
            Unchecked.defaultof<SlmGetStatusRequest>

        /// Create or update a policy.
        let putLifecycle (policyId: Types.Name) =
            let mutable req = Unchecked.defaultof<SlmPutLifecycleRequest>
            req <- { req with PolicyId = policyId }
            req

        /// Start snapshot lifecycle management.
        let start () =
            Unchecked.defaultof<SlmStartRequest>

        /// Stop snapshot lifecycle management.
        let stop () =
            Unchecked.defaultof<SlmStopRequest>

    module Snapshot =

        /// Clean up the snapshot repository.
        let cleanupRepository (repository: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotCleanupRepositoryRequest>
            req <- { req with Repository = repository }
            req

        /// Clone a snapshot.
        let clone (repository: Types.Name) (snapshot: Types.Name) (targetSnapshot: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotCloneRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req <- { req with TargetSnapshot = targetSnapshot }
            req

        /// Create a snapshot.
        let create (repository: Types.Name) (snapshot: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotCreateRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req

        /// Create or update a snapshot repository.
        let createRepository (repository: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotCreateRepositoryRequest>
            req <- { req with Repository = repository }
            req

        /// Delete snapshots.
        let delete (repository: Types.Name) (snapshot: Types.Names) =
            let mutable req = Unchecked.defaultof<SnapshotDeleteRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req

        /// Delete snapshot repositories.
        let deleteRepository (repository: Types.Names) =
            let mutable req = Unchecked.defaultof<SnapshotDeleteRepositoryRequest>
            req <- { req with Repository = repository }
            req

        /// Get snapshot information.
        let get (repository: Types.Name) (snapshot: Types.Names) =
            let mutable req = Unchecked.defaultof<SnapshotGetRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req

        /// Get snapshot repository information.
        let getRepository (repository: Types.Names) =
            let mutable req = Unchecked.defaultof<SnapshotGetRepositoryRequest>
            req <- { req with Repository = repository }
            req

        /// Analyze a snapshot repository.
        let repositoryAnalyze (repository: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotRepositoryAnalyzeRequest>
            req <- { req with Repository = repository }
            req

        /// Verify the repository integrity.
        let repositoryVerifyIntegrity (repository: Types.Names) =
            let mutable req = Unchecked.defaultof<SnapshotRepositoryVerifyIntegrityRequest>
            req <- { req with Repository = repository }
            req

        /// Restore a snapshot.
        let restore (repository: Types.Name) (snapshot: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotRestoreRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req

        /// Get the snapshot status.
        let status (repository: Types.Name) (snapshot: Types.Names) =
            let mutable req = Unchecked.defaultof<SnapshotStatusRequest>
            req <- { req with Repository = repository }
            req <- { req with Snapshot = snapshot }
            req

        /// Verify a snapshot repository.
        let verifyRepository (repository: Types.Name) =
            let mutable req = Unchecked.defaultof<SnapshotVerifyRepositoryRequest>
            req <- { req with Repository = repository }
            req

    module Sql =

        /// Clear an SQL search cursor.
        let clearCursor () =
            Unchecked.defaultof<SqlClearCursorRequest>

        /// Delete an async SQL search.
        let deleteAsync (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SqlDeleteAsyncRequest>
            req <- { req with Id = id }
            req

        /// Get async SQL search results.
        let getAsync (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SqlGetAsyncRequest>
            req <- { req with Id = id }
            req

        /// Get the async SQL search status.
        let getAsyncStatus (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SqlGetAsyncStatusRequest>
            req <- { req with Id = id }
            req

        /// Get SQL search results.
        let query () =
            Unchecked.defaultof<SqlQueryRequest>

        /// Translate SQL into Elasticsearch queries.
        let translate () =
            Unchecked.defaultof<SqlTranslateRequest>

    module Ssl =

        /// Get SSL certificates.
        let certificates () : SslCertificatesRequest =
            Unchecked.defaultof<SslCertificatesRequest>

    module Streams =

        /// Disable a named stream.
        let logsDisable (name: Types.StreamType) =
            let mutable req = Unchecked.defaultof<StreamsLogsDisableRequest>
            req <- { req with Name = name }
            req

        /// Enable a named stream.
        let logsEnable (name: Types.StreamType) =
            let mutable req = Unchecked.defaultof<StreamsLogsEnableRequest>
            req <- { req with Name = name }
            req

        /// Get the status of streams.
        let status () =
            Unchecked.defaultof<StreamsStatusRequest>

    module Synonyms =

        /// Delete a synonym set.
        let deleteSynonym (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SynonymsDeleteSynonymRequest>
            req <- { req with Id = id }
            req

        /// Delete a synonym rule.
        let deleteSynonymRule (setId: Types.Id) (ruleId: Types.Id) =
            let mutable req = Unchecked.defaultof<SynonymsDeleteSynonymRuleRequest>
            req <- { req with SetId = setId }
            req <- { req with RuleId = ruleId }
            req

        /// Get a synonym set.
        let getSynonym (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SynonymsGetSynonymRequest>
            req <- { req with Id = id }
            req

        /// Get a synonym rule.
        let getSynonymRule (setId: Types.Id) (ruleId: Types.Id) =
            let mutable req = Unchecked.defaultof<SynonymsGetSynonymRuleRequest>
            req <- { req with SetId = setId }
            req <- { req with RuleId = ruleId }
            req

        /// Get all synonym sets.
        let getSynonymsSets () =
            Unchecked.defaultof<SynonymsGetSynonymsSetsRequest>

        /// Create or update a synonym set.
        let putSynonym (id: Types.Id) =
            let mutable req = Unchecked.defaultof<SynonymsPutSynonymRequest>
            req <- { req with Id = id }
            req

        /// Create or update a synonym rule.
        let putSynonymRule (setId: Types.Id) (ruleId: Types.Id) =
            let mutable req = Unchecked.defaultof<SynonymsPutSynonymRuleRequest>
            req <- { req with SetId = setId }
            req <- { req with RuleId = ruleId }
            req

    module Tasks =

        /// Cancel a task.
        let cancel (taskId: Types.TaskId) =
            let mutable req = Unchecked.defaultof<TasksCancelRequest>
            req <- { req with TaskId = taskId }
            req

        /// Get task information.
        let get (taskId: Types.Id) =
            let mutable req = Unchecked.defaultof<TasksGetRequest>
            req <- { req with TaskId = taskId }
            req

        /// Get all tasks.
        let list () =
            Unchecked.defaultof<TasksListRequest>

    module TextStructure =

        /// Find the structure of a text field.
        let findFieldStructure () =
            Unchecked.defaultof<TextStructureFindFieldStructureRequest>

        /// Find the structure of text messages.
        let findMessageStructure () =
            Unchecked.defaultof<TextStructureFindMessageStructureRequest>

        /// Test a Grok pattern.
        let testGrokPattern () =
            Unchecked.defaultof<TextStructureTestGrokPatternRequest>

    module Transform =

        /// Delete a transform.
        let deleteTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformDeleteTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Get node stats.
        let getNodeStats () : TransformGetNodeStatsRequest =
            Unchecked.defaultof<TransformGetNodeStatsRequest>

        /// Get transforms.
        let getTransform (transformId: Types.Names) =
            let mutable req = Unchecked.defaultof<TransformGetTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Get transform stats.
        let getTransformStats (transformId: Types.Names) =
            let mutable req = Unchecked.defaultof<TransformGetTransformStatsRequest>
            req <- { req with TransformId = transformId }
            req

        /// Preview a transform.
        let previewTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformPreviewTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Create a transform.
        let putTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformPutTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Reset a transform.
        let resetTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformResetTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Schedule a transform to start now.
        let scheduleNowTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformScheduleNowTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Set upgrade_mode for transform indices.
        let setUpgradeMode () =
            Unchecked.defaultof<TransformSetUpgradeModeRequest>

        /// Start a transform.
        let startTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformStartTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Stop transforms.
        let stopTransform (transformId: Types.Name) =
            let mutable req = Unchecked.defaultof<TransformStopTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Update a transform.
        let updateTransform (transformId: Types.Id) =
            let mutable req = Unchecked.defaultof<TransformUpdateTransformRequest>
            req <- { req with TransformId = transformId }
            req

        /// Upgrade all transforms.
        let upgradeTransforms () =
            Unchecked.defaultof<TransformUpgradeTransformsRequest>

    module Watcher =

        /// Acknowledge a watch.
        let ackWatch (watchId: Types.Name) (actionId: Types.Names) =
            let mutable req = Unchecked.defaultof<WatcherAckWatchRequest>
            req <- { req with WatchId = watchId }
            req <- { req with ActionId = actionId }
            req

        /// Activate a watch.
        let activateWatch (watchId: Types.Name) =
            let mutable req = Unchecked.defaultof<WatcherActivateWatchRequest>
            req <- { req with WatchId = watchId }
            req

        /// Deactivate a watch.
        let deactivateWatch (watchId: Types.Name) =
            let mutable req = Unchecked.defaultof<WatcherDeactivateWatchRequest>
            req <- { req with WatchId = watchId }
            req

        /// Delete a watch.
        let deleteWatch (id: Types.Name) =
            let mutable req = Unchecked.defaultof<WatcherDeleteWatchRequest>
            req <- { req with Id = id }
            req

        /// Run a watch.
        let executeWatch (id: Types.Id) =
            let mutable req = Unchecked.defaultof<WatcherExecuteWatchRequest>
            req <- { req with Id = id }
            req

        /// Get Watcher index settings.
        let getSettings () =
            Unchecked.defaultof<WatcherGetSettingsRequest>

        /// Get a watch.
        let getWatch (id: Types.Name) =
            let mutable req = Unchecked.defaultof<WatcherGetWatchRequest>
            req <- { req with Id = id }
            req

        /// Create or update a watch.
        let putWatch (id: Types.Id) =
            let mutable req = Unchecked.defaultof<WatcherPutWatchRequest>
            req <- { req with Id = id }
            req

        /// Query watches.
        let queryWatches () =
            Unchecked.defaultof<WatcherQueryWatchesRequest>

        /// Start the watch service.
        let start () =
            Unchecked.defaultof<WatcherStartRequest>

        /// Get Watcher statistics.
        let stats (metric: System.Text.Json.JsonElement) =
            let mutable req = Unchecked.defaultof<WatcherStatsRequest>
            req <- { req with Metric = metric }
            req

        /// Stop the watch service.
        let stop () =
            Unchecked.defaultof<WatcherStopRequest>

        /// Update Watcher index settings.
        let updateSettings () =
            Unchecked.defaultof<WatcherUpdateSettingsRequest>

    module Xpack =

        /// Get information.
        let info () =
            Unchecked.defaultof<XpackInfoRequest>

        /// Get usage information.
        let usage () =
            Unchecked.defaultof<XpackUsageRequest>

