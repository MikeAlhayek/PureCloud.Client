using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicMergeOperation
/// </summary>
[DataContract]
public partial class ExternalContactsUnresolvedContactChangedTopicMergeOperation : IEquatable<ExternalContactsUnresolvedContactChangedTopicMergeOperation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicMergeOperation" /> class.
    /// </summary>
    /// <param name="SourceContactId">SourceContactId.</param>
    /// <param name="TargetContactId">TargetContactId.</param>
    /// <param name="ResultingContactId">ResultingContactId.</param>
    public ExternalContactsUnresolvedContactChangedTopicMergeOperation(string SourceContactId = null, string TargetContactId = null, string ResultingContactId = null)
    {
        this.SourceContactId = SourceContactId;
        this.TargetContactId = TargetContactId;
        this.ResultingContactId = ResultingContactId;

    }



    /// <summary>
    /// Gets or Sets SourceContactId
    /// </summary>
    [DataMember(Name = "sourceContactId", EmitDefaultValue = false)]
    public string SourceContactId { get; set; }



    /// <summary>
    /// Gets or Sets TargetContactId
    /// </summary>
    [DataMember(Name = "targetContactId", EmitDefaultValue = false)]
    public string TargetContactId { get; set; }



    /// <summary>
    /// Gets or Sets ResultingContactId
    /// </summary>
    [DataMember(Name = "resultingContactId", EmitDefaultValue = false)]
    public string ResultingContactId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicMergeOperation {\n");

        sb.Append("  SourceContactId: ").Append(SourceContactId).Append("\n");
        sb.Append("  TargetContactId: ").Append(TargetContactId).Append("\n");
        sb.Append("  ResultingContactId: ").Append(ResultingContactId).Append("\n");
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
        return Equals(obj as ExternalContactsUnresolvedContactChangedTopicMergeOperation);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicMergeOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicMergeOperation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicMergeOperation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceContactId == other.SourceContactId ||
                SourceContactId != null &&
                SourceContactId.Equals(other.SourceContactId)
            ) &&
            (
                TargetContactId == other.TargetContactId ||
                TargetContactId != null &&
                TargetContactId.Equals(other.TargetContactId)
            ) &&
            (
                ResultingContactId == other.ResultingContactId ||
                ResultingContactId != null &&
                ResultingContactId.Equals(other.ResultingContactId)
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
            if (SourceContactId != null)
            {
                hash = hash * 59 + SourceContactId.GetHashCode();
            }

            if (TargetContactId != null)
            {
                hash = hash * 59 + TargetContactId.GetHashCode();
            }

            if (ResultingContactId != null)
            {
                hash = hash * 59 + ResultingContactId.GetHashCode();
            }

            return hash;
        }
    }
}
