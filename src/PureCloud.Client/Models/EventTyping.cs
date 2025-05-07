using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A Typing event.
/// </summary>

public partial class EventTyping : IEquatable<EventTyping>
{
    /// <summary>
    /// Describes the type of Typing event.
    /// </summary>
    /// <value>Describes the type of Typing event.</value>
    
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
        /// Enum On for "On"
        /// </summary>
        [EnumMember(Value = "On")]
        On
    }
    /// <summary>
    /// Describes the type of Typing event.
    /// </summary>
    /// <value>Describes the type of Typing event.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventTyping" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EventTyping() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventTyping" /> class.
    /// </summary>
    /// <param name="Type">Describes the type of Typing event. (required).</param>
    public EventTyping(TypeEnum? Type = null)
    {
        this.Type = Type;

    }





    /// <summary>
    /// The duration of the Typing event in milliseconds.
    /// </summary>
    /// <value>The duration of the Typing event in milliseconds.</value>
    [JsonPropertyName("duration")]
    public long? Duration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventTyping {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Duration: ").Append(Duration).Append("\n");
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
        return Equals(obj as EventTyping);
    }

    /// <summary>
    /// Returns true if EventTyping instances are equal
    /// </summary>
    /// <param name="other">Instance of EventTyping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventTyping other)
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
                Duration == other.Duration ||
                Duration != null &&
                Duration.Equals(other.Duration)
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

            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            return hash;
        }
    }
}
