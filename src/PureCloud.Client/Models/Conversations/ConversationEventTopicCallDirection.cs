using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// Whether a call is inbound or outbound.
/// </summary>
/// <value>Whether a call is inbound or outbound.</value>

public enum ConversationEventTopicCallDirection
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Outbound for "outbound"
    /// </summary>
    [EnumMember(Value = "outbound")]
    Outbound,

    /// <summary>
    /// Enum Inbound for "inbound"
    /// </summary>
    [EnumMember(Value = "inbound")]
    Inbound,
}
