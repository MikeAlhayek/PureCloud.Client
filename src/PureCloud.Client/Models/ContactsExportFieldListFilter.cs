using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactsExportFieldListFilter
/// </summary>

public partial class ContactsExportFieldListFilter : IEquatable<ContactsExportFieldListFilter>
{
    /// <summary>
    /// Field name to apply the filter
    /// </summary>
    /// <value>Field name to apply the filter</value>
    
    public enum FieldEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Divisionid for "DivisionId"
        /// </summary>
        [EnumMember(Value = "DivisionId")]
        Divisionid,

        /// <summary>
        /// Enum Contactclassification for "ContactClassification"
        /// </summary>
        [EnumMember(Value = "ContactClassification")]
        Contactclassification,

        /// <summary>
        /// Enum Externalorganizationid for "ExternalOrganizationId"
        /// </summary>
        [EnumMember(Value = "ExternalOrganizationId")]
        Externalorganizationid
    }
    /// <summary>
    /// Field name to apply the filter
    /// </summary>
    /// <value>Field name to apply the filter</value>
    [JsonPropertyName("field")]
    public FieldEnum? Field { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsExportFieldListFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactsExportFieldListFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsExportFieldListFilter" /> class.
    /// </summary>
    /// <param name="Field">Field name to apply the filter (required).</param>
    /// <param name="Values">Values to check field&#39;s value against (required).</param>
    public ContactsExportFieldListFilter(FieldEnum? Field = null, List<string> Values = null)
    {
        this.Field = Field;
        this.Values = Values;

    }





    /// <summary>
    /// Values to check field&#39;s value against
    /// </summary>
    /// <value>Values to check field&#39;s value against</value>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactsExportFieldListFilter {\n");

        sb.Append("  Field: ").Append(Field).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as ContactsExportFieldListFilter);
    }

    /// <summary>
    /// Returns true if ContactsExportFieldListFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactsExportFieldListFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactsExportFieldListFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Field == other.Field ||
                Field != null &&
                Field.Equals(other.Field)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (Field != null)
            {
                hash = hash * 59 + Field.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
