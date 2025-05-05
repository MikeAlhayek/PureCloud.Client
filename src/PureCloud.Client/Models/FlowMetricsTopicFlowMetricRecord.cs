namespace PureCloud.Client.Models;

public sealed class FlowMetricsTopicFlowMetricRecord
{
    /// <summary>
    /// Metric name
    /// </summary>
    /// <value>Metric name</value>
    public FlowMetricsTopicFlowMetricRecordMetric? Metric { get; set; }

    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    public FlowMetricsTopicFlowMetricRecordActiveRouting? ActiveRouting { get; set; }

    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    public FlowMetricsTopicFlowMetricRecordConversationInitiator? ConversationInitiator { get; set; }

    /// <summary>
    /// The email or SMS delivery status
    /// </summary>
    /// <value>The email or SMS delivery status</value>
    public FlowMetricsTopicFlowMetricRecordDeliveryStatus? DeliveryStatus { get; set; }

    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    public FlowMetricsTopicFlowMetricRecordDirection? Direction { get; set; }

    /// <summary>
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    public FlowMetricsTopicFlowMetricRecordDisconnectType? DisconnectType { get; set; }

    /// <summary>
    /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
    /// </summary>
    /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
    public FlowMetricsTopicFlowMetricRecordEntryType? EntryType { get; set; }

    /// <summary>
    /// Reason for which participant flagged conversation
    /// </summary>
    /// <value>Reason for which participant flagged conversation</value>
    public FlowMetricsTopicFlowMetricRecordFlaggedReason? FlaggedReason { get; set; }

    /// <summary>
    /// Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.
    /// </summary>
    /// <value>Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.</value>
    public FlowMetricsTopicFlowMetricRecordFlowSubType? FlowSubType { get; set; }

    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    public FlowMetricsTopicFlowMetricRecordFlowType? FlowType { get; set; }

    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    public FlowMetricsTopicFlowMetricRecordMediaType? MediaType { get; set; }

    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    public FlowMetricsTopicFlowMetricRecordOriginatingDirection? OriginatingDirection { get; set; }

    /// <summary>
    /// The participant's purpose
    /// </summary>
    /// <value>The participant's purpose</value>
    public FlowMetricsTopicFlowMetricRecordPurpose? Purpose { get; set; }

    /// <summary>
    /// Routing rule type
    /// </summary>
    /// <value>Routing rule type</value>
    public FlowMetricsTopicFlowMetricRecordRoutingRuleType? RoutingRuleType { get; set; }

    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    public FlowMetricsTopicFlowMetricRecordUsedRouting? UsedRouting { get; set; }

    /// <summary>
    /// The date and time of metric creation
    /// </summary>
    /// <value>The date and time of metric creation</value>
    public DateTime? MetricDate { get; set; }

    /// <summary>
    /// Metric value
    /// </summary>
    /// <value>Metric value</value>
    public long? Value { get; set; }

    /// <summary>
    /// Record identifier
    /// </summary>
    /// <value>Record identifier</value>
    public string RecordId { get; set; }

    /// <summary>
    /// ID(s) of Skill(s) that are active on the conversation
    /// </summary>
    /// <value>ID(s) of Skill(s) that are active on the conversation</value>
    public IEnumerable<string> ActiveSkillIds { get; set; }

    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    public string AddressFrom { get; set; }

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
    public long? AgentBullseyeRing { get; set; }

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
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    public string ConvertedFrom { get; set; }

    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    public string ConvertedTo { get; set; }

    /// <summary>
    /// Indicates a messaging conversation in which the customer participated by sending at least one message
    /// </summary>
    /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
    public bool? CustomerParticipation { get; set; }

    /// <summary>
    /// Destination address(es) of transfers or consults
    /// </summary>
    /// <value>Destination address(es) of transfers or consults</value>
    public IEnumerable<string> DestinationAddresses { get; set; }

    /// <summary>
    /// Identifier(s) of division(s) associated with a conversation
    /// </summary>
    /// <value>Identifier(s) of division(s) associated with a conversation</value>
    public IEnumerable<string> DivisionIds { get; set; }

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
    public IEnumerable<long?> EligibleAgentCounts { get; set; }

