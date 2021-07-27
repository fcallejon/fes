namespace Fes

type QueryParameter = string * obj

[<RequireQualifiedAccess>]
module QueryParameter =
    open System.Web
    
    let inline toString (qp: QueryParameter) =
        let key, value =
            let k, v = qp
            HttpUtility.UrlEncode k, v |> (string >> HttpUtility.UrlEncode)
        $"%s{key}=%s{value}"

[<AutoOpen>]
module QueryParams =
    open System
    
    let inline toQueryParams x =
        (^T: (static member ToQueryParams : ^T -> Result<string, exn>) x)
        
    let inline queryParamsOfOption x =
        x
        |> Option.map toQueryParams
        |> Option.defaultValue (Ok String.Empty)
    
    module Builder =
        let inline qparam (key: string) value = Some <| QueryParameter(key, value)
        
        let inline qparamOpt (key: string) =
             function
             | Some value -> qparam key value
             | _ -> None
        
        let inline qparams (qps: seq<option<QueryParameter>>) =
            let v =
                qps
                |> Seq.choose id
                |> Seq.map QueryParameter.toString
            in String.Join("&", v) |> sprintf "?%s"
            |> Ok
            
        module Operators =
            let inline (&=) k v = qparam k v
            let inline (&=?) k v = qparamOpt k v