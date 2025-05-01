using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification
/// </summary>
[DataContract]
public partial class WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification : IEquatable<WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification>
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
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification" /> class.
    /// </summary>
    /// <param name="OperationId">OperationId.</param>
    /// <param name="DownloadUrls">DownloadUrls.</param>
    /// <param name="State">State.</param>
    public WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification(string OperationId = null, List<string> DownloadUrls = null, StateEnum? State = null)
    {
        this.OperationId = OperationId;
        this.DownloadUrls = DownloadUrls;
        this.State = State;

    }



    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name = "operationId", EmitDefaultValue = false)]
    public string OperationId { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUrls
    /// </summary>
    [DataMember(Name = "downloadUrls", EmitDefaultValue = false)]
    public List<string> DownloadUrls { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification {\n");

        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification);
    }

    /// <summary>
    /// Returns true if WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalShrinkageCalculationsCompleteTopicHistoricalShrinkageCalculationsCompleteNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OperationId == other.OperationId ||
                OperationId != null &&
                OperationId.Equals(other.OperationId)
            ) &&
            (
                DownloadUrls == other.DownloadUrls ||
                DownloadUrls != null &&
                DownloadUrls.SequenceEqual(other.DownloadUrls)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (OperationId != null)
            {
                hash = hash * 59 + OperationId.GetHashCode();
            }

            if (DownloadUrls != null)
            {
                hash = hash * 59 + DownloadUrls.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
