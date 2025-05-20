using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets NewState
/// </summary>

public enum WfmUserNotificationTopicAlternativeShiftNotificationNewStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Submitted for "Submitted"
    /// </summary>
    [EnumMember(Value = "Submitted")]
    Submitted,

    /// <summary>
    /// Enum Expired for "Expired"
    /// </summary>
    [EnumMember(Value = "Expired")]
    Expired,

    /// <summary>
    /// Enum Approved for "Approved"
    /// </summary>
    [EnumMember(Value = "Approved")]
    Approved,

    /// <summary>
    /// Enum Denied for "Denied"
    /// </summary>
    [EnumMember(Value = "Denied")]
    Denied,

    /// <summary>
    /// Enum Canceled for "Canceled"
    /// </summary>
    [EnumMember(Value = "Canceled")]
    Canceled
}
