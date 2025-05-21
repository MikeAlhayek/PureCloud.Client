using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResultListing Result { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public DateTime? WeekDate { get; set; }
}
