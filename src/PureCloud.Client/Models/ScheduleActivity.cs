using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ScheduleActivity
{
    /// <summary>
    /// The type of the external activity associated with this activity, if applicable
    /// </summary>
    /// <value>The type of the external activity associated with this activity, if applicable</value>
    public ScheduleActivityExternalActivityTypeEnum? ExternalActivityType { get; set; }

    /// <summary>
    /// The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The length of this activity in minutes
    /// </summary>
    /// <value>The length of this activity in minutes</value>
    public int? LengthMinutes { get; set; }

    /// <summary>
    /// The description of this activity
    /// </summary>
    /// <value>The description of this activity</value>
    public string Description { get; set; }

    /// <summary>
    /// The ID of the activity code associated with this activity
    /// </summary>
    /// <value>The ID of the activity code associated with this activity</value>
    public string ActivityCodeId { get; set; }

    /// <summary>
    /// Whether this activity is paid
    /// </summary>
    /// <value>Whether this activity is paid</value>
    public bool? Paid { get; set; }

    /// <summary>
    /// The ID of the time off request associated with this activity, if applicable
    /// </summary>
    /// <value>The ID of the time off request associated with this activity, if applicable</value>
    public string TimeOffRequestId { get; set; }

    /// <summary>
    /// The ID of the external activity associated with this activity, if applicable
    /// </summary>
    /// <value>The ID of the external activity associated with this activity, if applicable</value>
    public string ExternalActivityId { get; set; }
}
