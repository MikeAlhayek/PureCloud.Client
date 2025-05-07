using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MetricValueTrendAverage
/// </summary>

public partial class MetricValueTrendAverage : IEquatable<MetricValueTrendAverage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MetricValueTrendAverage" /> class.
    /// </summary>
    public MetricValueTrendAverage()
    {

    }



    /// <summary>
    /// The targeted start workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The targeted start workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; set; }



    /// <summary>
    /// The targeted end workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The targeted end workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; set; }



    /// <summary>
    /// The targeted reference workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The targeted reference workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateReferenceWorkday")]
    public string DateReferenceWorkday { get; set; }



    /// <summary>
    /// The targeted division for the metrics
    /// </summary>
    /// <value>The targeted division for the metrics</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// The targeted user for the metrics
    /// </summary>
    /// <value>The targeted user for the metrics</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The time zone used for aggregating metric values
    /// </summary>
    /// <value>The time zone used for aggregating metric values</value>
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }



    /// <summary>
    /// The metric value trend and average
    /// </summary>
    /// <value>The metric value trend and average</value>
    [JsonPropertyName("result")]
    public WorkdayValuesMetricItem Result { get; set; }



    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    [JsonPropertyName("performanceProfile")]
    public AddressableEntityRef PerformanceProfile { get; set; }



    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    [JsonPropertyName("metric")]
    public AddressableEntityRef Metric { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MetricValueTrendAverage {\n");

        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  DateReferenceWorkday: ").Append(DateReferenceWorkday).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Timezone: ").Append(Timezone).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
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
        return Equals(obj as MetricValueTrendAverage);
    }

    /// <summary>
    /// Returns true if MetricValueTrendAverage instances are equal
    /// </summary>
    /// <param name="other">Instance of MetricValueTrendAverage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MetricValueTrendAverage other)
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
                DateReferenceWorkday == other.DateReferenceWorkday ||
                DateReferenceWorkday != null &&
                DateReferenceWorkday.Equals(other.DateReferenceWorkday)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Timezone == other.Timezone ||
                Timezone != null &&
                Timezone.Equals(other.Timezone)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
            ) &&
            (
                PerformanceProfile == other.PerformanceProfile ||
                PerformanceProfile != null &&
                PerformanceProfile.Equals(other.PerformanceProfile)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
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

            if (DateReferenceWorkday != null)
            {
                hash = hash * 59 + DateReferenceWorkday.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Timezone != null)
            {
                hash = hash * 59 + Timezone.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            if (PerformanceProfile != null)
            {
                hash = hash * 59 + PerformanceProfile.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            return hash;
        }
    }
}
