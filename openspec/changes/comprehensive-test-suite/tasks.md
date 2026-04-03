## 1. Test Infrastructure

- [x] 1.1 Create `TestTransport.fs` in test project: `TestTransport.withResponse` wrapping `InMemoryRequestInvoker` with `DisableDirectStreaming`, `FesSerializer`, and `SingleNodePool`
- [x] 1.2 Create `Snapshot.fs` in test project: simple golden-file comparison against `snapshots/` directory
- [x] 1.3 Add both to `Fes.Tests.fsproj` before other test files

## 2. Generator Test Emitter

- [ ] 2.1 Create `Emitters/TestEmitter.fs` in `Fes.Generator`: module for emitting test files
- [ ] 2.2 Implement `sampleValue` function: maps schema types to F# expressions for test data (`Id` → `"test-id"`, `Indices` → `Types.Indices.IndexName "test-index"`, etc.)
- [ ] 2.3 Implement endpoint test emission: for each non-generic endpoint, emit `[<Fact>]` tests for method, path, and body presence
- [ ] 2.4 Implement enum round-trip test emission: for each enum, emit tests serialising/deserialising every case
- [ ] 2.5 Implement container variant discriminator test emission: for each container variant DU, emit tests checking the JSON discriminator key per case
- [ ] 2.6 Add `--test-output` CLI flag to `Program.fs`, call `TestEmitter` functions
- [ ] 2.7 Update `Fes.Generator.fsproj` with `TestEmitter.fs`

## 3. Generate and Compile Tests

- [ ] 3.1 Run generator with `--test-output tests/Fes.Tests/Generated`
- [ ] 3.2 Update `Fes.Tests.fsproj` to include generated test files
- [ ] 3.3 Verify all generated tests compile

## 4. Hand-Written Pipeline Tests

- [ ] 4.1 Write pipeline test: search request → in-memory transport → deserialise response → verify result
- [ ] 4.2 Write pipeline test: error response (404) → verify Error result with exception
- [ ] 4.3 Write pipeline test: verify `RequestBodyInBytes` contains expected JSON for a search with query
- [ ] 4.4 Write pipeline test: verify query DSL serialisation (bool query with must/filter)
- [ ] 4.5 Write pipeline test: verify aggregation serialisation (terms agg)

## 5. Verify and Clean Up

- [ ] 5.1 Run all tests (hand-written + generated), verify they pass
- [ ] 5.2 Report total test count
- [ ] 5.3 Commit
