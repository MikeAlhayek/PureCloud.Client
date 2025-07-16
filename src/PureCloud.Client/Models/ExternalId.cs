using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalId
{
    /// <summary>
    /// Gets or Sets ExternalSource
    /// </summary>
    public ExternalSource ExternalSource { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
