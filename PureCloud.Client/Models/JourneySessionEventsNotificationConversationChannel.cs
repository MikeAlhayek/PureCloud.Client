using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationConversationChannel
/// </summary>

public partial class JourneySessionEventsNotificationConversationChannel : IEquatable<JourneySessionEventsNotificationConversationChannel>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Cobrowse for "Cobrowse"
        /// </summary>
        [EnumMember(Value = "Cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video,

        /// <summary>
        /// Enum Screenshare for "Screenshare"
        /// </summary>
        [EnumMember(Value = "Screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Internalmessage for "InternalMessage"
        /// </summary>
        [EnumMember(Value = "InternalMessage")]
        Internalmessage
    }
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    
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
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

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
        /// Enum Webmessaging for "WebMessaging"
        /// </summary>
        [EnumMember(Value = "WebMessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Instagram for "Instagram"
        /// </summary>
        [EnumMember(Value = "Instagram")]
        Instagram
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    [JsonPropertyName("messageType")]
    public MessageTypeEnum? MessageType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationConversationChannel" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="MessageType">MessageType.</param>
    /// <param name="Platform">Platform.</param>
    public JourneySessionEventsNotificationConversationChannel(TypeEnum? Type = null, MessageTypeEnum? MessageType = null, string Platform = null)
    {
        this.Type = Type;
        this.MessageType = MessageType;
        this.Platform = Platform;

    }







    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [JsonPropertyName("platform")]
    public string Platform { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationConversationChannel {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
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
        return Equals(obj as JourneySessionEventsNotificationConversationChannel);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationConversationChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationConversationChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationConversationChannel other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
            ) &&
            (
                Platform == other.Platform ||
                Platform != null &&
                Platform.Equals(other.Platform)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (Platform != null)
            {
                hash = hash * 59 + Platform.GetHashCode();
            }

            return hash;
        }
    }
}
