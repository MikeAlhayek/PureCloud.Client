using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BuForecastResult
/// </summary>
[DataContract]
public partial class BuForecastResult : IEquatable<BuForecastResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastResult" /> class.
    /// </summary>
    /// <param name="ReferenceStartDate">The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="PlanningGroups">The forecast data broken up by planning group.</param>
    /// <param name="WeekNumber">The week number represented by this response.</param>
    /// <param name="WeekCount">The number of weeks in this forecast.</param>
    public BuForecastResult(DateTime? ReferenceStartDate = null, List<ForecastPlanningGroupData> PlanningGroups = null, int? WeekNumber = null, int? WeekCount = null)
    {
        this.ReferenceStartDate = ReferenceStartDate;
        this.PlanningGroups = PlanningGroups;
        this.WeekNumber = WeekNumber;
        this.WeekCount = WeekCount;

    }



    /// <summary>
    /// The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
    public DateTime? ReferenceStartDate { get; set; }



    /// <summary>
    /// The forecast data broken up by planning group
    /// </summary>
    /// <value>The forecast data broken up by planning group</value>
    [DataMember(Name = "planningGroups", EmitDefaultValue = false)]
    public List<ForecastPlanningGroupData> PlanningGroups { get; set; }



    /// <summary>
    /// The week number represented by this response
    /// </summary>
    /// <value>The week number represented by this response</value>
    [DataMember(Name = "weekNumber", EmitDefaultValue = false)]
    public int? WeekNumber { get; set; }



    /// <summary>
    /// The number of weeks in this forecast
    /// </summary>
    /// <value>The number of weeks in this forecast</value>
    [DataMember(Name = "weekCount", EmitDefaultValue = false)]
    public int? WeekCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuForecastResult {\n");

        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
        sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
        sb.Append("  WeekNumber: ").Append(WeekNumber).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
        return Equals(obj as BuForecastResult);
    }

    /// <summary>
    /// Returns true if BuForecastResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BuForecastResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuForecastResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ReferenceStartDate == other.ReferenceStartDate ||
                ReferenceStartDate != null &&
                ReferenceStartDate.Equals(other.ReferenceStartDate)
            ) &&
            (
                PlanningGroups == other.PlanningGroups ||
                PlanningGroups != null &&
                PlanningGroups.SequenceEqual(other.PlanningGroups)
            ) &&
            (
                WeekNumber == other.WeekNumber ||
                WeekNumber != null &&
                WeekNumber.Equals(other.WeekNumber)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
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
            if (ReferenceStartDate != null)
            {
                hash = hash * 59 + ReferenceStartDate.GetHashCode();
            }

            if (PlanningGroups != null)
            {
                hash = hash * 59 + PlanningGroups.GetHashCode();
            }

            if (WeekNumber != null)
            {
                hash = hash * 59 + WeekNumber.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            return hash;
        }
    }
}
