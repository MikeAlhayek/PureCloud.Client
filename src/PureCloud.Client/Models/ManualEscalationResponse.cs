using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ManualEscalationResponse
/// </summary>

public partial class ManualEscalationResponse : IEquatable<ManualEscalationResponse>
{
    /// <summary>
    /// Escalation Status of the message.
    /// </summary>
    /// <value>Escalation Status of the message.</value>
    
    public enum EscalationStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Throttled for "Throttled"
        /// </summary>
        [EnumMember(Value = "Throttled")]
        Throttled,

        /// <summary>
        /// Enum Previouslyescalated for "PreviouslyEscalated"
        /// </summary>
        [EnumMember(Value = "PreviouslyEscalated")]
        Previouslyescalated,

        /// <summary>
        /// Enum Notescalated for "NotEscalated"
        /// </summary>
        [EnumMember(Value = "NotEscalated")]
        Notescalated,

        /// <summary>
        /// Enum Automatic for "Automatic"
        /// </summary>
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    /// <summary>
    /// Escalation Status of the message.
    /// </summary>
    /// <value>Escalation Status of the message.</value>
    [JsonPropertyName("escalationStatus")]
    public EscalationStatusEnum? EscalationStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ManualEscalationResponse" /> class.
    /// </summary>
    /// <param name="SocialMediaNormalizedMessageId">The Id of the message that got escalated..</param>
    /// <param name="ConversationNormalizedMessageId">The ID of the message in the conversation..</param>
    /// <param name="EscalationTarget">The target integration configuration used for an social media message..</param>
    /// <param name="EscalationStatus">Escalation Status of the message..</param>
    public ManualEscalationResponse(string SocialMediaNormalizedMessageId = null, string ConversationNormalizedMessageId = null, EscalationTarget EscalationTarget = null, EscalationStatusEnum? EscalationStatus = null)
    {
        this.SocialMediaNormalizedMessageId = SocialMediaNormalizedMessageId;
        this.ConversationNormalizedMessageId = ConversationNormalizedMessageId;
        this.EscalationTarget = EscalationTarget;
        this.EscalationStatus = EscalationStatus;

    }



    /// <summary>
    /// The Id of the message that got escalated.
    /// </summary>
    /// <value>The Id of the message that got escalated.</value>
    [JsonPropertyName("socialMediaNormalizedMessageId")]
    public string SocialMediaNormalizedMessageId { get; set; }



    /// <summary>
    /// The ID of the message in the conversation.
    /// </summary>
    /// <value>The ID of the message in the conversation.</value>
    [JsonPropertyName("conversationNormalizedMessageId")]
    public string ConversationNormalizedMessageId { get; set; }



    /// <summary>
    /// The target integration configuration used for an social media message.
    /// </summary>
    /// <value>The target integration configuration used for an social media message.</value>
    [JsonPropertyName("escalationTarget")]
    public EscalationTarget EscalationTarget { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ManualEscalationResponse {\n");

        sb.Append("  SocialMediaNormalizedMessageId: ").Append(SocialMediaNormalizedMessageId).Append("\n");
        sb.Append("  ConversationNormalizedMessageId: ").Append(ConversationNormalizedMessageId).Append("\n");
        sb.Append("  EscalationTarget: ").Append(EscalationTarget).Append("\n");
        sb.Append("  EscalationStatus: ").Append(EscalationStatus).Append("\n");
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
        return Equals(obj as ManualEscalationResponse);
    }

    /// <summary>
    /// Returns true if ManualEscalationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ManualEscalationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ManualEscalationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SocialMediaNormalizedMessageId == other.SocialMediaNormalizedMessageId ||
                SocialMediaNormalizedMessageId != null &&
                SocialMediaNormalizedMessageId.Equals(other.SocialMediaNormalizedMessageId)
            ) &&
            (
                ConversationNormalizedMessageId == other.ConversationNormalizedMessageId ||
                ConversationNormalizedMessageId != null &&
                ConversationNormalizedMessageId.Equals(other.ConversationNormalizedMessageId)
            ) &&
            (
                EscalationTarget == other.EscalationTarget ||
                EscalationTarget != null &&
                EscalationTarget.Equals(other.EscalationTarget)
            ) &&
            (
                EscalationStatus == other.EscalationStatus ||
                EscalationStatus != null &&
                EscalationStatus.Equals(other.EscalationStatus)
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
            if (SocialMediaNormalizedMessageId != null)
            {
                hash = hash * 59 + SocialMediaNormalizedMessageId.GetHashCode();
            }

            if (ConversationNormalizedMessageId != null)
            {
                hash = hash * 59 + ConversationNormalizedMessageId.GetHashCode();
            }

            if (EscalationTarget != null)
            {
                hash = hash * 59 + EscalationTarget.GetHashCode();
            }

            if (EscalationStatus != null)
            {
                hash = hash * 59 + EscalationStatus.GetHashCode();
            }

            return hash;
        }
    }
}
