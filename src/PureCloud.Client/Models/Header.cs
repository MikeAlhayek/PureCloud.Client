using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Header
{
    /// <summary>
    /// Name of the header
    /// </summary>
    /// <value>Name of the header</value>
    public string Name { get; set; }

    /// <summary>
    /// Value of the header
    /// </summary>
    /// <value>Value of the header</value>
    public string Value { get; set; }
}
