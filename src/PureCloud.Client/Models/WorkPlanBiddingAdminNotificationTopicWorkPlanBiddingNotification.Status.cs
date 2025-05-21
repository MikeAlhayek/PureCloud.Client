using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationStatusEnum
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
    /// Enum Draft for "Draft"
    /// </summary>
    [EnumMember(Value = "Draft")]
    Draft,

    /// <summary>
    /// Enum Locked for "Locked"
    /// </summary>
    [EnumMember(Value = "Locked")]
    Locked,

    /// <summary>
    /// Enum Scheduled for "Scheduled"
    /// </summary>
    [EnumMember(Value = "Scheduled")]
    Scheduled,

    /// <summary>
    /// Enum Optimized for "Optimized"
    /// </summary>
    [EnumMember(Value = "Optimized")]
    Optimized,

    /// <summary>
    /// Enum Open for "Open"
    /// </summary>
    [EnumMember(Value = "Open")]
    Open,

    /// <summary>
    /// Enum Closed for "Closed"
    /// </summary>
    [EnumMember(Value = "Closed")]
    Closed,

    /// <summary>
    /// Enum Processed for "Processed"
    /// </summary>
    [EnumMember(Value = "Processed")]
    Processed,

    /// <summary>
    /// Enum Published for "Published"
    /// </summary>
    [EnumMember(Value = "Published")]
    Published
}
