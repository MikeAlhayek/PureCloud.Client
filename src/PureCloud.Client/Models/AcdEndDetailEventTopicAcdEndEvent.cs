using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AcdEndDetailEventTopicAcdEndEvent
{
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    public AcdEndDetailEventTopicAcdEndEventDisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public AcdEndDetailEventTopicAcdEndEventMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public AcdEndDetailEventTopicAcdEndEventDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    public AcdEndDetailEventTopicAcdEndEventMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets AcdOutcome
    /// </summary>
    public AcdEndDetailEventTopicAcdEndEventAcdOutcomeEnum? AcdOutcome { get; set; }

    /// <summary>
    /// Gets or Sets UsedRouting
    /// </summary>
    public AcdEndDetailEventTopicAcdEndEventUsedRoutingEnum? UsedRouting { get; set; }

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
    /// Gets or Sets QueueId
    /// </summary>
    public string QueueId { get; set; }

    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    public string DivisionId { get; set; }

    /// <summary>
    /// Gets or Sets AnsweredUserId
    /// </summary>
    public string AnsweredUserId { get; set; }

    /// <summary>
    /// Gets or Sets RequestedRoutings
    /// </summary>
    public IEnumerable<AcdEndDetailEventTopicAcdEndEventRequestedRoutingsEnum> RequestedRoutings { get; set; }

    /// <summary>
    /// Gets or Sets RequestedRoutingSkillIds
    /// </summary>
    public IEnumerable<Guid?> RequestedRoutingSkillIds { get; set; }

    /// <summary>
    /// Gets or Sets RequestedLanguageId
    /// </summary>
    public string RequestedLanguageId { get; set; }

    /// <summary>
    /// Gets or Sets RequestedRoutingUserIds
    /// </summary>
    public IEnumerable<Guid?> RequestedRoutingUserIds { get; set; }

    /// <summary>
    /// Gets or Sets RoutingPriority
    /// </summary>
    public long? RoutingPriority { get; set; }

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

    /// <summary>
    /// Gets or Sets UtilizationLabel
    /// </summary>
    public string UtilizationLabel { get; set; }

    /// <summary>
    /// Gets or Sets FlowType
    /// </summary>
    public string FlowType { get; set; }
}
