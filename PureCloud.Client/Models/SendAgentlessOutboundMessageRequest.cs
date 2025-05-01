using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SendAgentlessOutboundMessageRequest
/// </summary>
[DataContract]
public partial class SendAgentlessOutboundMessageRequest : IEquatable<SendAgentlessOutboundMessageRequest>
{
    /// <summary>
    /// The recipient messaging address messenger type.
    /// </summary>
    /// <value>The recipient messaging address messenger type.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ToAddressMessengerTypeEnum
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
    /// The recipient messaging address messenger type.
    /// </summary>
    /// <value>The recipient messaging address messenger type.</value>
    [DataMember(Name = "toAddressMessengerType", EmitDefaultValue = false)]
    public ToAddressMessengerTypeEnum? ToAddressMessengerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendAgentlessOutboundMessageRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SendAgentlessOutboundMessageRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SendAgentlessOutboundMessageRequest" /> class.
    /// </summary>
    /// <param name="FromAddress">The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID (required).</param>
    /// <param name="ToAddress">The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. For WhatsApp messenger type, use a WhatsApp ID of a phone number. E.g for a E.164 formatted phone number &#x60;+13175555555&#x60;, a WhatsApp ID would be 13175555555 (required).</param>
    /// <param name="ToAddressMessengerType">The recipient messaging address messenger type. (required).</param>
    /// <param name="TextBody">The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters..</param>
    /// <param name="MessagingTemplate">The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type.</param>
    /// <param name="UseExistingActiveConversation">Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false.</param>
    public SendAgentlessOutboundMessageRequest(string FromAddress = null, string ToAddress = null, ToAddressMessengerTypeEnum? ToAddressMessengerType = null, string TextBody = null, SendMessagingTemplateRequest MessagingTemplate = null, bool? UseExistingActiveConversation = null)
    {
        this.FromAddress = FromAddress;
        this.ToAddress = ToAddress;
        this.ToAddressMessengerType = ToAddressMessengerType;
        this.TextBody = TextBody;
        this.MessagingTemplate = MessagingTemplate;
        this.UseExistingActiveConversation = UseExistingActiveConversation;

    }



    /// <summary>
    /// The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID
    /// </summary>
    /// <value>The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID</value>
    [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
    public string FromAddress { get; set; }



    /// <summary>
    /// The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. For WhatsApp messenger type, use a WhatsApp ID of a phone number. E.g for a E.164 formatted phone number &#x60;+13175555555&#x60;, a WhatsApp ID would be 13175555555
    /// </summary>
    /// <value>The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. For WhatsApp messenger type, use a WhatsApp ID of a phone number. E.g for a E.164 formatted phone number &#x60;+13175555555&#x60;, a WhatsApp ID would be 13175555555</value>
    [DataMember(Name = "toAddress", EmitDefaultValue = false)]
    public string ToAddress { get; set; }





    /// <summary>
    /// The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters.
    /// </summary>
    /// <value>The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters.</value>
    [DataMember(Name = "textBody", EmitDefaultValue = false)]
    public string TextBody { get; set; }



    /// <summary>
    /// The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type
    /// </summary>
    /// <value>The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type</value>
    [DataMember(Name = "messagingTemplate", EmitDefaultValue = false)]
    public SendMessagingTemplateRequest MessagingTemplate { get; set; }



    /// <summary>
    /// Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false
    /// </summary>
    /// <value>Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false</value>
    [DataMember(Name = "useExistingActiveConversation", EmitDefaultValue = false)]
    public bool? UseExistingActiveConversation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SendAgentlessOutboundMessageRequest {\n");

        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  ToAddressMessengerType: ").Append(ToAddressMessengerType).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
        sb.Append("  UseExistingActiveConversation: ").Append(UseExistingActiveConversation).Append("\n");
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
        return Equals(obj as SendAgentlessOutboundMessageRequest);
    }

    /// <summary>
    /// Returns true if SendAgentlessOutboundMessageRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SendAgentlessOutboundMessageRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SendAgentlessOutboundMessageRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                ToAddressMessengerType == other.ToAddressMessengerType ||
                ToAddressMessengerType != null &&
                ToAddressMessengerType.Equals(other.ToAddressMessengerType)
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
            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (ToAddressMessengerType != null)
            {
                hash = hash * 59 + ToAddressMessengerType.GetHashCode();
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

            return hash;
        }
    }
}
