## ADDED Requirements

### Requirement: Bucket aggregation serialisation tests
All 9 bucket aggregation types SHALL have tests verifying that the F# aggregation construction serialises to the expected JSON and that aggregation responses deserialise correctly.

#### Scenario: DateHistogram aggregation JSON matches expected output
- **WHEN** a DateHistogram aggregation is constructed with `field = "timestamp"`, `calendarInterval = "month"`
- **THEN** serialising to JSON produces `{"date_histogram":{"field":"timestamp","calendar_interval":"month"}}`
- **THEN** deserialising a DateHistogram response with buckets produces typed bucket objects with `key_as_string`, `doc_count`

#### Scenario: GeoDistance aggregation JSON matches expected output
- **WHEN** a GeoDistance aggregation is constructed with `field = "location"`, `origin`, and `ranges`
- **THEN** serialising to JSON produces the expected `geo_distance` JSON structure
- **THEN** deserialising a GeoDistance response produces typed buckets with `from`, `to`, `doc_count`

#### Scenario: GeohashGrid aggregation JSON matches expected output
- **WHEN** a GeohashGrid aggregation is constructed with `field = "location"`, `precision = 3`
- **THEN** serialising to JSON produces `{"geohash_grid":{"field":"location","precision":3}}`

#### Scenario: GeotileGrid aggregation JSON matches expected output
- **WHEN** a GeotileGrid aggregation is constructed with `field = "location"`, `precision = 8`
- **THEN** serialising to JSON produces `{"geotile_grid":{"field":"location","precision":8}}`

#### Scenario: IpPrefix aggregation JSON matches expected output
- **WHEN** an IpPrefix aggregation is constructed with `field = "ip"`, `prefixLength = 24`
- **THEN** serialising to JSON produces `{"ip_prefix":{"field":"ip","prefix_length":24}}`

#### Scenario: MultiTerms aggregation JSON matches expected output
- **WHEN** a MultiTerms aggregation is constructed with multiple `terms` entries
- **THEN** serialising to JSON produces the expected `multi_terms` JSON with a `terms` array

#### Scenario: RareTerms aggregation JSON matches expected output
- **WHEN** a RareTerms aggregation is constructed with `field = "tags"`, `maxDocCount = 1`
- **THEN** serialising to JSON produces `{"rare_terms":{"field":"tags","max_doc_count":1}}`

#### Scenario: SignificantTerms aggregation JSON matches expected output
- **WHEN** a SignificantTerms aggregation is constructed with `field = "tags"`
- **THEN** serialising to JSON produces the expected `significant_terms` JSON structure

#### Scenario: Terms aggregation JSON matches expected output
- **WHEN** a Terms aggregation is constructed with `field = "status"`, `size = 10`
- **THEN** serialising to JSON produces `{"terms":{"field":"status","size":10}}`
- **THEN** deserialising a Terms response with buckets produces typed bucket objects with `key`, `doc_count`

### Requirement: Metric aggregation serialisation tests
All 16 metric aggregation types SHALL have tests verifying JSON serialisation and response deserialisation.

#### Scenario: Average aggregation JSON matches expected output
- **WHEN** an Average aggregation is constructed with `field = "price"`
- **THEN** serialising to JSON produces `{"avg":{"field":"price"}}`
- **THEN** deserialising a response with `"value": 75.0` produces a typed result

#### Scenario: Boxplot aggregation JSON matches expected output
- **WHEN** a Boxplot aggregation is constructed with `field = "load_time"`
- **THEN** serialising to JSON produces `{"boxplot":{"field":"load_time"}}`
- **THEN** deserialising a response produces typed result with `min`, `max`, `q1`, `q2`, `q3`

#### Scenario: Cardinality aggregation JSON matches expected output
- **WHEN** a Cardinality aggregation is constructed with `field = "author"`
- **THEN** serialising to JSON produces `{"cardinality":{"field":"author"}}`

#### Scenario: ExtendedStats aggregation JSON matches expected output
- **WHEN** an ExtendedStats aggregation is constructed with `field = "grade"`
- **THEN** serialising to JSON produces `{"extended_stats":{"field":"grade"}}`
- **THEN** deserialising a response produces typed result with `count`, `min`, `max`, `avg`, `sum`, `std_deviation`

#### Scenario: GeoBounds aggregation JSON matches expected output
- **WHEN** a GeoBounds aggregation is constructed with `field = "location"`
- **THEN** serialising to JSON produces `{"geo_bounds":{"field":"location"}}`

#### Scenario: GeoCentroid aggregation JSON matches expected output
- **WHEN** a GeoCentroid aggregation is constructed with `field = "location"`
- **THEN** serialising to JSON produces `{"geo_centroid":{"field":"location"}}`

#### Scenario: GeoLine aggregation JSON matches expected output
- **WHEN** a GeoLine aggregation is constructed with `point` and `sort` fields
- **THEN** serialising to JSON produces the expected `geo_line` JSON structure

#### Scenario: Max aggregation JSON matches expected output
- **WHEN** a Max aggregation is constructed with `field = "price"`
- **THEN** serialising to JSON produces `{"max":{"field":"price"}}`

#### Scenario: MedianAbsoluteDeviation aggregation JSON matches expected output
- **WHEN** a MedianAbsoluteDeviation aggregation is constructed with `field = "rating"`
- **THEN** serialising to JSON produces `{"median_absolute_deviation":{"field":"rating"}}`

#### Scenario: Min aggregation JSON matches expected output
- **WHEN** a Min aggregation is constructed with `field = "price"`
- **THEN** serialising to JSON produces `{"min":{"field":"price"}}`

#### Scenario: Stats aggregation JSON matches expected output
- **WHEN** a Stats aggregation is constructed with `field = "grade"`
- **THEN** serialising to JSON produces `{"stats":{"field":"grade"}}`

#### Scenario: StringStats aggregation JSON matches expected output
- **WHEN** a StringStats aggregation is constructed with `field = "message.keyword"`
- **THEN** serialising to JSON produces `{"string_stats":{"field":"message.keyword"}}`

#### Scenario: StringStatsWithDistribution aggregation JSON matches expected output
- **WHEN** a StringStats aggregation is constructed with `field = "message.keyword"` and `showDistribution = true`
- **THEN** serialising to JSON produces `{"string_stats":{"field":"message.keyword","show_distribution":true}}`

#### Scenario: Sum aggregation JSON matches expected output
- **WHEN** a Sum aggregation is constructed with `field = "price"`
- **THEN** serialising to JSON produces `{"sum":{"field":"price"}}`

#### Scenario: ValueCount aggregation JSON matches expected output
- **WHEN** a ValueCount aggregation is constructed with `field = "price"`
- **THEN** serialising to JSON produces `{"value_count":{"field":"price"}}`

#### Scenario: WeightedAverage aggregation JSON matches expected output
- **WHEN** a WeightedAverage aggregation is constructed with `value` and `weight` fields
- **THEN** serialising to JSON produces the expected `weighted_avg` JSON structure

### Requirement: Pipeline aggregation serialisation tests
All 2 pipeline aggregation types SHALL have tests verifying JSON serialisation.

#### Scenario: BucketSort aggregation JSON matches expected output
- **WHEN** a BucketSort aggregation is constructed with `sort` and `size`
- **THEN** serialising to JSON produces the expected `bucket_sort` JSON structure

#### Scenario: CumulativeSum aggregation JSON matches expected output
- **WHEN** a CumulativeSum aggregation is constructed with `bucketsPath = "sales"`
- **THEN** serialising to JSON produces `{"cumulative_sum":{"buckets_path":"sales"}}`
