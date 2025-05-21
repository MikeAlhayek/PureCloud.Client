using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets RankingTiebreakerType
/// </summary>

public enum WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationRankingTiebreakerTypeEnum
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
    /// Enum Hiredate for "HireDate"
    /// </summary>
    [EnumMember(Value = "HireDate")]
    Hiredate,

    /// <summary>
    /// Enum Performance for "Performance"
    /// </summary>
    [EnumMember(Value = "Performance")]
    Performance,

    /// <summary>
    /// Enum Custom for "Custom"
    /// </summary>
    [EnumMember(Value = "Custom")]
    Custom,

    /// <summary>
    /// Enum Randomlyassign for "RandomlyAssign"
    /// </summary>
    [EnumMember(Value = "RandomlyAssign")]
    Randomlyassign
}
