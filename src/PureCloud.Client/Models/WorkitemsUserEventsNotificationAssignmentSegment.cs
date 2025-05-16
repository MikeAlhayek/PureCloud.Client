using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsUserEventsNotificationAssignmentSegment
{
    /// <summary>
    /// Gets or Sets StartState
    /// </summary>
    public WorkitemsUserEventsNotificationAssignmentSegmentStartStateEnum? StartState { get; set; }

    /// <summary>
    /// Gets or Sets EndState
    /// </summary>
    public WorkitemsUserEventsNotificationAssignmentSegmentEndStateEnum? EndState { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }
}
