using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicUserReference Agent { get; set; }

    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicManagementUnit ManagementUnit { get; set; }

    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicBusinessUnit BusinessUnit { get; set; }

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
    public WfmAdherenceExplanationJobCompleteTopicUserReference ReviewedBy { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get; set; }
}
