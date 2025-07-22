using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The connection state of this member.
/// </summary>
/// <value>The connection state of this member.</value>

public enum WebChatMemberInfoStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Connected for "CONNECTED"
    /// </summary>
    [EnumMember(Value = "CONNECTED")]
    Connected,

    /// <summary>
    /// Enum Disconnected for "DISCONNECTED"
    /// </summary>
    [EnumMember(Value = "DISCONNECTED")]
    Disconnected,

    /// <summary>
    /// Enum Alerting for "ALERTING"
    /// </summary>
    [EnumMember(Value = "ALERTING")]
    Alerting
}
