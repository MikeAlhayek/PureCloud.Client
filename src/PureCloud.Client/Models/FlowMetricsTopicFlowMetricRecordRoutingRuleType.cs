using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Routing rule type
/// </summary>
/// <value>Routing rule type</value>

public enum FlowMetricsTopicFlowMetricRecordRoutingRuleType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Bullseye for "Bullseye"
    /// </summary>
    [EnumMember(Value = "Bullseye")]
    Bullseye,

    /// <summary>
    /// Enum Conditional for "Conditional"
    /// </summary>
    [EnumMember(Value = "Conditional")]
    Conditional,

    /// <summary>
    /// Enum Predictive for "Predictive"
    /// </summary>
    [EnumMember(Value = "Predictive")]
    Predictive,

    /// <summary>
    /// Enum Preferred for "Preferred"
    /// </summary>
    [EnumMember(Value = "Preferred")]
    Preferred
}
