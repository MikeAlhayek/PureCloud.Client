using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.
/// </summary>
/// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.</value>

public enum ConversationRecordingState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Active for "ACTIVE"
    /// </summary>
    [EnumMember(Value = "ACTIVE")]
    Active,

    /// <summary>
    /// Enum Paused for "PAUSED"
    /// </summary>
    [EnumMember(Value = "PAUSED")]
    Paused,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None
}
