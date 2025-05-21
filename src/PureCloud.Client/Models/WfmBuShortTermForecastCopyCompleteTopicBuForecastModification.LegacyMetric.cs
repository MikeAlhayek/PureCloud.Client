using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets LegacyMetric
/// </summary>

public enum WfmBuShortTermForecastCopyCompleteTopicBuForecastModificationLegacyMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Averageaftercallworktimeseconds for "AverageAfterCallWorkTimeSeconds"
    /// </summary>
    [EnumMember(Value = "AverageAfterCallWorkTimeSeconds")]
    Averageaftercallworktimeseconds,

    /// <summary>
    /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
    /// </summary>
    [EnumMember(Value = "AverageHandleTimeSeconds")]
    Averagehandletimeseconds,

    /// <summary>
    /// Enum Averagetalktimeseconds for "AverageTalkTimeSeconds"
    /// </summary>
    [EnumMember(Value = "AverageTalkTimeSeconds")]
    Averagetalktimeseconds,

    /// <summary>
    /// Enum Offered for "Offered"
    /// </summary>
    [EnumMember(Value = "Offered")]
    Offered
}
