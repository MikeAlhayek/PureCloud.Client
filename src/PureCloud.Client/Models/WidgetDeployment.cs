namespace PureCloud.Client.Models;

/// <summary>
/// WidgetDeployment
/// </summary>
public sealed class WidgetDeployment
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A human-readable description of this Deployment.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// When true, the customer members starting a chat must be authenticated by supplying their JWT to the create operation.
    /// </summary>
    public bool? AuthenticationRequired { get; set; }

    /// <summary>
    /// When true, all create chat operations using this Deployment will be rejected.
    /// </summary>
    public bool? Disabled { get; set; }

    /// <summary>
    /// The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.
    /// </summary>
    public DomainEntityRef Flow { get; set; }

    /// <summary>
    /// The list of domains that are approved to use this Deployment; the list will be added to CORS headers for ease of web use.
    /// </summary>
    public IEnumerable<string> AllowedDomains { get; set; }

    /// <summary>
    /// The type of display widget for which this Deployment is configured, which controls the administrator settings shown.
    /// </summary>
    public WidgetDeploymentClientType? ClientType { get; set; }

    /// <summary>
    /// The client configuration options that should be made available to the clients of this Deployment.
    /// </summary>
    public WidgetClientConfig ClientConfig { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}