using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AlertNotification
{
    /// <summary>
    /// The entity to receive the notification.
    /// </summary>
    /// <value>The entity to receive the notification.</value>
    public string Recipient { get; set; }

    /// <summary>
    /// The notification types the user will receive.
    /// </summary>
    /// <value>The notification types the user will receive.</value>
    public IEnumerable<AlertNotificationNotificationTypesEnum> NotificationTypes { get; set; }

    /// <summary>
    /// The locale whose language will be used when sending alerts.  Locale should be in theformat language_COUNTRY where language is always lower case and country is always upper case.
    /// </summary>
    /// <value>The locale whose language will be used when sending alerts.  Locale should be in theformat language_COUNTRY where language is always lower case and country is always upper case.</value>
    public string Locale { get; set; }
}
