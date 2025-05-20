using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmBuShortTermForecastUpdateCompleteTopicBuForecastModificationTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Minimumperinterval for "MinimumPerInterval"
    /// </summary>
    [EnumMember(Value = "MinimumPerInterval")]
    Minimumperinterval,

    /// <summary>
    /// Enum Maximumperinterval for "MaximumPerInterval"
    /// </summary>
    [EnumMember(Value = "MaximumPerInterval")]
    Maximumperinterval,

    /// <summary>
    /// Enum Setvalueperinterval for "SetValuePerInterval"
    /// </summary>
    [EnumMember(Value = "SetValuePerInterval")]
    Setvalueperinterval,

    /// <summary>
    /// Enum Changevalueperinterval for "ChangeValuePerInterval"
    /// </summary>
    [EnumMember(Value = "ChangeValuePerInterval")]
    Changevalueperinterval,

    /// <summary>
    /// Enum Changepercentperinterval for "ChangePercentPerInterval"
    /// </summary>
    [EnumMember(Value = "ChangePercentPerInterval")]
    Changepercentperinterval,

    /// <summary>
    /// Enum Setvalueoverrange for "SetValueOverRange"
    /// </summary>
    [EnumMember(Value = "SetValueOverRange")]
    Setvalueoverrange,

    /// <summary>
    /// Enum Changevalueoverrange for "ChangeValueOverRange"
    /// </summary>
    [EnumMember(Value = "ChangeValueOverRange")]
    Changevalueoverrange,

    /// <summary>
    /// Enum Setvaluesforintervalset for "SetValuesForIntervalSet"
    /// </summary>
    [EnumMember(Value = "SetValuesForIntervalSet")]
    Setvaluesforintervalset,

    /// <summary>
    /// Enum Setmultigranularityvaluesforintervalset for "SetMultiGranularityValuesForIntervalSet"
    /// </summary>
    [EnumMember(Value = "SetMultiGranularityValuesForIntervalSet")]
    Setmultigranularityvaluesforintervalset
}
