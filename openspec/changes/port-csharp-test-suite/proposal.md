## Why

The official C# Elasticsearch client has 196 test files covering every API endpoint, query type, aggregation type, document operation, serialisation round-trip, and response deserialisation. FEs currently has shallow generated tests and ~50 hand-written tests that don't verify actual JSON output or typed responses. We need to port every test from the C# client to ensure FEs produces correct Elasticsearch-compatible JSON and handles responses properly.

## What Changes

Port all test categories from https://github.com/elastic/elasticsearch-net/tree/main/tests/Tests:

- **Aggregations** (31 files): Every bucket, metric, and pipeline aggregation serialisation test
- **Query DSL** (15 files): Bool, geo, compound, specialized query tests with expected JSON
- **Search** (11 files): Search API, sort, scroll, count tests
- **Document CRUD** (30 files): Bulk, delete_by_query, MGet, create, delete, get, index, update, exists
- **Serialization** (28 files): JSON round-trips for queries, aggs, mappings, bulk, scripts, responses
- **Index Management** (9 files): Create, settings, aliases, mappings, templates
- **Cluster** (7 files): Health, allocation explain, pending tasks, state
- **Client Concepts** (29 files): Inference, error handling, type equality
- **Common/Types** (11 files): DateTime, fields, indices, metrics, URL params

Each C# test file SHALL be ported to an equivalent F# test file that verifies the same behaviour: exact URL paths, expected JSON bodies, and typed response deserialisation.

## Capabilities

### New Capabilities
- `aggregation-tests`: Port all 31 aggregation test files
- `query-dsl-tests`: Port all 15 query DSL test files
- `search-tests`: Port all 11 search test files
- `document-tests`: Port all 30 document CRUD test files
- `serialization-tests`: Port all 28 serialization test files
- `index-management-tests`: Port all 9 index management test files
- `cluster-tests`: Port all 7 cluster test files
- `client-concept-tests`: Port all 29 client concept test files
- `common-type-tests`: Port all 11 common/type test files

### Modified Capabilities

## Impact

- **tests/Fes.Tests/**: ~196 new F# test files mirroring the C# structure
- **Test count**: From ~2,785 to significantly more with deep verification
- **May expose bugs**: Porting tests will likely reveal serialisation issues in the generated code that need fixing
- **May require new response types**: Some response deserialisation tests will need typed response records instead of `JsonElement`
