using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CopilotNluDomainVersion
{
    /// <summary>
    /// Id of the NLU v3 domain version.
    /// </summary>
    /// <value>Id of the NLU v3 domain version.</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
