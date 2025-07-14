using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Celebration
{
    /// <summary>
    /// The Celebration Type
    /// </summary>
    /// <value>The Celebration Type</value>
    public CelebrationTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The Recipient of the celebration
    /// </summary>
    /// <value>The Recipient of the celebration</value>
    public UserReference Recipient { get; set; }

    /// <summary>
    /// The creator of the celebration
    /// </summary>
    /// <value>The creator of the celebration</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The Celebration title
    /// </summary>
    /// <value>The Celebration title</value>
    public string Title { get; set; }

    /// <summary>
    /// The Celebration note
    /// </summary>
    /// <value>The Celebration note</value>
    public string Note { get; set; }

    /// <summary>
    /// The celebration&#39;s source entity
    /// </summary>
    /// <value>The celebration&#39;s source entity</value>
    public SourceEntity SourceEntity { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
