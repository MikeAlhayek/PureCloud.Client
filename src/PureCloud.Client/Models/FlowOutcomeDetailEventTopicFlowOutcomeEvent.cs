using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowOutcomeDetailEventTopicFlowOutcomeEvent
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public FlowOutcomeDetailEventTopicFlowOutcomeEventMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public FlowOutcomeDetailEventTopicFlowOutcomeEventDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public FlowOutcomeDetailEventTopicFlowOutcomeEventMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets FlowType
    /// </summary>
    public FlowOutcomeDetailEventTopicFlowOutcomeEventFlowTypeEnum? FlowType { get; set; }

    /// <summary>
    /// Gets or Sets FlowOutcomeValue
    /// </summary>
    public FlowOutcomeDetailEventTopicFlowOutcomeEventFlowOutcomeValueEnum? FlowOutcomeValue { get; set; }

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
    /// Gets or Sets FlowOutcomeId
    /// </summary>
    public Guid? FlowOutcomeId { get; set; }

    /// <summary>
    /// Gets or Sets FlowOutcomeStartTime
    /// </summary>
    public long? FlowOutcomeStartTime { get; set; }

    /// <summary>
    /// Gets or Sets FlowOutcomeEndTime
    /// </summary>
    public long? FlowOutcomeEndTime { get; set; }

    /// <summary>
    /// Gets or Sets FlowMilestones
    /// </summary>
    public IEnumerable<FlowOutcomeDetailEventTopicFlowMilestone> FlowMilestones { get; set; }

    /// <summary>
    /// Gets or Sets ConversationExternalContactIds
    /// </summary>
    public IEnumerable<string> ConversationExternalContactIds { get; set; }

    /// <summary>
    /// Gets or Sets ConversationExternalOrganizationIds
    /// </summary>
    public IEnumerable<string> ConversationExternalOrganizationIds { get; set; }
}
