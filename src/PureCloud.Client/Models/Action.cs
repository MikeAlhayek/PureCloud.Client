using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Action`
/// </summary>
public sealed class Action
{
    // The globally unique identifier for the object.
    public string Id { get; set; }

    // Name.
    public string Name { get; set; }

    // The ID of the integration for which this action is associated.
    public string IntegrationId { get; set; }

    // Category of Action.
    public string Category { get; set; }

    // Action contract.
    public ActionContract Contract { get; set; }

    // Version of this action.
    public int? Version { get; set; }

    // Indication of whether or not the action is designed to accept sensitive data.
    public bool? Secure { get; set; }

    // Configuration to support request and response processing.
    public ActionConfig Config { get; set; }

    // The URI for this object.
    public string SelfUri { get; set; }
}
