using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UtilizationResponse
/// </summary>
[DataContract]
public partial class UtilizationResponse : IEquatable<UtilizationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UtilizationResponse" /> class.
    /// </summary>
    /// <param name="Utilization">Map of media type to utilization settings..</param>
    /// <param name="LabelUtilizations">Map of label ids to utilization settings..</param>
    public UtilizationResponse(Dictionary<string, MediaUtilization> Utilization = null, Dictionary<string, LabelUtilizationResponse> LabelUtilizations = null)
    {
        this.Utilization = Utilization;
        this.LabelUtilizations = LabelUtilizations;

    }



    /// <summary>
    /// Map of media type to utilization settings.
    /// </summary>
    /// <value>Map of media type to utilization settings.</value>
    [DataMember(Name = "utilization", EmitDefaultValue = false)]
    public Dictionary<string, MediaUtilization> Utilization { get; set; }



    /// <summary>
    /// Map of label ids to utilization settings.
    /// </summary>
    /// <value>Map of label ids to utilization settings.</value>
    [DataMember(Name = "labelUtilizations", EmitDefaultValue = false)]
    public Dictionary<string, LabelUtilizationResponse> LabelUtilizations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UtilizationResponse {\n");

        sb.Append("  Utilization: ").Append(Utilization).Append("\n");
        sb.Append("  LabelUtilizations: ").Append(LabelUtilizations).Append("\n");
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
        return Equals(obj as UtilizationResponse);
    }

    /// <summary>
    /// Returns true if UtilizationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UtilizationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UtilizationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Utilization == other.Utilization ||
                Utilization != null &&
                Utilization.SequenceEqual(other.Utilization)
            ) &&
            (
                LabelUtilizations == other.LabelUtilizations ||
                LabelUtilizations != null &&
                LabelUtilizations.SequenceEqual(other.LabelUtilizations)
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
            if (Utilization != null)
            {
                hash = hash * 59 + Utilization.GetHashCode();
            }

            if (LabelUtilizations != null)
            {
                hash = hash * 59 + LabelUtilizations.GetHashCode();
            }

            return hash;
        }
    }
}
