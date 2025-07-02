using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurn
{
    /// <summary>
    /// Result of the bot flow 'ask' action.
    /// </summary>
    /// <value>Result of the bot flow 'ask' action.</value>
    public ReportingTurnAskActionResultEnum? AskActionResult { get; set; }

    /// <summary>
    /// The chosen user input associated with this reporting turn.
    /// </summary>
    /// <value>The chosen user input associated with this reporting turn.</value>
    public string UserInput { get; set; }

    /// <summary>
    /// The bot prompts associated with this reporting turn.
    /// </summary>
    /// <value>The bot prompts associated with this reporting turn.</value>
    public IEnumerable<string> BotPrompts { get; set; }

    /// <summary>
    /// The bot session ID that this reporting turn is grouped under.
    /// </summary>
    /// <value>The bot session ID that this reporting turn is grouped under.</value>
    public string SessionId { get; set; }

    /// <summary>
    /// The bot flow &#39;ask&#39; action associated with this reporting turn (e.g. AskForIntent).
    /// </summary>
    /// <value>The bot flow &#39;ask&#39; action associated with this reporting turn (e.g. AskForIntent).</value>
    public ReportingTurnAction AskAction { get; set; }

    /// <summary>
    /// The intent and associated slots detected during this reporting turn.
    /// </summary>
    /// <value>The intent and associated slots detected during this reporting turn.</value>
    public ReportingTurnIntent Intent { get; set; }

    /// <summary>
    /// The knowledge data captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge data captured during this reporting turn.</value>
    public ReportingTurnKnowledge Knowledge { get; set; }

    /// <summary>
    /// The knowledge data captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge data captured during this reporting turn.</value>
    public ReportingTurnKnowledgeEvents KnowledgeBaseEvents { get; set; }

    /// <summary>
    /// Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Timestamp indicating when the original turn was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the original turn was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// The details related to end of bot flow session.
    /// </summary>
    /// <value>The details related to end of bot flow session.</value>
    public SessionEndDetails SessionEndDetails { get; set; }

    /// <summary>
    /// The conversation details, across potentially multiple Bot Flow sessions.
    public AddressableEntityRef Conversation { get; set; }
}
