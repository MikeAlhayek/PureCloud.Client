using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ClientApp
{
    /// <summary>
    /// Configured state of the integration.
    /// </summary>
    /// <value>Configured state of the integration.</value>
    public ClientAppIntendedStateEnum? IntendedState { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the integration, used to distinguish this integration from others of the same type.
    /// </summary>
    /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
    public string Name { get; set; }

    /// <summary>
    /// Type of the integration
    /// </summary>
    /// <value>Type of the integration</value>
    public IntegrationType IntegrationType { get; set; }

    /// <summary>
    /// Notes about the integration.
    /// </summary>
    /// <value>Notes about the integration.</value>
    public string Notes { get; set; }

    /// <summary>
    /// Configuration information for the integration.
    /// </summary>
    /// <value>Configuration information for the integration.</value>
    public ClientAppConfigurationInfo Config { get; set; }

    /// <summary>
    /// Last reported status of the integration.
    /// </summary>
    /// <value>Last reported status of the integration.</value>
    public IntegrationStatusInfo ReportedState { get; set; }

    /// <summary>
    /// Read-only attributes for the integration.
    /// </summary>
    /// <value>Read-only attributes for the integration.</value>
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
