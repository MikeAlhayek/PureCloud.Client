using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MergeOperation
/// </summary>

public partial class MergeOperation : IEquatable<MergeOperation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MergeOperation" /> class.
    /// </summary>
    public MergeOperation()
    {

    }



    /// <summary>
    /// The source contact for the merge operation
    /// </summary>
    /// <value>The source contact for the merge operation</value>
    [JsonPropertyName("sourceContact")]
    public AddressableEntityRef SourceContact { get; set; }



    /// <summary>
    /// The target contact for the merge operation
    /// </summary>
    /// <value>The target contact for the merge operation</value>
    [JsonPropertyName("targetContact")]
    public AddressableEntityRef TargetContact { get; set; }



    /// <summary>
    /// The contact created as a result of the merge operation
    /// </summary>
    /// <value>The contact created as a result of the merge operation</value>
    [JsonPropertyName("resultingContact")]
    public AddressableEntityRef ResultingContact { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MergeOperation {\n");

        sb.Append("  SourceContact: ").Append(SourceContact).Append("\n");
        sb.Append("  TargetContact: ").Append(TargetContact).Append("\n");
        sb.Append("  ResultingContact: ").Append(ResultingContact).Append("\n");
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
        return Equals(obj as MergeOperation);
    }

    /// <summary>
    /// Returns true if MergeOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of MergeOperation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MergeOperation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceContact == other.SourceContact ||
                SourceContact != null &&
                SourceContact.Equals(other.SourceContact)
            ) &&
            (
                TargetContact == other.TargetContact ||
                TargetContact != null &&
                TargetContact.Equals(other.TargetContact)
            ) &&
            (
                ResultingContact == other.ResultingContact ||
                ResultingContact != null &&
                ResultingContact.Equals(other.ResultingContact)
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
            if (SourceContact != null)
            {
                hash = hash * 59 + SourceContact.GetHashCode();
            }

            if (TargetContact != null)
            {
                hash = hash * 59 + TargetContact.GetHashCode();
            }

            if (ResultingContact != null)
            {
                hash = hash * 59 + ResultingContact.GetHashCode();
            }

            return hash;
        }
    }
}
