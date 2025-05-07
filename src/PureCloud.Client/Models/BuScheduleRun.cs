using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuScheduleRun
/// </summary>

public partial class BuScheduleRun : IEquatable<BuScheduleRun>
{
    /// <summary>
    /// The state of the generation run
    /// </summary>
    /// <value>The state of the generation run</value>
    
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
    /// The state of the generation run
    /// </summary>
    /// <value>The state of the generation run</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuScheduleRun" /> class.
    /// </summary>
    /// <param name="SchedulerRunId">The scheduler run ID.  Reference this value for support.</param>
    /// <param name="IntradayRescheduling">Whether this is an intraday rescheduling run.</param>
    /// <param name="State">The state of the generation run.</param>
    /// <param name="WeekCount">The number of weeks spanned by the schedule.</param>
    /// <param name="PercentComplete">Percent completion of the schedule run.</param>
    /// <param name="TargetWeek">The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Schedule">The generated schedule.  Null unless the schedule run is complete.</param>
    /// <param name="ScheduleDescription">The description of the generated schedule.</param>
    /// <param name="SchedulingStartTime">When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SchedulingStartedBy">The user who started the scheduling run.</param>
    /// <param name="SchedulingCanceledBy">The user who canceled the scheduling run, if applicable.</param>
    /// <param name="SchedulingCompletedTime">When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="MessageCount">The number of schedule generation messages for this schedule generation run.</param>
    /// <param name="MessageSeverityCounts">The list of schedule generation message counts by severity for this schedule generation run.</param>
    /// <param name="ReschedulingOptions">Rescheduling options for this run.  Null unless intradayRescheduling is true.</param>
    /// <param name="ReschedulingResultExpiration">When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public BuScheduleRun(string SchedulerRunId = null, bool? IntradayRescheduling = null, StateEnum? State = null, int? WeekCount = null, double? PercentComplete = null, string TargetWeek = null, BuScheduleReference Schedule = null, string ScheduleDescription = null, DateTime? SchedulingStartTime = null, UserReference SchedulingStartedBy = null, UserReference SchedulingCanceledBy = null, DateTime? SchedulingCompletedTime = null, int? MessageCount = null, List<SchedulerMessageSeverityCount> MessageSeverityCounts = null, ReschedulingOptionsRunResponse ReschedulingOptions = null, DateTime? ReschedulingResultExpiration = null)
    {
        this.SchedulerRunId = SchedulerRunId;
        this.IntradayRescheduling = IntradayRescheduling;
        this.State = State;
        this.WeekCount = WeekCount;
        this.PercentComplete = PercentComplete;
        this.TargetWeek = TargetWeek;
        this.Schedule = Schedule;
        this.ScheduleDescription = ScheduleDescription;
        this.SchedulingStartTime = SchedulingStartTime;
        this.SchedulingStartedBy = SchedulingStartedBy;
        this.SchedulingCanceledBy = SchedulingCanceledBy;
        this.SchedulingCompletedTime = SchedulingCompletedTime;
        this.MessageCount = MessageCount;
        this.MessageSeverityCounts = MessageSeverityCounts;
        this.ReschedulingOptions = ReschedulingOptions;
        this.ReschedulingResultExpiration = ReschedulingResultExpiration;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The scheduler run ID.  Reference this value for support
    /// </summary>
    /// <value>The scheduler run ID.  Reference this value for support</value>
    [JsonPropertyName("schedulerRunId")]
    public string SchedulerRunId { get; set; }



    /// <summary>
    /// Whether this is an intraday rescheduling run
    /// </summary>
    /// <value>Whether this is an intraday rescheduling run</value>
    [JsonPropertyName("intradayRescheduling")]
    public bool? IntradayRescheduling { get; set; }





    /// <summary>
    /// The number of weeks spanned by the schedule
    /// </summary>
    /// <value>The number of weeks spanned by the schedule</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }



    /// <summary>
    /// Percent completion of the schedule run
    /// </summary>
    /// <value>Percent completion of the schedule run</value>
    [JsonPropertyName("percentComplete")]
    public double? PercentComplete { get; set; }



    /// <summary>
    /// The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("targetWeek")]
    public string TargetWeek { get; set; }



    /// <summary>
    /// The generated schedule.  Null unless the schedule run is complete
    /// </summary>
    /// <value>The generated schedule.  Null unless the schedule run is complete</value>
    [JsonPropertyName("schedule")]
    public BuScheduleReference Schedule { get; set; }



    /// <summary>
    /// The description of the generated schedule
    /// </summary>
    /// <value>The description of the generated schedule</value>
    [JsonPropertyName("scheduleDescription")]
    public string ScheduleDescription { get; set; }



    /// <summary>
    /// When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("schedulingStartTime")]
    public DateTime? SchedulingStartTime { get; set; }



    /// <summary>
    /// The user who started the scheduling run
    /// </summary>
    /// <value>The user who started the scheduling run</value>
    [JsonPropertyName("schedulingStartedBy")]
    public UserReference SchedulingStartedBy { get; set; }



    /// <summary>
    /// The user who canceled the scheduling run, if applicable
    /// </summary>
    /// <value>The user who canceled the scheduling run, if applicable</value>
    [JsonPropertyName("schedulingCanceledBy")]
    public UserReference SchedulingCanceledBy { get; set; }



    /// <summary>
    /// When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("schedulingCompletedTime")]
    public DateTime? SchedulingCompletedTime { get; set; }



    /// <summary>
    /// The number of schedule generation messages for this schedule generation run
    /// </summary>
    /// <value>The number of schedule generation messages for this schedule generation run</value>
    [JsonPropertyName("messageCount")]
    public int? MessageCount { get; set; }



    /// <summary>
    /// The list of schedule generation message counts by severity for this schedule generation run
    /// </summary>
    /// <value>The list of schedule generation message counts by severity for this schedule generation run</value>
    [JsonPropertyName("messageSeverityCounts")]
    public List<SchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }



