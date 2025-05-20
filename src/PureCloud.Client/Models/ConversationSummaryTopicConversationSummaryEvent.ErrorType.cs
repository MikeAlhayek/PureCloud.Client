using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ErrorType
/// </summary>

public enum ConversationSummaryTopicConversationSummaryEventErrorTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum ConversationTooLong for "CONVERSATION_TOO_LONG"
    /// </summary>
    [EnumMember(Value = "CONVERSATION_TOO_LONG")]
    ConversationTooLong,

    /// <summary>
    /// Enum ConversationTooShort for "CONVERSATION_TOO_SHORT"
    /// </summary>
    [EnumMember(Value = "CONVERSATION_TOO_SHORT")]
    ConversationTooShort,

    /// <summary>
    /// Enum RateLimited for "RATE_LIMITED"
    /// </summary>
    [EnumMember(Value = "RATE_LIMITED")]
    RateLimited
}
