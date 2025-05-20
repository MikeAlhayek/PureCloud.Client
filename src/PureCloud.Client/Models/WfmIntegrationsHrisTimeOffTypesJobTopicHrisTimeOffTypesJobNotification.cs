using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffType> Entities { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public WfmIntegrationsHrisTimeOffTypesJobTopicErrorBody Error { get; set; }
}
