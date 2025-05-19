using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusRulesTopicAlertNotificationRecipient
{
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ContactAddress
    public string ContactAddress { get; set; }
}
