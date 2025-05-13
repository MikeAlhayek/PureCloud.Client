using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerContactlistfilterConfigChangeRange
{
    /// <summary>
    /// Minimum end of the range
    /// </summary>
    /// <value>Minimum end of the range</value>
    public string Min { get; set; }

    /// <summary>
    /// Maximum end of the range
    /// </summary>
    /// <value>Maximum end of the range</value>
    public string Max { get; set; }

    /// <summary>
    /// Whether or not to include the minimum in the range
    /// </summary>
    /// <value>Whether or not to include the minimum in the range</value>
    public bool? MinInclusive { get; set; }

    /// <summary>
    /// Whether or not to include the maximum in the range
    /// </summary>
    /// <value>Whether or not to include the maximum in the range</value>
    public bool? MaxInclusive { get; set; }

    /// <summary>
    /// Elements that apply to the IN operator
    /// </summary>
    /// <value>Elements that apply to the IN operator</value>
    public IEnumerable<string> InSet { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
