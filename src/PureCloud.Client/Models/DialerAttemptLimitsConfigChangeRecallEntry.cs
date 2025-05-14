using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerAttemptLimitsConfigChangeRecallEntry
{
    /// <summary>
    /// The number of recall attempts to make
    /// </summary>
    /// <value>The number of recall attempts to make</value>
    public long? NbrAttempts { get; set; }

    /// <summary>
    /// How long to wait between recall attempts
    /// </summary>
    /// <value>How long to wait between recall attempts</value>
    public long? MinutesBetweenAttempts { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
