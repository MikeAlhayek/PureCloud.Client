using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FilterPreviewResponse
/// </summary>
[DataContract]
public partial class FilterPreviewResponse : IEquatable<FilterPreviewResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FilterPreviewResponse" /> class.
    /// </summary>
    /// <param name="FilteredContacts">FilteredContacts.</param>
    /// <param name="TotalContacts">TotalContacts.</param>
    /// <param name="Preview">Preview.</param>
    public FilterPreviewResponse(long? FilteredContacts = null, long? TotalContacts = null, List<DialerContact> Preview = null)
    {
        this.FilteredContacts = FilteredContacts;
        this.TotalContacts = TotalContacts;
        this.Preview = Preview;

    }



    /// <summary>
    /// Gets or Sets FilteredContacts
    /// </summary>
    [DataMember(Name = "filteredContacts", EmitDefaultValue = false)]
    public long? FilteredContacts { get; set; }



    /// <summary>
    /// Gets or Sets TotalContacts
    /// </summary>
    [DataMember(Name = "totalContacts", EmitDefaultValue = false)]
    public long? TotalContacts { get; set; }



    /// <summary>
    /// Gets or Sets Preview
    /// </summary>
    [DataMember(Name = "preview", EmitDefaultValue = false)]
    public List<DialerContact> Preview { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FilterPreviewResponse {\n");

        sb.Append("  FilteredContacts: ").Append(FilteredContacts).Append("\n");
        sb.Append("  TotalContacts: ").Append(TotalContacts).Append("\n");
        sb.Append("  Preview: ").Append(Preview).Append("\n");
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
        return Equals(obj as FilterPreviewResponse);
    }

    /// <summary>
    /// Returns true if FilterPreviewResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of FilterPreviewResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FilterPreviewResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FilteredContacts == other.FilteredContacts ||
                FilteredContacts != null &&
                FilteredContacts.Equals(other.FilteredContacts)
            ) &&
            (
                TotalContacts == other.TotalContacts ||
                TotalContacts != null &&
                TotalContacts.Equals(other.TotalContacts)
            ) &&
            (
                Preview == other.Preview ||
                Preview != null &&
                Preview.SequenceEqual(other.Preview)
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
            if (FilteredContacts != null)
            {
                hash = hash * 59 + FilteredContacts.GetHashCode();
            }

            if (TotalContacts != null)
            {
                hash = hash * 59 + TotalContacts.GetHashCode();
            }

            if (Preview != null)
            {
                hash = hash * 59 + Preview.GetHashCode();
            }

            return hash;
        }
    }
}
