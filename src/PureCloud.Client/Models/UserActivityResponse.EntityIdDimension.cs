using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum UserActivityResponseEntityIdDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Organizationpresenceid for "organizationPresenceId"
    /// </summary>
    [EnumMember(Value = "organizationPresenceId")]
    Organizationpresenceid,

    /// <summary>
    /// Enum Presencedate for "presenceDate"
    /// </summary>
    [EnumMember(Value = "presenceDate")]
    Presencedate,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Queuemembershipstatus for "queueMembershipStatus"
    /// </summary>
    [EnumMember(Value = "queueMembershipStatus")]
    Queuemembershipstatus,

    /// <summary>
    /// Enum Routingstatus for "routingStatus"
    /// </summary>
    [EnumMember(Value = "routingStatus")]
    Routingstatus,

    /// <summary>
    /// Enum Routingstatusdate for "routingStatusDate"
    /// </summary>
    [EnumMember(Value = "routingStatusDate")]
    Routingstatusdate,

    /// <summary>
    /// Enum Systempresence for "systemPresence"
    /// </summary>
    [EnumMember(Value = "systemPresence")]
    Systempresence,

    /// <summary>
    /// Enum Teamid for "teamId"
    /// </summary>
    [EnumMember(Value = "teamId")]
    Teamid,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
