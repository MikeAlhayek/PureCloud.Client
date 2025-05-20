using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserNotificationTopicAlternativeShiftNotification
{
    /// <summary>
    /// Gets or Sets Granularity
    /// </summary>
    public WfmUserNotificationTopicAlternativeShiftNotificationGranularityEnum? Granularity { get; set; }

    /// <summary>
    /// Gets or Sets NewState
    /// </summary>
    public WfmUserNotificationTopicAlternativeShiftNotificationNewStateEnum? NewState { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public DateTime? WeekDate { get; set; }

    /// <summary>
    /// Gets or Sets InitiatingUser
    /// </summary>
    public WfmUserNotificationTopicUserReference InitiatingUser { get; set; }

    /// <summary>
    /// Gets or Sets InitiatingShiftDate
    /// </summary>
    public DateTime? InitiatingShiftDate { get; set; }

    /// <summary>
    /// Gets or Sets ReceivingUser
    /// </summary>
    public WfmUserNotificationTopicUserReference ReceivingUser { get; set; }

    /// <summary>
    /// Gets or Sets ReceivingShiftDate
    /// </summary>
    public DateTime? ReceivingShiftDate { get; set; }
}
