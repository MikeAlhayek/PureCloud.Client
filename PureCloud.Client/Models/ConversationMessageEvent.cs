using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message event element.  Examples include: system messages, typing indicators, cobrowse offerings.
/// </summary>
[DataContract]
public partial class ConversationMessageEvent : IEquatable<ConversationMessageEvent>
{
    /// <summary>
    /// Type of this event element
    /// </summary>
    /// <value>Type of this event element</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EventTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Cobrowse for "CoBrowse"
        /// </summary>
        [EnumMember(Value = "CoBrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Typing for "Typing"
        /// </summary>
        [EnumMember(Value = "Typing")]
        Typing,

        /// <summary>
        /// Enum Presence for "Presence"
        /// </summary>
        [EnumMember(Value = "Presence")]
        Presence,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Type of this event element
    /// </summary>
    /// <value>Type of this event element</value>
    [DataMember(Name = "eventType", EmitDefaultValue = false)]
    public EventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationMessageEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageEvent" /> class.
    /// </summary>
    /// <param name="EventType">Type of this event element (required).</param>
    /// <param name="CoBrowse">CoBrowse event..</param>
    /// <param name="Typing">Typing event..</param>
    /// <param name="Presence">Presence event..</param>
    /// <param name="Video">Video event..</param>
    public ConversationMessageEvent(EventTypeEnum? EventType = null, ConversationEventCoBrowse CoBrowse = null, ConversationEventTyping Typing = null, ConversationEventPresence Presence = null, ConversationEventVideo Video = null)
    {
        this.EventType = EventType;
        this.CoBrowse = CoBrowse;
        this.Typing = Typing;
        this.Presence = Presence;
        this.Video = Video;

    }





    /// <summary>
    /// CoBrowse event.
    /// </summary>
    /// <value>CoBrowse event.</value>
    [DataMember(Name = "coBrowse", EmitDefaultValue = false)]
    public ConversationEventCoBrowse CoBrowse { get; set; }



    /// <summary>
    /// Typing event.
    /// </summary>
    /// <value>Typing event.</value>
    [DataMember(Name = "typing", EmitDefaultValue = false)]
    public ConversationEventTyping Typing { get; set; }



    /// <summary>
    /// Presence event.
    /// </summary>
    /// <value>Presence event.</value>
    [DataMember(Name = "presence", EmitDefaultValue = false)]
    public ConversationEventPresence Presence { get; set; }



    /// <summary>
    /// Video event.
    /// </summary>
    /// <value>Video event.</value>
    [DataMember(Name = "video", EmitDefaultValue = false)]
    public ConversationEventVideo Video { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessageEvent {\n");

        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  CoBrowse: ").Append(CoBrowse).Append("\n");
        sb.Append("  Typing: ").Append(Typing).Append("\n");
        sb.Append("  Presence: ").Append(Presence).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
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
        return this.Equals(obj as ConversationMessageEvent);
    }

    /// <summary>
    /// Returns true if ConversationMessageEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessageEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessageEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.EventType == other.EventType ||
                this.EventType != null &&
                this.EventType.Equals(other.EventType)
            ) &&
            (
                this.CoBrowse == other.CoBrowse ||
                this.CoBrowse != null &&
                this.CoBrowse.Equals(other.CoBrowse)
            ) &&
            (
                this.Typing == other.Typing ||
                this.Typing != null &&
                this.Typing.Equals(other.Typing)
            ) &&
            (
                this.Presence == other.Presence ||
                this.Presence != null &&
                this.Presence.Equals(other.Presence)
            ) &&
            (
                this.Video == other.Video ||
                this.Video != null &&
                this.Video.Equals(other.Video)
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
            if (this.EventType != null)
            {
                hash = hash * 59 + this.EventType.GetHashCode();
            }

            if (this.CoBrowse != null)
            {
                hash = hash * 59 + this.CoBrowse.GetHashCode();
            }

            if (this.Typing != null)
            {
                hash = hash * 59 + this.Typing.GetHashCode();
            }

            if (this.Presence != null)
            {
                hash = hash * 59 + this.Presence.GetHashCode();
            }

            if (this.Video != null)
            {
                hash = hash * 59 + this.Video.GetHashCode();
            }

            return hash;
        }
    }
}
