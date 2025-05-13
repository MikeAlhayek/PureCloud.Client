using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmIntradayDataUpdateTopicIntradayMetricCategoryEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Historicalqueuedata for "HistoricalQueueData"
    /// </summary>
    [EnumMember(Value = "HistoricalQueueData")]
    Historicalqueuedata,

    /// <summary>
    /// Enum Historicalagentdata for "HistoricalAgentData"
    /// </summary>
    [EnumMember(Value = "HistoricalAgentData")]
    Historicalagentdata,

    /// <summary>
    /// Enum Forecastdata for "ForecastData"
    /// </summary>
    [EnumMember(Value = "ForecastData")]
    Forecastdata,

    /// <summary>
    /// Enum Scheduledata for "ScheduleData"
    /// </summary>
    [EnumMember(Value = "ScheduleData")]
    Scheduledata,

    /// <summary>
    /// Enum Performancepredictionagentdata for "PerformancePredictionAgentData"
    /// </summary>
    [EnumMember(Value = "PerformancePredictionAgentData")]
    Performancepredictionagentdata,

    /// <summary>
    /// Enum Performancepredictionqueuedata for "PerformancePredictionQueueData"
    /// </summary>
    [EnumMember(Value = "PerformancePredictionQueueData")]
    Performancepredictionqueuedata
}
