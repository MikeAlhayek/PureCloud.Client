using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatSettings
{
    /// <summary>
    /// Retention time for messages in days, expressed as int in the range [10,3650]
    /// </summary>
    /// <value>Retention time for messages in days, expressed as int in the range [10,3650]</value>
    public int? MessageRetentionPeriodDays { get; set; }

    /// <summary>
    /// Reactions enabled for org
    /// </summary>
    /// <value>Reactions enabled for org</value>
    public bool? ReactionsEnabled { get; set; }
}
