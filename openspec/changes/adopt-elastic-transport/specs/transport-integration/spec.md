## ADDED Requirements

### Requirement: FesSerializer bridges JsonSettings to Elastic.Transport
The library SHALL provide a `FesSerializer` class that extends `SystemTextJsonSerializer` and uses the existing `JsonSettings.options` (with all generated converters) as its `JsonSerializerOptions`.

#### Scenario: Serialiser is usable by the transport
- **WHEN** `FesSerializer` is passed to `TransportConfiguration`
- **THEN** the transport uses it for serialising `PostData.Serializable<T>` request bodies

### Requirement: ToEndpoint replaces ToRequest on generated request types
Each generated non-generic request type SHALL have a `static member ToEndpoint` that returns `EndpointPath * PostData option` instead of the current `Result<HttpRequestMessage, exn>`.

#### Scenario: Search request produces correct endpoint
- **WHEN** a `SearchRequest` with `Index = "products"` and query params is converted via `ToEndpoint`
- **THEN** it returns `EndpointPath(HttpMethod.Post, "/products/_search?q=...")` and `Some postData`

#### Scenario: Get request produces endpoint with no body
- **WHEN** a `GetRequest` with `Index = "products"` and `Id = "1"` is converted via `ToEndpoint`
- **THEN** it returns `EndpointPath(HttpMethod.Get, "/products/_doc/1")` and `None`

### Requirement: ES.send uses ITransport for request execution
`ES.send` SHALL accept an `ITransport` and a request value, call `transport.RequestAsync<StringResponse>`, deserialise the response body, and return `TaskResult<'TResponse, exn>`.

#### Scenario: Successful request round-trip
- **WHEN** `ES.send transport searchRequest` is called and Elasticsearch returns 200
- **THEN** the response body is deserialised into the expected response type
- **THEN** the result is `Ok responseValue`

#### Scenario: Failed request
- **WHEN** `ES.send transport request` is called and Elasticsearch returns an error
- **THEN** the result is `Error` containing a `TransportException` with `ApiCallDetails`

### Requirement: Static member constraint for toEndpoint
The library SHALL provide an inline `toEndpoint` function using static member constraints (`^T : (static member ToEndpoint: ^T -> EndpointPath * PostData option)`) to enable generic dispatch.

#### Scenario: Any request type works with ES.send
- **WHEN** a request type has `static member ToEndpoint`
- **THEN** it can be passed to `ES.send` without casting or explicit type annotation
