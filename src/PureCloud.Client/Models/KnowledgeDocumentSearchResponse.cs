namespace PureCloud.Client.Models;

/// <summary>
/// Knowledge Document Search Response
/// </summary>
public sealed class KnowledgeDocumentSearchResponse
{
    /// <summary>
    /// Search query
    /// </summary>
    public string Query { get; set; }

    /// <summary>
    /// Page count
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// Page size
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Page number
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Results
    /// </summary>
    public IEnumerable<KnowledgeDocumentSearchResult> Results { get; set; }

    /// <summary>
    /// Total count
    /// </summary>
    public int? Total { get; set; }

    /// <summary>
    /// Session ID for guest users
    /// </summary>
    public string SessionId { get; set; }
}