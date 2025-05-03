using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel
/// </summary>

public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel : IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel>
{
    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    
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
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms,

        /// <summary>
        /// Enum Apple for "Apple"
        /// </summary>
        [EnumMember(Value = "Apple")]
        Apple
    }
    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [JsonPropertyName("platform")]
    public PlatformEnum? Platform { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Platform">Platform.</param>
    /// <param name="To">To.</param>
    /// <param name="From">From.</param>
    /// <param name="Time">Time.</param>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel(string Id = null, PlatformEnum? Platform = null, V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingToRecipient To = null, V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingFromRecipient From = null, DateTime? Time = null)
    {
        this.Id = Id;
        this.Platform = Platform;
        this.To = To;
        this.From = From;
        this.Time = Time;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [JsonPropertyName("to")]
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingToRecipient To { get; set; }



    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [JsonPropertyName("from")]
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingFromRecipient From { get; set; }



    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
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
        return Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel);
    }

    /// <summary>
    /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingChannel other)
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

            return hash;
        }
    }
}
