## Context

FEs has a code generator (`Fes.Generator`) that reads `schema.json` and emits types, operations, builders, converters, and an ES module. The same schema data can drive test generation — URL templates, HTTP methods, enum members, and variant structures are all available. The library uses `Elastic.Transport` which provides `InMemoryRequestInvoker` for testing without a real Elasticsearch instance.

## Goals / Non-Goals

**Goals:**
- Full endpoint URL coverage via generated tests
- JSON round-trip coverage for all converter types (enums, container variants, internal-tag DUs)
- In-memory pipeline tests proving the full `ES.sendAsync` flow works
- Minimal hand-written test maintenance — generate what we can

**Non-Goals:**
- Integration tests against a real Elasticsearch cluster (future work)
- Verify/snapshot library adoption (too much friction for F# + xUnit v2)
- Testing every field of every request type (path + method + body presence is sufficient for generated tests)

## Decisions

### D1: In-Memory Transport via InMemoryRequestInvoker

**Choice**: Create a `TestTransport` module wrapping `InMemoryRequestInvoker` with `DisableDirectStreaming = true` to capture request/response bytes.

```fsharp
TestTransport.withResponse """{"acknowledged":true}""" 200
```

Returns an `ITransport` that records `ApiCallDetails` for assertions. This is the same pattern the C# client uses via `FixedResponseClient`.

**Why not mock ITransport directly**: `InMemoryRequestInvoker` exercises the real transport pipeline (serialisation, node selection, endpoint building) — we test more of the stack.

### D2: Generator emits test files into the test project

**Choice**: Extend `Fes.Generator` with a `TestEmitter.fs` that emits `.g.fs` test files. The generator CLI gets a `--test-output` flag pointing to the test project directory.

**Why generate**: 583 endpoints × 2-3 assertions each = ~1500 test cases. 379 enums × 3-10 cases each = ~2000 assertions. Hand-writing these is impractical and they'd drift from the schema.

### D3: Endpoint tests verify method + path + body presence

**Choice**: Each generated endpoint test:
1. Constructs a request via the CE builder with sample values for required path params
2. Calls `ToEndpoint`
3. Asserts `endpoint.Method` matches the schema's HTTP method
4. Asserts `endpoint.PathAndQuery` contains the expected path segments
5. Asserts `postData.IsSome` or `postData.IsNone` based on body kind

**Sample values**: string aliases get `"test-value"`, DU types (Indices, Ids, NodeIds) get their first case wrapping `"test-value"`, integers get `1`.

### D4: Enum tests verify every member's string representation

**Choice**: For each enum, generate a test that serialises every case to JSON and verifies the string matches the schema member name. Then deserialises back and checks equality.

**Why every case**: Enum converters map F# case names to ES snake_case strings. A typo in the converter breaks the API silently. Testing every case catches this.

### D5: Container variant tests verify discriminator key

**Choice**: For each container variant DU (QueryContainer, AggregationContainer, etc.), generate a test per case that serialises and checks the JSON contains the expected property name as the discriminator key.

**Why**: Container variants serialise as `{"case_name": {...}}`. The converter must emit the correct property name for each case. Testing each case verifies the mapping.

### D6: Simple snapshot helper (no Verify dependency)

**Choice**: A ~30-line `Snapshot` module for hand-written tests that compare JSON output against `.json` files in a `snapshots/` directory. No external dependency.

**Why not Verify**: `Verify.Xunit` for xUnit v2 is deprecated. It forces class-based tests. It adds a Newtonsoft transitive dependency. Our generator already knows the expected output, so the "review and accept" workflow adds no value.

## Risks / Trade-offs

**[Risk] Generated tests are noisy when they fail** → Mitigation: Group by operation/type. Use descriptive test names (`search_endpoint_uses_POST`). The test runner shows which specific assertion failed.

**[Risk] Sample values for DU path params need type-aware construction** → Mitigation: The generator already has the type resolver and nameMap. Add a `sampleValue` function that maps types to F# expressions.

**[Trade-off] Generated tests don't test complex query/body construction** → That's what the hand-written pipeline tests cover. Generated tests verify the transport layer (URL + method + body presence); pipeline tests verify end-to-end correctness.
