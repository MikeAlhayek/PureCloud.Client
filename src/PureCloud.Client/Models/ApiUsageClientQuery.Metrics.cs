using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ApiUsageClientQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Status200 for "Status200"
    /// </summary>
    [EnumMember(Value = "Status200")]
    Status200,

    /// <summary>
    /// Enum Status300 for "Status300"
    /// </summary>
    [EnumMember(Value = "Status300")]
    Status300,

    /// <summary>
    /// Enum Status400 for "Status400"
    /// </summary>
    [EnumMember(Value = "Status400")]
    Status400,

    /// <summary>
    /// Enum Status500 for "Status500"
    /// </summary>
    [EnumMember(Value = "Status500")]
    Status500,

    /// <summary>
    /// Enum Status429 for "Status429"
    /// </summary>
    [EnumMember(Value = "Status429")]
    Status429,

    /// <summary>
    /// Enum Requests for "Requests"
    /// </summary>
    [EnumMember(Value = "Requests")]
    Requests
}