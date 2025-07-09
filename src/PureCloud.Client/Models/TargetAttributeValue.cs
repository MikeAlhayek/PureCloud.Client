using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TargetAttributeValue
{
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets PolicyAttributes
    /// </summary>
    public IEnumerable<PolicyAttribute> PolicyAttributes { get; set; }
}
