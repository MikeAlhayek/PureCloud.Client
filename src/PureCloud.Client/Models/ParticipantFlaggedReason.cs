using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The reason specifying why participant flagged the conversation.
/// </summary>
/// <value>The reason specifying why participant flagged the conversation.</value>

public enum ParticipantFlaggedReason
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum General for "general"
    /// </summary>
    [EnumMember(Value = "general")]
    General
}
