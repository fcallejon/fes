## ADDED Requirements

### Requirement: DateTime type tests
The 2 DateTime test files SHALL verify date/time serialisation and parsing.

#### Scenario: DateMath expression serialises correctly
- **WHEN** a DateMath expression `"now-1d/d"` is serialised to JSON
- **THEN** it produces `"now-1d/d"`

#### Scenario: DateTime value round-trips through JSON
- **WHEN** a DateTime value `"2023-01-15T10:30:00Z"` is serialised and deserialised
- **THEN** the value is preserved

#### Scenario: Epoch milliseconds round-trip through JSON
- **WHEN** a date represented as epoch milliseconds is serialised and deserialised
- **THEN** the numeric value is preserved

### Requirement: Fields type tests
The Fields test file SHALL verify Fields serialisation and parsing.

#### Scenario: Single field serialises as string
- **WHEN** a Fields value containing one field `"title"` is serialised
- **THEN** it produces `"title"`

#### Scenario: Multiple fields serialise as array
- **WHEN** a Fields value containing `["title", "body"]` is serialised
- **THEN** it produces `["title","body"]`

### Requirement: Indices type tests
The Indices test file SHALL verify index name serialisation.

#### Scenario: Single index serialises as string
- **WHEN** an Indices value with one index `"project"` is serialised to a URL segment
- **THEN** it produces `"project"`

#### Scenario: Multiple indices serialise as comma-separated
- **WHEN** an Indices value with `["project", "other"]` is serialised to a URL segment
- **THEN** it produces `"project,other"`

#### Scenario: All indices serialises as _all
- **WHEN** an Indices.All value is serialised to a URL segment
- **THEN** it produces `"_all"`

### Requirement: TimeUnit type tests
The TimeUnit test file SHALL verify time unit serialisation and parsing.

#### Scenario: TimeUnit days serialises correctly
- **WHEN** a TimeUnit value of 5 days is serialised
- **THEN** it produces `"5d"`

#### Scenario: TimeUnit milliseconds serialises correctly
- **WHEN** a TimeUnit value of 500 milliseconds is serialised
- **THEN** it produces `"500ms"`

#### Scenario: TimeUnit minutes serialises correctly
- **WHEN** a TimeUnit value of 10 minutes is serialised
- **THEN** it produces `"10m"`

### Requirement: DataStreamName type tests
The 2 DataStreamName test files SHALL verify data stream name validation and serialisation.

#### Scenario: Valid data stream name is accepted
- **WHEN** `"my-data-stream"` is used as a DataStreamName
- **THEN** it is accepted without error

#### Scenario: Data stream name serialises to plain string
- **WHEN** a DataStreamName `"my-data-stream"` is serialised to a URL segment
- **THEN** it produces `"my-data-stream"`

### Requirement: IndexAlias type tests
The IndexAlias test file SHALL verify alias name serialisation.

#### Scenario: IndexAlias serialises to plain string
- **WHEN** an IndexAlias `"my-alias"` is serialised to a URL segment
- **THEN** it produces `"my-alias"`

### Requirement: Metrics type tests
The Metrics test file SHALL verify metric parameter serialisation.

#### Scenario: Single metric serialises as string
- **WHEN** a Metrics value with `"_all"` is serialised
- **THEN** it produces `"_all"`

#### Scenario: Multiple metrics serialise as comma-separated
- **WHEN** a Metrics value with `["metadata", "nodes"]` is serialised to a URL segment
- **THEN** it produces `"metadata,nodes"`

### Requirement: GeoBounds type tests
The GeoBounds test file SHALL verify geo bounds serialisation.

#### Scenario: GeoBounds with top_left and bottom_right serialises correctly
- **WHEN** a GeoBounds with `topLeft = { lat = 40.73, lon = -74.1 }` and `bottomRight = { lat = 40.01, lon = -71.12 }` is serialised
- **THEN** the JSON contains `"top_left"` and `"bottom_right"` with coordinate objects

### Requirement: GeoLocation type tests
The GeoLocation test file SHALL verify geo location serialisation formats.

#### Scenario: GeoLocation as object serialises with lat and lon
- **WHEN** a GeoLocation `{ lat = 40.73, lon = -74.1 }` is serialised
- **THEN** the JSON produces `{"lat":40.73,"lon":-74.1}`

#### Scenario: GeoLocation as array serialises as [lon, lat]
- **WHEN** a GeoLocation is serialised in array format
- **THEN** the JSON produces `[-74.1, 40.73]` (longitude first)

#### Scenario: GeoLocation as string serialises as "lat,lon"
- **WHEN** a GeoLocation is serialised in string format
- **THEN** the JSON produces `"40.73,-74.1"`
