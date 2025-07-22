using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ClientAppConfigurationInfo
{
    /// <summary>
    /// The current, active configuration for the integration.
    /// </summary>
    /// <value>The current, active configuration for the integration.</value>
    public IntegrationConfiguration Current { get; set; }

    /// <summary>
    /// The effective configuration for the app, containing the integration specific configuration along with overrides specified in the integration type.
    /// </summary>
    /// <value>The effective configuration for the app, containing the integration specific configuration along with overrides specified in the integration type.</value>
    public EffectiveConfiguration Effective { get; set; }
}
