namespace PureCloud.Client.Models;

/// <summary>
/// Script
/// </summary>

public sealed class Script
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public Division Division { get; set; }

    /// <summary>
    /// Gets or Sets VersionId
    /// </summary>
    public string VersionId { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? VersionDate { get; set; }

    /// <summary>
    /// Gets or Sets StartPageId
    /// </summary>
    public string StartPageId { get; set; }

    /// <summary>
    /// Gets or Sets StartPageName
    /// </summary>
    public string StartPageName { get; set; }

    /// <summary>
    /// Gets or Sets Features
    /// </summary>
    public object Features { get; set; }

    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    public object Variables { get; set; }

    /// <summary>
    /// Gets or Sets CustomActions
    /// </summary>
    public object CustomActions { get; set; }

    /// <summary>
    /// Gets or Sets Pages
    /// </summary>
    public IEnumerable<Page> Pages { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; private set; }
}
