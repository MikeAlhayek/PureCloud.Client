using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailSettings
{
    /// <summary>
    /// This setting allows a single inbound email that contains multiple routes configured in Genesys Cloud to create a conversation per route. When this setting is disabled only a single conversation will be created
    /// </summary>
    /// <value>This setting allows a single inbound email that contains multiple routes configured in Genesys Cloud to create a conversation per route. When this setting is disabled only a single conversation will be created</value>
    public bool? MultipleRouteDestinationsOnInboundEmailEnabled { get; set; }
}
