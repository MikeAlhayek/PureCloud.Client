using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The category of result for the session.
/// </summary>
/// <value>The category of result for the session.</value>

public enum BotFlowSessionBotResultCategoryEnum
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
    /// Enum Userexit for "UserExit"
    /// </summary>
    [EnumMember(Value = "UserExit")]
    Userexit,

    /// <summary>
    /// Enum Botexit for "BotExit"
    /// </summary>
    [EnumMember(Value = "BotExit")]
    Botexit,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Recognitionfailure for "RecognitionFailure"
    /// </summary>
    [EnumMember(Value = "RecognitionFailure")]
    Recognitionfailure,

    /// <summary>
    /// Enum Userdisconnect for "UserDisconnect"
    /// </summary>
    [EnumMember(Value = "UserDisconnect")]
    Userdisconnect,

    /// <summary>
    /// Enum Botdisconnect for "BotDisconnect"
    /// </summary>
    [EnumMember(Value = "BotDisconnect")]
    Botdisconnect,

    /// <summary>
    /// Enum Sessionexpired for "SessionExpired"
    /// </summary>
    [EnumMember(Value = "SessionExpired")]
    Sessionexpired,

    /// <summary>
    /// Enum Transfer for "Transfer"
    /// </summary>
    [EnumMember(Value = "Transfer")]
    Transfer
}
