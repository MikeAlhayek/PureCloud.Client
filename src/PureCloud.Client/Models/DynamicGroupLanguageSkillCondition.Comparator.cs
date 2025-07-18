using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DynamicGroupLanguageSkillConditionComparatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Equalto for "EqualTo"
    /// </summary>
    [EnumMember(Value = "EqualTo")]
    Equalto,

    /// <summary>
    /// Enum Notequalto for "NotEqualTo"
    /// </summary>
    [EnumMember(Value = "NotEqualTo")]
    Notequalto,

    /// <summary>
    /// Enum Lessthan for "LessThan"
    /// </summary>
    [EnumMember(Value = "LessThan")]
    Lessthan,

    /// <summary>
    /// Enum Greaterthan for "GreaterThan"
    /// </summary>
    [EnumMember(Value = "GreaterThan")]
    Greaterthan,

    /// <summary>
    /// Enum Greaterthanorequalto for "GreaterThanOrEqualTo"
    /// </summary>
    [EnumMember(Value = "GreaterThanOrEqualTo")]
    Greaterthanorequalto,

    /// <summary>
    /// Enum Lessthanorequalto for "LessThanOrEqualTo"
    /// </summary>
    [EnumMember(Value = "LessThanOrEqualTo")]
    Lessthanorequalto
}
