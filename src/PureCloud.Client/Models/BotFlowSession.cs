using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotFlowSession
{
    /// <summary>
    /// The reason for session termination.
    /// </summary>
    /// <value>The reason for session termination.</value>
    public BotFlowSessionBotResultEnum? BotResult { get; set; }

    /// <summary>
    /// The category of result for the session.
    /// </summary>
    /// <value>The category of result for the session.</value>
    public BotFlowSessionBotResultCategoryEnum? BotResultCategory { get; set; }

    /// <summary>
    /// The ID of the bot session.
    /// </summary>
    /// <value>The ID of the bot session.</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow associated to this bot session.
    /// </summary>
    /// <value>The flow associated to this bot session.</value>
    public Entity Flow { get; set; }

    /// <summary>
    /// Channel-specific information that describes the message channel/provider.
    /// </summary>
    /// <value>Channel-specific information that describes the message channel/provider.</value>
    public BotChannel Channel { get; set; }

    /// <summary>
    /// The initial language of operation for the session.
    /// </summary>
    /// <value>The initial language of operation for the session.</value>
    public string Language { get; set; }

    /// <summary>
    /// The language of the session at the time the session ended
    /// </summary>
    /// <value>The language of the session at the time the session ended</value>
    public string EndLanguage { get; set; }

    /// <summary>
    /// Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Timestamp indicating when the session was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// The conversation details, across potentially multiple Bot Flow sessions.
    /// </summary>
    /// <value>The conversation details, across potentially multiple Bot Flow sessions.</value>
    public AddressableEntityRef Conversation { get; set; }
}
