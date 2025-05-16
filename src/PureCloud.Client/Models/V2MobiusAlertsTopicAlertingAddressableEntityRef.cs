using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicAlertingAddressableEntityRef
{
    /// <summary>
    /// The ID of the resource
    /// </summary>
    /// <value>The ID of the resource</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }
}
