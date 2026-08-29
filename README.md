[![](https://img.shields.io/nuget/v/soenneker.requests.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.requests.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entities.named/actions/workflows/codeql.yml)

# Soenneker.Requests.Entities.Named

Defines the identifier and required human-readable name shared by create-or-update requests for named resources.

## Install

```bash
dotnet add package Soenneker.Requests.Entities.Named
```

## What you get

- `NamedEntityRequest` — Defines the identifier and required human-readable name shared by create-or-update requests for named resources.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `NamedEntityRequest.Name` | Human-readable display name for the resource, subject to the API's maximum name length. | Human-readable display name for the resource, subject to the API's maximum name length. |
