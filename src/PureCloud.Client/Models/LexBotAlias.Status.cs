using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum LexBotAliasStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Building for "BUILDING"
    /// </summary>
    [EnumMember(Value = "BUILDING")]
    Building,

    /// <summary>
    /// Enum Ready for "READY"
    /// </summary>
    [EnumMember(Value = "READY")]
    Ready,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed,

    /// <summary>
    /// Enum NotBuilt for "NOT_BUILT"
    /// </summary>
    [EnumMember(Value = "NOT_BUILT")]
    NotBuilt
}
