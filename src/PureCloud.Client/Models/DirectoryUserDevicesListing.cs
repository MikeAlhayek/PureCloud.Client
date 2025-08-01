using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DirectoryUserDevicesListing
/// </summary>
public sealed class DirectoryUserDevicesListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public IEnumerable<UserDevice> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets FirstUri
    /// </summary>
    [JsonPropertyName("firstUri")]
    public string FirstUri { get; set; }

    /// <summary>
    /// Gets or Sets LastUri
    /// </summary>
    [JsonPropertyName("lastUri")]
    public string LastUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [JsonPropertyName("nextUri")]
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    [JsonPropertyName("previousUri")]
    public string PreviousUri { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }
}

