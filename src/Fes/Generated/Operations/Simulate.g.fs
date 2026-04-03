// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module SimulateOperations =

    type SimulateIngestRequest = {
        Index: Types.IndexName
        Pipeline: Types.PipelineName option
        MergeType: Types.MergeType option
        Docs: Types.Document list
        ComponentTemplateSubstitutions: Map<string, Types.ComponentTemplateNode> option
        IndexTemplateSubstitutions: Map<string, Types.IndexTemplate> option
        MappingAddition: Types.TypeMapping option
        PipelineSubstitutions: Map<string, Types.IngestTypesPipeline> option
    }

        with
        static member ToRequest(req: SimulateIngestRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ingest/{req.Index}/_simulate"
                let queryParams =
                    [
                        req.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                        req.MergeType |> Option.map (fun v -> "merge_type", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SimulateIngestResponse = System.Text.Json.JsonElement

    type SimulateIngestRequestBuilder() =
        member _.Yield(_: unit) : SimulateIngestRequest =
            {
                Index = Unchecked.defaultof<_>
                Pipeline = None
                MergeType = None
                Docs = Unchecked.defaultof<_>
                ComponentTemplateSubstitutions = None
                IndexTemplateSubstitutions = None
                MappingAddition = None
                PipelineSubstitutions = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SimulateIngestRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: SimulateIngestRequest, value: Types.PipelineName) =
            { state with Pipeline = Some value }

        [<CustomOperation("mergeType")>]
        member _.MergeType(state: SimulateIngestRequest, value: Types.MergeType) =
            { state with MergeType = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: SimulateIngestRequest, value: Types.Document list) =
            { state with Docs = value }

        [<CustomOperation("componentTemplateSubstitutions")>]
        member _.ComponentTemplateSubstitutions(state: SimulateIngestRequest, value: Map<string, Types.ComponentTemplateNode>) =
            { state with ComponentTemplateSubstitutions = Some value }

        [<CustomOperation("indexTemplateSubstitutions")>]
        member _.IndexTemplateSubstitutions(state: SimulateIngestRequest, value: Map<string, Types.IndexTemplate>) =
            { state with IndexTemplateSubstitutions = Some value }

        [<CustomOperation("mappingAddition")>]
        member _.MappingAddition(state: SimulateIngestRequest, value: Types.TypeMapping) =
            { state with MappingAddition = Some value }

        [<CustomOperation("pipelineSubstitutions")>]
        member _.PipelineSubstitutions(state: SimulateIngestRequest, value: Map<string, Types.IngestTypesPipeline>) =
            { state with PipelineSubstitutions = Some value }

    let simulateIngestRequest = SimulateIngestRequestBuilder()

    module Ingest =
        let withPipeline (value: Types.PipelineName) (req: SimulateIngestRequest) =
            { req with Pipeline = Some value }
        let withMergeType (value: Types.MergeType) (req: SimulateIngestRequest) =
            { req with MergeType = Some value }
        let withDocs (value: Types.Document list) (req: SimulateIngestRequest) =
            { req with Docs = value }
        let withComponentTemplateSubstitutions (value: Map<string, Types.ComponentTemplateNode>) (req: SimulateIngestRequest) =
            { req with ComponentTemplateSubstitutions = Some value }
        let withIndexTemplateSubstitutions (value: Map<string, Types.IndexTemplate>) (req: SimulateIngestRequest) =
            { req with IndexTemplateSubstitutions = Some value }
        let withMappingAddition (value: Types.TypeMapping) (req: SimulateIngestRequest) =
            { req with MappingAddition = Some value }
        let withPipelineSubstitutions (value: Map<string, Types.IngestTypesPipeline>) (req: SimulateIngestRequest) =
            { req with PipelineSubstitutions = Some value }

