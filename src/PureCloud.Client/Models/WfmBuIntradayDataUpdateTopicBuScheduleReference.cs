using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuIntradayDataUpdateTopicBuScheduleReference
/// </summary>

public partial class WfmBuIntradayDataUpdateTopicBuScheduleReference : IEquatable<WfmBuIntradayDataUpdateTopicBuScheduleReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuScheduleReference" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="WeekDate">WeekDate.</param>
    public WfmBuIntradayDataUpdateTopicBuScheduleReference(string Id = null, DateTime? WeekDate = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    [JsonPropertyName("weekDate")]
    public DateTime? WeekDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuIntradayDataUpdateTopicBuScheduleReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
        return Equals(obj as WfmBuIntradayDataUpdateTopicBuScheduleReference);
    }

    /// <summary>
    /// Returns true if WfmBuIntradayDataUpdateTopicBuScheduleReference instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuScheduleReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuIntradayDataUpdateTopicBuScheduleReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            return hash;
        }
    }
}
