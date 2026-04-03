## Why

The current code generator consumes an OpenAPI spec (`esapi.2025-01.yaml`) which is a lossy derivation of Elasticsearch's canonical `schema.json` metamodel. This lossiness causes real problems: variant types (QueryContainer, AggregationContainer) become flat records with 80+ `Option.None` fields instead of proper discriminated unions; integer types collapse to `float`; shortcut properties, behaviours, and ES-specific annotations are lost. The generated DSL is verbose and unergonomic — users must `box` values for union types, manually construct enormous records, and navigate flat prefixed type names like `AggregationsTermsAggregation`.

We need to rebuild the generator from scratch: consume `schema.json` directly, produce an FsHttp-inspired DSL (Option D: verb-first functions + nested CEs), and restructure the generator as a proper F# project instead of a 1,778-line `.fsx` monolith.

## What Changes

- **BREAKING**: Replace entire generated DSL surface — all `*.g.fs` files regenerated with new types, modules, and API shape
- **BREAKING**: Remove OpenAPI-based generator (`scripts/generate-dsl.fsx`) and vendored `esapi.2025-01.yaml`
- New `Fes.Generator` F# project that reads `schema.json` and emits F# source
- Container variant types (`QueryContainer`, `AggregationContainer`, `Property`) become F# discriminated unions
- Internal tag variants become F# DUs with JSON discriminator support
- Open enums get an `| Other of string` case
- Generics preserved (e.g., `SearchResponse<'TDocument>`)
- Smart constructors generated from `shortcutProperty` annotations
- Verb-first API: `ES.search`, `ES.index`, `ES.get`, `ES.delete`, `ES.Indices.create`, etc.
- Per-operation CEs for complex requests (search, index), plain functions for simple ones (get, delete)
- Nested CEs for domain types: `Query.bool { }`, `Agg.terms { }`, `Mapping.text ()`
- Pipe-friendly alternative: `ES.search "idx" |> Search.withQuery q |> ES.send client`
- `schema.json` vendored in repo with build-time refresh option
- `integer` types correctly map to `int` (not `float`)
- Namespaced modules (`QueryDsl`, `Aggregations`, `Mapping`) replace flat prefixed names

## Capabilities

### New Capabilities
- `schema-reader`: Parse and deserialise the elasticsearch-specification `schema.json` metamodel into F# domain types
- `type-emitter`: Generate F# types (DUs, records, enums, type aliases) from the metamodel, handling variants, generics, and inheritance
- `operation-emitter`: Generate verb-first API functions (`ES.*`) and per-operation CE builders from endpoint definitions
- `builder-emitter`: Generate smart constructors and nested CEs for domain types (queries, aggregations, mappings) using shortcutProperty and variant annotations
- `dsl-design`: The user-facing DSL shape — verb-first functions, CEs, pipe API, type ergonomics

### Modified Capabilities

## Impact

- **Generated code**: All `src/Fes/DSL/` files replaced — new directory structure under `src/Fes/Generated/`
- **Fes.fsproj**: Compilation order updated for new generated file layout
- **Tests**: All existing tests (`Fes.Tests/Commands/*.fs`) must be rewritten for new DSL
- **Sample**: `Fes.Sample/Program.fs` must be rewritten
- **Dependencies**: `System.Text.Json` for schema.json parsing in generator; `FSharp.SystemTextJson` remains for runtime serialisation
- **Build**: New `Fes.Generator` project added to solution; generator invoked as build step or manual command
- **Scripts**: `scripts/generate-dsl.fsx` and `scripts/esapi.2025-01.yaml` removed
