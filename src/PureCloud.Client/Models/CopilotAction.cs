using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CopilotAction
{
    /// <summary>
    /// Type of action.
    /// </summary>
    /// <value>Type of action.</value>
    public CopilotActionActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// Action specific attributes, if any. Maximum 100 of string key-value pair allowed.
    /// </summary>
    /// <value>Action specific attributes, if any. Maximum 100 of string key-value pair allowed.</value>
    public Dictionary<string, string> Attributes { get; set; }
}
