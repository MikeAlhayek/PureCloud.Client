using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CopilotRule
{
    /// <summary>
    /// List of conditions to execute actions, must have at least 1 element and maximum 100 elements. Operator in case of multiple conditions: &#39;OR&#39;.
    /// </summary>
    /// <value>List of conditions to execute actions, must have at least 1 element and maximum 100 elements. Operator in case of multiple conditions: &#39;OR&#39;.</value>
    public IEnumerable<CopilotCondition> Conditions { get; set; }

    /// <summary>
    /// List of actions to execute, must have at least 1 element and maximum 100 elements.
    /// </summary>
    /// <value>List of actions to execute, must have at least 1 element and maximum 100 elements.</value>
    public IEnumerable<CopilotAction> Actions { get; set; }
}
