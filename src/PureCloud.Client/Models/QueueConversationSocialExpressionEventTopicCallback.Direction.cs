using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The direction of the call
/// </summary>
/// <value>The direction of the call</value>

public enum QueueConversationSocialExpressionEventTopicCallbackDirectionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inbound for "inbound"
    /// </summary>
    [EnumMember(Value = "inbound")]
    Inbound,

    /// <summary>
    /// Enum Outbound for "outbound"
    /// </summary>
    [EnumMember(Value = "outbound")]
    Outbound
}
