using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsAgentStateAgentSessionResult
{
    /// <summary>
    /// Segment type
    /// </summary>
    /// <value>Segment type</value>
    public AnalyticsAgentStateAgentSessionResultSegmentTypeEnum? SegmentType { get; set; }

    /// <summary>
    /// Originating direction
    /// </summary>
    /// <value>Originating direction</value>
    public AnalyticsAgentStateAgentSessionResultOriginatingDirectionEnum? OriginatingDirection { get; set; }

    /// <summary>
    /// Media type
    /// </summary>
    /// <value>Media type</value>
    public AnalyticsAgentStateAgentSessionResultMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Conversation Id
    /// </summary>
    /// <value>Conversation Id</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// Session Id
    /// </summary>
    /// <value>Session Id</value>
    public string SessionId { get; set; }

    /// <summary>
    /// Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? SessionStart { get; set; }

    /// <summary>
    /// Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? SegmentStart { get; set; }

    /// <summary>
    /// Routed queue Id
    /// </summary>
    /// <value>Routed queue Id</value>
    public string RoutedQueueId { get; set; }

    /// <summary>
    /// List of requested routing skill Id
    /// </summary>
    /// <value>List of requested routing skill Id</value>
    public IEnumerable<string> RequestedRoutingSkillIds { get; set; }

    /// <summary>
    /// Requested language Id
    /// </summary>
    /// <value>Requested language Id</value>
    public string RequestedLanguageId { get; set; }
}
