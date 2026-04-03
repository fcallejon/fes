module Fes.Generator.Analysis.DependencyGraph

open Fes.Generator.Schema

/// Collect all TypeName references from a ValueOf
let rec private collectValueOfRefs (v: ValueOf) : TypeName list =
    match v with
    | ValueOf.InstanceOf (tn, generics) ->
        if tn.Namespace = "_builtins" then
            generics |> List.collect collectValueOfRefs
        else
            tn :: (generics |> List.collect collectValueOfRefs)
    | ValueOf.ArrayOf inner -> collectValueOfRefs inner
    | ValueOf.UnionOf items -> items |> List.collect collectValueOfRefs
    | ValueOf.DictionaryOf (key, value, _) ->
        collectValueOfRefs key @ collectValueOfRefs value
    | ValueOf.UserDefinedValue -> []
    | ValueOf.LiteralValue _ -> []

/// Collect all TypeName references from a Property
let private collectPropertyRefs (p: Property) : TypeName list =
    collectValueOfRefs p.Type

/// Collect all TypeName references from a Body
let private collectBodyRefs (b: Body) : TypeName list =
    match b with
    | Body.Properties props -> props |> List.collect collectPropertyRefs
    | Body.Value (v, _) -> collectValueOfRefs v
    | Body.NoBody -> []

/// Collect all type dependencies for a TypeDefinition
let collectDependencies (td: TypeDefinition) : TypeName list =
    match td with
    | TypeDefinition.Interface d ->
        let propRefs = d.Properties |> List.collect collectPropertyRefs
        let inheritRefs =
            d.Inherits
            |> Option.map (fun i -> i.Type :: (i.Generics |> List.collect collectValueOfRefs))
            |> Option.defaultValue []
        propRefs @ inheritRefs
    | TypeDefinition.Request d ->
        let pathRefs = d.Path |> List.collect collectPropertyRefs
        let queryRefs = d.Query |> List.collect collectPropertyRefs
        let bodyRefs = collectBodyRefs d.Body
        let inheritRefs =
            d.Inherits
            |> Option.map (fun i -> i.Type :: (i.Generics |> List.collect collectValueOfRefs))
            |> Option.defaultValue []
        pathRefs @ queryRefs @ bodyRefs @ inheritRefs
    | TypeDefinition.Response d ->
        collectBodyRefs d.Body
    | TypeDefinition.Enum _ -> []
    | TypeDefinition.TypeAlias d ->
        collectValueOfRefs d.Type

/// A group of mutually-recursive types that must be emitted together with `and`
type TypeGroup = {
    Types: TypeDefinition list
}

/// Topological sort with cycle detection, grouping cycles into TypeGroups.
/// Returns groups in dependency order (dependencies first).
let topologicalSort (types: TypeDefinition list) : TypeGroup list =
    let nameToType =
        types
        |> List.map (fun t -> TypeDefinition.name t, t)
        |> Map.ofList

    let allNames = nameToType |> Map.keys |> Set.ofSeq

    // Build adjacency list (only to types in our set)
    let deps =
        types
        |> List.map (fun t ->
            let name = TypeDefinition.name t
            let refs =
                collectDependencies t
                |> List.filter (fun r -> Set.contains r allNames)
                |> List.distinct
                // Remove self-references
                |> List.filter (fun r -> r <> name)
            name, refs)
        |> Map.ofList

    // Tarjan's SCC algorithm
    let mutable index = 0
    let mutable stack : TypeName list = []
    let mutable onStack = Set.empty
    let mutable indices = Map.empty
    let mutable lowlinks = Map.empty
    let mutable sccs : TypeName list list = []

    let rec strongconnect (v: TypeName) =
        indices <- Map.add v index indices
        lowlinks <- Map.add v index lowlinks
        index <- index + 1
        stack <- v :: stack
        onStack <- Set.add v onStack

        let successors = Map.tryFind v deps |> Option.defaultValue []
        for w in successors do
            if not (Map.containsKey w indices) then
                strongconnect w
                lowlinks <- Map.add v (min lowlinks[v] lowlinks[w]) lowlinks
            elif Set.contains w onStack then
                lowlinks <- Map.add v (min lowlinks[v] indices[w]) lowlinks

        if lowlinks[v] = indices[v] then
            let mutable scc = []
            let mutable cont = true
            while cont do
                let w = List.head stack
                stack <- List.tail stack
                onStack <- Set.remove w onStack
                scc <- w :: scc
                if w = v then cont <- false
            sccs <- scc :: sccs

    for name in allNames do
        if not (Map.containsKey name indices) then
            strongconnect name

    // sccs is in reverse topological order, reverse it
    sccs
    |> List.rev
    |> List.map (fun scc ->
        { Types =
            scc
            |> List.choose (fun name -> Map.tryFind name nameToType) })
