module Fes.Generator.Analysis.Namespacing

open System
open Fes.Generator.Schema

let private fsharpKeywords =
    set [
        "abstract"; "and"; "as"; "assert"; "base"; "begin"; "class"; "default"
        "delegate"; "do"; "done"; "downcast"; "downto"; "elif"; "else"; "end"
        "exception"; "extern"; "false"; "finally"; "fixed"; "for"; "fun"; "function"
        "global"; "if"; "in"; "inherit"; "inline"; "interface"; "internal"; "lazy"
        "let"; "match"; "member"; "module"; "mutable"; "namespace"; "new"; "not"
        "null"; "of"; "open"; "or"; "override"; "private"; "public"; "rec"
        "return"; "select"; "static"; "struct"; "then"; "to"; "true"; "try"
        "type"; "upcast"; "use"; "val"; "void"; "when"; "while"; "with"; "yield"
        "asr"; "land"; "lor"; "lsl"; "lsr"; "lxor"; "mod"; "sig"
    ]

/// Escape an F# keyword by appending a tick
let escapeKeyword (name: string) =
    if fsharpKeywords.Contains name then name + "'"
    else name

/// Convert a string to PascalCase
let toPascalCase (s: string) =
    let sanitised =
        s.Replace(">=", "Gte").Replace("<=", "Lte").Replace(">", "Gt").Replace("<", "Lt")
         .Replace("@", "At").Replace("#", "Hash").Replace("$", "Dollar")
         .Replace("%", "Percent").Replace("&", "And").Replace("*", "Star")
         .Replace("+", "Plus").Replace("=", "Eq").Replace("!", "Bang")
         .Replace("?", "Question").Replace("/", "_").Replace("\\", "_")
         .Replace(":", "_").Replace(";", "_").Replace(",", "_")
         .Replace("'", "").Replace("\"", "")
         .Replace("(", "").Replace(")", "")
         .Replace("[", "").Replace("]", "")
         .Replace("{", "").Replace("}", "")
    sanitised.Split([| '_'; '-'; '.'; ' ' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun part ->
        if part.Length > 0 then
            Char.ToUpperInvariant(part[0]).ToString() + part.Substring(1)
        else "")
    |> String.concat ""

/// Convert a string to camelCase
let toCamelCase (s: string) =
    let pascal = toPascalCase s
    if pascal.Length > 0 then
        Char.ToLowerInvariant(pascal[0]).ToString() + pascal.Substring(1)
    else ""

/// Map an ES namespace to an F# module name
/// _types.query_dsl → QueryDsl
/// _global.search → Search
/// _types → Types
/// indices._types → IndicesTypes
/// ml._types → MlTypes
let toModuleName (ns: string) =
    ns.Split('.')
    |> Array.map (fun part -> part.TrimStart('_'))
    |> Array.filter (fun p -> p.Length > 0)
    |> Array.map toPascalCase
    |> String.concat ""

/// Get the F# module name for a TypeName's namespace
let moduleForType (tn: TypeName) = toModuleName tn.Namespace

/// Get a clean F# type name from the schema name
let toFSharpTypeName (name: string) = toPascalCase name

/// Get a clean F# record field name from a property name
let toFieldName (name: string) =
    let pascal = toPascalCase name
    escapeKeyword pascal

/// Get a clean F# function/let binding name
let toFunctionName (name: string) =
    let camel = toCamelCase name
    escapeKeyword camel

/// Get the output file path for a type's namespace
/// _types.query_dsl → Types/QueryDsl.g.fs
let toTypeFilePath (ns: string) =
    let moduleName = toModuleName ns
    $"Types/{moduleName}.g.fs"

/// Get the output file path for an endpoint
/// search → Operations/Search.g.fs
/// indices.create → Operations/Indices.g.fs
let toOperationFilePath (endpointName: string) =
    let parts = endpointName.Split('.')
    let moduleName = toPascalCase parts[0]
    $"Operations/{moduleName}.g.fs"

/// Map the endpoint name to ES module path
/// search → ES.search
/// indices.create → ES.Indices.create
/// async_search.submit → ES.AsyncSearch.submit
let toEndpointFunctionPath (endpointName: string) =
    let parts = endpointName.Split('.')
    match parts with
    | [| name |] -> $"ES.{toFunctionName name}"
    | [| ns; name |] -> $"ES.{toPascalCase ns}.{toFunctionName name}"
    | _ -> $"ES.{endpointName |> toPascalCase |> toFunctionName}"
