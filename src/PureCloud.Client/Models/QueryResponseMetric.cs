using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryResponseMetric
/// </summary>

public partial class QueryResponseMetric : IEquatable<QueryResponseMetric>
{
    /// <summary>
    /// The metric this applies to
    /// </summary>
    /// <value>The metric this applies to</value>
    
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nactivities for "nActivities"
        /// </summary>
        [EnumMember(Value = "nActivities")]
        Nactivities,

        /// <summary>
        /// Enum Nplannedactivities for "nPlannedActivities"
        /// </summary>
        [EnumMember(Value = "nPlannedActivities")]
        Nplannedactivities,

        /// <summary>
        /// Enum Ninprogressactivities for "nInProgressActivities"
        /// </summary>
        [EnumMember(Value = "nInProgressActivities")]
        Ninprogressactivities,

        /// <summary>
        /// Enum Ncompleteactivities for "nCompleteActivities"
        /// </summary>
        [EnumMember(Value = "nCompleteActivities")]
        Ncompleteactivities,

        /// <summary>
        /// Enum Noverdueactivities for "nOverdueActivities"
        /// </summary>
        [EnumMember(Value = "nOverdueActivities")]
        Noverdueactivities,

        /// <summary>
        /// Enum Ninvalidscheduleactivities for "nInvalidScheduleActivities"
        /// </summary>
        [EnumMember(Value = "nInvalidScheduleActivities")]
        Ninvalidscheduleactivities
    }
    /// <summary>
    /// The metric this applies to
    /// </summary>
    /// <value>The metric this applies to</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryResponseMetric" /> class.
    /// </summary>
    /// <param name="Metric">The metric this applies to.</param>
    /// <param name="Stats">The aggregated values for this metric.</param>
    public QueryResponseMetric(MetricEnum? Metric = null, QueryResponseStats Stats = null)
    {
        this.Metric = Metric;
        this.Stats = Stats;

    }





    /// <summary>
    /// The aggregated values for this metric
    /// </summary>
    /// <value>The aggregated values for this metric</value>
    [JsonPropertyName("stats")]
    public QueryResponseStats Stats { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryResponseMetric {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Stats: ").Append(Stats).Append("\n");
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
        return Equals(obj as QueryResponseMetric);
    }

    /// <summary>
    /// Returns true if QueryResponseMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryResponseMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryResponseMetric other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                Stats == other.Stats ||
                Stats != null &&
                Stats.Equals(other.Stats)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (Stats != null)
            {
                hash = hash * 59 + Stats.GetHashCode();
            }

            return hash;
        }
    }
}
