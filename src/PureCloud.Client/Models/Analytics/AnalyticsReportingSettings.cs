using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsReportingSettings
/// </summary>

public partial class AnalyticsReportingSettings : IEquatable<AnalyticsReportingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsReportingSettings" /> class.
    /// </summary>
    /// <param name="PiiMaskingEnabled">Indication of whether or not personal data is masked in data export and the Analytics/Reporting UI.</param>
    /// <param name="QueueAgentAccessObfuscation">Indication of whether or not to obfuscate export data from the Queue Agent Details view based on User ACL.</param>
    /// <param name="MyInteractionsPiiMaskingEnabled">Indicates whether PII data is masked in My Interaction export and the Analytics/Reporting UI.</param>
    public AnalyticsReportingSettings(bool? PiiMaskingEnabled = null, bool? QueueAgentAccessObfuscation = null, bool? MyInteractionsPiiMaskingEnabled = null)
    {
        this.PiiMaskingEnabled = PiiMaskingEnabled;
        this.QueueAgentAccessObfuscation = QueueAgentAccessObfuscation;
        this.MyInteractionsPiiMaskingEnabled = MyInteractionsPiiMaskingEnabled;

    }



    /// <summary>
    /// Indication of whether or not personal data is masked in data export and the Analytics/Reporting UI
    /// </summary>
    /// <value>Indication of whether or not personal data is masked in data export and the Analytics/Reporting UI</value>
    [JsonPropertyName("piiMaskingEnabled")]
    public bool? PiiMaskingEnabled { get; set; }



    /// <summary>
    /// Indication of whether or not to obfuscate export data from the Queue Agent Details view based on User ACL
    /// </summary>
    /// <value>Indication of whether or not to obfuscate export data from the Queue Agent Details view based on User ACL</value>
    [JsonPropertyName("queueAgentAccessObfuscation")]
    public bool? QueueAgentAccessObfuscation { get; set; }



    /// <summary>
    /// Indicates whether PII data is masked in My Interaction export and the Analytics/Reporting UI
    /// </summary>
    /// <value>Indicates whether PII data is masked in My Interaction export and the Analytics/Reporting UI</value>
    [JsonPropertyName("myInteractionsPiiMaskingEnabled")]
    public bool? MyInteractionsPiiMaskingEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsReportingSettings {\n");

        sb.Append("  PiiMaskingEnabled: ").Append(PiiMaskingEnabled).Append("\n");
        sb.Append("  QueueAgentAccessObfuscation: ").Append(QueueAgentAccessObfuscation).Append("\n");
        sb.Append("  MyInteractionsPiiMaskingEnabled: ").Append(MyInteractionsPiiMaskingEnabled).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as AnalyticsReportingSettings);
    }

    /// <summary>
    /// Returns true if AnalyticsReportingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsReportingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsReportingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PiiMaskingEnabled == other.PiiMaskingEnabled ||
                PiiMaskingEnabled != null &&
                PiiMaskingEnabled.Equals(other.PiiMaskingEnabled)
            ) &&
            (
                QueueAgentAccessObfuscation == other.QueueAgentAccessObfuscation ||
                QueueAgentAccessObfuscation != null &&
                QueueAgentAccessObfuscation.Equals(other.QueueAgentAccessObfuscation)
            ) &&
            (
                MyInteractionsPiiMaskingEnabled == other.MyInteractionsPiiMaskingEnabled ||
                MyInteractionsPiiMaskingEnabled != null &&
                MyInteractionsPiiMaskingEnabled.Equals(other.MyInteractionsPiiMaskingEnabled)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (PiiMaskingEnabled != null)
            {
                hash = hash * 59 + PiiMaskingEnabled.GetHashCode();
            }

            if (QueueAgentAccessObfuscation != null)
            {
                hash = hash * 59 + QueueAgentAccessObfuscation.GetHashCode();
            }

            if (MyInteractionsPiiMaskingEnabled != null)
            {
                hash = hash * 59 + MyInteractionsPiiMaskingEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
