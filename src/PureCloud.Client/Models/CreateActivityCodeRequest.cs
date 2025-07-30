namespace PureCloud.Client.Models;

/// <summary>
/// CreateActivityCodeRequest
/// </summary>
public sealed class CreateActivityCodeRequest
{
    /// <summary>
    /// The activity code's category
    /// </summary>
    /// <value>The activity code's category</value>
    public CreateActivityCodeRequestCategoryEnum? Category { get; set; }

    /// <summary>
    /// The name of the activity code
    /// </summary>
    /// <value>The name of the activity code</value>
    public string Name { get; set; }

    /// <summary>
    /// The default length of the activity in minutes
    /// </summary>
    /// <value>The default length of the activity in minutes</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// Whether an agent is paid while performing this activity
    /// </summary>
    /// <value>Whether an agent is paid while performing this activity</value>
    public bool? CountsAsPaidTime { get; set; }

    /// <summary>
    /// Indicates whether or not the activity should be counted as work time
    /// </summary>
    /// <value>Indicates whether or not the activity should be counted as work time</value>
    public bool? CountsAsWorkTime { get; set; }

    /// <summary>
    /// Whether an agent can select this activity code when creating or editing a time off request
    /// </summary>
    /// <value>Whether an agent can select this activity code when creating or editing a time off request</value>
    public bool? AgentTimeOffSelectable { get; set; }

    /// <summary>
    /// Whether or not this activity code counts toward shrinkage calculations
    /// </summary>
    /// <value>Whether or not this activity code counts toward shrinkage calculations</value>
    public bool? CountsTowardShrinkage { get; set; }

    /// <summary>
    /// Whether this activity code is considered planned shrinkage
    /// </summary>
    /// <value>Whether this activity code is considered planned shrinkage</value>
    public bool? PlannedShrinkage { get; set; }

    /// <summary>
    /// Whether this activity code is considered interruptible
    /// </summary>
    /// <value>Whether this activity code is considered interruptible</value>
    public bool? Interruptible { get; set; }

    /// <summary>
    /// List of secondary presences allowed to be set for this activity code
    /// </summary>
    /// <value>List of secondary presences allowed to be set for this activity code</value>
    public IEnumerable<SecondaryPresence> SecondaryPresences { get; set; }
}