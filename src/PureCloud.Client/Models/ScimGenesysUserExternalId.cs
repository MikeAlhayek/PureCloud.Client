using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// External Identifiers of user. The external identifier must be unique within the organization and the &#39;authority&#39;
/// </summary>
public sealed class ScimGenesysUserExternalId
{
    /// <summary>
    /// Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier.
    /// </summary>
    /// <value>Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier.</value>
    public string Authority { get; set; }

    /// <summary>
    /// Identifier of the user in an external system.
    /// </summary>
    /// <value>Identifier of the user in an external system.</value>
    public string Value { get; set; }
}
