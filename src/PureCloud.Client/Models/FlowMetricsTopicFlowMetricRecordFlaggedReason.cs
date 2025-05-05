using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Reason for which participant flagged conversation
/// </summary>
/// <value>Reason for which participant flagged conversation</value>

public enum FlowMetricsTopicFlowMetricRecordFlaggedReason
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum General for "general"
    /// </summary>
    [EnumMember(Value = "general")]
    General
}
