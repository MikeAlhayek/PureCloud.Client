using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowHealthErrorInfo
{
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Error message with params included.
    /// </summary>
    /// <value>Error message with params included.</value>
    public string MessageWithParams { get; set; }

    /// <summary>
    /// Map of variables and params for the error message.
    /// </summary>
    /// <value>Map of variables and params for the error message.</value>
    public Dictionary<string, object> MessageParams { get; set; }
}
