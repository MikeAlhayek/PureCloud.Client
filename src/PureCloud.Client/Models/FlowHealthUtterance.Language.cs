using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowHealthUtteranceLanguageEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Enus for "en-us"
    /// </summary>
    [EnumMember(Value = "en-us")]
    Enus,

    /// <summary>
    /// Enum Engb for "en-gb"
    /// </summary>
    [EnumMember(Value = "en-gb")]
    Engb,

    /// <summary>
    /// Enum Enau for "en-au"
    /// </summary>
    [EnumMember(Value = "en-au")]
    Enau,

    /// <summary>
    /// Enum Enza for "en-za"
    /// </summary>
    [EnumMember(Value = "en-za")]
    Enza,

    /// <summary>
    /// Enum Ennz for "en-nz"
    /// </summary>
    [EnumMember(Value = "en-nz")]
    Ennz,

    /// <summary>
    /// Enum Enie for "en-ie"
    /// </summary>
    [EnumMember(Value = "en-ie")]
    Enie,

    /// <summary>
    /// Enum Frca for "fr-ca"
    /// </summary>
    [EnumMember(Value = "fr-ca")]
    Frca,

    /// <summary>
    /// Enum Frfr for "fr-fr"
    /// </summary>
    [EnumMember(Value = "fr-fr")]
    Frfr,

    /// <summary>
    /// Enum Esus for "es-us"
    /// </summary>
    [EnumMember(Value = "es-us")]
    Esus,

    /// <summary>
    /// Enum Eses for "es-es"
    /// </summary>
    [EnumMember(Value = "es-es")]
    Eses,

    /// <summary>
    /// Enum Esmx for "es-mx"
    /// </summary>
    [EnumMember(Value = "es-mx")]
    Esmx,

    /// <summary>
    /// Enum Dede for "de-de"
    /// </summary>
    [EnumMember(Value = "de-de")]
    Dede,

    /// <summary>
    /// Enum Itit for "it-it"
    /// </summary>
    [EnumMember(Value = "it-it")]
    Itit,

    /// <summary>
    /// Enum Ptbr for "pt-br"
    /// </summary>
    [EnumMember(Value = "pt-br")]
    Ptbr,

    /// <summary>
    /// Enum Ptpt for "pt-pt"
    /// </summary>
    [EnumMember(Value = "pt-pt")]
    Ptpt,

    /// <summary>
    /// Enum Nlnl for "nl-nl"
    /// </summary>
    [EnumMember(Value = "nl-nl")]
    Nlnl
}
