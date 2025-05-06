using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public partial class ConversationCallEventTopicCallMediaParticipant
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public StateEnum? State { get; set; }


    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    public InitialStateEnum? InitialState { get; set; }


    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public DirectionEnum? Direction { get; set; }


    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    public DisconnectTypeEnum? DisconnectType { get; set; }


    /// <summary>
    /// Gets or Sets FlaggedReason
    /// </summary>
    public FlaggedReasonEnum? FlaggedReason { get; set; }


    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    public RecordingStateEnum? RecordingState { get; set; }


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
    public ConversationCallEventTopicUriReference User { get; set; }


    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public ConversationCallEventTopicUriReference Queue { get; set; }


    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public ConversationCallEventTopicUriReference Team { get; set; }


    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public Dictionary<string, string> Attributes { get; set; }


    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public ConversationCallEventTopicErrorBody ErrorInfo { get; set; }


    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    public ConversationCallEventTopicUriReference Script { get; set; }


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
    public ConversationCallEventTopicUriReference ExternalContact { get; set; }


    /// <summary>
    /// Gets or Sets ExternalContactInitialDivisionId
    /// </summary>
    public string ExternalContactInitialDivisionId { get; set; }


    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    public ConversationCallEventTopicUriReference ExternalOrganization { get; set; }


    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    public ConversationCallEventTopicWrapup Wrapup { get; set; }


    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    public ConversationCallEventTopicConversationRoutingData ConversationRoutingData { get; set; }


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
    public ConversationCallEventTopicJourneyContext JourneyContext { get; set; }


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
    public ConversationCallEventTopicQueueMediaSettings QueueMediaSettings { get; set; }


    /// <summary>
    /// Gets or Sets Muted
    /// </summary>
    public bool? Muted { get; set; }


    /// <summary>
    /// Gets or Sets Confined
    /// </summary>
    public bool? Confined { get; set; }


    /// <summary>
    /// Gets or Sets Recording
    /// </summary>
    public bool? Recording { get; set; }


    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    public bool? SecurePause { get; set; }


    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public ConversationCallEventTopicUriReference Group { get; set; }


    /// <summary>
    /// Gets or Sets Ani
    /// </summary>
    public string Ani { get; set; }


    /// <summary>
    /// Gets or Sets Dnis
    /// </summary>
    public string Dnis { get; set; }


    /// <summary>
    /// Gets or Sets DocumentId
    /// </summary>
    public string DocumentId { get; set; }


    /// <summary>
    /// Gets or Sets MonitoredParticipantId
    /// </summary>
    public string MonitoredParticipantId { get; set; }


    /// <summary>
    /// Gets or Sets CoachedParticipantId
    /// </summary>
    public string CoachedParticipantId { get; set; }


    /// <summary>
    /// Gets or Sets BargedParticipantId
    /// </summary>
    public string BargedParticipantId { get; set; }


    /// <summary>
    /// Gets or Sets BargedTime
    /// </summary>
    public DateTime? BargedTime { get; set; }


    /// <summary>
    /// Gets or Sets ConsultParticipantId
    /// </summary>
    public string ConsultParticipantId { get; set; }


    /// <summary>
    /// Gets or Sets FaxStatus
    /// </summary>
    public ConversationCallEventTopicFaxStatus FaxStatus { get; set; }
}
