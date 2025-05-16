using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeLogicalInterfacesChangeTopicErrorInfo
{
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets MessageWithParams
    /// </summary>
    public string MessageWithParams { get; set; }

    /// <summary>
    /// Gets or Sets MessageParams
    /// </summary>
    public Dictionary<string, string> MessageParams { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }
}
