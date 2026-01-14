// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module InfoOperations =

    type InfoRequest = unit

    let infoRequest = ()

    type InfoResponse = {
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("cluster_uuid")>]
        ClusterUuid: Uuid
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("tagline")>]
        Tagline: string
        [<JsonPropertyName("version")>]
        Version: ElasticsearchVersionInfo
    }

