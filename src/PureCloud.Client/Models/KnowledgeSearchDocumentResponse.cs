namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSearchDocumentResponse
/// </summary>
public sealed class KnowledgeSearchDocumentResponse
{
    /// <summary>
    /// KnowledgeSearchDocumentResponse
    /// </summary>
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSearchDocumentResponse" /> class.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Document title, having a limit of 500 words.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Indicates if the knowledge document should be included in search results.
    /// </summary>
    public bool? Visible { get; set; }

    /// <summary>
    /// List of alternate phrases related to the title which improves search results.
    /// </summary>
    public IEnumerable<KnowledgeDocumentAlternative> Alternatives { get; set; }

    /// <summary>
    /// Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateImported { get; set; }

    /// <summary>
    /// The last published version number of the document.
    /// </summary>
    public int? LastPublishedVersionNumber { get; set; }

    /// <summary>
    /// The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DatePublished { get; set; }

    /// <summary>
    /// The user who created the document.
    /// </summary>
    public UserReference? CreatedBy { get; set; }

    /// <summary>
    /// The user who modified the document.
    /// </summary>
    public UserReference? ModifiedBy { get; set; }

    /// <summary>
    /// The version of the document.
    /// </summary>
    public AddressableEntityRef? DocumentVersion { get; set; }

    /// <summary>
    /// The reference to category associated with the document.
    /// </summary>
    public CategoryResponse? Category { get; set; }

    /// <summary>
    /// The references to labels associated with the document.
    /// </summary>
    public IEnumerable<LabelResponse> Labels { get; set; }

    /// <summary>
    /// Knowledge base to which the document belongs to.
    /// </summary>
    public KnowledgeBaseReference? KnowledgeBase { get; set; }

    /// <summary>
    /// The reference to external id associated with the document.
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// The URL to external document.
    /// </summary>
    public string? ExternalUrl { get; set; }

    /// <summary>
    /// The reference to source associated with the document.
    /// </summary>
    public AddressableEntityRef? Source { get; set; }

    /// <summary>
    /// Whether the document is read-only.
    /// </summary>
    public bool? Readonly { get; set; }

    /// <summary>
    /// Variations of the document.
    /// </summary>
    public IEnumerable<DocumentVariationAnswer> Variations { get; set; }

    /// <summary>
    /// The answer to the query.
    /// </summary>
    public string? Answer { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string? SelfUri { get; set; }
}
