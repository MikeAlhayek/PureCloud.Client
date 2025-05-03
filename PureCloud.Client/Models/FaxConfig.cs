using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FaxConfig
/// </summary>

public partial class FaxConfig : IEquatable<FaxConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="FaxConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FaxConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxConfig" /> class.
    /// </summary>
    /// <param name="SendEmailNotifications">Whether to enable email notifications for this organization (required).</param>
    /// <param name="DisableEmailPii">Whether to disable PII for email notifications (required).</param>
    public FaxConfig(bool? SendEmailNotifications = null, bool? DisableEmailPii = null)
    {
        this.SendEmailNotifications = SendEmailNotifications;
        this.DisableEmailPii = DisableEmailPii;

    }



    /// <summary>
    /// Whether to enable email notifications for this organization
    /// </summary>
    /// <value>Whether to enable email notifications for this organization</value>
    [JsonPropertyName("sendEmailNotifications")]
    public bool? SendEmailNotifications { get; set; }



    /// <summary>
    /// Whether to disable PII for email notifications
    /// </summary>
    /// <value>Whether to disable PII for email notifications</value>
    [JsonPropertyName("disableEmailPii")]
    public bool? DisableEmailPii { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FaxConfig {\n");

        sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
        sb.Append("  DisableEmailPii: ").Append(DisableEmailPii).Append("\n");
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
        return Equals(obj as FaxConfig);
    }

    /// <summary>
    /// Returns true if FaxConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of FaxConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FaxConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SendEmailNotifications == other.SendEmailNotifications ||
                SendEmailNotifications != null &&
                SendEmailNotifications.Equals(other.SendEmailNotifications)
            ) &&
            (
                DisableEmailPii == other.DisableEmailPii ||
                DisableEmailPii != null &&
                DisableEmailPii.Equals(other.DisableEmailPii)
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
            if (SendEmailNotifications != null)
            {
                hash = hash * 59 + SendEmailNotifications.GetHashCode();
            }

            if (DisableEmailPii != null)
            {
                hash = hash * 59 + DisableEmailPii.GetHashCode();
            }

            return hash;
        }
    }
}
