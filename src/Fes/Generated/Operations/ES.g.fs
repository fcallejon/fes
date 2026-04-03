// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open Fes

module ES =

    let inline send (client: System.Net.Http.HttpClient) (request: ^T) =
        let arrow =
            client.SendAsync >> TaskResult.ofTask
            |> ElasticsearchClient.execute
        arrow request

    module AsyncSearch =

        /// Delete an async search.
        let delete (id: Types.Id) =
            let req = { Unchecked.defaultof<AsyncSearchDeleteRequest> with
                Id = id
            }
            req

        /// Get async search results.
        let get (id: Types.Id) =
            let req = { Unchecked.defaultof<AsyncSearchGetRequest> with
                Id = id
            }
            req

        /// Get the async search status.
        let status (id: Types.Id) =
            let req = { Unchecked.defaultof<AsyncSearchStatusRequest> with
                Id = id
            }
            req

        /// Run an async search.
        let submit (index: Types.Indices) =
            let req = { Unchecked.defaultof<AsyncSearchSubmitRequest> with
                Index = index
            }
            req

    module Autoscaling =

        /// Delete an autoscaling policy.
        let deleteAutoscalingPolicy (name: Types.Name) =
            let req = { Unchecked.defaultof<AutoscalingDeleteAutoscalingPolicyRequest> with
                Name = name
            }
            req

        /// Get the autoscaling capacity.
        let getAutoscalingCapacity () =
            Unchecked.defaultof<AutoscalingGetAutoscalingCapacityRequest>

        /// Get an autoscaling policy.
        let getAutoscalingPolicy (name: Types.Name) =
            let req = { Unchecked.defaultof<AutoscalingGetAutoscalingPolicyRequest> with
                Name = name
            }
            req

        /// Create or update an autoscaling policy.
        let putAutoscalingPolicy (name: Types.Name) =
            let req = { Unchecked.defaultof<AutoscalingPutAutoscalingPolicyRequest> with
                Name = name
            }
            req

    /// Bulk index or delete documents.
    let bulk (index: Types.IndexName) =
        { Unchecked.defaultof<BulkRequest> with
            Index = index
        }

    /// Checks if the specified combination of method, API, parameters, and arbitrary capabilities are supported.
    let capabilities  =
        { Unchecked.defaultof<CapabilitiesRequest> with
        }

    /// Clear a scrolling search.
    let clearScroll (scrollId: Types.ScrollIds) =
        { Unchecked.defaultof<ClearScrollRequest> with
            ScrollId = scrollId
        }

    /// Close a point in time.
    let closePointInTime  =
        { Unchecked.defaultof<ClosePointInTimeRequest> with
        }

    /// Count search results.
    let count (index: Types.Indices) =
        { Unchecked.defaultof<CountRequest> with
            Index = index
        }

    /// Create a new document in the index.
    let create (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<CreateRequest> with
            Id = id
            Index = index
        }

    /// Delete a document.
    let delete (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<DeleteRequest> with
            Id = id
            Index = index
        }

    /// Delete documents.
    let deleteByQuery (index: Types.Indices) =
        { Unchecked.defaultof<DeleteByQueryRequest> with
            Index = index
        }

    /// Throttle a delete by query operation.
    let deleteByQueryRethrottle (taskId: Types.TaskId) =
        { Unchecked.defaultof<DeleteByQueryRethrottleRequest> with
            TaskId = taskId
        }

    /// Delete a script or search template.
    let deleteScript (id: Types.Id) =
        { Unchecked.defaultof<DeleteScriptRequest> with
            Id = id
        }

    /// Check a document.
    let exists (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<ExistsRequest> with
            Id = id
            Index = index
        }

    /// Check for a document source.
    let existsSource (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<ExistsSourceRequest> with
            Id = id
            Index = index
        }

    /// Explain a document match result.
    let explain (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<ExplainRequest> with
            Id = id
            Index = index
        }

    /// Get the field capabilities.
    let fieldCaps (index: Types.Indices) =
        { Unchecked.defaultof<FieldCapsRequest> with
            Index = index
        }

    /// Get a document by its ID.
    let get (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<GetRequest> with
            Id = id
            Index = index
        }

    /// Get a script or search template.
    let getScript (id: Types.Id) =
        { Unchecked.defaultof<GetScriptRequest> with
            Id = id
        }

    /// Get script contexts.
    let getScriptContext  : GetScriptContextRequest =
        {
        }

    /// Get script languages.
    let getScriptLanguages  : GetScriptLanguagesRequest =
        {
        }

    /// Get a document's source.
    let getSource (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<GetSourceRequest> with
            Id = id
            Index = index
        }

    /// Get the cluster health.
    let healthReport (feature: System.Text.Json.JsonElement) =
        { Unchecked.defaultof<HealthReportRequest> with
            Feature = feature
        }

    /// Create or update a document in an index.
    let index (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<IndexRequest> with
            Id = id
            Index = index
        }

    /// Get cluster info.
    let info  : InfoRequest =
        {
        }

    /// Run a knn search.
    let knnSearch (index: Types.Indices) =
        { Unchecked.defaultof<KnnSearchRequest> with
            Index = index
        }

    /// Get multiple documents.
    let mget (index: Types.IndexName) =
        { Unchecked.defaultof<MgetRequest> with
            Index = index
        }

    /// Run multiple searches.
    let msearch (index: Types.Indices) =
        { Unchecked.defaultof<MsearchRequest> with
            Index = index
        }

    /// Run multiple templated searches.
    let msearchTemplate (index: Types.Indices) =
        { Unchecked.defaultof<MsearchTemplateRequest> with
            Index = index
        }

    /// Get multiple term vectors.
    let mtermvectors (index: Types.IndexName) =
        { Unchecked.defaultof<MtermvectorsRequest> with
            Index = index
        }

    /// Open a point in time.
    let openPointInTime (index: Types.Indices) =
        { Unchecked.defaultof<OpenPointInTimeRequest> with
            Index = index
        }

    /// Ping the cluster.
    let ping  : PingRequest =
        {
        }

    /// Create or update a script or search template.
    let putScript (id: Types.Id) (context: Types.Name) =
        { Unchecked.defaultof<PutScriptRequest> with
            Id = id
            Context = context
        }

    /// Evaluate ranked search results.
    let rankEval (index: Types.Indices) =
        { Unchecked.defaultof<RankEvalRequest> with
            Index = index
        }

    /// Reindex documents.
    let reindex  =
        { Unchecked.defaultof<ReindexRequest> with
        }

    /// Throttle a reindex operation.
    let reindexRethrottle (taskId: Types.Id) =
        { Unchecked.defaultof<ReindexRethrottleRequest> with
            TaskId = taskId
        }

    /// Render a search template.
    let renderSearchTemplate (id: Types.Id) =
        { Unchecked.defaultof<RenderSearchTemplateRequest> with
            Id = id
        }

    /// Run a script.
    let scriptsPainlessExecute  =
        { Unchecked.defaultof<ScriptsPainlessExecuteRequest> with
        }

    /// Run a scrolling search.
    let scroll (scrollId: Types.ScrollId) =
        { Unchecked.defaultof<ScrollRequest> with
            ScrollId = scrollId
        }

    /// Run a search.
    let search (index: Types.Indices) =
        { Unchecked.defaultof<SearchRequest> with
            Index = index
        }

    /// Search a vector tile.
    let searchMvt (index: Types.Indices) (field: Types.Field) (zoom: GlobalSearchMvtTypes.ZoomLevel) (x: GlobalSearchMvtTypes.Coordinate) (y: GlobalSearchMvtTypes.Coordinate) =
        { Unchecked.defaultof<SearchMvtRequest> with
            Index = index
            Field = field
            Zoom = zoom
            X = x
            Y = y
        }

    /// Get the search shards.
    let searchShards (index: Types.Indices) =
        { Unchecked.defaultof<SearchShardsRequest> with
            Index = index
        }

    /// Run a search with a search template.
    let searchTemplate (index: Types.Indices) =
        { Unchecked.defaultof<SearchTemplateRequest> with
            Index = index
        }

    /// Get terms in an index.
    let termsEnum (index: Types.Indices) =
        { Unchecked.defaultof<TermsEnumRequest> with
            Index = index
        }

    /// Get term vector information.
    let termvectors (index: Types.IndexName) (id: Types.Id) =
        { Unchecked.defaultof<TermvectorsRequest> with
            Index = index
            Id = id
        }

    /// Update a document.
    let update (id: Types.Id) (index: Types.IndexName) =
        { Unchecked.defaultof<UpdateRequest> with
            Id = id
            Index = index
        }

    /// Update documents.
    let updateByQuery (index: Types.Indices) =
        { Unchecked.defaultof<UpdateByQueryRequest> with
            Index = index
        }

    /// Throttle an update by query operation.
    let updateByQueryRethrottle (taskId: Types.Id) =
        { Unchecked.defaultof<UpdateByQueryRethrottleRequest> with
            TaskId = taskId
        }

    module Cat =

        /// Get aliases.
        let aliases (name: Types.Names) =
            let req = { Unchecked.defaultof<CatAliasesRequest> with
                Name = name
            }
            req

        /// Get shard allocation information.
        let allocation (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<CatAllocationRequest> with
                NodeId = nodeId
            }
            req

        /// Get circuit breakers statistics.
        let circuitBreaker (circuitBreakerPatterns: System.Text.Json.JsonElement) =
            let req = { Unchecked.defaultof<CatCircuitBreakerRequest> with
                CircuitBreakerPatterns = circuitBreakerPatterns
            }
            req

        /// Get component templates.
        let componentTemplates (name: string) =
            let req = { Unchecked.defaultof<CatComponentTemplatesRequest> with
                Name = name
            }
            req

        /// Get a document count.
        let count (index: Types.Indices) =
            let req = { Unchecked.defaultof<CatCountRequest> with
                Index = index
            }
            req

        /// Get field data cache information.
        let fielddata (fields: Types.Fields) =
            let req = { Unchecked.defaultof<CatFielddataRequest> with
                Fields = fields
            }
            req

        /// Get the cluster health status.
        let health () =
            Unchecked.defaultof<CatHealthRequest>

        /// Get CAT help.
        let help () : CatHelpRequest =
            Unchecked.defaultof<CatHelpRequest>

        /// Get index information.
        let indices (index: Types.Indices) =
            let req = { Unchecked.defaultof<CatIndicesRequest> with
                Index = index
            }
            req

        /// Get master node information.
        let master () =
            Unchecked.defaultof<CatMasterRequest>

        /// Get data frame analytics jobs.
        let mlDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<CatMlDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Get datafeeds.
        let mlDatafeeds (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<CatMlDatafeedsRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Get anomaly detection jobs.
        let mlJobs (jobId: Types.Id) =
            let req = { Unchecked.defaultof<CatMlJobsRequest> with
                JobId = jobId
            }
            req

        /// Get trained models.
        let mlTrainedModels (modelId: Types.Id) =
            let req = { Unchecked.defaultof<CatMlTrainedModelsRequest> with
                ModelId = modelId
            }
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
            let req = { Unchecked.defaultof<CatRecoveryRequest> with
                Index = index
            }
            req

        /// Get snapshot repository information.
        let repositories () =
            Unchecked.defaultof<CatRepositoriesRequest>

        /// Get segment information.
        let segments (index: Types.Indices) =
            let req = { Unchecked.defaultof<CatSegmentsRequest> with
                Index = index
            }
            req

        /// Get shard information.
        let shards (index: Types.Indices) =
            let req = { Unchecked.defaultof<CatShardsRequest> with
                Index = index
            }
            req

        /// Get snapshot information.
        let snapshots (repository: Types.Names) =
            let req = { Unchecked.defaultof<CatSnapshotsRequest> with
                Repository = repository
            }
            req

        /// Get task information.
        let tasks () =
            Unchecked.defaultof<CatTasksRequest>

        /// Get index template information.
        let templates (name: Types.Name) =
            let req = { Unchecked.defaultof<CatTemplatesRequest> with
                Name = name
            }
            req

        /// Get thread pool statistics.
        let threadPool (threadPoolPatterns: Types.Names) =
            let req = { Unchecked.defaultof<CatThreadPoolRequest> with
                ThreadPoolPatterns = threadPoolPatterns
            }
            req

        /// Get transform information.
        let transforms (transformId: Types.Id) =
            let req = { Unchecked.defaultof<CatTransformsRequest> with
                TransformId = transformId
            }
            req

    module Ccr =

        /// Delete auto-follow patterns.
        let deleteAutoFollowPattern (name: Types.Name) =
            let req = { Unchecked.defaultof<CcrDeleteAutoFollowPatternRequest> with
                Name = name
            }
            req

        /// Create a follower.
        let follow (index: Types.IndexName) =
            let req = { Unchecked.defaultof<CcrFollowRequest> with
                Index = index
            }
            req

        /// Get follower information.
        let followInfo (index: Types.Indices) =
            let req = { Unchecked.defaultof<CcrFollowInfoRequest> with
                Index = index
            }
            req

        /// Get follower stats.
        let followStats (index: Types.Indices) =
            let req = { Unchecked.defaultof<CcrFollowStatsRequest> with
                Index = index
            }
            req

        /// Forget a follower.
        let forgetFollower (index: Types.IndexName) =
            let req = { Unchecked.defaultof<CcrForgetFollowerRequest> with
                Index = index
            }
            req

        /// Get auto-follow patterns.
        let getAutoFollowPattern (name: Types.Name) =
            let req = { Unchecked.defaultof<CcrGetAutoFollowPatternRequest> with
                Name = name
            }
            req

        /// Pause an auto-follow pattern.
        let pauseAutoFollowPattern (name: Types.Name) =
            let req = { Unchecked.defaultof<CcrPauseAutoFollowPatternRequest> with
                Name = name
            }
            req

        /// Pause a follower.
        let pauseFollow (index: Types.IndexName) =
            let req = { Unchecked.defaultof<CcrPauseFollowRequest> with
                Index = index
            }
            req

        /// Create or update auto-follow patterns.
        let putAutoFollowPattern (name: Types.Name) =
            let req = { Unchecked.defaultof<CcrPutAutoFollowPatternRequest> with
                Name = name
            }
            req

        /// Resume an auto-follow pattern.
        let resumeAutoFollowPattern (name: Types.Name) =
            let req = { Unchecked.defaultof<CcrResumeAutoFollowPatternRequest> with
                Name = name
            }
            req

        /// Resume a follower.
        let resumeFollow (index: Types.IndexName) =
            let req = { Unchecked.defaultof<CcrResumeFollowRequest> with
                Index = index
            }
            req

        /// Get cross-cluster replication stats.
        let stats () =
            Unchecked.defaultof<CcrStatsRequest>

        /// Unfollow an index.
        let unfollow (index: Types.IndexName) =
            let req = { Unchecked.defaultof<CcrUnfollowRequest> with
                Index = index
            }
            req

    module Cluster =

        /// Explain the shard allocations.
        let allocationExplain () =
            Unchecked.defaultof<ClusterAllocationExplainRequest>

        /// Delete component templates.
        let deleteComponentTemplate (name: Types.Names) =
            let req = { Unchecked.defaultof<ClusterDeleteComponentTemplateRequest> with
                Name = name
            }
            req

        /// Clear cluster voting config exclusions.
        let deleteVotingConfigExclusions () =
            Unchecked.defaultof<ClusterDeleteVotingConfigExclusionsRequest>

        /// Check component templates.
        let existsComponentTemplate (name: Types.Names) =
            let req = { Unchecked.defaultof<ClusterExistsComponentTemplateRequest> with
                Name = name
            }
            req

        /// Get component templates.
        let getComponentTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<ClusterGetComponentTemplateRequest> with
                Name = name
            }
            req

        /// Get cluster-wide settings.
        let getSettings () =
            Unchecked.defaultof<ClusterGetSettingsRequest>

        /// Get the cluster health status.
        let health (index: Types.Indices) =
            let req = { Unchecked.defaultof<ClusterHealthRequest> with
                Index = index
            }
            req

        /// Get cluster info.
        let info (target: Types.ClusterInfoTargets) =
            let req = { Unchecked.defaultof<ClusterInfoRequest> with
                Target = target
            }
            req

        /// Get the pending cluster tasks.
        let pendingTasks () =
            Unchecked.defaultof<ClusterPendingTasksRequest>

        /// Update voting configuration exclusions.
        let postVotingConfigExclusions () =
            Unchecked.defaultof<ClusterPostVotingConfigExclusionsRequest>

        /// Create or update a component template.
        let putComponentTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<ClusterPutComponentTemplateRequest> with
                Name = name
            }
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
        let state (metric: ClusterState.ClusterStateMetrics) (index: Types.Indices) =
            let req = { Unchecked.defaultof<ClusterStateRequest> with
                Metric = metric
                Index = index
            }
            req

        /// Get cluster statistics.
        let stats (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<ClusterStatsRequest> with
                NodeId = nodeId
            }
            req

    module Connector =

        /// Check in a connector.
        let checkIn (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorCheckInRequest> with
                ConnectorId = connectorId
            }
            req

        /// Delete a connector.
        let delete (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorDeleteRequest> with
                ConnectorId = connectorId
            }
            req

        /// Get a connector.
        let get (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorGetRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector last sync stats.
        let lastSync (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorLastSyncRequest> with
                ConnectorId = connectorId
            }
            req

        /// Get all connectors.
        let list () =
            Unchecked.defaultof<ConnectorListRequest>

        /// Create a connector.
        let post () =
            Unchecked.defaultof<ConnectorPostRequest>

        /// Create or update a connector.
        let put (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorPutRequest> with
                ConnectorId = connectorId
            }
            req

        /// Deletes a connector secret.
        let secretDelete (id: string) =
            let req = { Unchecked.defaultof<ConnectorSecretDeleteRequest> with
                Id = id
            }
            req

        /// Retrieves a secret stored by Connectors.
        let secretGet (id: string) =
            let req = { Unchecked.defaultof<ConnectorSecretGetRequest> with
                Id = id
            }
            req

        /// Creates a secret for a Connector.
        let secretPost () =
            Unchecked.defaultof<ConnectorSecretPostRequest>

        /// Creates or updates a secret for a Connector.
        let secretPut (id: string) =
            let req = { Unchecked.defaultof<ConnectorSecretPutRequest> with
                Id = id
            }
            req

        /// Cancel a connector sync job.
        let syncJobCancel (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobCancelRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Check in a connector sync job.
        let syncJobCheckIn (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobCheckInRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Claim a connector sync job.
        let syncJobClaim (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobClaimRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Delete a connector sync job.
        let syncJobDelete (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobDeleteRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Set a connector sync job error.
        let syncJobError (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobErrorRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Get a connector sync job.
        let syncJobGet (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobGetRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Get all connector sync jobs.
        let syncJobList () =
            Unchecked.defaultof<ConnectorSyncJobListRequest>

        /// Create a connector sync job.
        let syncJobPost () =
            Unchecked.defaultof<ConnectorSyncJobPostRequest>

        /// Set the connector sync job stats.
        let syncJobUpdateStats (connectorSyncJobId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorSyncJobUpdateStatsRequest> with
                ConnectorSyncJobId = connectorSyncJobId
            }
            req

        /// Activate the connector draft filter.
        let updateActiveFiltering (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateActiveFilteringRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector API key ID.
        let updateApiKeyId (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateApiKeyIdRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector configuration.
        let updateConfiguration (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateConfigurationRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector error field.
        let updateError (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateErrorRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector features.
        let updateFeatures (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateFeaturesRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector filtering.
        let updateFiltering (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateFilteringRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector draft filtering validation.
        let updateFilteringValidation (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateFilteringValidationRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector index name.
        let updateIndexName (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateIndexNameRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector name and description.
        let updateName (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateNameRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector is_native flag.
        let updateNative (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateNativeRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector pipeline.
        let updatePipeline (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdatePipelineRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector scheduling.
        let updateScheduling (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateSchedulingRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector service type.
        let updateServiceType (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateServiceTypeRequest> with
                ConnectorId = connectorId
            }
            req

        /// Update the connector status.
        let updateStatus (connectorId: Types.Id) =
            let req = { Unchecked.defaultof<ConnectorUpdateStatusRequest> with
                ConnectorId = connectorId
            }
            req

    module DanglingIndices =

        /// Delete a dangling index.
        let deleteDanglingIndex (indexUuid: Types.Uuid) =
            let req = { Unchecked.defaultof<DanglingIndicesDeleteDanglingIndexRequest> with
                IndexUuid = indexUuid
            }
            req

        /// Import a dangling index.
        let importDanglingIndex (indexUuid: Types.Uuid) =
            let req = { Unchecked.defaultof<DanglingIndicesImportDanglingIndexRequest> with
                IndexUuid = indexUuid
            }
            req

        /// Get the dangling indices.
        let listDanglingIndices () : DanglingIndicesListDanglingIndicesRequest =
            Unchecked.defaultof<DanglingIndicesListDanglingIndicesRequest>

    module Enrich =

        /// Delete an enrich policy.
        let deletePolicy (name: Types.Name) =
            let req = { Unchecked.defaultof<EnrichDeletePolicyRequest> with
                Name = name
            }
            req

        /// Run an enrich policy.
        let executePolicy (name: Types.Name) =
            let req = { Unchecked.defaultof<EnrichExecutePolicyRequest> with
                Name = name
            }
            req

        /// Get an enrich policy.
        let getPolicy (name: Types.Names) =
            let req = { Unchecked.defaultof<EnrichGetPolicyRequest> with
                Name = name
            }
            req

        /// Create an enrich policy.
        let putPolicy (name: Types.Name) =
            let req = { Unchecked.defaultof<EnrichPutPolicyRequest> with
                Name = name
            }
            req

        /// Get enrich stats.
        let stats () =
            Unchecked.defaultof<EnrichStatsRequest>

    module Eql =

        /// Delete an async EQL search.
        let delete (id: Types.Id) =
            let req = { Unchecked.defaultof<EqlDeleteRequest> with
                Id = id
            }
            req

        /// Get async EQL search results.
        let get (id: Types.Id) =
            let req = { Unchecked.defaultof<EqlGetRequest> with
                Id = id
            }
            req

        /// Get the async EQL status.
        let getStatus (id: Types.Id) =
            let req = { Unchecked.defaultof<EqlGetStatusRequest> with
                Id = id
            }
            req

        /// Get EQL search results.
        let search (index: Types.Indices) =
            let req = { Unchecked.defaultof<EqlSearchRequest> with
                Index = index
            }
            req

    module Esql =

        /// Run an async ES|QL query.
        let asyncQuery () =
            Unchecked.defaultof<EsqlAsyncQueryRequest>

        /// Delete an async ES|QL query.
        let asyncQueryDelete (id: Types.Id) =
            let req = { Unchecked.defaultof<EsqlAsyncQueryDeleteRequest> with
                Id = id
            }
            req

        /// Get async ES|QL query results.
        let asyncQueryGet (id: Types.Id) =
            let req = { Unchecked.defaultof<EsqlAsyncQueryGetRequest> with
                Id = id
            }
            req

        /// Stop async ES|QL query.
        let asyncQueryStop (id: Types.Id) =
            let req = { Unchecked.defaultof<EsqlAsyncQueryStopRequest> with
                Id = id
            }
            req

        /// Delete an ES|QL view.
        let deleteView (name: Types.Id) =
            let req = { Unchecked.defaultof<EsqlDeleteViewRequest> with
                Name = name
            }
            req

        /// Get a specific running ES|QL query information.
        let getQuery (id: Types.Id) =
            let req = { Unchecked.defaultof<EsqlGetQueryRequest> with
                Id = id
            }
            req

        /// Get an ES|QL view.
        let getView (name: Types.Id) =
            let req = { Unchecked.defaultof<EsqlGetViewRequest> with
                Name = name
            }
            req

        /// Get running ES|QL queries information.
        let listQueries () : EsqlListQueriesRequest =
            Unchecked.defaultof<EsqlListQueriesRequest>

        /// Create or update an ES|QL view.
        let putView (name: Types.Id) =
            let req = { Unchecked.defaultof<EsqlPutViewRequest> with
                Name = name
            }
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
            let req = { Unchecked.defaultof<FleetDeleteSecretRequest> with
                Id = id
            }
            req

        /// Retrieves a secret stored by Fleet.
        let getSecret (id: string) =
            let req = { Unchecked.defaultof<FleetGetSecretRequest> with
                Id = id
            }
            req

        /// Get global checkpoints.
        let globalCheckpoints (index: System.Text.Json.JsonElement) =
            let req = { Unchecked.defaultof<FleetGlobalCheckpointsRequest> with
                Index = index
            }
            req

        /// Run multiple Fleet searches.
        let msearch (index: System.Text.Json.JsonElement) =
            let req = { Unchecked.defaultof<FleetMsearchRequest> with
                Index = index
            }
            req

        /// Creates a secret stored by Fleet.
        let postSecret () =
            Unchecked.defaultof<FleetPostSecretRequest>

        /// Run a Fleet search.
        let search (index: System.Text.Json.JsonElement) =
            let req = { Unchecked.defaultof<FleetSearchRequest> with
                Index = index
            }
            req

    module Graph =

        /// Explore graph analytics.
        let explore (index: Types.Indices) =
            let req = { Unchecked.defaultof<GraphExploreRequest> with
                Index = index
            }
            req

    module Ilm =

        /// Delete a lifecycle policy.
        let deleteLifecycle (policy: Types.Name) =
            let req = { Unchecked.defaultof<IlmDeleteLifecycleRequest> with
                Policy = policy
            }
            req

        /// Explain the lifecycle state.
        let explainLifecycle (index: Types.IndexName) =
            let req = { Unchecked.defaultof<IlmExplainLifecycleRequest> with
                Index = index
            }
            req

        /// Get lifecycle policies.
        let getLifecycle (policy: Types.Name) =
            let req = { Unchecked.defaultof<IlmGetLifecycleRequest> with
                Policy = policy
            }
            req

        /// Get the ILM status.
        let getStatus () : IlmGetStatusRequest =
            Unchecked.defaultof<IlmGetStatusRequest>

        /// Migrate to data tiers routing.
        let migrateToDataTiers () =
            Unchecked.defaultof<IlmMigrateToDataTiersRequest>

        /// Move to a lifecycle step.
        let moveToStep (index: Types.IndexName) =
            let req = { Unchecked.defaultof<IlmMoveToStepRequest> with
                Index = index
            }
            req

        /// Create or update a lifecycle policy.
        let putLifecycle (policy: Types.Name) =
            let req = { Unchecked.defaultof<IlmPutLifecycleRequest> with
                Policy = policy
            }
            req

        /// Remove policies from an index.
        let removePolicy (index: Types.IndexName) =
            let req = { Unchecked.defaultof<IlmRemovePolicyRequest> with
                Index = index
            }
            req

        /// Retry a policy.
        let retry (index: Types.IndexName) =
            let req = { Unchecked.defaultof<IlmRetryRequest> with
                Index = index
            }
            req

        /// Start the ILM plugin.
        let start () =
            Unchecked.defaultof<IlmStartRequest>

        /// Stop the ILM plugin.
        let stop () =
            Unchecked.defaultof<IlmStopRequest>

    module Indices =

        /// Add an index block.
        let addBlock (index: Types.Indices) (block: IndicesTypes.IndicesBlockOptions) =
            let req = { Unchecked.defaultof<IndicesAddBlockRequest> with
                Index = index
                Block = block
            }
            req

        /// Get tokens from text analysis.
        let analyze (index: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesAnalyzeRequest> with
                Index = index
            }
            req

        /// Cancel a migration reindex operation.
        let cancelMigrateReindex (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesCancelMigrateReindexRequest> with
                Index = index
            }
            req

        /// Clear the cache.
        let clearCache (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesClearCacheRequest> with
                Index = index
            }
            req

        /// Clone an index.
        let clone (index: Types.IndexName) (target: Types.Name) =
            let req = { Unchecked.defaultof<IndicesCloneRequest> with
                Index = index
                Target = target
            }
            req

        /// Close an index.
        let close (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesCloseRequest> with
                Index = index
            }
            req

        /// Create an index.
        let create (index: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesCreateRequest> with
                Index = index
            }
            req

        /// Create a data stream.
        let createDataStream (name: Types.DataStreamName) =
            let req = { Unchecked.defaultof<IndicesCreateDataStreamRequest> with
                Name = name
            }
            req

        /// Create an index from a source index.
        let createFrom (source: Types.IndexName) (dest: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesCreateFromRequest> with
                Source = source
                Dest = dest
            }
            req

        /// Get data stream stats.
        let dataStreamsStats (name: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesDataStreamsStatsRequest> with
                Name = name
            }
            req

        /// Delete indices.
        let delete (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesDeleteRequest> with
                Index = index
            }
            req

        /// Delete an alias.
        let deleteAlias (index: Types.Indices) (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesDeleteAliasRequest> with
                Index = index
                Name = name
            }
            req

        /// Delete data stream lifecycles.
        let deleteDataLifecycle (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesDeleteDataLifecycleRequest> with
                Name = name
            }
            req

        /// Delete data streams.
        let deleteDataStream (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesDeleteDataStreamRequest> with
                Name = name
            }
            req

        /// Delete data stream options.
        let deleteDataStreamOptions (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesDeleteDataStreamOptionsRequest> with
                Name = name
            }
            req

        /// Delete an index template.
        let deleteIndexTemplate (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesDeleteIndexTemplateRequest> with
                Name = name
            }
            req

        /// Delete a legacy index template.
        let deleteTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesDeleteTemplateRequest> with
                Name = name
            }
            req

        /// Analyze the index disk usage.
        let diskUsage (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesDiskUsageRequest> with
                Index = index
            }
            req

        /// Downsample an index.
        let downsample (index: Types.IndexName) (targetIndex: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesDownsampleRequest> with
                Index = index
                TargetIndex = targetIndex
            }
            req

        /// Check indices.
        let exists (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesExistsRequest> with
                Index = index
            }
            req

        /// Check aliases.
        let existsAlias (name: Types.Names) (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesExistsAliasRequest> with
                Name = name
                Index = index
            }
            req

        /// Check index templates.
        let existsIndexTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesExistsIndexTemplateRequest> with
                Name = name
            }
            req

        /// Check existence of index templates.
        let existsTemplate (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesExistsTemplateRequest> with
                Name = name
            }
            req

        /// Get the status for a data stream lifecycle.
        let explainDataLifecycle (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesExplainDataLifecycleRequest> with
                Index = index
            }
            req

        /// Get field usage stats.
        let fieldUsageStats (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesFieldUsageStatsRequest> with
                Index = index
            }
            req

        /// Flush data streams or indices.
        let flush (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesFlushRequest> with
                Index = index
            }
            req

        /// Force a merge.
        let forcemerge (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesForcemergeRequest> with
                Index = index
            }
            req

        /// Get index information.
        let get (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetRequest> with
                Index = index
            }
            req

        /// Get aliases.
        let getAlias (name: Types.Names) (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetAliasRequest> with
                Name = name
                Index = index
            }
            req

        /// Get data stream lifecycles.
        let getDataLifecycle (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesGetDataLifecycleRequest> with
                Name = name
            }
            req

        /// Get data stream lifecycle stats.
        let getDataLifecycleStats () : IndicesGetDataLifecycleStatsRequest =
            Unchecked.defaultof<IndicesGetDataLifecycleStatsRequest>

        /// Get data streams.
        let getDataStream (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesGetDataStreamRequest> with
                Name = name
            }
            req

        /// Get data stream mappings.
        let getDataStreamMappings (name: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetDataStreamMappingsRequest> with
                Name = name
            }
            req

        /// Get data stream options.
        let getDataStreamOptions (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesGetDataStreamOptionsRequest> with
                Name = name
            }
            req

        /// Get data stream settings.
        let getDataStreamSettings (name: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetDataStreamSettingsRequest> with
                Name = name
            }
            req

        /// Get mapping definitions.
        let getFieldMapping (fields: Types.Fields) (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetFieldMappingRequest> with
                Fields = fields
                Index = index
            }
            req

        /// Get index templates.
        let getIndexTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesGetIndexTemplateRequest> with
                Name = name
            }
            req

        /// Get mapping definitions.
        let getMapping (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetMappingRequest> with
                Index = index
            }
            req

        /// Get the migration reindexing status.
        let getMigrateReindexStatus (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesGetMigrateReindexStatusRequest> with
                Index = index
            }
            req

        /// Get index settings.
        let getSettings (index: Types.Indices) (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesGetSettingsRequest> with
                Index = index
                Name = name
            }
            req

        /// Get legacy index templates.
        let getTemplate (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesGetTemplateRequest> with
                Name = name
            }
            req

        /// Reindex legacy backing indices.
        let migrateReindex () =
            Unchecked.defaultof<IndicesMigrateReindexRequest>

        /// Convert an index alias to a data stream.
        let migrateToDataStream (name: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesMigrateToDataStreamRequest> with
                Name = name
            }
            req

        /// Update data streams.
        let modifyDataStream () =
            Unchecked.defaultof<IndicesModifyDataStreamRequest>

        /// Open a closed index.
        let open' (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesOpenRequest> with
                Index = index
            }
            req

        /// Promote a data stream.
        let promoteDataStream (name: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesPromoteDataStreamRequest> with
                Name = name
            }
            req

        /// Create or update an alias.
        let putAlias (index: Types.Indices) (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesPutAliasRequest> with
                Index = index
                Name = name
            }
            req

        /// Update data stream lifecycles.
        let putDataLifecycle (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesPutDataLifecycleRequest> with
                Name = name
            }
            req

        /// Update data stream mappings.
        let putDataStreamMappings (name: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesPutDataStreamMappingsRequest> with
                Name = name
            }
            req

        /// Update data stream options.
        let putDataStreamOptions (name: Types.DataStreamNames) =
            let req = { Unchecked.defaultof<IndicesPutDataStreamOptionsRequest> with
                Name = name
            }
            req

        /// Update data stream settings.
        let putDataStreamSettings (name: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesPutDataStreamSettingsRequest> with
                Name = name
            }
            req

        /// Create or update an index template.
        let putIndexTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesPutIndexTemplateRequest> with
                Name = name
            }
            req

        /// Update field mappings.
        let putMapping (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesPutMappingRequest> with
                Index = index
            }
            req

        /// Update index settings.
        let putSettings (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesPutSettingsRequest> with
                Index = index
            }
            req

        /// Create or update a legacy index template.
        let putTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesPutTemplateRequest> with
                Name = name
            }
            req

        /// Get index recovery information.
        let recovery (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesRecoveryRequest> with
                Index = index
            }
            req

        /// Refresh an index.
        let refresh (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesRefreshRequest> with
                Index = index
            }
            req

        /// Reload search analyzers.
        let reloadSearchAnalyzers (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesReloadSearchAnalyzersRequest> with
                Index = index
            }
            req

        /// Remove an index block.
        let removeBlock (index: Types.Indices) (block: IndicesTypes.IndicesBlockOptions) =
            let req = { Unchecked.defaultof<IndicesRemoveBlockRequest> with
                Index = index
                Block = block
            }
            req

        /// Resolve the cluster.
        let resolveCluster (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesResolveClusterRequest> with
                Name = name
            }
            req

        /// Resolve indices.
        let resolveIndex (name: Types.Names) =
            let req = { Unchecked.defaultof<IndicesResolveIndexRequest> with
                Name = name
            }
            req

        /// Roll over to a new index.
        let rollover (alias: Types.IndexAlias) (newIndex: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesRolloverRequest> with
                Alias = alias
                NewIndex = newIndex
            }
            req

        /// Get index segments.
        let segments (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesSegmentsRequest> with
                Index = index
            }
            req

        /// Get index shard stores.
        let shardStores (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesShardStoresRequest> with
                Index = index
            }
            req

        /// Shrink an index.
        let shrink (index: Types.IndexName) (target: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesShrinkRequest> with
                Index = index
                Target = target
            }
            req

        /// Simulate an index.
        let simulateIndexTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesSimulateIndexTemplateRequest> with
                Name = name
            }
            req

        /// Simulate an index template.
        let simulateTemplate (name: Types.Name) =
            let req = { Unchecked.defaultof<IndicesSimulateTemplateRequest> with
                Name = name
            }
            req

        /// Split an index.
        let split (index: Types.IndexName) (target: Types.IndexName) =
            let req = { Unchecked.defaultof<IndicesSplitRequest> with
                Index = index
                Target = target
            }
            req

        /// Get index statistics.
        let stats (metric: Types.CommonStatsFlags) (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesStatsRequest> with
                Metric = metric
                Index = index
            }
            req

        /// Create or update an alias.
        let updateAliases () =
            Unchecked.defaultof<IndicesUpdateAliasesRequest>

        /// Validate a query.
        let validateQuery (index: Types.Indices) =
            let req = { Unchecked.defaultof<IndicesValidateQueryRequest> with
                Index = index
            }
            req

    module Inference =

        /// Perform chat completion inference on the service.
        let chatCompletionUnified (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceChatCompletionUnifiedRequest> with
                InferenceId = inferenceId
            }
            req

        /// Perform completion inference on the service.
        let completion (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceCompletionRequest> with
                InferenceId = inferenceId
            }
            req

        /// Delete an inference endpoint.
        let delete (taskType: InferenceTypes.TaskType) (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceDeleteRequest> with
                TaskType = taskType
                InferenceId = inferenceId
            }
            req

        /// Perform dense embedding inference on the service.
        let embedding (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceEmbeddingRequest> with
                InferenceId = inferenceId
            }
            req

        /// Get an inference endpoint.
        let get (taskType: InferenceTypes.TaskType) (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceGetRequest> with
                TaskType = taskType
                InferenceId = inferenceId
            }
            req

        /// Perform inference on the service.
        let inference (taskType: InferenceTypes.TaskType) (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceInferenceRequest> with
                TaskType = taskType
                InferenceId = inferenceId
            }
            req

        /// Create an inference endpoint.
        let put (taskType: InferenceTypes.TaskType) (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutRequest> with
                TaskType = taskType
                InferenceId = inferenceId
            }
            req

        /// Create a AI21 inference endpoint.
        let putAi21 (taskType: InferenceTypes.Ai21TaskType) (ai21InferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAi21Request> with
                TaskType = taskType
                Ai21InferenceId = ai21InferenceId
            }
            req

        /// Create an AlibabaCloud AI Search inference endpoint.
        let putAlibabacloud (taskType: InferenceTypes.AlibabaCloudTaskType) (alibabacloudInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAlibabacloudRequest> with
                TaskType = taskType
                AlibabacloudInferenceId = alibabacloudInferenceId
            }
            req

        /// Create an Amazon Bedrock inference endpoint.
        let putAmazonbedrock (taskType: InferenceTypes.AmazonBedrockTaskType) (amazonbedrockInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAmazonbedrockRequest> with
                TaskType = taskType
                AmazonbedrockInferenceId = amazonbedrockInferenceId
            }
            req

        /// Create an Amazon SageMaker inference endpoint.
        let putAmazonsagemaker (taskType: InferenceTypes.TaskTypeAmazonSageMaker) (amazonsagemakerInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAmazonsagemakerRequest> with
                TaskType = taskType
                AmazonsagemakerInferenceId = amazonsagemakerInferenceId
            }
            req

        /// Create an Anthropic inference endpoint.
        let putAnthropic (taskType: InferenceTypes.AnthropicTaskType) (anthropicInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAnthropicRequest> with
                TaskType = taskType
                AnthropicInferenceId = anthropicInferenceId
            }
            req

        /// Create an Azure AI studio inference endpoint.
        let putAzureaistudio (taskType: InferenceTypes.AzureAiStudioTaskType) (azureaistudioInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAzureaistudioRequest> with
                TaskType = taskType
                AzureaistudioInferenceId = azureaistudioInferenceId
            }
            req

        /// Create an Azure OpenAI inference endpoint.
        let putAzureopenai (taskType: InferenceTypes.AzureOpenAITaskType) (azureopenaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutAzureopenaiRequest> with
                TaskType = taskType
                AzureopenaiInferenceId = azureopenaiInferenceId
            }
            req

        /// Create a Cohere inference endpoint.
        let putCohere (taskType: InferenceTypes.CohereTaskType) (cohereInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutCohereRequest> with
                TaskType = taskType
                CohereInferenceId = cohereInferenceId
            }
            req

        /// Create an Contextual AI inference endpoint.
        let putContextualai (taskType: InferenceTypes.TaskTypeContextualAI) (contextualaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutContextualaiRequest> with
                TaskType = taskType
                ContextualaiInferenceId = contextualaiInferenceId
            }
            req

        /// Create a custom inference endpoint.
        let putCustom (taskType: InferenceTypes.CustomTaskType) (customInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutCustomRequest> with
                TaskType = taskType
                CustomInferenceId = customInferenceId
            }
            req

        /// Create a DeepSeek inference endpoint.
        let putDeepseek (taskType: InferenceTypes.TaskTypeDeepSeek) (deepseekInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutDeepseekRequest> with
                TaskType = taskType
                DeepseekInferenceId = deepseekInferenceId
            }
            req

        /// Create an Elasticsearch inference endpoint.
        let putElasticsearch (taskType: InferenceTypes.ElasticsearchTaskType) (elasticsearchInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutElasticsearchRequest> with
                TaskType = taskType
                ElasticsearchInferenceId = elasticsearchInferenceId
            }
            req

        /// Create an ELSER inference endpoint.
        let putElser (taskType: InferenceTypes.ElserTaskType) (elserInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutElserRequest> with
                TaskType = taskType
                ElserInferenceId = elserInferenceId
            }
            req

        /// Create a Fireworks AI inference endpoint.
        let putFireworksai (taskType: InferenceTypes.FireworksAITaskType) (fireworksaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutFireworksaiRequest> with
                TaskType = taskType
                FireworksaiInferenceId = fireworksaiInferenceId
            }
            req

        /// Create an Google AI Studio inference endpoint.
        let putGoogleaistudio (taskType: InferenceTypes.GoogleAiStudioTaskType) (googleaistudioInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutGoogleaistudioRequest> with
                TaskType = taskType
                GoogleaistudioInferenceId = googleaistudioInferenceId
            }
            req

        /// Create a Google Vertex AI inference endpoint.
        let putGooglevertexai (taskType: InferenceTypes.GoogleVertexAITaskType) (googlevertexaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutGooglevertexaiRequest> with
                TaskType = taskType
                GooglevertexaiInferenceId = googlevertexaiInferenceId
            }
            req

        /// Create a Groq inference endpoint.
        let putGroq (taskType: InferenceTypes.GroqTaskType) (groqInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutGroqRequest> with
                TaskType = taskType
                GroqInferenceId = groqInferenceId
            }
            req

        /// Create a Hugging Face inference endpoint.
        let putHuggingFace (taskType: InferenceTypes.HuggingFaceTaskType) (huggingfaceInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutHuggingFaceRequest> with
                TaskType = taskType
                HuggingfaceInferenceId = huggingfaceInferenceId
            }
            req

        /// Create an JinaAI inference endpoint.
        let putJinaai (taskType: InferenceTypes.JinaAITaskType) (jinaaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutJinaaiRequest> with
                TaskType = taskType
                JinaaiInferenceId = jinaaiInferenceId
            }
            req

        /// Create a Llama inference endpoint.
        let putLlama (taskType: InferenceTypes.LlamaTaskType) (llamaInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutLlamaRequest> with
                TaskType = taskType
                LlamaInferenceId = llamaInferenceId
            }
            req

        /// Create a Mistral inference endpoint.
        let putMistral (taskType: InferenceTypes.MistralTaskType) (mistralInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutMistralRequest> with
                TaskType = taskType
                MistralInferenceId = mistralInferenceId
            }
            req

        /// Create an Nvidia inference endpoint.
        let putNvidia (taskType: InferenceTypes.NvidiaTaskType) (nvidiaInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutNvidiaRequest> with
                TaskType = taskType
                NvidiaInferenceId = nvidiaInferenceId
            }
            req

        /// Create an OpenAI inference endpoint.
        let putOpenai (taskType: InferenceTypes.OpenAITaskType) (openaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutOpenaiRequest> with
                TaskType = taskType
                OpenaiInferenceId = openaiInferenceId
            }
            req

        /// Create an OpenShift AI inference endpoint.
        let putOpenshiftAi (taskType: InferenceTypes.OpenShiftAiTaskType) (openshiftaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutOpenshiftAiRequest> with
                TaskType = taskType
                OpenshiftaiInferenceId = openshiftaiInferenceId
            }
            req

        /// Create a VoyageAI inference endpoint.
        let putVoyageai (taskType: InferenceTypes.VoyageAITaskType) (voyageaiInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutVoyageaiRequest> with
                TaskType = taskType
                VoyageaiInferenceId = voyageaiInferenceId
            }
            req

        /// Create a Watsonx inference endpoint.
        let putWatsonx (taskType: InferenceTypes.WatsonxTaskType) (watsonxInferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferencePutWatsonxRequest> with
                TaskType = taskType
                WatsonxInferenceId = watsonxInferenceId
            }
            req

        /// Perform reranking inference on the service.
        let rerank (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceRerankRequest> with
                InferenceId = inferenceId
            }
            req

        /// Perform sparse embedding inference on the service.
        let sparseEmbedding (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceSparseEmbeddingRequest> with
                InferenceId = inferenceId
            }
            req

        /// Perform streaming completion inference on the service.
        let streamCompletion (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceStreamCompletionRequest> with
                InferenceId = inferenceId
            }
            req

        /// Perform text embedding inference on the service.
        let textEmbedding (inferenceId: Types.Id) =
            let req = { Unchecked.defaultof<InferenceTextEmbeddingRequest> with
                InferenceId = inferenceId
            }
            req

        /// Update an inference endpoint.
        let update (inferenceId: Types.Id) (taskType: InferenceTypes.TaskType) =
            let req = { Unchecked.defaultof<InferenceUpdateRequest> with
                InferenceId = inferenceId
                TaskType = taskType
            }
            req

    module Ingest =

        /// Delete GeoIP database configurations.
        let deleteGeoipDatabase (id: Types.Ids) =
            let req = { Unchecked.defaultof<IngestDeleteGeoipDatabaseRequest> with
                Id = id
            }
            req

        /// Delete IP geolocation database configurations.
        let deleteIpLocationDatabase (id: Types.Ids) =
            let req = { Unchecked.defaultof<IngestDeleteIpLocationDatabaseRequest> with
                Id = id
            }
            req

        /// Delete pipelines.
        let deletePipeline (id: Types.Id) =
            let req = { Unchecked.defaultof<IngestDeletePipelineRequest> with
                Id = id
            }
            req

        /// Get GeoIP statistics.
        let geoIpStats () : IngestGeoIpStatsRequest =
            Unchecked.defaultof<IngestGeoIpStatsRequest>

        /// Get GeoIP database configurations.
        let getGeoipDatabase (id: Types.Ids) =
            let req = { Unchecked.defaultof<IngestGetGeoipDatabaseRequest> with
                Id = id
            }
            req

        /// Get IP geolocation database configurations.
        let getIpLocationDatabase (id: Types.Ids) =
            let req = { Unchecked.defaultof<IngestGetIpLocationDatabaseRequest> with
                Id = id
            }
            req

        /// Get pipelines.
        let getPipeline (id: Types.Id) =
            let req = { Unchecked.defaultof<IngestGetPipelineRequest> with
                Id = id
            }
            req

        /// Run a grok processor.
        let processorGrok () : IngestProcessorGrokRequest =
            Unchecked.defaultof<IngestProcessorGrokRequest>

        /// Create or update a GeoIP database configuration.
        let putGeoipDatabase (id: Types.Id) =
            let req = { Unchecked.defaultof<IngestPutGeoipDatabaseRequest> with
                Id = id
            }
            req

        /// Create or update an IP geolocation database configuration.
        let putIpLocationDatabase (id: Types.Id) =
            let req = { Unchecked.defaultof<IngestPutIpLocationDatabaseRequest> with
                Id = id
            }
            req

        /// Create or update a pipeline.
        let putPipeline (id: Types.Id) =
            let req = { Unchecked.defaultof<IngestPutPipelineRequest> with
                Id = id
            }
            req

        /// Simulate a pipeline.
        let simulate (id: Types.Id) =
            let req = { Unchecked.defaultof<IngestSimulateRequest> with
                Id = id
            }
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
            let req = { Unchecked.defaultof<LogstashDeletePipelineRequest> with
                Id = id
            }
            req

        /// Get Logstash pipelines.
        let getPipeline (id: Types.Ids) =
            let req = { Unchecked.defaultof<LogstashGetPipelineRequest> with
                Id = id
            }
            req

        /// Create or update a Logstash pipeline.
        let putPipeline (id: Types.Id) =
            let req = { Unchecked.defaultof<LogstashPutPipelineRequest> with
                Id = id
            }
            req

    module Migration =

        /// Get deprecation information.
        let deprecations (index: Types.IndexName) =
            let req = { Unchecked.defaultof<MigrationDeprecationsRequest> with
                Index = index
            }
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
            let req = { Unchecked.defaultof<MlClearTrainedModelDeploymentCacheRequest> with
                ModelId = modelId
            }
            req

        /// Close anomaly detection jobs.
        let closeJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlCloseJobRequest> with
                JobId = jobId
            }
            req

        /// Delete a calendar.
        let deleteCalendar (calendarId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteCalendarRequest> with
                CalendarId = calendarId
            }
            req

        /// Delete events from a calendar.
        let deleteCalendarEvent (calendarId: Types.Id) (eventId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteCalendarEventRequest> with
                CalendarId = calendarId
                EventId = eventId
            }
            req

        /// Delete anomaly jobs from a calendar.
        let deleteCalendarJob (calendarId: Types.Id) (jobId: Types.Ids) =
            let req = { Unchecked.defaultof<MlDeleteCalendarJobRequest> with
                CalendarId = calendarId
                JobId = jobId
            }
            req

        /// Delete a data frame analytics job.
        let deleteDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Delete a datafeed.
        let deleteDatafeed (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteDatafeedRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Delete expired ML data.
        let deleteExpiredData (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteExpiredDataRequest> with
                JobId = jobId
            }
            req

        /// Delete a filter.
        let deleteFilter (filterId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteFilterRequest> with
                FilterId = filterId
            }
            req

        /// Delete forecasts from a job.
        let deleteForecast (jobId: Types.Id) (forecastId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteForecastRequest> with
                JobId = jobId
                ForecastId = forecastId
            }
            req

        /// Delete an anomaly detection job.
        let deleteJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteJobRequest> with
                JobId = jobId
            }
            req

        /// Delete a model snapshot.
        let deleteModelSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteModelSnapshotRequest> with
                JobId = jobId
                SnapshotId = snapshotId
            }
            req

        /// Delete an unreferenced trained model.
        let deleteTrainedModel (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteTrainedModelRequest> with
                ModelId = modelId
            }
            req

        /// Delete a trained model alias.
        let deleteTrainedModelAlias (modelAlias: Types.Name) (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlDeleteTrainedModelAliasRequest> with
                ModelAlias = modelAlias
                ModelId = modelId
            }
            req

        /// Estimate job model memory usage.
        let estimateModelMemory () =
            Unchecked.defaultof<MlEstimateModelMemoryRequest>

        /// Evaluate data frame analytics.
        let evaluateDataFrame () =
            Unchecked.defaultof<MlEvaluateDataFrameRequest>

        /// Explain data frame analytics config.
        let explainDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlExplainDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Force buffered data to be processed.
        let flushJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlFlushJobRequest> with
                JobId = jobId
            }
            req

        /// Predict future behavior of a time series.
        let forecast (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlForecastRequest> with
                JobId = jobId
            }
            req

        /// Get anomaly detection job results for buckets.
        let getBuckets (jobId: Types.Id) (timestamp: Types.DateTime) =
            let req = { Unchecked.defaultof<MlGetBucketsRequest> with
                JobId = jobId
                Timestamp = timestamp
            }
            req

        /// Get info about events in calendars.
        let getCalendarEvents (calendarId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetCalendarEventsRequest> with
                CalendarId = calendarId
            }
            req

        /// Get calendar configuration info.
        let getCalendars (calendarId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetCalendarsRequest> with
                CalendarId = calendarId
            }
            req

        /// Get anomaly detection job results for categories.
        let getCategories (jobId: Types.Id) (categoryId: Types.CategoryId) =
            let req = { Unchecked.defaultof<MlGetCategoriesRequest> with
                JobId = jobId
                CategoryId = categoryId
            }
            req

        /// Get data frame analytics job configuration info.
        let getDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlGetDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Get data frame analytics job stats.
        let getDataFrameAnalyticsStats (id: Types.Id) =
            let req = { Unchecked.defaultof<MlGetDataFrameAnalyticsStatsRequest> with
                Id = id
            }
            req

        /// Get datafeed stats.
        let getDatafeedStats (datafeedId: Types.Ids) =
            let req = { Unchecked.defaultof<MlGetDatafeedStatsRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Get datafeeds configuration info.
        let getDatafeeds (datafeedId: Types.Ids) =
            let req = { Unchecked.defaultof<MlGetDatafeedsRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Get filters.
        let getFilters (filterId: Types.Ids) =
            let req = { Unchecked.defaultof<MlGetFiltersRequest> with
                FilterId = filterId
            }
            req

        /// Get anomaly detection job results for influencers.
        let getInfluencers (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetInfluencersRequest> with
                JobId = jobId
            }
            req

        /// Get anomaly detection job stats.
        let getJobStats (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetJobStatsRequest> with
                JobId = jobId
            }
            req

        /// Get anomaly detection jobs configuration info.
        let getJobs (jobId: Types.Ids) =
            let req = { Unchecked.defaultof<MlGetJobsRequest> with
                JobId = jobId
            }
            req

        /// Get machine learning memory usage info.
        let getMemoryStats (nodeId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetMemoryStatsRequest> with
                NodeId = nodeId
            }
            req

        /// Get anomaly detection job model snapshot upgrade usage info.
        let getModelSnapshotUpgradeStats (jobId: Types.Id) (snapshotId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetModelSnapshotUpgradeStatsRequest> with
                JobId = jobId
                SnapshotId = snapshotId
            }
            req

        /// Get model snapshots info.
        let getModelSnapshots (jobId: Types.Id) (snapshotId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetModelSnapshotsRequest> with
                JobId = jobId
                SnapshotId = snapshotId
            }
            req

        /// Get overall bucket results.
        let getOverallBuckets (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetOverallBucketsRequest> with
                JobId = jobId
            }
            req

        /// Get anomaly records for an anomaly detection job.
        let getRecords (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlGetRecordsRequest> with
                JobId = jobId
            }
            req

        /// Get trained model configuration info.
        let getTrainedModels (modelId: Types.Ids) =
            let req = { Unchecked.defaultof<MlGetTrainedModelsRequest> with
                ModelId = modelId
            }
            req

        /// Get trained models usage info.
        let getTrainedModelsStats (modelId: Types.Ids) =
            let req = { Unchecked.defaultof<MlGetTrainedModelsStatsRequest> with
                ModelId = modelId
            }
            req

        /// Evaluate a trained model.
        let inferTrainedModel (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlInferTrainedModelRequest> with
                ModelId = modelId
            }
            req

        /// Get machine learning information.
        let info () : MlInfoRequest =
            Unchecked.defaultof<MlInfoRequest>

        /// Open anomaly detection jobs.
        let openJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlOpenJobRequest> with
                JobId = jobId
            }
            req

        /// Add scheduled events to the calendar.
        let postCalendarEvents (calendarId: Types.Id) =
            let req = { Unchecked.defaultof<MlPostCalendarEventsRequest> with
                CalendarId = calendarId
            }
            req

        /// Send data to an anomaly detection job for analysis.
        let postData (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlPostDataRequest> with
                JobId = jobId
            }
            req

        /// Preview features used by data frame analytics.
        let previewDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlPreviewDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Preview a datafeed.
        let previewDatafeed (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<MlPreviewDatafeedRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Create a calendar.
        let putCalendar (calendarId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutCalendarRequest> with
                CalendarId = calendarId
            }
            req

        /// Add anomaly detection job to calendar.
        let putCalendarJob (calendarId: Types.Id) (jobId: Types.Ids) =
            let req = { Unchecked.defaultof<MlPutCalendarJobRequest> with
                CalendarId = calendarId
                JobId = jobId
            }
            req

        /// Create a data frame analytics job.
        let putDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlPutDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Create a datafeed.
        let putDatafeed (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutDatafeedRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Create a filter.
        let putFilter (filterId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutFilterRequest> with
                FilterId = filterId
            }
            req

        /// Create an anomaly detection job.
        let putJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutJobRequest> with
                JobId = jobId
            }
            req

        /// Create a trained model.
        let putTrainedModel (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutTrainedModelRequest> with
                ModelId = modelId
            }
            req

        /// Create or update a trained model alias.
        let putTrainedModelAlias (modelAlias: Types.Name) (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutTrainedModelAliasRequest> with
                ModelAlias = modelAlias
                ModelId = modelId
            }
            req

        /// Create part of a trained model definition.
        let putTrainedModelDefinitionPart (modelId: Types.Id) (part: Types.Integer) =
            let req = { Unchecked.defaultof<MlPutTrainedModelDefinitionPartRequest> with
                ModelId = modelId
                Part = part
            }
            req

        /// Create a trained model vocabulary.
        let putTrainedModelVocabulary (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlPutTrainedModelVocabularyRequest> with
                ModelId = modelId
            }
            req

        /// Reset an anomaly detection job.
        let resetJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlResetJobRequest> with
                JobId = jobId
            }
            req

        /// Revert to a snapshot.
        let revertModelSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let req = { Unchecked.defaultof<MlRevertModelSnapshotRequest> with
                JobId = jobId
                SnapshotId = snapshotId
            }
            req

        /// Set upgrade_mode for ML indices.
        let setUpgradeMode () =
            Unchecked.defaultof<MlSetUpgradeModeRequest>

        /// Start a data frame analytics job.
        let startDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlStartDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Start datafeeds.
        let startDatafeed (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<MlStartDatafeedRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Start a trained model deployment.
        let startTrainedModelDeployment (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlStartTrainedModelDeploymentRequest> with
                ModelId = modelId
            }
            req

        /// Stop data frame analytics jobs.
        let stopDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlStopDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Stop datafeeds.
        let stopDatafeed (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<MlStopDatafeedRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Stop a trained model deployment.
        let stopTrainedModelDeployment (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlStopTrainedModelDeploymentRequest> with
                ModelId = modelId
            }
            req

        /// Update a data frame analytics job.
        let updateDataFrameAnalytics (id: Types.Id) =
            let req = { Unchecked.defaultof<MlUpdateDataFrameAnalyticsRequest> with
                Id = id
            }
            req

        /// Update a datafeed.
        let updateDatafeed (datafeedId: Types.Id) =
            let req = { Unchecked.defaultof<MlUpdateDatafeedRequest> with
                DatafeedId = datafeedId
            }
            req

        /// Update a filter.
        let updateFilter (filterId: Types.Id) =
            let req = { Unchecked.defaultof<MlUpdateFilterRequest> with
                FilterId = filterId
            }
            req

        /// Update an anomaly detection job.
        let updateJob (jobId: Types.Id) =
            let req = { Unchecked.defaultof<MlUpdateJobRequest> with
                JobId = jobId
            }
            req

        /// Update a snapshot.
        let updateModelSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let req = { Unchecked.defaultof<MlUpdateModelSnapshotRequest> with
                JobId = jobId
                SnapshotId = snapshotId
            }
            req

        /// Update a trained model deployment.
        let updateTrainedModelDeployment (modelId: Types.Id) =
            let req = { Unchecked.defaultof<MlUpdateTrainedModelDeploymentRequest> with
                ModelId = modelId
            }
            req

        /// Upgrade a snapshot.
        let upgradeJobSnapshot (jobId: Types.Id) (snapshotId: Types.Id) =
            let req = { Unchecked.defaultof<MlUpgradeJobSnapshotRequest> with
                JobId = jobId
                SnapshotId = snapshotId
            }
            req

        /// Validate an anomaly detection job.
        let validate () =
            Unchecked.defaultof<MlValidateRequest>

        /// Validate an anomaly detection job.
        let validateDetector () =
            Unchecked.defaultof<MlValidateDetectorRequest>

    module Monitoring =

        /// Send monitoring data.
        let bulk () =
            Unchecked.defaultof<MonitoringBulkRequest>

    module Nodes =

        /// Clear the archived repositories metering.
        let clearRepositoriesMeteringArchive (nodeId: Types.NodeIds) (maxArchiveVersion: Types.Long) =
            let req = { Unchecked.defaultof<NodesClearRepositoriesMeteringArchiveRequest> with
                NodeId = nodeId
                MaxArchiveVersion = maxArchiveVersion
            }
            req

        /// Get cluster repositories metering.
        let getRepositoriesMeteringInfo (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<NodesGetRepositoriesMeteringInfoRequest> with
                NodeId = nodeId
            }
            req

        /// Get the hot threads for nodes.
        let hotThreads (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<NodesHotThreadsRequest> with
                NodeId = nodeId
            }
            req

        /// Get node information.
        let info (nodeId: Types.NodeIds) (metric: NodesInfo.NodesInfoMetrics) =
            let req = { Unchecked.defaultof<NodesInfoRequest> with
                NodeId = nodeId
                Metric = metric
            }
            req

        /// Reload the keystore on nodes in the cluster.
        let reloadSecureSettings (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<NodesReloadSecureSettingsRequest> with
                NodeId = nodeId
            }
            req

        /// Get node statistics.
        let stats (nodeId: Types.NodeIds) (metric: NodesStats.NodeStatsMetrics) (indexMetric: Types.CommonStatsFlags) =
            let req = { Unchecked.defaultof<NodesStatsRequest> with
                NodeId = nodeId
                Metric = metric
                IndexMetric = indexMetric
            }
            req

        /// Get feature usage information.
        let usage (nodeId: Types.NodeIds) (metric: NodesUsage.NodesUsageMetrics) =
            let req = { Unchecked.defaultof<NodesUsageRequest> with
                NodeId = nodeId
                Metric = metric
            }
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
            let req = { Unchecked.defaultof<ProjectCreateRoutingRequest> with
                Name = name
            }
            req

        /// Delete a project routing expression.
        let deleteRouting (name: string) =
            let req = { Unchecked.defaultof<ProjectDeleteRoutingRequest> with
                Name = name
            }
            req

        /// Get project routing expressions.
        let getManyRouting () : ProjectGetManyRoutingRequest =
            Unchecked.defaultof<ProjectGetManyRoutingRequest>

        /// Get a project routing expression.
        let getRouting (name: string) =
            let req = { Unchecked.defaultof<ProjectGetRoutingRequest> with
                Name = name
            }
            req

        /// Get tags.
        let tags () =
            Unchecked.defaultof<ProjectTagsRequest>

    module QueryRules =

        /// Delete a query rule.
        let deleteRule (rulesetId: Types.Id) (ruleId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesDeleteRuleRequest> with
                RulesetId = rulesetId
                RuleId = ruleId
            }
            req

        /// Delete a query ruleset.
        let deleteRuleset (rulesetId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesDeleteRulesetRequest> with
                RulesetId = rulesetId
            }
            req

        /// Get a query rule.
        let getRule (rulesetId: Types.Id) (ruleId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesGetRuleRequest> with
                RulesetId = rulesetId
                RuleId = ruleId
            }
            req

        /// Get a query ruleset.
        let getRuleset (rulesetId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesGetRulesetRequest> with
                RulesetId = rulesetId
            }
            req

        /// Get all query rulesets.
        let listRulesets () =
            Unchecked.defaultof<QueryRulesListRulesetsRequest>

        /// Create or update a query rule.
        let putRule (rulesetId: Types.Id) (ruleId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesPutRuleRequest> with
                RulesetId = rulesetId
                RuleId = ruleId
            }
            req

        /// Create or update a query ruleset.
        let putRuleset (rulesetId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesPutRulesetRequest> with
                RulesetId = rulesetId
            }
            req

        /// Test a query ruleset.
        let test (rulesetId: Types.Id) =
            let req = { Unchecked.defaultof<QueryRulesTestRequest> with
                RulesetId = rulesetId
            }
            req

    module Rollup =

        /// Delete a rollup job.
        let deleteJob (id: Types.Id) =
            let req = { Unchecked.defaultof<RollupDeleteJobRequest> with
                Id = id
            }
            req

        /// Get rollup job information.
        let getJobs (id: Types.Id) =
            let req = { Unchecked.defaultof<RollupGetJobsRequest> with
                Id = id
            }
            req

        /// Get the rollup job capabilities.
        let getRollupCaps (id: Types.Id) =
            let req = { Unchecked.defaultof<RollupGetRollupCapsRequest> with
                Id = id
            }
            req

        /// Get the rollup index capabilities.
        let getRollupIndexCaps (index: Types.Ids) =
            let req = { Unchecked.defaultof<RollupGetRollupIndexCapsRequest> with
                Index = index
            }
            req

        /// Create a rollup job.
        let putJob (id: Types.Id) =
            let req = { Unchecked.defaultof<RollupPutJobRequest> with
                Id = id
            }
            req

        /// Search rolled-up data.
        let rollupSearch (index: Types.Indices) =
            let req = { Unchecked.defaultof<RollupRollupSearchRequest> with
                Index = index
            }
            req

        /// Start rollup jobs.
        let startJob (id: Types.Id) =
            let req = { Unchecked.defaultof<RollupStartJobRequest> with
                Id = id
            }
            req

        /// Stop rollup jobs.
        let stopJob (id: Types.Id) =
            let req = { Unchecked.defaultof<RollupStopJobRequest> with
                Id = id
            }
            req

    module SearchApplication =

        /// Delete a search application.
        let delete (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationDeleteRequest> with
                Name = name
            }
            req

        /// Delete a behavioral analytics collection.
        let deleteBehavioralAnalytics (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationDeleteBehavioralAnalyticsRequest> with
                Name = name
            }
            req

        /// Get search application details.
        let get (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationGetRequest> with
                Name = name
            }
            req

        /// Get behavioral analytics collections.
        let getBehavioralAnalytics (name: Types.Name list) =
            let req = { Unchecked.defaultof<SearchApplicationGetBehavioralAnalyticsRequest> with
                Name = name
            }
            req

        /// Get search applications.
        let list () =
            Unchecked.defaultof<SearchApplicationListRequest>

        /// Create a behavioral analytics collection event.
        let postBehavioralAnalyticsEvent (collectionName: Types.Name) (eventType: SearchApplicationTypes.EventType) =
            let req = { Unchecked.defaultof<SearchApplicationPostBehavioralAnalyticsEventRequest> with
                CollectionName = collectionName
                EventType = eventType
            }
            req

        /// Create or update a search application.
        let put (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationPutRequest> with
                Name = name
            }
            req

        /// Create a behavioral analytics collection.
        let putBehavioralAnalytics (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationPutBehavioralAnalyticsRequest> with
                Name = name
            }
            req

        /// Render a search application query.
        let renderQuery (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationRenderQueryRequest> with
                Name = name
            }
            req

        /// Run a search application search.
        let search (name: Types.Name) =
            let req = { Unchecked.defaultof<SearchApplicationSearchRequest> with
                Name = name
            }
            req

    module SearchableSnapshots =

        /// Get cache statistics.
        let cacheStats (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<SearchableSnapshotsCacheStatsRequest> with
                NodeId = nodeId
            }
            req

        /// Clear the cache.
        let clearCache (index: Types.Indices) =
            let req = { Unchecked.defaultof<SearchableSnapshotsClearCacheRequest> with
                Index = index
            }
            req

        /// Mount a snapshot.
        let mount (repository: Types.Name) (snapshot: Types.Name) =
            let req = { Unchecked.defaultof<SearchableSnapshotsMountRequest> with
                Repository = repository
                Snapshot = snapshot
            }
            req

        /// Get searchable snapshot statistics.
        let stats (index: Types.Indices) =
            let req = { Unchecked.defaultof<SearchableSnapshotsStatsRequest> with
                Index = index
            }
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
            let req = { Unchecked.defaultof<SecurityChangePasswordRequest> with
                Username = username
            }
            req

        /// Clear the API key cache.
        let clearApiKeyCache (ids: Types.Ids) =
            let req = { Unchecked.defaultof<SecurityClearApiKeyCacheRequest> with
                Ids = ids
            }
            req

        /// Clear the privileges cache.
        let clearCachedPrivileges (application: Types.Names) =
            let req = { Unchecked.defaultof<SecurityClearCachedPrivilegesRequest> with
                Application = application
            }
            req

        /// Clear the user cache.
        let clearCachedRealms (realms: Types.Names) =
            let req = { Unchecked.defaultof<SecurityClearCachedRealmsRequest> with
                Realms = realms
            }
            req

        /// Clear the roles cache.
        let clearCachedRoles (name: Types.Names) =
            let req = { Unchecked.defaultof<SecurityClearCachedRolesRequest> with
                Name = name
            }
            req

        /// Clear service account token caches.
        let clearCachedServiceTokens (namespace': Types.Namespace) (service: Types.Service) (name: Types.Names) =
            let req = { Unchecked.defaultof<SecurityClearCachedServiceTokensRequest> with
                Namespace = namespace'
                Service = service
                Name = name
            }
            req

        /// Create an API key.
        let createApiKey () =
            Unchecked.defaultof<SecurityCreateApiKeyRequest>

        /// Create a cross-cluster API key.
        let createCrossClusterApiKey () =
            Unchecked.defaultof<SecurityCreateCrossClusterApiKeyRequest>

        /// Create a service account token.
        let createServiceToken (namespace': Types.Namespace) (service: Types.Service) (name: Types.Name) =
            let req = { Unchecked.defaultof<SecurityCreateServiceTokenRequest> with
                Namespace = namespace'
                Service = service
                Name = name
            }
            req

        /// Delegate PKI authentication.
        let delegatePki () =
            Unchecked.defaultof<SecurityDelegatePkiRequest>

        /// Delete application privileges.
        let deletePrivileges (application: Types.Name) (name: Types.Names) =
            let req = { Unchecked.defaultof<SecurityDeletePrivilegesRequest> with
                Application = application
                Name = name
            }
            req

        /// Delete roles.
        let deleteRole (name: Types.Name) =
            let req = { Unchecked.defaultof<SecurityDeleteRoleRequest> with
                Name = name
            }
            req

        /// Delete role mappings.
        let deleteRoleMapping (name: Types.Name) =
            let req = { Unchecked.defaultof<SecurityDeleteRoleMappingRequest> with
                Name = name
            }
            req

        /// Delete service account tokens.
        let deleteServiceToken (namespace': Types.Namespace) (service: Types.Service) (name: Types.Name) =
            let req = { Unchecked.defaultof<SecurityDeleteServiceTokenRequest> with
                Namespace = namespace'
                Service = service
                Name = name
            }
            req

        /// Delete users.
        let deleteUser (username: Types.Username) =
            let req = { Unchecked.defaultof<SecurityDeleteUserRequest> with
                Username = username
            }
            req

        /// Disable users.
        let disableUser (username: Types.Username) =
            let req = { Unchecked.defaultof<SecurityDisableUserRequest> with
                Username = username
            }
            req

        /// Disable a user profile.
        let disableUserProfile (uid: SecurityTypes.UserProfileId) =
            let req = { Unchecked.defaultof<SecurityDisableUserProfileRequest> with
                Uid = uid
            }
            req

        /// Enable users.
        let enableUser (username: Types.Username) =
            let req = { Unchecked.defaultof<SecurityEnableUserRequest> with
                Username = username
            }
            req

        /// Enable a user profile.
        let enableUserProfile (uid: SecurityTypes.UserProfileId) =
            let req = { Unchecked.defaultof<SecurityEnableUserProfileRequest> with
                Uid = uid
            }
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
            let req = { Unchecked.defaultof<SecurityGetPrivilegesRequest> with
                Application = application
                Name = name
            }
            req

        /// Get roles.
        let getRole (name: Types.Names) =
            let req = { Unchecked.defaultof<SecurityGetRoleRequest> with
                Name = name
            }
            req

        /// Get role mappings.
        let getRoleMapping (name: Types.Names) =
            let req = { Unchecked.defaultof<SecurityGetRoleMappingRequest> with
                Name = name
            }
            req

        /// Get service accounts.
        let getServiceAccounts (namespace': Types.Namespace) (service: Types.Service) =
            let req = { Unchecked.defaultof<SecurityGetServiceAccountsRequest> with
                Namespace = namespace'
                Service = service
            }
            req

        /// Get service account credentials.
        let getServiceCredentials (namespace': Types.Namespace) (service: Types.Name) =
            let req = { Unchecked.defaultof<SecurityGetServiceCredentialsRequest> with
                Namespace = namespace'
                Service = service
            }
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
            let req = { Unchecked.defaultof<SecurityGetUserRequest> with
                Username = username
            }
            req

        /// Get user privileges.
        let getUserPrivileges () : SecurityGetUserPrivilegesRequest =
            Unchecked.defaultof<SecurityGetUserPrivilegesRequest>

        /// Get a user profile.
        let getUserProfile (uid: System.Text.Json.JsonElement) =
            let req = { Unchecked.defaultof<SecurityGetUserProfileRequest> with
                Uid = uid
            }
            req

        /// Grant an API key.
        let grantApiKey () =
            Unchecked.defaultof<SecurityGrantApiKeyRequest>

        /// Check user privileges.
        let hasPrivileges (user: Types.Name) =
            let req = { Unchecked.defaultof<SecurityHasPrivilegesRequest> with
                User = user
            }
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
            let req = { Unchecked.defaultof<SecurityPutRoleRequest> with
                Name = name
            }
            req

        /// Create or update role mappings.
        let putRoleMapping (name: Types.Name) =
            let req = { Unchecked.defaultof<SecurityPutRoleMappingRequest> with
                Name = name
            }
            req

        /// Create or update users.
        let putUser (username: Types.Username) =
            let req = { Unchecked.defaultof<SecurityPutUserRequest> with
                Username = username
            }
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
            let req = { Unchecked.defaultof<SecuritySamlServiceProviderMetadataRequest> with
                RealmName = realmName
            }
            req

        /// Suggest a user profile.
        let suggestUserProfiles () =
            Unchecked.defaultof<SecuritySuggestUserProfilesRequest>

        /// Update an API key.
        let updateApiKey (id: Types.Id) =
            let req = { Unchecked.defaultof<SecurityUpdateApiKeyRequest> with
                Id = id
            }
            req

        /// Update a cross-cluster API key.
        let updateCrossClusterApiKey (id: Types.Id) =
            let req = { Unchecked.defaultof<SecurityUpdateCrossClusterApiKeyRequest> with
                Id = id
            }
            req

        /// Update security index settings.
        let updateSettings () =
            Unchecked.defaultof<SecurityUpdateSettingsRequest>

        /// Update user profile data.
        let updateUserProfileData (uid: SecurityTypes.UserProfileId) =
            let req = { Unchecked.defaultof<SecurityUpdateUserProfileDataRequest> with
                Uid = uid
            }
            req

    module Shutdown =

        /// Cancel node shutdown preparations.
        let deleteNode (nodeId: Types.NodeId) =
            let req = { Unchecked.defaultof<ShutdownDeleteNodeRequest> with
                NodeId = nodeId
            }
            req

        /// Get the shutdown status.
        let getNode (nodeId: Types.NodeIds) =
            let req = { Unchecked.defaultof<ShutdownGetNodeRequest> with
                NodeId = nodeId
            }
            req

        /// Prepare a node to be shut down.
        let putNode (nodeId: Types.NodeId) =
            let req = { Unchecked.defaultof<ShutdownPutNodeRequest> with
                NodeId = nodeId
            }
            req

    module Simulate =

        /// Simulate data ingestion.
        let ingest (index: Types.IndexName) =
            let req = { Unchecked.defaultof<SimulateIngestRequest> with
                Index = index
            }
            req

    module Slm =

        /// Delete a policy.
        let deleteLifecycle (policyId: Types.Name) =
            let req = { Unchecked.defaultof<SlmDeleteLifecycleRequest> with
                PolicyId = policyId
            }
            req

        /// Run a policy.
        let executeLifecycle (policyId: Types.Name) =
            let req = { Unchecked.defaultof<SlmExecuteLifecycleRequest> with
                PolicyId = policyId
            }
            req

        /// Run a retention policy.
        let executeRetention () =
            Unchecked.defaultof<SlmExecuteRetentionRequest>

        /// Get policy information.
        let getLifecycle (policyId: Types.Names) =
            let req = { Unchecked.defaultof<SlmGetLifecycleRequest> with
                PolicyId = policyId
            }
            req

        /// Get snapshot lifecycle management statistics.
        let getStats () =
            Unchecked.defaultof<SlmGetStatsRequest>

        /// Get the snapshot lifecycle management status.
        let getStatus () =
            Unchecked.defaultof<SlmGetStatusRequest>

        /// Create or update a policy.
        let putLifecycle (policyId: Types.Name) =
            let req = { Unchecked.defaultof<SlmPutLifecycleRequest> with
                PolicyId = policyId
            }
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
            let req = { Unchecked.defaultof<SnapshotCleanupRepositoryRequest> with
                Repository = repository
            }
            req

        /// Clone a snapshot.
        let clone (repository: Types.Name) (snapshot: Types.Name) (targetSnapshot: Types.Name) =
            let req = { Unchecked.defaultof<SnapshotCloneRequest> with
                Repository = repository
                Snapshot = snapshot
                TargetSnapshot = targetSnapshot
            }
            req

        /// Create a snapshot.
        let create (repository: Types.Name) (snapshot: Types.Name) =
            let req = { Unchecked.defaultof<SnapshotCreateRequest> with
                Repository = repository
                Snapshot = snapshot
            }
            req

        /// Create or update a snapshot repository.
        let createRepository (repository: Types.Name) =
            let req = { Unchecked.defaultof<SnapshotCreateRepositoryRequest> with
                Repository = repository
            }
            req

        /// Delete snapshots.
        let delete (repository: Types.Name) (snapshot: Types.Names) =
            let req = { Unchecked.defaultof<SnapshotDeleteRequest> with
                Repository = repository
                Snapshot = snapshot
            }
            req

        /// Delete snapshot repositories.
        let deleteRepository (repository: Types.Names) =
            let req = { Unchecked.defaultof<SnapshotDeleteRepositoryRequest> with
                Repository = repository
            }
            req

        /// Get snapshot information.
        let get (repository: Types.Name) (snapshot: Types.Names) =
            let req = { Unchecked.defaultof<SnapshotGetRequest> with
                Repository = repository
                Snapshot = snapshot
            }
            req

        /// Get snapshot repository information.
        let getRepository (repository: Types.Names) =
            let req = { Unchecked.defaultof<SnapshotGetRepositoryRequest> with
                Repository = repository
            }
            req

        /// Analyze a snapshot repository.
        let repositoryAnalyze (repository: Types.Name) =
            let req = { Unchecked.defaultof<SnapshotRepositoryAnalyzeRequest> with
                Repository = repository
            }
            req

        /// Verify the repository integrity.
        let repositoryVerifyIntegrity (repository: Types.Names) =
            let req = { Unchecked.defaultof<SnapshotRepositoryVerifyIntegrityRequest> with
                Repository = repository
            }
            req

        /// Restore a snapshot.
        let restore (repository: Types.Name) (snapshot: Types.Name) =
            let req = { Unchecked.defaultof<SnapshotRestoreRequest> with
                Repository = repository
                Snapshot = snapshot
            }
            req

        /// Get the snapshot status.
        let status (repository: Types.Name) (snapshot: Types.Names) =
            let req = { Unchecked.defaultof<SnapshotStatusRequest> with
                Repository = repository
                Snapshot = snapshot
            }
            req

        /// Verify a snapshot repository.
        let verifyRepository (repository: Types.Name) =
            let req = { Unchecked.defaultof<SnapshotVerifyRepositoryRequest> with
                Repository = repository
            }
            req

    module Sql =

        /// Clear an SQL search cursor.
        let clearCursor () =
            Unchecked.defaultof<SqlClearCursorRequest>

        /// Delete an async SQL search.
        let deleteAsync (id: Types.Id) =
            let req = { Unchecked.defaultof<SqlDeleteAsyncRequest> with
                Id = id
            }
            req

        /// Get async SQL search results.
        let getAsync (id: Types.Id) =
            let req = { Unchecked.defaultof<SqlGetAsyncRequest> with
                Id = id
            }
            req

        /// Get the async SQL search status.
        let getAsyncStatus (id: Types.Id) =
            let req = { Unchecked.defaultof<SqlGetAsyncStatusRequest> with
                Id = id
            }
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
        let logsDisable (name: StreamsTypes.StreamType) =
            let req = { Unchecked.defaultof<StreamsLogsDisableRequest> with
                Name = name
            }
            req

        /// Enable a named stream.
        let logsEnable (name: StreamsTypes.StreamType) =
            let req = { Unchecked.defaultof<StreamsLogsEnableRequest> with
                Name = name
            }
            req

        /// Get the status of streams.
        let status () =
            Unchecked.defaultof<StreamsStatusRequest>

    module Synonyms =

        /// Delete a synonym set.
        let deleteSynonym (id: Types.Id) =
            let req = { Unchecked.defaultof<SynonymsDeleteSynonymRequest> with
                Id = id
            }
            req

        /// Delete a synonym rule.
        let deleteSynonymRule (setId: Types.Id) (ruleId: Types.Id) =
            let req = { Unchecked.defaultof<SynonymsDeleteSynonymRuleRequest> with
                SetId = setId
                RuleId = ruleId
            }
            req

        /// Get a synonym set.
        let getSynonym (id: Types.Id) =
            let req = { Unchecked.defaultof<SynonymsGetSynonymRequest> with
                Id = id
            }
            req

        /// Get a synonym rule.
        let getSynonymRule (setId: Types.Id) (ruleId: Types.Id) =
            let req = { Unchecked.defaultof<SynonymsGetSynonymRuleRequest> with
                SetId = setId
                RuleId = ruleId
            }
            req

        /// Get all synonym sets.
        let getSynonymsSets () =
            Unchecked.defaultof<SynonymsGetSynonymsSetsRequest>

        /// Create or update a synonym set.
        let putSynonym (id: Types.Id) =
            let req = { Unchecked.defaultof<SynonymsPutSynonymRequest> with
                Id = id
            }
            req

        /// Create or update a synonym rule.
        let putSynonymRule (setId: Types.Id) (ruleId: Types.Id) =
            let req = { Unchecked.defaultof<SynonymsPutSynonymRuleRequest> with
                SetId = setId
                RuleId = ruleId
            }
            req

    module Tasks =

        /// Cancel a task.
        let cancel (taskId: Types.TaskId) =
            let req = { Unchecked.defaultof<TasksCancelRequest> with
                TaskId = taskId
            }
            req

        /// Get task information.
        let get (taskId: Types.Id) =
            let req = { Unchecked.defaultof<TasksGetRequest> with
                TaskId = taskId
            }
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

        /// Find the structure of a text file.
        let findStructure () =
            Unchecked.defaultof<TextStructureFindStructureRequest>

        /// Test a Grok pattern.
        let testGrokPattern () =
            Unchecked.defaultof<TextStructureTestGrokPatternRequest>

    module Transform =

        /// Delete a transform.
        let deleteTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformDeleteTransformRequest> with
                TransformId = transformId
            }
            req

        /// Get node stats.
        let getNodeStats () : TransformGetNodeStatsRequest =
            Unchecked.defaultof<TransformGetNodeStatsRequest>

        /// Get transforms.
        let getTransform (transformId: Types.Names) =
            let req = { Unchecked.defaultof<TransformGetTransformRequest> with
                TransformId = transformId
            }
            req

        /// Get transform stats.
        let getTransformStats (transformId: Types.Names) =
            let req = { Unchecked.defaultof<TransformGetTransformStatsRequest> with
                TransformId = transformId
            }
            req

        /// Preview a transform.
        let previewTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformPreviewTransformRequest> with
                TransformId = transformId
            }
            req

        /// Create a transform.
        let putTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformPutTransformRequest> with
                TransformId = transformId
            }
            req

        /// Reset a transform.
        let resetTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformResetTransformRequest> with
                TransformId = transformId
            }
            req

        /// Schedule a transform to start now.
        let scheduleNowTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformScheduleNowTransformRequest> with
                TransformId = transformId
            }
            req

        /// Set upgrade_mode for transform indices.
        let setUpgradeMode () =
            Unchecked.defaultof<TransformSetUpgradeModeRequest>

        /// Start a transform.
        let startTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformStartTransformRequest> with
                TransformId = transformId
            }
            req

        /// Stop transforms.
        let stopTransform (transformId: Types.Name) =
            let req = { Unchecked.defaultof<TransformStopTransformRequest> with
                TransformId = transformId
            }
            req

        /// Update a transform.
        let updateTransform (transformId: Types.Id) =
            let req = { Unchecked.defaultof<TransformUpdateTransformRequest> with
                TransformId = transformId
            }
            req

        /// Upgrade all transforms.
        let upgradeTransforms () =
            Unchecked.defaultof<TransformUpgradeTransformsRequest>

    module Watcher =

        /// Acknowledge a watch.
        let ackWatch (watchId: Types.Name) (actionId: Types.Names) =
            let req = { Unchecked.defaultof<WatcherAckWatchRequest> with
                WatchId = watchId
                ActionId = actionId
            }
            req

        /// Activate a watch.
        let activateWatch (watchId: Types.Name) =
            let req = { Unchecked.defaultof<WatcherActivateWatchRequest> with
                WatchId = watchId
            }
            req

        /// Deactivate a watch.
        let deactivateWatch (watchId: Types.Name) =
            let req = { Unchecked.defaultof<WatcherDeactivateWatchRequest> with
                WatchId = watchId
            }
            req

        /// Delete a watch.
        let deleteWatch (id: Types.Name) =
            let req = { Unchecked.defaultof<WatcherDeleteWatchRequest> with
                Id = id
            }
            req

        /// Run a watch.
        let executeWatch (id: Types.Id) =
            let req = { Unchecked.defaultof<WatcherExecuteWatchRequest> with
                Id = id
            }
            req

        /// Get Watcher index settings.
        let getSettings () =
            Unchecked.defaultof<WatcherGetSettingsRequest>

        /// Get a watch.
        let getWatch (id: Types.Name) =
            let req = { Unchecked.defaultof<WatcherGetWatchRequest> with
                Id = id
            }
            req

        /// Create or update a watch.
        let putWatch (id: Types.Id) =
            let req = { Unchecked.defaultof<WatcherPutWatchRequest> with
                Id = id
            }
            req

        /// Query watches.
        let queryWatches () =
            Unchecked.defaultof<WatcherQueryWatchesRequest>

        /// Start the watch service.
        let start () =
            Unchecked.defaultof<WatcherStartRequest>

        /// Get Watcher statistics.
        let stats (metric: System.Text.Json.JsonElement) =
            let req = { Unchecked.defaultof<WatcherStatsRequest> with
                Metric = metric
            }
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

