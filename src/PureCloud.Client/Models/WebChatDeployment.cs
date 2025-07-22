using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatDeployment
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
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationRequired
    /// </summary>
    public bool? AuthenticationRequired { get; set; }

    /// <summary>
    /// URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples
    /// </summary>
    /// <value>URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples</value>
    public string AuthenticationUrl { get; set; }

    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets WebChatConfig
    /// </summary>
    public WebChatConfig WebChatConfig { get; set; }

    /// <summary>
    /// Gets or Sets AllowedDomains
    /// </summary>
    public IEnumerable<string> AllowedDomains { get; set; }

    /// <summary>
    /// The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.
    /// </summary>
    /// <value>The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.</value>
    public DomainEntityRef Flow { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
