using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum PhoneChangeTopicPhoneStatusOperationalStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Operational for "OPERATIONAL"
    /// </summary>
    [EnumMember(Value = "OPERATIONAL")]
    Operational,

    /// <summary>
    /// Enum Degraded for "DEGRADED"
    /// </summary>
    [EnumMember(Value = "DEGRADED")]
    Degraded,

    /// <summary>
    /// Enum Offline for "OFFLINE"
    /// </summary>
    [EnumMember(Value = "OFFLINE")]
    Offline
}
