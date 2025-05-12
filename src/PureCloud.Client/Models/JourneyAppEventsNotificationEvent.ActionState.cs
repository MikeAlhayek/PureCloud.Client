using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyAppEventsNotificationEventActionStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Accepted for "accepted"
    /// </summary>
    [EnumMember(Value = "accepted")]
    Accepted,

    /// <summary>
    /// Enum Rejected for "rejected"
    /// </summary>
    [EnumMember(Value = "rejected")]
    Rejected,

    /// <summary>
    /// Enum Timedout for "timedout"
    /// </summary>
    [EnumMember(Value = "timedout")]
    Timedout,

    /// <summary>
    /// Enum Errored for "errored"
    /// </summary>
    [EnumMember(Value = "errored")]
    Errored,

    /// <summary>
    /// Enum Ignored for "ignored"
    /// </summary>
    [EnumMember(Value = "ignored")]
    Ignored,

    /// <summary>
    /// Enum Qualified for "qualified"
    /// </summary>
    [EnumMember(Value = "qualified")]
    Qualified,

    /// <summary>
    /// Enum Offered for "offered"
    /// </summary>
    [EnumMember(Value = "offered")]
    Offered,

    /// <summary>
    /// Enum Started for "started"
    /// </summary>
    [EnumMember(Value = "started")]
    Started,

    /// <summary>
    /// Enum Engaged for "engaged"
    /// </summary>
    [EnumMember(Value = "engaged")]
    Engaged,

    /// <summary>
    /// Enum Qualifiedoutsideschedule for "qualifiedOutsideSchedule"
    /// </summary>
    [EnumMember(Value = "qualifiedOutsideSchedule")]
    Qualifiedoutsideschedule,

    /// <summary>
    /// Enum Offeredoutsideschedule for "offeredOutsideSchedule"
    /// </summary>
    [EnumMember(Value = "offeredOutsideSchedule")]
    Offeredoutsideschedule,

    /// <summary>
    /// Enum Abandoned for "abandoned"
    /// </summary>
    [EnumMember(Value = "abandoned")]
    Abandoned,

    /// <summary>
    /// Enum Completed for "completed"
    /// </summary>
    [EnumMember(Value = "completed")]
    Completed,

    /// <summary>
    /// Enum Frequencycapreached for "frequencyCapReached"
    /// </summary>
    [EnumMember(Value = "frequencyCapReached")]
    Frequencycapreached
}
