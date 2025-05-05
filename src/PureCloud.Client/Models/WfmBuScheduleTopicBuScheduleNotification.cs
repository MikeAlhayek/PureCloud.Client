using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuScheduleTopicBuScheduleNotification
/// </summary>

public partial class WfmBuScheduleTopicBuScheduleNotification : IEquatable<WfmBuScheduleTopicBuScheduleNotification>
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
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete
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
    /// Initializes a new instance of the <see cref="WfmBuScheduleTopicBuScheduleNotification" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    /// <param name="OperationId">OperationId.</param>
    /// <param name="EventType">EventType.</param>
    /// <param name="Result">Result.</param>
    public WfmBuScheduleTopicBuScheduleNotification(StatusEnum? Status = null, string OperationId = null, EventTypeEnum? EventType = null, WfmBuScheduleTopicBuScheduleMetadata Result = null)
    {
        this.Status = Status;
        this.OperationId = OperationId;
        this.EventType = EventType;
        this.Result = Result;

    }





    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [JsonPropertyName("operationId")]
    public string OperationId { get; set; }





    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [JsonPropertyName("result")]
    public WfmBuScheduleTopicBuScheduleMetadata Result { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuScheduleTopicBuScheduleNotification {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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
        return Equals(obj as WfmBuScheduleTopicBuScheduleNotification);
    }

    /// <summary>
    /// Returns true if WfmBuScheduleTopicBuScheduleNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuScheduleTopicBuScheduleNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuScheduleTopicBuScheduleNotification other)
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
                EventType == other.EventType ||
                EventType != null &&
                EventType.Equals(other.EventType)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
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

            if (EventType != null)
            {
                hash = hash * 59 + EventType.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            return hash;
        }
    }
}
