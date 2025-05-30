using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialHandle
/// </summary>

public partial class SocialHandle : IEquatable<SocialHandle>
{
    /// <summary>
    /// Social Handle Type
    /// </summary>
    /// <value>Social Handle Type</value>
    
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
        /// Enum Twitter for "TWITTER"
        /// </summary>
        [EnumMember(Value = "TWITTER")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "FACEBOOK"
        /// </summary>
        [EnumMember(Value = "FACEBOOK")]
        Facebook,

        /// <summary>
        /// Enum Instagram for "INSTAGRAM"
        /// </summary>
        [EnumMember(Value = "INSTAGRAM")]
        Instagram
    }
    /// <summary>
    /// Social Handle Type
    /// </summary>
    /// <value>Social Handle Type</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialHandle" /> class.
    /// </summary>
    /// <param name="Type">Social Handle Type.</param>
    /// <param name="Value">Value.</param>
    public SocialHandle(TypeEnum? Type = null, string Value = null)
    {
        this.Type = Type;
        this.Value = Value;

    }





    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialHandle {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as SocialHandle);
    }

    /// <summary>
    /// Returns true if SocialHandle instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialHandle to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialHandle other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
