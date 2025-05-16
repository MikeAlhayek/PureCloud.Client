using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsUserEventsNotificationSession
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WorkitemsUserEventsNotificationSessionTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WorkitemsUserEventsNotificationSessionStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets DateSessionStart
    /// </summary>
    public string DateSessionStart { get; set; }

    /// <summary>
    /// Gets or Sets DateSessionEnd
    /// </summary>
    public string DateSessionEnd { get; set; }

    /// <summary>
    /// Gets or Sets AssignmentSegments
    /// </summary>
    public IEnumerable<WorkitemsUserEventsNotificationAssignmentSegment> AssignmentSegments { get; set; }
}
