// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module EsqlTypesBuilders =

    type EsqlClusterDetailsBuilder() =
        member _.Yield(_: unit) : EsqlClusterDetails =
            {
                Status = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                Took = None
                Shards = None
                Failures = None
            }

        [<CustomOperation("status")>]
        member _.Status(state: EsqlClusterDetails, value: EsqlTypes.EsqlClusterStatus) =
            { state with Status = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: EsqlClusterDetails, value: string) =
            { state with Indices = value }

        [<CustomOperation("took")>]
        member _.Took(state: EsqlClusterDetails, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: EsqlClusterDetails, value: EsqlTypes.EsqlShardInfo) =
            { state with Shards = Some value }

        [<CustomOperation("failures")>]
        member _.Failures(state: EsqlClusterDetails, value: EsqlTypes.EsqlShardFailure list) =
            { state with Failures = Some value }

    let esqlClusterDetails = EsqlClusterDetailsBuilder()

    type EsqlResultBuilder() =
        member _.Yield(_: unit) : EsqlResult =
            {
                Took = None
                IsPartial = None
                AllColumns = None
                Columns = Unchecked.defaultof<_>
                Values = Unchecked.defaultof<_>
                Clusters = None
                Profile = None
            }

        [<CustomOperation("took")>]
        member _.Took(state: EsqlResult, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: EsqlResult, value: bool) =
            { state with IsPartial = Some value }

        [<CustomOperation("allColumns")>]
        member _.AllColumns(state: EsqlResult, value: EsqlTypes.EsqlColumnInfo list) =
            { state with AllColumns = Some value }

        [<CustomOperation("columns")>]
        member _.Columns(state: EsqlResult, value: EsqlTypes.EsqlColumnInfo list) =
            { state with Columns = value }

        [<CustomOperation("values")>]
        member _.Values(state: EsqlResult, value: Types.FieldValue list list) =
            { state with Values = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: EsqlResult, value: EsqlTypes.EsqlClusterInfo) =
            { state with Clusters = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlResult, value: System.Text.Json.JsonElement) =
            { state with Profile = Some value }

    let esqlResult = EsqlResultBuilder()

    type EsqlShardInfoBuilder() =
        member _.Yield(_: unit) : EsqlShardInfo =
            {
                Total = Unchecked.defaultof<_>
                Successful = None
                Skipped = None
                Failed = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: EsqlShardInfo, value: Types.Integer) =
            { state with Total = value }

        [<CustomOperation("successful")>]
        member _.Successful(state: EsqlShardInfo, value: Types.Integer) =
            { state with Successful = Some value }

        [<CustomOperation("skipped")>]
        member _.Skipped(state: EsqlShardInfo, value: Types.Integer) =
            { state with Skipped = Some value }

        [<CustomOperation("failed")>]
        member _.Failed(state: EsqlShardInfo, value: Types.Integer) =
            { state with Failed = Some value }

    let esqlShardInfo = EsqlShardInfoBuilder()

    module TableValues =

        let integer (value: EsqlTypes.TableValuesIntegerValue list) =
            TableValuesContainer.Integer value

        let keyword (value: EsqlTypes.TableValuesKeywordValue list) =
            TableValuesContainer.Keyword value

        let long (value: EsqlTypes.TableValuesLongValue list) =
            TableValuesContainer.Long value

        let double (value: EsqlTypes.TableValuesLongDouble list) =
            TableValuesContainer.Double value

