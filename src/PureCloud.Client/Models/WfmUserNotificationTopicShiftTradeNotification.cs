using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserNotificationTopicShiftTradeNotification
{
    /// <summary>
    /// Gets or Sets NewState
    /// </summary>
    public WfmUserNotificationTopicShiftTradeNotificationNewStateEnum? NewState { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public string WeekDate { get; set; }

    /// <summary>
    /// Gets or Sets TradeId
    /// </summary>
    public string TradeId { get; set; }

    /// <summary>
    /// Gets or Sets OneSided
    /// </summary>
    public bool? OneSided { get; set; }

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
