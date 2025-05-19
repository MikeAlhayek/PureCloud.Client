using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusRulesTopicEntityProperties
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public V2MobiusRulesTopicEntityPropertiesEntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public V2MobiusRulesTopicAlertingAddressableEntityRef User { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public V2MobiusRulesTopicAlertingAddressableEntityRef Group { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public V2MobiusRulesTopicAlertingAddressableEntityRef Queue { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public V2MobiusRulesTopicAlertingAddressableEntityRef Team { get; set; }
}
