## ADDED Requirements

### Requirement: Verb-first ES module functions from endpoints
Each endpoint SHALL generate a function in the `ES` module (or a sub-module for namespaced endpoints). The function name is derived from the endpoint name; path parameters become function arguments.

#### Scenario: Search endpoint generates ES.search
- **WHEN** endpoint `search` has URLs `["/_search", "/{index}/_search"]` with methods `["GET","POST"]`
- **THEN** the emitter generates `ES.search<'TDocument> (index: string)` that returns a request value
- **THEN** overloads or optional params handle the index-less variant

#### Scenario: Namespaced endpoint generates sub-module function
- **WHEN** endpoint `indices.create` has namespace prefix `indices`
- **THEN** the emitter generates `ES.Indices.create (index: string)`

#### Scenario: All 589 endpoints are generated
- **WHEN** the generator runs on a full schema.json
- **THEN** every endpoint produces at least one `ES.*` function

### Requirement: CE builders for PropertiesBody requests
Endpoints whose request has `body.kind = "properties"` SHALL generate a computation expression builder. Each body property and query parameter becomes a `[<CustomOperation>]`.

#### Scenario: Search request CE with body and query operations
- **WHEN** the search request has query params (`routing`, `preference`, ...) and body properties (`query`, `aggregations`, `size`, ...)
- **THEN** the CE builder exposes all as custom operations with correct types
- **THEN** `size` in the body is `int` (not `float`) and does not conflict with query param `size`

#### Scenario: CE yields a request record
- **WHEN** a user writes `ES.search<Product> "products" { query q; size 10 }`
- **THEN** the CE produces a typed request value that can be piped to `ES.send`

### Requirement: Plain functions for NoBody requests
Endpoints whose request has `body.kind = "no_body"` SHALL generate plain functions (no CE needed), with optional CE for query parameters if the endpoint has them.

#### Scenario: Get endpoint as plain function
- **WHEN** `get` request has no body, path params `index` and `id`
- **THEN** `ES.get<'TDocument> "index" "id"` is a plain function returning a request
- **THEN** an optional CE variant exists for query params: `ES.get<'TDocument> "index" "id" { routing "shard_1" }`

#### Scenario: Delete endpoint
- **WHEN** `delete` has no body, path params `index` and `id`, query params `refresh`, `routing`
- **THEN** `ES.delete "index" "id"` works as a plain function
- **THEN** `ES.delete "index" "id" { refresh WaitFor }` works with CE for query params

### Requirement: ValueBody requests take the document as a parameter
Endpoints whose request has `body.kind = "value"` (e.g., Index) SHALL accept the body value as a CE operation or function parameter.

#### Scenario: Index endpoint with document body
- **WHEN** `index` request has `body.kind = "value"` with `codegenName = "document"` and type `TDocument`
- **THEN** the CE exposes `document myValue` as a custom operation
- **THEN** the document is serialised as the request body JSON

### Requirement: Pipe-friendly alternative API
Each endpoint with a CE builder SHALL also expose module functions for pipe composition: `Search.withQuery`, `Search.withSize`, `Index.withRefresh`, etc.

#### Scenario: Pipe-style search
- **WHEN** a user writes `ES.search<Product> "products" |> Search.withQuery q |> Search.withSize 10 |> ES.send client`
- **THEN** it produces the same request as the CE variant

### Requirement: ES.send executes requests through HttpClient
The `ES.send` function SHALL take a client and a request value, build the HTTP request (path + query string + method + body), execute it, and deserialise the response.

#### Scenario: Successful search round-trip
- **WHEN** `ES.send client searchRequest` is called
- **THEN** it builds the HTTP request from the request record's path, query params, method, and body
- **THEN** it deserialises the JSON response into the endpoint's response type

#### Scenario: Error response
- **WHEN** Elasticsearch returns an error status code
- **THEN** `ES.send` returns `Result.Error` with the parsed error details

### Requirement: ToRequest generates correct HTTP details from endpoint metadata
Each generated request type SHALL include a `ToRequest` method that builds path (with interpolated path params), query string (from optional query params), HTTP method, and serialised body.

#### Scenario: Path parameter interpolation
- **WHEN** the endpoint URL is `/{index}/_search` and `index = "products"`
- **THEN** the built path is `/products/_search`

#### Scenario: Optional query params omitted when None
- **WHEN** a query parameter is `None`
- **THEN** it is not included in the query string

#### Scenario: Body serialisation respects JsonPropertyName
- **WHEN** a body property has `[<JsonPropertyName("track_total_hits")>]`
- **THEN** the serialised JSON uses `track_total_hits` as the key
