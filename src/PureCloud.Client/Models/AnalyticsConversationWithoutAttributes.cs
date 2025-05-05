using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsConversationWithoutAttributes
/// </summary>

public partial class AnalyticsConversationWithoutAttributes : IEquatable<AnalyticsConversationWithoutAttributes>
{
    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    
    public enum ConversationInitiatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Acd for "acd"
        /// </summary>
        [EnumMember(Value = "acd")]
        Acd,

        /// <summary>
        /// Enum Agent for "agent"
        /// </summary>
        [EnumMember(Value = "agent")]
        Agent,

        /// <summary>
        /// Enum Api for "api"
        /// </summary>
        [EnumMember(Value = "api")]
        Api,

        /// <summary>
        /// Enum Botflow for "botflow"
        /// </summary>
        [EnumMember(Value = "botflow")]
        Botflow,

        /// <summary>
        /// Enum Campaign for "campaign"
        /// </summary>
        [EnumMember(Value = "campaign")]
        Campaign,

        /// <summary>
        /// Enum Customer for "customer"
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// Enum Dialer for "dialer"
        /// </summary>
        [EnumMember(Value = "dialer")]
        Dialer,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External,

        /// <summary>
        /// Enum Fax for "fax"
        /// </summary>
        [EnumMember(Value = "fax")]
        Fax,

        /// <summary>
        /// Enum Group for "group"
        /// </summary>
        [EnumMember(Value = "group")]
        Group,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Ivr for "ivr"
        /// </summary>
        [EnumMember(Value = "ivr")]
        Ivr,

        /// <summary>
        /// Enum Manual for "manual"
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound,

        /// <summary>
        /// Enum Station for "station"
        /// </summary>
        [EnumMember(Value = "station")]
        Station,

        /// <summary>
        /// Enum User for "user"
        /// </summary>
        [EnumMember(Value = "user")]
        User,

        /// <summary>
        /// Enum Voicemail for "voicemail"
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurveyflow for "voicesurveyflow"
        /// </summary>
        [EnumMember(Value = "voicesurveyflow")]
        Voicesurveyflow,

