using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsResolution
/// </summary>
[DataContract]
public partial class AnalyticsResolution : IEquatable<AnalyticsResolution>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsResolution" /> class.
    /// </summary>
    /// <param name="EventTime">Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="QueueId">The ID of the last queue on which the conversation was handled..</param>
    /// <param name="UserId">The ID of the last user who handled the conversation..</param>
    /// <param name="NNextContactAvoided">NNextContactAvoided.</param>
    public AnalyticsResolution(DateTime? EventTime = null, string QueueId = null, string UserId = null, long? NNextContactAvoided = null)
    {
        this.EventTime = EventTime;
        this.QueueId = QueueId;
        this.UserId = UserId;
        this.NNextContactAvoided = NNextContactAvoided;

    }



    /// <summary>
    /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// The ID of the last queue on which the conversation was handled.
    /// </summary>
    /// <value>The ID of the last queue on which the conversation was handled.</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// The ID of the last user who handled the conversation.
    /// </summary>
    /// <value>The ID of the last user who handled the conversation.</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets NNextContactAvoided
    /// </summary>
    [DataMember(Name = "nNextContactAvoided", EmitDefaultValue = false)]
    public long? NNextContactAvoided { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsResolution {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  NNextContactAvoided: ").Append(NNextContactAvoided).Append("\n");
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
        return Equals(obj as AnalyticsResolution);
    }

    /// <summary>
    /// Returns true if AnalyticsResolution instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsResolution to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsResolution other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                NNextContactAvoided == other.NNextContactAvoided ||
                NNextContactAvoided != null &&
                NNextContactAvoided.Equals(other.NNextContactAvoided)
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
            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (NNextContactAvoided != null)
            {
                hash = hash * 59 + NNextContactAvoided.GetHashCode();
            }

            return hash;
        }
    }
}
