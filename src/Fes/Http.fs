namespace Fes

open System.Net.Http
open System.Threading.Tasks

[<RequireQualifiedAccess>]
module Http =
    open System
    open System.Text

    type RequestMsg = HttpRequestMessage
    type ResponseMsg = HttpResponseMessage

    type Method =
    | Get
    | Post
    | Put
    | Patch
    | Delete
    | Head
    | Options
    | Trace
    with
        static member toNetMethod = function
            | Get -> HttpMethod.Get
            | Post -> HttpMethod.Post
            | Put -> HttpMethod.Put
            | Patch -> HttpMethod.Patch
            | Delete -> HttpMethod.Delete
            | Head -> HttpMethod.Head
            | Options -> HttpMethod.Options
            | Trace -> HttpMethod.Trace

    /// Converts a value to a query string representation suitable for Elasticsearch
    /// Booleans are converted to lowercase "true"/"false"
    let inline toQueryValue (v: 'a) : string =
        match box v with
        | :? bool as b -> if b then "true" else "false"
        | _ -> string v

    module Request =
        let fromPath (path: string) =
            let request = new RequestMsg()
            request.RequestUri <- Uri(path, UriKind.Relative)
            request

        let inline withMethod method (request: RequestMsg) =
            request.Method <- Method.toNetMethod method
            request

        let inline withJson body (request: RequestMsg) =
            request.Content <- new StringContent(body, Encoding.UTF8, "application/json")
            request

        let inline withJsonBody body =
            Json.serialize body
            |> withJson


    module Response =

        let inline asString (response: ResponseMsg) =
            response.Content.ReadAsStringAsync()
            |> TaskResult.ofTask

        let inline toResult (response: ResponseMsg) =
            let body = asString response
            if response.IsSuccessStatusCode then
                body
                |> TaskResult.bind JsonRes.ofString
            else
                body
                |> TaskHelpers.map (Result.bind ElasticsearchException.ofString)
                |> TaskHelpers.map (function | Ok e -> e :> exn |> Error | Error e -> Error e)

    let inline toRequest x =
        (^T : (static member ToRequest: ^T -> Result<RequestMsg, exn>) x)

[<RequireQualifiedAccess>]
module ElasticsearchClient =
    type HttpCall = HttpRequestMessage -> TaskResult<HttpResponseMessage, exn>

    let inline execute (httpCall: HttpCall) : 'fesRequest -> TaskResult<'fesResponse, exn> =
        let inReq = fun (req: 'fesRequest) -> Http.toRequest req |> TaskHelpers.retn
        httpCall
        |> TaskResult.bindOut Http.Response.toResult
        |> TaskResult.bindIn inReq
