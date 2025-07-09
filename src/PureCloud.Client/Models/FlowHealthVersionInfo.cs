using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowHealthVersionInfo
{
    /// <summary>
    /// Given flow&#39;s Version Info.
    /// </summary>
    /// <value>Given flow&#39;s Version Info.</value>
    public AddressableEntityRef FlowVersion { get; set; }

    /// <summary>
    /// NLU Domain Info for this flow version.
    /// </summary>
    public AddressableEntityRef NluDomain { get; set; }
}
