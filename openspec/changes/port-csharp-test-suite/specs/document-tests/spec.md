## ADDED Requirements

### Requirement: Bulk API tests
The 6 bulk test files SHALL verify bulk request URL, body serialisation (NDJSON format), and response deserialisation.

#### Scenario: Bulk request URL is correct
- **WHEN** a Bulk request is constructed
- **THEN** the request URL is `POST /_bulk`

#### Scenario: Bulk request with index-specific target URL is correct
- **WHEN** a Bulk request is constructed for index `"project"`
- **THEN** the request URL is `POST /project/_bulk`

#### Scenario: Bulk index operation serialises as NDJSON
- **WHEN** a Bulk request contains an index operation for document `{ "title": "test" }`
- **THEN** the body contains two NDJSON lines: action metadata `{"index":{"_index":"...","_id":"..."}}` and document `{"title":"test"}`

#### Scenario: Bulk delete operation serialises correctly
- **WHEN** a Bulk request contains a delete operation
- **THEN** the body contains one NDJSON line: `{"delete":{"_index":"...","_id":"..."}}`

#### Scenario: Bulk update operation serialises correctly
- **WHEN** a Bulk request contains an update operation with a partial document
- **THEN** the body contains two NDJSON lines: action metadata and `{"doc":{...}}`

#### Scenario: Bulk response deserialises item statuses
- **WHEN** a bulk response JSON is deserialised
- **THEN** each item contains `_index`, `_id`, `status`, and optionally `error`

### Requirement: BulkAll observable tests
The 7 BulkAll test files SHALL verify the observable bulk helper behaviour.

#### Scenario: BulkAll partitions documents into pages
- **WHEN** BulkAll is configured with `size = 100` and given 250 documents
- **THEN** it produces 3 bulk requests (100, 100, 50)

#### Scenario: BulkAll retries on failure
- **WHEN** a bulk request fails with a retryable error
- **THEN** BulkAll retries up to the configured `retries` count

#### Scenario: BulkAll backoff between retries
- **WHEN** BulkAll is configured with `backOffTime` and `backOffRetries`
- **THEN** retries are spaced by the configured backoff duration

#### Scenario: BulkAll reports progress per page
- **WHEN** BulkAll processes pages
- **THEN** the observer receives progress notifications with page number and item count

#### Scenario: BulkAll drops bad documents and continues
- **WHEN** a bulk response contains items with errors
- **THEN** BulkAll collects the errored documents and continues with remaining pages

#### Scenario: BulkAll with pipeline parameter
- **WHEN** BulkAll is configured with `pipeline = "my-pipeline"`
- **THEN** each bulk request includes `?pipeline=my-pipeline`

#### Scenario: BulkAll maximum runtime cancellation
- **WHEN** BulkAll is configured with `maximumRuntime` and the time expires
- **THEN** BulkAll stops processing and reports the partial result

### Requirement: DeleteByQuery API tests
The 2 DeleteByQuery test files SHALL verify URL and JSON body.

#### Scenario: DeleteByQuery request URL is correct
- **WHEN** a DeleteByQuery request is constructed for index `"project"`
- **THEN** the request URL is `POST /project/_delete_by_query`

#### Scenario: DeleteByQuery with query serialises body
- **WHEN** a DeleteByQuery request includes a match query
- **THEN** the JSON body contains `{"query":{"match":{...}}}`

### Requirement: MultiGet API tests
The MGet test file SHALL verify URL and body serialisation.

#### Scenario: MGet request URL is correct
- **WHEN** an MGet request is constructed
- **THEN** the request URL is `POST /_mget`

#### Scenario: MGet request body serialises docs array
- **WHEN** an MGet request includes multiple document references
- **THEN** the JSON body contains `{"docs":[{"_index":"...","_id":"..."},...]}`

### Requirement: Single document Create tests
The Create test file SHALL verify URL and body.

#### Scenario: Create request URL includes op_type
- **WHEN** a Create request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `PUT /project/_create/1`

#### Scenario: Create request body contains the document
- **WHEN** a Create request includes a document `{ "title": "test" }`
- **THEN** the JSON body is `{"title":"test"}`

### Requirement: Single document Delete tests
The Delete test file SHALL verify URL and response status.

#### Scenario: Delete request URL is correct
- **WHEN** a Delete request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `DELETE /project/_doc/1`

#### Scenario: Delete response deserialises result
- **WHEN** a delete response JSON with `"result": "deleted"` is deserialised
- **THEN** the typed response has `Result = "deleted"`

### Requirement: Document Exists tests
The 2 Exists test files SHALL verify URL and HEAD method.

#### Scenario: DocumentExists request URL and method are correct
- **WHEN** a DocumentExists request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `HEAD /project/_doc/1`

#### Scenario: SourceExists request URL is correct
- **WHEN** a SourceExists request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `HEAD /project/_source/1`

### Requirement: Single document Get tests
The Get test file SHALL verify URL and response deserialisation.

#### Scenario: Get request URL is correct
- **WHEN** a Get request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `GET /project/_doc/1`

#### Scenario: Get response deserialises source document
- **WHEN** a get response JSON with `"_source": { "title": "test" }` is deserialised
- **THEN** the typed response contains the source document

### Requirement: Index document tests
The 3 Index test files SHALL verify URL, body, and options.

#### Scenario: Index request URL without id uses POST
- **WHEN** an Index request is constructed for index `"project"` without an id
- **THEN** the request URL is `POST /project/_doc`

#### Scenario: Index request URL with id uses PUT
- **WHEN** an Index request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `PUT /project/_doc/1`

#### Scenario: Index request with refresh parameter
- **WHEN** an Index request includes `refresh = "wait_for"`
- **THEN** the request URL includes `?refresh=wait_for`

### Requirement: Source document tests
The Source test file SHALL verify URL for source retrieval.

#### Scenario: Source request URL is correct
- **WHEN** a Source request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `GET /project/_source/1`

### Requirement: Update document tests
The 4 Update test files SHALL verify URL and various update body formats.

#### Scenario: Update request URL is correct
- **WHEN** an Update request is constructed for index `"project"`, id `"1"`
- **THEN** the request URL is `POST /project/_update/1`

#### Scenario: Update with partial document serialises doc field
- **WHEN** an Update request includes a partial document
- **THEN** the JSON body contains `{"doc":{...}}`

#### Scenario: Update with script serialises script field
- **WHEN** an Update request includes a script
- **THEN** the JSON body contains `{"script":{"source":"...","lang":"painless"}}`

#### Scenario: Update with upsert serialises both doc and upsert
- **WHEN** an Update request includes both `doc` and `upsert`
- **THEN** the JSON body contains `{"doc":{...},"upsert":{...}}`

### Requirement: DocumentsCoordinated test
The DocumentsCoordinated test SHALL verify that document operations work together in sequence.

#### Scenario: Index then Get then Delete produces consistent results
- **WHEN** a document is indexed, then retrieved, then deleted
- **THEN** each operation produces the correct URL and the get response matches the indexed document
