using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntegrationsHrisTimeOffTypesJobTopicErrorBody
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public long? Status { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets MessageParams
    public Dictionary<string, string> MessageParams { get; set; }
}
