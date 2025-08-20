namespace PureCloud.Client.Models;

/// <summary>
/// Knowledge Document Variation
/// </summary>
public sealed class KnowledgeDocumentVariation
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    public string DocumentId { get; set; }

    /// <summary>
    /// Document version
    /// </summary>
    public int? DocumentVersion { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Body content
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}