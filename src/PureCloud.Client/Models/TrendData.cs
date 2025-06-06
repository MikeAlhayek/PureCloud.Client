using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrendData
/// </summary>

public partial class TrendData : IEquatable<TrendData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrendData" /> class.
    /// </summary>
    /// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="PercentOfGoal">Percent of goal.</param>
    /// <param name="AverageValue">Average metric value.</param>
    public TrendData(string DateStartWorkday = null, string DateEndWorkday = null, double? PercentOfGoal = null, double? AverageValue = null)
    {
        this.DateStartWorkday = DateStartWorkday;
        this.DateEndWorkday = DateEndWorkday;
        this.PercentOfGoal = PercentOfGoal;
        this.AverageValue = AverageValue;

    }



    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; set; }



    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; set; }



    /// <summary>
    /// Percent of goal
    /// </summary>
    /// <value>Percent of goal</value>
    [JsonPropertyName("percentOfGoal")]
    public double? PercentOfGoal { get; set; }



    /// <summary>
    /// Average metric value
    /// </summary>
    /// <value>Average metric value</value>
    [JsonPropertyName("averageValue")]
    public double? AverageValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrendData {\n");

        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
        sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
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
        return Equals(obj as TrendData);
    }

    /// <summary>
    /// Returns true if TrendData instances are equal
    /// </summary>
    /// <param name="other">Instance of TrendData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrendData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateStartWorkday == other.DateStartWorkday ||
                DateStartWorkday != null &&
                DateStartWorkday.Equals(other.DateStartWorkday)
            ) &&
            (
                DateEndWorkday == other.DateEndWorkday ||
                DateEndWorkday != null &&
                DateEndWorkday.Equals(other.DateEndWorkday)
            ) &&
            (
                PercentOfGoal == other.PercentOfGoal ||
                PercentOfGoal != null &&
                PercentOfGoal.Equals(other.PercentOfGoal)
            ) &&
            (
                AverageValue == other.AverageValue ||
                AverageValue != null &&
                AverageValue.Equals(other.AverageValue)
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
            if (DateStartWorkday != null)
            {
                hash = hash * 59 + DateStartWorkday.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (PercentOfGoal != null)
            {
                hash = hash * 59 + PercentOfGoal.GetHashCode();
            }

            if (AverageValue != null)
            {
                hash = hash * 59 + AverageValue.GetHashCode();
            }

            return hash;
        }
    }
}
