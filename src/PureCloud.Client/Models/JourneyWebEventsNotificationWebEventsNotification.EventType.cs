using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyWebEventsNotificationWebEventsNotificationEventTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Webevent for "WebEvent"
    /// </summary>
    [EnumMember(Value = "WebEvent")]
    Webevent,

    /// <summary>
    /// Enum Webactionevent for "WebActionEvent"
    /// </summary>
    [EnumMember(Value = "WebActionEvent")]
    Webactionevent,

    /// <summary>
    /// Enum Outcomeachievedevent for "OutcomeAchievedEvent"
    /// </summary>
    [EnumMember(Value = "OutcomeAchievedEvent")]
    Outcomeachievedevent,

    /// <summary>
    /// Enum Segmentassignmentevent for "SegmentAssignmentEvent"
    /// </summary>
    [EnumMember(Value = "SegmentAssignmentEvent")]
    Segmentassignmentevent
}
