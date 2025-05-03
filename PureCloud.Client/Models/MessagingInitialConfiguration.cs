using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessagingInitialConfiguration
/// </summary>

public partial class MessagingInitialConfiguration : IEquatable<MessagingInitialConfiguration>
{
    /// <summary>
    /// The type of message platform from which the message originated.
    /// </summary>
    /// <value>The type of message platform from which the message originated.</value>
    
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms,

        /// <summary>
        /// Enum Twitter for "Twitter"
        /// </summary>
        [EnumMember(Value = "Twitter")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "Facebook"
        /// </summary>
        [EnumMember(Value = "Facebook")]
        Facebook,

        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line,

        /// <summary>
        /// Enum Whatsapp for "WhatsApp"
        /// </summary>
        [EnumMember(Value = "WhatsApp")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessage for "WebMessage"
        /// </summary>
        [EnumMember(Value = "WebMessage")]
        Webmessage,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Instagram for "Instagram"
        /// </summary>
        [EnumMember(Value = "Instagram")]
        Instagram,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The type of message platform from which the message originated.
    /// </summary>
    /// <value>The type of message platform from which the message originated.</value>
    [JsonPropertyName("messageType")]
    public MessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingInitialConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingInitialConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingInitialConfiguration" /> class.
    /// </summary>
    /// <param name="ToAddress">Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended. (required).</param>
    /// <param name="FromAddress">Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended. (required).</param>
    /// <param name="MessageType">The type of message platform from which the message originated..</param>
    /// <param name="Held">Indicates that this communication&#39;s initial state is held..</param>
    /// <param name="Alerting">Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state..</param>
    /// <param name="Inbound">Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND..</param>
    /// <param name="InvitedBy">The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred..</param>
    /// <param name="AdditionalInfo">Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields..</param>
    public MessagingInitialConfiguration(string ToAddress = null, string FromAddress = null, MessageTypeEnum? MessageType = null, bool? Held = null, bool? Alerting = null, bool? Inbound = null, string InvitedBy = null, Dictionary<string, string> AdditionalInfo = null)
    {
        this.ToAddress = ToAddress;
        this.FromAddress = FromAddress;
        this.MessageType = MessageType;
        this.Held = Held;
        this.Alerting = Alerting;
        this.Inbound = Inbound;
        this.InvitedBy = InvitedBy;
        this.AdditionalInfo = AdditionalInfo;

    }



    /// <summary>
    /// Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended.
    /// </summary>
    /// <value>Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended.</value>
    [JsonPropertyName("toAddress")]
    public string ToAddress { get; set; }



    /// <summary>
    /// Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended.
    /// </summary>
    /// <value>Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended.</value>
    [JsonPropertyName("fromAddress")]
    public string FromAddress { get; set; }





    /// <summary>
    /// Indicates that this communication&#39;s initial state is held.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is held.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.</value>
    [JsonPropertyName("alerting")]
    public bool? Alerting { get; set; }



    /// <summary>
    /// Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.
    /// </summary>
    /// <value>Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.</value>
    [JsonPropertyName("inbound")]
    public bool? Inbound { get; set; }



    /// <summary>
    /// The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.
    /// </summary>
    /// <value>The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.</value>
    [JsonPropertyName("invitedBy")]
    public string InvitedBy { get; set; }



    /// <summary>
    /// Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.
    /// </summary>
    /// <value>Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.</value>
    [JsonPropertyName("additionalInfo")]
    public Dictionary<string, string> AdditionalInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingInitialConfiguration {\n");

        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  Alerting: ").Append(Alerting).Append("\n");
        sb.Append("  Inbound: ").Append(Inbound).Append("\n");
        sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
        sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
        return Equals(obj as MessagingInitialConfiguration);
    }

    /// <summary>
    /// Returns true if MessagingInitialConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingInitialConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingInitialConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ToAddress == other.ToAddress ||
                ToAddress != null &&
                ToAddress.Equals(other.ToAddress)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                Alerting == other.Alerting ||
                Alerting != null &&
                Alerting.Equals(other.Alerting)
            ) &&
            (
                Inbound == other.Inbound ||
                Inbound != null &&
                Inbound.Equals(other.Inbound)
            ) &&
            (
                InvitedBy == other.InvitedBy ||
                InvitedBy != null &&
                InvitedBy.Equals(other.InvitedBy)
            ) &&
            (
                AdditionalInfo == other.AdditionalInfo ||
                AdditionalInfo != null &&
                AdditionalInfo.SequenceEqual(other.AdditionalInfo)
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
            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (Alerting != null)
            {
                hash = hash * 59 + Alerting.GetHashCode();
            }

            if (Inbound != null)
            {
                hash = hash * 59 + Inbound.GetHashCode();
            }

            if (InvitedBy != null)
            {
                hash = hash * 59 + InvitedBy.GetHashCode();
            }

            if (AdditionalInfo != null)
            {
                hash = hash * 59 + AdditionalInfo.GetHashCode();
            }

            return hash;
        }
    }
}
