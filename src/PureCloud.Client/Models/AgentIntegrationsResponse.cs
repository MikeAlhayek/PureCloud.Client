namespace PureCloud.Client.Models;

/// <summary>
/// AgentIntegrationsResponse
/// </summary>
public sealed class AgentIntegrationsResponse
{
    /// <summary>
    /// The agent reference
    /// </summary>
    public UserReference Agent { get; set; }

    /// <summary>
    /// The selected integration reference
    /// </summary>
    public WfmIntegrationReference SelectedIntegration { get; set; }

    /// <summary>
    /// Whether the integration was user selected
    /// </summary>
    public bool? UserSelected { get; set; }

    /// <summary>
    /// Associated integrations
    /// </summary>
    public IEnumerable<AgentIntegrationAssociationResponse> AssociatedIntegrations { get; set; }
}