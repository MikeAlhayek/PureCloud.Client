using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailCommunicationDispositionAppliedEvent
{
    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    public string EventId { get; set; }

    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventDateTime { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication</value>
    public string CommunicationId { get; set; }

    /// <summary>
    /// The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped.
    /// </summary>
    /// <value>The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped.</value>
    public string Code { get; set; }

    /// <summary>
    /// Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.
    /// </summary>
    /// <value>Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.</value>
    public string Notes { get; set; }

    /// <summary>
    /// The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.
    /// </summary>
    /// <value>The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.</value>
    public IEnumerable<string> Tags { get; set; }
}
