## 1. Test Infrastructure

- [ ] 1.1 Download all ~170 `.verified.txt` snapshot files from `elasticsearch-net/tests/Tests/_VerifySnapshots/` into `tests/Fes.Tests/snapshots/`
- [ ] 1.2 Update `Snapshot.fs` to load snapshot files by name and return the expected JSON string
- [ ] 1.3 Create `assertJsonEqual` helper (order-independent JSON comparison using parsed JSON element trees)
- [ ] 1.4 Create `assertUrl` helper (construct request, call `ToEndpoint`, assert path and HTTP method)
- [ ] 1.5 Create `assertDeserialise` helper (JSON string to typed object, assert fields match expected values)
- [ ] 1.6 Create `assertJsonBody` helper (construct request, serialise body, compare with snapshot file)
- [ ] 1.7 Create `assertNdjsonBody` helper (construct bulk request, serialise, compare NDJSON lines)

## 2. Query DSL Tests (15 files)

- [ ] 2.1 Port BoolQueryAndOperatorTests (bool `&&` operator produces must clause)
- [ ] 2.2 Port BoolQueryOrOperatorTests (bool `||` operator produces should clause)
- [ ] 2.3 Port BoolQueryNotOperatorTests (bool `!` operator produces must_not clause)
- [ ] 2.4 Port BoolQueryCombinationTests (mixed operator combinations)
- [ ] 2.5 Port BoolQueryApiTests (API-level bool query construction)
- [ ] 2.6 Port BoolQuerySerialisationTests (bool query JSON serialisation)
- [ ] 2.7 Port BoolQueryMinimumShouldMatchTests (minimum_should_match field)
- [ ] 2.8 Port BoolQueryEmptyClausesTests (empty clauses omitted from JSON)
- [ ] 2.9 Port BoolQueryUsageTests (compound bool query)
- [ ] 2.10 Port FunctionScoreQueryUsageTests (function_score with script_score, weight, filter)
- [ ] 2.11 Port GeoBoundingBoxQueryUsageTests (geo_bounding_box query JSON)
- [ ] 2.12 Port GeoDistanceQueryUsageTests (geo_distance query JSON)
- [ ] 2.13 Port GeoPolygonQueryUsageTests (geo_polygon query JSON)
- [ ] 2.14 Port PinnedQueryUsageTests (pinned query with ids and docs)
- [ ] 2.15 Port RawJsonQueryUsageTests (raw JSON passthrough)

## 3. Aggregation Tests (31 files)

### Bucket Aggregations (9 files)

- [ ] 3.1 Port DateHistogramAggregationUsageTests
- [ ] 3.2 Port GeoDistanceAggregationUsageTests
- [ ] 3.3 Port GeohashGridAggregationUsageTests
- [ ] 3.4 Port GeotileGridAggregationUsageTests
- [ ] 3.5 Port IpPrefixAggregationUsageTests
- [ ] 3.6 Port MultiTermsAggregationUsageTests
- [ ] 3.7 Port RareTermsAggregationUsageTests
- [ ] 3.8 Port SignificantTermsAggregationUsageTests
- [ ] 3.9 Port TermsAggregationUsageTests

### Metric Aggregations (16 files)

- [ ] 3.10 Port AverageAggregationUsageTests
- [ ] 3.11 Port BoxplotAggregationUsageTests
- [ ] 3.12 Port CardinalityAggregationUsageTests
- [ ] 3.13 Port ExtendedStatsAggregationUsageTests
- [ ] 3.14 Port GeoBoundsAggregationUsageTests
- [ ] 3.15 Port GeoCentroidAggregationUsageTests
- [ ] 3.16 Port GeoLineAggregationUsageTests
- [ ] 3.17 Port MaxAggregationUsageTests
- [ ] 3.18 Port MedianAbsoluteDeviationAggregationUsageTests
- [ ] 3.19 Port MinAggregationUsageTests
- [ ] 3.20 Port StatsAggregationUsageTests
- [ ] 3.21 Port StringStatsAggregationUsageTests
- [ ] 3.22 Port StringStatsWithDistributionAggregationUsageTests
- [ ] 3.23 Port SumAggregationUsageTests
- [ ] 3.24 Port ValueCountAggregationUsageTests
- [ ] 3.25 Port WeightedAverageAggregationUsageTests

