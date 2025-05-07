using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmBuIntradayDataUpdateTopicBuIntradayResultCategoriesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
    /// Enum Performancepredictiondata for "PerformancePredictionData"
    /// </summary>
    [EnumMember(Value = "PerformancePredictionData")]
    Performancepredictiondata
}
