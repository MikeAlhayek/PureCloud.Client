using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentlessEmailSendRequestDto
/// </summary>

public partial class AgentlessEmailSendRequestDto : IEquatable<AgentlessEmailSendRequestDto>
{
    /// <summary>
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    
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
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    [JsonPropertyName("senderType")]
    public SenderTypeEnum? SenderType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentlessEmailSendRequestDto" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentlessEmailSendRequestDto() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentlessEmailSendRequestDto" /> class.
    /// </summary>
    /// <param name="SenderType">The direction of the message. (required).</param>
    /// <param name="ConversationId">The identifier of the conversation. This must be an email interaction..</param>
    /// <param name="FromAddress">The sender of the message. (required).</param>
    /// <param name="ToAddresses">The recipient of the message. We currently support one recipient only. (required).</param>
    /// <param name="ReplyToAddress">The address to use for reply..</param>
    /// <param name="Subject">The subject of the message..</param>
    /// <param name="TextBody">The Content of the message, in plain text..</param>
    /// <param name="HtmlBody">The Content of the message, in HTML. Links, images and styles are allowed.</param>
    public AgentlessEmailSendRequestDto(SenderTypeEnum? SenderType = null, string ConversationId = null, EmailAddress FromAddress = null, List<EmailAddress> ToAddresses = null, EmailAddress ReplyToAddress = null, string Subject = null, string TextBody = null, string HtmlBody = null)
    {
        this.SenderType = SenderType;
        this.ConversationId = ConversationId;
        this.FromAddress = FromAddress;
        this.ToAddresses = ToAddresses;
        this.ReplyToAddress = ReplyToAddress;
        this.Subject = Subject;
        this.TextBody = TextBody;
        this.HtmlBody = HtmlBody;

    }





    /// <summary>
    /// The identifier of the conversation. This must be an email interaction.
    /// </summary>
    /// <value>The identifier of the conversation. This must be an email interaction.</value>
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
    /// The Content of the message, in plain text.
    /// </summary>
    /// <value>The Content of the message, in plain text.</value>
    [JsonPropertyName("textBody")]
    public string TextBody { get; set; }



    /// <summary>
    /// The Content of the message, in HTML. Links, images and styles are allowed
    /// </summary>
    /// <value>The Content of the message, in HTML. Links, images and styles are allowed</value>
    [JsonPropertyName("htmlBody")]
    public string HtmlBody { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentlessEmailSendRequestDto {\n");

        sb.Append("  SenderType: ").Append(SenderType).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  ToAddresses: ").Append(ToAddresses).Append("\n");
        sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
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
        return Equals(obj as AgentlessEmailSendRequestDto);
    }

    /// <summary>
    /// Returns true if AgentlessEmailSendRequestDto instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentlessEmailSendRequestDto to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentlessEmailSendRequestDto other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SenderType == other.SenderType ||
                SenderType != null &&
                SenderType.Equals(other.SenderType)
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
                TextBody == other.TextBody ||
                TextBody != null &&
                TextBody.Equals(other.TextBody)
            ) &&
            (
                HtmlBody == other.HtmlBody ||
                HtmlBody != null &&
                HtmlBody.Equals(other.HtmlBody)
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
            if (SenderType != null)
            {
                hash = hash * 59 + SenderType.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
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

            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (HtmlBody != null)
            {
                hash = hash * 59 + HtmlBody.GetHashCode();
            }

            return hash;
        }
    }
}
