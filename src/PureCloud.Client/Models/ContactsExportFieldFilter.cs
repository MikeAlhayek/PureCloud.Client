using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactsExportFieldFilter
/// </summary>

public partial class ContactsExportFieldFilter : IEquatable<ContactsExportFieldFilter>
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
    /// Initializes a new instance of the <see cref="ContactsExportFieldFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactsExportFieldFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsExportFieldFilter" /> class.
    /// </summary>
    /// <param name="Field">Field name to apply the filter (required).</param>
    /// <param name="Value">Value to check field&#39;s value against (required).</param>
    public ContactsExportFieldFilter(FieldEnum? Field = null, string Value = null)
    {
        this.Field = Field;
        this.Value = Value;

    }





    /// <summary>
    /// Value to check field&#39;s value against
    /// </summary>
    /// <value>Value to check field&#39;s value against</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactsExportFieldFilter {\n");

        sb.Append("  Field: ").Append(Field).Append("\n");
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
        return Equals(obj as ContactsExportFieldFilter);
    }

    /// <summary>
    /// Returns true if ContactsExportFieldFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactsExportFieldFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactsExportFieldFilter other)
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
            if (Field != null)
            {
                hash = hash * 59 + Field.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
