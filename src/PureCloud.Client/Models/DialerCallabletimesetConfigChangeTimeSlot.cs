using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCallabletimesetConfigChangeTimeSlot
{
    /// <summary>
    /// The start time of this time slot
    /// </summary>
    /// <value>The start time of this time slot</value>
    public string StartTime { get; set; }

    /// <summary>
    /// The stop time of this time slot
    /// </summary>
    /// <value>The stop time of this time slot</value>
    public string StopTime { get; set; }

    /// <summary>
    /// The day this time slot applies
    /// </summary>
    /// <value>The day this time slot applies</value>
    public long? Day { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
