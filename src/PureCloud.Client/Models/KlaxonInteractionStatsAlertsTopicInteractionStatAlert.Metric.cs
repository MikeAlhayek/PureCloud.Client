using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metric
/// </summary>

public enum KlaxonInteractionStatsAlertsTopicInteractionStatAlertMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Tabandon for "tAbandon"
    /// </summary>
    [EnumMember(Value = "tAbandon")]
    Tabandon,

    /// <summary>
    /// Enum Tanswered for "tAnswered"
    /// </summary>
    [EnumMember(Value = "tAnswered")]
    Tanswered,

    /// <summary>
    /// Enum Ttalk for "tTalk"
    /// </summary>
    [EnumMember(Value = "tTalk")]
    Ttalk,

    /// <summary>
    /// Enum Noffered for "nOffered"
    /// </summary>
    [EnumMember(Value = "nOffered")]
    Noffered,

    /// <summary>
    /// Enum Thandle for "tHandle"
    /// </summary>
    [EnumMember(Value = "tHandle")]
    Thandle,

    /// <summary>
    /// Enum Ntransferred for "nTransferred"
    /// </summary>
    [EnumMember(Value = "nTransferred")]
    Ntransferred,

    /// <summary>
    /// Enum Oservicelevel for "oServiceLevel"
    /// </summary>
    [EnumMember(Value = "oServiceLevel")]
    Oservicelevel,

    /// <summary>
    /// Enum Twait for "tWait"
    /// </summary>
    [EnumMember(Value = "tWait")]
    Twait,

    /// <summary>
    /// Enum Theld for "tHeld"
    /// </summary>
    [EnumMember(Value = "tHeld")]
    Theld,

    /// <summary>
    /// Enum Tacw for "tAcw"
    /// </summary>
    [EnumMember(Value = "tAcw")]
    Tacw
}
