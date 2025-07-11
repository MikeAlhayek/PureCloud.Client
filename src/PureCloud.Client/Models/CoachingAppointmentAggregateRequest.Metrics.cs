using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CoachingAppointmentAggregateRequestMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nactivities for "nActivities"
    /// </summary>
    [EnumMember(Value = "nActivities")]
    Nactivities,

    /// <summary>
    /// Enum Nplannedactivities for "nPlannedActivities"
    /// </summary>
    [EnumMember(Value = "nPlannedActivities")]
    Nplannedactivities,

    /// <summary>
    /// Enum Ninprogressactivities for "nInProgressActivities"
    /// </summary>
    [EnumMember(Value = "nInProgressActivities")]
    Ninprogressactivities,

    /// <summary>
    /// Enum Ncompleteactivities for "nCompleteActivities"
    /// </summary>
    [EnumMember(Value = "nCompleteActivities")]
    Ncompleteactivities,

    /// <summary>
    /// Enum Noverdueactivities for "nOverdueActivities"
    /// </summary>
    [EnumMember(Value = "nOverdueActivities")]
    Noverdueactivities,

    /// <summary>
    /// Enum Ninvalidscheduleactivities for "nInvalidScheduleActivities"
    /// </summary>
    [EnumMember(Value = "nInvalidScheduleActivities")]
    Ninvalidscheduleactivities
}
