using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Metadata information about a message content.
/// </summary>

public partial class ConversationMessageMetadataContent : IEquatable<ConversationMessageMetadataContent>
{
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Reactions for "Reactions"
        /// </summary>
        [EnumMember(Value = "Reactions")]
        Reactions,

        /// <summary>
        /// Enum Attachment for "Attachment"
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment,

        /// <summary>
        /// Enum Location for "Location"
        /// </summary>
        [EnumMember(Value = "Location")]
        Location,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Notification for "Notification"
        /// </summary>
        [EnumMember(Value = "Notification")]
        Notification,

        /// <summary>
        /// Enum Buttonresponse for "ButtonResponse"
        /// </summary>
        [EnumMember(Value = "ButtonResponse")]
        Buttonresponse,

        /// <summary>
        /// Enum Story for "Story"
        /// </summary>
        [EnumMember(Value = "Story")]
        Story,

        /// <summary>
        /// Enum Mention for "Mention"
        /// </summary>
        [EnumMember(Value = "Mention")]
        Mention,

        /// <summary>
        /// Enum Card for "Card"
        /// </summary>
        [EnumMember(Value = "Card")]
        Card,

        /// <summary>
        /// Enum Carousel for "Carousel"
        /// </summary>
        [EnumMember(Value = "Carousel")]
        Carousel,

        /// <summary>
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// Enum Quickreplyv2 for "QuickReplyV2"
        /// </summary>
        [EnumMember(Value = "QuickReplyV2")]
        Quickreplyv2,

        /// <summary>
        /// Enum Datepicker for "DatePicker"
        /// </summary>
        [EnumMember(Value = "DatePicker")]
        Datepicker,

        /// <summary>
        /// Enum Interactiveapplication for "InteractiveApplication"
        /// </summary>
        [EnumMember(Value = "InteractiveApplication")]
        Interactiveapplication,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Content subtype
    /// </summary>
    /// <value>Content subtype</value>
    
    public enum SubTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Image for "Image"
        /// </summary>
        [EnumMember(Value = "Image")]
        Image,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video,

        /// <summary>
        /// Enum Audio for "Audio"
        /// </summary>
        [EnumMember(Value = "Audio")]
        Audio,

        /// <summary>
        /// Enum File for "File"
        /// </summary>
        [EnumMember(Value = "File")]
        File,

        /// <summary>
        /// Enum Link for "Link"
        /// </summary>
        [EnumMember(Value = "Link")]
        Link,

        /// <summary>
        /// Enum Mention for "Mention"
        /// </summary>
        [EnumMember(Value = "Mention")]
        Mention,

        /// <summary>
        /// Enum Reply for "Reply"
        /// </summary>
        [EnumMember(Value = "Reply")]
        Reply,

        /// <summary>
        /// Enum Button for "Button"
        /// </summary>
        [EnumMember(Value = "Button")]
        Button,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Postback for "Postback"
        /// </summary>
        [EnumMember(Value = "Postback")]
        Postback,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }
    /// <summary>
    /// Content subtype
    /// </summary>
    /// <value>Content subtype</value>
    [JsonPropertyName("subType")]
    public SubTypeEnum? SubType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageMetadataContent" /> class.
    /// </summary>
    /// <param name="ContentType">Type of this content element..</param>
    /// <param name="SubType">Content subtype.</param>
    public ConversationMessageMetadataContent(ContentTypeEnum? ContentType = null, SubTypeEnum? SubType = null)
    {
        this.ContentType = ContentType;
        this.SubType = SubType;

    }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessageMetadataContent {\n");

        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  SubType: ").Append(SubType).Append("\n");
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
        return Equals(obj as ConversationMessageMetadataContent);
    }

    /// <summary>
    /// Returns true if ConversationMessageMetadataContent instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessageMetadataContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessageMetadataContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                SubType == other.SubType ||
                SubType != null &&
                SubType.Equals(other.SubType)
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
            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (SubType != null)
            {
                hash = hash * 59 + SubType.GetHashCode();
            }

            return hash;
        }
    }
}
