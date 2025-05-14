using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerSequenceConfigChangeCampaignSequenceStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum On for "on"
    /// </summary>
    [EnumMember(Value = "on")]
    On,

    /// <summary>
    /// Enum Off for "off"
    /// </summary>
    [EnumMember(Value = "off")]
    Off,

    /// <summary>
    /// Enum Complete for "complete"
    /// </summary>
    [EnumMember(Value = "complete")]
    Complete
}
