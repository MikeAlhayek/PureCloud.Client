using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBodyStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    public WebDeploymentsDeploymentTopicWebMessagingConfigChangeEventBody Configuration { get; set; }
}
