using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder
/// </summary>
[DataContract]
public partial class WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder : IEquatable<WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder" /> class.
    /// </summary>
    /// <param name="ActivityCategory">ActivityCategory.</param>
    /// <param name="StartDate">StartDate.</param>
    public WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder(string ActivityCategory = null, DateTime? StartDate = null)
    {
        this.ActivityCategory = ActivityCategory;
        this.StartDate = StartDate;

    }



    /// <summary>
    /// Gets or Sets ActivityCategory
    /// </summary>
    [DataMember(Name = "activityCategory", EmitDefaultValue = false)]
    public string ActivityCategory { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder {\n");

        sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
        return this.Equals(obj as WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder);
    }

    /// <summary>
    /// Returns true if WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.ActivityCategory == other.ActivityCategory ||
                this.ActivityCategory != null &&
                this.ActivityCategory.Equals(other.ActivityCategory)
            ) &&
            (
                this.StartDate == other.StartDate ||
                this.StartDate != null &&
                this.StartDate.Equals(other.StartDate)
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
            if (this.ActivityCategory != null)
            {
                hash = hash * 59 + this.ActivityCategory.GetHashCode();
            }

            if (this.StartDate != null)
            {
                hash = hash * 59 + this.StartDate.GetHashCode();
            }

            return hash;
        }
    }
}
