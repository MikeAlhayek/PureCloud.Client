namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentConfigurationVersionEntityRef
/// </summary>
public sealed class WebDeploymentConfigurationVersionEntityRef
{
    /// <summary>
    /// The configuration version ID
    /// </summary>
    /// <value>The configuration version ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The configuration version name
    /// </summary>
    /// <value>The configuration version name</value>
    public string Name { get; set; }

    /// <summary>
    /// SelfUri
    /// </summary>
    /// <value>SelfUri</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The version of the configuration
    /// </summary>
    /// <value>The version of the configuration</value>
    public string Version { get; set; }
}
