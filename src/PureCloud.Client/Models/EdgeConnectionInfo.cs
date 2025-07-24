using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeConnectionInfo
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Interface used for the connection on the edge
    /// </summary>
    /// <value>Interface used for the connection on the edge</value>
    public string InterfaceName { get; set; }

    /// <summary>
    /// IP address of the interface
    /// </summary>
    /// <value>IP address of the interface</value>
    public string InterfaceIpAddress { get; set; }

    /// <summary>
    /// Connection errors
    /// </summary>
    /// <value>Connection errors</value>
    public IEnumerable<string> ConnectionErrors { get; set; }

    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    public AddressableEntityRef Site { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
