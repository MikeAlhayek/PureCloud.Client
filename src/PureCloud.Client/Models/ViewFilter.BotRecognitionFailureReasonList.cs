using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BotRecognitionFailureReasonList
/// </summary>

public enum ViewFilterBotRecognitionFailureReasonListEnum
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
    /// Enum Noinputcollection for "NoInputCollection"
    /// </summary>
    [EnumMember(Value = "NoInputCollection")]
    Noinputcollection,

    /// <summary>
    /// Enum Noinputconfirmation for "NoInputConfirmation"
    /// </summary>
    [EnumMember(Value = "NoInputConfirmation")]
    Noinputconfirmation,

    /// <summary>
    /// Enum Noinputdisambiguation for "NoInputDisambiguation"
    /// </summary>
    [EnumMember(Value = "NoInputDisambiguation")]
    Noinputdisambiguation,

    /// <summary>
    /// Enum Nomatchcollection for "NoMatchCollection"
    /// </summary>
    [EnumMember(Value = "NoMatchCollection")]
    Nomatchcollection,

    /// <summary>
    /// Enum Nomatchconfirmation for "NoMatchConfirmation"
    /// </summary>
    [EnumMember(Value = "NoMatchConfirmation")]
    Nomatchconfirmation,

    /// <summary>
    /// Enum Nomatchdisambiguation for "NoMatchDisambiguation"
    /// </summary>
    [EnumMember(Value = "NoMatchDisambiguation")]
    Nomatchdisambiguation,

    /// <summary>
    /// Enum Maxwrongmatch for "MaxWrongMatch"
    /// </summary>
    [EnumMember(Value = "MaxWrongMatch")]
    Maxwrongmatch,

    /// <summary>
    /// Enum Alloptionsrejected for "AllOptionsRejected"
    /// </summary>
    [EnumMember(Value = "AllOptionsRejected")]
    Alloptionsrejected
}
