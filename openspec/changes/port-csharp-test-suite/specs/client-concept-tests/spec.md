## ADDED Requirements

### Requirement: Error parsing tests
The 6 error test files SHALL verify that Elasticsearch error responses are correctly parsed into typed error objects.

#### Scenario: Root cause error is parsed from response
- **WHEN** an Elasticsearch error response JSON with `error.root_cause` is parsed
- **THEN** the error object contains `type`, `reason`, and `root_cause` list

#### Scenario: Nested caused_by error is parsed
- **WHEN** an error response contains `error.caused_by` with nested `caused_by`
- **THEN** the error chain is fully parsed with each `type` and `reason`

#### Scenario: Error with additional metadata is parsed
- **WHEN** an error response contains extra fields like `resource.type`, `resource.id`, `index`
- **THEN** the error object preserves these additional metadata fields

#### Scenario: 404 response produces typed NotFound error
- **WHEN** a 404 response is received for a Get request
- **THEN** the error has `status = 404` and `found = false`

#### Scenario: Bulk item error is parsed per item
- **WHEN** a bulk response contains items with errors
- **THEN** each errored item has a typed error with `type` and `reason`

#### Scenario: Error response with no body produces generic error
- **WHEN** an error response has no JSON body (e.g. connection refused)
- **THEN** a generic error is produced with the HTTP status code

### Requirement: Type inference tests
The 7 inference test files and 17 equality test files SHALL verify that types like `IndexName`, `Id`, `Field`, `Routing` are correctly inferred from values and support equality.

#### Scenario: IndexName inferred from string
- **WHEN** `"project"` is used where an `IndexName` is expected
- **THEN** it is implicitly converted to `IndexName "project"`

#### Scenario: Id inferred from string
- **WHEN** `"1"` is used where an `Id` is expected
- **THEN** it is implicitly converted to `Id "1"`

#### Scenario: Id inferred from integer
- **WHEN** `1` is used where an `Id` is expected
- **THEN** it is implicitly converted to `Id "1"`

#### Scenario: Field inferred from string
- **WHEN** `"title"` is used where a `Field` is expected
- **THEN** it is implicitly converted to `Field "title"`

#### Scenario: Routing inferred from string
- **WHEN** `"routing-value"` is used where a `Routing` is expected
- **THEN** it is implicitly converted to `Routing "routing-value"`

#### Scenario: Fields inferred from string array
- **WHEN** `["title"; "body"]` is used where a `Fields` is expected
- **THEN** it is implicitly converted to `Fields [Field "title"; Field "body"]`

#### Scenario: Indices inferred from string
- **WHEN** `"project"` is used where an `Indices` is expected
- **THEN** it is implicitly converted to a single index target

#### Scenario: IndexName equality
- **WHEN** `IndexName "project"` is compared with `IndexName "project"`
- **THEN** they are equal

#### Scenario: IndexName inequality
- **WHEN** `IndexName "project"` is compared with `IndexName "other"`
- **THEN** they are not equal

#### Scenario: Id equality
- **WHEN** `Id "1"` is compared with `Id "1"`
- **THEN** they are equal

#### Scenario: Field equality
- **WHEN** `Field "title"` is compared with `Field "title"`
- **THEN** they are equal

#### Scenario: Routing equality
- **WHEN** `Routing "a"` is compared with `Routing "a"`
- **THEN** they are equal

#### Scenario: Type inference values serialise to plain strings in URLs
- **WHEN** an `IndexName "project"` is used in a URL path
- **THEN** it serialises as `"project"` (not wrapped in an object)

#### Scenario: Type inference values serialise to plain strings in JSON
- **WHEN** a `Field "title"` is serialised to JSON
- **THEN** it produces `"title"` (a plain JSON string)

### Requirement: Mapping convention tests
The 2 mapping test files SHALL verify that field name mapping conventions work correctly.

#### Scenario: CamelCase field names are mapped to snake_case
- **WHEN** a property named `projectName` is used as a Field
- **THEN** it serialises to `"project_name"` in JSON

#### Scenario: Custom field name mapping overrides convention
- **WHEN** a custom field name mapping is configured for a type
- **THEN** the mapped name is used instead of the default convention

### Requirement: Serialisation concept tests
The serialisation concept test file SHALL verify serialiser configuration and behaviour.

#### Scenario: Default serialiser uses camelCase for user documents
- **WHEN** a user document with PascalCase property names is serialised
- **THEN** the JSON property names follow the configured naming convention

#### Scenario: Elasticsearch types always use snake_case
- **WHEN** Elasticsearch request/response types are serialised
- **THEN** the JSON property names are always snake_case regardless of user document naming convention
