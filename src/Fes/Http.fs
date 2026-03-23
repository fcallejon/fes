namespace Fes

open System.Net.Http
open System.Net.Http.Json
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

        /// Deserialises the HTTP response.
        /// Success path: streams JSON directly from the response content, avoiding an intermediate string allocation.
        /// Error path: reads the body as a string to preserve raw JSON in the ElasticsearchException.
        let inline toResult (response: ResponseMsg) : TaskResult<'a, exn> =
            if response.IsSuccessStatusCode then
                response.Content.ReadFromJsonAsync<'a>(JsonSettings.options)
                |> TaskResult.ofTask
            else
                response.Content.ReadAsStringAsync()
                |> TaskResult.ofTask
                |> TaskHelpers.map (fun r ->
                    match r with
                    | Ok s ->
                        match ElasticsearchException.ofString s with
                        | Ok e -> Error (e :> exn)
                        | Error parseError -> Error parseError
                    | Error e -> Error e)

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
