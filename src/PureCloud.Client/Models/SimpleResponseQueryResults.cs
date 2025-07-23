using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Simplified Response Query Results for Response Management API
/// </summary>
public class SimpleResponseQueryResults
{
    [JsonPropertyName("results")]
    public List<Response> Results { get; set; } = new();

    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }

    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }

    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }

    [JsonPropertyName("previousPage")]
    public string PreviousPage { get; set; }

    [JsonPropertyName("currentPage")]
    public string CurrentPage { get; set; }

    [JsonPropertyName("nextPage")]
    public string NextPage { get; set; }

    [JsonPropertyName("types")]
    public List<string> Types { get; set; } = new();

    [JsonPropertyName("aggregations")]
    public List<object> Aggregations { get; set; } = new();
}