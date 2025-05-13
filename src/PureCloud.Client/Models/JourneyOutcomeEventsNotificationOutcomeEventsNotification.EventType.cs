using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyOutcomeEventsNotificationOutcomeEventsNotificationEventTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Outcomeachievedevent for "OutcomeAchievedEvent"
    /// </summary>
    [EnumMember(Value = "OutcomeAchievedEvent")]
    Outcomeachievedevent,

    /// <summary>
    /// Enum Outcomeattributionevent for "OutcomeAttributionEvent"
    /// </summary>
    [EnumMember(Value = "OutcomeAttributionEvent")]
    Outcomeattributionevent
}
