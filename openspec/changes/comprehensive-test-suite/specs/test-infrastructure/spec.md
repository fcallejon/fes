## ADDED Requirements

### Requirement: TestTransport module for in-memory testing
A `TestTransport` module SHALL provide helper functions to create `ITransport` instances backed by `InMemoryRequestInvoker` for testing without a real Elasticsearch.

#### Scenario: Create transport with fixed JSON response
- **WHEN** `TestTransport.withResponse """{"acknowledged":true}""" 200` is called
- **THEN** it returns an `ITransport` that returns that response for every request
- **THEN** `DisableDirectStreaming` is enabled so `RequestBodyInBytes` and `ResponseBodyInBytes` are captured

#### Scenario: Access captured request details after a call
- **WHEN** a request is sent through the in-memory transport
- **THEN** `ApiCallDetails.Uri.PathAndQuery` contains the request path
- **THEN** `ApiCallDetails.HttpMethod` contains the HTTP method
- **THEN** `ApiCallDetails.RequestBodyInBytes` contains the serialised request body (when present)

### Requirement: Snapshot verification helper
A `Snapshot` module SHALL provide a function to compare serialised JSON against golden files stored in a `snapshots/` directory.

#### Scenario: First run creates snapshot file
- **WHEN** `Snapshot.verify "test-name" jsonString` is called and no snapshot file exists
- **THEN** the snapshot file is created at `snapshots/test-name.json`
- **THEN** the test fails with a message to review the snapshot

#### Scenario: Subsequent runs compare against snapshot
- **WHEN** `Snapshot.verify "test-name" jsonString` is called and a snapshot file exists
- **THEN** the JSON is compared against the file content
- **THEN** the test passes if they match, fails with a diff if they don't
