## ADDED Requirements

### Requirement: Generated endpoint URL tests for every non-generic endpoint
The generator SHALL emit a test file verifying HTTP method, path construction, and body presence for each endpoint that has a `ToEndpoint` method.

#### Scenario: Search endpoint test generation
- **WHEN** the generator processes the `search` endpoint
- **THEN** it emits tests asserting `POST` method, path containing `/test-value/_search`, and body present

#### Scenario: Get endpoint test generation
- **WHEN** the generator processes the `get` endpoint
- **THEN** it emits tests asserting `GET` method, path containing `/test-value/_doc/test-value`, and no body

#### Scenario: All non-generic endpoints covered
- **WHEN** the generator runs
- **THEN** every endpoint with a `ToEndpoint` method has at least one generated test

### Requirement: Generated enum round-trip tests for every enum type
The generator SHALL emit tests that serialise each enum case to JSON, verify the string matches the schema member name, and deserialise back to verify equality.

#### Scenario: Refresh enum round-trip
- **WHEN** `Refresh.True` is serialised
- **THEN** the JSON is `"true"`
- **THEN** deserialising `"true"` returns `Refresh.True`

#### Scenario: All enum cases covered
- **WHEN** the generator runs
- **THEN** every case of every enum has a serialise + deserialise assertion

### Requirement: Generated container variant discriminator tests
The generator SHALL emit tests that serialise each case of each container variant DU and verify the JSON contains the correct discriminator property name.

#### Scenario: QueryContainer.Bool discriminator
- **WHEN** `QueryContainer.Bool { ... }` is serialised
- **THEN** the JSON contains `"bool"` as a property key

#### Scenario: AggregationContainer.Terms discriminator
- **WHEN** `AggregationContainer.Terms { ... }` is serialised
- **THEN** the JSON contains `"terms"` as a property key

### Requirement: Generator CLI supports test output
The generator SHALL accept a `--test-output <path>` flag to specify where generated test files are written.

#### Scenario: Generate tests alongside code
- **WHEN** `dotnet run --project Fes.Generator -- --schema ... --output ... --test-output tests/Fes.Tests`
- **THEN** generated test files are written to the test output directory
