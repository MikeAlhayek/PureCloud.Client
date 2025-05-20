using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebDeploymentsDeploymentTopicWebMessagingConfigChangeEventBody
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WebDeploymentsDeploymentTopicWebMessagingConfigChangeEventBodyStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }
}
