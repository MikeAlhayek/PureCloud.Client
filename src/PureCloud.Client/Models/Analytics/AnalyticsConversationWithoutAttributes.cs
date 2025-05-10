namespace PureCloud.Client.Models.Analytics;
public sealed class AnalyticsConversationWithoutAttributes
{
    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    public AnalyticsConversationWithoutAttributesConversationInitiator? ConversationInitiator { get; set; }

    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    public AnalyticsConversationWithoutAttributesOriginatingDirection? OriginatingDirection { get; set; }

    /// <summary>
    /// The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConferenceStart { get; set; }

    /// <summary>
    /// The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConversationEnd { get; set; }

    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConversationStart { get; set; }

    /// <summary>
    /// Indicates a messaging conversation in which the customer participated by sending at least one message
    /// </summary>
    /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
    public bool? CustomerParticipation { get; set; }

    /// <summary>
    /// Identifier(s) of division(s) associated with a conversation
    /// </summary>
    /// <value>Identifier(s) of division(s) associated with a conversation</value>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// External tag for the conversation
    /// </summary>
    /// <value>External tag for the conversation</value>
    public string ExternalTag { get; set; }

    /// <summary>
    /// The unique identifier(s) of the knowledge base(s) used
    /// </summary>
    /// <value>The unique identifier(s) of the knowledge base(s) used</value>
    public IEnumerable<string> KnowledgeBaseIds { get; set; }

    /// <summary>
    /// The lowest estimated average MOS among all the audio streams belonging to this conversation
    /// </summary>
    /// <value>The lowest estimated average MOS among all the audio streams belonging to this conversation</value>
    public double? MediaStatsMinConversationMos { get; set; }

    /// <summary>
    /// The lowest R-factor value among all of the audio streams belonging to this conversation
    /// </summary>
    /// <value>The lowest R-factor value among all of the audio streams belonging to this conversation</value>
    public double? MediaStatsMinConversationRFactor { get; set; }

    /// <summary>
    /// Indicates whether all flow sessions were self serviced
    /// </summary>
    /// <value>Indicates whether all flow sessions were self serviced</value>
    public bool? SelfServed { get; set; }

    /// <summary>
    /// Evaluations associated with this conversation
    /// </summary>
    /// <value>Evaluations associated with this conversation</value>
    public IEnumerable<AnalyticsEvaluation> Evaluations { get; set; }

    /// <summary>
    /// Surveys associated with this conversation
    /// </summary>
    /// <value>Surveys associated with this conversation</value>
    public IEnumerable<AnalyticsSurvey> Surveys { get; set; }

    /// <summary>
    /// Resolutions associated with this conversation
    /// </summary>
    /// <value>Resolutions associated with this conversation</value>
    public IEnumerable<AnalyticsResolution> Resolutions { get; set; }

    /// <summary>
    /// Participants in the conversation
    /// </summary>
    /// <value>Participants in the conversation</value>
    public IEnumerable<AnalyticsParticipantWithoutAttributes> Participants { get; set; }
}
