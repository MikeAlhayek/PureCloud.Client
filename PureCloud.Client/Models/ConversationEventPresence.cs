using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A Presence event.
/// </summary>
[DataContract]
public partial class ConversationEventPresence : IEquatable<ConversationEventPresence>
{
    /// <summary>
    /// Describes the type of Presence event.
    /// </summary>
    /// <value>Describes the type of Presence event.</value>
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
        /// Enum Join for "Join"
        /// </summary>
        [EnumMember(Value = "Join")]
        Join,

        /// <summary>
        /// Enum Disconnect for "Disconnect"
        /// </summary>
        [EnumMember(Value = "Disconnect")]
        Disconnect,

        /// <summary>
        /// Enum Clear for "Clear"
        /// </summary>
        [EnumMember(Value = "Clear")]
        Clear,

        /// <summary>
        /// Enum Signin for "SignIn"
        /// </summary>
        [EnumMember(Value = "SignIn")]
        Signin,

        /// <summary>
        /// Enum Sessionexpired for "SessionExpired"
        /// </summary>
        [EnumMember(Value = "SessionExpired")]
        Sessionexpired
    }
    /// <summary>
    /// Describes the type of Presence event.
    /// </summary>
    /// <value>Describes the type of Presence event.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventPresence" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationEventPresence() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventPresence" /> class.
    /// </summary>
    /// <param name="Type">Describes the type of Presence event. (required).</param>
    public ConversationEventPresence(TypeEnum? Type = null)
    {
        this.Type = Type;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventPresence {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return this.Equals(obj as ConversationEventPresence);
    }

    /// <summary>
    /// Returns true if ConversationEventPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventPresence other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            return hash;
        }
    }
}
