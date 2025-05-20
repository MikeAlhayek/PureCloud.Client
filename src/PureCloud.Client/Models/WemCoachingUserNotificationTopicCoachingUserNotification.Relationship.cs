using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Relationship
/// </summary>

public enum WemCoachingUserNotificationTopicCoachingUserNotificationRelationshipEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Attendee for "Attendee"
    /// </summary>
    [EnumMember(Value = "Attendee")]
    Attendee,

    /// <summary>
    /// Enum Facilitator for "Facilitator"
    /// </summary>
    [EnumMember(Value = "Facilitator")]
    Facilitator,

    /// <summary>
    /// Enum Creator for "Creator"
    /// </summary>
    [EnumMember(Value = "Creator")]
    Creator
}
