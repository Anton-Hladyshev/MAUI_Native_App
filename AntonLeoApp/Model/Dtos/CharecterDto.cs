using System.Text.Json.Serialization;

namespace AntonLeoApp.Model.Dtos;

public class CharacterDto
{
    [JsonPropertyName("_id")]
    public string id { get; set; }
    [JsonPropertyName("name")]
    public string name { get; set; }
    [JsonPropertyName("description")]
    public string description { get; set; }
    [JsonPropertyName("image")]
    public string image { get; set; }
}