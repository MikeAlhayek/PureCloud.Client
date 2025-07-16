using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalSource
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the external source.
    /// </summary>
    /// <value>The name of the external source.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets LinkConfiguration
    /// </summary>
    public LinkConfiguration LinkConfiguration { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
