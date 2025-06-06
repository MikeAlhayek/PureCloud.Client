using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// For social media messages, the visibility of the message in the originating social platform
/// </summary>
/// <value>For social media messages, the visibility of the message in the originating social platform</value>

public enum QueueConversationVideoEventTopicMessageDetailsSocialVisibilityEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Private for "private"
    /// </summary>
    [EnumMember(Value = "private")]
    Private,

    /// <summary>
    /// Enum Public for "public"
    /// </summary>
    [EnumMember(Value = "public")]
    Public
}
