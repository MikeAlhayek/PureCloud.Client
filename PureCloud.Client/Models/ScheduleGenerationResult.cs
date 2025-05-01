using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ScheduleGenerationResult
/// </summary>
[DataContract]
public partial class ScheduleGenerationResult : IEquatable<ScheduleGenerationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScheduleGenerationResult" /> class.
    /// </summary>
    /// <param name="Failed">Whether the schedule generation run failed.</param>
    /// <param name="RunId">The ID of the schedule generation run. Reference this when requesting support.</param>
    /// <param name="MessageCount">The number of schedule generation messages for this schedule generation run.</param>
    /// <param name="Messages">User facing messages related to the schedule generation run.</param>
    /// <param name="MessageSeverities">The list of messages by severity in this schedule generation run.</param>
    public ScheduleGenerationResult(bool? Failed = null, string RunId = null, int? MessageCount = null, List<ScheduleGenerationMessage> Messages = null, List<SchedulerMessageTypeSeverity> MessageSeverities = null)
    {
        this.Failed = Failed;
        this.RunId = RunId;
        this.MessageCount = MessageCount;
        this.Messages = Messages;
        this.MessageSeverities = MessageSeverities;

    }



    /// <summary>
    /// Whether the schedule generation run failed
    /// </summary>
    /// <value>Whether the schedule generation run failed</value>
    [DataMember(Name = "failed", EmitDefaultValue = false)]
    public bool? Failed { get; set; }



    /// <summary>
    /// The ID of the schedule generation run. Reference this when requesting support
    /// </summary>
    /// <value>The ID of the schedule generation run. Reference this when requesting support</value>
    [DataMember(Name = "runId", EmitDefaultValue = false)]
    public string RunId { get; set; }



    /// <summary>
    /// The number of schedule generation messages for this schedule generation run
    /// </summary>
    /// <value>The number of schedule generation messages for this schedule generation run</value>
    [DataMember(Name = "messageCount", EmitDefaultValue = false)]
    public int? MessageCount { get; set; }



    /// <summary>
    /// User facing messages related to the schedule generation run
    /// </summary>
    /// <value>User facing messages related to the schedule generation run</value>
    [DataMember(Name = "messages", EmitDefaultValue = false)]
    public List<ScheduleGenerationMessage> Messages { get; set; }



    /// <summary>
    /// The list of messages by severity in this schedule generation run
    /// </summary>
    /// <value>The list of messages by severity in this schedule generation run</value>
    [DataMember(Name = "messageSeverities", EmitDefaultValue = false)]
    public List<SchedulerMessageTypeSeverity> MessageSeverities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScheduleGenerationResult {\n");

        sb.Append("  Failed: ").Append(Failed).Append("\n");
        sb.Append("  RunId: ").Append(RunId).Append("\n");
        sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
        sb.Append("  MessageSeverities: ").Append(MessageSeverities).Append("\n");
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
        return Equals(obj as ScheduleGenerationResult);
    }

    /// <summary>
    /// Returns true if ScheduleGenerationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of ScheduleGenerationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScheduleGenerationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Failed == other.Failed ||
                Failed != null &&
                Failed.Equals(other.Failed)
            ) &&
            (
                RunId == other.RunId ||
                RunId != null &&
                RunId.Equals(other.RunId)
            ) &&
            (
                MessageCount == other.MessageCount ||
                MessageCount != null &&
                MessageCount.Equals(other.MessageCount)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.SequenceEqual(other.Messages)
            ) &&
            (
                MessageSeverities == other.MessageSeverities ||
                MessageSeverities != null &&
                MessageSeverities.SequenceEqual(other.MessageSeverities)
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
            if (Failed != null)
            {
                hash = hash * 59 + Failed.GetHashCode();
            }

            if (RunId != null)
            {
                hash = hash * 59 + RunId.GetHashCode();
            }

            if (MessageCount != null)
            {
                hash = hash * 59 + MessageCount.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            if (MessageSeverities != null)
            {
                hash = hash * 59 + MessageSeverities.GetHashCode();
            }

            return hash;
        }
    }
}
