namespace PureCloud.Client.Models;

public sealed class EvaluationSettingsAssignee
{
    /// <summary>
    /// The assignee type. Valid values: Original, Individual, None
    /// </summary>
    /// <value>The assignee type. Valid values: Original, Individual, None</value>
    public EvaluationSettingsAssigneeType? Type { get; set; }

    /// <summary>
    /// The user the dispute should be assigned to
    /// </summary>
    /// <value>The user the dispute should be assigned to</value>
    public UserReferenceWithName User { get; set; }
}
