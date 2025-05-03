using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmScheduleActivity
/// </summary>

public partial class WfmScheduleActivity : IEquatable<WfmScheduleActivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmScheduleActivity" /> class.
    /// </summary>
    public WfmScheduleActivity()
    {

    }



    /// <summary>
    /// ID of user that the schedule is for
    /// </summary>
    /// <value>ID of user that the schedule is for</value>
    [JsonPropertyName("userReference")]
    public UserReference UserReference { get; private set; }



    /// <summary>
    /// List of user&#39;s scheduled activities
    /// </summary>
    /// <value>List of user&#39;s scheduled activities</value>
    [JsonPropertyName("activities")]
    public List<ScheduleActivity> Activities { get; private set; }



    /// <summary>
    /// List of user&#39;s days off
    /// </summary>
    /// <value>List of user&#39;s days off</value>
    [JsonPropertyName("fullDayTimeOffMarkers")]
    public List<FullDayTimeOffMarker> FullDayTimeOffMarkers { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmScheduleActivity {\n");

        sb.Append("  UserReference: ").Append(UserReference).Append("\n");
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
        return Equals(obj as WfmScheduleActivity);
    }

    /// <summary>
    /// Returns true if WfmScheduleActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmScheduleActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmScheduleActivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserReference == other.UserReference ||
                UserReference != null &&
                UserReference.Equals(other.UserReference)
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
            if (UserReference != null)
            {
                hash = hash * 59 + UserReference.GetHashCode();
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
