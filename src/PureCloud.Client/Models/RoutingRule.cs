namespace PureCloud.Client.Models;

public sealed class RoutingRule
{
    /// <summary>
    /// matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule's threshold.  ANY matches all specified agents, regardless of score.
    /// </summary>
    /// <value>matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule's threshold.  ANY matches all specified agents, regardless of score.</value>
    public RoutingRuleOperator? Operator { get; set; }

    /// <summary>
    /// threshold required for routing attempt (generally an agent score).  may be null for operator ANY.
    /// </summary>
    /// <value>threshold required for routing attempt (generally an agent score).  may be null for operator ANY.</value>
    public int? Threshold { get; set; }

    /// <summary>
    /// seconds to wait in this rule before moving to the next
    /// </summary>
    /// <value>seconds to wait in this rule before moving to the next</value>
    public double? WaitSeconds { get; set; }
}
