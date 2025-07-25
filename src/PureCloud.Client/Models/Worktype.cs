namespace PureCloud.Client.Models;

/// <summary>
/// Worktype
/// </summary>
public sealed class Worktype
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; init; }

    /// <summary>
    /// The name of the Worktype.
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// The description of the Worktype.
    /// </summary>
    public string Description { get; init; }

    /// <summary>
    /// The creation date of the Worktype. Date time is represented as an ISO-8601 string.
    /// </summary>
    public DateTime? DateCreated { get; init; }

    /// <summary>
    /// The modified date of the Worktype. Date time is represented as an ISO-8601 string.
    /// </summary>
    public DateTime? DateModified { get; init; }

    /// <summary>
    /// The default duration in seconds for Workitems created from the Worktype.
    /// </summary>
    public int? DefaultDurationSeconds { get; init; }

    /// <summary>
    /// The default expiration time in seconds for Workitems created from the Worktype.
    /// </summary>
    public int? DefaultExpirationSeconds { get; init; }

    /// <summary>
    /// The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    public int? DefaultPriority { get; init; }

    /// <summary>
    /// When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.
    /// </summary>
    public bool? AssignmentEnabled { get; init; }

    /// <summary>
    /// The target service level for Workitems created from the Worktype. The default value is 100.
    /// </summary>
    public int? ServiceLevelTarget { get; init; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; init; }
}
