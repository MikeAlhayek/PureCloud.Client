using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AgentStateQueryRequestUserOrderByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Username for "userName"
    /// </summary>
    [EnumMember(Value = "userName")]
    Username,

    /// <summary>
    /// Enum Segmentstart for "segmentStart"
    /// </summary>
    [EnumMember(Value = "segmentStart")]
    Segmentstart,

    /// <summary>
    /// Enum Sessionstart for "sessionStart"
    /// </summary>
    [EnumMember(Value = "sessionStart")]
    Sessionstart
}
