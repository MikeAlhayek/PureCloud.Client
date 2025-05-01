using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LabelUtilizationResponse
/// </summary>
[DataContract]
public partial class LabelUtilizationResponse : IEquatable<LabelUtilizationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LabelUtilizationResponse" /> class.
    /// </summary>
    /// <param name="MaximumCapacity">Defines the maximum number of interactions with this label that an agent can handle at one time..</param>
    /// <param name="InterruptingLabelIds">Defines other labels that can interrupt an interaction with this label..</param>
    /// <param name="LabelName">Name of the label this utilization relates to..</param>
    public LabelUtilizationResponse(int? MaximumCapacity = null, List<string> InterruptingLabelIds = null, string LabelName = null)
    {
        this.MaximumCapacity = MaximumCapacity;
        this.InterruptingLabelIds = InterruptingLabelIds;
        this.LabelName = LabelName;

    }



    /// <summary>
    /// Defines the maximum number of interactions with this label that an agent can handle at one time.
    /// </summary>
    /// <value>Defines the maximum number of interactions with this label that an agent can handle at one time.</value>
    [DataMember(Name = "maximumCapacity", EmitDefaultValue = false)]
    public int? MaximumCapacity { get; set; }



    /// <summary>
    /// Defines other labels that can interrupt an interaction with this label.
    /// </summary>
    /// <value>Defines other labels that can interrupt an interaction with this label.</value>
    [DataMember(Name = "interruptingLabelIds", EmitDefaultValue = false)]
    public List<string> InterruptingLabelIds { get; set; }



    /// <summary>
    /// Name of the label this utilization relates to.
    /// </summary>
    /// <value>Name of the label this utilization relates to.</value>
    [DataMember(Name = "labelName", EmitDefaultValue = false)]
    public string LabelName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LabelUtilizationResponse {\n");

        sb.Append("  MaximumCapacity: ").Append(MaximumCapacity).Append("\n");
        sb.Append("  InterruptingLabelIds: ").Append(InterruptingLabelIds).Append("\n");
        sb.Append("  LabelName: ").Append(LabelName).Append("\n");
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
        return Equals(obj as LabelUtilizationResponse);
    }

    /// <summary>
    /// Returns true if LabelUtilizationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LabelUtilizationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LabelUtilizationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MaximumCapacity == other.MaximumCapacity ||
                MaximumCapacity != null &&
                MaximumCapacity.Equals(other.MaximumCapacity)
            ) &&
            (
                InterruptingLabelIds == other.InterruptingLabelIds ||
                InterruptingLabelIds != null &&
                InterruptingLabelIds.SequenceEqual(other.InterruptingLabelIds)
            ) &&
            (
                LabelName == other.LabelName ||
                LabelName != null &&
                LabelName.Equals(other.LabelName)
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
            if (MaximumCapacity != null)
            {
                hash = hash * 59 + MaximumCapacity.GetHashCode();
            }

            if (InterruptingLabelIds != null)
            {
                hash = hash * 59 + InterruptingLabelIds.GetHashCode();
            }

            if (LabelName != null)
            {
                hash = hash * 59 + LabelName.GetHashCode();
            }

            return hash;
        }
    }
}
