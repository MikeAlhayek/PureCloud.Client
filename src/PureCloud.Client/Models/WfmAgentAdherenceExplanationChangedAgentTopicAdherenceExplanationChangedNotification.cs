using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAgentAdherenceExplanationChangedAgentTopicAdherenceExplanationChangedNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmAgentAdherenceExplanationChangedAgentTopicAdherenceExplanationChangedNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmAgentAdherenceExplanationChangedAgentTopicAdherenceExplanationChangedNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public WfmAgentAdherenceExplanationChangedAgentTopicUserReference Agent { get; set; }

    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    public WfmAgentAdherenceExplanationChangedAgentTopicManagementUnit ManagementUnit { get; set; }

    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    public WfmAgentAdherenceExplanationChangedAgentTopicBusinessUnit BusinessUnit { get; set; }

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

    /// <summary>
    /// Gets or Sets ReviewedBy
    /// </summary>
    public WfmAgentAdherenceExplanationChangedAgentTopicUserReference ReviewedBy { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get; set; }
}
