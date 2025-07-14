using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DownloadResponse
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public DownloadResponseStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ContentLocationUri
    /// </summary>
    public string ContentLocationUri { get; set; }

    /// <summary>
    /// Gets or Sets ImageUri
    /// </summary>
    public string ImageUri { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnails
    /// </summary>
    public IEnumerable<DocumentThumbnail> Thumbnails { get; set; }

    /// <summary>
    /// Gets or Sets ResultUri
    /// </summary>
    public string ResultUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}
