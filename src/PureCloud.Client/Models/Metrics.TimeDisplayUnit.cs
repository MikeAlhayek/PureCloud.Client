using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
/// </summary>
/// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>

public enum MetricsTimeDisplayUnitEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "None"
    /// </summary>
    [EnumMember(Value = "None")]
    None,

    /// <summary>
    /// Enum Seconds for "Seconds"
    /// </summary>
    [EnumMember(Value = "Seconds")]
    Seconds,

    /// <summary>
    /// Enum Minutes for "Minutes"
    /// </summary>
    [EnumMember(Value = "Minutes")]
    Minutes,

    /// <summary>
    /// Enum Hours for "Hours"
    /// </summary>
    [EnumMember(Value = "Hours")]
    Hours
}
