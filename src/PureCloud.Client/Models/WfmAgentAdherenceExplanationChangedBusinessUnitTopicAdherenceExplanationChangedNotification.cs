using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAgentAdherenceExplanationChangedBusinessUnitTopicAdherenceExplanationChangedNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicAdherenceExplanationChangedNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicAdherenceExplanationChangedNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicUserReference Agent { get; set; }

    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit ManagementUnit { get; set; }

    /// <summary>
    /// Gets or Sets BusinessUnit
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicBusinessUnit BusinessUnit { get; set; }

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

    /// Gets or Sets ReviewedBy
    /// </summary>
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicUserReference ReviewedBy { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get; set; }
}
