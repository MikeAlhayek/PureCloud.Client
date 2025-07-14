using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SharedResponse
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUri
    /// </summary>
    public string DownloadUri { get; set; }

    /// <summary>
    /// Gets or Sets ViewUri
    /// </summary>
    public string ViewUri { get; set; }

    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    public Document Document { get; set; }

    /// <summary>
    /// Gets or Sets Share
    /// </summary>
    public Share Share { get; set; }
}
