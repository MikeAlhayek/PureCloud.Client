using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateOutboundMessagingConversationRequest
/// </summary>

public partial class CreateOutboundMessagingConversationRequest : IEquatable<CreateOutboundMessagingConversationRequest>
{
    /// <summary>
    /// The messaging address messenger type.
    /// </summary>
    /// <value>The messaging address messenger type.</value>
    
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
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp
    }
    /// <summary>
    /// The messaging address messenger type.
    /// </summary>
    /// <value>The messaging address messenger type.</value>
    [JsonPropertyName("toAddressMessengerType")]
    public ToAddressMessengerTypeEnum? ToAddressMessengerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateOutboundMessagingConversationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateOutboundMessagingConversationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateOutboundMessagingConversationRequest" /> class.
    /// </summary>
    /// <param name="QueueId">The ID of the queue to be associated with the message. This will determine the fromAddress of the message, unless useUserFromAddress is true and the queue is configured to use the agent&#39;s Direct Routing address as the fromAddress. (required).</param>
    /// <param name="ToAddress">The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234.  For open messenger type, any string within the outbound.open.messaging.to.address.characters.max limit can be used. For whatsapp messenger type, use a Whatsapp ID of a phone number. E.g for a E.164 formatted phone number &#x60;+13175555555&#x60;, a Whatsapp ID would be 13175555555 (required).</param>
    /// <param name="ToAddressMessengerType">The messaging address messenger type. (required).</param>
    /// <param name="UseExistingConversation">An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window..</param>
    /// <param name="ExternalContactId">The external contact with which the message will be associated..</param>
    /// <param name="UseUserFromAddress">An override to attempt to use the user&#39;s configured direct routing address as the fromAddress.  If set to true, users configured address with &#39;directrouting&#39; integration will be used as fromAddress.  If set to false or not set, the queueId will be used for determining fromAddress..</param>
    public CreateOutboundMessagingConversationRequest(string QueueId = null, string ToAddress = null, ToAddressMessengerTypeEnum? ToAddressMessengerType = null, bool? UseExistingConversation = null, string ExternalContactId = null, bool? UseUserFromAddress = null)
    {
        this.QueueId = QueueId;
        this.ToAddress = ToAddress;
        this.ToAddressMessengerType = ToAddressMessengerType;
        this.UseExistingConversation = UseExistingConversation;
        this.ExternalContactId = ExternalContactId;
        this.UseUserFromAddress = UseUserFromAddress;

    }



    /// <summary>
    /// The ID of the queue to be associated with the message. This will determine the fromAddress of the message, unless useUserFromAddress is true and the queue is configured to use the agent&#39;s Direct Routing address as the fromAddress.
    /// </summary>
    /// <value>The ID of the queue to be associated with the message. This will determine the fromAddress of the message, unless useUserFromAddress is true and the queue is configured to use the agent&#39;s Direct Routing address as the fromAddress.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234.  For open messenger type, any string within the outbound.open.messaging.to.address.characters.max limit can be used. For whatsapp messenger type, use a Whatsapp ID of a phone number. E.g for a E.164 formatted phone number &#x60;+13175555555&#x60;, a Whatsapp ID would be 13175555555
    /// </summary>
    /// <value>The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234.  For open messenger type, any string within the outbound.open.messaging.to.address.characters.max limit can be used. For whatsapp messenger type, use a Whatsapp ID of a phone number. E.g for a E.164 formatted phone number &#x60;+13175555555&#x60;, a Whatsapp ID would be 13175555555</value>
    [JsonPropertyName("toAddress")]
    public string ToAddress { get; set; }





    /// <summary>
    /// An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window.
    /// </summary>
    /// <value>An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window.</value>
    [JsonPropertyName("useExistingConversation")]
    public bool? UseExistingConversation { get; set; }



    /// <summary>
    /// The external contact with which the message will be associated.
    /// </summary>
    /// <value>The external contact with which the message will be associated.</value>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// An override to attempt to use the user&#39;s configured direct routing address as the fromAddress.  If set to true, users configured address with &#39;directrouting&#39; integration will be used as fromAddress.  If set to false or not set, the queueId will be used for determining fromAddress.
    /// </summary>
    /// <value>An override to attempt to use the user&#39;s configured direct routing address as the fromAddress.  If set to true, users configured address with &#39;directrouting&#39; integration will be used as fromAddress.  If set to false or not set, the queueId will be used for determining fromAddress.</value>
    [JsonPropertyName("useUserFromAddress")]
    public bool? UseUserFromAddress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateOutboundMessagingConversationRequest {\n");

        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  ToAddressMessengerType: ").Append(ToAddressMessengerType).Append("\n");
        sb.Append("  UseExistingConversation: ").Append(UseExistingConversation).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  UseUserFromAddress: ").Append(UseUserFromAddress).Append("\n");
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
        return Equals(obj as CreateOutboundMessagingConversationRequest);
    }

    /// <summary>
    /// Returns true if CreateOutboundMessagingConversationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateOutboundMessagingConversationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateOutboundMessagingConversationRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
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
                UseExistingConversation == other.UseExistingConversation ||
                UseExistingConversation != null &&
                UseExistingConversation.Equals(other.UseExistingConversation)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                UseUserFromAddress == other.UseUserFromAddress ||
                UseUserFromAddress != null &&
                UseUserFromAddress.Equals(other.UseUserFromAddress)
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
            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (ToAddressMessengerType != null)
            {
                hash = hash * 59 + ToAddressMessengerType.GetHashCode();
            }

            if (UseExistingConversation != null)
            {
                hash = hash * 59 + UseExistingConversation.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (UseUserFromAddress != null)
            {
                hash = hash * 59 + UseUserFromAddress.GetHashCode();
            }

            return hash;
        }
    }
}
