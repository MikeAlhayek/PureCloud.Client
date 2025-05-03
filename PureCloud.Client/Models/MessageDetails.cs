using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageDetails
/// </summary>

public partial class MessageDetails : IEquatable<MessageDetails>
{
    /// <summary>
    /// Indicates the delivery status of the message.
    /// </summary>
    /// <value>Indicates the delivery status of the message.</value>
    
    public enum MessageStatusEnum
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
    /// For social media messages, the visibility of the message in the originating social platform
    /// </summary>
    /// <value>For social media messages, the visibility of the message in the originating social platform</value>
    
    public enum SocialVisibilityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Private for "private"
        /// </summary>
        [EnumMember(Value = "private")]
        Private,

        /// <summary>
        /// Enum Public for "public"
        /// </summary>
        [EnumMember(Value = "public")]
        Public
    }
    /// <summary>
    /// Indicates the delivery status of the message.
    /// </summary>
    /// <value>Indicates the delivery status of the message.</value>
    [JsonPropertyName("messageStatus")]
    public MessageStatusEnum? MessageStatus { get; set; }
    /// <summary>
    /// For social media messages, the visibility of the message in the originating social platform
    /// </summary>
    /// <value>For social media messages, the visibility of the message in the originating social platform</value>
    [JsonPropertyName("socialVisibility")]
    public SocialVisibilityEnum? SocialVisibility { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageDetails" /> class.
    /// </summary>
    /// <param name="MessageId">UUID identifying the message media..</param>
    /// <param name="MessageURI">A URI for this message entity..</param>
    /// <param name="MessageStatus">Indicates the delivery status of the message..</param>
    /// <param name="MessageSegmentCount">The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits..</param>
    /// <param name="MessageTime">The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Media">The media (images, files, etc) associated with this message, if any.</param>
    /// <param name="Stickers">One or more stickers associated with this message, if any.</param>
    /// <param name="MessageMetadata">Information that describes the content of the message, if any.</param>
    /// <param name="SocialVisibility">For social media messages, the visibility of the message in the originating social platform.</param>
    /// <param name="ErrorInfo">Provider specific error information for a communication..</param>
    public MessageDetails(string MessageId = null, string MessageURI = null, MessageStatusEnum? MessageStatus = null, int? MessageSegmentCount = null, DateTime? MessageTime = null, List<MessageMedia> Media = null, List<MessageSticker> Stickers = null, ConversationMessageMetadata MessageMetadata = null, SocialVisibilityEnum? SocialVisibility = null, ErrorBody ErrorInfo = null)
    {
        this.MessageId = MessageId;
        this.MessageURI = MessageURI;
        this.MessageStatus = MessageStatus;
        this.MessageSegmentCount = MessageSegmentCount;
        this.MessageTime = MessageTime;
        this.Media = Media;
        this.Stickers = Stickers;
        this.MessageMetadata = MessageMetadata;
        this.SocialVisibility = SocialVisibility;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// UUID identifying the message media.
    /// </summary>
    /// <value>UUID identifying the message media.</value>
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }



    /// <summary>
    /// A URI for this message entity.
    /// </summary>
    /// <value>A URI for this message entity.</value>
    [JsonPropertyName("messageURI")]
    public string MessageURI { get; set; }





    /// <summary>
    /// The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.
    /// </summary>
    /// <value>The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.</value>
    [JsonPropertyName("messageSegmentCount")]
    public int? MessageSegmentCount { get; set; }



    /// <summary>
    /// The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("messageTime")]
    public DateTime? MessageTime { get; set; }



    /// <summary>
    /// The media (images, files, etc) associated with this message, if any
    /// </summary>
    /// <value>The media (images, files, etc) associated with this message, if any</value>
    [JsonPropertyName("media")]
    public List<MessageMedia> Media { get; set; }



    /// <summary>
    /// One or more stickers associated with this message, if any
    /// </summary>
    /// <value>One or more stickers associated with this message, if any</value>
    [JsonPropertyName("stickers")]
    public List<MessageSticker> Stickers { get; set; }



    /// <summary>
    /// Information that describes the content of the message, if any
    /// </summary>
    /// <value>Information that describes the content of the message, if any</value>
    [JsonPropertyName("messageMetadata")]
    public ConversationMessageMetadata MessageMetadata { get; set; }





    /// <summary>
    /// Provider specific error information for a communication.
    /// </summary>
    /// <value>Provider specific error information for a communication.</value>
    [JsonPropertyName("errorInfo")]
    public ErrorBody ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessageDetails {\n");

        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
        sb.Append("  MessageURI: ").Append(MessageURI).Append("\n");
        sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
        sb.Append("  MessageSegmentCount: ").Append(MessageSegmentCount).Append("\n");
        sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
        sb.Append("  Media: ").Append(Media).Append("\n");
        sb.Append("  Stickers: ").Append(Stickers).Append("\n");
        sb.Append("  MessageMetadata: ").Append(MessageMetadata).Append("\n");
        sb.Append("  SocialVisibility: ").Append(SocialVisibility).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
        return Equals(obj as MessageDetails);
    }

    /// <summary>
    /// Returns true if MessageDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessageId == other.MessageId ||
                MessageId != null &&
                MessageId.Equals(other.MessageId)
            ) &&
            (
                MessageURI == other.MessageURI ||
                MessageURI != null &&
                MessageURI.Equals(other.MessageURI)
            ) &&
            (
                MessageStatus == other.MessageStatus ||
                MessageStatus != null &&
                MessageStatus.Equals(other.MessageStatus)
            ) &&
            (
                MessageSegmentCount == other.MessageSegmentCount ||
                MessageSegmentCount != null &&
                MessageSegmentCount.Equals(other.MessageSegmentCount)
            ) &&
            (
                MessageTime == other.MessageTime ||
                MessageTime != null &&
                MessageTime.Equals(other.MessageTime)
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
                MessageMetadata == other.MessageMetadata ||
                MessageMetadata != null &&
                MessageMetadata.Equals(other.MessageMetadata)
            ) &&
            (
                SocialVisibility == other.SocialVisibility ||
                SocialVisibility != null &&
                SocialVisibility.Equals(other.SocialVisibility)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
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
            if (MessageId != null)
            {
                hash = hash * 59 + MessageId.GetHashCode();
            }

            if (MessageURI != null)
            {
                hash = hash * 59 + MessageURI.GetHashCode();
            }

            if (MessageStatus != null)
            {
                hash = hash * 59 + MessageStatus.GetHashCode();
            }

            if (MessageSegmentCount != null)
            {
                hash = hash * 59 + MessageSegmentCount.GetHashCode();
            }

            if (MessageTime != null)
            {
                hash = hash * 59 + MessageTime.GetHashCode();
            }

            if (Media != null)
            {
                hash = hash * 59 + Media.GetHashCode();
            }

            if (Stickers != null)
            {
                hash = hash * 59 + Stickers.GetHashCode();
            }

            if (MessageMetadata != null)
            {
                hash = hash * 59 + MessageMetadata.GetHashCode();
            }

            if (SocialVisibility != null)
            {
                hash = hash * 59 + SocialVisibility.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
