using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterCustomMessage
/// </summary>

public partial class SupportCenterCustomMessage : IEquatable<SupportCenterCustomMessage>
{
    /// <summary>
    /// Type of the message
    /// </summary>
    /// <value>Type of the message</value>
    
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
        /// Enum Welcome for "Welcome"
        /// </summary>
        [EnumMember(Value = "Welcome")]
        Welcome,

        /// <summary>
        /// Enum Fallback for "Fallback"
        /// </summary>
        [EnumMember(Value = "Fallback")]
        Fallback
    }
    /// <summary>
    /// Type of the message
    /// </summary>
    /// <value>Type of the message</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterCustomMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterCustomMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterCustomMessage" /> class.
    /// </summary>
    /// <param name="DefaultValue">Default value for the message (required).</param>
    /// <param name="Type">Type of the message (required).</param>
    public SupportCenterCustomMessage(string DefaultValue = null, TypeEnum? Type = null)
    {
        this.DefaultValue = DefaultValue;
        this.Type = Type;

    }



    /// <summary>
    /// Default value for the message
    /// </summary>
    /// <value>Default value for the message</value>
    [JsonPropertyName("defaultValue")]
    public string DefaultValue { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterCustomMessage {\n");

        sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
        return Equals(obj as SupportCenterCustomMessage);
    }

    /// <summary>
    /// Returns true if SupportCenterCustomMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterCustomMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterCustomMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DefaultValue == other.DefaultValue ||
                DefaultValue != null &&
                DefaultValue.Equals(other.DefaultValue)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (DefaultValue != null)
            {
                hash = hash * 59 + DefaultValue.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
