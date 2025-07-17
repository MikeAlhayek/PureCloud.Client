using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PunctualityEvent
{
    /// <summary>
    /// The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateScheduleStart { get; set; }

    /// <summary>
    /// The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The length of the activity in minutes
    /// </summary>
    /// <value>The length of the activity in minutes</value>
    public int? LengthMinutes { get; set; }

    /// <summary>
    /// The description of the activity
    /// </summary>
    /// <value>The description of the activity</value>
    public string Description { get; set; }

    /// <summary>
    /// The ID of the activity code associated with this activity
    /// </summary>
    /// <value>The ID of the activity code associated with this activity</value>
    public string ActivityCodeId { get; set; }

    /// <summary>
    /// The activity code
    /// </summary>
    /// <value>The activity code</value>
    public string ActivityCode { get; set; }

    /// <summary>
    /// The activity name
    /// </summary>
    /// <value>The activity name</value>
    public string ActivityName { get; set; }

    /// <summary>
    /// The category for the activity
    /// </summary>
    /// <value>The category for the activity</value>
    public string Category { get; set; }

    /// <summary>
    /// The points earned for this activity
    /// </summary>
    /// <value>The points earned for this activity</value>
    public int? Points { get; set; }

    /// <summary>
    /// Difference between this activity and the last activity in seconds
    /// </summary>
    /// <value>Difference between this activity and the last activity in seconds</value>
    public double? Delta { get; set; }

    /// <summary>
    /// Gets or Sets Bullseye
    /// </summary>
    public bool? Bullseye { get; set; }
}
