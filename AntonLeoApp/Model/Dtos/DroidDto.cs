using System.Text.Json.Serialization;


namespace AntonLeoApp.Model.Dtos;

public abstract class DroidDto : IDto
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("image")]
    public string? Image { get; set; }
}