using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Substatus
/// </summary>

public enum WfmTimeOffRequestUpdateTopicTimeOffRequestUpdateSubstatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Advancetimeelapsed for "AdvanceTimeElapsed"
    /// </summary>
    [EnumMember(Value = "AdvanceTimeElapsed")]
    Advancetimeelapsed,

    /// <summary>
    /// Enum Autoapproved for "AutoApproved"
    /// </summary>
    [EnumMember(Value = "AutoApproved")]
    Autoapproved,

    /// <summary>
    /// Enum Insufficientbalance for "InsufficientBalance"
    /// </summary>
    [EnumMember(Value = "InsufficientBalance")]
    Insufficientbalance,

    /// <summary>
    /// Enum Invaliddailyduration for "InvalidDailyDuration"
    /// </summary>
    [EnumMember(Value = "InvalidDailyDuration")]
    Invaliddailyduration,

    /// <summary>
    /// Enum Outsideshift for "OutsideShift"
    /// </summary>
    [EnumMember(Value = "OutsideShift")]
    Outsideshift,

    /// <summary>
    /// Enum Overlapsrestrictedactivitycode for "OverlapsRestrictedActivityCode"
    /// </summary>
    [EnumMember(Value = "OverlapsRestrictedActivityCode")]
    Overlapsrestrictedactivitycode,

    /// <summary>
    /// Enum Removedfromwaitlist for "RemovedFromWaitlist"
    /// </summary>
    [EnumMember(Value = "RemovedFromWaitlist")]
    Removedfromwaitlist,

    /// <summary>
    /// Enum Waitlisted for "Waitlisted"
    /// </summary>
    [EnumMember(Value = "Waitlisted")]
    Waitlisted
}
