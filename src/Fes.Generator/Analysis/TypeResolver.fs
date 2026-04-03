module Fes.Generator.Analysis.TypeResolver

open Fes.Generator.Schema
open Fes.Generator.Analysis.Namespacing

/// Builtins from the _builtins namespace mapped to F# types
let private builtinMap =
    Map.ofList [
        "string", "string"
        "boolean", "bool"
        "integer", "int"
        "long", "int64"
        "float", "float32"
        "double", "float"
        "number", "float"
        "null", "unit"
        "binary", "byte array"
        "void", "unit"
    ]

/// Check if a TypeName is a builtin
let isBuiltin (tn: TypeName) = tn.Namespace = "_builtins"

/// Resolve a builtin TypeName to its F# type string
let resolveBuiltin (tn: TypeName) =
    Map.tryFind tn.Name builtinMap
    |> Option.defaultValue "obj"

/// Context for resolving types, carrying the set of generic parameter names in scope
type ResolveContext = {
    GenericParams: Set<string>
    TypeIndex: TypeIndex.TypeIndex
    CurrentNamespace: string option
    NameMap: Map<TypeName, string>
}

/// Check if a TypeName refers to a generic parameter in scope
let isGenericParam (ctx: ResolveContext) (tn: TypeName) =
    ctx.GenericParams.Contains tn.Name

/// Resolve a ValueOf to an F# type string
let rec resolveValueOf (ctx: ResolveContext) (v: ValueOf) : string =
    match v with
    | ValueOf.InstanceOf (tn, generics) ->
        if isBuiltin tn then
            resolveBuiltin tn
        elif isGenericParam ctx tn then
            $"'{toCamelCase tn.Name}"
        else
            // Look up the disambiguated name from the name map
            let resolvedName =
                match Map.tryFind tn ctx.NameMap with
                | Some n -> n
                | None -> toFSharpTypeName tn.Name
            // When in the merged all-types context, no prefix needed
            let baseName =
                match ctx.CurrentNamespace with
                | Some "__all__" -> resolvedName
                | _ -> $"Types.{resolvedName}"
            match generics with
            | [] -> baseName
            | gs ->
                let args = gs |> List.map (resolveValueOf ctx) |> String.concat ", "
                $"{baseName}<{args}>"
    | ValueOf.ArrayOf inner ->
        $"{resolveValueOf ctx inner} list"
    | ValueOf.UnionOf items ->
        // For simple two-item unions where one is null/unit, make it option
        match items with
        | [ a; b ] when isNullType a -> $"{resolveValueOf ctx b} option"
        | [ a; b ] when isNullType b -> $"{resolveValueOf ctx a} option"
        | _ ->
            // Fallback: use JsonElement for complex unions without a type_alias wrapper
            "System.Text.Json.JsonElement"
    | ValueOf.DictionaryOf (key, value, _singleKey) ->
        $"Map<{resolveValueOf ctx key}, {resolveValueOf ctx value}>"
    | ValueOf.UserDefinedValue ->
        "System.Text.Json.JsonElement"
    | ValueOf.LiteralValue literal ->
        match literal with
        | LiteralValue.String _ -> "string"
        | LiteralValue.Bool _ -> "bool"
        | LiteralValue.Number _ -> "float"

and private isNullType (v: ValueOf) =
    match v with
    | ValueOf.InstanceOf (tn, _) when tn.Namespace = "_builtins" && tn.Name = "null" -> true
    | _ -> false

/// Create a resolve context from generic parameters
let makeContext (index: TypeIndex.TypeIndex) (generics: TypeName list) : ResolveContext =
    { GenericParams = generics |> List.map _.Name |> Set.ofList
      TypeIndex = index
      CurrentNamespace = None
      NameMap = index.NameMap }

/// Create a resolve context with a current namespace for self-reference resolution
let makeContextInNamespace (index: TypeIndex.TypeIndex) (generics: TypeName list) (ns: string) : ResolveContext =
    { GenericParams = generics |> List.map _.Name |> Set.ofList
      TypeIndex = index
      CurrentNamespace = Some ns
      NameMap = index.NameMap }
