using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserApp
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the userApp, used to distinguish this userApp from others of the same type.
    /// </summary>
    /// <value>The name of the userApp, used to distinguish this userApp from others of the same type.</value>
    public string Name { get; set; }

    /// <summary>
    /// Integration Type for the userApp
    /// </summary>
    /// <value>Integration Type for the userApp</value>
    public IntegrationType IntegrationType { get; set; }

    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    public UserAppConfigurationInfo Config { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
