using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification
/// </summary>
[DataContract]
public partial class PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification : IEquatable<PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
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
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification" /> class.
    /// </summary>
    /// <param name="ScheduleId">ScheduleId.</param>
    /// <param name="WeekDate">WeekDate.</param>
    /// <param name="DownloadUrl">DownloadUrl.</param>
    /// <param name="State">State.</param>
    /// <param name="Error">Error.</param>
    public PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification(string ScheduleId = null, string WeekDate = null, string DownloadUrl = null, StateEnum? State = null, PerformancePredictionCompleteEventTopicErrorBody Error = null)
    {
        this.ScheduleId = ScheduleId;
        this.WeekDate = WeekDate;
        this.DownloadUrl = DownloadUrl;
        this.State = State;
        this.Error = Error;

    }



    /// <summary>
    /// Gets or Sets ScheduleId
    /// </summary>
    [DataMember(Name = "scheduleId", EmitDefaultValue = false)]
    public string ScheduleId { get; set; }



    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public string WeekDate { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }





    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public PerformancePredictionCompleteEventTopicErrorBody Error { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification {\n");

        sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
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
        return Equals(obj as PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification);
    }

    /// <summary>
    /// Returns true if PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PerformancePredictionCompleteEventTopicPerformancePredictionCalculationNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ScheduleId == other.ScheduleId ||
                ScheduleId != null &&
                ScheduleId.Equals(other.ScheduleId)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
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
            if (ScheduleId != null)
            {
                hash = hash * 59 + ScheduleId.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            return hash;
        }
    }
}
