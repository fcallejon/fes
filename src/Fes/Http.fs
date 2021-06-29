namespace Fes

open Fes
open Fes.Exceptions

[<RequireQualifiedAccess>]
module Http =
    open System
    open System.Net.Http
    open System.Text
    open FSharpPlus
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
    
    [<AutoOpen>]
    module Request =
        let mk (path: string) =
            let request = new RequestMsg()
            request.RequestUri <- Uri(path, UriKind.Relative)
            request

        let inline withFullUri uri (request: RequestMsg) =
            request.RequestUri <- uri
            request
            
        let inline withMethod method (request: RequestMsg) =
            request.Method <- Method.toNetMethod method
            request
          
        let inline withJsonBody body (request: RequestMsg) =
            let json = toJson body |> string
            request.Content <- new StringContent(json, Encoding.UTF8, "application/json")
            request
            
    module Response =        
        let toResult (response: AsyncResult<ResponseMsg, exn>) =
            response
            |> AsyncResult.map
                (fun res ->
                    async {
                        let! body = res.Content.ReadAsStringAsync() |> Async.AwaitTask
                        try
                            res.EnsureSuccessStatusCode() |> ignore
                            return Ok body
                        with
                        | ex when String.IsNullOrWhiteSpace(body) -> return Error ex
                        | fallbackException ->
                            return
                                ElasticsearchException.ofString body
                                |> ElasticsearchException.withDefaultException fallbackException
                    })
            |> AsyncResult.bind id
                    
                
    
    let mkClient =
      let client = new HttpClient()
      client
      
    let fromBaseUri uri =
      let client = mkClient
      client.BaseAddress <- uri
      client
      
    let run req (client: HttpClient) =
        client.SendAsync req
        |> Async.AwaitTask
        |> Async.Catch
        |> Async.map Result.ofChoice
        |> Response.toResult