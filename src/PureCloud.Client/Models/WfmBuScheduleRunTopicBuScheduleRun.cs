using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuScheduleRunTopicBuScheduleRun
/// </summary>

public partial class WfmBuScheduleRunTopicBuScheduleRun : IEquatable<WfmBuScheduleRunTopicBuScheduleRun>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,

        /// <summary>
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Scheduling for "Scheduling"
        /// </summary>
        [EnumMember(Value = "Scheduling")]
        Scheduling,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuScheduleRunTopicBuScheduleRun" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="PercentComplete">PercentComplete.</param>
    /// <param name="IntradayRescheduling">IntradayRescheduling.</param>
    /// <param name="State">State.</param>
    /// <param name="WeekCount">WeekCount.</param>
    /// <param name="Schedule">Schedule.</param>
    /// <param name="SchedulingCanceledBy">SchedulingCanceledBy.</param>
    /// <param name="SchedulingCompletedTime">SchedulingCompletedTime.</param>
    /// <param name="MessageCount">MessageCount.</param>
    /// <param name="MessageSeverityCounts">MessageSeverityCounts.</param>
    public WfmBuScheduleRunTopicBuScheduleRun(string Id = null, double? PercentComplete = null, bool? IntradayRescheduling = null, StateEnum? State = null, long? WeekCount = null, WfmBuScheduleRunTopicBuScheduleReference Schedule = null, WfmBuScheduleRunTopicUserReference SchedulingCanceledBy = null, string SchedulingCompletedTime = null, long? MessageCount = null, List<WfmBuScheduleRunTopicSchedulerMessageSeverityCount> MessageSeverityCounts = null)
    {
        this.Id = Id;
        this.PercentComplete = PercentComplete;
        this.IntradayRescheduling = IntradayRescheduling;
        this.State = State;
        this.WeekCount = WeekCount;
        this.Schedule = Schedule;
        this.SchedulingCanceledBy = SchedulingCanceledBy;
        this.SchedulingCompletedTime = SchedulingCompletedTime;
        this.MessageCount = MessageCount;
        this.MessageSeverityCounts = MessageSeverityCounts;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets PercentComplete
    /// </summary>
    [JsonPropertyName("percentComplete")]
    public double? PercentComplete { get; set; }



    /// <summary>
    /// Gets or Sets IntradayRescheduling
    /// </summary>
    [JsonPropertyName("intradayRescheduling")]
    public bool? IntradayRescheduling { get; set; }





    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    [JsonPropertyName("weekCount")]
    public long? WeekCount { get; set; }



    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [JsonPropertyName("schedule")]
    public WfmBuScheduleRunTopicBuScheduleReference Schedule { get; set; }



    /// <summary>
    /// Gets or Sets SchedulingCanceledBy
    /// </summary>
    [JsonPropertyName("schedulingCanceledBy")]
    public WfmBuScheduleRunTopicUserReference SchedulingCanceledBy { get; set; }



    /// <summary>
    /// Gets or Sets SchedulingCompletedTime
    /// </summary>
    [JsonPropertyName("schedulingCompletedTime")]
    public string SchedulingCompletedTime { get; set; }



    /// <summary>
    /// Gets or Sets MessageCount
    /// </summary>
    [JsonPropertyName("messageCount")]
    public long? MessageCount { get; set; }



    /// <summary>
    /// Gets or Sets MessageSeverityCounts
    /// </summary>
    [JsonPropertyName("messageSeverityCounts")]
    public List<WfmBuScheduleRunTopicSchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuScheduleRunTopicBuScheduleRun {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
        sb.Append("  IntradayRescheduling: ").Append(IntradayRescheduling).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  SchedulingCanceledBy: ").Append(SchedulingCanceledBy).Append("\n");
        sb.Append("  SchedulingCompletedTime: ").Append(SchedulingCompletedTime).Append("\n");
        sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
        sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
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
        return Equals(obj as WfmBuScheduleRunTopicBuScheduleRun);
    }

    /// <summary>
    /// Returns true if WfmBuScheduleRunTopicBuScheduleRun instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuScheduleRunTopicBuScheduleRun to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuScheduleRunTopicBuScheduleRun other)
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
                PercentComplete == other.PercentComplete ||
                PercentComplete != null &&
                PercentComplete.Equals(other.PercentComplete)
            ) &&
            (
                IntradayRescheduling == other.IntradayRescheduling ||
                IntradayRescheduling != null &&
                IntradayRescheduling.Equals(other.IntradayRescheduling)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                SchedulingCanceledBy == other.SchedulingCanceledBy ||
                SchedulingCanceledBy != null &&
                SchedulingCanceledBy.Equals(other.SchedulingCanceledBy)
            ) &&
            (
                SchedulingCompletedTime == other.SchedulingCompletedTime ||
                SchedulingCompletedTime != null &&
                SchedulingCompletedTime.Equals(other.SchedulingCompletedTime)
            ) &&
            (
                MessageCount == other.MessageCount ||
                MessageCount != null &&
                MessageCount.Equals(other.MessageCount)
            ) &&
            (
                MessageSeverityCounts == other.MessageSeverityCounts ||
                MessageSeverityCounts != null &&
                MessageSeverityCounts.SequenceEqual(other.MessageSeverityCounts)
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

            if (PercentComplete != null)
            {
                hash = hash * 59 + PercentComplete.GetHashCode();
            }

            if (IntradayRescheduling != null)
            {
                hash = hash * 59 + IntradayRescheduling.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (SchedulingCanceledBy != null)
            {
                hash = hash * 59 + SchedulingCanceledBy.GetHashCode();
            }

            if (SchedulingCompletedTime != null)
            {
                hash = hash * 59 + SchedulingCompletedTime.GetHashCode();
            }

            if (MessageCount != null)
            {
                hash = hash * 59 + MessageCount.GetHashCode();
            }

            if (MessageSeverityCounts != null)
            {
                hash = hash * 59 + MessageSeverityCounts.GetHashCode();
            }

            return hash;
        }
    }
}
