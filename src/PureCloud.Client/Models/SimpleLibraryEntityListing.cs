using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Simplified Library Entity Listing for Response Management API
/// </summary>
public class SimpleLibraryEntityListing
{
    [JsonPropertyName("entities")]
    public List<Library> Entities { get; set; } = new();

    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }

    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }

    [JsonPropertyName("total")]
    public long? Total { get; set; }

    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }

    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }

    [JsonPropertyName("firstUri")]
    public string FirstUri { get; set; }

    [JsonPropertyName("lastUri")]
    public string LastUri { get; set; }

    [JsonPropertyName("nextUri")]
    public string NextUri { get; set; }

    [JsonPropertyName("previousUri")]
    public string PreviousUri { get; set; }
}