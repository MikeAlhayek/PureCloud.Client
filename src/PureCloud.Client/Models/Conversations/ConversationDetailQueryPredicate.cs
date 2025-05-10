using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationDetailQueryPredicate
/// </summary>

public partial class ConversationDetailQueryPredicate : IEquatable<ConversationDetailQueryPredicate>
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
        /// Enum Conversationend for "conversationEnd"
        /// </summary>
        [EnumMember(Value = "conversationEnd")]
        Conversationend,

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
        /// Enum Conversationstart for "conversationStart"
        /// </summary>
        [EnumMember(Value = "conversationStart")]
        Conversationstart,

        /// <summary>
        /// Enum Customerparticipation for "customerParticipation"
        /// </summary>
        [EnumMember(Value = "customerParticipation")]
        Customerparticipation,

        /// <summary>
        /// Enum Divisionid for "divisionId"
        /// </summary>
        [EnumMember(Value = "divisionId")]
        Divisionid,

        /// <summary>
        /// Enum Externaltag for "externalTag"
        /// </summary>
        [EnumMember(Value = "externalTag")]
        Externaltag,

        /// <summary>
        /// Enum Mediastatsminconversationmos for "mediaStatsMinConversationMos"
        /// </summary>
        [EnumMember(Value = "mediaStatsMinConversationMos")]
        Mediastatsminconversationmos,

        /// <summary>
        /// Enum Originatingdirection for "originatingDirection"
        /// </summary>
        [EnumMember(Value = "originatingDirection")]
        Originatingdirection,

        /// <summary>
        /// Enum Originatingsocialmediapublic for "originatingSocialMediaPublic"
        /// </summary>
        [EnumMember(Value = "originatingSocialMediaPublic")]
        Originatingsocialmediapublic
    }
    /// <summary>
    /// Left hand side for metric predicates
    /// </summary>
    /// <value>Left hand side for metric predicates</value>
    
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nblindtransferred for "nBlindTransferred"
        /// </summary>
        [EnumMember(Value = "nBlindTransferred")]
        Nblindtransferred,

        /// <summary>
        /// Enum Nbotinteractions for "nBotInteractions"
        /// </summary>
        [EnumMember(Value = "nBotInteractions")]
        Nbotinteractions,

        /// <summary>
        /// Enum Ncobrowsesessions for "nCobrowseSessions"
        /// </summary>
        [EnumMember(Value = "nCobrowseSessions")]
        Ncobrowsesessions,

        /// <summary>
        /// Enum Nconnected for "nConnected"
        /// </summary>
        [EnumMember(Value = "nConnected")]
        Nconnected,

        /// <summary>
        /// Enum Nconsult for "nConsult"
        /// </summary>
        [EnumMember(Value = "nConsult")]
        Nconsult,

        /// <summary>
        /// Enum Nconsulttransferred for "nConsultTransferred"
        /// </summary>
        [EnumMember(Value = "nConsultTransferred")]
        Nconsulttransferred,

        /// <summary>
        /// Enum Nerror for "nError"
        /// </summary>
        [EnumMember(Value = "nError")]
        Nerror,

        /// <summary>
        /// Enum Nflow for "nFlow"
        /// </summary>
        [EnumMember(Value = "nFlow")]
        Nflow,

        /// <summary>
        /// Enum Nflowmilestone for "nFlowMilestone"
        /// </summary>
        [EnumMember(Value = "nFlowMilestone")]
        Nflowmilestone,

        /// <summary>
        /// Enum Nflowoutcome for "nFlowOutcome"
        /// </summary>
        [EnumMember(Value = "nFlowOutcome")]
        Nflowoutcome,

        /// <summary>
        /// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
        /// </summary>
        [EnumMember(Value = "nFlowOutcomeFailed")]
        Nflowoutcomefailed,

        /// <summary>
        /// Enum Noffered for "nOffered"
        /// </summary>
        [EnumMember(Value = "nOffered")]
        Noffered,

        /// <summary>
        /// Enum Noutbound for "nOutbound"
        /// </summary>
        [EnumMember(Value = "nOutbound")]
        Noutbound,

        /// <summary>
        /// Enum Noutboundabandoned for "nOutboundAbandoned"
        /// </summary>
        [EnumMember(Value = "nOutboundAbandoned")]
        Noutboundabandoned,

        /// <summary>
        /// Enum Noutboundattempted for "nOutboundAttempted"
        /// </summary>
        [EnumMember(Value = "nOutboundAttempted")]
        Noutboundattempted,

        /// <summary>
        /// Enum Noutboundconnected for "nOutboundConnected"
        /// </summary>
        [EnumMember(Value = "nOutboundConnected")]
        Noutboundconnected,

        /// <summary>
        /// Enum Noversla for "nOverSla"
        /// </summary>
        [EnumMember(Value = "nOverSla")]
        Noversla,

        /// <summary>
        /// Enum Nstatetransitionerror for "nStateTransitionError"
        /// </summary>
        [EnumMember(Value = "nStateTransitionError")]
        Nstatetransitionerror,

        /// <summary>
        /// Enum Ntransferred for "nTransferred"
        /// </summary>
        [EnumMember(Value = "nTransferred")]
        Ntransferred,

        /// <summary>
        /// Enum Oexternalmediacount for "oExternalMediaCount"
        /// </summary>
        [EnumMember(Value = "oExternalMediaCount")]
        Oexternalmediacount,

        /// <summary>
        /// Enum Oflowmilestone for "oFlowMilestone"
        /// </summary>
        [EnumMember(Value = "oFlowMilestone")]
        Oflowmilestone,

        /// <summary>
        /// Enum Omediacount for "oMediaCount"
        /// </summary>
        [EnumMember(Value = "oMediaCount")]
        Omediacount,

        /// <summary>
        /// Enum Omessagecount for "oMessageCount"
        /// </summary>
        [EnumMember(Value = "oMessageCount")]
        Omessagecount,

        /// <summary>
        /// Enum Omessagesegmentcount for "oMessageSegmentCount"
        /// </summary>
        [EnumMember(Value = "oMessageSegmentCount")]
        Omessagesegmentcount,

        /// <summary>
        /// Enum Omessageturn for "oMessageTurn"
        /// </summary>
        [EnumMember(Value = "oMessageTurn")]
        Omessageturn,

        /// <summary>
        /// Enum Tabandon for "tAbandon"
        /// </summary>
        [EnumMember(Value = "tAbandon")]
        Tabandon,

        /// <summary>
        /// Enum Tacd for "tAcd"
        /// </summary>
        [EnumMember(Value = "tAcd")]
        Tacd,

        /// <summary>
        /// Enum Tactivecallback for "tActiveCallback"
        /// </summary>
        [EnumMember(Value = "tActiveCallback")]
        Tactivecallback,

        /// <summary>
        /// Enum Tactivecallbackcomplete for "tActiveCallbackComplete"
        /// </summary>
        [EnumMember(Value = "tActiveCallbackComplete")]
        Tactivecallbackcomplete,

        /// <summary>
        /// Enum Tacw for "tAcw"
        /// </summary>
        [EnumMember(Value = "tAcw")]
        Tacw,

        /// <summary>
        /// Enum Tagentresponsetime for "tAgentResponseTime"
        /// </summary>
        [EnumMember(Value = "tAgentResponseTime")]
        Tagentresponsetime,

        /// <summary>
        /// Enum Talert for "tAlert"
        /// </summary>
        [EnumMember(Value = "tAlert")]
        Talert,

        /// <summary>
        /// Enum Tanswered for "tAnswered"
        /// </summary>
        [EnumMember(Value = "tAnswered")]
        Tanswered,

        /// <summary>
        /// Enum Taverageagentresponsetime for "tAverageAgentResponseTime"
        /// </summary>
        [EnumMember(Value = "tAverageAgentResponseTime")]
        Taverageagentresponsetime,

        /// <summary>
        /// Enum Taveragecustomerresponsetime for "tAverageCustomerResponseTime"
        /// </summary>
        [EnumMember(Value = "tAverageCustomerResponseTime")]
        Taveragecustomerresponsetime,

        /// <summary>
        /// Enum Tbarging for "tBarging"
        /// </summary>
        [EnumMember(Value = "tBarging")]
        Tbarging,

        /// <summary>
        /// Enum Tcoaching for "tCoaching"
        /// </summary>
        [EnumMember(Value = "tCoaching")]
        Tcoaching,

        /// <summary>
        /// Enum Tcoachingcomplete for "tCoachingComplete"
        /// </summary>
        [EnumMember(Value = "tCoachingComplete")]
        Tcoachingcomplete,

        /// <summary>
        /// Enum Tconnected for "tConnected"
        /// </summary>
        [EnumMember(Value = "tConnected")]
        Tconnected,

        /// <summary>
        /// Enum Tcontacting for "tContacting"
        /// </summary>
        [EnumMember(Value = "tContacting")]
        Tcontacting,

        /// <summary>
        /// Enum Tconversationduration for "tConversationDuration"
        /// </summary>
        [EnumMember(Value = "tConversationDuration")]
        Tconversationduration,

        /// <summary>
        /// Enum Tdialing for "tDialing"
        /// </summary>
        [EnumMember(Value = "tDialing")]
        Tdialing,

        /// <summary>
        /// Enum Tfirstconnect for "tFirstConnect"
        /// </summary>
        [EnumMember(Value = "tFirstConnect")]
        Tfirstconnect,

        /// <summary>
        /// Enum Tfirstdial for "tFirstDial"
        /// </summary>
        [EnumMember(Value = "tFirstDial")]
        Tfirstdial,

        /// <summary>
        /// Enum Tfirstengagement for "tFirstEngagement"
        /// </summary>
        [EnumMember(Value = "tFirstEngagement")]
        Tfirstengagement,

        /// <summary>
        /// Enum Tfirstresponse for "tFirstResponse"
        /// </summary>
        [EnumMember(Value = "tFirstResponse")]
        Tfirstresponse,

        /// <summary>
        /// Enum Tflow for "tFlow"
        /// </summary>
        [EnumMember(Value = "tFlow")]
        Tflow,

        /// <summary>
        /// Enum Tflowdisconnect for "tFlowDisconnect"
        /// </summary>
        [EnumMember(Value = "tFlowDisconnect")]
        Tflowdisconnect,

        /// <summary>
        /// Enum Tflowexit for "tFlowExit"
        /// </summary>
        [EnumMember(Value = "tFlowExit")]
        Tflowexit,

        /// <summary>
        /// Enum Tflowout for "tFlowOut"
        /// </summary>
        [EnumMember(Value = "tFlowOut")]
        Tflowout,

        /// <summary>
        /// Enum Tflowoutcome for "tFlowOutcome"
        /// </summary>
        [EnumMember(Value = "tFlowOutcome")]
        Tflowoutcome,

        /// <summary>
        /// Enum Thandle for "tHandle"
        /// </summary>
        [EnumMember(Value = "tHandle")]
        Thandle,

        /// <summary>
        /// Enum Theld for "tHeld"
        /// </summary>
        [EnumMember(Value = "tHeld")]
        Theld,

        /// <summary>
        /// Enum Theldcomplete for "tHeldComplete"
        /// </summary>
        [EnumMember(Value = "tHeldComplete")]
        Theldcomplete,

        /// <summary>
        /// Enum Tivr for "tIvr"
        /// </summary>
        [EnumMember(Value = "tIvr")]
        Tivr,

        /// <summary>
        /// Enum Tmonitoring for "tMonitoring"
        /// </summary>
        [EnumMember(Value = "tMonitoring")]
        Tmonitoring,

        /// <summary>
        /// Enum Tmonitoringcomplete for "tMonitoringComplete"
        /// </summary>
        [EnumMember(Value = "tMonitoringComplete")]
        Tmonitoringcomplete,

        /// <summary>
        /// Enum Tnotresponding for "tNotResponding"
        /// </summary>
        [EnumMember(Value = "tNotResponding")]
        Tnotresponding,

        /// <summary>
        /// Enum Tpark for "tPark"
        /// </summary>
        [EnumMember(Value = "tPark")]
        Tpark,

        /// <summary>
        /// Enum Tparkcomplete for "tParkComplete"
        /// </summary>
        [EnumMember(Value = "tParkComplete")]
        Tparkcomplete,

        /// <summary>
        /// Enum Tshortabandon for "tShortAbandon"
        /// </summary>
        [EnumMember(Value = "tShortAbandon")]
        Tshortabandon,

        /// <summary>
        /// Enum Ttalk for "tTalk"
        /// </summary>
        [EnumMember(Value = "tTalk")]
        Ttalk,

        /// <summary>
        /// Enum Ttalkcomplete for "tTalkComplete"
        /// </summary>
        [EnumMember(Value = "tTalkComplete")]
        Ttalkcomplete,

        /// <summary>
        /// Enum Tuserresponsetime for "tUserResponseTime"
        /// </summary>
        [EnumMember(Value = "tUserResponseTime")]
        Tuserresponsetime,

        /// <summary>
        /// Enum Tvoicemail for "tVoicemail"
        /// </summary>
        [EnumMember(Value = "tVoicemail")]
        Tvoicemail
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
    /// Left hand side for metric predicates
    /// </summary>
    /// <value>Left hand side for metric predicates</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationDetailQueryPredicate" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Dimension">Left hand side for dimension predicates.</param>
    /// <param name="Metric">Left hand side for metric predicates.</param>
    /// <param name="Operator">Optional operator, default is matches.</param>
    /// <param name="Value">Right hand side for dimension or metric predicates.</param>
    /// <param name="Range">Right hand side for dimension or metric predicates.</param>
    public ConversationDetailQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, MetricEnum? Metric = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
    {
        this.Type = Type;
        this.Dimension = Dimension;
        this.Metric = Metric;
        this.Operator = Operator;
        this.Value = Value;
        this.Range = Range;

    }











    /// <summary>
    /// Right hand side for dimension or metric predicates
    /// </summary>
    /// <value>Right hand side for dimension or metric predicates</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// Right hand side for dimension or metric predicates
    /// </summary>
    /// <value>Right hand side for dimension or metric predicates</value>
    [JsonPropertyName("range")]
    public NumericRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationDetailQueryPredicate {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
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
        return Equals(obj as ConversationDetailQueryPredicate);
    }

    /// <summary>
    /// Returns true if ConversationDetailQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationDetailQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationDetailQueryPredicate other)
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
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
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

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
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
