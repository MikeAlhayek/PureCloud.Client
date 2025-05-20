using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserNotificationTopicWfmUserNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmUserNotificationTopicWfmUserNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets MutableGroupId
    /// </summary>
    public string MutableGroupId { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets ShiftTrade
    /// </summary>
    public WfmUserNotificationTopicShiftTradeNotification ShiftTrade { get; set; }

    /// <summary>
    /// Gets or Sets TimeOffRequest
    /// </summary>
    public WfmUserNotificationTopicTimeOffRequestNotification TimeOffRequest { get; set; }

    /// <summary>
    /// Gets or Sets AdherenceExplanation
    /// </summary>
    public WfmUserNotificationTopicAdherenceExplanationNotification AdherenceExplanation { get; set; }

    /// <summary>
    /// Gets or Sets AlternativeShift
    /// </summary>
    public WfmUserNotificationTopicAlternativeShiftNotification AlternativeShift { get; set; }

    /// <summary>
    /// Gets or Sets AgentNotification
    /// </summary>
    public bool? AgentNotification { get; set; }

    /// <summary>
    /// Gets or Sets OtherNotificationIdsInGroup
    /// </summary>
    public IEnumerable<string> OtherNotificationIdsInGroup { get; set; }

    /// <summary>
    /// Gets or Sets MarkedAsRead
    /// </summary>
    public bool? MarkedAsRead { get; set; }
}
