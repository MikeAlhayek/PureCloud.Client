using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum QueueConversationEventTopicAfterCallWorkStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Skipped for "skipped"
    /// </summary>
    [EnumMember(Value = "skipped")]
    Skipped,

    /// <summary>
    /// Enum Pending for "pending"
    /// </summary>
    [EnumMember(Value = "pending")]
    Pending,

    /// <summary>
    /// Enum Complete for "complete"
    /// </summary>
    [EnumMember(Value = "complete")]
    Complete,

    /// <summary>
    /// Enum Notapplicable for "notApplicable"
    /// </summary>
    [EnumMember(Value = "notApplicable")]
    Notapplicable
}
