module Fes.Tests.Snapshot

open System.IO
open Xunit

let private snapshotDir =
    Path.Combine(__SOURCE_DIRECTORY__, "snapshots")

/// Compare a JSON string against a golden file in snapshots/.
/// On first run, creates the file and fails so you can review it.
let verify (testName: string) (actual: string) =
    if not (Directory.Exists snapshotDir) then
        Directory.CreateDirectory(snapshotDir) |> ignore

    let path = Path.Combine(snapshotDir, $"{testName}.json")

    if File.Exists path then
        let expected = File.ReadAllText(path).Trim()
        Assert.Equal(expected, actual.Trim())
    else
        File.WriteAllText(path, actual)
        Assert.Fail $"Snapshot created at {path} — review and re-run"