    /// <summary>
    /// Flow ending language, e.g. en-us
    /// </summary>
    /// <value>Flow ending language, e.g. en-us</value>
    public string EndingLanguage { get; set; }

    /// <summary>
    /// The particular entry reason for this flow, e.g. an address, userId, or flowId
    /// </summary>
    /// <value>The particular entry reason for this flow, e.g. an address, userId, or flowId</value>
    public string EntryReason { get; set; }

    /// <summary>
    /// A code corresponding to the error that occurred
    /// </summary>
    /// <value>A code corresponding to the error that occurred</value>
    public string ErrorCode { get; set; }

    /// <summary>
    /// The exit reason for this flow, e.g. DISCONNECT
    /// </summary>
    /// <value>The exit reason for this flow, e.g. DISCONNECT</value>
    public string ExitReason { get; set; }

    /// <summary>
    /// Extended delivery status
    /// </summary>
    /// <value>Extended delivery status</value>
    public string ExtendedDeliveryStatus { get; set; }

    /// <summary>
    /// External contact identifier
    /// </summary>
    /// <value>External contact identifier</value>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// Count of any media (images, files, etc) included on the external session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included on the external session</value>
    public long? ExternalMediaCount { get; set; }

    /// <summary>
    /// External organization identifier
    /// </summary>
    /// <value>External organization identifier</value>
    public string ExternalOrganizationId { get; set; }

    /// <summary>
    /// External tag for the conversation
    /// </summary>
    /// <value>External tag for the conversation</value>
    public string ExternalTag { get; set; }

    /// <summary>
    /// Marker that is set if the current queue is the first queue in a conversation
    /// </summary>
    /// <value>Marker that is set if the current queue is the first queue in a conversation</value>
    public bool? FirstQueue { get; set; }

    /// <summary>
    /// The unique identifier of this flow
    /// </summary>
    /// <value>The unique identifier of this flow</value>
    public string FlowId { get; set; }

    /// <summary>
    /// Type of flow in that occurred when entering ACD.
    /// </summary>
    /// <value>Type of flow in that occurred when entering ACD.</value>
    public string FlowInType { get; set; }

    /// <summary>
    /// The ID of a flow outcome milestone
    /// </summary>
    /// <value>The ID of a flow outcome milestone</value>
    public IEnumerable<string> FlowMilestoneIds { get; set; }

    /// <summary>
    /// The name of this flow at the time of flow execution
    /// </summary>
    /// <value>The name of this flow at the time of flow execution</value>
    public string FlowName { get; set; }

    /// <summary>
    /// Type of flow out that occurred when emitting tFlowOut.
    /// </summary>
    /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
    public string FlowOutType { get; set; }

    /// <summary>
    /// The version of this flow
    /// </summary>
    /// <value>The version of this flow</value>
    public string FlowVersion { get; set; }

    /// <summary>
    /// Unique identifier for a Genesys Cloud group
    /// </summary>
    /// <value>Unique identifier for a Genesys Cloud group</value>
    public string GroupId { get; set; }

    /// <summary>
    /// The interaction type (enterprise or contactCenter)
    /// </summary>
    /// <value>The interaction type (enterprise or contactCenter)</value>
    public string InteractionType { get; set; }

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
    public long? JourneyActionMapVersion { get; set; }

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
    /// The unique identifier of the knowledge base used
    /// </summary>
    /// <value>The unique identifier of the knowledge base used</value>
    public string KnowledgeBaseId { get; set; }

    /// <summary>
    /// Count of any media (images, files, etc) included in this session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included in this session</value>
    public long? MediaCount { get; set; }

    /// <summary>
    /// Message type for messaging services. E.g.: sms, facebook, twitter, line
    /// </summary>
    /// <value>Message type for messaging services. E.g.: sms, facebook, twitter, line</value>
    public string MessageType { get; set; }

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
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    public string ParticipantName { get; set; }

    /// <summary>
    /// This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.
    /// </summary>
    /// <value>This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// The source provider for the communication.
    /// </summary>
    /// <value>The source provider for the communication.</value>
    public string Provider { get; set; }

    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    public string QueueId { get; set; }

