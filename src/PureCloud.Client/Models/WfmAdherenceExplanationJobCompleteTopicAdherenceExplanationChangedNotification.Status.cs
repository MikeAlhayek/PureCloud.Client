using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Status
/// </summary>

public enum WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotificationStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// Enum Approved for "Approved"
    /// </summary>
    [EnumMember(Value = "Approved")]
    Approved,

    /// <summary>
    /// Enum Denied for "Denied"
    /// </summary>
    [EnumMember(Value = "Denied")]
    Denied
}
