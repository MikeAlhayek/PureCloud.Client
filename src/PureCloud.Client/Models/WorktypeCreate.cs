namespace PureCloud.Client.Models;

/// <summary>
/// WorktypeCreate
/// </summary>
public sealed class WorktypeCreate
{
    /// <summary>
    /// The name of the Worktype.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The description of the Worktype.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The default duration in seconds for Workitems created from the Worktype.
    /// </summary>
    public int? DefaultDurationSeconds { get; set; }

    /// <summary>
    /// The default expiration time in seconds for Workitems created from the Worktype.
    /// </summary>
    public int? DefaultExpirationSeconds { get; set; }

    /// <summary>
    /// The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    public int? DefaultPriority { get; set; }

    /// <summary>
    /// When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.
    /// </summary>
    public bool? AssignmentEnabled { get; set; }

    /// <summary>
    /// The target service level for Workitems created from the Worktype. The default value is 100.
    /// </summary>
    public int? ServiceLevelTarget { get; set; }
}
