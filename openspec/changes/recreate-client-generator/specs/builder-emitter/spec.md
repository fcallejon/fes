## ADDED Requirements

### Requirement: Smart constructors from shortcutProperty
Types with a `shortcutProperty` annotation SHALL generate a module function that constructs the type with the shortcut value, defaulting all other fields.

#### Scenario: TermQuery shortcut on "value"
- **WHEN** `TermQuery` has `shortcutProperty: "value"`
- **THEN** the emitter generates `Query.term (field: Field) (value: FieldValue) : Query` that returns `Query.Term (field, { Value = value; CaseInsensitive = None; ... })`

#### Scenario: FieldAndFormat shortcut on "field"
- **WHEN** `FieldAndFormat` has `shortcutProperty: "field"`
- **THEN** the emitter generates `FieldAndFormat.ofField (f: Field) : FieldAndFormat`

### Requirement: CE builders for complex domain types
Container variant types and interfaces with 3+ optional properties SHALL generate computation expression builders with `[<CustomOperation>]` per settable field.

#### Scenario: BoolQuery CE builder
- **WHEN** `BoolQuery` has optional properties `must`, `should`, `must_not`, `filter`, `minimum_should_match`
- **THEN** the emitter generates a `boolQuery { }` CE with custom operations for each
- **THEN** `Query.bool { must [...]; filter [...] }` produces a `Query.Bool` value

#### Scenario: TermsAggregation CE builder
- **WHEN** `TermsAggregation` has properties `field`, `size`, `min_doc_count`, `order`, etc.
- **THEN** the emitter generates `Agg.terms { field "category"; size 10 }` as a CE

### Requirement: Convenience module functions for variant construction
Each case of a container variant DU SHALL have a corresponding module function for direct construction.

#### Scenario: Query module functions
- **WHEN** `Query` DU has cases `Bool`, `Term`, `Match`, `MatchAll`, etc.
- **THEN** `Query.bool`, `Query.term`, `Query.match'`, `Query.matchAll` module functions exist
- **THEN** `Query.matchAll ()` creates `Query.MatchAll { Boost = None }`

#### Scenario: Aggregation module functions
- **WHEN** `Aggregation` DU has cases `Terms`, `Avg`, `DateHistogram`, etc.
- **THEN** `Agg.terms`, `Agg.avg`, `Agg.dateHistogram` module functions exist
- **THEN** each accepts either a CE result or a direct config record

### Requirement: Mapping builder helpers
Mapping `Property` variants (which use `internal_tag` on `"type"`) SHALL generate `Mapping.text ()`, `Mapping.keyword ()`, `Mapping.float' ()`, `Mapping.boolean ()`, etc.

#### Scenario: Simple mapping property creation
- **WHEN** a user writes `Mapping.keyword ()`
- **THEN** it returns a `Property.Keyword` with default settings

#### Scenario: Mapping property with options via CE
- **WHEN** a user writes `Mapping.text { analyzer "english"; boost 1.5 }`
- **THEN** it returns a `Property.Text` with `Analyzer = Some "english"` and `Boost = Some 1.5`

### Requirement: Mapping.properties helper for index creation
A convenience function SHALL exist to build a properties map from a list of field name + property pairs.

#### Scenario: Properties map construction
- **WHEN** a user writes `Mapping.properties [ "name", Mapping.text (); "price", Mapping.float' () ]`
- **THEN** it returns a `Map<string, Property>` suitable for index creation

### Requirement: JSON converters for DU serialisation
Each generated DU (container variant, internal-tag variant, enum) SHALL have a companion `JsonConverter<T>` that handles the Elasticsearch JSON encoding.

#### Scenario: Container variant serialisation
- **WHEN** `Query.Term ("status", termQuery)` is serialised
- **THEN** JSON output is `{ "term": { "status": { "value": "active" } } }`

#### Scenario: Container variant deserialisation
- **WHEN** JSON `{ "bool": { "must": [...] } }` is deserialised as `Query`
- **THEN** it produces `Query.Bool { Must = Some [...]; ... }`

#### Scenario: Internal tag variant serialisation
- **WHEN** `Property.Keyword { ... }` is serialised
- **THEN** JSON output includes `{ "type": "keyword", ... }`

#### Scenario: Enum serialisation
- **WHEN** `Refresh.WaitFor` is serialised
- **THEN** JSON output is `"wait_for"` (snake_case string)

#### Scenario: Open enum deserialisation with unknown value
- **WHEN** JSON contains an enum value not in the known members
- **THEN** it deserialises as the `Custom of string` case
