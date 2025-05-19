using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MediaType
/// </summary>

public enum KlaxonInteractionStatsAlertsTopicInteractionStatAlertMediaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Voice for "voice"
    /// </summary>
    [EnumMember(Value = "voice")]
    Voice,

    /// <summary>
    /// Enum Chat for "chat"
    /// </summary>
    [EnumMember(Value = "chat")]
    Chat,

    /// <summary>
    /// Enum Email for "email"
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// Enum Callback for "callback"
    /// </summary>
    [EnumMember(Value = "callback")]
    Callback,

    /// <summary>
    /// Enum Message for "message"
    /// </summary>
    [EnumMember(Value = "message")]
    Message
}
