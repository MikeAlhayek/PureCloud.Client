using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody
{
    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentId
    /// </summary>
    public string DeploymentId { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantId
    public string ParticipantId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// Gets or Sets CommunicationId
    /// </summary>
    public string CommunicationId { get; set; }

    /// <summary>
    /// Gets or Sets SessionExpiry
    /// </summary>
    public long? SessionExpiry { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    public IEnumerable<V2WebMessagingUndeliveredMessageTopicMessage> Messages { get; set; }

    /// <summary>
    /// Gets or Sets EventTimeMs
    /// </summary>
    public long? EventTimeMs { get; set; }
}
