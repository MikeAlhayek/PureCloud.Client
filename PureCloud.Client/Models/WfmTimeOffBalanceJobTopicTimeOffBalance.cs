using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmTimeOffBalanceJobTopicTimeOffBalance
/// </summary>
[DataContract]
public partial class WfmTimeOffBalanceJobTopicTimeOffBalance : IEquatable<WfmTimeOffBalanceJobTopicTimeOffBalance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmTimeOffBalanceJobTopicTimeOffBalance" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">ActivityCodeId.</param>
    /// <param name="HrisTimeOffTypeId">HrisTimeOffTypeId.</param>
    /// <param name="HrisTimeOffTypeSecondaryId">HrisTimeOffTypeSecondaryId.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="BalanceMinutesPerDay">BalanceMinutesPerDay.</param>
    public WfmTimeOffBalanceJobTopicTimeOffBalance(string ActivityCodeId = null, string HrisTimeOffTypeId = null, string HrisTimeOffTypeSecondaryId = null, DateTime? StartDate = null, List<long?> BalanceMinutesPerDay = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.HrisTimeOffTypeId = HrisTimeOffTypeId;
        this.HrisTimeOffTypeSecondaryId = HrisTimeOffTypeSecondaryId;
        this.StartDate = StartDate;
        this.BalanceMinutesPerDay = BalanceMinutesPerDay;

    }



    /// <summary>
    /// Gets or Sets ActivityCodeId
    /// </summary>
    [DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Gets or Sets HrisTimeOffTypeId
    /// </summary>
    [DataMember(Name = "hrisTimeOffTypeId", EmitDefaultValue = false)]
    public string HrisTimeOffTypeId { get; set; }



    /// <summary>
    /// Gets or Sets HrisTimeOffTypeSecondaryId
    /// </summary>
    [DataMember(Name = "hrisTimeOffTypeSecondaryId", EmitDefaultValue = false)]
    public string HrisTimeOffTypeSecondaryId { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets BalanceMinutesPerDay
    /// </summary>
    [DataMember(Name = "balanceMinutesPerDay", EmitDefaultValue = false)]
    public List<long?> BalanceMinutesPerDay { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmTimeOffBalanceJobTopicTimeOffBalance {\n");

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
        return Equals(obj as WfmTimeOffBalanceJobTopicTimeOffBalance);
    }

    /// <summary>
    /// Returns true if WfmTimeOffBalanceJobTopicTimeOffBalance instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmTimeOffBalanceJobTopicTimeOffBalance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmTimeOffBalanceJobTopicTimeOffBalance other)
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
