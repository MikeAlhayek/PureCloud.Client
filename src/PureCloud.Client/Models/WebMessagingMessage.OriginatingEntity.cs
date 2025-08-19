using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.
/// </summary>
public enum WebMessagingMessageOriginatingEntity
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Human for "Human"
    /// </summary>
    [EnumMember(Value = "Human")]
    Human,

    /// <summary>
    /// Enum Bot for "Bot"
    /// </summary>
    [EnumMember(Value = "Bot")]
    Bot
}