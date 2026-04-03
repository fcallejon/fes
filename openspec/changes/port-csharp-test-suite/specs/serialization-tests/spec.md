## ADDED Requirements

### Requirement: Root serialisation round-trip tests
The 12 root serialisation test files SHALL verify JSON round-trip (serialise then deserialise) for core response and request types.

#### Scenario: SearchResponse round-trips through JSON
- **WHEN** a SearchResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON (order-independent comparison)

#### Scenario: BulkResponse round-trips through JSON
- **WHEN** a BulkResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: MultiGetResponse round-trips through JSON
- **WHEN** a MultiGetResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: ClusterHealthResponse round-trips through JSON
- **WHEN** a ClusterHealthResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: IndexResponse round-trips through JSON
- **WHEN** an IndexResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: GetResponse round-trips through JSON
- **WHEN** a GetResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: DeleteResponse round-trips through JSON
- **WHEN** a DeleteResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: UpdateResponse round-trips through JSON
- **WHEN** an UpdateResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: CreateResponse round-trips through JSON
- **WHEN** a CreateResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: CountResponse round-trips through JSON
- **WHEN** a CountResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: ScrollResponse round-trips through JSON
- **WHEN** a scroll SearchResponse JSON string with `_scroll_id` is deserialised and re-serialised
- **THEN** the output JSON preserves the `_scroll_id` field

#### Scenario: DeleteByQueryResponse round-trips through JSON
- **WHEN** a DeleteByQueryResponse JSON string is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

### Requirement: Aggregation serialisation round-trip tests
The 12 aggregation serialisation test files SHALL verify that aggregation request and response JSON round-trips correctly.

#### Scenario: Terms aggregation request round-trips through JSON
- **WHEN** a terms aggregation JSON is deserialised into the aggregation type and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Terms aggregation response deserialises buckets
- **WHEN** a terms aggregation response JSON with `buckets` array is deserialised
- **THEN** each bucket has typed `key` and `doc_count` fields

#### Scenario: Date histogram aggregation round-trips through JSON
- **WHEN** a date_histogram aggregation JSON is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Nested aggregation round-trips through JSON
- **WHEN** an aggregation JSON with sub-aggregations is deserialised and re-serialised
- **THEN** both parent and child aggregation JSON are preserved

#### Scenario: Metric aggregation response values deserialise correctly
- **WHEN** metric aggregation responses (avg, sum, min, max, cardinality, value_count) are deserialised
- **THEN** each produces typed `value` fields with correct numeric types

#### Scenario: Pipeline aggregation round-trips through JSON
- **WHEN** pipeline aggregation JSON (bucket_sort, cumulative_sum) is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

### Requirement: Bulk serialisation tests
The 2 bulk serialisation test files SHALL verify NDJSON format round-trips.

#### Scenario: Bulk request NDJSON serialises action and document pairs
- **WHEN** a bulk request with index, update, and delete operations is serialised
- **THEN** the output is valid NDJSON with correct line pairs per operation type

#### Scenario: Bulk response JSON deserialises all item types
- **WHEN** a bulk response JSON with index, update, and delete result items is deserialised
- **THEN** each item has the correct operation type, status code, and optional error

### Requirement: Document serialisation tests
The 2 document serialisation test files SHALL verify document body round-trips.

#### Scenario: Document with nested objects round-trips through JSON
- **WHEN** a document JSON with nested objects and arrays is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Document with all field types round-trips through JSON
- **WHEN** a document JSON with string, number, boolean, null, array, and object fields is deserialised and re-serialised
- **THEN** all field types are preserved

### Requirement: Mapping serialisation tests
The 2 mapping serialisation test files SHALL verify index mapping JSON round-trips.

#### Scenario: Mapping with properties round-trips through JSON
- **WHEN** a mapping JSON with `text`, `keyword`, `integer`, `date` properties is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Mapping with multi-fields round-trips through JSON
- **WHEN** a mapping JSON containing `fields` sub-mappings is deserialised and re-serialised
- **THEN** the multi-field structure is preserved

### Requirement: Query serialisation round-trip tests
The 5 query serialisation test files SHALL verify query JSON round-trips.

#### Scenario: Bool query round-trips through JSON
- **WHEN** a bool query JSON with must, should, filter clauses is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Match query round-trips through JSON
- **WHEN** a match query JSON is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Term query round-trips through JSON
- **WHEN** a term query JSON is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Range query round-trips through JSON
- **WHEN** a range query JSON with gt, lt, gte, lte is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Nested query round-trips through JSON
- **WHEN** a nested query JSON with path and inner query is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

### Requirement: Request serialisation tests
The request serialisation test file SHALL verify full request body round-trips.

#### Scenario: Search request with all fields round-trips through JSON
- **WHEN** a search request JSON with query, aggs, sort, from, size, _source, highlight is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

### Requirement: Scripting serialisation tests
The 2 scripting serialisation test files SHALL verify script JSON round-trips.

#### Scenario: Inline script round-trips through JSON
- **WHEN** a script JSON with `source`, `lang`, `params` is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

#### Scenario: Stored script reference round-trips through JSON
- **WHEN** a script JSON with `id` and `params` is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON

### Requirement: Types serialisation tests
The types serialisation test file SHALL verify common type JSON round-trips.

#### Scenario: Duration string round-trips through JSON
- **WHEN** a Duration value `"5m"` is serialised and deserialised
- **THEN** the value is preserved as `"5m"`

### Requirement: Xpack serialisation tests
The Xpack serialisation test file SHALL verify Xpack-specific type round-trips.

#### Scenario: Xpack response fields round-trip through JSON
- **WHEN** an Xpack-specific response JSON is deserialised and re-serialised
- **THEN** the output JSON is equivalent to the input JSON
