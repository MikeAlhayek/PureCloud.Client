using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerRulesetConfigChangeConditionValueTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum String for "STRING"
    /// </summary>
    [EnumMember(Value = "STRING")]
    String,

    /// <summary>
    /// Enum Numeric for "NUMERIC"
    /// </summary>
    [EnumMember(Value = "NUMERIC")]
    Numeric,

    /// <summary>
    /// Enum Datetime for "DATETIME"
    /// </summary>
    [EnumMember(Value = "DATETIME")]
    Datetime,

    /// <summary>
    /// Enum Period for "PERIOD"
    /// </summary>
    [EnumMember(Value = "PERIOD")]
    Period
}
