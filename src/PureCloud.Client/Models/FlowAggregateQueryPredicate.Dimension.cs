using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum FlowAggregateQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Activerouting for "activeRouting"
    /// </summary>
    [EnumMember(Value = "activeRouting")]
    Activerouting,

    /// <summary>
    /// Enum Activeskillid for "activeSkillId"
    /// </summary>
    [EnumMember(Value = "activeSkillId")]
    Activeskillid,

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
    /// Enum Agentbullseyering for "agentBullseyeRing"
    /// </summary>
    [EnumMember(Value = "agentBullseyeRing")]
    Agentbullseyering,

    /// <summary>
    /// Enum Agentowned for "agentOwned"
    /// </summary>
    [EnumMember(Value = "agentOwned")]
    Agentowned,

    /// <summary>
    /// Enum Agentrank for "agentRank"
    /// </summary>
    [EnumMember(Value = "agentRank")]
    Agentrank,

    /// <summary>
    /// Enum Agentscore for "agentScore"
    /// </summary>
    [EnumMember(Value = "agentScore")]
    Agentscore,

    /// <summary>
    /// Enum Ani for "ani"
    /// </summary>
    [EnumMember(Value = "ani")]
    Ani,

    /// <summary>
    /// Enum Assignerid for "assignerId"
    /// </summary>
    [EnumMember(Value = "assignerId")]
    Assignerid,

    /// <summary>
    /// Enum Authenticated for "authenticated"
    /// </summary>
    [EnumMember(Value = "authenticated")]
    Authenticated,

    /// <summary>
    /// Enum Canonicalexternalcontactid for "canonicalExternalContactId"
    /// </summary>
    [EnumMember(Value = "canonicalExternalContactId")]
    Canonicalexternalcontactid,

    /// <summary>
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

    /// <summary>
    /// Enum Conversationinitiator for "conversationInitiator"
    /// </summary>
    [EnumMember(Value = "conversationInitiator")]
    Conversationinitiator,

    /// <summary>
    /// Enum Convertedfrom for "convertedFrom"
    /// </summary>
    [EnumMember(Value = "convertedFrom")]
    Convertedfrom,

    /// <summary>
    /// Enum Convertedto for "convertedTo"
    /// </summary>
    [EnumMember(Value = "convertedTo")]
    Convertedto,

    /// <summary>
    /// Enum Customerparticipation for "customerParticipation"
    /// </summary>
    [EnumMember(Value = "customerParticipation")]
    Customerparticipation,

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
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

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
    /// Enum Eligibleagentcount for "eligibleAgentCount"
    /// </summary>
    [EnumMember(Value = "eligibleAgentCount")]
    Eligibleagentcount,

    /// <summary>
    /// Enum Endinglanguage for "endingLanguage"
    /// </summary>
    [EnumMember(Value = "endingLanguage")]
    Endinglanguage,

    /// <summary>
    /// Enum Entryreason for "entryReason"
    /// </summary>
    [EnumMember(Value = "entryReason")]
    Entryreason,

    /// <summary>
    /// Enum Entrytype for "entryType"
    /// </summary>
    [EnumMember(Value = "entryType")]
    Entrytype,

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
    /// Enum Externalmediacount for "externalMediaCount"
    /// </summary>
    [EnumMember(Value = "externalMediaCount")]
    Externalmediacount,

    /// <summary>
    /// Enum Externalorganizationid for "externalOrganizationId"
    /// </summary>
    [EnumMember(Value = "externalOrganizationId")]
    Externalorganizationid,

    /// <summary>
    /// Enum Externaltag for "externalTag"
    /// </summary>
    [EnumMember(Value = "externalTag")]
    Externaltag,

    /// <summary>
    /// Enum Firstqueue for "firstQueue"
    /// </summary>
    [EnumMember(Value = "firstQueue")]
    Firstqueue,

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
    /// Enum Flowintype for "flowInType"
    /// </summary>
    [EnumMember(Value = "flowInType")]
    Flowintype,

    /// <summary>
    /// Enum Flowmilestoneid for "flowMilestoneId"
    /// </summary>
    [EnumMember(Value = "flowMilestoneId")]
    Flowmilestoneid,

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
    /// Enum Flowsubtype for "flowSubType"
    /// </summary>
    [EnumMember(Value = "flowSubType")]
    Flowsubtype,

    /// <summary>
    /// Enum Flowtype for "flowType"
    /// </summary>
    [EnumMember(Value = "flowType")]
    Flowtype,

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
    /// Enum Interactiontype for "interactionType"
    /// </summary>
    [EnumMember(Value = "interactionType")]
    Interactiontype,

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
    /// Enum Journeyactionmapversion for "journeyActionMapVersion"
    /// </summary>
    [EnumMember(Value = "journeyActionMapVersion")]
    Journeyactionmapversion,

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
    /// Enum Journeycustomersessionidtype for "journeyCustomerSessionIdType"
    /// </summary>
    [EnumMember(Value = "journeyCustomerSessionIdType")]
    Journeycustomersessionidtype,

    /// <summary>
    /// Enum Knowledgebaseid for "knowledgeBaseId"
    /// </summary>
    [EnumMember(Value = "knowledgeBaseId")]
    Knowledgebaseid,

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
    /// Enum Originatingdirection for "originatingDirection"
    /// </summary>
    [EnumMember(Value = "originatingDirection")]
    Originatingdirection,

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
    /// Enum Peerid for "peerId"
    /// </summary>
    [EnumMember(Value = "peerId")]
    Peerid,

    /// <summary>
    /// Enum Proposedagentid for "proposedAgentId"
    /// </summary>
    [EnumMember(Value = "proposedAgentId")]
    Proposedagentid,

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
    /// Enum Recognitionfailurereason for "recognitionFailureReason"
    /// </summary>
    [EnumMember(Value = "recognitionFailureReason")]
    Recognitionfailurereason,

    /// <summary>
    /// Enum Remote for "remote"
    /// </summary>
    [EnumMember(Value = "remote")]
    Remote,

    /// <summary>
    /// Enum Removedskillid for "removedSkillId"
    /// </summary>
    [EnumMember(Value = "removedSkillId")]
    Removedskillid,

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
    /// Enum Roomid for "roomId"
    /// </summary>
    [EnumMember(Value = "roomId")]
    Roomid,

    /// <summary>
    /// Enum Routingpriority for "routingPriority"
    /// </summary>
    [EnumMember(Value = "routingPriority")]
    Routingpriority,

    /// <summary>
    /// Enum Routingring for "routingRing"
    /// </summary>
    [EnumMember(Value = "routingRing")]
    Routingring,

    /// <summary>
    /// Enum Routingrule for "routingRule"
    /// </summary>
    [EnumMember(Value = "routingRule")]
    Routingrule,

    /// <summary>
    /// Enum Routingruletype for "routingRuleType"
    /// </summary>
    [EnumMember(Value = "routingRuleType")]
    Routingruletype,

    /// <summary>
    /// Enum Scoredagentid for "scoredAgentId"
    /// </summary>
    [EnumMember(Value = "scoredAgentId")]
    Scoredagentid,

    /// <summary>
    /// Enum Selectedagentid for "selectedAgentId"
    /// </summary>
    [EnumMember(Value = "selectedAgentId")]
    Selectedagentid,

    /// <summary>
    /// Enum Selectedagentrank for "selectedAgentRank"
    /// </summary>
    [EnumMember(Value = "selectedAgentRank")]
    Selectedagentrank,

    /// <summary>
    /// Enum Selfserved for "selfServed"
    /// </summary>
    [EnumMember(Value = "selfServed")]
    Selfserved,

    /// <summary>
    /// Enum Sessiondnis for "sessionDnis"
    /// </summary>
    [EnumMember(Value = "sessionDnis")]
    Sessiondnis,

    /// <summary>
    /// Enum Sessionid for "sessionId"
    /// </summary>
    [EnumMember(Value = "sessionId")]
    Sessionid,

    /// <summary>
    /// Enum Startinglanguage for "startingLanguage"
    /// </summary>
    [EnumMember(Value = "startingLanguage")]
    Startinglanguage,

    /// <summary>
    /// Enum Stationid for "stationId"
    /// </summary>
    [EnumMember(Value = "stationId")]
    Stationid,

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
    /// Enum Videopresent for "videoPresent"
    /// </summary>
    [EnumMember(Value = "videoPresent")]
    Videopresent,

    /// <summary>
    /// Enum Waitinginteractioncount for "waitingInteractionCount"
    /// </summary>
    [EnumMember(Value = "waitingInteractionCount")]
    Waitinginteractioncount,

    /// <summary>
    /// Enum Wrapupcode for "wrapUpCode"
    /// </summary>
    [EnumMember(Value = "wrapUpCode")]
    Wrapupcode
}
