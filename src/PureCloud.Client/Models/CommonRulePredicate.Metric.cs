using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The metric being evaluated.
/// </summary>
/// <value>The metric being evaluated.</value>

public enum CommonRulePredicateMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nabandon for "nAbandon"
    /// </summary>
    [EnumMember(Value = "nAbandon")]
    Nabandon,

    /// <summary>
    /// Enum Nconnected for "nConnected"
    /// </summary>
    [EnumMember(Value = "nConnected")]
    Nconnected,

    /// <summary>
    /// Enum Ninteractions for "nInteractions"
    /// </summary>
    [EnumMember(Value = "nInteractions")]
    Ninteractions,

    /// <summary>
    /// Enum Noffered for "nOffered"
    /// </summary>
    [EnumMember(Value = "nOffered")]
    Noffered,

    /// <summary>
    /// Enum Noutbound for "nOutbound"
    /// </summary>
    [EnumMember(Value = "nOutbound")]
    Noutbound,

    /// <summary>
    /// Enum Ntransferred for "nTransferred"
    /// </summary>
    [EnumMember(Value = "nTransferred")]
    Ntransferred,

    /// <summary>
    /// Enum Servicelevel for "serviceLevel"
    /// </summary>
    [EnumMember(Value = "serviceLevel")]
    Servicelevel,

    /// <summary>
    /// Enum Oservicelevel for "oServiceLevel"
    /// </summary>
    [EnumMember(Value = "oServiceLevel")]
    Oservicelevel,

    /// <summary>
    /// Enum Owaiting for "oWaiting"
    /// </summary>
    [EnumMember(Value = "oWaiting")]
    Owaiting,

    /// <summary>
    /// Enum Tabandon for "tAbandon"
    /// </summary>
    [EnumMember(Value = "tAbandon")]
    Tabandon,

    /// <summary>
    /// Enum Tacw for "tAcw"
    /// </summary>
    [EnumMember(Value = "tAcw")]
    Tacw,

    /// <summary>
    /// Enum Talert for "tAlert"
    /// </summary>
    [EnumMember(Value = "tAlert")]
    Talert,

    /// <summary>
    /// Enum Tanswered for "tAnswered"
    /// </summary>
    [EnumMember(Value = "tAnswered")]
    Tanswered,

    /// <summary>
    /// Enum Thandle for "tHandle"
    /// </summary>
    [EnumMember(Value = "tHandle")]
    Thandle,

    /// <summary>
    /// Enum Theldcomplete for "tHeldComplete"
    /// </summary>
    [EnumMember(Value = "tHeldComplete")]
    Theldcomplete,

    /// <summary>
    /// Enum Ttalkcomplete for "tTalkComplete"
    /// </summary>
    [EnumMember(Value = "tTalkComplete")]
    Ttalkcomplete,

    /// <summary>
    /// Enum Twait for "tWait"
    /// </summary>
    [EnumMember(Value = "tWait")]
    Twait,

    /// <summary>
    /// Enum Ttalk for "tTalk"
    /// </summary>
    [EnumMember(Value = "tTalk")]
    Ttalk,

    /// <summary>
    /// Enum Theld for "tHeld"
    /// </summary>
    [EnumMember(Value = "tHeld")]
    Theld,

    /// <summary>
    /// Enum Torganizationpresence for "tOrganizationPresence"
    /// </summary>
    [EnumMember(Value = "tOrganizationPresence")]
    Torganizationpresence,

    /// <summary>
    /// Enum Tsystempresence for "tSystemPresence"
    /// </summary>
    [EnumMember(Value = "tSystemPresence")]
    Tsystempresence,

    /// <summary>
    /// Enum Tagentroutingstatus for "tAgentRoutingStatus"
    /// </summary>
    [EnumMember(Value = "tAgentRoutingStatus")]
    Tagentroutingstatus,

    /// <summary>
    /// Enum Ouserroutingstatuses for "oUserRoutingStatuses"
    /// </summary>
    [EnumMember(Value = "oUserRoutingStatuses")]
    Ouserroutingstatuses,

    /// <summary>
    /// Enum Ouserpresences for "oUserPresences"
    /// </summary>
    [EnumMember(Value = "oUserPresences")]
    Ouserpresences,

    /// <summary>
    /// Enum Ointeracting for "oInteracting"
    /// </summary>
    [EnumMember(Value = "oInteracting")]
    Ointeracting,

    /// <summary>
    /// Enum Tflowout for "tFlowOut"
    /// </summary>
    [EnumMember(Value = "tFlowOut")]
    Tflowout,

    /// <summary>
    /// Enum Tadherencestatus for "tAdherenceStatus"
    /// </summary>
    [EnumMember(Value = "tAdherenceStatus")]
    Tadherencestatus,

    /// <summary>
    /// Enum Nevents for "nEvents"
    /// </summary>
    [EnumMember(Value = "nEvents")]
    Nevents
}
