using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebEventsNotificationSegmentAssignmentMessage
{
    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    public JourneyWebEventsNotificationSegment Segment { get; set; }
}
