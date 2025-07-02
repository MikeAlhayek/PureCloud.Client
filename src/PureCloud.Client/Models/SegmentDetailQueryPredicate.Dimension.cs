using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum SegmentDetailQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Addressfrom for "addressFrom"
    /// </summary>
    [EnumMember(Value = "addressFrom")]
    Addressfrom,

    /// <summary>
    /// Enum Addressto for "addressTo"
    /// </summary>
    [EnumMember(Value = "addressTo")]
    Addressto,

    /// <summary>
    /// Enum Agentassistantid for "agentAssistantId"
    /// </summary>
    [EnumMember(Value = "agentAssistantId")]
    Agentassistantid,

    /// <summary>
    /// Enum Agentowned for "agentOwned"
    /// </summary>
    [EnumMember(Value = "agentOwned")]
    Agentowned,

    /// <summary>
    /// Enum Ani for "ani"
    /// </summary>
    [EnumMember(Value = "ani")]
    Ani,

    /// <summary>
    /// Enum Authenticated for "authenticated"
    /// </summary>
    [EnumMember(Value = "authenticated")]
    Authenticated,

    /// <summary>
    /// Enum Bargedparticipantid for "bargedParticipantId"
    /// </summary>
    [EnumMember(Value = "bargedParticipantId")]
    Bargedparticipantid,

    /// <summary>
    /// Enum Callbacknumber for "callbackNumber"
    /// </summary>
    [EnumMember(Value = "callbackNumber")]
    Callbacknumber,

    /// <summary>
    /// Enum Callbackscheduledtime for "callbackScheduledTime"
    /// </summary>
    [EnumMember(Value = "callbackScheduledTime")]
    Callbackscheduledtime,

    /// <summary>
    /// Enum Canonicalexternalcontactid for "canonicalExternalContactId"
    /// </summary>
    [EnumMember(Value = "canonicalExternalContactId")]
    Canonicalexternalcontactid,

    /// <summary>
    /// Enum Cleared for "cleared"
    /// </summary>
    [EnumMember(Value = "cleared")]
    Cleared,

    /// <summary>
    /// Enum Coachedparticipantid for "coachedParticipantId"
    /// </summary>
    [EnumMember(Value = "coachedParticipantId")]
    Coachedparticipantid,

    /// <summary>
    /// Enum Conference for "conference"
    /// </summary>
    [EnumMember(Value = "conference")]
    Conference,

    /// <summary>
    /// Enum Deliverypushed for "deliveryPushed"
    /// </summary>
    [EnumMember(Value = "deliveryPushed")]
    Deliverypushed,

    /// <summary>
    /// Enum Deliverystatus for "deliveryStatus"
    /// </summary>
    [EnumMember(Value = "deliveryStatus")]
    Deliverystatus,

    /// <summary>
    /// Enum Destinationaddress for "destinationAddress"
    /// </summary>
    [EnumMember(Value = "destinationAddress")]
    Destinationaddress,

    /// <summary>
    /// Enum Destinationconversationid for "destinationConversationId"
    /// </summary>
    [EnumMember(Value = "destinationConversationId")]
    Destinationconversationid,

    /// <summary>
    /// Enum Detectedspeechend for "detectedSpeechEnd"
    /// </summary>
    [EnumMember(Value = "detectedSpeechEnd")]
    Detectedspeechend,

    /// <summary>
    /// Enum Detectedspeechstart for "detectedSpeechStart"
    /// </summary>
    [EnumMember(Value = "detectedSpeechStart")]
    Detectedspeechstart,

    /// <summary>
    /// Enum Direction for "direction"
    /// </summary>
    [EnumMember(Value = "direction")]
    Direction,

    /// <summary>
    /// Enum Disconnecttype for "disconnectType"
    /// </summary>
    [EnumMember(Value = "disconnectType")]
    Disconnecttype,

    /// <summary>
    /// Enum Dnis for "dnis"
    /// </summary>
    [EnumMember(Value = "dnis")]
    Dnis,

    /// <summary>
    /// Enum Edgeid for "edgeId"
    /// </summary>
    [EnumMember(Value = "edgeId")]
    Edgeid,

    /// <summary>
    /// Enum Errorcode for "errorCode"
    /// </summary>
    [EnumMember(Value = "errorCode")]
    Errorcode,

    /// <summary>
    /// Enum Exitreason for "exitReason"
    /// </summary>
    [EnumMember(Value = "exitReason")]
    Exitreason,

    /// <summary>
    /// Enum Extendeddeliverystatus for "extendedDeliveryStatus"
    /// </summary>
    [EnumMember(Value = "extendedDeliveryStatus")]
    Extendeddeliverystatus,

    /// <summary>
    /// Enum Externalcontactid for "externalContactId"
    /// </summary>
    [EnumMember(Value = "externalContactId")]
    Externalcontactid,

    /// <summary>
    /// Enum Externalorganizationid for "externalOrganizationId"
    /// </summary>
    [EnumMember(Value = "externalOrganizationId")]
    Externalorganizationid,

    /// <summary>
    /// Enum Flaggedreason for "flaggedReason"
    /// </summary>
    [EnumMember(Value = "flaggedReason")]
    Flaggedreason,

    /// <summary>
    /// Enum Flowid for "flowId"
    /// </summary>
    [EnumMember(Value = "flowId")]
    Flowid,

    /// <summary>
    /// Enum Flowname for "flowName"
    /// </summary>
    [EnumMember(Value = "flowName")]
    Flowname,

    /// <summary>
    /// Enum Flowouttype for "flowOutType"
    /// </summary>
    [EnumMember(Value = "flowOutType")]
    Flowouttype,

    /// <summary>
    /// Enum Flowoutcome for "flowOutcome"
    /// </summary>
    [EnumMember(Value = "flowOutcome")]
    Flowoutcome,

    /// <summary>
    /// Enum Flowoutcomeid for "flowOutcomeId"
    /// </summary>
    [EnumMember(Value = "flowOutcomeId")]
    Flowoutcomeid,

    /// <summary>
    /// Enum Flowoutcomevalue for "flowOutcomeValue"
    /// </summary>
    [EnumMember(Value = "flowOutcomeValue")]
    Flowoutcomevalue,

    /// <summary>
    /// Enum Flowversion for "flowVersion"
    /// </summary>
    [EnumMember(Value = "flowVersion")]
    Flowversion,

    /// <summary>
    /// Enum Groupid for "groupId"
    /// </summary>
    [EnumMember(Value = "groupId")]
    Groupid,

    /// <summary>
    /// Enum Journeyactionid for "journeyActionId"
    /// </summary>
    [EnumMember(Value = "journeyActionId")]
    Journeyactionid,

    /// <summary>
    /// Enum Journeyactionmapid for "journeyActionMapId"
    /// </summary>
    [EnumMember(Value = "journeyActionMapId")]
    Journeyactionmapid,

    /// <summary>
    /// Enum Journeycustomerid for "journeyCustomerId"
    /// </summary>
    [EnumMember(Value = "journeyCustomerId")]
    Journeycustomerid,

    /// <summary>
    /// Enum Journeycustomeridtype for "journeyCustomerIdType"
    /// </summary>
    [EnumMember(Value = "journeyCustomerIdType")]
    Journeycustomeridtype,

    /// <summary>
    /// Enum Journeycustomersessionid for "journeyCustomerSessionId"
    /// </summary>
    [EnumMember(Value = "journeyCustomerSessionId")]
    Journeycustomersessionid,

    /// <summary>
    /// Enum Mediacount for "mediaCount"
    /// </summary>
    [EnumMember(Value = "mediaCount")]
    Mediacount,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Messagetype for "messageType"
    /// </summary>
    [EnumMember(Value = "messageType")]
    Messagetype,

    /// <summary>
    /// Enum Monitoredparticipantid for "monitoredParticipantId"
    /// </summary>
    [EnumMember(Value = "monitoredParticipantId")]
    Monitoredparticipantid,

    /// <summary>
    /// Enum Outboundcampaignid for "outboundCampaignId"
    /// </summary>
    [EnumMember(Value = "outboundCampaignId")]
    Outboundcampaignid,

    /// <summary>
    /// Enum Outboundcontactid for "outboundContactId"
    /// </summary>
    [EnumMember(Value = "outboundContactId")]
    Outboundcontactid,

    /// <summary>
    /// Enum Outboundcontactlistid for "outboundContactListId"
    /// </summary>
    [EnumMember(Value = "outboundContactListId")]
    Outboundcontactlistid,

    /// <summary>
    /// Enum Participantname for "participantName"
    /// </summary>
    [EnumMember(Value = "participantName")]
    Participantname,

    /// <summary>
    /// Enum Protocolcallid for "protocolCallId"
    /// </summary>
    [EnumMember(Value = "protocolCallId")]
    Protocolcallid,

    /// <summary>
    /// Enum Provider for "provider"
    /// </summary>
    [EnumMember(Value = "provider")]
    Provider,

    /// <summary>
    /// Enum Purpose for "purpose"
    /// </summary>
    [EnumMember(Value = "purpose")]
    Purpose,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Recording for "recording"
    /// </summary>
    [EnumMember(Value = "recording")]
    Recording,

    /// <summary>
    /// Enum Remote for "remote"
    /// </summary>
    [EnumMember(Value = "remote")]
    Remote,

    /// <summary>
    /// Enum Remotenamedisplayable for "remoteNameDisplayable"
    /// </summary>
    [EnumMember(Value = "remoteNameDisplayable")]
    Remotenamedisplayable,

    /// <summary>
    /// Enum Requestedlanguageid for "requestedLanguageId"
    /// </summary>
    [EnumMember(Value = "requestedLanguageId")]
    Requestedlanguageid,

    /// <summary>
    /// Enum Requestedrouting for "requestedRouting"
    /// </summary>
    [EnumMember(Value = "requestedRouting")]
    Requestedrouting,

    /// <summary>
    /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
    /// </summary>
    [EnumMember(Value = "requestedRoutingSkillId")]
    Requestedroutingskillid,

    /// <summary>
    /// Enum Scoredagentid for "scoredAgentId"
    /// </summary>
    [EnumMember(Value = "scoredAgentId")]
    Scoredagentid,

    /// <summary>
    /// Enum Screenrecording for "screenRecording"
    /// </summary>
    [EnumMember(Value = "screenRecording")]
    Screenrecording,

    /// <summary>
    /// Enum Scriptid for "scriptId"
    /// </summary>
    [EnumMember(Value = "scriptId")]
    Scriptid,

    /// <summary>
    /// Enum Segmentend for "segmentEnd"
    /// </summary>
    [EnumMember(Value = "segmentEnd")]
    Segmentend,

    /// <summary>
    /// Enum Segmenttype for "segmentType"
    /// </summary>
    [EnumMember(Value = "segmentType")]
    Segmenttype,

    /// <summary>
    /// Enum Sessiondnis for "sessionDnis"
    /// </summary>
    [EnumMember(Value = "sessionDnis")]
    Sessiondnis,

    /// <summary>
    /// Enum Sipresponsecode for "sipResponseCode"
    /// </summary>
    [EnumMember(Value = "sipResponseCode")]
    Sipresponsecode,

    /// <summary>
    /// Enum Subject for "subject"
    /// </summary>
    [EnumMember(Value = "subject")]
    Subject,

    /// <summary>
    /// Enum Teamid for "teamId"
    /// </summary>
    [EnumMember(Value = "teamId")]
    Teamid,

    /// <summary>
    /// Enum Transfertargetaddress for "transferTargetAddress"
    /// </summary>
    [EnumMember(Value = "transferTargetAddress")]
    Transfertargetaddress,

    /// <summary>
    /// Enum Transfertargetname for "transferTargetName"
    /// </summary>
    [EnumMember(Value = "transferTargetName")]
    Transfertargetname,

    /// <summary>
    /// Enum Transfertype for "transferType"
    /// </summary>
    [EnumMember(Value = "transferType")]
    Transfertype,

    /// <summary>
    /// Enum Usedrouting for "usedRouting"
    /// </summary>
    [EnumMember(Value = "usedRouting")]
    Usedrouting,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Wrapupcode for "wrapUpCode"
    /// </summary>
    [EnumMember(Value = "wrapUpCode")]
    Wrapupcode,

    /// <summary>
    /// Enum Wrapupnote for "wrapUpNote"
    /// </summary>
    [EnumMember(Value = "wrapUpNote")]
    Wrapupnote
}
