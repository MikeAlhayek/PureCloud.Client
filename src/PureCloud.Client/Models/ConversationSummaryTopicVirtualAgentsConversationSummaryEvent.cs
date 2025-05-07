using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicVirtualAgentsConversationSummaryEvent
{
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationSummaryEventMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationSummaryEventMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets ErrorType
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationSummaryEventErrorTypeEnum? ErrorType { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public Guid? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    public Guid? QueueId { get; set; }

    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    public IEnumerable<ConversationSummaryTopicVirtualAgentsConversationSummaryParticipant> Participants { get; set; }

    /// <summary>
    /// Gets or Sets CommunicationIds
    /// </summary>
    public IEnumerable<string> CommunicationIds { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets SummaryId
    /// </summary>
    public Guid? SummaryId { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationSummary Summary { get; set; }

    /// <summary>
    /// Gets or Sets Headline
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationHeadline Headline { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationReason Reason { get; set; }

    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationResolution Resolution { get; set; }

    /// <summary>
    /// Gets or Sets WrapUpCodes
    /// </summary>
    public IEnumerable<ConversationSummaryTopicVirtualAgentsConversationWrapUpCode> WrapUpCodes { get; set; }

    /// <summary>
    /// Gets or Sets TriggerSource
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsTriggerSource TriggerSource { get; set; }

    /// <summary>
    /// Gets or Sets LastEditedBy
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsConversationSummaryParticipant LastEditedBy { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }
}
