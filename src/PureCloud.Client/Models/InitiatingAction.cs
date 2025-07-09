using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InitiatingAction
{
    /// <summary>
    /// Id of the audit initiating the transaction
    /// </summary>
    /// <value>Id of the audit initiating the transaction</value>
    public string TransactionId { get; set; }

    /// <summary>
    /// Action of the audit initiating the transaction
    /// </summary>
    /// <value>Action of the audit initiating the transaction</value>
    public string ActionContext { get; set; }
}
