using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ActivityPlan
    /// </summary>
    public WfmActivityPlanJobCompleteTopicActivityPlanReference ActivityPlan { get; set; }

    /// <summary>
    /// Gets or Sets Exceptions
    /// </summary>
    public IEnumerable<WfmActivityPlanJobCompleteTopicActivityPlanJobException> Exceptions { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public WfmActivityPlanJobCompleteTopicErrorBody Error { get; set; }

    /// <summary>
    /// Gets or Sets Occurrence
    /// </summary>
    public WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference Occurrence { get; set; }
}
