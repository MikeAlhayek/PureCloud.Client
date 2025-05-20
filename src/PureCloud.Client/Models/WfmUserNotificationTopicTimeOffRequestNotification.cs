using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserNotificationTopicTimeOffRequestNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmUserNotificationTopicTimeOffRequestNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets TimeOffRequestId
    /// </summary>
    public string TimeOffRequestId { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public WfmUserNotificationTopicUserReference User { get; set; }

    /// <summary>
    /// Gets or Sets IsFullDayRequest
    /// </summary>
    public bool? IsFullDayRequest { get; set; }

    /// <summary>
    /// Gets or Sets PartialDayStartDateTimes
    /// </summary>
    public IEnumerable<DateTime?> PartialDayStartDateTimes { get; set; }

    /// <summary>
    /// Gets or Sets FullDayManagementUnitDates
    /// </summary>
    public IEnumerable<string> FullDayManagementUnitDates { get; set; }
}
