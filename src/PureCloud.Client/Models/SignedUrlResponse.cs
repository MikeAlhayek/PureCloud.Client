namespace PureCloud.Client.Models;

/// <summary>
/// SignedUrlResponse
/// </summary>
public sealed class SignedUrlResponse
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
    /// Url of the downloaded pcap file.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The URI for this object.
    /// </summary>
    public string SelfUri { get; set; }
}
