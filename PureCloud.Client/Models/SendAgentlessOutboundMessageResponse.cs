using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SendAgentlessOutboundMessageResponse
/// </summary>

public partial class SendAgentlessOutboundMessageResponse : IEquatable<SendAgentlessOutboundMessageResponse>
{
    /// <summary>
    /// Type of messenger.
    /// </summary>
    /// <value>Type of messenger.</value>
    
    public enum MessengerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "sms"
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open
    }
    /// <summary>
    /// Type of messenger.
    /// </summary>
    /// <value>Type of messenger.</value>
    [JsonPropertyName("messengerType")]
    public MessengerTypeEnum? MessengerType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SendAgentlessOutboundMessageResponse" /> class.
    /// </summary>
    /// <param name="ConversationId">The identifier of the conversation..</param>
    /// <param name="FromAddress">The sender of the message..</param>
    /// <param name="ToAddress">The recipient of the message..</param>
    /// <param name="MessengerType">Type of messenger..</param>
    /// <param name="TextBody">The body of the text message. (Deprecated - Instead use message.normalizedMessage.text).</param>
    /// <param name="MessagingTemplate">The messaging template sent. (Deprecated - Instead use message.normalizedMessage.content[#].template).</param>
    /// <param name="UseExistingActiveConversation">Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false.</param>
    /// <param name="Message">Sent agentless outbound message in normalized format.</param>
    /// <param name="Timestamp">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public SendAgentlessOutboundMessageResponse(string ConversationId = null, string FromAddress = null, string ToAddress = null, MessengerTypeEnum? MessengerType = null, string TextBody = null, SendMessagingTemplateRequest MessagingTemplate = null, bool? UseExistingActiveConversation = null, MessageData Message = null, DateTime? Timestamp = null)
    {
        this.ConversationId = ConversationId;
        this.FromAddress = FromAddress;
        this.ToAddress = ToAddress;
        this.MessengerType = MessengerType;
        this.TextBody = TextBody;
        this.MessagingTemplate = MessagingTemplate;
        this.UseExistingActiveConversation = UseExistingActiveConversation;
        this.Message = Message;
        this.Timestamp = Timestamp;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The identifier of the conversation.
    /// </summary>
    /// <value>The identifier of the conversation.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The sender of the message.
    /// </summary>
    /// <value>The sender of the message.</value>
    [JsonPropertyName("fromAddress")]
    public string FromAddress { get; set; }



    /// <summary>
    /// The recipient of the message.
    /// </summary>
    /// <value>The recipient of the message.</value>
    [JsonPropertyName("toAddress")]
    public string ToAddress { get; set; }





    /// <summary>
    /// The body of the text message. (Deprecated - Instead use message.normalizedMessage.text)
    /// </summary>
    /// <value>The body of the text message. (Deprecated - Instead use message.normalizedMessage.text)</value>
    [JsonPropertyName("textBody")]
    public string TextBody { get; set; }



    /// <summary>
    /// The messaging template sent. (Deprecated - Instead use message.normalizedMessage.content[#].template)
    /// </summary>
    /// <value>The messaging template sent. (Deprecated - Instead use message.normalizedMessage.content[#].template)</value>
    [JsonPropertyName("messagingTemplate")]
    public SendMessagingTemplateRequest MessagingTemplate { get; set; }



    /// <summary>
    /// Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false
    /// </summary>
    /// <value>Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false</value>
    [JsonPropertyName("useExistingActiveConversation")]
    public bool? UseExistingActiveConversation { get; set; }



    /// <summary>
    /// Sent agentless outbound message in normalized format
    /// </summary>
    /// <value>Sent agentless outbound message in normalized format</value>
    [JsonPropertyName("message")]
    public MessageData Message { get; set; }



    /// <summary>
    /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Details of the user created the job
    /// </summary>
    /// <value>Details of the user created the job</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SendAgentlessOutboundMessageResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
        sb.Append("  UseExistingActiveConversation: ").Append(UseExistingActiveConversation).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as SendAgentlessOutboundMessageResponse);
    }

    /// <summary>
    /// Returns true if SendAgentlessOutboundMessageResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SendAgentlessOutboundMessageResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SendAgentlessOutboundMessageResponse other)
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
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                ToAddress == other.ToAddress ||
                ToAddress != null &&
                ToAddress.Equals(other.ToAddress)
            ) &&
            (
                MessengerType == other.MessengerType ||
                MessengerType != null &&
                MessengerType.Equals(other.MessengerType)
            ) &&
            (
                TextBody == other.TextBody ||
                TextBody != null &&
                TextBody.Equals(other.TextBody)
            ) &&
            (
                MessagingTemplate == other.MessagingTemplate ||
                MessagingTemplate != null &&
                MessagingTemplate.Equals(other.MessagingTemplate)
            ) &&
            (
                UseExistingActiveConversation == other.UseExistingActiveConversation ||
                UseExistingActiveConversation != null &&
                UseExistingActiveConversation.Equals(other.UseExistingActiveConversation)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
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
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (MessengerType != null)
            {
                hash = hash * 59 + MessengerType.GetHashCode();
            }

            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (MessagingTemplate != null)
            {
                hash = hash * 59 + MessagingTemplate.GetHashCode();
            }

            if (UseExistingActiveConversation != null)
            {
                hash = hash * 59 + UseExistingActiveConversation.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
