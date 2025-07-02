using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Search session order dimension names; default to segmentStart
/// </summary>
/// <value>Search session order dimension names; default to segmentStart</value>

public enum AgentStateQueryRequestSessionOrderByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
