using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicMessageDetails
/// </summary>

public partial class QueueConversationVideoEventTopicMessageDetails : IEquatable<QueueConversationVideoEventTopicMessageDetails>
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
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicMessageDetails" /> class.
    /// </summary>
    /// <param name="MessageId">UUID identifying the message media..</param>
    /// <param name="MessageTime">The time when the message was sent or received..</param>
    /// <param name="MessageStatus">Indicates the delivery status of the message..</param>
    /// <param name="MessageSegmentCount">The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits..</param>
    /// <param name="Media">The media (images, files, etc) associated with this message, if any.</param>
    /// <param name="ErrorInfo">Detailed information about an error response..</param>
    /// <param name="Stickers">A list of stickers included in the message.</param>
    /// <param name="MessageMetadata">MessageMetadata.</param>
    /// <param name="SocialVisibility">For social media messages, the visibility of the message in the originating social platform.</param>
    public QueueConversationVideoEventTopicMessageDetails(string MessageId = null, DateTime? MessageTime = null, MessageStatusEnum? MessageStatus = null, long? MessageSegmentCount = null, List<QueueConversationVideoEventTopicMessageMedia> Media = null, QueueConversationVideoEventTopicErrorDetails ErrorInfo = null, List<QueueConversationVideoEventTopicMessageSticker> Stickers = null, QueueConversationVideoEventTopicMessageMetadata MessageMetadata = null, SocialVisibilityEnum? SocialVisibility = null)
    {
        this.MessageId = MessageId;
        this.MessageTime = MessageTime;
        this.MessageStatus = MessageStatus;
        this.MessageSegmentCount = MessageSegmentCount;
        this.Media = Media;
        this.ErrorInfo = ErrorInfo;
        this.Stickers = Stickers;
        this.MessageMetadata = MessageMetadata;
        this.SocialVisibility = SocialVisibility;

    }



    /// <summary>
    /// UUID identifying the message media.
    /// </summary>
    /// <value>UUID identifying the message media.</value>
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }



    /// <summary>
    /// The time when the message was sent or received.
    /// </summary>
    /// <value>The time when the message was sent or received.</value>
    [JsonPropertyName("messageTime")]
    public DateTime? MessageTime { get; set; }





    /// <summary>
    /// The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.
    /// </summary>
    /// <value>The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.</value>
    [JsonPropertyName("messageSegmentCount")]
    public long? MessageSegmentCount { get; set; }



    /// <summary>
    /// The media (images, files, etc) associated with this message, if any
    /// </summary>
    /// <value>The media (images, files, etc) associated with this message, if any</value>
    [JsonPropertyName("media")]
    public List<QueueConversationVideoEventTopicMessageMedia> Media { get; set; }



    /// <summary>
    /// Detailed information about an error response.
    /// </summary>
    /// <value>Detailed information about an error response.</value>
    [JsonPropertyName("errorInfo")]
    public QueueConversationVideoEventTopicErrorDetails ErrorInfo { get; set; }



    /// <summary>
    /// A list of stickers included in the message
    /// </summary>
    /// <value>A list of stickers included in the message</value>
    [JsonPropertyName("stickers")]
    public List<QueueConversationVideoEventTopicMessageSticker> Stickers { get; set; }



    /// <summary>
    /// Gets or Sets MessageMetadata
    /// </summary>
    [JsonPropertyName("messageMetadata")]
    public QueueConversationVideoEventTopicMessageMetadata MessageMetadata { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicMessageDetails {\n");

        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
        sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
        sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
        sb.Append("  MessageSegmentCount: ").Append(MessageSegmentCount).Append("\n");
        sb.Append("  Media: ").Append(Media).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  Stickers: ").Append(Stickers).Append("\n");
        sb.Append("  MessageMetadata: ").Append(MessageMetadata).Append("\n");
        sb.Append("  SocialVisibility: ").Append(SocialVisibility).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicMessageDetails);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicMessageDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicMessageDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicMessageDetails other)
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
                MessageTime == other.MessageTime ||
                MessageTime != null &&
                MessageTime.Equals(other.MessageTime)
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
                Media == other.Media ||
                Media != null &&
                Media.SequenceEqual(other.Media)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
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

            if (MessageTime != null)
            {
                hash = hash * 59 + MessageTime.GetHashCode();
            }

            if (MessageStatus != null)
            {
                hash = hash * 59 + MessageStatus.GetHashCode();
            }

            if (MessageSegmentCount != null)
            {
                hash = hash * 59 + MessageSegmentCount.GetHashCode();
            }

            if (Media != null)
            {
                hash = hash * 59 + Media.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
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

            return hash;
        }
    }
}
