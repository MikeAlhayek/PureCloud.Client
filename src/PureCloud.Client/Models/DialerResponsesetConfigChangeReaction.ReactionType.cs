using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerResponsesetConfigChangeReactionReactionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Hangup for "hangup"
    /// </summary>
    [EnumMember(Value = "hangup")]
    Hangup,

    /// <summary>
    /// Enum Transfer for "transfer"
    /// </summary>
    [EnumMember(Value = "transfer")]
    Transfer,

    /// <summary>
    /// Enum TransferFlow for "transfer_flow"
    /// </summary>
    [EnumMember(Value = "transfer_flow")]
    TransferFlow,

    /// <summary>
    /// Enum PlayFile for "play_file"
    /// </summary>
    [EnumMember(Value = "play_file")]
    PlayFile
}
