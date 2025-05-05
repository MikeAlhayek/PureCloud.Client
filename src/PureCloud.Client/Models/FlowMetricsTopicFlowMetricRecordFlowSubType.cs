using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.
/// </summary>
/// <value>Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.</value>

public enum FlowMetricsTopicFlowMetricRecordFlowSubType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum VirtualAgent for "VIRTUAL_AGENT"
    /// </summary>
    [EnumMember(Value = "VIRTUAL_AGENT")]
    VirtualAgent
}
