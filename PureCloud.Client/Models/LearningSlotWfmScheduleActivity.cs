using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningSlotWfmScheduleActivity
/// </summary>
[DataContract]
public partial class LearningSlotWfmScheduleActivity : IEquatable<LearningSlotWfmScheduleActivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningSlotWfmScheduleActivity" /> class.
    /// </summary>
    /// <param name="User">User that the schedule is for.</param>
    /// <param name="Activities">List of user&#39;s scheduled activities.</param>
    /// <param name="FullDayTimeOffMarkers">List of user&#39;s days off.</param>
    public LearningSlotWfmScheduleActivity(UserReference User = null, List<LearningSlotScheduleActivity> Activities = null, List<LearningSlotFullDayTimeOffMarker> FullDayTimeOffMarkers = null)
    {
        this.User = User;
        this.Activities = Activities;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;

    }



    /// <summary>
    /// User that the schedule is for
    /// </summary>
    /// <value>User that the schedule is for</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; set; }



    /// <summary>
    /// List of user&#39;s scheduled activities
    /// </summary>
    /// <value>List of user&#39;s scheduled activities</value>
    [DataMember(Name = "activities", EmitDefaultValue = false)]
    public List<LearningSlotScheduleActivity> Activities { get; set; }



    /// <summary>
    /// List of user&#39;s days off
    /// </summary>
    /// <value>List of user&#39;s days off</value>
    [DataMember(Name = "fullDayTimeOffMarkers", EmitDefaultValue = false)]
    public List<LearningSlotFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningSlotWfmScheduleActivity {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
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
        return Equals(obj as LearningSlotWfmScheduleActivity);
    }

    /// <summary>
    /// Returns true if LearningSlotWfmScheduleActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningSlotWfmScheduleActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningSlotWfmScheduleActivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Activities == other.Activities ||
                Activities != null &&
                Activities.SequenceEqual(other.Activities)
            ) &&
            (
                FullDayTimeOffMarkers == other.FullDayTimeOffMarkers ||
                FullDayTimeOffMarkers != null &&
                FullDayTimeOffMarkers.SequenceEqual(other.FullDayTimeOffMarkers)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Activities != null)
            {
                hash = hash * 59 + Activities.GetHashCode();
            }

            if (FullDayTimeOffMarkers != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkers.GetHashCode();
            }

            return hash;
        }
    }
}
