namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module ClusterCommands =

    [<Fact>]
    let ``Cluster health request returns correct HTTP call`` () =
        let healthReq = clusterHealthRequest {
            index (box "*" : Indices)
        }

        let result = healthReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cluster/health/*", result)

    [<Fact>]
    let ``Cluster health request with options returns correct HTTP call`` () =
        let healthReq = clusterHealthRequest {
            index (box "products" : Indices)
            timeout "30s"
            wait_for_status HealthStatus.Yellow
        }

        let result = healthReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cluster/health/products", result)
        Assert.Contains("timeout=30s", result)
        Assert.Contains("wait_for_status=yellow", result)

    [<Fact>]
    let ``Cluster health with wait for nodes returns correct HTTP call`` () =
        let healthReq = clusterHealthRequest {
            index (box "*" : Indices)
            wait_for_nodes (box ">=3" : HealthWaitForNodes)
            wait_for_no_relocating_shards true
        }

        let result = healthReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cluster/health/*", result)
        Assert.Contains("wait_for_nodes=>=3", result)
        Assert.Contains("wait_for_no_relocating_shards=true", result)

    [<Fact>]
    let ``Cluster state request returns correct HTTP call`` () =
        let stateReq = clusterStateRequest {
            metric (box "_all" : StateClusterStateMetrics)
            index (box "*" : Indices)
        }

        let result = stateReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cluster/state", result)

    [<Fact>]
    let ``Cluster stats request returns correct HTTP call`` () =
        let statsReq = clusterStatsRequest {
            node_id (box "_all" : NodeIds)
        }

        let result = statsReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cluster/stats", result)

    [<Fact>]
    let ``Cluster settings get request returns correct HTTP call`` () =
        let settingsReq = clusterGetSettingsRequest {
            include_defaults true
        }

        let result = settingsReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cluster/settings", result)
        Assert.Contains("include_defaults=true", result)


module CatCommands =

    [<Fact>]
    let ``Cat indices request returns correct HTTP call`` () =
        let catReq = catIndicesRequest {
            index (box "*" : Indices)
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/indices/*", result)

    [<Fact>]
    let ``Cat indices with health filter returns correct HTTP call`` () =
        let catReq = catIndicesRequest {
            index (box "*" : Indices)
            health HealthStatus.Yellow
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/indices/*", result)
        Assert.Contains("health=yellow", result)

    [<Fact>]
    let ``Cat indices with primary only returns correct HTTP call`` () =
        let catReq = catIndicesRequest {
            index (box "products*" : Indices)
            pri true
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/indices/products*", result)
        Assert.Contains("pri=true", result)

    [<Fact>]
    let ``Cat nodes request returns correct HTTP call`` () =
        let catReq = catNodesRequest {
            full_id true
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/nodes", result)
        Assert.Contains("full_id=true", result)

    [<Fact>]
    let ``Cat nodes with master timeout returns correct HTTP call`` () =
        let catReq = catNodesRequest {
            master_timeout "30s"
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/nodes", result)
        Assert.Contains("master_timeout=30s", result)

    [<Fact>]
    let ``Cat health request returns correct HTTP call`` () =
        let catReq = catHealthRequest { ts true }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/health", result)

    [<Fact>]
    let ``Cat shards request returns correct HTTP call`` () =
        let catReq = catShardsRequest {
            index (box "products" : Indices)
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/shards/products", result)

    [<Fact>]
    let ``Cat count request returns correct HTTP call`` () =
        let catReq = catCountRequest {
            index (box "products" : Indices)
        }

        let result = catReq |> toRequestString

        // Note: Generated code uses POST for this endpoint
        Assert.Contains("Method: POST", result)
        Assert.Contains("/_cat/count/products", result)

    [<Fact>]
    let ``Cat aliases request returns correct HTTP call`` () =
        let catReq = catAliasesRequest {
            name (box "product_alias" : Names)
        }

        let result = catReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_cat/aliases/product_alias", result)
