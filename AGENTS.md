# AGENTS.md — Contributor & AI-Agent Guide

This file captures project conventions, build commands, and contribution guidelines for human contributors and automated AI agents (e.g., GitHub Copilot, Repo Assist).

---

## Project Overview

**FEs** is an F# client library for Elasticsearch. It generates a typed DSL from the Elasticsearch OpenAPI spec and provides a thin HTTP layer that works with any `HttpClient`.

Key design goals:
- **Minimal dependencies** — only `FSharp.Core` and `FSharp.SystemTextJson` at runtime.
- **Task-based async** — uses `Task<Result<'a, exn>>` (aliased as `TaskResult<'a, 'e>`) throughout; no `Async<_>` or `AsyncResult`.
- **No breaking changes** without a tracked issue and maintainer approval.
- **Auto-generated DSL** — do not edit `*.g.fs` files by hand; regenerate them from the script.

---

## Project Structure

```
src/
  Fes/
    Prelude.fs          # Utility helpers (konst, teeOk, teeError)
    Task.fs             # TaskHelpers module (map, bind, etc.)
    Result.fs           # Result helpers
    TaskResult.fs       # TaskResult<'a,'e> = Task<Result<'a,'e>>
    Exceptions.fs       # ElasticsearchException + JSON converters
    Json.fs             # JsonSettings, Json.serialize/deserialize, JsonRes.ofString
    Http.fs             # Http.Request / Http.Response / ElasticsearchClient
    DSL/
      Models/
        Types.g.fs      # Auto-generated types from OpenAPI spec
      Operations/
        *.Operations.g.fs  # Auto-generated per-namespace operation builders
tests/
  Fes.Tests/
    AssertRequestCommands.fs     # Helpers for asserting HTTP request shape
    Commands/                    # One file per operation namespace
    Responses/
      ErrorDeserialization.fs    # Error JSON parsing tests
    JsonDeserializationTests.fs  # Enum / record round-trip tests
scripts/
  esapi.2025-01.yaml    # Elasticsearch OpenAPI spec (source of truth for DSL)
  generate-dsl.fsx      # F# script that regenerates DSL/Models and DSL/Operations
```

---

## Build & Test

> **Target framework**: `net10.0`

### Restore packages

```bash
dotnet restore
```

### Build

```bash
dotnet build
```

### Run tests

```bash
dotnet test
```

Integration tests that call a live Elasticsearch instance are skipped unless `ES_URL` is set:

```bash
ES_URL=http://localhost:9200 dotnet test
```

A local Elasticsearch instance can be started with:

```bash
docker compose up -d
```

---

## Regenerating the DSL

The DSL is auto-generated from `scripts/esapi.2025-01.yaml` using `scripts/generate-dsl.fsx`. After updating the spec or the script, regenerate with:

```bash
dotnet fsi scripts/generate-dsl.fsx
```

**Never edit `*.g.fs` files manually.** All customisation belongs in `Exceptions.fs`, `Json.fs`, or `Http.fs`.

---

## Coding Conventions

### F# style
- Use `[<RequireQualifiedAccess>]` on modules to avoid name collisions.
- Prefer `inline` for generic helpers that rely on SRTP or benefit from specialisation.
- Avoid `mutable` except in JSON converters where the `byref` pattern is required.
- Match the `snake_case_lower` JSON property naming used throughout (`JsonNamingPolicy.SnakeCaseLower`).

### Error handling
- All errors flow as `Result<_, exn>` or `TaskResult<_, exn>`.
- Never `raise`; surface exceptions as `Error e`.
- Use `TaskResult.ofTask` to wrap `Task<'a>` and catch exceptions.

### Adding a new operation
1. Add the shape to `scripts/esapi.2025-01.yaml` (or wait for a spec update).
2. Regenerate the DSL.
3. Wire any new converters in `JsonSettings.options` in `Json.fs`.
4. Add a test in `tests/Fes.Tests/Commands/` following the existing pattern.

### Commit messages
Use [Conventional Commits](https://www.conventionalcommits.org/):

```
feat: add BulkRequest builder
fix: correct query-string encoding for boolean params
docs: update README with Task-based examples
test: add cluster health command tests
chore: regenerate DSL from esapi.2025-01.yaml
```

---

## Pull Request Checklist

- [ ] `dotnet build` passes with no errors or warnings.
- [ ] `dotnet test` passes.
- [ ] No new runtime dependencies introduced without maintainer discussion.
- [ ] `*.g.fs` files regenerated if the OpenAPI spec changed.
- [ ] Tests added for any new public API or bug fix.
- [ ] Commit message follows Conventional Commits.

---

## AI Agent Notes

- **Read this file first** before making any changes.
- **Do not modify `*.g.fs` files** — they are regenerated automatically.
- **Build and test before opening a PR.** If the build fails due to infrastructure (OOM, missing network), document it in the PR's Test Status section.
- **One concern per PR.** Do not bundle unrelated changes.
- **Identify yourself** in all PR descriptions and issue comments (e.g., `🤖 This is an automated PR from Repo Assist`).
