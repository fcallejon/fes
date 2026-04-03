## ADDED Requirements

### Requirement: Count API tests
The Count test SHALL verify URL construction and JSON body for count requests.

#### Scenario: Count request URL is correct
- **WHEN** a Count request is constructed for index `"project"`
- **THEN** the request URL is `POST /project/_count`

#### Scenario: Count request with query serialises body
- **WHEN** a Count request includes a match_all query
- **THEN** the JSON body contains `{"query":{"match_all":{}}}`

### Requirement: ClearScroll API tests
The ClearScroll test SHALL verify URL construction and body.

#### Scenario: ClearScroll request URL is correct
- **WHEN** a ClearScroll request is constructed with a scroll_id
- **THEN** the request URL is `DELETE /_search/scroll`
- **THEN** the JSON body contains the scroll_id

### Requirement: Scroll API tests
The 3 scroll test files SHALL verify scroll initiation, continuation, and slice configuration.

#### Scenario: Initial search with scroll parameter produces correct URL
- **WHEN** a Search request is constructed with `scroll = "5m"`
- **THEN** the request URL includes `?scroll=5m`

#### Scenario: Scroll continuation request URL is correct
- **WHEN** a Scroll request is constructed with `scrollId` and `scroll = "5m"`
- **THEN** the request URL is `POST /_search/scroll`
- **THEN** the JSON body contains `{"scroll":"5m","scroll_id":"..."}`

#### Scenario: Sliced scroll request serialises slice configuration
- **WHEN** a Search request includes a `slice` with `id = 0`, `max = 5`
- **THEN** the JSON body contains `{"slice":{"id":0,"max":5}}`

### Requirement: Search API tests
The 5 search test files SHALL verify URL construction, JSON body serialisation, sort usage, and response deserialisation.

#### Scenario: Basic search request URL is correct
- **WHEN** a Search request is constructed for index `"project"`
- **THEN** the request URL is `POST /project/_search`

#### Scenario: Search request with query and size serialises correctly
- **WHEN** a Search request includes a match_all query and `size = 10`
- **THEN** the JSON body contains `{"query":{"match_all":{}},"size":10}`

#### Scenario: Search request serialisation handles all top-level fields
- **WHEN** a Search request includes `query`, `from`, `size`, `sort`, `_source`, `aggregations`, `highlight`, `post_filter`, `track_total_hits`
- **THEN** all fields appear in the serialised JSON with correct names

#### Scenario: Sort by field ascending serialises correctly
- **WHEN** a search sort is configured with `field = "date"`, `order = "asc"`
- **THEN** the JSON sort entry is `{"date":{"order":"asc"}}`

#### Scenario: Sort by score descending serialises correctly
- **WHEN** a search sort is configured with `"_score"` descending
- **THEN** the JSON sort entry is `{"_score":{"order":"desc"}}`

#### Scenario: Sort by geo distance serialises correctly
- **WHEN** a search sort uses geo_distance with a field, location, and unit
- **THEN** the JSON sort entry contains `{"_geo_distance":{...}}`

#### Scenario: Search response deserialises hits
- **WHEN** a search response JSON with `hits.hits` array is deserialised
- **THEN** the typed response contains `Hits` with `Total`, `MaxScore`, and `Hits` list

#### Scenario: Search response deserialises aggregations
- **WHEN** a search response JSON includes `aggregations` with named buckets
- **THEN** the aggregation results are accessible by name
