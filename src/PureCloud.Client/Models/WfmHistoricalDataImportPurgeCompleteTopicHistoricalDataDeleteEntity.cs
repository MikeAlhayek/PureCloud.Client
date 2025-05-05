using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity
/// </summary>

public partial class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity : IEquatable<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity" /> class.
    /// </summary>
    /// <param name="RequestId">RequestId.</param>
    /// <param name="Status">Status.</param>
    public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity(string RequestId = null, StatusEnum? Status = null)
    {
        this.RequestId = RequestId;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity {\n");

        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity);
    }

    /// <summary>
    /// Returns true if WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
