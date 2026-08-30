[![](https://img.shields.io/nuget/v/soenneker.requests.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.requests.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entities.named/actions/workflows/codeql.yml)

# Soenneker.Requests.Entities.Named

A reusable create-or-update request containing an optional entity ID and a required display name.

## Installation

```bash
dotnet add package Soenneker.Requests.Entities.Named
```

## Usage

Use `NamedEntityRequest` directly when an endpoint only needs an ID and name:

```csharp
using Soenneker.Requests.Entities.Named;

var create = new NamedEntityRequest
{
    Name = "Production"
};

var update = new NamedEntityRequest
{
    Id = "75f11404-9c6f-4b33-b16c-d3ffea59f8f4",
    Name = "Production US"
};
```

It can also be used as the base for a more specific API contract:

```csharp
public record SaveEnvironmentRequest : NamedEntityRequest
{
    public string? Region { get; init; }
}
```

The JSON properties are `id` and `name`. `Id` is optional and, when present, must be a GUID. `Name` is required and length-limited by the shared Soenneker data constant. Run the request through ASP.NET Core model validation or another data-annotation validator; constructing or deserializing the record does not validate it automatically.
