using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models.Queues;

public sealed class Queue
{
    /// <summary>
    /// The Scoring Method for the queue.
    /// </summary>
    /// <value>The Scoring Method for the queue.</value>
    public ScoringMethodEnum? ScoringMethod { get; set; }

    /// <summary>
    /// The Last Agent Routing Mode for the queue.
    /// </summary>
    /// <value>The Last Agent Routing Mode for the queue.</value>
    public LastAgentRoutingModeEnum? LastAgentRoutingMode { get; set; }

    /// <summary>
    /// The skill evaluation method to use when routing conversations.
    /// </summary>
    /// <value>The skill evaluation method to use when routing conversations.</value>
    public SkillEvaluationMethodEnum? SkillEvaluationMethod { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public Division Division { get; set; }

    /// <summary>
    /// The queue description.
    /// </summary>
    /// <value>The queue description.</value>
    public string Description { get; set; }

    /// <summary>
    /// The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The ID of the user that last modified the queue.
    /// </summary>
    /// <value>The ID of the user that last modified the queue.</value>
    public string ModifiedBy { get; set; }

    /// <summary>
    /// The ID of the user that created the queue.
    /// </summary>
    /// <value>The ID of the user that created the queue.</value>
    public string CreatedBy { get; set; }

    /// <summary>
    /// The total number of members in the queue.
    /// </summary>
    /// <value>The total number of members in the queue.</value>
    public int? MemberCount { get; set; }

    /// <summary>
    /// The number of user members (i.e., non-group members) in the queue.
    /// </summary>
    /// <value>The number of user members (i.e., non-group members) in the queue.</value>
    public int? UserMemberCount { get; set; }

    /// <summary>
    /// The number of joined members in the queue.
    /// </summary>
    /// <value>The number of joined members in the queue.</value>
    public int? JoinedMemberCount { get; set; }

    /// <summary>
    /// The media settings for the queue.
    /// </summary>
    /// <value>The media settings for the queue.</value>
    public QueueMediaSettings MediaSettings { get; set; }

    /// <summary>
    /// The routing rules for the queue, used for Preferred Agent Routing.
    /// </summary>
    /// <value>The routing rules for the queue, used for Preferred Agent Routing.</value>
    public IEnumerable<RoutingRule> RoutingRules { get; set; }

    /// <summary>
    /// The Conditional Group Routing settings for the queue.
    /// </summary>
    /// <value>The Conditional Group Routing settings for the queue.</value>
    public ConditionalGroupRouting ConditionalGroupRouting { get; set; }

    /// <summary>
    /// The bullseye settings for the queue.
    /// </summary>
    /// <value>The bullseye settings for the queue.</value>
    public Bullseye Bullseye { get; set; }

    /// <summary>
    /// The ACW settings for the queue.
    /// </summary>
    /// <value>The ACW settings for the queue.</value>
    public AcwSettings AcwSettings { get; set; }

    /// <summary>
    /// The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes.
    /// </summary>
    /// <value>The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes.</value>
    public IEnumerable<MemberGroup> MemberGroups { get; set; }

    /// <summary>
    /// The in-queue flow to use for call conversations waiting in queue.
    /// </summary>
    /// <value>The in-queue flow to use for call conversations waiting in queue.</value>
    public DomainEntityRef QueueFlow { get; set; }

    /// <summary>
    /// The in-queue flow to use for email conversations waiting in queue.
    /// </summary>
    /// <value>The in-queue flow to use for email conversations waiting in queue.</value>
    public DomainEntityRef EmailInQueueFlow { get; set; }

    /// <summary>
    /// The in-queue flow to use for message conversations waiting in queue.
    /// </summary>
    /// <value>The in-queue flow to use for message conversations waiting in queue.</value>
    public DomainEntityRef MessageInQueueFlow { get; set; }

    /// <summary>
    /// The prompt used for whisper on the queue, if configured.
    /// </summary>
    /// <value>The prompt used for whisper on the queue, if configured.</value>
    public DomainEntityRef WhisperPrompt { get; set; }

    /// <summary>
    /// The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play.
    /// </summary>
    /// <value>The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play.</value>
    public DomainEntityRef OnHoldPrompt { get; set; }

    /// <summary>
    /// Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.
    /// </summary>
    /// <value>Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.</value>
    public bool? AutoAnswerOnly { get; set; }

    /// <summary>
    /// Canned response library IDs and mode with which they are associated with the queue
    /// </summary>
    /// <value>Canned response library IDs and mode with which they are associated with the queue</value>
    public CannedResponseLibraries CannedResponseLibraries { get; set; }

    /// <summary>
    /// Indicates whether voice transcription is enabled for this queue.
    /// </summary>
    /// <value>Indicates whether voice transcription is enabled for this queue.</value>
    public bool? EnableTranscription { get; set; }

    /// <summary>
    /// Indicates whether audio monitoring is enabled for this queue.
    /// </summary>
    /// <value>Indicates whether audio monitoring is enabled for this queue.</value>
    public bool? EnableAudioMonitoring { get; set; }

    /// <summary>
    /// Indicates whether manual assignment is enabled for this queue.
    /// </summary>
    /// <value>Indicates whether manual assignment is enabled for this queue.</value>
    public bool? EnableManualAssignment { get; set; }

    /// <summary>
    /// The Agent Owned Routing settings for the queue
    /// </summary>
    /// <value>The Agent Owned Routing settings for the queue</value>
    public AgentOwnedRouting AgentOwnedRouting { get; set; }

    /// <summary>
    /// The Direct Routing settings for the queue
    /// </summary>
    /// <value>The Direct Routing settings for the queue</value>
    public DirectRouting DirectRouting { get; set; }

    /// <summary>
    /// The name to use for caller identification for outbound calls from this queue.
    /// </summary>
    /// <value>The name to use for caller identification for outbound calls from this queue.</value>
    public string CallingPartyName { get; set; }

    /// <summary>
    /// The phone number to use for caller identification for outbound calls from this queue.
    /// </summary>
    /// <value>The phone number to use for caller identification for outbound calls from this queue.</value>
    public string CallingPartyNumber { get; set; }

    /// <summary>
    /// The default script Ids for the communication types.
    /// </summary>
    /// <value>The default script Ids for the communication types.</value>
    public Dictionary<string, Script> DefaultScripts { get; set; }

    /// <summary>
    /// The messaging addresses for the queue.
    /// </summary>
    /// <value>The messaging addresses for the queue.</value>
    public QueueMessagingAddresses OutboundMessagingAddresses { get; set; }

    /// <summary>
    /// The default email address to use for outbound email from this queue.
    /// </summary>
    /// <value>The default email address to use for outbound email from this queue.</value>
    public QueueEmailAddress OutboundEmailAddress { get; set; }

    /// <summary>
    /// The ID of an associated external queue.
    /// </summary>
    /// <value>The ID of an associated external queue.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// Indicates whether recording in-queue calls is suppressed for this queue.
    /// </summary>
    /// <value>Indicates whether recording in-queue calls is suppressed for this queue.</value>
    public bool? SuppressInQueueCallRecording { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
