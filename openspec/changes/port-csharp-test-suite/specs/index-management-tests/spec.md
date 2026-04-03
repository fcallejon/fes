## ADDED Requirements

### Requirement: CreateIndex API tests
The CreateIndex test SHALL verify URL, JSON body with settings and mappings.

#### Scenario: CreateIndex request URL is correct
- **WHEN** a CreateIndex request is constructed for index `"project"`
- **THEN** the request URL is `PUT /project`

#### Scenario: CreateIndex with settings and mappings serialises correctly
- **WHEN** a CreateIndex request includes `settings` (number_of_shards, number_of_replicas) and `mappings` with properties
- **THEN** the JSON body contains `{"settings":{...},"mappings":{"properties":{...}}}`

### Requirement: GetIndex API tests
The GetIndex test SHALL verify URL and response deserialisation.

#### Scenario: GetIndex request URL is correct
- **WHEN** a GetIndex request is constructed for index `"project"`
- **THEN** the request URL is `GET /project`

#### Scenario: GetIndex response deserialises settings and mappings
- **WHEN** a GetIndex response JSON is deserialised
- **THEN** the typed response contains index settings and mapping properties

### Requirement: IndexSettings serialisation tests
The IndexSettings test SHALL verify settings JSON structure.

#### Scenario: IndexSettings serialises number_of_shards and number_of_replicas
- **WHEN** IndexSettings is constructed with `numberOfShards = 3`, `numberOfReplicas = 1`
- **THEN** serialising to JSON produces `{"number_of_shards":"3","number_of_replicas":"1"}`

#### Scenario: IndexSettings with analysis serialises correctly
- **WHEN** IndexSettings includes custom analysers, tokenisers, and filters
- **THEN** the JSON includes the `analysis` object with all components

### Requirement: GetAlias API tests
The GetAlias test SHALL verify URL construction.

#### Scenario: GetAlias request URL for specific alias is correct
- **WHEN** a GetAlias request is constructed for alias `"my-alias"`
- **THEN** the request URL is `GET /_alias/my-alias`

#### Scenario: GetAlias request URL for index-specific alias is correct
- **WHEN** a GetAlias request is constructed for index `"project"`, alias `"my-alias"`
- **THEN** the request URL is `GET /project/_alias/my-alias`

### Requirement: UpdateAliases API tests
The UpdateAliases test SHALL verify URL and actions body.

#### Scenario: UpdateAliases request URL is correct
- **WHEN** an UpdateAliases request is constructed
- **THEN** the request URL is `POST /_aliases`

#### Scenario: UpdateAliases with add and remove actions serialises correctly
- **WHEN** an UpdateAliases request includes an add action and a remove action
- **THEN** the JSON body contains `{"actions":[{"add":{"index":"...","alias":"..."}},{"remove":{"index":"...","alias":"..."}}]}`

### Requirement: GetDataStream API tests
The GetDataStream test SHALL verify URL construction.

#### Scenario: GetDataStream request URL is correct
- **WHEN** a GetDataStream request is constructed for `"my-data-stream"`
- **THEN** the request URL is `GET /_data_stream/my-data-stream`

### Requirement: GetFieldMapping API tests
The GetFieldMapping test SHALL verify URL construction.

#### Scenario: GetFieldMapping request URL is correct
- **WHEN** a GetFieldMapping request is constructed for index `"project"`, fields `"title"`
- **THEN** the request URL is `GET /project/_mapping/field/title`

### Requirement: GetMapping API tests
The GetMapping test SHALL verify URL and response.

#### Scenario: GetMapping request URL is correct
- **WHEN** a GetMapping request is constructed for index `"project"`
- **THEN** the request URL is `GET /project/_mapping`

#### Scenario: GetMapping response deserialises property types
- **WHEN** a GetMapping response JSON is deserialised
- **THEN** the typed response contains mapping properties with their field types

### Requirement: GetTemplate API tests
The GetTemplate test SHALL verify URL construction.

#### Scenario: GetTemplate request URL is correct
- **WHEN** a GetTemplate request is constructed for template `"my-template"`
- **THEN** the request URL is `GET /_template/my-template`
