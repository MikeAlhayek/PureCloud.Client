using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RoutingActivityMetricValueMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Oactiveusers for "oActiveUsers"
    /// </summary>
    [EnumMember(Value = "oActiveUsers")]
    Oactiveusers,

    /// <summary>
    /// Enum Omemberusers for "oMemberUsers"
    /// </summary>
    [EnumMember(Value = "oMemberUsers")]
    Omemberusers,

    /// <summary>
    /// Enum Ooffqueueusers for "oOffQueueUsers"
    /// </summary>
    [EnumMember(Value = "oOffQueueUsers")]
    Ooffqueueusers,

    /// <summary>
    /// Enum Oonqueueusers for "oOnQueueUsers"
    /// </summary>
    [EnumMember(Value = "oOnQueueUsers")]
    Oonqueueusers,

    /// <summary>
    /// Enum Ouserpresences for "oUserPresences"
    /// </summary>
    [EnumMember(Value = "oUserPresences")]
    Ouserpresences,

    /// <summary>
    /// Enum Ouserroutingstatuses for "oUserRoutingStatuses"
    /// </summary>
    [EnumMember(Value = "oUserRoutingStatuses")]
    Ouserroutingstatuses
}
