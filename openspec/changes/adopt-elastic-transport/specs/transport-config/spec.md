## ADDED Requirements

### Requirement: ES.connect for single-node connection
`ES.connect` SHALL accept a URI string and return an `ITransport` configured with a `SingleNodePool`, default timeouts, and the `FesSerializer`.

#### Scenario: Connect to local Elasticsearch
- **WHEN** `ES.connect "http://localhost:9200"` is called
- **THEN** it returns an `ITransport` ready to send requests

### Requirement: ES.connectWithApiKey for API key auth
`ES.connectWithApiKey` SHALL accept a URI string and an API key string, returning an `ITransport` with `ApiKey` authentication configured.

#### Scenario: Connect with API key
- **WHEN** `ES.connectWithApiKey "http://localhost:9200" "my-api-key"` is called
- **THEN** the transport sends requests with the `ApiKey` authorization header

### Requirement: ES.connectCloud for Elastic Cloud
`ES.connectCloud` SHALL accept a cloud ID and an API key, returning an `ITransport` with `CloudNodePool` and compression enabled.

#### Scenario: Connect to Elastic Cloud
- **WHEN** `ES.connectCloud "deployment:base64..." "api-key"` is called
- **THEN** the transport connects to the cloud endpoint with API key auth and compression

### Requirement: esTransport CE for full configuration
An `esTransport { }` computation expression SHALL allow configuring all common transport options in an idiomatic F# style.

#### Scenario: Custom configuration
- **WHEN** a user writes:
  ```fsharp
  esTransport {
      uri "http://localhost:9200"
      apiKey "my-key"
      requestTimeout 30.
      maxRetries 3
      compression true
  }
  ```
- **THEN** it returns an `ITransport` with all specified options applied

#### Scenario: Basic auth
- **WHEN** a user writes `esTransport { uri "..."; basicAuth "user" "pass" }`
- **THEN** the transport uses basic authentication
