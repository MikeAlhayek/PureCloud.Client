using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class CollaborateChatGroupMessageEventTopicCollaborateChatMessage
{
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    public CollaborateChatGroupMessageEventTopicCollaborateChatMessageActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// Gets or Sets MessageId
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    public string Created { get; set; }

    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    public CollaborateChatGroupMessageEventTopicCollaborateChatEntity From { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    public CollaborateChatGroupMessageEventTopicCollaborateChatEntity To { get; set; }

    /// <summary>
    /// Gets or Sets Mentions
    /// </summary>
    public IEnumerable<CollaborateChatGroupMessageEventTopicCollaborateChatEntity> Mentions { get; set; }

    /// <summary>
    /// Gets or Sets NotifyAll
    /// </summary>
    public bool? NotifyAll { get; set; }

    /// <summary>
    /// Gets or Sets Reactions
    /// </summary>
    public Dictionary<string, List<string>> Reactions { get; set; }
}
