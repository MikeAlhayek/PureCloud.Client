using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerRulesetConfigChangeAction
{
    /// <summary>
    /// Type of the action
    /// </summary>
    /// <value>Type of the action</value>
    public string Type { get; set; }

    /// <summary>
    /// Identifier of the action
    /// </summary>
    public string ActionTypeName { get; set; }

    /// <summary>
    /// Indicator of the type of update action (applicable only to certain types of actions)
    /// </summary>
    /// <value>Indicator of the type of update action (applicable only to certain types of actions)</value>
    public string UpdateOption { get; set; }

    /// <summary>
    /// Map of key-value pairs pertinent to the action (different actions require different properties)
    /// </summary>
    /// <value>Map of key-value pairs pertinent to the action (different actions require different properties)</value>
    public Dictionary<string, string> Properties { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
