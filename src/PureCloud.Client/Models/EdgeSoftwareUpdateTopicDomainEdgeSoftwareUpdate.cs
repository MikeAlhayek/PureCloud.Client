using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate
/// </summary>

public partial class EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate : IEquatable<EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate>
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
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None,

        /// <summary>
        /// Enum Init for "INIT"
        /// </summary>
        [EnumMember(Value = "INIT")]
        Init,

        /// <summary>
        /// Enum InProgress for "IN_PROGRESS"
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        /// Enum Expired for "EXPIRED"
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        /// Enum Exception for "EXCEPTION"
        /// </summary>
        [EnumMember(Value = "EXCEPTION")]
        Exception,

        /// <summary>
        /// Enum Aborted for "ABORTED"
        /// </summary>
        [EnumMember(Value = "ABORTED")]
        Aborted,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Enum Succeeded for "SUCCEEDED"
        /// </summary>
        [EnumMember(Value = "SUCCEEDED")]
        Succeeded,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Status">Status.</param>
    /// <param name="DownloadStartTime">DownloadStartTime.</param>
    /// <param name="ExecuteStartTime">ExecuteStartTime.</param>
    /// <param name="ExecuteStopTime">ExecuteStopTime.</param>
    public EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate(string Id = null, StatusEnum? Status = null, DateTime? DownloadStartTime = null, DateTime? ExecuteStartTime = null, DateTime? ExecuteStopTime = null)
    {
        this.Id = Id;
        this.Status = Status;
        this.DownloadStartTime = DownloadStartTime;
        this.ExecuteStartTime = ExecuteStartTime;
        this.ExecuteStopTime = ExecuteStopTime;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets DownloadStartTime
    /// </summary>
    [JsonPropertyName("downloadStartTime")]
    public DateTime? DownloadStartTime { get; set; }



    /// <summary>
    /// Gets or Sets ExecuteStartTime
    /// </summary>
    [JsonPropertyName("executeStartTime")]
    public DateTime? ExecuteStartTime { get; set; }



    /// <summary>
    /// Gets or Sets ExecuteStopTime
    /// </summary>
    [JsonPropertyName("executeStopTime")]
    public DateTime? ExecuteStopTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DownloadStartTime: ").Append(DownloadStartTime).Append("\n");
        sb.Append("  ExecuteStartTime: ").Append(ExecuteStartTime).Append("\n");
        sb.Append("  ExecuteStopTime: ").Append(ExecuteStopTime).Append("\n");
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
        return Equals(obj as EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate);
    }

    /// <summary>
    /// Returns true if EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DownloadStartTime == other.DownloadStartTime ||
                DownloadStartTime != null &&
                DownloadStartTime.Equals(other.DownloadStartTime)
            ) &&
            (
                ExecuteStartTime == other.ExecuteStartTime ||
                ExecuteStartTime != null &&
                ExecuteStartTime.Equals(other.ExecuteStartTime)
            ) &&
            (
                ExecuteStopTime == other.ExecuteStopTime ||
                ExecuteStopTime != null &&
                ExecuteStopTime.Equals(other.ExecuteStopTime)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DownloadStartTime != null)
            {
                hash = hash * 59 + DownloadStartTime.GetHashCode();
            }

            if (ExecuteStartTime != null)
            {
                hash = hash * 59 + ExecuteStartTime.GetHashCode();
            }

            if (ExecuteStopTime != null)
            {
                hash = hash * 59 + ExecuteStopTime.GetHashCode();
            }

            return hash;
        }
    }
}
