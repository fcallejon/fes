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
        static member ToEndpoint(req: ProjectCreateManyRoutingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_project_routing"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

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
        static member ToEndpoint(req: ProjectCreateRoutingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_project_routing/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

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
        static member ToEndpoint(req: ProjectDeleteRoutingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_project_routing/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: ProjectGetManyRoutingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_project_routing"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type ProjectGetManyRoutingResponse = Types.NamedProjectRoutingExpressions

    type ProjectGetRoutingRequest = {
        Name: string
    }

        with
        static member ToEndpoint(req: ProjectGetRoutingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_project_routing/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: ProjectTagsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_project/tags"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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

