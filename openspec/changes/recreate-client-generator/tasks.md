## 1. Project Setup

- [x] 1.1 Create `Fes.Generator` F# project (`dotnet new console -lang F#`), add to solution, add `System.Text.Json` dependency
- [x] 1.2 Create `schema/` directory, download and vendor `elasticsearch-schema.json` from elasticsearch-specification repo
- [x] 1.3 Create refresh script/target to download latest schema.json from upstream
- [x] 1.4 Create `src/Fes/Generated/` directory structure (`Types/`, `Operations/`, `Builders/`)

## 2. Schema Reader (Metamodel)

- [x] 2.1 Define F# metamodel types in `Schema/Metamodel.fs`: Model, Endpoint, TypeDefinition DU, ValueOf DU, Property, TypeName, variant descriptors, Body kinds
- [x] 2.2 Implement `Schema/SchemaReader.fs`: deserialise schema.json into Metamodel using System.Text.Json with custom converters for the discriminated unions (kind-based)
- [x] 2.3 Implement type index builder: `Map<TypeName, TypeDefinition>` for O(1) lookup
- [x] 2.4 Add validation: warn on unresolvable references, report stats (endpoint count, type counts by kind)
- [ ] 2.5 Write tests: round-trip a sample schema fragment, verify type index resolution, verify error on invalid input (deferred)

## 3. Analysis Layer

- [x] 3.1 Implement `Analysis/Namespacing.fs`: map ES namespaces to F# module names (`_types.query_dsl` → `QueryDsl`, `_global.search` → `Search`, etc.), handle reserved words with tick suffix
- [x] 3.2 Implement `Analysis/TypeResolver.fs`: resolve ValueOf references recursively, map builtins (`string`, `boolean`, `integer`, `long`, `float`, `double`, `number`, `null`, `binary`, `void`) to F# types
- [x] 3.3 Implement `Analysis/DependencyGraph.fs`: collect dependencies per type, topological sort, detect and group mutual recursion cycles for `type ... and ...` emission
- [ ] 3.4 Write tests for namespace mapping, builtin resolution, and cycle detection (deferred)

## 4. F# Source Writer

- [x] 4.1 Implement `Emitters/FSharpWriter.fs`: indentation-aware string builder with helpers for `module`, `type`, `member`, `let`, attributes, doc comments, and `and` keyword for mutual recursion

## 5. Type Emitter

- [x] 5.1 Implement enum emission: closed enums as DUs, open enums with `| Custom of string` case, `[<RequireQualifiedAccess>]`
- [x] 5.2 Implement interface-to-record emission: properties to record fields, optional/required handling, `[<JsonPropertyName>]` attributes, PascalCase naming
- [x] 5.3 Implement container variant emission: non-containerProperty fields as DU cases, containerProperty fields as separate metadata record, SingleKeyDictionary → `field: Field` tuple in case, `nonExhaustive` → `| Unknown of string * JsonElement`
- [x] 5.4 Implement internal-tag variant emission: DU cases keyed by tag field value
- [x] 5.5 Implement type alias emission: simple aliases as `type X = Y`, union_of aliases as DUs
- [x] 5.6 Implement generic type parameter threading: emit `<'T>` parameters, resolve generic references to the correct parameter
- [x] 5.7 Integrate dependency graph: emit types in topological order, group cycles with `and`
- [x] 5.8 Emit all types into namespaced `.g.fs` files under `Generated/Types/`
- [ ] 5.9 Write tests: verify generated source for QueryContainer (container variant), BoolQuery (record), SearchType (enum), Duration (alias), SearchResponse (generic) (deferred)

## 6. Serialisation Emitter

- [x] 6.1 Implement container variant `JsonConverter<T>` emission: write single-key object, read by inspecting property names, handle SingleKeyDictionary encoding
- [x] 6.2 Implement internal-tag variant `JsonConverter<T>` emission: read tag field, dispatch to case
- [x] 6.3 Implement enum `JsonConverter<T>` emission: string ↔ DU case mapping, open enum fallback
- [ ] 6.4 Implement union alias `JsonConverter<T>` emission: try-parse each alternative (deferred)
- [x] 6.5 Emit converter registration (JsonSerializerOptions setup) in a `Serialisation.g.fs` file
- [ ] 6.6 Write tests: serialise/deserialise Query, Aggregation, Property, Refresh enum round-trips (deferred)

