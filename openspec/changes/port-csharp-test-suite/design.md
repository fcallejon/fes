## Context

The C# Elasticsearch client has 196 test files covering every API surface. Each test verifies: (1) exact URL path, (2) exact expected JSON body, (3) typed response deserialisation. FEs has shallow generated tests that don't verify any of these properly.

The C# tests use 5 base class patterns that we need F# equivalents of.

## Goals / Non-Goals

**Goals:**
- Port every test category from the C# client
- Verify exact URL paths (not just HTTP method)
- Verify exact JSON bodies (not just "contains a key")
- Verify typed response deserialisation (not just JsonElement)
- Match the C# test structure 1:1 so we can track coverage

**Non-Goals:**
- Integration tests against live ES (future work)
- Fluent/Initializer duality (F# has one API style)
- Documentation tests (.doc.cs files are C#-specific)
- OpenTelemetry tests (not implemented yet)

## Decisions

### D1: F# equivalents of C# test base classes

| C# Base Class | F# Equivalent |
|---|---|
| `UrlTestsBase` + `UrlTester` | `assertUrl` function: construct request → `ToEndpoint` → assert path and method |
| `ExpectJsonTestBase` | `assertJson` function: construct request → serialise body → compare JSON |
| `SerialisationTestBase<T>` | `assertDeserialise` function: JSON string → `Json.deserialize<T>` → assert fields |
| `QueryDslUsageTestsBase` | Each query test constructs query DU, wraps in search, verifies JSON |
| `AggregationUsageTestBase` | Each agg test constructs agg DU, verifies JSON |
| `ServerErrorTestsBase` | `ElasticsearchException.ofString` → assert error fields |

### D2: Test file structure mirrors C# directories

```
tests/Fes.Tests/
  Aggregations/
    Bucket/
      TermsAggregationTests.fs
      DateHistogramAggregationTests.fs
      ...
    Metric/
      AverageAggregationTests.fs
      CardinalityAggregationTests.fs
      ...
    Pipeline/
      ...
  QueryDsl/
    Compound/
      BoolQueryTests.fs
      FunctionScoreQueryTests.fs
    Geo/
      ...
    Specialized/
      ...
  Search/
    SearchApiTests.fs
    SortTests.fs
    ScrollTests.fs
    CountTests.fs
  Document/
    Single/
      IndexTests.fs
      GetTests.fs
      DeleteTests.fs
      ...
    Multiple/
      BulkTests.fs
      ...
  Serialization/
    SearchSerializationTests.fs
    Aggregations/
      TermsDeserializationTests.fs
      ...
  IndexManagement/
    CreateIndexTests.fs
    ...
  Cluster/
    ClusterHealthTests.fs
    ...
  ClientConcepts/
    Errors/
      ...
```

### D3: Use the C# client's .verified.txt snapshot files as golden truth

The C# client has ~170 `.verified.txt` files in `tests/Tests/_VerifySnapshots/` that contain the expected JSON for every serialisation test. We SHALL:

1. Download all `.verified.txt` files from the C# repo into `tests/Fes.Tests/snapshots/`
2. Each F# test reads the corresponding snapshot file and compares its serialised output against it
3. JSON comparison is order-independent for object keys (using parsed JsonElement comparison)

```fsharp
let actual = Json.serialize searchRequest
let expected = Snapshot.load "BoolQueryUsageTests.VerifyDescriptorJson"
assertJsonEqual expected actual
```

This ensures our JSON output matches exactly what the C# client produces — same source of truth, no reinventing.

### D4: Response types that are JsonElement need typed wrappers

Some response types currently resolve to `JsonElement` because the schema interface was empty. For tests that need typed deserialisation (SearchResponse, ClusterHealthResponse), we may need to:
1. Fix the generator to produce proper response records, OR
2. Use `JsonElement` property access with explicit assertions (less ideal but works now)

## Risks / Trade-offs

**[Risk] Some C# tests test features we haven't implemented** (e.g. inference, source serialiser) → Skip those tests for now, track as TODO.

**[Risk] Response types are mostly JsonElement** → Use JsonElement property access first. Fix generator to produce proper response records as a follow-up.

**[Trade-off] 196 test files is a lot of work** → Prioritise by impact: Query DSL + Aggregations + Search first (most likely to have serialisation bugs), then Document CRUD, then the rest.
