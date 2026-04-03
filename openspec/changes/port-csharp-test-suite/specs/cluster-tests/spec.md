## ADDED Requirements

### Requirement: Cluster allocation explain tests
The 2 allocation explain test files SHALL verify URL, request body, and response deserialisation.

#### Scenario: AllocationExplain request URL is correct
- **WHEN** a ClusterAllocationExplain request is constructed
- **THEN** the request URL is `POST /_cluster/allocation/explain`

#### Scenario: AllocationExplain with index and shard serialises body
- **WHEN** a ClusterAllocationExplain request includes `index = "project"`, `shard = 0`, `primary = true`
- **THEN** the JSON body contains `{"index":"project","shard":0,"primary":true}`

#### Scenario: AllocationExplain response deserialises shard allocation details
- **WHEN** an allocation explain response JSON is deserialised
- **THEN** the typed response contains `index`, `shard`, `primary`, `current_state`, and allocation decision details

### Requirement: Cluster health tests
The 3 health test files SHALL verify URL construction with various parameters and response deserialisation.

#### Scenario: ClusterHealth request URL with no parameters is correct
- **WHEN** a ClusterHealth request is constructed with no arguments
- **THEN** the request URL is `GET /_cluster/health`

#### Scenario: ClusterHealth request URL with index is correct
- **WHEN** a ClusterHealth request is constructed for index `"project"`
- **THEN** the request URL is `GET /_cluster/health/project`

#### Scenario: ClusterHealth request URL with wait_for_status is correct
- **WHEN** a ClusterHealth request includes `waitForStatus = "yellow"`
- **THEN** the request URL includes `?wait_for_status=yellow`

#### Scenario: ClusterHealth response deserialises all fields
- **WHEN** a cluster health response JSON is deserialised
- **THEN** the typed response contains `clusterName`, `status`, `numberOfNodes`, `numberOfDataNodes`, `activePrimaryShards`, `activeShards`, `relocatingShards`, `initializingShards`, `unassignedShards`

#### Scenario: ClusterHealth response status values are typed
- **WHEN** a cluster health response has `"status": "green"`
- **THEN** the deserialised status is the `Green` enum case (not a raw string)

### Requirement: Pending tasks tests
The 2 pending tasks test files SHALL verify URL and response deserialisation.

#### Scenario: PendingTasks request URL is correct
- **WHEN** a PendingClusterTasks request is constructed
- **THEN** the request URL is `GET /_cluster/pending_tasks`

#### Scenario: PendingTasks response deserialises task list
- **WHEN** a pending tasks response JSON is deserialised
- **THEN** the typed response contains a list of tasks with `insertOrder`, `priority`, `source`, `timeInQueue`

### Requirement: Cluster state tests
The cluster state test file SHALL verify URL construction.

#### Scenario: ClusterState request URL with no parameters is correct
- **WHEN** a ClusterState request is constructed
- **THEN** the request URL is `GET /_cluster/state`

#### Scenario: ClusterState request URL with metrics is correct
- **WHEN** a ClusterState request is constructed with `metric = "metadata"`
- **THEN** the request URL is `GET /_cluster/state/metadata`

#### Scenario: ClusterState request URL with metrics and index is correct
- **WHEN** a ClusterState request is constructed with `metric = "metadata"`, `index = "project"`
- **THEN** the request URL is `GET /_cluster/state/metadata/project`
