namespace Fes

open System.Net.Http
open System.Threading.Tasks

[<RequireQualifiedAccess>]
module Http =
    open System
    open System.Text

    /// Alias for HttpRequestMessage.
    type RequestMsg = HttpRequestMessage
    /// Alias for HttpResponseMessage.
    type ResponseMsg = HttpResponseMessage

    /// HTTP methods supported by the Elasticsearch client.
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

    /// Converts a value to a query string representation suitable for Elasticsearch.
    /// Booleans are converted to lowercase "true"/"false".
    let inline toQueryValue (v: 'a) : string =
        match box v with
        | :? bool as b -> if b then "true" else "false"
        | _ -> string v

    /// Helpers for constructing HTTP request messages.
    module Request =
        /// Creates a new request with the given relative URI path.
        let fromPath (path: string) =
            let request = new RequestMsg()
            request.RequestUri <- Uri(path, UriKind.Relative)
            request

        /// Sets the HTTP method on the request.
        let inline withMethod method (request: RequestMsg) =
            request.Method <- Method.toNetMethod method
            request

        /// Sets the request body to the given JSON string with UTF-8 encoding.
        let inline withJson body (request: RequestMsg) =
            request.Content <- new StringContent(body, Encoding.UTF8, "application/json")
            request

        /// Serializes body to JSON and sets it as the request content.
        let inline withJsonBody body =
            Json.serialize body
            |> withJson


    /// Helpers for reading HTTP response messages.
    module Response =

        /// Reads the response content as a string, wrapping any exception in Error.
        let inline asString (response: ResponseMsg) =
            response.Content.ReadAsStringAsync()
            |> TaskResult.ofTask

        /// Converts an HTTP response to a typed TaskResult.
        /// Success responses are deserialized as 'a; error responses are parsed as ElasticsearchException.
        let inline toResult (response: ResponseMsg) =
            let body = asString response
            if response.IsSuccessStatusCode then
                body
                |> TaskResult.bind JsonRes.ofString
            else
                body
                |> TaskHelpers.map (Result.bind ElasticsearchException.ofString)
                |> TaskHelpers.map (function | Ok e -> e :> exn |> Error | Error e -> Error e)

    /// Invokes the static ToRequest member on a request type via static member constraint.
    let inline toRequest x =
        (^T : (static member ToRequest: ^T -> Result<RequestMsg, exn>) x)

[<RequireQualifiedAccess>]
module ElasticsearchClient =
    /// A function that sends an HTTP request and returns the response as a TaskResult.
    type HttpCall = HttpRequestMessage -> TaskResult<HttpResponseMessage, exn>

    /// Builds a function that converts a typed Fes request to a typed Fes response,
    /// using the provided HTTP call function to perform the network request.
    let inline execute (httpCall: HttpCall) : 'fesRequest -> TaskResult<'fesResponse, exn> =
        let inReq = fun (req: 'fesRequest) -> Http.toRequest req |> TaskHelpers.retn
        httpCall
        |> TaskResult.bindOut Http.Response.toResult
        |> TaskResult.bindIn inReq
