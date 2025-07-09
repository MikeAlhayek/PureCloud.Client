using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LocaleFlowVersionInfo
{
    /// <summary>
    /// NLU Version Info for this flow version.
    /// </summary>
    /// <value>NLU Version Info for this flow version.</value>
    public AddressableEntityRef NluVersion { get; set; }
}
