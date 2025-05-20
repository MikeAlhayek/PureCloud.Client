using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserNotificationTopicAdherenceExplanationNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmUserNotificationTopicAdherenceExplanationNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmUserNotificationTopicAdherenceExplanationNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public WfmUserNotificationTopicUserReference Agent { get; set; }

    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    public WfmUserNotificationTopicManagementUnit ManagementUnit { get; set; }

    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    public WfmUserNotificationTopicBusinessUnit BusinessUnit { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets LengthMinutes
    /// </summary>
    public long? LengthMinutes { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    public string Notes { get; set; }
}
