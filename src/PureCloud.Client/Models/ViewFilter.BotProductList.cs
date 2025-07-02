using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BotProductList
/// </summary>

public enum ViewFilterBotProductListEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Genesysdialogengine for "GenesysDialogEngine"
    /// </summary>
    [EnumMember(Value = "GenesysDialogEngine")]
    Genesysdialogengine,

    /// <summary>
    /// Enum Amazonlex for "AmazonLex"
    /// </summary>
    [EnumMember(Value = "AmazonLex")]
    Amazonlex,

    /// <summary>
    /// Enum Googledialogflow for "GoogleDialogFlow"
    /// </summary>
    [EnumMember(Value = "GoogleDialogFlow")]
    Googledialogflow,

    /// <summary>
    /// Enum Googledialogflowresell for "GoogleDialogFlowResell"
    /// </summary>
    [EnumMember(Value = "GoogleDialogFlowResell")]
    Googledialogflowresell,

    /// <summary>
    /// Enum Genesysbotflow for "GenesysBotFlow"
    /// </summary>
    [EnumMember(Value = "GenesysBotFlow")]
    Genesysbotflow,

    /// <summary>
    /// Enum Nuancedlg for "NuanceDlg"
    /// </summary>
    [EnumMember(Value = "NuanceDlg")]
    Nuancedlg,

    /// <summary>
    /// Enum Googledialogflowcx for "GoogleDialogFlowCx"
    /// </summary>
    [EnumMember(Value = "GoogleDialogFlowCx")]
    Googledialogflowcx,

    /// <summary>
    /// Enum Genesysbyob for "GenesysByob"
    /// </summary>
    [EnumMember(Value = "GenesysByob")]
    Genesysbyob,

    /// <summary>
    /// Enum Amazonlexv2 for "AmazonLexV2"
    /// </summary>
    [EnumMember(Value = "AmazonLexV2")]
    Amazonlexv2,

    /// <summary>
    /// Enum Googledialogflowcxresell for "GoogleDialogFlowCxResell"
    /// </summary>
    [EnumMember(Value = "GoogleDialogFlowCxResell")]
    Googledialogflowcxresell,

    /// <summary>
    /// Enum Googlesttbotflow for "GoogleSttBotFlow"
    /// </summary>
    [EnumMember(Value = "GoogleSttBotFlow")]
    Googlesttbotflow,

    /// <summary>
    /// Enum Microsoftsttbotflow for "MicrosoftSttBotFlow"
    /// </summary>
    [EnumMember(Value = "MicrosoftSttBotFlow")]
    Microsoftsttbotflow,

    /// <summary>
    /// Enum Audioconnector for "AudioConnector"
    /// </summary>
    [EnumMember(Value = "AudioConnector")]
    Audioconnector,

    /// <summary>
    /// Enum Botconnector for "BotConnector"
    /// </summary>
    [EnumMember(Value = "BotConnector")]
    Botconnector
}
