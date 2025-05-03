using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQueryFilter
/// </summary>

public partial class AuditQueryFilter : IEquatable<AuditQueryFilter>
{
    /// <summary>
    /// Name of the property to filter.
    /// </summary>
    /// <value>Name of the property to filter.</value>
    
    public enum PropertyEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Userid for "UserId"
        /// </summary>
        [EnumMember(Value = "UserId")]
        Userid,

        /// <summary>
        /// Enum Trusteeorganizationid for "TrusteeOrganizationId"
        /// </summary>
        [EnumMember(Value = "TrusteeOrganizationId")]
        Trusteeorganizationid,

        /// <summary>
        /// Enum Clientid for "ClientId"
        /// </summary>
        [EnumMember(Value = "ClientId")]
        Clientid,

        /// <summary>
        /// Enum Action for "Action"
        /// </summary>
        [EnumMember(Value = "Action")]
        Action,

        /// <summary>
        /// Enum Entitytype for "EntityType"
        /// </summary>
        [EnumMember(Value = "EntityType")]
        Entitytype,

        /// <summary>
        /// Enum Entityid for "EntityId"
        /// </summary>
        [EnumMember(Value = "EntityId")]
        Entityid
    }
    /// <summary>
    /// Name of the property to filter.
    /// </summary>
    /// <value>Name of the property to filter.</value>
    [JsonPropertyName("property")]
    public PropertyEnum? Property { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuditQueryFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryFilter" /> class.
    /// </summary>
    /// <param name="Property">Name of the property to filter. (required).</param>
    /// <param name="Value">Value of the property to filter. (required).</param>
    public AuditQueryFilter(PropertyEnum? Property = null, string Value = null)
    {
        this.Property = Property;
        this.Value = Value;

    }





    /// <summary>
    /// Value of the property to filter.
    /// </summary>
    /// <value>Value of the property to filter.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQueryFilter {\n");

        sb.Append("  Property: ").Append(Property).Append("\n");
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
        return Equals(obj as AuditQueryFilter);
    }

    /// <summary>
    /// Returns true if AuditQueryFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQueryFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQueryFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Property == other.Property ||
                Property != null &&
                Property.Equals(other.Property)
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
            if (Property != null)
            {
                hash = hash * 59 + Property.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
