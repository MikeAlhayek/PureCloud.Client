namespace PureCloud.Client.Models;

/// <summary>
/// ActivityCode
/// </summary>
public sealed class ActivityCode
{
    /// <summary>
    /// The activity code's category.
    /// </summary>
    /// <value>The activity code's category.</value>
    public ActivityCodeCategory? Category { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The name of the activity code. Default activity codes will be created with an empty name
    /// </summary>
    /// <value>The name of the activity code. Default activity codes will be created with an empty name</value>
    public string Name { get; set; }

    /// <summary>
    /// Whether this activity code is active or has been deleted
    /// </summary>
    /// <value>Whether this activity code is active or has been deleted</value>
    public bool? IsActive { get; set; }

    /// <summary>
    /// Whether this is a default activity code
    /// </summary>
    /// <value>Whether this is a default activity code</value>
    public bool? IsDefault { get; set; }

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
    /// Version metadata for the associated management unit's list of activity codes
    /// </summary>
    /// <value>Version metadata for the associated management unit's list of activity codes</value>
    public WfmVersionedEntityMetadata Metadata { get; set; }
}