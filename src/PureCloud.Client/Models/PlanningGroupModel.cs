using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PlanningGroupModel
/// </summary>

public partial class PlanningGroupModel : IEquatable<PlanningGroupModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanningGroupModel" /> class.
    /// </summary>
    /// <param name="PlanningGroup">Planning group id.</param>
    public PlanningGroupModel(string PlanningGroup = null)
    {
        this.PlanningGroup = PlanningGroup;

    }



    /// <summary>
    /// Planning group id
    /// </summary>
    /// <value>Planning group id</value>
    [JsonPropertyName("planningGroup")]
    public string PlanningGroup { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PlanningGroupModel {\n");

        sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
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
        return Equals(obj as PlanningGroupModel);
    }

    /// <summary>
    /// Returns true if PlanningGroupModel instances are equal
    /// </summary>
    /// <param name="other">Instance of PlanningGroupModel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PlanningGroupModel other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroup == other.PlanningGroup ||
                PlanningGroup != null &&
                PlanningGroup.Equals(other.PlanningGroup)
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
            if (PlanningGroup != null)
            {
                hash = hash * 59 + PlanningGroup.GetHashCode();
            }

            return hash;
        }
    }
}
