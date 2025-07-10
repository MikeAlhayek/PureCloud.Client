using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Models;

public sealed class EmergencyLocation
{
    /// <summary>
    /// source
    /// </summary>
    /// <value>source</value>
    public EmergencyLocationSourceEnum? Source { get; set; }

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
    /// Emergency address
    /// </summary>
    /// <value>Emergency address</value>
    public LocationAddress Address { get; set; }

    /// <summary>
    /// Phone number in E164 format
    /// </summary>
    /// <value>Phone number in E164 format</value>
    public string Did { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
