using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Determines the type of the property associated with the condition
/// </summary>
/// <value>Determines the type of the property associated with the condition</value>

public enum DialerRulesetConfigChangeConditionPropertyTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum AttemptByColumn for "LAST_ATTEMPT_BY_COLUMN"
    /// </summary>
    [EnumMember(Value = "LAST_ATTEMPT_BY_COLUMN")]
    AttemptByColumn,

    /// <summary>
    /// Enum AttemptOverall for "LAST_ATTEMPT_OVERALL"
    /// </summary>
    [EnumMember(Value = "LAST_ATTEMPT_OVERALL")]
    AttemptOverall,

    /// <summary>
    /// Enum ResultByColumn for "LAST_RESULT_BY_COLUMN"
    /// </summary>
    [EnumMember(Value = "LAST_RESULT_BY_COLUMN")]
    ResultByColumn,

    /// <summary>
    /// Enum ResultOverall for "LAST_RESULT_OVERALL"
    /// </summary>
    [EnumMember(Value = "LAST_RESULT_OVERALL")]
    ResultOverall
}
