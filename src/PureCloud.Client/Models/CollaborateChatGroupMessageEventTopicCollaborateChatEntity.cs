using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CollaborateChatGroupMessageEventTopicCollaborateChatEntity
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public CollaborateChatGroupMessageEventTopicCollaborateChatEntityEntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Gets or Sets EntityJid
    /// </summary>
    public string EntityJid { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    public string EntityId { get; set; }
}
