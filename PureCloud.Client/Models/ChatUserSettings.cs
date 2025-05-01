using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for a chat user
/// </summary>
[DataContract]
public partial class ChatUserSettings : IEquatable<ChatUserSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatUserSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatUserSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatUserSettings" /> class.
    /// </summary>
    /// <param name="Mobile">Settings for mobile devices (required).</param>
    public ChatUserSettings(MobileSettings Mobile = null)
    {
        this.Mobile = Mobile;

    }



    /// <summary>
    /// Settings for mobile devices
    /// </summary>
    /// <value>Settings for mobile devices</value>
    [DataMember(Name = "mobile", EmitDefaultValue = false)]
    public MobileSettings Mobile { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatUserSettings {\n");

        sb.Append("  Mobile: ").Append(Mobile).Append("\n");
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
        return this.Equals(obj as ChatUserSettings);
    }

    /// <summary>
    /// Returns true if ChatUserSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatUserSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatUserSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Mobile == other.Mobile ||
                this.Mobile != null &&
                this.Mobile.Equals(other.Mobile)
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
            if (this.Mobile != null)
            {
                hash = hash * 59 + this.Mobile.GetHashCode();
            }

            return hash;
        }
    }
}
