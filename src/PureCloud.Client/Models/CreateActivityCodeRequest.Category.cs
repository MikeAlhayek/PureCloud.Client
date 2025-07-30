using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CreateActivityCodeRequestCategoryEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Onqueuework for "OnQueueWork"
    /// </summary>
    [EnumMember(Value = "OnQueueWork")]
    Onqueuework,

    /// <summary>
    /// Enum Break for "Break"
    /// </summary>
    [EnumMember(Value = "Break")]
    Break,

    /// <summary>
    /// Enum Meal for "Meal"
    /// </summary>
    [EnumMember(Value = "Meal")]
    Meal,

    /// <summary>
    /// Enum Meeting for "Meeting"
    /// </summary>
    [EnumMember(Value = "Meeting")]
    Meeting,

    /// <summary>
    /// Enum Offqueuework for "OffQueueWork"
    /// </summary>
    [EnumMember(Value = "OffQueueWork")]
    Offqueuework,

    /// <summary>
    /// Enum Timeoff for "TimeOff"
    /// </summary>
    [EnumMember(Value = "TimeOff")]
    Timeoff,

    /// <summary>
    /// Enum Training for "Training"
    /// </summary>
    [EnumMember(Value = "Training")]
    Training,

    /// <summary>
    /// Enum Unavailable for "Unavailable"
    /// </summary>
    [EnumMember(Value = "Unavailable")]
    Unavailable,

    /// <summary>
    /// Enum Unscheduled for "Unscheduled"
    /// </summary>
    [EnumMember(Value = "Unscheduled")]
    Unscheduled
}