namespace PureCloud.Client.Models;

/// <summary>
/// Document Variation Listing
/// </summary>
public sealed class DocumentVariationListing
{
    /// <summary>
    /// Entities
    /// </summary>
    public IEnumerable<KnowledgeDocumentVariation> Entities { get; set; }

    /// <summary>
    /// Next URI
    /// </summary>
    public string NextUri { get; set; }

    /// <summary>
    /// Previous URI
    /// </summary>
    public string PreviousUri { get; set; }

    /// <summary>
    /// Self URI
    /// </summary>
    public string SelfUri { get; set; }

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
    /// Total count
    /// </summary>
    public int? Total { get; set; }
}