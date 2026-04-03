## ADDED Requirements

### Requirement: ES module is the primary entry point
All Elasticsearch operations SHALL be accessible through the `ES` module as static functions. Namespaced endpoints use sub-modules (`ES.Indices`, `ES.Cluster`, `ES.Nodes`, etc.).

#### Scenario: Top-level search
- **WHEN** a user writes `ES.search<Product> "products" { query q; size 10 }`
- **THEN** it compiles and produces a valid search request

#### Scenario: Namespaced index creation
- **WHEN** a user writes `ES.Indices.create "products" { mappings m }`
- **THEN** it compiles and produces a valid index creation request

#### Scenario: Discoverability via autocomplete
- **WHEN** a user types `ES.` in an IDE
- **THEN** all available endpoint functions appear grouped by namespace

### Requirement: Progressive disclosure — simple operations need no CE
Operations with no body and few/no query params SHALL work as plain function calls without requiring a CE block.

#### Scenario: Get document
- **WHEN** a user writes `ES.get<Product> "products" "product_1"`
- **THEN** it compiles without a CE block

#### Scenario: Delete index
- **WHEN** a user writes `ES.Indices.delete "products"`
- **THEN** it compiles without a CE block

#### Scenario: Adding optional params via CE
- **WHEN** a user writes `ES.get<Product> "products" "product_1" { routing "shard_1" }`
- **THEN** the CE variant works for adding optional query params

### Requirement: ES.send and ES.sendAsync for execution
`ES.send` SHALL take an `HttpClient` (or an Fes client wrapper) and a request, execute it, and return `TaskResult<'Response, exn>`. An `ES.sendAsync` alias MAY exist for discoverability.

#### Scenario: Pipe to send
- **WHEN** a user writes `ES.search<Product> "idx" { size 10 } |> ES.send client`
- **THEN** it executes the request and returns `TaskResult<SearchResponse<Product>, exn>`

### Requirement: No box coercions for union-typed parameters
Parameters that accept multiple types (e.g., `Indices` = string or string array, `TrackHits` = bool or int) SHALL use F# DUs or overloaded CE operations so users never need to `box`.

#### Scenario: Index as string
- **WHEN** a user writes `ES.search<Product> "products" { ... }`
- **THEN** the string `"products"` is accepted directly as the index, no boxing

#### Scenario: TrackHits as bool
- **WHEN** a user writes `track_total_hits true` inside a search CE
- **THEN** the `bool` is accepted directly, no boxing

#### Scenario: TrackHits as int
- **WHEN** a user writes `track_total_hits 100` inside a search CE
- **THEN** the `int` is accepted directly via overloaded custom operation or DU

### Requirement: Domain type builders are composable and nestable
Query, aggregation, and mapping builders SHALL be composable — their output can be used inline within operation CEs.

#### Scenario: Nested query inside search CE
- **WHEN** a user writes:
  ```fsharp
  ES.search<Product> "products" {
      query (Query.bool {
          must [ Query.match' "name" "laptop" ]
          filter [ Query.term "in_stock" (FieldValue.Bool true) ]
      })
      size 10
  }
  ```
- **THEN** it compiles and produces the correct nested JSON structure

#### Scenario: Aggregations with sub-aggregations
- **WHEN** a user writes:
  ```fsharp
  ES.search<Product> "products" {
      aggs [
          "by_category", Agg.terms { field "category"; size 10 }
          "avg_price", Agg.avg { field "price" }
      ]
      size 0
  }
  ```
- **THEN** it compiles and produces correct aggregation JSON

### Requirement: F# naming conventions throughout
All generated types, fields, and functions SHALL use F# conventions: PascalCase for types and record fields, camelCase for functions and let bindings. JSON mapping uses `[<JsonPropertyName>]` for snake_case wire format.

#### Scenario: Record field naming
- **WHEN** a schema property is `min_doc_count`
- **THEN** the F# field is `MinDocCount` with `[<JsonPropertyName("min_doc_count")>]`

#### Scenario: Function naming
- **WHEN** an endpoint is `async_search.submit`
- **THEN** the function is `ES.AsyncSearch.submit`

#### Scenario: Reserved word escaping
- **WHEN** a function name collides with an F# keyword (e.g., `match`, `type`)
- **THEN** the function uses a tick suffix: `Query.match'`, `Mapping.type'`

### Requirement: Generated files follow consistent layout
All generated files SHALL use the `.g.fs` suffix, be placed under `src/Fes/Generated/`, and include a header comment indicating they are auto-generated.

#### Scenario: File header
- **WHEN** a generated file is created
- **THEN** it starts with `// Auto-generated from Elasticsearch schema.json — do not edit manually`

#### Scenario: File organisation
- **WHEN** types are in namespace `_types.query_dsl`
- **THEN** they are emitted to `src/Fes/Generated/Types/QueryDsl.g.fs`

#### Scenario: Operations file organisation
- **WHEN** endpoint `search` is generated
- **THEN** it is emitted to `src/Fes/Generated/Operations/Search.g.fs`
