using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LongTermForecastPlanningGroupData
/// </summary>
[DataContract]
public partial class LongTermForecastPlanningGroupData : IEquatable<LongTermForecastPlanningGroupData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LongTermForecastPlanningGroupData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LongTermForecastPlanningGroupData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LongTermForecastPlanningGroupData" /> class.
    /// </summary>
    /// <param name="PlanningGroupId">The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration (required).</param>
    /// <param name="OfferedPerDay">Forecast offered counts per day for this planning group (required).</param>
    /// <param name="AverageHandleTimeSecondsPerDay">Forecast average handle time per day in seconds (required).</param>
    public LongTermForecastPlanningGroupData(string PlanningGroupId = null, List<double?> OfferedPerDay = null, List<double?> AverageHandleTimeSecondsPerDay = null)
    {
        this.PlanningGroupId = PlanningGroupId;
        this.OfferedPerDay = OfferedPerDay;
        this.AverageHandleTimeSecondsPerDay = AverageHandleTimeSecondsPerDay;

    }



    /// <summary>
    /// The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration
    /// </summary>
    /// <value>The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration</value>
    [DataMember(Name = "planningGroupId", EmitDefaultValue = false)]
    public string PlanningGroupId { get; set; }



    /// <summary>
    /// Forecast offered counts per day for this planning group
    /// </summary>
    /// <value>Forecast offered counts per day for this planning group</value>
    [DataMember(Name = "offeredPerDay", EmitDefaultValue = false)]
    public List<double?> OfferedPerDay { get; set; }



    /// <summary>
    /// Forecast average handle time per day in seconds
    /// </summary>
    /// <value>Forecast average handle time per day in seconds</value>
    [DataMember(Name = "averageHandleTimeSecondsPerDay", EmitDefaultValue = false)]
    public List<double?> AverageHandleTimeSecondsPerDay { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LongTermForecastPlanningGroupData {\n");

        sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
        sb.Append("  OfferedPerDay: ").Append(OfferedPerDay).Append("\n");
        sb.Append("  AverageHandleTimeSecondsPerDay: ").Append(AverageHandleTimeSecondsPerDay).Append("\n");
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
        return Equals(obj as LongTermForecastPlanningGroupData);
    }

    /// <summary>
    /// Returns true if LongTermForecastPlanningGroupData instances are equal
    /// </summary>
    /// <param name="other">Instance of LongTermForecastPlanningGroupData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LongTermForecastPlanningGroupData other)
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
                OfferedPerDay == other.OfferedPerDay ||
                OfferedPerDay != null &&
                OfferedPerDay.SequenceEqual(other.OfferedPerDay)
            ) &&
            (
                AverageHandleTimeSecondsPerDay == other.AverageHandleTimeSecondsPerDay ||
                AverageHandleTimeSecondsPerDay != null &&
                AverageHandleTimeSecondsPerDay.SequenceEqual(other.AverageHandleTimeSecondsPerDay)
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

            if (OfferedPerDay != null)
            {
                hash = hash * 59 + OfferedPerDay.GetHashCode();
            }

            if (AverageHandleTimeSecondsPerDay != null)
            {
                hash = hash * 59 + AverageHandleTimeSecondsPerDay.GetHashCode();
            }

            return hash;
        }
    }
}
