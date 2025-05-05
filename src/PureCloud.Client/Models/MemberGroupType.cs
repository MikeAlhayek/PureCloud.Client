using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum MemberGroupType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Team for "TEAM"
    /// </summary>
    [EnumMember(Value = "TEAM")]
    Team,

    /// <summary>
    /// Enum Group for "GROUP"
    /// </summary>
    [EnumMember(Value = "GROUP")]
    Group,

    /// <summary>
    /// Enum Skillgroup for "SKILLGROUP"
    /// </summary>
    [EnumMember(Value = "SKILLGROUP")]
    Skillgroup
}
