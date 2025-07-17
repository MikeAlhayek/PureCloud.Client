using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContestsEssentialsStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Upcoming for "Upcoming"
    /// </summary>
    [EnumMember(Value = "Upcoming")]
    Upcoming,

    /// <summary>
    /// Enum Ongoing for "Ongoing"
    /// </summary>
    [EnumMember(Value = "Ongoing")]
    Ongoing,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// Enum Recentlycompleted for "RecentlyCompleted"
    /// </summary>
    [EnumMember(Value = "RecentlyCompleted")]
    Recentlycompleted,

    /// <summary>
    /// Enum Completed for "Completed"
    /// </summary>
    [EnumMember(Value = "Completed")]
    Completed,

    /// <summary>
    /// Enum Cancelled for "Cancelled"
    /// </summary>
    [EnumMember(Value = "Cancelled")]
    Cancelled
}
