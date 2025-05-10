namespace PureCloud.Client.Models;

/// <summary>
/// ScoredAgent
/// </summary>

public sealed class ScoredAgent
{
    /// <summary>
    /// The agent
    /// </summary>
    /// <value>The agent</value>
    public DomainEntityRef Agent { get; set; }

    /// <summary>
    /// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
    /// </summary>
    /// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
    public int? Score { get; set; }
}
