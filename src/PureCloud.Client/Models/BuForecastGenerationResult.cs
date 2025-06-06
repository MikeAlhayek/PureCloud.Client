using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuForecastGenerationResult
/// </summary>

public partial class BuForecastGenerationResult : IEquatable<BuForecastGenerationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastGenerationResult" /> class.
    /// </summary>
    /// <param name="PlanningGroupResults">Generation results, broken down by planning group.</param>
    public BuForecastGenerationResult(List<BuForecastGenerationPlanningGroupResult> PlanningGroupResults = null)
    {
        this.PlanningGroupResults = PlanningGroupResults;

    }



    /// <summary>
    /// Generation results, broken down by planning group
    /// </summary>
    /// <value>Generation results, broken down by planning group</value>
    [JsonPropertyName("planningGroupResults")]
    public List<BuForecastGenerationPlanningGroupResult> PlanningGroupResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuForecastGenerationResult {\n");

        sb.Append("  PlanningGroupResults: ").Append(PlanningGroupResults).Append("\n");
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
        return Equals(obj as BuForecastGenerationResult);
    }

    /// <summary>
    /// Returns true if BuForecastGenerationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BuForecastGenerationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuForecastGenerationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroupResults == other.PlanningGroupResults ||
                PlanningGroupResults != null &&
                PlanningGroupResults.SequenceEqual(other.PlanningGroupResults)
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
            if (PlanningGroupResults != null)
            {
                hash = hash * 59 + PlanningGroupResults.GetHashCode();
            }

            return hash;
        }
    }
}
