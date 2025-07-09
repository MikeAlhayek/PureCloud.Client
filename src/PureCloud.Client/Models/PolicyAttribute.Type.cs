using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum PolicyAttributeTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Boolean for "BOOLEAN"
    /// </summary>
    [EnumMember(Value = "BOOLEAN")]
    Boolean,

    /// <summary>
    /// Enum Number for "NUMBER"
    /// </summary>
    [EnumMember(Value = "NUMBER")]
    Number,

    /// <summary>
    /// Enum String for "STRING"
    /// </summary>
    [EnumMember(Value = "STRING")]
    String,

    /// <summary>
    /// Enum StringList for "STRING_LIST"
    /// </summary>
    [EnumMember(Value = "STRING_LIST")]
    StringList,

    /// <summary>
    /// Enum Time for "TIME"
    /// </summary>
    [EnumMember(Value = "TIME")]
    Time,

    /// <summary>
    /// Enum RelativeTime for "RELATIVE_TIME"
    /// </summary>
    [EnumMember(Value = "RELATIVE_TIME")]
    RelativeTime,

    /// <summary>
    /// Enum TimeRange for "TIME_RANGE"
    /// </summary>
    [EnumMember(Value = "TIME_RANGE")]
    TimeRange,

    /// <summary>
    /// Enum DayRange for "DAY_RANGE"
    /// </summary>
    [EnumMember(Value = "DAY_RANGE")]
    DayRange,

    /// <summary>
    /// Enum IpAddress for "IP_ADDRESS"
    /// </summary>
    [EnumMember(Value = "IP_ADDRESS")]
    IpAddress,

    /// <summary>
    /// Enum IpCidr for "IP_CIDR"
    /// </summary>
    [EnumMember(Value = "IP_CIDR")]
    IpCidr
}
