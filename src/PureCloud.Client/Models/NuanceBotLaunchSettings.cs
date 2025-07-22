using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceBotLaunchSettings
{
    /// <summary>
    /// The list of Nuance bots that are configured as available to the Genesys Cloud system
    /// </summary>
    /// <value>The list of Nuance bots that are configured as available to the Genesys Cloud system</value>
    public IEnumerable<BotExecutionConfiguration> BotExecutionConfigurations { get; set; }
}
