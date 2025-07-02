using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of this flow
/// </summary>
/// <value>The type of this flow</value>

public enum FlowActivityEntityDataFlowTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Bot for "BOT"
    /// </summary>
    [EnumMember(Value = "BOT")]
    Bot,

    /// <summary>
    /// Enum Commonmodule for "COMMONMODULE"
    /// </summary>
    [EnumMember(Value = "COMMONMODULE")]
    Commonmodule,

    /// <summary>
    /// Enum Digitalbot for "DIGITALBOT"
    /// </summary>
    [EnumMember(Value = "DIGITALBOT")]
    Digitalbot,

    /// <summary>
    /// Enum Inboundcall for "INBOUNDCALL"
    /// </summary>
    [EnumMember(Value = "INBOUNDCALL")]
    Inboundcall,

    /// <summary>
    /// Enum Inboundchat for "INBOUNDCHAT"
    /// </summary>
    [EnumMember(Value = "INBOUNDCHAT")]
    Inboundchat,

    /// <summary>
    /// Enum Inboundemail for "INBOUNDEMAIL"
    /// </summary>
    [EnumMember(Value = "INBOUNDEMAIL")]
    Inboundemail,

    /// <summary>
    /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
    /// </summary>
    [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
    Inboundshortmessage,

    /// <summary>
    /// Enum Inqueuecall for "INQUEUECALL"
    /// </summary>
    [EnumMember(Value = "INQUEUECALL")]
    Inqueuecall,

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
    /// Enum Outboundcall for "OUTBOUNDCALL"
    /// </summary>
    [EnumMember(Value = "OUTBOUNDCALL")]
    Outboundcall,

    /// <summary>
    /// Enum Securecall for "SECURECALL"
    /// </summary>
    [EnumMember(Value = "SECURECALL")]
    Securecall,

    /// <summary>
    /// Enum Speech for "SPEECH"
    /// </summary>
    [EnumMember(Value = "SPEECH")]
    Speech,

    /// <summary>
    /// Enum Surveyinvite for "SURVEYINVITE"
    /// </summary>
    [EnumMember(Value = "SURVEYINVITE")]
    Surveyinvite,

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
    /// Enum Voicesurvey for "VOICESURVEY"
    /// </summary>
    [EnumMember(Value = "VOICESURVEY")]
    Voicesurvey,

    /// <summary>
    /// Enum Workflow for "WORKFLOW"
    /// </summary>
    [EnumMember(Value = "WORKFLOW")]
    Workflow,

    /// <summary>
    /// Enum Workitem for "WORKITEM"
    /// </summary>
    [EnumMember(Value = "WORKITEM")]
    Workitem
}
