using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationVideoEventTopicTransferResponse
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public QueueConversationVideoEventTopicTransferResponseStateEnum? State { get; set; }

    /// <summary>
    /// The type of transfer to perform.
    /// </summary>
    /// <value>The type of transfer to perform.</value>
    public QueueConversationVideoEventTopicTransferResponseTransferTypeEnum? TransferType { get; set; }

    /// <summary>
    /// The id of the command.
    /// </summary>
    /// <value>The id of the command.</value>
    public string Id { get; set; }

    /// <summary>
    /// The date/time that this command was issued.
    /// </summary>
    /// <value>The date/time that this command was issued.</value>
    public DateTime? DateIssued { get; set; }

    /// <summary>
    /// Gets or Sets Initiator
    /// </summary>
    public QueueConversationVideoEventTopicTransferInitiator Initiator { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public QueueConversationVideoEventTopicTransferModifedBy ModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    public QueueConversationVideoEventTopicTransferDestination Destination { get; set; }
}
