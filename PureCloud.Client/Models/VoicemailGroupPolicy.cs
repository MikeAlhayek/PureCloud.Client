using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailGroupPolicy
/// </summary>

public partial class VoicemailGroupPolicy : IEquatable<VoicemailGroupPolicy>
{
    /// <summary>
    /// Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.
    /// </summary>
    /// <value>Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.</value>
    
    public enum GroupAlertTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Random for "RANDOM"
        /// </summary>
        [EnumMember(Value = "RANDOM")]
        Random,

        /// <summary>
        /// Enum RoundRobin for "ROUND_ROBIN"
        /// </summary>
        [EnumMember(Value = "ROUND_ROBIN")]
        RoundRobin,

        /// <summary>
        /// Enum Sequential for "SEQUENTIAL"
        /// </summary>
        [EnumMember(Value = "SEQUENTIAL")]
        Sequential
    }
    /// <summary>
    /// Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.
    /// </summary>
    /// <value>Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.</value>
    [JsonPropertyName("groupAlertType")]
    public GroupAlertTypeEnum? GroupAlertType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailGroupPolicy" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Enabled">Whether voicemail is enabled for the group.</param>
    /// <param name="SendEmailNotifications">Whether email notifications are sent to group members when a new voicemail is received.</param>
    /// <param name="DisableEmailPii">Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization..</param>
    /// <param name="IncludeEmailTranscriptions">Whether to include the voicemail transcription in a group notification email.</param>
    /// <param name="LanguagePreference">The language preference for the group.  Used for group voicemail transcription.</param>
    /// <param name="EmailPolicy">The email policy for the group.</param>
    /// <param name="RotateCallsSecs">How many seconds to ring before rotating to the next member in the group.</param>
    /// <param name="StopRingingAfterRotations">How many rotations to go through.</param>
    /// <param name="OverflowGroupId">A fallback group to contact when all of the members in this group did not answer the call..</param>
    /// <param name="GroupAlertType">Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin..</param>
    /// <param name="InteractiveResponsePromptId">The prompt to use when connecting a user to a Group Ring call.</param>
    /// <param name="InteractiveResponseRequired">Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call.</param>
    public VoicemailGroupPolicy(string Name = null, bool? Enabled = null, bool? SendEmailNotifications = null, bool? DisableEmailPii = null, bool? IncludeEmailTranscriptions = null, string LanguagePreference = null, GroupEmailPolicy EmailPolicy = null, int? RotateCallsSecs = null, int? StopRingingAfterRotations = null, string OverflowGroupId = null, GroupAlertTypeEnum? GroupAlertType = null, string InteractiveResponsePromptId = null, bool? InteractiveResponseRequired = null)
    {
        this.Name = Name;
        this.Enabled = Enabled;
        this.SendEmailNotifications = SendEmailNotifications;
        this.DisableEmailPii = DisableEmailPii;
        this.IncludeEmailTranscriptions = IncludeEmailTranscriptions;
        this.LanguagePreference = LanguagePreference;
        this.EmailPolicy = EmailPolicy;
        this.RotateCallsSecs = RotateCallsSecs;
        this.StopRingingAfterRotations = StopRingingAfterRotations;
        this.OverflowGroupId = OverflowGroupId;
        this.GroupAlertType = GroupAlertType;
        this.InteractiveResponsePromptId = InteractiveResponsePromptId;
        this.InteractiveResponseRequired = InteractiveResponseRequired;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The group associated with the policy
    /// </summary>
    /// <value>The group associated with the policy</value>
    [JsonPropertyName("group")]
    public Group Group { get; private set; }



    /// <summary>
    /// Whether voicemail is enabled for the group
    /// </summary>
    /// <value>Whether voicemail is enabled for the group</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Whether email notifications are sent to group members when a new voicemail is received
    /// </summary>
    /// <value>Whether email notifications are sent to group members when a new voicemail is received</value>
    [JsonPropertyName("sendEmailNotifications")]
    public bool? SendEmailNotifications { get; set; }



    /// <summary>
    /// Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization.
    /// </summary>
    /// <value>Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization.</value>
    [JsonPropertyName("disableEmailPii")]
    public bool? DisableEmailPii { get; set; }



    /// <summary>
    /// Whether to include the voicemail transcription in a group notification email
    /// </summary>
    /// <value>Whether to include the voicemail transcription in a group notification email</value>
    [JsonPropertyName("includeEmailTranscriptions")]
    public bool? IncludeEmailTranscriptions { get; set; }



    /// <summary>
    /// The language preference for the group.  Used for group voicemail transcription
    /// </summary>
    /// <value>The language preference for the group.  Used for group voicemail transcription</value>
    [JsonPropertyName("languagePreference")]
    public string LanguagePreference { get; set; }



    /// <summary>
    /// The email policy for the group
    /// </summary>
    /// <value>The email policy for the group</value>
    [JsonPropertyName("emailPolicy")]
    public GroupEmailPolicy EmailPolicy { get; set; }



    /// <summary>
    /// How many seconds to ring before rotating to the next member in the group
    /// </summary>
    /// <value>How many seconds to ring before rotating to the next member in the group</value>
    [JsonPropertyName("rotateCallsSecs")]
    public int? RotateCallsSecs { get; set; }



    /// <summary>
    /// How many rotations to go through
    /// </summary>
    /// <value>How many rotations to go through</value>
    [JsonPropertyName("stopRingingAfterRotations")]
    public int? StopRingingAfterRotations { get; set; }



    /// <summary>
    /// A fallback group to contact when all of the members in this group did not answer the call.
    /// </summary>
    /// <value>A fallback group to contact when all of the members in this group did not answer the call.</value>
    [JsonPropertyName("overflowGroupId")]
    public string OverflowGroupId { get; set; }





    /// <summary>
    /// The prompt to use when connecting a user to a Group Ring call
    /// </summary>
    /// <value>The prompt to use when connecting a user to a Group Ring call</value>
    [JsonPropertyName("interactiveResponsePromptId")]
    public string InteractiveResponsePromptId { get; set; }



    /// <summary>
    /// Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call
    /// </summary>
    /// <value>Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call</value>
    [JsonPropertyName("interactiveResponseRequired")]
    public bool? InteractiveResponseRequired { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailGroupPolicy {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
        sb.Append("  DisableEmailPii: ").Append(DisableEmailPii).Append("\n");
        sb.Append("  IncludeEmailTranscriptions: ").Append(IncludeEmailTranscriptions).Append("\n");
        sb.Append("  LanguagePreference: ").Append(LanguagePreference).Append("\n");
        sb.Append("  EmailPolicy: ").Append(EmailPolicy).Append("\n");
        sb.Append("  RotateCallsSecs: ").Append(RotateCallsSecs).Append("\n");
        sb.Append("  StopRingingAfterRotations: ").Append(StopRingingAfterRotations).Append("\n");
        sb.Append("  OverflowGroupId: ").Append(OverflowGroupId).Append("\n");
        sb.Append("  GroupAlertType: ").Append(GroupAlertType).Append("\n");
        sb.Append("  InteractiveResponsePromptId: ").Append(InteractiveResponsePromptId).Append("\n");
        sb.Append("  InteractiveResponseRequired: ").Append(InteractiveResponseRequired).Append("\n");
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
        return Equals(obj as VoicemailGroupPolicy);
    }

    /// <summary>
    /// Returns true if VoicemailGroupPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailGroupPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailGroupPolicy other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                SendEmailNotifications == other.SendEmailNotifications ||
                SendEmailNotifications != null &&
                SendEmailNotifications.Equals(other.SendEmailNotifications)
            ) &&
            (
                DisableEmailPii == other.DisableEmailPii ||
                DisableEmailPii != null &&
                DisableEmailPii.Equals(other.DisableEmailPii)
            ) &&
            (
                IncludeEmailTranscriptions == other.IncludeEmailTranscriptions ||
                IncludeEmailTranscriptions != null &&
                IncludeEmailTranscriptions.Equals(other.IncludeEmailTranscriptions)
            ) &&
            (
                LanguagePreference == other.LanguagePreference ||
                LanguagePreference != null &&
                LanguagePreference.Equals(other.LanguagePreference)
            ) &&
            (
                EmailPolicy == other.EmailPolicy ||
                EmailPolicy != null &&
                EmailPolicy.Equals(other.EmailPolicy)
            ) &&
            (
                RotateCallsSecs == other.RotateCallsSecs ||
                RotateCallsSecs != null &&
                RotateCallsSecs.Equals(other.RotateCallsSecs)
            ) &&
            (
                StopRingingAfterRotations == other.StopRingingAfterRotations ||
                StopRingingAfterRotations != null &&
                StopRingingAfterRotations.Equals(other.StopRingingAfterRotations)
            ) &&
            (
                OverflowGroupId == other.OverflowGroupId ||
                OverflowGroupId != null &&
                OverflowGroupId.Equals(other.OverflowGroupId)
            ) &&
            (
                GroupAlertType == other.GroupAlertType ||
                GroupAlertType != null &&
                GroupAlertType.Equals(other.GroupAlertType)
            ) &&
            (
                InteractiveResponsePromptId == other.InteractiveResponsePromptId ||
                InteractiveResponsePromptId != null &&
                InteractiveResponsePromptId.Equals(other.InteractiveResponsePromptId)
            ) &&
            (
                InteractiveResponseRequired == other.InteractiveResponseRequired ||
                InteractiveResponseRequired != null &&
                InteractiveResponseRequired.Equals(other.InteractiveResponseRequired)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (SendEmailNotifications != null)
            {
                hash = hash * 59 + SendEmailNotifications.GetHashCode();
            }

            if (DisableEmailPii != null)
            {
                hash = hash * 59 + DisableEmailPii.GetHashCode();
            }

            if (IncludeEmailTranscriptions != null)
            {
                hash = hash * 59 + IncludeEmailTranscriptions.GetHashCode();
            }

            if (LanguagePreference != null)
            {
                hash = hash * 59 + LanguagePreference.GetHashCode();
            }

            if (EmailPolicy != null)
            {
                hash = hash * 59 + EmailPolicy.GetHashCode();
            }

            if (RotateCallsSecs != null)
            {
                hash = hash * 59 + RotateCallsSecs.GetHashCode();
            }

            if (StopRingingAfterRotations != null)
            {
                hash = hash * 59 + StopRingingAfterRotations.GetHashCode();
            }

            if (OverflowGroupId != null)
            {
                hash = hash * 59 + OverflowGroupId.GetHashCode();
            }

            if (GroupAlertType != null)
            {
                hash = hash * 59 + GroupAlertType.GetHashCode();
            }

            if (InteractiveResponsePromptId != null)
            {
                hash = hash * 59 + InteractiveResponsePromptId.GetHashCode();
            }

            if (InteractiveResponseRequired != null)
            {
                hash = hash * 59 + InteractiveResponseRequired.GetHashCode();
            }

            return hash;
        }
    }
}
