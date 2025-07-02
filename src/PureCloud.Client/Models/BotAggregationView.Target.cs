using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum BotAggregationViewTargetEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nbotsessionturns for "nBotSessionTurns"
    /// </summary>
    [EnumMember(Value = "nBotSessionTurns")]
    Nbotsessionturns,

    /// <summary>
    /// Enum Nbotsessions for "nBotSessions"
    /// </summary>
    [EnumMember(Value = "nBotSessions")]
    Nbotsessions,

    /// <summary>
    /// Enum Obotintent for "oBotIntent"
    /// </summary>
    [EnumMember(Value = "oBotIntent")]
    Obotintent,

    /// <summary>
    /// Enum Obotsessioncollection for "oBotSessionCollection"
    /// </summary>
    [EnumMember(Value = "oBotSessionCollection")]
    Obotsessioncollection,

    /// <summary>
    /// Enum Obotsessioncollectionselfserved for "oBotSessionCollectionSelfServed"
    /// </summary>
    [EnumMember(Value = "oBotSessionCollectionSelfServed")]
    Obotsessioncollectionselfserved,

    /// <summary>
    /// Enum Obotsessionquery for "oBotSessionQuery"
    /// </summary>
    [EnumMember(Value = "oBotSessionQuery")]
    Obotsessionquery,

    /// <summary>
    /// Enum Obotsessionqueryselfserved for "oBotSessionQuerySelfServed"
    /// </summary>
    [EnumMember(Value = "oBotSessionQuerySelfServed")]
    Obotsessionqueryselfserved,

    /// <summary>
    /// Enum Obotsessionturn for "oBotSessionTurn"
    /// </summary>
    [EnumMember(Value = "oBotSessionTurn")]
    Obotsessionturn,

    /// <summary>
    /// Enum Obotslot for "oBotSlot"
    /// </summary>
    [EnumMember(Value = "oBotSlot")]
    Obotslot,

    /// <summary>
    /// Enum Tbotdisconnect for "tBotDisconnect"
    /// </summary>
    [EnumMember(Value = "tBotDisconnect")]
    Tbotdisconnect,

    /// <summary>
    /// Enum Tbotexit for "tBotExit"
    /// </summary>
    [EnumMember(Value = "tBotExit")]
    Tbotexit,

    /// <summary>
    /// Enum Tbotrecognitionfailure for "tBotRecognitionFailure"
    /// </summary>
    [EnumMember(Value = "tBotRecognitionFailure")]
    Tbotrecognitionfailure,

    /// <summary>
    /// Enum Tbotsession for "tBotSession"
    /// </summary>
    [EnumMember(Value = "tBotSession")]
    Tbotsession
}
