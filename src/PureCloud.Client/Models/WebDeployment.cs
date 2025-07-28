namespace PureCloud.Client.Models;

/// <summary>
/// Details about a Web Deployment
/// </summary>
public sealed class WebDeployment
{
    /// <summary>
    /// The deployment ID
    /// </summary>
    /// <value>The deployment ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The deployment name
    /// </summary>
    /// <value>The deployment name</value>
    public string Name { get; set; }

    /// <summary>
    /// The description of the config
    /// </summary>
    /// <value>The description of the config</value>
    public string Description { get; set; }

    /// <summary>
    /// Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true.
    /// </summary>
    /// <value>Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true.</value>
    public bool? AllowAllDomains { get; set; }

    /// <summary>
    /// The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use.
    /// </summary>
    /// <value>The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use.</value>
    public IEnumerable<string> AllowedDomains { get; set; }

    /// <summary>
    /// The supported content profile for a deployment
    /// </summary>
    /// <value>The supported content profile for a deployment</value>
    public SupportedContentReference SupportedContent { get; set; }

    /// <summary>
    /// Javascript snippet used to load the config
    /// </summary>
    /// <value>Javascript snippet used to load the config</value>
    public string Snippet { get; set; }

    /// <summary>
    /// The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// A reference to the user who most recently modified the deployment
    /// </summary>
    /// <value>A reference to the user who most recently modified the deployment</value>
    public AddressableEntityRef LastModifiedUser { get; set; }

    /// <summary>
    /// A reference to the inboundshortmessage flow used by this deployment
    /// </summary>
    /// <value>A reference to the inboundshortmessage flow used by this deployment</value>
    public WebDeploymentFlowEntityRef Flow { get; set; }

    /// <summary>
    /// The current status of the deployment
    /// </summary>
    /// <value>The current status of the deployment</value>
    public WebDeploymentStatus? Status { get; set; }

    /// <summary>
    /// The config version this deployment uses
    /// </summary>
    /// <value>The config version this deployment uses</value>
    public WebDeploymentConfigurationVersionEntityRef Configuration { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}