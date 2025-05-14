using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCallabletimesetConfigChangeCallableTime
{
    /// <summary>
    /// The time slots
    /// </summary>
    /// <value>The time slots</value>
    public IEnumerable<DialerCallabletimesetConfigChangeTimeSlot> TimeSlots { get; set; }

    /// <summary>
    /// The ISO ID for the timezone
    /// </summary>
    /// <value>The ISO ID for the timezone</value>
    public string TimeZoneId { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
