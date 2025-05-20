using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WfmTimeOffBalanceJobTopicTimeOffBalance> Entities { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public WfmTimeOffBalanceJobTopicErrorBody Error { get; set; }
}
