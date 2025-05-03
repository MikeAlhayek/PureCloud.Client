using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationAggregateQueryPredicate
/// </summary>

public partial class ConversationAggregateQueryPredicate : IEquatable<ConversationAggregateQueryPredicate>
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Dimension for "dimension"
        /// </summary>
        [EnumMember(Value = "dimension")]
        Dimension,

        /// <summary>
        /// Enum Property for "property"
        /// </summary>
        [EnumMember(Value = "property")]
        Property,

        /// <summary>
        /// Enum Metric for "metric"
        /// </summary>
        [EnumMember(Value = "metric")]
        Metric
    }
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    
    public enum DimensionEnum
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
        /// Enum Errorcode for "errorCode"
        /// </summary>
        [EnumMember(Value = "errorCode")]
        Errorcode,

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
        /// Enum Flowintype for "flowInType"
        /// </summary>
        [EnumMember(Value = "flowInType")]
        Flowintype,

        /// <summary>
        /// Enum Flowouttype for "flowOutType"
        /// </summary>
        [EnumMember(Value = "flowOutType")]
        Flowouttype,

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
        /// Enum Originatingsocialmediapublic for "originatingSocialMediaPublic"
        /// </summary>
        [EnumMember(Value = "originatingSocialMediaPublic")]
        Originatingsocialmediapublic,

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
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Matches for "matches"
        /// </summary>
        [EnumMember(Value = "matches")]
        Matches,

        /// <summary>
        /// Enum Exists for "exists"
        /// </summary>
        [EnumMember(Value = "exists")]
        Exists,

        /// <summary>
        /// Enum Notexists for "notExists"
        /// </summary>
        [EnumMember(Value = "notExists")]
        Notexists
    }
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    [JsonPropertyName("dimension")]
    public DimensionEnum? Dimension { get; set; }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationAggregateQueryPredicate" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Dimension">Left hand side for dimension predicates.</param>
    /// <param name="Operator">Optional operator, default is matches.</param>
    /// <param name="Value">Right hand side for dimension predicates.</param>
    /// <param name="Range">Right hand side for dimension predicates.</param>
    public ConversationAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
    {
        this.Type = Type;
        this.Dimension = Dimension;
        this.Operator = Operator;
        this.Value = Value;
        this.Range = Range;

    }









    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    [JsonPropertyName("range")]
    public NumericRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationAggregateQueryPredicate {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Range: ").Append(Range).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ConversationAggregateQueryPredicate);
    }

    /// <summary>
    /// Returns true if ConversationAggregateQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationAggregateQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationAggregateQueryPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Dimension == other.Dimension ||
                Dimension != null &&
                Dimension.Equals(other.Dimension)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Range == other.Range ||
                Range != null &&
                Range.Equals(other.Range)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Dimension != null)
            {
                hash = hash * 59 + Dimension.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Range != null)
            {
                hash = hash * 59 + Range.GetHashCode();
            }

            return hash;
        }
    }
}
