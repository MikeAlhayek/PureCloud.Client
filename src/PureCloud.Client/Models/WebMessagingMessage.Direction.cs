using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The direction of the message.  Direction is always from the perspective of the Genesys Cloud platform.  An Inbound message is one sent from a guest to the Genesys Cloud Platform.  An Outbound message is one sent from the Genesys Cloud Platform to a guest.
/// </summary>
public enum WebMessagingMessageDirection
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inbound for "Inbound"
    /// </summary>
    [EnumMember(Value = "Inbound")]
    Inbound,

    /// <summary>
    /// Enum Outbound for "Outbound"
    /// </summary>
    [EnumMember(Value = "Outbound")]
    Outbound
}
