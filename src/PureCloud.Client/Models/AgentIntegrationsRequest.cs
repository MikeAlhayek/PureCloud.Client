namespace PureCloud.Client.Models;

/// <summary>
/// AgentIntegrationsRequest
/// </summary>
public sealed class AgentIntegrationsRequest
{
    /// <summary>
    /// The selected integration ID
    /// </summary>
    public string SelectedIntegrationId { get; set; }

    /// <summary>
    /// Associated integrations
    /// </summary>
    public IEnumerable<AgentIntegrationAssociationRequest> AssociatedIntegrations { get; set; }
}