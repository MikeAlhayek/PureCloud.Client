namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemUpdate
/// </summary>
public sealed class WorkitemUpdate
{
    /// <summary>
    /// The name of the Workitem. Valid length between 3 and 256 characters.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// The description of the Workitem. Maximum length of 512 characters.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The ID of the Status of the Workitem.
    /// </summary>
    public string StatusId { get; set; }

    /// <summary>
    /// The due date of the Workitem. Date time is represented as an ISO-8601 string.
    /// </summary>
    public DateTime? DateDue { get; set; }

    /// <summary>
    /// The expiry date of the Workitem. Date time is represented as an ISO-8601 string.
    /// </summary>
    public DateTime? DateExpires { get; set; }

    /// <summary>
    /// The estimated duration in seconds to complete the Workitem.
    /// </summary>
    public int? DurationSeconds { get; set; }

    /// <summary>
    /// The assignment state of the Workitem.
    /// </summary>
    public WorkitemAssignmentState? AssignmentState { get; set; }
}
