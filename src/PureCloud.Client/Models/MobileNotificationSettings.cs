using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MobileNotificationSettings
{
    /// <summary>
    /// When the user should receive notifications
    /// </summary>
    /// <value>When the user should receive notifications</value>
    public MobileNotificationSettingsWhenEnum? When { get; set; }
}
