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
