using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// LongTermForecastResult
/// </summary>
[DataContract]
public partial class LongTermForecastResult : IEquatable<LongTermForecastResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LongTermForecastResult" /> class.
    /// </summary>
    /// <param name="PlanningGroups">The forecast data broken up by planning group.</param>
    /// <param name="ReferenceStartDate">The reference start date relative to the business unit time zone in this forecast. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="WeekCount">The number of weeks in this forecast.</param>
    public LongTermForecastResult(List<LongTermForecastPlanningGroupData> PlanningGroups = null, string ReferenceStartDate = null, int? WeekCount = null)
    {
        this.PlanningGroups = PlanningGroups;
        this.ReferenceStartDate = ReferenceStartDate;
        this.WeekCount = WeekCount;

    }



    /// <summary>
    /// The forecast data broken up by planning group
    /// </summary>
    /// <value>The forecast data broken up by planning group</value>
    [DataMember(Name = "planningGroups", EmitDefaultValue = false)]
    public List<LongTermForecastPlanningGroupData> PlanningGroups { get; set; }



    /// <summary>
    /// The reference start date relative to the business unit time zone in this forecast. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The reference start date relative to the business unit time zone in this forecast. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
    public string ReferenceStartDate { get; set; }



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
        sb.Append("class LongTermForecastResult {\n");

        sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
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
        return Equals(obj as LongTermForecastResult);
    }

    /// <summary>
    /// Returns true if LongTermForecastResult instances are equal
    /// </summary>
    /// <param name="other">Instance of LongTermForecastResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LongTermForecastResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroups == other.PlanningGroups ||
                PlanningGroups != null &&
                PlanningGroups.SequenceEqual(other.PlanningGroups)
            ) &&
            (
                ReferenceStartDate == other.ReferenceStartDate ||
                ReferenceStartDate != null &&
                ReferenceStartDate.Equals(other.ReferenceStartDate)
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
            if (PlanningGroups != null)
            {
                hash = hash * 59 + PlanningGroups.GetHashCode();
            }

            if (ReferenceStartDate != null)
            {
                hash = hash * 59 + ReferenceStartDate.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            return hash;
        }
    }
}
