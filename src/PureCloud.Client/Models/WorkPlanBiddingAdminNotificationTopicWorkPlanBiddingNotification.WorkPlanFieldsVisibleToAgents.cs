using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets WorkPlanFieldsVisibleToAgents
/// </summary>

public enum WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationWorkPlanFieldsVisibleToAgents
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Name for "Name"
    /// </summary>
    [EnumMember(Value = "Name")]
    Name,

    /// <summary>
    /// Enum Paidhours for "PaidHours"
    /// </summary>
    [EnumMember(Value = "PaidHours")]
    Paidhours
}
