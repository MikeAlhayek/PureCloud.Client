using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsQueueEventsNotificationAssignmentSegment
/// </summary>
[DataContract]
public partial class WorkitemsQueueEventsNotificationAssignmentSegment : IEquatable<WorkitemsQueueEventsNotificationAssignmentSegment>
{
    /// <summary>
    /// Gets or Sets StartState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StartStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

        /// <summary>
        /// Enum Acdstarted for "AcdStarted"
        /// </summary>
        [EnumMember(Value = "AcdStarted")]
        Acdstarted,

        /// <summary>
        /// Enum Alerting for "Alerting"
        /// </summary>
        [EnumMember(Value = "Alerting")]
        Alerting,

        /// <summary>
        /// Enum Alerttimeout for "AlertTimeout"
        /// </summary>
        [EnumMember(Value = "AlertTimeout")]
        Alerttimeout,

        /// <summary>
        /// Enum Declined for "Declined"
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined,

        /// <summary>
        /// Enum Connected for "Connected"
        /// </summary>
        [EnumMember(Value = "Connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "Disconnected"
        /// </summary>
        [EnumMember(Value = "Disconnected")]
        Disconnected,

        /// <summary>
        /// Enum Parked for "Parked"
        /// </summary>
        [EnumMember(Value = "Parked")]
        Parked,

        /// <summary>
        /// Enum Held for "Held"
        /// </summary>
        [EnumMember(Value = "Held")]
        Held,

        /// <summary>
        /// Enum Acdcancelled for "AcdCancelled"
        /// </summary>
        [EnumMember(Value = "AcdCancelled")]
        Acdcancelled,

        /// <summary>
        /// Enum Terminated for "Terminated"
        /// </summary>
        [EnumMember(Value = "Terminated")]
        Terminated,

        /// <summary>
        /// Enum Acdexpired for "AcdExpired"
        /// </summary>
        [EnumMember(Value = "AcdExpired")]
        Acdexpired
    }
    /// <summary>
    /// Gets or Sets EndState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EndStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

        /// <summary>
        /// Enum Acdstarted for "AcdStarted"
        /// </summary>
        [EnumMember(Value = "AcdStarted")]
        Acdstarted,

        /// <summary>
        /// Enum Alerting for "Alerting"
        /// </summary>
        [EnumMember(Value = "Alerting")]
        Alerting,

        /// <summary>
        /// Enum Alerttimeout for "AlertTimeout"
        /// </summary>
        [EnumMember(Value = "AlertTimeout")]
        Alerttimeout,

        /// <summary>
        /// Enum Declined for "Declined"
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined,

        /// <summary>
        /// Enum Connected for "Connected"
        /// </summary>
        [EnumMember(Value = "Connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "Disconnected"
        /// </summary>
        [EnumMember(Value = "Disconnected")]
        Disconnected,

        /// <summary>
        /// Enum Parked for "Parked"
        /// </summary>
        [EnumMember(Value = "Parked")]
        Parked,

        /// <summary>
        /// Enum Held for "Held"
        /// </summary>
        [EnumMember(Value = "Held")]
        Held,

        /// <summary>
        /// Enum Acdcancelled for "AcdCancelled"
        /// </summary>
        [EnumMember(Value = "AcdCancelled")]
        Acdcancelled,

        /// <summary>
        /// Enum Terminated for "Terminated"
        /// </summary>
        [EnumMember(Value = "Terminated")]
        Terminated,

        /// <summary>
        /// Enum Acdexpired for "AcdExpired"
        /// </summary>
        [EnumMember(Value = "AcdExpired")]
        Acdexpired
    }
    /// <summary>
    /// Gets or Sets StartState
    /// </summary>
    [DataMember(Name = "startState", EmitDefaultValue = false)]
    public StartStateEnum? StartState { get; set; }
    /// <summary>
    /// Gets or Sets EndState
    /// </summary>
    [DataMember(Name = "endState", EmitDefaultValue = false)]
    public EndStateEnum? EndState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsQueueEventsNotificationAssignmentSegment" /> class.
    /// </summary>
    /// <param name="StartState">StartState.</param>
    /// <param name="EndState">EndState.</param>
    /// <param name="DurationMs">DurationMs.</param>
    public WorkitemsQueueEventsNotificationAssignmentSegment(StartStateEnum? StartState = null, EndStateEnum? EndState = null, long? DurationMs = null)
    {
        this.StartState = StartState;
        this.EndState = EndState;
        this.DurationMs = DurationMs;

    }







    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    [DataMember(Name = "durationMs", EmitDefaultValue = false)]
    public long? DurationMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsQueueEventsNotificationAssignmentSegment {\n");

        sb.Append("  StartState: ").Append(StartState).Append("\n");
        sb.Append("  EndState: ").Append(EndState).Append("\n");
        sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
        return Equals(obj as WorkitemsQueueEventsNotificationAssignmentSegment);
    }

    /// <summary>
    /// Returns true if WorkitemsQueueEventsNotificationAssignmentSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsQueueEventsNotificationAssignmentSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsQueueEventsNotificationAssignmentSegment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartState == other.StartState ||
                StartState != null &&
                StartState.Equals(other.StartState)
            ) &&
            (
                EndState == other.EndState ||
                EndState != null &&
                EndState.Equals(other.EndState)
            ) &&
            (
                DurationMs == other.DurationMs ||
                DurationMs != null &&
                DurationMs.Equals(other.DurationMs)
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
            if (StartState != null)
            {
                hash = hash * 59 + StartState.GetHashCode();
            }

            if (EndState != null)
            {
                hash = hash * 59 + EndState.GetHashCode();
            }

            if (DurationMs != null)
            {
                hash = hash * 59 + DurationMs.GetHashCode();
            }

            return hash;
        }
    }
}
