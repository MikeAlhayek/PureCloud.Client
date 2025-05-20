using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactlistDownloadReadyExportUri
{
    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    public string Uri { get; set; }

    /// <summary>
    /// Gets or Sets ExportTimestamp
    /// </summary>
    public string ExportTimestamp { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
