using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerOutboundSettingsConfigChangeAtzmTimeSlot
{
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
