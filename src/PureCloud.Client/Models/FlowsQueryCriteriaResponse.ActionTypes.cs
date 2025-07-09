using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ActionTypes
/// </summary>

public enum FlowsQueryCriteriaResponseActionTypesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Actionabortsurveyinvite for "actionAbortSurveyInvite"
    /// </summary>
    [EnumMember(Value = "actionAbortSurveyInvite")]
    Actionabortsurveyinvite,

    /// <summary>
    /// Enum Actionaddflowmilestone for "actionAddFlowMilestone"
    /// </summary>
    [EnumMember(Value = "actionAddFlowMilestone")]
    Actionaddflowmilestone,

    /// <summary>
    /// Enum Actionaskforboolean for "actionAskForBoolean"
    /// </summary>
    [EnumMember(Value = "actionAskForBoolean")]
    Actionaskforboolean,

    /// <summary>
    /// Enum Actionaskfornluintent for "actionAskForNLUIntent"
    /// </summary>
    [EnumMember(Value = "actionAskForNLUIntent")]
    Actionaskfornluintent,

    /// <summary>
    /// Enum Actionaskfornlunextintent for "actionAskForNLUNextIntent"
    /// </summary>
    [EnumMember(Value = "actionAskForNLUNextIntent")]
    Actionaskfornlunextintent,

    /// <summary>
    /// Enum Actionaskforslot for "actionAskForSlot"
    /// </summary>
    [EnumMember(Value = "actionAskForSlot")]
    Actionaskforslot,

    /// <summary>
    /// Enum Actioncallbotconnector for "actionCallBotConnector"
    /// </summary>
    [EnumMember(Value = "actionCallBotConnector")]
    Actioncallbotconnector,

    /// <summary>
    /// Enum Actioncallbotflow for "actionCallBotFlow"
    /// </summary>
    [EnumMember(Value = "actionCallBotFlow")]
    Actioncallbotflow,

    /// <summary>
    /// Enum Actioncallcommonmodule for "actionCallCommonModule"
    /// </summary>
    [EnumMember(Value = "actionCallCommonModule")]
    Actioncallcommonmodule,

    /// <summary>
    /// Enum Actioncalldata for "actionCallData"
    /// </summary>
    [EnumMember(Value = "actionCallData")]
    Actioncalldata,

    /// <summary>
    /// Enum Actioncalldatasecure for "actionCallDataSecure"
    /// </summary>
    [EnumMember(Value = "actionCallDataSecure")]
    Actioncalldatasecure,

    /// <summary>
    /// Enum Actioncalldialogenginebot for "actionCallDialogEngineBot"
    /// </summary>
    [EnumMember(Value = "actionCallDialogEngineBot")]
    Actioncalldialogenginebot,

    /// <summary>
    /// Enum Actioncalldialogflowbot for "actionCallDialogflowBot"
    /// </summary>
    [EnumMember(Value = "actionCallDialogflowBot")]
    Actioncalldialogflowbot,

    /// <summary>
    /// Enum Actioncalldialogflowcxbot for "actionCallDialogflowCxBot"
    /// </summary>
    [EnumMember(Value = "actionCallDialogflowCxBot")]
    Actioncalldialogflowcxbot,

    /// <summary>
    /// Enum Actioncalldigitalbotflow for "actionCallDigitalBotFlow"
    /// </summary>
    [EnumMember(Value = "actionCallDigitalBotFlow")]
    Actioncalldigitalbotflow,

    /// <summary>
    /// Enum Actioncalllexbot for "actionCallLexBot"
    /// </summary>
    [EnumMember(Value = "actionCallLexBot")]
    Actioncalllexbot,

    /// <summary>
    /// Enum Actioncalllexv2bot for "actionCallLexV2Bot"
    /// </summary>
    [EnumMember(Value = "actionCallLexV2Bot")]
    Actioncalllexv2bot,

    /// <summary>
    /// Enum Actioncallnuancemixbot for "actionCallNuanceMixBot"
    /// </summary>
    [EnumMember(Value = "actionCallNuanceMixBot")]
    Actioncallnuancemixbot,

    /// <summary>
    /// Enum Actioncalltask for "actionCallTask"
    /// </summary>
    [EnumMember(Value = "actionCallTask")]
    Actioncalltask,

    /// <summary>
    /// Enum Actionchangestate for "actionChangeState"
    /// </summary>
    [EnumMember(Value = "actionChangeState")]
    Actionchangestate,

    /// <summary>
    /// Enum Actionclearslot for "actionClearSlot"
    /// </summary>
    [EnumMember(Value = "actionClearSlot")]
    Actionclearslot,

    /// <summary>
    /// Enum Actionclearvoicemailsnippet for "actionClearVoicemailSnippet"
    /// </summary>
    [EnumMember(Value = "actionClearVoicemailSnippet")]
    Actionclearvoicemailsnippet,

    /// <summary>
    /// Enum Actioncollectinput for "actionCollectInput"
    /// </summary>
    [EnumMember(Value = "actionCollectInput")]
    Actioncollectinput,

    /// <summary>
    /// Enum Actioncommunicate for "actionCommunicate"
    /// </summary>
    [EnumMember(Value = "actionCommunicate")]
    Actioncommunicate,

    /// <summary>
    /// Enum Actioncompletesurveyinvite for "actionCompleteSurveyInvite"
    /// </summary>
    [EnumMember(Value = "actionCompleteSurveyInvite")]
    Actioncompletesurveyinvite,

    /// <summary>
    /// Enum Actioncreatecallback for "actionCreateCallback"
    /// </summary>
    [EnumMember(Value = "actionCreateCallback")]
    Actioncreatecallback,

    /// <summary>
    /// Enum Actiondatatablelookup for "actionDataTableLookup"
    /// </summary>
    [EnumMember(Value = "actionDataTableLookup")]
    Actiondatatablelookup,

    /// <summary>
    /// Enum Actiondecision for "actionDecision"
    /// </summary>
    [EnumMember(Value = "actionDecision")]
    Actiondecision,

    /// <summary>
    /// Enum Actiondecryptdata for "actionDecryptData"
    /// </summary>
    [EnumMember(Value = "actionDecryptData")]
    Actiondecryptdata,

    /// <summary>
    /// Enum Actiondetectsilence for "actionDetectSilence"
    /// </summary>
    [EnumMember(Value = "actionDetectSilence")]
    Actiondetectsilence,

    /// <summary>
    /// Enum Actiondialextension for "actionDialExtension"
    /// </summary>
    [EnumMember(Value = "actionDialExtension")]
    Actiondialextension,

    /// <summary>
    /// Enum Actiondialname for "actionDialName"
    /// </summary>
    [EnumMember(Value = "actionDialName")]
    Actiondialname,

    /// <summary>
    /// Enum Actiondigitalmenu for "actionDigitalMenu"
    /// </summary>
    [EnumMember(Value = "actionDigitalMenu")]
    Actiondigitalmenu,

    /// <summary>
    /// Enum Actiondisconnect for "actionDisconnect"
    /// </summary>
    [EnumMember(Value = "actionDisconnect")]
    Actiondisconnect,

    /// <summary>
    /// Enum Actionenableparticipantrecord for "actionEnableParticipantRecord"
    /// </summary>
    [EnumMember(Value = "actionEnableParticipantRecord")]
    Actionenableparticipantrecord,

    /// <summary>
    /// Enum Actionencryptdata for "actionEncryptData"
    /// </summary>
    [EnumMember(Value = "actionEncryptData")]
    Actionencryptdata,

    /// <summary>
    /// Enum Actionendstate for "actionEndState"
    /// </summary>
    [EnumMember(Value = "actionEndState")]
    Actionendstate,

    /// <summary>
    /// Enum Actionendtask for "actionEndTask"
    /// </summary>
    [EnumMember(Value = "actionEndTask")]
    Actionendtask,

    /// <summary>
    /// Enum Actionendworkflow for "actionEndWorkflow"
    /// </summary>
    [EnumMember(Value = "actionEndWorkflow")]
    Actionendworkflow,

    /// <summary>
    /// Enum Actionevaluateschedule for "actionEvaluateSchedule"
    /// </summary>
    [EnumMember(Value = "actionEvaluateSchedule")]
    Actionevaluateschedule,

    /// <summary>
    /// Enum Actionevaluateschedulegroup for "actionEvaluateScheduleGroup"
    /// </summary>
    [EnumMember(Value = "actionEvaluateScheduleGroup")]
    Actionevaluateschedulegroup,

    /// <summary>
    /// Enum Actionexitbotflow for "actionExitBotFlow"
    /// </summary>
    [EnumMember(Value = "actionExitBotFlow")]
    Actionexitbotflow,

    /// <summary>
    /// Enum Actionexitloop for "actionExitLoop"
    /// </summary>
    [EnumMember(Value = "actionExitLoop")]
    Actionexitloop,

    /// <summary>
    /// Enum Actionextractsecuredata for "actionExtractSecureData"
    /// </summary>
    [EnumMember(Value = "actionExtractSecureData")]
    Actionextractsecuredata,

    /// <summary>
    /// Enum Actionfindemergencygroup for "actionFindEmergencyGroup"
    /// </summary>
    [EnumMember(Value = "actionFindEmergencyGroup")]
    Actionfindemergencygroup,

    /// <summary>
    /// Enum Actionfindgroup for "actionFindGroup"
    /// </summary>
    [EnumMember(Value = "actionFindGroup")]
    Actionfindgroup,

    /// <summary>
    /// Enum Actionfindlanguageskill for "actionFindLanguageSkill"
    /// </summary>
    [EnumMember(Value = "actionFindLanguageSkill")]
    Actionfindlanguageskill,

    /// <summary>
    /// Enum Actionfindqueue for "actionFindQueue"
    /// </summary>
    [EnumMember(Value = "actionFindQueue")]
    Actionfindqueue,

    /// <summary>
    /// Enum Actionfindqueuebyid for "actionFindQueueById"
    /// </summary>
    [EnumMember(Value = "actionFindQueueById")]
    Actionfindqueuebyid,

    /// <summary>
    /// Enum Actionfindschedule for "actionFindSchedule"
    /// </summary>
    [EnumMember(Value = "actionFindSchedule")]
    Actionfindschedule,

    /// <summary>
    /// Enum Actionfindschedulegroup for "actionFindScheduleGroup"
    /// </summary>
    [EnumMember(Value = "actionFindScheduleGroup")]
    Actionfindschedulegroup,

    /// <summary>
    /// Enum Actionfindskill for "actionFindSkill"
    /// </summary>
    [EnumMember(Value = "actionFindSkill")]
    Actionfindskill,

    /// <summary>
    /// Enum Actionfindsystemprompt for "actionFindSystemPrompt"
    /// </summary>
    [EnumMember(Value = "actionFindSystemPrompt")]
    Actionfindsystemprompt,

    /// <summary>
    /// Enum Actionfinduser for "actionFindUser"
    /// </summary>
    [EnumMember(Value = "actionFindUser")]
    Actionfinduser,

    /// <summary>
    /// Enum Actionfinduserbyid for "actionFindUserById"
    /// </summary>
    [EnumMember(Value = "actionFindUserById")]
    Actionfinduserbyid,

    /// <summary>
    /// Enum Actionfinduserprompt for "actionFindUserPrompt"
    /// </summary>
    [EnumMember(Value = "actionFindUserPrompt")]
    Actionfinduserprompt,

    /// <summary>
    /// Enum Actionfindusersbyid for "actionFindUsersById"
    /// </summary>
    [EnumMember(Value = "actionFindUsersById")]
    Actionfindusersbyid,

    /// <summary>
    /// Enum Actionflushaudio for "actionFlushAudio"
    /// </summary>
    [EnumMember(Value = "actionFlushAudio")]
    Actionflushaudio,

    /// <summary>
    /// Enum Actiongetconversationdata for "actionGetConversationData"
    /// </summary>
    [EnumMember(Value = "actionGetConversationData")]
    Actiongetconversationdata,

    /// <summary>
    /// Enum Actiongetexternalcontact for "actionGetExternalContact"
    /// </summary>
    [EnumMember(Value = "actionGetExternalContact")]
    Actiongetexternalcontact,

    /// <summary>
    /// Enum Actiongetexternalorganization for "actionGetExternalOrganization"
    /// </summary>
    [EnumMember(Value = "actionGetExternalOrganization")]
    Actiongetexternalorganization,

    /// <summary>
    /// Enum Actiongetjourneyoutcome for "actionGetJourneyOutcome"
    /// </summary>
    [EnumMember(Value = "actionGetJourneyOutcome")]
    Actiongetjourneyoutcome,

    /// <summary>
    /// Enum Actiongetjourneyoutcomescoresbysession for "actionGetJourneyOutcomeScoresBySession"
    /// </summary>
    [EnumMember(Value = "actionGetJourneyOutcomeScoresBySession")]
    Actiongetjourneyoutcomescoresbysession,

    /// <summary>
    /// Enum Actiongetjourneysegment for "actionGetJourneySegment"
    /// </summary>
    [EnumMember(Value = "actionGetJourneySegment")]
    Actiongetjourneysegment,

    /// <summary>
    /// Enum Actiongetjourneysession for "actionGetJourneySession"
    /// </summary>
    [EnumMember(Value = "actionGetJourneySession")]
    Actiongetjourneysession,

    /// <summary>
    /// Enum Actiongetjourneysessionsbycustomer for "actionGetJourneySessionsByCustomer"
    /// </summary>
    [EnumMember(Value = "actionGetJourneySessionsByCustomer")]
    Actiongetjourneysessionsbycustomer,

    /// <summary>
    /// Enum Actiongetjourneysessionsbyexternalcontact for "actionGetJourneySessionsByExternalContact"
    /// </summary>
    [EnumMember(Value = "actionGetJourneySessionsByExternalContact")]
    Actiongetjourneysessionsbyexternalcontact,

    /// <summary>
    /// Enum Actiongetparticipantdata for "actionGetParticipantData"
    /// </summary>
    [EnumMember(Value = "actionGetParticipantData")]
    Actiongetparticipantdata,

    /// <summary>
    /// Enum Actiongetresponse for "actionGetResponse"
    /// </summary>
    [EnumMember(Value = "actionGetResponse")]
    Actiongetresponse,

    /// <summary>
    /// Enum Actiongetsecureddata for "actionGetSecuredData"
    /// </summary>
    [EnumMember(Value = "actionGetSecuredData")]
    Actiongetsecureddata,

    /// <summary>
    /// Enum Actionholdmusic for "actionHoldMusic"
    /// </summary>
    [EnumMember(Value = "actionHoldMusic")]
    Actionholdmusic,

    /// <summary>
    /// Enum Actioninitializeflowoutcome for "actionInitializeFlowOutcome"
    /// </summary>
    [EnumMember(Value = "actionInitializeFlowOutcome")]
    Actioninitializeflowoutcome,

    /// <summary>
    /// Enum Actionjumptomenu for "actionJumpToMenu"
    /// </summary>
    [EnumMember(Value = "actionJumpToMenu")]
    Actionjumptomenu,

    /// <summary>
    /// Enum Actionjumptotask for "actionJumpToTask"
    /// </summary>
    [EnumMember(Value = "actionJumpToTask")]
    Actionjumptotask,

    /// <summary>
    /// Enum Actionloop for "actionLoop"
    /// </summary>
    [EnumMember(Value = "actionLoop")]
    Actionloop,

    /// <summary>
    /// Enum Actionloopuntil for "actionLoopUntil"
    /// </summary>
    [EnumMember(Value = "actionLoopUntil")]
    Actionloopuntil,

    /// <summary>
    /// Enum Actionnextloop for "actionNextLoop"
    /// </summary>
    [EnumMember(Value = "actionNextLoop")]
    Actionnextloop,

    /// <summary>
    /// Enum Actionplayaudio for "actionPlayAudio"
    /// </summary>
    [EnumMember(Value = "actionPlayAudio")]
    Actionplayaudio,

    /// <summary>
    /// Enum Actionplayaudioonsilence for "actionPlayAudioOnSilence"
    /// </summary>
    [EnumMember(Value = "actionPlayAudioOnSilence")]
    Actionplayaudioonsilence,

    /// <summary>
    /// Enum Actionplayestimatedwaittime for "actionPlayEstimatedWaitTime"
    /// </summary>
    [EnumMember(Value = "actionPlayEstimatedWaitTime")]
    Actionplayestimatedwaittime,

    /// <summary>
    /// Enum Actionplaypositioninqueue for "actionPlayPositionInQueue"
    /// </summary>
    [EnumMember(Value = "actionPlayPositionInQueue")]
    Actionplaypositioninqueue,

    /// <summary>
    /// Enum Actionplayusergreeting for "actionPlayUserGreeting"
    /// </summary>
    [EnumMember(Value = "actionPlayUserGreeting")]
    Actionplayusergreeting,

    /// <summary>
    /// Enum Actionplayusername for "actionPlayUserName"
    /// </summary>
    [EnumMember(Value = "actionPlayUserName")]
    Actionplayusername,

    /// <summary>
    /// Enum Actionpreviousmenu for "actionPreviousMenu"
    /// </summary>
    [EnumMember(Value = "actionPreviousMenu")]
    Actionpreviousmenu,

    /// <summary>
    /// Enum Actionprocessvoicemailinput for "actionProcessVoicemailInput"
    /// </summary>
    [EnumMember(Value = "actionProcessVoicemailInput")]
    Actionprocessvoicemailinput,

    /// <summary>
    /// Enum Actionrepeatmenu for "actionRepeatMenu"
    /// </summary>
    [EnumMember(Value = "actionRepeatMenu")]
    Actionrepeatmenu,

    /// <summary>
    /// Enum Actionreturntoagent for "actionReturnToAgent"
    /// </summary>
    [EnumMember(Value = "actionReturnToAgent")]
    Actionreturntoagent,

    /// <summary>
    /// Enum Actionsaveworkitem for "actionSaveWorkitem"
    /// </summary>
    [EnumMember(Value = "actionSaveWorkitem")]
    Actionsaveworkitem,

    /// <summary>
    /// Enum Actionscreenpop for "actionScreenPop"
    /// </summary>
    [EnumMember(Value = "actionScreenPop")]
    Actionscreenpop,

    /// <summary>
    /// Enum Actionsearchexternalcontacts for "actionSearchExternalContacts"
    /// </summary>
    [EnumMember(Value = "actionSearchExternalContacts")]
    Actionsearchexternalcontacts,

    /// <summary>
    /// Enum Actionsendautoreply for "actionSendAutoReply"
    /// </summary>
    [EnumMember(Value = "actionSendAutoReply")]
    Actionsendautoreply,

    /// <summary>
    /// Enum Actionsendresponse for "actionSendResponse"
    /// </summary>
    [EnumMember(Value = "actionSendResponse")]
    Actionsendresponse,

    /// <summary>
    /// Enum Actionsetactiveintent for "actionSetActiveIntent"
    /// </summary>
    [EnumMember(Value = "actionSetActiveIntent")]
    Actionsetactiveintent,

    /// <summary>
    /// Enum Actionsetconversationdata for "actionSetConversationData"
    /// </summary>
    [EnumMember(Value = "actionSetConversationData")]
    Actionsetconversationdata,

    /// <summary>
    /// Enum Actionsetexternaltag for "actionSetExternalTag"
    /// </summary>
    [EnumMember(Value = "actionSetExternalTag")]
    Actionsetexternaltag,

    /// <summary>
    /// Enum Actionsetflowoutcome for "actionSetFlowOutcome"
    /// </summary>
    [EnumMember(Value = "actionSetFlowOutcome")]
    Actionsetflowoutcome,

    /// <summary>
    /// Enum Actionsetlocale for "actionSetLocale"
    /// </summary>
    [EnumMember(Value = "actionSetLocale")]
    Actionsetlocale,

    /// <summary>
    /// Enum Actionsetparticipantdata for "actionSetParticipantData"
    /// </summary>
    [EnumMember(Value = "actionSetParticipantData")]
    Actionsetparticipantdata,

    /// <summary>
    /// Enum Actionsetpriority for "actionSetPriority"
    /// </summary>
    [EnumMember(Value = "actionSetPriority")]
    Actionsetpriority,

    /// <summary>
    /// Enum Actionsetsecureddata for "actionSetSecuredData"
    /// </summary>
    [EnumMember(Value = "actionSetSecuredData")]
    Actionsetsecureddata,

    /// <summary>
    /// Enum Actionsetskills for "actionSetSkills"
    /// </summary>
    [EnumMember(Value = "actionSetSkills")]
    Actionsetskills,

    /// <summary>
    /// Enum Actionsetuuidata for "actionSetUUIData"
    /// </summary>
    [EnumMember(Value = "actionSetUUIData")]
    Actionsetuuidata,

    /// <summary>
    /// Enum Actionsetwhisperaudio for "actionSetWhisperAudio"
    /// </summary>
    [EnumMember(Value = "actionSetWhisperAudio")]
    Actionsetwhisperaudio,

    /// <summary>
    /// Enum Actionsetwrapupcode for "actionSetWrapupCode"
    /// </summary>
    [EnumMember(Value = "actionSetWrapupCode")]
    Actionsetwrapupcode,

    /// <summary>
    /// Enum Actionshowknowledgearticle for "actionShowKnowledgeArticle"
    /// </summary>
    [EnumMember(Value = "actionShowKnowledgeArticle")]
    Actionshowknowledgearticle,

    /// <summary>
    /// Enum Actionsubmitvoicemailsnippet for "actionSubmitVoicemailSnippet"
    /// </summary>
    [EnumMember(Value = "actionSubmitVoicemailSnippet")]
    Actionsubmitvoicemailsnippet,

    /// <summary>
    /// Enum Actionswitch for "actionSwitch"
    /// </summary>
    [EnumMember(Value = "actionSwitch")]
    Actionswitch,

    /// <summary>
    /// Enum Actiontranscription for "actionTranscription"
    /// </summary>
    [EnumMember(Value = "actionTranscription")]
    Actiontranscription,

    /// <summary>
    /// Enum Actiontransferexternal for "actionTransferExternal"
    /// </summary>
    [EnumMember(Value = "actionTransferExternal")]
    Actiontransferexternal,

    /// <summary>
    /// Enum Actiontransferflow for "actionTransferFlow"
    /// </summary>
    [EnumMember(Value = "actionTransferFlow")]
    Actiontransferflow,

    /// <summary>
    /// Enum Actiontransferflowsecure for "actionTransferFlowSecure"
    /// </summary>
    [EnumMember(Value = "actionTransferFlowSecure")]
    Actiontransferflowsecure,

    /// <summary>
    /// Enum Actiontransfergroup for "actionTransferGroup"
    /// </summary>
    [EnumMember(Value = "actionTransferGroup")]
    Actiontransfergroup,

    /// <summary>
    /// Enum Actiontransfertoacd for "actionTransferToAcd"
    /// </summary>
    [EnumMember(Value = "actionTransferToAcd")]
    Actiontransfertoacd,

    /// <summary>
    /// Enum Actiontransferuser for "actionTransferUser"
    /// </summary>
    [EnumMember(Value = "actionTransferUser")]
    Actiontransferuser,

    /// <summary>
    /// Enum Actiontransfervoicemail for "actionTransferVoicemail"
    /// </summary>
    [EnumMember(Value = "actionTransferVoicemail")]
    Actiontransfervoicemail,

    /// <summary>
    /// Enum Actionupdatedata for "actionUpdateData"
    /// </summary>
    [EnumMember(Value = "actionUpdateData")]
    Actionupdatedata,

    /// <summary>
    /// Enum Actionwait for "actionWait"
    /// </summary>
    [EnumMember(Value = "actionWait")]
    Actionwait,

    /// <summary>
    /// Enum Actionwaitforinput for "actionWaitForInput"
    /// </summary>
    [EnumMember(Value = "actionWaitForInput")]
    Actionwaitforinput,

    /// <summary>
    /// Enum Menudialextension for "menuDialExtension"
    /// </summary>
    [EnumMember(Value = "menuDialExtension")]
    Menudialextension,

    /// <summary>
    /// Enum Menudialname for "menuDialName"
    /// </summary>
    [EnumMember(Value = "menuDialName")]
    Menudialname,

    /// <summary>
    /// Enum Menudisconnect for "menuDisconnect"
    /// </summary>
    [EnumMember(Value = "menuDisconnect")]
    Menudisconnect,

    /// <summary>
    /// Enum Menujumptomenu for "menuJumpToMenu"
    /// </summary>
    [EnumMember(Value = "menuJumpToMenu")]
    Menujumptomenu,

    /// <summary>
    /// Enum Menujumptotask for "menuJumpToTask"
    /// </summary>
    [EnumMember(Value = "menuJumpToTask")]
    Menujumptotask,

    /// <summary>
    /// Enum Menumenu for "menuMenu"
    /// </summary>
    [EnumMember(Value = "menuMenu")]
    Menumenu,

    /// <summary>
    /// Enum Menupreviousmenu for "menuPreviousMenu"
    /// </summary>
    [EnumMember(Value = "menuPreviousMenu")]
    Menupreviousmenu,

    /// <summary>
    /// Enum Menurepeatmenu for "menuRepeatMenu"
    /// </summary>
    [EnumMember(Value = "menuRepeatMenu")]
    Menurepeatmenu,

    /// <summary>
    /// Enum Menushowknowledgearticle for "menuShowKnowledgeArticle"
    /// </summary>
    [EnumMember(Value = "menuShowKnowledgeArticle")]
    Menushowknowledgearticle,

    /// <summary>
    /// Enum Menutask for "menuTask"
    /// </summary>
    [EnumMember(Value = "menuTask")]
    Menutask,

    /// <summary>
    /// Enum Menutransfertoacd for "menuTransferToAcd"
    /// </summary>
    [EnumMember(Value = "menuTransferToAcd")]
    Menutransfertoacd,

    /// <summary>
    /// Enum Menutransferflow for "menuTransferFlow"
    /// </summary>
    [EnumMember(Value = "menuTransferFlow")]
    Menutransferflow,

    /// <summary>
    /// Enum Menutransfergroup for "menuTransferGroup"
    /// </summary>
    [EnumMember(Value = "menuTransferGroup")]
    Menutransfergroup,

    /// <summary>
    /// Enum Menutransferexternal for "menuTransferExternal"
    /// </summary>
    [EnumMember(Value = "menuTransferExternal")]
    Menutransferexternal,

    /// <summary>
    /// Enum Menutransferflowsecure for "menuTransferFlowSecure"
    /// </summary>
    [EnumMember(Value = "menuTransferFlowSecure")]
    Menutransferflowsecure,

    /// <summary>
    /// Enum Menutransferuser for "menuTransferUser"
    /// </summary>
    [EnumMember(Value = "menuTransferUser")]
    Menutransferuser,

    /// <summary>
    /// Enum Menutransfervoicemail for "menuTransferVoicemail"
    /// </summary>
    [EnumMember(Value = "menuTransferVoicemail")]
    Menutransfervoicemail
}
