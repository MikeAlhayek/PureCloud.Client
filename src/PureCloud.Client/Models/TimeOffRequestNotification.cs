using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffRequestNotification
/// </summary>

public partial class TimeOffRequestNotification : IEquatable<TimeOffRequestNotification>
{
    /// <summary>
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    
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
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequestNotification" /> class.
    /// </summary>
    /// <param name="TimeOffRequestId">The ID of this time off request.</param>
    /// <param name="User">The user associated with this time off request.</param>
    /// <param name="IsFullDayRequest">Whether this is a full day request (false means partial day).</param>
    /// <param name="Status">The status of this time off request.</param>
    /// <param name="PartialDayStartDateTimes">A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false.</param>
    /// <param name="FullDayManagementUnitDates">A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true.</param>
    public TimeOffRequestNotification(string TimeOffRequestId = null, UserReference User = null, bool? IsFullDayRequest = null, StatusEnum? Status = null, List<DateTime?> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null)
    {
        this.TimeOffRequestId = TimeOffRequestId;
        this.User = User;
        this.IsFullDayRequest = IsFullDayRequest;
        this.Status = Status;
        this.PartialDayStartDateTimes = PartialDayStartDateTimes;
        this.FullDayManagementUnitDates = FullDayManagementUnitDates;

    }



    /// <summary>
    /// The ID of this time off request
    /// </summary>
    /// <value>The ID of this time off request</value>
    [JsonPropertyName("timeOffRequestId")]
    public string TimeOffRequestId { get; set; }



    /// <summary>
    /// The user associated with this time off request
    /// </summary>
    /// <value>The user associated with this time off request</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// Whether this is a full day request (false means partial day)
    /// </summary>
    /// <value>Whether this is a full day request (false means partial day)</value>
    [JsonPropertyName("isFullDayRequest")]
    public bool? IsFullDayRequest { get; set; }





    /// <summary>
    /// A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false
    /// </summary>
    /// <value>A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false</value>
    [JsonPropertyName("partialDayStartDateTimes")]
    public List<DateTime?> PartialDayStartDateTimes { get; set; }



    /// <summary>
    /// A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true
    /// </summary>
    /// <value>A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true</value>
    [JsonPropertyName("fullDayManagementUnitDates")]
    public List<string> FullDayManagementUnitDates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffRequestNotification {\n");

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
        return Equals(obj as TimeOffRequestNotification);
    }

    /// <summary>
    /// Returns true if TimeOffRequestNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffRequestNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffRequestNotification other)
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
