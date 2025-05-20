using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmActivityPlanJobCompleteTopicActivityPlanJobExceptionExceptionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unscheduledattendees for "UnscheduledAttendees"
    /// </summary>
    [EnumMember(Value = "UnscheduledAttendees")]
    Unscheduledattendees,

    /// <summary>
    /// Enum Sessionsnotdeleted for "SessionsNotDeleted"
    /// </summary>
    [EnumMember(Value = "SessionsNotDeleted")]
    Sessionsnotdeleted
}
