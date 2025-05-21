using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metric
/// </summary>

public enum WfmBuShortTermForecastCopyCompleteTopicBuForecastModificationMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Offered for "Offered"
    /// </summary>
    [EnumMember(Value = "Offered")]
    Offered,

    /// <summary>
    /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
    /// </summary>
    [EnumMember(Value = "AverageHandleTimeSeconds")]
    Averagehandletimeseconds
}
