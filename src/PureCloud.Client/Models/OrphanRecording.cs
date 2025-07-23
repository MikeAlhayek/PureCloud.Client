namespace PureCloud.Client.Models;

/// <summary>
/// OrphanRecording
/// </summary>
public sealed class OrphanRecording
{
    /// <summary>
    /// Gets or Sets ProviderType
    /// </summary>
    public OrphanRecordingProviderType? ProviderType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public OrphanRecordingMediaType? MediaType { get; set; }

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
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? RecoveredTime { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ProviderEndTime { get; set; }

    /// <summary>
    /// Gets or Sets Recording
    /// </summary>
    public Recording Recording { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}