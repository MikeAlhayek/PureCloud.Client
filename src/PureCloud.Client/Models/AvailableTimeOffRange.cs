using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableTimeOffRange
/// </summary>

public partial class AvailableTimeOffRange : IEquatable<AvailableTimeOffRange>
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
    /// Initializes a new instance of the <see cref="AvailableTimeOffRange" /> class.
    /// </summary>
    /// <param name="TimeOffLimit">The time off limit.</param>
    /// <param name="StartDate">Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Granularity">Granularity choice for time off limit.</param>
    /// <param name="AvailableMinutesPerInterval">The list of available time off values in minutes per granularity interval.</param>
    /// <param name="WaitlistedRequestsPerInterval">The current number of waitlisted time off requests for every interval per granularity.</param>
    /// <param name="WaitlistEnabled">Whether the time off request can be waitlisted.</param>
    public AvailableTimeOffRange(TimeOffLimitReference TimeOffLimit = null, string StartDate = null, GranularityEnum? Granularity = null, List<int?> AvailableMinutesPerInterval = null, List<int?> WaitlistedRequestsPerInterval = null, bool? WaitlistEnabled = null)
    {
        this.TimeOffLimit = TimeOffLimit;
        this.StartDate = StartDate;
        this.Granularity = Granularity;
        this.AvailableMinutesPerInterval = AvailableMinutesPerInterval;
        this.WaitlistedRequestsPerInterval = WaitlistedRequestsPerInterval;
        this.WaitlistEnabled = WaitlistEnabled;

    }



    /// <summary>
    /// The time off limit
    /// </summary>
    /// <value>The time off limit</value>
    [JsonPropertyName("timeOffLimit")]
    public TimeOffLimitReference TimeOffLimit { get; set; }



    /// <summary>
    /// Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }





    /// <summary>
    /// The list of available time off values in minutes per granularity interval
    /// </summary>
    /// <value>The list of available time off values in minutes per granularity interval</value>
    [JsonPropertyName("availableMinutesPerInterval")]
    public List<int?> AvailableMinutesPerInterval { get; set; }



    /// <summary>
    /// The current number of waitlisted time off requests for every interval per granularity
    /// </summary>
    /// <value>The current number of waitlisted time off requests for every interval per granularity</value>
    [JsonPropertyName("waitlistedRequestsPerInterval")]
    public List<int?> WaitlistedRequestsPerInterval { get; set; }



    /// <summary>
    /// Whether the time off request can be waitlisted
    /// </summary>
    /// <value>Whether the time off request can be waitlisted</value>
    [JsonPropertyName("waitlistEnabled")]
    public bool? WaitlistEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableTimeOffRange {\n");

        sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  AvailableMinutesPerInterval: ").Append(AvailableMinutesPerInterval).Append("\n");
        sb.Append("  WaitlistedRequestsPerInterval: ").Append(WaitlistedRequestsPerInterval).Append("\n");
        sb.Append("  WaitlistEnabled: ").Append(WaitlistEnabled).Append("\n");
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
        return Equals(obj as AvailableTimeOffRange);
    }

    /// <summary>
    /// Returns true if AvailableTimeOffRange instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableTimeOffRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableTimeOffRange other)
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
                AvailableMinutesPerInterval == other.AvailableMinutesPerInterval ||
                AvailableMinutesPerInterval != null &&
                AvailableMinutesPerInterval.SequenceEqual(other.AvailableMinutesPerInterval)
            ) &&
            (
                WaitlistedRequestsPerInterval == other.WaitlistedRequestsPerInterval ||
                WaitlistedRequestsPerInterval != null &&
                WaitlistedRequestsPerInterval.SequenceEqual(other.WaitlistedRequestsPerInterval)
            ) &&
            (
                WaitlistEnabled == other.WaitlistEnabled ||
                WaitlistEnabled != null &&
                WaitlistEnabled.Equals(other.WaitlistEnabled)
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

            if (AvailableMinutesPerInterval != null)
            {
                hash = hash * 59 + AvailableMinutesPerInterval.GetHashCode();
            }

            if (WaitlistedRequestsPerInterval != null)
            {
                hash = hash * 59 + WaitlistedRequestsPerInterval.GetHashCode();
            }

            if (WaitlistEnabled != null)
            {
                hash = hash * 59 + WaitlistEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
