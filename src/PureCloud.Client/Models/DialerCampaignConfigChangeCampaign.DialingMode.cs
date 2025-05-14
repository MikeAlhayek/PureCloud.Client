using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerCampaignConfigChangeCampaignDialingModeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Agentless for "agentless"
    /// </summary>
    [EnumMember(Value = "agentless")]
    Agentless,

    /// <summary>
    /// Enum External for "external"
    /// </summary>
    [EnumMember(Value = "external")]
    External,

    /// <summary>
    /// Enum Preview for "preview"
    /// </summary>
    [EnumMember(Value = "preview")]
    Preview,

    /// <summary>
    /// Enum Power for "power"
    /// </summary>
    [EnumMember(Value = "power")]
    Power,

    /// <summary>
    /// Enum Predictive for "predictive"
    /// </summary>
    [EnumMember(Value = "predictive")]
    Predictive,

    /// <summary>
    /// Enum Progressive for "progressive"
    /// </summary>
    [EnumMember(Value = "progressive")]
    Progressive
}
