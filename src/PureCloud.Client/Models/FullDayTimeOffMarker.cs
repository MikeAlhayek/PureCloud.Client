using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FullDayTimeOffMarker
{
    /// <summary>
    /// The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string BusinessUnitDate { get; set; }

    /// <summary>
    /// The length of the time off marker in minutes
    /// </summary>
    /// <value>The length of the time off marker in minutes</value>
    public int? LengthMinutes { get; set; }

    /// <summary>
    /// The description of the time off marker
    /// </summary>
    /// <value>The description of the time off marker</value>
    public string Description { get; set; }

    /// <summary>
    /// The ID of the activity code associated with the time off marker
    /// </summary>
    /// <value>The ID of the activity code associated with the time off marker</value>
    public string ActivityCodeId { get; set; }

    /// <summary>
    /// Whether the time off marker is paid
    /// </summary>
    /// <value>Whether the time off marker is paid</value>
    public bool? Paid { get; set; }

    /// <summary>
    /// The ID of the time off request
    /// </summary>
    /// <value>The ID of the time off request</value>
    public string TimeOffRequestId { get; set; }
}
