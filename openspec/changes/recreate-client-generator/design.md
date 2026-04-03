## Context

FEs is an F# Elasticsearch client library aiming for an ergonomic, FsHttp-inspired DSL. The current generator is a 1,778-line `.fsx` script that parses an OpenAPI YAML spec — itself a lossy derivative of the canonical `elasticsearch-specification` metamodel (`schema.json`). This lossiness causes variant types to degrade into flat records with 80+ optional fields, integers to become floats, and union types to require `box` coercions.

The elasticsearch-specification repo (`elastic/elasticsearch-specification`) compiles TypeScript API definitions into `schema.json` — a structured metamodel with 589 endpoints and ~3,800 types including proper variant annotations, generics, shortcut properties, and behaviours. The internal .NET client generator (not public) consumes this directly. We will do the same.

Current generated output: ~150K lines across `Types.g.fs` + 30 `*.Operations.g.fs` files with flat CE builders per request type.

## Goals / Non-Goals

**Goals:**
- Replace the OpenAPI-based generator with a proper F# project consuming `schema.json` directly
- Generate idiomatic F# types: DUs for container/internal-tag variants, proper enums, generics
- Produce an FsHttp-inspired verb-first DSL (Option D) with nested CEs for domain types
- Cover all 589 endpoints in the specification
- Generate JSON serialisation converters for variant types (DU ↔ JSON container/tagged encoding)
- Vendor `schema.json` with a build-time refresh mechanism
- Preserve the existing `Http.fs` / `Client` / `Json.fs` core where possible

**Non-Goals:**
- C# interop (may come later, not in scope)
- Type provider approach (too fragile for this scale)
- Supporting multiple ES versions simultaneously (one schema.json at a time)
- Generating tests (tests will be written manually against the new DSL)
- Response streaming or bulk API optimisations (existing behaviour kept)

## Decisions

### D1: Consume `schema.json` directly instead of OpenAPI

**Choice**: Parse the elasticsearch-specification `schema.json` metamodel directly.

**Why not OpenAPI**: The OpenAPI conversion (done by `compiler-rs/clients_schema_to_openapi`) is lossy. It discards variant strategies (`container`, `internal_tag`, `external_tag`, `untagged`), `shortcutProperty`, behaviours, `esQuirk`, integer vs number distinction, and availability annotations. These are exactly the features needed for ergonomic F# DUs and smart constructors.

**Why not TypeScript specs**: The TS files are a DSL that requires ts-morph to parse. `schema.json` is the compiled, stable contract designed for client generators.

### D2: F# DUs for container variants (QueryContainer, AggregationContainer, Property)

**Choice**: Container variant types become F# discriminated unions. Each non-`containerProperty` field becomes a DU case. `containerProperty` fields become a separate metadata record.

**Why**: This is the single biggest ergonomic win. Instead of constructing an 80-field record with 79 `Option.None` values, users write `Query.Term (field, query)` or `Agg.Terms termsConfig`.

**Alternatives considered**:
- Keep as records with options → rejected, this is the core problem we're solving
- Use `Choice` types → rejected, doesn't scale to 50+ cases
- Use an interface hierarchy → rejected, not idiomatic F#

**JSON round-trip**: Container variants serialise as `{ "case_name": { ...case_value... } }`. We generate a `JsonConverter<Query>` that writes the single active case as a single-key object and reads by inspecting which key is present.

### D3: Verb-first API with nested CEs (Option D)

**Choice**: Top-level API is `ES.search`, `ES.index`, `ES.get`, etc. Complex operations get CE builders. Simple operations are plain functions. Domain types (queries, aggregations, mappings) get their own nested CEs and smart constructors.

```
ES.search<'T> "index" { ... }    → SearchRequest with CE
ES.get<'T> "index" "id"          → plain function
Query.bool { ... }                → nested CE
Query.term "field" value          → smart constructor (from shortcutProperty)
Agg.terms { ... }                 → nested CE
Mapping.keyword ()                → smart constructor
```

**Why over unified CE (Option A)**: A single `es { }` CE would expose all 400+ endpoints' custom operations everywhere — no compile-time safety.

**Why over per-request CE only (current)**: Current approach lacks domain-type builders (queries, aggs, mappings must be constructed as raw records). Verb-first + nested CEs gives progressive disclosure.

