namespace PureCloud.Client.Models.Users;

public sealed class UserStation
{
    /// <summary>
    /// A globally unique identifier for this station
    /// </summary>
    /// <value>A globally unique identifier for this station</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets AssociatedUser
    /// </summary>
    public User AssociatedUser { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? AssociatedDate { get; set; }

    /// <summary>
    /// Gets or Sets DefaultUser
    /// </summary>
    public User DefaultUser { get; set; }

    /// <summary>
    /// Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }
    /// </summary>
    /// <value>Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }</value>
    public Dictionary<string, string> ProviderInfo { get; set; }

    /// <summary>
    /// The number of call appearances on the station.
    /// </summary>
    /// <value>The number of call appearances on the station.</value>
    public int? WebRtcCallAppearances { get; set; }
}
