using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class DialerSequenceScheduleConfigChangeAlteration
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public DialerSequenceScheduleConfigChangeAlterationTypeEnum? Type { get; set; }

    /// <summary>
    /// the end date of an alteration range as an ISO-8601 string
    /// </summary>
    /// <value>the end date of an alteration range as an ISO-8601 string</value>
    public string Start { get; set; }

    /// <summary>
    /// the end date of an alteration range as an ISO-8601 string
    /// </summary>
    /// <value>the end date of an alteration range as an ISO-8601 string</value>
    public string End { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
