using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Conversations;

public enum ConversationEventTopicTransferResponseState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "pending"
    /// </summary>
    [EnumMember(Value = "pending")]
    Pending,

    /// <summary>
    /// Enum Active for "active"
    /// </summary>
    [EnumMember(Value = "active")]
    Active,

    /// <summary>
    /// Enum Complete for "complete"
    /// </summary>
    [EnumMember(Value = "complete")]
    Complete,

    /// <summary>
    /// Enum Canceled for "canceled"
    /// </summary>
    [EnumMember(Value = "canceled")]
    Canceled,

    /// <summary>
    /// Enum Failed for "failed"
    /// </summary>
    [EnumMember(Value = "failed")]
    Failed,

    /// <summary>
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,
}
