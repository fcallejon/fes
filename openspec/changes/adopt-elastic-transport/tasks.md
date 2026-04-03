## 1. Dependencies & Project Setup

- [x] 1.1 Add `Elastic.Transport 0.15.1` to `Directory.Packages.props` and `Fes.fsproj`
- [x] 1.2 Verify the package restores and builds with existing code

## 2. FesSerializer

- [x] 2.1 Create `FesSerializer` in `Json.fs`: `IJsonSerializerOptionsProvider` returning `JsonSettings.options`, `SystemTextJsonSerializer` subclass
- [x] 2.2 Verify `FesSerializer` can serialise/deserialise a sample type via the transport's `Serializer` API

## 3. Transport Configuration Wrappers

- [x] 3.1 Create `Transport.fs` with `ES.connect` (URI → ITransport with SingleNodePool + FesSerializer)
- [x] 3.2 Add `ES.connectWithApiKey` (URI + API key → ITransport with ApiKey auth)
- [x] 3.3 Add `ES.connectCloud` (cloud ID + API key → ITransport with CloudNodePool)
- [x] 3.4 Create `esTransport { }` CE builder with operations: `uri`, `apiKey`, `basicAuth`, `requestTimeout`, `maxRetries`, `compression`, `disablePings`
- [x] 3.5 Update `Fes.fsproj` compile order: `Transport.fs` after `Json.fs`

## 4. ES.send / Request Execution

- [x] 4.1 Create inline `toEndpoint` function with static member constraint in `Transport.fs`
- [x] 4.2 Implement `ES.send`: `ITransport → ^TRequest → TaskResult<'TResponse, exn>` using `StringResponse` + `Json.deserialize`
- [x] 4.3 Handle error responses: map `ApiCallDetails` to `TransportException` or extract `OriginalException`

## 5. Generator Changes

- [x] 5.1 Update `OperationEmitter.fs`: change `emitToRequest` to `emitToEndpoint` — produce `EndpointPath * PostData voption` instead of `Result<HttpRequestMessage, exn>`
- [x] 5.2 Update `ESModuleEmitter.fs`: rename to Endpoints module, remove old send
- [x] 5.3 Regenerate all operation files and ES module
- [x] 5.4 Verify Fes.fsproj compiles with regenerated code

## 6. Cleanup

- [x] 6.1 Slim `Http.fs` to just `toQueryValue` utility (still used by generated code)
- [ ] 6.2 Adapt `Exceptions.fs` — simplify to work with `TransportException`/`ApiCallDetails` instead of custom parsing (deferred)
- [x] 6.3 Remove old DSL files (`src/Fes/DSL/`) and old generator (`scripts/generate-dsl.fsx`, `scripts/esapi.2025-01.yaml`)
- [x] 6.4 Update `Fes.fsproj` compile order and remove old file references

## 7. Tests

- [x] 7.1 Write tests for `FesSerializer` (serialise/deserialise round-trip via `Serializer` API)
- [x] 7.2 Write tests for `ES.connect`, `ES.connectWithApiKey`, `ES.connectCloud` (verify transport configuration)
- [x] 7.3 Write tests for `ToEndpoint` on key request types (search, get, delete, index create) — verify EndpointPath and PostData
- [x] 7.4 Write tests for query builders (`Query.bool`, `Query.match'`, `Query.term`) — verify DU construction
- [x] 7.5 Write tests for aggregation builders (`Aggregation.terms`, `Aggregation.avg`) — verify DU construction
- [x] 7.6 Write tests for CE builders (`searchRequest { }`, `boolQuery { }`) — verify record construction
- [x] 7.7 Write tests for JSON converter round-trips (enum, container variant, internal-tag)
- [x] 7.8 Remove old test files and update `Fes.Tests.fsproj`
- [x] 7.9 Verify all tests pass
