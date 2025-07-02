using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum TaskManagementAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nworkitemsacdcancelled for "nWorkitemsAcdCancelled"
    /// </summary>
    [EnumMember(Value = "nWorkitemsAcdCancelled")]
    Nworkitemsacdcancelled,

    /// <summary>
    /// Enum Nworkitemsacdexpired for "nWorkitemsAcdExpired"
    /// </summary>
    [EnumMember(Value = "nWorkitemsAcdExpired")]
    Nworkitemsacdexpired,

    /// <summary>
    /// Enum Nworkitemsacdstarted for "nWorkitemsAcdStarted"
    /// </summary>
    [EnumMember(Value = "nWorkitemsAcdStarted")]
    Nworkitemsacdstarted,

    /// <summary>
    /// Enum Nworkitemsagenttransferred for "nWorkitemsAgentTransferred"
    /// </summary>
    [EnumMember(Value = "nWorkitemsAgentTransferred")]
    Nworkitemsagenttransferred,

    /// <summary>
    /// Enum Nworkitemscreated for "nWorkitemsCreated"
    /// </summary>
    [EnumMember(Value = "nWorkitemsCreated")]
    Nworkitemscreated,

    /// <summary>
    /// Enum Nworkitemsdeclined for "nWorkitemsDeclined"
    /// </summary>
    [EnumMember(Value = "nWorkitemsDeclined")]
    Nworkitemsdeclined,

    /// <summary>
    /// Enum Nworkitemsdeleted for "nWorkitemsDeleted"
    /// </summary>
    [EnumMember(Value = "nWorkitemsDeleted")]
    Nworkitemsdeleted,

    /// <summary>
    /// Enum Nworkitemsdisconnected for "nWorkitemsDisconnected"
    /// </summary>
    [EnumMember(Value = "nWorkitemsDisconnected")]
    Nworkitemsdisconnected,

    /// <summary>
    /// Enum Nworkitemsoffered for "nWorkitemsOffered"
    /// </summary>
    [EnumMember(Value = "nWorkitemsOffered")]
    Nworkitemsoffered,

    /// <summary>
    /// Enum Nworkitemsoversla for "nWorkitemsOverSla"
    /// </summary>
    [EnumMember(Value = "nWorkitemsOverSla")]
    Nworkitemsoversla,

    /// <summary>
    /// Enum Nworkitemspurged for "nWorkitemsPurged"
    /// </summary>
    [EnumMember(Value = "nWorkitemsPurged")]
    Nworkitemspurged,

    /// <summary>
    /// Enum Nworkitemsqueuetransferred for "nWorkitemsQueueTransferred"
    /// </summary>
    [EnumMember(Value = "nWorkitemsQueueTransferred")]
    Nworkitemsqueuetransferred,

    /// <summary>
    /// Enum Nworkitemsstatuschanged for "nWorkitemsStatusChanged"
    /// </summary>
    [EnumMember(Value = "nWorkitemsStatusChanged")]
    Nworkitemsstatuschanged,

    /// <summary>
    /// Enum Nworkitemsterminated for "nWorkitemsTerminated"
    /// </summary>
    [EnumMember(Value = "nWorkitemsTerminated")]
    Nworkitemsterminated,

    /// <summary>
    /// Enum Nworkitemstimedout for "nWorkitemsTimedout"
    /// </summary>
    [EnumMember(Value = "nWorkitemsTimedout")]
    Nworkitemstimedout,

    /// <summary>
    /// Enum Nworkitemstransferred for "nWorkitemsTransferred"
    /// </summary>
    [EnumMember(Value = "nWorkitemsTransferred")]
    Nworkitemstransferred,

    /// <summary>
    /// Enum Nworkitemswrapupadded for "nWorkitemsWrapupAdded"
    /// </summary>
    [EnumMember(Value = "nWorkitemsWrapupAdded")]
    Nworkitemswrapupadded,

    /// <summary>
    /// Enum Nworkitemswrapupremoved for "nWorkitemsWrapupRemoved"
    /// </summary>
    [EnumMember(Value = "nWorkitemsWrapupRemoved")]
    Nworkitemswrapupremoved,

    /// <summary>
    /// Enum Oworkitemsservicelevel for "oWorkitemsServiceLevel"
    /// </summary>
    [EnumMember(Value = "oWorkitemsServiceLevel")]
    Oworkitemsservicelevel,

    /// <summary>
    /// Enum Tworkitemsagentfocuscomplete for "tWorkitemsAgentFocusComplete"
    /// </summary>
    [EnumMember(Value = "tWorkitemsAgentFocusComplete")]
    Tworkitemsagentfocuscomplete,

    /// <summary>
    /// Enum Tworkitemsalert for "tWorkitemsAlert"
    /// </summary>
    [EnumMember(Value = "tWorkitemsAlert")]
    Tworkitemsalert,

    /// <summary>
    /// Enum Tworkitemsanswered for "tWorkitemsAnswered"
    /// </summary>
    [EnumMember(Value = "tWorkitemsAnswered")]
    Tworkitemsanswered,

    /// <summary>
    /// Enum Tworkitemsdirectanswered for "tWorkitemsDirectAnswered"
    /// </summary>
    [EnumMember(Value = "tWorkitemsDirectAnswered")]
    Tworkitemsdirectanswered,

    /// <summary>
    /// Enum Tworkitemsfocus for "tWorkitemsFocus"
    /// </summary>
    [EnumMember(Value = "tWorkitemsFocus")]
    Tworkitemsfocus,

    /// <summary>
    /// Enum Tworkitemsfocuscomplete for "tWorkitemsFocusComplete"
    /// </summary>
    [EnumMember(Value = "tWorkitemsFocusComplete")]
    Tworkitemsfocuscomplete,

    /// <summary>
    /// Enum Tworkitemshandled for "tWorkitemsHandled"
    /// </summary>
    [EnumMember(Value = "tWorkitemsHandled")]
    Tworkitemshandled,

    /// <summary>
    /// Enum Tworkitemsheld for "tWorkitemsHeld"
    /// </summary>
    [EnumMember(Value = "tWorkitemsHeld")]
    Tworkitemsheld,

    /// <summary>
    /// Enum Tworkitemsheldcomplete for "tWorkitemsHeldComplete"
    /// </summary>
    [EnumMember(Value = "tWorkitemsHeldComplete")]
    Tworkitemsheldcomplete,

    /// <summary>
    /// Enum Tworkitemsnotresponding for "tWorkitemsNotResponding"
    /// </summary>
    [EnumMember(Value = "tWorkitemsNotResponding")]
    Tworkitemsnotresponding,

    /// <summary>
    /// Enum Tworkitemsparked for "tWorkitemsParked"
    /// </summary>
    [EnumMember(Value = "tWorkitemsParked")]
    Tworkitemsparked,

    /// <summary>
    /// Enum Tworkitemsqueueanswered for "tWorkitemsQueueAnswered"
    /// </summary>
    [EnumMember(Value = "tWorkitemsQueueAnswered")]
    Tworkitemsqueueanswered,

    /// <summary>
    /// Enum Tworkitemsstatus for "tWorkitemsStatus"
    /// </summary>
    [EnumMember(Value = "tWorkitemsStatus")]
    Tworkitemsstatus
}
