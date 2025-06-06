using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM email address.
/// </summary>

public partial class ScimEmail : IEquatable<ScimEmail>
{
    /// <summary>
    /// The type of email address. \"value\" is immutable if \"type\" is set to \"other\".
    /// </summary>
    /// <value>The type of email address. \"value\" is immutable if \"type\" is set to \"other\".</value>
    
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
        /// Enum Work for "work"
        /// </summary>
        [EnumMember(Value = "work")]
        Work,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
    /// <summary>
    /// The type of email address. \"value\" is immutable if \"type\" is set to \"other\".
    /// </summary>
    /// <value>The type of email address. \"value\" is immutable if \"type\" is set to \"other\".</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimEmail" /> class.
    /// </summary>
    /// <param name="Value">The email address. Is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;..</param>
    /// <param name="Type">The type of email address. \&quot;value\&quot; is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;..</param>
    /// <param name="Primary">Indicates whether the email address is the primary email address..</param>
    public ScimEmail(string Value = null, TypeEnum? Type = null, bool? Primary = null)
    {
        this.Value = Value;
        this.Type = Type;
        this.Primary = Primary;

    }



    /// <summary>
    /// The email address. Is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;.
    /// </summary>
    /// <value>The email address. Is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }





    /// <summary>
    /// Indicates whether the email address is the primary email address.
    /// </summary>
    /// <value>Indicates whether the email address is the primary email address.</value>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimEmail {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
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
        return Equals(obj as ScimEmail);
    }

    /// <summary>
    /// Returns true if ScimEmail instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimEmail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimEmail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            return hash;
        }
    }
}
