using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusRulesTopicAlertNotification
{
    /// <summary>
    /// Gets or Sets Recipient
    /// </summary>
    public V2MobiusRulesTopicAlertNotificationRecipient Recipient { get; set; }

    /// <summary>
    /// Gets or Sets NotificationTypes
    /// </summary>
    public IEnumerable<V2MobiusRulesTopicAlertNotificationNotificationTypesEnum> NotificationTypes { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    public string Locale { get; set; }
}
