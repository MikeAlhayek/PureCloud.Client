using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification
/// </summary>
[DataContract]
public partial class WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification : IEquatable<WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
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
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    /// <param name="Result">Result.</param>
    /// <param name="OperationId">OperationId.</param>
    /// <param name="Progress">Progress.</param>
    public WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification(StatusEnum? Status = null, WfmBuShortTermForecastGenerateProgressTopicBuShortTermForecast Result = null, string OperationId = null, long? Progress = null)
    {
        this.Status = Status;
        this.Result = Result;
        this.OperationId = OperationId;
        this.Progress = Progress;

    }





    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public WfmBuShortTermForecastGenerateProgressTopicBuShortTermForecast Result { get; set; }



    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name = "operationId", EmitDefaultValue = false)]
    public string OperationId { get; set; }



    /// <summary>
    /// Gets or Sets Progress
    /// </summary>
    [DataMember(Name = "progress", EmitDefaultValue = false)]
    public long? Progress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  Progress: ").Append(Progress).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
            ) &&
            (
                OperationId == other.OperationId ||
                OperationId != null &&
                OperationId.Equals(other.OperationId)
            ) &&
            (
                Progress == other.Progress ||
                Progress != null &&
                Progress.Equals(other.Progress)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            if (OperationId != null)
            {
                hash = hash * 59 + OperationId.GetHashCode();
            }

            if (Progress != null)
            {
                hash = hash * 59 + Progress.GetHashCode();
            }

            return hash;
        }
    }
}
