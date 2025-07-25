using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The provider of the bot
/// </summary>
public enum BotSearchResponseBotType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Genesysbotconnector for "GenesysBotConnector"
    /// </summary>
    [EnumMember(Value = "GenesysBotConnector")]
    Genesysbotconnector,

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
    /// Enum Googledialogflowes for "GoogleDialogFlowES"
    /// </summary>
    [EnumMember(Value = "GoogleDialogFlowES")]
    Googledialogflowes,

    /// <summary>
    /// Enum Googledialogflowcx for "GoogleDialogFlowCX"
    /// </summary>
    [EnumMember(Value = "GoogleDialogFlowCX")]
    Googledialogflowcx,

    /// <summary>
    /// Enum Nuancedlg for "NuanceDlg"
    /// </summary>
    [EnumMember(Value = "NuanceDlg")]
    Nuancedlg,

    /// <summary>
    /// Enum Genesysbotflow for "GenesysBotFlow"
    /// </summary>
    [EnumMember(Value = "GenesysBotFlow")]
    Genesysbotflow,

    /// <summary>
    /// Enum Genesysdigitalbotflow for "GenesysDigitalBotFlow"
    /// </summary>
    [EnumMember(Value = "GenesysDigitalBotFlow")]
    Genesysdigitalbotflow,

    /// <summary>
    /// Enum Genesysvoicesurveyflow for "GenesysVoiceSurveyFlow"
    /// </summary>
    [EnumMember(Value = "GenesysVoiceSurveyFlow")]
    Genesysvoicesurveyflow
}