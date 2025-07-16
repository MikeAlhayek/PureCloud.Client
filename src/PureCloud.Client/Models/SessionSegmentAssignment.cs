using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SessionSegmentAssignment
{
    /// <summary>
    /// The segment that was assigned.
    /// </summary>
    /// <value>The segment that was assigned.</value>
    public AssignedSegment Segment { get; set; }

    /// <summary>
    /// Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? AssignedDate { get; set; }
}
