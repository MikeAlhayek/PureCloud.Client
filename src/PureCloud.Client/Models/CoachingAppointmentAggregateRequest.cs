using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingAppointmentAggregateRequest
/// </summary>

public partial class CoachingAppointmentAggregateRequest : IEquatable<CoachingAppointmentAggregateRequest>
{
    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    
    public enum MetricsEnum
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
    /// Gets or Sets GroupBy
    /// </summary>
    
    public enum GroupByEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attendeeid for "attendeeId"
        /// </summary>
        [EnumMember(Value = "attendeeId")]
        Attendeeid
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingAppointmentAggregateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CoachingAppointmentAggregateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingAppointmentAggregateRequest" /> class.
    /// </summary>
    /// <param name="Interval">Interval to aggregate across. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="Metrics">A list of metrics to aggregate.  If omitted, all metrics are returned..</param>
    /// <param name="GroupBy">An optional list of items by which to group the result data..</param>
    /// <param name="Filter">The filter applied to the data (required).</param>
    public CoachingAppointmentAggregateRequest(string Interval = null, List<MetricsEnum> Metrics = null, List<GroupByEnum> GroupBy = null, QueryRequestFilter Filter = null)
    {
        this.Interval = Interval;
        this.Metrics = Metrics;
        this.GroupBy = GroupBy;
        this.Filter = Filter;

    }



    /// <summary>
    /// Interval to aggregate across. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Interval to aggregate across. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// A list of metrics to aggregate.  If omitted, all metrics are returned.
    /// </summary>
    /// <value>A list of metrics to aggregate.  If omitted, all metrics are returned.</value>
    [JsonPropertyName("metrics")]
    public List<MetricsEnum> Metrics { get; set; }



    /// <summary>
    /// An optional list of items by which to group the result data.
    /// </summary>
    /// <value>An optional list of items by which to group the result data.</value>
    [JsonPropertyName("groupBy")]
    public List<GroupByEnum> GroupBy { get; set; }



    /// <summary>
    /// The filter applied to the data
    /// </summary>
    /// <value>The filter applied to the data</value>
    [JsonPropertyName("filter")]
    public QueryRequestFilter Filter { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoachingAppointmentAggregateRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
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
        return Equals(obj as CoachingAppointmentAggregateRequest);
    }

    /// <summary>
    /// Returns true if CoachingAppointmentAggregateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingAppointmentAggregateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingAppointmentAggregateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                GroupBy == other.GroupBy ||
                GroupBy != null &&
                GroupBy.SequenceEqual(other.GroupBy)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (GroupBy != null)
            {
                hash = hash * 59 + GroupBy.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            return hash;
        }
    }
}
