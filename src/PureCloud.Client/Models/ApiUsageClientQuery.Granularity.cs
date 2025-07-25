using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ApiUsageClientQueryGranularityEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Day for "Day"
    /// </summary>
    [EnumMember(Value = "Day")]
    Day,

    /// <summary>
    /// Enum Week for "Week"
    /// </summary>
    [EnumMember(Value = "Week")]
    Week,

    /// <summary>
    /// Enum Month for "Month"
    /// </summary>
    [EnumMember(Value = "Month")]
    Month
}