using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AlertRuleProperties
{
    /// <summary>
    /// The type of rule being alerted.
    /// </summary>
    /// <value>The type of rule being alerted.</value>
    public AlertRulePropertiesTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    public string Name { get; set; }
}
