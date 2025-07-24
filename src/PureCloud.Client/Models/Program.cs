namespace PureCloud.Client.Models;

/// <summary>
/// Program
/// </summary>
public sealed class Program
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
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    public bool? Published { get; set; }

    /// <summary>
    /// Gets or Sets Topics
    /// </summary>
    public IEnumerable<BaseTopicEntitiy> Topics { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    public IEnumerable<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public AddressableEntityRef ModifiedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets PublishedBy
    /// </summary>
    public AddressableEntityRef PublishedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DatePublished { get; set; }

    /// <summary>
    /// Gets or Sets TopicLinksJob
    /// </summary>
    public AddressableEntityRef TopicLinksJob { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}