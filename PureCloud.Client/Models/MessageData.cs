using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageData
/// </summary>
[DataContract]
public partial class MessageData : IEquatable<MessageData>
{
    /// <summary>
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// Type of text messenger.
    /// </summary>
    /// <value>Type of text messenger.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Facebook for "facebook"
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

        /// <summary>
        /// Enum Twitter for "twitter"
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessaging for "webmessaging"
        /// </summary>
        [EnumMember(Value = "webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Instagram for "instagram"
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Enum Apple for "apple"
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple
    }
    /// <summary>
    /// The status of the message.
    /// </summary>
    /// <value>The status of the message.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Queued for "queued"
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued,

        /// <summary>
        /// Enum Sent for "sent"
        /// </summary>
        [EnumMember(Value = "sent")]
        Sent,

        /// <summary>
        /// Enum Failed for "failed"
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Enum Received for "received"
        /// </summary>
        [EnumMember(Value = "received")]
        Received,

        /// <summary>
        /// Enum Deliverysuccess for "delivery-success"
        /// </summary>
        [EnumMember(Value = "delivery-success")]
        Deliverysuccess,

        /// <summary>
        /// Enum Deliveryfailed for "delivery-failed"
        /// </summary>
        [EnumMember(Value = "delivery-failed")]
        Deliveryfailed,

        /// <summary>
        /// Enum Read for "read"
        /// </summary>
        [EnumMember(Value = "read")]
        Read,

        /// <summary>
        /// Enum Removed for "removed"
        /// </summary>
        [EnumMember(Value = "removed")]
        Removed,

        /// <summary>
        /// Enum Published for "published"
        /// </summary>
        [EnumMember(Value = "published")]
        Published
    }
    /// <summary>
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Type of text messenger.
    /// </summary>
    /// <value>Type of text messenger.</value>
    [DataMember(Name = "messengerType", EmitDefaultValue = false)]
    public MessengerTypeEnum? MessengerType { get; set; }
    /// <summary>
    /// The status of the message.
    /// </summary>
    /// <value>The status of the message.</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessageData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessageData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageData" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ProviderMessageId">The unique identifier of the message from provider.</param>
    /// <param name="Timestamp">The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="FromAddress">The sender of the text message..</param>
    /// <param name="ToAddress">The recipient of the text message..</param>
    /// <param name="Direction">The direction of the message..</param>
    /// <param name="MessengerType">Type of text messenger..</param>
    /// <param name="TextBody">The body of the text message. (Deprecated - Instead use normalizedMessage.text) (required).</param>
    /// <param name="Status">The status of the message. (required).</param>
    /// <param name="Media">The media details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment).</param>
    /// <param name="Stickers">The sticker details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment.</param>
    /// <param name="CreatedBy">User who sent this message..</param>
    /// <param name="ConversationId">The id of the conversation of this message..</param>
    public MessageData(string Name = null, string ProviderMessageId = null, DateTime? Timestamp = null, string FromAddress = null, string ToAddress = null, DirectionEnum? Direction = null, MessengerTypeEnum? MessengerType = null, string TextBody = null, StatusEnum? Status = null, List<MessageMedia> Media = null, List<MessageSticker> Stickers = null, User CreatedBy = null, string ConversationId = null)
    {
        this.Name = Name;
        this.ProviderMessageId = ProviderMessageId;
        this.Timestamp = Timestamp;
        this.FromAddress = FromAddress;
        this.ToAddress = ToAddress;
        this.Direction = Direction;
        this.MessengerType = MessengerType;
        this.TextBody = TextBody;
        this.Status = Status;
        this.Media = Media;
        this.Stickers = Stickers;
        this.CreatedBy = CreatedBy;
        this.ConversationId = ConversationId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The unique identifier of the message from provider
    /// </summary>
    /// <value>The unique identifier of the message from provider</value>
    [DataMember(Name = "providerMessageId", EmitDefaultValue = false)]
    public string ProviderMessageId { get; set; }



    /// <summary>
    /// The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "timestamp", EmitDefaultValue = false)]
    public DateTime? Timestamp { get; set; }



    /// <summary>
    /// The sender of the text message.
    /// </summary>
    /// <value>The sender of the text message.</value>
    [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
    public string FromAddress { get; set; }



    /// <summary>
    /// The recipient of the text message.
    /// </summary>
    /// <value>The recipient of the text message.</value>
    [DataMember(Name = "toAddress", EmitDefaultValue = false)]
    public string ToAddress { get; set; }







    /// <summary>
    /// The body of the text message. (Deprecated - Instead use normalizedMessage.text)
    /// </summary>
    /// <value>The body of the text message. (Deprecated - Instead use normalizedMessage.text)</value>
    [DataMember(Name = "textBody", EmitDefaultValue = false)]
    public string TextBody { get; set; }





    /// <summary>
    /// The media details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment)
    /// </summary>
    /// <value>The media details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment)</value>
    [DataMember(Name = "media", EmitDefaultValue = false)]
    public List<MessageMedia> Media { get; set; }



    /// <summary>
    /// The sticker details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment
    /// </summary>
    /// <value>The sticker details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment</value>
    [DataMember(Name = "stickers", EmitDefaultValue = false)]
    public List<MessageSticker> Stickers { get; set; }



    /// <summary>
    /// The message into normalized format
    /// </summary>
    /// <value>The message into normalized format</value>
    [DataMember(Name = "normalizedMessage", EmitDefaultValue = false)]
    public ConversationNormalizedMessage NormalizedMessage { get; private set; }



    /// <summary>
    /// The delivery event associated with this message in normalized format, if the message direction was outbound
    /// </summary>
    /// <value>The delivery event associated with this message in normalized format, if the message direction was outbound</value>
    [DataMember(Name = "normalizedReceipts", EmitDefaultValue = false)]
    public List<ConversationNormalizedMessage> NormalizedReceipts { get; private set; }



    /// <summary>
    /// User who sent this message.
    /// </summary>
    /// <value>User who sent this message.</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public User CreatedBy { get; set; }



    /// <summary>
    /// The id of the conversation of this message.
    /// </summary>
    /// <value>The id of the conversation of this message.</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessageData {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ProviderMessageId: ").Append(ProviderMessageId).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
        sb.Append("  TextBody: ").Append(TextBody).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Media: ").Append(Media).Append("\n");
        sb.Append("  Stickers: ").Append(Stickers).Append("\n");
        sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
        sb.Append("  NormalizedReceipts: ").Append(NormalizedReceipts).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
        return Equals(obj as MessageData);
    }

    /// <summary>
    /// Returns true if MessageData instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageData other)
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
                ProviderMessageId == other.ProviderMessageId ||
                ProviderMessageId != null &&
                ProviderMessageId.Equals(other.ProviderMessageId)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
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
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Media == other.Media ||
                Media != null &&
                Media.SequenceEqual(other.Media)
            ) &&
            (
                Stickers == other.Stickers ||
                Stickers != null &&
                Stickers.SequenceEqual(other.Stickers)
            ) &&
            (
                NormalizedMessage == other.NormalizedMessage ||
                NormalizedMessage != null &&
                NormalizedMessage.Equals(other.NormalizedMessage)
            ) &&
            (
                NormalizedReceipts == other.NormalizedReceipts ||
                NormalizedReceipts != null &&
                NormalizedReceipts.SequenceEqual(other.NormalizedReceipts)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
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

            if (ProviderMessageId != null)
            {
                hash = hash * 59 + ProviderMessageId.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (MessengerType != null)
            {
                hash = hash * 59 + MessengerType.GetHashCode();
            }

            if (TextBody != null)
            {
                hash = hash * 59 + TextBody.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Media != null)
            {
                hash = hash * 59 + Media.GetHashCode();
            }

            if (Stickers != null)
            {
                hash = hash * 59 + Stickers.GetHashCode();
            }

            if (NormalizedMessage != null)
            {
                hash = hash * 59 + NormalizedMessage.GetHashCode();
            }

            if (NormalizedReceipts != null)
            {
                hash = hash * 59 + NormalizedReceipts.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
