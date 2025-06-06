using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayValuesTrend
/// </summary>

public partial class WorkdayValuesTrend : IEquatable<WorkdayValuesTrend>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayValuesTrend" /> class.
    /// </summary>
    public WorkdayValuesTrend()
    {

    }



    /// <summary>
    /// The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; set; }



    /// <summary>
    /// The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; set; }



    /// <summary>
    /// The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateReferenceWorkday")]
    public string DateReferenceWorkday { get; set; }



    /// <summary>
    /// The targeted division for the query
    /// </summary>
    /// <value>The targeted division for the query</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// The targeted user for the query
    /// </summary>
    /// <value>The targeted user for the query</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The time zone used for aggregating metric values
    /// </summary>
    /// <value>The time zone used for aggregating metric values</value>
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }



    /// <summary>
    /// The metric value trends
    /// </summary>
    /// <value>The metric value trends</value>
    [JsonPropertyName("results")]
    public List<WorkdayValuesMetricItem> Results { get; set; }



    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    [JsonPropertyName("performanceProfile")]
    public AddressableEntityRef PerformanceProfile { get; set; }



    /// <summary>
    /// The targeted metric for the average points
    /// </summary>
    /// <value>The targeted metric for the average points</value>
    [JsonPropertyName("metric")]
    public AddressableEntityRef Metric { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayValuesTrend {\n");

        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  DateReferenceWorkday: ").Append(DateReferenceWorkday).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Timezone: ").Append(Timezone).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as WorkdayValuesTrend);
    }

    /// <summary>
    /// Returns true if WorkdayValuesTrend instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayValuesTrend to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayValuesTrend other)
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
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
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
