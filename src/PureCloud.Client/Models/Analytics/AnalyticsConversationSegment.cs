namespace PureCloud.Client.Models.Analytics;
public sealed class AnalyticsConversationSegment
{
    /// <summary>
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    public AnalyticsConversationSegmentDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// The activity that takes place in the segment, such as hold or interact
    /// </summary>
    /// <value>The activity that takes place in the segment, such as hold or interact</value>
    public AnalyticsConversationSegmentType? SegmentType { get; set; }

    /// <summary>
    /// Flag indicating if audio is muted or not (true/false)
    /// </summary>
    /// <value>Flag indicating if audio is muted or not (true/false)</value>
    public bool? AudioMuted { get; set; }

    /// <summary>
    /// Indicates whether the segment was a conference
    /// </summary>
    /// <value>Indicates whether the segment was a conference</value>
    public bool? Conference { get; set; }

    /// <summary>
    /// The unique identifier of a new conversation when a conversation is ended for a conference
    /// </summary>
    /// <value>The unique identifier of a new conversation when a conversation is ended for a conference</value>
    public string DestinationConversationId { get; set; }

    /// <summary>
    /// The unique identifier of a new session when a session is ended for a conference
    /// </summary>
    /// <value>The unique identifier of a new session when a session is ended for a conference</value>
    public string DestinationSessionId { get; set; }

    /// <summary>
    /// A code corresponding to the error that occurred
    /// </summary>
    /// <value>A code corresponding to the error that occurred</value>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Unique identifier for a Genesys Cloud group
    /// </summary>
    /// <value>Unique identifier for a Genesys Cloud group</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Q.850 response code(s)
    /// </summary>
    /// <value>Q.850 response code(s)</value>
    public IEnumerable<long?> Q850ResponseCodes { get; set; }

    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    public string RequestedLanguageId { get; set; }

    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    public IEnumerable<string> RequestedRoutingSkillIds { get; set; }

    /// <summary>
    /// Unique identifier(s) for agent(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for agent(s) requested for an interaction</value>
    public IEnumerable<string> RequestedRoutingUserIds { get; set; }

    /// <summary>
    /// The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? SegmentEnd { get; set; }

    /// <summary>
    /// The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? SegmentStart { get; set; }

    /// <summary>
    /// SIP response code(s)
    /// </summary>
    /// <value>SIP response code(s)</value>
    public IEnumerable<long?> SipResponseCodes { get; set; }

    /// <summary>
    /// The unique identifier of the previous conversation when a new conversation is created for a conference
    /// </summary>
    /// <value>The unique identifier of the previous conversation when a new conversation is created for a conference</value>
    public string SourceConversationId { get; set; }

    /// <summary>
    /// The unique identifier of the previous session when a new session is created for a conference
    /// </summary>
    /// <value>The unique identifier of the previous session when a new session is created for a conference</value>
    public string SourceSessionId { get; set; }

    /// <summary>
    /// The subject for the initial email that started this conversation
    /// </summary>
    /// <value>The subject for the initial email that started this conversation</value>
    public string Subject { get; set; }

    /// <summary>
    /// Flag indicating if video is muted/paused or not (true/false)
    /// </summary>
    /// <value>Flag indicating if video is muted/paused or not (true/false)</value>
    public bool? VideoMuted { get; set; }

    /// <summary>
    /// Wrap up code
    /// </summary>
    /// <value>Wrap up code</value>
    public string WrapUpCode { get; set; }

    /// <summary>
    /// Note entered by an agent during after-call work
    /// </summary>
    /// <value>Note entered by an agent during after-call work</value>
    public string WrapUpNote { get; set; }

    /// <summary>
    /// Tag(s) assigned during after-call work
    /// </summary>
    /// <value>Tag(s) assigned during after-call work</value>
    public IEnumerable<string> WrapUpTags { get; set; }

    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    public IEnumerable<AnalyticsScoredAgent> ScoredAgents { get; set; }

    /// <summary>
    /// Additional segment properties
    /// </summary>
    /// <value>Additional segment properties</value>
    public IEnumerable<AnalyticsProperty> Properties { get; set; }
}
