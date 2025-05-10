namespace PureCloud.Client.Models;

public sealed class Participant
{
    /// <summary>
    /// This field controls how the UI prompts the agent for a wrapup.
    /// </summary>
    /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
    public WrapupPromptEnum? WrapupPrompt { get; set; }

    /// <summary>
    /// The current screen recording state for this participant.
    /// </summary>
    /// <value>The current screen recording state for this participant.</value>
    public ScreenRecordingStateEnum? ScreenRecordingState { get; set; }

    /// <summary>
    /// The reason specifying why participant flagged the conversation.
    /// </summary>
    /// <value>The reason specifying why participant flagged the conversation.</value>
    public ParticipantFlaggedReason? FlaggedReason { get; set; }

    /// <summary>
    /// A globally unique identifier for this conversation.
    /// </summary>
    /// <value>A globally unique identifier for this conversation.</value>
    public string Id { get; set; }

    /// <summary>
    /// The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConnectedTime { get; set; }

    /// <summary>
    /// A human readable name identifying the participant.
    /// </summary>
    /// <value>A human readable name identifying the participant.</value>
    public string Name { get; set; }

    /// <summary>
    /// If this participant represents a user, then this will be an URI that can be used to fetch the user.
    /// </summary>
    /// <value>If this participant represents a user, then this will be an URI that can be used to fetch the user.</value>
    public string UserUri { get; set; }

    /// <summary>
    /// If this participant represents a user, then this will be the globally unique identifier for the user.
    /// </summary>
    /// <value>If this participant represents a user, then this will be the globally unique identifier for the user.</value>
    public string UserId { get; set; }

    /// <summary>
    /// If this participant represents an external contact, then this will be the globally unique identifier for the external contact.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the globally unique identifier for the external contact.</value>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.</value>
    public string ExternalContactInitialDivisionId { get; set; }

    /// <summary>
    /// If this participant represents an external org, then this will be the globally unique identifier for the external org.
    /// </summary>
    /// <value>If this participant represents an external org, then this will be the globally unique identifier for the external org.</value>
    public string ExternalOrganizationId { get; set; }

    /// <summary>
    /// If present, the queue id that the communication channel came in on.
    /// </summary>
    /// <value>If present, the queue id that the communication channel came in on.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// If present, group of users the participant represents.
    /// </summary>
    /// <value>If present, group of users the participant represents.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// The team id that this participant is a member of when added to the conversation.
    /// </summary>
    /// <value>The team id that this participant is a member of when added to the conversation.</value>
    public string TeamId { get; set; }

    /// <summary>
    /// If present, the queue name that the communication channel came in on.
    /// </summary>
    /// <value>If present, the queue name that the communication channel came in on.</value>
    public string QueueName { get; set; }

    /// <summary>
    /// A well known string that specifies the purpose of this participant.
    /// </summary>
    /// <value>A well known string that specifies the purpose of this participant.</value>
    public string Purpose { get; set; }

    /// <summary>
    /// A well known string that specifies the type of this participant.
    /// </summary>
    /// <value>A well known string that specifies the type of this participant.</value>
    public string ParticipantType { get; set; }

    /// <summary>
    /// If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.
    /// </summary>
    /// <value>If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.</value>
    public string ConsultParticipantId { get; set; }

    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    public string Address { get; set; }

    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    public string Ani { get; set; }

    /// <summary>
    /// The ani-based name for this participant.
    /// </summary>
    /// <value>The ani-based name for this participant.</value>
    public string AniName { get; set; }

    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    public string Dnis { get; set; }

    /// <summary>
    /// An ISO 639 language code specifying the locale for this participant
    /// </summary>
    /// <value>An ISO 639 language code specifying the locale for this participant</value>
    public string Locale { get; set; }

    /// <summary>
    /// True iff this participant is required to enter wrapup for this conversation.
    /// </summary>
    /// <value>True iff this participant is required to enter wrapup for this conversation.</value>
    public bool? WrapupRequired { get; set; }

    /// <summary>
    /// Specifies how long a timed ACW session will last.
    /// </summary>
    /// <value>Specifies how long a timed ACW session will last.</value>
    public int? WrapupTimeoutMs { get; set; }

    /// <summary>
    /// The UI sets this field when the agent chooses to skip entering a wrapup for this participant.
    /// </summary>
    /// <value>The UI sets this field when the agent chooses to skip entering a wrapup for this participant.</value>
    public bool? WrapupSkipped { get; set; }

    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    public Wrapup Wrapup { get; set; }

    /// <summary>
    /// List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.
    /// </summary>
    /// <value>List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.</value>
    public IEnumerable<string> MediaRoles { get; set; }

    /// <summary>
    /// Information on how a communication should be routed to an agent.
    /// </summary>
    /// <value>Information on how a communication should be routed to an agent.</value>
    public ConversationRoutingData ConversationRoutingData { get; set; }

    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    public int? AlertingTimeoutMs { get; set; }

    /// <summary>
    /// If this participant is a monitor, then this will be the id of the participant that is being monitored.
    /// </summary>
    /// <value>If this participant is a monitor, then this will be the id of the participant that is being monitored.</value>
    public string MonitoredParticipantId { get; set; }

    /// <summary>
    /// If this participant is a coach, then this will be the id of the participant that is being coached.
    /// </summary>
    /// <value>If this participant is a coach, then this will be the id of the participant that is being coached.</value>
    public string CoachedParticipantId { get; set; }

    /// <summary>
    /// Additional participant attributes
    /// </summary>
    /// <value>Additional participant attributes</value>
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    public IEnumerable<Call> Calls { get; set; }

    /// <summary>
    /// Gets or Sets Callbacks
    /// </summary>
    public IEnumerable<Callback> Callbacks { get; set; }

    /// <summary>
    /// Gets or Sets Chats
    /// </summary>
    public IEnumerable<ConversationChat> Chats { get; set; }

    /// <summary>
    /// Gets or Sets CobrowseSessions
    /// </summary>
    public IEnumerable<CobrowseSession> CobrowseSessions { get; set; }

    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    public IEnumerable<Email> Emails { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    public IEnumerable<Message> Messages { get; set; }

    /// <summary>
    /// Gets or Sets Screenshares
    /// </summary>
    public IEnumerable<Screenshare> Screenshares { get; set; }

    /// <summary>
    /// Gets or Sets SocialExpressions
    /// </summary>
    public IEnumerable<SocialExpression> SocialExpressions { get; set; }

    /// <summary>
    /// Gets or Sets Videos
    /// </summary>
    public IEnumerable<Video> Videos { get; set; }

    /// <summary>
    /// Gets or Sets Evaluations
    /// </summary>
    public IEnumerable<Evaluation> Evaluations { get; set; }

    /// <summary>
    /// The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartAcwTime { get; set; }

    /// <summary>
    /// The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndAcwTime { get; set; }

    /// <summary>
    /// Gets or Sets InternalMessages
    /// </summary>
    public IEnumerable<InternalMessage> InternalMessages { get; set; }

    /// <summary>
    /// If this participant barged in a participant&#39;s call, then this will be the id of the targeted participant.
    /// </summary>
    /// <value>If this participant barged in a participant&#39;s call, then this will be the id of the targeted participant.</value>
    public string BargedParticipantId { get; set; }
}
