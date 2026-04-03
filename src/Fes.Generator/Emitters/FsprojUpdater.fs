module Fes.Generator.Emitters.FsprojUpdater

open System.IO
open System.Text

/// Update the Fes.fsproj to include generated files in the correct order.
/// NOTE: This rewrites the entire fsproj. If custom PropertyGroup, ProjectReference,
/// or other items are added outside the known structure, they will be lost.
/// TODO: Consider updating only the generated ItemGroup region instead.
let updateFsproj (fsprojPath: string) (generatedDir: string) =
    let fsprojDir = Path.GetDirectoryName(fsprojPath)

    // Find all .g.fs files
    let generatedFiles =
        if Directory.Exists generatedDir then
            Directory.GetFiles(generatedDir, "*.g.fs", SearchOption.AllDirectories)
            |> Array.map (fun f -> Path.GetRelativePath(fsprojDir, f).Replace('\\', '/'))
            |> Array.sort
            |> Array.toList
        else
            []

    if generatedFiles.IsEmpty then
        printfn "  No generated files found, skipping fsproj update"
    else

    // Order: Core types first (_types.*), then other types, then Converters, then Builders, then Operations
    // Within types, ensure foundational namespaces come first
    let allTypeFiles = generatedFiles |> List.filter (fun f -> f.Contains("/Types/"))
    let typeFiles = allTypeFiles // Single file (AllTypes.g.fs)
    let converterFiles = generatedFiles |> List.filter (fun f -> f.EndsWith("Converters.g.fs"))
    let builderFiles = generatedFiles |> List.filter (fun f -> f.Contains("/Builders/"))
    let esModule = generatedFiles |> List.filter (fun f -> f.EndsWith("/ES.g.fs"))
    let otherOpFiles =
        generatedFiles
        |> List.filter (fun f ->
            f.Contains("/Operations/") &&
            not (f.EndsWith("/ES.g.fs")))
    let orderedFiles = typeFiles @ converterFiles @ builderFiles @ otherOpFiles @ esModule

    let sb = StringBuilder()
    sb.AppendLine("""<?xml version="1.0" encoding="utf-8"?>""") |> ignore
    sb.AppendLine("""<Project Sdk="Microsoft.NET.Sdk">""") |> ignore
    sb.AppendLine("""    <PropertyGroup>""") |> ignore
    sb.AppendLine("""        <GenerateDocumentationFile>true</GenerateDocumentationFile>""") |> ignore
    sb.AppendLine("""        <WarnOn>3390;$(WarnOn)</WarnOn>""") |> ignore
    sb.AppendLine("""        <RootNamespace>Fes</RootNamespace>""") |> ignore
    sb.AppendLine("""    </PropertyGroup>""") |> ignore
    sb.AppendLine("""    <ItemGroup>""") |> ignore
    sb.AppendLine("""        <PackageReference Include="Elastic.Transport"/>""") |> ignore
    sb.AppendLine("""        <PackageReference Include="FSharp.Core"/>""") |> ignore
    sb.AppendLine("""        <PackageReference Include="FSharp.SystemTextJson"/>""") |> ignore
    sb.AppendLine("""    </ItemGroup>""") |> ignore
    sb.AppendLine("""    <ItemGroup>""") |> ignore
    sb.AppendLine("""        <!-- Core library files (before generated code) -->""") |> ignore
    sb.AppendLine("""        <Compile Include="Prelude.fs"/>""") |> ignore
    sb.AppendLine("""        <Compile Include="Task.fs"/>""") |> ignore
    sb.AppendLine("""        <Compile Include="Result.fs"/>""") |> ignore
    sb.AppendLine("""        <Compile Include="TaskResult.fs"/>""") |> ignore
    sb.AppendLine("""        <Compile Include="Exceptions.fs"/>""") |> ignore
    sb.AppendLine("""        <!-- Generated types -->""") |> ignore
    for f in typeFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("""        <!-- Generated converters -->""") |> ignore
    for f in converterFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("""        <!-- Core library files (after types/converters) -->""") |> ignore
    sb.AppendLine("""        <Compile Include="Json.fs"/>""") |> ignore
    sb.AppendLine("""        <Compile Include="Http.fs"/>""") |> ignore
    sb.AppendLine("""        <Compile Include="Transport.fs"/>""") |> ignore
    sb.AppendLine("""        <!-- Generated builders -->""") |> ignore
    for f in builderFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("""        <!-- Generated operations -->""") |> ignore
    for f in otherOpFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    for f in esModule do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("""    </ItemGroup>""") |> ignore
    sb.AppendLine("""</Project>""") |> ignore

    File.WriteAllText(fsprojPath, sb.ToString())
    printfn $"  Updated {fsprojPath} with {orderedFiles.Length} generated files"
