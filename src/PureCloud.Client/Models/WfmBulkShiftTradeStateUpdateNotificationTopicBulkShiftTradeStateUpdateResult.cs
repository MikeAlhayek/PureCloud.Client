using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResultStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets FailureReason
    /// </summary>
    public WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResultFailureReasonEnum? FailureReason { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedBy
    /// </summary>
    public WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ReviewedBy { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    public WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata Metadata { get; set; }
}
