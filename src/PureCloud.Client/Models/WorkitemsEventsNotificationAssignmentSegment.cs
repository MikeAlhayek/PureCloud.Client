using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsEventsNotificationAssignmentSegment
{
    /// <summary>
    /// Gets or Sets StartState
    /// </summary>
    public WorkitemsEventsNotificationAssignmentSegmentStartStateEnum? StartState { get; set; }

    /// <summary>
    /// Gets or Sets EndState
    /// </summary>
    public WorkitemsEventsNotificationAssignmentSegmentEndStateEnum? EndState { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }
}
