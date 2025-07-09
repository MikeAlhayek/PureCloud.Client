using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DependencyObjectTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Acdlanguage for "ACDLANGUAGE"
    /// </summary>
    [EnumMember(Value = "ACDLANGUAGE")]
    Acdlanguage,

    /// <summary>
    /// Enum Acdskill for "ACDSKILL"
    /// </summary>
    [EnumMember(Value = "ACDSKILL")]
    Acdskill,

    /// <summary>
    /// Enum Acdwrapupcode for "ACDWRAPUPCODE"
    /// </summary>
    [EnumMember(Value = "ACDWRAPUPCODE")]
    Acdwrapupcode,

    /// <summary>
    /// Enum Audioconnectorbot for "AUDIOCONNECTORBOT"
    /// </summary>
    [EnumMember(Value = "AUDIOCONNECTORBOT")]
    Audioconnectorbot,

    /// <summary>
    /// Enum Botconnectorbot for "BOTCONNECTORBOT"
    /// </summary>
    [EnumMember(Value = "BOTCONNECTORBOT")]
    Botconnectorbot,

    /// <summary>
    /// Enum Botconnectorintegration for "BOTCONNECTORINTEGRATION"
    /// </summary>
    [EnumMember(Value = "BOTCONNECTORINTEGRATION")]
    Botconnectorintegration,

    /// <summary>
    /// Enum Botflow for "BOTFLOW"
    /// </summary>
    [EnumMember(Value = "BOTFLOW")]
    Botflow,

    /// <summary>
    /// Enum Bridgeaction for "BRIDGEACTION"
    /// </summary>
    [EnumMember(Value = "BRIDGEACTION")]
    Bridgeaction,

    /// <summary>
    /// Enum Commonmoduleflow for "COMMONMODULEFLOW"
    /// </summary>
    [EnumMember(Value = "COMMONMODULEFLOW")]
    Commonmoduleflow,

    /// <summary>
    /// Enum Composerscript for "COMPOSERSCRIPT"
    /// </summary>
    [EnumMember(Value = "COMPOSERSCRIPT")]
    Composerscript,

    /// <summary>
    /// Enum Contactlist for "CONTACTLIST"
    /// </summary>
    [EnumMember(Value = "CONTACTLIST")]
    Contactlist,

    /// <summary>
    /// Enum Dataaction for "DATAACTION"
    /// </summary>
    [EnumMember(Value = "DATAACTION")]
    Dataaction,

    /// <summary>
    /// Enum Datatable for "DATATABLE"
    /// </summary>
    [EnumMember(Value = "DATATABLE")]
    Datatable,

    /// <summary>
    /// Enum Decisiontable for "DECISIONTABLE"
    /// </summary>
    [EnumMember(Value = "DECISIONTABLE")]
    Decisiontable,

    /// <summary>
    /// Enum Dialogenginebot for "DIALOGENGINEBOT"
    /// </summary>
    [EnumMember(Value = "DIALOGENGINEBOT")]
    Dialogenginebot,

    /// <summary>
    /// Enum Dialogenginebotversion for "DIALOGENGINEBOTVERSION"
    /// </summary>
    [EnumMember(Value = "DIALOGENGINEBOTVERSION")]
    Dialogenginebotversion,

    /// <summary>
    /// Enum Dialogflowagent for "DIALOGFLOWAGENT"
    /// </summary>
    [EnumMember(Value = "DIALOGFLOWAGENT")]
    Dialogflowagent,

    /// <summary>
    /// Enum Dialogflowcxagent for "DIALOGFLOWCXAGENT"
    /// </summary>
    [EnumMember(Value = "DIALOGFLOWCXAGENT")]
    Dialogflowcxagent,

    /// <summary>
    /// Enum Digitalbotconnector for "DIGITALBOTCONNECTOR"
    /// </summary>
    [EnumMember(Value = "DIGITALBOTCONNECTOR")]
    Digitalbotconnector,

    /// <summary>
    /// Enum Digitalbotflow for "DIGITALBOTFLOW"
    /// </summary>
    [EnumMember(Value = "DIGITALBOTFLOW")]
    Digitalbotflow,

    /// <summary>
    /// Enum Emailroute for "EMAILROUTE"
    /// </summary>
    [EnumMember(Value = "EMAILROUTE")]
    Emailroute,

    /// <summary>
    /// Enum Emergencygroup for "EMERGENCYGROUP"
    /// </summary>
    [EnumMember(Value = "EMERGENCYGROUP")]
    Emergencygroup,

    /// <summary>
    /// Enum Flowaction for "FLOWACTION"
    /// </summary>
    [EnumMember(Value = "FLOWACTION")]
    Flowaction,

    /// <summary>
    /// Enum Flowdatatype for "FLOWDATATYPE"
    /// </summary>
    [EnumMember(Value = "FLOWDATATYPE")]
    Flowdatatype,

    /// <summary>
    /// Enum Flowmilestone for "FLOWMILESTONE"
    /// </summary>
    [EnumMember(Value = "FLOWMILESTONE")]
    Flowmilestone,

    /// <summary>
    /// Enum Flowoutcome for "FLOWOUTCOME"
    /// </summary>
    [EnumMember(Value = "FLOWOUTCOME")]
    Flowoutcome,

    /// <summary>
    /// Enum Grammar for "GRAMMAR"
    /// </summary>
    [EnumMember(Value = "GRAMMAR")]
    Grammar,

    /// <summary>
    /// Enum Group for "GROUP"
    /// </summary>
    [EnumMember(Value = "GROUP")]
    Group,

    /// <summary>
    /// Enum Image for "IMAGE"
    /// </summary>
    [EnumMember(Value = "IMAGE")]
    Image,

    /// <summary>
    /// Enum Inboundcallflow for "INBOUNDCALLFLOW"
    /// </summary>
    [EnumMember(Value = "INBOUNDCALLFLOW")]
    Inboundcallflow,

    /// <summary>
    /// Enum Inboundchatflow for "INBOUNDCHATFLOW"
    /// </summary>
    [EnumMember(Value = "INBOUNDCHATFLOW")]
    Inboundchatflow,

    /// <summary>
    /// Enum Inboundemailflow for "INBOUNDEMAILFLOW"
    /// </summary>
    [EnumMember(Value = "INBOUNDEMAILFLOW")]
    Inboundemailflow,

    /// <summary>
    /// Enum Inboundshortmessageflow for "INBOUNDSHORTMESSAGEFLOW"
    /// </summary>
    [EnumMember(Value = "INBOUNDSHORTMESSAGEFLOW")]
    Inboundshortmessageflow,

    /// <summary>
    /// Enum Inqueuecallflow for "INQUEUECALLFLOW"
    /// </summary>
    [EnumMember(Value = "INQUEUECALLFLOW")]
    Inqueuecallflow,

    /// <summary>
    /// Enum Inqueueemailflow for "INQUEUEEMAILFLOW"
    /// </summary>
    [EnumMember(Value = "INQUEUEEMAILFLOW")]
    Inqueueemailflow,

    /// <summary>
    /// Enum Inqueueshortmessageflow for "INQUEUESHORTMESSAGEFLOW"
    /// </summary>
    [EnumMember(Value = "INQUEUESHORTMESSAGEFLOW")]
    Inqueueshortmessageflow,

    /// <summary>
    /// Enum Ivrconfiguration for "IVRCONFIGURATION"
    /// </summary>
    [EnumMember(Value = "IVRCONFIGURATION")]
    Ivrconfiguration,

    /// <summary>
    /// Enum Knowledgebase for "KNOWLEDGEBASE"
    /// </summary>
    [EnumMember(Value = "KNOWLEDGEBASE")]
    Knowledgebase,

    /// <summary>
    /// Enum Knowledgebasedocument for "KNOWLEDGEBASEDOCUMENT"
    /// </summary>
    [EnumMember(Value = "KNOWLEDGEBASEDOCUMENT")]
    Knowledgebasedocument,

    /// <summary>
    /// Enum Language for "LANGUAGE"
    /// </summary>
    [EnumMember(Value = "LANGUAGE")]
    Language,

    /// <summary>
    /// Enum Lexbot for "LEXBOT"
    /// </summary>
    [EnumMember(Value = "LEXBOT")]
    Lexbot,

    /// <summary>
    /// Enum Lexbotalias for "LEXBOTALIAS"
    /// </summary>
    [EnumMember(Value = "LEXBOTALIAS")]
    Lexbotalias,

    /// <summary>
    /// Enum Lexv2bot for "LEXV2BOT"
    /// </summary>
    [EnumMember(Value = "LEXV2BOT")]
    Lexv2bot,

    /// <summary>
    /// Enum Lexv2botalias for "LEXV2BOTALIAS"
    /// </summary>
    [EnumMember(Value = "LEXV2BOTALIAS")]
    Lexv2botalias,

    /// <summary>
    /// Enum Nludomain for "NLUDOMAIN"
    /// </summary>
    [EnumMember(Value = "NLUDOMAIN")]
    Nludomain,

    /// <summary>
    /// Enum Nuancemixbot for "NUANCEMIXBOT"
    /// </summary>
    [EnumMember(Value = "NUANCEMIXBOT")]
    Nuancemixbot,

    /// <summary>
    /// Enum Nuancemixintegration for "NUANCEMIXINTEGRATION"
    /// </summary>
    [EnumMember(Value = "NUANCEMIXINTEGRATION")]
    Nuancemixintegration,

    /// <summary>
    /// Enum Oauthclient for "OAUTHCLIENT"
    /// </summary>
    [EnumMember(Value = "OAUTHCLIENT")]
    Oauthclient,

    /// <summary>
    /// Enum Outboundcallflow for "OUTBOUNDCALLFLOW"
    /// </summary>
    [EnumMember(Value = "OUTBOUNDCALLFLOW")]
    Outboundcallflow,

    /// <summary>
    /// Enum Queue for "QUEUE"
    /// </summary>
    [EnumMember(Value = "QUEUE")]
    Queue,

    /// <summary>
    /// Enum Recordingpolicy for "RECORDINGPOLICY"
    /// </summary>
    [EnumMember(Value = "RECORDINGPOLICY")]
    Recordingpolicy,

    /// <summary>
    /// Enum Response for "RESPONSE"
    /// </summary>
    [EnumMember(Value = "RESPONSE")]
    Response,

    /// <summary>
    /// Enum Schedule for "SCHEDULE"
    /// </summary>
    [EnumMember(Value = "SCHEDULE")]
    Schedule,

    /// <summary>
    /// Enum Schedulegroup for "SCHEDULEGROUP"
    /// </summary>
    [EnumMember(Value = "SCHEDULEGROUP")]
    Schedulegroup,

    /// <summary>
    /// Enum Secureaction for "SECUREACTION"
    /// </summary>
    [EnumMember(Value = "SECUREACTION")]
    Secureaction,

    /// <summary>
    /// Enum Securecallflow for "SECURECALLFLOW"
    /// </summary>
    [EnumMember(Value = "SECURECALLFLOW")]
    Securecallflow,

    /// <summary>
    /// Enum Smsphonenumber for "SMSPHONENUMBER"
    /// </summary>
    [EnumMember(Value = "SMSPHONENUMBER")]
    Smsphonenumber,

    /// <summary>
    /// Enum Sttengine for "STTENGINE"
    /// </summary>
    [EnumMember(Value = "STTENGINE")]
    Sttengine,

    /// <summary>
    /// Enum Surveyform for "SURVEYFORM"
    /// </summary>
    [EnumMember(Value = "SURVEYFORM")]
    Surveyform,

    /// <summary>
    /// Enum Surveyinviteflow for "SURVEYINVITEFLOW"
    /// </summary>
    [EnumMember(Value = "SURVEYINVITEFLOW")]
    Surveyinviteflow,

    /// <summary>
    /// Enum Systemprompt for "SYSTEMPROMPT"
    /// </summary>
    [EnumMember(Value = "SYSTEMPROMPT")]
    Systemprompt,

    /// <summary>
    /// Enum Ttsengine for "TTSENGINE"
    /// </summary>
    [EnumMember(Value = "TTSENGINE")]
    Ttsengine,

    /// <summary>
    /// Enum Ttsvoice for "TTSVOICE"
    /// </summary>
    [EnumMember(Value = "TTSVOICE")]
    Ttsvoice,

    /// <summary>
    /// Enum User for "USER"
    /// </summary>
    [EnumMember(Value = "USER")]
    User,

    /// <summary>
    /// Enum Userprompt for "USERPROMPT"
    /// </summary>
    [EnumMember(Value = "USERPROMPT")]
    Userprompt,

    /// <summary>
    /// Enum Utilizationlabel for "UTILIZATIONLABEL"
    /// </summary>
    [EnumMember(Value = "UTILIZATIONLABEL")]
    Utilizationlabel,

    /// <summary>
    /// Enum Voiceflow for "VOICEFLOW"
    /// </summary>
    [EnumMember(Value = "VOICEFLOW")]
    Voiceflow,

    /// <summary>
    /// Enum Voicemailflow for "VOICEMAILFLOW"
    /// </summary>
    [EnumMember(Value = "VOICEMAILFLOW")]
    Voicemailflow,

    /// <summary>
    /// Enum Voicesurveyflow for "VOICESURVEYFLOW"
    /// </summary>
    [EnumMember(Value = "VOICESURVEYFLOW")]
    Voicesurveyflow,

    /// <summary>
    /// Enum Widget for "WIDGET"
    /// </summary>
    [EnumMember(Value = "WIDGET")]
    Widget,

    /// <summary>
    /// Enum Workflow for "WORKFLOW"
    /// </summary>
    [EnumMember(Value = "WORKFLOW")]
    Workflow,

    /// <summary>
    /// Enum Workitemflow for "WORKITEMFLOW"
    /// </summary>
    [EnumMember(Value = "WORKITEMFLOW")]
    Workitemflow,

    /// <summary>
    /// Enum Worktype for "WORKTYPE"
    /// </summary>
    [EnumMember(Value = "WORKTYPE")]
    Worktype
}
