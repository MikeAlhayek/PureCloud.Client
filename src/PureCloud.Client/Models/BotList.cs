using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotList
{
    /// <summary>
    /// A list of botConnector Bots. Max 50
    /// </summary>
    /// <value>A list of botConnector Bots. Max 50</value>
    public IEnumerable<BotConnectorBot> ChatBots { get; set; }
}
