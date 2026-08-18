using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Constants.Data;
using Soenneker.Requests.Entity;

namespace Soenneker.Requests.Entities.Named;

/// <summary>
/// Defines the identifier and required human-readable name shared by create-or-update requests for named resources.
/// </summary>
[PublicOpenApiObject]
public record NamedEntityRequest : EntityRequest
{
    /// <summary>
    /// Human-readable display name for the resource, subject to the API's maximum name length.
    /// </summary>
    [Required, StringLength(DataConstants.Name)]
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}
