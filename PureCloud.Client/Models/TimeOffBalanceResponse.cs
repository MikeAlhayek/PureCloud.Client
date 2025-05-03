using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffBalanceResponse
/// </summary>

public partial class TimeOffBalanceResponse : IEquatable<TimeOffBalanceResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffBalanceResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffBalanceResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffBalanceResponse" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">The ID for activity code associated with time off balance (required).</param>
    /// <param name="HrisTimeOffTypeId">The ID of the time off type configured in HRIS integration (required).</param>
    /// <param name="HrisTimeOffTypeSecondaryId">The secondary ID of the time off type configured in HRIS integration.</param>
    /// <param name="StartDate">The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="BalanceMinutesPerDay">The list of available time off balance values in minutes for each day.</param>
    public TimeOffBalanceResponse(string ActivityCodeId = null, string HrisTimeOffTypeId = null, string HrisTimeOffTypeSecondaryId = null, string StartDate = null, List<int?> BalanceMinutesPerDay = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.HrisTimeOffTypeId = HrisTimeOffTypeId;
        this.HrisTimeOffTypeSecondaryId = HrisTimeOffTypeSecondaryId;
        this.StartDate = StartDate;
        this.BalanceMinutesPerDay = BalanceMinutesPerDay;

    }



    /// <summary>
    /// The ID for activity code associated with time off balance
    /// </summary>
    /// <value>The ID for activity code associated with time off balance</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// The ID of the time off type configured in HRIS integration
    /// </summary>
    /// <value>The ID of the time off type configured in HRIS integration</value>
    [JsonPropertyName("hrisTimeOffTypeId")]
    public string HrisTimeOffTypeId { get; set; }



    /// <summary>
    /// The secondary ID of the time off type configured in HRIS integration
    /// </summary>
    /// <value>The secondary ID of the time off type configured in HRIS integration</value>
    [JsonPropertyName("hrisTimeOffTypeSecondaryId")]
    public string HrisTimeOffTypeSecondaryId { get; set; }



    /// <summary>
    /// The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }



    /// <summary>
    /// The list of available time off balance values in minutes for each day
    /// </summary>
    /// <value>The list of available time off balance values in minutes for each day</value>
    [JsonPropertyName("balanceMinutesPerDay")]
    public List<int?> BalanceMinutesPerDay { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffBalanceResponse {\n");

        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  HrisTimeOffTypeId: ").Append(HrisTimeOffTypeId).Append("\n");
        sb.Append("  HrisTimeOffTypeSecondaryId: ").Append(HrisTimeOffTypeSecondaryId).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  BalanceMinutesPerDay: ").Append(BalanceMinutesPerDay).Append("\n");
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
        return Equals(obj as TimeOffBalanceResponse);
    }

    /// <summary>
    /// Returns true if TimeOffBalanceResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffBalanceResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffBalanceResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                HrisTimeOffTypeId == other.HrisTimeOffTypeId ||
                HrisTimeOffTypeId != null &&
                HrisTimeOffTypeId.Equals(other.HrisTimeOffTypeId)
            ) &&
            (
                HrisTimeOffTypeSecondaryId == other.HrisTimeOffTypeSecondaryId ||
                HrisTimeOffTypeSecondaryId != null &&
                HrisTimeOffTypeSecondaryId.Equals(other.HrisTimeOffTypeSecondaryId)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                BalanceMinutesPerDay == other.BalanceMinutesPerDay ||
                BalanceMinutesPerDay != null &&
                BalanceMinutesPerDay.SequenceEqual(other.BalanceMinutesPerDay)
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
            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (HrisTimeOffTypeId != null)
            {
                hash = hash * 59 + HrisTimeOffTypeId.GetHashCode();
            }

            if (HrisTimeOffTypeSecondaryId != null)
            {
                hash = hash * 59 + HrisTimeOffTypeSecondaryId.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (BalanceMinutesPerDay != null)
            {
                hash = hash * 59 + BalanceMinutesPerDay.GetHashCode();
            }

            return hash;
        }
    }
}
