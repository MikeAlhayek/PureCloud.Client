using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class IdentifierClaimRequest
{
    /// <summary>
    /// The operation to perform claim/release
    /// </summary>
    /// <value>The operation to perform claim/release</value>
    public IdentifierClaimRequestOperationEnum? Operation { get; set; }

    /// <summary>
    /// The identifier that should be claimed/released from a contact
    /// </summary>
    /// <value>The identifier that should be claimed/released from a contact</value>
    public ContactIdentifier Identifier { get; set; }
}
