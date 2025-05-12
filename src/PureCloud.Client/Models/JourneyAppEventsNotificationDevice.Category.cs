using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyAppEventsNotificationDeviceCategoryEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Desktop for "desktop"
    /// </summary>
    [EnumMember(Value = "desktop")]
    Desktop,

    /// <summary>
    /// Enum Mobile for "mobile"
    /// </summary>
    [EnumMember(Value = "mobile")]
    Mobile,

    /// <summary>
    /// Enum Tablet for "tablet"
    /// </summary>
    [EnumMember(Value = "tablet")]
    Tablet,

    /// <summary>
    /// Enum Other for "other"
    /// </summary>
    [EnumMember(Value = "other")]
    Other
}
