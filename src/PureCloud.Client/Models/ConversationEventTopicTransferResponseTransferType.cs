using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of transfer to perform.
/// </summary>
/// <value>The type of transfer to perform.</value>
public enum ConversationEventTopicTransferResponseTransferType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Attended for "attended"
    /// </summary>
    [EnumMember(Value = "attended")]
    Attended,

    /// <summary>
    /// Enum Unattended for "unattended"
    /// </summary>
    [EnumMember(Value = "unattended")]
    Unattended
}
