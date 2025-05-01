using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsRoutingStatusRecord
/// </summary>
[DataContract]
public partial class AnalyticsRoutingStatusRecord : IEquatable<AnalyticsRoutingStatusRecord>
{
    /// <summary>
    /// The user's ACD routing status
    /// </summary>
    /// <value>The user's ACD routing status</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoutingStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum OffQueue for "OFF_QUEUE"
        /// </summary>
        [EnumMember(Value = "OFF_QUEUE")]
        OffQueue,

        /// <summary>
        /// Enum Idle for "IDLE"
        /// </summary>
        [EnumMember(Value = "IDLE")]
        Idle,

        /// <summary>
        /// Enum Interacting for "INTERACTING"
        /// </summary>
        [EnumMember(Value = "INTERACTING")]
        Interacting,

        /// <summary>
        /// Enum NotResponding for "NOT_RESPONDING"
        /// </summary>
        [EnumMember(Value = "NOT_RESPONDING")]
        NotResponding,

        /// <summary>
        /// Enum Communicating for "COMMUNICATING"
        /// </summary>
        [EnumMember(Value = "COMMUNICATING")]
        Communicating
    }
    /// <summary>
    /// The user's ACD routing status
    /// </summary>
    /// <value>The user's ACD routing status</value>
    [DataMember(Name = "routingStatus", EmitDefaultValue = false)]
    public RoutingStatusEnum? RoutingStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsRoutingStatusRecord" /> class.
    /// </summary>
    /// <param name="StartTime">The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndTime">The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RoutingStatus">The user&#39;s ACD routing status.</param>
    public AnalyticsRoutingStatusRecord(DateTime? StartTime = null, DateTime? EndTime = null, RoutingStatusEnum? RoutingStatus = null)
    {
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.RoutingStatus = RoutingStatus;

    }



    /// <summary>
    /// The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public DateTime? EndTime { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsRoutingStatusRecord {\n");

        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
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
        return this.Equals(obj as AnalyticsRoutingStatusRecord);
    }

    /// <summary>
    /// Returns true if AnalyticsRoutingStatusRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsRoutingStatusRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsRoutingStatusRecord other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.StartTime == other.StartTime ||
                this.StartTime != null &&
                this.StartTime.Equals(other.StartTime)
            ) &&
            (
                this.EndTime == other.EndTime ||
                this.EndTime != null &&
                this.EndTime.Equals(other.EndTime)
            ) &&
            (
                this.RoutingStatus == other.RoutingStatus ||
                this.RoutingStatus != null &&
                this.RoutingStatus.Equals(other.RoutingStatus)
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
            if (this.StartTime != null)
            {
                hash = hash * 59 + this.StartTime.GetHashCode();
            }

            if (this.EndTime != null)
            {
                hash = hash * 59 + this.EndTime.GetHashCode();
            }

            if (this.RoutingStatus != null)
            {
                hash = hash * 59 + this.RoutingStatus.GetHashCode();
            }

            return hash;
        }
    }
}
