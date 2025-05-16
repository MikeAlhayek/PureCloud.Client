using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicAlertNotification
{
    /// <summary>
    /// Gets or Sets Recipient
    /// </summary>
    public V2MobiusAlertsTopicAlertNotificationRecipient Recipient { get; set; }

    /// <summary>
    /// Gets or Sets NotificationTypes
    /// </summary>
    public IEnumerable<V2MobiusAlertsTopicAlertNotificationNotificationTypesEnum> NotificationTypes { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    public string Locale { get; set; }
}
