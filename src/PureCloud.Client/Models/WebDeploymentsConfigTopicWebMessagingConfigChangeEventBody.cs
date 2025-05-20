using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebDeploymentsConfigTopicWebMessagingConfigChangeEventBody
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WebDeploymentsConfigTopicWebMessagingConfigChangeEventBodyStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Version
    public string Version { get; set; }
}
