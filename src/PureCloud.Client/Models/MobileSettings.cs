using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MobileSettings
{
    /// <summary>
    /// Settings for a user&#39;s mobile notifications
    /// </summary>
    /// <value>Settings for a user&#39;s mobile notifications</value>
    public MobileNotificationSettings Notifications { get; set; }
}
