using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyWebActionEventsNotificationActionMapPageUrlConditionOperatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Equal for "equal"
    /// </summary>
    [EnumMember(Value = "equal")]
    Equal,

    /// <summary>
    /// Enum Notequal for "notEqual"
    /// </summary>
    [EnumMember(Value = "notEqual")]
    Notequal,

    /// <summary>
    /// Enum Like for "like"
    /// </summary>
    [EnumMember(Value = "like")]
    Like,

    /// <summary>
    /// Enum Notlike for "notLike"
    /// </summary>
    [EnumMember(Value = "notLike")]
    Notlike,

    /// <summary>
    /// Enum Greaterthan for "greaterThan"
    /// </summary>
    [EnumMember(Value = "greaterThan")]
    Greaterthan,

    /// <summary>
    /// Enum Greaterthanorequal for "greaterThanOrEqual"
    /// </summary>
    [EnumMember(Value = "greaterThanOrEqual")]
    Greaterthanorequal,

    /// <summary>
    /// Enum Lessthan for "lessThan"
    /// </summary>
    [EnumMember(Value = "lessThan")]
    Lessthan,

    /// <summary>
    /// Enum Lessthanorequal for "lessThanOrEqual"
    /// </summary>
    [EnumMember(Value = "lessThanOrEqual")]
    Lessthanorequal,

    /// <summary>
    /// Enum Startswith for "startsWith"
    /// </summary>
    [EnumMember(Value = "startsWith")]
    Startswith,

    /// <summary>
    /// Enum Endswith for "endsWith"
    /// </summary>
    [EnumMember(Value = "endsWith")]
    Endswith,

    /// <summary>
    /// Enum Containsany for "containsAny"
    /// </summary>
    [EnumMember(Value = "containsAny")]
    Containsany,

    /// <summary>
    /// Enum Notcontainsany for "notContainsAny"
    /// </summary>
    [EnumMember(Value = "notContainsAny")]
    Notcontainsany,

    /// <summary>
    /// Enum Containsall for "containsAll"
    /// </summary>
    [EnumMember(Value = "containsAll")]
    Containsall,

    /// <summary>
    /// Enum Notcontainsal for "notContainsAl"
    /// </summary>
    [EnumMember(Value = "notContainsAl")]
    Notcontainsal
}
