## ADDED Requirements

### Requirement: Bool query operator tests
The 8 bool query test files SHALL verify that combining queries with `&&`, `||`, and `!` operators produces correct JSON, and that bool query serialisation handles all clause types.

#### Scenario: And operator combines two queries into bool must
- **WHEN** two queries are combined with the `&&` operator
- **THEN** serialising to JSON produces a `bool` query with both queries in the `must` clause

#### Scenario: Or operator combines two queries into bool should
- **WHEN** two queries are combined with the `||` operator
- **THEN** serialising to JSON produces a `bool` query with both queries in the `should` clause

#### Scenario: Not operator wraps query in bool must_not
- **WHEN** a query is negated with the `!` operator
- **THEN** serialising to JSON produces a `bool` query with the query in the `must_not` clause

#### Scenario: Combining and/or/not operators produces nested bool
- **WHEN** queries are combined using mixed operators `(q1 && q2) || !q3`
- **THEN** serialising to JSON produces the correctly nested bool structure

#### Scenario: Bool query with must, should, filter, must_not serialises correctly
- **WHEN** a BoolQuery is constructed with all four clause types populated
- **THEN** serialising to JSON produces `{"bool":{"must":[...],"should":[...],"filter":[...],"must_not":[...]}}`

#### Scenario: Bool query with minimum_should_match serialises correctly
- **WHEN** a BoolQuery includes `minimumShouldMatch = 1`
- **THEN** the JSON includes `"minimum_should_match":1`

#### Scenario: Bool query with boost serialises correctly
- **WHEN** a BoolQuery includes `boost = 1.1`
- **THEN** the JSON includes `"boost":1.1`

#### Scenario: Empty bool clauses are omitted from JSON
- **WHEN** a BoolQuery has only `must` populated and `should`, `filter`, `must_not` are empty/None
- **THEN** only `"must"` appears in the serialised JSON

### Requirement: Compound query tests
The 2 compound query test files SHALL verify BoolQuery and FunctionScore query serialisation.

#### Scenario: FunctionScore query with script_score serialises correctly
- **WHEN** a FunctionScoreQuery is constructed with a `scriptScore` function and a query
- **THEN** serialising to JSON produces the expected `function_score` JSON with `query` and `functions` array

#### Scenario: FunctionScore query with weight and filter serialises correctly
- **WHEN** a FunctionScoreQuery function includes `weight` and `filter`
- **THEN** the JSON includes both fields in the function object

### Requirement: Geo query tests
The 3 geo query test files SHALL verify GeoBoundingBox, GeoDistance, and GeoPolygon query serialisation.

#### Scenario: GeoBoundingBox query serialises correctly
- **WHEN** a GeoBoundingBox query is constructed with `topLeft` and `bottomRight` coordinates
- **THEN** serialising to JSON produces `{"geo_bounding_box":{"<field>":{"top_left":...,"bottom_right":...}}}`

#### Scenario: GeoDistance query serialises correctly
- **WHEN** a GeoDistance query is constructed with `distance = "200km"` and a location
- **THEN** serialising to JSON produces `{"geo_distance":{"distance":"200km","<field>":...}}`

#### Scenario: GeoPolygon query serialises correctly
- **WHEN** a GeoPolygon query is constructed with a list of points
- **THEN** serialising to JSON produces `{"geo_polygon":{"<field>":{"points":[...]}}}`

### Requirement: Specialised query tests
The Pinned query test file SHALL verify pinned query serialisation.

#### Scenario: Pinned query with ids serialises correctly
- **WHEN** a Pinned query is constructed with `ids = ["1","2","3"]` and an `organic` sub-query
- **THEN** serialising to JSON produces `{"pinned":{"ids":["1","2","3"],"organic":{...}}}`

#### Scenario: Pinned query with docs serialises correctly
- **WHEN** a Pinned query is constructed with `docs` containing index and id pairs
- **THEN** serialising to JSON produces `{"pinned":{"docs":[{"_index":"...","_id":"..."}],"organic":{...}}}`

### Requirement: Raw JSON query test
The RawJsonQuery test SHALL verify that arbitrary JSON can be used as a query.

#### Scenario: Raw JSON query passes through unchanged
- **WHEN** a raw JSON string `{"match":{"title":"test"}}` is used as a query
- **THEN** the serialised search request contains that exact JSON in the `query` field
