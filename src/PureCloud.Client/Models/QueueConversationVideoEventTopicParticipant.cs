using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationVideoEventTopicParticipant
{
    /// <summary>
    /// The current screen recording state for this participant.
    /// </summary>
    /// <value>The current screen recording state for this participant.</value>
    public QueueConversationVideoEventTopicParticipantScreenRecordingStateEnum? ScreenRecordingState { get; set; }

    /// <summary>
    /// A globally unique identifier for this conversation.
    /// </summary>
    /// <value>A globally unique identifier for this conversation.</value>
    public string Id { get; set; }

    /// <summary>
    /// The timestamp when this participant was connected to the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this participant was connected to the conversation in the provider clock.</value>
    public DateTime? ConnectedTime { get; set; }

    /// <summary>
    /// The timestamp when this participant disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this participant disconnected from the conversation in the provider clock.</value>
    public DateTime? EndTime { get; set; }

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
    /// A human readable name identifying the participant.
    /// </summary>
    /// <value>A human readable name identifying the participant.</value>
    public string Name { get; set; }

    /// <summary>
    /// If present, the queue id that the communication channel came in on.
    /// </summary>
    /// <value>If present, the queue id that the communication channel came in on.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// If present, the group id that the participant represents.
    /// </summary>
    /// <value>If present, the group id that the participant represents.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// The team id that this participant is a member of when added to the conversation.
    /// </summary>
    /// <value>The team id that this participant is a member of when added to the conversation.</value>
    public string TeamId { get; set; }

    /// <summary>
    /// A well known string that specifies the purpose or type of this participant.
    /// </summary>
    /// <value>A well known string that specifies the purpose or type of this participant.</value>
    public string Purpose { get; set; }

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
    /// True iff this participant is required to enter wrapup for this conversation.
    /// </summary>
    /// <value>True iff this participant is required to enter wrapup for this conversation.</value>
    public bool? WrapupRequired { get; set; }

    /// <summary>
    /// True when a participant is expected to enter a wrapup code once the call connects.
    /// </summary>
    /// <value>True when a participant is expected to enter a wrapup code once the call connects.</value>
    public bool? WrapupExpected { get; set; }

    /// <summary>
    /// This field controls how the UI prompts the agent for a wrapup.
    /// </summary>
    /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
    public string WrapupPrompt { get; set; }

    /// <summary>
    /// Specifies how long a timed ACW session will last.
    /// </summary>
    /// <value>Specifies how long a timed ACW session will last.</value>
    public long? WrapupTimeoutMs { get; set; }

    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    public QueueConversationVideoEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// The timestamp when this participant started after-call work.
    /// </summary>
    /// <value>The timestamp when this participant started after-call work.</value>
    public DateTime? StartAcwTime { get; set; }

    /// <summary>
    /// The timestamp when this participant ended after-call work.
    /// </summary>
    /// <value>The timestamp when this participant ended after-call work.</value>
    public DateTime? EndAcwTime { get; set; }

    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    public QueueConversationVideoEventTopicConversationRoutingData ConversationRoutingData { get; set; }

    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    public long? AlertingTimeoutMs { get; set; }

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
    /// If this participant created a barge in conference, then this will be the id of the participant that is barged in.
    /// </summary>
    /// <value>If this participant created a barge in conference, then this will be the id of the participant that is barged in.</value>
    public string BargedParticipantId { get; set; }

    /// <summary>
    /// List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.
    /// </summary>
    /// <value>List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.</value>
    public IEnumerable<string> MediaRoles { get; set; }

    /// <summary>
    /// If this participant has flagged the conversation, the reason code given.
    /// </summary>
    /// <value>If this participant has flagged the conversation, the reason code given.</value>
    public string FlaggedReason { get; set; }

    /// <summary>
    /// Additional participant attributes
    /// </summary>
    /// <value>Additional participant attributes</value>
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicCall> Calls { get; set; }

    /// <summary>
    /// Gets or Sets Callbacks
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicCallback> Callbacks { get; set; }

    /// <summary>
    /// Gets or Sets Chats
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicChat> Chats { get; set; }

    /// <summary>
    /// Gets or Sets Cobrowsesessions
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicCobrowse> Cobrowsesessions { get; set; }

    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicEmail> Emails { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicMessage> Messages { get; set; }

    /// <summary>
    /// Gets or Sets InternalMessages
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicInternalMessage> InternalMessages { get; set; }

    /// <summary>
    /// Gets or Sets Screenshares
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicScreenshare> Screenshares { get; set; }

    /// <summary>
    /// Gets or Sets SocialExpressions
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicSocialExpression> SocialExpressions { get; set; }

    /// <summary>
    /// Gets or Sets Videos
    /// </summary>
    public IEnumerable<QueueConversationVideoEventTopicVideo> Videos { get; set; }

    /// <summary>
    /// Gets or Sets Workflow
    /// </summary>
    public QueueConversationVideoEventTopicWorkflow Workflow { get; set; }
}
