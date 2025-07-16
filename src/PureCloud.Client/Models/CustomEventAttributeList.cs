using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CustomEventAttributeList
{
    /// <summary>
    /// The data type of the custom attributes.
    /// </summary>
    /// <value>The data type of the custom attributes.</value>
    public string DataType { get; set; }

    /// <summary>
    /// The list of custom event attribute values.
    /// </summary>
    /// <value>The list of custom event attribute values.</value>
    public IEnumerable<string> Values { get; set; }
}
