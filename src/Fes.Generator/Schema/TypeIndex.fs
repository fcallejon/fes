module Fes.Generator.Schema.TypeIndex

open Fes.Generator.Schema

type TypeIndex = {
    ByName: Map<TypeName, TypeDefinition>
    Endpoints: Endpoint list
    EndpointsToGenerate: Endpoint list
    NameMap: Map<TypeName, string>
}

let build (model: Model) : TypeIndex =
    let byName =
        model.Types
        |> List.map (fun t -> TypeDefinition.name t, t)
        |> Map.ofList

    let toGenerate =
        model.Endpoints
        |> List.filter (fun e -> not e.CodegenExclude)

    { ByName = byName
      Endpoints = model.Endpoints
      EndpointsToGenerate = toGenerate
      NameMap = Map.empty }

let withNameMap (nameMap: Map<TypeName, string>) (index: TypeIndex) : TypeIndex =
    { index with NameMap = nameMap }

let tryResolve (index: TypeIndex) (name: TypeName) : TypeDefinition option =
    Map.tryFind name index.ByName

let resolve (index: TypeIndex) (name: TypeName) : TypeDefinition =
    match tryResolve index name with
    | Some t -> t
    | None ->
        eprintfn $"Warning: unresolvable type reference: {name.Namespace}.{name.Name}"
        // Return a dummy empty interface so generation can continue
        TypeDefinition.Interface {
            Name = name; Properties = []; Inherits = None
            Generics = []; Variants = None; ShortcutProperty = None
            Behaviours = []; Description = None
        }
