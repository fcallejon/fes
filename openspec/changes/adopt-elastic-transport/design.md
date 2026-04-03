## Context

FEs has a working code generator producing types, operations, builders, converters, and an ES module from the Elasticsearch `schema.json`. The HTTP layer (`Http.fs`) uses raw `HttpClient` — no pooling, failover, or cloud support. `Elastic.Transport 0.15.1` is the official transport used by the C# Elasticsearch client, providing all of this.

Current pipeline: `FesRequest → ToRequest → HttpRequestMessage → HttpClient.SendAsync → HttpResponseMessage → Json.deserialize → TaskResult`

Target pipeline: `FesRequest → ToEndpoint → EndpointPath + PostData → ITransport.RequestAsync<StringResponse> → Json.deserialize → TaskResult`

## Goals / Non-Goals

**Goals:**
- Replace `HttpClient` with `Elastic.Transport` for production-grade HTTP handling
- Plug our existing `JsonSettings.options` (with all generated converters) into the transport's serialiser
- Provide idiomatic F# configuration: `ES.connect`, `ES.connectWithApiKey`, `ES.connectCloud`, `esTransport { }`
- Keep `TaskResult` monadic composition unchanged
- Keep `Json.fs` serialisation logic, just add the `FesSerializer` bridge class
- Adopt `TransportException`/`ApiCallDetails` for error handling

**Non-Goals:**
- Custom `IRequestInvoker` implementation (use the default `HttpRequestInvoker`)
- Custom `ProductRegistration` (not needed for a client library)
- Supporting both `HttpClient` and `ITransport` simultaneously
- Type-safe response deserialisation via the transport (use `StringResponse` + our own deser)

## Decisions

### D1: Use StringResponse + own deserialisation

**Choice**: Call `transport.RequestAsync<StringResponse>()` and deserialise the response body ourselves via `Json.deserialize<'T>`.

**Why not transport-native deserialisation**: The transport's `TResponse` requires `new()` constraint which F# records can't satisfy. Using `StringResponse` sidesteps this entirely and keeps our existing `Json.fs` (with `FSharp.SystemTextJson`, generated converters, etc.) as the single serialisation path.

### D2: FesSerializer as SystemTextJsonSerializer subclass

**Choice**: Create `FesSerializer` extending `SystemTextJsonSerializer` via `IJsonSerializerOptionsProvider` that returns our `JsonSettings.options`.

**Why**: `SystemTextJsonSerializer` implements all 8 abstract `Serializer` methods for us. We only need to provide the `JsonSerializerOptions`. This is used by the transport for `PostData.Serializable<T>()` serialisation.

### D3: ToEndpoint replaces ToRequest

**Choice**: Generated request types change from `static member ToRequest(req) : Result<HttpRequestMessage, exn>` to `static member ToEndpoint(req) : EndpointPath * PostData option`.

**Why**: No more `HttpRequestMessage` construction. The `EndpointPath` is a simple `struct(HttpMethod, string)` and `PostData` is the transport's body abstraction. The tuple is pure data — no error case needed (path construction can't fail).

### D4: Configuration via functions + optional CE

**Choice**: Provide simple functions for common cases and a CE for full control:
```
ES.connect "http://localhost:9200"
ES.connectWithApiKey "http://localhost:9200" "key"
ES.connectCloud "cloudId" "apiKey"
esTransport { uri "..."; apiKey "..."; requestTimeout 30. }
```

**Why**: Most users need single-node with optional auth. The CE covers advanced cases (timeouts, retries, compression, node predicates) without requiring users to learn the C# `TransportConfiguration` API.

### D5: Error handling via TransportException

**Choice**: Replace custom `ElasticsearchException` with the transport's `TransportException` and `ApiCallDetails`. Map errors in `ES.send`.

**Why**: The transport already classifies errors, tracks audit trails, and provides `DebugInformation`. Duplicating this is waste. Our `Exceptions.fs` becomes a thin adapter.

## Risks / Trade-offs

**[Risk] Elastic.Transport 0.15.1 is pre-1.0** → Mitigation: It's what the official C# client uses in production. API stability is effectively guaranteed by the C# client's dependency on it.

**[Risk] F# ergonomics of C# record init properties** → Mitigation: The `esTransport { }` CE wraps all configuration, users never touch `TransportConfiguration` directly.

**[Trade-off] StringResponse adds a string allocation** → The transport deserialises the body to string, then we deserialise string to types. For most ES responses this is negligible. Could optimise later with `BytesResponse` + stream deserialisation if needed.
