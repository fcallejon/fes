// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module ProjectOperations =

    type ProjectCreateManyRoutingRequest = {
        Document: obj
    }

        with
        static member ToRequest(req: ProjectCreateManyRoutingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_project_routing"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type ProjectCreateManyRoutingResponse = Types.AcknowledgedResponseBase

    type ProjectCreateManyRoutingRequestBuilder() =
        member _.Yield(_: unit) : ProjectCreateManyRoutingRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: ProjectCreateManyRoutingRequest, value) =
            { state with Document = value }

    let projectCreateManyRoutingRequest = ProjectCreateManyRoutingRequestBuilder()

    type ProjectCreateRoutingRequest = {
        Name: string
        Document: obj
    }

        with
        static member ToRequest(req: ProjectCreateRoutingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_project_routing/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type ProjectCreateRoutingResponse = Types.AcknowledgedResponseBase

    type ProjectCreateRoutingRequestBuilder() =
        member _.Yield(_: unit) : ProjectCreateRoutingRequest =
            {
                Name = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: ProjectCreateRoutingRequest, value: string) =
            { state with Name = value }

        [<CustomOperation("document")>]
        member _.Document(state: ProjectCreateRoutingRequest, value) =
            { state with Document = value }

    let projectCreateRoutingRequest = ProjectCreateRoutingRequestBuilder()

    type ProjectDeleteRoutingRequest = {
        Name: string
    }

        with
        static member ToRequest(req: ProjectDeleteRoutingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_project_routing/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type ProjectDeleteRoutingResponse = Types.AcknowledgedResponseBase

    type ProjectDeleteRoutingRequestBuilder() =
        member _.Yield(_: unit) : ProjectDeleteRoutingRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: ProjectDeleteRoutingRequest, value: string) =
            { state with Name = value }

    let projectDeleteRoutingRequest = ProjectDeleteRoutingRequestBuilder()

    type ProjectGetManyRoutingRequest = | ProjectGetManyRoutingRequest

        with
        static member ToRequest(req: ProjectGetManyRoutingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_project_routing"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ProjectGetManyRoutingResponse = Types.NamedProjectRoutingExpressions

    type ProjectGetManyRoutingRequestBuilder() =
        member _.Yield(_: unit) : ProjectGetManyRoutingRequest =
            {
            }

    let projectGetManyRoutingRequest = ProjectGetManyRoutingRequestBuilder()

    type ProjectGetRoutingRequest = {
        Name: string
    }

        with
        static member ToRequest(req: ProjectGetRoutingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_project_routing/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ProjectGetRoutingResponse = Types.ProjectRoutingExpression

    type ProjectGetRoutingRequestBuilder() =
        member _.Yield(_: unit) : ProjectGetRoutingRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: ProjectGetRoutingRequest, value: string) =
            { state with Name = value }

    let projectGetRoutingRequest = ProjectGetRoutingRequestBuilder()

    type ProjectTagsRequest = {
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToRequest(req: ProjectTagsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_project/tags"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ProjectTagsResponse = Types.ProjectTags

    type ProjectTagsRequestBuilder() =
        member _.Yield(_: unit) : ProjectTagsRequest =
            {
                ProjectRouting = None
            }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: ProjectTagsRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let projectTagsRequest = ProjectTagsRequestBuilder()

    module Tags =
        let withProjectRouting (value: Types.ProjectRouting) (req: ProjectTagsRequest) =
            { req with ProjectRouting = Some value }

