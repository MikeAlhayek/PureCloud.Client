using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MergeContactsRequest
/// </summary>
[DataContract]
public partial class MergeContactsRequest : IEquatable<MergeContactsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MergeContactsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MergeContactsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MergeContactsRequest" /> class.
    /// </summary>
    /// <param name="ContactIds">The IDs of all contacts involved in the merge operation (must be between 2 and 25). (required).</param>
    /// <param name="ValueOverride">Override data to set for specific Contact fields after a merge. Any null fields in &#x60;valueOverride&#x60; will not replace existing data..</param>
    public MergeContactsRequest(List<string> ContactIds = null, ExternalContact ValueOverride = null)
    {
        this.ContactIds = ContactIds;
        this.ValueOverride = ValueOverride;

    }



    /// <summary>
    /// The IDs of all contacts involved in the merge operation (must be between 2 and 25).
    /// </summary>
    /// <value>The IDs of all contacts involved in the merge operation (must be between 2 and 25).</value>
    [DataMember(Name = "contactIds", EmitDefaultValue = false)]
    public List<string> ContactIds { get; set; }



    /// <summary>
    /// Override data to set for specific Contact fields after a merge. Any null fields in &#x60;valueOverride&#x60; will not replace existing data.
    /// </summary>
    /// <value>Override data to set for specific Contact fields after a merge. Any null fields in &#x60;valueOverride&#x60; will not replace existing data.</value>
    [DataMember(Name = "valueOverride", EmitDefaultValue = false)]
    public ExternalContact ValueOverride { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MergeContactsRequest {\n");

        sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
        sb.Append("  ValueOverride: ").Append(ValueOverride).Append("\n");
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
        return Equals(obj as MergeContactsRequest);
    }

    /// <summary>
    /// Returns true if MergeContactsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MergeContactsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MergeContactsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactIds == other.ContactIds ||
                ContactIds != null &&
                ContactIds.SequenceEqual(other.ContactIds)
            ) &&
            (
                ValueOverride == other.ValueOverride ||
                ValueOverride != null &&
                ValueOverride.Equals(other.ValueOverride)
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
            if (ContactIds != null)
            {
                hash = hash * 59 + ContactIds.GetHashCode();
            }

            if (ValueOverride != null)
            {
                hash = hash * 59 + ValueOverride.GetHashCode();
            }

            return hash;
        }
    }
}
