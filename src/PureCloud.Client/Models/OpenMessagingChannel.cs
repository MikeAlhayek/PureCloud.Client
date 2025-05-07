using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Channel-specific information that describes the message and the message channel/provider.
/// </summary>

public partial class OpenMessagingChannel : IEquatable<OpenMessagingChannel>
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
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open
    }
    /// <summary>
    /// Specifies if this message is part of a private or public conversation.
    /// </summary>
    /// <value>Specifies if this message is part of a private or public conversation.</value>
    
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
        /// Enum Private for "Private"
        /// </summary>
        [EnumMember(Value = "Private")]
        Private
    }
    /// <summary>
    /// The provider type.
    /// </summary>
    /// <value>The provider type.</value>
    [JsonPropertyName("platform")]
    public PlatformEnum? Platform { get; set; }
    /// <summary>
    /// Specifies if this message is part of a private or public conversation.
    /// </summary>
    /// <value>Specifies if this message is part of a private or public conversation.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingChannel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenMessagingChannel() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingChannel" /> class.
    /// </summary>
    /// <param name="Type">Specifies if this message is part of a private or public conversation..</param>
    /// <param name="MessageId">Unique provider ID of the message such as a Facebook message ID..</param>
    /// <param name="To">Information about the recipient the message is sent to. (required).</param>
    /// <param name="From">Information about the recipient the message is received from. (required).</param>
    /// <param name="Time">Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Metadata">Information about the channel..</param>
    public OpenMessagingChannel(TypeEnum? Type = null, string MessageId = null, OpenMessagingToRecipient To = null, OpenMessagingFromRecipient From = null, DateTime? Time = null, object Metadata = null)
    {
        this.Type = Type;
        this.MessageId = MessageId;
        this.To = To;
        this.From = From;
        this.Time = Time;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The Messaging Platform integration ID.
    /// </summary>
    /// <value>The Messaging Platform integration ID.</value>
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
    public OpenMessagingToRecipient To { get; set; }



    /// <summary>
    /// Information about the recipient the message is received from.
    /// </summary>
    /// <value>Information about the recipient the message is received from.</value>
    [JsonPropertyName("from")]
    public OpenMessagingFromRecipient From { get; set; }



    /// <summary>
    /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Information about the channel.
    /// </summary>
    /// <value>Information about the channel.</value>
    [JsonPropertyName("metadata")]
    public object Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenMessagingChannel {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as OpenMessagingChannel);
    }

    /// <summary>
    /// Returns true if OpenMessagingChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenMessagingChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenMessagingChannel other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
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

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
