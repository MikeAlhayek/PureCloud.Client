using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmUserNotificationTopicShiftTradeNotificationNewStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unmatched for "Unmatched"
    /// </summary>
    [EnumMember(Value = "Unmatched")]
    Unmatched,

    /// <summary>
    /// Enum Matched for "Matched"
    /// </summary>
    [EnumMember(Value = "Matched")]
    Matched,

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
    /// Enum Expired for "Expired"
    /// </summary>
    [EnumMember(Value = "Expired")]
    Expired,

    /// <summary>
    /// Enum Canceled for "Canceled"
    /// </summary>
    [EnumMember(Value = "Canceled")]
    Canceled
}
