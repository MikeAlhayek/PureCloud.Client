using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebhookInvocationResponse
{
    /// <summary>
    /// The id of the Webhook Invocation
    /// </summary>
    /// <value>The id of the Webhook Invocation</value>
    public string InvocationId { get; set; }
}
