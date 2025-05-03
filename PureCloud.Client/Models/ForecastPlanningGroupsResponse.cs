using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ForecastPlanningGroupsResponse
/// </summary>

public partial class ForecastPlanningGroupsResponse : IEquatable<ForecastPlanningGroupsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastPlanningGroupsResponse" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="BusinessUnitServiceGoalImpact">A snapshot of a business unit’s service goal impact settings taken at forecast generation time..</param>
    public ForecastPlanningGroupsResponse(List<ForecastPlanningGroupResponse> Entities = null, WfmServiceGoalImpactSettings BusinessUnitServiceGoalImpact = null)
    {
        this.Entities = Entities;
        this.BusinessUnitServiceGoalImpact = BusinessUnitServiceGoalImpact;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<ForecastPlanningGroupResponse> Entities { get; set; }



    /// <summary>
    /// A snapshot of a business unit’s service goal impact settings taken at forecast generation time.
    /// </summary>
    /// <value>A snapshot of a business unit’s service goal impact settings taken at forecast generation time.</value>
    [JsonPropertyName("businessUnitServiceGoalImpact")]
    public WfmServiceGoalImpactSettings BusinessUnitServiceGoalImpact { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ForecastPlanningGroupsResponse {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  BusinessUnitServiceGoalImpact: ").Append(BusinessUnitServiceGoalImpact).Append("\n");
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
        return Equals(obj as ForecastPlanningGroupsResponse);
    }

    /// <summary>
    /// Returns true if ForecastPlanningGroupsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ForecastPlanningGroupsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ForecastPlanningGroupsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                BusinessUnitServiceGoalImpact == other.BusinessUnitServiceGoalImpact ||
                BusinessUnitServiceGoalImpact != null &&
                BusinessUnitServiceGoalImpact.Equals(other.BusinessUnitServiceGoalImpact)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (BusinessUnitServiceGoalImpact != null)
            {
                hash = hash * 59 + BusinessUnitServiceGoalImpact.GetHashCode();
            }

            return hash;
        }
    }
}
