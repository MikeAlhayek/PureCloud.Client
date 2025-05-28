using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CopilotConditionConditionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Intent for "Intent"
    /// </summary>
    [EnumMember(Value = "Intent")]
    Intent,

    /// <summary>
    /// Enum Conversationstart for "ConversationStart"
    /// </summary>
    [EnumMember(Value = "ConversationStart")]
    Conversationstart,

    /// <summary>
    /// Enum Conversationtransfer for "ConversationTransfer"
    /// </summary>
    [EnumMember(Value = "ConversationTransfer")]
    Conversationtransfer,

    /// <summary>
    /// Enum Conversationend for "ConversationEnd"
    /// </summary>
    [EnumMember(Value = "ConversationEnd")]
    Conversationend
}
