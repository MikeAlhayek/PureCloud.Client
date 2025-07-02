using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TeamActivityMetricValueMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Oteamoffqueueusers for "oTeamOffQueueUsers"
    /// </summary>
    [EnumMember(Value = "oTeamOffQueueUsers")]
    Oteamoffqueueusers,

    /// <summary>
    /// Enum Oteamonqueueusers for "oTeamOnQueueUsers"
    /// </summary>
    [EnumMember(Value = "oTeamOnQueueUsers")]
    Oteamonqueueusers,

    /// <summary>
    /// Enum Oteampresences for "oTeamPresences"
    /// </summary>
    [EnumMember(Value = "oTeamPresences")]
    Oteampresences,

    /// <summary>
    /// Enum Oteamroutingstatuses for "oTeamRoutingStatuses"
    /// </summary>
    [EnumMember(Value = "oTeamRoutingStatuses")]
    Oteamroutingstatuses
}
