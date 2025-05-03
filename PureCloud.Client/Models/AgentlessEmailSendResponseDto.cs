using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentlessEmailSendResponseDto
/// </summary>

public partial class AgentlessEmailSendResponseDto : IEquatable<AgentlessEmailSendResponseDto>
{
    /// <summary>
    /// The identifier of the external participant of the given conversation.
    /// </summary>
    /// <value>The identifier of the external participant of the given conversation.</value>
    
    public enum SenderTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Outbound for "Outbound"
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound,

        /// <summary>
        /// Enum Inbound for "Inbound"
        /// </summary>
        [EnumMember(Value = "Inbound")]
        Inbound,

        /// <summary>
        /// Enum Integration for "Integration"
        /// </summary>
        [EnumMember(Value = "Integration")]
        Integration
    }
    /// <summary>
    /// The identifier of the external participant of the given conversation.
    /// </summary>
    /// <value>The identifier of the external participant of the given conversation.</value>
    [JsonPropertyName("senderType")]
    public SenderTypeEnum? SenderType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentlessEmailSendResponseDto" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentlessEmailSendResponseDto() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentlessEmailSendResponseDto" /> class.
    /// </summary>
    /// <param name="ConversationId">The identifier of the conversation. (required).</param>
    /// <param name="SenderType">The identifier of the external participant of the given conversation. (required).</param>
    /// <param name="FromAddress">The sender of the message. (required).</param>
    /// <param name="ToAddresses">The recipient of the message. We currently support one recipient only. (required).</param>
    /// <param name="ReplyToAddress">The address to use for reply..</param>
    /// <param name="Subject">The subject of the message..</param>
    /// <param name="DateCreated">The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public AgentlessEmailSendResponseDto(string ConversationId = null, SenderTypeEnum? SenderType = null, EmailAddress FromAddress = null, List<EmailAddress> ToAddresses = null, EmailAddress ReplyToAddress = null, string Subject = null, DateTime? DateCreated = null)
    {
        this.ConversationId = ConversationId;
        this.SenderType = SenderType;
        this.FromAddress = FromAddress;
        this.ToAddresses = ToAddresses;
        this.ReplyToAddress = ReplyToAddress;
        this.Subject = Subject;
        this.DateCreated = DateCreated;

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
    public EmailAddress FromAddress { get; set; }



    /// <summary>
    /// The recipient of the message. We currently support one recipient only.
    /// </summary>
    /// <value>The recipient of the message. We currently support one recipient only.</value>
    [JsonPropertyName("toAddresses")]
    public List<EmailAddress> ToAddresses { get; set; }



    /// <summary>
    /// The address to use for reply.
    /// </summary>
    /// <value>The address to use for reply.</value>
    [JsonPropertyName("replyToAddress")]
    public EmailAddress ReplyToAddress { get; set; }



    /// <summary>
    /// The subject of the message.
    /// </summary>
    /// <value>The subject of the message.</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }



    /// <summary>
    /// The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentlessEmailSendResponseDto {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  SenderType: ").Append(SenderType).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  ToAddresses: ").Append(ToAddresses).Append("\n");
        sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
        return Equals(obj as AgentlessEmailSendResponseDto);
    }

    /// <summary>
    /// Returns true if AgentlessEmailSendResponseDto instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentlessEmailSendResponseDto to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentlessEmailSendResponseDto other)
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
                SenderType == other.SenderType ||
                SenderType != null &&
                SenderType.Equals(other.SenderType)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                ToAddresses == other.ToAddresses ||
                ToAddresses != null &&
                ToAddresses.SequenceEqual(other.ToAddresses)
            ) &&
            (
                ReplyToAddress == other.ReplyToAddress ||
                ReplyToAddress != null &&
                ReplyToAddress.Equals(other.ReplyToAddress)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
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

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (SenderType != null)
            {
                hash = hash * 59 + SenderType.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (ToAddresses != null)
            {
                hash = hash * 59 + ToAddresses.GetHashCode();
            }

            if (ReplyToAddress != null)
            {
                hash = hash * 59 + ReplyToAddress.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
