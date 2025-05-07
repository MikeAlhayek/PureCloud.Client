using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatMessage
/// </summary>

public partial class WebChatMessage : IEquatable<WebChatMessage>
{
    /// <summary>
    /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
    /// </summary>
    /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
    
    public enum BodyTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Standard for "standard"
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard,

        /// <summary>
        /// Enum Notice for "notice"
        /// </summary>
        [EnumMember(Value = "notice")]
        Notice,

        /// <summary>
        /// Enum Memberjoin for "member-join"
        /// </summary>
        [EnumMember(Value = "member-join")]
        Memberjoin,

        /// <summary>
        /// Enum Memberleave for "member-leave"
        /// </summary>
        [EnumMember(Value = "member-leave")]
        Memberleave,

        /// <summary>
        /// Enum Mediarequest for "media-request"
        /// </summary>
        [EnumMember(Value = "media-request")]
        Mediarequest
    }
    /// <summary>
    /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
    /// </summary>
    /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
    [JsonPropertyName("bodyType")]
    public BodyTypeEnum? BodyType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebChatMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatMessage" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Conversation">The identifier of the conversation (required).</param>
    /// <param name="Sender">The member who sent the message (required).</param>
    /// <param name="Body">The message body. (required).</param>
    /// <param name="BodyType">The purpose of the message within the conversation, such as a standard text entry versus a greeting. (required).</param>
    /// <param name="Timestamp">The timestamp of the message, in ISO-8601 format (required).</param>
    public WebChatMessage(string Name = null, WebChatConversation Conversation = null, WebChatMemberInfo Sender = null, string Body = null, BodyTypeEnum? BodyType = null, DateTime? Timestamp = null)
    {
        this.Name = Name;
        this.Conversation = Conversation;
        this.Sender = Sender;
        this.Body = Body;
        this.BodyType = BodyType;
        this.Timestamp = Timestamp;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The identifier of the conversation
    /// </summary>
    /// <value>The identifier of the conversation</value>
    [JsonPropertyName("conversation")]
    public WebChatConversation Conversation { get; set; }



    /// <summary>
    /// The member who sent the message
    /// </summary>
    /// <value>The member who sent the message</value>
    [JsonPropertyName("sender")]
    public WebChatMemberInfo Sender { get; set; }



    /// <summary>
    /// The message body.
    /// </summary>
    /// <value>The message body.</value>
    [JsonPropertyName("body")]
    public string Body { get; set; }





    /// <summary>
    /// The timestamp of the message, in ISO-8601 format
    /// </summary>
    /// <value>The timestamp of the message, in ISO-8601 format</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Sender: ").Append(Sender).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  BodyType: ").Append(BodyType).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as WebChatMessage);
    }

    /// <summary>
    /// Returns true if WebChatMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Sender == other.Sender ||
                Sender != null &&
                Sender.Equals(other.Sender)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
            ) &&
            (
                BodyType == other.BodyType ||
                BodyType != null &&
                BodyType.Equals(other.BodyType)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Sender != null)
            {
                hash = hash * 59 + Sender.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            if (BodyType != null)
            {
                hash = hash * 59 + BodyType.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
