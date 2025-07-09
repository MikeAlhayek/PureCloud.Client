using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowSettingsResponseTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Bot for "bot"
    /// </summary>
    [EnumMember(Value = "bot")]
    Bot,

    /// <summary>
    /// Enum Commonmodule for "commonmodule"
    /// </summary>
    [EnumMember(Value = "commonmodule")]
    Commonmodule,

    /// <summary>
    /// Enum Digitalbot for "digitalbot"
    /// </summary>
    [EnumMember(Value = "digitalbot")]
    Digitalbot,

    /// <summary>
    /// Enum Inboundcall for "inboundcall"
    /// </summary>
    [EnumMember(Value = "inboundcall")]
    Inboundcall,

    /// <summary>
    /// Enum Inboundchat for "inboundchat"
    /// </summary>
    [EnumMember(Value = "inboundchat")]
    Inboundchat,

    /// <summary>
    /// Enum Inboundemail for "inboundemail"
    /// </summary>
    [EnumMember(Value = "inboundemail")]
    Inboundemail,

    /// <summary>
    /// Enum Inboundshortmessage for "inboundshortmessage"
    /// </summary>
    [EnumMember(Value = "inboundshortmessage")]
    Inboundshortmessage,

    /// <summary>
    /// Enum Inqueuecall for "inqueuecall"
    /// </summary>
    [EnumMember(Value = "inqueuecall")]
    Inqueuecall,

    /// <summary>
    /// Enum Inqueueshortmessage for "inqueueshortmessage"
    /// </summary>
    [EnumMember(Value = "inqueueshortmessage")]
    Inqueueshortmessage,

    /// <summary>
    /// Enum Inqueueemail for "inqueueemail"
    /// </summary>
    [EnumMember(Value = "inqueueemail")]
    Inqueueemail,

    /// <summary>
    /// Enum Outboundcall for "outboundcall"
    /// </summary>
    [EnumMember(Value = "outboundcall")]
    Outboundcall,

    /// <summary>
    /// Enum Securecall for "securecall"
    /// </summary>
    [EnumMember(Value = "securecall")]
    Securecall,

    /// <summary>
    /// Enum Surveyinvite for "surveyinvite"
    /// </summary>
    [EnumMember(Value = "surveyinvite")]
    Surveyinvite,

    /// <summary>
    /// Enum Voice for "voice"
    /// </summary>
    [EnumMember(Value = "voice")]
    Voice,

    /// <summary>
    /// Enum Voicemail for "voicemail"
    /// </summary>
    [EnumMember(Value = "voicemail")]
    Voicemail,

    /// <summary>
    /// Enum Voicesurvey for "voicesurvey"
    /// </summary>
    [EnumMember(Value = "voicesurvey")]
    Voicesurvey,

    /// <summary>
    /// Enum Workflow for "workflow"
    /// </summary>
    [EnumMember(Value = "workflow")]
    Workflow,

    /// <summary>
    /// Enum Workitem for "workitem"
    /// </summary>
    [EnumMember(Value = "workitem")]
    Workitem
}
