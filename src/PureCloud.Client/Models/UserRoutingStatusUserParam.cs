using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserRoutingStatusUserParam
{
    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
