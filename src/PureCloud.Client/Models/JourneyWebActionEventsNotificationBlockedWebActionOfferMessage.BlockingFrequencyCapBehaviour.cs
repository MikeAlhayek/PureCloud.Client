using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BlockingFrequencyCapBehaviour
/// </summary>

public enum JourneyWebActionEventsNotificationBlockedWebActionOfferMessageBlockingFrequencyCapBehaviourEnum
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
    /// Enum Caponcefinalized for "CapOnceFinalized"
    /// </summary>
    [EnumMember(Value = "CapOnceFinalized")]
    Caponcefinalized,

    /// <summary>
    /// Enum Caponcerejected for "CapOnceRejected"
    /// </summary>
    [EnumMember(Value = "CapOnceRejected")]
    Caponcerejected,

    /// <summary>
    /// Enum Capforperiod for "CapForPeriod"
    /// </summary>
    [EnumMember(Value = "CapForPeriod")]
    Capforperiod
}
