namespace PureCloud.Client.Models;

public sealed class Channel
{
    /// <summary>
    /// Gets or Sets ConnectUri
    /// </summary>
    public string ConnectUri { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Expires { get; set; }
}
