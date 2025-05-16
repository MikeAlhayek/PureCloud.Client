using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsQueueEventsNotificationAssignmentSegment
{
    /// <summary>
    /// Gets or Sets StartState
    /// </summary>
    public WorkitemsQueueEventsNotificationAssignmentSegmentStartStateEnum? StartState { get; set; }

    /// <summary>
    /// Gets or Sets EndState
    /// </summary>
    public WorkitemsQueueEventsNotificationAssignmentSegmentEndStateEnum? EndState { get; set; }


    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }
}
