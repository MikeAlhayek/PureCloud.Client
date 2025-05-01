using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PersistentConnectionChangeTopicPersistentConnectionChangeEvent
/// </summary>
[DataContract]
public partial class PersistentConnectionChangeTopicPersistentConnectionChangeEvent : IEquatable<PersistentConnectionChangeTopicPersistentConnectionChangeEvent>
{
    /// <summary>
    /// Gets or Sets PersistentState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersistentStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Persisted for "PERSISTED"
        /// </summary>
        [EnumMember(Value = "PERSISTED")]
        Persisted,

        /// <summary>
        /// Enum ActiveCall for "ACTIVE_CALL"
        /// </summary>
        [EnumMember(Value = "ACTIVE_CALL")]
        ActiveCall,

        /// <summary>
        /// Enum Disconnected for "DISCONNECTED"
        /// </summary>
        [EnumMember(Value = "DISCONNECTED")]
        Disconnected,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// Gets or Sets PersistentState
    /// </summary>
    [DataMember(Name = "persistentState", EmitDefaultValue = false)]
    public PersistentStateEnum? PersistentState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PersistentConnectionChangeTopicPersistentConnectionChangeEvent" /> class.
    /// </summary>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    /// <param name="StationId">StationId.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="PersistentState">PersistentState.</param>
    /// <param name="EventTime">EventTime.</param>
    public PersistentConnectionChangeTopicPersistentConnectionChangeEvent(PersistentConnectionChangeTopicErrorInfo ErrorInfo = null, string StationId = null, string UserId = null, PersistentStateEnum? PersistentState = null, DateTime? EventTime = null)
    {
        this.ErrorInfo = ErrorInfo;
        this.StationId = StationId;
        this.UserId = UserId;
        this.PersistentState = PersistentState;
        this.EventTime = EventTime;

    }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [DataMember(Name = "errorInfo", EmitDefaultValue = false)]
    public PersistentConnectionChangeTopicErrorInfo ErrorInfo { get; set; }



    /// <summary>
    /// Gets or Sets StationId
    /// </summary>
    [DataMember(Name = "stationId", EmitDefaultValue = false)]
    public string StationId { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }





    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PersistentConnectionChangeTopicPersistentConnectionChangeEvent {\n");

        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  StationId: ").Append(StationId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  PersistentState: ").Append(PersistentState).Append("\n");
        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
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
        return Equals(obj as PersistentConnectionChangeTopicPersistentConnectionChangeEvent);
    }

    /// <summary>
    /// Returns true if PersistentConnectionChangeTopicPersistentConnectionChangeEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of PersistentConnectionChangeTopicPersistentConnectionChangeEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PersistentConnectionChangeTopicPersistentConnectionChangeEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                StationId == other.StationId ||
                StationId != null &&
                StationId.Equals(other.StationId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                PersistentState == other.PersistentState ||
                PersistentState != null &&
                PersistentState.Equals(other.PersistentState)
            ) &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
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
            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (StationId != null)
            {
                hash = hash * 59 + StationId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (PersistentState != null)
            {
                hash = hash * 59 + PersistentState.GetHashCode();
            }

            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            return hash;
        }
    }
}
