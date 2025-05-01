using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity
/// </summary>
[DataContract]
public partial class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity : IEquatable<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity>
{
    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReasonEnum
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
        /// Enum Deleteinprogress for "DeleteInProgress"
        /// </summary>
        [EnumMember(Value = "DeleteInProgress")]
        Deleteinprogress,

        /// <summary>
        /// Enum Validationinprogress for "ValidationInProgress"
        /// </summary>
        [EnumMember(Value = "ValidationInProgress")]
        Validationinprogress,

        /// <summary>
        /// Enum Requestidnotfound for "RequestIdNotFound"
        /// </summary>
        [EnumMember(Value = "RequestIdNotFound")]
        Requestidnotfound,

        /// <summary>
        /// Enum Invalidrequest for "InvalidRequest"
        /// </summary>
        [EnumMember(Value = "InvalidRequest")]
        Invalidrequest
    }
    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    public ReasonEnum? Reason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity" /> class.
    /// </summary>
    /// <param name="RequestId">RequestId.</param>
    /// <param name="Reason">Reason.</param>
    public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity(string RequestId = null, ReasonEnum? Reason = null)
    {
        this.RequestId = RequestId;
        this.Reason = Reason;

    }



    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    [DataMember(Name = "requestId", EmitDefaultValue = false)]
    public string RequestId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity {\n");

        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
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
        return Equals(obj as WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity);
    }

    /// <summary>
    /// Returns true if WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RequestId == other.RequestId ||
                RequestId != null &&
                RequestId.Equals(other.RequestId)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
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
            if (RequestId != null)
            {
                hash = hash * 59 + RequestId.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            return hash;
        }
    }
}
