## ADDED Requirements

### Requirement: Full pipeline tests using in-memory transport
Hand-written tests SHALL verify the complete `ES.sendAsync` flow: request construction → ToEndpoint → transport call → response deserialisation → TaskResult.

#### Scenario: Search request pipeline
- **WHEN** a search request is sent through an in-memory transport returning a valid search response JSON
- **THEN** the result is `Ok` with a deserialised response containing hits metadata

#### Scenario: Error response pipeline
- **WHEN** a request is sent through an in-memory transport returning a 404 response
- **THEN** the result is `Error` with appropriate exception details

#### Scenario: Request body is correctly serialised
- **WHEN** a search request with a query is sent through an in-memory transport
- **THEN** `ApiCallDetails.RequestBodyInBytes` contains the expected JSON with the query

### Requirement: Query DSL serialisation pipeline tests
Hand-written tests SHALL verify that query DSL constructions serialise to correct Elasticsearch JSON when sent through the pipeline.

#### Scenario: Bool query with must and filter
- **WHEN** a search with `Query.bool { Must = ...; Filter = ... }` is serialised
- **THEN** the request body JSON contains `"query":{"bool":{"must":[...],"filter":[...]}}`

#### Scenario: Terms aggregation
- **WHEN** a search with `Aggregation.terms { field "category"; size 10 }` is serialised
- **THEN** the request body JSON contains `"aggregations":{"name":{"terms":{"field":"category","size":10}}}`
