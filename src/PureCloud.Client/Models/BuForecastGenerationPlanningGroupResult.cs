using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuForecastGenerationPlanningGroupResult
/// </summary>

public partial class BuForecastGenerationPlanningGroupResult : IEquatable<BuForecastGenerationPlanningGroupResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastGenerationPlanningGroupResult" /> class.
    /// </summary>
    /// <param name="PlanningGroupId">The ID of the planning group.</param>
    /// <param name="MetricResults">The generation results for the associated planning group.</param>
    public BuForecastGenerationPlanningGroupResult(string PlanningGroupId = null, List<BuForecastTimeSeriesResult> MetricResults = null)
    {
        this.PlanningGroupId = PlanningGroupId;
        this.MetricResults = MetricResults;

    }



    /// <summary>
    /// The ID of the planning group
    /// </summary>
    /// <value>The ID of the planning group</value>
    [JsonPropertyName("planningGroupId")]
    public string PlanningGroupId { get; set; }



    /// <summary>
    /// The generation results for the associated planning group
    /// </summary>
    /// <value>The generation results for the associated planning group</value>
    [JsonPropertyName("metricResults")]
    public List<BuForecastTimeSeriesResult> MetricResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuForecastGenerationPlanningGroupResult {\n");

        sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
        sb.Append("  MetricResults: ").Append(MetricResults).Append("\n");
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
        return Equals(obj as BuForecastGenerationPlanningGroupResult);
    }

    /// <summary>
    /// Returns true if BuForecastGenerationPlanningGroupResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BuForecastGenerationPlanningGroupResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuForecastGenerationPlanningGroupResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroupId == other.PlanningGroupId ||
                PlanningGroupId != null &&
                PlanningGroupId.Equals(other.PlanningGroupId)
            ) &&
            (
                MetricResults == other.MetricResults ||
                MetricResults != null &&
                MetricResults.SequenceEqual(other.MetricResults)
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
            if (PlanningGroupId != null)
            {
                hash = hash * 59 + PlanningGroupId.GetHashCode();
            }

            if (MetricResults != null)
            {
                hash = hash * 59 + MetricResults.GetHashCode();
            }

            return hash;
        }
    }
}
