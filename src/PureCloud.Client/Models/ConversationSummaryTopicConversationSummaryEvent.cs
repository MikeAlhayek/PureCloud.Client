using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicConversationSummaryEvent
{
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public ConversationSummaryTopicConversationSummaryEventMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public ConversationSummaryTopicConversationSummaryEventMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets ErrorType
    /// </summary>
    public ConversationSummaryTopicConversationSummaryEventErrorTypeEnum? ErrorType { get; set; }

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
    public IEnumerable<ConversationSummaryTopicConversationSummaryParticipant> Participants { get; set; }

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
    public ConversationSummaryTopicConversationSummary Summary { get; set; }

    /// <summary>
    /// Gets or Sets Headline
    /// </summary>
    public ConversationSummaryTopicConversationHeadline Headline { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    public ConversationSummaryTopicConversationReason Reason { get; set; }

    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>
    public ConversationSummaryTopicConversationResolution Resolution { get; set; }

    /// <summary>
    /// Gets or Sets WrapUpCodes
    /// </summary>
    public IEnumerable<ConversationSummaryTopicConversationWrapUpCode> WrapUpCodes { get; set; }

    /// <summary>
    /// Gets or Sets TriggerSource
    /// </summary>
    public ConversationSummaryTopicTriggerSource TriggerSource { get; set; }

    /// <summary>
    /// Gets or Sets LastEditedBy
    /// </summary>
    public ConversationSummaryTopicConversationSummaryParticipant LastEditedBy { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    public long? DurationMs { get; set; }
}
