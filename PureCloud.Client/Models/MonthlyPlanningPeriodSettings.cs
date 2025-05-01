using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MonthlyPlanningPeriodSettings
/// </summary>
[DataContract]
public partial class MonthlyPlanningPeriodSettings : IEquatable<MonthlyPlanningPeriodSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MonthlyPlanningPeriodSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MonthlyPlanningPeriodSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MonthlyPlanningPeriodSettings" /> class.
    /// </summary>
    /// <param name="StartDate">Start date of the monthly planning period in yyyy-MM-dd format. The date must represent the first day of the given month. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    public MonthlyPlanningPeriodSettings(string StartDate = null)
    {
        this.StartDate = StartDate;

    }



    /// <summary>
    /// Start date of the monthly planning period in yyyy-MM-dd format. The date must represent the first day of the given month. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of the monthly planning period in yyyy-MM-dd format. The date must represent the first day of the given month. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public string StartDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MonthlyPlanningPeriodSettings {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
        return Equals(obj as MonthlyPlanningPeriodSettings);
    }

    /// <summary>
    /// Returns true if MonthlyPlanningPeriodSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of MonthlyPlanningPeriodSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MonthlyPlanningPeriodSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            return hash;
        }
    }
}
