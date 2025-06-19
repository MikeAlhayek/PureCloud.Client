using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AlertRequestTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Mute for "Mute"
    /// </summary>
    [EnumMember(Value = "Mute")]
    Mute,

    /// <summary>
    /// Enum Snooze for "Snooze"
    /// </summary>
    [EnumMember(Value = "Snooze")]
    Snooze,

    /// <summary>
    /// Enum Unread for "Unread"
    /// </summary>
    [EnumMember(Value = "Unread")]
    Unread
}
