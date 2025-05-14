using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerOutboundSettingsConfigChangeCallableWindow
{
    /// <summary>
    /// Gets or Sets Mapped
    /// </summary>
    public DialerOutboundSettingsConfigChangeAtzmTimeSlot Mapped { get; set; }

    /// <summary>
    /// Gets or Sets Unmapped
    /// </summary>
    public DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone Unmapped { get; set; }
}
