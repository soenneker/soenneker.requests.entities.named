using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Constants.Data;
using Soenneker.Requests.Entity;

namespace Soenneker.Requests.Entities.Named;

/// <summary>
/// A request model that includes a required, length-limited Name property for named entities.
/// </summary>
[PublicOpenApiObject]
public record NamedEntityRequest : EntityRequest
{
    /// <summary>
    /// The display name for the entity.
    /// </summary>
    [Required, StringLength(DataConstants.Name)]
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}
