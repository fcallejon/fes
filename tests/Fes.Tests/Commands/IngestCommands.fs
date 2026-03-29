namespace Fes.Tests

open Fes.DSL.Operations
open Xunit

module IngestPipelineCommands =

    [<Fact>]
    let ``Get ingest pipeline request returns correct HTTP call`` () =
        let getReq = ingestGetPipelineRequest {
            id "my_pipeline"
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("RequestUri: '/_ingest/pipeline/my_pipeline'", result)

    [<Fact>]
    let ``Get ingest pipeline request with options returns correct HTTP call`` () =
        let getReq = ingestGetPipelineRequest {
            id "my_pipeline"
            summary true
            master_timeout "30s"
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_ingest/pipeline/my_pipeline", result)
        Assert.Contains("summary=true", result)
        Assert.Contains("master_timeout=30s", result)

    [<Fact>]
    let ``Put ingest pipeline request returns correct HTTP call`` () =
        let putReq = ingestPutPipelineRequest {
            id "my_pipeline"
            description "A test ingest pipeline"
            timeout "30s"
        }

        let result = putReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/_ingest/pipeline/my_pipeline", result)
        Assert.Contains("timeout=30s", result)
        Assert.Contains("Content-Type: application/json", result)

    [<Fact>]
    let ``Put ingest pipeline request with description serializes body`` () =
        let putReq = ingestPutPipelineRequest {
            id "enrichment_pipeline"
            description "Enrich documents"
        }

        let result = putReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/_ingest/pipeline/enrichment_pipeline", result)
        Assert.Contains("\"description\":\"Enrich documents\"", result)

    [<Fact>]
    let ``Put ingest pipeline request with if_version returns correct HTTP call`` () =
        let putReq = ingestPutPipelineRequest {
            id "my_pipeline"
            if_version 2.0
        }

        let result = putReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/_ingest/pipeline/my_pipeline", result)
        Assert.Contains("if_version=2", result)

    [<Fact>]
    let ``Delete ingest pipeline request returns correct HTTP call`` () =
        let deleteReq = ingestDeletePipelineRequest {
            id "my_pipeline"
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("RequestUri: '/_ingest/pipeline/my_pipeline'", result)

    [<Fact>]
    let ``Delete ingest pipeline request with options returns correct HTTP call`` () =
        let deleteReq = ingestDeletePipelineRequest {
            id "my_pipeline"
            timeout "30s"
            master_timeout "60s"
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/_ingest/pipeline/my_pipeline", result)
        Assert.Contains("timeout=30s", result)
        Assert.Contains("master_timeout=60s", result)
