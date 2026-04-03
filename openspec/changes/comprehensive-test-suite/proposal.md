## Why

The library currently has 31 hand-written tests covering basic functionality. The official C# Elasticsearch client has thousands of tests organised into URL verification, serialisation round-trips, and full pipeline tests using an in-memory transport. We need similar coverage to ensure correctness across 583 endpoints, 3800 types, 448 JSON converters, and the full request→transport→response pipeline. Most of this can be **generated** by extending the existing `Fes.Generator` — the schema already contains everything needed.

## What Changes

- New `TestTransport.fs` module: helper to create in-memory transports using `InMemoryRequestInvoker` from `Elastic.Transport`
- New hand-written pipeline tests: full `ES.sendAsync` round-trips with fake responses
- **Generated** endpoint URL tests (~1200 test cases): verify HTTP method, path, and body presence for every non-generic endpoint
- **Generated** enum round-trip tests (~379 enums): serialize every case, verify string, deserialize back
- **Generated** container variant tests (~56 DUs): serialize, verify discriminator key, deserialize
- Simple snapshot helper for hand-written complex JSON verification
- New `TestEmitter.fs` in `Fes.Generator` to emit all generated test files
- Update `Fes.Tests.fsproj` to include generated and hand-written test files

## Capabilities

### New Capabilities
- `test-infrastructure`: In-memory transport helper and snapshot verification utility
- `generated-tests`: Extend `Fes.Generator` to emit endpoint, enum, and DU round-trip tests
- `pipeline-tests`: Hand-written full-pipeline tests using in-memory transport

### Modified Capabilities

## Impact

- **Fes.Tests/**: New generated test files (`EndpointTests.g.fs`, `EnumRoundTripTests.g.fs`, `VariantRoundTripTests.g.fs`) plus hand-written infrastructure and pipeline tests
- **Fes.Generator/**: New `Emitters/TestEmitter.fs` for generating test files
- **Fes.Generator/Program.fs**: Add test generation to the CLI (`--test-output` flag)
- **Test count**: From 31 to ~2000+ (mostly generated)
