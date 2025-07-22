using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum LexV2BotAliasStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Creating for "Creating"
    /// </summary>
    [EnumMember(Value = "Creating")]
    Creating,

    /// <summary>
    /// Enum Available for "Available"
    /// </summary>
    [EnumMember(Value = "Available")]
    Available,

    /// <summary>
    /// Enum Deleting for "Deleting"
    /// </summary>
    [EnumMember(Value = "Deleting")]
    Deleting,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed
}
