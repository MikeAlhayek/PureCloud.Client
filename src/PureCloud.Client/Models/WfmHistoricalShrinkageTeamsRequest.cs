using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalShrinkageTeamsRequest
/// </summary>

public partial class WfmHistoricalShrinkageTeamsRequest : IEquatable<WfmHistoricalShrinkageTeamsRequest>
{
    /// <summary>
    /// Shrinkage aggregation interval granularity
    /// </summary>
    /// <value>Shrinkage aggregation interval granularity</value>
    
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
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly
    }
    /// <summary>
    /// Shrinkage aggregation interval granularity
    /// </summary>
    /// <value>Shrinkage aggregation interval granularity</value>
    [JsonPropertyName("granularity")]
    public GranularityEnum? Granularity { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalShrinkageTeamsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmHistoricalShrinkageTeamsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalShrinkageTeamsRequest" /> class.
    /// </summary>
    /// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
    /// <param name="EndDate">End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time.</param>
    /// <param name="TimeZone">The time zone, in olson format, to use in defining days when computing shrinkage for requested granularity. The results will be returned as UTC timestamps regardless of the time zone input. (required).</param>
    /// <param name="Granularity">Shrinkage aggregation interval granularity.</param>
    public WfmHistoricalShrinkageTeamsRequest(DateTime? StartDate = null, DateTime? EndDate = null, string TimeZone = null, GranularityEnum? Granularity = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.TimeZone = TimeZone;
        this.Granularity = Granularity;

    }



    /// <summary>
    /// Beginning of the date range to query in ISO-8601 format
    /// </summary>
    /// <value>Beginning of the date range to query in ISO-8601 format</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time
    /// </summary>
    /// <value>End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The time zone, in olson format, to use in defining days when computing shrinkage for requested granularity. The results will be returned as UTC timestamps regardless of the time zone input.
    /// </summary>
    /// <value>The time zone, in olson format, to use in defining days when computing shrinkage for requested granularity. The results will be returned as UTC timestamps regardless of the time zone input.</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalShrinkageTeamsRequest {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
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
        return Equals(obj as WfmHistoricalShrinkageTeamsRequest);
    }

    /// <summary>
    /// Returns true if WfmHistoricalShrinkageTeamsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalShrinkageTeamsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalShrinkageTeamsRequest other)
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
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
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

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            return hash;
        }
    }
}
