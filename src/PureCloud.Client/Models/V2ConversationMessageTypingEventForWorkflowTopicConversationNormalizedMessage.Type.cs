using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessageTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Event for "Event"
    /// </summary>
    [EnumMember(Value = "Event")]
    Event
}
