namespace Fes

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
            printfn $"%s{json}"
            request.Content <- new StringContent(json, Encoding.UTF8, "application/json")
            request

    
    module Response =
        
        let inline toJson (response: ResponseMsg) =
            response.Content.ReadAsStringAsync()
            |> AsyncResult.waitOfTask
            |> AsyncResult.bind JsonRes.ofString
            
        let inline asString (response: ResponseMsg) =
            response.Content.ReadAsStringAsync()
            |> AsyncResult.waitOfTask
        
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
      
    let inline run req (client: HttpClient) =
        let inline _run msg = async {
            let! res = client.SendAsync msg |> Async.AwaitTask
            return! res |> Response.toResult }

        (toRequest >> Async.retn) req
        |> AsyncResult.bind _run
        