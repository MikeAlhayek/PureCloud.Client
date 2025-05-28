using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CopilotNluDomain
{
    /// <summary>
    /// Id of the NLU domain.
    /// </summary>
    /// <value>Id of the NLU domain.</value>
    public string Id { get; set; }

    /// <summary>
    /// Use the latest version of the NLU domain. If false, version is required.
    /// </summary>
    /// <value>Use the latest version of the NLU domain. If false, version is required.</value>
    public bool? UseLatestVersion { get; set; }

    /// <summary>
    /// NLU domain version.
    /// </summary>
    /// <value>NLU domain version.</value>
    public CopilotNluDomainVersion Version { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
