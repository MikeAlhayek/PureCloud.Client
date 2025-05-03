using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeConversationContextResponse
/// </summary>

public partial class KnowledgeConversationContextResponse : IEquatable<KnowledgeConversationContextResponse>
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
    /// Initializes a new instance of the <see cref="KnowledgeConversationContextResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeConversationContextResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeConversationContextResponse" /> class.
    /// </summary>
    /// <param name="Conversation">The conversation. (required).</param>
    /// <param name="Queue">The queue used to assign the interaction to the user..</param>
    /// <param name="ExternalContact">The end-user participant of the conversation..</param>
    /// <param name="MediaType">The media type of the conversation..</param>
    public KnowledgeConversationContextResponse(AddressableEntityRef Conversation = null, AddressableEntityRef Queue = null, AddressableEntityRef ExternalContact = null, MediaTypeEnum? MediaType = null)
    {
        this.Conversation = Conversation;
        this.Queue = Queue;
        this.ExternalContact = ExternalContact;
        this.MediaType = MediaType;

    }



    /// <summary>
    /// The conversation.
    /// </summary>
    /// <value>The conversation.</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// The queue used to assign the interaction to the user.
    /// </summary>
    /// <value>The queue used to assign the interaction to the user.</value>
    [JsonPropertyName("queue")]
    public AddressableEntityRef Queue { get; set; }



    /// <summary>
    /// The end-user participant of the conversation.
    /// </summary>
    /// <value>The end-user participant of the conversation.</value>
    [JsonPropertyName("externalContact")]
    public AddressableEntityRef ExternalContact { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeConversationContextResponse {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
        return Equals(obj as KnowledgeConversationContextResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeConversationContextResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeConversationContextResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeConversationContextResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
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
            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            return hash;
        }
    }
}
