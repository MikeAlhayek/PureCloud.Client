using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationEmailEventTopicEmailMediaParticipant
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationEmailEventTopicEmailMediaParticipantStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public ConversationEmailEventTopicEmailMediaParticipantInitialStateEnum? InitialState { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public ConversationEmailEventTopicEmailMediaParticipantDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    public ConversationEmailEventTopicEmailMediaParticipantDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// Gets or Sets FlaggedReason
    /// </summary>
    public ConversationEmailEventTopicEmailMediaParticipantFlaggedReasonEnum? FlaggedReason { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Gets or Sets ConnectedTime
    /// </summary>
    public DateTime? ConnectedTime { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Gets or Sets StartHoldTime
    /// </summary>
    public DateTime? StartHoldTime { get; set; }

    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    public string Purpose { get; set; }

    /// <summary>
    /// Gets or Sets Held
    /// </summary>
    public bool? Held { get; set; }

    /// <summary>
    /// Gets or Sets WrapupRequired
    /// </summary>
    public bool? WrapupRequired { get; set; }

    /// <summary>
    /// Gets or Sets WrapupPrompt
    /// </summary>
    public string WrapupPrompt { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public ConversationEmailEventTopicUriReference User { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public ConversationEmailEventTopicUriReference Queue { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public ConversationEmailEventTopicUriReference Team { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ConversationEmailEventTopicErrorBody ErrorInfo { get; set; }

    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    public ConversationEmailEventTopicUriReference Script { get; set; }

    /// <summary>
    /// Gets or Sets WrapupTimeoutMs
    /// </summary>
    public long? WrapupTimeoutMs { get; set; }

    /// <summary>
    /// Gets or Sets WrapupSkipped
    /// </summary>
    public bool? WrapupSkipped { get; set; }

    /// <summary>
    /// Gets or Sets AlertingTimeoutMs
    /// </summary>
    public long? AlertingTimeoutMs { get; set; }

    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    public string Provider { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    public ConversationEmailEventTopicUriReference ExternalContact { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContactInitialDivisionId
    /// </summary>
    public string ExternalContactInitialDivisionId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    public ConversationEmailEventTopicUriReference ExternalOrganization { get; set; }

    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    public ConversationEmailEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    public ConversationEmailEventTopicConversationRoutingData ConversationRoutingData { get; set; }

    /// <summary>
    /// Gets or Sets Peer
    /// </summary>
    public string Peer { get; set; }

    /// <summary>
    /// Gets or Sets ScreenRecordingState
    /// </summary>
    public string ScreenRecordingState { get; set; }

    /// <summary>
    /// Gets or Sets JourneyContext
    /// </summary>
    public ConversationEmailEventTopicJourneyContext JourneyContext { get; set; }

    /// <summary>
    /// Gets or Sets StartAcwTime
    /// </summary>
    public DateTime? StartAcwTime { get; set; }

    /// <summary>
    /// Gets or Sets EndAcwTime
    /// </summary>
    public DateTime? EndAcwTime { get; set; }

    /// <summary>
    /// Gets or Sets ResumeTime
    /// </summary>
    public DateTime? ResumeTime { get; set; }

    /// <summary>
    /// Gets or Sets ParkTime
    /// </summary>
    public DateTime? ParkTime { get; set; }

    /// <summary>
    /// Gets or Sets MediaRoles
    /// </summary>
    public IEnumerable<string> MediaRoles { get; set; }

    /// <summary>
    /// Gets or Sets QueueMediaSettings
    /// </summary>
    public ConversationEmailEventTopicQueueMediaSettings QueueMediaSettings { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets MessagesSent
    /// </summary>
    public long? MessagesSent { get; set; }

    /// <summary>
    /// Gets or Sets AutoGenerated
    /// </summary>
    public bool? AutoGenerated { get; set; }

    /// <summary>
    /// Gets or Sets MessageId
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    /// Gets or Sets DraftAttachments
    /// </summary>
    public IEnumerable<ConversationEmailEventTopicAttachment> DraftAttachments { get; set; }

    /// <summary>
    /// Gets or Sets Spam
    /// </summary>
    public bool? Spam { get; set; }
}
