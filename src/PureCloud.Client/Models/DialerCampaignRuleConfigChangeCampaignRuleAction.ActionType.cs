using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerCampaignRuleConfigChangeCampaignRuleActionActionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Turnoncampaign for "turnOnCampaign"
    /// </summary>
    [EnumMember(Value = "turnOnCampaign")]
    Turnoncampaign,

    /// <summary>
    /// Enum Turnoffcampaign for "turnOffCampaign"
    /// </summary>
    [EnumMember(Value = "turnOffCampaign")]
    Turnoffcampaign,

    /// <summary>
    /// Enum Turnonsequence for "turnOnSequence"
    /// </summary>
    [EnumMember(Value = "turnOnSequence")]
    Turnonsequence,

    /// <summary>
    /// Enum Turnoffsequence for "turnOffSequence"
    /// </summary>
    [EnumMember(Value = "turnOffSequence")]
    Turnoffsequence,

    /// <summary>
    /// Enum Setcampaignpriority for "setCampaignPriority"
    /// </summary>
    [EnumMember(Value = "setCampaignPriority")]
    Setcampaignpriority,

    /// <summary>
    /// Enum Recyclecampaign for "recycleCampaign"
    /// </summary>
    [EnumMember(Value = "recycleCampaign")]
    Recyclecampaign
}
