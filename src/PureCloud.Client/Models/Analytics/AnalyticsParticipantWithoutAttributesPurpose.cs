using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Analytics;

/// <summary>
/// The participant's purpose
/// </summary>
/// <value>The participant's purpose</value>

public enum AnalyticsParticipantWithoutAttributesPurpose
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Acd for "acd"
    /// </summary>
    [EnumMember(Value = "acd")]
    Acd,

    /// <summary>
    /// Enum Agent for "agent"
    /// </summary>
    [EnumMember(Value = "agent")]
    Agent,

    /// <summary>
    /// Enum Api for "api"
    /// </summary>
    [EnumMember(Value = "api")]
    Api,

    /// <summary>
    /// Enum Botflow for "botflow"
    /// </summary>
    [EnumMember(Value = "botflow")]
    Botflow,

    /// <summary>
    /// Enum Campaign for "campaign"
    /// </summary>
    [EnumMember(Value = "campaign")]
    Campaign,

    /// <summary>
    /// Enum Customer for "customer"
    /// </summary>
    [EnumMember(Value = "customer")]
    Customer,

    /// <summary>
    /// Enum Dialer for "dialer"
    /// </summary>
    [EnumMember(Value = "dialer")]
    Dialer,

    /// <summary>
    /// Enum External for "external"
    /// </summary>
    [EnumMember(Value = "external")]
    External,

    /// <summary>
    /// Enum Fax for "fax"
    /// </summary>
    [EnumMember(Value = "fax")]
    Fax,

    /// <summary>
    /// Enum Group for "group"
    /// </summary>
    [EnumMember(Value = "group")]
    Group,

    /// <summary>
    /// Enum Inbound for "inbound"
    /// </summary>
    [EnumMember(Value = "inbound")]
    Inbound,

    /// <summary>
    /// Enum Ivr for "ivr"
    /// </summary>
    [EnumMember(Value = "ivr")]
    Ivr,

    /// <summary>
    /// Enum Manual for "manual"
    /// </summary>
    [EnumMember(Value = "manual")]
    Manual,

    /// <summary>
    /// Enum Outbound for "outbound"
    /// </summary>
    [EnumMember(Value = "outbound")]
    Outbound,

    /// <summary>
    /// Enum Station for "station"
    /// </summary>
    [EnumMember(Value = "station")]
    Station,

    /// <summary>
    /// Enum User for "user"
    /// </summary>
    [EnumMember(Value = "user")]
    User,

    /// <summary>
    /// Enum Voicemail for "voicemail"
    /// </summary>
    [EnumMember(Value = "voicemail")]
    Voicemail,

    /// <summary>
    /// Enum Voicesurveyflow for "voicesurveyflow"
    /// </summary>
    [EnumMember(Value = "voicesurveyflow")]
    Voicesurveyflow,

    /// <summary>
    /// Enum Workflow for "workflow"
    /// </summary>
    [EnumMember(Value = "workflow")]
    Workflow,
}
