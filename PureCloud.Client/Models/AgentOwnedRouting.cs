namespace PureCloud.Client.Models;

public sealed class AgentOwnedRouting
{
    /// <summary>
    /// Indicates if Agent Owned Callbacks are enabled for the queue
    /// </summary>
    /// <value>Indicates if Agent Owned Callbacks are enabled for the queue</value>
    public bool? EnableAgentOwnedCallbacks { get; set; }

    /// <summary>
    /// The max amount of time a callback can be owned (in hours); Allowable range 1 - 168 hour(s) (inclusive)
    /// </summary>
    /// <value>The max amount of time a callback can be owned (in hours); Allowable range 1 - 168 hour(s) (inclusive)</value>
    public int? MaxOwnedCallbackHours { get; set; }

    /// <summary>
    /// The max amount of time a callback can be scheduled out into the future (in hours); Allowable range 1 - 720 hour(s) (inclusive)
    /// </summary>
    /// <value>The max amount of time a callback can be scheduled out into the future (in hours); Allowable range 1 - 720 hour(s) (inclusive)</value>
    public int? MaxOwnedCallbackDelayHours { get; set; }
}
