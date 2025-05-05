using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PerformancePredictionOutputs
/// </summary>

public partial class PerformancePredictionOutputs : IEquatable<PerformancePredictionOutputs>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PerformancePredictionOutputs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PerformancePredictionOutputs() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PerformancePredictionOutputs" /> class.
    /// </summary>
    /// <param name="CalculationStartDate">Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results (required).</param>
    /// <param name="CalculationIntervalLengthMinutes">Interval length of the response metrics (required).</param>
    /// <param name="PlanningGroupResults">List of planning group level performance prediction results (required).</param>
    public PerformancePredictionOutputs(DateTime? CalculationStartDate = null, int? CalculationIntervalLengthMinutes = null, List<PlanningGroupOutputs> PlanningGroupResults = null)
    {
        this.CalculationStartDate = CalculationStartDate;
        this.CalculationIntervalLengthMinutes = CalculationIntervalLengthMinutes;
        this.PlanningGroupResults = PlanningGroupResults;

    }



    /// <summary>
    /// Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results
    /// </summary>
    /// <value>Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results</value>
    [JsonPropertyName("calculationStartDate")]
    public DateTime? CalculationStartDate { get; set; }



    /// <summary>
    /// Interval length of the response metrics
    /// </summary>
    /// <value>Interval length of the response metrics</value>
    [JsonPropertyName("calculationIntervalLengthMinutes")]
    public int? CalculationIntervalLengthMinutes { get; set; }



    /// <summary>
    /// List of planning group level performance prediction results
    /// </summary>
    /// <value>List of planning group level performance prediction results</value>
    [JsonPropertyName("planningGroupResults")]
    public List<PlanningGroupOutputs> PlanningGroupResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PerformancePredictionOutputs {\n");

        sb.Append("  CalculationStartDate: ").Append(CalculationStartDate).Append("\n");
        sb.Append("  CalculationIntervalLengthMinutes: ").Append(CalculationIntervalLengthMinutes).Append("\n");
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
        return Equals(obj as PerformancePredictionOutputs);
    }

    /// <summary>
    /// Returns true if PerformancePredictionOutputs instances are equal
    /// </summary>
    /// <param name="other">Instance of PerformancePredictionOutputs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PerformancePredictionOutputs other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CalculationStartDate == other.CalculationStartDate ||
                CalculationStartDate != null &&
                CalculationStartDate.Equals(other.CalculationStartDate)
            ) &&
            (
                CalculationIntervalLengthMinutes == other.CalculationIntervalLengthMinutes ||
                CalculationIntervalLengthMinutes != null &&
                CalculationIntervalLengthMinutes.Equals(other.CalculationIntervalLengthMinutes)
            ) &&
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
            if (CalculationStartDate != null)
            {
                hash = hash * 59 + CalculationStartDate.GetHashCode();
            }

            if (CalculationIntervalLengthMinutes != null)
            {
                hash = hash * 59 + CalculationIntervalLengthMinutes.GetHashCode();
            }

            if (PlanningGroupResults != null)
            {
                hash = hash * 59 + PlanningGroupResults.GetHashCode();
            }

            return hash;
        }
    }
}
