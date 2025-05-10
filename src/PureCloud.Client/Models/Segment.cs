namespace PureCloud.Client.Models;

public sealed class Segment
{
    /// <summary>
    /// The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The activity taking place for the participant in the segment.
    /// </summary>
    /// <value>The activity taking place for the participant in the segment.</value>
    public string Type { get; set; }

    /// <summary>
    /// A description of the event that ended the segment.
    /// </summary>
    /// <value>A description of the event that ended the segment.</value>
    public string HowEnded { get; set; }

    /// <summary>
    /// A description of the event that disconnected the segment
    /// </summary>
    /// <value>A description of the event that disconnected the segment</value>
    public string DisconnectType { get; set; }
}