### D4: Generator as a proper F# project

**Choice**: `Fes.Generator` as a separate `.fsproj` in the solution, not an `.fsx` script.

**Why**:
- Testable: can unit-test individual emitters
- Maintainable: modules with clear responsibilities
- Debuggable: proper IDE support, breakpoints
- Performant: compiled, can use parallel emission

**Structure**:
```
Fes.Generator/
  Schema/
    Metamodel.fs       — F# types mirroring schema.json
    SchemaReader.fs    — Deserialise schema.json → Metamodel
  Analysis/
    TypeResolver.fs    — Type index, reference resolution
    DependencyGraph.fs — Topological sort for declaration order
    Namespacing.fs     — ES namespaces → F# module hierarchy
  Emitters/
    TypeEmitter.fs     — DUs, records, enums, type aliases
    OperationEmitter.fs — ES.* functions + request CEs
    BuilderEmitter.fs  — Smart constructors + domain CEs
    SerialiserEmitter.fs — JsonConverters for DUs
    FSharpWriter.fs    — Indentation-aware source writer
  Program.fs           — CLI: dotnet run --project Fes.Generator -- [--schema path] [--output path]
```

### D5: SingleKeyDictionary → named tuple in DU case

**Choice**: Schema properties marked with `singleKey: true` on `dictionary_of` (like `term`, `match`, `range`) encode as `CaseName of field: Field * CaseType`.

```fsharp
type Query =
    | Term of field: Field * TermQuery
    | Match of field: Field * MatchQuery
    | Bool of BoolQuery             // no field key
```

**Why**: This matches the Elasticsearch JSON encoding `{ "term": { "field_name": { "value": ... } } }` and gives users a natural way to specify the target field.

### D6: Separate body/query params via request record design

**Choice**: Generated request types separate path parameters (required positional args to `ES.*` functions), query parameters (CE custom operations or pipe functions), and body properties (CE custom operations after implicit body context).

```fsharp
// Path params → function args
ES.search<Product> "products" {    // "products" is the index path param
    // Query params
    routing "shard_1"
    // Body properties
    query (Query.matchAll ())
    size 10
}
```

**Why**: The schema.json request type explicitly separates `path`, `query`, and `body` — we can generate clean separation rather than the current flat mix with `BodySize`/`Size` duplicates.

### D7: schema.json vendoring + refresh

**Choice**: Vendor `schema.json` at `schema/elasticsearch-schema.json`. Provide a script/target to download the latest from the elasticsearch-specification repo's release artifacts.

**Why**: Vendoring ensures reproducible builds. Refresh mechanism allows staying current. Same pattern as the current OpenAPI YAML but with the canonical source.

## Risks / Trade-offs

**[Risk] schema.json is large and complex (~3,800 types)** → Mitigation: Start with core type mapping and a subset of emitters. The generator architecture is modular — each emitter can be developed and tested independently. Full 589-endpoint coverage is the goal but incremental progress is viable.

**[Risk] JSON serialisation of F# DUs is non-trivial** → Mitigation: Generate custom `JsonConverter<T>` per DU. Container variants use single-key object encoding. Internal-tag variants use the tag field for discrimination. `FSharp.SystemTextJson` handles basic cases; custom converters handle ES-specific patterns.

**[Risk] Breaking change — all existing user code stops compiling** → Mitigation: This is on a feature branch. The library is pre-1.0 and the current DSL has known ergonomic issues. A clean break is preferable to compatibility shims.

**[Risk] Some schema.json patterns may be hard to map to F#** → Mitigation: `user_defined_value` → `JsonElement`; `untagged` variants → erased union with runtime discrimination; `AdditionalProperties` behaviour → extra `Map<string, JsonElement>` field. Edge cases handled pragmatically, not perfectly.

**[Risk] Circular type references in the schema** → Mitigation: The current generator already handles this with F# `and` keyword for mutual recursion. The new generator's `DependencyGraph.fs` will detect cycles and group mutually-recursive types.

**[Trade-off] Generated code verbosity vs readability** → Generated files will be larger (custom converters, smart constructors, CEs) but the user-facing API will be dramatically simpler. Generated code doesn't need to be pretty — it needs to be correct and produce a good API.
