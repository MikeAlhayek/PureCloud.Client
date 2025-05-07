using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailOrganizationPolicy
/// </summary>

public partial class VoicemailOrganizationPolicy : IEquatable<VoicemailOrganizationPolicy>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailOrganizationPolicy" /> class.
    /// </summary>
    /// <param name="AlertTimeoutSeconds">The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transferred to voicemail.</param>
    /// <param name="PinConfiguration">The configuration for user PINs to access their voicemail from a phone.</param>
    /// <param name="VoicemailExtension">The extension for voicemail retrieval.  The default value is *86..</param>
    /// <param name="PinRequired">If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone..</param>
    /// <param name="InteractiveResponseRequired">Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call.</param>
    /// <param name="SendEmailNotifications">Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting..</param>
    /// <param name="IncludeEmailTranscriptions">Whether to include the voicemail transcription in the notification email.</param>
    /// <param name="DisableEmailPii">Removes any PII from emails. This overrides any analogous group configuration value. This is always true if HIPAA is enabled or unknown for an organization..</param>
    /// <param name="MaximumRecordingTimeSeconds">Default value for the maximum length of time in seconds of a recorded voicemail.</param>
    public VoicemailOrganizationPolicy(int? AlertTimeoutSeconds = null, PINConfiguration PinConfiguration = null, string VoicemailExtension = null, bool? PinRequired = null, bool? InteractiveResponseRequired = null, bool? SendEmailNotifications = null, bool? IncludeEmailTranscriptions = null, bool? DisableEmailPii = null, int? MaximumRecordingTimeSeconds = null)
    {
        this.AlertTimeoutSeconds = AlertTimeoutSeconds;
        this.PinConfiguration = PinConfiguration;
        this.VoicemailExtension = VoicemailExtension;
        this.PinRequired = PinRequired;
        this.InteractiveResponseRequired = InteractiveResponseRequired;
        this.SendEmailNotifications = SendEmailNotifications;
        this.IncludeEmailTranscriptions = IncludeEmailTranscriptions;
        this.DisableEmailPii = DisableEmailPii;
        this.MaximumRecordingTimeSeconds = MaximumRecordingTimeSeconds;

    }



    /// <summary>
    /// Whether voicemail is enabled for this organization
    /// </summary>
    /// <value>Whether voicemail is enabled for this organization</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transferred to voicemail
    /// </summary>
    /// <value>The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transferred to voicemail</value>
    [JsonPropertyName("alertTimeoutSeconds")]
    public int? AlertTimeoutSeconds { get; set; }



    /// <summary>
    /// The configuration for user PINs to access their voicemail from a phone
    /// </summary>
    /// <value>The configuration for user PINs to access their voicemail from a phone</value>
    [JsonPropertyName("pinConfiguration")]
    public PINConfiguration PinConfiguration { get; set; }



    /// <summary>
    /// The extension for voicemail retrieval.  The default value is *86.
    /// </summary>
    /// <value>The extension for voicemail retrieval.  The default value is *86.</value>
    [JsonPropertyName("voicemailExtension")]
    public string VoicemailExtension { get; set; }



    /// <summary>
    /// If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone.
    /// </summary>
    /// <value>If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone.</value>
    [JsonPropertyName("pinRequired")]
    public bool? PinRequired { get; set; }



    /// <summary>
    /// Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call
    /// </summary>
    /// <value>Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call</value>
    [JsonPropertyName("interactiveResponseRequired")]
    public bool? InteractiveResponseRequired { get; set; }



    /// <summary>
    /// Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting.
    /// </summary>
    /// <value>Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting.</value>
    [JsonPropertyName("sendEmailNotifications")]
    public bool? SendEmailNotifications { get; set; }



    /// <summary>
    /// Whether to include the voicemail transcription in the notification email
    /// </summary>
    /// <value>Whether to include the voicemail transcription in the notification email</value>
    [JsonPropertyName("includeEmailTranscriptions")]
    public bool? IncludeEmailTranscriptions { get; set; }



    /// <summary>
    /// Removes any PII from emails. This overrides any analogous group configuration value. This is always true if HIPAA is enabled or unknown for an organization.
    /// </summary>
    /// <value>Removes any PII from emails. This overrides any analogous group configuration value. This is always true if HIPAA is enabled or unknown for an organization.</value>
    [JsonPropertyName("disableEmailPii")]
    public bool? DisableEmailPii { get; set; }



    /// <summary>
    /// Default value for the maximum length of time in seconds of a recorded voicemail
    /// </summary>
    /// <value>Default value for the maximum length of time in seconds of a recorded voicemail</value>
    [JsonPropertyName("maximumRecordingTimeSeconds")]
    public int? MaximumRecordingTimeSeconds { get; set; }



    /// <summary>
    /// The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailOrganizationPolicy {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
        sb.Append("  PinConfiguration: ").Append(PinConfiguration).Append("\n");
        sb.Append("  VoicemailExtension: ").Append(VoicemailExtension).Append("\n");
        sb.Append("  PinRequired: ").Append(PinRequired).Append("\n");
        sb.Append("  InteractiveResponseRequired: ").Append(InteractiveResponseRequired).Append("\n");
        sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
        sb.Append("  IncludeEmailTranscriptions: ").Append(IncludeEmailTranscriptions).Append("\n");
        sb.Append("  DisableEmailPii: ").Append(DisableEmailPii).Append("\n");
        sb.Append("  MaximumRecordingTimeSeconds: ").Append(MaximumRecordingTimeSeconds).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as VoicemailOrganizationPolicy);
    }

    /// <summary>
    /// Returns true if VoicemailOrganizationPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailOrganizationPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailOrganizationPolicy other)
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
                PinConfiguration == other.PinConfiguration ||
                PinConfiguration != null &&
                PinConfiguration.Equals(other.PinConfiguration)
            ) &&
            (
                VoicemailExtension == other.VoicemailExtension ||
                VoicemailExtension != null &&
                VoicemailExtension.Equals(other.VoicemailExtension)
            ) &&
            (
                PinRequired == other.PinRequired ||
                PinRequired != null &&
                PinRequired.Equals(other.PinRequired)
            ) &&
            (
                InteractiveResponseRequired == other.InteractiveResponseRequired ||
                InteractiveResponseRequired != null &&
                InteractiveResponseRequired.Equals(other.InteractiveResponseRequired)
            ) &&
            (
                SendEmailNotifications == other.SendEmailNotifications ||
                SendEmailNotifications != null &&
                SendEmailNotifications.Equals(other.SendEmailNotifications)
            ) &&
            (
                IncludeEmailTranscriptions == other.IncludeEmailTranscriptions ||
                IncludeEmailTranscriptions != null &&
                IncludeEmailTranscriptions.Equals(other.IncludeEmailTranscriptions)
            ) &&
            (
                DisableEmailPii == other.DisableEmailPii ||
                DisableEmailPii != null &&
                DisableEmailPii.Equals(other.DisableEmailPii)
            ) &&
            (
                MaximumRecordingTimeSeconds == other.MaximumRecordingTimeSeconds ||
                MaximumRecordingTimeSeconds != null &&
                MaximumRecordingTimeSeconds.Equals(other.MaximumRecordingTimeSeconds)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (PinConfiguration != null)
            {
                hash = hash * 59 + PinConfiguration.GetHashCode();
            }

            if (VoicemailExtension != null)
            {
                hash = hash * 59 + VoicemailExtension.GetHashCode();
            }

            if (PinRequired != null)
            {
                hash = hash * 59 + PinRequired.GetHashCode();
            }

            if (InteractiveResponseRequired != null)
            {
                hash = hash * 59 + InteractiveResponseRequired.GetHashCode();
            }

            if (SendEmailNotifications != null)
            {
                hash = hash * 59 + SendEmailNotifications.GetHashCode();
            }

            if (IncludeEmailTranscriptions != null)
            {
                hash = hash * 59 + IncludeEmailTranscriptions.GetHashCode();
            }

            if (DisableEmailPii != null)
            {
                hash = hash * 59 + DisableEmailPii.GetHashCode();
            }

            if (MaximumRecordingTimeSeconds != null)
            {
                hash = hash * 59 + MaximumRecordingTimeSeconds.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
