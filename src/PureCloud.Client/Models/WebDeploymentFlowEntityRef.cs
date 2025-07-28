namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentFlowEntityRef
/// </summary>
public sealed class WebDeploymentFlowEntityRef
{
    /// <summary>
    /// The Flow ID
    /// </summary>
    /// <value>The Flow ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The Flow name
    /// </summary>
    /// <value>The Flow name</value>
    public string Name { get; set; }

    /// <summary>
    /// SelfUri
    /// </summary>
    /// <value>SelfUri</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The flow description for the webdeployment
    /// </summary>
    /// <value>The flow description for the webdeployment</value>
    public string FlowDescription { get; set; }

    /// <summary>
    /// The published config version for the associated deployment
    /// </summary>
    /// <value>The published config version for the associated deployment</value>
    public FlowVersion PublishVersion { get; set; }
}