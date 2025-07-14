using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DocumentThumbnail
{
    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>
    public string Resolution { get; set; }
    /// <summary>
    /// Gets or Sets ImageUri
    /// </summary>
    public string ImageUri { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Gets or Sets Width
    /// </summary>
    public int? Width { get; set; }
}
