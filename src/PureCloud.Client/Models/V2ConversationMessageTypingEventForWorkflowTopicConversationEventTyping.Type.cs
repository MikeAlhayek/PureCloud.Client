using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2ConversationMessageTypingEventForWorkflowTopicConversationEventTypingTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum On for "On"
    /// </summary>
    [EnumMember(Value = "On")]
    On
}
