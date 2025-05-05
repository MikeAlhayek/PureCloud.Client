using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningScheduleSlotsQueryRequest
/// </summary>

public partial class LearningScheduleSlotsQueryRequest : IEquatable<LearningScheduleSlotsQueryRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningScheduleSlotsQueryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningScheduleSlotsQueryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningScheduleSlotsQueryRequest" /> class.
    /// </summary>
    /// <param name="Interval">Range of time to get slots for scheduling learning activities. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="LengthInMinutes">The duration of Learning Assignment to schedule in 15 minutes granularity (required).</param>
    /// <param name="UserIds">The user IDs for which to fetch schedules. Must be only 1. (required).</param>
    /// <param name="InterruptibleAssignmentId">Assignment ID to exclude from consideration when determining blocked slots.</param>
    public LearningScheduleSlotsQueryRequest(string Interval = null, int? LengthInMinutes = null, List<string> UserIds = null, string InterruptibleAssignmentId = null)
    {
        this.Interval = Interval;
        this.LengthInMinutes = LengthInMinutes;
        this.UserIds = UserIds;
        this.InterruptibleAssignmentId = InterruptibleAssignmentId;

    }



    /// <summary>
    /// Range of time to get slots for scheduling learning activities. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Range of time to get slots for scheduling learning activities. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// The duration of Learning Assignment to schedule in 15 minutes granularity
    /// </summary>
    /// <value>The duration of Learning Assignment to schedule in 15 minutes granularity</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// The user IDs for which to fetch schedules. Must be only 1.
    /// </summary>
    /// <value>The user IDs for which to fetch schedules. Must be only 1.</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// Assignment ID to exclude from consideration when determining blocked slots
    /// </summary>
    /// <value>Assignment ID to exclude from consideration when determining blocked slots</value>
    [JsonPropertyName("interruptibleAssignmentId")]
    public string InterruptibleAssignmentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningScheduleSlotsQueryRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  InterruptibleAssignmentId: ").Append(InterruptibleAssignmentId).Append("\n");
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
        return Equals(obj as LearningScheduleSlotsQueryRequest);
    }

    /// <summary>
    /// Returns true if LearningScheduleSlotsQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningScheduleSlotsQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningScheduleSlotsQueryRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
            ) &&
            (
                InterruptibleAssignmentId == other.InterruptibleAssignmentId ||
                InterruptibleAssignmentId != null &&
                InterruptibleAssignmentId.Equals(other.InterruptibleAssignmentId)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (InterruptibleAssignmentId != null)
            {
                hash = hash * 59 + InterruptibleAssignmentId.GetHashCode();
            }

            return hash;
        }
    }
}
