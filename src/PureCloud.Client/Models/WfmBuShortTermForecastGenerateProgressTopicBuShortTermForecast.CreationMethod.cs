using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmBuShortTermForecastGenerateProgressTopicBuShortTermForecastCreationMethodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Import for "Import"
    /// </summary>
    [EnumMember(Value = "Import")]
    Import,

    /// <summary>
    /// Enum Importedhistoricalweightedaverage for "ImportedHistoricalWeightedAverage"
    /// </summary>
    [EnumMember(Value = "ImportedHistoricalWeightedAverage")]
    Importedhistoricalweightedaverage,

    /// <summary>
    /// Enum Historicalweightedaverage for "HistoricalWeightedAverage"
    /// </summary>
    [EnumMember(Value = "HistoricalWeightedAverage")]
    Historicalweightedaverage,

    /// <summary>
    /// Enum Advanced for "Advanced"
    /// </summary>
    [EnumMember(Value = "Advanced")]
    Advanced
}