### Pipeline Aggregations (2 files)

- [ ] 3.26 Port BucketSortAggregationUsageTests
- [ ] 3.27 Port CumulativeSumAggregationUsageTests

## 4. Search Tests (11 files)

- [ ] 4.1 Port CountApiTests (URL + body)
- [ ] 4.2 Port ClearScrollApiTests (URL + body)
- [ ] 4.3 Port ScrollInitiationTests (search with scroll parameter)
- [ ] 4.4 Port ScrollContinuationTests (scroll request with scroll_id)
- [ ] 4.5 Port SlicedScrollTests (scroll with slice configuration)
- [ ] 4.6 Port BasicSortUsageTests (field, score, geo_distance sort)
- [ ] 4.7 Port SearchApiTests (URL + basic request body)
- [ ] 4.8 Port SearchRequestSerializationTests (full request with all fields)
- [ ] 4.9 Port SortUsageTests (sort serialisation variants)
- [ ] 4.10 Port SearchResponseDeserializationTests (hits, total, aggregations)
- [ ] 4.11 Port SearchResponseWithAggregationsTests (named aggregation results)

## 5. Document Tests (30 files)

### Bulk (6 files)

- [ ] 5.1 Port BulkUrlTests (URL with and without index)
- [ ] 5.2 Port BulkIndexOperationTests (NDJSON index action + document)
- [ ] 5.3 Port BulkDeleteOperationTests (NDJSON delete action)
- [ ] 5.4 Port BulkUpdateOperationTests (NDJSON update action + partial doc)
- [ ] 5.5 Port BulkCreateOperationTests (NDJSON create action)
- [ ] 5.6 Port BulkResponseDeserializationTests (item statuses and errors)

### BulkAll (7 files)

- [ ] 5.7 Port BulkAllPartitioningTests (document batching by size)
- [ ] 5.8 Port BulkAllRetryTests (retry on failure)
- [ ] 5.9 Port BulkAllBackoffTests (backoff between retries)
- [ ] 5.10 Port BulkAllProgressTests (progress reporting per page)
- [ ] 5.11 Port BulkAllErrorHandlingTests (drop bad documents, continue)
- [ ] 5.12 Port BulkAllPipelineTests (pipeline parameter)
- [ ] 5.13 Port BulkAllMaxRuntimeTests (cancellation on timeout)

### DeleteByQuery (2 files)

- [ ] 5.14 Port DeleteByQueryUrlTests (URL construction)
- [ ] 5.15 Port DeleteByQueryBodyTests (query body serialisation)

### MGet (1 file)

- [ ] 5.16 Port MultiGetApiTests (URL + docs array body)

### Single Document (14 files)

- [ ] 5.17 Port CreateDocumentUrlTests (PUT with _create path)
- [ ] 5.18 Port DeleteDocumentUrlTests (DELETE URL)
- [ ] 5.19 Port DeleteDocumentResponseTests (result field deserialisation)
- [ ] 5.20 Port DocumentExistsUrlTests (HEAD URL)
- [ ] 5.21 Port SourceExistsUrlTests (HEAD _source URL)
- [ ] 5.22 Port GetDocumentUrlTests (GET URL)
- [ ] 5.23 Port GetDocumentResponseTests (source deserialisation)
- [ ] 5.24 Port IndexDocumentPostUrlTests (POST without id)
- [ ] 5.25 Port IndexDocumentPutUrlTests (PUT with id)
- [ ] 5.26 Port IndexDocumentRefreshTests (refresh query parameter)
- [ ] 5.27 Port SourceDocumentUrlTests (GET _source URL)
- [ ] 5.28 Port UpdateDocumentUrlTests (POST _update URL)
- [ ] 5.29 Port UpdateDocumentPartialTests (doc body)
- [ ] 5.30 Port UpdateDocumentScriptTests (script body)
- [ ] 5.31 Port UpdateDocumentUpsertTests (doc + upsert body)

### Coordinated (1 file)

- [ ] 5.32 Port DocumentsCoordinatedTests (index then get then delete sequence)

