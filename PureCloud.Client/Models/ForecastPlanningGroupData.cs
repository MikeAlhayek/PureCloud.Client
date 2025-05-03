using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ForecastPlanningGroupData
/// </summary>

public partial class ForecastPlanningGroupData : IEquatable<ForecastPlanningGroupData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastPlanningGroupData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ForecastPlanningGroupData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastPlanningGroupData" /> class.
    /// </summary>
    /// <param name="PlanningGroupId">The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration (required).</param>
    /// <param name="OfferedPerInterval">Forecast offered counts per 15 minute interval for this week of the forecast (required).</param>
    /// <param name="AverageHandleTimeSecondsPerInterval">Forecast average handle time per 15 minute interval in seconds (required).</param>
    public ForecastPlanningGroupData(string PlanningGroupId = null, List<double?> OfferedPerInterval = null, List<double?> AverageHandleTimeSecondsPerInterval = null)
    {
        this.PlanningGroupId = PlanningGroupId;
        this.OfferedPerInterval = OfferedPerInterval;
        this.AverageHandleTimeSecondsPerInterval = AverageHandleTimeSecondsPerInterval;

    }



    /// <summary>
    /// The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration
    /// </summary>
    /// <value>The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration</value>
    [JsonPropertyName("planningGroupId")]
    public string PlanningGroupId { get; set; }



    /// <summary>
    /// Forecast offered counts per 15 minute interval for this week of the forecast
    /// </summary>
    /// <value>Forecast offered counts per 15 minute interval for this week of the forecast</value>
    [JsonPropertyName("offeredPerInterval")]
    public List<double?> OfferedPerInterval { get; set; }



    /// <summary>
    /// Forecast average handle time per 15 minute interval in seconds
    /// </summary>
    /// <value>Forecast average handle time per 15 minute interval in seconds</value>
    [JsonPropertyName("averageHandleTimeSecondsPerInterval")]
    public List<double?> AverageHandleTimeSecondsPerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ForecastPlanningGroupData {\n");

        sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
        sb.Append("  OfferedPerInterval: ").Append(OfferedPerInterval).Append("\n");
        sb.Append("  AverageHandleTimeSecondsPerInterval: ").Append(AverageHandleTimeSecondsPerInterval).Append("\n");
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
        return Equals(obj as ForecastPlanningGroupData);
    }

    /// <summary>
    /// Returns true if ForecastPlanningGroupData instances are equal
    /// </summary>
    /// <param name="other">Instance of ForecastPlanningGroupData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ForecastPlanningGroupData other)
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
                OfferedPerInterval == other.OfferedPerInterval ||
                OfferedPerInterval != null &&
                OfferedPerInterval.SequenceEqual(other.OfferedPerInterval)
            ) &&
            (
                AverageHandleTimeSecondsPerInterval == other.AverageHandleTimeSecondsPerInterval ||
                AverageHandleTimeSecondsPerInterval != null &&
                AverageHandleTimeSecondsPerInterval.SequenceEqual(other.AverageHandleTimeSecondsPerInterval)
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

            if (OfferedPerInterval != null)
            {
                hash = hash * 59 + OfferedPerInterval.GetHashCode();
            }

            if (AverageHandleTimeSecondsPerInterval != null)
            {
                hash = hash * 59 + AverageHandleTimeSecondsPerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
