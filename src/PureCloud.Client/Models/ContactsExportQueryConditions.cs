using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactsExportQueryConditions
/// </summary>

public partial class ContactsExportQueryConditions : IEquatable<ContactsExportQueryConditions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsExportQueryConditions" /> class.
    /// </summary>
    /// <param name="Filters">Filters to apply on export.</param>
    /// <param name="Limit">Maximum result count in export, default is 180 000 000.</param>
    public ContactsExportQueryConditions(ContactsExportFilter Filters = null, int? Limit = null)
    {
        this.Filters = Filters;
        this.Limit = Limit;

    }



    /// <summary>
    /// Filters to apply on export
    /// </summary>
    /// <value>Filters to apply on export</value>
    [JsonPropertyName("filters")]
    public ContactsExportFilter Filters { get; set; }



    /// <summary>
    /// Maximum result count in export, default is 180 000 000
    /// </summary>
    /// <value>Maximum result count in export, default is 180 000 000</value>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactsExportQueryConditions {\n");

        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("  Limit: ").Append(Limit).Append("\n");
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
        return Equals(obj as ContactsExportQueryConditions);
    }

    /// <summary>
    /// Returns true if ContactsExportQueryConditions instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactsExportQueryConditions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactsExportQueryConditions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.Equals(other.Filters)
            ) &&
            (
                Limit == other.Limit ||
                Limit != null &&
                Limit.Equals(other.Limit)
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
            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            if (Limit != null)
            {
                hash = hash * 59 + Limit.GetHashCode();
            }

            return hash;
        }
    }
}
