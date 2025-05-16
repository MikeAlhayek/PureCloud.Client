using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicAlertRuleProperties
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2MobiusAlertsTopicAlertRulePropertiesTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }
}
