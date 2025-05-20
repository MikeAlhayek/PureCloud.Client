using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipientIdTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Email for "Email"
    /// </summary>
    [EnumMember(Value = "Email")]
    Email,

    /// <summary>
    /// Enum Phone for "Phone"
    /// </summary>
    [EnumMember(Value = "Phone")]
    Phone,

    /// <summary>
    /// Enum Opaque for "Opaque"
    /// </summary>
    [EnumMember(Value = "Opaque")]
    Opaque
}
