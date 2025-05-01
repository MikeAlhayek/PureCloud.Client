using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage
/// </summary>
[DataContract]
public partial class V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage : IEquatable<V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Event for "Event"
        /// </summary>
        [EnumMember(Value = "Event")]
        Event
    }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
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
        /// Enum Inbound for "Inbound"
        /// </summary>
        [EnumMember(Value = "Inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "Outbound"
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage" /> class.
    /// </summary>
    /// <param name="Channel">Channel.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Events">Events.</param>
    /// <param name="Direction">Direction.</param>
    public V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage(V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel Channel = null, TypeEnum? Type = null, List<V2ConversationMessageTypingEventForUserTopicConversationMessageEvent> Events = null, DirectionEnum? Direction = null)
    {
        this.Channel = Channel;
        this.Type = Type;
        this.Events = Events;
        this.Direction = Direction;

    }



    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    [DataMember(Name = "channel", EmitDefaultValue = false)]
    public V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel Channel { get; set; }





    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    [DataMember(Name = "events", EmitDefaultValue = false)]
    public List<V2ConversationMessageTypingEventForUserTopicConversationMessageEvent> Events { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage {\n");

        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
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
        return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage);
    }

    /// <summary>
    /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Channel == other.Channel ||
                this.Channel != null &&
                this.Channel.Equals(other.Channel)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Events == other.Events ||
                this.Events != null &&
                this.Events.SequenceEqual(other.Events)
            ) &&
            (
                this.Direction == other.Direction ||
                this.Direction != null &&
                this.Direction.Equals(other.Direction)
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
            if (this.Channel != null)
            {
                hash = hash * 59 + this.Channel.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Events != null)
            {
                hash = hash * 59 + this.Events.GetHashCode();
            }

            if (this.Direction != null)
            {
                hash = hash * 59 + this.Direction.GetHashCode();
            }

            return hash;
        }
    }
}
