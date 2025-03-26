using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Soenneker.Constants.Data;
using Soenneker.Requests.Entity;

namespace Soenneker.Requests.Entities.Named;

/// <summary>
/// A request model that includes a required, length-limited Name property for named entities.
/// </summary>
public record NamedEntityRequest : EntityRequest
{
    [Required, StringLength(DataConstants.Name)]
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}