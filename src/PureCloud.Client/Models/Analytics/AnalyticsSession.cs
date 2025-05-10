namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsSession
{
    /// <summary>
    /// The email or SMS delivery status
    /// </summary>
    /// <value>The email or SMS delivery status</value>
    public AnalyticsSessionDeliveryStatus? DeliveryStatus { get; set; }

    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    public AnalyticsSessionMediaType? MediaType { get; set; }

    /// <summary>
    /// Routing rule type
    /// </summary>
    /// <value>Routing rule type</value>
    public AnalyticsSessionRoutingRuleType? RoutingRuleType { get; set; }

    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    public AnalyticsSessionUsedRouting? UsedRouting { get; set; }

    /// <summary>
    /// ID(s) of Skill(s) that are active on the conversation
    /// </summary>
    /// <value>ID(s) of Skill(s) that are active on the conversation</value>
    public IEnumerable<string> ActiveSkillIds { get; set; }

    /// <summary>
    /// Marker for an agent that skipped after call work
    /// </summary>
    /// <value>Marker for an agent that skipped after call work</value>
    public bool? AcwSkipped { get; set; }

    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    public string AddressFrom { get; set; }

    /// <summary>
    /// The email address for the participant on the other side of the email conversation
    /// </summary>
    /// <value>The email address for the participant on the other side of the email conversation</value>
    public string AddressOther { get; set; }

    /// <summary>
    /// The email address for the participant on this side of the email conversation
    /// </summary>
    /// <value>The email address for the participant on this side of the email conversation</value>
    public string AddressSelf { get; set; }

    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    public string AddressTo { get; set; }

    /// <summary>
    /// Unique identifier of the active virtual agent assistant
    /// </summary>
    /// <value>Unique identifier of the active virtual agent assistant</value>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// Bullseye ring of the targeted agent
    /// </summary>
    /// <value>Bullseye ring of the targeted agent</value>
    public int? AgentBullseyeRing { get; set; }

    /// <summary>
    /// Flag indicating an agent-owned callback
    /// </summary>
    /// <value>Flag indicating an agent-owned callback</value>
    public bool? AgentOwned { get; set; }

    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    public string Ani { get; set; }

    /// <summary>
    /// ID of the user that manually assigned a conversation
    /// </summary>
    /// <value>ID of the user that manually assigned a conversation</value>
    public string AssignerId { get; set; }

    /// <summary>
    /// Flag that indicates that the identity of the customer has been asserted as verified by the provider.
    /// </summary>
    /// <value>Flag that indicates that the identity of the customer has been asserted as verified by the provider.</value>
    public bool? Authenticated { get; set; }

    /// <summary>
    /// The participantId being barged in on (if someone (e.g. an agent) is being barged in on, this would correspond to one of the other participantIds present in the conversation)
    /// </summary>
    /// <value>The participantId being barged in on (if someone (e.g. an agent) is being barged in on, this would correspond to one of the other participantIds present in the conversation)</value>
    public string BargedParticipantId { get; set; }

    /// <summary>
    /// Blind carbon copy email address(es)
    /// </summary>
    /// <value>Blind carbon copy email address(es)</value>
    public IEnumerable<string> Bcc { get; set; }

    /// <summary>
    /// Callback phone number(s)
    /// </summary>
    /// <value>Callback phone number(s)</value>
    public IEnumerable<string> CallbackNumbers { get; set; }

    /// <summary>
    /// Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CallbackScheduledTime { get; set; }

    /// <summary>
    /// The name of the user requesting a call back
    /// </summary>
    /// <value>The name of the user requesting a call back</value>
    public string CallbackUserName { get; set; }

    /// <summary>
    /// Carbon copy email address(es)
    /// </summary>
    /// <value>Carbon copy email address(es)</value>
    public IEnumerable<string> Cc { get; set; }

    /// <summary>
    /// Flag that indicates that the conversation has been cleared by the customer
    /// </summary>
    /// <value>Flag that indicates that the conversation has been cleared by the customer</value>
    public bool? Cleared { get; set; }

    /// <summary>
    /// The participantId being coached (if someone (e.g. an agent) is being coached, this would correspond to one of the other participantIds present in the conversation)
    /// </summary>
    /// <value>The participantId being coached (if someone (e.g. an agent) is being coached, this would correspond to one of the other participantIds present in the conversation)</value>
    public string CoachedParticipantId { get; set; }

    /// <summary>
    /// Describes side of the cobrowse (sharer or viewer)
    /// </summary>
    /// <value>Describes side of the cobrowse (sharer or viewer)</value>
    public string CobrowseRole { get; set; }

    /// <summary>
    /// A unique identifier for a Genesys Cloud cobrowse room
    /// </summary>
    /// <value>A unique identifier for a Genesys Cloud cobrowse room</value>
    public string CobrowseRoomId { get; set; }

    /// <summary>
    /// Flag that indicates that the push delivery mechanism was used
    /// </summary>
    /// <value>Flag that indicates that the push delivery mechanism was used</value>
    public bool? DeliveryPushed { get; set; }

    /// <summary>
    /// Date and time of the most recent delivery status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time of the most recent delivery status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DeliveryStatusChangeDate { get; set; }

    /// <summary>
    /// Destination address(es) of transfers or consults
    /// </summary>
    /// <value>Destination address(es) of transfers or consults</value>
    public IEnumerable<string> DestinationAddresses { get; set; }

    /// <summary>
    /// Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DetectedSpeechEnd { get; set; }

    /// <summary>
    /// Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DetectedSpeechStart { get; set; }

    /// <summary>
    /// (Dialer) Analyzer (for example speech.person)
    /// </summary>
    /// <value>(Dialer) Analyzer (for example speech.person)</value>
    public string DispositionAnalyzer { get; set; }

    /// <summary>
    /// (Dialer) Result of the analysis (for example disposition.classification.callable.machine)
    /// </summary>
    /// <value>(Dialer) Result of the analysis (for example disposition.classification.callable.machine)</value>
    public string DispositionName { get; set; }

    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    public string Dnis { get; set; }

    /// <summary>
    /// Unique identifier of the edge device
    /// </summary>
    /// <value>Unique identifier of the edge device</value>
    public string EdgeId { get; set; }

    /// <summary>
    /// Number of eligible agents for each predictive routing attempt
    /// </summary>
    /// <value>Number of eligible agents for each predictive routing attempt</value>
    public IEnumerable<int?> EligibleAgentCounts { get; set; }

    /// <summary>
    /// Extended delivery status
    /// </summary>
    /// <value>Extended delivery status</value>
    public string ExtendedDeliveryStatus { get; set; }

    /// <summary>
    /// Type of flow in that occurred when entering ACD.
    /// </summary>
    /// <value>Type of flow in that occurred when entering ACD.</value>
    public string FlowInType { get; set; }

    /// <summary>
    /// Type of flow out that occurred when emitting tFlowOut.
    /// </summary>
    /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
    public string FlowOutType { get; set; }

    /// <summary>
    /// Identifier of the journey action.
    /// </summary>
    /// <value>Identifier of the journey action.</value>
    public string JourneyActionId { get; set; }

    /// <summary>
    /// Identifier of the journey action map that triggered the action.
    /// </summary>
    /// <value>Identifier of the journey action map that triggered the action.</value>
    public string JourneyActionMapId { get; set; }

    /// <summary>
    /// Version of the journey action map that triggered the action.
    /// </summary>
    /// <value>Version of the journey action map that triggered the action.</value>
    public int? JourneyActionMapVersion { get; set; }

    /// <summary>
    /// Primary identifier of the journey customer in the source where the activities originate from.
    /// </summary>
    /// <value>Primary identifier of the journey customer in the source where the activities originate from.</value>
    public string JourneyCustomerId { get; set; }

    /// <summary>
    /// Type of primary identifier of the journey customer (e.g. cookie).
    /// </summary>
    /// <value>Type of primary identifier of the journey customer (e.g. cookie).</value>
    public string JourneyCustomerIdType { get; set; }

    /// <summary>
    /// Unique identifier of the journey session.
    /// </summary>
    /// <value>Unique identifier of the journey session.</value>
    public string JourneyCustomerSessionId { get; set; }

    /// <summary>
    /// Type or category of journey sessions (e.g. web, ticket, delivery, atm).
    /// </summary>
    /// <value>Type or category of journey sessions (e.g. web, ticket, delivery, atm).</value>
    public string JourneyCustomerSessionIdType { get; set; }

    /// <summary>
    /// Media bridge ID for the conference session consistent across all participants
    /// </summary>
    /// <value>Media bridge ID for the conference session consistent across all participants</value>
    public string MediaBridgeId { get; set; }

    /// <summary>
    /// Count of any media (images, files, etc) included in this session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included in this session</value>
    public int? MediaCount { get; set; }

    /// <summary>
    /// Message type for messaging services. E.g.: sms, facebook, twitter, line
    /// </summary>
    /// <value>Message type for messaging services. E.g.: sms, facebook, twitter, line</value>
    public string MessageType { get; set; }

    /// <summary>
    /// The participantId being monitored (if someone (e.g. an agent) is being monitored, this would correspond to one of the other participantIds present in the conversation)
    /// </summary>
    /// <value>The participantId being monitored (if someone (e.g. an agent) is being monitored, this would correspond to one of the other participantIds present in the conversation)</value>
    public string MonitoredParticipantId { get; set; }

    /// <summary>
    /// (Dialer) Unique identifier of the outbound campaign
    /// </summary>
    /// <value>(Dialer) Unique identifier of the outbound campaign</value>
    public string OutboundCampaignId { get; set; }

    /// <summary>
    /// (Dialer) Unique identifier of the contact
    /// </summary>
    /// <value>(Dialer) Unique identifier of the contact</value>
    public string OutboundContactId { get; set; }

    /// <summary>
    /// (Dialer) Unique identifier of the contact list that this contact belongs to
    /// </summary>
    /// <value>(Dialer) Unique identifier of the contact list that this contact belongs to</value>
    public string OutboundContactListId { get; set; }

    /// <summary>
    /// This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.
    /// </summary>
    /// <value>This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// The original voice protocol call ID, e.g. a SIP call ID
    /// </summary>
    /// <value>The original voice protocol call ID, e.g. a SIP call ID</value>
    public string ProtocolCallId { get; set; }

    /// <summary>
    /// The source provider for the communication.
    /// </summary>
    /// <value>The source provider for the communication.</value>
    public string Provider { get; set; }

    /// <summary>
    /// Flag determining if an audio recording was started or not
    /// </summary>
    /// <value>Flag determining if an audio recording was started or not</value>
    public bool? Recording { get; set; }

    /// <summary>
    /// Name, phone number, or email address of the remote party.
    /// </summary>
    /// <value>Name, phone number, or email address of the remote party.</value>
    public string Remote { get; set; }

    /// <summary>
    /// Unique identifier for the remote party
    /// </summary>
    /// <value>Unique identifier for the remote party</value>
    public string RemoteNameDisplayable { get; set; }

    /// <summary>
    /// ID(s) of Skill(s) that have been removed by bullseye routing
    /// </summary>
    /// <value>ID(s) of Skill(s) that have been removed by bullseye routing</value>
    public IEnumerable<string> RemovedSkillIds { get; set; }

    /// <summary>
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    public IEnumerable<AnalyticsSessionRequestedRoutings> RequestedRoutings { get; set; }

    /// <summary>
    /// Unique identifier for the room
    /// </summary>
    /// <value>Unique identifier for the room</value>
    public string RoomId { get; set; }

    /// <summary>
    /// Routing ring for bullseye or preferred agent routing
    /// </summary>
    /// <value>Routing ring for bullseye or preferred agent routing</value>
    public int? RoutingRing { get; set; }

    /// <summary>
    /// Routing rule for preferred, conditional and predictive routing type
    /// </summary>
    /// <value>Routing rule for preferred, conditional and predictive routing type</value>
    public string RoutingRule { get; set; }

    /// <summary>
    /// Direct screen share address
    /// </summary>
    /// <value>Direct screen share address</value>
    public string ScreenShareAddressSelf { get; set; }

    /// <summary>
    /// A unique identifier for a Genesys Cloud screen share room
    /// </summary>
    /// <value>A unique identifier for a Genesys Cloud screen share room</value>
    public string ScreenShareRoomId { get; set; }

    /// <summary>
    /// A unique identifier for a script
    /// </summary>
    /// <value>A unique identifier for a script</value>
    public string ScriptId { get; set; }

    /// <summary>
    /// Selected agent ID
    /// </summary>
    /// <value>Selected agent ID</value>
    public string SelectedAgentId { get; set; }

    /// <summary>
    /// Selected agent GPR rank
    /// </summary>
    /// <value>Selected agent GPR rank</value>
    public int? SelectedAgentRank { get; set; }

    /// <summary>
    /// Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred
    /// </summary>
    /// <value>Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred</value>
    public string SessionDnis { get; set; }

    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    public string SessionId { get; set; }

    /// <summary>
    /// Flag determining if screen share is started or not (true/false)
    /// </summary>
    /// <value>Flag determining if screen share is started or not (true/false)</value>
    public bool? SharingScreen { get; set; }

    /// <summary>
    /// (Dialer) Whether the agent can skip the dialer contact
    /// </summary>
    /// <value>(Dialer) Whether the agent can skip the dialer contact</value>
    public bool? SkipEnabled { get; set; }

    /// <summary>
    /// The number of seconds before Genesys Cloud begins the call for a call back (0 disables automatic calling)
    /// </summary>
    /// <value>The number of seconds before Genesys Cloud begins the call for a call back (0 disables automatic calling)</value>
    public int? TimeoutSeconds { get; set; }

    /// <summary>
    /// Direct Video address
    /// </summary>
    /// <value>Direct Video address</value>
    public string VideoAddressSelf { get; set; }

    /// <summary>
    /// A unique identifier for a Genesys Cloud video room
    /// </summary>
    /// <value>A unique identifier for a Genesys Cloud video room</value>
    public string VideoRoomId { get; set; }

    /// <summary>
    /// Number of waiting interactions for each predictive routing attempt
    /// </summary>
    /// <value>Number of waiting interactions for each predictive routing attempt</value>
    public IEnumerable<int?> WaitingInteractionCounts { get; set; }

    /// <summary>
    /// Conditional group routing agent groups
    /// </summary>
    /// <value>Conditional group routing agent groups</value>
    public IEnumerable<AnalyticsAgentGroup> AgentGroups { get; set; }

    /// <summary>
    /// Proposed agents
    /// </summary>
    /// <value>Proposed agents</value>
    public IEnumerable<AnalyticsProposedAgent> ProposedAgents { get; set; }

    /// <summary>
    /// MediaEndpointStats associated with this session
    /// </summary>
    /// <value>MediaEndpointStats associated with this session</value>
    public IEnumerable<AnalyticsMediaEndpointStat> MediaEndpointStats { get; set; }

    /// <summary>
    /// IVR flow execution associated with this session
    /// </summary>
    /// <value>IVR flow execution associated with this session</value>
    public AnalyticsFlow Flow { get; set; }

    /// <summary>
    /// List of metrics for this session
    /// </summary>
    /// <value>List of metrics for this session</value>
    public IEnumerable<AnalyticsSessionMetric> Metrics { get; set; }

    /// <summary>
    /// List of segments for this session
    /// </summary>
    /// <value>List of segments for this session</value>
    public IEnumerable<AnalyticsConversationSegment> Segments { get; set; }
}
