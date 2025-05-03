using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffLimitRange
/// </summary>

public partial class TimeOffLimitRange : IEquatable<TimeOffLimitRange>
{
    /// <summary>
    /// Granularity choice for the time off limit
    /// </summary>
    /// <value>Granularity choice for the time off limit</value>
    
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
    /// Granularity choice for the time off limit
    /// </summary>
    /// <value>Granularity choice for the time off limit</value>
    [JsonPropertyName("granularity")]
    public GranularityEnum? Granularity { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffLimitRange" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffLimitRange() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffLimitRange" /> class.
    /// </summary>
    /// <param name="StartDate">Start date of the range. The end date is determined by &#39;granularity&#39; and the size of &#39;limitMinutesPerInterval&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="Granularity">Granularity choice for the time off limit (required).</param>
    /// <param name="LimitMinutesPerInterval">The list of time off limit values in minutes per granularity interval. If &#39;null&#39; is specified, then interval specific value is cleared. Such interval will have &#39;defaultLimitMinutes&#39; value (required).</param>
    public TimeOffLimitRange(string StartDate = null, GranularityEnum? Granularity = null, List<int?> LimitMinutesPerInterval = null)
    {
        this.StartDate = StartDate;
        this.Granularity = Granularity;
        this.LimitMinutesPerInterval = LimitMinutesPerInterval;

    }



    /// <summary>
    /// Start date of the range. The end date is determined by &#39;granularity&#39; and the size of &#39;limitMinutesPerInterval&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of the range. The end date is determined by &#39;granularity&#39; and the size of &#39;limitMinutesPerInterval&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }





    /// <summary>
    /// The list of time off limit values in minutes per granularity interval. If &#39;null&#39; is specified, then interval specific value is cleared. Such interval will have &#39;defaultLimitMinutes&#39; value
    /// </summary>
    /// <value>The list of time off limit values in minutes per granularity interval. If &#39;null&#39; is specified, then interval specific value is cleared. Such interval will have &#39;defaultLimitMinutes&#39; value</value>
    [JsonPropertyName("limitMinutesPerInterval")]
    public List<int?> LimitMinutesPerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffLimitRange {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  LimitMinutesPerInterval: ").Append(LimitMinutesPerInterval).Append("\n");
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
        return Equals(obj as TimeOffLimitRange);
    }

    /// <summary>
    /// Returns true if TimeOffLimitRange instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffLimitRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffLimitRange other)
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

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (LimitMinutesPerInterval != null)
            {
                hash = hash * 59 + LimitMinutesPerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
