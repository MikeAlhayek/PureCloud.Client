using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public WfmAlternativeShiftJobCompleteEventV3ErrorBody Error { get; set; }
}
