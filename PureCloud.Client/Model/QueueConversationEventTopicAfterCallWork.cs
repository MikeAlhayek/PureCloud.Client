using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// A communication&#39;s after-call work data.
/// </summary>
[DataContract]
public partial class QueueConversationEventTopicAfterCallWork : IEquatable<QueueConversationEventTopicAfterCallWork>
{
    /// <summary>
    /// The communication's after-call work state.
    /// </summary>
    /// <value>The communication's after-call work state.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicAfterCallWork" /> class.
    /// </summary>
    /// <param name="State">The communication&#39;s after-call work state..</param>
    /// <param name="StartTime">The timestamp when this communication started after-call work in the cloud clock..</param>
    /// <param name="EndTime">The timestamp when this communication ended after-call work in the cloud clock..</param>
    public QueueConversationEventTopicAfterCallWork(StateEnum? State = null, DateTime? StartTime = null, DateTime? EndTime = null)
    {
        this.State = State;
        this.StartTime = StartTime;
        this.EndTime = EndTime;

    }





    /// <summary>
    /// The timestamp when this communication started after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication started after-call work in the cloud clock.</value>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The timestamp when this communication ended after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication ended after-call work in the cloud clock.</value>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public DateTime? EndTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicAfterCallWork {\n");

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
        return this.Equals(obj as QueueConversationEventTopicAfterCallWork);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicAfterCallWork instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicAfterCallWork to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicAfterCallWork other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.StartTime == other.StartTime ||
                this.StartTime != null &&
                this.StartTime.Equals(other.StartTime)
            ) &&
            (
                this.EndTime == other.EndTime ||
                this.EndTime != null &&
                this.EndTime.Equals(other.EndTime)
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
            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.StartTime != null)
            {
                hash = hash * 59 + this.StartTime.GetHashCode();
            }

            if (this.EndTime != null)
            {
                hash = hash * 59 + this.EndTime.GetHashCode();
            }

            return hash;
        }
    }
}
