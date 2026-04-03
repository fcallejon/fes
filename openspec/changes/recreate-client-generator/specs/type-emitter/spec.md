## ADDED Requirements

### Requirement: Container variants emit F# discriminated unions
Types with `variants.kind = "container"` SHALL be emitted as F# discriminated unions. Each non-`containerProperty` field becomes a DU case. Fields marked `containerProperty: true` SHALL be emitted as a separate metadata record type.

#### Scenario: QueryContainer becomes a Query DU
- **WHEN** the schema contains `QueryContainer` with `variants.kind = "container"` and properties `bool`, `term`, `match`, etc.
- **THEN** the emitter generates `type Query = | Bool of BoolQuery | Term of field: Field * TermQuery | Match of field: Field * MatchQuery | ...`
- **THEN** `containerProperty` fields are not included as DU cases

#### Scenario: AggregationContainer with containerProperty fields
- **WHEN** `AggregationContainer` has `containerProperty` fields `aggregations` and `meta`
- **THEN** the emitter generates a separate `AggregationMeta` record with those fields
- **THEN** the `Aggregation` DU only contains non-containerProperty cases

#### Scenario: NonExhaustive container variant
- **WHEN** a container variant has `nonExhaustive: true`
- **THEN** the DU includes a fallback case `| Unknown of string * JsonElement`

### Requirement: SingleKeyDictionary properties emit field-keyed DU cases
Properties with `dictionary_of` where `singleKey: true` SHALL emit DU cases with a `field: Field` component: `CaseName of field: Field * CaseValueType`.

#### Scenario: Term query with SingleKeyDictionary
- **WHEN** the `term` property on `QueryContainer` has type `dictionary_of { singleKey: true, key: Field, value: TermQuery }`
- **THEN** the emitter generates `| Term of field: Field * TermQuery`

### Requirement: Internal tag variants emit F# discriminated unions
Types with `variants.kind = "internal_tag"` SHALL be emitted as F# DUs where the tag field value determines the case.

#### Scenario: Property type with internal tag on "type" field
- **WHEN** `Property` (mapping) has `variants: { kind: "internal_tag", tag: "type" }`
- **THEN** the emitter generates a DU where each variant's `type` field value maps to a case name

### Requirement: Enums emit F# discriminated unions
Schema types with `kind = "enum"` SHALL be emitted as F# DUs with one case per member. Open enums (`isOpen: true`) SHALL include a `| Custom of string` case.

#### Scenario: Closed enum
- **WHEN** an enum has members `["query_then_fetch", "dfs_query_then_fetch"]` and `isOpen` is false/absent
- **THEN** the emitter generates `type SearchType = | QueryThenFetch | DfsQueryThenFetch`

#### Scenario: Open enum
- **WHEN** an enum has `isOpen: true`
- **THEN** the DU includes `| Custom of string` as a final case

### Requirement: Interface types emit F# records
Schema types with `kind = "interface"` (without variants) SHALL be emitted as F# record types. Optional properties use `option`. Required properties are non-optional.

#### Scenario: BoolQuery as a record
- **WHEN** `BoolQuery` is an interface with optional properties `must`, `should`, `must_not`, `filter`
- **THEN** the emitter generates a record with `Must: Query list option`, `Should: Query list option`, etc.

#### Scenario: JsonPropertyName attributes for snake_case mapping
- **WHEN** a property has a snake_case name like `min_doc_count`
- **THEN** the record field gets `[<JsonPropertyName("min_doc_count")>]` and a PascalCase F# name `MinDocCount`

### Requirement: Type aliases emit F# type abbreviations or DUs
Schema `type_alias` types SHALL emit `type X = Y` for simple aliases, or a DU when the alias wraps a `union_of`.

#### Scenario: Simple alias
- **WHEN** a type alias maps `Duration` to `string`
- **THEN** the emitter generates `type Duration = string`

#### Scenario: Union alias
- **WHEN** a type alias wraps `union_of [string, int]`
- **THEN** the emitter generates a DU: `type TrackHits = | TrackHitsBoolean of bool | TrackHitsInteger of int`

### Requirement: Generics are preserved as F# type parameters
Types with `generics` arrays SHALL emit F# generic type parameters.

#### Scenario: SearchResponse with TDocument
- **WHEN** `Response` in `_global.search` has `generics: [TDocument]`
- **THEN** the emitter generates `type SearchResponse<'TDocument> = { ... }`

### Requirement: Integer types map to int, not float
Schema properties with `instance_of` referencing `integer` or `long` from `_builtins` SHALL emit `int` or `int64` in F#, not `float`.

#### Scenario: Size field is integer
- **WHEN** a property `size` has type `instance_of { name: "integer" }`
- **THEN** the F# field type is `int`, not `float`

### Requirement: Dependency-ordered output with mutual recursion support
The emitter SHALL topologically sort types by dependency and group mutually-recursive types using F# `and` keyword.

#### Scenario: Circular reference between Query and BoolQuery
- **WHEN** `Query` references `BoolQuery` and `BoolQuery` references `Query`
- **THEN** both types are emitted in the same `type ... and ...` group

### Requirement: Namespaced modules replace flat prefixed names
Types SHALL be emitted into F# modules based on their schema namespace. `_types.query_dsl` → `QueryDsl`, `_types.aggregations` → `Aggregations`, `_types.mapping` → `Mapping`.

#### Scenario: QueryContainer in QueryDsl module
- **WHEN** `QueryContainer` has namespace `_types.query_dsl`
- **THEN** it is emitted inside `module QueryDsl` as `type Query = ...`
- **THEN** users reference it as `QueryDsl.Query` or open the module
