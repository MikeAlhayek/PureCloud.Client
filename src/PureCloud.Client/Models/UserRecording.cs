using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserRecording
/// </summary>
public sealed class UserRecording
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets ContentUri
    /// </summary>
    public string ContentUri { get; set; }

    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    public DomainEntityRef Workspace { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    public Conversation Conversation { get; set; }

    /// <summary>
    /// Gets or Sets ContentLength
    /// </summary>
    public long? ContentLength { get; set; }

    /// <summary>
    /// Gets or Sets DurationMilliseconds
    /// </summary>
    public long? DurationMilliseconds { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnails
    /// </summary>
    public IEnumerable<DocumentThumbnail> Thumbnails { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
