using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateAdminTimeOffRequest
/// </summary>
public sealed class CreateAdminTimeOffRequest
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
        Approved
    }

    /// <summary>
    /// The status of this time off request
    /// </summary>
    /// <value>The status of this time off request</value>
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// A set of IDs for users to associate with this time off request
    /// </summary>
    /// <value>A set of IDs for users to associate with this time off request</value>
    public List<UserReference> Users { get; set; }

    /// <summary>
    /// The ID of the activity code associated with this time off request
    /// </summary>
    /// <value>The ID of the activity code associated with this time off request</value>
    public string ActivityCodeId { get; set; }

    /// <summary>
    /// Notes about the time off request
    /// </summary>
    /// <value>Notes about the time off request</value>
    public string Notes { get; set; }

    /// <summary>
    /// A set of dates in yyyy-MM-dd format. Should be interpreted in the management unit's configured time zone
    /// </summary>
    /// <value>A set of dates in yyyy-MM-dd format. Should be interpreted in the management unit's configured time zone</value>
    public IEnumerable<string> FullDayManagementUnitDates { get; set; }

    /// <summary>
    /// A set of start date-times in ISO-8601 format for partial day requests
    /// </summary>
    /// <value>A set of start date-times in ISO-8601 format for partial day requests</value>
    public IEnumerable<DateTime?> PartialDayStartDateTimes { get; set; }

    /// <summary>
    /// The daily duration of this time off request in minutes
    /// </summary>
    /// <value>The daily duration of this time off request in minutes</value>
    public int? DailyDurationMinutes { get; set; }

    /// <summary>
    /// Daily durations for each day of this time off request in minutes
    /// </summary>
    /// <value>Daily durations for each day of this time off request in minutes</value>
    public IEnumerable<int?> DurationMinutes { get; set; }

    /// <summary>
    /// Payable minutes for each day of this time off request
    /// </summary>
    /// <value>Payable minutes for each day of this time off request</value>
    public IEnumerable<int?> PayableMinutes { get; set; }

    /// <summary>
    /// Whether this is a paid time off request
    /// </summary>
    /// <value>Whether this is a paid time off request</value>
    public bool? Paid { get; set; }
}