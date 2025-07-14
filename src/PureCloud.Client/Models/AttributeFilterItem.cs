using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AttributeFilterItem
{
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    public AttributeFilterItemOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    public IEnumerable<string> Values { get; set; }
}