## 6. Serialization Tests (28 files)

### Root (12 files)

- [ ] 6.1 Port SearchResponseSerializationTests
- [ ] 6.2 Port BulkResponseSerializationTests
- [ ] 6.3 Port MultiGetResponseSerializationTests
- [ ] 6.4 Port ClusterHealthResponseSerializationTests
- [ ] 6.5 Port IndexResponseSerializationTests
- [ ] 6.6 Port GetResponseSerializationTests
- [ ] 6.7 Port DeleteResponseSerializationTests
- [ ] 6.8 Port UpdateResponseSerializationTests
- [ ] 6.9 Port CreateResponseSerializationTests
- [ ] 6.10 Port CountResponseSerializationTests
- [ ] 6.11 Port ScrollResponseSerializationTests
- [ ] 6.12 Port DeleteByQueryResponseSerializationTests

### Aggregations (12 files)

- [ ] 6.13 Port TermsAggregationSerializationTests (request + response round-trip)
- [ ] 6.14 Port DateHistogramAggregationSerializationTests
- [ ] 6.15 Port NestedAggregationSerializationTests (sub-aggregation preservation)
- [ ] 6.16 Port AvgAggregationSerializationTests
- [ ] 6.17 Port SumAggregationSerializationTests
- [ ] 6.18 Port MinAggregationSerializationTests
- [ ] 6.19 Port MaxAggregationSerializationTests
- [ ] 6.20 Port CardinalityAggregationSerializationTests
- [ ] 6.21 Port ValueCountAggregationSerializationTests
- [ ] 6.22 Port ExtendedStatsAggregationSerializationTests
- [ ] 6.23 Port BucketSortAggregationSerializationTests
- [ ] 6.24 Port CumulativeSumAggregationSerializationTests

### Bulk (2 files)

- [ ] 6.25 Port BulkRequestNdjsonSerializationTests
- [ ] 6.26 Port BulkResponseItemSerializationTests

### Documents (2 files)

- [ ] 6.27 Port NestedDocumentSerializationTests
- [ ] 6.28 Port AllFieldTypesDocumentSerializationTests

### Mapping (2 files)

- [ ] 6.29 Port MappingPropertiesSerializationTests
- [ ] 6.30 Port MultiFieldMappingSerializationTests

### Queries (5 files)

- [ ] 6.31 Port BoolQuerySerializationTests
- [ ] 6.32 Port MatchQuerySerializationTests
- [ ] 6.33 Port TermQuerySerializationTests
- [ ] 6.34 Port RangeQuerySerializationTests
- [ ] 6.35 Port NestedQuerySerializationTests

### Requests (1 file)

- [ ] 6.36 Port SearchRequestFullSerializationTests

### Scripting (2 files)

- [ ] 6.37 Port InlineScriptSerializationTests
- [ ] 6.38 Port StoredScriptSerializationTests

### Types (1 file)

- [ ] 6.39 Port DurationSerializationTests

### Xpack (1 file)

- [ ] 6.40 Port XpackResponseSerializationTests

## 7. Index Management Tests (9 files)

- [ ] 7.1 Port CreateIndexApiTests (URL + settings + mappings body)
- [ ] 7.2 Port GetIndexApiTests (URL + response deserialisation)
- [ ] 7.3 Port IndexSettingsSerializationTests (shards, replicas, analysis)
- [ ] 7.4 Port GetAliasApiTests (URL with alias and index variants)
- [ ] 7.5 Port UpdateAliasesApiTests (URL + add/remove actions body)
- [ ] 7.6 Port GetDataStreamApiTests (URL construction)
- [ ] 7.7 Port GetFieldMappingApiTests (URL construction)
- [ ] 7.8 Port GetMappingApiTests (URL + response deserialisation)
- [ ] 7.9 Port GetTemplateApiTests (URL construction)

## 8. Cluster Tests (7 files)

