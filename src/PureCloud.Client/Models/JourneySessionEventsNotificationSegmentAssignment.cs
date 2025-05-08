using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneySessionEventsNotificationSegmentAssignment
{
    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    public JourneySessionEventsNotificationSegment Segment { get; set; }

    /// <summary>
    /// Gets or Sets AssignedDate
    /// </summary>
    public DateTime? AssignedDate { get; set; }
}
