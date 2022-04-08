namespace Fes

open System.Net.Http

[<RequireQualifiedAccess>]
module Http =
    open System
    open System.Text
    open Fleece.SystemTextJson
    
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
            toJson body
            |> string
            |> withJson

    
    module Response =
            
        let inline asString (response: ResponseMsg) =
            response.Content.ReadAsStringAsync()
            |> AsyncResult.waitTask
        
        let inline toResult (response: ResponseMsg) =
            let body = asString response
            if response.IsSuccessStatusCode then
                body
                |> AsyncResult.bind JsonRes.ofString
            else
                body
                |> Async.map (Result.bind ElasticsearchException.ofString)
                |> Async.map (function | Ok e -> e :> exn |> Error | Error e -> Error e)

    let inline toRequest x =
        (^T : (static member ToRequest: ^T -> Result<RequestMsg, exn>) x)
      
[<RequireQualifiedAccess>]
module ElasticsearchClient =
    type HttpCall = HttpRequestMessage -> AsyncResult<HttpResponseMessage, exn>
    
    let inline execute (httpCall: HttpCall) : 'fesRequest -> AsyncResult<'fesResponse, exn> =
        let inReq = fun (req: 'fesRequest) -> Http.toRequest req |> Async.retn
        httpCall
        |> AsyncResult.bindOut Http.Response.toResult
        |> AsyncResult.bindIn inReq