        /// <summary>
        /// Enum Workflow for "workflow"
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow
    }
    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    
    public enum OriginatingDirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    [JsonPropertyName("conversationInitiator")]
    public ConversationInitiatorEnum? ConversationInitiator { get; set; }
    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    [JsonPropertyName("originatingDirection")]
    public OriginatingDirectionEnum? OriginatingDirection { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsConversationWithoutAttributes" /> class.
    /// </summary>
    /// <param name="ConferenceStart">The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConversationEnd">The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConversationId">Unique identifier for the conversation.</param>
    /// <param name="ConversationInitiator">Indicates the participant purpose of the participant initiating a message conversation.</param>
    /// <param name="ConversationStart">The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CustomerParticipation">Indicates a messaging conversation in which the customer participated by sending at least one message.</param>
    /// <param name="DivisionIds">Identifier(s) of division(s) associated with a conversation.</param>
    /// <param name="ExternalTag">External tag for the conversation.</param>
    /// <param name="KnowledgeBaseIds">The unique identifier(s) of the knowledge base(s) used.</param>
    /// <param name="MediaStatsMinConversationMos">The lowest estimated average MOS among all the audio streams belonging to this conversation.</param>
    /// <param name="MediaStatsMinConversationRFactor">The lowest R-factor value among all of the audio streams belonging to this conversation.</param>
    /// <param name="OriginatingDirection">The original direction of the conversation.</param>
    /// <param name="SelfServed">Indicates whether all flow sessions were self serviced.</param>
    /// <param name="Evaluations">Evaluations associated with this conversation.</param>
    /// <param name="Surveys">Surveys associated with this conversation.</param>
    /// <param name="Resolutions">Resolutions associated with this conversation.</param>
    /// <param name="Participants">Participants in the conversation.</param>
    public AnalyticsConversationWithoutAttributes(DateTime? ConferenceStart = null, DateTime? ConversationEnd = null, string ConversationId = null, ConversationInitiatorEnum? ConversationInitiator = null, DateTime? ConversationStart = null, bool? CustomerParticipation = null, List<string> DivisionIds = null, string ExternalTag = null, List<string> KnowledgeBaseIds = null, double? MediaStatsMinConversationMos = null, double? MediaStatsMinConversationRFactor = null, OriginatingDirectionEnum? OriginatingDirection = null, bool? SelfServed = null, List<AnalyticsEvaluation> Evaluations = null, List<AnalyticsSurvey> Surveys = null, List<AnalyticsResolution> Resolutions = null, List<AnalyticsParticipantWithoutAttributes> Participants = null)
    {
        this.ConferenceStart = ConferenceStart;
        this.ConversationEnd = ConversationEnd;
        this.ConversationId = ConversationId;
        this.ConversationInitiator = ConversationInitiator;
        this.ConversationStart = ConversationStart;
        this.CustomerParticipation = CustomerParticipation;
        this.DivisionIds = DivisionIds;
        this.ExternalTag = ExternalTag;
        this.KnowledgeBaseIds = KnowledgeBaseIds;
        this.MediaStatsMinConversationMos = MediaStatsMinConversationMos;
        this.MediaStatsMinConversationRFactor = MediaStatsMinConversationRFactor;
        this.OriginatingDirection = OriginatingDirection;
        this.SelfServed = SelfServed;
        this.Evaluations = Evaluations;
        this.Surveys = Surveys;
        this.Resolutions = Resolutions;
        this.Participants = Participants;

    }



    /// <summary>
    /// The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conferenceStart")]
    public DateTime? ConferenceStart { get; set; }



    /// <summary>
    /// The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conversationEnd")]
    public DateTime? ConversationEnd { get; set; }



    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }





    /// <summary>
    /// The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conversationStart")]
    public DateTime? ConversationStart { get; set; }



    /// <summary>
    /// Indicates a messaging conversation in which the customer participated by sending at least one message
    /// </summary>
    /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
    [JsonPropertyName("customerParticipation")]
    public bool? CustomerParticipation { get; set; }



    /// <summary>
    /// Identifier(s) of division(s) associated with a conversation
    /// </summary>
    /// <value>Identifier(s) of division(s) associated with a conversation</value>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// External tag for the conversation
    /// </summary>
    /// <value>External tag for the conversation</value>
    [JsonPropertyName("externalTag")]
    public string ExternalTag { get; set; }



    /// <summary>
    /// The unique identifier(s) of the knowledge base(s) used
    /// </summary>
    /// <value>The unique identifier(s) of the knowledge base(s) used</value>
    [JsonPropertyName("knowledgeBaseIds")]
    public List<string> KnowledgeBaseIds { get; set; }



    /// <summary>
    /// The lowest estimated average MOS among all the audio streams belonging to this conversation
    /// </summary>
    /// <value>The lowest estimated average MOS among all the audio streams belonging to this conversation</value>
    [JsonPropertyName("mediaStatsMinConversationMos")]
    public double? MediaStatsMinConversationMos { get; set; }



    /// <summary>
    /// The lowest R-factor value among all of the audio streams belonging to this conversation
    /// </summary>
    /// <value>The lowest R-factor value among all of the audio streams belonging to this conversation</value>
    [JsonPropertyName("mediaStatsMinConversationRFactor")]
    public double? MediaStatsMinConversationRFactor { get; set; }





    /// <summary>
    /// Indicates whether all flow sessions were self serviced
    /// </summary>
    /// <value>Indicates whether all flow sessions were self serviced</value>
    [JsonPropertyName("selfServed")]
    public bool? SelfServed { get; set; }



    /// <summary>
    /// Evaluations associated with this conversation
    /// </summary>
    /// <value>Evaluations associated with this conversation</value>
    [JsonPropertyName("evaluations")]
    public List<AnalyticsEvaluation> Evaluations { get; set; }



    /// <summary>
    /// Surveys associated with this conversation
    /// </summary>
    /// <value>Surveys associated with this conversation</value>
    [JsonPropertyName("surveys")]
    public List<AnalyticsSurvey> Surveys { get; set; }



    /// <summary>
    /// Resolutions associated with this conversation
    /// </summary>
    /// <value>Resolutions associated with this conversation</value>
    [JsonPropertyName("resolutions")]
    public List<AnalyticsResolution> Resolutions { get; set; }



    /// <summary>
    /// Participants in the conversation
    /// </summary>
    /// <value>Participants in the conversation</value>
    [JsonPropertyName("participants")]
    public List<AnalyticsParticipantWithoutAttributes> Participants { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsConversationWithoutAttributes {\n");

        sb.Append("  ConferenceStart: ").Append(ConferenceStart).Append("\n");
        sb.Append("  ConversationEnd: ").Append(ConversationEnd).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConversationInitiator: ").Append(ConversationInitiator).Append("\n");
        sb.Append("  ConversationStart: ").Append(ConversationStart).Append("\n");
        sb.Append("  CustomerParticipation: ").Append(CustomerParticipation).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
        sb.Append("  MediaStatsMinConversationMos: ").Append(MediaStatsMinConversationMos).Append("\n");
        sb.Append("  MediaStatsMinConversationRFactor: ").Append(MediaStatsMinConversationRFactor).Append("\n");
        sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
        sb.Append("  SelfServed: ").Append(SelfServed).Append("\n");
        sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
        sb.Append("  Surveys: ").Append(Surveys).Append("\n");
        sb.Append("  Resolutions: ").Append(Resolutions).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
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
        return Equals(obj as AnalyticsConversationWithoutAttributes);
    }

    /// <summary>
    /// Returns true if AnalyticsConversationWithoutAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsConversationWithoutAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsConversationWithoutAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConferenceStart == other.ConferenceStart ||
                ConferenceStart != null &&
                ConferenceStart.Equals(other.ConferenceStart)
            ) &&
            (
                ConversationEnd == other.ConversationEnd ||
                ConversationEnd != null &&
                ConversationEnd.Equals(other.ConversationEnd)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConversationInitiator == other.ConversationInitiator ||
                ConversationInitiator != null &&
                ConversationInitiator.Equals(other.ConversationInitiator)
            ) &&
            (
                ConversationStart == other.ConversationStart ||
                ConversationStart != null &&
                ConversationStart.Equals(other.ConversationStart)
            ) &&
            (
                CustomerParticipation == other.CustomerParticipation ||
                CustomerParticipation != null &&
                CustomerParticipation.Equals(other.CustomerParticipation)
            ) &&
            (
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                KnowledgeBaseIds == other.KnowledgeBaseIds ||
                KnowledgeBaseIds != null &&
                KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
            ) &&
            (
                MediaStatsMinConversationMos == other.MediaStatsMinConversationMos ||
                MediaStatsMinConversationMos != null &&
                MediaStatsMinConversationMos.Equals(other.MediaStatsMinConversationMos)
            ) &&
            (
                MediaStatsMinConversationRFactor == other.MediaStatsMinConversationRFactor ||
                MediaStatsMinConversationRFactor != null &&
                MediaStatsMinConversationRFactor.Equals(other.MediaStatsMinConversationRFactor)
            ) &&
            (
                OriginatingDirection == other.OriginatingDirection ||
                OriginatingDirection != null &&
                OriginatingDirection.Equals(other.OriginatingDirection)
            ) &&
            (
                SelfServed == other.SelfServed ||
                SelfServed != null &&
                SelfServed.Equals(other.SelfServed)
            ) &&
            (
                Evaluations == other.Evaluations ||
                Evaluations != null &&
                Evaluations.SequenceEqual(other.Evaluations)
            ) &&
            (
                Surveys == other.Surveys ||
                Surveys != null &&
                Surveys.SequenceEqual(other.Surveys)
            ) &&
            (
                Resolutions == other.Resolutions ||
                Resolutions != null &&
                Resolutions.SequenceEqual(other.Resolutions)
            ) &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
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
            if (ConferenceStart != null)
            {
                hash = hash * 59 + ConferenceStart.GetHashCode();
            }

            if (ConversationEnd != null)
            {
                hash = hash * 59 + ConversationEnd.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConversationInitiator != null)
            {
                hash = hash * 59 + ConversationInitiator.GetHashCode();
            }

            if (ConversationStart != null)
            {
                hash = hash * 59 + ConversationStart.GetHashCode();
            }

            if (CustomerParticipation != null)
            {
                hash = hash * 59 + CustomerParticipation.GetHashCode();
            }

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (KnowledgeBaseIds != null)
            {
                hash = hash * 59 + KnowledgeBaseIds.GetHashCode();
            }

            if (MediaStatsMinConversationMos != null)
            {
                hash = hash * 59 + MediaStatsMinConversationMos.GetHashCode();
            }

            if (MediaStatsMinConversationRFactor != null)
            {
                hash = hash * 59 + MediaStatsMinConversationRFactor.GetHashCode();
            }

            if (OriginatingDirection != null)
            {
                hash = hash * 59 + OriginatingDirection.GetHashCode();
            }

            if (SelfServed != null)
            {
                hash = hash * 59 + SelfServed.GetHashCode();
            }

            if (Evaluations != null)
            {
                hash = hash * 59 + Evaluations.GetHashCode();
            }

            if (Surveys != null)
            {
                hash = hash * 59 + Surveys.GetHashCode();
            }

            if (Resolutions != null)
            {
                hash = hash * 59 + Resolutions.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            return hash;
        }
    }
}
