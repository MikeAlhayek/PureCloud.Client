using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQuerySort
/// </summary>

public partial class AuditQuerySort : IEquatable<AuditQuerySort>
{
    /// <summary>
    /// Name of the property to sort.
    /// </summary>
    /// <value>Name of the property to sort.</value>
    
    public enum NameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Timestamp for "Timestamp"
        /// </summary>
        [EnumMember(Value = "Timestamp")]
        Timestamp
    }
    /// <summary>
    /// Sort Order
    /// </summary>
    /// <value>Sort Order</value>
    
    public enum SortOrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ascending for "ascending"
        /// </summary>
        [EnumMember(Value = "ascending")]
        Ascending,

        /// <summary>
        /// Enum Descending for "descending"
        /// </summary>
        [EnumMember(Value = "descending")]
        Descending
    }
    /// <summary>
    /// Name of the property to sort.
    /// </summary>
    /// <value>Name of the property to sort.</value>
    [JsonPropertyName("name")]
    public NameEnum? Name { get; set; }
    /// <summary>
    /// Sort Order
    /// </summary>
    /// <value>Sort Order</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQuerySort" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuditQuerySort() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQuerySort" /> class.
    /// </summary>
    /// <param name="Name">Name of the property to sort. (required).</param>
    /// <param name="SortOrder">Sort Order (required).</param>
    public AuditQuerySort(NameEnum? Name = null, SortOrderEnum? SortOrder = null)
    {
        this.Name = Name;
        this.SortOrder = SortOrder;

    }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQuerySort {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
        return Equals(obj as AuditQuerySort);
    }

    /// <summary>
    /// Returns true if AuditQuerySort instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQuerySort to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQuerySort other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                SortOrder == other.SortOrder ||
                SortOrder != null &&
                SortOrder.Equals(other.SortOrder)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            return hash;
        }
    }
}
