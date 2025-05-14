using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerRulesetConfigChangeConditionOperatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Equals for "EQUALS"
    /// </summary>
    [EnumMember(Value = "EQUALS")]
    Equals,

    /// <summary>
    /// Enum LessThan for "LESS_THAN"
    /// </summary>
    [EnumMember(Value = "LESS_THAN")]
    LessThan,

    /// <summary>
    /// Enum LessThanEquals for "LESS_THAN_EQUALS"
    /// </summary>
    [EnumMember(Value = "LESS_THAN_EQUALS")]
    LessThanEquals,

    /// <summary>
    /// Enum GreaterThan for "GREATER_THAN"
    /// </summary>
    [EnumMember(Value = "GREATER_THAN")]
    GreaterThan,

    /// <summary>
    /// Enum GreaterThanEquals for "GREATER_THAN_EQUALS"
    /// </summary>
    [EnumMember(Value = "GREATER_THAN_EQUALS")]
    GreaterThanEquals,

    /// <summary>
    /// Enum Contains for "CONTAINS"
    /// </summary>
    [EnumMember(Value = "CONTAINS")]
    Contains,

    /// <summary>
    /// Enum BeginsWith for "BEGINS_WITH"
    /// </summary>
    [EnumMember(Value = "BEGINS_WITH")]
    BeginsWith,

    /// <summary>
    /// Enum EndsWith for "ENDS_WITH"
    /// </summary>
    [EnumMember(Value = "ENDS_WITH")]
    EndsWith,

    /// <summary>
    /// Enum Before for "BEFORE"
    /// </summary>
    [EnumMember(Value = "BEFORE")]
    Before,

    /// <summary>
    /// Enum After for "AFTER"
    /// </summary>
    [EnumMember(Value = "AFTER")]
    After
}
