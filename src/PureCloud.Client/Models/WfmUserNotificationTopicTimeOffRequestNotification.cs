using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserNotificationTopicTimeOffRequestNotification
/// </summary>

public partial class WfmUserNotificationTopicTimeOffRequestNotification : IEquatable<WfmUserNotificationTopicTimeOffRequestNotification>
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
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Approved for "APPROVED"
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        /// Enum Denied for "DENIED"
        /// </summary>
        [EnumMember(Value = "DENIED")]
        Denied,

        /// <summary>
        /// Enum Canceled for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        Canceled
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotificationTopicTimeOffRequestNotification" /> class.
    /// </summary>
    /// <param name="TimeOffRequestId">TimeOffRequestId.</param>
    /// <param name="User">User.</param>
    /// <param name="IsFullDayRequest">IsFullDayRequest.</param>
    /// <param name="Status">Status.</param>
    /// <param name="PartialDayStartDateTimes">PartialDayStartDateTimes.</param>
    /// <param name="FullDayManagementUnitDates">FullDayManagementUnitDates.</param>
    public WfmUserNotificationTopicTimeOffRequestNotification(string TimeOffRequestId = null, WfmUserNotificationTopicUserReference User = null, bool? IsFullDayRequest = null, StatusEnum? Status = null, List<DateTime?> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null)
    {
        this.TimeOffRequestId = TimeOffRequestId;
        this.User = User;
        this.IsFullDayRequest = IsFullDayRequest;
        this.Status = Status;
        this.PartialDayStartDateTimes = PartialDayStartDateTimes;
        this.FullDayManagementUnitDates = FullDayManagementUnitDates;

    }



    /// <summary>
    /// Gets or Sets TimeOffRequestId
    /// </summary>
    [JsonPropertyName("timeOffRequestId")]
    public string TimeOffRequestId { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public WfmUserNotificationTopicUserReference User { get; set; }



    /// <summary>
    /// Gets or Sets IsFullDayRequest
    /// </summary>
    [JsonPropertyName("isFullDayRequest")]
    public bool? IsFullDayRequest { get; set; }





    /// <summary>
    /// Gets or Sets PartialDayStartDateTimes
    /// </summary>
    [JsonPropertyName("partialDayStartDateTimes")]
    public List<DateTime?> PartialDayStartDateTimes { get; set; }



    /// <summary>
    /// Gets or Sets FullDayManagementUnitDates
    /// </summary>
    [JsonPropertyName("fullDayManagementUnitDates")]
    public List<string> FullDayManagementUnitDates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserNotificationTopicTimeOffRequestNotification {\n");

        sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  IsFullDayRequest: ").Append(IsFullDayRequest).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
        sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
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
        return Equals(obj as WfmUserNotificationTopicTimeOffRequestNotification);
    }

    /// <summary>
    /// Returns true if WfmUserNotificationTopicTimeOffRequestNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserNotificationTopicTimeOffRequestNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserNotificationTopicTimeOffRequestNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequestId == other.TimeOffRequestId ||
                TimeOffRequestId != null &&
                TimeOffRequestId.Equals(other.TimeOffRequestId)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                IsFullDayRequest == other.IsFullDayRequest ||
                IsFullDayRequest != null &&
                IsFullDayRequest.Equals(other.IsFullDayRequest)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                PartialDayStartDateTimes != null &&
                PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
            ) &&
            (
                FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                FullDayManagementUnitDates != null &&
                FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
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
            if (TimeOffRequestId != null)
            {
                hash = hash * 59 + TimeOffRequestId.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (IsFullDayRequest != null)
            {
                hash = hash * 59 + IsFullDayRequest.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (PartialDayStartDateTimes != null)
            {
                hash = hash * 59 + PartialDayStartDateTimes.GetHashCode();
            }

            if (FullDayManagementUnitDates != null)
            {
                hash = hash * 59 + FullDayManagementUnitDates.GetHashCode();
            }

            return hash;
        }
    }
}
