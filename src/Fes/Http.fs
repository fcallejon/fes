namespace Fes

/// HTTP utilities used by generated operation code
[<RequireQualifiedAccess>]
module Http =

    /// Converts a value to a query string representation suitable for Elasticsearch.
    /// Booleans are converted to lowercase "true"/"false".
    let inline toQueryValue (v: 'a) : string =
        match box v with
        | :? bool as b -> if b then "true" else "false"
        | _ -> string v

    /// Converts a value to a path segment string.
    /// Handles DU types like Indices, NodeIds, Ids that wrap strings or string lists.
    let toPathSegment (v: obj) : string =
        match v with
        | :? string as s -> s
        | _ ->
            let t = v.GetType()
            if Microsoft.FSharp.Reflection.FSharpType.IsUnion(t) then
                let _, fields = Microsoft.FSharp.Reflection.FSharpValue.GetUnionFields(v, t)
                match fields with
                | [| :? string as s |] -> s
                | [| :? (string list) as lst |] -> lst |> String.concat ","
                | _ -> string v
            else
                string v
