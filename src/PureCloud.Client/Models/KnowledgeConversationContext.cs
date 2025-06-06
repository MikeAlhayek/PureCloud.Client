using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeConversationContext
/// </summary>

public partial class KnowledgeConversationContext : IEquatable<KnowledgeConversationContext>
{
    /// <summary>
    /// The media type of the conversation.
    /// </summary>
    /// <value>The media type of the conversation.</value>
    
    public enum MediaTypeEnum
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
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "Cobrowse"
        /// </summary>
        [EnumMember(Value = "Cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Screenshare for "Screenshare"
        /// </summary>
        [EnumMember(Value = "Screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice
    }
    /// <summary>
    /// The media type of the conversation.
    /// </summary>
    /// <value>The media type of the conversation.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeConversationContext" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeConversationContext() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeConversationContext" /> class.
    /// </summary>
    /// <param name="ConversationId">The unique identifier of the conversation. (required).</param>
    /// <param name="MediaType">The media type of the conversation..</param>
    /// <param name="QueueId">The unique identifier of the queue used to assign the interaction to the user..</param>
    /// <param name="ExternalContactId">The external contact identifier of the end-user participant..</param>
    public KnowledgeConversationContext(string ConversationId = null, MediaTypeEnum? MediaType = null, string QueueId = null, string ExternalContactId = null)
    {
        this.ConversationId = ConversationId;
        this.MediaType = MediaType;
        this.QueueId = QueueId;
        this.ExternalContactId = ExternalContactId;

    }



    /// <summary>
    /// The unique identifier of the conversation.
    /// </summary>
    /// <value>The unique identifier of the conversation.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }





    /// <summary>
    /// The unique identifier of the queue used to assign the interaction to the user.
    /// </summary>
    /// <value>The unique identifier of the queue used to assign the interaction to the user.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The external contact identifier of the end-user participant.
    /// </summary>
    /// <value>The external contact identifier of the end-user participant.</value>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeConversationContext {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
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
        return Equals(obj as KnowledgeConversationContext);
    }

    /// <summary>
    /// Returns true if KnowledgeConversationContext instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeConversationContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeConversationContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
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
            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            return hash;
        }
    }
}
