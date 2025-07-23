using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum LogCaptureUserConfigurationCaptureMethodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ondemand for "OnDemand"
    /// </summary>
    [EnumMember(Value = "OnDemand")]
    Ondemand,

    /// <summary>
    /// Enum Scheduled for "Scheduled"
    /// </summary>
    [EnumMember(Value = "Scheduled")]
    Scheduled
}
