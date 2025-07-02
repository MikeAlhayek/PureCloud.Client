using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowActivityQueryGroupByEnum
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
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

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
    /// Enum Direction for "direction"
    /// </summary>
    [EnumMember(Value = "direction")]
    Direction,

    /// <summary>
    /// Enum Dnis for "dnis"
    /// </summary>
    [EnumMember(Value = "dnis")]
    Dnis,

    /// <summary>
    /// Enum Flowid for "flowId"
    /// </summary>
    [EnumMember(Value = "flowId")]
    Flowid,

    /// <summary>
    /// Enum Flowtype for "flowType"
    /// </summary>
    [EnumMember(Value = "flowType")]
    Flowtype,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Participantname for "participantName"
    /// </summary>
    [EnumMember(Value = "participantName")]
    Participantname,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

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
    /// Enum Routingpriority for "routingPriority"
    /// </summary>
    [EnumMember(Value = "routingPriority")]
    Routingpriority,

    /// <summary>
    /// Enum Scoredagentid for "scoredAgentId"
    /// </summary>
    [EnumMember(Value = "scoredAgentId")]
    Scoredagentid,

    /// <summary>
    /// Enum Sessionid for "sessionId"
    /// </summary>
    [EnumMember(Value = "sessionId")]
    Sessionid,

    /// <summary>
    /// Enum Teamid for "teamId"
    /// </summary>
    [EnumMember(Value = "teamId")]
    Teamid,

    /// <summary>
    /// Enum Usedrouting for "usedRouting"
    /// </summary>
    [EnumMember(Value = "usedRouting")]
    Usedrouting,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
