using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CopilotCondition
{
    /// <summary>
    /// Type of condition.
    /// </summary>
    /// <value>Type of condition.</value>
    public CopilotConditionConditionTypeEnum? ConditionType { get; set; }

    /// <summary>
    /// Condition values.
    /// </summary>
    /// <value>Condition values.</value>
    public IEnumerable<string> ConditionValues { get; set; }
}
