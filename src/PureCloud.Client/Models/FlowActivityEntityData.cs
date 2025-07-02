using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowActivityEntityData
{
    /// <summary>
    /// Activity metric
    /// </summary>
    /// <value>Activity metric</value>
    public FlowActivityEntityDataMetricEnum? Metric { get; set; }

    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    public FlowActivityEntityDataActiveRoutingEnum? ActiveRouting { get; set; }

    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    public FlowActivityEntityDataDirectionEnum? Direction { get; set; }

    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    public FlowActivityEntityDataFlowTypeEnum? FlowType { get; set; }

    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    public FlowActivityEntityDataMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    public FlowActivityEntityDataUsedRoutingEnum? UsedRouting { get; set; }

    /// <summary>
    /// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ActivityDate { get; set; }

    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    public string AddressFrom { get; set; }

    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    public string AddressTo { get; set; }

    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    public string Ani { get; set; }

    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    public string ConvertedFrom { get; set; }

    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    public string ConvertedTo { get; set; }

    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    public string Dnis { get; set; }

    /// <summary>
    /// The unique identifier of this flow
    /// </summary>
    /// <value>The unique identifier of this flow</value>
    public string FlowId { get; set; }

    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    public string ParticipantName { get; set; }

    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    public string RequestedLanguageId { get; set; }

    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    public IEnumerable<string> RequestedRoutingSkillIds { get; set; }

    /// <summary>
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    public IEnumerable<FlowActivityEntityDataRequestedRoutingsEnum> RequestedRoutings { get; set; }

    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    public long? RoutingPriority { get; set; }

    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    public string SessionId { get; set; }

    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    public string TeamId { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    public string UserId { get; set; }

    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    public IEnumerable<FlowActivityScoredAgent> ScoredAgents { get; set; }
}
