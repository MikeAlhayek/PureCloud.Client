using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CustomEventAttribute
{
    /// <summary>
    /// The data type of the custom attribute.
    /// </summary>
    /// <value>The data type of the custom attribute.</value>
    public string DataType { get; set; }

    /// <summary>
    /// The value of the custom attribute.
    /// </summary>
    /// <value>The value of the custom attribute.</value>
    public string Value { get; set; }
}
