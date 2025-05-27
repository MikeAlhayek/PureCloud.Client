using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Models;

public sealed class ObservationValue
{
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    public ObservationValueDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    public ObservationValueUsedRoutingEnum? UsedRouting { get; set; }

    /// <summary>
    /// The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ObservationDate { get; set; }

    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    public string SessionId { get; set; }

    /// <summary>
    /// Unique identifier for a skill requested for an interaction
    /// </summary>
    /// <value>Unique identifier for a skill requested for an interaction</value>
    public IEnumerable<string> RequestedRoutingSkillIds { get; set; }

    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    public string RequestedLanguageId { get; set; }

    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    public long? RoutingPriority { get; set; }

    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    public string ParticipantName { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    public string UserId { get; set; }

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
    /// The address that initiated an action
    /// </summary>
    public string AddressFrom { get; set; }

    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    public string AddressTo { get; set; }

    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    public string Ani { get; set; }

    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    public string Dnis { get; set; }

    /// <summary>
    /// The team id the user is a member of
    /// </summary>
    /// <value>The team id the user is a member of</value>
    public string TeamId { get; set; }

    /// <summary>
    /// All routing types for requested/attempted routing methods
    /// </summary>
    /// <value>All routing types for requested/attempted routing methods</value>
    public IEnumerable<ObservationValueRequestedRoutingsEnum> RequestedRoutings { get; set; }

    /// <summary>
    /// Gets or Sets ScoredAgents
    /// </summary>
    public IEnumerable<AnalyticsScoredAgent> ScoredAgents { get; set; }
}
