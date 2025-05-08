using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserStartDetailEventTopicUserStartEvent
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public UserStartDetailEventTopicUserStartEventMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public UserStartDetailEventTopicUserStartEventDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public UserStartDetailEventTopicUserStartEventMessageTypeEnum? MessageType { get; set; }

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
    /// Gets or Sets CallbackUserName
    /// </summary>
    public string CallbackUserName { get; set; }

    /// <summary>
    /// Gets or Sets CallbackNumbers
    /// </summary>
    public IEnumerable<string> CallbackNumbers { get; set; }

    /// <summary>
    /// Gets or Sets CallbackScheduledTime
    /// </summary>
    public long? CallbackScheduledTime { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    public string DivisionId { get; set; }

    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    public string QueueId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationExternalContactIds
    /// </summary>
    public IEnumerable<string> ConversationExternalContactIds { get; set; }

    /// <summary>
    /// Gets or Sets ConversationExternalOrganizationIds
    /// </summary>
    public IEnumerable<string> ConversationExternalOrganizationIds { get; set; }
}
