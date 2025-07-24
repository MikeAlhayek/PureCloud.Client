using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConnectedEdge
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
    /// Edge interface name used for the connection
    /// </summary>
    /// <value>Edge interface name used for the connection</value>
    public string InterfaceName { get; set; }

    /// <summary>
    /// Edge interface IP address
    /// </summary>
    /// <value>Edge interface IP address</value>
    public string InterfaceIpAddress { get; set; }

    /// <summary>
    /// Gets or Sets EdgeConnectionList
    /// </summary>
    public IEnumerable<EdgeConnectionInfo> EdgeConnectionList { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
