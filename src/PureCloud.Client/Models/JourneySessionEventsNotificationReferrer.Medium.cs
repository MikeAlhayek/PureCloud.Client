using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneySessionEventsNotificationReferrerMediumEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Internal for "internal"
    /// </summary>
    [EnumMember(Value = "internal")]
    Internal,

    /// <summary>
    /// Enum Search for "search"
    /// </summary>
    [EnumMember(Value = "search")]
    Search,

    /// <summary>
    /// Enum Social for "social"
    /// </summary>
    [EnumMember(Value = "social")]
    Social,

    /// <summary>
    /// Enum Email for "email"
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Paid for "paid"
    /// </summary>
    [EnumMember(Value = "paid")]
    Paid
}
