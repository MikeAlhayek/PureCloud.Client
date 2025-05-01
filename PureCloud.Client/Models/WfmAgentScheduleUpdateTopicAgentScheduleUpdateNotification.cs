using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification
/// </summary>
[DataContract]
public partial class WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification : IEquatable<WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="EndDate">EndDate.</param>
    /// <param name="Updates">Updates.</param>
    public WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification(WfmAgentScheduleUpdateTopicUserReference User = null, DateTime? StartDate = null, DateTime? EndDate = null, List<WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate> Updates = null)
    {
        this.User = User;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.Updates = Updates;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public WfmAgentScheduleUpdateTopicUserReference User { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Gets or Sets Updates
    /// </summary>
    [DataMember(Name = "updates", EmitDefaultValue = false)]
    public List<WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate> Updates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  Updates: ").Append(Updates).Append("\n");
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
        return Equals(obj as WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification);
    }

    /// <summary>
    /// Returns true if WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification other)
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
                Updates == other.Updates ||
                Updates != null &&
                Updates.SequenceEqual(other.Updates)
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

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (Updates != null)
            {
                hash = hash * 59 + Updates.GetHashCode();
            }

            return hash;
        }
    }
}
