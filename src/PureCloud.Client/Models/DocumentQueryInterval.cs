using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentQueryInterval
/// </summary>

public partial class DocumentQueryInterval : IEquatable<DocumentQueryInterval>
{
    /// <summary>
    /// Specifies the date field to be used for date and time range.
    /// </summary>
    /// <value>Specifies the date field to be used for date and time range.</value>
    
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
        /// Enum Datecreated for "dateCreated"
        /// </summary>
        [EnumMember(Value = "dateCreated")]
        Datecreated,

        /// <summary>
        /// Enum Datemodified for "dateModified"
        /// </summary>
        [EnumMember(Value = "dateModified")]
        Datemodified,

        /// <summary>
        /// Enum Datepublished for "datePublished"
        /// </summary>
        [EnumMember(Value = "datePublished")]
        Datepublished
    }
    /// <summary>
    /// Specifies the date field to be used for date and time range.
    /// </summary>
    /// <value>Specifies the date field to be used for date and time range.</value>
    [JsonPropertyName("field")]
    public FieldEnum? Field { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentQueryInterval" /> class.
    /// </summary>
    /// <param name="Field">Specifies the date field to be used for date and time range..</param>
    /// <param name="Value">Specifies the date and time range for filtering the documents. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    public DocumentQueryInterval(FieldEnum? Field = null, string Value = null)
    {
        this.Field = Field;
        this.Value = Value;

    }





    /// <summary>
    /// Specifies the date and time range for filtering the documents. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the date and time range for filtering the documents. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentQueryInterval {\n");

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
        return Equals(obj as DocumentQueryInterval);
    }

    /// <summary>
    /// Returns true if DocumentQueryInterval instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentQueryInterval to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentQueryInterval other)
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
