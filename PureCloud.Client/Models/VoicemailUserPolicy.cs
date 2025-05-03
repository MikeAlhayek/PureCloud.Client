using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailUserPolicy
/// </summary>

public partial class VoicemailUserPolicy : IEquatable<VoicemailUserPolicy>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailUserPolicy" /> class.
    /// </summary>
    /// <param name="AlertTimeoutSeconds">The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail.</param>
    /// <param name="Pin">The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security.</param>
    /// <param name="SendEmailNotifications">Whether email notifications are sent to the user when a new voicemail is received.</param>
    public VoicemailUserPolicy(int? AlertTimeoutSeconds = null, string Pin = null, bool? SendEmailNotifications = null)
    {
        this.AlertTimeoutSeconds = AlertTimeoutSeconds;
        this.Pin = Pin;
        this.SendEmailNotifications = SendEmailNotifications;

    }



    /// <summary>
    /// Whether the user has voicemail enabled
    /// </summary>
    /// <value>Whether the user has voicemail enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; private set; }



    /// <summary>
    /// The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail
    /// </summary>
    /// <value>The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail</value>
    [JsonPropertyName("alertTimeoutSeconds")]
    public int? AlertTimeoutSeconds { get; set; }



    /// <summary>
    /// The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security
    /// </summary>
    /// <value>The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security</value>
    [JsonPropertyName("pin")]
    public string Pin { get; set; }



    /// <summary>
    /// The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; private set; }



    /// <summary>
    /// Whether email notifications are sent to the user when a new voicemail is received
    /// </summary>
    /// <value>Whether email notifications are sent to the user when a new voicemail is received</value>
    [JsonPropertyName("sendEmailNotifications")]
    public bool? SendEmailNotifications { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailUserPolicy {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
        sb.Append("  Pin: ").Append(Pin).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
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
        return Equals(obj as VoicemailUserPolicy);
    }

    /// <summary>
    /// Returns true if VoicemailUserPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailUserPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailUserPolicy other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
                AlertTimeoutSeconds != null &&
                AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
            ) &&
            (
                Pin == other.Pin ||
                Pin != null &&
                Pin.Equals(other.Pin)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                SendEmailNotifications == other.SendEmailNotifications ||
                SendEmailNotifications != null &&
                SendEmailNotifications.Equals(other.SendEmailNotifications)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (AlertTimeoutSeconds != null)
            {
                hash = hash * 59 + AlertTimeoutSeconds.GetHashCode();
            }

            if (Pin != null)
            {
                hash = hash * 59 + Pin.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (SendEmailNotifications != null)
            {
                hash = hash * 59 + SendEmailNotifications.GetHashCode();
            }

            return hash;
        }
    }
}
