namespace PureCloud.Client.Models;

/// <summary>
/// SipDownloadResponse
/// </summary>
public sealed class SipDownloadResponse
{
    /// <summary>
    /// Unique id of the downloaded file.
    /// </summary>
    public string DownloadId { get; set; }

    /// <summary>
    /// Document id of pcap file.
    /// </summary>
    public string DocumentId { get; set; }
}
