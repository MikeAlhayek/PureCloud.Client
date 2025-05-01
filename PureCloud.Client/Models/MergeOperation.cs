using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MergeOperation
/// </summary>
[DataContract]
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
    [DataMember(Name = "sourceContact", EmitDefaultValue = false)]
    public AddressableEntityRef SourceContact { get; private set; }



    /// <summary>
    /// The target contact for the merge operation
    /// </summary>
    /// <value>The target contact for the merge operation</value>
    [DataMember(Name = "targetContact", EmitDefaultValue = false)]
    public AddressableEntityRef TargetContact { get; private set; }



    /// <summary>
    /// The contact created as a result of the merge operation
    /// </summary>
    /// <value>The contact created as a result of the merge operation</value>
    [DataMember(Name = "resultingContact", EmitDefaultValue = false)]
    public AddressableEntityRef ResultingContact { get; private set; }


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
        return this.Equals(obj as MergeOperation);
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
                this.SourceContact == other.SourceContact ||
                this.SourceContact != null &&
                this.SourceContact.Equals(other.SourceContact)
            ) &&
            (
                this.TargetContact == other.TargetContact ||
                this.TargetContact != null &&
                this.TargetContact.Equals(other.TargetContact)
            ) &&
            (
                this.ResultingContact == other.ResultingContact ||
                this.ResultingContact != null &&
                this.ResultingContact.Equals(other.ResultingContact)
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
            if (this.SourceContact != null)
            {
                hash = hash * 59 + this.SourceContact.GetHashCode();
            }

            if (this.TargetContact != null)
            {
                hash = hash * 59 + this.TargetContact.GetHashCode();
            }

            if (this.ResultingContact != null)
            {
                hash = hash * 59 + this.ResultingContact.GetHashCode();
            }

            return hash;
        }
    }
}
