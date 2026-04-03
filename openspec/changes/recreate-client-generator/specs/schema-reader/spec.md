## ADDED Requirements

### Requirement: Metamodel F# types mirror schema.json structure
The generator SHALL define F# types that faithfully represent the `schema.json` metamodel: `Model` (top-level with `endpoints` and `types` arrays), `Endpoint`, `TypeDefinition` (DU of Interface, Request, Response, Enum, TypeAlias), `ValueOf` (DU of InstanceOf, ArrayOf, UnionOf, DictionaryOf, UserDefinedValue, LiteralValue), `Property`, `TypeName` (namespace + name), and variant descriptors (Container, InternalTag, ExternalTag, Untagged).

#### Scenario: All type definition kinds are represented
- **WHEN** schema.json contains types with `kind` values `interface`, `request`, `response`, `enum`, `type_alias`
- **THEN** each deserialises into the corresponding F# DU case of `TypeDefinition`

#### Scenario: All ValueOf kinds are represented
- **WHEN** a property type has `kind` of `instance_of`, `array_of`, `union_of`, `dictionary_of`, `user_defined_value`, or `literal_value`
- **THEN** each deserialises into the corresponding F# DU case of `ValueOf`

#### Scenario: Variant descriptors are preserved
- **WHEN** a type has `variants` with `kind` of `container`, `internal_tag`, `external_tag`, or `untagged`
- **THEN** the variant descriptor deserialises with all metadata (tag field name, default tag, nonExhaustive flag)

### Requirement: Deserialise schema.json into Metamodel types
The generator SHALL read a `schema.json` file from a configurable path and deserialise it into the F# metamodel types using `System.Text.Json`.

#### Scenario: Successful parse of full schema
- **WHEN** the generator is given a valid `schema.json` from elasticsearch-specification
- **THEN** it produces a `Model` with all endpoints and types populated
- **THEN** no types or endpoints are silently dropped

#### Scenario: Invalid or missing file
- **WHEN** the schema file path does not exist or contains invalid JSON
- **THEN** the generator SHALL report a clear error message and exit with a non-zero code

### Requirement: Type index for reference resolution
The generator SHALL build an index from `TypeName` (namespace + name) to `TypeDefinition`, enabling O(1) lookup when resolving `instance_of` references.

#### Scenario: Resolve a type reference
- **WHEN** an endpoint's request field references `{ namespace: "_types.query_dsl", name: "QueryContainer" }`
- **THEN** the type index returns the corresponding `TypeDefinition` for `QueryContainer`

#### Scenario: Unresolvable reference
- **WHEN** a type reference points to a namespace+name not present in the schema
- **THEN** the generator SHALL emit a warning and use `JsonElement` as a fallback type

### Requirement: Vendor schema.json with refresh mechanism
The project SHALL include a vendored `schema.json` at `schema/elasticsearch-schema.json`. A build target or script SHALL download the latest schema from the elasticsearch-specification repository's published output.

#### Scenario: Build with vendored schema
- **WHEN** the generator runs without `--schema` flag
- **THEN** it uses `schema/elasticsearch-schema.json`

#### Scenario: Refresh schema from upstream
- **WHEN** a user runs the refresh script/target
- **THEN** the latest `schema.json` is downloaded from the elasticsearch-specification repo and written to `schema/elasticsearch-schema.json`
