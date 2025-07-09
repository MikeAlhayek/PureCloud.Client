using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowHealthIntentVersionInfo
{
    /// <summary>
    /// NLU Version Info for this flow version.
    /// </summary>
    /// <value>NLU Version Info for this flow version.</value>
    public AddressableEntityRef NluVersion { get; set; }

    /// <summary>
    /// Given flow&#39;s Version Info.
    /// </summary>
    /// <value>Given flow&#39;s Version Info.</value>
    public AddressableEntityRef FlowVersion { get; set; }

    /// <summary>
    /// NLU Domain Info for this flow version.
    /// </summary>
    /// <value>NLU Domain Info for this flow version.</value>
    public AddressableEntityRef NluDomain { get; set; }
}
