namespace PureCloud.Client.Models;

/// <summary>
/// Details about the active configuration on a deployment
/// </summary>
public sealed class WebDeploymentActiveConfigurationOnDeployment
{
    /// <summary>
    /// The active configuration on a deployment
    /// </summary>
    /// <value>The active configuration on a deployment</value>
    public WebDeploymentConfigurationVersion ConfigurationVersion { get; set; }

    /// <summary>
    /// The web deployment associated with the active configuration
    /// </summary>
    /// <value>The web deployment associated with the active configuration</value>
    public WebDeployment Deployment { get; set; }
}
