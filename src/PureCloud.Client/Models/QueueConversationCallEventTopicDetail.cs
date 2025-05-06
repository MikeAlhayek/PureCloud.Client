using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationCallEventTopicDetail
{
    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    public string FieldName { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    public string EntityId { get; set; }

    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    public string EntityName { get; set; }
}
