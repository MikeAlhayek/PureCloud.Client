using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BotFlowTypes
/// </summary>

public enum ViewFilterBotFlowTypesEnum
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
    /// Enum Bot for "Bot"
    /// </summary>
    [EnumMember(Value = "Bot")]
    Bot,

    /// <summary>
    /// Enum Digitalbot for "DigitalBot"
    /// </summary>
    [EnumMember(Value = "DigitalBot")]
    Digitalbot,

    /// <summary>
    /// Enum Voicesurvey for "VoiceSurvey"
    /// </summary>
    [EnumMember(Value = "VoiceSurvey")]
    Voicesurvey
}
