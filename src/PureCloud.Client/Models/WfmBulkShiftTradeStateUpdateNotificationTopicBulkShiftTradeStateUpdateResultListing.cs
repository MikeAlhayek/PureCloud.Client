using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResultListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult> Entities { get; set; }
}
