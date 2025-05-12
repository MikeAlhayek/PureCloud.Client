using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyWebActionEventsNotificationWebActionEventsNotificationEventTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Webactionevent for "WebActionEvent"
    /// </summary>
    [EnumMember(Value = "WebActionEvent")]
    Webactionevent,

    /// <summary>
    /// Enum Blockedwebactionofferevent for "BlockedWebActionOfferEvent"
    /// </summary>
    [EnumMember(Value = "BlockedWebActionOfferEvent")]
    Blockedwebactionofferevent
}
