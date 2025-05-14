using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationSegmentAssignmentMessage
{
    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    public JourneyAppEventsNotificationSegment Segment { get; set; }
}
