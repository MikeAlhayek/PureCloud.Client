using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MediaType
/// </summary>

public enum ConversationSummaryTopicConversationSummaryEventMediaTypeEnum
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
    /// Enum Message for "MESSAGE"
    /// </summary>
    [EnumMember(Value = "MESSAGE")]
    Message,

    /// <summary>
    /// Enum Call for "CALL"
    /// </summary>
    [EnumMember(Value = "CALL")]
    Call,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email
}