    /// <summary>
    /// The recognition failure reason causing to exit/disconnect
    /// </summary>
    /// <value>The recognition failure reason causing to exit/disconnect</value>
    public string RecognitionFailureReason { get; set; }

    /// <summary>
    /// Name, phone number, or email address of the remote party.
    /// </summary>
    /// <value>Name, phone number, or email address of the remote party.</value>
    public string Remote { get; set; }

    /// <summary>
    /// ID(s) of Skill(s) that have been removed by bullseye routing
    /// </summary>
    /// <value>ID(s) of Skill(s) that have been removed by bullseye routing</value>
    public IEnumerable<string> RemovedSkillIds { get; set; }

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
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    public IEnumerable<FlowMetricsTopicFlowMetricRecordRequestedRoutings> RequestedRoutings { get; set; }

    /// <summary>
    /// Unique identifier for the room
    /// </summary>
    /// <value>Unique identifier for the room</value>
    public string RoomId { get; set; }

    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    public long? RoutingPriority { get; set; }

    /// <summary>
    /// Routing ring for bullseye or preferred agent routing
    /// </summary>
    /// <value>Routing ring for bullseye or preferred agent routing</value>
    public long? RoutingRing { get; set; }

    /// <summary>
    /// Routing rule for preferred, conditional and predictive routing type
    /// </summary>
    /// <value>Routing rule for preferred, conditional and predictive routing type</value>
    public string RoutingRule { get; set; }

    /// <summary>
    /// Selected agent ID
    /// </summary>
    /// <value>Selected agent ID</value>
    public string SelectedAgentId { get; set; }

    /// <summary>
    /// Selected agent GPR rank
    /// </summary>
    /// <value>Selected agent GPR rank</value>
    public long? SelectedAgentRank { get; set; }

    /// <summary>
    /// Indicates whether the flow session was self serviced
    /// </summary>
    /// <value>Indicates whether the flow session was self serviced</value>
    public bool? SelfServed { get; set; }

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
    /// Flow starting language, e.g. en-us
    /// </summary>
    /// <value>Flow starting language, e.g. en-us</value>
    public string StartingLanguage { get; set; }

    /// <summary>
    /// Unique identifier for a phone
    /// </summary>
    /// <value>Unique identifier for a phone</value>
    public string StationId { get; set; }

    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    public string TeamId { get; set; }

    /// <summary>
    /// The address of a flow transfer target, e.g. a phone number, an email address, or a queueId
    /// </summary>
    /// <value>The address of a flow transfer target, e.g. a phone number, an email address, or a queueId</value>
    public string TransferTargetAddress { get; set; }

    /// <summary>
    /// The name of a flow transfer target
    /// </summary>
    /// <value>The name of a flow transfer target</value>
    public string TransferTargetName { get; set; }

    /// <summary>
    /// The type of transfer for flows that ended with a transfer
    /// </summary>
    /// <value>The type of transfer for flows that ended with a transfer</value>
    public string TransferType { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    public string UserId { get; set; }

    /// <summary>
    /// Flag indicating if video is present
    /// </summary>
    /// <value>Flag indicating if video is present</value>
    public bool? VideoPresent { get; set; }

    /// <summary>
    /// Number of waiting interactions for each predictive routing attempt
    /// </summary>
    /// <value>Number of waiting interactions for each predictive routing attempt</value>
    public IEnumerable<long?> WaitingInteractionCounts { get; set; }

    /// <summary>
    /// Wrap up code
    /// </summary>
    /// <value>Wrap up code</value>
    public string WrapUpCode { get; set; }

    /// <summary>
    /// Proposed agents
    /// </summary>
    /// <value>Proposed agents</value>
    public IEnumerable<FlowMetricsTopicFlowProposedAgent> ProposedAgents { get; set; }

    /// <summary>
    /// Flow outcomes
    /// </summary>
    /// <value>Flow outcomes</value>
    public IEnumerable<FlowMetricsTopicFlowOutcome> Outcomes { get; set; }

    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    public IEnumerable<FlowMetricsTopicFlowScoredAgent> ScoredAgents { get; set; }
}
