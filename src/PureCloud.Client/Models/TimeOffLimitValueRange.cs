using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffLimitValueRange
/// </summary>

public partial class TimeOffLimitValueRange : IEquatable<TimeOffLimitValueRange>
{
    /// <summary>
    /// Granularity choice for time off limit
    /// </summary>
    /// <value>Granularity choice for time off limit</value>
    
    public enum GranularityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily
    }
    /// <summary>
    /// Granularity choice for time off limit
    /// </summary>
    /// <value>Granularity choice for time off limit</value>
    [JsonPropertyName("granularity")]
    public GranularityEnum? Granularity { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffLimitValueRange" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffLimitValueRange() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffLimitValueRange" /> class.
    /// </summary>
    /// <param name="TimeOffLimit">The ID of the time off limit.</param>
    /// <param name="StartDate">Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists (required).</param>
    /// <param name="Granularity">Granularity choice for time off limit (required).</param>
    /// <param name="LimitMinutesPerInterval">A list of time off limit values in minutes per granularity interval.</param>
    /// <param name="AllocatedMinutesPerInterval">A list of allocated time off minutes per granularity interval.</param>
    /// <param name="WaitlistedMinutesPerInterval">A list of waitlisted time off minutes per granularity interval.</param>
    /// <param name="WaitlistedRequestsPerInterval">The current number of waitlisted time off requests for every interval per granularity.</param>
    /// <param name="Metadata">Version metadata for the time off limit.</param>
    public TimeOffLimitValueRange(TimeOffLimitReference TimeOffLimit = null, string StartDate = null, GranularityEnum? Granularity = null, List<int?> LimitMinutesPerInterval = null, List<int?> AllocatedMinutesPerInterval = null, List<int?> WaitlistedMinutesPerInterval = null, List<int?> WaitlistedRequestsPerInterval = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.TimeOffLimit = TimeOffLimit;
        this.StartDate = StartDate;
        this.Granularity = Granularity;
        this.LimitMinutesPerInterval = LimitMinutesPerInterval;
        this.AllocatedMinutesPerInterval = AllocatedMinutesPerInterval;
        this.WaitlistedMinutesPerInterval = WaitlistedMinutesPerInterval;
        this.WaitlistedRequestsPerInterval = WaitlistedRequestsPerInterval;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The ID of the time off limit
    /// </summary>
    /// <value>The ID of the time off limit</value>
    [JsonPropertyName("timeOffLimit")]
    public TimeOffLimitReference TimeOffLimit { get; set; }



    /// <summary>
    /// Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists
    /// </summary>
    /// <value>Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists</value>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }





    /// <summary>
    /// A list of time off limit values in minutes per granularity interval
    /// </summary>
    /// <value>A list of time off limit values in minutes per granularity interval</value>
    [JsonPropertyName("limitMinutesPerInterval")]
    public List<int?> LimitMinutesPerInterval { get; set; }



    /// <summary>
    /// A list of allocated time off minutes per granularity interval
    /// </summary>
    /// <value>A list of allocated time off minutes per granularity interval</value>
    [JsonPropertyName("allocatedMinutesPerInterval")]
    public List<int?> AllocatedMinutesPerInterval { get; set; }



    /// <summary>
    /// A list of waitlisted time off minutes per granularity interval
    /// </summary>
    /// <value>A list of waitlisted time off minutes per granularity interval</value>
    [JsonPropertyName("waitlistedMinutesPerInterval")]
    public List<int?> WaitlistedMinutesPerInterval { get; set; }



    /// <summary>
    /// The current number of waitlisted time off requests for every interval per granularity
    /// </summary>
    /// <value>The current number of waitlisted time off requests for every interval per granularity</value>
    [JsonPropertyName("waitlistedRequestsPerInterval")]
    public List<int?> WaitlistedRequestsPerInterval { get; set; }



    /// <summary>
    /// Version metadata for the time off limit
    /// </summary>
    /// <value>Version metadata for the time off limit</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffLimitValueRange {\n");

        sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  LimitMinutesPerInterval: ").Append(LimitMinutesPerInterval).Append("\n");
        sb.Append("  AllocatedMinutesPerInterval: ").Append(AllocatedMinutesPerInterval).Append("\n");
        sb.Append("  WaitlistedMinutesPerInterval: ").Append(WaitlistedMinutesPerInterval).Append("\n");
        sb.Append("  WaitlistedRequestsPerInterval: ").Append(WaitlistedRequestsPerInterval).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as TimeOffLimitValueRange);
    }

    /// <summary>
    /// Returns true if TimeOffLimitValueRange instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffLimitValueRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffLimitValueRange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffLimit == other.TimeOffLimit ||
                TimeOffLimit != null &&
                TimeOffLimit.Equals(other.TimeOffLimit)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
            ) &&
            (
                LimitMinutesPerInterval == other.LimitMinutesPerInterval ||
                LimitMinutesPerInterval != null &&
                LimitMinutesPerInterval.SequenceEqual(other.LimitMinutesPerInterval)
            ) &&
            (
                AllocatedMinutesPerInterval == other.AllocatedMinutesPerInterval ||
                AllocatedMinutesPerInterval != null &&
                AllocatedMinutesPerInterval.SequenceEqual(other.AllocatedMinutesPerInterval)
            ) &&
            (
                WaitlistedMinutesPerInterval == other.WaitlistedMinutesPerInterval ||
                WaitlistedMinutesPerInterval != null &&
                WaitlistedMinutesPerInterval.SequenceEqual(other.WaitlistedMinutesPerInterval)
            ) &&
            (
                WaitlistedRequestsPerInterval == other.WaitlistedRequestsPerInterval ||
                WaitlistedRequestsPerInterval != null &&
                WaitlistedRequestsPerInterval.SequenceEqual(other.WaitlistedRequestsPerInterval)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (TimeOffLimit != null)
            {
                hash = hash * 59 + TimeOffLimit.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (LimitMinutesPerInterval != null)
            {
                hash = hash * 59 + LimitMinutesPerInterval.GetHashCode();
            }

            if (AllocatedMinutesPerInterval != null)
            {
                hash = hash * 59 + AllocatedMinutesPerInterval.GetHashCode();
            }

            if (WaitlistedMinutesPerInterval != null)
            {
                hash = hash * 59 + WaitlistedMinutesPerInterval.GetHashCode();
            }

            if (WaitlistedRequestsPerInterval != null)
            {
                hash = hash * 59 + WaitlistedRequestsPerInterval.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