- [ ] 8.1 Port AllocationExplainUrlTests (URL construction)
- [ ] 8.2 Port AllocationExplainResponseTests (body + response deserialisation)
- [ ] 8.3 Port ClusterHealthUrlTests (URL with no params, index, wait_for_status)
- [ ] 8.4 Port ClusterHealthResponseTests (response field deserialisation)
- [ ] 8.5 Port ClusterHealthStatusTests (status enum deserialisation)
- [ ] 8.6 Port PendingTasksUrlTests (URL construction)
- [ ] 8.7 Port PendingTasksResponseTests (task list deserialisation)
- [ ] 8.8 Port ClusterStateUrlTests (URL with metrics and index variants)

## 9. Client Concept Tests (29 files)

### Errors (6 files)

- [ ] 9.1 Port RootCauseErrorTests (error.root_cause parsing)
- [ ] 9.2 Port CausedByErrorTests (nested caused_by chain)
- [ ] 9.3 Port ErrorMetadataTests (additional error fields)
- [ ] 9.4 Port NotFoundErrorTests (404 response handling)
- [ ] 9.5 Port BulkItemErrorTests (per-item error parsing)
- [ ] 9.6 Port NoBodyErrorTests (error with no JSON body)

### Inference (24 files)

- [ ] 9.7 Port IndexNameInferenceTests (string to IndexName)
- [ ] 9.8 Port IdInferenceTests (string and int to Id)
- [ ] 9.9 Port FieldInferenceTests (string to Field)
- [ ] 9.10 Port RoutingInferenceTests (string to Routing)
- [ ] 9.11 Port FieldsInferenceTests (string array to Fields)
- [ ] 9.12 Port IndicesInferenceTests (string to Indices)
- [ ] 9.13 Port TypeInferenceUrlSerializationTests (types serialise to plain strings in URLs)
- [ ] 9.14 Port IndexNameEqualityTests
- [ ] 9.15 Port IndexNameInequalityTests
- [ ] 9.16 Port IdEqualityTests
- [ ] 9.17 Port IdInequalityTests
- [ ] 9.18 Port FieldEqualityTests
- [ ] 9.19 Port FieldInequalityTests
- [ ] 9.20 Port RoutingEqualityTests
- [ ] 9.21 Port RoutingInequalityTests
- [ ] 9.22 Port IndicesEqualityTests
- [ ] 9.23 Port IndicesInequalityTests
- [ ] 9.24 Port FieldsEqualityTests
- [ ] 9.25 Port FieldsInequalityTests
- [ ] 9.26 Port DataStreamNameEqualityTests
- [ ] 9.27 Port DataStreamNameInequalityTests
- [ ] 9.28 Port MetricsEqualityTests
- [ ] 9.29 Port MetricsInequalityTests
- [ ] 9.30 Port FieldJsonSerializationTests (Field to plain JSON string)

### Mapping (2 files)

- [ ] 9.31 Port CamelCaseFieldMappingTests (PascalCase to snake_case)
- [ ] 9.32 Port CustomFieldMappingTests (override convention)

### Serialization (1 file)

- [ ] 9.33 Port SerializerConventionTests (user doc naming vs ES type naming)

## 10. Common Type Tests (11 files)

### DateTime (2 files)

- [ ] 10.1 Port DateMathExpressionTests (date math string serialisation)
- [ ] 10.2 Port DateTimeSerializationTests (ISO and epoch round-trips)

### Fields (1 file)

- [ ] 10.3 Port FieldsSerializationTests (single string vs array)

### Indices (1 file)

- [ ] 10.4 Port IndicesSerializationTests (single, multiple, _all)

### TimeUnit (1 file)

- [ ] 10.5 Port TimeUnitSerializationTests (days, ms, minutes format)

### DataStreamNames (2 files)

- [ ] 10.6 Port DataStreamNameValidationTests (valid names accepted)
- [ ] 10.7 Port DataStreamNameSerializationTests (plain string output)

### IndexAlias (1 file)

- [ ] 10.8 Port IndexAliasSerializationTests (plain string output)

### Metrics (1 file)

- [ ] 10.9 Port MetricsSerializationTests (single, comma-separated)

### GeoBounds (1 file)

- [ ] 10.10 Port GeoBoundsSerializationTests (top_left, bottom_right)

### GeoLocation (1 file)

- [ ] 10.11 Port GeoLocationSerializationTests (object, array, string formats)
