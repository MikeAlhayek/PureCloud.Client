using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationVideoEventTopicVideoMediaParticipant
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationVideoEventTopicVideoMediaParticipantStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public ConversationVideoEventTopicVideoMediaParticipantInitialStateEnum? InitialState { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public ConversationVideoEventTopicVideoMediaParticipantDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    public ConversationVideoEventTopicVideoMediaParticipantDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// Gets or Sets FlaggedReason
    /// </summary>
    public ConversationVideoEventTopicVideoMediaParticipantFlaggedReasonEnum? FlaggedReason { get; set; }

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
    public ConversationVideoEventTopicUriReference User { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public ConversationVideoEventTopicUriReference Queue { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public ConversationVideoEventTopicUriReference Team { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ConversationVideoEventTopicErrorBody ErrorInfo { get; set; }

    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    public ConversationVideoEventTopicUriReference Script { get; set; }

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
    public ConversationVideoEventTopicUriReference ExternalContact { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContactInitialDivisionId
    /// </summary>
    public string ExternalContactInitialDivisionId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    public ConversationVideoEventTopicUriReference ExternalOrganization { get; set; }

    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    public ConversationVideoEventTopicWrapup Wrapup { get; set; }

    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    public ConversationVideoEventTopicConversationRoutingData ConversationRoutingData { get; set; }

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
    public ConversationVideoEventTopicJourneyContext JourneyContext { get; set; }

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
    public ConversationVideoEventTopicQueueMediaSettings QueueMediaSettings { get; set; }

    /// <summary>
    /// Gets or Sets AudioMuted
    /// </summary>
    public bool? AudioMuted { get; set; }

    /// <summary>
    /// Gets or Sets VideoMuted
    /// </summary>
    public bool? VideoMuted { get; set; }

    /// <summary>
    /// Gets or Sets SharingScreen
    /// </summary>
    public bool? SharingScreen { get; set; }

    /// <summary>
    /// Gets or Sets PeerCount
    /// </summary>
    public long? PeerCount { get; set; }

    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    public string Context { get; set; }

    /// <summary>
    /// Gets or Sets Msids
    /// </summary>
    public IEnumerable<string> Msids { get; set; }
}
