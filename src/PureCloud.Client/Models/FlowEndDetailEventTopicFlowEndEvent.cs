using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowEndDetailEventTopicFlowEndEvent
{
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    public FlowEndDetailEventTopicFlowEndEventDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public FlowEndDetailEventTopicFlowEndEventMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public FlowEndDetailEventTopicFlowEndEventDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public FlowEndDetailEventTopicFlowEndEventMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets FlowType
    /// </summary>
    public FlowEndDetailEventTopicFlowEndEventFlowTypeEnum? FlowType { get; set; }

    /// <summary>
    /// Gets or Sets ExitReason
    /// </summary>
    public FlowEndDetailEventTopicFlowEndEventExitReasonEnum? ExitReason { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public long? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantId
    /// </summary>
    public string ParticipantId { get; set; }

    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    public string Provider { get; set; }

    /// <summary>
    /// Gets or Sets Ani
    /// </summary>
    public string Ani { get; set; }

    /// <summary>
    /// Gets or Sets Dnis
    /// </summary>
    public string Dnis { get; set; }

    /// <summary>
    /// Gets or Sets AddressTo
    /// </summary>
    public string AddressTo { get; set; }

    /// <summary>
    /// Gets or Sets AddressFrom
    /// </summary>
    public string AddressFrom { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets FlowId
    /// </summary>
    public string FlowId { get; set; }

    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    public string DivisionId { get; set; }

    /// <summary>
    /// Gets or Sets FlowVersion
    /// </summary>
    public string FlowVersion { get; set; }

    /// <summary>
    /// Gets or Sets ConnectedDurationMs
    /// </summary>
    public long? ConnectedDurationMs { get; set; }

    /// <summary>
    /// Gets or Sets ConversationExternalContactIds
    /// </summary>
    public IEnumerable<string> ConversationExternalContactIds { get; set; }

    /// <summary>
    /// Gets or Sets ConversationExternalOrganizationIds
    /// </summary>
    public IEnumerable<string> ConversationExternalOrganizationIds { get; set; }
}
