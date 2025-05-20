using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Direction
/// </summary>

public enum V2ConversationMessageTypingEventForUserTopicConversationNormalizedMessageDirectionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inbound for "Inbound"
    /// </summary>
    [EnumMember(Value = "Inbound")]
    Inbound,

    /// <summary>
    /// Enum Outbound for "Outbound"
    /// </summary>
    [EnumMember(Value = "Outbound")]
    Outbound
}
