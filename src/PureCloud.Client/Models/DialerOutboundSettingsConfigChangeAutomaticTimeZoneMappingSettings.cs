using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings
{
    /// <summary>
    /// The time intervals to use for automatic time zone mapping
    /// </summary>
    /// <value>The time intervals to use for automatic time zone mapping</value>
    public IEnumerable<DialerOutboundSettingsConfigChangeCallableWindow> CallableWindows { get; set; }
}