    /// <summary>
    /// Rescheduling options for this run.  Null unless intradayRescheduling is true
    /// </summary>
    /// <value>Rescheduling options for this run.  Null unless intradayRescheduling is true</value>
    [JsonPropertyName("reschedulingOptions")]
    public ReschedulingOptionsRunResponse ReschedulingOptions { get; set; }



    /// <summary>
    /// When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("reschedulingResultExpiration")]
    public DateTime? ReschedulingResultExpiration { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuScheduleRun {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SchedulerRunId: ").Append(SchedulerRunId).Append("\n");
        sb.Append("  IntradayRescheduling: ").Append(IntradayRescheduling).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
        sb.Append("  TargetWeek: ").Append(TargetWeek).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  ScheduleDescription: ").Append(ScheduleDescription).Append("\n");
        sb.Append("  SchedulingStartTime: ").Append(SchedulingStartTime).Append("\n");
        sb.Append("  SchedulingStartedBy: ").Append(SchedulingStartedBy).Append("\n");
        sb.Append("  SchedulingCanceledBy: ").Append(SchedulingCanceledBy).Append("\n");
        sb.Append("  SchedulingCompletedTime: ").Append(SchedulingCompletedTime).Append("\n");
        sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
        sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
        sb.Append("  ReschedulingOptions: ").Append(ReschedulingOptions).Append("\n");
        sb.Append("  ReschedulingResultExpiration: ").Append(ReschedulingResultExpiration).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as BuScheduleRun);
    }

    /// <summary>
    /// Returns true if BuScheduleRun instances are equal
    /// </summary>
    /// <param name="other">Instance of BuScheduleRun to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuScheduleRun other)
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
                SchedulerRunId == other.SchedulerRunId ||
                SchedulerRunId != null &&
                SchedulerRunId.Equals(other.SchedulerRunId)
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
                PercentComplete == other.PercentComplete ||
                PercentComplete != null &&
                PercentComplete.Equals(other.PercentComplete)
            ) &&
            (
                TargetWeek == other.TargetWeek ||
                TargetWeek != null &&
                TargetWeek.Equals(other.TargetWeek)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                ScheduleDescription == other.ScheduleDescription ||
                ScheduleDescription != null &&
                ScheduleDescription.Equals(other.ScheduleDescription)
            ) &&
            (
                SchedulingStartTime == other.SchedulingStartTime ||
                SchedulingStartTime != null &&
                SchedulingStartTime.Equals(other.SchedulingStartTime)
            ) &&
            (
                SchedulingStartedBy == other.SchedulingStartedBy ||
                SchedulingStartedBy != null &&
                SchedulingStartedBy.Equals(other.SchedulingStartedBy)
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
            ) &&
            (
                ReschedulingOptions == other.ReschedulingOptions ||
                ReschedulingOptions != null &&
                ReschedulingOptions.Equals(other.ReschedulingOptions)
            ) &&
            (
                ReschedulingResultExpiration == other.ReschedulingResultExpiration ||
                ReschedulingResultExpiration != null &&
                ReschedulingResultExpiration.Equals(other.ReschedulingResultExpiration)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (SchedulerRunId != null)
            {
                hash = hash * 59 + SchedulerRunId.GetHashCode();
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

            if (PercentComplete != null)
            {
                hash = hash * 59 + PercentComplete.GetHashCode();
            }

            if (TargetWeek != null)
            {
                hash = hash * 59 + TargetWeek.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (ScheduleDescription != null)
            {
                hash = hash * 59 + ScheduleDescription.GetHashCode();
            }

            if (SchedulingStartTime != null)
            {
                hash = hash * 59 + SchedulingStartTime.GetHashCode();
            }

            if (SchedulingStartedBy != null)
            {
                hash = hash * 59 + SchedulingStartedBy.GetHashCode();
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

            if (ReschedulingOptions != null)
            {
                hash = hash * 59 + ReschedulingOptions.GetHashCode();
            }

            if (ReschedulingResultExpiration != null)
            {
                hash = hash * 59 + ReschedulingResultExpiration.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
