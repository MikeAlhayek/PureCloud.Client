using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2MobiusAlertsTopicConditionRulePredicateMetricTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Interval for "Interval"
    /// </summary>
    [EnumMember(Value = "Interval")]
    Interval,

    /// <summary>
    /// Enum Instance for "Instance"
    /// </summary>
    [EnumMember(Value = "Instance")]
    Instance,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
