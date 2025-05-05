using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmScheduleTopicWfmScheduleNotification
/// </summary>

public partial class WfmScheduleTopicWfmScheduleNotification : IEquatable<WfmScheduleTopicWfmScheduleNotification>
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
    /// Gets or Sets EventType
    /// </summary>
    
    public enum EventTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,

        /// <summary>
        /// Enum Import for "Import"
        /// </summary>
        [EnumMember(Value = "Import")]
        Import,

        /// <summary>
        /// Enum Copy for "Copy"
        /// </summary>
        [EnumMember(Value = "Copy")]
        Copy,

        /// <summary>
        /// Enum Generate for "Generate"
        /// </summary>
        [EnumMember(Value = "Generate")]
        Generate,

        /// <summary>
        /// Enum Reschedule for "Reschedule"
        /// </summary>
        [EnumMember(Value = "Reschedule")]
        Reschedule
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [JsonPropertyName("eventType")]
    public EventTypeEnum? EventType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmScheduleTopicWfmScheduleNotification" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    /// <param name="OperationId">OperationId.</param>
    /// <param name="DownloadUrl">DownloadUrl.</param>
    /// <param name="PercentComplete">PercentComplete.</param>
    /// <param name="EventType">EventType.</param>
    public WfmScheduleTopicWfmScheduleNotification(StatusEnum? Status = null, string OperationId = null, string DownloadUrl = null, long? PercentComplete = null, EventTypeEnum? EventType = null)
    {
        this.Status = Status;
        this.OperationId = OperationId;
        this.DownloadUrl = DownloadUrl;
        this.PercentComplete = PercentComplete;
        this.EventType = EventType;

    }





    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [JsonPropertyName("operationId")]
    public string OperationId { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Gets or Sets PercentComplete
    /// </summary>
    [JsonPropertyName("percentComplete")]
    public long? PercentComplete { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmScheduleTopicWfmScheduleNotification {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
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
        return Equals(obj as WfmScheduleTopicWfmScheduleNotification);
    }

    /// <summary>
    /// Returns true if WfmScheduleTopicWfmScheduleNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmScheduleTopicWfmScheduleNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmScheduleTopicWfmScheduleNotification other)
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
                OperationId == other.OperationId ||
                OperationId != null &&
                OperationId.Equals(other.OperationId)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                PercentComplete == other.PercentComplete ||
                PercentComplete != null &&
                PercentComplete.Equals(other.PercentComplete)
            ) &&
            (
                EventType == other.EventType ||
                EventType != null &&
                EventType.Equals(other.EventType)
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

            if (OperationId != null)
            {
                hash = hash * 59 + OperationId.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (PercentComplete != null)
            {
                hash = hash * 59 + PercentComplete.GetHashCode();
            }

            if (EventType != null)
            {
                hash = hash * 59 + EventType.GetHashCode();
            }

            return hash;
        }
    }
}
