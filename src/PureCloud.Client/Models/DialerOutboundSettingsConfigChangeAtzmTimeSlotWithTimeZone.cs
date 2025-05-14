using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerOutboundSettingsConfigChangeAtzmTimeSlotWithTimeZone
{
    /// <summary>
    /// The time zone to use for contacts that cannot be mapped
    /// </summary>
    /// <value>The time zone to use for contacts that cannot be mapped</value>
    public string TimeZoneId { get; set; }

    /// <summary>
    /// The earliest time to dial a contact
    /// </summary>
    /// <value>The earliest time to dial a contact</value>
    public string EarliestCallableTime { get; set; }

    /// <summary>
    /// The latest time to dial a contact
    /// </summary>
    /// <value>The latest time to dial a contact</value>
    public string LatestCallableTime { get; set; }
}
