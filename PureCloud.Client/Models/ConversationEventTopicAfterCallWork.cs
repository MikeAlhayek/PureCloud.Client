using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A communication&#39;s after-call work data.
/// </summary>

public partial class ConversationEventTopicAfterCallWork : IEquatable<ConversationEventTopicAfterCallWork>
{
    /// <summary>
    /// The communication's after-call work state.
    /// </summary>
    /// <value>The communication's after-call work state.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Skipped for "skipped"
        /// </summary>
        [EnumMember(Value = "skipped")]
        Skipped,

        /// <summary>
        /// Enum Pending for "pending"
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Enum Complete for "complete"
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,

        /// <summary>
        /// Enum Notapplicable for "notApplicable"
        /// </summary>
        [EnumMember(Value = "notApplicable")]
        Notapplicable
    }
    /// <summary>
    /// The communication's after-call work state.
    /// </summary>
    /// <value>The communication's after-call work state.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventTopicAfterCallWork" /> class.
    /// </summary>
    /// <param name="State">The communication&#39;s after-call work state..</param>
    /// <param name="StartTime">The timestamp when this communication started after-call work in the cloud clock..</param>
    /// <param name="EndTime">The timestamp when this communication ended after-call work in the cloud clock..</param>
    public ConversationEventTopicAfterCallWork(StateEnum? State = null, DateTime? StartTime = null, DateTime? EndTime = null)
    {
        this.State = State;
        this.StartTime = StartTime;
        this.EndTime = EndTime;

    }





    /// <summary>
    /// The timestamp when this communication started after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication started after-call work in the cloud clock.</value>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The timestamp when this communication ended after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication ended after-call work in the cloud clock.</value>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventTopicAfterCallWork {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
        return Equals(obj as ConversationEventTopicAfterCallWork);
    }

    /// <summary>
    /// Returns true if ConversationEventTopicAfterCallWork instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventTopicAfterCallWork to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventTopicAfterCallWork other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
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
            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            return hash;
        }
    }
}
