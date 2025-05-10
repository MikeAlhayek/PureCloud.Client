using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Queues;

public enum ScoringMethodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Timestampandpriority for "TimestampAndPriority"
    /// </summary>
    [EnumMember(Value = "TimestampAndPriority")]
    Timestampandpriority,

    /// <summary>
    /// Enum Priorityonly for "PriorityOnly"
    /// </summary>
    [EnumMember(Value = "PriorityOnly")]
    Priorityonly
}
