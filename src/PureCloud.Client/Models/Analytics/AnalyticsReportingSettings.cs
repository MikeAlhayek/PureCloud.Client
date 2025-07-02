using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsReportingSettings
{
    /// <summary>
    /// Indication of whether or not personal data is masked in data export and the Analytics/Reporting UI
    /// </summary>
    /// <value>Indication of whether or not personal data is masked in data export and the Analytics/Reporting UI</value>
    public bool? PiiMaskingEnabled { get; set; }

    /// <summary>
    /// Indication of whether or not to obfuscate export data from the Queue Agent Details view based on User ACL
    /// </summary>
    /// <value>Indication of whether or not to obfuscate export data from the Queue Agent Details view based on User ACL</value>
    public bool? QueueAgentAccessObfuscation { get; set; }

    /// <summary>
    /// Indicates whether PII data is masked in My Interaction export and the Analytics/Reporting UI
    /// </summary>
    /// <value>Indicates whether PII data is masked in My Interaction export and the Analytics/Reporting UI</value>
    public bool? MyInteractionsPiiMaskingEnabled { get; set; }
}
