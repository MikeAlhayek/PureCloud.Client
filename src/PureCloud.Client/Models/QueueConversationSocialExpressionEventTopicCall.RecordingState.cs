using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// State of recording on this call.
/// </summary>
/// <value>State of recording on this call.</value>

public enum QueueConversationSocialExpressionEventTopicCallRecordingStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "none"
    /// </summary>
    [EnumMember(Value = "none")]
    None,

    /// <summary>
    /// Enum Active for "active"
    /// </summary>
    [EnumMember(Value = "active")]
    Active,

    /// <summary>
    /// Enum Paused for "paused"
    /// </summary>
    [EnumMember(Value = "paused")]
    Paused
}
