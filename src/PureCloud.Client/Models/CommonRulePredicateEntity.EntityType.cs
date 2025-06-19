using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CommonRulePredicateEntityEntityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum User for "User"
    /// </summary>
    [EnumMember(Value = "User")]
    User,

    /// <summary>
    /// Enum Group for "Group"
    /// </summary>
    [EnumMember(Value = "Group")]
    Group,

    /// <summary>
    /// Enum Queue for "Queue"
    /// </summary>
    [EnumMember(Value = "Queue")]
    Queue,

    /// <summary>
    /// Enum Team for "Team"
    /// </summary>
    [EnumMember(Value = "Team")]
    Team,

    /// <summary>
    /// Enum Teammembers for "TeamMembers"
    /// </summary>
    [EnumMember(Value = "TeamMembers")]
    Teammembers
}
