namespace Fes

/// HTTP utilities used by generated operation code
[<RequireQualifiedAccess>]
module Http =

    /// Converts a value to a query string representation suitable for Elasticsearch.
    /// Booleans are converted to lowercase "true"/"false".
    /// Lists are comma-separated (ES multi-value query param convention).
    let inline toQueryValue (v: 'a) : string =
        match box v with
        | :? bool as b -> if b then "true" else "false"
        | :? (string list) as lst -> lst |> String.concat ","
        | _ ->
            let boxed = box v
            let t = boxed.GetType()
            if t.IsGenericType && t.GetGenericTypeDefinition() = typedefof<_ list> then
                // Handle list<'T> for non-string element types (e.g. enum DU lists)
                let items = boxed :?> System.Collections.IEnumerable
                [ for item in items -> string item ] |> String.concat ","
            else
                string v

    /// Converts a value to a path segment string.
    /// Handles DU types like Indices, NodeIds, Ids that wrap strings or string lists,
    /// and bare F# lists from union-resolved T|T[] types.
    let toPathSegment (v: obj) : string =
        match v with
        | :? string as s -> s
        | :? (string list) as lst -> lst |> String.concat ","
        | _ ->
            let t = v.GetType()
            if t.IsGenericType && t.GetGenericTypeDefinition() = typedefof<_ list> then
                let items = v :?> System.Collections.IEnumerable
                [ for item in items -> string item ] |> String.concat ","
            elif Microsoft.FSharp.Reflection.FSharpType.IsUnion(t) then
                let _, fields = Microsoft.FSharp.Reflection.FSharpValue.GetUnionFields(v, t)
                match fields with
                | [| :? string as s |] -> s
                | [| :? (string list) as lst |] -> lst |> String.concat ","
                | _ -> string v
            else
                string v