## 7. Operation Emitter

- [x] 7.1 Implement request type emission per endpoint: separate path, query, and body fields into a clean request record
- [x] 7.2 Implement `ToRequest` emission: path interpolation, query string assembly, HTTP method selection, body serialisation (PropertiesBody → JSON object, ValueBody → serialise value, NoBody → no content)
- [x] 7.3 Implement CE builder emission for PropertiesBody endpoints: `[<CustomOperation>]` per query param and body property
- [x] 7.4 Implement CE builder emission for NoBody endpoints with query params (optional CE for query param configuration)
- [x] 7.5 Implement CE builder emission for ValueBody endpoints: `document` custom operation
- [x] 7.6 Implement `ES.*` function emission: verb-first functions with path params as arguments, returning request values
- [x] 7.7 Implement `ES.Namespace.*` sub-module emission for namespaced endpoints (Indices, Cluster, Nodes, etc.)
- [x] 7.8 Implement pipe-friendly module functions: `Search.withQuery`, `Search.withSize`, `Index.withRefresh`, etc.
- [x] 7.9 Emit all operations into `Generated/Operations/*.g.fs` files
- [ ] 7.10 Write tests: verify generated source for Search (PropertiesBody + CE), Get (NoBody), Index (ValueBody), Indices.Create (namespaced) (deferred)

## 8. Builder Emitter

- [x] 8.1 Implement smart constructor emission from shortcutProperty: module functions like `Query.term`, `Query.match'`
- [x] 8.2 Implement CE builder emission for complex domain types: `boolQuery { }`, `termsAggregation { }`, etc.
- [x] 8.3 Implement convenience variant constructors: `Query.bool`, `Query.matchAll`, `Agg.terms`, `Agg.avg`
- [x] 8.4 Implement mapping builders: `Mapping.text`, `Mapping.keyword`, `Mapping.float'`, `Mapping.boolean`, `Mapping.properties`
- [x] 8.5 Emit all builders into `Generated/Builders/*.g.fs` files
- [ ] 8.6 Write tests: verify generated source for Query builders, Agg builders, Mapping builders (deferred)

## 9. Generator CLI & Integration

- [ ] 9.1 Implement `Program.fs` CLI: `--schema <path>` (default `schema/elasticsearch-schema.json`), `--output <path>` (default `src/Fes/Generated/`), `--clean` flag to remove old `.g.fs` before emitting
- [ ] 9.2 Implement `Fes.fsproj` updater: rewrite `<Compile>` items for generated files in correct dependency order
- [ ] 9.3 Run full generation against vendored schema.json, verify solution compiles
- [ ] 9.4 Remove old generator (`scripts/generate-dsl.fsx`, `scripts/esapi.2025-01.yaml`)
- [ ] 9.5 Remove old generated files (`src/Fes/DSL/`)

## 10. Library Core Updates

- [ ] 10.1 Update `Http.fs` if needed: ensure `toQueryValue` handles new enum DU types, integer types
- [ ] 10.2 Update `Json.fs`: register all generated `JsonConverter`s in serialisation options
- [ ] 10.3 Update or create `Client.fs`: `ES.send` / `ES.connect` wiring, `TaskResult` return types
- [ ] 10.4 Update `Fes.fsproj` target frameworks and package references if needed

## 11. Tests & Sample Update

- [ ] 11.1 Rewrite `Fes.Tests/Commands/SearchCommands.fs` for new DSL
- [ ] 11.2 Rewrite `Fes.Tests/Commands/IndexCommands.fs` for new DSL
- [ ] 11.3 Rewrite `Fes.Tests/Commands/DocumentCommands.fs` for new DSL
- [ ] 11.4 Rewrite `Fes.Tests/Commands/ClusterCommands.fs` for new DSL
- [ ] 11.5 Rewrite remaining test files for new DSL
- [ ] 11.6 Rewrite `Fes.Sample/Program.fs` to showcase new DSL (search, index, get, delete, aggregations, mappings)
- [ ] 11.7 Verify all tests pass and sample runs against a live Elasticsearch instance

## 12. Cleanup & Documentation

- [ ] 12.1 Verify full solution compiles on net6.0, net8.0, net10.0
- [ ] 12.2 Update CI workflow (`.github/workflows/dotnet.yml`) to include generator project
- [ ] 12.3 Run generator as part of CI to verify reproducibility (generated files match committed files)
