using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Specifies the type of action that is triggered upon clicking the quick reply.
/// </summary>
public enum ContentQuickReplyAction
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Message for "Message"
    /// </summary>
    [EnumMember(Value = "Message")]
    Message
}
