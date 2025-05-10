namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationEventTopicTransferResponse
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ConversationEventTopicTransferResponseState? State { get; set; }

    /// <summary>
    /// The type of transfer to perform.
    /// </summary>
    /// <value>The type of transfer to perform.</value>
    public ConversationEventTopicTransferResponseTransferType? TransferType { get; set; }

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
    public ConversationEventTopicTransferInitiator Initiator { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public ConversationEventTopicTransferModifiedBy ModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    public ConversationEventTopicTransferDestination Destination { get; set; }
}
