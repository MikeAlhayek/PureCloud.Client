using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum BotChannelNameEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Chat for "Chat"
    /// </summary>
    [EnumMember(Value = "Chat")]
    Chat,

    /// <summary>
    /// Enum Call for "Call"
    /// </summary>
    [EnumMember(Value = "Call")]
    Call,

    /// <summary>
    /// Enum Messaging for "Messaging"
    /// </summary>
    [EnumMember(Value = "Messaging")]
    Messaging
}
