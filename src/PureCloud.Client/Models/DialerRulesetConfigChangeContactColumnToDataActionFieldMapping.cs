using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerRulesetConfigChangeContactColumnToDataActionFieldMapping
{
    /// <summary>
    /// The name of a contact column whose data will be passed to the data action
    /// </summary>
    /// <value>The name of a contact column whose data will be passed to the data action</value>
    public string ContactColumnName { get; set; }

    /// <summary>
    /// The name of an output field from the data action that the contact column data will be passed to
    /// </summary>
    /// <value>The name of an output field from the data action that the contact column data will be passed to</value>
    public string DataActionField { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
