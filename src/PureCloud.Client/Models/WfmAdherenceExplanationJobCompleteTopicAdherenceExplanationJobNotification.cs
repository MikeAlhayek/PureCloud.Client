using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationJobNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationJobNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationJobNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets AdherenceExplanation
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification AdherenceExplanation { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public WfmAdherenceExplanationJobCompleteTopicErrorBody Error { get; set; }
}
