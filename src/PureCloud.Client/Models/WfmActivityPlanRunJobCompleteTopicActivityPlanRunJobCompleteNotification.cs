using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ActivityPlan
    /// </summary>
    public WfmActivityPlanRunJobCompleteTopicActivityPlanReference ActivityPlan { get; set; }

    /// <summary>
    /// Gets or Sets Exceptions
    /// </summary>
    public IEnumerable<WfmActivityPlanRunJobCompleteTopicActivityPlanJobException> Exceptions { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public WfmActivityPlanRunJobCompleteTopicErrorBody Error { get; set; }
}
