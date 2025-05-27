using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserExternalIdentifier
{
    /// <summary>
    /// Authority or System of Record which owns the External Identifier
    /// </summary>
    /// <value>Authority or System of Record which owns the External Identifier</value>
    public string AuthorityName { get; set; }

    /// <summary>
    /// External Key
    /// </summary>
    /// <value>External Key</value>
    public string ExternalKey { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
