using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactAddressTypeConditionSettings
/// </summary>

public partial class ContactAddressTypeConditionSettings : IEquatable<ContactAddressTypeConditionSettings>
{
    /// <summary>
    /// The operator to use when comparing the address types.
    /// </summary>
    /// <value>The operator to use when comparing the address types.</value>
    
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Equals for "Equals"
        /// </summary>
        [EnumMember(Value = "Equals")]
        Equals,

        /// <summary>
        /// Enum Contains for "Contains"
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains,

        /// <summary>
        /// Enum Beginswith for "BeginsWith"
        /// </summary>
        [EnumMember(Value = "BeginsWith")]
        Beginswith,

        /// <summary>
        /// Enum Endswith for "EndsWith"
        /// </summary>
        [EnumMember(Value = "EndsWith")]
        Endswith
    }
    /// <summary>
    /// The operator to use when comparing the address types.
    /// </summary>
    /// <value>The operator to use when comparing the address types.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactAddressTypeConditionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactAddressTypeConditionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactAddressTypeConditionSettings" /> class.
    /// </summary>
    /// <param name="Operator">The operator to use when comparing the address types. (required).</param>
    /// <param name="Value">The type value to compare against the contact column type. (required).</param>
    public ContactAddressTypeConditionSettings(OperatorEnum? Operator = null, string Value = null)
    {
        this.Operator = Operator;
        this.Value = Value;

    }





    /// <summary>
    /// The type value to compare against the contact column type.
    /// </summary>
    /// <value>The type value to compare against the contact column type.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactAddressTypeConditionSettings {\n");

        sb.Append("  Operator: ").Append(Operator).Append("\n");
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
        return Equals(obj as ContactAddressTypeConditionSettings);
    }

    /// <summary>
    /// Returns true if ContactAddressTypeConditionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactAddressTypeConditionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactAddressTypeConditionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
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
            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
