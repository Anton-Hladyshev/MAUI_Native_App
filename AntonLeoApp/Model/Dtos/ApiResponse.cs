using System.Text.Json.Serialization;

namespace AntonLeoApp.Model.Dtos;

public class ApiResponse<T>
{
    [JsonPropertyName("info")]
    public ApiInfo? Info { get; set; }

    [JsonPropertyName("data")]
    public T? Data { get; set; }
}

public class ApiInfo
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("prev")]
    public string? Prev { get; set; }
}
