using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ScheduleActivityExternalActivityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Activityplan for "ActivityPlan"
    /// </summary>
    [EnumMember(Value = "ActivityPlan")]
    Activityplan,

    /// <summary>
    /// Enum Coaching for "Coaching"
    /// </summary>
    [EnumMember(Value = "Coaching")]
    Coaching,

    /// <summary>
    /// Enum Learning for "Learning"
    /// </summary>
    [EnumMember(Value = "Learning")]
    Learning
}
