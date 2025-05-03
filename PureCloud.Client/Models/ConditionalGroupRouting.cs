namespace PureCloud.Client.Models;

public sealed class ConditionalGroupRouting
{
    /// <summary>
    /// The set of rules to be executed for each conversation
    /// </summary>
    /// <value>The set of rules to be executed for each conversation</value>
    public IEnumerable<ConditionalGroupRoutingRule> Rules { get; set; }
}
