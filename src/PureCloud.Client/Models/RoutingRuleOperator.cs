using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RoutingRuleOperator
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum MeetsThreshold for "MEETS_THRESHOLD"
    /// </summary>
    [EnumMember(Value = "MEETS_THRESHOLD")]
    MeetsThreshold,

    /// <summary>
    /// Enum Any for "ANY"
    /// </summary>
    [EnumMember(Value = "ANY")]
    Any,
}
