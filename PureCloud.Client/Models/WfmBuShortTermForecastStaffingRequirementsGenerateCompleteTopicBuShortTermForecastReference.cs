using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference
/// </summary>

public partial class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference : IEquatable<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="WeekDate">WeekDate.</param>
    /// <param name="Description">Description.</param>
    public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference(string Id = null, string WeekDate = null, string Description = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;
        this.Description = Description;

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
    public string WeekDate { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference other)
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
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            return hash;
        }
    }
}
