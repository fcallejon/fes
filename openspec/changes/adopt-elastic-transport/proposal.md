## Why

FEs currently uses a raw `HttpClient` wrapper (`Http.fs`) for all Elasticsearch communication. This means the library has no connection pooling, node failover, retry logic, sniffing, or Elastic Cloud support — all things that the official `Elastic.Transport` library provides out of the box. This is the same transport layer used by the official C# client (`Elastic.Clients.Elasticsearch`), so adopting it gives us production-grade resilience for free and aligns us with the Elasticsearch ecosystem.

## What Changes

- **BREAKING**: Replace `Http.fs` request/response pipeline with `Elastic.Transport` (`ITransport`)
- **BREAKING**: `ES.send` takes an `ITransport` instead of `HttpClient`
- **BREAKING**: Generated `ToRequest` methods become `ToEndpoint` returning `EndpointPath * PostData option`
- New `FesSerializer` class: subclass of `SystemTextJsonSerializer` wrapping our existing `JsonSettings.options`
- New `Transport.fs` module: thin F# wrapper for `TransportConfiguration` — `ES.connect`, `ES.connectWithApiKey`, `ES.connectCloud`, and an `esTransport { }` CE for full configuration
- Add `Elastic.Transport 0.15.1` NuGet dependency
- Keep `TaskResult.fs`, `Result.fs`, `Task.fs` combinators unchanged
- Adapt error handling to use `TransportException` / `ApiCallDetails` instead of custom `ElasticsearchException`
- Remove `Http.fs` (replaced by `Transport.fs`)
- Update generator `OperationEmitter` and `ESModuleEmitter` to emit `ToEndpoint` instead of `ToRequest`

## Capabilities

### New Capabilities
- `transport-integration`: Wire up Elastic.Transport as the HTTP layer — serialiser, configuration, request/response lifecycle
- `transport-config`: F#-friendly configuration wrappers for connecting to Elasticsearch (single node, cloud, auth, timeouts)

### Modified Capabilities

## Impact

- **Fes.fsproj**: New dependency `Elastic.Transport 0.15.1`, remove `Http.fs`, add `Transport.fs`
- **Json.fs**: Add `FesSerializer` class (subclass of `SystemTextJsonSerializer`)
- **Exceptions.fs**: Adapt to map from `ApiCallDetails`/`TransportException`
- **Generator**: `OperationEmitter.fs` changes `ToRequest` → `ToEndpoint`; `ESModuleEmitter.fs` changes `ES.send` signature
- **All generated operation files**: Regenerated with new `ToEndpoint` methods
- **Tests**: Need updating for new transport-based API
- **Sample**: Need updating
