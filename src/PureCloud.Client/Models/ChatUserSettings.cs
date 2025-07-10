using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatUserSettings
{
    /// <summary>
    /// Settings for mobile devices
    /// </summary>
    /// <value>Settings for mobile devices</value>
    public MobileSettings Mobile { get; set; }
}
