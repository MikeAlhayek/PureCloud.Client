using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MetricValueType
/// </summary>

public enum V2MobiusAlertsTopicConditionRulePredicateMetricValueTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Count for "Count"
    /// </summary>
    [EnumMember(Value = "Count")]
    Count,

    /// <summary>
    /// Enum Percentage for "Percentage"
    /// </summary>
    [EnumMember(Value = "Percentage")]
    Percentage,

    /// <summary>
    /// Enum Average for "Average"
    /// </summary>
    [EnumMember(Value = "Average")]
    Average,

    /// <summary>
    /// Enum Timer for "Timer"
    /// </summary>
    [EnumMember(Value = "Timer")]
    Timer,

    /// <summary>
    /// Enum Observation for "Observation"
    /// </summary>
    [EnumMember(Value = "Observation")]
    Observation,

    /// <summary>
    /// Enum Min for "Min"
    /// </summary>
    [EnumMember(Value = "Min")]
    Min,

    /// <summary>
    /// Enum Max for "Max"
    /// </summary>
    [EnumMember(Value = "Max")]
    Max,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
