using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationCobrowseEventTopicErrorBody
{
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public long? Status { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    public string EntityId { get; set; }

    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    public string EntityName { get; set; }

    /// <summary>
    /// Gets or Sets MessageWithParams
    /// </summary>
    public string MessageWithParams { get; set; }

    /// <summary>
    /// Gets or Sets MessageParams
    /// </summary>
    public Dictionary<string, string> MessageParams { get; set; }

    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    public string ContextId { get; set; }

    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    public IEnumerable<ConversationCobrowseEventTopicDetail> Details { get; set; }

    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    public IEnumerable<ConversationCobrowseEventTopicErrorBody> Errors { get; set; }

    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    public ConversationCobrowseEventTopicLimit Limit { get; set; }
}
