using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Channel-specific information that describes the message and the message channel/provider.
/// </summary>

public partial class ConversationMessagingChannel : IEquatable<ConversationMessagingChannel>
{
    /// <summary>
    /// The provider type.
    /// </summary>
    /// <value>The provider type.</value>
    
    public enum PlatformEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

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
        /// Enum Instagram for "Instagram"
        /// </summary>
        [EnumMember(Value = "Instagram")]
        Instagram,

        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line,

        /// <summary>
        /// Enum Whatsapp for "Whatsapp"
        /// </summary>
        [EnumMember(Value = "Whatsapp")]
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
        /// Enum Apple for "Apple"
        /// </summary>
        [EnumMember(Value = "Apple")]
        Apple,

        /// <summary>
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms
    }
    /// <summary>
    /// The provider type.
    /// </summary>
    /// <value>The provider type.</value>
    [JsonPropertyName("platform")]
    public PlatformEnum? Platform { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessagingChannel" /> class.
    /// </summary>
    public ConversationMessagingChannel()
    {

    }



    /// <summary>
    /// The integration ID.
    /// </summary>
    /// <value>The integration ID.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Unique provider ID of the message such as a Facebook message ID.
    /// </summary>
    /// <value>Unique provider ID of the message such as a Facebook message ID.</value>
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }



    /// <summary>
    /// Information about the recipient the message is sent to.
    /// </summary>
    /// <value>Information about the recipient the message is sent to.</value>
    [JsonPropertyName("to")]
    public ConversationMessagingToRecipient To { get; set; }



    /// <summary>
    /// Information about the recipient the message is received from.
    /// </summary>
    /// <value>Information about the recipient the message is received from.</value>
    [JsonPropertyName("from")]
    public ConversationMessagingFromRecipient From { get; set; }



    /// <summary>
    /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Time the message was edited. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Time the message was edited. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Time the message was deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Time the message was deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateDeleted")]
    public DateTime? DateDeleted { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessagingChannel {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
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
        return Equals(obj as ConversationMessagingChannel);
    }

    /// <summary>
    /// Returns true if ConversationMessagingChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessagingChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessagingChannel other)
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
                Platform == other.Platform ||
                Platform != null &&
                Platform.Equals(other.Platform)
            ) &&
            (
                MessageId == other.MessageId ||
                MessageId != null &&
                MessageId.Equals(other.MessageId)
            ) &&
            (
                To == other.To ||
                To != null &&
                To.Equals(other.To)
            ) &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
            ) &&
            (
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateDeleted == other.DateDeleted ||
                DateDeleted != null &&
                DateDeleted.Equals(other.DateDeleted)
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

            if (Platform != null)
            {
                hash = hash * 59 + Platform.GetHashCode();
            }

            if (MessageId != null)
            {
                hash = hash * 59 + MessageId.GetHashCode();
            }

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateDeleted != null)
            {
                hash = hash * 59 + DateDeleted.GetHashCode();
            }

            return hash;
        }
    }
}
