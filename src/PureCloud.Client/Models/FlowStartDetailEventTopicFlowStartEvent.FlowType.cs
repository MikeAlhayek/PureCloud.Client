using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets FlowType
/// </summary>

public enum FlowStartDetailEventTopicFlowStartEventFlowTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Inboundcall for "INBOUNDCALL"
    /// </summary>
    [EnumMember(Value = "INBOUNDCALL")]
    Inboundcall,

    /// <summary>
    /// Enum Outboundcall for "OUTBOUNDCALL"
    /// </summary>
    [EnumMember(Value = "OUTBOUNDCALL")]
    Outboundcall,

    /// <summary>
    /// Enum Inqueuecall for "INQUEUECALL"
    /// </summary>
    [EnumMember(Value = "INQUEUECALL")]
    Inqueuecall,

    /// <summary>
    /// Enum Securecall for "SECURECALL"
    /// </summary>
    [EnumMember(Value = "SECURECALL")]
    Securecall,

    /// <summary>
    /// Enum Inboundemail for "INBOUNDEMAIL"
    /// </summary>
    [EnumMember(Value = "INBOUNDEMAIL")]
    Inboundemail,

    /// <summary>
    /// Enum Surveyinvite for "SURVEYINVITE"
    /// </summary>
    [EnumMember(Value = "SURVEYINVITE")]
    Surveyinvite,

    /// <summary>
    /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
    /// </summary>
    [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
    Inboundshortmessage,

    /// <summary>
    /// Enum Inboundchat for "INBOUNDCHAT"
    /// </summary>
    [EnumMember(Value = "INBOUNDCHAT")]
    Inboundchat,

    /// <summary>
    /// Enum Workflow for "WORKFLOW"
    /// </summary>
    [EnumMember(Value = "WORKFLOW")]
    Workflow,

    /// <summary>
    /// Enum Bot for "BOT"
    /// </summary>
    [EnumMember(Value = "BOT")]
    Bot,

    /// <summary>
    /// Enum Digitalbot for "DIGITALBOT"
    /// </summary>
    [EnumMember(Value = "DIGITALBOT")]
    Digitalbot,

    /// <summary>
    /// Enum Commonmodule for "COMMONMODULE"
    /// </summary>
    [EnumMember(Value = "COMMONMODULE")]
    Commonmodule,

    /// <summary>
    /// Enum Inqueueemail for "INQUEUEEMAIL"
    /// </summary>
    [EnumMember(Value = "INQUEUEEMAIL")]
    Inqueueemail,

    /// <summary>
    /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
    /// </summary>
    [EnumMember(Value = "INQUEUESHORTMESSAGE")]
    Inqueueshortmessage,

    /// <summary>
    /// Enum Voice for "VOICE"
    /// </summary>
    [EnumMember(Value = "VOICE")]
    Voice,

    /// <summary>
    /// Enum Voicemail for "VOICEMAIL"
    /// </summary>
    [EnumMember(Value = "VOICEMAIL")]
    Voicemail,

    /// <summary>
    /// Enum Workitem for "WORKITEM"
    /// </summary>
    [EnumMember(Value = "WORKITEM")]
    Workitem,

    /// <summary>
    /// Enum Voicesurvey for "VOICESURVEY"
    /// </summary>
    [EnumMember(Value = "VOICESURVEY")]
    Voicesurvey
}
