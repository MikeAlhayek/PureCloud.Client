using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ChannelTopicState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Permitted for "Permitted"
    /// </summary>
    [EnumMember(Value = "Permitted")]
    Permitted,

    /// <summary>
    /// Enum Rejected for "Rejected"
    /// </summary>
    [EnumMember(Value = "Rejected")]
    Rejected,
}
