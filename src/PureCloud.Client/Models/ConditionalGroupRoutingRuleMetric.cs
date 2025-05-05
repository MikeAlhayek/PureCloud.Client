using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConditionalGroupRoutingRuleMetric
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Estimatedwaittime for "EstimatedWaitTime"
    /// </summary>
    [EnumMember(Value = "EstimatedWaitTime")]
    Estimatedwaittime,

    /// <summary>
    /// Enum Servicelevel for "ServiceLevel"
    /// </summary>
    [EnumMember(Value = "ServiceLevel")]
    Servicelevel
}
