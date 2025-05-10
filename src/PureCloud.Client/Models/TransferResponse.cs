namespace PureCloud.Client.Models;

public sealed class TransferResponse
{
    /// <summary>
    /// The state of the command.
    /// </summary>
    /// <value>The state of the command.</value>
    public TransferResponseState? State { get; set; }

    /// <summary>
    /// The type of transfer to perform.
    /// </summary>
    /// <value>The type of transfer to perform.</value>
    public TransferResponseTransferType? TransferType { get; set; }

    /// <summary>
    /// The id of the command.
    /// </summary>
    /// <value>The id of the command.</value>
    public string Id { get; set; }

    /// <summary>
    /// The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateIssued { get; set; }

    /// <summary>
    /// The initiator of the command.
    /// </summary>
    /// <value>The initiator of the command.</value>
    public TransferInitiator Initiator { get; set; }

    /// <summary>
    /// The user or entity that modified the command.
    /// </summary>
    /// <value>The user or entity that modified the command.</value>
    public TransferResponseModifiedBy ModifiedBy { get; set; }

    /// <summary>
    /// The destination of the command.
    /// </summary>
    /// <value>The destination of the command.</value>
    public TransferDestination Destination { get; set; }
}
