using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentFilterItem
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public ContentFilterItemTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    public ContentFilterItemOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    public IEnumerable<string> Values { get; set; }
}
