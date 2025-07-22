using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotExecutionConfiguration
{
    /// <summary>
    /// The Nuance bot ID
    /// </summary>
    /// <value>The Nuance bot ID</value>
    public string BotId { get; set; }

    /// <summary>
    /// The hostname to use when contacting Nuance to execute this bot
    /// </summary>
    /// <value>The hostname to use when contacting Nuance to execute this bot</value>
    public string ExecutionHost { get; set; }

    /// <summary>
    /// The bot&#39;s launch credentials
    /// </summary>
    /// <value>The bot&#39;s launch credentials</value>
    public NuanceBotCredentials BotCredentials { get; set; }
}
