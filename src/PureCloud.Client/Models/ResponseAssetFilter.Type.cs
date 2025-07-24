using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ResponseAssetFilterTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Term for "TERM"
    /// </summary>
    [EnumMember(Value = "TERM")]
    Term,

    /// <summary>
    /// Enum Terms for "TERMS"
    /// </summary>
    [EnumMember(Value = "TERMS")]
    Terms,

    /// <summary>
    /// Enum StartsWith for "STARTS_WITH"
    /// </summary>
    [EnumMember(Value = "STARTS_WITH")]
    StartsWith,

    /// <summary>
    /// Enum Range for "RANGE"
    /// </summary>
    [EnumMember(Value = "RANGE")]
    Range,

    /// <summary>
    /// Enum GreaterThanEqualTo for "GREATER_THAN_EQUAL_TO"
    /// </summary>
    [EnumMember(Value = "GREATER_THAN_EQUAL_TO")]
    GreaterThanEqualTo,

    /// <summary>
    /// Enum LessThanEqualTo for "LESS_THAN_EQUAL_TO"
    /// </summary>
    [EnumMember(Value = "LESS_THAN_EQUAL_TO")]
    LessThanEqualTo,

    /// <summary>
    /// Enum DateRange for "DATE_RANGE"
    /// </summary>
    [EnumMember(Value = "DATE_RANGE")]
    DateRange
}
