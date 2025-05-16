using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsQueueEventsNotificationSession
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WorkitemsQueueEventsNotificationSessionTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WorkitemsQueueEventsNotificationSessionStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets DateSessionStart
    public string DateSessionStart { get; set; }

    /// <summary>
    /// Gets or Sets DateSessionEnd
    /// </summary>
    public string DateSessionEnd { get; set; }

    /// <summary>
    /// Gets or Sets AssignmentSegments
    /// </summary>
    public IEnumerable<WorkitemsQueueEventsNotificationAssignmentSegment> AssignmentSegments { get; set; }
}
